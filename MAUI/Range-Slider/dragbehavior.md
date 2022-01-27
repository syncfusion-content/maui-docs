---
layout: post
title: Thumb DragBehavior in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about Thumb Dragbehavior feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Thumb DragBehavior in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about thumb drag behavior in the range slider.

## OnThumb

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSlider_DragBehavior) is set to [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb), individual thumb can be moved based on the dragging. By default, the [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb) has been used as drag behavior.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Minimum="0" 
                           Maximum="100" 
                           ShowTicks="True"
                           ShowLabels="True"
                           DragBehavior="OnThumb">
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100; 
rangeSlider.ShowTicks = true;
rangeSlider.ShowLabels = true;  
rangeSlider.DragBehavior = SliderDragBehavior.OnThumb;

{% endhighlight %}

{% endtabs %}

![DragBehavior OnThumb](images/drag-behavior/onthumb.gif)

## BetweenThumbs

When the [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSlider_DragBehavior) is set to [BetweenThumbs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs), both the thumbs can be moved at same time without changing the range between the start and end thumbs. We had considered this behavior without the range slider thumb radius. Its not possible to move the individual thumb when setting this behavior.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Minimum="0" 
                           Maximum="100" 
                           ShowTicks="True"
                           ShowLabels="True"
                           DragBehavior="BetweenThumbs">
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100; 
rangeSlider.ShowTicks = true;
rangeSlider.ShowLabels = true;   
rangeSlider.DragBehavior = SliderDragBehavior.BetweenThumbs;

{% endhighlight %}

{% endtabs %}

![DragBehavior Betweenthumb](images/drag-behavior/betweenthumb.gif)

## Both

When the  [DragBehavior](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SfRangeSlider.html?tabs=tabid-1#Syncfusion_Maui_Sliders_SfRangeSlider_DragBehavior) is set to [Both](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both), the individual thumb can be moved and also the both thumbs can be moved at same time without changing the range between the start and end thumbs.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Minimum="0" 
                           Maximum="100" 
                           ShowTicks="True"
                           ShowLabels="True"
                           DragBehavior="Both">
</rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100; 
rangeSlider.ShowTicks = true; 
rangeSlider.ShowLabels = true;  
rangeSlider.DragBehavior = SliderDragBehavior.Both;

{% endhighlight %}

{% endtabs %}

![DragBehavior Both](images/drag-behavior/both.gif)

