---
layout: post
title: Getting Started with .NET MAUI Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Chart (SfCircularChart) control, its elements, and more.
platform: maui
control: SfCircularChart
documentation: ug
---

> **Notice**: After **Volume 1 2025 (Mid of March 2025)**, updates, bug fixes, and feature enhancements for this control will no longer be available in the Syncfusion package. Please switch to the **Syncfusion Toolkit for .NET MAUI** for continued support. For a smooth transition refer this [migration document](https://help.syncfusion.com/maui-toolkit/migration).

# Getting Started with .NET MAUI Chart

This section explains how to populate the circular chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the circular chart.

To get start quickly with our .NET MAUI Circular Chart, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=2WDZfXpMZsE&t=3s" %}

## Creating an application using the .NET MAUI chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfCircularChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

{% tabs %}

{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfCircularChart/>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .

public partial class MainWindow : ContentPage
{
    public MainPage()
    {
        this.InitializeComponent();
        SfCircularChart chart = new SfCircularChart();
        this.Content = chart;
    }
}   
{% endhighlight %}

{% endtabs %}

## Register the handler

Syncfusion.Maui.Core nuget is a dependent package for all Syncfusion controls of .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

{% highlight C# %}

using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Xaml;
using Syncfusion.Maui.Core.Hosting;

namespace ChartGettingStarted
{
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
            });

            return builder.Build();
        }
    }
}

{% endhighlight %} 

## Initialize view model

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

    public ChartViewModel()
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

Create a `SalesViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from `SalesViewModel` class.

N> Add namespace of `SalesViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <chart:SfCircularChart>
        <chart:SfCircularChart.BindingContext>
            <model:SalesViewModel/>
        </chart:SfCircularChart.BindingContext>
    </chart:SfCircularChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
this.BindingContext = new SalesViewModel();
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Populate chart with data

Adding [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html) to the charts [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection and binding `Data` to the series [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource) property from its BindingContext to create our own Product Sales Pie chart.

N> The circular chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) as its default content.

N> To plot the series, the [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath) properties must be configured so that the chart may get values from the respective properties in the data model.

{% tabs %}   

{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:PieSeries ItemsSource="{Binding Data}" 
                     XBindingPath="Product" 
                     YBindingPath="SalesRate"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
SalesViewModel viewModel = new SalesViewModel();
. . .
PieSeries series = new PieSeries();
series.ItemsSource = viewModel.Data;
series.XBindingPath = "Product";
series.YBindingPath = "SalesRate";
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart acts as the title to provide quick information to the user about the data being plotted in the chart. You can set title using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property of circular chart as follows.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.Title>
        <Label Text="PRODUCT SALES"/>
    </chart:SfCircularChart.Title>
    . . .
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
chart.Title = new Label()
{
    Text = "PRODUCT SALES"
};
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property of series can be used to enable data labels to improve the readability of the circular chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:PieSeries ShowDataLabels="True"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.ShowDataLabels = true;
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Enable a legend

The legend provides information about the data point displayed in the circular chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:SfCircularChart.Legend>
    	<chart:ChartLegend/>
    </chart:SfCircularChart.Legend>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
. . .
chart.Legend = new ChartLegend();
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse over on it. Enable tooltip by setting series [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property as true.

{% tabs %} 

{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:PieSeries EnableTooltip="True"/>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight C# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries();
series.EnableTooltip = true;
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

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

using Syncfusion.Maui.Charts;
. . .
public partial class MainPage : ContentPage
{   
    public MainWindow()
    {
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
    }
}

{% endhighlight %}

{% endtabs %}

![Pie chart in .NET MAUI Chart](Getting-Started_Images/MAUI_pie_chart.png)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/GettingStarted_CircularChart_MAUI).
