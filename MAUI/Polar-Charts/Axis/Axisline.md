---
layout: post
title: Axis line in .NET MAUI Polar Chart control | Syncfusion
description: Learn here all about the chart axis line and its customization in the Syncfusion® .NET MAUI Polar Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis line in .NET MAUI Polar Chart

## Customization

The polar chart axis provides support for customizing the style of the axis line by defining the [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle) property, as shown in the code sample below.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfPolarChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/polar-charts/getting-started)** guide.

N> The customization of axis lines using the `AxisLineStyle` property can only be applied to the secondary axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <!-- code omitted for brevity -->
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth = "2" Stroke = "Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity
NumericalAxis secondaryAxis = new NumericalAxis();
ChartLineStyle axisLineStyle = new ChartLineStyle()
{
    Stroke = Colors.Red,
    StrokeWidth = 2
};
secondaryAxis.AxisLineStyle = axisLineStyle;
chart.SecondaryAxis = secondaryAxis;

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Offset

The padding for the axis line is defined by using the [AxisLineOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineOffset) property. The value is specified in pixels (px).

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <!-- code omitted for brevity -->
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis AxisLineOffset = "25">
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth = "2" Stroke = "Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
// code omitted for brevity
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.AxisLineOffset = 25;
ChartLineStyle axisLineStyle = new ChartLineStyle()
{
    Stroke = Colors.Red,
    StrokeWidth = 2
};
secondaryAxis.AxisLineStyle = axisLineStyle;
chart.SecondaryAxis = secondaryAxis;

this.Content = chart;

{% endhighlight %}

{% endtabs %}