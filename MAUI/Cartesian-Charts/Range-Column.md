---
layout: post
title: Range Column Chart in .NET MAUI Chart control | Syncfusion®
description: Learn here all about range column and range bar chart support in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui range column chart, maui range column chart, range column chart customization .net maui, syncfusion maui range column chart, cartesian range column chart maui, .net maui chart range column visualization, .net maui interval column chart.
---

# Range Column Chart in .NET MAUI Chart

## Range Column Chart

Range Column Chart is used to visualize data points with columns, with the height of each column representing the difference between the lowest and highest values of the data point. 

To render a range column chart, create an instance of [RangeColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeColumnSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

Since the [RangeColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeColumnSeries.html) requires two Y values for each point, your data should contain both the high and low values. These high and low values specify the maximum and minimum ranges of the point.

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>   

    <chart:RangeColumnSeries ItemsSource="{Binding Data}"
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

RangeColumnSeries series = new RangeColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    High = "HighValue",
    Low = "LowValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Range column chart type in MAUI Chart](Chart-Types-images/maui_range_column.png)

## Spacing and Width

The [Spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeColumnSeries.html#Syncfusion_Maui_Charts_RangeColumnSeries_Spacing) property is used to change the spacing between two segments. The default value of spacing is 0, and the value ranges from 0 to 1. Here, 1 and 0 correspond to 100% and 0% of the available space, respectively. 

The [Width](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeColumnSeries.html#Syncfusion_Maui_Charts_RangeColumnSeries_Width) property is used to change the width of the segment. The default value of the width is 0.8, and the value ranges from 0 to 1.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>  
    
    <chart:RangeColumnSeries ItemsSource="{Binding Data}"
                             XBindingPath="XValue"
                             High="HighValue"
                             Low="LowValue"
                             Spacing="0.3"
                             Width="0.7"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

RangeColumnSeries series = new RangeColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    High = "HighValue",
    Low = "LowValue",
    Spacing = 0.3,
    Width = 0.7,
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Range column segment spacing in MAUI Chart](Chart-Types-images/maui_rangeColumn_space_width.png)
