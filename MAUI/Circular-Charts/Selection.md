---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Chart

The [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html) provides selection behavior support, which allows you to select or highlight a segment (data points) in a series using the [DataPointSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html).

## Enable selection

To enable the data point selection, create an instance of the series [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior) property.

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

DataPointSelectionBehavior selection = new DataPointSelectionBehavior()
{
    SelectionBrush = Color.FromHex("#314A6E"),
};

DoughnutSeries series = new DoughnutSeries();
. . .    
series.SelectionBehavior = selection;
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Behavior customization 

The following properties are used to customize the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html):

* [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type) - Gets or sets the [ChartSelectionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionType.html) for the selection behavior.     
Chart selection types:
    * `Single` - The user can select only one item at a time
    * `SingleDeselect` - The user can select and deselect only one item at a time.
    * `Multiple` - The user can select and deselect multiple items at a time.
    * `None` - The user can't select any item.
* [SelectionBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionBrush) - Gets or sets the brush color for the selection.
* [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndex) - Gets or sets the value of the index to be selected.
* [SelectedIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndexes) - Gets or sets the list of indexes to be selected.
* [ClearSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_ClearSelection) - Used to reset all the selection customizations to default.

## Events

The following selection events are available in the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html).

### SelectionChanging

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging) event occurs before the data point is being selected. This is a cancelable event. The following properties are contained in the event arguments:

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_NewIndexes) - Gets the index of the selected data point.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_OldIndexes) - Gets the index of the deselected data point.
* `Cancel` - Gets or sets a value indicating whether to continue the selection.

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanged) event occurs after a data point has been selected. The following properties are contained in the event arguments:

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_NewIndexes) - Gets the index of the selected data point.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_OldIndexes) - Gets the index of the deselected data point.