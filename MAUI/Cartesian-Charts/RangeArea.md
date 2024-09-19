---
layout: post
title: Range Area Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about range area chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui range area chart, maui range area chart, .net maui chart range area type, range area chart customization .net maui, syncfusion maui range area chart, cartesian range area chart maui, .net maui chart range area visualization.
---

# Range Area Chart in .NET MAUI Chart

## Range Area Chart

Range Area Chart is a type of data visualization useful for displaying the relationship between two variables over time. In this Series, the area between two lines is filled to indicate a range of values, such as a high and low price range or an upper and lower limit.

By displaying ranges of data, range area series can make it easier to compare multiple datasets at once.

To render a range area chart, create an instance of the [RangeAreaSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAreaSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

Since the [RangeAreaSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAreaSeries.html) requires two Y values for each point, your data should contain both the high and low values. These high and low values specify the maximum and minimum ranges of the point.

N> The Cartesian chart has the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>   
     
    <chart:RangeAreaSeries ItemsSource="{Binding Data}"
                           XBindingPath="XValue"
                           High="HighValue"
                           Low="LowValue"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

RangeAreaSeries series = new RangeAreaSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    High="HighValue",
    Low="LowValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Range Area chart type in MAUI Chart](Chart-types-images/maui_range_area.png)

## Enable Marker

A marker, also known as a symbol, is used to determine or highlight the position of the data point. To enable markers in the series, set the [ShowMarkers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAreaSeries.html#Syncfusion_Maui_Charts_RangeAreaSeries_ShowMarkers) property to true.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:RangeAreaSeries XBindingPath="XValue"
                           High="HighValue"
                           Low="LowValue"
                           ItemsSource="{Binding Data}"
                           ShowMarkers="True"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
RangeAreaSeries series = new RangeAreaSeries()
{
    XBindingPath = "XValue",
    High = "HighValue",
    Low = "LowValue",
    ItemsSource = new ViewModel().Data,
    ShowMarkers= true,
};

chart.Series.Add(series);
this.Content= chart;

{% endhighlight %}

{% endtabs %}

### Marker Customization

In order to change the series markers’ appearance, create an instance of the [MarkerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAreaSeries.html#Syncfusion_Maui_Charts_RangeAreaSeries_MarkerSettings) property. The following properties are used to customize marker appearance.

* [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Type), of type `ShapeType`, describes the shape of the series marker. The default value of this property is the [ShapeType.Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeType.html#Syncfusion_Maui_Charts_ShapeType_Circle).
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Stroke), of type `Brush`, indicates the brush used to paint the marker border.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_StrokeWidth), of type `double`, indicates the width of the marker border.
* [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Fill), of type `Brush`, indicates the color of the marker.
* [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Width), of type `double`, indicates the width of the marker.
* [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Height), of type `double`, indicates the height of the marker.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:RangeAreaSeries XBindingPath="XValue"
                           High="HighValue"
                           Low="LowValue"
                           ItemsSource="{Binding Data}"
                           ShowMarkers="True">
        <chart:RangeAreaSeries.MarkerSettings>
            <chart:ChartMarkerSettings Type="Diamond"
                                       Fill="Brown"
                                       Stroke="Black"
                                       StrokeWidth="1"
                                       Height="8"
                                       Width="8"/>
        </chart:RangeAreaSeries.MarkerSettings>
    </chart:RangeAreaSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
ChartMarkerSettings chartMarker= new ChartMarkerSettings();
chartMarker.Type = ShapeType.Diamond;
chartMarker.Fill = Colors.Brown;
chartMarker.Stroke = Colors.Black;
chartMarker.StrokeWidth= 1;
chartMarker.Height = 8;
chartMarker.Width = 8;

RangeAreaSeries series = new RangeAreaSeries()
{
    XBindingPath = "XValue",
    High = "HighValue",
    Low = "LowValue",
    ItemsSource = new ViewModel().Data,
    ShowMarkers = true,
    MarkerSettings = chartMarker
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}