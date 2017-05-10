using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenerateCSharpErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            var (options, exitCode) = CommandLineOptions.Parse(args);
            if (exitCode.HasValue)
                Environment.Exit(exitCode.Value);

            var errorCodes = GetErrorCodes();
            Stream stream = null;
            TextWriter writer = Console.Out;
            try
            {
                if (!string.IsNullOrWhiteSpace(options.Output))
                {
                    stream = File.Open(options.Output, FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(stream, Encoding.UTF8);
                }
                WriteMarkdownTable(errorCodes, writer);
            }
            finally
            {
                writer.Flush();
                stream?.Dispose();
            }
        }

        const string ErrorCodesUrl = "https://raw.githubusercontent.com/dotnet/roslyn/master/src/Compilers/CSharp/Portable/Errors/ErrorCode.cs";
        const string ErrorResourcesUrl = "https://raw.githubusercontent.com/dotnet/roslyn/master/src/Compilers/CSharp/Portable/CSharpResources.resx";

        private static IReadOnlyList<ErrorCode> GetErrorCodes()
        {
            using (var client = new HttpClient())
            {
                var enumMembers = GetErrorCodeEnumMembers(client);
                var dictionary = GetResourceDictionary(client);
                
                string GetMessage(string name) => dictionary.TryGetValue(name, out var msg) ? msg : "";

                var errorCodes =
                    enumMembers
                        .Select(m => ErrorCode.Create(m, GetMessage(m.Identifier.ValueText)))
                        .ToList();

                return errorCodes;
            }
        }

        private static IEnumerable<EnumMemberDeclarationSyntax> GetErrorCodeEnumMembers(HttpClient client)
        {
            string errorCodesFileContent = client.GetStringAsync(ErrorCodesUrl).Result;
            var syntaxTree = CSharpSyntaxTree.ParseText(errorCodesFileContent);
            var root = syntaxTree.GetRoot();
            var enumDeclaration =
                root.DescendantNodes()
                    .OfType<EnumDeclarationSyntax>()
                    .First(e => e.Identifier.ValueText == "ErrorCode");
            return enumDeclaration.Members;
        }

        private static IReadOnlyDictionary<string, string> GetResourceDictionary(HttpClient client)
        {
            string resourcesFileContent = client.GetStringAsync(ErrorResourcesUrl).Result;
            var doc = XDocument.Parse(resourcesFileContent);
            var dictionary =
                doc.Root.Elements("data")
                    .ToDictionary(
                        e => e.Attribute("name").Value,
                        e => e.Element("value").Value);
            return dictionary;
        }

        private static void WriteMarkdownTable(IReadOnlyList<ErrorCode> errorCodes, TextWriter writer)
        {
            writer.WriteLine("# All C# errors and warnings");
            
            writer.WriteLine();
            writer.WriteLine("*Parsed from the [Roslyn source code](https://github.com/dotnet/roslyn) using Roslyn.*");
            writer.WriteLine();
            
            writer.WriteLine("|Code|Severity|Message|");
            writer.WriteLine("|----|--------|-------|");
            foreach (var e in errorCodes)
            {
                if (e.Severity== Severity.Unknown) continue;
                writer.WriteLine($"|{e.Code}|{e.Severity}|{e.Message}|");
            }

            writer.WriteLine();
            writer.WriteLine("## Statistics");
            writer.WriteLine();

            var lookup = errorCodes.OrderByDescending(e => e.Severity).ToLookup(e => e.Severity);
            writer.WriteLine("|Severity|Count|");
            writer.WriteLine("|--------|-----|");
            foreach (var g in lookup)
            {
                if (g.Key == Severity.Unknown) continue;
                writer.WriteLine($"|{g.Key}|{g.Count()}|");
            }
            writer.WriteLine($"|**Total**|**{errorCodes.Count}**|");
        }

        class ErrorCode
        {
            public static ErrorCode Create(EnumMemberDeclarationSyntax member, string message)
            {
                string name = member.Identifier.ValueText;
                if (name == "Void" || name == "Unknown")
                {
                    return new ErrorCode(name, 0, Severity.Unknown, message);
                }
                else
                {
                    return new ErrorCode(
                        name.Substring(4),
                        int.Parse(member.EqualsValue?.Value?.GetText()?.ToString() ?? "0"),
                        ParseSeverity(name.Substring(0, 3)),
                        message);
                }
            }
            
            private ErrorCode(string name, int value, Severity severity, string message)
            {
                Name = name;
                Value = value;
                Severity = severity;
                Message = message;
            }
            
            public string Name { get; }
            public int Value { get; }
            public string Code => $"CS{Value:D4}";
            public Severity Severity { get; }
            public string Message { get; }
            
            private static Severity ParseSeverity(string severity)
            {
                switch (severity)
                {
                    case "HDN":
                        return Severity.Hidden;
                    case "INF":
                        return Severity.Info;
                    case "WRN":
                        return Severity.Warning;
                    case "ERR":
                        return Severity.Error;
                    case "FTL":
                        return Severity.Fatal;
                    default:
                        return Severity.Unknown;
                }
            }
        }

        enum Severity
        {
            Unknown,
            Hidden,
            Info,
            Warning,
            Error,
            Fatal
        }

        class CommandLineOptions
        {
            public string Output { get; set; }

            private static readonly string[] _helpOptions =
            {
                "-h",
                "-?",
                "--help"
            };

            private static readonly string[] _outputOptions =
            {
                "-o",
                "--output"
            };

            public static (CommandLineOptions options, int? exitCode) Parse(string[] args)
            {
                var options = new CommandLineOptions();

                for (int i = 0; i < args.Length; i++)
                {
                    if (_helpOptions.Contains(args[i]))
                    {
                        ShowUsage();
                        return (options, 0);
                    }
                    else if (_outputOptions.Contains(args[i]))
                    {
                        if (i + 1 >= args.Length)
                        {
                            ShowUsage($"Missing filename for {args[i]} option");
                            return (options, 1);
                        }
                        options.Output = args[++i];
                    }
                    else
                    {
                        ShowUsage($"Unknown option: {args[i]}");
                        return (options, 1);
                    }
                }
                
                return (options, null);
            }

            private static void ShowUsage(string error = null)
            {
                if (!string.IsNullOrEmpty(error))
                {
                    var normalColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error);
                    Console.ForegroundColor = normalColor;
                    Console.WriteLine();
                }

                Console.WriteLine("C# errors and warnings list generator");
                Console.WriteLine();
                Console.WriteLine("Usage: GenerateCSharpErrors.exe [options]");
                Console.WriteLine();
                Console.WriteLine("Options:");
                Console.WriteLine("  -h|--help              Show this help message");
                Console.WriteLine("  -o|--output <file>     Output to the specified file (default: output to the console)");
                Console.WriteLine();
            }
        }
    }
}
