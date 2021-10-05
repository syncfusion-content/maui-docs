---
layout: post
title: Getting started with .NET MAUI Chart control | Syncfusion
description: This section explains about the getting started with Syncfusion MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Getting Started with .NET MAUI Chart

This section explains how to populate the Cartesian chart with data, a title, data labels, a legend, and tooltips, as well as the essential aspects for getting started with the chart.

## Creating an application with .NET MAUI chart

1. Create a new .NET MAUI application in Visual Studio.
2. Syncfusion .NET MAUI components are available in [nuget.org](https://www.nuget.org/). To add SfCartesianChart to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Charts and then install it.
3. To initialize the control, import the Chart namespace.
4. Initialize [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

{% tabs %} 

{% highlight xaml %}

    <ContentPage
    . . .    
        xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
        <Grid>
            <chart:SfCartesianChart/>
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
                SfCartesianChart chart = new SfCartesianChart(); 
            }
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

    public class Person   
    {   
        public string Name { get; set; }
        public double Height { get; set; }
    }

{% endhighlight %} 

{% endtabs %} 

Next, create a view model class and initialize a list of `Person` objects as follows.

{% tabs %}  

{% highlight c# %}

    public class ViewModel  
    {
        Data = new List<Person>()
        {
            new Person { Name = "David", Height = 170 },
            new Person { Name = "Michael", Height = 96 },
            new Person { Name = "Steve", Height = 65 },
            new Person { Name = "Joel", Height = 182 },
            new Person { Name = "Bob", Height = 134 }
        };
    }   

{% endhighlight %} 

{% endtabs %} 

Set the `ViewModel` instance as the `BindingContext` of your page to bind `ViewModel` properties to the chart. 
 
N> Add namespace of `ViewModel` class to your XAML Page, if you prefer to set `BindingContext` in XAML.

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

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) is used to locate the data points inside the chart area. The [PrimaryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PrimaryAxis) and [SecondaryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SecondaryAxis) properties of the chart is used to initialize the axis for the chart.

{% tabs %} 

{% highlight xaml %} 

    <chart:SfCartesianChart>                            
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis/>
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.SecondaryAxis>                       
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %} 

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

{% endhighlight %}

{% endtabs %} 

Run the project and check if you get following output to make sure you have configured your project properly to add a chart.

![Initializing axis for .NET MAUI Chart](Getting-Started_Images/MAUI_chart_initialized.jpg)

## Populate Chart with data

As we are going to visualize the comparison of heights in the data model, add [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1) to [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) property of chart, and then bind the `Data` property of the above `ViewModel` to the `ColumnSeries.ItemsSource` as follows.

N> You need to set [XBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath) and [YBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_YBindingPath)
 properties so that chart will fetch values from the respective properties in the data model to plot the series. 

{% tabs %}   

{% highlight xaml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis>
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Name" />
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis>
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Height(in cm)" />
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.SecondaryAxis>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Name" 
                                YBindingPath="Height">
            </chart:ColumnSeries>
        </chart:SfCartesianChart.Series>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    
    // Initializing primary axis
    CategoryAxis primaryAxis = new CategoryAxis();
    primaryAxis.Title.Text = "Name";
    chart.PrimaryAxis = primaryAxis;

    //Initializing secondary Axis
    NumericalAxis secondaryAxis = new NumericalAxis();
    secondaryAxis.Title.Text = "Height(in cm)";
    chart.SecondaryAxis = secondaryAxis;

    //Initialize the two series for SfChart
    ColumnSeries series = new ColumnSeries();
    series.Label = "Height";
    series.ShowDataLabels = true;
    series.ItemsSource = (new ViewModel()).Data;
    series.XBindingPath = "Name";
    series.YBindingPath = "Height";

    //Adding Series to the Chart Series Collection
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %} 

## Add a title

The title of the chart provide quick information to the user about the data being plotted in the chart. The [Title](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title) property is used to set title for the chart as follows.

{% tabs %} 

{% highlight xaml %}

    <Grid>
        <chart:SfCartesianChart>
            <chart:SfCartesianChart.Title>
                <Label Text="Height Comparison" />
            </chart:SfCartesianChart.Title> 
        </chart:SfCartesianChart>
    </Grid>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.Title = new Label
    {
        Text = "Height Comparison"
    };

{% endhighlight %}

{% endtabs %}  

## Enable the data labels

The [ShowDataLabels](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels) property of series can be used to enable the data labels to improve the readability of the chart. The label visibility is set to `False` by default.

{% tabs %} 

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . . 
        <chart:ColumnSeries ShowDataLabels="True">
        </chart:ColumnSeries>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart()
    . . .
    ColumnSeries series = new ColumnSeries();
    series.ShowDataLabels = true;
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}  

## Enable a legend

