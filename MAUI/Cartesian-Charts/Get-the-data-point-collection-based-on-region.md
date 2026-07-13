---
layout: post
title: Get the data point collection based on region in .NET MAUI Cartesian Chart | Syncfusion
description: Get the data points that fall inside a given rectangular area or within specified X and Y coordinate ranges in SfCartesianChart.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart data point collection, get data points by region, sfCartesianChart get data points rectangle, .net maui chart point collection by axis range
---

# Get the data point collection based on region

[CartesianSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html) provides the following methods to get a collection of data under a particular region.

* [`GetDataPoints(Rect rectangle)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_GetDataPoints_Microsoft_Maui_Graphics_Rect_) - Gets the collection of data that falls inside the given rectangle region.
* [`GetDataPoints(double startX, double endX, double startY, double endY)`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_GetDataPoints_System_Double_System_Double_System_Double_System_Double_) - Gets the collection of data from the given axis visible range.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight c# %}

// Gets the collection of data that falls inside the given rectangle region.
List<object> dataPoints = Series.GetDataPoints(rectangle);

// Gets the collection of data from the given axis visible range.
List<object> dataPoints = Series.GetDataPoints(startX, endX, startY, endY);

{% endhighlight  %}

{% endtabs %}

N> You can get the visible plotting region of the series in the chart using the [SeriesBounds](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SeriesBounds) property at runtime.

## See also

* [How to highlight selected data points by using GetDataPoints method in .NET MAUI Cartesian Charts](https://support.syncfusion.com/kb/article/16174/how-to-highlight-selected-data-points-by-using-getdatapoints-method-in-net-maui-cartesian-charts)
* [Transform axis value to pixel value and vice-versa](https://help.syncfusion.com/maui/cartesian-charts/transform-axis-value-to-pixel-value-and-vice-versa)