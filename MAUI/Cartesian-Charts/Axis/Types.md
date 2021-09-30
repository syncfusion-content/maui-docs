---
layout: post
title: Axis types in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis types and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control and more.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Types of Axis in .NET MAUI Chart (SfCartesianChart)

Cartesian chart supports the following types of chart axis.

* NumericalAxis
* CategoryAxis
* DateTimeAxis

## Numerical Axis

`NumericalAxis` is used to plot numerical values to the chart. `NumericalAxis` can be defined for both `PrimaryAxis` and `SecondaryAxis`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis();

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

### Interval

Axis interval can be customized by using the `Interval` property. By default, interval will be calculated based on the minimum and maximum value of the provided data.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:NumericalAxis Interval="10" />
    </chart:SfCartesianChart.PrimaryAxis>
    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new NumericalAxis()
    {
        Interval = 10, 
    };

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

### Customizing the Range

`Maximum` and `Minimum` properties of axis is used for setting the maximum and minimum value of the axis range respectively.

N> If  minimum or maximum value is set, the other value is calculated by default internally.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis Maximum="2750" Minimum="250" Interval="250"/>
    </chart:SfCartesianChart.SecondaryAxis>

{% endhighlight %}

{% highlight c# %}

    chart.SecondaryAxis = new NumericalAxis()
    {
        Maximum = 2750,
        Minimum = 250,
        Interval = 250
    };

{% endhighlight %}

{% endtabs %}

## Category Axis

The `CategoryAxis` is an indexed based axis that plots values based on the index of the data point collection. The points are equally spaced here.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
    . . .
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new CategoryAxis();

{% endhighlight %}

{% endtabs %}

### Label placement

The `LabelPlacement` property in `CategoryAxis` is used to placed the axis labels based on ticks and between ticks. The default value of `LabelPlacement` is `OnTicks`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis LabelPlacement="BetweenTicks"/>
        </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new CategoryAxis()
    {
        LabelPlacement = LabelPlacement.BetweenTicks
    };

{% endhighlight %}

{% endtabs %}

### Interval

By default, the `CategoryAxis` axis labels are display with fixed interval 1. It can customized by using the `Interval` property of axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis Interval="2" />
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new CategoryAxis()
    {
        Interval = 2, 
    };

chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

## DateTime Axis

`DateTimeAxis` is used to plot `DateTime` values. The `DateTimeAxis` is widely used to make financial charts in places like the Stock Market, where index plotting is done every day.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:DateTimeAxis/>
        </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new DateTimeAxis();

{% endhighlight %}

{% endtabs %}

### Interval

In `DateTimeAxis`, intervals can be customized by using the `Interval` and `IntervalType` properties. For example, setting `Interval` as 6 and `IntervalType` as `Months` will consider 6 months as interval.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:DateTimeAxis Interval="6" IntervalType="Months"/>
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new DateTimeAxis()
    {
        Interval = 6, 
        IntervalType = DateTimeIntervalType.Months
    };

    chart.SecondaryAxis = new NumericalAxis();

{% endhighlight %}

{% endtabs %}

### Customizing the Range

`Minimum` and `Maximum` properties behavior is same as in `NumericalAxis` instead of setting numerical value, have to set date time values.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:DateTimeAxis Minimum="2021/05/1" Maximum="2021/11/01"/>
        </chart:SfCartesianChart.PrimaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    chart.PrimaryAxis = new DateTimeAxis()
    {
        Minimum = new DateTime(2021,05,10),
        Maximum = new DateTime(2021,11,01),
    };

{% endhighlight %}

{% endtabs %}

## Inversed

Axis can be inverted by using the `IsInversed` property. The default value of this property is `False`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis IsInversed="True"/>
        </chart:SfCartesianChart.SecondaryAxis>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    this.Chart.SecondaryAxis = new NumericalAxis();
    this.Chart.SecondaryAxis.IsInversed = true;

{% endhighlight %}

{% endtabs %}

## Multiple Axes

Cartesian charts provides support to arrange the multiple series inside the same chart area with specified x-axis and y-axis. There are two properties `XAxis` and `YAxis` in all the Cartesian series type, which is used to provide multiple axes support. These axes can be arranged in a stacking order or in a side by side pattern.

By default, all the series are plotted based on primary and secondary axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.Series>
            <chart:SfCartesianChart.Series>
                <chart:ColumnSeries ItemsSource="{Binding Data1}" 
                     XBindingPath="Date"
                     YBindingPath="Value">
                    <chart:ColumnSeries.XAxis>
                            <chart:DateTimeAxis OpposedPosition="True" ShowMajorGridLines="False"/>
                    </chart:ColumnSeries.XAxis>
                    <chart:ColumnSeries.YAxis>
                            <chart:NumericalAxis OpposedPosition="True" ShowMajorGridLines="False" />
                    </chart:ColumnSeries.YAxis>
                </chart:ColumnSeries>
                <chart:SplineSeries ItemsSource="{Binding Data}" 
                     XBindingPath="Date"
                     YBindingPath="Value"/>
        </chart:SfCartesianChart.Series>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .

ColumnSeries series1 = new ColumnSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Demand",
    YBindingPath = "Year2011"
};

SplineSeries series2 = new SplineSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Date",
    YBindingPath = "Year2011",
};

series1.XAxis = new DateTimeAxis()
{
    OpposedPosition = true,
    ShowMajorGridLines = false
};
series1.YAxis = new NumericalAxis()
{
    OpposedPosition = true,
    ShowMajorGridLines = false
};

chart.Series.Add(series1);
chart.Series.Add(series2);

{% endhighlight %}

{% endtabs %}

In the above image, the `ColumnSeries` is plotted based on additional X & Y axes, and `SplineSeries` is plotted based on the primary and secondary axes.
