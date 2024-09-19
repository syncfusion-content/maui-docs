---
layout: post
title: Step Area Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the Step area chart types and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui step area chart, maui step area chart, .net maui chart step area type, step area chart customization .net maui, syncfusion maui step area chart, cartesian step area chart maui, .net maui chart step area visualization, syncfusion maui stair-step area chart.
---

# Step Area Chart in .NET MAUI Chart

## Step Area Chart
The step area chart displays data that changes over time or across different categories. 
In a step area chart, the data points are connected by horizontal and vertical lines to create a series of steps. Each step represents a specific time interval or category. The area between the steps is then filled with a color or shading. To render an area chart, create an instance of [StepAreaSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StepAreaSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). 

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>   

    <chart:StepAreaSeries ItemsSource="{Binding Data}"
                          XBindingPath="Month"
                          YBindingPath="Value"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

StepAreaSeries series = new StepAreaSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Month",
    YBindingPath = "Value",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Step Area chart type in MAUI Chart](Chart-types-images/maui_StepArea_chart.png)

## Enable Marker

A marker, also known as a symbol, determines or highlights the data point’s position. To enable markers in the series, set the [ShowMarkers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AreaSeries.html#Syncfusion_Maui_Charts_AreaSeries_ShowMarkers) property to true.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:StepAreaSeries XBindingPath="Month"
                          YBindingPath="Value"
                          ItemsSource="{Binding Data}"
                          ShowMarkers="True"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...
StepAreaSeries series = new StepAreaSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = new ViewModel().Data,
    ShowMarkers= true,
 };

chart.Series.Add(series);
this.Content= chart;

{% endhighlight %}

{% endtabs %}

### Marker customization

To change the series markers appearance, create an instance of the [MarkerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AreaSeries.html#Syncfusion_Maui_Charts_AreaSeries_MarkerSettings) property. The following properties are used to customize marker appearance.

* [Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Type), of type `ShapeType`, describes the shape of the series marker. The default value of this property is [ShapeType.Circle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeType.html#Syncfusion_Maui_Charts_ShapeType_Circle).
* [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Stroke), of type `Brush`, indicates the brush used to paint the marker border.
* [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_StrokeWidth), of type `double`, indicates the width of the marker border.
* [Fill](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Fill), of type `Brush`, indicates the color of the marker.
* [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Width), of type `double`, indicates the width of the marker.
* [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Height), of type `double`, indicates the height of the marker.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:StepAreaSeries XBindingPath="Month"
                          YBindingPath="Value"
                          ItemsSource="{Binding Data}"
                          ShowMarkers="True">
        <chart:StepAreaSeries.MarkerSettings>
            <chart:ChartMarkerSettings Type="Diamond"
                                        Fill="Brown"
                                        Stroke="Black"
                                        StrokeWidth="1"
                                        Height="8"
                                        Width="8"/>
        </chart:StepAreaSeries.MarkerSettings>
    </chart:StepAreaSeries>
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

StepAreaSeries = new StepAreaSeries()
{
   XBindingPath = "Month",
   YBindingPath = "Value",
   ItemsSource = new ViewModel().Data,
   ShowMarkers = true,
   MarkerSettings = chartMarker
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}