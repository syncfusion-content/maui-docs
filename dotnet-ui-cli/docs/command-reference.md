# Command reference

> Package removal is temporarily disabled across all platforms. The interactive
> remove option and every `sf remove` form are unavailable while improvements are
> in progress. Removal examples below document the preserved implementation.

## Synopsis

```text
sf <action> <platform> <target> [options]
```

Platforms: `maui`, `blazor`, `wpf`, `winforms`, `winui`. Run `sf help` for the concise
command list or `sf help <platform>` for a platform command map.
Desktop `--language`, `--theme`, project formats and package-only behavior are
documented in [Desktop platforms](desktop-platforms.md).
The MAUI commands below retain their existing behavior.

### Interactive home menu

Run `sf` without arguments in an interactive terminal to show the grouped menu.
Section headings use bold uppercase text and leading category icons on
Unicode-capable terminals. ASCII terminals retain uppercase labels without
icons; `--no-color`, `NO_COLOR`, and non-ANSI output omit styling.
One blank row separates categories. Option labels are indented beneath their
headings, with a fixed selection-marker column and aligned command hints.
The home menu renders every category and action without a paged choice window.
If it exceeds the terminal height, normal terminal scrollback applies.
The available actions, command hints, ordering, and keyboard navigation are
unchanged.

### Blazor projects

```text
sf new blazor -n MyApp [--app-type web-app|webassembly-standalone]
  [--target-framework <tfm>] [--render-mode server|webassembly|auto]
  [--interactivity per-page|global] [--auth none|individual]
  [--https yes|no] [--theme <theme>] [--control <id> ...]
  [--path <directory>] [--post-action generate|build]
```

`web-app`, Server, per-page interactivity, no authentication, HTTPS, Fluent 2,
and Grid are the interactive defaults. Use `--control empty` for an official
minimal project without Syncfusion packages or demos. Standalone WebAssembly
uses WebAssembly rendering automatically. Installed Microsoft templates
determine target framework availability; .NET 10 is preferred when available.

Existing-project commands use the shared package workflow:

```text
sf add blazor grid -p ./MyApp
sf remove blazor grid -p ./MyApp
sf update blazor grid -p ./MyApp
sf list blazor packages
sf list blazor installed -p ./MyApp
sf search grid --framework blazor
sf help blazor
```

See [Blazor support](blazor.md) for component aliases, themes, prerequisites,
hosting behavior, and authentication restrictions.

## Commands

### Project

Create a .NET MAUI project:

```text
sf new maui -n MyApp [options]
```

Options include `-n/--name`, `-p/--path`, `-t/--target-framework`,
`--control`, `--project-type`, `--post-action`, `--build-framework`, `--source`, `--configfile`,
`--dry-run`, `--force`, `--no-restore`, and `--no-build`.
Omit `--control` to create an empty project, or use `--control empty` to make
that choice explicit. Provide one or more control IDs to create a project with
Syncfusion controls:

```text
sf new maui -n MyApp --control datagrid
sf new maui -n MyApp --control datagrid combobox
sf new maui -n MyApp --control cartesian-chart circular-chart
```

Every wizard input has a command equivalent:

| Wizard input | Argument/default |
| --- | --- |
| Platform | `maui` or `--framework maui` |
| Project template | `--project-type app` (only enabled template; Hybrid temporarily disabled) |
| Framework | `--target-framework net10.0` (default) |
| Name | `--name MyApp`; required when prompting is unavailable |
| Parent directory | `--path <directory>`; defaults to the current directory |
| Setup and controls | `--control empty` or one or more canonical IDs |
| Post-creation action | `--post-action generate` or `build`; direct commands default to build |
| Optional build target | `--build-framework <TFM>`; defaults to all configured targets |

For example, generate a blank project without prompting, restore, or build:

```text
sf new maui --name MyApp --path ./apps --project-type app --target-framework net10.0 --control empty --post-action generate --no-interactive
```

Interactive prompts show keyboard hints only while awaiting input. Completion
clears that prompt's title, wrapped hints, and option list, then retains one
plain result such as `Platform: .NET MAUI`, `Template: .NET MAUI App`, or
`Project name: MyApp`. Multiple selections retain one line containing the
selected names. Earlier results stay in the terminal; only the current prompt
region is cleared. Automatically resolved values print their result without
keyboard hints. Escape and Ctrl+C clear the active region before cancelling.

