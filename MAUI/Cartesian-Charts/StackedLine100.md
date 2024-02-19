---
layout: post
title: Stacked Line 100 Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stacked line 100 chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Stacked Line 100 Chart in .NET MAUI Chart


The stacked line 100 chart is a type of chart that displays multiple line series stacked on top of each other, to indicate the cumulative value of the data points at 100%.

To render a stacked line 100 chart, create an instance of the [StackingLine100Series]() and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

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

    <chart:StackingLine100Series ItemsSource="{Binding Data1}"
                                XBindingPath="Year"
                                YBindingPath="Value"        
    </chart:StackingLine100Series>

    <chart:StackingLine100Series ItemsSource="{Binding Data2}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLine100Series>

    <chart:StackingLine100Series ItemsSource="{Binding Data3}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLine100Series>

    <chart:StackingLine100Series ItemsSource="{Binding Data4}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingLine100Series>

</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ViewModel viewModel = new ViewModel();

StackingLine100Series series1 = new  StackingLine100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1
};

StackingLine100Series series2 = new StackingLine100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data2
};
StackingLine100Series series3 = new StackingLine100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data3
};

StackingLine100Series series4 = new StackingLine100Series()
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

![Stacking Line 100 Chart in .NET MAUI Cartesian Charts.]