---
layout: post
title: Stacked Area Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stacked area chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui stacked area chart, maui stacked area chart, stacked area chart customization .net maui, syncfusion maui stacked area chart, cartesian stacked area chart maui, .net maui chart stacked area visualization, .net maui cumulative area chart.
---

# Stacked Area Chart in .NET MAUI Chart

The stacked area chart enables users to visually represent data points on top of each other to indicate the cumulative value of the data points.

To render a stacked area chart, create an instance of the [StackingAreaSeries]() and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

N> The Cartesian chart has a [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
...
    <chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:StackingAreaSeries ItemsSource="{Binding Data1}"
                              XBindingPath="Year"
                              YBindingPath="Value"/>        

    <chart:StackingAreaSeries ItemsSource="{Binding Data2}"
                              XBindingPath="Year"
                              YBindingPath="Value"/>         

    <chart:StackingAreaSeries ItemsSource="{Binding Data3}"
                              XBindingPath="Year"
                              YBindingPath="Value"/>         

    <chart:StackingAreaSeries ItemsSource="{Binding Data4}"
                              XBindingPath="Year"
                              YBindingPath="Value"/>         

</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ViewModel viewModel = new ViewModel();

StackingAreaSeries series1 = new  StackingAreaSeries()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1
};

StackingAreaSeries series2 = new StackingAreaSeries()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data2
};
StackingAreaSeries series3 = new StackingAreaSeries()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data3
};

StackingAreaSeries series4 = new StackingAreaSeries()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data4
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
chart.Series.Add(series3); 
chart.Series.Add(series4); 
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Stacking Area Chart in .NET MAUI Cartesian Charts.](chart-types-images\net-maui-cartesian-charts-stacked-area-chart.png)