---
layout: post
title: Liquid Glass Effect in .NET MAUI Sunburst control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfSunburstChart) for stunning UI..
platform: maui
control: SfSunburstChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino sunburst tooltip maui, .net maui chart visualization.
---

# Liquid Glass Effect in .NET MAUI Sunburst Chart

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The liquid glass effect is supported only on `.NET 10` and on `iOS` and `macOS` versions 26 or later

## How it Enhances Chart UI on macOS and iOS

The Liquid Glass Effect enhances chart interactivity with liquid glass effects on tooltips, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Apply Liquid Glass Effect to SfSunburstChart

Wrap the SfSunburstChart inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart surface a glass (blurred or clear) appearance. SfGlassEffectView is available in the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package. To apply the glassy effect to the chart’s tooltips, set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableLiquidGlassEffect) property of SfSunburstChart to `True`.

{% tabs %}

{% highlight xaml %}

<core:SfGlassEffectView CornerRadius="20"
                        Padding="12"
                        EffectType="Regular"
                        EnableShadowEffect="True">

    <chart:SfSunburstChart EnableLiquidGlassEffect="True">
    . . .

    </chart:SfSunburstChart>
</core:SfGlassEffectView>

{% endhighlight %}

{% highlight c# %}

SfSunburstChart chart = new SfSunburstChart();
chart.EnableLiquidGlassEffect = true;

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

### Best Practices and Tips

- Host the chart inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart body a glass appearance.
- Liquid glass effects are most visible over images or colorful backgrounds.
- Set [EffectType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html#Syncfusion_Maui_Core_SfGlassEffectView_EffectType) property of SfGlassEffectView as `Regular` for a blurrier look and `Clear` for a crisper, glassy look.
- Tune CornerRadius and Padding to balance content density and visual polish.
- When using a custom template for tooltip using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_TooltipTemplate), set the background to `Transparent` to display the liquid glass effect.