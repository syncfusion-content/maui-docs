---
layout: post
title: Value selection in .NET MAUI Slider control | Syncfusion<sup>®</sup>
description: Learn here all about the value selection of Syncfusion<sup>®</sup> .NET MAUI Slider (SfSlider) control and more.
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

## Deferred update

You can control when the dependent components are updated while thumbs are being dragged continuously. It can be achieved by setting the `EnableDeferredUpdate` property and the delay in the update can be achieved by setting the `DeferredUpdateDelay` property. The default value of the `DeferredUpdateDelay` property is `500` milliseconds.

It invokes the `ValueChanging` event when the thumb is dragged and held for the duration specified in the `DeferredUpdateDelay`. However, the values are immediately updated in touch-up action.

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