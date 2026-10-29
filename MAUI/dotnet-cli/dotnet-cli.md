---
layout: post
title: Syncfusion .NET CLI Overview for .NET MAUI | Syncfusion®
description: Learn to install and use the Syncfusion® .NET CLI (sf) to create .NET MAUI apps, manage Syncfusion MAUI packages, and register licenses.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Overview of the Syncfusion<sup>®</sup> .NET CLI

The Syncfusion<sup>®</sup> .NET CLI (`sf`) is a cross-platform command line tool that creates .NET MAUI projects, manages Syncfusion<sup>®</sup> .NET MAUI NuGet packages, and registers licenses from a terminal. After you install the CLI, you can run `sf` with no arguments to open an interactive menu, or run a direct command such as `sf new maui` for scripted, prompt-free creation.

N> The Syncfusion<sup>®</sup> .NET CLI is currently in preview and is installed with the `--prerelease` flag.

You can use the CLI to perform the following actions:

* Create a blank .NET MAUI app, or an app containing generated Syncfusion<sup>®</sup> control samples.
* Add or update Syncfusion<sup>®</sup> .NET MAUI NuGet package references in an existing project.
* List available and installed packages, and search the package catalog.
* Activate Syncfusion<sup>®</sup> licenses for the controls used in a sample, and view installed licenses.
* Configure an official Syncfusion<sup>®</sup> Model Context Protocol (MCP) server for AI coding clients.
* Install official Syncfusion<sup>®</sup> component skills for AI agents.
* Generate projects for .NET MAUI, Blazor, WPF, WinForms, and WinUI 3.

This documentation covers the .NET MAUI platform.

## Prerequisites

The following software is required before you install and use the CLI:

