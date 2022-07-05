---
layout: post
title: Basic features in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Basic features  in .NET MAUI Range Slider (SfRangeSlider)

This section explains how to add the numeric range slider.

## Minimum

The minimum value that the user can select. The default value of the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) property is 0 and it must be less than the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) value.

## Maximum

The maximum value that the user can select. The default value of the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Maximum) property is 1.5 and it must be greater than the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_Minimum) value.

## Range values

It represents the values currently selected in the range slider. The range slider’s thumb is drawn corresponding to this [`RangeStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeStart) and [`RangeEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.NumericRangeSliderBase.html#Syncfusion_Maui_Sliders_NumericRangeSliderBase_RangeEnd) values.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0"
                       Maximum="10"
                       RangeStart="3"
                       RangeEnd="7"
                       ShowLabels="True">
</sliders:SfRangeSlider>
 
{% endhighlight %}

{% highlight C# %}

 SfRangeSlider rangeSlider = new SfRangeSlider();
 rangeSlider.Minimum = "0";
 rangeSlider.Maximum = "10";
 rangeSlider.RangeStart = "3";
 rangeSlider.RangeEnd = "7";
 rangeSlider.ShowLabels = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider numeric label](images/basic-features/rangeslider-basic.png)

