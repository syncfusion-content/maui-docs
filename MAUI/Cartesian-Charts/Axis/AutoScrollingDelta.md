---
layout: post
title: Auto scrolling delta in .NET MAUI Chart control | Syncfusion
description: Learn here all about auto scrolling delta and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
---

# AutoScrollingDelta in .NET MAUI Chart

[AutoScrollingDelta]() ensures that the specified range of data is always visible in the chart. It always shows the recently added data points at the end, and scrolling will be reset to the end of the range whenever a new point is added.

By adding [ChartZoomPanBehavior]() to the chart, you can scroll to see the previous data points.

## AutoScrollingMode

[AutoScrollingMode]() property can be used to determine whether the axis should be scrolled from start position or end position. The default value of [AutoScrollingMode]() is End.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis AutoScrollingDelta="3" AutoScrollingMode="Start"/>
        </chart:SfCartesianChart.XAxes>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis()
    {
        AutoScrollingDelta = 3,
        AutoScrollingMode = ChartAutoScrollingMode.start,
    };
    chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

## AutoScrollingDeltaType

In [DateTimeAxis](), you can apply auto scrolling delta value in [Years](), [Months](), [Days](), [Hours](), [Minutes](), [Seconds]() and [Milliseconds]() by setting [AutoScrollingDeltaType]() property. The default value of this property is [Auto](), and the delta will be calculated automatically based on range.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.XAxes>
            <chart:DateTimeAxis AutoScrollingDelta="3" AutoScrollingDeltaType="Days"/>
        </chart:SfCartesianChart.XAxes>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    DateTimeAxis primaryAxis = new DateTimeAxis()
    {
        AutoScrollingDelta = 3,
        AutoScrollingDeltaType = DateTimeDeltaType.Days,
    };
    chart.XAxes.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}