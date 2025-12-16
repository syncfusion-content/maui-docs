---
layout: post
title: Liquid Glass Effect in .NET MAUI Pyramid Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfPyramidChart) for stunning UI..
platform: maui
control: SfPyramidChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino pyramid tooltip maui, .net maui chart visualization.
---

# Liquid Glass Effect in .NET MAUI Pyramid Chart

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The liquid glass effect is supported only on `.NET 10` and on `iOS` and `macOS` versions 26 or later

## How it Enhances Chart UI on macOS and iOS

The Liquid Glass Effect enhances MAUI SfPyramidChart with a sleek, glassy look and improved interactivity.

**Tooltip:** Applies a glassy appearance to tooltips for clearer data highlights.
**Chart Background:** Wrap the chart in an SfGlassEffectView to give the chart surface a blurred or clear glass background.

## Apply Liquid Glass Effect to SfPyramidChart

Wrap the SfPyramidChart inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart surface a glass (blurred or clear) appearance. SfGlassEffectView is available in the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package.

{% tabs %}

{% highlight xaml %}

<core:SfGlassEffectView CornerRadius="20"
                        Padding="12"
                        EffectType="Regular"
                        EnableShadowEffect="True">

    <chart:SfPyramidChart/>
</core:SfGlassEffectView>

{% endhighlight %}

{% highlight c# %}

SfPyramidChart chart = new SfPyramidChart();

var glass = new SfGlassEffectView
{
    CornerRadius = 20,
    Padding = 12,
    EffectType = GlassEffectType.Regular, // Regular (blurrier) or Clear (glassy)
    EnableShadowEffect = true,
    Content = chart
};

{% endhighlight %}

{% endtabs %}

For detailed guidance on SfGlassEffectView, refer to the Getting Started [documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

### Enable Liquid Glass Effect to SfPyramidChart Tooltip

To Enable Liquid Glass Effect to the tooltip, set `True` to [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_EnableLiquidGlassEffect) property and [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_EnableTooltip) property of SfPyramidChart.

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

![Pyramid Chart with Liquid Glass Tooltip](Liquid-Glass-Images/pyramid_liquid_tooltip.png)

### Best Practices and Tips

- Host the chart inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart body a glass appearance.
- Liquid glass effects are most visible over images or colorful backgrounds.
- Set [EffectType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html#Syncfusion_Maui_Core_SfGlassEffectView_EffectType) property of SfGlassEffectView as `Regular` for a blurrier look and `Clear` for a crisper, glassy look.
- Tune CornerRadius and Padding to balance content density and visual polish.
- When using a custom template for tooltip using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_TooltipTemplate), set the background to `Transparent` to display the liquid glass effect.