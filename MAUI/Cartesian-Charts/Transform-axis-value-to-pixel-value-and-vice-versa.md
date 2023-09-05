---
layout: post
title: Transform axis value to pixel value and vice-versa | Syncfusion
description: Learn here all about to transform axis value to pixel value and vice-versa in SfCartesianChart in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Transform axis value to pixel value and vice-versa

[`SfCartesianChart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) offers two utility methods to transform the pixel to chart point and vice-versa.

* [`ValueToPoint(double value)`]() - Converts the data point value to screen point.
* [`PointToValue(double x, double y)`]() - Converts the screen point to chart value.

{% highlight c# %}

float chartPointX = chart.ValueToPoint(axis,Value);

double chartValue = chart.PointToValue(axis,xValue,yValue);

{% endhighlight  %}