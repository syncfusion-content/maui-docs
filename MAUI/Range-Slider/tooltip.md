---
layout: post
title: Tooltip in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Tooltip in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to add tooltip in the range slider.

## Enable tooltip

You can enable tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with numberFormat. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property is null.  

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   
   <sliders:SfRangeSlider.Tooltip>
      <sliders:SliderTooltip />
   </sliders:SfRangeSlider.Tooltip>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Tooltip = new SliderTooltip();

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/range-slider/events) to customize tooltip text format through range slider events.

## Tooltip label style

You can change the appearance of the tooltip text like fill, stroke, padding around the text using the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property.

{% tabs %}

{% highlight xaml %}

 <sliders:SfRangeSlider>
    
    <sliders:SfRangeSlider.Tooltip>
       <sliders:SliderTooltip Fill="#F7B1AE" 
                              Stroke="#EE3F3F" 
                              StrokeThickness="2" />
    </sliders:SfRangeSlider.Tooltip>
 
 </sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

 SfRangeSlider rangeSlider = new SfRangeSlider();
 rangeSlider.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
 rangeSlider.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
 rangeSlider.Tooltip.StrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip style](images/tooltip/tooltip-style.png)

