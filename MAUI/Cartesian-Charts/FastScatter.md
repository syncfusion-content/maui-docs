---
layout: post
title: Fast Scatter Chart in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about the fast scatter chart and its features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui fast scatter chart, .net maui performance scatter chart, fast scatter chart customization .net maui, syncfusion maui fast scatter chart, cartesian fast scatter chart maui, cartesian performance scatter chart maui, .net maui chart fast scatter visualization.
---

# Fast Scatter Chart in .NET MAUI Cartesian Chart

The [FastScatterSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastScatterSeries.html) is a specialized scatter series designed to efficiently render a large number of data points. It is optimized for performance when compared to the regular scatter series, making it suitable for large datasets. To render a fast scatter chart, create an instance of [FastScatterSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastScatterSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

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

![Fast scatter chart type in .NET MAUI Cartesian Chart](Chart-types-images/maui_fast_scatter_chart.png)

## Segment customization

The [PointHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastScatterSeries.html#Syncfusion_Maui_Charts_FastScatterSeries_PointHeight) and [PointWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastScatterSeries.html#Syncfusion_Maui_Charts_FastScatterSeries_PointWidth) properties, of type `double`, control the height and width of the scatter segments. The default value of both properties is `5`. The [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastScatterSeries.html#Syncfusion_Maui_Charts_FastScatterSeries_Type) property, of type `ShapeType`, allows you to change the rendering shape of the `FastScatterSeries`. The default value is `ShapeType.Circle`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
    <chart:FastScatterSeries ItemsSource="{Binding Data1}"
                            XBindingPath="XValue"
                            YBindingPath="YValue"
                            PointHeight="10"
                            PointWidth="10"
                            Type="Rectangle"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
// code omitted for brevity

FastScatterSeries scatterSeries = new FastScatterSeries
{
    ItemsSource = new ViewModel().Data1,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    PointHeight = 10,
    PointWidth = 10,
    Type = ShapeType.Rectangle
};

chart.Series.Add(scatterSeries);
this.Content = chart;

{% endhighlight %}

{% endtabs %}
