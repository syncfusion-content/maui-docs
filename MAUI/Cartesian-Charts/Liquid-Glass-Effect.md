---
layout: post
title: Liquid Glass Effect in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn how to enable and customize the Liquid Glass visual effect in Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) for stunning UI.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui chart, cupertino theme, glass effect, maui cupertino chart, cupertino cartesian tooltip maui, .net maui chart visualization, cupertino cartesian trackball maui.
---

# Liquid Glass Effect in .NET MAUI Cartesian Chart

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners and sophisticated visual treatments that create a polished, professional look for your charts.

N> **Prerequisite:** 
- Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **SfCartesianChart** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/cartesian-charts/getting-started)** guide.
- To use **SfGlassEffectView**, ensure that the Syncfusion.Maui.Core package is installed and import the Syncfusion.Maui.Core namespace.

N> The liquid glass effect is supported only on `.NET 10` and on `iOS` and `macOS` versions 26 or later.

## How it enhances chart UI on macOS and iOS

The Liquid Glass Effect enhances MAUI [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) with a sleek, glassy look and improved interactivity.

- **Tooltip:** Applies a glassy appearance to tooltips for clearer data highlights.
- **Trackball:** Adds a glassy style to trackball labels for precise value inspection.
- **Chart Background:** Wrap the chart in an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart surface a blurred or clear glass background.

## Apply Liquid Glass Effect to SfCartesianChart Background

Wrap the [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart surface a glass (blurred or clear) appearance. `SfGlassEffectView` is available in the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package.

{% tabs %}

{% highlight xaml %}

<core:SfGlassEffectView CornerRadius="20"
                        Padding="12"
                        EffectType="Regular"
                        EnableShadowEffect="True">

    <chart:SfCartesianChart>

        <chart:SfCartesianChart.XAxes>
            <chart:CategoryAxis />
        </chart:SfCartesianChart.XAxes>
        <chart:SfCartesianChart.YAxes>
            <chart:NumericalAxis />
        </chart:SfCartesianChart.YAxes>

        <chart:ColumnSeries
            ItemsSource="{Binding Data}"
            XBindingPath="Category"
            YBindingPath="Value" />

    </chart:SfCartesianChart>
</core:SfGlassEffectView>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();

chart.XAxes.Add(new CategoryAxis());
chart.YAxes.Add(new NumericalAxis());

chart.Series.Add(new ColumnSeries
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Category",
    YBindingPath = "Value"
});

var glass = new SfGlassEffectView
{
    CornerRadius = 20,
    Padding = 12,
    EffectType = GlassEffectType.Regular, // Regular (blurrier) or Clear (glassy)
    EnableShadowEffect = true,
    Content = chart
};

this.Content = glass;

{% endhighlight %}

{% endtabs %}

For detailed guidance on [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html), refer to the Getting Started [documentation](https://help.syncfusion.com/maui/liquid-glass-ui/getting-started).

## Enable Liquid Glass effect to SfCartesianChart elements

### Tooltip

To enable the Liquid Glass effect for the tooltip, set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_EnableLiquidGlassEffect) property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) to `true` and the [EnableTooltip](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip) property of `ChartSeries` to `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart EnableLiquidGlassEffect="True">
    <!-- code omitted for brevity -->
    <chart:ColumnSeries ItemsSource="{Binding Data}" 
                        XBindingPath="Category"
                        YBindingPath="Value"
                        EnableTooltip="True">
    </chart:ColumnSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
chart.EnableLiquidGlassEffect = true;
//code omitted for brevity
ColumnSeries series = new ColumnSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Category",
    YBindingPath = "Value",
    EnableTooltip = true
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Column chart with liquid glass tooltip in .NET MAUI Cartesian Chart](Liquid-Glass-Images/column_liquid_tooltip.png)

### Trackball

To enable the Liquid Glass effect for the trackball, set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_EnableLiquidGlassEffect) property of [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) to `true` and the [ShowTrackballLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_ShowTrackballLabel) property of `ChartSeries` to `true`.

{% tabs %}

{% highlight xaml %}

<chart:SfCartesianChart EnableLiquidGlassEffect="True">
    <!-- code omitted for brevity -->
    <chart:LineSeries ItemsSource="{Binding Data}" 
                      XBindingPath="Category"
                      YBindingPath="Value"
                      ShowTrackballLabel="True">
    </chart:LineSeries>
</chart:SfCartesianChart>

{% endhighlight %}

{% highlight c# %}

SfCartesianChart chart = new SfCartesianChart();
chart.EnableLiquidGlassEffect = true;
//code omitted for brevity
LineSeries series = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Category",
    YBindingPath = "Value",
    ShowTrackballLabel = true
};

chart.Series.Add(series);
this.Content = chart;

{% endhighlight %}

{% endtabs %}

![Line chart with liquid glass trackball in .NET MAUI Cartesian Chart](Liquid-Glass-Images/line_liquid_trackball.png)

### Best practices and tips

- Host the chart inside an [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) to give the chart body a glass appearance.
- Liquid glass effects are most visible over images or colorful backgrounds.
- Set [EffectType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html#Syncfusion_Maui_Core_SfGlassEffectView_EffectType) property of [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) as `Regular` for a blurrier look and `Clear` for a crisper, glassy look.
- Tune CornerRadius and Padding to balance content density and visual polish.
- When using a custom template for tooltip and trackball using [TooltipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate) and [TrackballLabelTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CartesianSeries.html#Syncfusion_Maui_Charts_CartesianSeries_TrackballLabelTemplate), set the background to `Transparent` to display the liquid glass effect.