---
layout: post
title: Performance in .NET MAUI Chart control | Syncfusion
description: Learn about performance optimization using suspend and resume notifications in Syncfusion .NET MAUI Chart control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart performance, maui chart optimization, .net maui suspend notification, syncfusion maui chart performance, cartesian performance maui, .net maui chart real-time updates.
---

# Performance in .NET MAUI Chart (SfCartesianChart)

The .NET MAUI Chart provides performance optimization techniques to efficiently handle large datasets and dynamic data updates.

## Deferred Real-Time Updates

When updating chart data dynamically—such as adding, removing, or modifying multiple data points—each individual change triggers a complete chart refresh cycle. This can cause noticeable UI lag when dealing with bulk operations.

The chart provides suspension methods to batch multiple data changes and apply them in a single consolidated update:

* **SuspendNotification** - Suspends the series from updating the data till ResumeNotification is called. It is specifically used when you need to append the collection of data.

* **ResumeNotification** - Processes the data that is added to the data source after the SuspendNotification is called.

These methods can be called at both series level and chart level depending on the update scope.

### Series-Level Suspend and Resume

Use `SuspendNotification` and `ResumeNotification` methods on a specific series instance when appending or updating data for that individual series. This suspends the series from updating until `ResumeNotification` is called.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

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

Use `SuspendNotification` and `ResumeNotification` methods on the chart instance when updating data across multiple series simultaneously. This suspends all series in the chart from updating until `ResumeNotification` is called.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart x:Name="chart">
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

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

chart.SuspendNotification();


    for (int i = 0; i < 1000; i++)
    {
        viewModel.Data1.Add(new DataModel { XValue = i, YValue = GetValue1(i) });
        viewModel.Data2.Add(new DataModel { XValue = i, YValue = GetValue2(i) });
    }

chart.ResumeNotification();

{% endhighlight %}

{% endtabs %}

>**NOTE** For bulk operations involving 1000+ data points, using suspend/resume can reduce processing time or more compared to individual updates.
