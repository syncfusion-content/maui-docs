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

<syncfusion:SfCartesianChart xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"
                             xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                             x:Name="chart">
  <syncfusion:SfCartesianChart.PrimaryAxis>
    <syncfusion:DateTimeAxis />
  </syncfusion:SfCartesianChart.PrimaryAxis>

  <syncfusion:LineSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
    <syncfusion:LineSeries.Trendlines>
      <syncfusion:Trendline Type="Linear" Label="Linear Trend" Stroke="Blue" StrokeWidth="2" />
    </syncfusion:LineSeries.Trendlines>
  </syncfusion:LineSeries>
</syncfusion:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;

var series = new LineSeries { ItemsSource = viewModel.Data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Linear, Label = "Linear Trend", Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2 });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Trendline support in MAUI Charts](#)

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
    <syncfusion:Trendline Type="Linear" Label="Linear"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = linearData, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Linear, Label = "Linear" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Linear type trendline](#)

### Logarithmic

Logarithmic trendline fits data that changes rapidly and then levels off. It supports negative and positive values.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Logarithmic" Label="Logarithmic"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Logarithmic, Label = "Logarithmic" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Logarithmic type trendline](#)

### Exponential

Exponential trendline fits data that rises or falls at an increasing rate. Do not use when data contains zeros or negatives.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Exponential" Label="Exponential"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Exponential, Label = "Exponential" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Exponential type trendline](#)

### Power

Power trendline models data that grows at a specific multiplicative rate. Use positive values where applicable.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Power" Label="Power"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Power, Label = "Power" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Power type trendline](#)

### Polynomial

Polynomial trendline fits fluctuating data. Use Order to set the polynomial degree (default commonly 2). Avoid very high order to prevent excessive curve fitting.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Polynomial" Order="3" Label="Polynomial (3)"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.Polynomial, Order = 3, Label = "Polynomial (3)" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Polynomial type trendline](#)

### Moving Average

Moving Average smooths short-term fluctuations. Use Period to define the window size (integer > 1).

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="MovingAverage" Period="5" Label="MA (5)"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };
series.Trendlines.Add(new Trendline { Type = TrendlineType.MovingAverage, Period = 5, Label = "MA (5)" });
chart.Series.Add(series);

{% endhighlight %}

{% endtabs %}

