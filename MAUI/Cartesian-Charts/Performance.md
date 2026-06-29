---
layout: post
title: Performance in .NET MAUI Cartesian Chart control | Syncfusion
description: Explore performance optimization techniques for .NET MAUI Cartesian Chart with fast series, real-time updates, and responsive data visualization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart performance, maui chart optimization, .net maui fast line chart, .net maui fast scatter chart, .net maui suspend notification, syncfusion maui chart performance, cartesian performance maui, .net maui chart real-time updates, maui chart large dataset.
---

# Performance in .NET MAUI Cartesian Chart

The .NET MAUI Chart provides performance optimization techniques to efficiently handle large datasets and dynamic data updates. Whether we are rendering thousands of data points or pushing real-time updates, the following strategies help us get the best rendering performance from `SfCartesianChart`.

## Fast Chart in .NET MAUI Cartesian Charts

A fast series is a special kind of chart series that can render a collection with a huge number of data points efficiently. Unlike standard series, fast series render all data points using a single segment, which significantly reduces the rendering overhead and improves frame rates when dealing with large datasets.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:FastLineSeries ItemsSource="{Binding Data}"
                          XBindingPath="XValue"
                          YBindingPath="YValue"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
FastLineSeries series = new FastLineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![FastLine chart type in MAUI Chart](Chart-types-images/maui_fastline_chart.png)

**When to use fast series:**

* Use fast series when we need to plot continuous time-series or sensor data with thousands of points.
* Prefer fast series over standard series whenever rendering performance is a priority and advanced per-point customization is not required.

## ListenPropertyChange in .NET MAUI Charts

The `ListenPropertyChange` property allows the chart to update dynamically when the underlying data source properties change. This enables real-time data visualization with responsive updates. By leveraging `INotifyPropertyChanged`, the data points automatically reflect changes, ensuring the chart remains responsive to data updates.

Use `ListenPropertyChange` with our series when our data model implements `INotifyPropertyChanged`:

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:LineSeries ItemsSource="{Binding DataSource}"
                      XBindingPath="Category"
                      YBindingPath="Metric"
                      ListenPropertyChange="True" />
    ...
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

public class DataModel : INotifyPropertyChanged
{
    private string category;
    private double metric;

    public string Category
    {
        get => category;
        set
        {
            if (category != value)
            {
                category = value;
                OnPropertyChanged(nameof(Category));
            }
        }
    }

    public double Metric
    {
        get => metric;
        set
        {
            if (metric != value)
            {
                metric = value;
                OnPropertyChanged(nameof(Metric));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

{% endhighlight %}

{% endtabs %}

* Enabling the `ListenPropertyChange` property registers the `PropertyChanged` event for every object in the data source.

* When dealing with a large number of data points, registering these events can slow down the chart's loading time.

N> To optimize performance and avoid unnecessary event registration, the `ListenPropertyChange` property is set to `false` by default.

## Deferred Real-Time Updates

When performing bulk or real-time updates such as adding, removing, or modifying multiple data points, the chart refreshes for every change, which may impact performance. To optimize this, use chart-level or series-level suspend and resume notification methods to batch updates and reduce unnecessary refresh cycles based on our requirements.

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

N> `SuspendNotification` and `ResumeNotification` (and their chart-level equivalents) apply only to the data source updates of the series. Other chart elements such as annotations are not considered and will not be suspended or resumed by these methods.

## Additional Performance Best Practices

For more tips and best practices on improving chart design and rendering performance, refer to the following resources:

* [12 Chart Design Tips Every Developer Needs To Know](https://www.syncfusion.com/blogs/post/chart-design-tips-for-every-developer)
* [How to optimize FastLine series performance in .NET MAUI Chart](https://support.syncfusion.com/kb/article/18844/how-to-optimize-fastline-series-performance-in-net-maui-chart)

