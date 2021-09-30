---
layout: post
title: Axis Tick Line in .NET MAUI Chart control | Syncfusion
description: Learn here all about chart axis tick line and its customization in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Tick Lines in .NET MAUI Chart (SfCartesianChart)

Tick lines are the small lines which is drawn on the axis line representing the axis labels. Tick lines will be drawn outside of the axis by default. 

And also minor tick lines can be added to the axis by defining the `MinorTicksPerInterval` property. This property will add the minor tick lines to every interval based on value.

N> For category axis, minor tick lines are not applicable. Since it is rendered based on index positions.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis MinorTicksPerInterval="4"/>
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis()
    {
        MinorTicksPerInterval = 4 
    };

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

## Customization

Both major and minor tick lines can be customized by using the `MajorTickStyle` and `MinorTickStyle` properties respectively. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Resources>
        <Style TargetType="Line" x:Key="lineStyle">
            <Setter Property="StrokeThickness" Value="1"/>
            <Setter Property="Stroke" Value="Red"/>
        </Style>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis MinorTicksPerInterval="4" MinorTickStyle="{StaticResource lineStyle}"  MajorTickStyle="{StaticResource lineStyle}" />
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis()
    {
        MinorTicksPerInterval = 4,
        MajorTickStyle = chart.Resources["lineStyle"] as Style,
        MinorTickStyle = chart.Resources["lineStyle"] as Style 
    };

chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}
