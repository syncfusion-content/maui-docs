---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: Learn here all about selection and multi-selection support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Selection in .NET MAUI Chart (SfCartesianChart)

Cartesian chart supports selection that allows to select a segment or series in the chart by using `ChartSelectionBehavior`. 

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

## Segment Selection in Linear Series

In linear type series the segment selection can be viewed by changing the data label interior.

The following code example demonstrates the spline series segment selection by changing the data label interior.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.ChartBehaviors>
        <chart:ChartSelectionBehavior />
    </chart:SfCartesianChart.ChartBehaviors>

    <chart:SplineSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Demand"
                        YBindingPath="Year2010"
                        SelectionBrush="Green"
                        ShowDataLabels="True"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ChartSelectionBehavior selection = new ChartSelectionBehavior();
chart.ChartBehaviors.Add(selection);

SplineSeries series = new SplineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    SelectionBrush = Brush.Green,
    ShowDataLabels="True" 
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Selection Type

Cartesian chart provides support to select single or None by using the `Type` property. `Type` property with `Point` value is used to select segment in a series and `None` is used for not to select any segment.

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

## Events

The following selection events are available in the `SfCartesianChart`.

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
* `SelectedSegments`) - Gets the segments collection of the selected series.
* `SelectedSegment` - Gets the segment of the selected data point.
* `SelectedIndex` - Gets the selected data point index.
* `PreviousSelectedSeries` - Gets the previous selected series.
* `PreviousSelectedSegment` - Gets the segment of previous selected data point.
* `PreviousSelectedIndex`] - Gets the previous selected data point index.
* `IsDataPointSelection` - Gets a value that indicates whether the selection is segment selection or series selection.
