---
layout: post
title: Axis types in .NET MAUI Chart control | Syncfusion
description: Learn here all about axis types and their features in Syncfusion .NET MAUI Chart (SfPolarChart) control and more.
platform: maui
control: SfPolarChart
documentation: ug
---

# Types of Axis in .NET MAUI Chart

Polar chart supports the following types of chart axis.

* NumericalAxis
* CategoryAxis
* DateTimeAxis
* LogarithmicAxis

## Numerical Axis

[NumericalAxis]() is used to plot numerical values to the chart. [NumericalAxis]() can be defined for both [PrimaryAxis]() and [SecondaryAxis]().

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.PrimaryAxis>
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis();
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![NumericalAxis interval support in MAUI Chart](Axis_Images/MAUI_numerical_axis.png)

### Interval

Axis interval can be customized by using the [Interval]() property. By default, interval will be calculated based on the minimum and maximum value of the provided data.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
<chart:SfPolarChart.PrimaryAxis>
    <chart:NumericalAxis Interval="10" />
</chart:SfPolarChart.PrimaryAxis>
<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis/>
</chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis()
{
    Interval = 10, 
};
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

### Customizing the Range

[Maximum]() and [Minimum]() properties of axis is used for setting the maximum and minimum value of the axis range respectively.

N> If  minimum or maximum value is set, the other value is calculated by default internally.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis Maximum="100" Minimum="0" Interval="20"/>
</chart:SfPolarChart.SecondaryAxis>

{% endhighlight %}

{% highlight c# %}

NumericalAxis secondaryAxis = new NumericalAxis()
{
    Maximum = 100,
    Minimum = 0,
    Interval = 20
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Category Axis

The [CategoryAxis]() is an indexed based axis that plots values based on the index of the data point collection. The points are equally spaced here.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
<chart:SfPolarChart.PrimaryAxis>
    <chart:CategoryAxis/>
</chart:SfPolarChart.PrimaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![CategoryAxis support in MAUI Chart](Axis_Images/MAUI_category_axis.png)

### Label placement

The [LabelPlacement]() property in [CategoryAxis]() is used to placed the axis labels based on ticks and between ticks. The default value of [LabelPlacement]() is [OnTicks]().

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis LabelPlacement="BetweenTicks"/>
    </chart:SfPolarChart.PrimaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelPlacement = LabelPlacement.BetweenTicks
};
chart.PrimaryAxis.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

### Interval

By default, the [CategoryAxis]() axis labels are display with fixed interval 1. It can customized by using the [Interval]() property of axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis Interval="2" />
    </chart:SfPolarChart.PrimaryAxis>
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
CategoryAxis primaryAxis = new CategoryAxis()
{
    Interval = 2, 
};
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

### Indexed category axis

In Polar Charts, the [ArrangeByIndex]() property is used to determine how the items in a category axis are arranged. 

If [ArrangeByIndex]() is set to true, then the items in the category axis will be arranged according to their index values.

If [ArrangeByIndex]() is set to false, then the items in the category axis will be arranged according to their values. By default, [ArrangeByIndex]() is true.

The following code illustrates how to define the property [ArrangeByIndex]() in chart.

{% tabs %}

{% highlight xaml %}

    <chart:SfPolarChart>
        . . .
        <chart:SfPolarChart.PrimaryAxis>
            <chart:CategoryAxis ArrangeByIndex="False" />
        </chart:SfPolarChart.PrimaryAxis>
        <chart:SfPolarChart.SecondaryAxis>
            <chart:NumericalAxis/>
        </chart:SfPolarChart.SecondaryAxis>

        <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}"
                            XBindingPath="Direction"
                            YBindingPath="Tree"/>

        <chart:PolarAreaSeries ItemsSource="{Binding PlantDetails}"
                            XBindingPath="Direction"
                            YBindingPath="Flower"/>

        </chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

    SfPolarChart chart = new SfPolarChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis()
    {
        ArrangeByIndex = false, 
    };
    chart.PrimaryAxis.Add(primaryAxis);

    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis.Add(secondaryAxis);  

    PolarAreaSeries series1 = new PolarAreaSeries();
    series1.ItemsSource = ItePlantDetailsms; 
    series1.XBindingPath = "Direction";
    series1.YBindingPath = "Tree";

    PolarAreaSeries series2 = new PolarAreaSeries();
    series2.ItemsSource = PlantDetails;  
    series2.XBindingPath = "Direction";
    series2.YBindingPath = "Flower";

    chart.Series.Add(series1);
    chart.Series.Add(series2);  

{% endhighlight %}

{% endtabs %}    

## DateTime Axis

