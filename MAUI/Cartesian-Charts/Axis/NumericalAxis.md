---
layout: post
title: Numerical Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: Numerical Axis in Syncfusion .NET MAUI Cartesian Chart displays continuous numeric data with support for ranges, intervals, labels, and customization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui numerical axis, numerical axis in maui chart, .net maui cartesian chart numerical axis, syncfusion maui chart numerical axis, maui chart numeric axis, cartesian chart axis customization maui, sfcartesianchart numerical axis, .net maui chart axis labels.
---

# Numerical Axis in .NET MAUI Cartesian Chart

[NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) is used to plot numerical values on the chart. [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) can be defined for both [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) and [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![NumericalAxis support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_types.jpg)

To customize the [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) in .NET MAUI Cartesian Charts, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=BJAEtUZSK_c" %}

## Interval

The axis interval can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_Interval) property, of type `double`, with a default value of `double.NaN`. By default, the interval will be calculated based on the minimum and maximum values of the provided data.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis Interval="10"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis()
{
    Interval = 10
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![NumericalAxis interval support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_numeric_axis_interval.jpg)

## Customizing the range

[Maximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_Maximum) and [Minimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_Minimum) properties of the axis are used for setting the maximum and minimum values of the axis range respectively.

N> If the minimum or maximum value is set, the other value is calculated by default internally.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
      <chart:NumericalAxis Maximum="2750" Minimum="250" Interval="250"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis secondaryAxis = new NumericalAxis()
{
    Maximum = 2750,
    Minimum = 250,
    Interval = 250
};
chart.YAxes.Add(secondaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}