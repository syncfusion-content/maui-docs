---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart (SfCircularChart)

Circular chart supports selection that allows to select a segment in a series by using `ChartSelectionBehavior`. 

## Enable Selection

To enable the selection in chart, create an instance of `ChartSelectionBehavior` and add it to the `ChartBehaviors` collection of circular chart. And also need to set the `SelectionBrush` property to highlight the segment in the series.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>
        <chart:SfCircularChart.ChartBehaviors>
            <chart:ChartSelectionBehavior />
        </chart:SfCircularChart.ChartBehaviors>
    <chart:SfCircularChart.Series>
        <chart:PieSeries SelectionBrush="BlueViolet"/>
    </chart:SfCircularChart.Series>
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    ChartSelectionBehavior selection = new ChartSelectionBehavior();
    chart.ChartBehaviors.Add(selection);

    PieSeries series = new PieSeries();
    series.SelectionBrush = Brush.BlueViolet;
    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Selection Type

Circular chart allows to select single or None using `Type` property. By default the `Type` value is `Point`.

{% tabs %}

{% highlight xml %}

    <chart:SfCircularChart>
    . . .
        <chart:SfCircularChart.ChartBehaviors>
            <chart:ChartSelectionBehavior Type="Point"/>
        </chart:SfCircularChart.ChartBehaviors>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();
    . . .
    ChartSelectionBehavior selection = new ChartSelectionBehavior();
    selection.Type = SelectionType.Point;
    chart.ChartBehaviors.Add(selection);

{% endhighlight %}

{% endtabs %}

## Events

The following events are available in chart `SfCircularChart`.

### SelectionChanging

The `SelectionChanging` event occurs before the data point is being selected. This is a cancelable event. This argument contains the following information.

* `SelectedSeries` - Gets the series of the selected data point.
* `SelectedSegments` - Gets or sets the segments collection of the selected series.
* `SelectedSegment` - Gets the segment of the selected data point.
* `SelectedIndex` - Gets the selected data point index.
* `PreviousSelectedIndex` - Gets the previous selected data point index.
* `IsDataPointSelection` - Gets a value that indicates whether the selection is segment selection or series selection.
* `Cancel` - Gets or Sets a value that indicates whether the selection should be canceled.

### SelectionChanged

The `SelectionChanged` event occurs after a data point has been selected. This argument contains the following information.

* `SelectedSeries` - Gets the series of the selected data point.
* `SelectedSegments` - Gets the segments collection of the selected series.
* `SelectedSegment` - Gets the segment of the selected data point.
* `SelectedIndex` - Gets the selected data point index.
* `PreviousSelectedSeries` - Gets the previous selected series.
* `PreviousSelectedIndex` - Gets the previous selected data point index.
* `IsDataPointSelection` - Gets a value that indicates whether the selection is segment selection or series selection.
* `SelectedSeriesCollection` - Gets the series collection that has been selected through rectangle selection or mouse interaction.
