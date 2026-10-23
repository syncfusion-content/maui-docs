---
layout: post
title: Installation of Syncfusion .NET CLI for .NET MAUI | Syncfusion®
description: Learn how to install, update, and uninstall the Syncfusion® .NET CLI (sf) global tool using the dotnet tool install command.
platform: MAUI
control: Syncfusion<sup>®</sup> .NET CLI
documentation: UG
---

# Installation of the Syncfusion<sup>®</sup> .NET CLI

The Syncfusion<sup>®</sup> .NET CLI is published as a .NET global tool with the package ID `Syncfusion.DotNet.CLI`. Install it globally with the [dotnet tool install](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install) command.

1. Open a terminal and run the following command. Add `--prerelease` while only preview versions are available.

    ```bash
    dotnet tool install -g Syncfusion.DotNet.CLI --prerelease
    ```

2. Verify the installation and print the CLI version.

    ```bash
    sf --version
    ```

## Update the CLI

To update the tool to the latest release, run the following command:

```bash
dotnet tool update -g Syncfusion.DotNet.CLI --prerelease
```

## Uninstall the CLI

To remove the tool, run the following command:

```bash
dotnet tool uninstall -g Syncfusion.DotNet.CLI
```

N> If the `sf` command is not found after installation, confirm that the .NET global tools directory is on your `PATH`. The .NET SDK prints the tool location at the end of a successful installation.