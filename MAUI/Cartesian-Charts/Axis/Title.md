---
layout: post
title: Title for axis in .NET MAUI Chart control | Syncfusion
description: This section explains about chart axis title, title style, title template and its customization in .NET .NET MAUI chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis Title in MAUI Chart (SfCartesianChart)

The `Title` property is used to set the title for the chart axis.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        . . .
        <chart:SfCartesianChart.PrimaryAxis>
            <chart:CategoryAxis>
                <chart:CategoryAxis.Title>
                    <chart:ChartAxisTitle Text="Category"/>
                </chart:CategoryAxis.Title>
            </chart:CategoryAxis>
        </chart:SfCartesianChart.PrimaryAxis>
        <chart:SfCartesianChart.SecondaryAxis>
            <chart:NumericalAxis>
                <chart:NumericalAxis.Title>
                    <chart:ChartAxisTitle Text="Values"/>
                </chart:NumericalAxis.Title>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.SecondaryAxis>

    /chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    . . .
    CategoryAxis primaryAxis = new CategoryAxis();
    primaryAxis.Title.Text = "Category";
    chart.PrimaryAxis = primaryAxis;
    
    NumericalAxis secondaryAxis = new NumericalAxis();
    secondaryAxis.Title.Text = "Values";
    chart.SecondaryAxis = secondaryAxis;

{% endhighlight %}

{% endtabs %}

## Label Customization 

The `ChartAxisLabelStyle` is used to customize the appearance of chart axis labels. The axis labels can be customized using following properties:

* `FontFamily` - used to change the font family for the axis label.
* `FontAttributes` - used to change the font style for the axis label.
* `FontSize` - used to change the font size for the axis label.
* `LabelsPosition` - Used to set the position of the axis labels.
* `LabelAlignment` - Used to align the label at the `Start`, `Center`, or `End`.
* `MaxWidth` - Provides the maximum text width of the axis label and wraps into the next line when exceeds the maximum width.
* `WrappedLabelAlignment` - Positions the wrapped text at the start, center, or end. The default value of the WrappedLabelAlignment property is Start.



