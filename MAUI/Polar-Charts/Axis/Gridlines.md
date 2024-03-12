---
layout: post
title: Axis Grid Lines in .NET MAUI Chart Control | Syncfusion
description: Learn here all about the chart axis grid lines and their customization in Syncfusion .NET MAUI Chart (SfPolarChart).
platform: maui
control: SfPolarChart
documentation: ug
---

# Grid Lines in .NET MAUI Chart

## Major Grid Lines

By default, major gridlines are automatically added to the [ChartAxis]() in its defined intervals. The visibility of the major gridlines can be controlled using the [ShowMajorGridLines]() property. The default value of [ShowMajorGridLines]() is `true`. 

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <chart:SfPolarChart.PrimaryAxis>
        <chart:NumericalAxis ShowMajorGridLines="False" />
    </chart:SfPolarChart.PrimaryAxis>
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfPolarChart.SecondaryAxis>
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.ShowMajorGridLines = false;
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

### Customization

The [MajorGridLineStyle]() property in the chart axis is used to customize the appearance of major gridlines.

{% tabs %}

{% highlight xaml %}
<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>3</x:Double>
            <x:Double>3</x:Double>
        </DoubleCollection>
    </chart:SfPolarChart.Resources>
    
    <chart:SfPolarChart.PrimaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.MajorGridLineStyle>
                <chart:ChartLineStyle StrokeDashArray="{StaticResource dashArray}"
									  Stroke="Black"
									  StrokeWidth="2" />
            </chart:NumericalAxis.MajorGridLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
    . . .
DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(3);

NumericalAxis primaryAxis = new NumericalAxis();
ChartLineStyle axisLineStyle = new ChartLineStyle();
axisLineStyle.Stroke = Colors.Black;
axisLineStyle.StrokeWidth = 2;
axisLineStyle.StrokeDashArray = doubleCollection;
primaryAxis.MajorGridLineStyle = axisLineStyle;
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Minor Grid Lines

Minor gridlines will be added automatically when the small tick lines is defined and using the [MinorTicksPerInterval]() property of the chart axis. The visibility of the minor gridlines can be controlled using the [ShowMinorGridLines]() property. The default value of [ShowMinorGridLines]() is `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <chart:SfPolarChart.PrimaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis MinorTicksPerInterval="3" />
    </chart:SfPolarChart.SecondaryAxis>
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.PrimaryAxis.Add(primaryAxis);
chart.SecondaryAxis = new NumericalAxis()
{
    MinorTicksPerInterval = 3,
};
chart.SecondaryAxis.Add(secondaryAxis);
. . .

{% endhighlight %}

{% endtabs %}

### Customization

The [MinorGridLineStyle]() property in the chart axis is used to customize the appearance of minor gridlines.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    . . .
    <chart:SfPolarChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>3</x:Double>
            <x:Double>3</x:Double>
        </DoubleCollection>
    </chart:SfPolarChart.Resources>

    <chart:SfPolarChart.PrimaryAxis>
        <chart:NumericalAxis/>
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis ShowMinorGridLines="True" MinorTicksPerInterval="2">
            <chart:NumericalAxis.MinorGridLineStyle>
                <chart:ChartLineStyle StrokeDashArray="{StaticResource dashArray}"
									  Stroke="Black" 
									  StrokeWidth="0.8"  />
            </chart:NumericalAxis.MinorGridLineStyle>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.PrimaryAxis.Add(primaryAxis);

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(3);

NumericalAxis secondaryAxis = new NumericalAxis() { MinorTicksPerInterval = 2 };
ChartLineStyle axisLineStyle = new ChartLineStyle();
axisLineStyle.Stroke = Colors.Black;
axisLineStyle.StrokeWidth = 0.8;
axisLineStyle.StrokeDashArray = doubleCollection;
secondaryAxis.MinorGridLineStyle = axisLineStyle;
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}