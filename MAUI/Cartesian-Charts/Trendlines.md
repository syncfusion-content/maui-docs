---
layout: post
title: Trendlines in MAUI Charts control | Syncfusion
description: This section explains all about trendlines support in Syncfusion® MAUI Charts (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui trendlines, maui chart trendlines, cartesian trendlines, trend analysis, data forecasting, trend prediction, trendline customization, syncfusion maui charts, sfcartesianchart, maui data visualization, trend pattern recognition.
---

# Trendlines in MAUI Charts

A trendline is a visual representation of the linear relationship between data points in a series. It shows the overall direction and trend of data by fitting a line (or curve) through the data points. 

N> We can draw trendlines for all type of Cartesian series except bar type.

You can add trendlines to your charts using XAML or C# as shown in the following examples.

{% tabs %}

{% highlight xaml %}

<ContentPage x:Class="TrendlineSample.MainPage"
             xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

  <chart:SfCartesianChart x:Name="chart">  
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}"
                      XBindingPath="X" 
                      YBindingPath="Y">
      <chart:ColumnSeries.Trendlines>
        <chart:LinearTrendline/>
      </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
  </chart:SfCartesianChart>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.Charts;
using Microsoft.Maui.Graphics;

SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new LinearTrendline());
chart.Series.Add(series);
this.Content = chart;

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

Each type is described below.

### Linear

A linear trendline draws a straight line through your data. Use this when your data moves in a consistent direction—either steadily up or down. It's the simplest way to show the overall trend in your data.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y"
};
series.Trendlines.Add(new LinearTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Linear type trendline](TrendlineS_images/linear_trend.png)

### Logarithmic

A logarithmic trendline shows data that changes quickly at first and then levels off. This is useful for showing how something grows or reduces rapidly in the beginning but then stabilizes over time.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LogarithmicTrendline Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new LogarithmicTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Logarithmic type trendline](TrendlineS_images/logarithmic_trend.png)

### Exponential

An exponential trendline shows data that grows or shrinks at an increasingly fast rate. Use this for data that accelerates over time, like population growth or viral spread. This trendline requires all positive values and cannot work with zero or negative numbers.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:ExponentialTrendline Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new ExponentialTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Exponential type trendline](TrendlineS_images/exponential_trend.png)

### Power

A power trendline models data that accelerates at different rates. It works well for scientific or physical measurements where the rate of change depends on the magnitude of the values. Always use positive values for best results.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:PowerTrendline Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new PowerTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Power type trendline](TrendlineS_images/power_trend.png)

### Polynomial

A polynomial trendline is a curved line that follows the ups and downs in your data. Use this when your data has multiple peaks and valleys or doesn't follow a straight line. You can control how closely the curve follows your data using the `Order` property (default is 2).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:PolynomialTrendline Order="3" Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new PolynomialTrendline 
{ 
    Order = 3, 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Polynomial type trendline](TrendlineS_images/polynomial_trend.png)

### Moving Average

A moving average trendline smooths out small bumps in your data by averaging nearby points. This helps you see the main trend without being distracted by temporary ups and downs. You can change how many points are used for averaging with the `Period` property (default is 2).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:MovingAverageTrendline Period="5" Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new MovingAverageTrendline 
{ 
    Period = 5, 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Moving average trendline](TrendlineS_images/movingAverage_trend.png)

## Forecasting

Forecasting extends the trendline beyond your existing data to predict future or past values based on the established trend. This is useful for projecting outcomes or understanding historical patterns. You can extend the trendline using two properties:

* **ForwardForecast** - Extends the trendline into the future
* **BackwardForecast** - Extends the trendline into the past

### Forward Forecasting

Use the `ForwardForecast` property to extend the trendline forward and visualize predicted future trends. The value represents the number of data points to forecast ahead.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline ForwardForecast="5" Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new LinearTrendline 
{ 
    ForwardForecast = 5, 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Forward Forecasting](TrendlineS_images/trendline_forward_forecast.png)

### Backward Forecasting

Use the `BackwardForecast` property to extend the trendline backward and visualize historical trend projections. The value represents the number of data points to forecast backward.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline BackwardForecast="3" Stroke="Blue" StrokeWidth="2"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new LinearTrendline 
{ 
    BackwardForecast = 3, 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Backward Forecasting](TrendlineS_images/trendline_backward_forecast.png)

## Customization

You can customize the appearance of trendlines to match your chart design. The key customization properties are:

* **Stroke** - Sets the color of the trendline
* **StrokeWidth** - Defines the thickness of the trendline
* **StrokeDashArray** - Creates a dashed or dotted line pattern

The following example shows how to customize a trendline with a black color, thickness of 2, and a dashed pattern:

{% tabs %}

