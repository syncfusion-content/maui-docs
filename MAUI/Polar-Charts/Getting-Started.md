---
layout: post
title: Getting Started with .NET MAUI Chart Control | Syncfusion
description: This section explains about the getting started with Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Getting Started with .NET MAUI Chart

This section explains how to populate the Polar chart with data, a title, data labels, a legend, tooltips, and markers. It also covers the essential aspects of getting started with the chart.

To get start quickly with our .NET MAUI Polar Chart, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=Ga9mytwCo_s&t=4s" %}

## Creating an application with .NET MAUI chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available on [nuget.org](https://www.nuget.org/). To add SfPolarChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts, and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize the [SfPolarChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html).

{% tabs %} 

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <Grid>
        <chart:SfPolarChart/>
    </Grid>
</ContentPage>
    
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();           
            SfPolarChart chart = new SfPolarChart(); 
        }
    }   
}

{% endhighlight %}

{% endtabs %}

## Register the handler

The Syncfusion.Maui.Core NuGet package is a dependent package for all Syncfusion controls in .NET MAUI. In the MauiProgram.cs file, register the handler for Syncfusion core.

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

Now, let us define a simple data model that represents a data point on the chart.

{% tabs %}  

{% highlight c# %}

public class PlantData   
{   
    public string Direction { get; set; }
    public double Tree { get; set; }
    public double Flower { get; set; }
    public double Weed { get; set; }
}

{% endhighlight %} 

{% endtabs %} 

Next, create a view model class and initialize a list of `PlantData` objects as follows.

{% tabs %}  

{% highlight c# %}

public class ViewModel  
{
    public List<PlantData> PlantDetails { get; set; }      

    public ViewModel()       
    {
        PlantDetails  = new List<PlantData>()
        {
            new PlantData(){ Direction = "North", Tree = 80, Flower = 42, Weed = 63},
            new PlantData(){ Direction = "NorthEast", Tree = 85, Flower = 40, Weed = 70},
            new PlantData(){ Direction = "East", Tree = 78 , Flower = 47, Weed = 65},
            new PlantData(){ Direction = "SouthEast", Tree = 90 , Flower = 40, Weed = 70},
            new PlantData(){ Direction = "South", Tree = 78 , Flower = 27, Weed = 47},
            new PlantData(){ Direction = "SouthWest", Tree = 83 , Flower = 45, Weed = 65},
            new PlantData(){ Direction = "West", Tree = 79 , Flower = 40, Weed = 58},
            new PlantData(){ Direction = "NorthWest", Tree = 88 , Flower = 38, Weed = 73}
        }; 
    }
}

{% endhighlight %} 

{% endtabs %} 

Create a `ViewModel` instance and set it as the chart's `BindingContext`. This enables property binding from the `ViewModel` class.
 
N> Add the namespace of the `ViewModel` class to your XAML page, if you prefer to set the `BindingContext` in XAML.

{% tabs %} 

{% highlight xaml %} 

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <ContentPage.BindingContext>
        <model:ViewModel></model:ViewModel>
    </ContentPage.BindingContext>
</ContentPage>

{% endhighlight %}

{% highlight C# %} 

this.BindingContext = new ViewModel();

{% endhighlight %}

{% endtabs %} 

## Initialize Chart axis

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) is used to locate the data points inside the chart area. The [PrimaryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_PrimaryAxis) and [SecondaryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_SecondaryAxis) properties of the chart are used to initialize the axis for the chart.

{% tabs %} 

{% highlight xaml %} 

<chart:SfPolarChart>                            
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.SecondaryAxis>                       
</chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %} 

SfPolarChart chart = new SfPolarChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

{% endhighlight %}

{% endtabs %} 

## Populate Chart with data

To create a polar chart, you can add a [PolarLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarLineSeries.html?tabs=tabid-1%2Ctabid-4) to the polar chart [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_Series) property of the chart, and  then bind the `PlantData` property of the above `ViewModel` to the `PolarLineSeries.ItemsSource` as follows.

N> In order to plot the series, the [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath) properties need to be configured correctly. These properties allow the chart to retrieve values from the corresponding properties in the data model.

{% tabs %}   

{% highlight xaml %}

<chart:SfPolarChart>
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis>
        </chart:CategoryAxis>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis Maximum="100">
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>

    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree"/>
        
    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Weed"/>

    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Flower"/>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %}

SfPolarChart chart = new SfPolarChart();

// Initializing primary axis
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;

//Initializing secondary Axis
NumericalAxis secondaryAxis = new NumericalAxis()
{
    Maximum="100"
};
chart.SecondaryAxis = secondaryAxis;

//Initialize the series
PolarLineSeries  series1 = new PolarLineSeries();
series1.ItemsSource = (new ViewModel()).PlantDetails;
series1.XBindingPath = "Direction";
series1.YBindingPath = "Tree";

PolarLineSeries  series2 = new PolarLineSeries();
series2.ItemsSource = (new ViewModel()).PlantDetails;
series2.XBindingPath = "Direction";
series2.YBindingPath = "Weed";

PolarLineSeries  series3 = new PolarLineSeries();
series3.ItemsSource = (new ViewModel()).PlantDetails;
series3.XBindingPath = "Direction";
series3.YBindingPath = "Flower";

//Adding Series to the Chart Series Collection
chart.Series.Add(series1);
chart.Series.Add(series2);
chart.Series.Add(series3);

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart provides quick information to the user about the data being plotted in the chart. The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property is used to set the title for the chart as follows.

{% tabs %} 

{% highlight xaml %}

<Grid>
    <chart:SfPolarChart>
        <chart:SfPolarChart.Title>
            <Label Text="Plant Analysis" HorizontalTextAlignment="Center"/>
        </chart:SfPolarChart.Title> 
    </chart:SfPolarChart>
</Grid>

{% endhighlight %}

{% highlight C# %}

SfPolarChart chart = new SfPolarChart();
chart.Title = new Label
{
    Text = "Plant Analysis",
    HorizontalTextAlignment="Center"
};

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property of series can be used to enable the data labels to enhance the readability of the chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

<chart:SfPolarChart>
    . . . 
    <chart:PolarLineSeries  ShowDataLabels="True">
    </chart:PolarLineSeries>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %}

SfPolarChart chart = new SfPolarChart()
. . .
PolarLineSeries series1 = new PolarLineSeries();
series1.ShowDataLabels = true;
chart.Series.Add(series1);

{% endhighlight %}

{% endtabs %}  

## Enable a legend

The legend provides information about the data point displayed in the chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.Legend>
        <chart:ChartLegend/>
    </chart:SfPolarChart.Legend>
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %}