Project creation replaces these completed-step records with one final review.
The CLI header and output preceding the wizard remain intact. The parent-folder
explanation belongs to the active destination prompt and disappears when that
input completes. Final labels align compactly; long values wrap onto indented
continuation lines without truncation. Below 48 columns, values appear indented
under their labels to keep paths and framework names readable. `Controls:` has no count. Collision
warnings remain visible before confirmation, with the resolved name in the
review. Confirmation hints appear only while awaiting input and clear on
acceptance, decline, Escape, or Ctrl+C. See the [final-review validation report](validation/project-wizard-review.md).

The resulting folder is `./apps/MyApp`. A complete direct command does not open
the wizard. Missing required values in scripts produce an error. When a name is
missing in an interactive terminal, the wizard supplies an explicit default and
collects the remaining unspecified inputs. Legacy `--template` and `--no-build`
remain supported; `--post-action build` conflicts with `--no-build`.

Only an accepted default name can receive an available numeric suffix when its
destination exists; the wizard explains the resolved name before confirmation.
Explicit names are never silently renamed. Neither `--force` nor confirmation
authorizes overwriting an existing destination.

Build project runs `dotnet build "<generated-project.csproj>"`, with no automatic
Android/host target or `TargetFramework` override. MSBuild honors the project's
multi-platform configuration, imports, and OS conditions; the review shows
`Post-create: Build project (all configured targets)`. The default build
includes restore, so missing workloads or platform tools appear as build errors
after creation. The generated project is retained and the CLI prints the
diagnostics and a quoted build command to retry from any directory.

To build one target explicitly:

```text
sf new maui --name MyApp --target-framework net10.0 --post-action build --build-framework net10.0-android
```

`--build-framework` is validated against MSBuild's evaluated project targets on
the current OS and passed to `dotnet build` through `-f`; the review shows a
separate `Build target:` row. It requires the Build project action. Existing
`--framework/-f` still selects the CLI platform (such as `maui`), and
`--target-framework/-t` still selects the MAUI template's .NET version; neither
implicitly narrows the post-creation build.

The destination is the selected parent joined with the resolved project name.
If both end in the same name, nesting is intentional: parent `/apps/MyApp`
and project name `MyApp` produce `/apps/MyApp/MyApp`. Running inside an existing
project does not rewrite or move the chosen project location.

Generation/build status and rollback status are also available in JSON
(`generationSucceeded`, `buildSucceeded`, `rolledBack`), together with errors
and `nextCommands`. A build failure returns a nonzero exit code with
`generationSucceeded: true`, `buildSucceeded: false`, and `rolledBack: false`.
Incomplete generation is still rolled back. Native workloads and tools remain
necessary for selected control package compatibility checks; blank generation
needs the SDK and MAUI templates only. See the [build validation report](validation/maui-post-creation-build.md).

Creation failures include their failing stage and the underlying template or
filesystem diagnostic, including output written by `dotnet new` to stdout.
Child SDK commands use an absolute executable path: the SDK selected through
`PATH` takes precedence, with the running .NET installation as a fallback.
This also avoids executable lookup failures when the shell remains inside a
directory deleted by an earlier rollback. For older CLI installations, move
to an existing directory (`cd "$HOME"`) before starting `sf` again.

Projects use the native MAUI appearance and platform/system light and dark
behavior. No project-theme selection is provided; application styling can be
added after creation using .NET MAUI resources. The obsolete `--theme` input
fails with a migration message and does not create or modify a project.

### Packages

Package operations change NuGet references only; they do not generate control
files.

```text
sf add maui <package> [options]
sf remove maui <package> [options]
sf update maui <package> [options]
```

`<package>` accepts a canonical package alias, a canonical package ID, or an
exact unambiguous package display name. Canonical aliases are case-insensitive
and are shown by `sf list maui packages` and `sf help maui`. The package
catalog is broader than the generated-control scope; package availability
does not depend on control generation. Dependency-only, development-tool,
Toolkit, unresolved, and unsupported records are classified separately.
The `recommended` flag determines interactive package-picker membership;
unresolved registration metadata does not prevent explicit package operations.
Toolkit is a distinct product family with its own
registration and version strategy.
Examples:

