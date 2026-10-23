---
layout: post
title: Manage Packages using the Syncfusion .NET CLI | Syncfusion®
description: Learn how to add, update, list, and search Syncfusion® .NET MAUI NuGet packages in an existing project using the sf CLI.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Manage packages in an existing project

Package operations change NuGet references only. They do not generate control files.

`<package>` accepts a canonical package alias, a canonical package ID, or an exact unambiguous package display name. Canonical aliases are case-insensitive and are shown by `sf list maui packages` and `sf help maui`.

```bash
sf add maui datagrid
sf add maui inputs
sf add maui Syncfusion.Maui.DataGrid
sf update maui datagrid
```

## Add a package

In a CLI-generated project, supported package aliases also integrate their samples. `sf add maui datagrid` adds the DataGrid package and integrates the DataGrid sample, and `sf add maui inputs` adds the Inputs package and integrates the ComboBox sample.

```bash
sf add maui datagrid -p ./MyApp
```

In an ordinary .NET MAUI project, the same command adds the package reference only. The CLI reports that no sample was generated and prints the explicit sample command.

N> `--no-restore` keeps an add as a package operation because sample compatibility cannot be established without restore.

## Add generated samples

Use `--control` to add generated samples directly, with one or more control IDs:

```bash
sf add maui --control datagrid listview --path ./MyApp
sf add maui --control cartesian-chart circular-chart --path ./MyApp
```

`--template` remains a compatibility alias for `--control`. Do not combine them, or mix a positional package target with a control selection. Control-only aliases such as `combobox` can be positional.

Adding another control from an installed package generates its files and navigation without changing the existing reference or version. Package removal removes every tracked sample that depends on that package, along with its registry entry and owned navigation blocks.

N> Package removal (`sf remove`) is temporarily disabled across all platforms.

## Update a package

```bash
sf update maui datagrid -p ./MyApp
```

Package add and update resolve the latest stable release from nuget.org and write a concrete version. Use `--version` to pin a release.

## List and search packages

```bash
sf list maui packages
sf list maui installed -p ./MyApp
sf list maui packages --search grid
sf search maui grid
```

* `sf list maui packages` shows one `Alias`, `Name`, `NuGet` table of the available catalog. Interactive terminals paginate; redirected output and `--no-interactive` return the complete list.
* `sf list maui installed` shows `Alias`, `NuGet`, and `Version` columns for direct `Syncfusion.Maui.*` references in a project. Central `Directory.Packages.props` values are honored, and missing versions read `not specified`.
* `sf search maui <text>` searches aliases, IDs, display names, and descriptions, and returns package records only.
* Add `--details` for descriptions, release status, registration requirements, documentation links, and verification evidence. `--verbose` writes those details to stderr.

## Project resolution

`-p/--path` accepts a .NET MAUI `.csproj` path or a directory. A directory with one .NET MAUI project is selected automatically. When multiple projects are present, interactive mode presents a selector; non-interactive mode requires an explicit project path. Discovery stops at the nearest project or repository boundary.