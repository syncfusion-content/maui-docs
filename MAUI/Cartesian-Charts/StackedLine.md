---
layout: post
title: Stacked Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stacked line chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Stacked Line Chart in .NET MAUI Chart


The stacked line chart is a type of chart that displays multiple line series stacked on top of each other, with the values of each series combined to show a cumulative value of the data points.

To render a stacked line chart, create an instance of the [StackingLineSeries]() and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

N> The Cartesian chart has a [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
    <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:StackingLineSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Year"
                                YBindingPath="Value"        
    </chart:StackingLineSeries>

    <chart:StackingLineSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLineSeries>

    <chart:StackingLineSeries ItemsSource="{Binding Data3}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLineSeries>

    <chart:StackingLineSeries ItemsSource="{Binding Data4}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLineSeries>

    </chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.XAxes.Add(primaryAxis);
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.YAxes.Add(secondaryAxis);

    ViewModel viewModel = new ViewModel();

    StackingLineSeries series1 = new  StackingLineSeries()
    {
        XBindingPath = "Year",
        YBindingPath = "Value",
        ItemsSource = viewModel.Data1
    };

    StackingLineSeries series2 = new StackingLineSeries()
    {
        XBindingPath = "Year",
        YBindingPath = "Value",
        ItemsSource = viewModel.Data2
    };
    StackingLineSeries series3 = new StackingLineSeries()       
    {
        XBindingPath = "Year",
        YBindingPath = "Value",
        ItemsSource = viewModel.Data3
    };

    StackingLineSeries series4 = new StackingLineSeries()
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

![Stacking Line Chart in .NET MAUI Cartesian Charts.](chart-types-images\net-maui-cartesian-charts-stacked-line-chart.png)