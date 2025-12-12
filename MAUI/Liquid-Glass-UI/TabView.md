---
layout: post
title: Provide Liquid Glass Support for .NET MAUI TabView | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI TabView (SfTabView) control and more.
platform: MAUI
control: SfTabView
documentation: ug
---


# Liquid glass support:

The  [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html?tabs=tabid-1) provides `liquid glass` (acrylic/glassmorphism) effect for its tabview when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the tabview is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the tabview’s appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the tabview render with the standard appearance.

XAML example The tabview’s glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml hl_lines="49 52" %}

    <Grid>
        <!-- Background to make the glass effect visible while pressing the tabview -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />
        <tabview:SfTabView EnableLiquidGlassEffect="True" />
    </Grid>

{% endhighlight %}
{% highlight c# hl_lines="74 77" %}

using Syncfusion.Maui.Sliders;

SfTabView tabView = new SfTabView
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the tabview only during active interactions; at rest, the tabview uses the standard look.
- Place the tabview over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.

The following screenshot illustrates SfTabView with the glass effect visible on the tabview while it is in active state.

N> The glass effect is applied to the tabview only while it is in active state.
