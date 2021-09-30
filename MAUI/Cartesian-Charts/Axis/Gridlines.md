---
layout: post
title: Axis grid lines in .NET MAUI Chart control | Syncfusion
description: Learn here all about the chart axis grid lines and its customization in syncfusion .NET MAUI Chart(SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Grid Lines in .NET MAUI Chart (SfCartesianChart)

## Major Grid Lines

By default, major gridlines are automatically added to the `ChartAxis` in its defined intervals. The visibility of the major gridlines can be controlled using the `ShowMajorGridLines` property. The default value of `ShowMajorGridLines` is true. 

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.PrimaryAxis>
            <chart:NumericalAxis ShowMajorGridLines="False"/>
        </chart:SfCartesianChart.PrimaryAxis>

        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.SecondaryAxis>
        . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis()
    {
        ShowMajorGridLines = false
    };

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

### Customization

The `MajorGridLineStyle` property in the chart axis is used to customize the appearance of major gridlines.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Resources>
        <Style TargetType="Line" x:Key="lineStyle">
            <Setter Property="StrokeThickness" Value="2"/>
            <Setter Property="Stroke" Value="Black"/>
            <Setter Property="StrokeDashArray" Value="3,3"/>
        </Style>
    </chart:SfCartesianChart.Resources>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis MajorGridLineStyle="{StaticResource lineStyle}"/>
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
        MajorGridLineStyle = chart.Resources["lineStyle"] as Style 
    };

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

## Minor Grid Lines

Minor gridlines will be added automatically when the small tick lines is defined and using the `MinorTicksPerInterval` property of chart axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis MinorTicksPerInterval="3" />
    </chart:SfCartesianChart.SecondaryAxis>
    . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.PrimaryAxis = new NumericalAxis();
    chart.SecondaryAxis = new NumericalAxis()
    {
        MinorTicksPerInterval = 3,
    };
    . . .

{% endhighlight %}

{% endtabs %}

### Customization

The `MinorGridLineStyle` property in the chart axis is used to customize the appearance of minor gridlines.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.Resources>
        <Style TargetType="Line" x:Key="lineStyle">
            <Setter Property="StrokeThickness" Value="0.8"/>
            <Setter Property="Stroke" Value="Black"/>
            <Setter Property="StrokeDashArray" Value="3,3"/>
        </Style>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis MinorTicksPerInterval="3" MinorGridLineStyle="{StaticResource lineStyle}"/>
    </chart:SfCartesianChart.SecondaryAxis>
    . . .
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    chart.PrimaryAxis = new NumericalAxis();
    chart.SecondaryAxis = new NumericalAxis()
    {
        MinorTicksPerInterval = 3,
        MinorGridLineStyle = chart.Resources["lineStyle"] as Style 
    };
    . . .

{% endhighlight %}

{% endtabs %}
