---
layout: post
title: Axis line in .NET MAUI Chart control | Syncfusion
description: Learn here all about the chart axis line and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis line in .NET MAUI Chart (SfCartesianChart)

## Customization

Cartesian chart axis provides support to customize the style of axis line by defining the `AxisLineStyle` property as shown in the below code snippet.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Resources>
        <Style TargetType="Line" x:Key="lineStyle">
            <Setter Property="StrokeThickness" Value="2"/>
            <Setter Property="Stroke" Value="Red"/>
            <Setter Property="StrokeDashArray" Value="6,2,3"/>
        </Style>
    </chart:SfCartesianChart.Resources>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis AxisLineStyle="{StaticResource lineStyle}" />
    </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis()
    {
        AxisLineStyle = chart.Resources["lineStyle"] as Style 
    };

{% endhighlight %}

{% endtabs %}

## Offset

The padding to the axis line is defined by using the `AxisLineOffset` property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
<chart:SfCartesianChart.PrimaryAxis>
    <chart:NumericalAxis AxisLineOffset="25" AxisLineStyle="{StaticResource lineStyle}"/>
</chart:SfCartesianChart.PrimaryAxis>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
chart.PrimaryAxis = new NumericalAxis()
{
    AxisLineOffset = 25
    AxisLineStyle = chart.Resources["lineStyle"] as Style
};

{% endhighlight %}

{% endtabs %}
