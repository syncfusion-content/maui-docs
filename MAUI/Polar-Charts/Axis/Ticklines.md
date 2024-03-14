---
layout: post
title: Axis Tick Line in .NET MAUI Chart Control | Syncfusion
description: Learn here all about the chart axis tick lines and their customization in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Tick Lines in .NET MAUI Chart

Tick lines are the small lines which is drawn on the axis line representing the axis labels. By default, tick lines are drawn outside of the axis.

Minor tick lines can be added to the axis by defining the [MinorTicksPerInterval]() property. This property will add the minor tick lines to every interval based on value.

N> For category axis, minor tick lines are not applicable as it is rendered based on index positions.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
<chart:SfPolarChart.PrimaryAxis>
    <chart:NumericalAxis />
</chart:SfPolarChart.PrimaryAxis>

<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis MinorTicksPerInterval="4"/>
</chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis()
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    MinorTicksPerInterval = 4 
};
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}

## Customization

Both major and minor tick lines can be customized using the [MajorTickStyle]() and [MinorTickStyle]() properties respectively. They provide options to change the [StrokeWidth](), [TickSize](), [Stroke]() of tick lines. By default, minor tick lines will not be visible.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
. . .
<chart:SfPolarChart.PrimaryAxis>
    <chart:NumericalAxis />
</chart:SfPolarChart.PrimaryAxis>

<chart:SfPolarChart.SecondaryAxis>
    <chart:NumericalAxis MinorTicksPerInterval="4">
        <chart:NumericalAxis.MajorTickStyle>
            <chart:ChartAxisTickStyle Stroke="Red"
									  StrokeWidth="1"
									  TickSize="10"/>
        </chart:NumericalAxis.MajorTickStyle>
        
        <chart:NumericalAxis.MinorTickStyle>
            <chart:ChartAxisTickStyle Stroke="Red" StrokeWidth="1"/>
        </chart:NumericalAxis.MinorTickStyle>
    </chart:NumericalAxis>
</chart:SfPolarChart.SecondaryAxis>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
NumericalAxis primaryAxis = new NumericalAxis();
chart.PrimaryAxis.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
numerical.MajorTickStyle.StrokeWidth = 1;
numerical.MajorTickStyle.Stroke = Colors.Red;
numerical.MajorTickStyle.TickSize = 10;
numerical.MinorTicksPerInterval = 4;
numerical.MinorTickStyle.StrokeWidth = 1;
numerical.MinorTickStyle.Stroke = Colors.Red;
chart.SecondaryAxis.Add(secondaryAxis);

{% endhighlight %}

{% endtabs %}