{% highlight xaml %}
<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline Stroke="Black" StrokeWidth="2" StrokeDashArray="5,6"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>
{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
var trendline = new LinearTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Black), 
    StrokeWidth = 2 
};
trendline.StrokeDashArray = new DoubleCollection { 5, 6 };
series.Trendlines.Add(trendline);
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Custom stroke and dash](TrendlineS_images/custom_trend.png)

## Trendline Legend Label

You can display a custom label for the trendline in the chart legend using the `Label` property. This helps distinguish between multiple trendlines and makes your chart more descriptive.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline Stroke="Blue" StrokeWidth="2" Label="Trend (shown in legend)"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
series.Trendlines.Add(new LinearTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2, 
    Label = "Trend (shown in legend)" 
});
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Trendline legend label](TrendlineS_images/trendline_legend_label.png)

## Markers

Markers are visual indicators (like circles, squares, etc.) placed along the trendline to highlight specific data points. You can enable and customize markers using:

* **ShowMarkers** - Enables markers on the trendline
* **MarkerSettings** - Customizes the appearance, size, shape, and color of markers

This is helpful for emphasizing key points on the trendline or making it more visually distinct.

{% tabs %}

{% highlight xaml %}
<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline ShowMarkers="True">
                <chart:LinearTrendline.MarkerSettings>
                    <chart:ChartMarkerSettings Width="8" Height="8" Type="Circle" Fill="Purple" Stroke="Blue"/>
                </chart:LinearTrendline.MarkerSettings>
            </chart:LinearTrendline>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>
{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
var trendline = new LinearTrendline() { ShowMarkers = true };
trendline.MarkerSettings = new ChartMarkerSettings 
{ 
    Width = 8, 
    Height = 8, 
    Stroke = new SolidColorBrush(Colors.Blue), 
    Fill = new SolidColorBrush(Colors.Purple), 
    Type = ShapeType.Circle 
};
series.Trendlines.Add(trendline);
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Trendline markers](TrendlineS_images/Trendline_marker.png)

## Tooltip and Trackball

Tooltips and trackball labels provide interactive information when users hover over or tap the trendline:

* **EnableTooltip** - Displays a tooltip showing trendline data when hovered
* **ShowTrackballLabel** - Displays a label when the trackball intersects the trendline
* **TooltipTemplate** - Customizes the tooltip appearance and content
* **TrackballLabelTemplate** - Customizes the trackball label appearance

These features enhance user interactivity and data exploration.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
            <chart:LinearTrendline EnableTooltip="True" ShowTrackballLabel="True"/>
        </chart:ColumnSeries.Trendlines>
    </chart:ColumnSeries>
</chart:SfCartesianChart>
{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
var series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};
var trendline = new LinearTrendline 
{ 
    EnableTooltip = true, 
    ShowTrackballLabel = true 
};
series.Trendlines.Add(trendline);
chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Tooltip example](TrendlineS_images/tooltip_trackball_trend.png) 

## Multiple Trendlines

You can add multiple trendlines to a single series to compare different trend models and find the best fit for your data. This is useful for:

* Comparing different trendline types (Linear vs. Polynomial vs. Moving Average)
* Analyzing which trend model best represents your data
* Providing multiple perspectives on the same dataset

Each trendline can have different properties, colors, and labels to make them easily distinguishable.

{% tabs %}
{% highlight xaml %}

<ContentPage x:Class="TrendlineSample.MainPage"
             xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts"> 
    <chart:SfCartesianChart x:Name="chart">
      . . .
      <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="X" YBindingPath="Y">
        <chart:ColumnSeries.Trendlines>
          <chart:LinearTrendline Stroke="RoyalBlue" StrokeWidth="2" Label="Linear" />
          <chart:PolynomialTrendline Order="3" Stroke="Orange" StrokeWidth="2" Label="Polynomial (3)" />
          <chart:MovingAverageTrendline Period="5" Stroke="Green" StrokeWidth="2" Label="MovingAverage (5)" />
        </chart:ColumnSeries.Trendlines>
      </chart:ColumnSeries>
    </chart:SfCartesianChart>
</ContentPage>
{% endhighlight %}
 

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
ColumnSeries series = new ColumnSeries() 
{ 
    ItemsSource = new ViewModel().Data, 
    XBindingPath = "X", 
    YBindingPath = "Y" 
};

series.Trendlines.Add(new LinearTrendline 
{ 
    Stroke = new SolidColorBrush(Colors.Blue), 
    StrokeWidth = 2, 
    Label = "Linear" 
});
series.Trendlines.Add(new PolynomialTrendline 
{ 
    Order = 3, 
    Stroke = new SolidColorBrush(Colors.Orange), 
    Label = "Polynomial (3)" 
});
series.Trendlines.Add(new MovingAverageTrendline 
{ 
    Period = 5, 
    Stroke = new SolidColorBrush(Colors.Green), 
    Label = "MovingAverage (5)" 
});

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}
{% endtabs %} 
![Multiple Trendlines](TrendlineS_images/multiple_trend.png) 
