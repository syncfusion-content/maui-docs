---
layout: post
title: Get the data point collection in Syncfusion SfCartesianChart
description: Get the data points that fall inside a given rectangular area or within specified X and Y coordinate ranges in SfCartesianChart
platform: maui
control: SfCartesianChart
documentation: ug
---

# Get the data point collection based on region

[CartesianSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html) provides the following methods to get a collection of data under a particular region.

* [`GetDataPoints(Rect rectangle)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_GetDataPoints_Microsoft_Maui_Graphics_Rect_) - Gets the collection of data that falls inside the given rectangle region.
* [`GetDataPoints(double startX, double endX, double startY, double endY)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_GetDataPoints_System_Double_System_Double_System_Double_System_Double_) - Gets the collection of data from the given axis visible range.

{% tabs %}

{% highlight c# %}

//Gets the collection of data that falls inside the given rectangle region.
List<object> dataPoints = Series.GetDataPoints(rectangle);

or

//Gets the collection of data from the given axis visible range.
List<object> dataPoints = Series.GetDataPoints(startX, endX, startY, endY);

{% endhighlight  %}

{% endtabs %}

N> You can get the visible plotting region of the series in the chart using [SeriesBounds](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SeriesBounds) property in run time.

## See also 

[How to highlight selected data points by using GetDataPoints method in .NET MAUI Cartesian Charts](https://support.syncfusion.com/kb/article/16174/how-to-highlight-selected-data-points-by-using-getdatapoints-method-in-net-maui-cartesian-charts)