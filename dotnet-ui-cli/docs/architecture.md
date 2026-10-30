# Architecture

This document describes the current .NET CLI structure. MAUI, Blazor, WPF,
WinForms and WinUI have separate implementations.

## Solution layout

```text
src/
├─ Syncfusion.DotNet.Cli/             Executable, command handling, and user interaction
├─ Syncfusion.DotNet.Cli.Core/        Platform-neutral contracts and helpers
├─ Syncfusion.DotNet.Cli.Maui/       MAUI catalogs, project workflows, and templates
├─ Syncfusion.DotNet.Cli.Blazor/     Blazor templates, catalogs, validation and generation
├─ Syncfusion.DotNet.Cli.WPF/        WPF generation, controls and themes
├─ Syncfusion.DotNet.Cli.WinForms/   WinForms generation, controls and themes
└─ Syncfusion.DotNet.Cli.WinUI/      WinUI generation and native controls
tests/
└─ Syncfusion.DotNet.Cli.Tests/       CLI, MAUI and desktop behavior tests
```

Repository-wide SDK, package, and style settings are kept at the root in
`global.json`, `Directory.Build.props`, `Directory.Packages.props`, and
`.editorconfig`.

## Project responsibilities

### Syncfusion.DotNet.Cli

The executable owns command-line concerns and dispatches implemented workflows
to MAUI or the shared desktop adapter:

- `Program.cs` and `Hosting/` create the application, wire cancellation, and
  compose the `System.CommandLine` command tree.
- `Commands/` contains command definitions. `Commands/Actions/` contains
  root-level actions; `Options/`, `Parsing/`, `Operations/`, and `Reporting/`
  contain command support by responsibility.
- `Wizard/` owns the interactive menu and prompts. It collects the same
  request data as direct commands and uses the same operation services.
- `Presentation/` owns console output and request previews; it does not own
  interactive navigation.

Platform routing uses the existing Framework enum and registry. The desktop
adapter contains parsing/presentation; each desktop provider owns its control,
source and theme decisions. Shared orchestration lives in Core/Desktop.
Blazor command handling delegates official template orchestration and all
Blazor-specific validation to the Blazor assembly, while reusing shared
presentation and transactional package services.

### Syncfusion.DotNet.Cli.Core

Core contains shared contracts and utilities and has no MAUI dependency.
`Commands/` contains requests, global options, and command-related values;
`IO/` contains path and file helpers; `Metadata/` contains product metadata;
and `NuGet/` contains shared package-operation arguments and process execution.
Only code that is independent of MAUI, Blazor, WinUI, and WPF belongs here.

### Syncfusion.DotNet.Cli.Blazor

The Blazor platform layer owns application/render-mode models, installed
template capability discovery, the Syncfusion package/theme/component catalog,
Razor demo sources, official `dotnet new` orchestration, and its manifest.
WebAssembly and Auto demos are written to the generated client project. Shared
Core services provide project detection, package operations, rollback, and
process execution without embedding Blazor UI policy in Core.

### Syncfusion.DotNet.Cli.Maui

The MAUI project references Core and contains all MAUI-specific behavior:

- `Catalog/` contains separate curated package and template metadata. A
  catalog is descriptive data; it is not a package-operation service.
- `Discovery/` reads catalogs and project state for `list`, `search`, and
  `info`; discovery does not mutate projects.
- `Packages/PackageOperationService` executes package-only actions. These
  actions change package references without generating template files.
- `Manifest/` owns the serialized record of files, packages, and templates
  managed by the CLI.
- `Injection/` owns the MAUI registration patcher.
- `Projects/` detects and resolves MAUI projects and scaffolds new projects.
- `Execution/` contains the MAUI `dotnet` process runner.
- `TemplateResources/` loads embedded resources and resolves template paths.
- `Templates/Controls/` contains the source files copied into generated apps.
  These are text templates, not compiled CLI code.

Template actions are distinct from package actions: template installation also
tracks generated files, package dependencies, and MAUI registration in the
project manifest. `ControlInstaller` coordinates that workflow and currently
resides in `Packages/`; its responsibilities span packages and templates.
Extracting it into smaller workflow services requires focused behavior tests
and is tracked separately from this structural organization. There is no
generic `Pipeline/` abstraction: the MAUI workflow is explicitly orchestrated
and uses `FileRollback` for changes that need rollback.

### Tests and maintenance tools

`Syncfusion.DotNet.Cli.Tests` covers command parsing, direct and interactive
behavior, Core architecture boundaries, catalogs, package workflows, and
template lifecycle behavior. Test count is not a cleanup criterion; remove a
test only when it duplicates coverage or protects behavior that no longer
exists.

`tools/catalog-audit/` is a read-only maintainer utility for checking curated
package metadata against NuGet search evidence. It does not rewrite the
production catalogs.

`.github/workflows/desktop-validation.yml` builds the CLI and generates,
builds and launches advertised desktop configurations on Windows. Run the full
CLI regression suite locally as well, including MAUI and live-terminal tests.

## Command flow

`Program.Main` handles Ctrl+C and passes cancellation to the CLI. `CliApp`
builds and runs the command tree. Direct commands and the interactive wizard
collect input, validate it into shared request types, call the same operation
services, and report text or JSON through the presenter. Core owns shared
contracts. MAUI and the three desktop provider assemblies implement operations.

## Dependencies

