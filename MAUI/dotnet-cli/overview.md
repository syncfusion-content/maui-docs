---
layout: post
title: Overview of Syncfusion .NET CLI for .NET MAUI | Syncfusion®
description: An overview of the Syncfusion .NET CLI (sf), a command line tool to create .NET MAUI projects and manage Syncfusion MAUI NuGet package references.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Overview of the Syncfusion<sup>®</sup> .NET CLI

The Syncfusion<sup>®</sup> .NET CLI (`sf`) is a cross-platform command line tool that creates .NET MAUI projects and manages Syncfusion<sup>®</sup> .NET MAUI NuGet package references from a terminal. After you install the tool, run `sf` with no arguments to open an interactive menu, or run a direct command such as `sf new maui` for scripted, prompt-free creation.

N> The Syncfusion<sup>®</sup> .NET CLI is currently in preview and is installed with the `--prerelease` flag.

You can use the CLI to perform the following actions:

* Create a blank .NET MAUI app or an app that contains generated Syncfusion<sup>®</sup> control samples.
* Add, update, or remove Syncfusion<sup>®</sup> .NET MAUI NuGet package references in an existing project.
* List available and installed packages, and search the package catalog.
* Generate projects for .NET MAUI, Blazor, WPF, WinForms, and WinUI 3.

N> Package removal (`sf remove`) is temporarily disabled across all platforms while improvements are in progress. The `sf remove` forms document the preserved implementation and are currently unavailable.

## Command synopsis

```text
sf <action> <platform> <target> [options]
```

`<platform>` is `maui` for .NET MAUI. The other supported platforms are `blazor`, `wpf`, `winforms`, and `winui`. Run `sf help` for the concise command list, or `sf help maui` for the .NET MAUI command map.

## Related sections

* [Prerequisites](prerequisites.md)
* [Installation](installation.md)
* [Initialize the CLI](initialize-the-cli.md)
* [Available commands](available-commands.md)
* [Create a .NET MAUI project](create-a-maui-project.md)
* [Manage packages in an existing project](manage-packages.md)
* [Platform and .NET version selection](platform-and-dotnet-version-selection.md)
* [Troubleshooting](troubleshooting.md)