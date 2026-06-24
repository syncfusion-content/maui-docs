---
layout: post
title: Getting Started with .NET MAUI Rating control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Rating (SfRating) control, its elements and more.
platform: maui
control: Rating
documentation: ug
---

# Getting Started with .NET MAUI Rating

This section explains how to configure a [Rating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html) control in a real-time scenario and also provides a walk-through on some of the customization features available in SfRating control.

To quickly get started with the .NET MAUI Rating, watch this video.

{% youtube "https://www.youtube.com/watch?v=yEJzdjPNjBs" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a New MAUI Project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are in place:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a New MAUI Project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET:New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Inputs` to install the Syncfusion<sup>®</sup> .NET MAUI Inputs package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a New MAUI Project

1. Go to **File > New Solution,** Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Inputs NuGet Package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

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

## Step 4: Import Rating namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}

xmlns:rating="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Inputs;

{% endhighlight %}
{% endtabs %}

## Step 5: Add the Rating component

{% tabs %}
{% highlight xaml %}

<rating:SfRating x:Name="rating" />
	
{% endhighlight %}
{% highlight C# %}

SfRating rating = new SfRating();
this.Content = rating;

{% endhighlight %}
{% endtabs %}

![SfRating Getting Started ](images/getting-started.png)

You can download the Rating Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/maui-rating-samples)
