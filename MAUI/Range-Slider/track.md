---
layout: post
title: Track in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the track feature of .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Track in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to customize the track in the range slider.

## Track color

You can change the active and inactive track color of the range slider using the `ActiveFill` and `InactiveFill` properties of the `TrackStyle` class.

The active side of the range slider is between start and end thumbs.

The inactive side of the range slider is between the `Minimum` value and the left thumb, and the right thumb and the `Maximum` value.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
  <sliders:SfRangeSlider.TrackStyle>
      <sliders:SliderTrackStyle ActiveFill="#EE3F3F" InactiveFill="#F7B1AE" />
  </sliders:SfRangeSlider.TrackStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.TrackStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.TrackStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![RangeSlider track color](images/track/track-color.png)

## Track height

You can change the active and inactive track height of the range slider using the `ActiveSize` and `InactiveSize` properties of the `TrackStyle` class. The default value of the `ActiveSize` and the `InactiveSize` properties are `8.0` and `6.0` respectively.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   <sliders:SfRangeSlider.TrackStyle>
      <sliders:SliderTrackStyle ActiveSize="10" InactiveSize="8" />
   </sliders:SfRangeSlider.TrackStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.TrackStyle.ActiveSize = 10;
rangeSlider.TrackStyle.InactiveSize = 8;

{% endhighlight %}

{% endtabs %}

![RangeSlider track size](images/track/track-size.png)

