---
layout: post
title: Trendlines in MAUI Charts control | Syncfusion
description: This section explains all about trendlines support in Syncfusion® MAUI Charts (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart trendlines, maui chart trendlines, syncfusion maui trendlines chart, cartesian trendlines maui, .net maui trendlines visualization.
---

# Trendlines in MAUI Charts (SfCartesianChart)

A Trendline is a line drawn over a series to show the overall direction of the data. Trendlines help reveal patterns and can be used for simple forecasting.

N> Trendlines can be added to Cartesian series (Line, Spline, Column, Area, Scatter, Candle, HiLo, etc.). Bar series are not supported.

The following examples show how to add trendlines in MAUI Charts using XAML and C#.

{% tabs %}

{% highlight xaml %}

<ContentPage x:Class="TrendlineSample.MainPage"
             xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

  <syncfusion:SfCartesianChart x:Name="chart">  
    <syncfusion:LineSeries ItemsSource="{Binding Data}"
                           XBindingPath="X" 
                           YBindingPath="Y">
      <syncfusion:LineSeries.Trendlines>
        <syncfusion:LinearTrendline/>
      </syncfusion:LineSeries.Trendlines>
    </syncfusion:LineSeries>
  </syncfusion:SfCartesianChart>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;
using Microsoft.Maui.Graphics;

var series = new LineSeries { ItemsSource = viewModel.Data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new LinearTrendline());
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Trendline support in MAUI Charts](TrendlineS_images/default_trendline.png)

## Types of Trendline

MAUI Charts support the following trendline types:

* Linear  
* Exponential  
* Logarithmic  
* Power  
* Polynomial  
* MovingAverage

Each type is described below with simple examples.

### Linear

Linear trendline is a straight best-fit line for simple linear datasets. Use it when data increases or decreases at a steady rate.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding linearData}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:LinearTrendline Stroke="Blue" StrokeWidth="2"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = linearData, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new LinearTrendline { Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Linear type trendline](TrendlineS_images/linear_trend.png)

### Logarithmic

Logarithmic trendline fits data that changes rapidly and then levels off. It supports negative and positive values.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:LogarithmicTrendline Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new LogarithmicTrendline { Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Logarithmic type trendline](TrendlineS_images/logarithmic_trend.png)

### Exponential

Exponential trendline fits data that rises or falls at an increasing rate. Do not use when data contains zeros or negatives.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:ExponentialTrendline Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new ExponentialTrendline { Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Exponential type trendline](TrendlineS_images/exponential_trend.png)

### Power

Power trendline models data that grows at a specific multiplicative rate. Use positive values where applicable.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:PowerTrendline Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new PowerTrendline { Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Power type trendline](TrendlineS_images/power_trend.png)

### Polynomial

Polynomial trendline fits fluctuating data. Use Order to set the polynomial degree (default commonly 2). Avoid very high order to prevent excessive curve fitting.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:PolynomialTrendline Order="3" Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new PolynomialTrendline { Order = 3, Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Polynomial type trendline](TrendlineS_images/polynomial_trend.png)

### Moving Average

Moving Average smooths short-term fluctuations. Use Period to define the window size (integer > 1).

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:MovingAverageTrendline Period="5" Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new MovingAverageTrendline { Period = 5, Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Moving average trendline](TrendlineS_images/movingAverage_trend.png)

## Forecasting

Forecasting predicts future/past trends using ForwardForecast and BackwardForecast.

### Forward Forecasting

Set ForwardForecast to extend the trendline forward.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:LinearTrendline ForwardForecast="5" Stroke="Blue" StrokeWidth="2"  />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new LinearTrendline { ForwardForecast = 5, Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2});

{% endhighlight %}

{% endtabs %}

![Forward Forecasting](TrendlineS_images/forwardForecast_trend.png)

### Backward Forecasting

Set BackwardForecast to extend the trendline backward.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:LinearTrendline BackwardForecast="3" Stroke="Blue" StrokeWidth="2" />
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new LinearTrendline { BackwardForecast = 3, Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2  });

{% endhighlight %}

{% endtabs %}

![Backward Forecasting](TrendlineS_images/backwardForecast_trend.png)

## Customization

Customize stroke, width and dash pattern using Stroke, StrokeWidth and StrokeDashArray.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries.Trendlines>
  <syncfusion:LinearTrendline Stroke="Black" 
                              StrokeWidth="2"  
                              StrokeDashArray="5,6">
  </syncfusion:LinearTrendline>
</syncfusion:LineSeries.Trendlines>

{% endhighlight %}

{% highlight c# %}

var t = new LinearTrendline { Stroke = new SolidColorBrush(Colors.Black), StrokeWidth = 2  };
t.StrokeDashArray = new DoubleCollection { 5, 6 };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Custom stroke and dash](TrendlineS_images/custom_trend.png)

