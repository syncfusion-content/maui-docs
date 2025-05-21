---
layout: post
title: Range Selection in .NET MAUI Range Slider control | Syncfusion®
description: Learn about range selection features of the Syncfusion® .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Range Selection in .NET MAUI Range Slider (SfRangeSlider)

This section provides an overview of range selection in the Range Slider.

## Discrete Selection

The thumb can be moved in a discrete manner for numeric values using the [`StepSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.INumericElement.html#Syncfusion_Maui_Sliders_INumericElement_StepSize) property in the range slider.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0"
                       Maximum="10"
                       RangeStart="2"
                       RangeEnd="8"
                       Interval="2"
                       StepSize="2"
                       ShowLabels="True"
                       ShowTicks="True"
                       ShowDividers="True" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.StepSize = 2;
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 10;
rangeSlider.RangeStart = 2;
rangeSlider.RangeEnd = 8;
rangeSlider.Interval = 2;
rangeSlider.ShowLabels = true;
rangeSlider.ShowTicks = true;
rangeSlider.ShowDividers = true;
         
{% endhighlight %}

{% endtabs %}

![RangeSlider numeric discrete mode](images/selection/step-size.gif)

## Interval Selection

If the [`EnableIntervalSelection`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_EnableIntervalSelection) property is set to true, both thumbs move to the selected interval. Otherwise, the nearest thumb moves to the touch position.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0" 
                       Maximum="10"
                       RangeStart="2"
                       RangeEnd="8"
                       Interval="2"
                       ShowTicks="True"
                       ShowLabels="True"
                       EnableIntervalSelection="True" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 10;
rangeSlider.RangeStart = 2; 
rangeSlider.RangeEnd = 8;
rangeSlider.Interval = 2;        
rangeSlider.ShowLabels = true;
rangeSlider.ShowTicks = true;    
rangeSlider.EnableIntervalSelection = true;
         
{% endhighlight %}

{% endtabs %}

![RangeSlider EnableIntervalSelection](images/selection/enableintervalselection.gif)

## DragBehavior

### OnThumb

Setting the [`DragBehavior`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) to [OnThumb](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_OnThumb) allows moving individual thumbs by dragging. This is the default drag behavior.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0" 
                       Maximum="100"
                       RangeStart="25"
                       RangeEnd="75"
                       Interval="25" 
                       ShowTicks="True"
                       ShowLabels="True"
                       DragBehavior="OnThumb" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100;
rangeSlider.RangeStart = 25;
rangeSlider.RangeEnd = 75;
rangeSlider.Interval = 25; 
rangeSlider.ShowTicks = true;
rangeSlider.ShowLabels = true;  
rangeSlider.DragBehavior = SliderDragBehavior.OnThumb;

{% endhighlight %}

{% endtabs %}

### BetweenThumbs

If [`DragBehavior`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) is set to [BetweenThumbs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_BetweenThumbs), both thumbs can move simultaneously without changing the overall range. Individual thumb movement isn't possible when set to this behavior.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0" 
                       Maximum="100"
                       RangeStart="25"
                       RangeEnd="75"
                       Interval="25" 
                       ShowTicks="True"
                       ShowLabels="True"
                       DragBehavior="BetweenThumbs" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100;
rangeSlider.RangeStart = 25;
rangeSlider.RangeEnd = 75;
rangeSlider.Interval = 25; 
rangeSlider.ShowTicks = true;
rangeSlider.ShowLabels = true;   
rangeSlider.DragBehavior = SliderDragBehavior.BetweenThumbs;

{% endhighlight %}

{% endtabs %}

### Both

With [`DragBehavior`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeSliderBase-1.html#Syncfusion_Maui_Sliders_RangeSliderBase_1_DragBehavior) set to [Both](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderDragBehavior.html#Syncfusion_Maui_Sliders_SliderDragBehavior_Both), you can move individual thumbs or both together without changing the range between them.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0" 
                       Maximum="100"
                       RangeStart="25"
                       RangeEnd="75"
                       Interval="25" 
                       ShowTicks="True"
                       ShowLabels="True"
                       DragBehavior="Both" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 100;
rangeSlider.RangeStart = 25;
rangeSlider.RangeEnd = 75;
rangeSlider.Interval = 25; 
rangeSlider.ShowTicks = true; 
rangeSlider.ShowLabels = true;  
rangeSlider.DragBehavior = SliderDragBehavior.Both;

{% endhighlight %}

{% endtabs %}

![RangeSlider DragBehavior](images/selection/drag_behavior.gif)

## Deferred Update

You can control when dependent components update while thumbs are being dragged continuously by setting the `EnableDeferredUpdate` property. The delay can be configured with the `DeferredUpdateDelay` property, defaulting to `500` milliseconds.

This setup invokes the `ValueChanging` event when a thumb is dragged for the duration specified in `DeferredUpdateDelay`. Values are updated immediately upon releasing the touch.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider Minimum="0" 
                       Maximum="10"
                       RangeStart="2"
                       RangeEnd="8"
                       Interval="2"
                       ShowTicks="True"
                       ShowLabels="True"
                       EnableDeferredUpdate="True"
                       DeferredUpdateDelay="1000" />

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Minimum = 0;
rangeSlider.Maximum = 10;
rangeSlider.RangeStart = 2; 
rangeSlider.RangeEnd = 8;
rangeSlider.Interval = 2;        
rangeSlider.ShowLabels = true;
rangeSlider.ShowTicks = true;    
rangeSlider.EnableDeferredUpdate = true;
rangeSlider.DeferredUpdateDelay = 1000;
         
{% endhighlight %}

{% endtabs %}