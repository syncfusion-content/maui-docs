---
layout: post
title: Provide Liquid Glass Support for .NET MAUI ColorPicker | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI ColorPicker (SfColorPicker) control and more.
platform: MAUI
control: SfColorPicker
documentation: ug
---

# Liquid Glass Support for .NET MAUI ColorPicker:

The [SfColorPicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfColorPicker.html) supports a `liquid glass` effect (also called acrylic or glassmorphism) when you enable the `EnableLiquidGlassEffect`. This feature adds a frosted, translucent style that blends with the background, giving the color picker a modern and elegant look. It works best over images or colorful layouts and provides smooth visual feedback during interaction.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the color picker render with the standard appearance.

{% tabs %}
{% highlight xaml %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the color picker -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <colorPicker:SfColorPicker  EnableLiquidGlassEffect="True" />
    </Grid>

{% endhighlight %}
{% highlight c# %}

SfColorPicker colorPicker = new SfColorPicker
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the color picker at render time and during user interaction.
- Place the color picker over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- For an enhanced UI, set `SliderThumbStroke="Transparent"` and `SliderThumbFill="White"` at the sample level for the color picker.
