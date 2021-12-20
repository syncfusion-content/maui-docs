---
layout: post
title: Thumb and Thumb Overlay in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about the Thumb and Thumb Overlay features of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Thumb and Thumb Overlay in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to customize the thumb and thumb overlay in the range slider.

* Thumb - It is one of the elements of slider which can be used to drag and change the selected value of the range slider.
* Thumb overlay - It is rendered around the thumb while interacting with them.

## Thumb size

You can change the size of the thumb in the range slider using the `Radius` property of the `ThumbStyle` class. The default value of the `Radius` property is `10.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
   <sliders:SfRangeSlider.ThumbStyle>
       <sliders:SliderThumbStyle Radius="15" />
   </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Radius = 15;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb color

You can change the color of the thumb in the range slider using the `Fill` property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
   <sliders:SfRangeSlider.ThumbStyle>
       <sliders:SliderThumbStyle Fill="#EE3F3F" />
   </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb stroke width and stroke color

You can change the thumb stroke width using the `StrokeThickness` property and thumb stroke color using the `Stroke` property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
   <sliders:SfRangeSlider.ThumbStyle>
       <sliders:SliderThumbStyle StrokeThickness="2" Stroke="#EE3F3F" />
   </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.ThumbStyle.StrokeThickness = 2;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb overlapping stroke color

You can change the thumb stroke color while two thumbs are overlapping in the range slider using the `OverlapStrokeColor` property of the `ThumbStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
  <sliders:SfRangeSlider.ThumbStyle>
      <sliders:SliderThumbStyle OverlapStroke="#EE3F3F" />
  </sliders:SfRangeSlider.ThumbStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.OverlapStrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb stroke color](images/thumb-and-thumb-overlay/thumb-overlapstrokecolor.gif)

## Thumb overlay size

You can change the size of the thumb overlay in the range slider using the `Radius` property of the `ThumbOverlayStyle` class. The default value of the `Radius` property is `24.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
   <sliders:SfRangeSlider.ThumbOverlayStyle>
      <sliders:SliderThumbOverlayStyle Radius="30"/>
   </sliders:SfRangeSlider.ThumbOverlayStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Radius = 30;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

You can change the color of the thumb overlay in the range slider using the `Fill` property of the `ThumbOverlayStyle` class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider >
   <sliders:SfRangeSlider.ThumbOverlayStyle>
      <sliders:SliderThumbOverlayStyle Fill="#F7C8DB"/>
   </sliders:SfRangeSlider.ThumbOverlayStyle>
</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#F7C8DB"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)
