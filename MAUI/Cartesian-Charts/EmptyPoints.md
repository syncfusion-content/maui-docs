---
layout: post
title: Empty Points in .NET MAUI Chart control | Syncfusion
description: Learn here all about empty points support and its features in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart empty points, .net maui empty points customization, syncfusion maui chart empty points, maui chart empty points, .net maui chart empty points visualization, cartesian empty points maui, missing data handling
---

# Empty Points in .NET MAUI Chart
Empty Points are used to indicate missing or null data in a series. These empty points can occur when data is unavailable, improperly formatted, or explicitly set as null or double.NaN. The chart provides options to handle and customize these empty points to enhance visualization and maintain the integrity of data representation.

[SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) provides support for empty points, allowing users to handle missing data effectively.

The data collection that is passed to the chart can have NaN or Null values that are considered as empty points. The empty point can be defined as in the below code example.

{% highlight C# %}

    MovieSales.Add(new Model() { Day = "Monday", TicketsSold = 60 });
    MovieSales.Add(new Model() { Day = "Tuesday", TicketsSold = 55 });
    MovieSales.Add(new Model() { Day = "Wednesday", TicketsSold = double.NaN });
    MovieSales.Add(new Model() { Day = "Thursday", TicketsSold = 62 });
    MovieSales.Add(new Model() { Day = "Friday", TicketsSold = 58 });
    MovieSales.Add(new Model() { Day = "Saturday", TicketsSold = double.NaN });
    MovieSales.Add(new Model() { Day = "Sunday", TicketsSold = 65 });

{% endhighlight %}

By default, the [EmptyPointMode]() property is None. So the empty points will not be rendered as shown in the below.

![Empty Points in MAUI Chart](EmptyPoints_images/EmptyPoints_Default.png)

## EmptyPointMode
The [EmptyPointMode]() property of series specifies how empty points should be handled. 

This property is an enumeration with the following options:

* None - Empty points are not rendered. This is the default behavior.
* Zero - Empty points will be replaced with zero.
* Average - Empty points will be replaced with the average value of the surrounding data points.

The following code example shows the [EmptyPointMode]() as Zero.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        .....

        <chart:LineSeries ItemsSource="{Binding MovieSales}"
                  XBindingPath="Day"
                  YBindingPath="TicketsSold"
                  Fill="#3068F7"
                  StrokeWidth="2"
                  ShowMarkers="True"
                  ShowDataLabels="True"
                  EmptyPointMode="Zero">
        </chart:LineSeries>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();

    .....

    LineSeries series = new LineSeries()
    {
        ItemsSource = new ViewModel().MovieSales,
        XBindingPath = "Day",
        YBindingPath = "TicketsSold",
        Fill = Color.FromArgb("#3068F7"),
        ShowDataLabels = true,
        ShowMarkers = true,
        EmptyPointMode = EmptyPointMode.Zero
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![EmptyPoint Mode Zero in MAUI Chart](EmptyPoints_images/EmptyPoints_Mode_Zero.png)

The following code example shows the [EmptyPointMode]() as Average.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        .....

        <chart:ColumnSeries ItemsSource="{Binding MovieSales}"
                  XBindingPath="Day"
                  YBindingPath="TicketsSold"
                  Fill="#3068F7"
                  ShowDataLabels="True"
                  EmptyPointMode="Average">
        </chart:ColumnSeries>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();

    .....

    ColumnSeries series = new ColumnSeries()
    {
        ItemsSource = new ViewModel().MovieSales,
        XBindingPath = "Day",
        YBindingPath = "TicketsSold",
        Fill = Color.FromArgb("#3068F7"),
        ShowDataLabels = true,
        EmptyPointMode = EmptyPointMode.Average
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![EmptyPoint Mode Average in MAUI Chart](EmptyPoints_images/EmptyPoints_Mode_Average.png)

## Customizing Empty Points
The [EmptyPointSettings]() property allows you to customize the appearance of empty points in a chart. This enables you to adjust various visual aspects of empty points, making them more distinct from the other data points. You can modify the following properties within [EmptyPointSettings]().

* [Fill]() - Gets or sets the fill color for the empty points.
* [Stroke]() - Gets or sets the stroke color for empty points.
* [StrokeWidth]() - Gets or sets the stroke thickness for empty points.

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        .....

        <chart:LineSeries ItemsSource="{Binding MovieSales}"
                  XBindingPath="Day"
                  YBindingPath="TicketsSold"
                  Fill="#3068F7"
                  StrokeWidth="2"
                  ShowMarkers="True"
                  ShowDataLabels="True"
                  EmptyPointMode="Average">
            <chart:LineSeries.EmptyPointSettings>
                <chart:EmptyPointSettings Fill="DarkOrange" 
                                        StrokeWidth="3"/>
            </chart:LineSeries.EmptyPointSettings>
        </chart:LineSeries>
    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();

    .....

    LineSeries series = new LineSeries()
    {
        ItemsSource = new ViewModel().MovieSales,
        XBindingPath = "Day",
        YBindingPath = "TicketsSold",
        Fill = Color.FromArgb("#3068F7"),
        StrokeWidth = 2,
        ShowDataLabels = true,
        ShowMarkers = true,
        EmptyPointMode = EmptyPointMode.Average
    };

    EmptyPointSettings emptypointSettings = new EmptyPointSettings()
    {
        Fill = Colors.Orange,
        StrokeWidth = 3
    };

    series.EmptyPointSettings = emptypointSettings;

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Customize EmptyPoints in MAUI Chart](EmptyPoints_images\Customize_EmptyPoints.png)

N> The EmptyPoints feature is not supported for Histogram and BoxAnd series.
