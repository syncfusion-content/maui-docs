# Syncfusion .NET CLI

Syncfusion .NET CLI (`sfdotnet`) is a .NET global tool for creating Syncfusion sample projects, managing Syncfusion packages, configuring MCP servers, and installing component skills for AI assistants. It supports .NET MAUI, Blazor, WPF, WinForms, and WinUI project workflows.

## Package details

| Property | Value |
|---|---|
| Product | Syncfusion .NET CLI |
| NuGet package ID | `Syncfusion.DotNet.Cli` |
| Package type | .NET global tool |
| Tool command | `sfdotnet` |

## Prerequisites

- Install the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).
  Check your installation with `dotnet --info`. The CLI runs on .NET 10 even
  when generating a project for an earlier supported framework.
- Install the SDKs, templates, workloads, and native build tools required by
  your chosen platform. MAUI needs the appropriate MAUI workloads and platform
  tools; Apple targets require macOS and Xcode. WPF, Windows Forms, and WinUI
  applications require Windows and the appropriate Windows build tools to
  build and run. Legacy .NET Framework projects need their targeting packs.
- Using Syncfusion components in an application requires an appropriate
  [Syncfusion license](https://www.syncfusion.com/sales/licensing).
  Installing this CLI does not register a component license in your application.

MCP and agent skills have additional prerequisites described below.

## Install

Install the latest stable release:

```bash
dotnet tool install --global Syncfusion.DotNet.Cli
```

To install a prerelease when one is available:

```bash
dotnet tool install --global Syncfusion.DotNet.Cli --prerelease
```

Check the installed version and available commands:

```bash
sfdotnet --version
sfdotnet help
```

Run `sfdotnet` without arguments in an interactive terminal to open the guided menu:

```bash
sfdotnet
```

The menu provides project creation, package management, discovery, help, MCP
setup, and component skills installation. Use the direct commands below for
scripts or repeatable workflows.

If `sfdotnet` is not found after installation, restart your terminal and check that
the .NET global tool directory is on `PATH`: `%USERPROFILE%\.dotnet\tools` on
Windows or `$HOME/.dotnet/tools` on macOS/Linux.

## Update or uninstall the CLI

Update to the latest stable release, or include prereleases:

```bash
dotnet tool update --global Syncfusion.DotNet.Cli
dotnet tool update --global Syncfusion.DotNet.Cli --prerelease
sfdotnet --version
```

Choose the update command appropriate to the release you want. To uninstall:

```bash
dotnet tool uninstall --global Syncfusion.DotNet.Cli
```

These commands manage the CLI tool, not component packages in your applications.
Uninstalling does not remove projects, generated MCP configuration, or agent skills.

## Generated project framework support

Framework options are platform-specific; not every framework below applies to every platform.

| Project platform | Supported target frameworks |
|---|---|
| .NET MAUI | .NET 9 and .NET 10. The selected platform adds its target identifier, such as `-android`, `-ios`, `-maccatalyst`, or `-windows10.0.19041`. The available targets can depend on the installed MAUI templates and workloads. |
| Blazor | `net10.0`, `net9.0`, `net8.0` |
| WPF | `net10.0`, `net9.0`, `net8.0`, `net48`, `net47`, `net462` |
| Windows Forms | `net10.0`, `net9.0`, `net8.0`, `net48`, `net47`, `net462` |
| WinUI | `net10.0`, `net9.0`, `net8.0` |

For example, WPF and Windows Forms support .NET Framework 4.8, 4.7, and 4.6.2. These are generated-project targets; they do not change the CLI's own `net10.0` target. WinUI does not support .NET Framework targets.

## Command reference

The CLI supports MAUI, Blazor, WPF, Windows Forms, and WinUI. Use the platform name as the argument to project and package commands.

### Help and CLI information

```bash
sfdotnet help
sfdotnet help maui
sfdotnet help blazor
sfdotnet help wpf
sfdotnet help winforms
sfdotnet help winui
sfdotnet info
sfdotnet --version
```

`sfdotnet help` shows the general command map. `sfdotnet help <platform>` displays the commands, target frameworks, and options for that platform. `sfdotnet info` reports the CLI version, package ID, tool command, supported platforms, and command groups.

### Create projects

```bash
sfdotnet new maui --name MauiSamples --control datagrid
sfdotnet new blazor --name BlazorSamples --app-type web-app --render-mode server --control grid
sfdotnet new wpf --name WpfSamples --target-framework net48 --control chart datagrid
sfdotnet new winforms --name WinFormsSamples --target-framework net10.0 --control chart
sfdotnet new winui --name WinUiSamples --target-framework net10.0 --control cartesian-chart
```

Use `--target-framework` to select a framework supported by the chosen
platform. Use `--help` on a command for its options. When required values are omitted in an interactive terminal, the CLI can prompt for them.

### Add or update packages

```bash
sfdotnet add maui datagrid
sfdotnet add blazor grid --path ./BlazorSamples
sfdotnet add wpf chart --path ./WpfSamples
sfdotnet update maui datagrid
sfdotnet update winforms chart --path ./WinFormsSamples
```

Use `--path` (or `-p`) to identify an existing project when it is not in the current directory. Package aliases and exact Syncfusion package IDs are accepted; use `--version` to request a specific package version.

### List and search packages

```bash
sfdotnet list maui packages
sfdotnet list maui installed
sfdotnet list blazor packages
sfdotnet list wpf installed --path ./WpfSamples
sfdotnet search maui datagrid
sfdotnet search grid --framework blazor
sfdotnet search chart --framework wpf
```

Use `packages` to browse the selected platform's catalog and `installed` to
inspect packages in a project. Search accepts the platform as a positional
argument (for example, `sfdotnet search maui datagrid`) or through `--framework`.

### Global options

The commands support these global behavior options:

| Option | Purpose |
|---|---|
| `--json` | Write supported command results as JSON. |
| `--verbose` | Include verbose diagnostic output. |
| `--no-color` | Disable colored terminal output. |
| `--interactive` | Enable interactive prompts when the terminal supports them. |
| `--no-interactive` | Do not prompt; report missing required values instead. |

Package removal is currently unavailable. Run `sfdotnet help <platform>` for the
current command syntax and platform-specific options.

## MCP and AI agent skills

Both workflows support `maui`, `blazor`, `wpf`, `winforms`, and `winui`.
They do not add component packages or modify application code.

### Configure an MCP server

Configure an official Syncfusion MCP server for your AI client:

```text
sfdotnet mcp init maui --client vscode --key-file "<absolute-path-to-api-key.txt>"
sfdotnet mcp init blazor --client cursor --path "<workspace-directory>" --key-file "<absolute-path-to-api-key.txt>"
sfdotnet mcp init --help
```

Replace the placeholders before running these commands. Supported `--client`
values are `vscode` (VS Code/GitHub Copilot), `cursor`, `codestudio`, and
`claude-code`. The workspace must exist; `--path` defaults to the current directory.

- Obtain an [MCP API key](https://www.syncfusion.com/account/api-key) and save it
  in an existing `.txt` or `.key` file **outside the workspace**. MCP usage also
  requires an active Syncfusion license. This API key is separate from your
  component license key.
- Pass the file path, not the key itself. Configuration stores only the path;
  never commit the key file.
- Setup writes project-local client configuration. By default, a workspace
  using SDK 10 or later uses `dnx`; SDK 8/9 uses a local .NET tool. The CLI
  itself still requires .NET 10. Downloading the server requires network access.
- Use `--dry-run` to preview without changing files or installing tools.
  An existing conflicting server entry requires `--force` to replace it.

After setup, open or reload the workspace in your client, start the server,
and confirm its tools are listed. Saving configuration alone does **not**
verify connectivity. Then ask a Syncfusion documentation question.

### Install component skills

Skills provide component-specific guidance to your AI assistant.
Install **Node.js 22.20 or later**, including npm, and **Git**. Network access
is required to download the Skills CLI and official skills repositories.
No Syncfusion account, API key, or license is required to install or read skills.

```bash
sfdotnet skills install maui
sfdotnet skills install maui --list
sfdotnet skills install blazor --agent github-copilot --all --yes --no-interactive
sfdotnet skills install --help
```

Interactive installation lets you select skills, agents, and project/global scope.
Supported `--agent` values are `github-copilot`, `cursor`, `codestudio`, and
`claude-code`. Noninteractive installation requires an explicit agent, either
`--skill <exact-skill-name>` or `--all`, and `--yes`. Discover exact names with
`--list`; `--all` selects all skills for the specified agents, not all agents.
Noninteractive scope defaults to the project; add `--global` for user-level skills.
Use `--dry-run` to preview an installation without making changes.

## License

See the included `LICENSE.txt` for license terms.

## Documentation and support

- [Syncfusion product documentation](https://help.syncfusion.com/)
- [Syncfusion support](https://www.syncfusion.com/support)
- [MAUI MCP server guide](https://help.syncfusion.com/maui/ai-coding-assistant/mcp)
- [MAUI component skills guide](https://help.syncfusion.com/maui/ai-coding-assistant/skills/controls-user-skills)
