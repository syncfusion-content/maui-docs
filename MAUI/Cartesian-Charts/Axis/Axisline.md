---
layout: post
title: Axis line in .NET MAUI Chart control | Syncfusion
description: Learn here all about the chart axis line and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis line in .NET MAUI Chart (SfCartesianChart)

## Customization

Cartesian chart axis provides support to customize the style of axis line by defining the [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle) property as shown in the below code snippet.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis >
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth ="10" Stroke="Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    NumericalAxis primaryAxis = new NumericalAxis();

    ChartLineStyle axisLineStyle = new ChartLineStyle();

    axisLineStyle.Stroke = Colors.Red;

    axisLineStyle.StrokeWidth = 10;

    primaryAxis.AxisLineStyle = axisLineStyle;

    chart.PrimaryAxis = primaryAxis;

{% endhighlight %}

{% endtabs %}

## Offset

The padding to the axis line is defined by using the [AxisLineOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineOffset) property.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis AxisLineOffset="25">
            <chart:NumericalAxis.AxisLineStyle>

                <chart:ChartLineStyle StrokeWidth ="10" Stroke="Red"/>

            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    NumericalAxis primaryAxis = new NumericalAxis();

    primaryAxis.AxisLineOffset = 25;

    ChartLineStyle axisLineStyle = new ChartLineStyle();

    axisLineStyle.Stroke = Colors.Red;

    axisLineStyle.StrokeWidth = 10;

    primaryAxis.AxisLineStyle = axisLineStyle;

    chart.PrimaryAxis = primaryAxis;

{% endhighlight %}

{% endtabs %}
