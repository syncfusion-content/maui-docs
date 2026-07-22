---
layout: post
title: Liquid Glass Support for .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about the liquid glass effect in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Liquid Glass Support for .NET MAUI Navigation Drawer

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Liquid Glass Support

The [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) supports a liquid glass effect (also called acrylic or glass morphism) that applies a frosted, translucent style to the drawer pane, allowing the background to show through during interaction.

For an overview of Liquid Glass across Syncfusion controls, see [Liquid glass integration with Syncfusion® .NET MAUI controls](https://help.syncfusion.com/maui/liquid-glass-ui/glassy-controls).

N> This feature is supported only on `.NET 10` along with `iOS 26` and `macOS 26`

## Enable the Liquid Glass effect

The following code example illustrates how to enable the liquid glass effect on the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html). Place the drawer over a visually rich background (image, gradient, or color block) so the translucent effect is visible.

{% tabs %}
{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the navigation drawer -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
    <navigationDrawer:SfNavigationDrawer EnableLiquidGlassEffect="True" />
</Grid>

{% endhighlight %}
{% highlight c# %}

Grid grid = new Grid
{
    Children =
    {
        new Image
        {
            Source = "wallpaper.jpg",
            Aspect = Aspect.AspectFill
        },
        new SfNavigationDrawer
        {
            EnableLiquidGlassEffect = true
        }
    }
};

{% endhighlight %}
{% endtabs %}

## Behavior and tips

- The glass effect is applied to the Navigation Drawer at render time and during user interaction.
- Place the Navigation Drawer over visually rich content (images, gradients, or color blocks) to better showcase the transient glass effect.
- Visual output and performance may vary by device/platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- For an enhanced UI, set `ContentBackground="Transparent"` for the `DrawerSettings` and `Background="Transparent"` for the `ContentView` at the sample.

The following GIF demonstrates the liquid glass effect of Navigation Drawer.

![Liquid Glass effect in .NET MAUI Navigation Drawer](images/LiquidGlass/liquid-glass.gif)

N> The liquid glass support is only applicable for slide-on mode.

## See also

- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)