---
layout: post
title: Cupertino Theme in .NET MAUI Pyramid Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfPyramidChart) for stunning UI..
platform: maui
control: SfPyramidChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino pyramid tooltip maui, .net maui chart visualization.
---

# Cupertino Theme in .NET MAUI Pyramid Chart

The Cupertino theme is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The Cupertino liquid glass effect is only available on macOS and iOS platforms with iOS version 26 or higher.

## How it Enhances Chart UI on macOS and iOS

The Cupertino theme enhances chart interactivity with liquid glass effects on tooltips, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Enable Cupertino Theme

To Enable Cupertino Theme effect by setting `True` to [EnableLiquidGlassEffect]() property of SfPyramidChart

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart EnableLiquidGlassEffect="True">
    . . .
</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
chart.EnableLiquidGlassEffect = true;
. . .

this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Tooltip

To Enable Cupertino Theme effect to the tooltip, set `True` to [EnableLiquidGlassEffect]() property and [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_EnableTooltip) property of SfPyramidChart.

{% tabs %}

{% highlight xaml %}

<chart:SfPyramidChart EnableLiquidGlassEffect="True"
                      EnableTooltip="True">
. . .

</chart:SfPyramidChart>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();
chart.EnableLiquidGlassEffect = true;
chart.EnableTooltip = true;
. . .

this.Content = chart;

{% endhighlight %}

{% endtabs %}

N> When using a custom tooltip template using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_TooltipTemplate), set the background to transparent to display the liquid glass effect.
