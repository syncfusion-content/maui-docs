---
layout: post
title: Fast Line Chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the fast line chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Fast Line Chart in .NET MAUI Chart

## Fast Line Chart

The [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html?tabs=tabid-1) is a special kind of line series that can render a collection with large number of datapoints. To render a fast line chart, create an instance of [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html?tabs=tabid-1), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1). 

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.PrimaryAxis>
        <chart:DateTimeAxis />
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>  
                
    <chart:SfCartesianChart.Series>
        <chart:FastLineSeries ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue"/>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

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

![FastLine chart type in MAUI Chart](Chart-types_images/maui_fastline_chart.png)

### Dashed line

The [StrokeDashArray](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html#Syncfusion_Maui_Charts_FastLineSeries_StrokeDashArray) property of [FastLineSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FastLineSeries.html?tabs=tabid-1) is used to render the line with dashes. The odd value is considered as the rendering size, while the even value is considered as the gap.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <chart:SfCartesianChart.Resources>
        <DoubleCollection x:Key="dashArray">
            <x:Double>5</x:Double>
            <x:Double>2</x:Double>
        </DoubleCollection>
    </chart:SfCartesianChart.Resources>

    <chart:SfCartesianChart.PrimaryAxis>
        <chart:chart:DateTimeAxis />
    </chart:SfCartesianChart.PrimaryAxis>

    <chart:SfCartesianChart.SecondaryAxis>
        <chart:NumericalAxis />
    </chart:SfCartesianChart.SecondaryAxis>  

    <chart:SfCartesianChart.Series>
        <chart:FastLineSeries ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue" StrokeDashArray="{StaticResource dashArray}"/>
    </chart:SfCartesianChart.Series>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
DateTimeAxis primaryAxis = new DateTimeAxis();
chart.PrimaryAxis = primaryAxis;
NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

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

![Dashed fast line chart in MAUI](Chart-types_images/maui_dashed_fastline_chart.png)

### Anti-aliasing

There may be some jagged lines at the edges. This can be reduced by using the `EnableAntiAliasing` property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    .....

    <chart:SfCartesianChart.Series>
        <chart:FastLineSeries EnableAntiAliasing="True" ItemsSource="{Binding Data}" XBindingPath="XValue" YBindingPath="YValue"/>
    </chart:SfCartesianChart.Series>
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