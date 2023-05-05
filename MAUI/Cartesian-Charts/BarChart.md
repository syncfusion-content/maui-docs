---
layout: post
title: Bar Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about bar chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Bar Chart in .NET MAUI Chart

A bar chart uses bars to represent data points and compare values across different categories. To render bar chart, initialize the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) and switch the chart X and Y axes by using the [IsTransposed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_IsTransposedProperty) property as true. Then, create the column chart. To render a column chart, create an instance of [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

N> By default, [IsTransposed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_IsTransposedProperty) property of the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1) is false.

N> The cartesian chart has Series as its default content.

{% tabs %}

{% highlight xaml %}

  <chart:SfCartesianChart  x:Name="chart" IsTransposed="True">

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>   

    <chart:ColumnSeries ItemsSource="{Binding Data}"
						XBindingPath="XValue"
						YBindingPath="YValue"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
chart.IsTransposed = true;
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Bar chart type in MAUI Chart](Chart-Types_images/maui_bar_chart.png)

## Spacing and Width

The [Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html#Syncfusion_Maui_Charts_ColumnSeries_Spacing) property of the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1) is used to change the spacing between two segments. The default value of spacing is 0, and the value ranges from 0 to 1. Here, 1 and 0 correspond to 100% and 0% of the available space, respectively. 

The [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html#Syncfusion_Maui_Charts_ColumnSeries_Width) property of the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1) is used to change the width of the rectangle. The default value of the width is 0.8, and the value ranges from 0 to 1.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart x:Name="chart" IsTransposed="True">

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.YAxes>  

    <chart:ColumnSeries ItemsSource="{Binding Data}"
						XBindingPath="XValue"
						YBindingPath="YValue"
						Spacing="0.3"
						Width="0.5"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
chart.IsTransposed = true;
CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);
NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    Spacing = 0.3,
    Width = 0.5
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Bar segment spacing in MAUI Chart](Chart-Types_images/maui_bar_chart_with_segment_spacing.png)
