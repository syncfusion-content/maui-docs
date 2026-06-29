---
layout: post
title: Fast Scatter Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the fast scatter chart and its features in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui fast scatter chart, .net maui performance scatter chart, fast scatter chart customization .net maui, syncfusion maui fast scatter chart, cartesian fast scatter chart maui, cartesian performance scatter chart maui, .net maui chart fast scatter visualization.
---

# Fast Scatter in .NET MAUI Chart

The `FastScatterSeries` is a specialized scatter series designed to efficiently render a large number of data points. To render a fast scatter chart, create an instance of `FastScatterSeries`, and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

The `PointHeight` and `PointWidth` properties in the FastScatterSeries control the height and width of scatter segments. The `Type` property allows you to change the rendering shape of the `FastScatterSeries`.

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:FastScatterSeries ItemsSource="{Binding Data1}"
                            XBindingPath="XValue"
                            YBindingPath="YValue" />

    <chart:FastScatterSeries ItemsSource="{Binding Data2}"
                            XBindingPath="XValue"
                            YBindingPath="YValue" />
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

FastScatterSeries scatterSeries1 = new FastScatterSeries
{
    ItemsSource = new ViewModel().Data1,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

FastScatterSeries scatterSeries2 = new FastScatterSeries
{
    ItemsSource = new ViewModel().Data2,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

chart.Series.Add(scatterSeries1);
chart.Series.Add(scatterSeries2);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![FastScatter chart type in MAUI Chart](Chart-types-images/maui_fast_scatter_chart.png)