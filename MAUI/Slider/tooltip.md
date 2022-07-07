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

Enable tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property is `null`. 

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
  <sliders:SfSlider.Tooltip>
    <sliders:SliderTooltip />
  </sliders:SfSlider.Tooltip>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Tooltip = new SliderTooltip();

{% endhighlight %}

{% endtabs %}

![Slider tooltip](images/tooltip/tooltip.png)

## Show always

Always shows a tooltip with and without the thumb interaction by setting the [`SliderTooltip.ShowAlways`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_ShowAlways) property. The default value of the [`SliderTooltip.ShowAlways`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_ShowAlways) property is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
  <sliders:SfSlider.Tooltip>
    <sliders:SliderTooltip ShowAlways="True" />
  </sliders:SfSlider.Tooltip>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Tooltip = new SliderTooltip();
slider.Tooltip.ShowAlways = true;

{% endhighlight %}

{% endtabs %}

![Slider show always tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/slider/events-and-commands#tooltip-text-format) to customize tooltip text format through Slider events.

## Tooltip label style

Change the appearance of the tooltip using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Fill), [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Stroke), [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_StrokeThickness), and [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Position) properties. Also, customize the tooltip text using the [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TextColor), [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontSize), [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontAttributes), [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontFamily), [`Padding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Padding), and [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_NumberFormat) properties of the [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfSlider>
  <sliders:SfSlider.Tooltip>
    <sliders:SliderTooltip Fill="#F7B1AE" 
                           Stroke="#EE3F3F" 
				                   StrokeThickness="2" />
  </sliders:SfSlider.Tooltip>
</sliders:SfSlider>

{% endhighlight %}

{% highlight C# %}

SfSlider slider = new SfSlider();
slider.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
slider.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
slider.Tooltip.StrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![Slider tooltip style](images/tooltip/tooltip-style.png)
