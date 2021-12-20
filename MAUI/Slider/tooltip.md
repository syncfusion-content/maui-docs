---
layout: post
title: Tooltip in .NET MAUI Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Slider (SfSlider) control and more.
platform: maui
control: SfSlider
documentation: ug
---

# Tooltip in .NET MAUI Slider (SfSlider)

This section helps to learn about how to add tooltip in the slider.

## Enable tooltip

You can enable tooltip for the thumb by setting the [`ToolTipShape`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property to [`SliderToolTipShape.Rectangle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderToolTipShape.html#Syncfusion_Maui_Sliders_SliderToolTipShape_Rectangle). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the [`ToolTipShape`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property is [`SliderToolTipShape.None`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderToolTipShape.html#Syncfusion_Maui_Sliders_SliderToolTipShape_None). 

{% tabs %}

{% highlight xaml %}

  <sliders:SfSlider ToolTipShape="Rectangle" />

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ToolTipShape = SliderToolTipShape.Rectangle;

{% endhighlight %}

{% endtabs %}

![Slider tooltip](images/tooltip/tooltip.png)

N> Learn how to customize tooltip text format through [Events](https://help.syncfusion.com/maui/slider/events)

## Tooltip label style

You can change the appearance of the tooltip text like color, stroke color, padding around the text using the [`ToolTipStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipStyle) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider ToolTipShape="Rectangle">
   <sliders:SfSlider.ToolTipStyle>
      <sliders:SliderToolTipStyle Color="#F7B1AE" 
                                  StrokeColor="#EE3F3F" 
				  StrokeWidth="2" />
    </sliders:SfSlider.ToolTipStyle>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.ToolTipShape = SliderToolTipShape.Rectangle;
slider.ToolTipStyle.Color = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.ToolTipStyle.StrokeColor = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.ToolTipStyle.StrokeWidth = 2;

{% endhighlight %}

{% endtabs %}

![Slider tooltip style](images/tooltip/tooltip-style.png)
