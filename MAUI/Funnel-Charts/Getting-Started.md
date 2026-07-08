---
layout: post
title: Getting Started with .NET MAUI Funnel Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion® .NET MAUI Funnel Chart (SfFunnelChart) control, its elements, and more.
keywords: maui funnel chart, getting started, setup, project creation, initialization
platform: maui
control: SfFunnelChart
documentation: ug
---

# Getting Started with .NET MAUI Funnel Chart

This section explains how to populate the funnel chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the funnel chart.

To get started quickly with the [.NET MAUI Funnel Chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html), you can check the following video.

{% youtube "https://www.youtube.com/watch?v=wJhqKHduXTI&t=2s" %}

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
3. Run the command `dotnet add package Syncfusion.Maui.Charts` to install the Syncfusion<sup>®</sup> .NET MAUI Charts package.
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

using System.Collections.Generic;

public class AdmissionModel
{
    public string XValue { get; set; }
    public double YValue { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create an `AdmissionViewModel` class and initialize a list of `AdmissionModel` objects:

{% tabs %}  

{% highlight c# %}

using System.Collections.Generic;

public class AdmissionViewModel
{
    public List<AdmissionModel> Data { get; set; }

    public AdmissionViewModel()
    {
        Data = new List<AdmissionModel>()
        {
            new AdmissionModel() { XValue = "Enrolled", YValue = 175 },
            new AdmissionModel() { XValue = "Admits", YValue = 190 },
            new AdmissionModel() { XValue = "Applicants", YValue = 245 },
            new AdmissionModel() { XValue = "Inquiries", YValue = 290 },
            new AdmissionModel() { XValue = "Prospects", YValue = 320 },
        };
    }
}

{% endhighlight %} 

{% endtabs %} 

Create an `AdmissionViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from the `AdmissionViewModel` class.

N> Add the namespace of the `AdmissionViewModel` class to your XAML Page if you prefer to set `BindingContext` in XAML.

## Step 5: Import the Funnel Chart namespace
 
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

Initialize the [SfFunnelChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#constructors) and bind the `Data` to it by using the [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ItemsSource) property. The data can be provided through the BindingContext, enabling you to create a customized funnel chart with your own data.

{% tabs %} 

{% highlight xml %}

xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
xmlns:model="clr-namespace:YourAppNamespace"

<chart:SfFunnelChart ItemsSource="{Binding Data}" 
                     XBindingPath="XValue" 
                     YBindingPath="YValue"
                     ShowDataLabels="True" 
                     EnableTooltip="True">

    <chart:SfFunnelChart.BindingContext>
        <model:AdmissionViewModel/>
    </chart:SfFunnelChart.BindingContext>

    <chart:SfFunnelChart.Title>
        <Label Text="School Admission"/>
    </chart:SfFunnelChart.Title>

    <chart:SfFunnelChart.Legend>
        <chart:ChartLegend/>
    </chart:SfFunnelChart.Legend>

</chart:SfFunnelChart>
 
{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;

SfFunnelChart chart = new SfFunnelChart()
{
    ItemsSource = new AdmissionViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    ShowDataLabels = true,
    EnableTooltip = true,
    Title = new Label()
    {
        Text = "School Admission"
    },
    Legend = new ChartLegend()
};

this.Content = chart;

{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Funnel chart in .NET MAUI Funnel Chart](Getting-Started_Images/MAUI_funnel_chart.png)

You can download the FunnelCharts Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/GettingStarted_FunnelChart_MAUI).