```text
sf add maui datagrid
sf add maui inputs
sf add maui Syncfusion.Maui.DataGrid
sf remove maui datagrid
sf update maui datagrid
```

In a CLI-generated project, supported package aliases also integrate their
samples: `sf add maui datagrid` adds DataGrid and `sf add maui inputs` adds
ComboBox. Control-only aliases such as `combobox` and `circular-chart` also
work positionally, or use `--control <id> [id ...]`. For a package containing
several samples, its canonical catalog alias selects the matching default template.
Use `--control` to select another supported sample from the same package.
Packages without templates remain available. Ordinary MAUI projects keep
package-only behavior and their existing startup page and navigation.

Package add/update support `-v/--version`, `--source`, `--configfile`,
`--no-restore`, `--dry-run`, and `--force`. Existing-project commands accept
`-p/--path`, accepting a project file, project directory, or supported
subdirectory. Discovery stops at the nearest project/repository boundary;
multiple MAUI projects retain interactive selection or require a specific
`.csproj` in scripts. `--json` emits one JSON document.

Sample adds build all configured targets by default. `--no-build` skips that
build; `--build-framework <tfm>` selects an enabled target without changing the
meaning of `-f/--framework maui`. Removal builds only with `--build` or an
explicit `--build-framework`. Default builds run `dotnet build "<project.csproj>"`
without a forced target; explicit build frameworks use `-f`.

### Controls in a new project

The ten approved control families are DataGrid, ListView, Scheduler, Charts,
AssistView, Rich Text Editor, ComboBox, Maps, Image Editor, and TreeView.
Charts contains six choices: Cartesian Chart, Circular Chart, Polar Chart,
Pyramid Chart, Funnel Chart, and Sunburst Chart. `charts` remains a legacy
control ID resolving to `cartesian-chart`; new selections use the concrete
chart IDs.

### Discovery and information

```text
sf list maui packages
sf list maui installed
sf search maui datagrid
sf info
sf --version
sf help
sf help maui
```

List categories are `packages` and `installed`.
Installed MAUI results contain direct `Syncfusion.Maui.*` references; other
platforms show direct `Syncfusion.*` references. Other vendors are excluded.
`sf search maui <text>` searches package aliases, IDs, display names, and
descriptions and returns package records only. `--json` is supported for
package, installed, search, and info queries.

Package lists and searches on all five platforms show `Syncfusion <platform> packages`
(`.NET MAUI`, `WPF`, `WinForms`, `WinUI` or `Blazor`)
with exactly one `Alias`, `Name`, `NuGet` header row and no counts. Existing
classification/category groups and ordering are preserved internally; one
blank line separates groups, without group titles. All rows share widths
calculated from displayed content, with two spaces between columns and no
terminal stretching. When three columns cannot fit without splitting words,
each record starts with its alias, followed by the name indented two spaces
and the NuGet ID indented four spaces; the headers still appear only once.
Interactive terminals paginate; redirected output, JSON, and
`--no-interactive` always return complete results without prompts.

The package-list command excludes `Syncfusion.Maui.MCP` through a listing
filter, including filtered lists, details, verbose output, and JSON. Its
catalog metadata, direct search, and package operations remain unchanged.
No MCP integration/configuration implementation is present in the CLI.

All platforms use the same installed-package layout: a platform-specific heading,
then content-sized `Alias`, `NuGet`, `Version` columns with two-space indentation.
Unknown Syncfusion packages retain an empty alias cell. Inline/child versions and
`VersionOverride` take precedence over central `Directory.Packages.props` values;
missing versions read `not specified`. Empty lists have a clear platform-specific
message. Existing JSON field names remain unchanged.

WPF, WinForms, WinUI and Blazor package catalogs include verified package-only
libraries as well as generated-control aliases. Package discovery does not add
control templates or default selections. Use `--details` or `--verbose` to see
package descriptions and whether a generated sample is available. The NuGet.org
snapshot and scope are recorded in each platform's `Catalog/available-packages.json`.
Installation still resolves the latest stable version from NuGet.org unless an
explicit version is supplied; snapshot versions do not pin installations.

