---
layout: post
title: Interval in.NET MAUI Slider control | Syncfusion 
description: Learn here all about adding the Interval feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Interval in .NET MAUI Slider (SfSlider)

This section explains how to add the interval for numeric slider.

## Numeric interval

Slider elements like labels, ticks and dividers are rendered based on the [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Interval), [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimum) and [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) properties. The default value is `0`.

For example, if the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Minimu) is 0.0, the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_Maximum) is 10.0, and [`Interval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Interval) is 2.0, the slider will render the labels, major ticks, and dividers at 0.0, 2.0, 4.0, and so on.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="0"
                  Maximum="10"
                  Interval="2"
                  Value="5"
                  ShowLabels="True"
                  ShowTicks="True"
                  ShowDividers="True" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 0,
    Maximum = 10,
    Value = 5,
    Interval = 2,
    ShowDividers = true,
    ShowLabels = true,
    ShowTicks = true,
};

{% endhighlight %}

{% endtabs %}

![Slider numeric interval](images/interval/numeric-interval.png)

## Discrete selection for numeric values

Move the thumb in discrete manner for numeric values using the [`StepSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_StepSize) property in the slider.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="20"
                  Maximum="40"
                  Interval="5"
                  Value="30"
                  StepSize="5"
                  ShowLabels="True"
                  ShowTicks="True"
                  ShowDividers="True" />                 

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider()
{
    Minimum = 20,
    Maximum = 40,
    Value = 30,
    Interval = 5,
    ShowTicks = true,
    ShowLabels = true,
    ShowDividers = true,
    StepSize = 5,
};

{% endhighlight %}

{% endtabs %}

![Slider numeric discrete mode](images/interval/step-size.gif)