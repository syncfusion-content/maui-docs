---
layout: post
title: Scatter Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the scatter chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug 
keywords: .net maui scatter chart, maui scatter chart, scatter chart customization .net maui, syncfusion maui scatter chart, cartesian scatter chart maui, .net maui chart scatter visualization, .net maui point chart.
---

# Scatter Chart in .NET MAUI Chart

The scatter chart is used to represent the each data point by a dot or circle with equal size.

To render a scatter chart, create an instance of [ScatterSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ScatterSeries.html?tabs=tabid-1), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1). The segment size can be defined by using the [PointHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ScatterSeries.html#Syncfusion_Maui_Charts_ScatterSeries_PointHeight) and [PointWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ScatterSeries.html#Syncfusion_Maui_Charts_ScatterSeries_PointWidth) properties.

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>  
                
    <chart:ScatterSeries PointHeight="7"
                        PointWidth="7"
                        ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        YBindingPath="YValue"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ScatterSeries series = new ScatterSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    PointHeight = 7,
    PointWidth = 7,
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Scatter chart type in MAUI Chart](Chart-types-images/maui_scatter_chart.jpg)