---
layout: post
title: Getting Started with .NET MAUI Masked Entry control | Syncfusion®
description: Learn about getting started with Syncfusion® .NET MAUI Masked Entry (SfMaskedEntry) control, its elements, and more.
platform: maui
control: MaskedEntry
documentation: ug 
keywords: mask, SfMaskedEntry, maskedentry
---

# Getting Started with .NET MAUI Masked Entry

This section guides you through setting up and configuring a [Masked Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) in your .NET MAUI application. Follow the steps below to add a basic Masked Entry to your project.

To quickly get started with the .NET MAUI Masked Entry, watch this video.

{% youtube "https://www.youtube.com/watch?v=yTbh1Jo95Vw" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next.**
3. Select the .NET framework version and click **Create.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI TreeView NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Make sure to add the namespace.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Masked Entry namespace
 
Add the following namespace in your XAML or C#.
 
{% tabs %}
{% highlight xaml %}
 
xmlns:editors="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"
 
{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Inputs; 

{% endhighlight %}
{% endtabs %}

## Step 5: Adding Mask to the Masked Entry

Initialize the [SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html) and set its `MaskType` property to define a mask format

{% tabs %}
{% highlight xaml %}

<editors:SfMaskedEntry WidthRequest="200" 
                       ClearButtonVisibility="WhileEditing" 
                       MaskType="Simple" 
                       Mask="00/00/0000" />

{% endhighlight %}
{% highlight C# %}

SfMaskedEntry maskedEntry = new SfMaskedEntry();
maskedEntry.WidthRequest = 200;
maskedEntry.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
maskedEntry.MaskType = MaskedEntryMaskType.Simple;
maskedEntry.Mask = "00/00/0000";
content = maskedEntry;

{% endhighlight %}
{% endtabs %}

![Simple mask in .NET MAUI Masked Entry.](maskedentry_images/net-maui-masked-entry-simple-mask.png)

You can download the Masked Entry Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/maui-maskedentry-samples)

N> You can refer to our [.NET MAUI Masked Entry](https://www.syncfusion.com/maui-controls/maui-masked-entry) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Masked Entry Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/MaskedEntry) that shows you how to render the Masked Entry in .NET MAUI.