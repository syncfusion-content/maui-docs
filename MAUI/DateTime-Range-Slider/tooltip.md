---
layout: post
title: Tooltip in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Range Slider (SfDateTimeRangeSlider) control and more.
platform: maui
control: SfDateTimeRangeSlider
documentation: ug
---

# Tooltip in .NET MAUI DateTime Range Slider (SfDateTimeRangeSlider)

This section helps to learn about how to add tooltip in the DateTime Range Slider.

## Enable tooltip

You can enable the tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html). It is used to clearly indicate the current selection of the value during the interaction. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property is null.  

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2018-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2016-01-01">
   
   <sliders:SfDateTimeRangeSlider.Tooltip>
      <sliders:SliderTooltip />
   </sliders:SfDateTimeRangeSlider.Tooltip>

</sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
rangeSlider.Tooltip = new SliderTooltip();

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/range-slider/events) to customize the tooltip text format through range slider events.

## Tooltip label style

You can change the appearance of the tooltip text like fill, stroke, and padding around the text using the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2018-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2016-01-01">
    
    <sliders:SfDateTimeRangeSlider.Tooltip>
       <sliders:SliderTooltip Fill="#F7B1AE" 
                              Stroke="#EE3F3F" 
                              StrokeThickness="2" />
    </sliders:SfDateTimeRangeSlider.Tooltip>
 
 </sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
 rangeSlider.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
 rangeSlider.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
 rangeSlider.Tooltip.StrokeThickness = 2;

{% endhighlight %}

{% endtabs %}

![RangeSlider tooltip style](images/tooltip/tooltip-style.png)

