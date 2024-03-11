---
layout: post
title: Polar Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the Polar line chart type and its features in the Syncfusion .NET MAUI Chart (SfPolarChart) control.
platform: maui
control: SfPolarChart
documentation: ug
---

# Polar Line Chart in .NET MAUI Chart

## Polar Line Chart

To display an line series in a polar chart, instantiate the [PolarLineSeries]() and include it in the [Series]() collection property of [SfPolarChart]().

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
    
    <chart:SfPolarChart.PrimaryAxis>
        <chart:CategoryAxis />
    </chart:SfPolarChart.PrimaryAxis>

    <chart:SfPolarChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfPolarChart.SecondaryAxis>   

    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}"
					  XBindingPath="Direction"
					  YBindingPath="Tree"/>  

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis.Add(secondaryAxis);

PolarLineSeries series = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Polar line chart type in MAUI Chart](Chart-types_images/MAUI_polar_line_chart.png)

## Grid line Type

The [GridLineType]() property used to modify the rendering style of axis grid lines. The default [GridLineType]() is [Circle](). Switching to the [Polygon]() grid line type transforms the polar chart appearance, resembling a spider or web chart.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart GridLineType="Polygon"> 
. . .
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}"
					  XBindingPath="Direction"
					  YBindingPath="Tree"/>  

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
chart.GridLineType = PolarChartGridLineType.Polygon;
. . .
PolarLineSeries series = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Polar gridline type in MAUI Chart](Chart-types_images/MAUI_polar_line_gridline.png)

## Closed Series

The [IsClosed]() property used to render the series with or without closed path. The default value of [IsClosed]() is true.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart> 
. . .
    <chart:PolarLineSeries ItemsSource="{Binding PlantDetails}"
					  XBindingPath="Direction"
					  YBindingPath="Tree"
                      IsClosed="False"/>  

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
. . .
PolarLineSeries series = new PolarLineSeries()
{
    ItemsSource = new ViewModel().PlantDetails,
    XBindingPath = "Direction",
    YBindingPath = "Tree",
    IsClosed = "False"
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Polar open series in MAUI Chart](Chart-types_images/MAUI_polar_line_IsClosed.png)

## Enable Marker

A marker, also known as a symbol, is used to determine or highlight the position of the data point. To enable markers in the series, set the [ShowMarkers]() property to true.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
...
 <chart:PolarLineSeries XBindingPath="Direction"
                   YBindingPath="Tree"
                   ItemsSource="{Binding PlantDetails}"
                   ShowMarkers="True"/>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

...
PolarLineSeries series = new PolarLineSeries()
{
    XBindingPath = "Direction",
    YBindingPath = "Tree",
    ItemsSource = new ViewModel().PlantDetails,
    ShowMarkers= true
 };

chart.Series.Add(series);
this.Content= chart;

{% endhighlight %}

{% endtabs %}

### Marker customization

In order to change the series markers appearance, create an instance of the [MarkerSettings]() property. The following properties are used to customize marker appearance.

* [Type](), of type `ShapeType`, describes the shape of the series marker. The default value of this property is [ShapeType.Circle]().
* [Stroke](), of type `Brush`, indicates the brush used to paint the marker border.
* [StrokeWidth](), of type `double`, indicates the width of the marker border.
* [Fill](), of type `Brush`, indicates the color of the marker.
* [Width](), of type `double`, indicates the width of the marker.
* [Height](), of type `double`, indicates the height of the marker.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart>
...
 <chart:PolarLineSeries XBindingPath="Direction"
                   YBindingPath="Tree"
                   ItemsSource="{Binding PlantDetails}"
                   ShowMarkers="True">
    <chart:PolarLineSeries.MarkerSettings>
        <chart:ChartMarkerSettings Type="Diamond"
                                   Fill="Brown"
                                   Stroke="Black"
                                   StrokeWidth="1"
                                   Height="8"
                                   Width="8"/>
    </chart:PolarLineSeries.MarkerSettings>
 </chart:PolarLineSeries>

</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();

...
PolarLineSeries series = new PolarLineSeries()
{
   XBindingPath = "Direction",
   YBindingPath = "Tree",
   ItemsSource = new ViewModel().PlantDetails,
   ShowMarkers = true,
 };

ChartMarkerSettings chartMarker= new ChartMarkerSettings();
        chartMarker.Type = ShapeType.Diamond;
        chartMarker.Fill = Colors.Brown;
        chartMarker.Stroke = Colors.Black;
        chartMarker.StrokeWidth= 1;
        chartMarker.Height = 8;
        chartMarker.Width = 8;


chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}