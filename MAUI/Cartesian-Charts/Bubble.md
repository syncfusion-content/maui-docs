---
layout: post
title: Bubble chart in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about the bubble chart and its features in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui bubble chart, maui bubble chart, bubble chart customization .net maui, syncfusion maui bubble chart, cartesian bubble chart maui, .net maui chart bubble visualization.
---

# Bubble Chart in .NET MAUI Cartesian Chart

## Bubble Chart

The bubble chart is represented by closely packed circles, whose areas are proportional to the data values they represent. The bubble chart is similar to a [scatter plot](https://help.syncfusion.com/maui/cartesian-charts/scatter), but with the additional dimension of bubble size to represent a third variable. 

To render a bubble chart, create an instance of [BubbleSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html) and add it to the [Series](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series) collection property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html). The data model must include `XValue`, `YValue`, and `Size` properties; the bubble size is proportional to the value bound via the [SizeValuePath](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_SizeValuePath) property. You can constrain the bubble size using the [MinimumRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_MinimumRadius) (default `3`) and [MaximumRadius](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_MaximumRadius) (default `10`) properties. The following code shows how to configure these properties. 

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.

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

![Bubble chart type in .NET MAUI Cartesian Chart](Chart-types-images/BubbleBasisImage.png)

## Show zero size bubbles

When the `Size` value of a data point is 0 or null, the bubble is referred to as a zero-size bubble. The zero-size bubble segments can be enabled or disabled using the [ShowZeroSizeBubbles](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.BubbleSeries.html#Syncfusion_Maui_Charts_BubbleSeries_ShowZeroSizeBubbles) property. By default, the property value is `True`. The following code shows how to disable zero-size bubbles.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart>
    <!-- code omitted for brevity -->
    <chart:BubbleSeries ItemsSource="{Binding Data}"
                        XBindingPath="XValue"
                        YBindingPath="YValue"
                        SizeValuePath="Size"
                        ShowZeroSizeBubbles="False"/>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
// code omitted for brevity

BubbleSeries bubbleSeries = new BubbleSeries() 
{ 
    ItemsSource = new ViewModel().Data,
    XBindingPath = "XValue",
    YBindingPath = "YValue",
    SizeValuePath = "Size",
    ShowZeroSizeBubbles = false,
};

chart.Series.Add(bubbleSeries);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Show zero size bubbles in .NET MAUI Cartesian Chart](Chart-types-images/ShowZeroSizeBubble.png)