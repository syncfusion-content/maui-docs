---
layout: post
title: Axis padding in .NET MAUI Chart control | Syncfusion
description: Learn here all about how to set padding for chart axis in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis Padding in .NET MAUI Chart

## PlotOffsetStart

The [PlotOffsetStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetStart) property is used to provide padding to the axis at start position. The following code sample demonstrates the padding applied to Start position for both x and y-axes.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:CategoryAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis PlotOffsetStart="30"/>
    </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new CategoryAxis()
    {
    PlotOffsetStart = 30
    };

    chart.SecondaryAxis = new NumericalAxis()
    {
    PlotOffsetStart = 30
    };

{% endhighlight %}

{% endtabs %}

## PlotOffsetEnd

The [PlotOffsetEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetEnd) property is used to provide padding to the axis at end position. The following code sample demonstrates the padding applied to end position for both x and y-axes.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:CategoryAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis PlotOffsetEnd="30"/>
    </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new CategoryAxis()
    {
    PlotOffsetEnd = 30
    };

    chart.SecondaryAxis = new NumericalAxis()
    {
    PlotOffsetEnd = 30
    };

{% endhighlight %}

{% endtabs %}