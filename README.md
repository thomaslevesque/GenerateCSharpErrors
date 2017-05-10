Just a small program to generate the [full list of C# errors and warnings](CSharpErrorsAndWarnings.md). The list is extracted from the [Roslyn repository](https://github.com/dotnet/roslyn) and parsed using Roslyn.

To regenerate the list, just run this script in PowerShell:

```
> .\generate.ps1
```

Or if you don't like Powershell, just run this command:

```
dotnet run > CSharpErrorsAndWarnings.md
```
