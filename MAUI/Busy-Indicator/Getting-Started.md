---
layout: post
title: Getting Started with .NET MAUI Busy Indicator Control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Busy Indicator (SfBusyIndicator) control, its elements, and more.
platform: MAUI
control: SfBusyIndicator
documentation: UG
keywords : .net maui busy indicator, maui busy indicator, .net maui activity indicator, maui activity indicator, .net maui loading indicator, maui loading indicator.
---

# Getting Started with .NET MAUI Busy Indicator

This section guides you through setting up and configuring a [SfBusyIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) in your .NET MAUI application. Follow the steps below to add a basic Busy Indicator to your project.

To quickly get started with the .NET MAUI Busy Indicator, watch this video.

{% youtube "https://www.youtube.com/watch?v=EY1y5PUBkCw" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Then, click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1.  In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2.  Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3.  Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Core` to install the Syncfusion<sup>®</sup> .NET MAUI Core package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution,** Select .NET (C#) and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Core NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the terminal in Rider and manually run: `dotnet restore`.

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

## Step 4: Import the Busy Indicator namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Core;
{% endhighlight %}
{% endtabs %}

## Step 5: Add the Busy Indicator component

Create an instance for the Busy Indicator control. The [.NET MAUI Busy Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html?tabs=tabid-1) provides some predefined animation types like Cupertino, LinearMaterial, and CircularMaterial. Users can select any one of the animation types using the [AnimationType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType) property.

The following example depicts the CircularMaterial type animation of .NET  MAUI Busy Indicator.

{% tabs %}

{% highlight xaml %}
<core:SfBusyIndicator x:Name="busyIndicator"
                      IsRunning="True"
                      AnimationType="CircularMaterial">
</core:SfBusyIndicator>
{% endhighlight %}

{% highlight C# %}
SfBusyIndicator busyIndicator = new SfBusyIndicator()
{
    IsRunning = true,
    AnimationType = AnimationType.CircularMaterial;
};
{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![CircularMaterial in .NET MAUI Busy Indicator.](images/gettingstarted/net-maui-busy-indicator-circular-material.gif){:width="144" height="138" loading="lazy"}

You can download the Busy Indicator Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/Getting-Started-with-.NET-MAUI-BusyIndicator)

N> You can refer to our [.NET MAUI Busy Indicator](https://www.syncfusion.com/maui-controls/maui-busy-indicator) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Busy Indicator example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/BusyIndicator) that shows you how to render the Busy Indicator in .NET MAUI.
