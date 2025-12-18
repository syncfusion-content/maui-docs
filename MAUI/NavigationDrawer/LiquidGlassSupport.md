---
layout: post
title: Liquid Glass Support for .NET MAUI NavigationDrawer | Syncfusion®
description: Learn here about providing liquid glass support for Syncfusion® .NET MAUI NavigationDrawer (SfNavigationDrawer) control and more.
platform: MAUI
control: SfNavigationDrawer
documentation: ug
---


# Liquid Glass Support for .NET MAUI NavigationDrawer

The [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) supports a `liquid glass` effect (also called acrylic or glass morphism) when you enable the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect). This feature adds a frosted, translucent style that blends with the background, giving the Navigation Drawer a modern and elegant look.

N>
* This feature is supported only on `.NET 10` along with `iOS 26` and `macOS 26` .

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

- The glass effect is applied to the Navigation Drawer at render time and during user interaction.
- Place the Navigation Drawer over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- For an enhanced UI, set `ContentBackground="Transparent"` for the `DrawerSettings` and `Background="Transparent"` for the `ContentView` at the sample .

The following GIF demonstrates the liquid glass effect of Navigation Drawer.

![Liquid Glass](images/LiquidGlass/liquid-glass.gif)

N> The liquid glass support is only applicable for slide-on mode.
