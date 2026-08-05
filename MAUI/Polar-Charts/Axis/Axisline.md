---
layout: post
title: Axis Line in .NET MAUI Polar Chart | Syncfusion
description: Axis line in .NET MAUI Polar Chart defines the visual representation of chart axes, helping organize data and improve chart readability.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis Line in .NET MAUI Polar Chart

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