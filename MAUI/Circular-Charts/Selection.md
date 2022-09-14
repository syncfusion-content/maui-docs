---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart

[SfCircularChart]() provides selection behavior, which allows you to select or highlight a chart segment using [DataPointSelectionBehavior]().

## Data Point Selection

To enable the data point selection in the [SfCircularChart](), create an instance of [DataPointSelectionBehavior]() and specify a color value for the [SelectionBrush]() property to highlight the selected segment in the series. The selection instance should then be set to the chart series [SelectionBehavior]() property.

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

The Selection feature can be configured using the following properties:

* [Type]() - Retrieves the ChartSelectionType Enum value for the Selection Behavior.     
And the following SelectionType can be achieved during Selection:
    * ChartSelectionType.None
    * ChartSelectionType.Single
    * ChartSelectionType.SingleDeselect
    * ChartSelectionType.Multiple
* [SelectionBrush]() - Retrieves the SelectionBrush color value for Selection Behavior.
* [SelectedIndex]() - Retrieves the index value of the segment that should be selected during the Selection.
* [SelectedIndexes]() - Retrieves the list of indexes of the segments that should be selected during the Selection.

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

The Selection Behavior has a public method called [ClearSelection ()](), which resets all current Selection Behavior property values to their default values.

## Events

The following public Chart Selection Events are available in [ChartSelectionBehavior]().

### SelectionChanging

The [SelectionChanging]() event is triggered before any data point has been selected. This event is cancelable, and these details are contained in the following event arguments.

* [NewIndexes]() - Holds the index of the currently selected data point.
* [OldIndexes]() - Holds the index of the previously selected data point.
* [Cancel]() - Returns a Boolean value indicating whether to continue the segment selection or not.

### SelectionChanged

The [SelectionChanged]() event is triggered after a data point has been selected. And these following details are contained in the following event arguments.

* [NewIndexes]() - Holds the index of the currently selected data point.
* [OldIndexes]() - Holds the index of the previously selected data point.
