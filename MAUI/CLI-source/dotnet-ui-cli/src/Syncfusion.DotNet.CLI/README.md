# Syncfusion .NET CLI

Syncfusion .NET CLI (`sf`) is a .NET global tool for creating Syncfusion sample projects and managing Syncfusion packages. It supports .NET MAUI, Blazor, WPF, WinForms, and WinUI project workflows.

## Package details

| Property | Value |
|---|---|
| Product | Syncfusion .NET CLI |
| NuGet package ID | `Syncfusion.DotNet.CLI` |
| Package type | .NET global tool |
| Tool command | `sf` |
| Assembly name | `Syncfusion.DotNet.CLI` |
| CLI target framework | `net10.0` |

## Install

Install the latest stable release:

```bash
dotnet tool install --global Syncfusion.DotNet.CLI
```

To install a prerelease when one is available:

```bash
dotnet tool install --global Syncfusion.DotNet.CLI --prerelease
```

Check the installed version and available commands:

```bash
sf --version
sf help
```

## Generated project framework support

Framework options are platform-specific; not every framework below applies to every platform.

| Project platform | Supported target frameworks |
|---|---|
| .NET MAUI | .NET 9 and .NET 10. The selected platform adds its target identifier, such as `-android`, `-ios`, `-maccatalyst`, or `-windows10.0.19041`. The available targets can depend on the installed MAUI templates and workloads. |
| Blazor | `net10.0`, `net9.0`, `net8.0` |
| WPF | `net10.0`, `net9.0`, `net8.0`, `net4.8`, `net4.7`, `net4.6.2` |
| Windows Forms | `net10.0`, `net9.0`, `net8.0`, `net4.8`, `net4.7`, `net4.6.2` |
| WinUI | `net10.0`, `net9.0`, `net8.0` |

For example, WPF and Windows Forms support .NET Framework 4.8, 4.7, and 4.6.2. These are generated-project targets; they do not change the CLI's own `net10.0` target. WinUI does not support .NET Framework targets.

## Command reference

The CLI supports MAUI, Blazor, WPF, Windows Forms, and WinUI. Use the platform name as the argument to project and package commands.

### Help and CLI information

```bash
sf help
sf help maui
sf help blazor
sf help wpf
sf help winforms
sf help winui
sf info
sf --version
```

`sf help` shows the general command map. `sf help <platform>` displays the commands, target frameworks, and options for that platform. `sf info` reports the CLI version, package ID, tool command, supported platforms, and command groups.

### Create projects

```bash
sf new maui --name MauiSamples --control datagrid
sf new blazor --name BlazorSamples --app-type web-app --render-mode server --control grid
sf new wpf --name WpfSamples --target-framework net48 --control chart datagrid
sf new winforms --name WinFormsSamples --target-framework net10.0 --control chart
sf new winui --name WinUiSamples --target-framework net10.0 --control cartesian-chart
```

Use `--target-framework` to select a framework supported by the chosen
platform. Use `--help` on a command for its options. When required values are omitted in an interactive terminal, the CLI can prompt for them.

### Add or update packages

```bash
sf add maui datagrid
sf add blazor grid --path ./BlazorSamples
sf add wpf chart --path ./WpfSamples
sf update maui datagrid
sf update winforms chart --path ./WinFormsSamples
```

Use `--path` (or `-p`) to identify an existing project when it is not in the current directory. Package aliases and exact Syncfusion package IDs are accepted; use `--version` to request a specific package version.

### List and search packages

```bash
sf list maui packages
sf list maui installed
sf list blazor packages
sf list wpf installed --path ./WpfSamples
sf search maui datagrid
sf search grid --framework blazor
sf search chart --framework wpf
```

Use `packages` to browse the selected platform's catalog and `installed` to
inspect packages in a project. Search accepts the platform as a positional
argument (for example, `sf search maui datagrid`) or through `--framework`.

### Global options

The commands support these global behavior options:

| Option | Purpose |
|---|---|
| `--json` | Write supported command results as JSON. |
| `--verbose` | Include verbose diagnostic output. |
| `--no-color` | Disable colored terminal output. |
| `--interactive` | Enable interactive prompts when the terminal supports them. |
| `--no-interactive` | Do not prompt; report missing required values instead. |

Package removal is currently unavailable. Run `sf help <platform>` for the
current command syntax and platform-specific options.

## Project structure

The package contains the CLI and its platform providers:

- `Syncfusion.DotNet.CLI.Core` — shared contracts and orchestration.
- `Syncfusion.DotNet.CLI.Maui` — MAUI project and package support.
- `Syncfusion.DotNet.CLI.Blazor` — Blazor project and package support.
- `Syncfusion.DotNet.CLI.WPF` — WPF project and package support.
- `Syncfusion.DotNet.CLI.WinForms` — Windows Forms project and package support.
- `Syncfusion.DotNet.CLI.WinUI` — WinUI project and package support.

## License

See the included `LICENSE.txt` for license terms.

## Documentation and support

- [Syncfusion .NET CLI source repository](https://gitea.syncfusion.com/essential-studio/dotnet-ui-cli)
