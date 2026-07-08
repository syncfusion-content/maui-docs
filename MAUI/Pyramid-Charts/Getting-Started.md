---
layout: post
title: Getting Started with .NET MAUI Pyramid Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion® .NET MAUI Pyramid Chart (SfPyramidChart) control, its elements, and more.
keywords: maui pyramid chart, getting started, setup, project creation, initialization
platform: maui
control: SfPyramidChart
documentation: ug
---

# Getting Started with .NET MAUI Pyramid Chart

This section explains how to populate the pyramid chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the pyramid chart.

To get started quickly with the [.NET MAUI Pyramid Chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html), you can check the following video.

{% youtube "https://www.youtube.com/watch?v=wJhqKHduXTI&t=2s" %}

{% tabcontents %}
{% tabcontent Visual Studio %}

## Prerequisites
Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio 2022 v17.12 or later.

## Step 1: Create a new .NET MAUI project

1. Go to **File > New > Project** and choose the **.NET MAUI App** template.
2. Name the project and choose a location. Click **Next**.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Charts NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored.

{% endtabcontent %}
{% tabcontent Visual Studio Code %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with Visual Studio Code.
3. Ensure that the .NET MAUI workloads are installed and configured as described [here](https://learn.microsoft.com/en-us/dotnet/maui/get-started/installation?view=net-maui-9.0&tabs=visual-studio-code).

## Step 1: Create a new .NET MAUI project

1. Open the Command Palette by pressing **Ctrl+Shift+P**, type **.NET:New Project**, and press **Enter**.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name, and press **Enter**.
4. Then choose **Create project**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Charts NuGet package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
4. To ensure all dependencies are installed, run `dotnet restore`.

{% endtabcontent %}
{% tabcontent JetBrains Rider %}

## Prerequisites

Before proceeding, ensure the following are set up:

1. Install [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later.
2. Set up a .NET MAUI environment with JetBrains Rider 2024.3 or later.
3. Make sure the MAUI workloads are installed and configured as described [here](https://www.jetbrains.com/help/rider/MAUI.html#before-you-start).

## Step 1: Create a new .NET MAUI project

1. Go to **File > New Solution**, select **.NET (C#)**, and choose the **.NET MAUI App** template.
2. Enter the Project Name, Solution Name, and Location.
3. Select the .NET framework version and click **Create**.

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Charts NuGet package

1. In **Solution Explorer**, right-click the project and choose **Manage NuGet Packages**.
2. Search for [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts/) and install the latest version.
3. Ensure the necessary dependencies are installed correctly, and the project is restored. If not, open the Terminal in Rider and manually run: `dotnet restore`

{% endtabcontent %}
{% endtabcontents %}

## Step 3: Register Syncfusion handler

The Syncfusion handler must be registered to enable all Syncfusion MAUI controls in your application. Add the following namespace to your `MauiProgram.cs` file:

{% tabs %}
{% highlight c# %}

using Syncfusion.Maui.Core.Hosting;

{% endhighlight %}
{% endtabs %}

Register the Syncfusion core handler in your `CreateMauiApp` method of `MauiProgram.cs` file:

{% tabs %}
{% highlight c# %}

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

{% endhighlight %}
{% endtabs %}

## Step 4: Define the data model and view model

First, define a simple data model that represents a data point in the chart:

{% tabs %}

{% highlight c# %}

public class PyramidModel
{
    public string XValue { get; set; }
    public double YValue { get; set; }
}

{% endhighlight %}

{% endtabs %}

Next, create a `PyramidViewModel` class and initialize a list of `PyramidModel` objects:

{% tabs %}

{% highlight c# %}

public class PyramidViewModel
{
    public List<PyramidModel> Data { get; set; }

    public PyramidViewModel()
    {
        Data = new List<PyramidModel>()
        {
            new PyramidModel() { XValue = "Stage A", YValue = 12 },
            new PyramidModel() { XValue = "Stage B", YValue = 21 },
            new PyramidModel() { XValue = "Stage C", YValue = 29 },
            new PyramidModel() { XValue = "Stage D", YValue = 37 },
        };
    }
}

{% endhighlight %}

{% endtabs %}

Create a `PyramidViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from the `PyramidViewModel` class.

N> Add the namespace of the `PyramidViewModel` class to your XAML Page if you prefer to set `BindingContext` in XAML.

## Step 5: Import the Pyramid Chart namespace

Add the following namespace in your XAML or C#:

{% tabs %}
{% highlight xml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Charts;

{% endhighlight %}
{% endtabs %}

## Step 6: Populate chart with data

Initialize the [SfPyramidChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#constructors) and bind the `Data` to it by using the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_ItemsSource) property. The data can be provided through the BindingContext, enabling you to create a customized pyramid chart with your own data.

{% tabs %} 

{% highlight xml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="XValue" 
                      YBindingPath="YValue"
                      ShowDataLabels="True" 
                      EnableTooltip="True">

    <chart:SfPyramidChart.BindingContext>
        <model:PyramidViewModel/>
    </chart:SfPyramidChart.BindingContext>

    <chart:SfPyramidChart.Title>
        <Label Text="Pyramid Stages"/>
    </chart:SfPyramidChart.Title>

    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPyramidChart.Legend>

</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart()
{
    ItemsSource = new PyramidViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    ShowDataLabels = true,
    EnableTooltip = true,
    Title = new Label()
    {
        Text = "Pyramid Stages"
    },
    Legend = new ChartLegend()
};

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Pyramid chart in .NET MAUI Pyramid Chart](Getting-Started_Images/MAUI_pyramid_chart.png)

You can download the Pyramid Charts Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/GettingStarted_PyramidChart_MAUI).