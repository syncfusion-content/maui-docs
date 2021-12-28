---
layout: post
title: Thumb and Thumb Overlay in .NET MAUI Slider control | Syncfusion
description: Learn here all about the Thumb and Thumb Overlay features of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Thumb and Overlay in .NET MAUI Slider (SfSlider)

This section helps to learn about how to customize the thumb and thumb overlay in the slider.

* Thumb - It is one of the elements of slider which can be used to drag and change the selected value of the slider.
* Thumb overlay - It is rendered around the thumb while interacting with them.

## Thumb size

You can change the size of the thumb in the slider using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Radius)  property is `10.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
    <sliders:SfSlider.ThumbStyle>
        <sliders:SliderThumbStyle Radius="15" />
     </sliders:SfSlider.ThumbStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ThumbStyle.Radius = 15;

{% endhighlight %}

{% endtabs %}

![Slider thumb size](images/thumb-and-thumb-overlay/thumb-radius.png)

## Thumb color

You can change the color of the thumb in the slider using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Fill) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
   <sliders:SfSlider.ThumbStyle>
       <sliders:SliderThumbStyle Fill="#EE3F3F" />
   </sliders:SfSlider.ThumbStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ThumbStyle.Fill = new SolidColorBrush(Color.FromArgb("#EE3F3F"));

{% endhighlight %}

{% endtabs %}

![Slider thumb color](images/thumb-and-thumb-overlay/thumb-color.png)

## Thumb stroke thickness and stroke

You can change the thumb stroke width using the [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_StrokeThickness) property and thumb stroke color using the [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html#Syncfusion_Maui_Sliders_SliderThumbStyle_Stroke) property of the [`ThumbStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
    <sliders:SfSlider.ThumbStyle>
        <sliders:SliderThumbStyle Stroke="#EE3F3F" 
                                  StrokeThickness="2"/>
    </sliders:SfSlider.ThumbStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ThumbStyle.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.ThumbStyle.StrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![Slider thumb stroke color](images/thumb-and-thumb-overlay/thumb-stroke-color.png)

## Thumb overlay size

You can change the size of the thumb overlay in the slider using the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class. The default value of the [`Radius`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Radius)  property is `24.0`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
   <sliders:SfSlider.ThumbOverlayStyle>
      <sliders:SliderThumbOverlayStyle Radius="26"/>
   </sliders:SfSlider.ThumbOverlayStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ThumbOverlayStyle.Radius = 26;

{% endhighlight %}

{% endtabs %}

![Slider thumb overlay size](images/thumb-and-thumb-overlay/thumb-overlay-radius.png)

## Thumb overlay color

You can change the color of the thumb overlay in the slider using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html#Syncfusion_Maui_Sliders_SliderThumbOverlayStyle_Fill) property of the [`ThumbOverlayStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderThumbOverlayStyle.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
   <sliders:SfSlider.ThumbOverlayStyle>
       <sliders:SliderThumbOverlayStyle Fill="#F7C8DB"/>
   </sliders:SfSlider.ThumbOverlayStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ThumbOverlayStyle.Fill = new SolidColorBrush(Color.FromArgb("#F7C8DB")); 

{% endhighlight %}

{% endtabs %}

![Slider thumb overlay color](images/thumb-and-thumb-overlay/thumb-overlay-color.png)
