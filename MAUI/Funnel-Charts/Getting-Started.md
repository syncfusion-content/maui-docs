---
layout: post
title: Getting Started with .NET MAUI Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Chart (SfFunnelChart) control, its elements, and more.
platform: maui
control: SfFunnelChart
documentation: ug
---

# Getting Started with .NET MAUI Chart

This section explains how to populate the funnel chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the funnel chart.

## Creating an application using the .NET MAUI chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfFunnelChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize SfFunnelChart.

{% tabs %} 

{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfFunnelChart/>
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
        SfFunnelChart chart = new SfFunnelChart();
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

public class Sales
{
    public string Product { get; set; }
    public double SalesRate { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create a view model class and initialize a list of `Model` objects as follows.

{% tabs %}  

{% highlight c# %}

public class ChartViewModel
{
    public List<Sales> Data { get; set; }

    public ChartViewModel()
    {
        Data = new List<Sales>()
        {
            new Sales(){Product = "iPad", SalesRate = 25},
            new Sales(){Product = "iPhone", SalesRate = 35},
            new Sales(){Product = "MacBook", SalesRate = 15},
            new Sales(){Product = "Mac", SalesRate = 5},
            new Sales(){Product = "Others", SalesRate = 10},
        };
    }
}

{% endhighlight %} 

{% endtabs %} 

Create a `ViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from `ViewModel` class.

N> Add namespace of `ViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %} 

<ContentPage
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <chart:SfFunnelChart>
        <chart:SfFunnelChart.BindingContext>
        <model:ChartViewModel/>
        </chart:SfFunnelChart.BindingContext>
    </chart:SfFunnelChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %} 

ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;

{% endhighlight %}

{% endtabs %} 

## Populate chart with data

 Binding `Data` to the Funnel chart ItemsSource property from its BindingContext to create our own Product Sales funnel chart.

{% tabs %}   

{% highlight xaml %}

<chart:SfFunnelChart ItemsSource="{Binding Data}" 
                    XBindingPath="Product" 
                    YBindingPath="SalesRate"/>
. . .            
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "Product";
chart.YBindingPath = "SalesRate";
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart acts as the title to provide quick information to the user about the data being plotted in the chart. You can set title using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property of funnel chart as follows.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart>
    <chart:SfFunnelChart.Title>
        <Label Text="PRODUCT SALES"/>
    </chart:SfFunnelChart.Title>
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
chart.Title = new Label
{
    Text = "PRODUCT SALES"
};

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The ShowDataLabels property of chart can be used to enable data labels to improve the readability of the funnel chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart ShowDataLabels="True">
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.ShowDataLabels = true;

{% endhighlight %}

{% endtabs %} 

## Enable a legend

The legend provides information about the data point displayed in the funnel chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart>
    . . .
    <chart:SfFunnelChart.Legend>
    <chart:ChartLegend/>
    </chart:SfFunnelChart.Legend>
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse over on it. Enable tooltip by setting chart EnableTooltip property as true.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart EnableTooltip="True">
    . . .
</chart:SfFunnelChart>

{% endhighlight %}

{% highlight C# %}

SfFunnelChart chart = new SfFunnelChart();
. . .
chart.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<chart:SfFunnelChart  ItemsSource="{Binding Data}" ShowDataLabels="True" XBindingPath="Product" EnableTooltip="True"        YBindingPath="SalesRate">
    <chart:SfFunnelChart.Title>
        <Label Text="PRODUCT SALES"/>
    </chart:SfFunnelChart.Title>
    <chart:SfFunnelChart.BindingContext>
        <model:ChartViewModel/>
    </chart:SfFunnelChart.BindingContext>
    <chart:SfFunnelChart.Legend>
        <chart:ChartLegend/>
    </chart:SfFunnelChart.Legend>
</chart:SfFunnelChart>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
public partial class MainPage : ContentPage
{   
    public MainWindow()
    {
        SfFunnelChart chart = new SfFunnelChart();
        chart.Title = new Label
        {
            Text = "PRODUCT SALES"
        };
        chart.Legend = new ChartLegend();
        ChartViewModel viewModel = new ChartViewModel();
        chart.BindingContext = viewModel;

        chart.ItemsSource = viewModel.Data;
        chart.XBindingPath = "Product";
        chart.YBindingPath = "SalesRate";
        chart.EnableTooltip = true;
        chart.ShowDataLabels = true;
        this.Content = chart;
    }
}

{% endhighlight %}

{% endtabs %}