Use `sf list maui packages --search grid` to reuse package search, or
`sf search maui grid`. Add `--details` for descriptions, release status,
registration requirements, documentation links, and verification evidence.
`--verbose` writes those details to stderr. Normal tables omit audit notes.
JSON retains the existing package-record fields for script compatibility.
See [the full sample listing](package-list-sample.txt) captured from
`sf list maui packages --no-interactive` for the visible entries.

The catalog's `recommended` field controls membership in the interactive add
picker only. It describes CLI setup support, independently of package
availability or release status. Explicit package commands accept all catalog
aliases and package IDs, including entries outside the picker and entries
with unresolved registration metadata. Package operations change references
only; they never apply control registration based on package metadata.

For compatibility, project creation still accepts the hidden `--template`
alias for `--control`. The legacy generated-content listing syntax also
remains parseable but is omitted from help and interactive menus; its
human-readable output uses Control terminology.

### Catalog maintenance

Run the read-only, paginated NuGet metadata audit from the repository root:

```text
python tools/catalog-audit/audit_package_catalog.py
```

The audit reports catalog records missing from the current official listed
search results, official listed search results not yet in the catalog,
unlisted packages, and entries requiring metadata review. NuGet search results
are advisory evidence, not authority to rewrite the curated catalog. The
script never changes production catalog files. Its pagination and comparison
tests use local fixtures and do not access the network.

The 2026-10-08 review accounts for all 52 packages and resolves the 37 formerly
`Unresolved` categories using official Syncfusion documentation and NuGet
descriptions. The field schema remains version 1; validation also requires
unique aliases/IDs, required fields, and supported metadata values.
Future unverified categories retain `Unresolved` in metadata and are grouped
internally as Other, with no category title printed. See [the metadata review](../src/Platforms/Syncfusion.DotNet.CLI.Maui/Catalog/package-metadata-review.json)
for per-package sources, documentation commits, and release observations.

Registration requirements remain unverified for Calendar, Core, DataGridExport,
PdfToImageConverter, PdfViewer, Picker, SmartComponents, SmartPdfViewer, and
SmartScheduler. Direct control guides were unavailable in the reviewed
documentation repository for Calendar, Picker, the PDF packages, and
SmartScheduler; product identity/category is supported by the official product
overview or NuGet descriptions. Core and SmartComponents are infrastructure;
the export guide does not establish a separate registration requirement.
These unknowns remain in the catalog rather than being inferred from another
package. Stable status means a listed non-prerelease NuGet release, not a
guarantee that every feature inside a package is out of preview.

Expander's NuGet title says Accordion, while its description and both official
guides confirm Expander and Accordion are in `Syncfusion.Maui.Expander`.
The display name covers both; the existing alias, ID, and old display-name
argument remain accepted. Toolkit registration is independently documented as
`ConfigureSyncfusionToolkit()`. Skills and MCP integration/configuration
features remain removed; the MCP NuGet catalog entry remains accessible to
search and package operations, but is excluded from the package-list command.

## Backward compatibility

The existing target-first argument forms remain supported and use the same
request models and operations as the primary syntax:

```text
sf add datagrid maui
sf remove datagrid maui
sf update datagrid maui
sf list packages maui
sf search datagrid maui
```

## Project resolution

For existing-project operations, `-p/--path` accepts a MAUI `.csproj` path or
a directory. Without it, the current directory is used. A directory with one
MAUI project is selected automatically. When multiple MAUI projects are
present, interactive mode presents a deterministic selector; non-interactive
mode requires an explicit project path. A supplied `.csproj` must exist and
must be a MAUI project.

## Global options

| Option | Description |
| --- | --- |
| `-h/--help` | Show command help. |
| `--version` | Show the CLI version. |
| `--interactive` | Allow prompts when running in an interactive terminal. |
| `--no-interactive` | Disable prompts. |
| `--json` | Emit machine-readable output. |
| `--verbose` | Write diagnostics to stderr. |
| `--no-color` | Disable colored output. |

## Exit codes

