---
layout: post
title: Axis line in .NET MAUI Chart control | Syncfusion
description: Learn here all about the chart axis line and its customization in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis line in .NET MAUI Chart

## Customization

The polar chart axis provides support for customizing the style of the axis line by defining the [AxisLineStyle]()property, as shown in the code snippet below.

N> The customization of axis lines using the AxisLineStyle property can only be applied to the secondary axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis >
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth ="2"
									  Stroke="Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis();

ChartLineStyle axisLineStyle = new ChartLineStyle();

axisLineStyle.Stroke = Colors.Red;

axisLineStyle.StrokeWidth = 2;

secondaryAxis.AxisLineStyle = axisLineStyle;

chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Offset

The padding to the axis line is defined by using the [AxisLineOffset]() property.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis AxisLineOffset="25">
            <chart:NumericalAxis.AxisLineStyle>
                <chart:ChartLineStyle StrokeWidth ="2"
									  Stroke="Red"/>
            </chart:NumericalAxis.AxisLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis();

secondaryAxis.AxisLineOffset = 25;

ChartLineStyle axisLineStyle = new ChartLineStyle();

axisLineStyle.Stroke = Colors.Red;

axisLineStyle.StrokeWidth = 2;

secondaryAxis.AxisLineStyle = axisLineStyle;

chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}