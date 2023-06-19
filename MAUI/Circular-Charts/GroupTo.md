---
layout: post
title: Grouping data points in .NET MAUI Chart control | Syncfusion
description: This section explains about how to group data points in Syncfusion .NET MAUI Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# Grouping Data Points in .NET MAUI SfCircularChart

The small segments in the circular chart can be grouped into an `Others` category using the [GroupTo]() and [GroupMode]() properties of the circular chart. The [GroupMode]() property is used to specify the grouping type based on slice angle, actual data point value, or percentage. The [GroupTo]() property is used to set the limit to group data points into a single slice. The grouped segment is labeled as `Others` in the chart legend.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart>

        <chart:PieSeries ItemsSource="{Binding Data}" 
                         GroupMode="Value"
                         GroupTo="15"
                         XBindingPath="Product" 
                         YBindingPath="SalesRate"/>
  
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
. . .
PieSeries series = new PieSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath="Product", 
    YBindingPath="SalesRate",
    GroupMode=Value,
    GroupTo=15
};

chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Grouped data points circular chart in MAUI](GroupTo_images/GroupTo_in_CircularChart.png)