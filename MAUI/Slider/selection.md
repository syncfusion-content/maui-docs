---
layout: post
title: Value selection in .NET MAUI Slider control | Syncfusion
description: Learn here all about value selection of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Value selection in .NET MAUI Slider (SfSlider)

This section helps to learn about the value selection in the Slider.

## Discrete selection

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

![Slider numeric discrete mode](images/selection/step-size.gif)