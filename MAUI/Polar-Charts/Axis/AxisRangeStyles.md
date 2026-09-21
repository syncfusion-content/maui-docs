---
layout: post
title: Axis Range Styles in .NET MAUI Polar Chart | Syncfusion®
description: Axis Range Styles in .NET MAUI Polar Chart allow customization of labels, grid lines, and tick elements for specific axis ranges.
platform: maui
control: SfPolarChart
documentation: ug
keywords: .net maui polar chart axis range style, polar chart range styles maui, customize polar axis elements maui, polar chart axis label style maui, syncfusion maui polar axis range style.
---

# Axis Range Styles in .NET MAUI Polar Chart

The [RangeStyles]() property allows you to customize the appearance of individual axis elements within a specified range.

The following axis elements can be customized using [ChartAxisRangeStyle]():

- [MajorGridLineStyle]()
- [MinorGridLineStyle]()
- [MajorTickStyle]()
- [MinorTickStyle]()
- [LabelStyle]()

The following example demonstrates how to customize major and minor grid lines within specific axis ranges.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis>
            <chart:NumericalAxis.RangeStyles>
                <chart:ChartAxisRangeStyle Start="20" End="40">
                    <chart:ChartAxisRangeStyle.MajorGridLineStyle>
                        <chart:ChartLineStyle
                            Stroke="Blue"
                            StrokeWidth="2" />
                    </chart:ChartAxisRangeStyle.MajorGridLineStyle>
                </chart:ChartAxisRangeStyle>
                <chart:ChartAxisRangeStyle Start="40" End="60">
                    <chart:ChartAxisRangeStyle.MinorGridLineStyle>
                        <chart:ChartLineStyle
                            Stroke="Green"
                            StrokeWidth="1"
                            StrokeDashArray="4,2" />
                    </chart:ChartAxisRangeStyle.MinorGridLineStyle>
                </chart:ChartAxisRangeStyle>
            </chart:NumericalAxis.RangeStyles>
        </chart:NumericalAxis>
    </chart:SfPolarChart.SecondaryAxis>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

NumericalAxis axis = new NumericalAxis();

axis.RangeStyles.Add(new ChartAxisRangeStyle()
{
    Start = 20,
    End = 40,
    MajorGridLineStyle = new ChartLineStyle()
    {
        Stroke = Colors.Blue,
        StrokeWidth = 2
    }
});

axis.RangeStyles.Add(new ChartAxisRangeStyle()
{
    Start = 40,
    End = 60,
    MinorGridLineStyle = new ChartLineStyle()
    {
        Stroke = Colors.Green,
        StrokeWidth = 1,
        StrokeDashArray = new double[] { 4, 2 }
    }
});

chart.SecondaryAxis = axis;
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis Range Styles in .NET MAUI Cartesian Chart](Axis_Images/Polar_axis_range_style.png)