SfPolarChart chart = new SfPolarChart();
chart.Legend = new ChartLegend(); 

{% endhighlight %}

{% endtabs %}  

N> Additionally, set a label for each series using the `Label` property of the chart series, which will be displayed in the corresponding legend.

{% tabs %} 

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree"
                            Label="Tree"/>

    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Weed" 
                            Label="Weed"/>

    <chart:PolarLineSeries  ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Flower" 
                            Label="Flower"/>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight C# %}

PolarLineSeries series1 = new PolarLineSeries(); 
series1.ItemsSource = (new ViewModel()).PlantDetails;
series1.XBindingPath = "Direction"; 
series1.YBindingPath = "Tree"; 
series1.Label = "Tree";

PolarLineSeries series2 = new PolarLineSeries();
series2.ItemsSource = (new ViewModel()).PlantDetails;
series2.XBindingPath = "Direction";
series2.YBindingPath = "Weed";
series2.Label = "Weed";

PolarLineSeries series3 = new PolarLineSeries();
series3.ItemsSource = (new ViewModel()).PlantDetails;
series3.XBindingPath = "Direction";
series3.YBindingPath = "Flower";
series3.Label = "Flower";

{% endhighlight %}

{% endtabs %}  

## Enable tooltip

Tooltips are used to display information about a segment when a user hovers over it. Enable the tooltip by setting the series [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property to true.

{% tabs %} 

{% highlight xaml %}

<chart:SfPolarChart>
    ...
    <chart:PolarLineSeries EnableTooltip="True"/>
    ...
</chart:SfPolarChart> 

{% endhighlight %}

{% highlight C# %}

PolarLineSeries  series1 = new PolarLineSeries();
series1.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

The following code example gives you the complete code of above configurations.

{% tabs %} 

{% highlight xaml %}

<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    x:Class="ChartGettingStarted.MainPage"
    xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
    xmlns:model="clr-namespace:ChartGettingStarted">

    <ContentPage.BindingContext>
        <model:ViewModel></model:ViewModel>
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <Grid>
            <chart:SfPolarChart>
                <chart:SfPolarChart.Title>
                    <Label Text="Plant Analysis" HorizontalTextAlignment="Center"/>
                </chart:SfPolarChart.Title>

                <chart:SfPolarChart.Legend>
                    <chart:ChartLegend/>
                </chart:SfPolarChart.Legend>
    
                <chart:SfPolarChart.PrimaryAxis>
                    <chart:CategoryAxis/>                    
                </chart:SfPolarChart.PrimaryAxis>

                <chart:SfPolarChart.SecondaryAxis>
                    <chart:NumericalAxis Maximum="100"/>                   
                </chart:SfPolarChart.SecondaryAxis>

                <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Tree" 
                                       Label="Tree" EnableTooltip="True" ShowDataLabels="True"/>

                <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Weed" 
                                       Label="Weed" EnableTooltip="True" ShowDataLabels="True"/>

                <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}" XBindingPath="Direction" YBindingPath="Flower" 
                                       Label="Flower" EnableTooltip="True" ShowDataLabels="True"/>
            </chart:SfPolarChart>
        </Grid>
    </ContentPage.Content>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Charts;
namespace ChartGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
            SfPolarChart chart = new SfPolarChart();

            chart.Title = new Label
            {
                Text = "Plant Analysis",
                HorizontalTextAlignment="Center"
            };

            CategoryAxis primaryAxis = new CategoryAxis();
            chart.PrimaryAxis = primaryAxis;

            NumericalAxis secondaryAxis = new NumericalAxis()
            {
                Maximum="100"
            };
            chart.SecondaryAxis = secondaryAxis;

            PolarLineSeries  series1 = new PolarLineSeries()
            {
                ItemsSource = (new ViewModel()).PlantDetails,
                XBindingPath = "Direction",
                YBindingPath = "Tree",
                Label="Tree", 
                EnableTooltip="True", 
                ShowDataLabels="True"
            }; 

            PolarLineSeries  series2 = new PolarLineSeries()
            {
                ItemsSource = (new ViewModel()).PlantDetails,
                XBindingPath = "Direction",
                YBindingPath = "Weed",
                Label="Weed", 
                EnableTooltip="True", 
                ShowDataLabels="True"
            }; 

            PolarLineSeries series3 = new PolarLineSeries()
            {
                ItemsSource = (new ViewModel()).PlantDetails,
                XBindingPath = "Direction",
                YBindingPath = "Flower",
                Label="Flower", 
                EnableTooltip="True", 
                ShowDataLabels="True"
            };   

            chart.Series.Add(series1);
            chart.Series.Add(series2);
            chart.Series.Add(series3);
            this.Content = chart;
        }
    }   
}

{% endhighlight %}

{% endtabs %}

The following chart is created as a result of the previous codes.

![Getting started for .NET MAUI Chart](Getting-Started_Images/MAUI_polar_chart.png)

You can find the complete getting started sample from this [link](https://github.com/SyncfusionExamples/Creating-a-Getting-Started-application-for-NET-MAUI-Polar-Chart).
