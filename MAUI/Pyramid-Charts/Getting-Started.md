---
layout: post
title: Getting Started with .NET MAUI Chart control | Syncfusion
description: Learn here all about getting started with Syncfusion .NET MAUI Chart (SfPyramidChart) control, its elements, and more.
platform: maui
control: SfPyramidChart
documentation: ug
---

# Getting Started with .NET MAUI Chart(SfPyramidChart)

This section explains how to populate the pyramid chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the pyramid chart.

## Creating an application using the .NET MAUI chart(SfPyramidChart)

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfPyramidChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize [SfPyramidChart]().

{% tabs %} 

{% highlight xaml %}

<ContentPage   
    . . .
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfPyramidChart/>
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
        SfPyramidChart chart = new SfPyramidChart();
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

 public class Learning
{
    public string Name { get; set; }
    public double Value { get; set; }

}

{% endhighlight %} 

{% endtabs %} 

Next, create a view model class and initialize a list of `Model` objects as follows.

{% tabs %}  

{% highlight c# %}

public class ChartViewModel
{
    public List<Learning> Data { get; set; }

    public ChartViewModel()
    {
        Data = new List<Learning>()
        {
            new Learning(){Name = "Others", Value = 20},
            new Learning(){Name = "Oils and Sweet", Value = 35},
            new Learning(){Name = "Protein", Value = 40},
            new Learning(){Name = "Fruits and vegetables", Value = 56},
            new Learning(){Name = "Grains", Value = 80},
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

    <chart:SfPyramidChart>
        <chart:SfPyramidChart.BindingContext>
        <model:ChartViewModel/>
        </chart:SfPyramidChart.BindingContext>
    </chart:SfPyramidChart>
</ContentPage>

{% endhighlight %}

{% highlight C# %} 

ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;

{% endhighlight %}

{% endtabs %} 

## Populate chart with data

 Binding `Data` to the pyramid chart [ItemsSource]() property from its BindingContext to create our own pyramid chart.

{% tabs %}   

{% highlight xaml %}

<chart:SfPyramidChart ItemsSource="{Binding Data}" 
                      XBindingPath="Name" 
                      YBindingPath="Value"/>
. . .            
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
ChartViewModel viewModel = new ChartViewModel();
chart.BindingContext = viewModel;
chart.ItemsSource = viewModel.Data;
chart.XBindingPath = "Name";
chart.YBindingPath = "Value";
this.Content = chart;

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart acts as the title to provide quick information to the user about the data being plotted in the chart. You can set title using the [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property of pyramid chart as follows.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart>
    <chart:SfPyramidChart.Title>
        <Label Text="Nutritional Food"/>
    </chart:SfPyramidChart.Title>
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
chart.Title = new Label
{
    Text = "Nutritional Food"
};

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The [ShowDataLabels]() property of chart can be used to enable data labels to improve the readability of the pyramid chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart ShowDataLabels="True">
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.ShowDataLabels = true;

{% endhighlight %}

{% endtabs %} 

## Enable a legend

The legend provides information about the data point displayed in the pyramid chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart>
    . . .
    <chart:SfPyramidChart.Legend>
    <chart:ChartLegend/>
    </chart:SfPyramidChart.Legend>
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.Legend = new ChartLegend();

{% endhighlight %}

{% endtabs %} 

## Enable Tooltip

Tooltips are used to show information about the segment, when mouse over on it. Enable tooltip by setting chart [EnableTooltip]() property as true.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart EnableTooltip="True">
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight C# %}

SfPyramidChart chart = new SfPyramidChart();
. . .
chart.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<chart:SfPyramidChart  ItemsSource="{Binding Data}" ShowDataLabels="True" XBindingPath="Name" EnableTooltip="True"        YBindingPath="Value">
    <chart:SfPyramidChart.Title>
        <Label Text="Nutritional Food"/>
    </chart:SfPyramidChart.Title>
    <chart:SfPyramidChart.BindingContext>
        <model:ChartViewModel/>
    </chart:SfPyramidChart.BindingContext>
    <chart:SfPyramidChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPyramidChart.Legend>
</chart:SfPyramidChart>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
. . .
public partial class MainPage : ContentPage
{   
    public MainWindow()
    {
        SfPyramidChart chart = new SfPyramidChart();
        chart.Title = new Label
        {
            Text = "Nutritional Food"
        };
        chart.Legend = new ChartLegend();
        ChartViewModel viewModel = new ChartViewModel();
        chart.BindingContext = viewModel;

        chart.ItemsSource = viewModel.Data;
        chart.XBindingPath = "Name";
        chart.YBindingPath = "Value";
        chart.EnableTooltip = true;
        chart.ShowDataLabels = true;
        this.Content = chart;
    }
}

{% endhighlight %}

{% endtabs %}

![Pyramid chart in .NET MAUI Chart](Getting-Started_Images/MAUI_pyramid_chart.png)
