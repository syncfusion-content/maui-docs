---
layout: post
title: Download and Setup in .NET MAUI Extension | Syncfusion®
description: Learn here more about how to download, install, and configure the Syncfusion® .NET MAUI Extension in JetBrains Rider.
platform: MAUI
component: Common
documentation: ug
---

# Download and Setup Guide

Before developing Syncfusion<sup>®</sup> .NET MAUI applications in JetBrains Rider, ensure that the required software and .NET MAUI development tools are installed and configured properly.

## Prerequisites

The following software must be installed to develop Syncfusion<sup>®</sup> .NET MAUI applications in JetBrains Rider:

* [JetBrains Rider 2025.1 or later](https://www.jetbrains.com/rider/)

* [.NET 9.0 or later SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

## Install JetBrains Rider

The following steps illustrate how to download and install JetBrains Rider.

1. Download JetBrains Rider from the official [JetBrains](https://www.jetbrains.com/rider/) website.

2. Run the installer and complete the installation process.

3. Launch JetBrains Rider after the installation is complete.

## Configure .NET MAUI Support

The following steps will guide you through configuring .NET MAUI support in JetBrains Rider.

1. Install the required .NET SDK version.

2. Open a terminal and install the .NET MAUI workload using the following command:

   ```bash
   dotnet workload install maui
   ```

3. Restart JetBrains Rider if it is already running.

4. Verify that the **.NET MAUI Application** template is available when creating a new solution.

## Additional Platform Requirements

Depending on the target platform, install the following components:

* Android SDK and Android Emulator for Android application development.

* Xcode on macOS for iOS and Mac Catalyst application development.

## Verify Installation

1. Open JetBrains Rider and click **New Solution**.

2. Select the **.NET MAUI Application** template.

3. Create a new .NET MAUI project.

4. Build and run the application to verify that the development environment is configured successfully.

After completing these steps, you can start developing Syncfusion® .NET MAUI applications in JetBrains Rider and add the required Syncfusion® NuGet packages to your projects.
