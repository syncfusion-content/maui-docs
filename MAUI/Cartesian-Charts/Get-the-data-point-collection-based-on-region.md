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

* [`GetDataPoints(Rect rectangle)`]() - Method to get the collection of data that fall inside the given rectangle region. 
* [`GetDataPoints(double startX, double endX, double startY, double endY)`]() - Method to get the data points from the given range.

{% tabs %}

{% highlight c# %}

    //Get the collection of data that fall inside the given rectangle
    List<object> dataPoints = Series.GetDataPoints(rectangle);

    or

    //Get the data points from the given range.
    List<object> dataPoints = Series.GetDataPoints(startX, endX, startY, endY);

{% endhighlight  %}

{% endtabs %}

N> You can get the visible plotting region of the series in the chart using [SeriesBounds]() property in run time.