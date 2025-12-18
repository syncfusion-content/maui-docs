---
layout: post
title: Liquid Glass Effect for .NET MAUI TreeView Control | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI TreeView (SfTreeView) control.
platform: MAUI
control: SfAIAssistView
documentation: ug
---

# Liquid Glass Effect in .NET MAUI TreeView (SfTreeView)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI TreeView (SfTreeView) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the TreeView control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `TreeView ` control, wrap the control inside the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on TreeView 

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableLiquidGlassEffect) property to `true` in the `SfTreeView` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the TreeView  control to maintain the desired translucent appearance, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfTreeView` control:

{% tabs %}
{% highlight xaml hl_lines="2 5" %}

<Grid Background="#FF54A3CD">
    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <treeView:SfTreeView x:Name="treeView"
                             Background="Transparent"
                             EnableLiquidGlassEffect="True"/>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# hl_lines="14 23" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.TreeView;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var grid = new Grid
        {
            Background = Color.FromArgb("#FF54A3CD")
        };

        var glassView = new SfGlassEffectView
        {
            CornerRadius = 20,
            EffectType = LiquidGlassEffectType.Regular
        };

        var treeView = new SfTreeView
        {
            Background = Colors.Transparent,
            EnableLiquidGlassEffect = true,
        };

        glassView.Content = treeView;
        grid.Children.Add(glassView);
        this.Content = grid;
    }
}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`