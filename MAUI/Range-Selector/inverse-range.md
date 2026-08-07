---
layout: post
title: Inverse Range in .NET MAUI Range Selector | Syncfusion®
description: Learn how to invert the Syncfusion® .NET MAUI Range Selector control to reverse the visual range direction.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Inverse Range in .NET MAUI Range Selector

Invert the Range Selector using the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property. The default value of the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property is `False`.

{% tabs %}

{% highlight xaml %}

<ContentPage xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <sliders:SfRangeSelector Minimum="0" 
                             Maximum="10" 
                             RangeStart="2" 
                             RangeEnd="8"
                             Interval="2"
                             ShowLabels="True"
                             ShowTicks="True" 
                             MinorTicksPerInterval="1" 
                             IsInversed="True">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Minimum = 0;
rangeSelector.Maximum = 10;
rangeSelector.RangeStart = 2;
rangeSelector.RangeEnd = 8;
rangeSelector.Interval = 2;
rangeSelector.ShowLabels = true;
rangeSelector.ShowTicks = true;
rangeSelector.MinorTicksPerInterval = 1;
rangeSelector.IsInversed = true;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![Inverse rangeselector](images/getting-started/slider-inverse.png)