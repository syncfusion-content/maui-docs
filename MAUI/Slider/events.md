---
layout: post
title: Events in.NET MAUI Slider control | Syncfusion 
description: Learn here all about adding and customizing through events of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Events in .NET MAUI Slider (SfSlider)

This section explains about how to add the events for slider.

## Handle ValueChanging, ValueChanged, ValueChangeStart, and ValueChangeEnd callbacks

* ValueChangeStart -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* ValueChanging - Called when the user is selecting a new value for the slider by dragging the thumb.
* ValueChanged - Called when the user completed selecting a new value.
* ValueChangeEnd - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider  Minimum="2010-01-01" 
  	           Maximum="2020-01-01" 
		   Value="2014-01-01" 
	           ValueChangeStart="OnValueChangeStart" 
	 	   ValueChanging="OnValueChanging" 
		   ValueChanged="OnValueChanged" 
		   ValueChangeEnd="OnValueChangeEnd">
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

{
   SfSlider slider = new SfSlider();
   slider.ValueChangeStart += OnValueChanged;
   slider.ValueChanging += OnValueChanged;
   slider.ValueChanged += OnValueChanged;
   slider.ValueChangeEnd += OnValueChanged;
}

private void OnValueChangeStart(object sender, SliderValueChangeStartEventArgs e)
{
}

private void OnValueChanging(object sender, SliderValueChangingEventArgs e)
{
}

private void OnValueChanged(object sender, SliderValueChangedEventArgs e) 
{
}
private void OnValueChangeEnd(object sender, SliderValueChangeEndEventArgs e)
{
}

{% endhighlight %}

{% endtabs %}

