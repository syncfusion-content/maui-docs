---
layout: post
title: Transform axis value to pixel value and vice-versa | Syncfusion
description: Learn here all about to transform axis value to pixel value and vice-versa in SfCartesianChart in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Transform axis value to pixel value and vice-versa

[`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) offers two utility methods to transform the pixel into a chart point and vice-versa.

* [`ValueToPoint(ChartAxis axis,double value)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_) - Converts the data point value to the screen point.
* [`PointToValue(ChartAxis axis,double x, double y)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_) - Converts the screen point to the chart value.

{% tabs %}

{% highlight C# %}


if (chart is SfCartesianChart cartesianChart)
{
    //Convert screen point to chart point.
    var xValue = cartesianChart.PointToValue(cartesianChart.XAxes[0], pointX, pointY);
    var yValue = cartesianChart.PointToValue(cartesianChart.YAxes[0], pointX, pointY);

    //Convert chart point to screen point.
    var xPoint = cartesianChart.ValueToPoint(cartesianChart.XAxes[0], xValue);
    var yPoint = cartesianChart.ValueToPoint(cartesianChart.YAxes[0], yValue);
    
}

{% endhighlight  %}

{% endtabs %}
