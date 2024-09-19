---
layout: post
title: Stacked Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about stacked line chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Stacked Line Chart in .NET MAUI Chart

## Stacked Line Chart

The stacked line chart is a type of chart that displays multiple line series stacked on top of each other, with the values of each series combined to show a cumulative value of the data points.

To render a stacked line chart, create an instance of the [StackingLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingLineSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

N> The Cartesian chart has a [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:SfCartesianChart.BindingContext>
        <local:ViewModel/>
    </chart:SfCartesianChart.BindingContext>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:StackingLineSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Month"
                                YBindingPath="Value"/>        

    <chart:StackingLineSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Month"
                                YBindingPath="Value"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data3}"
                                XBindingPath="Month"
                                YBindingPath="Value"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data4}"
                                XBindingPath="Month"
                                YBindingPath="Value"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ViewModel viewModel = new ViewModel();

StackingLineSeries series1 = new  StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1
};

StackingLineSeries series2 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data2
};
StackingLineSeries series3 = new StackingLineSeries()       
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data3
};

StackingLineSeries series4 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data4   
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
chart.Series.Add(series3); 
chart.Series.Add(series4); 

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Stacking Line Chart in .NET MAUI Cartesian Charts.](chart-types-images\net-maui-cartesian-charts-stacked-line-chart.png)

## Dashed Stacked Line

The [StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingSeriesBase.html#Syncfusion_Maui_Charts_StackingSeriesBase_StrokeDashArray) property of [StackingLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingLineSeries.html) is used to render the stacked line series with dashes. Odd value is considered as rendering size and even value is considered as gap.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>5</x:Double>
            <x:Double>2</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.BindingContext>
        <local:ViewModel/>
    </chart:SfCartesianChart.BindingContext>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>  

    <chart:StackingLineSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Month"
                                YBindingPath="Value"  
                                StrokeDashArray="{StaticResource dashArray}"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Month"
                                YBindingPath="Value"  
                                StrokeDashArray="{StaticResource dashArray}"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data3}"
                                XBindingPath="Month"
                                YBindingPath="Value"   
                                StrokeDashArray="{StaticResource dashArray}"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data4}"
                                XBindingPath="Month"
                                YBindingPath="Value"       
                                StrokeDashArray="{StaticResource dashArray}"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ViewModel viewModel = new ViewModel();

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(5);
doubleCollection.Add(2);
. . .
StackingLineSeries series1 = new  StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1,
    StrokeDashArray = doubleCollection
};

StackingLineSeries series2 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data2,
    StrokeDashArray = doubleCollection
};

StackingLineSeries series3 = new StackingLineSeries()       
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data3,
    StrokeDashArray = doubleCollection
};

StackingLineSeries series4 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data4,
    StrokeDashArray = doubleCollection
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
chart.Series.Add(series3); 
chart.Series.Add(series4); 

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Dashed Stacked Line chart in MAUI](Chart-types-images/maui_dashed_stacked_line_chart.png)

## Enable Marker

A marker, also known as a symbol, is used to determine or highlight the position of the data point. To enable markers in the series, set the [ShowMarkers](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingLineSeries.html#Syncfusion_Maui_Charts_StackingLineSeries_ShowMarkers) property to `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
...
    <chart:SfCartesianChart.BindingContext>
        <local:ViewModel/>
    </chart:SfCartesianChart.BindingContext>
    ...
    <chart:StackingLineSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Month"
                                YBindingPath="Value"
                                ShowMarkers="True"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data2}"
                                XBindingPath="Month"
                                YBindingPath="Value"
                                ShowMarkers="True"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data3}"
                                XBindingPath="Month"
                                YBindingPath="Value"
                                ShowMarkers="True"/>

    <chart:StackingLineSeries ItemsSource="{Binding Data4}"
                                XBindingPath="Month"
                                YBindingPath="Value"
                                ShowMarkers="True"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

ViewModel viewModel = new ViewModel();
...
StackingLineSeries series1 = new  StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1,
    ShowMarkers= true,
};

StackingLineSeries series2 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data2,
    ShowMarkers= true,
};

StackingLineSeries series3 = new StackingLineSeries()       
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data3,
    ShowMarkers= true,
};

StackingLineSeries series4 = new StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data4,
    ShowMarkers= true, 
};

chart.Series.Add(series1);
chart.Series.Add(series2);     
chart.Series.Add(series3); 
chart.Series.Add(series4); 

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Stacked Line Marker support in MAUI Chart](Chart-types-images/stacked_line_marker_support.png)

### Marker customization

In order to change the series markers appearance, create an instance of the [MarkerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingLineSeries.html#Syncfusion_Maui_Charts_StackingLineSeries_MarkerSettings) property. The following properties are used to customize marker appearance.

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
    <chart:SfCartesianChart.BindingContext>
        <local:ViewModel/>
    </chart:SfCartesianChart.BindingContext>
    ...
    <chart:StackingLineSeries ItemsSource="{Binding Data1}"
                                XBindingPath="Month"
                                YBindingPath="Value"
                                ShowMarkers="True">
        <chart:StackingLineSeries.MarkerSettings>
            <chart:ChartMarkerSettings Type="Diamond" 
                                        StrokeWidth="2"
                                        Fill="White"
                                        Height="8"
                                        Width="8"/>
        </chart:StackingLineSeries.MarkerSettings>    
    </chart:StackingLineSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

ViewModel viewModel = new ViewModel();
...
ChartMarkerSettings chartMarker= new ChartMarkerSettings();
chartMarker.Type = ShapeType.Diamond;
chartMarker.Fill=Colors.White;
chartMarker.StrokeWidth= 2;
chartMarker.Height = 8;
chartMarker.Width = 8;

StackingLineSeries series = new  StackingLineSeries()
{
    XBindingPath = "Month",
    YBindingPath = "Value",
    ItemsSource = viewModel.Data1,
    ShowMarkers= true,
    MarkerSettings = chartMarker,
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}
