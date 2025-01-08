---
layout: post
title: Tooltip in .NET MAUI Range Slider control | Syncfusion<sup>®</sup>
description: Learn here all about adding the Tooltip feature of Syncfusion<sup>®</sup> .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Tooltip in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to add tooltip in the range slider.

## Enable tooltip

Enable tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with numberFormat. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_Tooltip) property is `null`.  

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

## Show always

Always shows a tooltip with and without the thumb interaction by setting the [`SliderTooltip.ShowAlways`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_ShowAlways) property. The default value of the [`SliderTooltip.ShowAlways`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_ShowAlways) property is `False`.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>
   
   <sliders:SfRangeSlider.Tooltip>
      <sliders:SliderTooltip ShowAlways="True" />
   </sliders:SfRangeSlider.Tooltip>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Tooltip = new SliderTooltip();
rangeSlider.Tooltip.ShowAlways = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider show always tooltip](images/tooltip/show-always-tooltip.gif)

N> Refer [here](https://help.syncfusion.com/maui/range-slider/events-and-commands#tooltip-text-format) to customize the tooltip text through the [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html) events.

## Tooltip label style

Change the appearance of the tooltip using the [`Fill`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Fill), [`Stroke`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Stroke), [`StrokeThickness`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_StrokeThickness), and [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Position) properties. Also, customize the tooltip text using the [`TextColor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_TextColor), [`FontSize`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontSize), [`FontAttributes`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontAttributes), [`FontFamily`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_FontFamily), [`Padding`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_Padding), and [`NumberFormat`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html#Syncfusion_Maui_Sliders_SliderTooltip_NumberFormat) properties of the [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html) class.

{% tabs %}

{% highlight xaml %}

<sliders:SfRangeSlider>

    <sliders:SfRangeSlider.Tooltip>
        <sliders:SliderTooltip Fill="#DFD8F7"
                               Stroke="#512BD4"
                               StrokeThickness="2"
                               TextColor="#512BD4"
                               FontSize="14"
                               FontAttributes="Bold"
                               Padding="12,12" />
    </sliders:SfRangeSlider.Tooltip>

</sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfRangeSlider rangeSlider = new SfRangeSlider();
rangeSlider.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#DFD8F7"));
rangeSlider.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#512BD4"));
rangeSlider.Tooltip.StrokeThickness = 2;
rangeSlider.Tooltip.TextColor = Color.FromArgb("#512BD4");
rangeSlider.Tooltip.FontSize = 14;
rangeSlider.Tooltip.FontAttributes = FontAttributes.Bold;
rangeSlider.Tooltip.Padding = new Thickness(12, 12);

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip style](images/tooltip/tooltip-style.png)

