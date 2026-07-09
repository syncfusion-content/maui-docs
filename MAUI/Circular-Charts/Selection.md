---
layout: post
title: Selection in .NET MAUI Circular Chart control | Syncfusion
description: This section explains about how to configure the selection support and its features applying in .NET MAUI Circular Chart (SfCircularChart).
platform: maui
control: SfCircularChart
documentation: ug
---

# Selection in .NET MAUI Circular Chart

The [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html) provides selection behavior support, which allows you to select or highlight a segment (data points) in a series using the [DataPointSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html). When a user taps or clicks on a segment, the selection behavior highlights that data point with the specified selection brush color.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCircularChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/circular-charts/getting-started)** guide.

## Enable selection

To enable the data point selection, create an instance of the series [SelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    <!-- code omitted for brevity -->
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
    SelectionBrush = new SolidColorBrush(Color.FromArgb("#314A6E")),
};

DoughnutSeries series = new DoughnutSeries();
// code omitted for brevity
series.SelectionBehavior = selection;
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Behavior customization 

The following properties are used to customize the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html):

* [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type), of type `ChartSelectionType`, specifies the selection mode. Both use the [ChartSelectionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionType.html) enum with the following values:
    * `Single` - The user can select only one item at a time
    * `SingleDeselect` - The user can select and deselect only one item at a time.
    * `Multiple` - The user can select and deselect multiple items at a time.
    * `None` - The user can't select any item.
* [SelectionBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionBrush), of type `Brush`, specifies the color that highlights the selected segment.
* [SelectedIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndex), of type `int`, specifies the index of the data point to be selected programmatically.
* [SelectedIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndexes), of type `ObservableCollection<int>`, specifies a collection of indexes to be selected when using Multiple selection mode.
* [ClearSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_ClearSelection), a method, clears all applied selection customizations and resets to default state.

## Events

The following selection events are available in the [ChartSelectionBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html). Use `SelectionChanging` to validate or cancel a selection before it takes effect, and `SelectionChanged` to respond after the selection is confirmed.

### SelectionChanging

The [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging) event occurs before the data point is being selected. This is a cancelable event. Set the `Cancel` property to `true` to prevent the selection. The following properties are contained in the event arguments:

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_NewIndexes), of type `List<int>`, contains the indexes of data points being selected.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangingEventArgs_OldIndexes), of type `List<int>`, contains the indexes of data points being deselected.
* `Cancel`, of type `bool`, determines whether the selection action should be canceled.

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanged) event occurs after a data point has been selected. Use this event to respond to confirmed selection changes, such as updating UI or triggering downstream logic. The following properties are contained in the event arguments:

* [NewIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_NewIndexes), of type `List<int>`, contains the indexes of the newly selected data points.
* [OldIndexes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_Maui_Charts_ChartSelectionChangedEventArgs_OldIndexes), of type `List<int>`, contains the indexes of the previously selected data points.