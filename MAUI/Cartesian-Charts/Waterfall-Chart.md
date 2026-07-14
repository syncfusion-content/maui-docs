---
layout: post
title: Waterfall Chart in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about the Waterfall Series chart and its features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui waterfall chart, .net maui bridge chart, waterfall chart customization .net maui, syncfusion maui waterfall chart, cartesian waterfall chart maui, .net maui chart waterfall visualization.
---

# Waterfall Chart in .NET MAUI Cartesian Chart

## Waterfall chart

[WaterfallSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html) clarifies the cumulative effect of a set of provided positive and negative values. The series is represented by a rectangle and a connector between the rectangles. To render a waterfall chart, create an instance of [WaterfallSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

The following properties customize the waterfall series:

* [SummaryBindingPath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_SummaryBindingPath), of type `string`, is used to get or set the path value on the source subject to serve summary values to the series.
* [SummaryPointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_SummaryPointsBrush), of type `Brush`, is used to change the fill of the summary segment of the series.
* [NegativePointsBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_NegativePointsBrush), of type `Brush`, is used to change the fill of the negative segment of the series.
* [AllowAutoSum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_AllowAutoSum), of type `bool`, is used to change the summary segment calculation. The default value is `true`. When this property is disabled, the segment is rendered using the y value of the provided ItemsSource collection.
* [ShowConnectorLine](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_ShowConnectorLine), of type `bool`, is used to enable or disable the connector line. The default value is `true`.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    
    <chart:SfCartesianChart.Series>
        <chart:WaterfallSeries ItemsSource="{Binding Sales}"
                               XBindingPath="Department"
                               YBindingPath="Value"
                               AllowAutoSum="True"
                               NegativePointsBrush="Red"
                               SummaryBindingPath="IsSummary"
                               SummaryPointsBrush="RoyalBlue"
                               ShowConnectorLine="True"/>
    </chart:SfCartesianChart.Series>   
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis xAxis = new CategoryAxis();
NumericalAxis yAxis = new NumericalAxis();
chart.XAxes.Add(xAxis);
chart.YAxes.Add(yAxis);
   
ViewModel viewModel = new ViewModel();

WaterfallSeries series = new WaterfallSeries()
{
    ItemsSource = new viewModel().Sales,
    XBindingPath = "Department",
    YBindingPath = "Value",
    AllowAutoSum = true,
    NegativePointsBrush = new SolidColorBrush(Colors.Red),
    SummaryBindingPath = "IsSummary",
    SummaryPointsBrush = new SolidColorBrush(Colors.RoyalBlue),
    ShowConnectorLine = true,
};
    
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Waterfall Chart in .NET MAUI Cartesian Chart](Chart-types-images/maui_waterfall_Basic.png)

## Connector line customization

The connector line can be customized by applying the [ConnectorLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.WaterfallSeries.html#Syncfusion_Maui_Charts_WaterfallSeries_ConnectorLineStyle) property of the series.
The following code example illustrates how to apply style for connector line.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart.Series>
    <chart:WaterfallSeries ItemsSource="{Binding Sales}"
                           XBindingPath="Department"
                           YBindingPath="Value">
        <chart:WaterfallSeries.ConnectorLineStyle>
                <chart:ChartLineStyle Stroke="DarkViolet" StrokeWidth="2"/>
        </chart:WaterfallSeries.ConnectorLineStyle>
    </chart:WaterfallSeries>
</chart:SfCartesianChart.Series>   
    
{% endhighlight %}

{% highlight c# %}

ChartLineStyle lineStyle = new ChartLineStyle()
{
    Stroke = new SolidColorBrush(Colors.DarkViolet),
    StrokeThickness = 2
};

WaterfallSeries series = new WaterfallSeries()
{
    ItemsSource = new viewModel().Sales,
    XBindingPath = "Department",
    YBindingPath = "Value",
    ConnectorLineStyle = lineStyle,
};

chart.Series.Add(series);
    
{% endhighlight %}

{% endtabs %}

![Connector line customization for Waterfall Chart in .NET MAUI Cartesian Chart](Chart-types-images/maui_waterfall_LineStyle.png)
