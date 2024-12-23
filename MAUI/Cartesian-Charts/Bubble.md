---
layout: post
title: Bubble chart in .NET MAUI Chart control | Syncfusion
description: Learn here all about the bubble chart and its features in Syncfusion .NET MAUI Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui bubble chart, maui bubble chart, bubble chart customization .net maui, syncfusion maui bubble chart, cartesian bubble chart maui, .net maui chart bubble visualization.
---

# Bubble Chart in .NET MAUI Chart

## Bubble Chart

The bubble chart is represented by closely packed circles, whose areas are proportional to the quantities.

To render a bubble chart, create an instance of [BubbleSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html), and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). The bubble chart is similar to a scatter plot, but with the additional dimension of bubble size to represent the third variable. 

The size of the [BubbleSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html) is relatively proportional to the value bound with the series using the [SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_SizeValuePath) property. You can set the constraints on this size using the [MinimumRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_MinimumRadius) and [MaximumRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_MaximumRadius). The following code illustrates how to set the value to the property. 

N> The Cartesian chart has [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) as its default content.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis/>
    </chart:SfCartesianChart.YAxes>  
                
    <chart:BubbleSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        YBindingPath="YValue"
                        SizeValuePath="Size"/>

</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

NumericalAxis primaryAxis = new NumericalAxis();
chart.XAxes.Add(primaryAxis);

NumericalAxis secondaryAxis = new NumericalAxis();
chart.YAxes.Add(secondaryAxis);

BubbleSeries series = new BubbleSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    SizeValuePath = "Size",
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Bubble chart type in MAUI Chart](Chart-Types-images/BubbleBasisImage.png)

## Show zero size bubbles
The zero size bubble segments can be enabled or disabled using the [ShowZeroSizeBubbles](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_ShowZeroSizeBubbles) property. By default, the property value is `True`. The following code illustrates how to set the value to the property.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    . . .
    <chart:BubbleSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        YBindingPath="YValue"
                        SizeValuePath="Size"
                        ShowZeroSizeBubbles="False"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
...

BubbleSeries bubbleSeries = new BubbleSeries() 
{ 
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    SizeValuePath = "Size",
    ShowZeroSizeBubbles = false;
};

chart.Series.Add(bubbleSeries);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![ShowZeroSize bubble  type in MAUI Chart](Chart-Types-images/ShowZeroSizeBubble.png)