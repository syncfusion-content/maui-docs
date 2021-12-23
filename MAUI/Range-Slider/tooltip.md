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

You can enable tooltip for the thumb by setting the [`ToolTipShape`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property to [`SliderToolTipShape.Rectangle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderToolTipShape.html#Syncfusion_Maui_Sliders_SliderToolTipShape_Rectangle). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the [`ToolTipShape`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property is[`SliderToolTipShape.None`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderToolTipShape.html#Syncfusion_Maui_Sliders_SliderToolTipShape_None). 

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider ToolTipShape="Rectangle"/>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.ToolTipShape = SliderToolTipShape.Rectangle;

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/range-slider/events) to customize tooltip text format through range slider events.

## Tooltip label style

You can change the appearance of the tooltip text like color, stroke color, padding around the text using the [`ToolTipStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipStyle) property.

{% tabs %}

{% highlight xaml %}

 <rangeslider:SfRangeSlider  ToolTipShape="Rectangle">
    <rangeslider:SfRangeSlider.ToolTipStyle>
       <rangeslider:SliderToolTipStyle Color="#F7B1AE" 
                                       StrokeColor="#EE3F3F" 
                                       StrokeWidth="2" />
    </rangeslider:SfRangeSlider.ToolTipStyle>
 </rangeslider:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

 SfRangeSlider rangeSlider = new SfRangeSlider();
 rangeSlider.ToolTipShape = SliderToolTipShape.Rectangle;
 rangeSlider.ToolTipStyle.Color = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
 rangeSlider.ToolTipStyle.StrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
 rangeSlider.ToolTipStyle.StrokeWidth = 2;

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip style](images/tooltip/tooltip-style.png)

