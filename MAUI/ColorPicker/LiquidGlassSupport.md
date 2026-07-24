---
layout: post
title: Provide Liquid Glass Support for the .NET MAUI ColorPicker | Syncfusion®
description: Learn about providing Liquid Glass support for the Syncfusion® .NET MAUI ColorPicker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: UG
keywords : .net maui color picker, maui color picker, liquid glass, glass effect, acrylic, glass morphism, EnableLiquidGlassEffect
---

# Liquid Glass Support for the .NET MAUI ColorPicker

The [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) supports an optional **Liquid Glass** effect — a frosted, translucent style (analogous to acrylic on Windows or glass morphism on the web) that blends the picker with whatever is rendered behind it. When enabled, the picker picks up color from the background and shows subtle, smooth visual feedback during interaction. The effect is most visible over images, gradients, or colorful layouts.

N> **Platform support:** The Liquid Glass effect requires **.NET 10** and is supported on **iOS 26** and **macOS 26**. On other platforms, or when the minimum OS/SDK is not met, the property is ignored and the picker renders normally.

## Enable Liquid Glass

Set the [`EnableLiquidGlassEffect`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html#Syncfusion_Maui_Inputs_SfColorPicker_EnableLiquidGlassEffect) property to `true` to apply the effect. Place the picker over visually rich content (an image, a gradient, or a color block) so the effect is visible.

{% tabs %}

{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the color picker. -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
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
