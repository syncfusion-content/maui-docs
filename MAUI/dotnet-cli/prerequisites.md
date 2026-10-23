---
layout: post
title: Prerequisites for Syncfusion .NET CLI for .NET MAUI | Syncfusion®
description: Describes the software requirements needed before you install and use the Syncfusion® .NET CLI (sf) to create .NET MAUI projects.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Prerequisites

The following software is required before you install and use the Syncfusion<sup>®</sup> .NET CLI for .NET MAUI projects.

* [.NET SDK](https://dotnet.microsoft.com/download). Project creation runs `dotnet new` and package restore through the SDK. The SDK selected through `PATH` takes precedence, with the running .NET installation as a fallback.
* The **.NET Multi-platform App UI development** workload, installed through Visual Studio or the [dotnet workload](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-workload-install) commands.
* The .NET MAUI project templates, which are installed with the MAUI workload. The CLI creates .NET MAUI projects through the installed `maui` template.
* An internet connection so package operations can reach `https://api.nuget.org/v3/index.json`.

N> The CLI resolves Syncfusion<sup>®</sup> packages from the official nuget.org feed only. Local NuGet configuration cannot override the CLI feed.

## Target frameworks

The .NET MAUI project template supports the following .NET versions:

| Target framework | Value |
| --- | --- |
| .NET 10 | `net10.0` (default) |
| .NET 9 | `net9.0` |

N> Installed template and workload compatibility is checked separately during project creation. A missing workload appears as a build error after the project files are generated.

## Native platform requirements

Building and running a .NET MAUI app requires the platform-specific tools for each target:

* Windows apps require Windows.
* Mac Catalyst apps require macOS.
* Android builds require the Android workload. Running an Android app requires an emulator or a connected device.
* iOS builds require Xcode on macOS, with a simulator runtime selected.

## Licensing

Syncfusion<sup>®</sup> licensing requirements continue to apply to generated projects. The CLI does not create or embed a license key. To register a license key in your project, refer to the [Syncfusion licensing](../licensing/overview.md) documentation.