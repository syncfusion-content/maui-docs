---
layout: post
title: Liquid Glass Effect in .NET MAUI Polar Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfPolarChart) for stunning UI..
platform: maui
control: SfPolarChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino polar tooltip maui, .net maui chart visualization.
---

# Liquid Glass Effect in .NET MAUI Polar Chart

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The liquid glass effect is only available on macOS and iOS platforms with iOS version 26 or higher.

## How it Enhances Chart UI on macOS and iOS

The Liquid Glass Effect enhances chart interactivity with liquid glass effects on tooltips, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Apply Liquid Glass Effect to SfPolarChart

Wrap the SfPolarChart inside an [SfGlassEffectsView]() to give the chart surface a glass (blurred or clear) appearance. Enable the liquid glass effect to get a sleek, glassy output. SfGlassEffectsView available in [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package.

{% tabs %}

{% highlight xaml %}

<core:SfGlassEffectsView CornerRadius="20"
                         Padding="12"
                         EffectType="Regular"
                         EnableShadowEffect="True">

    <chart:SfPolarChart EnableLiquidGlassEffect="True">
        <chart:SfPolarChart.PrimaryAxis>
            <chart:CategoryAxis />
        </chart:SfPolarChart.PrimaryAxis>
        <chart:SfPolarChart.SecondaryAxis>
            <chart:NumericalAxis />
        </chart:SfPolarChart.SecondaryAxis>

        <!-- Add your series here -->
        <chart:PolarLineSeries
            ItemsSource="{Binding Data}"
            XBindingPath="Category"
            YBindingPath="Value" />
    </chart:SfPolarChart>
</core:SfGlassEffectsView>

{% endhighlight %}

{% highlight c# %}

SfPolarChart chart = new SfPolarChart();
chart.EnableLiquidGlassEffect = true;

CategoryAxis primaryAxis = new CategoryAxis();
chart.PrimaryAxis = primaryAxis;

NumericalAxis secondaryAxis = new NumericalAxis();
chart.SecondaryAxis = secondaryAxis;

chart.Series.Add(new PolarLineSeries
{
    ItemsSource = viewModel.Data,
    XBindingPath = "Category",
    YBindingPath = "Value"
});

var glass = new SfGlassEffectsView
{
    CornerRadius = 20,
    Padding = 12,
    EffectType = GlassEffectType.Regular, // Regular (blurrier) or Clear (glassy)
    EnableShadowEffect = true,
    LiquidGlassEffect = true,
    Content = chart
};

{% endhighlight %}

{% endtabs %}

### Key Properties

- [EffectType](): Chooses the visual style (Regular or Clear).
- [CornerRadius](): Rounds the container edges for a polished look.
- [EnableShadowEffect](): Adds a subtle drop shadow to enhance depth.
- [EnableLiquidGlassEffect](): Enables the glass effect for the chart's tooltip.

### Best Practices and Tips

- Hosting the chart inside [SfGlassEffectsView]() gives the chart body an acrylic look.
- Liquid glass effects are most visible over images or colorful backgrounds.
- Use EffectType="Regular" for a blurrier look and EffectType="Clear" for a crisper, glassy look.
- Tune CornerRadius and Padding to balance content density and visual polish.
- When using a custom template for tooltip using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate), set the background to transparent to display the liquid glass effect.