---
layout: post
title: Explode segments in .NET MAUI Chart control | Syncfusion
description: This section explains about how to explode single segment or all segments in Syncfusion .NET MAUI Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Explode segments in .NET MAUI SfCircularChart

Exploding a segment is used to pull attention to a specific area of the circular chart. The following properties are used to explode the segments in the circular chart.

* [ExplodeIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeIndex) - Used to explode any specific segment.
* [ExplodeRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeRadius) - Used to define the explode distance.
* [ExplodeOnTouch]() - Can be used to explode a specific segment by touch interaction when value is true.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>
    . . .
    <chart:DoughnutSeries x:Name="DoughnutSeries" ItemsSource="{Binding Data}" ExplodeIndex="2" ExplodeRadius="10" ExplodeOnTouch="True" XBindingPath="Utilization" YBindingPath="ResponseTime" />
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
. . .
DoughnutSeries series = new DoughnutSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Utilization",
    YBindingPath = "ResponseTime",
    ExplodeIndex = 2,
    ExplodeRadius = 10,
    ExplodeOnTouch = true
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Exploded doughnut chart in MAUI](Explode_images/explode_segment_in_circularchart.gif)