# Internal CLI installation guide

For developers and testers installing `Syncfusion.DotNet.CLI` preview packages.
The installed command is **`sf`**; install, update and uninstall use the
**package ID**, not `sf`.

These instructions manage the CLI tool itself, not Syncfusion component
packages in an application. See the [command reference](docs/command-reference.md)
for application commands.

## Prerequisites

- Install the .NET 10 SDK and confirm `dotnet --version` works.
- Obtain the required `.nupkg`, or build it using the commands below.
- Run global tool commands as your normal user; administrator/root access is
  not required.

The examples use **0.1.0-preview.7**. Change the version for a newer package.
Local previews are not necessarily published on NuGet.org and are not a claim
that all release gates have passed.

## Install globally from a local package

Run from the repository root in PowerShell:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
dotnet tool install --global Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed"
sf --version
sf --help
```

`--add-source` takes the **directory containing the `.nupkg`**, not the package
file. If you received the package separately, set `$feed` to that directory:

```powershell
$feed = "C:\Packages\Syncfusion"
```

For macOS/Linux using a shell, from the repository root:

```bash
feed="$(pwd)/artifacts/packages"
dotnet tool install --global Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed"
sf --version
```

Do not install again if the tool is already installed in the same scope; use
the update command instead.

## Update a global installation

PowerShell, from the repository root:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
dotnet tool update --global Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed"
sf --version
```

macOS/Linux:

```bash
feed="$(pwd)/artifacts/packages"
dotnet tool update --global Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed"
sf --version
```

Use the version of the new package. Prefer a new preview version for each build;
reusing a version can select a cached package. To deliberately return to an
older version, add `--allow-downgrade` to the update command.

## Uninstall a global installation

Same command on Windows, macOS and Linux:

```text
dotnet tool uninstall --global Syncfusion.DotNet.CLI
dotnet tool list --global
```

Uninstalling the CLI does not remove application files, generated MCP
configuration or installed agent skills.

## Test in an isolated tool directory

Use `--tool-path` **instead of** `--global` to leave your global installation
untouched. PowerShell, from the repository root:

```powershell
$feed = (Resolve-Path ".\artifacts\packages").Path
$toolPath = Join-Path ([System.IO.Path]::GetTempPath()) "syncfusion-cli-test"

# Install and invoke this exact installation.
dotnet tool install Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$toolPath"
& (Join-Path $toolPath "sf") --version
& (Join-Path $toolPath "sf") --help

# Update an existing installation in this directory.
dotnet tool update Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$toolPath"

# Uninstall only this isolated copy.
dotnet tool uninstall Syncfusion.DotNet.CLI --tool-path "$toolPath"
```

On macOS/Linux, use an explicit executable path as well:

```bash
feed="$(pwd)/artifacts/packages"
tool_path="${TMPDIR:-/tmp}/syncfusion-cli-test"
dotnet tool install Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$tool_path"
"$tool_path/sf" --version
dotnet tool update Syncfusion.DotNet.CLI --version 0.1.0-preview.7 --add-source "$feed" --tool-path "$tool_path"
dotnet tool uninstall Syncfusion.DotNet.CLI --tool-path "$tool_path"
```

## Pack a new internal preview

From the repository root in PowerShell:

```powershell
$version = "0.1.0-preview.8" # Choose a new, unused preview version.
dotnet pack .\src\Syncfusion.DotNet.CLI\Syncfusion.DotNet.CLI.csproj --configuration Release "-p:Version=$version" "-p:PackageVersion=$version" "-p:InformationalVersion=$version"
```

macOS/Linux:

```bash
version="0.1.0-preview.8"
dotnet pack ./src/Syncfusion.DotNet.CLI/Syncfusion.DotNet.CLI.csproj --configuration Release "-p:Version=$version" "-p:PackageVersion=$version" "-p:InformationalVersion=$version"
```

Output: `artifacts/packages/Syncfusion.DotNet.CLI.<version>.nupkg`.
All three overrides keep the package and `sf --version` aligned without editing
the repository's default version. Packing does **not** publish or install it.

## Troubleshooting

- **`sf` not found:** restart the terminal and check that the global tool
  directory is on `PATH`: `%USERPROFILE%\.dotnet\tools` on Windows or
  `$HOME/.dotnet/tools` on macOS/Linux.
- **Wrong version runs:** check `dotnet tool list --global` and locate the
  executable with `Get-Command sf -All` in PowerShell or `type -a sf` in bash.
  An isolated installation must be invoked by its explicit path.
- **Version not found:** confirm the exact package version exists in the local
  feed directory. The package version is not a Syncfusion component version.
- **Private feed authentication errors:** configured NuGet sources are still
  consulted when using `--add-source`. Use a dedicated NuGet configuration with
  only the local feed and pass `--configfile <path>` if needed. Do not copy
  credentials into this guide or source control.
