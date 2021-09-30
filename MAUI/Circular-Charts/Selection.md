---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart (SfCircularChart)

Circular chart supports selection that allows to select or highlight a segment in the chart by using `ChartSelectionBehavior`.

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

The `Type` property allows users to set selection type of series, which includes `Point` and `None`. `Type` property with `Point` value is used to select segment in a series and `None` is used to set deselect state for all segments. 

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

* `CurrentIndex` - Gets the index of currently selected data point.
* `PreviousIndex` - Gets the index of previously selected data point.
* `Series` - Gets the selected series.
* `Cancel` - Gets or sets a value indicating whether to continue the segment selection.

### SelectionChanged

The `SelectionChanged` event occurs after a data point has been selected. This argument contains the following information.

* `CurrentIndex` - Gets the index of currently selected data point.
* `PreviousIndex` - Gets the index of previously selected data point.
* `Series` - Gets the selected series.