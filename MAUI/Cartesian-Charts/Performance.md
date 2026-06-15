---
layout: post
title: Performance in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn about performance optimization using suspend and resume notifications in Syncfusion .NET MAUI Cartesian Chart control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart performance, maui chart optimization, .net maui suspend notification, syncfusion maui chart performance, cartesian performance maui, .net maui chart real-time updates.
---

# Performance in .NET MAUI Chart (SfCartesianChart)

The .NET MAUI Chart provides performance optimization techniques to efficiently handle large datasets and dynamic data updates.

## Deferred Real-Time Updates

When performing bulk or real-time updates such as adding, removing, or modifying multiple data points, the chart refreshes for every change, which may impact performance. To optimize this, use chart-level or series-level suspend and resume notification methods to batch updates and reduce unnecessary refresh cycles based on your requirements.

### Series-Level Suspend and Resume

Use `SuspendNotification` and `ResumeNotification` methods on a specific series instance when appending or updating data for that individual series. This suspends the series from updating until `ResumeNotification` is called.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.Series>
        <chart:FastLineSeries x:Name="series"
                          ItemsSource="{Binding Data}"
                          XBindingPath="XValue"
                          YBindingPath="YValue"/>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

series.SuspendNotification();

    for (int i = 0; i < 1000; i++)
    {
        viewModel.Data.Add(new DataModel 
        { 
            XValue = i, 
            YValue = GetRandomValue() 
        });
    }

series.ResumeNotification();

{% endhighlight %}

{% endtabs %}

### Chart-Level Suspend and Resume

Use `SuspendSeriesNotification` and `ResumeSeriesNotification` methods on the chart instance when updating data across multiple series simultaneously. This suspends all series in the chart from updating until `ResumeSeriesNotification` is called.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart x:Name="chart">
    ...
    <chart:SfCartesianChart.Series>
        <chart:FastLineSeries ItemsSource="{Binding Data1}"
                          XBindingPath="XValue"
                          YBindingPath="YValue"/>
        <chart:FastLineSeries ItemsSource="{Binding Data2}"
                            XBindingPath="XValue"
                            YBindingPath="YValue"/>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

chart.SuspendSeriesNotification();

    for (int i = 0; i < 1000; i++)
    {
        viewModel.Data1.Add(new DataModel { XValue = i, YValue = GetValue1(i) });
        viewModel.Data2.Add(new DataModel { XValue = i, YValue = GetValue2(i) });
    }

chart.ResumeSeriesNotification();

{% endhighlight %}

{% endtabs %}
