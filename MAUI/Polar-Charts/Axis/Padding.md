---
layout: post
title: Axis padding in .NET MAUI Chart control | Syncfusion
description: Learn here all about how to set padding for chart axis in Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis Padding in .NET MAUI Chart

## PlotOffsetStart

The [PlotOffsetStart]() property is used to provide padding to the axis at start position. The following code sample demonstrates the padding applied to Start position for both primary and secondary axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis PlotOffsetStart="30"/>
</chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis()
{
PlotOffsetStart = 30
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## PlotOffsetEnd

The [PlotOffsetEnd]() property is used to provide padding to the axis at end position. The following code sample demonstrates the padding applied to end position for both primary and secondary axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis PlotOffsetEnd="30"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis()
{
PlotOffsetEnd = 30
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}