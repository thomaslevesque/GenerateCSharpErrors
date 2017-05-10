Just a small program to generate the [full list of C# errors and warnings](CSharpErrorsAndWarnings.md). The list is extracted from the [Roslyn repository](https://github.com/dotnet/roslyn) and parsed using Roslyn.

It targets .NET Core 1.0 and should work on Windows and Linux if you have .NET Core installed.

To regenerate the list, just run the generate script:

- PowerShell:

  ```
  > .\generate.ps1
  ```

- Bash:

  ```
  $ ./generate.sh
  ```
