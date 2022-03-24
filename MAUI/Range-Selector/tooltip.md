---
layout: post
title: Tooltip in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Range Selector (SfRangeSelector) control and more.
platform: maui
control: SfRangeSelector
documentation: ug
---

# Tooltip in .NET MAUI Range Selector (SfRangeSelector)

This section helps to learn about how to add tooltip in the range selector.

## Enable tooltip

You can enable tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderToolTipShape.html#Syncfusion_Maui_Sliders_SliderToolTipShape_Rectangle). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipShape) property is null. 

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <rangeselector:SfRangeSelector>
         <rangeselector:SfRangeSelector.Tooltip>
            <rangeselector:SliderTooltip />
         </rangeselector:SfRangeSelector.Tooltip>
      <chart:SfCartesianChart />
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Tooltip = new SliderTooltip();
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/range-slider/events) to customize tooltip text format through range selector events.

## Tooltip label style

You can change the appearance of the tooltip text like fill, stroke, padding around the text using the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_ToolTipStyle) property.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:rangeselector="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chart="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    <rangeselector:SfRangeSelector>
         <rangeselector:SfRangeSelector.Tooltip>
            <rangeselector:SliderTooltip Fill="#F7B1AE" 
                                         Stroke="#EE3F3F" 
                                         StrokeThickness="2" />
         </rangeselector:SfRangeSelector.Tooltip>
        <chart:SfCartesianChart />
    </rangeselector:SfRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfRangeSelector rangeSelector = new SfRangeSelector();
rangeSelector.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
rangeSelector.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.Tooltip.StrokeThickness = 2;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector tooltip style](images/tooltip/tooltip-style.png)

