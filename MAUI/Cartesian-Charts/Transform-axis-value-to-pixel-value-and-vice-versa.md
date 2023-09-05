---
layout: post
title: Transform axis value to pixel value and vice-versa | Syncfusion
description: Learn here all about to transform axis value to pixel value and vice-versa in SfCartesianChart in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Transform axis value to pixel value and vice-versa

[`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1%2Ctabid-3%2Ctabid-6%2Ctabid-8%2Ctabid-10%2Ctabid-12%2Ctabid-25%2Ctabid-27%2Ctabid-29%2Ctabid-23%2Ctabid-14%2Ctabid-37%2Ctabid-17%2Ctabid-19%2Ctabid-21) offers two utility methods to transform the pixel to chart point and vice-versa.

* [`ValueToPoint(double value)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ValueToPoint_System_Double_) - Converts the data point value to screen point.
* [`PointToValue(double x, double y)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PointToValue_System_Double_System_Double_) - Converts the screen point to chart value.

{% highlight c# %}

double chartPointX = Chart.ValueToPoint(xValue);

double chartPointY = Chart.ValueToPoint(yValue);

double chartValue = Chart.PointToValue(xValue,yValue);

{% endhighlight  %}

Use the [`ValueToPoint`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ValueToPoint_System_Double_) and [`PointToValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PointToValue_System_Double_System_Double_) methods, which are available in [`ChartAxis`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html?tabs=tabid-7%2Ctabid-5%2Ctabid-11%2Ctabid-15%2Ctabid-13%2Ctabid-21%2Ctabid-33%2Ctabid-19%2Ctabid-9%2Ctabid-23%2Ctabid-25%2Ctabid-3%2Ctabid-1%2Ctabid-31%2Ctabid-17%2Ctabid-29%2Ctabid-27%2Ctabid-37%2Ctabid-35), to convert the screen point within the rendered area of the series.