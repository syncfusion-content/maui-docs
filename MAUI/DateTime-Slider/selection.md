---
layout: post
title: Value selection in .NET MAUI Slider control | Syncfusion
description: Learn here all about value selection of Syncfusion .NET MAUI Slider (SfDateTimeSlider) control and more.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Value selection in .NET MAUI DateTime Slider (SfDateTimeSlider)

This section helps to learn about the value selection in the DateTime Slider.

## Discrete selection

Move the thumb in discrete manner for date values using the [`StepDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_StepDuration) property in the slider.

For example, if the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) is DateTime(2015, 01, 01), the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) is DateTime(2020, 01, 01), and [`StepDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_StepDuration) is `1`,the slider will move the thumbs at DateTime(2015, 01, 01), DateTime(2016, 01, 01), DateTime(2017, 01, 01),and DateTime(2018, 01, 01).

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2000-01-01"
                          Maximum="2004-01-01"
                          Value="2002-01-01"
                          Interval="1"
                          StepDuration="1"
                          IntervalType="Years"
                          ShowTicks="True"
                          ShowLabels="True" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2000, 01, 01),
    Maximum = new DateTime(2004, 01, 01),
    Value = new DateTime(2002, 01, 01),
    Interval = 1,
    StepDuration = new SliderStepDuration(years: 1),
    IntervalType = SliderDateIntervalType.Years,
    ShowTicks = true,
    ShowLabels = true,
};

{% endhighlight %}

{% endtabs %}

![Slider date discrete mode](images/selection/step-duration.gif)