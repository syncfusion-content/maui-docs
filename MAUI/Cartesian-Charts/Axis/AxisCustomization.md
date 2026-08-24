---
layout: post
title: Common Axis Features in .NET MAUI Cartesian Chart | Syncfusion®
description: Common axis features in Syncfusion .NET MAUI Cartesian Chart support axis inversion, visibility, crossing, multiple axes, and axis events.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui common axis features, common axis features in maui chart, .net maui cartesian chart axis features, syncfusion maui chart axis features, maui chart multiple axes, maui chart axis crossing, sfcartesianchart axis events, .net maui axis visibility
---

# Common Axis Features in .NET MAUI Cartesian Chart

## Inverse axis

An axis can be inverted by using the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsInversed) property. The default value of this property is `false`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis IsInversed="True"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.IsInversed = true;
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Inversed axis support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_isInversed.jpg)

## Axis visibility

Axis visibility can be controlled using the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsVisible) property of the axis. The default value of the [IsVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsVisible) property is `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis IsVisible="False"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis secondaryAxis = new NumericalAxis() 
{
	IsVisible = false 
};
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Multiple axes

Cartesian charts provide support to arrange multiple series inside the same chart area with a specified X-axis and Y-axis. There are two properties, [XAxisName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_XAxisName) and [YAxisName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_YAxisName), in all the Cartesian series types, which are used to provide multiple axes support. These axes can be arranged in a stacking order or in a side-by-side pattern.

By default, the 0th index value of XAxes and YAxes is used to plot all the series.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sys="clr-namespace:System;assembly=mscorlib"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <chart:SfCartesianChart>
        <chart:SfCartesianChart.XAxes>
            <chart:DateTimeAxis ShowMajorGridLines="False"/>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis ShowMajorGridLines="False"/>
            <chart:NumericalAxis Name="series_YAxis" CrossesAt="{x:Static Member=sys:Double.MaxValue}" ShowMajorGridLines="False"/>
        </chart:SfCartesianChart.YAxes>

        <chart:ColumnSeries ItemsSource="{Binding Demands}" 
                            XBindingPath="Demand"
                            YBindingPath="Year2011" 
                            YAxisName="series_YAxis"/>
        <chart:SplineSeries ItemsSource="{Binding Demands}" 
                            XBindingPath="Date"
                            YBindingPath="Year2011"/>
    </chart:SfCartesianChart>
</ContentPage>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis()
{
    ShowMajorGridLines = false
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis()
{
    CrossesAt = double.MaxValue,
    ShowMajorGridLines = false
};
secondaryAxis.Name = "series_YAxis";
chart.YAxes.Add(secondaryAxis);

NumericalAxis secondaryAxis1 = new NumericalAxis();
chart.YAxes.Add(secondaryAxis1);

ColumnSeries series1 = new ColumnSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Demand",
    YBindingPath = "Year2011",
    YAxisName = "series_YAxis"
};

SplineSeries series2 = new SplineSeries()
{
    ItemsSource = new ViewModel().Demands,
    XBindingPath = "Date",
    YBindingPath = "Year2011"
};

chart.Series.Add(series1);
chart.Series.Add(series2);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Multiple axes support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_multiple_axes.png)

In the above image, the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html) is plotted based on additional axes of [YAxes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes) collection, and [SplineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SplineSeries.html) is plotted based on axis of the collection's 0th index.

## Axis crossing

The chart allows you to customize the origin; by default, the axis will be rendered with (0,0) as the origin in the X and Y axes. An axis can be positioned anywhere in the chart area by using the [CrossesAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt) property. This property specifies where the horizontal axis crosses the vertical axis, and vice versa. The default value of the CrossesAt property is `double.NaN`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis CrossesAt="0"
                             Minimum="-8"
                             Maximum="8"
                             ShowMajorGridLines="False"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis CrossesAt="0"
                             Minimum="-8"
                             Maximum="8"
                             ShowMajorGridLines="False"/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.CrossesAt = 0;
primaryAxis.Minimum = -8;
primaryAxis.Maximum = 8;
primaryAxis.ShowMajorGridLines = false;
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = 0;
secondaryAxis.Minimum = -8;
secondaryAxis.Maximum = 8;
secondaryAxis.ShowMajorGridLines = false;
chart.YAxes.Add(secondaryAxis);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis crossing support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_crossing.png)

### Positioning the axis elements while crossing

The [RenderNextToCrossingValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_RenderNextToCrossingValue) property is used to determine whether the crossing axis should be placed at the crossing position or not. The default value of the [RenderNextToCrossingValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_RenderNextToCrossingValue) property is `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis CrossesAt="0" RenderNextToCrossingValue="False"/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis CrossesAt="0"/>
    </chart:SfCartesianChart.YAxes>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.CrossesAt = 0;
primaryAxis.RenderNextToCrossingValue = false;
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = 0;
chart.YAxes.Add(secondaryAxis);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![RenderNextToCrossingValue support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_rendernexttocrossingvalue.png)

### Crossing the date-time axis

For crossing on a date-time horizontal axis, a `DateTime` object should be provided as the value for the `CrossesAt` property of the vertical axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis CrossesAt="2021-01-01"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = new DateTime(2021, 01, 01);
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![DateTimeAxis crossing support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_datetime_axis_crossing.png)

### Opposite side axis with CrossesAt

The chart allows you to position the axis to the opposite position by setting the value as `double.MaxValue` for the [CrossesAt](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis CrossesAt="{x:Static sys:Double.MaxValue}"/>
    </chart:SfCartesianChart.YAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
secondaryAxis.CrossesAt = double.MaxValue;
chart.YAxes.Add(secondaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis opposite position in .NET MAUI Cartesian Chart](Axis_images/maui_chart_axis_opposite_position.png)

## Events

### ActualRangeChanged

The [ActualRangeChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ActualRangeChanged) event is triggered when the actual range of the axis is changed. The [ActualRangeChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html) contains the following information:

* [ActualMinimum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_ActualMinimum) - used to get the actual minimum value of the axis.
* [ActualMaximum](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html#Syncfusion_Maui_Charts_ActualRangeChangedEventArgs_ActualMaximum) - used to get the actual maximum value of the axis.

N> The actual range is changed by specifying the [ZoomPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomPosition) and [ZoomFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomFactor) properties or zooming the chart interactively.

{% tabs %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.ActualRangeChanged += PrimaryAxis_ActualRangeChanged;
chart.XAxes.Add(primaryAxis);

private void PrimaryAxis_ActualRangeChanged(object sender, ActualRangeChangedEventArgs e)
{
    double minimum = (double)e.ActualMinimum;
    double maximum = (double)e.ActualMaximum;
}

{% endhighlight %}

{% endtabs %}

### LabelCreated

The [LabelCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelCreated) event is triggered when the axis label is created. The [ChartAxisLabelEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html) contains the following information:

* [Label](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_Label) - used to get or set the text of the axis label.
* [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_Position) - used to get the position of the label.
* [LabelStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html#Syncfusion_Maui_Charts_ChartAxisLabelEventArgs_LabelStyle) - used to customize the appearance of axis labels.

{% tabs %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
NumericalAxis primaryAxis = new NumericalAxis();
primaryAxis.LabelCreated += PrimaryAxis_LabelCreated;
chart.XAxes.Add(primaryAxis);

private void PrimaryAxis_LabelCreated(object sender, ChartAxisLabelEventArgs e)
{
    string label = e.Label;
    double position = e.Position;
}

{% endhighlight %}

{% endtabs %}
