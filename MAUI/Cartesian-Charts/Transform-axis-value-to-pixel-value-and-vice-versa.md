---
layout: post
title: Transform axis value to pixel value and vice-versa in .NET MAUI Cartesian Chart | Syncfusion
description: Learn how to transform an axis value to a pixel value and vice-versa in SfCartesianChart in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart transform axis value to pixel, maui chart axis value to pixel conversion, .net maui chart axis pixel to value, syncfusion maui chart axis coordinate transformation, sfCartesianChart axis value to pixel conversion in .net maui
---

# Transform axis value to pixel value and vice-versa in .NET MAUI Cartesian Chart

[SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) offers two utility methods to transform a pixel into a chart point and vice-versa.

* [`ValueToPoint(ChartAxis axis, double value)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) - Converts the data point value to the screen point.
* [`PointToValue(ChartAxis axis, double x, double y)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_) - Converts the screen point to the chart value.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight c# %}

if (chart is SfCartesianChart cartesianChart)
{
    // Convert screen point to chart point.
    var xValue = cartesianChart.PointToValue(cartesianChart.XAxes[0], pointX, pointY);
    var yValue = cartesianChart.PointToValue(cartesianChart.YAxes[0], pointX, pointY);

    // Convert chart point to screen point.
    var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], xValue);
    var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], yValue);
}

{% endhighlight  %}

{% endtabs %}
