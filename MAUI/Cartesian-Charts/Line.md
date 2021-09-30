---
layout: post
title: Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the line chart and its type in Syncfusion .NET MAUI Chart (SfCartesianChart) control. 
platform: maui
control: SfCartesianChart
documentation: ug
---

# Line Chart in .NET MAUI Chart (SfCartesianChart)

## Line Chart

Line chart is used to represent the data trends at equal intervals by connecting points on a plot with straight lines. To render a line chart, create an instance of [LineSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.LineSeries.html?tabs=tabid-1), and add it to the [Series](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1).

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
        <chart:LineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2010"/>
        <chart:LineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2011"/>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

LineSeries series1 = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
};

LineSeries series2 = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2011",

};

chart.Series.Add(series1);
chart.Series.Add(series2);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Dashed line

The [StrokeDashArray](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.LineSeries.html#Syncfusion_Maui_Charts_LineSeries_StrokeDashArray) property of [LineSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.LineSeries.html?tabs=tabid-1) is used to render the line series with dashes. Odd value is considered as rendering size and even value is considered as gap.

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
        <chart:LineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2010" StrokeDashArray="5,2"/>
        <chart:LineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2011" StrokeDashArray="5,2"/>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(5);
doubleCollection.Add(2);
. . .
LineSeries series1 = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
    StrokeDashArray = doubleCollection

};

LineSeries series2 = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2011",
    StrokeDashArray = doubleCollection
};

chart.Series.Add(series1);
chart.Series.Add(series2);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

## Spline Chart 

The [SplineSeries](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SplineSeries.html?tabs=tabid-1) resembles line series, but instead of connecting the data points with line segments, the data points are connected by smooth bezier curves.

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
        <chart:SplineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2010"/>
        <chart:SplineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2011"/>
    </chart:SfCartesianChart.Series>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

SplineSeries series1 = new SplineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2010",
};

SplineSeries series2 = new SplineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Demand",
    YBindingPath = "Year2011",
};

chart.Series.Add(series1);
chart.Series.Add(series2);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Spline rendering types

The [Type](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SplineSeries.html#Syncfusion_Maui_Charts_SplineSeries_Type) allows you to change the spline curve in series. By default, the value of [Type](https://npmci.syncfusion.com/maui/api/development/maui-charts/api/Syncfusion.Maui.Charts.SplineSeries.html#Syncfusion_Maui_Charts_SplineSeries_Type) is `Natural`.

The following types are used in SplineSeries:

* `Natural`
* `Monotonic`
* `Cardinal`
* `Clamped`

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
            <chart:SplineSeries XBindingPath="Demand" ItemsSource="{Binding Data}" YBindingPath="Year2010" Type="Cardinal"/>
        </chart:SfCartesianChart.Series>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

    SfCartesianChart chart = new SfCartesianChart();
    CategoryAxis primaryAxis = new CategoryAxis();
    chart.PrimaryAxis = primaryAxis;
    NumericalAxis secondaryAxis = new NumericalAxis();
    chart.SecondaryAxis = secondaryAxis;

    SplineSeries series = new SplineSeries()
    {
        ItemsSource = new ViewModel().Data,
        XBindingPath = "Demand",
        YBindingPath = "Year2010",
        Type = SplineType.Cardinal
    };

    chart.Series.Add(series);

    this.Content = chart;

{% endhighlight %}

{% endtabs %}

