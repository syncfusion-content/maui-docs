---
layout: post
title: Liquid Glass Support in .NET MAUI Switch | Syncfusion®
description: Learn how to enable the Liquid Glass effect in the Syncfusion® .NET MAUI Switch (SfSwitch) control to render a modern glass UI.
platform: MAUI
control: SfSwitch
documentation: UG
---

# Liquid Glass Support in .NET MAUI Switch

## Prerequisites

Before using the [`SfSwitch`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html), Install the [Syncfusion.Maui.Buttons](https://www.nuget.org/packages/Syncfusion.Maui.Buttons) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/switch/getting-started) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Overview

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains readable on top of any background. This section explains how to enable and customize the effect in the [SfSwitch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) control.

## Apply the liquid glass effect

The `SfSwitch` control renders a glass (also called acrylic or glass morphism) effect on the track and thumb when the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_EnableLiquidGlassEffect) property is set to `true`. The effect is visible against vibrant images or colorful backgrounds and updates on user interaction.

* [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_EnableLiquidGlassEffect): A `bool` property that enables the Liquid Glass effect on the Switch. The default value is `false`.

{% tabs %}
{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the switch -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
    <syncfusion:SfSwitch x:Name="sfSwitch" 
                         EnableLiquidGlassEffect="True" />
</Grid>

{% endhighlight %}
{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch
{
    EnableLiquidGlassEffect = true
};
this.Content = sfSwitch;

{% endhighlight %}
{% endtabs %}

## Behavior

- The glass effect is applied during rendering and on every user interaction.
- The effect is most visible when the Switch is placed over visually rich content such as images, gradients, or color blocks.
- The Liquid Glass effect can be combined with the [SwitchSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html) properties, and the [AllowIndeterminateState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState) property.

## Tips

- Use an image with sufficient detail so that the glass effect is noticeable. A solid color background will hide the effect.
- Keep background file sizes reasonable to avoid affecting the app's memory usage on mobile devices.
- Verify the effect on a physical iOS or macOS device, since the simulator may render glass effects differently.

The following GIF demonstrates the Liquid Glass effect on the Switch.

![Liquid Glass](Images/LiquidGlass/liquid-glass.gif)

## See Also

- [Customization in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/customization)
- [States in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/states)
- [Visual state manager in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/visual-state-manager)