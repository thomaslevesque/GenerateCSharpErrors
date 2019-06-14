using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpYaml.Serialization;

namespace GenerateCSharpErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            var (options, exitCode) = CommandLineOptions.Parse(args);

            if (exitCode.HasValue)
            {
                Environment.Exit(exitCode.Value);
                return;
            }

            var errorCodes = GetErrorCodes(options);
            
            using (var writer = GetOutputWriter(options))
            {
                WriteMarkdownTable(errorCodes, writer);
            }
        }

        const string ErrorCodesUrl = "https://raw.githubusercontent.com/dotnet/roslyn/master/src/Compilers/CSharp/Portable/Errors/ErrorCode.cs";
        const string ErrorResourcesUrl = "https://raw.githubusercontent.com/dotnet/roslyn/master/src/Compilers/CSharp/Portable/CSharpResources.resx";
        const string DocUrlTemplate = "https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/compiler-messages/cs{0:D4}";
        const string DocTableOfContentsUrl = "https://raw.githubusercontent.com/dotnet/docs/master/docs/csharp/language-reference/compiler-messages/toc.yml";

        private static IReadOnlyList<ErrorCode> GetErrorCodes(CommandLineOptions options)
        {
            using (var client = new HttpClient())
            {
                var enumMembers = GetErrorCodeEnumMembers(client);
                var messages = GetResourceDictionary(client);
                var documentedCodes = options.IncludeLinks ? GetDocumentedCodes(client) : null;
                
                string GetMessage(string name) => messages.TryGetValue(name, out var msg) ? msg : "";
                string GetDocLink(int value) => options.IncludeLinks && documentedCodes.Contains(value)
                    ? string.Format(DocUrlTemplate, value)
                    : "";

                var errorCodes =
                    enumMembers
                        .Select(m => ErrorCode.Create(m, GetMessage, GetDocLink))
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

        private static ISet<int> GetDocumentedCodes(HttpClient client)
        {
            string tocContent = client.GetStringAsync(DocTableOfContentsUrl).Result;
            var serializer = new SharpYaml.Serialization.Serializer();
            var toc = serializer.Deserialize<TocNode[]>(tocContent);
            var codes = toc.SelectMany(n => n.Items)
                .Select(n => int.Parse(Path.GetFileNameWithoutExtension(n.Href).Substring(2)));
            return new HashSet<int>(codes);
        }

        private class TocNode
        {
            [YamlMember("name")]
            public string Name { get; set; }
            [YamlMember("href")]
            public string Href { get; set; }
            [YamlMember("items")]
            public TocNode[] Items { get; set; }
        }

        private static TextWriter GetOutputWriter(CommandLineOptions options)
        {
            if (string.IsNullOrWhiteSpace(options.Output))
            {
                return Console.Out;
            }
            else
            {
                var stream = File.Open(options.Output, FileMode.Create, FileAccess.Write);
                return new StreamWriter(stream, Encoding.UTF8);
            }
        }

        private static void WriteMarkdownTable(IReadOnlyList<ErrorCode> errorCodes, TextWriter writer)
        {
            writer.WriteLine("# All C# errors and warnings");
            
            writer.WriteLine();
            writer.WriteLine("*Parsed from the [Roslyn source code](https://github.com/dotnet/roslyn) using Roslyn.*");
            writer.WriteLine();
            
            string Link(ErrorCode e) =>
                string.IsNullOrEmpty(e.Link)
                    ? e.Code
                    : $"[{e.Code}]({e.Link})";

            writer.WriteLine("|Code|Severity|Message|");
            writer.WriteLine("|----|--------|-------|");
            foreach (var e in errorCodes)
            {
                if (e.Severity== Severity.Unknown) continue;
                writer.WriteLine($"|{Link(e)}|{e.Severity}|{e.Message}|");
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
            public static ErrorCode Create(
                EnumMemberDeclarationSyntax member,
                Func<string, string> getMessageByName,
                Func<int, string> getLinkByValue)
            {
                string name = member.Identifier.ValueText;
                if (name == "Void" || name == "Unknown")
                {
                    return new ErrorCode(name, 0, Severity.Unknown, "", "");
                }
                else
                {
                    int value = int.Parse(member.EqualsValue?.Value?.GetText()?.ToString() ?? "0");
                    return new ErrorCode(
                        name.Substring(4),
                        value,
                        ParseSeverity(name.Substring(0, 3)),
                        getMessageByName(name),
                        getLinkByValue(value));
                }
            }
            
            private ErrorCode(string name, int value, Severity severity, string message, string link)
            {
                Name = name;
                Value = value;
                Severity = severity;
                Message = message;
                Link = link;
            }
            
            public string Name { get; }
            public int Value { get; }
            public string Code => $"CS{Value:D4}";
            public Severity Severity { get; }
            public string Message { get; }
            public string Link { get; }
            
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
            public bool IncludeLinks { get; set; }

            private static readonly IImmutableSet<string> _helpOptions =
                ImmutableHashSet.Create(
                    StringComparer.OrdinalIgnoreCase,
                    "-h", "-?", "--help");
            private static readonly IImmutableSet<string> _outputOptions =
                ImmutableHashSet.Create(
                    StringComparer.OrdinalIgnoreCase,
                    "-o", "--output");
            private static readonly IImmutableSet<string> _linksOptions =
                ImmutableHashSet.Create(
                    StringComparer.OrdinalIgnoreCase,
                    "-l", "--link");
            public static (CommandLineOptions options, int? exitCode) Parse(string[] args)
            {
                var options = new CommandLineOptions();

                for (int i = 0; i < args.Length; i++)
                {
                    var option = args[i];

                    if (_helpOptions.Contains(option))
                    {
                        ShowUsage();
                        return (options, 0);
                    }
                    else if (_outputOptions.Contains(option))
                    {
                        if (i + 1 >= args.Length)
                        {
                            ShowUsage($"Missing filename for {option} option");
                            return (options, 1);
                        }
                        options.Output = args[++i];
                    }
                    else if (_linksOptions.Contains(option))
                    {
                        options.IncludeLinks = true;
                    }
                    else
                    {
                        ShowUsage($"Unknown option: {option}");
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
                Console.WriteLine("  -l|--link              Include links to documentation when they exist");
                Console.WriteLine();
            }
        }
    }
}
