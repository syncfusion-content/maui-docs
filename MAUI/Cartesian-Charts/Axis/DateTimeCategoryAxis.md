---
layout: post
title: DateTimeCategory Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: DateTimeCategory Axis in Syncfusion .NET MAUI Cartesian Chart displays date-based categories with support for intervals, labels, sorting, and customization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui datetimecategory axis, datetimecategory axis in maui chart, .net maui cartesian chart datetimecategory axis, syncfusion maui chart datetimecategory axis, maui chart date category axis, cartesian chart datetime category labels maui, sfcartesianchart datetimecategory axis, .net maui chart date categories.
---

# DateTimeCategory Axis in .NET MAUI Cartesian Chart

The [DateTimeCategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html) is a specialized type of axis primarily used with financial series. Similar to the [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html), all data points are plotted with equal spacing, eliminating visual gaps for missing dates. The intervals and ranges for this axis are calculated similarly to the [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), even if the difference between two points exceeds a year.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeCategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeCategoryAxis primaryAxis = new DateTimeCategoryAxis();
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeCategoryAxis support in .NET MAUI Cartesian Chart](Axis_images/maui_dateTimeCategory_axis.png)

## Interval

In [DateTimeCategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html), intervals can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html#Syncfusion_Maui_Charts_DateTimeCategoryAxis_Interval) and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html#Syncfusion_Maui_Charts_DateTimeCategoryAxis_IntervalType) properties, similar to [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html). For example, setting [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html#Syncfusion_Maui_Charts_DateTimeCategoryAxis_Interval) as 5 and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html#Syncfusion_Maui_Charts_DateTimeCategoryAxis_IntervalType) as [Days](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeIntervalType.html#Syncfusion_Maui_Charts_DateTimeIntervalType_Days) will consider 5 days as an interval.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeCategoryAxis Interval="5" 
                                    IntervalType="Days"/> 
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart(); 
DateTimeCategoryAxis primaryAxis = new DateTimeCategoryAxis() 
{ 
    Interval = 5, 
    IntervalType = DateTimeIntervalType.Days 
}; 
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart; 

{% endhighlight %}

{% endtabs %}

![DateTimeCategoryAxis interval support in .NET MAUI Cartesian Chart](Axis_images/maui_dateTimeCategory_interval.png)