---
layout: post
title: Liquid Glass Support for .NET MAUI NavigationDrawer | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI NavigationDrawer (SfNavigationDrawer) control and more.
platform: MAUI
control: SfNavigationDrawer
documentation: ug
---


# Liquid Glass Support for .NET MAUI NavigationDrawer:

The  [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) provides `liquid glass` (acrylic/glass morphism) effect for its navigation drawer when [EnableLiquidGlassEffect]() is enabled. The frosted, translucent effect is applied only while the navigation drawer is in active state, creating a subtle, responsive visual that blends with the content behind it. This enhances visual feedback without altering the navigation drawer's appearance at rest, and works well over images or colorful layouts.

## Availability

1.  Supported on .NET 10 or greater.
2.  Supported on mac or iOS 26 or greater.
3.  On platforms/versions below these requirements, the glass effect is not applied and the navigation drawer render with the standard appearance.

XAML example The navigation drawer's glass effect appears only while it is in active state.

{% tabs %}
{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the navigation drawer -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
    <navigationDrawer:SfNavigationDrawer EnableLiquidGlassEffect="True" />     
</Grid>

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    EnableLiquidGlassEffect = true
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the navigation drawer only during active interactions; at rest, the navigation drawer uses the standard look.
- Place the navigation drawer over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- For an enhanced UI, set `ContentBackground="Transparent"` for the `SfNavigationDrawer` and `Background="Transparent"` at the sample level for the content view.

N> The glass effect is applied to the navigation drawer only while it is in active state.
