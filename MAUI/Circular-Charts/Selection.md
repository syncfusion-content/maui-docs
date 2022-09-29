---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart

The [SfCircularChart]() provides selection behavior support, which allows you to select or highlight a segment (data points) in a series using the [DataPointSelectionBehavior]().

## Enable selection

To enable the data point selection, create an instance of the series [SelectionBehavior]() property. And the following code example shows how to configure and specify the brush for the highlighted segment using [DataPointSelectionBehavior]().

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <chart:SfCircularChart.Series>
        <chart:DoughnutSeries>
            <chart:DoughnutSeries.SelectionBehavior>
                <chart:DataPointSelectionBehavior SelectionBrush="#314A6E"/>
            </chart:DoughnutSeries.SelectionBehavior>
        </chart:DoughnutSeries>
    </chart:SfCircularChart.Series>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush="#314A6E";

DoughnutSeries series = new DoughnutSeries();
series.SelectionBehavior = selection;
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Segment Selection Support in MAUI SfCircularChart](Selection_images/maui_chart_segment_selection.png)

## Behavior customization 

The following properties are used to customize the [ChartSelectionBehavior]():

* [Type]() - Gets or sets the [ChartSelectionType]() for the selection behavior.     
Chart selection types:
    * Single - The user can select only one item at a time
    * SingleDeselect - The user can select and deselect only one item at a time.
    * Multiple - The user can select and deselect multiple items at a time.
    * None - The user can't select any item.
* [SelectionBrush]() - Gets or sets the SelectionBrush color for the selection behavior.
* [SelectedIndex]() - Gets or sets the index value of the segment.
* [SelectedIndexes]() - Gets or sets the list of indexes of the segments.

## Clear selection

Resets all the selection customization to default. The following code example shows how to use [ClearSelection]():

{% tabs %}

{% highlight c# %}

Button button = new Button
{
    Text = "Click to Rotate Text!",
    VerticalOptions = LayoutOptions.Center,
    HorizontalOptions = LayoutOptions.Center
};
button.Clicked += Button_Clicked(sender, args);

SfCircularChart chart = new SfCircularChart ();
DataPointSelectionBehavior selection = new DataPointSelectionBehavior ();
selection.SelectionBrush = Color.FromArgb("#314A6E");

PieSeries series = new PieSeries ();
series.SelectionBehavior = selection;
chart.Series.Add(series);

private void Button_Clicked(object sender, EventArgs e)
{
    selection.ClearSelection();
}

{% endhighlight %}

{% endtabs %}

## Events

The following selection events are available in the [ChartSelectionBehavior]().

### SelectionChanging

The [SelectionChanging]() event occurs before the data point is being selected. This is a cancelable event. The following properties are contained in the event arguments:

* [NewIndexes]() - Gets the index of the selected data point.
* [OldIndexes]() - Gets the index of the deselected data point.
* [Cancel]() - Gets or sets a value indicating whether to continue the selection.

### SelectionChanged

The [SelectionChanged]() event occurs after a data point has been selected. The following properties are contained in the event arguments:

* [NewIndexes]() - Gets the index of the selected data point.
* [OldIndexes]() - Gets the index of the deselected data point.