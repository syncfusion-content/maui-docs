---
layout: post
title: Install Syncfusion® MAUI NuGet Packages - Syncfusion®
description: Learn how to install Syncfusion® MAUI NuGet packages from the Package Manager and NuGet Manager.
platform: MAUI
component: Common
documentation: UG
---

# Install Syncfusion<sup>®</sup> MAUI NuGet Packages

**NuGet** is a package management system for Visual Studio that allows you to easily add, update, and remove external libraries in your application. Syncfusion<sup>®</sup> publishes all MAUI NuGet packages on [nuget.org](https://www.nuget.org/packages?q=Tag%3A%22Maui%22+Syncfusion). The Syncfusion<sup>®</sup> MAUI NuGet packages can be used without installing the Syncfusion<sup>®</sup> installation. You can simply exploit the Syncfusion<sup>®</sup> MAUI NuGet packages in your MAUI application to develop with the Syncfusion<sup>®</sup> MAUI components.

## Installation using package manager UI

The NuGet **Package Manager UI** allows you to search, install, uninstall, and update Syncfusion<sup>®</sup> MAUI NuGet packages in your applications and solutions. You can find and install the Syncfusion<sup>®</sup> MAUI NuGet packages in your Visual Studio MAUI application and this process is easy with the steps below:

1. Right-click on the MAUI application or solution in the `Solution Explorer`, and choose **Manage NuGet Packages...**

    ![Manage NuGet packages add-in](images/ManageNuGet.png)

    Alternatively, after opening the MAUI application in Visual Studio, go to the **Tools** menu, hover over **NuGet Package Manager**, and select **Manage NuGet Packages for Solution...**

2. The Manage NuGet Packages window will open. Navigate to the **Browse** tab, then search for the Syncfusion<sup>®</sup> MAUI NuGet packages using a term like **"Syncfusion<sup>®</sup> Maui"** and select the appropriate Syncfusion<sup>®</sup> MAUI NuGet package for your development.

    N> The [nuget.org](https://api.nuget.org/v3/index.json) package source is selected by default in the Package source drop-down. If your Visual Studio does not have nuget.org configured, follow the instructions in the [Microsoft documents](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio#package-sources) to set up the nuget.org feed URL.

    ![MAUI NuGet packages search](images/NuGetsearch.png)

3. When you select a MAUI package, the right side panel will provide more information about it.

4. By default, the latest version of the package is selected. You can choose the required version and click the **Install** button and accept the license terms. The package will be added to your MAUI application.

    ![MAUI NuGet packages install](images/InstallNuGet.png)

5. At this point, your application has all the required Syncfusion<sup>®</sup> assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion<sup>®</sup> MAUI components](https://www.syncfusion.com/maui-controls). Also, you can refer to the [MAUI help document](https://help.syncfusion.com/maui/introduction/overview) for development.

## Installation using Dotnet (.NET) CLI

The [dotnet Command Line Interface (CLI)](https://learn.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli), allows you to add, restore, pack, publish, and manage packages without making any changes to your application files. [Dotnet add package](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package?tabs=netcore2x) adds a package reference to the application file, then runs [dotnet restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x) to install the package.

Follow the below instructions to use the dotnet CLI command to install the Syncfusion<sup>®</sup> MAUI NuGet packages.

1. Open a command prompt and navigate to the directory of your MAUI application file.
2. To install a NuGet package, run the following command.

    ```dotnet add package <Package name>```

    **For Example:**
    dotnet add package Syncfusion.Maui.Core

    N> If you don’t provide a version flag, this command will be upgrading to the latest version by default. To specify a version, add the -v parameter: dotnet add package Syncfusion.Maui.Core -v 24.1.45.

3. Examine the MAUI application file after the command has completed to ensure that the Syncfusion<sup>®</sup> MAUI package was installed. To see the added reference, open the .csproj file.

    ![MAUI package entry ](images/packageentry.png)

4. Run [dotnet restore](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x) command to restore all the packages listed in the application file.

5. At this point, your application has all the required Syncfusion<sup>®</sup> assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion<sup>®</sup> MAUI components](https://www.syncfusion.com/maui-controls). Also, you can refer to the [MAUI help document](https://help.syncfusion.com/maui/introduction/overview) for development.

## Installation using Package Manager Console

The **Package Manager Console** saves NuGet packages installation time since you don't have to search for the Syncfusion<sup>®</sup> MAUI NuGet package which you want to install, and you can just type the installation command to install the appropriate Syncfusion<sup>®</sup> MAUI NuGet package. Follow the instructions below to use the Package Manager Console to reference the Syncfusion<sup>®</sup> MAUI component as NuGet packages in your MAUI application.

1. To show the Package Manager Console, open your MAUI application in Visual Studio and navigate to **Tools -> NuGet Package Manager -> Package Manager Console**.

    ![Package Manager Console ](images/console.png)

2. The **Package Manager Console** will be shown at the bottom of the screen. You can install the Syncfusion<sup>®</sup> MAUI NuGet packages by entering the following NuGet installation commands.

    ***Install specified Syncfusion<sup>®</sup> MAUI NuGet package.***

    The following command will install the Syncfusion<sup>®</sup> MAUI NuGet package in the default MAUI application.

    ```Install-Package <Package Name>```

    **For example:** Install-Package Syncfusion.Maui.Grid

    N> You can find the list of Syncfusion<sup>®</sup> MAUI NuGet packages which are published in nuget.org from [here](https://www.nuget.org/packages?q=Tags%3A%22Maui%22+syncfusion)

    ***Install specified Syncfusion<sup>®</sup> MAUI NuGet package in specified MAUI application***

    The following command will install the Syncfusion<sup>®</sup> MAUI NuGet package in the given MAUI application.

    ```Install-Package <Package Name> - ProjectName <Project Name>```

    **For example:** Install-Package Syncfusion.Maui.Grid -ProjectName SyncfusionMauiApp

3. By default, the package will be installed with latest version. You can give the required version with the -Version term like below to install the Syncfusion<sup>®</sup> MAUI NuGet packages in the appropriate version.

    ```Install-Package Syncfusion.Maui.Core -Version 24.1.45```

    ![Package Manager Console output ](images/ConsoleInstallationOutput.png)

4. The NuGet package manager console will install the Syncfusion<sup>®</sup> MAUI NuGet package as well as the dependencies it has. When the installation is complete, the console will show that your Syncfusion<sup>®</sup> MAUI package has been successfully added to the application.

5. At this point, your application has all the required Syncfusion<sup>®</sup> assemblies, and you will be ready to start building high-performance, responsive app with [Syncfusion<sup>®</sup> MAUI components](https://www.syncfusion.com/maui-controls). Also, you can refer to the [MAUI help document](https://help.syncfusion.com/maui/introduction/overview) for development.