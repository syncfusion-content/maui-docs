---
layout: post
title: Getting started with DateTime Range Selector control | Syncfusion®
description: This section explains about the getting started with Syncfusion® MAUI Range Selector (SfDateTimeRangeSelector) control.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# Getting Started with .NET MAUI DateTime Range Selector

This section guides you through setting up and configuring a [DateTime Range Selector](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeRangeSelector.html) in your .NET MAUI application. Follow the steps below to add a basic DateTime Range Selector to your project.

To quickly get started with the .NET MAUI DateTime Range Selector, watch this video.

<style>#MAUIDateTimeRangeSelectorVideoTutorial{width : 90% !important; height: 350px !important }</style>
<iframe id='MAUIDateTimeRangeSelectorVideoTutorial' src='https://www.youtube.com/embed/QpaNVNcn7xc'></iframe>

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Sliders NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New .NET MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Sliders NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Sliders` to install the Syncfusion<sup>®</sup> .NET MAUI Sliders package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}

{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Sliders NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Sliders](https://www.nuget.org/packages/Syncfusion.Maui.Sliders/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, Open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

Make sure to add the namespace.

{% highlight csharp %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %} 

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file to use Syncfusion controls.

{% highlight csharp %}
builder.ConfigureSyncfusionCore();
{% endhighlight %} 

## Step 4: Import the DateTime Range Selector namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml tabtitle="xaml" %}
xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Sliders;
{% endhighlight %}
{% endtabs %}

## Step 5: Add the DateTime Range Selector component

Create an instance of the SfDateTimeRangeSelector and initialize it as follows:

{% tabs %}
{% highlight xaml %}
    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01" />
{% endhighlight %}

{% highlight C# %}
    SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
    rangeSelector.Minimum = new DateTime(2010, 01, 01);
    rangeSelector.Maximum = new DateTime(2018, 01, 01);
    rangeSelector.RangeStart = new DateTime(2012, 01, 01);
    rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
    content = rangeSelector;
{% endhighlight %}

{% endtabs %}

![Initialize RangeSelector](images/getting-started/initialize-slider.png)

You can download the DateTime Range Selector Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-datetime-range-selector)
