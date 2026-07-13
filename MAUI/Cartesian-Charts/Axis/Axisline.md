---
layout: post
title: Axis line in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about the chart axis line and its customization in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart axis line, .net maui chart axis customization, .net maui chart axisline guide, maui chart axis line settings, syncfusion maui chart axis line, .net maui chart axis styling, customize axis line .net maui chart.
---

# Axis line in .NET MAUI Cartesian Chart

The axis line in .NET MAUI Cartesian Chart visually represents the axis itself in the chart area. You can customize its appearance, including stroke color, width, and dash patterns, using the [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle) property. Additionally, you can control the spacing between the axis and the chart area using the [AxisLineOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineOffset) property.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Cartesian Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

## Customizing axis line style

The [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle) property allows you to customize the axis line appearance. The [ChartLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLineStyle.html) class provides the following properties:

* `Stroke` — Sets the color of the axis line.
* `StrokeWidth` — Sets the width of the axis line in pixels.
* `DashArray` — Sets the dash pattern for the axis line (e.g., solid, dotted, dashed).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth="2" Stroke="Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
ChartLineStyle axisLineStyle = new ChartLineStyle()
{
    Stroke = Colors.Red,
    StrokeWidth = 2
};
primaryAxis.AxisLineStyle = axisLineStyle;
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis line customization support in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_linestyle.jpg)

## Axis line offset

The [AxisLineOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineOffset) property controls the distance between the axis line and the chart area in device-independent pixels (DIPs). The default value is `0`. A positive value moves the axis line away from the chart area, while a negative value moves it closer.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis AxisLineOffset="25">
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth="2" Stroke="Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.AxisLineOffset = 25;
ChartLineStyle axisLineStyle = new ChartLineStyle()
{
    Stroke = Colors.Red,
    StrokeWidth = 2
};
primaryAxis.AxisLineStyle = axisLineStyle;
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis line offset support in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_line_offset.jpg)
