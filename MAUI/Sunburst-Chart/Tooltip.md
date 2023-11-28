---
layout: post
title: Tooltip in .NET MAUI Chart control | Syncfusion
description: This section explains about how to enable tooltip in Syncfusion .NET MAUI Chart (SfSunburstChart) control
platform: maui
control: SfSunburstChart
documentation: ug
---

# Tooltip in .NET MAUI Chart

Tooltip provides additional information about the segments in the sunburst chart. Tooltip is displayed by tapping the segment. By default, tooltip displays the corresponding segment’s category and value. To enable the tooltip, set the [EnableTooltip]() property to true.

## Enable Tooltip

To define the tooltip in the chart, set the [EnableTooltip]() property of [SfSunburstChart]() to true.

{% tabs %}

{% highlight xaml %}

    <chart:SfSunburstChart EnableTooltip="True">
    . . .
    </chart:SfSunburstChart>


{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .      
    chart.EnableTooltip = true;

{% endhighlight %}

{% endtabs %}

![Tooltip support in MAUI chart]()

## customization

The appearance of the tooltip can be customized using the following properties:

* [Background]() of type `Brush`, indicates background color to the tooltip label.
* [FontAttributes]() of type `FontAttributes`, indicates the font style of * the label.
* [FontFamily]() of type `string`, indicates the font family for the label.
* [FontSize]() of type `float`, indicates the font size.
* [Duration]() of type `int`, indicates the duration for displaying the tooltip.
* [Margin]() of type `Thickness`, indicates the label’s margin.
* [TextColor]() of type `Color`, indicates the color of the displayed text.

{% tabs %}

{% highlight xml %}

    <chart:SfSunburstChart EnableTooltip="True">
    . . .
        <chart:SfSunburstChart.TooltipSettings>
            <chart:SunburstTooltipSettings  TextColor="Black" 
                                            Margin="10"
                                            FontSize="10"
                                            Background="Green" 
                                            Duration="4" />
        </chart:SfSunburstChart.TooltipSettings>
    . . .
    
{% endhighlight %}

{% highlight c# %}

    SfSunburstChart chart = new SfSunburstChart();
    . . .
    chart.EnableTooltip = true;
    SunburstTooltipSettings tooltipSettings = new SunburstTooltipSettings();
    tooltipSettings.TextColor = Colors.White;
    tooltipSettings.Background = Brush.Green;          
    tooltipSettings.Duration = 10;
    sunburstChart.TooltipSettings = tooltipSettings;
    . . .

{% endhighlight %}

{% endtabs %}


