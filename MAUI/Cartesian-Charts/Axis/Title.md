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

