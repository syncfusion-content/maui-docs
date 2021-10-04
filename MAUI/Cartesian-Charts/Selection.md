---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: Learn here all about selection and multi-selection support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Selection in .NET MAUI Chart (SfCartesianChart)

Cartesian chart supports selection that allows to select or highlight a segment in the chart by using `ChartSelectionBehavior`.

## Enable Selection

To enable the selection in chart, create an instance of `ChartSelectionBehavior` and add it to the `ChartBehaviors` collection of `SfCartesianChart`. And also need to set the `SelectionBrush` property to highlight the segment in the chart.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartSelectionBehavior />
        </chart:SfCartesianChart.ChartBehaviors>

        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Demand"
                            YBindingPath="Year2010"
                            SelectionBrush="Green"/>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ChartSelectionBehavior selection = new ChartSelectionBehavior();
chart.ChartBehaviors.Add(selection);

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    SelectionBrush = Brush.Green
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Segment selection support in MAUI Chart](Selection_images/MAUI_chart_segment_selection.png)

## Selection Type

The `Type` property allows users to set selection type of series, which includes `Point` and `None`. `Type` property with `Point` value is used to select segment in a series and `None` is used to set deselect state for all segments. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartSelectionBehavior  Type="Point"/>
        </chart:SfCartesianChart.ChartBehaviors>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}"  
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                SelectionBrush="Green"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ChartSelectionBehavior selection = new ChartSelectionBehavior();
    selection.Type = SelectionType.Point;
    chart.ChartBehaviors.Add(selection);

    ColumnSeries series = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        SelectionBrush = Brush.Green
    };
    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Selection on initial rendering

Cartesian chart provides support to select a point programmatically on a chart using the `SelectedIndex` property of series.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
        <chart:SfCartesianChart.ChartBehaviors>
            <chart:ChartSelectionBehavior/>
        </chart:SfCartesianChart.ChartBehaviors>

        <chart:SfCartesianChart.Series>
            <chart:ColumnSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Demand"
                                YBindingPath="Year2010" 
                                SelectionBrush="Green"
                                SelectedIndex="3"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    ChartSelectionBehavior selection = new ChartSelectionBehavior();
    chart.ChartBehaviors.Add(selection);

    ColumnSeries series = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        SelectionBrush = Brush.Green,
        SelectedIndex = 3
    };
    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Initial selection rendering support in MAUI Chart](Selection_images/MAUI_chart_selected_index.png)

## Events

The following selection events are available in the `SfCartesianChart`.

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
