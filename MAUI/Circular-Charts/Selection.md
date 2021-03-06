---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart

Circular chart supports selection that allows to select or highlight a segment in the chart by using [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html).

## Enable Selection

To enable the selection in chart, create an instance of [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html) and set it to the [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionBehavior) property of circular chart. And also need to set the `SelectionBrush` property to highlight the segment in the series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.SelectionBehavior>
        <chart:ChartSelectionBehavior />
    </chart:SfCircularChart.SelectionBehavior>
<chart:SfCircularChart.Series>
    <chart:PieSeries SelectionBrush="BlueViolet"/>
</chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

ChartSelectionBehavior selection = new ChartSelectionBehavior();
chart.SelectionBehavior = selection;

PieSeries series = new PieSeries();
series.SelectionBrush = Brush.BlueViolet;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Segment selection support in MAUI Chart](Selection_images/maui_chart_segment_selection.png)

## Events

The following events are available in chart [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

### SelectionChanging

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionChanging) event occurs before the data point is being selected. This is a cancelable event. This argument contains the following information.

* [CurrentIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_CurrentIndex) - Gets the index of currently selected data point.
* [PreviousIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_PreviousIndex) - Gets the index of previously selected data point.
* [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_Series) - Gets the selected series.
* [Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionChangingEventArgs.html#Syncfusion_Maui_Charts_SelectionChangingEventArgs_Cancel) - Gets or sets a value indicating whether to continue the segment selection.

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SelectionChanged) event occurs after a data point has been selected. This argument contains the following information.

* [CurrentIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_CurrentIndex) - Gets the index of currently selected data point.
* [PreviousIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_PreviousIndex) - Gets the index of previously selected data point.
* [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionEventArgs.html#Syncfusion_Maui_Charts_SelectionEventArgs_Series) - Gets the selected series.
