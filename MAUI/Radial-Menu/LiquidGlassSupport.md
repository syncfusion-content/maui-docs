---
layout: post
title: Provide Liquid Glass Support for .NET MAUI RadialMenu | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI RadialMenu (SfRadialMenu) control and more.
platform: MAUI
control: SfRadialMenu
documentation: ug
---

# Liquid glass support:

The  [SfRadialMenu](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html) provides `liquid glass` (acrylic/glassmorphism) effect for its radial menu when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the radial menu is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the radial menu's appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the radial menu render with the standard appearance.

XAML example The radial menu's glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the radial menu -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <radialMenu:SfRadialMenu  EnableLiquidGlassEffect="True" />
    </Grid>

{% endhighlight %}
{% highlight c# %}

SfRadialMenu radialMenu = new SfRadialMenu
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the radial menu only during active interactions; at rest, the radial menu uses the standard look.
- Place the radial menu over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.

The following video illustrates SfRadialMenu with the glass effect visible on the radial menu while it is in active state.

![Radial Menu](images/LiquidGlass/liquid-glass.gif)

N> The glass effect is applied to the radial menu only while it is in active state.
