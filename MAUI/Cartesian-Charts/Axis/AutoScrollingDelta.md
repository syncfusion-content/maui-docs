---
layout: post
title: Auto scrolling in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about auto scrolling and its features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart auto scrolling, .net maui chart scrolling customization, .net maui chart auto scroll feature, syncfusion maui chart auto scrolling, cartesian chart auto scroll maui, .net maui chart dynamic scrolling, enable auto scrolling .net maui chart.
---

# Auto scrolling in .NET MAUI Cartesian Chart

Auto-scrolling in .NET MAUI Cartesian Chart ensures that a specified range of data is always visible, making it ideal for real-time data feeds and streaming dashboards. The [AutoScrollingDelta](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AutoScrollingDelta) property of the chart axis sets the number of data points to be always visible. As new data points are added, the visible range scrolls to keep them in view, and you can use the [AutoScrollingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AutoScrollingMode) property to control the scroll direction.

By adding [ChartZoomPanBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html) to the chart, you can manually scroll to view previous data points.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **Cartesian Chart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis AutoScrollingDelta="3"/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.ZoomPanBehavior>
        <chart:ChartZoomPanBehavior EnablePanning="True"/>
    </chart:SfCartesianChart.ZoomPanBehavior>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis()
{
    AutoScrollingDelta = 3,
};
chart.XAxes.Add(primaryAxis);

ChartZoomPanBehavior zooming = new ChartZoomPanBehavior()
{
    EnablePanning = true
};
chart.ZoomPanBehavior = zooming;
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Auto scrolling mode

The [AutoScrollingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AutoScrollingMode) property of the [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) class determines whether the axis scrolls from the start or end of the data. The [ChartAutoScrollingMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAutoScrollingMode.html) enum provides the following values:

- `Start` — Scrolls from the start, keeping earlier data points visible as new data is added.
- `End` — Scrolls from the end (default), keeping the latest data points visible as new data is added.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis AutoScrollingDelta="3" AutoScrollingMode="Start"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis()
{
    AutoScrollingDelta = 3,
    AutoScrollingMode = ChartAutoScrollingMode.Start
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Auto scrolling delta type

When using [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) in .NET MAUI Cartesian Chart, you can set the time unit for auto-scrolling delta using the [AutoScrollingDeltaType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_AutoScrollingDeltaType) property. The [DateTimeDeltaType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeDeltaType.html) enum provides the following values:

- `Years` — Sets delta in years.
- `Months` — Sets delta in months.
- `Days` — Sets delta in days.
- `Hours` — Sets delta in hours.
- `Minutes` — Sets delta in minutes.
- `Seconds` — Sets delta in seconds.
- `Milliseconds` — Sets delta in milliseconds.
- `Auto` (default) — Calculates the delta automatically based on the data range.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis AutoScrollingDelta="3" AutoScrollingDeltaType="Days"/>
    </chart:SfCartesianChart.XAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    AutoScrollingDelta = 3,
    AutoScrollingDeltaType = DateTimeDeltaType.Days
};
chart.XAxes.Add(primaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}