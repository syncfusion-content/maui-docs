---
layout: post
title: Histogram Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the Histogram chart and its type in Syncfusion .NET MAUI Chart (SfCartesianChart) control. 
platform: maui
control: SfCartesianChart
documentation: ug
---

# Histogarm Chart in .NET MAUI Chart

## Histogarm Chart

Histogram chart provides a visual display of large amount of data that are difficult to understand in a tabular or data grid form.

You can customize intervals using the [HistogramInterval]() property and collapse the normal distribution curve using the [ShowNormalDistributionCurve]() property. 


{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.XAxes>
            <chart:NumericalAxis>
            </chart:NumericalAxis>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis x:Name="yAxis"/>
        </chart:SfCartesianChart.YAxes>

        <chart:HistogramSeries ItemsSource="{Binding HistogramData}" 
                               XBindingPath="Value" 
                               YBindingPath="Size"
                               HistogramInterval="20" 
                               ShowNormalDistributionCurve="True">
        </chart:HistogramSeries>
    </chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();

    NumericalAxis xAxis = new NumericalAxis();
    chart.XAxes.Add(xAxis);

    NumericalAxis yAxis = new NumericalAxis();
    chart.YAxes.Add(yAxis);

    ViewModel viewModel = new ViewModel();

    HistogramSeries histogramSeries = new HistogramSeries
    {
        ItemsSource = new viewModel().HistogramData, 
        XBindingPath = "Value",
        YBindingPath = "Size",
        HistogramInterval = 20,
        ShowNormalDistributionCurve = true
    };

    chart.Series.Add(histogramSeries);

    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Histogram Chart in MAUI]()

## Customization of distribution curve

You can define the [CurveStyle]() of the distribution curve using the [ChartLineStyle]() property as in the following code example.


{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>
        ....

        <chart:HistogramSeries ItemsSource="{Binding HistogramData}" 
                               XBindingPath="Value" 
                               YBindingPath="Size"
                               HistogramInterval="20">
                               <chart:HistogramSeries.CurveStyle>
                                    <chart:ChartLineStyle Stroke="Blue"
                                                          StrokeWidth="2"
                                                          StrokeDashArray="5,6,3">
                                    </chart:ChartLineStyle>
                                </chart:HistogramSeries.CurveStyle>
        </chart:HistogramSeries>
    </chart:SfCartesianChart>


{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    ....
    ViewModel viewModel = new ViewModel();

    HistogramSeries histogramSeries = new HistogramSeries
    {
        ItemsSource = new viewModel().HistogramData, 
        XBindingPath = "Value",
        YBindingPath = "Size",
        HistogramInterval = 20,
        CurveStyle = new ChartLineStyle
        {
            Stroke = Color.Blue,
            StrokeWidth = 2,
            StrokeDashArray = new double[] { 5, 6, 3 }
        }
    };

    chart.Series.Add(histogramSeries);

    this.Content = chart;

{% endhighlight %}

{% endtabs %}


