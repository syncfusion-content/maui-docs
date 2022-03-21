---
layout: post
title: Track in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about adding the track feature of .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Track in .NET MAUI Range Selector (SfRangeSelector)

This section helps to learn about how to customize the track in the range selector.

## Track color

You can change the active and inactive track color of the range selector using the [`ActiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveFill) and [`InactiveFill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveFill) properties of the [`TrackStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_TrackStyle) class.

The active side of the range selector is between start and end thumbs.

The inactive side of the range selector is between the [`Minimum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Minimum) value and the left thumb, and the right thumb and the [`Maximum`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Maximum) value.

{% tabs %}

{% highlight xaml %}

<rangeselector:SfRangeSelector>
  <rangeselector:SfRangeSelector.TrackStyle>
      <rangeselector:SliderTrackStyle ActiveFill="#EE3F3F" InactiveFill="#F7B1AE" />
  </rangeselector:SfRangeSelector.TrackStyle>
</rangeselector:SfRangeSelector>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.TrackStyle.ActiveFill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.TrackStyle.InactiveFill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![RangeSelector track color](images/track/track-color.png)

## Track height

You can change the active and inactive track height of the range selector using the [`ActiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveSize) and [`InactiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveSize) properties of the [`TrackStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_TrackStyle) class. The default value of the [`ActiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_ActiveSize) and the [`InactiveSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTrackStyle.html#Syncfusion_Maui_Sliders_SliderTrackStyle_InactiveSize) properties are `8.0` and `6.0` respectively.

{% tabs %}

{% highlight xaml %}

<rangeselector:SfRangeSelector>
   <rangeselector:SfRangeSelector.TrackStyle>
      <rangeselector:SliderTrackStyle ActiveSize="10" InactiveSize="8" />
   </rangeselector:SfRangeSelector.TrackStyle>
</rangeselector:SfRangeSelector>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.TrackStyle.ActiveSize = 10;
rangeSelector.TrackStyle.InactiveSize = 8;

{% endhighlight %}

{% endtabs %}

![RangeSelector track size](images/track/track-size.png)