The legend provides information about the data point displayed in the chart. The [Legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) property of the chart was used to enable it.

{% tabs %} 

{% highlight xaml %}

    <chart:SfCartesianChart >
        . . .
        <chart:SfCartesianChart.Legend>
            <chart:ChartLegend/>
        </chart:SfCartesianChart.Legend>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.Legend = new ChartLegend (); 

{% endhighlight %}

{% endtabs %}  

N> Additionally, set label for each series using the `Label` property of chart series, which will be displayed in corresponding legend.

{% tabs %} 

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:ColumnSeries Label="Height"
                        ItemsSource="{Binding Data}"
                        XBindingPath="Name" 
                        YBindingPath="Height">
        </chart:ColumnSeries>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight C# %}

    ColumnSeries series = new ColumnSeries (); 
    series.ItemsSource = (new ViewModel()).Data;
    series.XBindingPath = "Name"; 
    series.YBindingPath = "Height"; 
    series.Label = "Height";

{% endhighlight %}

{% endtabs %}  

## Enable tooltip

Tooltips are used to show information about the segment, when a user hovers over a segment. Enable tooltip by setting series [ShowTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowTooltip) property to true.

{% tabs %} 

{% highlight xaml %}

    <chart:SfCartesianChart>
	    ...
        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ShowTooltip="True" ItemsSource="{Binding Data}" XBindingPath="Name" YBindingPath="Height"/>
        </chart:SfCartesianChart.Series>
	    ...
    </chart:SfCartesianChart> 

{% endhighlight %}

{% highlight C# %}

    ColumnSeries series = new ColumnSeries();
    series.ItemsSource = (new ViewModel()).Data;
    series.XBindingPath = "Name";          
    series.YBindingPath = "Height";
    series.ShowTooltip = true;

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
                <chart:SfCartesianChart>
                    <chart:SfCartesianChart.Title>
                        <Label Text="Height Comparison"/>
                    </chart:SfCartesianChart.Title>

                    <chart:SfCartesianChart.Legend>
                        <chart:ChartLegend/>
                    </chart:SfCartesianChart.Legend>
        
                    <chart:SfCartesianChart.PrimaryAxis>
                        <chart:CategoryAxis>
                            <chart:CategoryAxis.Title>
                                <chart:ChartAxisTitle Text="Name"/>
                            </chart:CategoryAxis.Title>
                        </chart:CategoryAxis>
                    </chart:SfCartesianChart.PrimaryAxis>

                    <chart:SfCartesianChart.SecondaryAxis>
                        <chart:NumericalAxis>
                            <chart:NumericalAxis.Title>
                                <chart:ChartAxisTitle Text="Height(in cm)"/>
                        </chart:NumericalAxis.Title>
                    </chart:NumericalAxis>
                </chart:SfCartesianChart.SecondaryAxis>

                <!--Initialize the series for chart-->
                    <chart:SfCartesianChart.Series>
                        <chart:ColumnSeries Label="Height" 
                                ShowTooltip="True"
                                ShowDataLabels="True"
                                ItemsSource="{Binding Data}"
                                XBindingPath="Name" 
                                YBindingPath="Height">
                            <chart:ColumnSeries.DataLabelSettings>
                                <chart:CartesianDataLabelSettings LabelPlacement="Inner"/>
                            </chart:ColumnSeries.DataLabelSettings>
                        </chart:ColumnSeries>
                    </chart:SfCartesianChart.Series>
                </chart:SfCartesianChart>
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
                SfCartesianChart chart = new SfCartesianChart();

                chart.Title = new Label
                {
                    Text = "Height Comparison"
                };

                // Initializing primary axis
                CategoryAxis primaryAxis = new CategoryAxis();
                primaryAxis.Title.Text = "Name";
                chart.PrimaryAxis = primaryAxis;

                //Initializing secondary Axis
                NumericalAxis secondaryAxis = new NumericalAxis();
                secondaryAxis.Title.Text = "Height(in cm)";
                chart.SecondaryAxis = secondaryAxis;

                //Initialize the two series for SfChart
                ColumnSeries series = new ColumnSeries()
                {
                    Label = "Height",
                    ShowDataLabels = true,
                    ItemsSource = (new ViewModel()).Data,
                    XBindingPath = "Name",
                    YBindingPath = "Height",
                    DataLabelSettings = new CartesianDataLabelSettings
                    {
                        LabelPlacement = Placement.Inner
                    }              
                };  

                //Adding Series to the Chart Series Collection
                chart.Series.Add(series);
                this.Content = chart;
            }
        }   
    }

{% endhighlight %}

{% endtabs %}

The following chart is created as a result of the previous codes.

![Getting started for .NET MAUI Chart](Getting-Started_Images/MAUI_chart.jpg)
