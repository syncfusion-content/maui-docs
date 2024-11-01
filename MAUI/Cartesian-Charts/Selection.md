---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: Learn here all about selection and multi-selection support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart selection, maui chart selection, .net maui chart selection customization, syncfusion maui chart selection, .net maui chart highlighting, .net maui chart highlighting visualization.
---

# Selection in .NET MAUI Chart

The [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) provides selection behavior support, which allows you to select or highlight a segment (data points) or a series in the chart using the [DataPointSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html) and [SeriesSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SeriesSelectionBehavior.html).

## Enable data point selection

To enable the data point selection, create an instance of the series [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Time"
                            YBindingPath="FootStepsCount">
            <chart:ColumnSeries.SelectionBehavior>
                <chart:DataPointSelectionBehavior SelectionBrush="#314A6E"/>
            </chart:ColumnSeries.SelectionBehavior>
        </chart:ColumnSeries>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
DataPointSelectionBehavior selection = new DataPointSelectionBehavior();
selection.SelectionBrush=Color.FromArgb("#314A6E");

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    SelectionBehavior = selection
};
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Enable series selection

To enable the series selection, create an instance of the Cartesian chart [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionBehavior) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.SelectionBehavior>
        <chart:SeriesSelectionBehavior SelectionBrush="#314A6E"/>
    </chart:SfCartesianChart.SelectionBehavior>
    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Country"
                            YBindingPath="Kids"/>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Country"
                            YBindingPath="Adults"/>
        <chart:ColumnSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Country"
                            YBindingPath="Seniors"/>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
SeriesSelectionBehavior selection = new SeriesSelectionBehavior();
selection.SelectionBrush=Color.FromArgb("#314A6E");
chart.SelectionBehavior = selection;

ColumnSeries series1 = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Country",
    YBindingPath = "Kids",
};
ColumnSeries series2 = new ColumnSeries()
{ . . . };
ColumnSeries series3 = new ColumnSeries()
{ . . . };

chart.Series.Add(series1);
chart.Series.Add(series2);
chart.Series.Add(series3);
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

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_NewIndexes) - Gets the index of the selected items.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_OldIndexes) - Gets the index of the deselected items.
* `Cancel` - Gets or sets a value indicating whether to continue the selection.

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanged) event occurs after a data point has been selected. The following properties are contained in the event arguments:

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_NewIndexes) - Gets the index of the selected items.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_OldIndexes) - Gets the index of the deselected items.