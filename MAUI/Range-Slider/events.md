---
layout: post
title: Events in.NET MAUI Range Slider control | Syncfusion 
description: Learn here all about adding the events of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Events in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the events for range slider.

## Handle ValueChanging, ValueChanged, ValueChangeStart, and ValueChangeEnd callbacks

* [ValueChangeStart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChangeStart) -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* [ValueChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChanging) - Called when the user is selecting a new value for the slider by dragging the thumb.
* [ValueChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChanged) - Called when the user completed selecting a new value.
* [ValueChangeEnd](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html#Syncfusion_Maui_Sliders_SfRangeSlider_ValueChangeEnd) - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

 <rangeslider:SfSlider Minimum="2010-01-01" 
                       Maximum="2020-01-01" 
                       RangeStart="2012-01-01" 
                       RangeEnd="2018-01-01" 
                       ValueChangeStart="OnValueChangeStart" 
                       ValueChanging="OnValueChanging" 
                       ValueChanged="OnValueChanged" 
                       ValueChangeEnd="OnValueChangeEnd">
</rangeslider:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
   SfRangeSlider rangeSlider = new SfRangeSlider();
   rangeSlider.ValueChangeStart += OnValueChanged;
   rangeSlider.ValueChanging += OnValueChanged;
   rangeSlider.ValueChanged += OnValueChanged;
   rangeSlider.ValueChangeEnd += OnValueChanged;
}

private void OnValueChangeStart(object sender, RangeSliderValueChangeStartEventArgs e)
{
}

private void OnValueChanging(object sender, RangeSliderValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, RangeSliderValueChangedEventArgs e)
{
}

private void OnValueChangeEnd(object sender, RangeSliderValueChangeEndEventArgs e)
{
}

{% endhighlight %}

{% endtabs %}

