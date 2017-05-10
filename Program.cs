using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenerateCSharpErrors
{
    class Program
    {
        static void Main()
        {
            var errorCodes = GetErrorCodes();
            WriteMarkdownTable(errorCodes, Console.Out);
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
            
            writer.WriteLine("|Code|Level|Message|");
            writer.WriteLine("|----|-----|-------|");
            foreach (var e in errorCodes)
            {
                if (e.Level== DiagnosticLevel.Unknown) continue;
                writer.WriteLine($"|{e.Code}|{e.Level}|{e.Message}|");
            }

            writer.WriteLine();
            writer.WriteLine("## Statistics");
            writer.WriteLine();

            var lookup = errorCodes.OrderByDescending(e => e.Level).ToLookup(e => e.Level);
            writer.WriteLine("|Level|Count|");
            writer.WriteLine("|-----|-----|");
            foreach (var g in lookup)
            {
                if (g.Key == DiagnosticLevel.Unknown) continue;
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
                    return new ErrorCode(name, 0, DiagnosticLevel.Unknown, message);
                }
                else
                {
                    return new ErrorCode(
                        name.Substring(4),
                        int.Parse(member.EqualsValue?.Value?.GetText()?.ToString() ?? "0"),
                        ParseLevel(name.Substring(0, 3)),
                        message);
                }
            }
            
            private ErrorCode(string name, int value, DiagnosticLevel level, string message)
            {
                Name = name;
                Value = value;
                Level = level;
                Message = message;
            }
            
            public string Name { get; }
            public int Value { get; }
            public string Code => $"CS{Value:D4}";
            public DiagnosticLevel Level { get; }
            public string Message { get; }
            
            private static DiagnosticLevel ParseLevel(string level)
            {
                switch (level)
                {
                    case "HDN":
                        return DiagnosticLevel.Hidden;
                    case "INF":
                        return DiagnosticLevel.Info;
                    case "WRN":
                        return DiagnosticLevel.Warning;
                    case "ERR":
                        return DiagnosticLevel.Error;
                    case "FTL":
                        return DiagnosticLevel.Fatal;
                    default:
                        return DiagnosticLevel.Unknown;
                }
            }
        }

        enum DiagnosticLevel
        {
            Unknown,
            Hidden,
            Info,
            Warning,
            Error,
            Fatal
        }
    }
}
