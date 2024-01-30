---
layout: post
title: Axis range padding in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis range padding and its types and features in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Axis Range Padding in .NET MAUI Chart

Range padding is used to apply the minimum and maximum extremes of chart axis range by using the [RangePadding]() property. The [NumericalAxis]() and [DateTimeAxis]() have a [RangePadding]() property that can be used to add padding to the range of the chart axis.

## Numerical Range Padding

The [RangePadding]() is used to set the numeric range for axis.

The following types are available for [NumericalAxis]() range padding:

* `Additional` - The visible start and end range will be added with an additional interval. 
* `None` - The visible range sets to exact minimum and maximum value of the items source.
* `Normal` - The visible range will be the actual range calculated from given items source and series types.
* `Auto` - Automatically chosen based on the orientation of the axis.
* `Round` - The visible start and end range round to nearest interval value.
* `RoundStart` - The visible start range round to nearest interval value.
* `RoundEnd` - The visible end range round to nearest interval value. 
* `PrependInterval` - The visible start range will be prepended with an additional interval.
* `AppendInterval` - The visible end range will be appended with an additional interval.

By default, the [RangePadding]() value for [SecondaryAxis]() is `Round`.

**Additional**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="Additional"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

NumericalAxis secondaryAxis = new NumericalAxis()
{
    RangePadding = NumericalPadding.Additional,
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

**None**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="None"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

NumericalAxis secondaryAxis = new NumericalAxis()
{
    RangePadding = NumericalPadding.None,
};
chart.SecondaryAxis.Add(secondaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

**Round**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="Round"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

NumericalAxis secondaryAxis = new NumericalAxis()
{
    RangePadding = NumericalPadding.Round,
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## DateTime Range Padding

The [RangePadding]() types available in the [DateTimeAxis]() are: 

* `Auto` - Automatically chosen based on the orientation of the axis.
* `Additional` - The visible start and end range will be added with an additional interval.
* `None` - The visible range sets to exact minimum and maximum value of the items source.
* `Round` - The visible start and end range round to nearest interval value.
* `RoundStart` - The visible start range round to nearest interval value.
* `RoundEnd` - The visible end range round to nearest interval value.
* `PrependInterval` - The visible start range will be prepended with an additional interval.
* `AppendInterval` - The visible start range will be appended with an additional interval.

**Additional**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="Additional"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

DateTimeAxis secondaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.Additional
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

**None**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="None"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

DateTimeAxis secondaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.None
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

**Round**

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis RangePadding="Round"/>
    </chart:SfPolarChart.SecondaryAxis>
. . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

DateTimeAxis secondaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.Round
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}