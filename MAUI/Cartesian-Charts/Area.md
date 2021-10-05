---
layout: post
title: Area Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the area chart types and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Area Chart in .NET MAUI Chart

## Area Chart

The area chart is rendered by using a collection of line segments connected to form a closed loop area, filled with the specified color. To render a area chart, create an instance of [AreaSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AreaSeries.html?tabs=tabid-1) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the chart.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis />
        </chart:SfCartesianChart.PrimaryAxis>

        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.SecondaryAxis>   

        <chart:SfCartesianChart.Series>
            <chart:AreaSeries ItemsSource="{Binding Data}" XBindingPath="Demand" YBindingPath="Year2010"/>  
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

    AreaSeries series = new AreaSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Area chart type in MAUI Chart](Chart-types_images/maui_area_chart.png)

## Spline Area Chart

The [SplineAreaSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SplineAreaSeries.html?tabs=tabid-1) connects a series of data points using smooth bezier line curves, with the underlying areas filled.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis />
        </chart:SfCartesianChart.PrimaryAxis>

        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.SecondaryAxis>
                
        <chart:SfCartesianChart.Series>
            <chart:SplineAreaSeries ItemsSource="{Binding Data}" XBindingPath="Demand" YBindingPath="Year2010"/>  
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

    SplineAreaSeries series = new SplineAreaSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Spline area chart type in MAUI Chart](Chart-types_images/maui_spline_area_chart.png)

