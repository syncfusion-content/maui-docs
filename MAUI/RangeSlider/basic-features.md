---
layout: post
title: Basic features in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Basic features  in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the numeric and date range slider.

## Minimum

The minimum value that the user can select. The default value of `Minimum` property is 0.0 and it must be less than the `Maximum` value.

## Maximum

The maximum value that the user can select. The default value of `Maximum` property is 1.5 and it must be greater than the `Minimum` value.

## Range values

It represents the values currently selected in the range slider. The range slider’s thumb is drawn corresponding to this `RangeStart` and `RangeEnd` values.

For date values, the range slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="2010-01-01" 
                       Maximum="2020-01-01" 
                       RangeStart="2012-01-01" 
                       RangeEnd="2018-01-01" >
 </sliders:SfRangeSlider>
 
{% endhighlight %}

{% highlight C# %}

 SfRangeSlider rangeSlider = new SfRangeSlider();
 rangeSlider.Minimum = new DateTime(2010, 01, 01);
 rangeSlider.Maximum = new DateTime(2020, 01, 01);
 rangeSlider.RangeStart = new DateTime(2012, 01, 01);
 rangeSlider.RangeEnd = new DateTime(2018, 01, 01);

{% endhighlight %}

{% endtabs %}

![RangeSlider date label](images/basic-features/date-labels.png)

## Handle ValueChanging, ValueChanged, ValueChangeStart, and ValueChangeEnd callbacks

* ValueChangeStart -  Called when the user selecting a new value for the slider by tap/mouse down in the thumb.
* ValueChanging - Called when the user is selecting a new value for the slider by dragging the thumb.
* ValueChanged - Called when the user completed selecting a new value.
* ValueChangeEnd - Called when the user stopped interacting with slider by tap/mouse up the thumb.

{% tabs %}

{% highlight xaml %}

 <sliders:SfSlider Minimum="2010-01-01" 
                   Maximum="2020-01-01" 
                   RangeStart="2012-01-01" 
                   RangeEnd="2018-01-01" 
                   ValueChangeStart="OnValueChangeStart" 
                   ValueChanging="OnValueChanging" 
                   ValueChanged="OnValueChanged" 
                   ValueChangeEnd="OnValueChangeEnd">
 </sliders:SfSlider>

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