| Code | Meaning |
| --- | --- |
| `0` | Success. |
| `1` | Usage or operation error. |
| `70` | Unhandled internal error. |
| `130` | Cancelled by the user. |

## Native MAUI welcome and samples

Native app projects now open on a responsive welcome screen. Use `sf add maui --control <id> [id ...]` and `sf remove maui --control <id> [id ...]` to manage generated samples, navigation, and welcome buttons. `--template` is still supported. Supported package aliases integrate samples in CLI-generated projects; ordinary MAUI projects retain package-only behavior. Package removal cleans every tracked sample depending on that package. See [the welcome-screen guide](maui-welcome-screen.md) for ownership rules, conflicts, and validation.

## Package source and version policy

Syncfusion installs resolve the latest stable release from nuget.org and write
a concrete version. `--version` pins a release; `--source` accepts only the
official nuget.org URL. Local NuGet configuration cannot override the CLI feed.
See [package policy](nuget-package-policy.md) for behavior and verification.

### WinUI control templates

WinUI offers DataGrid (`datagrid`), Charts (`chart`), TreeGrid (`treegrid`),
Ribbon (`ribbon`) and DockingManager (`docking-manager`). All start unchecked in
interactive creation. Each selected control generates its own XAML page and
code-behind; data-driven samples also include a view model. Controls stretch to
available space and use the default theme. The Charts sample contains 12 monthly
sales points; DataGrid has 50 editable orders and eight columns; TreeGrid has
three teams with 21 employees. Ribbon commands edit the sample document, and
DockingManager demonstrates docked tools and a document pane.

```sh
sf new winui --name MyWinUIApp --control datagrid chart treegrid ribbon docking-manager
sf add winui ribbon --path ./MyWinUIApp/MyWinUIApp.csproj
sf update winui chart --path ./MyWinUIApp/MyWinUIApp.csproj
```

The existing `chart` alias remains valid. DataGrid and TreeGrid share
`Syncfusion.Grid.WinUI`; use a control alias when adding a sample. Managed CLI
projects receive sample files and welcome/navigation changes through `sf add`;
`sf update` preserves source edits and aligns managed dependency versions.
Unmanaged projects receive package-reference changes only. Public removal is
temporarily disabled. Native XAML compilation and runtime checks require Windows.

### Platform help layout

`sf help <platform>` uses **Available package aliases:** with alphabetically
sorted, content-sized columns. The column count follows terminal width; narrow
terminals stack or wrap aliases, and redirected output uses a stable 120-column
layout. MAUI help omits the former Controls section; its multi-control example
uses the available DataGrid and ListView samples.

Each footer option has a separate flag/description row, grouped under
existing-project package options, package operation options and project target
framework. Descriptions wrap with consistent indentation. `--force` appears only
for MAUI, where supported; `-t` is identified as the .NET target framework option.

### Commands after project creation

Successful creation prints a copyable **Next commands** block for every platform:

- Generate only: `cd`, build, run.
- Build project: `cd`, run. Modern desktop/Blazor run commands use `--no-build`.

Commands name the generated project explicitly, use its C#/VB extension and quote
paths for the indicated shell. Windows desktop commands are PowerShell commands.
Legacy WPF/WinForms .NET Framework projects use `msbuild /restore` in a Visual
Studio Developer PowerShell and launch their `bin\Debug` executable directly.
Modern WPF, WinForms and WinUI projects use `dotnet build` / `dotnet run`.

MAUI commands use an explicit declared target: Windows on Windows, Mac Catalyst
on macOS, or Android on Linux. An explicit `--build-framework` takes precedence.
The SDK run command is `dotnet build -t:Run -f <target>`; this launch target may
perform an incremental build. Android requires an emulator/device; iOS run
commands select a simulator runtime on macOS. Native platform SDK prerequisites
still apply.

Blazor commands target the server project for hosted WebAssembly/Auto modes and
the standalone project for standalone WebAssembly. They never launch `.Client`
in a hosted application.

JSON creation output includes a `nextCommands` array after success. Dry runs and
rolled-back creations do not provide runnable completion steps. Existing MAUI
build-failure recovery keeps its rebuild instructions and does not claim the app
is ready to run. The CLI displays these commands; it does not execute them.
