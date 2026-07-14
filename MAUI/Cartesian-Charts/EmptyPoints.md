---
layout: post
title: Empty points in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about empty points support and their features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart empty points, .net maui empty points customization, syncfusion maui chart empty points, maui chart empty points, .net maui chart empty points visualization, cartesian empty points maui, missing data handling
---

# Empty points in .NET MAUI Cartesian Chart

Empty points are used to indicate missing or null data in a series. These empty points can occur when data is unavailable, improperly formatted, or explicitly set as null or `double.NaN`. The chart provides options to handle and customize these empty points to enhance visualization and maintain the integrity of data representation.

[SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) provides support for empty points, allowing users to handle missing data effectively.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

The data collection that is passed to the chart can have `NaN` or null values that are considered as empty points. The empty points can be defined as in the following code example.

{% tabs %}

{% highlight c# %}

ProductSales = new ObservableCollection<Model>();
ProductSales.Add(new Model() { Product = "Electronics", Sales = 60 });
ProductSales.Add(new Model() { Product = "Clothing", Sales = 40 });
ProductSales.Add(new Model() { Product = "Groceries", Sales = double.NaN });
ProductSales.Add(new Model() { Product = "Furniture", Sales = 70 });
ProductSales.Add(new Model() { Product = "Toys", Sales = 30 });
ProductSales.Add(new Model() { Product = "Sports", Sales = double.NaN });
ProductSales.Add(new Model() { Product = "Books", Sales = 50 });

{% endhighlight %}

{% endtabs %}

By default, the [EmptyPointMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html) property is [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html#Syncfusion_Maui_Charts_EmptyPointMode_None). So the empty points will not be rendered as shown below.

![Empty points in .NET MAUI Cartesian Chart](EmptyPoints_images/EmptyPoints_Default.png)

## Empty point mode

The [EmptyPointMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html) property of the series specifies how empty points should be handled. 

This property provides the following options:

* **None** - Empty points are not rendered. This is the default behavior.
* **Zero** - Empty points will be replaced with zero.
* **Average** - Empty points will be replaced with the average value of the surrounding data points.

The following code example shows the [EmptyPointMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html) as [Zero](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html#Syncfusion_Maui_Charts_EmptyPointMode_Zero).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
   <chart:LineSeries ItemsSource="{Binding ProductSales}"
                  XBindingPath="Product"
                  YBindingPath="Sales"
                  EmptyPointMode="Zero">
   </chart:LineSeries>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
//code omitted for brevity
LineSeries series = new LineSeries()
{
   ItemsSource = new ViewModel().ProductSales,
   XBindingPath = "Product",
   YBindingPath = "Sales",
   EmptyPointMode = EmptyPointMode.Zero
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Empty point mode Zero in .NET MAUI Cartesian Chart](EmptyPoints_images/EmptyPoints_Mode_Zero.png)

The following code example shows the [EmptyPointMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html) as [Average](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointMode.html#Syncfusion_Maui_Charts_EmptyPointMode_Average).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
   <chart:ColumnSeries ItemsSource="{Binding ProductSales}"
                  XBindingPath="Product"
                  YBindingPath="Sales"
                  EmptyPointMode="Average">
   </chart:ColumnSeries>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
//code omitted for brevity
ColumnSeries series = new ColumnSeries()
{
   ItemsSource = new ViewModel().ProductSales,
   XBindingPath = "Product",
   YBindingPath = "Sales",
   EmptyPointMode = EmptyPointMode.Average
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Empty point mode Average in .NET MAUI Cartesian Chart](EmptyPoints_images/EmptyPoints_Mode_Average.png)

## Empty point customization

The [EmptyPointSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointSettings.html) property allows you to customize the appearance of empty points in a series. This enables you to adjust various visual aspects of empty points, making them more distinct from the other data points. You can modify the following properties within [EmptyPointSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointSettings.html).

* [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointSettings.html#Syncfusion_Maui_Charts_EmptyPointSettings_Fill) - Gets or sets the fill color for the empty points.
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointSettings.html#Syncfusion_Maui_Charts_EmptyPointSettings_Stroke) - Gets or sets the stroke color for empty points.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EmptyPointSettings.html#Syncfusion_Maui_Charts_EmptyPointSettings_StrokeWidth) - Gets or sets the stroke thickness for empty points.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
   <chart:LineSeries ItemsSource="{Binding ProductSales}"
                  XBindingPath="Product"
                  YBindingPath="Sales"
                  Fill="#3068F7"
                  StrokeWidth="2"
                  ShowMarkers="True"
                  ShowDataLabels="True"
                  EmptyPointMode="Average">
        <chart:LineSeries.EmptyPointSettings>
            <chart:EmptyPointSettings Fill="Orange" StrokeWidth="2"/>
        </chart:LineSeries.EmptyPointSettings>
    </chart:LineSeries>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
//code omitted for brevity
LineSeries series = new LineSeries()
{
   ItemsSource = new ViewModel().ProductSales,
   XBindingPath = "Product",
   YBindingPath = "Sales",
   Fill = Color.FromArgb("#3068F7"),
   StrokeWidth = 2,
   ShowMarkers = true,
   ShowDataLabels = true,
   EmptyPointMode = EmptyPointMode.Average
};

EmptyPointSettings emptypointSettings = new EmptyPointSettings()
{
   Fill = Colors.Orange,
   StrokeWidth = 2
};

series.EmptyPointSettings = emptypointSettings;

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Customize empty points in .NET MAUI Cartesian Chart](EmptyPoints_images/Customize_EmptyPoints.png)

N> EmptyPoint support is not applicable for Histogram and BoxAndWhisker series.
