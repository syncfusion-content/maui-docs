---
layout: post
title: Axis padding in .NET MAUI Chart control | Syncfusion®
description: Learn here all about how to set padding for chart axis in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui chart axis padding, .net maui chart axis spacing, .net maui chart axis padding guide, syncfusion maui chart axis padding, cartesian chart axis padding maui, .net maui chart axis margin, customize axis padding .net maui chart.
---

# Axis Padding in .NET MAUI Chart

## PlotOffsetStart

The [PlotOffsetStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetStart) property is used to provide padding to the axis at start position. The following code sample demonstrates the padding applied to Start position for both x and y-axes.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.YAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    PlotOffsetStart = 30
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    PlotOffsetStart = 30
};
chart.YAxes.Add(secondaryAxis);
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![PlotOffsetStart support in MAUI Chart](Axis_images/maui_chart_axis_plot-offset-start.jpg)

## PlotOffsetEnd

The [PlotOffsetEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetEnd) property is used to provide padding to the axis at end position. The following code sample demonstrates the padding applied to end position for both x and y-axes.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.YAxes>
    . . .
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    PlotOffsetEnd = 30
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    PlotOffsetEnd = 30
};
chart.YAxes.Add(secondaryAxis);
. . .
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![PlotOffsetEnd support in MAUI Chart](Axis_images/maui_chart_axis_plot-offset-end.jpg)