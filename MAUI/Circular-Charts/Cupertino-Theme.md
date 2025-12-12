---
layout: post
title: Cupertino Theme in .NET MAUI Circular Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfCircularChart) for stunning UI..
platform: maui
control: SfCircularChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino circular tooltip maui, .net maui chart visualization.
---

# Cupertino Theme in .NET MAUI Circular Chart

The Cupertino theme is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The Cupertino liquid glass effect is only available on macOS and iOS platforms with iOS version 26 or higher.

## How it Enhances Chart UI on macOS and iOS

The Cupertino theme enhances chart interactivity with liquid glass effects on tooltips, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Chart Elements Supported for Cupertino Theme

The Cupertino theme support is provided for the following MAUI Circular Chart elements:

- **Tooltip:** Interactive data point information display with liquid glass effect

## Enable Cupertino Theme

To Enable Cupertino Theme effect by setting `True` to [EnableLiquidGlassEffect]() property of SfCircularChart.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart EnableLiquidGlassEffect="True">
    . . .
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
chart.EnableLiquidGlassEffect = true;
. . .

this.Content = chart;

{% endhighlight %}

{% endtabs %}

### Tooltip

To Enable Cupertino Theme effect to the tooltip, set `True` to [EnableLiquidGlassEffect]() property of SfCircularChart and [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property of ChartSeries.

{% tabs %}

{% highlight xaml %}

<chart:SfCircularChart EnableLiquidGlassEffect="True">
    . . .
    <chart:PieSeries ItemsSource="{Binding Data}" 
                     XBindingPath="Category"
                     YBindingPath="Value"
                     EnableTooltip="True">
    </chart:PieSeries>
</chart:SfCircularChart>

{% endhighlight %}

{% highlight c# %}

SfCircularChart chart = new SfCircularChart();
chart.EnableLiquidGlassEffect = true;
. . .
PieSeries series = new PieSeries()
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