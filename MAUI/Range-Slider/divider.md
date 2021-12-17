---
layout: post
title: Dividers in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about the Dividers feature of .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Dividers in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the dividers in the range slider.

## Show dividers

The `ShowDividers` property is used to render the dividers on the track. The default value of the `ShowDividers` property is `False`. It is a shape which is used to represent the major interval points of the track.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the range slider will render the dividers at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Interval="0.2" 
                           ShowDividers="True">
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider](images/labels-and-dividers/divider.png)

## Divider radius

You can change the active and inactive divider radius of the range slider using the `ActiveRadius` and the `InactiveRadius` properties of the `DividerStyle` class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Interval="0.2" 
                           ShowDividers="True">
   <rangeslider:SfRangeSlider.DividerStyle>
      <rangeslider:SliderDividerStyle ActiveRadius="7" InactiveRadius="7" />
   </rangeslider:SfRangeSlider.DividerStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 7;
rangeSlider.DividerStyle.InactiveRadius = 7;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider radius](images/labels-and-dividers/divider-radius.png)

## Divider stroke width and stroke color

You can change the active and inactive divider stroke width of the range slider using the `ActiveStrokeWidth` and the `InactiveStrokeWidth` properties of the `DividerStyle` class.

Also, you can change the active and inactive divider stroke color of the range slider using the `ActiveStrokeColor` and the `InactiveStrokeColor` properties of the `DividerStyle` class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Interval="0.2" 
                           ShowDividers="True">
   <rangeslider:SfRangeSlider.DividerStyle>
        <rangeslider:SliderDividerStyle ActiveRadius="7" 
                                        InactiveRadius="7" 
                                        ActiveStrokeWidth="2" 
                                        InactiveStrokeWidth="2" 
                                        ActiveStrokeColor="#EE3F3F" 
                                        InactiveStrokeColor="#F7B1AE"/>
   </rangeslider:SfRangeSlider.DividerStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 7;
rangeSlider.DividerStyle.InactiveRadius = 7;
rangeSlider.DividerStyle.ActiveStrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.DividerStyle.InactiveStrokeColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
rangeSlider.DividerStyle.ActiveStrokeWidth = 2;
rangeSlider.DividerStyle.InactiveStrokeWidth = 2;

{% endhighlight %}

{% endtabs %}

![RangeSlider divider stroke color](images/labels-and-dividers/divider-stroke-color.png)

## Divider color

You can change the active and inactive divider color of the range slider using the `ActiveColor` and `InactiveColor` properties of the `DividerStyle` class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Interval="0.2" 
                           ShowDividers="True">
    <rangeslider:SfRangeSlider.DividerStyle>
        <rangeslider:SliderDividerStyle ActiveRadius="7" 
                                        InactiveRadius="7" 
                                        ActiveColor="#EE3F3F" 
                                        InactiveColor="#F7B1AE"/>
     </rangeslider:SfRangeSlider.DividerStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Interval = 0.2;
rangeSlider.ShowDividers = true;
rangeSlider.DividerStyle.ActiveRadius = 7;
rangeSlider.DividerStyle.InactiveRadius = 7;
rangeSlider.DividerStyle.ActiveColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.DividerStyle.InactiveColor = new SolidColorBrush(Color.FromArgb("#F7B1AE"));

{% endhighlight %}

{% endtabs %}

![RangeSlider divider color](images/labels-and-dividers/divider-color.png)
