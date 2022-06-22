---
layout: post
title: Tooltip in .NET MAUI Range Selector control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Range Selector (SfDateTimeRangeSelector) control and more.
platform: maui
control: SfDateTimeRangeSelector
documentation: ug
---

# Tooltip in .NET MAUI DateTime Range Selector (SfDateTimeRangeSelector)

This section helps to learn about how to add tooltip in the DateTime Range Selector.

## Enable tooltip

You can enable tooltip for the thumb by setting the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property to [`SliderTooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderTooltip.html). It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property is null. 

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chartS="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01">
         
         <sliders:SfDateTimeRangeSelector.Tooltip>
            <sliders:SliderTooltip />
         </sliders:SfDateTimeRangeSelector.Tooltip>
     
     <charts:SfCartesianChart>
         ...
     </charts:SfCartesianChart>
    
    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
rangeSelector.Tooltip = new SliderTooltip();
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector tooltip](images/tooltip/tooltip.png)

N> Refer [here](https://help.syncfusion.com/maui/range-selector/events) to customize tooltip text format through Range Selector events.

## Tooltip label style

You can change the appearance of the tooltip text like fill, stroke, padding around the text using the [`Tooltip`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.SliderBase.html#Syncfusion_Maui_Sliders_SliderBase_Tooltip) property.

{% tabs %}

{% highlight xaml %}

<ContentPage 
             ...
             xmlns:sliders="clr-namespace:Syncfusion.Maui.Sliders;assembly=Syncfusion.Maui.Sliders"
             xmlns:chartS="clr-namespace:Syncfusion.Maui.Charts;assembly=Syncfusion.Maui.Charts">
    
    <sliders:SfDateTimeRangeSelector Minimum="2010-01-01" 
                                     Maximum="2018-01-01" 
                                     RangeStart="2012-01-01" 
                                     RangeEnd="2016-01-01">
         
         <sliders:SfDateTimeRangeSelector.Tooltip>
            <sliders:SliderTooltip Fill="#F7B1AE" 
                                   Stroke="#EE3F3F" 
                                   StrokeThickness="2" />
        
         </sliders:SfDateTimeRangeSelector.Tooltip>
        
        <charts:SfCartesianChart>
            ...
        </charts:SfCartesianChart>
    
    </sliders:SfDateTimeRangeSelector>
</ContentPage>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSelector rangeSelector = new SfDateTimeRangeSelector();
rangeSelector.Minimum = new DateTime(2010, 01, 01);
rangeSelector.Maximum = new DateTime(2018, 01, 01);
rangeSelector.RangeStart = new DateTime(2012, 01, 01);
rangeSelector.RangeEnd = new DateTime(2016, 01, 01);
rangeSelector.Tooltip.Fill = new SolidColorBrush(Color.FromArgb("#F7B1AE"));
rangeSelector.Tooltip.Stroke = new SolidColorBrush(Color.FromArgb("#EE3F3F"));
rangeSelector.Tooltip.StrokeThickness = 2;
SfCartesianChart chart = new SfCartesianChart();
rangeSelector.Content = chart;

{% endhighlight %}

{% endtabs %}

![RangeSelector tooltip style](images/tooltip/tooltip-style.png)

