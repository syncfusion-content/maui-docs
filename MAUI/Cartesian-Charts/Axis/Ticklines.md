---
layout: post
title: Axis tick lines in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about chart axis tick line and its customization in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart tick lines, .net maui cartesian chart tick customization, .net maui cartesian chart tickline guide, syncfusion maui cartesian chart tick lines, cartesian chart tick lines maui, .net maui cartesian chart axis tick lines, customize tick lines .net maui cartesian chart.
---

# Tick Lines in .NET MAUI Cartesian Chart

Tick lines are the small lines which are drawn on the axis line representing the axis labels. Tick lines will be drawn outside of the axis by default.

Minor tick lines can also be added to the axis by defining the [MinorTicksPerInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTicksPerInterval) property, of type `int` with a default value of `0`. This property is available on axes derived from [RangeAxisBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html) and will add the minor tick lines to every interval based on the value.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

N> For the category axis, minor tick lines are not applicable because it is rendered based on index positions.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis MinorTicksPerInterval="4"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis()
{
    MinorTicksPerInterval = 4
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Positioning the ticks

The tick lines can be positioned inside or outside the chart area using the [TickPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_TickPosition) property, of type [AxisElementPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisElementPosition.html), with the following values:

* `Outside` - Draws the tick lines outside the chart area.
* `Inside` - Draws the tick lines inside the chart area.

The default value of the [TickPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_TickPosition) property is `AxisElementPosition.Outside`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis TickPosition="Inside"/>
    </chart:SfCartesianChart.YAxes>
    <!-- code omitted for brevity -->
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
NumericalAxis secondaryAxis = new NumericalAxis()
{
    TickPosition = AxisElementPosition.Inside
};

chart.XAxes.Add(primaryAxis);
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis ticks inside position in .NET MAUI Cartesian Chart](Axis_images/maui_chart_inside_ticks.png)

## Customization

Both major and minor tick lines can be customized by using the [MajorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorTickStyle) and [MinorTickStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTickStyle) properties respectively. They provide options to change the [StrokeWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTickStyle.html#Syncfusion_Maui_Charts_ChartAxisTickStyle_StrokeWidth), [TickSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTickStyle.html#Syncfusion_Maui_Charts_ChartAxisTickStyle_TickSize), and [Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTickStyle.html#Syncfusion_Maui_Charts_ChartAxisTickStyle_Stroke) of tick lines. By default, minor tick lines will not be visible; the [MinorTicksPerInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_MinorTicksPerInterval) property must be set to a value greater than zero before the minor tick style is applied.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis MinorTicksPerInterval="4">
            <chart:NumericalAxis.MajorTickStyle>
                <chart:ChartAxisTickStyle Stroke="Red"
                                          StrokeWidth="1"
                                          TickSize="10"/>
            </chart:NumericalAxis.MajorTickStyle>

            <chart:NumericalAxis.MinorTickStyle>
                <chart:ChartAxisTickStyle Stroke="Red" StrokeWidth="1"/>
            </chart:NumericalAxis.MinorTickStyle>
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

NumericalAxis numerical = new NumericalAxis();
numerical.MinorTicksPerInterval = 4;

numerical.MajorTickStyle = new ChartAxisTickStyle()
{
    StrokeWidth = 1,
    Stroke = new SolidColorBrush(Colors.Red),
    TickSize = 10,
};

numerical.MinorTickStyle = new ChartAxisTickStyle()
{
    StrokeWidth = 1,
    Stroke = new SolidColorBrush(Colors.Red),
};

chart.XAxes.Add(numerical);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);
// code omitted for brevity
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis tick lines customization support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_tickline_customization.jpg)
