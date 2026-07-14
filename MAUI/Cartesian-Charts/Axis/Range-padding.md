---
layout: post
title: Axis range padding in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about axis range padding and its types features of Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart axis range padding, .net maui cartesian chart range padding customization, maui cartesian chart axis range padding guide, syncfusion maui cartesian chart range padding, cartesian chart range padding maui, .net maui cartesian chart axis range adjustment.
---

# Axis Range Padding in .NET MAUI Cartesian Chart

Range padding is used to set the minimum and maximum extremes of the chart axis range by using the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) property. The [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_RangePadding) property, available on axes derived from [RangeAxisBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html) such as [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html), [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), and [LogarithmicAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html), can be used to add padding to the range of the chart axis.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

## Numerical Range Padding

The [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) property is used to set the numeric range for the axis.

The following [NumericalPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html) values are available for [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) range padding:

* `Additional` - The visible start and end range will be added with an additional interval.
* `None` - The visible range sets to exact minimum and maximum value of the items source.
* `Normal` - The visible range will be the actual range calculated from given items source and series types.
* `Auto` - Automatically chosen based on the orientation of the axis.
* `Round` - The visible start and end range round to nearest interval value.
* `RoundStart` - The visible start range round to nearest interval value.
* `RoundEnd` - The visible end range round to nearest interval value.
* `PrependInterval` - The visible start range will be prepended with an additional interval.
* `AppendInterval` - The visible end range will be appended with an additional interval.

By default, the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) value for NumericalAxis is `Auto`.

### Additional

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="Additional"/>
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
    RangePadding = NumericalPadding.Additional,
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding Additional in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_numerical-range-padding_additional.jpg)

### None

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="None"/>
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
    RangePadding = NumericalPadding.None,
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding None in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_numerical-range-padding_none.jpg)

### Round

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="Round"/>
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
    RangePadding = NumericalPadding.Round,
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding Round in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_numerical-range-padding_round.jpg)

## DateTime Range Padding

The following [DateTimeRangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html) values are available for the [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html):

* `Auto` - Automatically chosen based on the orientation of the axis.
* `Additional` - The visible start and end range will be added with an additional interval.
* `None` - The visible range sets to exact minimum and maximum value of the items source.
* `Round` - The visible start and end range round to nearest interval value.
* `RoundStart` - The visible start range round to nearest interval value.
* `RoundEnd` - The visible end range round to nearest interval value.
* `PrependInterval` - The visible start range will be prepended with an additional interval.
* `AppendInterval` - The visible end range will be appended with an additional interval.

By default, the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_RangePadding) value for the [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) is `Auto`.

### Additional

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="Additional"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <chart:SfCartesianChart.Series>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.Additional
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding Additional in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_datetime-range-padding_additional.jpg)

### None

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="None"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.None
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding None in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_datetime-range-padding_none.jpg)

### Round

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="Round"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    RangePadding = DateTimeRangePadding.Round
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding Round in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_datetime-range-padding_round.jpg)