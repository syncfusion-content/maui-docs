---
layout: post
title: Liquid Glass Effect in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Chart (SfCartesianChart) for stunning UI..
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino cartesian tooltip maui, .net maui chart visualization, cupertino cartesian trackball maui.
---

# Liquid Glass Effect in .NET MAUI Cartesian Chart

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> The liquid glass effect is only available on macOS and iOS platforms with version 26 or higher.

## How it Enhances Chart UI on macOS and iOS

The Liquid Glass Effect enhances chart interactivity with liquid glass effects on tooltips and trackballs, creating a modern and visually appealing data visualization interface that delivers a sophisticated user experience.

## Apply Liquid Glass Effect to SfCartesianChart

Wrap the SfCartesianChart inside an [SfGlassEffectsView]() to give the chart surface a glass (blurred or clear) appearance. SfGlassEffectsView is available in the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package. To apply the glassy effect to the chart’s tooltips and trackballs, set the [EnableLiquidGlassEffect]() property of SfCartesianChart to `True`.

{% tabs %}

{% highlight xaml %}

<core:SfGlassEffectsView CornerRadius="20"
                         Padding="12"
                         EffectType="Regular"
                         EnableShadowEffect="True">

    <chart:SfCartesianChart EnableLiquidGlassEffect="True">
        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis />
        </chart:SfCartesianChart.XAxes>
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.YAxes>

        <!-- Add your series here -->
        <chart:ColumnSeries
            ItemsSource="{Binding Data}"
            XBindingPath="Category"
            YBindingPath="Value" />
    </chart:SfCartesianChart>
</core:SfGlassEffectsView>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
chart.EnableLiquidGlassEffect = true;
chart.XAxes.Add(new CategoryAxis());
chart.YAxes.Add(new NumericalAxis());
chart.Series.Add(new ColumnSeries
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
    Content = chart
};

{% endhighlight %}

{% endtabs %}

### Key Properties

- [EffectType](): Chooses the visual style (Regular or Clear).
- [CornerRadius](): Rounds the container edges for a polished look.
- [EnableShadowEffect](): Adds a subtle drop shadow to enhance depth.
- [EnableLiquidGlassEffect](): Enables the glass effect for the chart's tooltip and trackballs.

### Best Practices and Tips

- Host the chart inside an [SfGlassEffectsView]() to give the chart body a glass appearance.
- Liquid glass effects are most visible over images or colorful backgrounds.
- Use EffectType="Regular" for a blurrier look and EffectType="Clear" for a crisper, glassy look.
- Tune CornerRadius and Padding to balance content density and visual polish.
- When using a custom template for tooltip and trackball using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) and [TrackballLabelTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_TrackballLabelTemplate), set the background to `Transparent` to display the liquid glass effect.