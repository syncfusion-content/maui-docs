---
layout: post
title: Getting Started with .NET MAUI Circular Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion® .NET MAUI Chart (SfCircularChart) control, its elements, and more.
platform: maui
control: SfCircularChart
documentation: ug
---

# Getting Started with .NET MAUI Circular Chart

This section explains how to populate the circular chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the circular chart.

To get start quickly with our [.NET MAUI Circular Chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html), you can check the below video.

{% youtube "https://www.youtube.com/watch?v=2WDZfXpMZsE&t=3s" %}

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

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Charts Package

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

1. Open the command palette by pressing `Ctrl+Shift+P` and type **.NET:New Project** and enter.
2. Choose the **.NET MAUI App** template.
3. Select the project location, type the project name and press **Enter.**
4. Then choose **Create project.**

## Step 2: Install the Syncfusion<sup>®</sup> .NET MAUI Charts Package

1. Press <kbd>Ctrl</kbd> + <kbd>`</kbd> (backtick) to open the integrated terminal in Visual Studio Code.
2. Ensure you're in the project root directory where your .csproj file is located.
3. Run the command `dotnet add package Syncfusion.Maui.Charts` to install the Syncfusion<sup>®</sup> .NET MAUI Charts NuGet package.
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

## Step 2: Install the Syncfusion<sup>®</sup> MAUI Charts NuGet Package

1. In **Solution Explorer,** right-click the project and choose **Manage NuGet Packages.**
2. Search for [Syncfusion.Maui.Charts](https://www.nuget.org/packages/Syncfusion.Maui.Charts/) and install the latest version.
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

## Step 4: Define Model and View Model

Now, let us define a simple data model that represents a data point in the chart.

{% tabs %}  
{% highlight c# %}

public class SalesModel
{
    public string Product { get; set; }
    public double SalesRate { get; set; }
}

{% endhighlight %} 
{% endtabs %} 

Next, create a SalesViewModel class and initialize a list of `SalesModel` objects as follows.

{% tabs %}  
{% highlight c# %}

public class SalesViewModel
{
    public List<SalesModel> Data { get; set; }

    public SalesViewModel()
    {
        Data = new List<SalesModel>()
        {
            new SalesModel(){Product = "iPad", SalesRate = 25},
            new SalesModel(){Product = "iPhone", SalesRate = 35},
            new SalesModel(){Product = "MacBook", SalesRate = 15},
            new SalesModel(){Product = "Mac", SalesRate = 5},
            new SalesModel(){Product = "Others", SalesRate = 10},
        };
    }
}

{% endhighlight %} 
{% endtabs %} 

## Step 5: Import the Circular Chart namespace

Add the following namespace in your XAML or C#.

{% tabs %}
{% highlight xaml %}
xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
{% endhighlight %}
{% highlight c# tabtitle="C#" %}
using Syncfusion.Maui.Charts;
{% endhighlight %}
{% endtabs %}

## Step 6: Add the Circular Chart component

Create an instance for the AI AssistView control, and add it as content. Now, Create a `SalesViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from `SalesViewModel` class.

N> Add namespace of `SalesViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

Adding [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html) to the charts [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection and binding `Data` to the series [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource) property from its BindingContext to create our own Product Sales Pie chart.

N> The circular chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) as its default content.

N> To plot the series, the [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath) properties must be configured so that the chart may get values from the respective properties in the data model.

{% tabs %} 

{% highlight xaml %}
    <chart:SfCircularChart>
        <chart:SfCircularChart.Title>
            <Label Text="PRODUCT SALES"/>
        </chart:SfCircularChart.Title>

        <chart:SfCircularChart.BindingContext>
            <model:SalesViewModel/>
        </chart:SfCircularChart.BindingContext>

        <chart:SfCircularChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCircularChart.Legend>

        <chart:PieSeries ItemsSource="{Binding Data}"
                         XBindingPath="Product" 
                         YBindingPath="SalesRate"
                         ShowDataLabels="True"
                         EnableTooltip="True"/>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}
    SfCircularChart chart = new SfCircularChart();
    chart.Title = new Label()
    {
        Text = "PRODUCT SALES"
    };
    chart.Legend = new ChartLegend();
    SalesViewModel viewModel = new SalesViewModel();
    chart.BindingContext = viewModel;

    PieSeries series = new PieSeries();
    series.ItemsSource = viewModel.Data;
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    series.EnableTooltip = true;
    series.ShowDataLabels = true;
    chart.Series.Add(series);
    this.Content = chart;
{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Pie chart in .NET MAUI Chart](Getting-Started_Images/MAUI_pie_chart.png)

You can download the Circular Chart Getting Started sample from [GitHub](https://github.com/SyncfusionExamples/GettingStarted_CircularChart_MAUI).
