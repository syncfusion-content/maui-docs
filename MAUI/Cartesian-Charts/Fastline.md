---
layout: post
title: Fast Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the fast line chart and its features in Syncfusion® .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
Keywords: .net maui fast line chart, .net maui performance line chart, fast line chart customization .net maui, syncfusion maui fast line chart, cartesian fast line chart maui, cartesian performance line chart maui, .net maui chart fast line visualization.
---

# Fast Line Chart in .NET MAUI Chart

## Fast Line Chart

The [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html) is a special kind of line series that can render a collection with large number of datapoints. To render a fast line chart, create an instance of [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). 

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.XAxes>
        <chart:DateTimeAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>  
                
    <chart:FastLineSeries ItemsSource="{Binding Data}"
                          XBindingPath="XValue"
                          YBindingPath="YValue"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

FastLineSeries series = new FastLineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![FastLine chart type in MAUI Chart](Chart-types-images/maui_fastline_chart.png)

### Dashed line

The [StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html#Syncfusion_Maui_Charts_FastLineSeries_StrokeDashArray) property of [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html) is used to render the line with dashes. The odd value is considered as the rendering size, while the even value is considered as the gap.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>5</x:Double>
            <x:Double>2</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.XAxes>
        <chart:chart:DateTimeAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>  

    <chart:FastLineSeries ItemsSource="{Binding Data}"
                          XBindingPath="XValue"
                          YBindingPath="YValue" 
                          StrokeDashArray="{StaticResource dashArray}"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

DateTimeAxis primaryAxis = new DateTimeAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

DoubleCollection doubleCollection = new DoubleCollection();
doubleCollection.Add(5);
doubleCollection.Add(2);
. . .
FastLineSeries series = new FastLineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    StrokeDashArray = doubleCollection

};

chart.Series.Add(series);

this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Dashed fast line chart in MAUI](Chart-types-images/maui_dashed_fastline_chart.png)

### Anti-aliasing

There may be some jagged lines at the edges. This can be reduced by using the [EnableAntiAliasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html#Syncfusion_Maui_Charts_FastLineSeries_EnableAntiAliasing) property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    ...
    <chart:FastLineSeries ItemsSource="{Binding Data}"
                          XBindingPath="XValue"
                          YBindingPath="YValue"
                          EnableAntiAliasing="True"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
. . .
FastLineSeries series = new FastLineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    EnableAntiAliasing = true
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}