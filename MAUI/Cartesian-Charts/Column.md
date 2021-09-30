---
layout: post
title: Column Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about column and bar chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Column Chart in .NET MAUI Chart (SfCartesianChart)

Column chart is used to plot discrete rectangles for the given data point values. To render a column chart, create an instance of [ColumnSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ColumnSeries.html?tabs=tabid-1), and add it to the [Series](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>   

    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue"/>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

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

## Spacing

The [Spacing](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.ColumnSeries.html#Syncfusion_Maui_Charts_ColumnSeries_Spacing) property is used to change the spacing between two segments. The default value of spacing is 0, and the value ranges from 0 to 1. Here, 1 and 0 correspond to 100% and 0% of the available space, respectively.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:CategoryAxis />
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>  

    <chart:SfCartesianChart.Series>
        <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue" Spacing="0.5"/>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

    ColumnSeries series = new ColumnSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "XValue",
        YBindingPath = "YValue",
        Spacing = 0.5
    };

    chart.Series.Add(series);
    this.Content = chart;

{% endhighlight %}

{% endtabs %}

