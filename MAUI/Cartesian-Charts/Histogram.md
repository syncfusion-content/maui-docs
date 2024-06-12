---
layout: post
title: Histogram Chart in .NET MAUI Chart Control | Syncfusion
description: Learn here all about the Histogram chart and its type in Syncfusion .NET MAUI Chart (SfCartesianChart) control. 
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui histogram chart, histogram chart customization .net maui, syncfusion maui histogram chart, cartesian histogram chart maui, .net maui chart histogram , .net maui frequency distribution chart.
---

# Histogram Chart in .NET MAUI Chart
[Histogram chart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HistogramSeries.html?tabs=tabid-1%2Ctabid-28) is a graphical representation that organizes a group of data points into user-specified ranges. It is similar in appearance to a column chart.

Customize histogram intervals using the [HistogramInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HistogramSeries.html#Syncfusion_Maui_Charts_HistogramSeries_HistogramInterval) property and normal distribution curve can be collapsed using the [ShowNormalDistributionCurve](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HistogramSeries.html#Syncfusion_Maui_Charts_HistogramSeries_ShowNormalDistributionCurve) property. 

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
        <chart:SfCartesianChart.XAxes>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis />
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

HistogramSeries histogramSeries = new HistogramSeries
{
    ItemsSource = new ViewModel().HistogramData, 
    XBindingPath = "Value",
    YBindingPath = "Size",
    HistogramInterval = 20,
    ShowNormalDistributionCurve = true
};

chart.Series.Add(histogramSeries);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Histogram Chart in MAUI](chart-types-images/maui_Histogram_chart.png)

## Customization of distribution curve

Customize the normal distribution curve by using the [CurveLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.HistogramSeries.html#Syncfusion_Maui_Charts_HistogramSeries_CurveStyle) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
        ....

      <chart:HistogramSeries ItemsSource="{Binding HistogramData}" 
                             XBindingPath="Value" 
                             YBindingPath="Size"
                             HistogramInterval="20"
                             ShowNormalDistributionCurve="True">
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
  
HistogramSeries histogramSeries = new HistogramSeries
{
    ItemsSource = new ViewModel().HistogramData, 
    XBindingPath = "Value",
    YBindingPath = "Size",
    HistogramInterval = 20,
    ShowNormalDistributionCurve = true,
    CurveStyle = new ChartLineStyle()
    {
        Stroke = Color.Blue,
        StrokeWidth = 2,
        StrokeDashArray = new double[] { 5, 6, 3 }
    };
};

chart.Series.Add(histogramSeries);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Customized distribution curve of Histogram chart](chart-types-images/maui_Histogram_chart_distribution_curve.png)