# Syncfusion® .NET CLI

The Syncfusion .NET CLI (`sf`) creates projects and manages Syncfusion packages
for .NET MAUI, Blazor, WPF, WinForms and WinUI 3.

**Platform implementations:** .NET MAUI, Blazor, WPF, WinForms and WinUI 3.
See [desktop configurations and validation limits](docs/desktop-platforms.md)
before using the new desktop providers. The Windows build and launch matrix
passes; visual theme appearance and deeper control interactions still need
manual review.

## How the CLI is organized

The CLI keeps command-line handling separate from shared logic and platform-specific
implementations:

```text
sf command
  ├─ CLI: command parsing, validation, direct commands, and interactive prompts
  ├─ Core: platform-neutral contracts, framework metadata, and path/process helpers
  └─ Platforms
      ├─ MAUI: project detection, catalogs/resources, and MAUI operations
      ├─ Blazor: official template orchestration, demo pages, themes, and packages
      ├─ WPF: C#/VB projects, Chart/DataGrid samples, and themes
      ├─ WinForms: C#/VB projects, Chart/DataGrid samples, and Office2019
      └─ WinUI 3: Windows App SDK projects with DataGrid, Charts, TreeGrid, Ribbon and DockingManager samples
```

The CLI project is under `src/Syncfusion.DotNet.CLI`, platform-neutral code is
under `src/Syncfusion.DotNet.CLI.Core`, and MAUI implementation, catalogs,
resource loading, and embedded control resources are under
`src/Syncfusion.DotNet.CLI.Maui`. Desktop implementations are in
`src/Syncfusion.DotNet.CLI.WPF`, `.WinForms` and `.WinUI`; solution folders group
them under Platforms. Blazor support is in `src/Syncfusion.DotNet.CLI.Blazor`.
Tests are under `tests/`.

Core groups request and command contracts in `Commands`, file and path helpers
in `IO`, package-process support in `NuGet`, and version metadata in `Metadata`.
The types keep the shared Core namespace so the public contract remains easy to
find.

Within the MAUI project, `Catalog`, `Discovery`, `Injection`, `Manifest`,
`Packages`, `Projects`, and `Execution` separate metadata, read-only discovery,
registration edits, ownership records, package actions, project workflows,
embedded resource loading, and process execution. The `ControlInstaller`
currently coordinates both control and package work; extracting that large
workflow is a separate behavior-tested task. A generic pipeline abstraction is
not used.

## Command flow

`Program.Main` wires Ctrl+C to cancellation and starts `CliApp`. `CliApp` builds
the `System.CommandLine` tree; command handlers parse and validate input into
Core request types, then call the selected platform operation and report results through
the presenter. Running `sf` without a command enters `InteractiveMenu`, which
uses the same request and operation paths as direct commands.

## Install and start

Install the published tool globally. Add `--prerelease` while only preview
versions are available:

```bash
dotnet tool install -g Syncfusion.DotNet.CLI --prerelease
sf --version
```

Package removal (`sf remove`, including control removal) is temporarily disabled
for all platforms while improvements are in progress. Its implementation is
preserved with `// Improvement:` comments. Removal examples later in this
document describe the retained behavior and are currently unavailable.

Run `sf` with no arguments in an interactive terminal to open the menu. It
shows the current CLI version and groups these operations:

- **Project creation:** Create a new project (`sf new`).
- **Package management:** Add a package to an existing project (`sf add`),
  or update a package in an existing project (`sf update`).
- **Discovery:** List available packages (menu hint: `sf list <platform> packages`),
  List installed packages in an existing project (menu hint: `sf list <platform> installed`),
  or Search for packages (`sf search`). The `<platform>` text is a usage placeholder; use the
  supported platform in a direct command.
- **Help and information:** View CLI information (`sf info`) and Show help (`sf help`).
- **Exit:** Return successfully without making changes.

The command references are guidance; selecting an operation enters its existing
workflow. Selection screens keep navigation and cancellation hints visible: use
Up/Down and Enter for single selection, and Space to toggle then Enter to continue
for multi-selection. Text-entry and confirmation screens show Enter, Esc, and Ctrl+C.
Escape cancels the current question without using a default and returns to the
menu; Escape on the menu keeps the menu open. Ctrl+C exits the interactive
session with code 130 and prints `The operation was canceled.` The main menu
shows its keyboard guidance without a heading. Interactive menu headings and
command hints use restrained blue accents; `--no-color` removes color while
retaining the layout.
Complete direct commands remain usable without opening the menu. Run `sf help`
for a short command map, `sf help maui` for MAUI examples, or `sf help blazor`
for Blazor options and package commands.

## Blazor