![Moving average trendline](#)

## Forecasting

Forecasting predicts future/past trends using ForwardForecast and BackwardForecast.

### Forward Forecasting

Set ForwardForecast to extend the trendline forward.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Linear" ForwardForecast="5" Label="Forward Forecast"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new Trendline { Type = TrendlineType.Linear, ForwardForecast = 5, Label = "Forward Forecast" });

{% endhighlight %}

{% endtabs %}

![Forward Forecasting](#)

### Backward Forecasting

Set BackwardForecast to extend the trendline backward.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries ItemsSource="{Binding data}">
  <syncfusion:LineSeries.Trendlines>
    <syncfusion:Trendline Type="Linear" BackwardForecast="3" Label="Backward Forecast"/>
  </syncfusion:LineSeries.Trendlines>
</syncfusion:LineSeries>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new Trendline { Type = TrendlineType.Linear, BackwardForecast = 3, Label = "Backward Forecast" });

{% endhighlight %}

{% endtabs %}

![Backward Forecasting](#)

## Customization

Customize stroke, width and dash pattern using Stroke, StrokeWidth and StrokeDashArray.

{% tabs %}

{% highlight xaml %}

<syncfusion:LineSeries.Trendlines>
  <syncfusion:Trendline Stroke="Black" StrokeWidth="3" Opacity="0.9">
    <syncfusion:Trendline.StrokeDashArray>
      <x:Double>5</x:Double>
      <x:Double>6</x:Double>
    </syncfusion:Trendline.StrokeDashArray>
  </syncfusion:Trendline>
</syncfusion:LineSeries.Trendlines>

{% endhighlight %}

{% highlight c# %}

var t = new Trendline { Stroke = new SolidColorBrush(Colors.Black), StrokeWidth = 3, Opacity = 0.9 };
t.StrokeDashArray = new DoubleCollection { 5, 6 };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Custom stroke and dash](#)

## Legend Item Visibility

Control trendline legend visibility with IsVisibleInLegend.

{% tabs %}

{% highlight xaml %}

<syncfusion:Trendline IsVisibleInLegend="True" Label="Trend (shown in legend)"/>

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new Trendline { IsVisibleInLegend = true, Label = "Trend (shown in legend)" });

{% endhighlight %}

{% endtabs %}

N> Use Label to change legend text and LegendIconType to change legend icon.

## Markers

Enable markers on trendline points via MarkerSettings or MarkerTemplate.

{% tabs %}

{% highlight xaml %}

<syncfusion:Trendline>
  <syncfusion:Trendline.MarkerSettings>
    <syncfusion:ChartMarkerSettings IsVisible="True" Width="8" Height="8" Shape="Circle" Fill="White" Stroke="Blue"/>
  </syncfusion:Trendline.MarkerSettings>
</syncfusion:Trendline>

{% endhighlight %}

{% highlight c# %}

var t = new Trendline { Type = TrendlineType.Linear };
t.MarkerSettings = new ChartMarkerSettings { IsVisible = true, Width = 8, Height = 8 };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Trendline markers](#)

## Tooltip and Trackball

Enable tooltip for trendlines using EnableTooltip and customize with TooltipTemplate. Trackball labels can be enabled via ShowTrackballLabel and TrackballLabelTemplate.

{% tabs %}

{% highlight xaml %}

<ContentPage.Resources>
  <DataTemplate x:Key="TrendlineTooltip">
    <Grid Padding="6">
      <Label Text="{Binding Y, StringFormat='Value: {0:F2}'}" FontAttributes="Bold"/>
    </Grid>
  </DataTemplate>
</ContentPage.Resources>

<syncfusion:Trendline EnableTooltip="True" TooltipTemplate="{StaticResource TrendlineTooltip}" ShowTrackballLabel="True"/>

{% endhighlight %}

{% highlight c# %}

var t = new Trendline { EnableTooltip = true, TooltipTemplate = myDataTemplate, ShowTrackballLabel = true };
series.Trendlines.Add(t);

{% endhighlight %}

{% endtabs %}

![Tooltip example](#)

## ValueField for Candle/HiLo series

Choose which value to use (High or Low) for trendline calculation on financial series.

{% tabs %}

{% highlight xaml %}

<syncfusion:Trendline ValueField="High" />

{% endhighlight %}

{% highlight c# %}

series.Trendlines.Add(new Trendline { ValueField = "High" });

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
      <syncfusion:Trendline Type="Linear" Stroke="RoyalBlue" StrokeWidth="2" Label="Linear" />
      <syncfusion:Trendline Type="Polynomial" Order="3" Stroke="Orange" StrokeWidth="2" Label="Polynomial (3)" />
      <syncfusion:Trendline Type="MovingAverage" Period="5" Stroke="Green" StrokeWidth="2" Label="MA (5)" />
    </syncfusion:LineSeries.Trendlines>
  </syncfusion:LineSeries>
</syncfusion:SfCartesianChart>

{% endhighlight %}

## Runtime creation (C#)

{% highlight c# %}

var chart = new SfCartesianChart { PrimaryAxis = new DateTimeAxis() };
var series = new LineSeries { ItemsSource = data, XBindingPath = "X", YBindingPath = "Y" };

series.Trendlines.Add(new Trendline { Type = TrendlineType.Linear, Stroke = new SolidColorBrush(Colors.Blue), StrokeWidth = 2 });
series.Trendlines.Add(new Trendline { Type = TrendlineType.Polynomial, Order = 3, Stroke = new SolidColorBrush(Colors.Orange) });
series.Trendlines.Add(new Trendline { Type = TrendlineType.MovingAverage, Period = 5, Stroke = new SolidColorBrush(Colors.Green) });

chart.Series.Add(series);

{% endhighlight %}

## Notes & best practices

- Exponential and Power require positive non-zero data.  
- Keep Polynomial Order modest to avoid overly complex fitting.  
- MovingAverage Period must be an integer > 1.  
- Forecast values are in axis units; for DateTime axis they follow the axis Interval/IntervalType.  
- Read computed statistics only after rendering (Loaded/LayoutChanged or render callback).

N> For full API details and advanced scenarios refer to the official Syncfusion MAUI Charts documentation.
