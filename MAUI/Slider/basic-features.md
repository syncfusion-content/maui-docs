---
layout: post
title: Basic features in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Basic features  in .NET MAUI Slider (SfSlider)

This section explains how to add the numeric slider.

## Minimum

The minimum value that the user can select. The default value of the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) property is `0` and it must be less than the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) value.

## Maximum

The maximum value that the user can select. The default value of the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) property is `1` and it must be greater than the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) value.

## Value

It represents the value currently selected in the slider. The slider's thumb is drawn corresponding to this value.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="20"
                  Maximum="60"
                  Value="40"
                  Interval="10"
                  ShowTicks="True"
                  ShowLabels="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 20,
    Maximum = 60,
    Value = 40,
    Interval = 10,
    ShowTicks = true,
    ShowLabels = true,
};

{% endhighlight %}

{% endtabs %}

![Slider numeric label](images/basic-features/numeric-labels.png)