Blazor is a first-class platform backed by Microsoft's `blazor` and
`blazorwasm` templates. It supports Blazor Web Apps with Server, WebAssembly,
or Auto interactivity and standalone WebAssembly projects. The wizard can add
responsive Syncfusion demos for Grid, Charts, Scheduler, Gantt, Diagram, Rich
Text Editor, File Manager, PDF Viewer, Document Editor, Spreadsheet, Kanban,
and Query Builder with one of five Syncfusion themes.

```bash
sf new blazor --name MyApp --render-mode server --control grid charts
sf new blazor --name ClientApp --app-type webassembly-standalone --control grid
sf add blazor gantt --path ./MyApp
sf list blazor packages
```

Package discovery uses the same aligned available/installed tables across all
five platforms. WPF, WinForms, WinUI and Blazor include verified NuGet.org
package-only libraries in addition to generated-control aliases; `--details`
shows sample availability. See [package discovery verification](docs/package-discovery-verification.md)
for the inventory, output contracts and validation results.


The available target frameworks come from the installed official template;
.NET 10 remains the default. See [Blazor support](docs/blazor.md) for options,
prerequisites, themes, and verified restrictions.

## Command structure and count

Most project and control operations use this structure:

```text
sf <action> maui [target] [options]
```

For example:

```bash
sf new maui --name MyApp
sf add maui datagrid
sf new maui --name MyApp --control datagrid
```

There are **7 named subcommands**: `new`, `add`, `update`, `list`,
`search`, `info`, and `help`. The root command also provides `--help` and the
built-in `--version` action. Running `sf` without arguments starts interactive
mode; it is an entry point, not another named subcommand. Package, control, and
list-category forms below are variations of these commands, not additional
subcommands.

## Direct commands

### Create a project

| Command | Purpose |
| --- | --- |
| `sf new maui --name <name>` | Create a standard MAUI project. |
| `sf new maui --name <name> --control <id> [<id> ...]` | Create a MAUI project with one or more Syncfusion controls. |
| `sf new maui --name <name> --path <directory>` | Create the project under the specified output directory. |

Omit `--control` to create an empty project, or use `--control empty` to make
that choice explicit. The approved control families are DataGrid, ListView,
Scheduler, Charts, AssistView, Rich Text Editor, ComboBox, Maps, Image Editor,
and TreeView. Charts offers Cartesian Chart, Circular Chart, Polar Chart,
Pyramid Chart, Funnel Chart, and Sunburst Chart.

The only enabled project type is MAUI App (`--project-type app`). Blazor Hybrid
creation is temporarily disabled, including explicit `--project-type blazor-hybrid`
requests. The default target framework is `net10.0`; use
`--target-framework <tfm>` to choose another target. The native MAUI appearance
is used; customize styling in the generated project with .NET MAUI resources.
`--path` accepts relative or absolute directories and defaults to the current
directory; the project is created in `<path>/<name>`. Existing destination
files or directories are not overwritten or merged, and the CLI does not pick
another destination automatically.

### Manage NuGet packages

Syncfusion package installs resolve the latest stable release from nuget.org and
write a concrete version, never `*`. Custom/local package sources are rejected.
Use `--version` to pin a release. See [package policy](docs/nuget-package-policy.md).


These commands change package references only; they do not create or remove
generated control files.

| Command | Purpose |
| --- | --- |
| `sf add maui <package>` | Add a Syncfusion MAUI NuGet package. |
| `sf remove maui <package>` | Remove a Syncfusion MAUI NuGet package. |
| `sf update maui <package>` | Update a Syncfusion MAUI NuGet package. |

Use a package alias, package ID, or exact unambiguous display name. Examples:

```bash
sf add maui datagrid
sf add maui inputs
sf add maui Syncfusion.Maui.DataGrid
sf remove maui datagrid
sf update maui datagrid
```

In CLI-generated projects, `sf add maui datagrid` also generates the DataGrid
sample and welcome button; `sf add maui inputs` integrates ComboBox. Use
`sf add maui --control <id>` to select a particular sample, including controls
sharing a package. Ordinary projects retain package-only behavior. Packages
without sample templates remain available, with an explanatory message.

### Discover packages and project information

| Command | Purpose |
| --- | --- |
| `sf list maui packages` | List packages in the MAUI package catalog. |
| `sf list maui installed` | List directly installed Syncfusion MAUI packages in the project. |
| `sf search maui <text>` | Search package aliases, IDs, names, and descriptions. |
| `sf info` | Show CLI information. |

Search results contain package records. `--json` is available for supported list,
search, and information commands.

### Help and version

| Command | Purpose |
| --- | --- |
| `sf help` | Show the concise command map. |
| `sf help maui` | Show the MAUI command map and package aliases. |
| `sf --help` | Show root help. |
| `sf --version` | Show the CLI version. |

`-h` is an alias for `--help`. Within commands that accept a package version,
`-v`/`--version <version>` selects the Syncfusion NuGet version; at the root,
`sf --version` displays the CLI version.

