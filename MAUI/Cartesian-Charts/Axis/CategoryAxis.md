---
layout: post
title: Category Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: Category Axis in Syncfusion .NET MAUI Cartesian Chart displays discrete data categories with support for labels, positioning, sorting, and customization.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian charts, .net maui category axis, category axis in maui chart, .net maui cartesian chart category axis, syncfusion maui chart category axis, maui chart categorical axis, cartesian chart category labels maui, sfcartesianchart category axis, .net maui chart category data.
---

# Category Axis in .NET MAUI Cartesian Chart

The [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) is an index-based axis that plots values based on the index of the data point collection. Data points are equally spaced.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![CategoryAxis support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_category_axis.jpg)

To customize the [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) in .NET MAUI Cartesian Charts, you can check the below video.

{% youtube "https://www.youtube.com/watch?v=D_8MHoglBVI" %}

## Label placement

The [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_LabelPlacement) property in [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) is used to place axis labels either on ticks or between ticks. The default value of [LabelPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_LabelPlacement) is [OnTicks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelPlacement.html#Syncfusion_Maui_Charts_LabelPlacement_OnTicks).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis LabelPlacement="BetweenTicks"/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis()
{
    LabelPlacement = LabelPlacement.BetweenTicks
};
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Axis label placement support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_category_axis_labelPlacement.jpg)

## Interval

By default, the [CategoryAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html) labels are displayed at a fixed interval of 1. This can be customized by using the [Interval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval) property of the axis.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis Interval="2"/>
    </chart:SfCartesianChart.XAxes>

    <!-- code omitted for brevity -->

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis()
{
    Interval = 2
};
chart.XAxes.Add(primaryAxis);

// code omitted for brevity

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![CategoryAxis interval support in .NET MAUI Cartesian Chart](Axis_images/maui_chart_category_axis_interval.jpg)

## Indexed category axis

In Cartesian Charts, the [ArrangeByIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_ArrangeByIndex) property is used to determine how the items in a category axis are arranged.

When [ArrangeByIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_ArrangeByIndex) is set to `true`, the items in the category axis will be arranged according to their index values. Conversely, when set to `false`, the items will be arranged according to their values. By default, [ArrangeByIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_ArrangeByIndex) is `true`.

The following code illustrates how to define the property [ArrangeByIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_ArrangeByIndex) in chart.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis ArrangeByIndex="False"/>
    </chart:SfCartesianChart.XAxes>
    
    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>

    <chart:ColumnSeries ItemsSource="{Binding Data1}"
                        XBindingPath="Year"
                        YBindingPath="Value"/>

    <chart:ColumnSeries ItemsSource="{Binding Data2}"
                        XBindingPath="Year"
                        YBindingPath="Value"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis()
{
    ArrangeByIndex = false, 
};
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);  

ColumnSeries series1 = new ColumnSeries();
series1.ItemsSource = new ViewModel().Data1; 
series1.XBindingPath = "Year";
series1.YBindingPath = "Value";

ColumnSeries series2 = new ColumnSeries();
series2.ItemsSource = new ViewModel().Data2;  
series2.XBindingPath = "Year";
series2.YBindingPath = "Value";

chart.Series.Add(series1);
chart.Series.Add(series2);  

this.Content = chart;

{% endhighlight %}

{% endtabs %}    

![CategoryAxis ArrangeByIndex support in .NET MAUI Cartesian Chart](Axis_images/ArrangeByIndex.png)