---
layout: post
title: Selection in .NET MAUI Chart control | Syncfusion
description: Learn here all about selection and multi-selection support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Selection in .NET MAUI Chart (SfCartesianChart)

Cartesian chart supports selection that allows to select a segment or series in the chart by using [ChartSelectionBehavior](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSelectionBehavior.html?tabs=tabid-1). 

## Enable Selection

To enable the selection in chart, create an instance of [ChartSelectionBehavior](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSelectionBehavior.html?tabs=tabid-1) and add it to the `ChartBehaviors` collection of [SfCartesianChart](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1). And also need to set the [SelectionBrush](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBrush) property to highlight the segment in the chart.

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

Cartesian chart provides support to select single or None by using the [Type](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type) property. [Type](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type) property with `Point` value is used to select segment in a series and `None` is used for not to select any segment.

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

Cartesian chart provides support to select a point programmatically on a chart using the [SelectedIndex](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectedIndex) property of series.

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

The following selection events are available in the [SfCartesianChart](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

### SelectionChanging

The [SelectionChanging](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_OnSelectionChanging_Syncfusion_Maui_Charts_SelectionChangingEventArgs_) event occurs before the data point is being selected. This is a cancelable event. This argument contains the following information.

* [SelectedSeries](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_SelectedSeries) - Gets the series of the selected data point.
* [SelectedSegments](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_SelectedSegments) - Gets or sets the segments collection of the selected series.
* [SelectedSegment](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_SelectedSegment) - Gets the segment of the selected data point.
* [SelectedIndex](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_SelectedIndex) - Gets the selected data point index.
* [PreviousSelectedIndex](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_PreviousSelectedIndex) - Gets the previous selected data point index.
* [IsDataPointSelection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_IsDataPointSelection) - Gets a value that indicates whether the selection is segment selection or series selection.
* [Cancel](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangingEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangingEventArgs_Cancel) - Gets or Sets a value that indicates whether the selection should be canceled.

### SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartBase.html#Syncfusion_UI_Xaml_Charts_ChartBase_SelectionChanged) event occurs after a data point has been selected. This argument contains the following information.

* [SelectedSeries](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_SelectedSeries) - Gets the series of the selected data point.
* [SelectedSegments](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_SelectedSegments) - Gets the segments collection of the selected series.
* [SelectedSegment](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_SelectedSegment) - Gets the segment of the selected data point.
* [SelectedIndex](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_SelectedIndex) - Gets the selected data point index.
* [PreviousSelectedSeries](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_PreviousSelectedSeries) - Gets the previous selected series.
* [PreviousSelectedSegment](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_PreviousSelectedSegment) - Gets the segment of previous selected data point.
* [PreviousSelectedIndex](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_PreviousSelectedIndex) - Gets the previous selected data point index.
* [IsDataPointSelection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.ChartSelectionChangedEventArgs.html#Syncfusion_UI_Xaml_Charts_ChartSelectionChangedEventArgs_IsDataPointSelection) - Gets a value that indicates whether the selection is segment selection or series selection.
