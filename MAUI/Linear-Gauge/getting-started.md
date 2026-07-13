---
layout: post
title: Getting started with .NET MAUI Linear Gauge control | Syncfusion®
description: Learn here about getting started with Syncfusion® .NET MAUI Linear Gauge (SfLinearGauge) control, its elements, and more. 
platform: maui
control: SfLinearGauge
documentation: ug
---

# Getting Started with .NET MAUI Linear Gauge

This section explains the steps required to add the [`.NET MAUI Linear Gauge`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) control and its elements such as scale, range, and pointer. This section covers only basic features needed to get started with the Syncfusion® .NET MAUI Linear Gauge control. The .NET MAUI Linear Gauge is supported on Windows, macOS, iOS, and Android. Follow the steps below to add a .NET MAUI Linear Gauge control to your project.

To get started quickly with our .NET MAUI Linear Gauge, you can check the following video.

{% youtube
"youtube:https://www.youtube.com/watch?v=wclf360zOPc"%}

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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Gauges NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P** and type **.NET: New Project** and press Enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press Enter.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Gauges NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Gauges` to install the Syncfusion<sup>®</sup> .NET MAUI Gauges package.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here.](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start)

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**. Select .NET (C#) and choose the .NET MAUI App template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click Create.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Gauges NuGet package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Gauges](https://www.nuget.org/packages/Syncfusion.Maui.Gauges/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register the Syncfusion handler
 
Add the following namespace in the `MauiProgram.cs` file.
 
{% tabs %}
{% highlight c# %}
using Syncfusion.Maui.Core.Hosting;
{% endhighlight %}
{% endtabs %}
 
Register the Syncfusion core handler in the `CreateMauiApp` method of the `MauiProgram.cs` file to use Syncfusion controls.
 
{% tabs %}
{% highlight c# %}
builder.ConfigureSyncfusionCore();
{% endhighlight %}
{% endtabs %}

## Step 4: Import the Gauges namespace
 
Add the following namespace in your XAML or C#.
 
{% tabs %}
{% highlight xaml %}
 
xmlns:gauge="clr-namespace:Syncfusion.Maui.Gauges;assembly=Syncfusion.Maui.Gauges"
 
{% endhighlight %}
{% highlight c# %}
 
using Syncfusion.Maui.Gauges;
 
{% endhighlight %}
{% endtabs %}

## Step 5: Add a Linear Gauge with Pointers, Ranges, and Bar Pointers

Initialize the [SfLinearGauge](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html?tabs=tabid-1) to show values on a linear scale, with [ranges](https://help.syncfusion.com/maui/linear-gauge/range) highlighting value segments and [pointers](https://help.syncfusion.com/maui/linear-gauge/pointers) indicating specific values clearly. The [LinearRange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html) highlights a value segment, the [LinearShapePointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearShapePointer.html) and [LinearContentPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearContentPointer.html) are marker pointers, and the [BarPointer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html) is a shaded bar from the minimum scale value to the specified value.

N> The image used in the `LinearContentPointer` source (e.g., `pin.png`) must be added to your project's resources.

{% tabs %}

{% highlight xaml %}

<gauge:SfLinearGauge x:Name="gauge">
    <gauge:SfLinearGauge.Ranges>
        <gauge:LinearRange/>
    </gauge:SfLinearGauge.Ranges>

    <gauge:SfLinearGauge.MarkerPointers>
        <gauge:LinearShapePointer Value="70"/>

        <gauge:LinearContentPointer Value="80">
            <gauge:LinearContentPointer.Content>
                <Image Source="pin.png" HeightRequest="20" 
                       WidthRequest="20"/>
            </gauge:LinearContentPointer.Content>
        </gauge:LinearContentPointer>
    </gauge:SfLinearGauge.MarkerPointers>

    <gauge:SfLinearGauge.BarPointers>
        <gauge:BarPointer Value="60"/>
    </gauge:SfLinearGauge.BarPointers>
</gauge:SfLinearGauge>

{% endhighlight %}

{% highlight c# %}

SfLinearGauge gauge = new SfLinearGauge();
LinearRange range = new LinearRange();
gauge.Ranges.Add(range);

LinearShapePointer shapePointer = new LinearShapePointer();
shapePointer.Value = 70;
gauge.MarkerPointers.Add(shapePointer);

LinearContentPointer contentPointer = new LinearContentPointer();
contentPointer.Value = 80;
contentPointer.Content = new Image() { Source = "pin.png", HeightRequest = 20, WidthRequest = 20 };
gauge.MarkerPointers.Add(contentPointer);

BarPointer barPointer = new BarPointer();
barPointer.Value = 60;
gauge.BarPointers.Add(barPointer);

this.Content = gauge;

{% endhighlight %}
{% endtabs %}

The following screenshot illustrates the result of the above code.

![Getting started with .NET MAUI Linear Gauge](images/getting-started/maui-linear-gauge.PNG)

You can download the Linear Gauge Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-linear-gauge).

N> You can refer to our [.NET MAUI Linear Gauge](https://www.syncfusion.com/maui-controls/maui-linear-gauge) feature tour page for its groundbreaking feature representations. You can also explore our [.NET MAUI Linear Gauge Example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Gauges/SampleBrowser.Maui.Gauges/Samples/LinearGauge) that shows you how to render the Linear Gauge in .NET MAUI.