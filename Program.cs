using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpYaml.Serialization;

namespace GenerateCSharpErrors
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var (options, exitCode) = CommandLineOptions.Parse(args);

            if (exitCode.HasValue)
            {
                Environment.Exit(exitCode.Value);
                return;
            }

            var errorCodes = await GetErrorCodesAsync(options);
            if (options.CheckLinks)
            {
                await CheckLinksAsync(errorCodes);
            }

            using var writer = GetOutputWriter(options);
            WriteMarkdownTable(errorCodes, writer);
        }

        const string ErrorCodesUrlFormat = "https://raw.githubusercontent.com/dotnet/roslyn/{0}/src/Compilers/CSharp/Portable/Errors/ErrorCode.cs";
        const string ErrorResourcesUrl = "https://raw.githubusercontent.com/dotnet/roslyn/{0}/src/Compilers/CSharp/Portable/CSharpResources.resx";
        const string DocBaseUrl = "https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/";
        const string DocUrlTemplateFallback = "https://docs.microsoft.com/en-us/dotnet/csharp/misc/cs{0:D4}";
        const string DocTableOfContentsUrl = "https://raw.githubusercontent.com/dotnet/docs/main/docs/csharp/language-reference/compiler-messages/toc.yml";

        private static async Task<IReadOnlyList<ErrorCode>> GetErrorCodesAsync(CommandLineOptions options)
        {
            using var client = new HttpClient();
            var enumMembers = await GetErrorCodeEnumMembersAsync(client, options.BranchOrTag);
            var messages = await GetResourceDictionaryAsync(client, options.BranchOrTag);
            var docRelativeUris = options.IncludeLinks ? await GetDocRelativeUrisAsync(client) : null;

            string GetMessage(string name) => messages.TryGetValue(name, out var msg) ? msg : "";

            var docBaseUri = new Uri(DocBaseUrl);
            Uri GetDocLink(int value)
            {
                if (options.IncludeLinks)
                {
                    var link = docRelativeUris.TryGetValue(value, out var relativeUrl)
                        ? new KnownGoodUri(docBaseUri, relativeUrl)
                        : new Uri(string.Format(DocUrlTemplateFallback, value));

                    return link;
                }

                return null;
            }

            var errorCodes = new List<ErrorCode>();
            foreach (var m in enumMembers)
            {
                errorCodes.Add(ErrorCode.Create(m, GetMessage, GetDocLink));
            }

            return errorCodes;
        }

        private async static Task CheckLinksAsync(IReadOnlyList<ErrorCode> errorCodes)
        {
            using var client = new HttpClient();
            using var sem = new SemaphoreSlim(4);
            var logLock = new object();
            int done = 0;
            var tasks = errorCodes.Select(e => Task.Run(async () =>
            {
                await sem.WaitAsync();
                try
                {
                    await CheckLinkAsync(client, e);
                    done++;
                    lock (logLock)
                        Console.Error.WriteLine($"Checked link for {e.Code} ({done}/{errorCodes.Count}, {(double)done/errorCodes.Count:P0})");
                }
                finally
                {
                    sem.Release();
                }
            }));
            await Task.WhenAll(tasks);
        }

        private static async Task CheckLinkAsync(HttpClient client, ErrorCode errorCode)
        {
            if (errorCode.Link is null or KnownGoodUri)
                return;
            using var request = new HttpRequestMessage(HttpMethod.Head, errorCode.Link);
            using var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
                errorCode.Link = null;
        }

        private static async Task<IReadOnlyList<EnumMemberDeclarationSyntax>> GetErrorCodeEnumMembersAsync(HttpClient client, string branchOrTag)
        {
            var url = string.Format(ErrorCodesUrlFormat, branchOrTag);
            string errorCodesFileContent = await client.GetStringAsync(url);
            var syntaxTree = CSharpSyntaxTree.ParseText(errorCodesFileContent);
            var root = syntaxTree.GetRoot();
            var enumDeclaration =
                root.DescendantNodes()
                    .OfType<EnumDeclarationSyntax>()
                    .First(e => e.Identifier.ValueText == "ErrorCode");
            return enumDeclaration.Members;
        }

        private static async Task<IReadOnlyDictionary<string, string>> GetResourceDictionaryAsync(HttpClient client, string branchOrTag)
        {
            var url = string.Format(ErrorResourcesUrl, branchOrTag);
            string resourcesFileContent = await client.GetStringAsync(url);
            var doc = XDocument.Parse(resourcesFileContent);
            var dictionary =
                doc.Root.Elements("data")
                    .ToDictionary(
                        e => e.Attribute("name").Value,
                        e => e.Element("value").Value);
            return dictionary;
        }

        private static async Task<IReadOnlyDictionary<int, string>> GetDocRelativeUrisAsync(HttpClient client)
        {
            string tocContent = await client.GetStringAsync(DocTableOfContentsUrl);
            var serializer = new SharpYaml.Serialization.Serializer();
            var root = serializer.Deserialize<TocRoot>(tocContent);
            var codes = new Dictionary<int, string>();
            foreach (var item in root.Items.SelectMany(n => n.Items ?? Array.Empty<TocNode>()))
            {
                int code = int.Parse(Path.GetFileNameWithoutExtension(item.Name)[2..]);
                var href = item.Href.EndsWith(".md", StringComparison.OrdinalIgnoreCase)
                    ? item.Href[..^3]
                    : item.Href;
                codes.Add(code, href);
            }

            return codes;
        }

        private class TocRoot
        {
            [YamlMember("items")]
            public TocNode[] Items { get; set; }
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

        private class KnownGoodUri : Uri
        {
            public KnownGoodUri(Uri baseUri, string relativeUri) : base(baseUri, relativeUri)
            {
            }
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

        private static void WriteMarkdownTable(IEnumerable<ErrorCode> errorCodes, TextWriter writer)
        {
            writer.WriteLine("# All C# errors and warnings");
            
            writer.WriteLine();
            writer.WriteLine("*Parsed from the [Roslyn source code](https://github.com/dotnet/roslyn) using Roslyn.*");
            writer.WriteLine();
            
            static string Link(ErrorCode e) =>
                e.Link is null
                    ? e.Code
                    : $"[{e.Code}]({e.Link})";

            var stats = new Dictionary<Severity, int>();

            writer.WriteLine("|Code|Severity|Message|");
            writer.WriteLine("|----|--------|-------|");
            foreach (var e in errorCodes)
            {
                if (e.Severity == Severity.Unknown) continue;
                stats[e.Severity] = stats.GetValueOrDefault(e.Severity) + 1;
                writer.WriteLine($"|{Link(e)}|{e.Severity}|{e.Message}|");
            }

            writer.WriteLine();
            writer.WriteLine("## Statistics");
            writer.WriteLine();

            writer.WriteLine("|Severity|Count|");
            writer.WriteLine("|--------|-----|");
            foreach (var kvp in stats.OrderBy(_ => _.Key))
            {
                writer.WriteLine($"|{kvp.Key}|{kvp.Value}|");
            }
            writer.WriteLine($"|**Total**|**{stats.Sum(kvp => kvp.Value)}**|");
        }

        class ErrorCode
        {
            public static ErrorCode Create(
                EnumMemberDeclarationSyntax member,
                Func<string, string> getMessageByName,
                Func<int, Uri> getLinkByValue)
            {
                string name = member.Identifier.ValueText;
                if (name == "Void" || name == "Unknown")
                {
                    return new ErrorCode(name, 0, Severity.Unknown, "", null);
                }
                else
                {
                    int value = int.Parse(member.EqualsValue?.Value?.GetText()?.ToString() ?? "0");
                    return new ErrorCode(
                        name[4..],
                        value,
                        ParseSeverity(name.Substring(0, 3)),
                        getMessageByName(name),
                        getLinkByValue(value));
                }
            }
            
            private ErrorCode(string name, int value, Severity severity, string message, Uri link)
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
            public Uri Link { get; set; }
            
            private static Severity ParseSeverity(string severity)
            {
                return severity switch
                {
                    "HDN" => Severity.Hidden,
                    "INF" => Severity.Info,
                    "WRN" => Severity.Warning,
                    "ERR" => Severity.Error,
                    "FTL" => Severity.Fatal,
                    _ => Severity.Unknown,
                };
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
            public bool CheckLinks { get; set; }
            public string BranchOrTag { get; set; } = "main";

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

            private static readonly IImmutableSet<string> _checkLinksOptions =
                ImmutableHashSet.Create(
                    StringComparer.OrdinalIgnoreCase,
                    "-c", "--check-links");

            private static readonly IImmutableSet<string> _refOptions =
                ImmutableHashSet.Create(
                    StringComparer.OrdinalIgnoreCase,
                    "-r", "--ref");

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
                    else if (_checkLinksOptions.Contains(option))
                    {
                        options.CheckLinks = true;
                    }
                    else if (_refOptions.Contains(option))
                    {
                        if (i + 1 >= args.Length)
                        {
                            ShowUsage($"Missing branch or tag name for {option} option");
                            return (options, 1);
                        }
                        options.BranchOrTag = args[++i];
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
                Console.WriteLine("  -c|--check-links       Check links to documentation and only include them if they're valid");
                Console.WriteLine("  -r|--ref               Specifies Roslyn branch or tag to use (default: main)");
                Console.WriteLine();
            }
        }
    }
}
