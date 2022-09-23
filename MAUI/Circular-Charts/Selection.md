---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI SfCircularChart

The [SfCircularChart]() provides selection behavior, which allows you to select or highlight a chart segment using the [DataPointSelectionBehavior]().

## Enable Selection

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

![Segment Selection Support in MAUI SfCircularChart](Selection_images/maui_chart_segment_selection.png)

## Properties

The Selection feature can be configured using the following properties:

* [Type]() - Gets or sets the ChartSelectionType Enum value for the Selection Behavior.     
The following ChartSelectionType can be achieved during Selection:
    * Single
    * SingleDeselect
    * Multiple
    * None
* [SelectionBrush]() - Gets or sets  the SelectionBrush color value for the Selection Behavior.
* [SelectedIndex]() - Gets or sets the index value of the segment that should be selected during the selection.
* [SelectedIndexes]() - Gets or sets the list of indexes of the segments that should be selected during the selection.

## Rendering Selection Programmatically

The [SfCircularChart]() provides support to select a point programmatically on a chart using the [SelectionBrush]() and  [SelectedIndex](), properties of the [ChartSelectionBehavior]().

{% tabs %}

{% highlight xaml %}

<chart:PieSeries>
    <chart:PieSeries.SelectionBehavior>
        <chart:DataPointSelectionBehavior SelectionBrush="BlueViolet" SelectedIndex="5" />
    </chart:PieSeries.SelectionBehavior>
</chart:PieSeries>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush = Brush.BlueViolet;
selection.SelectedIndex = 5;

PieSeries series = new PieSeries();
series.SelectionBehavior = selection;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Rendering Selection Programmatically in MAUI SfCircularChart](Selection_images/data_point_selection_properties.PNG)

## ClearSelection Method

The Selection Behavior has a public method called [ClearSelection ()](), which resets all current Selection Behavior property values to their default values.

{% tabs %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart ();

DataPointSelectionBehavior selection = new DataPointSelectionBehavior ();

PieSeries series = new PieSeries ();
series.SelectionBehavior = selection;
chart.Series.Add(series);

selection.ClearSelection();

{% endhighlight %}

{% endtabs %}

## Events

The following public Chart Selection Events are available in the [ChartSelectionBehavior]():

### SelectionChanging

The [SelectionChanging]() event is triggered before any data point has been selected. This event is cancelable because it inherits the CancelEventArgs, which has a public property [Cancel]() that holds a Boolean value indicating whether to continue the segment selection or not. The following properties are contained in the event arguments:

* [NewIndexes]() - Gets or sets the index of the selected data point before selection changes occur.
* [OldIndexes]() - Gets or sets the index of the deselected data point before selection changes occur.


### SelectionChanged

The [SelectionChanged]() event is triggered after a data point has been selected. The following properties are contained in the event arguments:

* [NewIndexes]() - Gets or sets the index of the selected data point after selection changes occur.
* [OldIndexes]() - Gets or sets the index of the deselected data point after selection changes occur.