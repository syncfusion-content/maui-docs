---
layout: post
title: Available Commands in Syncfusion .NET CLI | Syncfusion®
description: A reference of all Syncfusion® .NET CLI (sf) commands, options, and exit codes for .NET MAUI project creation and package management.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Available commands

The following table lists the commands available for .NET MAUI. `<platform>` is `maui`.

| Command | Purpose |
| --- | --- |
| `sf new maui` | Create a new .NET MAUI project |
| `sf add maui <package>` | Add a Syncfusion<sup>®</sup> package to an existing project |
| `sf remove maui <package>` | Remove a package (temporarily disabled) |
| `sf update maui <package>` | Update a package in an existing project |
| `sf list maui packages` | List available packages |
| `sf list maui installed` | List installed packages in an existing project |
| `sf search maui <text>` | Search package aliases, IDs, display names, and descriptions |
| `sf info` | Show CLI information |
| `sf help maui` | Show the .NET MAUI command map and package aliases |
| `sf --version` | Show the CLI version |

N> The target-first argument forms, such as `sf add datagrid maui`, `sf list packages maui`, and `sf search datagrid maui`, remain supported for backward compatibility and use the same operations.

## Creation options

| Option | Description |
| --- | --- |
| `-n`, `--name` | Project name. Required when prompting is unavailable |
| `-p`, `--path` | Parent directory. Defaults to the current directory |
| `-t`, `--target-framework` | The .NET target framework, such as `net10.0` |
| `--control` | One or more control IDs, or `empty`. Omit to create an empty project |
| `--project-type` | The .NET MAUI project type: `app` |
| `--post-action` | Post-create action: `generate` or `build`. Defaults to `build` for direct commands |
| `--build-framework` | Build only this configured project target, such as `net10.0-android`. Defaults to all configured targets |
| `--template` | Hidden compatibility alias for `--control` |
| `--force` | Allow supported overwrites. Edited control samples remain protected |
| `--dry-run` | Preview the action without making changes |
| `--no-restore` | Skip `dotnet restore` after the action |
| `--no-build` | Skip `dotnet build` after the action |
| `--version`, `-v` | The Syncfusion<sup>®</sup> NuGet package release |
| `--source` | Package source. Syncfusion<sup>®</sup> packages require `https://api.nuget.org/v3/index.json` |
| `--configfile` | The NuGet configuration file to use |

N> The obsolete `--theme` input fails with a migration message and does not create or modify a project. .NET MAUI projects use the native MAUI appearance and the platform light and dark behavior.

## Existing-project options

Package operations accept `-p/--path`, with a project file, project directory, or supported subdirectory. Without it, the current directory is used.

| Option | Description |
| --- | --- |
| `-p`, `--path` | Project file, project directory, or supported subdirectory |
| `-v`, `--version` | Pin a specific package release |
| `--source` | Package source |
| `--configfile` | NuGet configuration file |
| `--dry-run` | Preview without writing changes |
| `--no-restore` | Skip restore after the action |
| `--build-framework` | Build only this enabled target |

## Global options

| Option | Description |
| --- | --- |
| `-h`, `--help` | Show command help |
| `--version` | Show the CLI version |
| `--interactive` | Allow prompts when running in an interactive terminal |
| `--no-interactive` | Disable prompts |
| `--json` | Emit machine-readable output |
| `--verbose` | Write diagnostics to stderr |
| `--no-color` | Disable colored output |

## Exit codes

| Code | Meaning |
| --- | --- |
| `0` | Success |
| `1` | Usage or operation error |
| `70` | Unhandled internal error |
| `130` | Cancelled by the user |