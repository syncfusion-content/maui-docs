---
layout: post
title: Cupertino Theme in .NET MAUI Polar Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfPolarChart) for stunning UI..
platform: maui
control: SfPolarChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino polar tooltip maui, .net maui chart visualization.
---

# Cupertino Theme in .NET MAUI Polar Chart

The Cupertino theme is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The Cupertino liquid glass effect is only available on macOS and iOS platforms with iOS version 26 or higher.

## How it Enhances Chart UI on macOS and iOS

The Cupertino theme enhances chart interactivity with liquid glass effects on tooltips, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Enable Cupertino Theme

To Enable Cupertino Theme effect by setting `True` to [EnableLiquidGlassEffect]() property of SfPolarChart.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart EnableLiquidGlassEffect="True">
    . . .
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
chart.EnableLiquidGlassEffect = true;
. . .

this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Tooltip

To Enable Cupertino Theme effect to the tooltip, set `True` to [EnableLiquidGlassEffect]() property of SfPolarChart and [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property of ChartSeries.

{% tabs %}

{% highlight xaml %}

<chart:SfPolarChart EnableLiquidGlassEffect="True">
    . . .
    <chart:PolarLineSeries ItemsSource="{Binding Data}" 
                           XBindingPath="Category"
                           YBindingPath="Value"
                           EnableTooltip="True">
    </chart:PolarLineSeries>
</chart:SfPolarChart>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
chart.EnableLiquidGlassEffect = true;
. . .
PolarLineSeries series = new PolarLineSeries()
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Category",
    YBindingPath = "Value",
    EnableTooltip = true
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

N> When using a custom tooltip template using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate), set the background to transparent to display the liquid glass effect.