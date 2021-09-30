---
layout: post
title: Pie Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the pie chart and its features in Syncfusion .NET MAUI Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Pie Chart in .NET MAUI Chart (SfCircularChart)

To render a `PieSeries` in circular chart, create an instance of the `PieSeries` and add it to the `Series` collection property of `SfCircularChart`.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:PieSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Product" 
                            YBindingPath="SalesRate"/>
        </chart:SfCircularChart.Series>
            
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    PieSeries series = new PieSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Circular Coefficient

The rendering size of the `PieSeries` can be controlled using the `CircularCoefficient` property as shown in the following code sample.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:PieSeries ItemsSource="{Binding Data}" 
                            XBindingPath="Product" 
                            YBindingPath="SalesRate"
                            CircularCoefficient = "0.9"/>
        </chart:SfCircularChart.Series>
            
    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    PieSeries series = new PieSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    series.CircularCoefficient = 0.9;

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

## Semi Pie

By using the `StartAngle` and `EndAngle` properties, you can draw pie series in different shapes such as semi-pie or quarter pie series.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:PieSeries StartAngle="180" EndAngle="360" ItemsSource="{Binding Data}  XBindingPath="Product"  YBindingPath="SalesRate" ShowDataLabels="True"/>
        </chart:SfCircularChart.Series>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    PieSeries series = new PieSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    series.StartAngle = 180;
    series.EndAngle = 360;

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}
