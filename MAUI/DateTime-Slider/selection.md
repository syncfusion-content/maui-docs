---
layout: post
title: Value Selection in .NET MAUI Slider Control | Syncfusion®
description: Learn about value selection features in the Syncfusion® .NET MAUI Slider (SfDateTimeSlider) control.
platform: maui
control: SfDateTimeSlider
documentation: ug
---

# Value Selection in .NET MAUI DateTime Slider (SfDateTimeSlider)

This section provides insight into value selection within the DateTime Slider.

## Discrete Selection

Use the [`StepDuration`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfDateTimeSlider.html#Syncfusion_Maui_Sliders_SfDateTimeSlider_StepDuration) property to move the thumb discretely for DateTime values.

For example, with a [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Minimum) of `DateTime(2015, 01, 01)`, a [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Maximum) of `DateTime(2020, 01, 01)`, and a `StepDuration` of `1`, the slider will move the thumb to DateTime(2015, 01, 01), DateTime(2016, 01, 01), DateTime(2017, 01, 01), and DateTime(2018, 01, 01).

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

## Deferred Update

Control when dependent components are updated while thumbs are being dragged continuously by setting the `EnableDeferredUpdate` property. The delay in updates can be managed using the `DeferredUpdateDelay` property, which defaults to `500` milliseconds.

The `ValueChanging` event is invoked when the thumb is held for the duration specified in `DeferredUpdateDelay`. However, values are immediately updated upon touch release.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeSlider Minimum="2000-01-01"
                          Maximum="2004-01-01"
                          Value="2002-01-01"
                          Interval="1"
                          ShowTicks="True"
                          ShowLabels="True"
                          EnableDeferredUpdate="True"
                          DeferredUpdateDelay="1000" />

{% endhighlight %}

{% highlight C# %}

SfDateTimeSlider slider = new SfDateTimeSlider()
{
    Minimum = new DateTime(2000, 01, 01),
    Maximum = new DateTime(2004, 01, 01),
    Value = new DateTime(2002, 01, 01),
    Interval = 1,
    ShowTicks = true,
    ShowLabels = true,
    EnableDeferredUpdate = true,
    DeferredUpdateDelay = 1000,
};

{% endhighlight %}

{% endtabs %}