## Interactive mode

Run `sf` in an interactive terminal to open the menu. It contains the
implemented operations, in this order:

- Create a MAUI project.
- Add, remove, update, list, and search packages; list installed packages.
- Add and remove controls.
- Show CLI and environment information, show MAUI help, or Exit.

The menu keeps package actions separate from generated controls. In an
incomplete direct `add` or `remove` command, the CLI asks whether you want a
Package or a Control, then keeps the remaining questions and results specific
to that choice.

Choosing **Create a new project** collects the platform, project template, framework,
project location, project name, project setup, and post-creation action, in that
order. Labels include **.NET MAUI**, **.NET MAUI App**, **.NET MAUI Blazor Hybrid**,
and **.NET 10 (net10.0)**. Name and parent-directory prompts show explicit defaults;
Enter accepts them. The final folder is `<project location>/<resolved name>`.

**Select project setup:** offers **Blank app** and **Include Syncfusion controls**.
The control picker uses readable names, checkboxes, and a live selected count.
Use arrows to navigate, Space to toggle, and Enter to continue. Escape cancels
and Ctrl+C exits. Selection markers remain visible with `--no-color`.

The **Post-create:** step offers **Generate only** (create files, skip build)
and **Build project** (create files, then restore and build), with aligned
hints. The final review shows only the selected value under **Post-create:**.
Generate only skips
restore and build for a blank app; including controls still requires their
package restore and generation validation. Build project builds all configured
targets and respects the project's OS conditions. An explicit
`--build-framework <tfm>` selects one enabled target. The selected .NET SDK,
MAUI workloads, and platform tools are checked before generation. Native Android builds need
an Android SDK and a compatible JDK; Windows builds need the Windows SDK.
Run remains deferred until compatible run-target discovery is implemented.

Before creation, a compact summary shows the action, platform, template,
framework, chosen project location, project name, setup, selected controls
(when present), and
post-creation action. Setup is shown as **Blank app** or **Include Syncfusion
controls**; blank apps omit the Controls row.
`Create project? [Y/n]:` accepts Enter as Yes. No or Escape cancels without
creating files. Generation and build results are reported separately, followed
by the full project path and next commands. Success prints
`Project created at <project location>/<project name>`. A failed build rolls back the
new project and reports that it was not retained.

The default project name is `SyncfusionMauiApp`. Empty input accepts the
displayed default; an explicit input replaces the default and is validated
against the existing .NET naming rules. Before prompting, the CLI chooses the
next available name in the selected project location (`SyncfusionMauiApp2`,
`SyncfusionMauiApp3`, ...), checking both files and directories. The prompt is
`Project name:      [SyncfusionMauiApp]`. A conflicting submitted name immediately
asks for a different name and is never renamed automatically.

The interactive default parent is `<UserProfile>\source\repos` on Windows
and `<UserProfile>/Projects` on macOS/Linux, resolved from the current user
profile at runtime. `Project location:  [<default>]` accepts Enter for the
default; an explicit input is also a project location. The selected parent
is created if missing. Protected system locations and their descendants
(including directory links into them) show a warning and ask again.
Scripted commands with an explicit name retain their existing `--path` default.
The final destination is normalized to an absolute path with standard .NET
APIs and is shown in the review. The process current directory is not
changed.

Blank-app progress shows **Creating project**, **Setting up project files**,
and **Building project** (only for Build project). With selected controls,
progress shows **Creating project**, **Adding Syncfusion controls**,
**Finalizing project**, and the optional **Building project** step.
Build progress ends with **✓ Built project** or **✗ Build failed.** A failed
build shows diagnostics and `cd`/`dotnet build` commands to retry in the project
folder, retaining any explicit build target. `--verbose` displays the detailed
internal sub-steps instead. Other failures identify the group and specific
failed sub-step, followed by diagnostic details. Internal execution order is
unchanged.

The post-creation action is **Create only** or **Build**. **Run** is
deferred until a verified run target discovery is available; when it is
offered, the CLI shows only compatible targets and auto-selects the single
target when one is available. When selected controls require build
validation, **Run** is also deferred.

From the main menu, Escape at any project-creation step returns to the
unchanged main menu. Confirmation Yes starts creation, while No returns to
the menu. In a direct `sf new` flow, Escape or No cancels the command
without creating files. Ctrl+C prints `The operation was canceled.` once and
exits with code 130.

For existing-project operations, the CLI uses a valid explicit project path.
Otherwise, it selects the current MAUI project automatically when exactly one
is found. When multiple MAUI projects are present, choose from a
deterministically sorted list of relative project paths. If project selection
is not available, pass `--path` with the intended project.

