---
layout: post
title: Basic features in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Basic features  in .NET MAUI Range Selector (SfRangeSelector)

This section explains about how to add the numeric Range Selector.

## Minimum

The minimum value that the user can select. The default value of [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) property is 0.0 and it must be less than the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) value.

## Maximum

The maximum value that the user can select. The default value of [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) property is 1.0 and it must be greater than the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) value.

## Range values

It represents the values currently selected in the Range Selector. The Range Selector’s thumb is drawn corresponding to this [`RangeStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeStart) and [`RangeEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeEnd) values.

## Numeric Range Selector

You can show numeric values in the Range Selector by setting double values to the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum), [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum), [`RangeStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeStart), and [`RangeEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeEnd) properties.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:charts="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">

    <sliders:SfRangeSelector Minimum="10"
                             Maximum="20"
                             RangeStart="13"
                             RangeEnd="17"
                             ShowLabels="True">

        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>

    </sliders:SfRangeSelector>
</ContentPage>
 
{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Minimum = 10;
rangeSelector.Maximum = 20;
rangeSelector.RangeStart = 13;
rangeSelector.RangeEnd = 17;
rangeSelector.ShowLabels = true;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector numeric label](images/basic-features/rangeselector-basic.png)