## Legend Item Visibility

Control trendline legend visibility with IsVisibleInLegend.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding linearData}" XBindingPath="X" YBindingPath="Y">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:LinearTrendline Stroke="Blue" StrokeWidth="2"  Label="Trend (shown in legend)"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new LinearTrendline {Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2 , Label = "Trend (shown in legend)" });

{% endhighlight %}

{% endtabs %}

![Trendline legend label](TrendlineS_images/trendline_legend_label.png)

N> Use Label to change legend text and LegendIconType to change legend icon.

## Markers

Enable markers on trendline points via MarkerSettings or MarkerTemplate.

{% tabs %}

{% highlight xaml %}

<syncfusion:LinearTrendline ShowMarkers="True">
  <syncfusion:LinearTrendline.MarkerSettings>
    <syncfusion:ChartMarkerSettings Width="8" Height="8" Type="Circle" Fill="Purple" Stroke="Blue"/>
  </syncfusion:LinearTrendline.MarkerSettings>
</syncfusion:LinearTrendline>

{% endhighlight %}

{% highlight c# %}

var t = new LinearTrendline();
t.ShowMarkers=true;
t.MarkerSettings = new ChartMarkerSettings { Width = 8, Height = 8 ,Stroke = new SolidColorBrush(Colors.Blue), Fill = new SolidColorBrush(Colors.Purple), Type=ShapeType.Circle };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Trendline markers](TrendlineS_images/Trendline_marker.png)

## Tooltip and Trackball

Enable tooltip for trendlines using EnableTooltip and customize with TooltipTemplate. Trackball labels can be enabled via ShowTrackballLabel and TrackballLabelTemplate.

{% tabs %}

{% highlight xaml %}


<syncfusion:LinearTrendline EnableTooltip="True" 
                            ShowTrackballLabel="True"/>

{% endhighlight %}

{% highlight c# %}

var t = new LinearTrendline { EnableTooltip = true, ShowTrackballLabel = true };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Tooltip example](TrendlineS_images/tooltip_trackball_trend.png)

## ValueField for Candle/HiLo series

Choose which value to use (High or Low) for trendline calculation on financial series.

{% tabs %}

{% highlight xaml %}

<syncfusion:LinearTrendline ValueField="High" />

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new LinearTrendline { ValueField = "High" });

{% endhighlight %}

{% endtabs %}

## Accessing computed statistics

Read computed values (Intercept, Coefficients, RSquared) only after the chart/trendline renders.

{% highlight c# %}

var trend = series.Trendlines.FirstOrDefault();
if (trend != null)
{
    double intercept = trend.Intercept;
    double rSquared = trend.RSquared;
    double[] coeff = trend.Coefficients;
}

{% endhighlight %}

## Complete XAML sample (multiple trendlines)

{% highlight xaml %}

<syncfusion:SfCartesianChart xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
                             xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                             x:Name="Chart" LegendVisibility="Visible">
  <syncfusion:SfCartesianChart.PrimaryAxis>
    <syncfusion:DateTimeAxis IntervalType="Days" Interval="1"/>
  </syncfusion:SfCartesianChart.PrimaryAxis>

  <syncfusion:LineSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
    <syncfusion:LineSeries.Trendlines>
      <syncfusion:LinearTrendline Stroke="RoyalBlue" StrokeWidth="2" Label="Linear" />
      <syncfusion:PolynomialTrendline Order="3" Stroke="Orange" StrokeWidth="2" Label="Polynomial (3)" />
      <syncfusion:MovingAverageTrendline Period="5" Stroke="Green" StrokeWidth="2" Label="MA (5)" />
    </syncfusion:LineSeries.Trendlines>
  </syncfusion:LineSeries>
</syncfusion:SfCartesianChart>

{% endhighlight %}

## Runtime creation (C#)

{% highlight c# %}

var chart = new SfCartesianChart { PrimaryAxis = new DateTimeAxis() };
var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };

series.Trendlines.Add(new LinearTrendline { Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2 });
series.Trendlines.Add(new PolynomialTrendline { Order = 3, Stroke = new SolidColorBrush(Colors.Orange) });
series.Trendlines.Add(new MovingAverageTrendline { Period = 5, Stroke = new SolidColorBrush(Colors.Green) });

chart.Series.Add(series);

{% endhighlight %}

## Notes & best practices

- Exponential and Power require positive non-zero data.  
- Keep Polynomial Order modest to avoid overly complex fitting.  
- MovingAverage Period must be an integer > 1.  
- Forecast values are in axis units; for DateTime axis they follow the axis Interval/IntervalType.  
- Read computed statistics only after rendering (Loaded/LayoutChanged or render callback).

N> For full API details and advanced scenarios refer to the official Syncfusion MAUI Charts documentation.