[DateTimeAxis]() is used to plot `DateTime` values. The [DateTimeAxis]() is widely used to make financial charts in places like the Stock Market, where index plotting is done every day.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:DateTimeAxis/>
    </chart:SfPolarChart.PrimaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.PrimaryAxis.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

![DateTimeAxis support in MAUI Chart](Axis_Images/MAUI_datetime_axis.png)

### Interval

In [DateTimeAxis](), intervals can be customized by using the [Interval]() and [IntervalType]() properties. For example, setting [Interval]() as 6 and [IntervalType]() as [Months]() will consider 6 months as interval.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    ...
    <chart:SfPolarChart.PrimaryAxis>
        <chart:DateTimeAxis Interval="6" IntervalType="Months"/>
    </chart:SfPolarChart.PrimaryAxis>
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Interval = 6, 
    IntervalType = DateTimeIntervalType.Months
};
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

### Customizing the Range

[Minimum]() and [Maximum]() properties behavior is same as in [NumericalAxis]() instead of setting numerical value, have to set date time values.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.PrimaryAxis>
        <chart:DateTimeAxis Minimum="2021/05/10" Maximum="2021/11/01"/>
    </chart:SfPolarChart.PrimaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
DateTimeAxis primaryAxis = new DateTimeAxis()
{
    Minimum = new DateTime(2021,05,10),
    Maximum = new DateTime(2021,11,01),
};
chart.PrimaryAxis.Add(primaryAxis);

{% endhighlight %}

{% endtabs %}

## Logarithmic Axis

The [LogarithmicAxis]() uses a logarithmic scale, and it is very useful in visualizing data when the given data range has a big difference. It can be used either on the x-axis or the chart's y-axis.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>

   . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:LogarithmicAxis/>
    </chart:SfPolarChart.SecondaryAxis>
    
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

. . .

LogarithmicAxis secondaryAxis = new LogarithmicAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis support in MAUI Chart]()

### Interval

Axis interval can be customized using the [Interval]() property of the axis. By default, interval will be calculated based on the minimum and maximum value of the provided data. And the default value of the interval is 1. 

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart.SecondaryAxis>

    <chart:LogarithmicAxis Interval="2"/>

</chart:SfPolarChart.SecondaryAxis>

{% endhighlight %}

{% highlight c# %}

chart.SecondaryAxis.Add(new LogarithmicAxis( ) { Interval = 2 });

{% endhighlight %}

{% endtabs %}

### Range customization

To customize the range of the log axis, you can use the [Minimum](), [Maximum]() properties of the [LogarithmicAxis](). By default, an excellent range will be calculated automatically based on the provided data. 

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart.SecondaryAxis>

    <chart:LogarithmicAxis Minimum="100" Maximum="10000"/>

</chart:SfPolarChart.SecondaryAxis>


{% endhighlight %}

{% highlight c# %}

chart.SecondaryAxis.Add(new LogarithmicAxis() { 
	Minimum = 100, 
	Maximum = 10000 
});

{% endhighlight %}

{% endtabs %}

### Base customization

The logarithmic axis base can be customized using the [LogarithmicBase]() property of the axis. By default, the base value is 10.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart.SecondaryAxis>

    <chart:LogarithmicAxis LogarithmicBase="5"/>

</chart:SfPolarChart.SecondaryAxis>

{% endhighlight %}

{% highlight c# %}

chart.SecondaryAxis.Add(new LogarithmicAxis( ) { LogarithmicBase = 5 });

{% endhighlight %}

{% endtabs %}

![LogarithmicAxis base customization in MAUI Chart]()

## Inversed

Axis can be inverted by using the [IsInversed]() property. The default value of this property is `False`.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis IsInversed="True"/>
    </chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.IsInversed = true;
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Axis Visibility

Axis visibility can be controlled using the [IsVisible]() property of axis. Default value of [IsVisible]() property is `True`.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis IsVisible="False"/>
</chart:SfPolarChart.SecondaryAxis>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis secondaryAxis = new NumericalAxis() { IsVisible = false };
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Events

### ActualRangeChanged

The [ActualRangeChanged]() event is triggered when the actual range of the axis is changed. The argument contains the following information:

* [ActualMinimum]() - used to get the actual minimum value of the axis.
* [ActualMaximum]() - used to get the actual maximum value of the axis.

N> The actual range is changed by specifying the [ZoomPosition]() and [ZoomFactor]() properties or zooming the chart interactively.

### LabelCreated

The [LabelCreated]() event is triggered when the axis label is created. The argument contains the following information:

* [Label]() - Used to get or set the text of axis label.
* [Position]() - Used to get the position of label.
* [LabelStyle]() - Used to customize the appearance of axis labels.