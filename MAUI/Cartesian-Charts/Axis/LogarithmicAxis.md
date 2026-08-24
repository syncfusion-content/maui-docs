---
layout: post
title: Logarithmic Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: Logarithmic Axis in Syncfusion .NET MAUI Cartesian Chart displays data across a logarithmic scale with support for ranges, intervals, labels, and customization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui logarithmic axis, logarithmic axis in maui chart, .net maui cartesian chart logarithmic axis, syncfusion maui chart logarithmic axis, maui chart log axis, cartesian chart logarithmic scale maui, sfcartesianchart logarithmic axis, .net maui chart logarithmic labels.
---

# Logarithmic Axis in .NET MAUI Cartesian Chart

The [LogarithmicAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html) uses a logarithmic scale, and it is useful for visualizing data when the data range spans several orders of magnitude. It can be used either on the X-axis or the Y-axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:LogarithmicAxis/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
LogarithmicAxis secondaryAxis = new LogarithmicAxis();
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_logarithmic_axis.jpg)

To customize the [LogarithmicAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html) in .NET MAUI Cartesian Charts, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=HWPRuTYThDc" %}

## Interval

The axis interval can be customized using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html#Syncfusion_Maui_Charts_LogarithmicAxis_Interval) property of the axis. By default, the interval will be calculated based on the minimum and maximum values of the provided data. The default value of the interval is `double.NaN`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:LogarithmicAxis Interval="2"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
LogarithmicAxis secondaryAxis = new LogarithmicAxis()
{
    Interval = 2 
};
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Customizing the range

To customize the range of the log axis, you can use the [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html#Syncfusion_Maui_Charts_LogarithmicAxis_Minimum) and [Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html#Syncfusion_Maui_Charts_LogarithmicAxis_Maximum) properties of the [LogarithmicAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html). By default, an optimal range will be calculated automatically based on the provided data.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:LogarithmicAxis Minimum="100" Maximum="10000"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
LogarithmicAxis secondaryAxis = new LogarithmicAxis()
{
    Minimum = 100, 
    Maximum = 10000 
};
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Customizing the base

The logarithmic axis base can be customized using the [LogarithmicBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html#Syncfusion_Maui_Charts_LogarithmicAxis_LogarithmicBase) property, of type `double`, of the axis. By default, the base value is `10`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:LogarithmicAxis LogarithmicBase="5"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
LogarithmicAxis secondaryAxis = new LogarithmicAxis()
{
    LogarithmicBase = 5
};
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis base customization in .NET MAUI Cartesian Chart](Axis_images/maui_chart_logarithmic_axis_base.jpg)

To customize the [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) in .NET MAUI Cartesian Charts, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=IGLyuQS18iQ" %}