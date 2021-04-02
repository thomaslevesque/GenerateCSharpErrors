Just a small program to generate the [full list of C# errors and warnings](CSharpErrorsAndWarnings.md). The list is extracted from the [Roslyn repository](https://github.com/dotnet/roslyn) and parsed using Roslyn.

It targets .NET 5.0 and should work on Windows and Linux if you have the .NET 5 SDK installed.

To regenerate the list, just run the generate script:

- PowerShell:

  ```
  > .\generate.ps1
  ```

- Bash:

  ```
  $ ./generate.sh
  ```
