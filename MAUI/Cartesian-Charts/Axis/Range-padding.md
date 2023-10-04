---
layout: post
title: Axis range padding in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis range padding and its types features of Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis Range Padding in .NET MAUI Chart

Range padding is used to apply the minimum and maximum extremes of chart axis range by using the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) property. The [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) and [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) have a [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) property that can be used to add padding to the range of the chart axis.

## Numerical Range Padding

The [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) is used to set the numeric range for axis.

The following types are available for [NumericalAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html) range padding:

* [Additional](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Additional) - The visible start and end range will be added with an additional interval. 
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_None) - The visible range sets to exact minimum and maximum value of the items source.
* [Normal](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Normal) - The visible range will be the actual range calculated from given items source and series types.
* [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Auto) - Automatically chosen based on the orientation of the axis.
* [Round](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Round) - The visible start and end range round to nearest interval value.
* [RoundStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_RoundStart) - The visible start range round to nearest interval value.
* [RoundEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_RoundEnd) - The visible end range round to nearest interval value. 
* [PrependInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_PrependInterval) - The visible start range will be prepended with an additional interval.
* [AppendInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_AppendInterval) - The visible end range will be appended with an additional interval.

By default, the [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html#Syncfusion_Maui_Charts_NumericalAxis_RangePadding) value for [XAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes) is [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Auto) and for [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes) is [Round](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPadding.html#Syncfusion_Maui_Charts_NumericalPadding_Round).

**Additional**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="Additional"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding support in MAUI Chart](Axis_Images/maui_chart_axis_numerical-range-padding_additional.jpg)

**None**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="None"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding none in MAUI Chart](Axis_Images/maui_chart_axis_numerical-range-padding_none.jpg)

**Round**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis RangePadding="Round"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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

{% endhighlight %}

{% endtabs %}

![NumericalAxis range padding round in MAUI Chart](Axis_Images/maui_chart_axis_numerical-range-padding_round.jpg)

## DateTime Range Padding

The [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html#Syncfusion_Maui_Charts_DateTimeAxis_RangePadding) types available in the [DateTimeAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html) are: 

* [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_Auto) - Automatically chosen based on the orientation of the axis.
* [Additional](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_Additional) - The visible start and end range will be added with an additional interval.
* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_None) - The visible range sets to exact minimum and maximum value of the items source.
* [Round](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_Round) - The visible start and end range round to nearest interval value.
* [RoundStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_RoundStart) - The visible start range round to nearest interval value.
* [RoundEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_RoundEnd) - The visible end range round to nearest interval value.
* [PrependInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_PrependInterval) - The visible start range will be prepended with an additional interval.
* [AppendInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeRangePadding.html#Syncfusion_Maui_Charts_DateTimeRangePadding_AppendInterval) - The visible start range will be appended with an additional interval.

**Additional**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="Additional"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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


{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding support in MAUI Chart](Axis_Images/maui_chart_axis_datetime-range-padding_additional.jpg)

**None**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="None" />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding none in MAUI Chart](Axis_Images/maui_chart_axis_datetime-range-padding_none.jpg)

**Round**

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
. . .
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis RangePadding="Round"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>
. . .
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

{% endhighlight %}

{% endtabs %}

![DateTimeAxis range padding round in MAUI Chart](Axis_Images/maui_chart_axis_datetime-range-padding_round.jpg)