---
layout: post
title: Axis padding in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about how to set padding for chart axis in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart axis padding, .net maui cartesian chart axis spacing, .net maui cartesian chart axis padding guide, syncfusion maui cartesian chart axis padding, cartesian chart axis padding maui, .net maui cartesian chart axis margin, customize axis padding .net maui cartesian chart.
---

# Axis Padding in .NET MAUI Cartesian Chart

## PlotOffsetStart

The [PlotOffsetStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetStart) property, of type `double` and measured in pixels (px), is used to provide padding to the axis at the start position. The default value is `0`. The following code sample demonstrates the padding applied to the start position for both the X and Y axes.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

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
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![PlotOffsetStart support in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_plot-offset-start.jpg)

## PlotOffsetEnd

The [PlotOffsetEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetEnd) property, of type `double` and measured in pixels (px), is used to provide padding to the axis at the end position. The default value is `0`. The following code sample demonstrates the padding applied to the end position for both the X and Y axes.

> **NOTE:** `PlotOffsetStart` and `PlotOffsetEnd` set padding at the edges of the plot area; for rounding/spacing of the visible axis range, use the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_RangePadding) property instead.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

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
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![PlotOffsetEnd support in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_plot-offset-end.jpg)