---
layout: post
title: Axis Range Styles in .NET MAUI Cartesian Chart | Syncfusion®
description: Axis Range Styles in .NET MAUI Cartesian Chart allow customization of labels, grid lines, and tick elements for specific axis ranges.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart axis range style, axis range styles maui chart, customize axis elements maui chart, chart axis label style maui, syncfusion maui axis range style.
---

# Axis Range Styles in .NET MAUI Cartesian Chart

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
<chart:SfCartesianChart>
    <chart:SfCartesianChart.YAxes>
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
    </chart:SfCartesianChart.YAxes>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

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

chart.YAxes.Add(axis);
// code omitted for brevity
this.Content = chart;    

{% endhighlight %}

{% endtabs %}