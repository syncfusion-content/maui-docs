---
layout: post
title: Doughnut chart in .NET MAUI Chart Chart control | Syncfusion
description: Learn here all about doughnut chart and its features in Syncfusion .NET MAUI Chart Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Doughnut Chart in .NET MAUI Chart Chart

[DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) is similar to [PieSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html). It is used to show the relationship between parts of data and whole data. To render a [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) in circular chart, create an instance of the [DoughnutSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series) collection property of [SfCircularChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html).

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:DoughnutSeries ItemsSource="{Binding Data}" 
                                XBindingPath="Product" 
                                YBindingPath="SalesRate" />
        </chart:SfCircularChart.Series>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    DoughnutSeries series = new DoughnutSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Doughnut chart type in MAUI Chart](Chart-Types_images/maui_doughnut_chart.png)

## Doughnut Coefficient

The [DoughnutCoefficient](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_DoughnutCoefficient) property of doughnut series is used to define the inner circle.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:DoughnutSeries ItemsSource="{Binding Data}" DoughnutCoefficient="0.7" XBindingPath="Product" YBindingPath="SalesRate" />
        </chart:SfCircularChart.Series>

    </chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();

    DoughnutSeries series = new DoughnutSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    series.DoughnutCoefficient = 0.7;

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Doughnut chart with coefficient in MAUI Chart](Chart-Types_images/maui_doughnut_chart_doughnutcoefficient.png)

## Semi Doughnut

By using the [StartAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle) and [EndAngle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle) properties, you can draw doughnut series in different shapes such as semi-doughnut or quarter doughnut series.

{% tabs %}

{% highlight xaml %}

    <chart:SfCircularChart>

        <chart:SfCircularChart.Series>
            <chart:DoughnutSeries StartAngle="180" EndAngle="360"
                            ItemsSource="{Binding Data}"
                            XBindingPath="Product" 
                            YBindingPath="SalesRate" />
        </chart:SfCircularChart.Series>

    </chart:SfCircularChart>
    
{% endhighlight %}

{% highlight c# %}

    SfCircularChart chart = new SfCircularChart();

    DoughnutSeries series = new DoughnutSeries();
    series.XBindingPath = "Product";
    series.YBindingPath = "SalesRate";
    series.StartAngle = 180;
    series.EndAngle = 360;

    chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Semi doughnut chart in MAUI Chart](Chart-Types_images/maui_semi_doughnut_chart.png)