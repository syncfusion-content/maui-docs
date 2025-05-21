---
layout: post
title: Value Selection in .NET MAUI Slider Control | Syncfusion®
description: Learn about the value selection feature of the Syncfusion® .NET MAUI Slider (SfSlider) control.
platform: maui
control: SfSlider
documentation: ug
---

# Value Selection in .NET MAUI Slider (SfSlider)

This section explains how value selection works in the Slider control.

## Discrete Selection

The thumb can be moved in a discrete manner for numeric values using the [`StepSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfSlider.html#Syncfusion_Maui_Sliders_SfSlider_StepSize) property of the slider.

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

## Deferred Update

Control when the dependent components are updated while thumbs are being dragged continuously by setting the `EnableDeferredUpdate` property. The delay in the update can be configured using the `DeferredUpdateDelay` property. By default, the delay is set to `500` milliseconds.
The `ValueChanging` event is invoked when the thumb is dragged and held for the duration specified in the `DeferredUpdateDelay`; however, values are immediately updated upon touch-up action.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider Minimum="20"
                  Maximum="40"
                  Interval="5"
                  Value="30"
                  ShowLabels="True"
                  ShowTicks="True"
                  EnableDeferredUpdate="True"
                  DeferredUpdateDelay="1000" />                 

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
    EnableDeferredUpdate = true,
    DeferredUpdateDelay = 1000,
};
         
{% endhighlight %}

{% endtabs %}