---
layout: post
title: Stacked Column Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stacked column and bar chart support in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui stacked column chart, maui stacked column chart, stacked column chart customization .net maui, syncfusion maui stacked column chart, cartesian stacked column chart maui, .net maui chart stacked column visualization, .net maui cumulative column chart.
---

# Stacked Column Chart in .NET MAUI Chart

## Stacked Column Chart

The stacked column chart represents data values in a stacked format, where the columns are stacked on each other to indicate the cumulative value of the data points.

To render a stacked column chart, create an instance of the [StackingColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingColumnSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:StackingColumnSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Name"
                                YBindingPath="Value"/>        

    <chart:StackingColumnSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Name"
                                YBindingPath="Value"/>         
</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

StackingColumnSeries  series1 = new  StackingColumnSeries()
{
    ItemsSource = new ViewModel().Data1
    XBindingPath = "Name",
    YBindingPath = "Value",
};
StackingColumnSeries series2 = new StackingColumnSeries()
{
    ItemsSource = new ViewModel().Data2
    XBindingPath = "Name",
    YBindingPath = "Value",
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
this.Content = chart;

{% endhighlight %}

{% endtabs %}


## Grouping Series

Each series in a stacked chart with several series may be difficult to compare. To solve that problem, grouping is used.
The [GroupingLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingSeriesBase.html#Syncfusion_Maui_Charts_StackingSeriesBase_GroupingLabel) property used to group the series, which allows users to assign a label to each stacked column series. This label identifies the specific group to which the stacked column series belongs and can be used to group similar series.

N> If the [GroupingLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingSeriesBase.html#Syncfusion_Maui_Charts_StackingSeriesBase_GroupingLabel) is not provided, the stacked column will consider all series as a single group.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ....
    <chart:StackingColumnSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Name"
                                YBindingPath="Value"
                                GroupingLabel="GroupOne"/>

    <chart:StackingColumnSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Name"
                                YBindingPath="Value"
                                GroupingLabel="GroupTwo"/>

    <chart:StackingColumnSeries ItemsSource="{Binding Data3}"
                                XBindingPath="Name"
                                YBindingPath="Value"
                                GroupingLabel="GroupOne"/>
</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

StackingColumnSeries  series1 = new  StackingColumnSeries()
{
    ItemsSource = new ViewModel().Data1,
    XBindingPath = "Name",
    YBindingPath = "Value",
    GroupingLabel="GroupOne"
};
StackingColumnSeries series2 = new StackingColumnSeries()
{
    ItemsSource = new ViewModel().Data2,
    XBindingPath = "Name",
    YBindingPath = "Value",
    GroupingLabel="GroupTwo"
};
StackingColumnSeries series3 = new  StackingColumnSeries()
{
    ItemsSource = new ViewModel().Data3,
    XBindingPath = "Name",
    YBindingPath = "Value",
    GroupingLabel="GroupOne"
};

chart.Series.Add(series1);
chart.Series.Add(series2); 
chart.Series.Add(series3);      
this.Content = chart;

{% endhighlight %}

{% endtabs %}


## Appearance customization

* [Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingColumnSeries.html#Syncfusion_Maui_Charts_StackingColumnSeries_Spacing) of the `Double` type is used to change the spacing between two segments. The default spacing value is 0, ranging from 0 to 1.
* [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingColumnSeries.html#Syncfusion_Maui_Charts_StackingColumnSeries_Width) of the `Double` type is used to change the width of the rectangle. The default value of the width is 0.8, and the value ranges from 0 to 1.
* [CornerRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingColumnSeries.html#Syncfusion_Maui_Charts_StackingColumnSeries_CornerRadius) of the type `CornerRadius`, indicates the rounded corner for the stacked column.
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingColumnSeries.html#Syncfusion_Maui_Charts_StackingColumnSeries_Stroke) of the type `Brush` indicates the brush used to paint the border of the stacked column.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.XYDataSeries.html#Syncfusion_Maui_Charts_XYDataSeries_StrokeWidth) of the type `Double` indicates the width of the stacked segment.