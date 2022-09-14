---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart

[SfCircularChart]() supports selection that allows you to select or highlight a segment in the chart by using [DataPointSelectionBehavior]().

## Data Point Selection

To enable the data point selection in the [SfCircularChart](), create an instance of [DataSelectionBehavior]() and set a color value for[SelectionBrush]() property to highlight the segment in the series. Then set the selection instance to the [SelectionBehavior]() property of the chart series.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.Series>
        <chart:PieSeries>
            <chart:PieSeries.SelectionBehavior>
                <chart:DataPointSelectionBehavior SelectionBrush="BlueViolet"/>
            </chart:PieSeries.SelectionBehavior>
        </chart:PieSeries>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush = Brush.BlueViolet;

PieSeries series = new PieSeries();
series.SelectionBehavior = selection;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Segment selection support in MAUI CircularChart](Selection_images/maui_chart_segment_selection.png)

## Properties

The following properties are used to configure the selection feature,

* [Type]() - Gets the ChartSelectionType enum value for Selection behavior.     
And the following types are in ChartSelectionType :
    * ChartSelectionType.None
    * ChartSelectionType.Single
    * ChartSelectionType.SingleDeselect
    * ChartSelectionType.Multiple
* [SelectionBrush]() - Gets the Selection brush color for Selection behavior.
* [SelectedIndex]() - Gets the index of segment to be selected in Selection behavior.
* [SelectedIndexes]() - Gets the list of segments to be selected in Selection behavior.

{% tabs %}

{% highlight xaml %}

<chart:PieSeries>
    <chart:PieSeries.SelectionBehavior>
        <chart:DataPointSelectionBehavior SelectionBrush="BlueViolet" SelectedIndex="5" Type="Single"/>
    </chart:PieSeries.SelectionBehavior>
</chart:PieSeries>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush = Brush.BlueViolet;
selection.SelectedIndex = 5;
selection.Type = ChartSelectionType.Single;

PieSeries series = new PieSeries();
series.SelectionBehavior = selection;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![SelectionBrush, SelectedIndex and Type properties in DataPointSelectionBehavior](Selection_images/data_point_selection_properties.PNG)

## Methods

The Selection Behavior has a public method called [ClearSelecton()](), which resets all the current Selection properties to default.

## Events

The following events are available in chart [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

### SelectionChanging

The [SelectionChanging]() event occurs before the data point is being selected. This is a cancelable event. This argument contains the following information.

* [NewIndexws]() - Gets the index of currently selected data point.
* [OldIndexes]() - Gets the index of previously selected data point.
* [Cancel]() - Gets a boolean value indicating whether to continue the segment selection or not.

### SelectionChanged

The [SelectionChanged]() event occurs after a data point has been selected. This argument contains the following information.

* [NewIndexes]() - Gets the index of currently selected data point.
* [OldIndexes]() - Gets the index of previously selected data point.
