---
layout: post
title: StackedArea100 Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about StackedArea100 chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# StackedArea100 Chart in .NET MAUI Chart

The stacked area 100% chart enables users to visually represent data points vertically, one above the other, to indicate the cumulative value of the data points at 100%.

## StackedArea100 Chart

To render the StackedArea100 chart, create an instance of the [StackingArea100Series](), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

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

    <chart:StackingArea100Series ItemsSource="{Binding Data1}"
                                XBindingPath="Year"
                                YBindingPath="Value"        
    </chart:StackingArea100Series>

    <chart:StackingArea100Series ItemsSource="{Binding Data2}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingArea100Series>

    <chart:StackingArea100Series ItemsSource="{Binding Data3}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingArea100Series>

    <chart:StackingArea100Series ItemsSource="{Binding Data4}"
                                XBindingPath="Year"
                                YBindingPath="Value"         
    </chart:StackingArea100Series>

</chart:SfCartesianChart>

{% endhighlight xaml %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

StackingArea100Series series1 = new  StackingArea100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = Data1
};

StackingArea100Series series2 = new StackingArea100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = Data2
};

StackingArea100Series series3 = new StackingArea100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = Data3
};

StackingArea100Series series4 = new StackingArea100Series()
{
    XBindingPath = "Year",
    YBindingPath = "Value",
    ItemsSource = Data4
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
chart.Series.Add(series3); 
chart.Series.Add(series4);
this.Content = chart;

{% endhighlight C# %}

{% endtabs %}

![Stacking Area 100 Chart in MAUI](Chart-types_images\StackedArea100Chart.png)