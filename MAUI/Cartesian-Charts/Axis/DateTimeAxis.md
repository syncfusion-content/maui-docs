---
layout: post
title: DateTime Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: DateTime Axis in Syncfusion .NET MAUI Cartesian Chart displays time-based data with support for intervals, formatting, ranges, and customization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui datetime axis, datetime axis in maui chart, .net maui cartesian chart datetime axis, syncfusion maui chart datetime axis, maui chart date axis, cartesian chart time series maui, sfcartesianchart datetime axis, .net maui chart date labels.
---

# DateTime Axis in .NET MAUI Cartesian Chart

[DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) is used to plot `DateTime` values. The [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) is widely used in financial charts such as stock market charts, where data is plotted daily.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_datetime_axis.jpg)

To customize the [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) in .NET MAUI Cartesian Charts, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=Z_ZIJ1zlVg0" %}

## Interval

In [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), intervals can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Interval) and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_IntervalType) properties. For example, setting [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Interval) as 6 and [IntervalType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_IntervalType) as [Months](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeIntervalType.html#Syncfusion_Maui_Charts_DateTimeIntervalType_Months) will consider 6 months as an interval. The default value of the IntervalType is `DateTimeIntervalType.Auto`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis Interval="6" IntervalType="Months"/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Interval = 6, 
    IntervalType = DateTimeIntervalType.Months
};
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis interval support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_datetime_axis_interval.jpg)

## Customizing the range

[Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Minimum) and [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_Maximum) properties behave the same as in [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html); instead of numeric values, `DateTime` values must be used.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis Minimum="2021/05/10" Maximum="2021/11/01"/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Minimum = new DateTime(2021, 05, 10),
    Maximum = new DateTime(2021, 11, 01),
};
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range customization support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_datetime_axis_range.jpg)