---
layout: post
title: Platform and .NET Version Selection in the Syncfusion .NET CLI | Syncfusion®
description: Describes how platform, project template, .NET version, and build target selection work in the Syncfusion® .NET CLI (sf) for .NET MAUI projects.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Platform and .NET version selection

## Platform selection

The CLI supports `maui`, `blazor`, `wpf`, `winforms`, and `winui` platforms. This documentation covers the .NET MAUI (`maui`) platform.

Actions that need a platform ask for the platform first. In a direct command, the platform is the positional argument or the `--framework/-f` option:

```bash
sf new maui -n MyApp
sf new -n MyApp --framework maui
```

Information (`sf info`) and general help (`sf help`) do not ask for a platform.

## Project template selection

.NET MAUI offers the **.NET MAUI App** template (`--project-type app`). It is the only enabled template and is recorded automatically in the wizard without a picker. Blazor Hybrid creation is temporarily disabled.

## .NET version selection

The .NET MAUI template supports the following .NET versions:

* .NET 10 (`net10.0`), the default
* .NET 9 (`net9.0`)

In the wizard, the framework step selects the base .NET version. The framework menu does not select Android, iOS, Windows, or Mac Catalyst individually. Installed template and workload compatibility is checked separately.

```bash
sf new maui -n MyApp --target-framework net9.0
```

## Build target selection

A .NET MAUI project declares multiple platform targets, such as `net10.0-android` and `net10.0-windows`. By default, builds run `dotnet build "<project.csproj>"` for all configured targets. Use `--build-framework` to build one enabled target:

```bash
sf new maui -n MyApp --build-framework net10.0-android --post-action build
sf add maui datagrid --path ./MyApp --build-framework net10.0-windows
```

`--build-framework` is validated against MSBuild's evaluated project targets on the current OS and passed to `dotnet build` through `-f`. It requires a build action.

N> `--framework/-f` selects the CLI platform, and `--target-framework/-t` selects the .NET version. Neither implicitly narrows a build. `--build-framework` selects the platform build target.

## Wizard input and command equivalents

Every wizard input has a command equivalent:

| Wizard input | Argument or default |
| --- | --- |
| Platform | `maui` or `--framework maui` |
| Project template | `--project-type app` (only enabled template) |
| Framework | `--target-framework net10.0` (default) |
| Project name | `--name MyApp`; required when prompting is unavailable |
| Parent directory | `--path <directory>`; defaults to the current directory |
| Setup and controls | `--control empty` or one or more control IDs |
| Post-creation action | `--post-action generate` or `build`; direct commands default to `build` |
| Optional build target | `--build-framework <TFM>`; defaults to all configured targets |

## Non-interactive and JSON output

Add `--no-interactive` to disable prompts. Required values must then be supplied as options. `--json` emits machine-readable output and never opens the wizard. JSON creation output includes `generationSucceeded`, `buildSucceeded`, `rolledBack`, errors, and a `nextCommands` array after success. Dry runs and rolled-back creations do not provide runnable completion steps.