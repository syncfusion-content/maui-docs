---
layout: post
title: Axis grid lines in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about the chart axis grid lines and its customization in syncfusion® .NET MAUI Cartesian Chart(SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart grid lines, .net maui cartesian chart grid customization, syncfusion maui cartesian chart grid lines, cartesian chart grid lines maui, .net maui cartesian chart axis grid lines, customize grid lines .net maui cartesian chart.
---

# Grid Lines in .NET MAUI Cartesian Chart

## Major Grid Lines

By default, major gridlines are automatically added to the [ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) in its defined intervals. The visibility of the major gridlines can be controlled using the [ShowMajorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ShowMajorGridLines) property. The default value of [ShowMajorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ShowMajorGridLines) is `true`.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.


{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis ShowMajorGridLines="False"/>
    </chart:SfCartesianChart.XAxes>
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.ShowMajorGridLines = false;
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Hiding major gridlines in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_show_major_gridline.jpg)

### Customization

The [MajorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorGridLineStyle) property in the chart axis is used to customize the appearance of major gridlines.

{% tabs %}

{% highlight xaml %}
<chart:SfCartesianChart>
    <chart:SfCartesianChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>3</x:Double>
            <x:Double>3</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resources>
    
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis>
            <chart:NumericalAxis.MajorGridLineStyle>
                <chart:ChartLineStyle StrokeDashArray="{StaticResource dashArray}"
                                      Stroke="Black"
                                      StrokeWidth="2"/>
            </chart:NumericalAxis.MajorGridLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(3);

NumericalAxis primaryAxis = new NumericalAxis();
ChartLineStyle gridLineStyle = new ChartLineStyle()
{
    Stroke = new SolidColorBrush(Colors.Black),
    StrokeWidth = 2,
    StrokeDashArray = doubleCollection,
};
primaryAxis.MajorGridLineStyle = gridLineStyle;
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Major gridline style customization in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_major_linestyle.jpg)

## Minor Grid Lines

Minor gridlines are added automatically when minor ticks are enabled by setting the [MinorTicksPerInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTicksPerInterval) property of the chart axis (available on axes derived from [RangeAxisBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html)). The visibility of the minor gridlines can be controlled using the [ShowMinorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_ShowMinorGridLines) property. The default value of [ShowMinorGridLines](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_ShowMinorGridLines) is `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis MinorTicksPerInterval="3"
                             ShowMinorGridLines="True"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    MinorTicksPerInterval = 3,
    ShowMinorGridLines = true,
};
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Customization

The [MinorGridLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorGridLineStyle) property in the chart axis is used to customize the appearance of minor gridlines.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>3</x:Double>
            <x:Double>3</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis ShowMinorGridLines="True" MinorTicksPerInterval="3">
            <chart:NumericalAxis.MinorGridLineStyle>
                <chart:ChartLineStyle StrokeDashArray="{StaticResource dashArray}"
                                      Stroke="Black"
                                      StrokeWidth="0.8"/>
            </chart:NumericalAxis.MinorGridLineStyle>
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(3);
doubleCollection.Add(3);

NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis() { MinorTicksPerInterval = 3 };
ChartLineStyle gridLineStyle = new ChartLineStyle()
{
    Stroke = new SolidColorBrush(Colors.Black),
    StrokeWidth = 0.8,
    StrokeDashArray = doubleCollection,
};
secondaryAxis.MinorGridLineStyle = gridLineStyle;
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Minor gridline style customization in .NET MAUI Cartesian Chart.](Axis_images/maui_chart_axis_minor_grid_linestyle.jpg)
