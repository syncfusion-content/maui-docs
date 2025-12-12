---
layout: post
title: Provide Liquid Glass Support for .NET MAUI ColorPicker | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI ColorPicker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: ug
---


# Liquid glass support:

The  [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) provides `liquid glass` (acrylic/glassmorphism) effect for its color picker when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the color picker is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the color picker’s appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the color picker render with the standard appearance.

XAML example The color picker’s glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the color picker -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <colorPicker:SfColorPicker  EnableLiquidGlassEffect="True" />
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Sliders;

SfColorPicker colorPicker = new SfColorPicker
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the color picker only during active interactions; at rest, the color picker uses the standard look.
- Place the color picker over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- For an enhanced UI, set `SliderThumbStroke="Transparent"` at the sample level for the color picker.

The following screenshot illustrates SfColorPicker with the glass effect visible on the color picker while it is in active state.

N> The glass effect is applied to the color picker only while it is in active state.
