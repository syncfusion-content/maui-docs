---
layout: post
title: Liquid Glass Effect for .NET MAUI Chat Control | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Chat (SfChat) control.
platform: MAUI
control: SfChat
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Chat (SfChat)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Chat (SfChat) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Chat control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `Chat` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Enable the liquid glass effect on Chat

Set the `EnableLiquidGlassEffect` property to `true` in the `SfChat` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Chat control to maintain the desired translucent appearance, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the `SfChat` control:

{% tabs %}
{% highlight xaml hl_lines="2 6" %}

<Grid Background="#FF54A3CD">
    <core:SfGlassEffectView EffectType="Regular"
                            CornerRadius="20">
        <chat:SfChat x:Name="chat"
                     Background="Transparent"
                     EnableLiquidGlassEffect="True">
        </chat:SfChat>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# hl_lines="14 23" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Chat;

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

        var chat = new SfChat
        {
            Background = Colors.Transparent,
            EnableLiquidGlassEffect = true,
        };

        glassView.Content = chat;
        grid.Children.Add(glassView);
        this.Content = grid;
    }
}

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`