* [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0). The SDK selected through `PATH` takes precedence, with the running .NET installation as a fallback.
* The **.NET Multi-platform App UI development** workload.
* The .NET MAUI project templates, which are installed with the MAUI workload. The CLI creates .NET MAUI projects through the installed `maui` template.
* An internet connection so package operations can reach [nuget.org](https://www.nuget.org).
* A Syncfusion<sup>®</sup> account to activate licenses. Sign in is performed through the browser during license activation.

N> Syncfusion<sup>®</sup> packages resolve from the official nuget.org feed, `https://api.nuget.org/v3/index.json`. The CLI accepts only this source through `--source`.

## Installation

The CLI is published as a .NET global tool with the package ID `Syncfusion.DotNet.CLI`.

1. Open a terminal and run the following command. Add `--prerelease` while only preview versions are available.

    ```bash
    dotnet tool install -g Syncfusion.DotNet.CLI --prerelease
    ```

2. Verify the installation and print the CLI version.

    ```bash
    sf --version
    ```

To update the tool to the latest release, run:

```bash
dotnet tool update -g Syncfusion.DotNet.CLI --prerelease
```

To remove the tool, run:

```bash
dotnet tool uninstall -g Syncfusion.DotNet.CLI
```

## Initialize the CLI

Run `sf` in an interactive terminal to open the main menu. The menu shows the current CLI version and groups the available operations.

![Syncfusion .NET CLI main menu](images/cli-main-menu.png)

| Group | Operation | Command reference |
| --- | --- | --- |
| Project creation | Create a new project | `sf new` |
| Package management | Add a package to an existing project | `sf add` |
| Package management | Update a package in an existing project | `sf update` |
| Discovery | List available packages | `sf list <platform> packages` |
| Discovery | List installed packages in an existing project | `sf list <platform> installed` |
| Discovery | Search for packages | `sf search` |
| AI & Skills | Setup Model Context Protocol (MCP) | `sf mcp init` |
| AI & Skills | Add component skills to AI Agent | `sf skills install` |
| License management | Activate license | `sf license activate` |
| License management | View installed licenses | `sf license view` |
| License management | Sign in to Syncfusion | `sf login` |
| License management | Sign out | `sf logout` |
| Help and information | View CLI information | `sf info` |
| Help and information | Show help | `sf help` |
| Exit | Exit | `Ctrl+C` |

N> The `<platform>` text is a usage placeholder. Use `maui` for .NET MAUI.

Use the following keys to navigate the interactive screens:

| Key | Action |
| --- | --- |
| Up / Down | Move through the options |
| Enter | Choose the focused option, or continue |
| Space | Toggle a checkbox in a multi-selection list |
| Escape | Cancel the current question and return to the menu |
| `Ctrl+C` | Exit the interactive session |

Complete direct commands remain usable without opening the menu. `--no-interactive` disables prompts in any command.

## Available commands

| Command | Purpose |
| --- | --- |
| `sf new maui` | Create a new .NET MAUI project |
| `sf add maui <package>` | Add a Syncfusion<sup>®</sup> package to an existing project |
| `sf update maui <package>` | Update a package in an existing project |
| `sf list maui packages` | List available packages |
| `sf list maui installed` | List installed packages in an existing project |
| `sf search maui <text>` | Search packages |
| `sf mcp init maui` | Configure a project-local Syncfusion<sup>®</sup> MCP client |
| `sf skills install maui` | Install Syncfusion<sup>®</sup> component skills for AI agents |
| `sf login` | Sign in to Syncfusion through the browser |
| `sf logout` | Sign out and clear the local session |
| `sf license activate` | Download the license for the project's packages and register it in the project's startup code |
| `sf license view` | Show the licenses cached for the project (no network call) |
| `sf info` | Show CLI information |
| `sf help maui` | Show the .NET MAUI command map |
| `sf --version` | Show the CLI version |

## Create a .NET MAUI project

You can create a .NET MAUI project through the interactive wizard or a direct command.

### Create a project using the interactive wizard

Run `sf new`, or select **Create a new project** from the main menu. The .NET MAUI creation flow is:

1. **Platform:** Select **.NET MAUI**.

    ![Framework selection in the Syncfusion .NET CLI](images/cli-framework-selection.png)

2. **Project template:** The **.NET MAUI App** template is the only enabled project type and is recorded automatically. Blazor Hybrid creation is temporarily disabled.
3. **Framework:** Select the .NET version.

    * .NET 10 (`net10.0`), the default
    * .NET 9 (`net9.0`)

4. **Location and name:** Enter the parent directory and the project name. The default locations are `%USERPROFILE%\source\repos` on Windows and `~/Projects` on Linux and macOS. The suggested name is `SyncfusionMauiApp`, and the first available numeric suffix is used when the destination name collides.

    ![Project location and name in the Syncfusion .NET CLI](images/cli-project-location-and-name.png)

5. **Setup:** Select **Blank app** or **Include Syncfusion controls**. Blank app is the first option.

    ![Select a blank app or a Syncfusion controls project in the Syncfusion .NET CLI](images/cli-setup-selection.png)

6. **Controls:** When you include controls, choose one or more controls from the list. Controls start unchecked, and at least one selection is required.

7. **Post-create:** Select **Generate only** or **Build project**.

8. **Confirmation:** Review the selected values and confirm to create the project.

N> A complete direct command does not open the wizard. When a name is missing in an interactive terminal, the wizard supplies a default and collects the remaining unspecified inputs. Missing required values in scripts produce an error.

### Available controls

The following controls are available in a new .NET MAUI project:

| Control | Control ID |
| --- | --- |
| AI AssistView | `assistview` |
| Cartesian Chart | `cartesian-chart` |
| Circular Chart | `circular-chart` |
| DataGrid | `datagrid` |
| Diagram | `diagram` |
| Kanban | `kanban` |
| ListView | `listview` |
| PDF Viewer | `pdf-viewer` |
| Rich Text Editor | `rich-text-editor` |
| Scheduler | `scheduler` |

### Create a project using direct commands

To create a blank project without the wizard:

```bash
sf new maui -n MyApp
```

To create a project containing Syncfusion<sup>®</sup> control samples:

```bash
sf new maui -n MyApp --control datagrid
sf new maui -n MyApp --control datagrid listview
sf new maui -n MyApp --control cartesian-chart circular-chart
```

## Platform and .NET version selection

The CLI supports the `maui`, `blazor`, `wpf`, `winforms`, and `winui` platforms. In a direct command, the platform is the positional argument or the `--framework/-f` option. Actions that need a platform ask for the platform first. Information (`sf info`) and general help (`sf help`) do not ask for a platform.

The framework step selects the base .NET version. It does not select Android, iOS, Windows, or Mac Catalyst individually.

```bash
sf new maui -n MyApp --target-framework net9.0
```

A .NET MAUI project declares multiple platform targets, such as `net10.0-android` and `net10.0-windows`. By default, builds run `dotnet build` for all configured targets. Use `--build-framework` to build one enabled target:

```bash
sf new maui -n MyApp --build-framework net10.0-android --post-action build
```

`--build-framework` is validated against MSBuild's evaluated targets, and an unknown target is rejected.

## Run the created project

A generated .NET MAUI project declares multiple platform targets, such as `net10.0-android` and `net10.0-windows`. Run the project with the target framework for your platform:

```bash
dotnet run --project ./MyApp/MyApp.csproj -f net10.0-windows
```

Native platform requirements still apply. Windows apps run on Windows, Mac Catalyst apps on macOS, and Android and iOS apps on an emulator or a connected device.

## Manage packages in an existing project

Package operations change NuGet references only. They do not generate control files.

`<package>` accepts a canonical package alias, a canonical package ID, or an exact unambiguous package display name:

```bash
sf add maui datagrid
sf add maui Syncfusion.Maui.DataGrid
```

In a CLI-generated project, supported package aliases also integrate their samples. For example, `sf add maui datagrid` adds the DataGrid package and integrates the DataGrid sample. In an ordinary project, the same command adds the package reference only, and the CLI reports that no sample was generated.

To add generated samples directly, use `--control`:

```bash
sf add maui --control datagrid listview --path ./MyApp
```

To list the available and installed packages:

```bash
sf list maui packages
sf list maui installed --path ./MyApp
```

![List of available packages in the Syncfusion .NET CLI](images/cli-list-of-available-packages.png)

To search the package catalog:

```bash
sf search maui grid
```

Existing-project commands accept `-p/--path` with a project file, a project directory, or a supported subdirectory. Discovery stops at the nearest project or repository boundary. `--json` emits one JSON document for script use.

## Activate Syncfusion<sup>®</sup> licenses

The CLI detects the Syncfusion<sup>®</sup> controls used in a project, downloads the matching license keys from your Syncfusion<sup>®</sup> account, and registers the keys in the project's startup code. For example, when a sample is created with the Cartesian Chart control, the CLI registers the license for `Syncfusion.Maui.Charts` in `MauiProgram.cs` so the build runs without a license warning.

N> Open the Command Prompt or Terminal in the target sample's project directory before running the license activation command. The license operation is project-specific, and the command path must point to the intended sample.

### How license activation works

1. The CLI scans the project at the current directory or at the path you pass through `--path`. It identifies the platform from the project file (`.csproj`) and detects all Syncfusion<sup>®</sup> `PackageReference` entries whose IDs start with `Syncfusion.`.
2. It checks your Syncfusion<sup>®</sup> account for entitlements that cover each detected package. When a paid or trial entitlement is available, the matching license keys are downloaded.
3. The keys are cached in `syncfusion-license.txt` and metadata in `.syncfusion/license-meta.json` inside the project directory.
4. The CLI inserts `SyncfusionLicenseProvider.RegisterLicense(...)` into the platform-specific startup file. For .NET MAUI, the block is added to `MauiProgram.cs` before `MauiApp.CreateBuilder()`. The block is idempotent, so re-running the command refreshes the keys without duplicating the call.
5. If a control in the project is not covered by a paid entitlement, the CLI prompts you to accept the Syncfusion<sup>®</sup> trial EULA and download a trial key for the missing packages. Pass `--yes` to accept the prompt automatically.

### Activate a license through the interactive menu

1. Open the Command Prompt or Terminal in the target sample's project directory.

    ```bash
    cd D:\CLI\NetMauiSample
    ```

2. Run `sf` to open the main menu.

    ```bash
    sf
    ```

3. Under **License management**, select **Activate license**. The CLI focuses the **Activate License** entry and shows the navigation hint at the bottom of the screen.

    ![Activate license option in the Syncfusion .NET CLI](images/cli-activate-license.png)

4. If you are not signed in, the CLI opens your default browser to the Syncfusion<sup>®</sup> sign-in page. Complete sign in with your Syncfusion<sup>®</sup> account.

    ![Syncfusion sign-in page in the browser](images/cli-license-sign-in.png)

5. After sign in, the CLI checks your entitlements, downloads the matching keys for the Syncfusion<sup>®</sup> controls in the sample, and registers the keys in `MauiProgram.cs`.

    ![License registered successfully in the Syncfusion .NET CLI](images/cli-license-registered.png)

6. Rebuild the application so the newly registered license is applied. The CLI prints the following reminder at the end of the activation output.

    > Note: Rebuild the application so the newly registered license is applied.

### Activate a license using a direct command

Run the activation command from the sample's project directory:

```bash
sf license activate
```

Pass `--path` to point the CLI at a specific project directory or `.csproj` file:

```bash
sf license activate --path ./MyApp
sf license activate --path ./MyApp/MyApp.csproj
```

Use `--yes` to accept the trial EULA prompt without asking:

```bash
sf license activate --yes
```

Use `--file` to activate from an existing key file. With no value, the CLI reads `./syncfusion-license.txt` from the project directory. With an absolute path, the CLI uses the specified file instead:

```bash
sf license activate --file
sf license activate --file C:\keys\syncfusion-license.txt
```

N> When a license key is supplied through `--file`, the CLI skips sign in and download and registers the keys already in the file. The file path must be absolute.

### View installed licenses

To see the licenses cached for the current project, run:

```bash
sf license view
```

The command reads the cached metadata, lists each product, the license type, the status, and the expiry date, and warns when a Syncfusion<sup>®</sup> package in the project is not covered.

![View installed licenses in the Syncfusion .NET CLI](images/cli-view-installed-license-menu.png)

The cached output reports the registered email, platform, major version, and one row per product.

![Installed license details in the Syncfusion .NET CLI](images/cli-view-installed-license.png)

### License operation notes

* License activation is project-specific. The command path must point to the intended sample, because each project is detected through its `.csproj` and scanned independently.
* The CLI writes `syncfusion-license.txt` and `.syncfusion/license-meta.json` to the project directory.
* The startup file the CLI modifies by platform is `MauiProgram.cs` for .NET MAUI, `Program.cs` for Blazor, `App.xaml.cs` for WPF, `App.xaml.cs` for WinUI, and `Program.cs` (or `Application.xaml.vb` for VB) for WinForms.
* Use `sf logout` to clear the local sign-in session. Use `sf login` to sign in again without running activation.

## Configure an MCP server

The `sf mcp init` command configures the official Syncfusion<sup>®</sup> .NET MAUI MCP server (`Syncfusion.Maui.MCP`) for an AI coding client in a project-local workspace. The MCP server exposes Syncfusion<sup>®</sup> documentation and product knowledge to AI agents, such as GitHub Copilot, Cursor, and Claude Code.

The MCP setup workflow does not install component libraries and does not modify application code. It only writes the client's project-local MCP configuration file and, when needed, installs the official MCP NuGet tool.

### Prerequisites

* The .NET SDK 8 or later must be selected in the target workspace. The `--runner dnx` mode requires .NET SDK 10 or later.
* A Syncfusion<sup>®</sup> MCP API key, generated at [https://www.syncfusion.com/account/api-key](https://www.syncfusion.com/account/api-key).
* An active Syncfusion<sup>®</sup> license for MCP usage.

N> The MCP API key is separate from your product license key and from the `sf login` session. It is used only by the MCP server.

### Configure MCP through the interactive menu

1. Run `sf` to open the main menu, and under **AI & Skills**, select **Setup Model Context Protocol (MCP)**.

    ![AI and Skills section in the Syncfusion .NET CLI main menu](images/cli-setup-mcp-command-menu.png)

2. Select the platform. Choose **.NET MAUI**.

    ![Platform selection in the MCP setup flow of the Syncfusion .NET CLI](images/cli-select-platform-mcp.png)

3. Enter the workspace directory. The default is the current directory. The workspace directory must already exist.

4. Select the MCP client: **VS Code / GitHub Copilot**, **Cursor**, **Syncfusion Code Studio**, or **Claude Code**.

5. Enter the API-key file path. The CLI prints the API-key download location, and the file must exist before setup. It must remain outside the workspace directory.

    ![MCP configuration saved successfully in the Syncfusion .NET CLI](images/cli-configured-mcp.png)

6. Open or reload the workspace in the selected client, start the server, and confirm that its tools are listed. Then ask a Syncfusion documentation question to verify the integration.

N> Saving the configuration does not verify the connection to the MCP server. The CLI does not start the server or contact it during setup.

### Configure MCP using direct commands

```bash
sf mcp init maui --client vscode --key-file "C:\Users\me\.syncfusion\api-key.txt"
sf mcp init maui --client cursor --path "C:\Projects\MyApp" --key-file "C:\Keys\syncfusion.key"
sf mcp init maui --client codestudio --key-file "C:\Keys\syncfusion.key" --dry-run
sf mcp init maui --client claude-code --key-file "C:\Keys\syncfusion.key" --no-interactive --json
```

In a direct command, the platform is the positional argument. `--path` defaults to the current directory. In noninteractive or `--json` usage, the platform, client, and key file must be provided explicitly.

### MCP configuration file location

The CLI writes a project-local configuration file inside the workspace, next to the client's expected location:

| Client | Configuration file | Server property |
| --- | --- | --- |
| VS Code / GitHub Copilot | `.vscode/mcp.json` | `servers` |
| Cursor | `.cursor/mcp.json` | `mcpServers` |
| Syncfusion Code Studio | `.codestudio/mcp.json` | `servers` |
| Claude Code | `.mcp.json` | `mcpServers` |

The generated entry registers a server named `sf-maui-mcp`. For example, for VS Code the CLI adds the following entry to `.vscode/mcp.json`:

```json
{
  "servers": {
    "sf-maui-mcp": {
      "type": "stdio",
      "command": "dotnet",
      "args": ["tool", "run", "syncfusion-maui-mcp"],
      "env": {
        "Syncfusion_API_Key_Path": "C:\\Keys\\syncfusion.key"
      }
    }
  }
}
```

The CLI edits only the selected platform server entry. Unrelated JSON values, comments, and trailing commas in the file are preserved. Malformed files, duplicate JSON properties, and wrong-shaped configurations are rejected before any change is written. An identical existing entry is left untouched; a differing entry requires `--force`, which replaces only that platform's server entry.

### Runner modes

The MCP server runs as a .NET tool. The `--runner` option selects how the client starts it:

| Runner | Behavior |
| --- | --- |
| `auto` (default) | Checks the .NET SDK selected in the workspace (including `global.json`). SDK 10 or later uses `dnx`; SDK 8/9 uses the local tool mode. |
| `dnx` | Starts the server with `dnx Syncfusion.Maui.MCP --yes`. The package is downloaded when the client first starts the server. Requires .NET SDK 10 or later. |
| `local` | Creates a local tool manifest at `.config/dotnet-tools.json` if one does not exist, installs the `Syncfusion.Maui.MCP` tool into it, and configures `dotnet tool run syncfusion-maui-mcp`. |

N> When the local tool manifest already lists the MCP tool, the CLI restores the manifest's tools instead of reinstalling. This may also download other tools listed in that manifest. Run the client from the configured workspace so local-tool resolution uses that manifest.

### MCP API key configuration

The MCP server authenticates with a Syncfusion<sup>®</sup> API key that is different from the product license key. The CLI never reads, copies, or stores the key itself. It writes only the absolute file path into the configuration as the `Syncfusion_API_Key_Path` environment variable.

**Create the API key file:**

1. Sign in to your Syncfusion<sup>®</sup> account and generate an API key at [https://www.syncfusion.com/account/api-key](https://www.syncfusion.com/account/api-key).
2. Save the key into a `.txt` or `.key` file, such as `C:\Users\me\.syncfusion\api-key.txt` or `~/.syncfusion/api-key.key`. These are the only supported file extensions.
3. Keep the file outside the workspace directory. Setup rejects a key file located inside the workspace to prevent the credential from being committed to source control.
4. Pass the file path through `--key-file` or enter it at the prompt. The CLI suggests the path stored in the `Syncfusion_API_Key_Path` environment variable as the default.

**Update or manage the key:**

* To use a new key value, edit the existing file in place. The configuration stores the file path, not the key content, so no configuration change is needed.
* To use a different file, re-run `sf mcp init` with the new `--key-file` path.
* Symbolic links are rejected; pass the real file path.

W> Never commit the API-key file to source control, and never paste the key value directly into the terminal. Store the file in a location excluded from repositories, such as the user profile directory.

## Install AI component skills

The `sf skills install` command installs the official Syncfusion<sup>®</sup> .NET MAUI component skills for AI agents from the `syncfusion/maui-ui-components-skills` GitHub repository. Skills give AI agents product-specific guidance for generating and editing Syncfusion<sup>®</sup> control code. Skills are installed for the agents you choose, either project-local or global.

No Syncfusion<sup>®</sup> account, API key, or license is required to install or read skills.

### Prerequisites

* [Node.js](https://nodejs.org/en) 22.20 or later, installed with npm and Git, available on `PATH`.
* The setup uses the official Skills CLI (`skills@1.7.4`) through npx, which may download the CLI package and the official skills repository on first use.

### Install skills through the interactive menu

1. Run `sf` to open the main menu, and under **AI & Skills**, select **Add component skills to AI Agent**.

    ![Add component skills to AI Agent option in the Syncfusion .NET CLI main menu](images/cli-setup-skills-command-menu.png)

2. Select the platform. Choose **.NET MAUI**.

    ![Platform selection in the skills installation flow of the Syncfusion .NET CLI](images/cli-select-platform-skills.png)

3. Enter the workspace directory. The Skills CLI then presents its own interactive flow, in which you choose the component skills, the agents, and the project or global scope. No API key is required.

    ![Component skills, agents, and scope selection in the Skills CLI](images/cli-skills-installation.png)

4. After the Skills CLI completes, the CLI reports the completed status for the skills repository.

    ![Skills installed successfully in the Syncfusion .NET CLI](images/cli-skills-installed.png)

### Install skills using direct commands

```bash
sf skills install maui
sf skills install maui --list
sf skills install maui --agent github-copilot --skill <exact-skill-name> --yes
sf skills install maui --agent cursor claude-code --all --yes
```

* Use `--list` to list the exact skill names available in the repository without installing anything.
* Use `--agent` with one or more agent IDs: `github-copilot`, `cursor`, `codestudio`, or `claude-code`.
* Use `--skill` with one or more exact skill names, or `--all` to install all skills for the selected agents. `--all` does not mean all agents.
* Noninteractive installation requires `--agent`, `--skill` (or `--all`), and `--yes`. The scope defaults to project-local; add `--global` explicitly to install skills in the user's global agent directories.
* Skills are copied into the agent's skills location, so no symlink privileges are required.

N> `completed` means the Skills CLI exited successfully, not that an AI agent has loaded or executed the skills. Reload the workspace in your AI agent so the newly installed skills are picked up.

## Options reference

### Creation options

| Option | Description |
| --- | --- |
| `-n`, `--name` | Project name. Required when prompting is unavailable |
| `-p`, `--path` | Parent directory. Defaults to the current directory |
| `-t`, `--target-framework` | The .NET target framework, such as `net10.0` |
| `--control` | One or more control IDs, or `empty`. Omit to create an empty project |
| `--project-type` | The .NET MAUI project type: `app` |
| `--post-action` | Post-create action: `generate` or `build`. Defaults to `build` for direct commands |
| `--build-framework` | Build only this configured project target, such as `net10.0-android`. Defaults to all configured targets |
| `--dry-run` | Preview the action without making changes |
| `--force` | Allow supported overwrites. Edited control samples remain protected |
| `--no-restore` | Skip `dotnet restore` after the action |
| `--no-build` | Skip `dotnet build` after the action |
| `--no-interactive` | Disable interactive prompts |
| `--json` | Emit a JSON document instead of table output |

N> `--post-action build` conflicts with `--no-build`. Neither `--force` nor confirmation authorizes overwriting an existing project destination.

### Package operation options

| Option | Description |
| --- | --- |
| `-p`, `--path` | The project directory, `.csproj` file, or a supported subdirectory |
| `-v`, `--version` | The Syncfusion<sup>®</sup> NuGet package version |
| `--source` | Package source; Syncfusion<sup>®</sup> packages require `https://api.nuget.org/v3/index.json` |
| `--configfile` | The NuGet configuration file to use |
| `--dry-run` | Preview the action without making changes |
| `--force` | Allow supported overwrites |
| `--no-restore` | Skip `dotnet restore` after the action |
| `--json` | Emit one JSON document |

### MCP options

| Option | Description |
| --- | --- |
| `<platform>` | The platform: `maui`, `blazor`, `wpf`, `winforms`, or `winui` |
| `--client` | The MCP client: `vscode`, `cursor`, `codestudio`, or `claude-code` |
| `--key-file` | Path to an existing API-key `.txt`/`.key` file outside the workspace |
| `--runner` | Server runner: `auto` (default), `dnx`, or `local` |
| `-p`, `--path` | The workspace directory. Defaults to the current directory. The directory must already exist |
| `--dry-run` | Validate inputs and preview the destination without writing files or running tools |
| `--force` | Replace an existing, differing platform server entry |
| `--json` | Emit one JSON document |

### Skills options

| Option | Description |
| --- | --- |
| `<platform>` | The platform: `maui`, `blazor`, `wpf`, `winforms`, or `winui` |
| `--agent` | One or more agent IDs: `github-copilot`, `cursor`, `codestudio`, or `claude-code` |
| `--skill` | One or more exact skill names. Discover names with `--list` |
| `--all` | Install all skills for the selected agents, not all agents |
| `--global` | Install skills in the user's global agent directories |
| `--yes` | Confirm noninteractive installation |
| `--list` | List repository skill names without installing |
| `-p`, `--path` | The workspace directory. Defaults to the current directory |
| `--dry-run` | Show the planned Skills CLI command without executing it |
| `--json` | Emit one JSON document |

### License options

| Option | Description |
| --- | --- |
| `-p`, `--path` | The project directory or `.csproj`/`.vbproj` to scan for Syncfusion<sup>®</sup> packages. Defaults to the current directory |
| `-y`, `--yes` | Accept the trial EULA prompt automatically during activation |
| `--file` | Activate from an existing key file. With no value, the CLI reads `./syncfusion-license.txt` from the project directory. With an absolute path, the CLI uses the specified file |
| `--json` | Emit one JSON document instead of table output |

## FAQs

**Does the CLI register a license?** Yes. `sf license activate` scans the project for Syncfusion<sup>®</sup> `PackageReference` entries, downloads the matching license keys from your Syncfusion<sup>®</sup> account, and inserts `SyncfusionLicenseProvider.RegisterLicense(...)` into `MauiProgram.cs` (or the platform-specific startup file). The CLI signs you in through the browser the first time, or you can sign in ahead with `sf login`. For background information on Syncfusion<sup>®</sup> licensing, refer to the [licensing overview](https://help.syncfusion.com/common/essential-studio/licensing/overview).

**Does `sf add maui datagrid` generate the DataGrid sample?** In a CLI-generated project, yes. In an ordinary project, the command adds the NuGet package reference only and reports that no sample was generated.

**Where does the CLI register the license for .NET MAUI?** In `MauiProgram.cs`, immediately before `MauiApp.CreateBuilder()`. For Blazor, WPF, WinUI, and WinForms, the CLI targets `Program.cs`, `App.xaml.cs`, `App.xaml.cs`, and `Program.cs` respectively.

**Can I use my own key file?** Yes. Run `sf license activate --file C:\keys\syncfusion-license.txt` with an absolute path. The CLI reads the keys from the file and registers them in the project's startup code without contacting the license service.

**Which .NET versions are supported?** .NET 10 (`net10.0`) and .NET 9 (`net9.0`). Installed template and workload compatibility is checked separately during creation.

**Which platforms does the CLI support?** .NET MAUI, Blazor, WPF, WinForms, and WinUI 3. This documentation covers .NET MAUI.

**Is the MCP API key the same as my product license key?** No. The MCP server uses a separate API key generated at [https://www.syncfusion.com/account/api-key](https://www.syncfusion.com/account/api-key). Store it in a `.txt` or `.key` file outside the workspace, and pass the file path through `--key-file`. The CLI writes only the file path into the MCP configuration; it never reads or copies the key.

**Does MCP setup verify the server connection?** No. Setup writes the client configuration and installs the required tool, but does not contact the server. Open or reload the workspace in the client, start the server, confirm its tools are listed, and then ask a Syncfusion documentation question.

**Do I need a license to install AI component skills?** No. Skills installation requires no Syncfusion<sup>®</sup> account, API key, or license. It requires Node.js 22.20 or later with npm and Git.

## See also

* [Syncfusion .NET MAUI controls](https://www.syncfusion.com/maui-controls)
* [Syncfusion .NET MAUI help documentation](https://help.syncfusion.com/maui/introduction/overview)
* [System requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)
* [Installing .NET MAUI NuGet packages](https://help.syncfusion.com/maui/installation/install-nuget-packages)
* [Syncfusion<sup>®</sup> licensing overview](https://help.syncfusion.com/common/essential-studio/licensing/overview)
* [Syncfusion<sup>®</sup> .NET MAUI AI coding assistant skills](https://help.syncfusion.com/maui/ai-coding-assistant/skills/controls-user-skills)i-coding-assistant/skills/controls-user-skills)