Interactive package and control choices use the same operations as direct
commands. Package choices are single-select. Before a change, the CLI shows
one review of the selected project and requested changes. Creation, additions,
and updates default to Yes; removals default to No. Read-only commands and dry
runs do not ask for confirmation. Complete valid direct commands run without
prompts.

Direct commands with missing values can ask only for those values in an
interactive terminal; they do not reopen the main menu. Invalid supplied
package aliases, control IDs, framework names, and project paths are reported
instead of being replaced or guessed. Explicit package versions and new-project
target frameworks are validated before unrelated interactive questions, using
their existing validators. Use
`--no-interactive` to make missing values an error. The CLI does not prompt when
`--json` is supplied, stdin is redirected, or the terminal cannot support
interactive selection. JSON output remains machine-readable.

The main menu and active interactive questions display their keyboard guidance
vertically. `--no-color` keeps prompts readable without color. Select **Exit**
to return success without making changes. Ctrl+C requests cancellation; the CLI
reports `The operation was canceled.` and returns exit code 130.

Package operations remain single-selection because the package layer does not
provide the existing atomic batch operation required for safe multi-selection.

## Options

Global options can be used with commands:

| Option | Purpose |
| --- | --- |
| `-h`, `--help` | Show help for the command. |
| `--interactive` | Allow prompts when running in an interactive terminal. |
| `--no-interactive` | Disable prompts. |
| `--json` | Emit machine-readable output where supported. |
| `--verbose` | Print diagnostic details. |
| `--no-color` | Disable colored output. |

Common command-specific options:

| Option | Purpose |
| --- | --- |
| `-n`, `--name` | Set the name of a new project. |
| `-p`, `--path` | Set the output directory or identify an existing project directory or `.csproj`. |
| `-t`, `--target-framework` | Set the new project's .NET target framework. |
| `--control` | Select one or more controls for a new project. |
| `--project-type` | Select `app` for a new project; Hybrid creation is temporarily disabled. |
| `--post-action` | Select `generate` or `build` after project creation. |
| `-v`, `--version` | Select a Syncfusion package version where supported. |
| `--source`, `--configfile` | Use the official nuget.org source or supply other NuGet configuration settings. |
| `--dry-run` | Preview an operation without changing the project. |
| `--force` | Force an operation where supported. |
| `--no-restore`, `--no-build` | Skip applicable post-operation steps; not allowed when creating a project with controls. |

For command-specific syntax and defaults, see
[the command reference](docs/command-reference.md).

## Compatibility

The primary form puts `maui` before the target. Existing target-first forms
remain supported for compatibility, for example:

```bash
sf add datagrid maui
sf remove datagrid maui
sf update datagrid maui
sf list packages maui
sf search datagrid maui
```

For project creation, the hidden `--template` option remains accepted as a
compatibility alias for `--control`.

The main-menu Add flow uses the same provider-backed control picker as Create:
**Which controls would you like to add?** supports multiple selections. Controls
already recorded in the selected project's manifest show **Added** and cannot
be selected. If every listed control is added, the flow reports that and exits
without changes. **Other packages...** opens the full platform package catalog;
direct `sf add <package-name>` commands remain available for packages without
samples.

Selected controls run as one existing batch operation: shared NuGet packages are
deduplicated, and templates, registration, navigation, and manifests use the
existing installer. The review shows **Controls:** with catalog display names.

The main-menu package-add review uses the shared creation label column and
shows Action, Platform, Project file, Controls (or Package for Other packages),
Version, and Post-add once.
Post-add offers Restore only or Restore and build, retaining build as the
default. Direct add commands continue honoring their existing flags, including
`--no-build` and `--no-restore`. Confirmation uses `Apply these changes? [Y/n]:`
without retaining a separate answer row.

Package-add progress reports actual work as Adding package, Restoring packages,
Updating project files, and Building project when applicable. Planned/pending
lines are hidden. `--verbose` retains detailed stages. Platform providers own
stage mappings and diagnostic vocabulary; MAUI-specific registration and
control names remain in the MAUI implementation. All sample and manifest writes
finish before build validation; failed validation still rolls back the changes.

## Build, test, and pack

The solution targets .NET 10. From the repository root:

```bash
dotnet restore
dotnet build
dotnet format
dotnet test
dotnet pack -c Release
```

The package is a .NET global tool named `Syncfusion.DotNet.CLI`; its command is
`sf`. The packed `.nupkg` is written to `artifacts/packages`.

## Requirements and limitations

- Install the .NET MAUI workload if it is not already available:
  `dotnet workload install maui`.
- Desktop framework/language/theme support and Windows prerequisites are
  listed in [Desktop platforms](docs/desktop-platforms.md).
- Standalone Blazor, .NET 11 and VB WinUI are not offered.

## License

Copyright (c) 2026 Syncfusion Inc. All Rights Reserved.
