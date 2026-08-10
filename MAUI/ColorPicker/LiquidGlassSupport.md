---
layout: post
title: Liquid Glass Support in .NET MAUI Color Picker | Syncfusion®
description: Learn about providing Liquid Glass support for the Syncfusion® .NET MAUI Color Picker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, liquid glass, glass effect, acrylic, glass morphism, EnableLiquidGlassEffect
---

# Liquid Glass Support in .NET MAUI Color Picker

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the [.NET MAUI Color Picker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) control.

## Prerequisites

Before using the [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html), Install the [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/colorpicker/getting-started) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Enable Liquid Glass

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_EnableLiquidGlassEffect) property to `true` to apply the effect. Place the picker over visually rich content (an image, a gradient, or a color block) so the effect is visible.

{% tabs %}

{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the color picker. -->
    <Image Source="wallpaper.jpg" 
           Aspect="AspectFill" />
    <inputs:SfColorPicker EnableLiquidGlassEffect="True" />
</Grid>

{% endhighlight %}

{% highlight c# %}

var grid = new Grid();

// Background to make the glass effect visible while pressing the color picker.
var backgroundImage = new Image
{
    Source = "wallpaper.jpg",
    Aspect = Aspect.AspectFill
};

var colorPicker = new SfColorPicker
{
    EnableLiquidGlassEffect = true
};

grid.Children.Add(backgroundImage);
grid.Children.Add(colorPicker);

this.Content = grid;

{% endhighlight %}

{% endtabs %}

![Liquid Glass effect](Images/LiquidGlass/liquid-glass.gif)

## Behavior

- The glass effect is applied to the picker at render time and remains visible during user interaction (for example, while the user presses or drags a swatch).
- The effect samples pixels from the content rendered behind the picker. Place the picker over visually rich content (images, gradients, or color blocks) to make the effect clearly visible.
- If the background is a single flat color, the effect may be subtle or invisible. Use a textured or multi-color background to showcase the glass effect.
- On unsupported platforms or OS versions, the property is silently ignored and the picker renders with its normal appearance.

## Tips for the best result

- Use a high-contrast, multi-color background image. Avoid flat single-color backgrounds.
- Keep the picker at a reasonable size; the effect is more visible on larger surfaces.
- For an enhanced UI, pair the effect with a subtle border and rounded corners on the host layout.
- Test on a real device or simulator. Visual output and performance may vary by device and platform; keep backgrounds moderately detailed to maintain clarity during interaction.

## See also

* [Customization in .NET MAUI Color Picker](https://help.syncfusion.com/maui/colorpicker/customization)
* [Mode and Value](https://help.syncfusion.com/maui/colorpicker/mode)
* [Display View Customization](https://help.syncfusion.com/maui/colorpicker/display-view)