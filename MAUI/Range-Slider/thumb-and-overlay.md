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

You can change the size of the thumb in the range slider using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)  property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius) property is `10.0`.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
   <rangeslider:SfRangeSlider.ThumbStyle>
       <rangeslider:SliderThumbStyle Radius="15" />
   </rangeslider:SfRangeSlider.ThumbStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Radius = 15;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb color

You can change the color of the thumb in the range slider using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
   <rangeslider:SfRangeSlider.ThumbStyle>
       <rangeslider:SliderThumbStyle Fill="#EE3F3F" />
   </rangeslider:SfRangeSlider.ThumbStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb stroke width and stroke color

You can change the thumb stroke width using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness) property and thumb stroke color using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
   <rangeslider:SfRangeSlider.ThumbStyle>
       <rangeslider:SliderThumbStyle StrokeThickness="2" Stroke="#EE3F3F" />
   </rangeslider:SfRangeSlider.ThumbStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSlider.ThumbStyle.StrokeThickness = 2;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb overlapping stroke color

You can change the thumb stroke color while two thumbs are overlapping in the range slider using the [`OverlapStroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_OverlapStroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
  <rangeslider:SfRangeSlider.ThumbStyle>
      <rangeslider:SliderThumbStyle OverlapStroke="#EE3F3F" />
  </rangeslider:SfRangeSlider.ThumbStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbStyle.OverlapStroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb stroke color](images/thumb-and-thumb-overlay/thumb-overlapstrokecolor.gif)

## Thumb overlay size

You can change the size of the thumb overlay in the range slider using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property is `24.0`.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
   <rangeslider:SfRangeSlider.ThumbOverlayStyle>
      <rangeslider:SliderThumbOverlayStyle Radius="30"/>
   </rangeslider:SfRangeSlider.ThumbOverlayStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Radius = 30;
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

You can change the color of the thumb overlay in the range slider using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Fill) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider >
   <rangeslider:SfRangeSlider.ThumbOverlayStyle>
      <rangeslider:SliderThumbOverlayStyle Fill="#F7C8DB"/>
   </rangeslider:SfRangeSlider.ThumbOverlayStyle>
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#F7C8DB"));
        
{% endhighlight %}

{% endtabs %}

![RangeSlider thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)
