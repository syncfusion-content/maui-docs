---
layout: post
title: Spline Range Area Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about Spline Range Area chart support in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui spline range area chart, maui spline range area chart, spline range area chart customization .net maui, syncfusion maui spline range area chart, cartesian spline range area chart maui, .net maui chart spline range area visualization.
---

# Spline Range Area Chart in .NET MAUI Chart

## Spline Range Area Chart

Spline Range Area Chart is used to visualize data points with smooth curves. In this series, the area between the curves is filled to indicate a range of values, such as a high and low price range or an upper and lower limit.

To render a spline range area chart, create an instance of [SplineRangeAreaSeries]() and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html).

Since the [SplineRangeAreaSeries]() requires two Y values for each point, your data should contain both the high and low values. These high and low values specify the maximum and minimum ranges of the point.

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

    <chart:SplineRangeAreaSeries ItemsSource="{Binding Data}"
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

SplineRangeAreaSeries series = new SplineRangeAreaSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    High="HighValue",
    Low="LowValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Spline rendering types

The [Type]() property allows to change the rendering type of spline curve in series. The default value of [Type]() is [Natural](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SplineType.html#Syncfusion_Maui_Charts_SplineType_Natural).

The following types are used in [SplineRangeAreaSeries]():

* `Natural`
* `Monotonic`
* `Cardinal`
* `Clamped`

{% tabs %}

{% highlight xaml %}

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis/>
        </chart:SfCartesianChart.XAxes>

        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis/>
        </chart:SfCartesianChart.YAxes>  

        <chart:SplineRangeAreaSeries ItemsSource="{Binding Data}"
                                     XBindingPath="XValue"
                                     High="HighValue"
                                     Low="LowValue"
                                     Type="Cardinal"/>

    </chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

CategoryAxis primaryAxis = new CategoryAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

SplineRangeAreaSeries series = new SplineRangeAreaSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    High="HighValue",
    Low="LowValue",
    Type = SplineType.Cardinal
};

chart.Series.Add(series);

this.Content = chart;

{% endhighlight %}

{% endtabs %}