- [System.CommandLine](https://github.com/dotnet/command-line-api) (2.0.x) for
  command parsing and the built-in `--help`/`--version` options.
- A small in-house console prompt for the interactive menu. No third-party console UI package is required.
- [xUnit](https://xunit.net/) for tests.
- Central package management via `Directory.Packages.props`.

## Design decisions

### Command construction is separate from presentation

`CliApp` builds the command tree and binds options. `ConsolePresenter` owns
console output, while `Wizard` owns interactive navigation and prompts. This
keeps command handlers testable without a real terminal.

### Version is sourced from assembly metadata

`CliMetadata.Version` reads `AssemblyInformationalVersionAttribute` from the
Core assembly. The version is set once in `Directory.Build.props` so every
assembly reports the same value. The built-in `--version` action is replaced
with the root `VersionAction` so the printed version always reflects the CLI,
not the host process (important for in-process tests).

### Cancellation maps to exit code 130

`Program.Main` wires `Console.CancelKeyPress` to a `CancellationTokenSource`
and passes the token to `CliApp.RunAsync`. System.CommandLine swallows
`OperationCanceledException` and returns a generic error; `CliApp.RunAsync`
detects the cancelled token and returns `ExitCodes.Cancelled` (130) instead,
so Ctrl+C exits safely and predictably.

### Minimal interactive UI

The menu uses a plain in-house selection prompt with one dim accent, no
borders, icons, or animation. Non-interactive terminals (piped input or
output) fall back to a help hint.

### Direct and interactive command paths

Each command exposes a pure static `Parse(ParseResult)` used by tests and the
non-interactive path, and a `Build(ParseResult, GlobalOptions)` that layers
interactive completion on top. Missing required values are prompted for only
when `InteractivePrompt.CanPrompt` is true (interactive terminal and not
`--no-interactive`); otherwise a clear validation error is returned.

`FrameworkResolver` centralizes the framework rule: the positional argument
and the `-f/--framework` option are mutually exclusive, with a single shared
error message. `CommandPreview` renders the equivalent direct command for any
request, quoting values that contain spaces, so interactive completion can
show users the command they are confirming.

Global options are added to every subcommand in `CliApp` because
System.CommandLine 2.0 does not inherit root options into subcommands.

### Warnings as errors, deterministic builds

`Directory.Build.props` enables `Nullable`, `ImplicitUsings`,
`Deterministic`, and `TreatWarningsAsErrors` for repository-owned code.
Test projects opt out of `TreatWarningsAsErrors` so analyzer noise does not
block the test build.

### Catalogs, templates, and package operations

The embedded package catalog contains curated official `Syncfusion.Maui.*`
package records independent of the smaller template catalog. Package
records define canonical aliases, package IDs, classification, status,
recommendation, registration requirements, and version strategies.
Unresolved metadata is explicitly marked; interactive package selection uses
the catalog's `recommended` flag without inferring package quality or
availability. Explicit arguments can address every package. The template catalog separately records
operable concrete control templates, their required package, resources, and
template-specific registration metadata. Package operations never consult the
template catalog; template operations require explicit `--template` routing.

The read-only `tools/catalog-audit/audit_package_catalog.py` maintainer script
pages through NuGet SearchQueryService metadata and reports differences and
entries for review. NuGet search is advisory evidence only; the script never
rewrites either production catalog.

Templates are plain text (XAML/C#) with five fixed placeholders
(`__PROJECT_NAME__`, `__ROOT_NAMESPACE__`, `__CONTROL_NAME__`, `__VIEW_NAME__`,
`__VIEW_MODEL_NAME__`). `PlaceholderReplacer` substitutes only those tokens;
there is no template language. `TemplatePathResolver` computes destination
paths and embedded resource names from the catalog entries.

`Syncfusion/syncfusion.json` is the manifest the CLI writes next to the
project. It tracks the CLI version, framework, project type, target
framework, installed controls, package ids and versions, generated
files, modified files, and the SHA-256 hashes of generated files at write
time. The hashes let `update` detect customer edits and preserve them unless
`--force` is supplied, and let `remove` and the shared-package/registration
retention logic know what the CLI owns.

`ControlInstaller` ties the pieces together with `FileRollback` for
transactional safety: created files are deleted and modified files are
restored when an operation fails mid-flight, so the project is never left in
a partially updated state. `NuGetRunner` shells out to the official
`dotnet add|remove package` commands, enforcing nuget.org while honoring `--configfile`,
`--no-restore`, and `--dry-run`, and never modifies NuGet configuration or
stores credentials.

### Project scaffolding, update, discovery, and `--json`

`NewProjectScaffolder` implements the `sfdotnet new maui` flow by composing the
native `dotnet new maui`/`maui-blazor` template with the `ControlInstaller`
add flow, `MauiProgramPatcher` registration injection, and manifest writing.
Created projects retain native MAUI appearance. MAUI Blazor Hybrid is a MAUI
project type (`--project-type blazor-hybrid`), not a separate platform or
NuGet package.

`ControlInstaller.ExecuteUpdateAsync` updates the package to the requested
version (or latest when omitted), compares current generated-file hashes with
the manifest hashes, preserves modified CLI-owned files by default, and
requires `--force` to replace them. The manifest is updated only after a
successful update.

`DiscoveryService` powers `sfdotnet list` (packages, installed, and templates),
`sfdotnet search` (case-insensitive across id, display name, alias, package id, and
description), and `sfdotnet info` (CLI/package metadata only — never duplicates
`dotnet --info`). `list`, `search`, and `info` emit stable JSON to stdout
when `--json` is set, with diagnostics on stderr.

## Desktop providers

`Syncfusion.DotNet.Cli.WPF`, `.WinForms` and `.WinUI` own their catalogs, themes,
language-specific source generation and initialization APIs. Core/Desktop owns
transactional creation, project format helpers, process execution and package-only
operations. The CLI DesktopCommands adapter reuses existing input, layout,
progress and reporting components. Desktop manifests are separate from MAUI
manifests. MAUI workflows remain in the existing MAUI implementation.

See [desktop configurations](desktop-platforms.md) for project formats,
prerequisites and the distinction between static tests, builds and runtime checks.
