---
layout: post
title: Getting started with .NET MAUI Date Picker control | Syncfusion®
description: Learn about getting started with Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Getting started with .NET MAUI Date Picker

This section explains how to add the [.NET MAUI Date Picker](https://www.syncfusion.com/maui-controls/maui-datepicker) control. It covers only the basic features needed to get started with the Syncfusion<sup>&reg;</sup> Date Picker. Follow the steps below to add a .NET MAUI Date Picker control to your project.

To get start quickly with our .NET MAUI Date Picker, you can check the below video.

{% youtube "youtube:https://youtu.be/PeQf-5pPCWo?si=KlwcdMcLN634G_AA" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project, choose a location, and then click **Next**.
3. Select the .NET version (.NET 9 or later is recommended) and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Picker NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>P</kbd> and type **.NET: New Project**, and then press <kbd>Enter</kbd>.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press <kbd>Enter</kbd>.
4. Choose **Create project**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Picker NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you are in the project root directory where your `.csproj` file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Picker` to install the Syncfusion<sup>&reg;</sup> .NET MAUI Picker NuGet package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)** and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET version (.NET 9 or later is recommended) and click **Create**.

## Step 2: Install the Syncfusion<sup>&reg;</sup> MAUI Picker NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly and the project is restored. If not, open the Terminal in Rider and manually run `dotnet restore`.

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler
 
Make sure to add the namespace.

{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}

Register the Syncfusion<sup>&reg;</sup> core handler in the `CreateMauiApp` method of the `MauiProgram.cs` file to enable Syncfusion<sup>&reg;</sup> controls.

{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Date Picker namespace

Add the following namespace declaration in XAML, and the matching `using` directive in C#.

{% tabs %}
{% highlight xaml %}
xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Picker;
{% endhighlight %}
{% endtabs %}

## Step 5: Add the Date Picker control

Create an instance of the Date Picker control and add it to your page.

{% tabs %}
{% highlight xaml tabtitle="XAML" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">

    <picker:SfDatePicker />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker picker = new SfDatePicker();
this.Content = picker;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

![Set Height and width in .NET MAUI Date picker.](images/getting-started/maui-date-picker-set-height-and-width.png)

You can download the Date Picker Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/dotnet-maui-datepicker-sample).
