---
layout: post
title: Liquid Glass Effect in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about the liquid glass effect in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Liquid Glass Effect in .NET MAUI Navigation Drawer

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass-like user experience that remains clear and accessible while maintaining readable contrast. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control.

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), Install the [Syncfusion.Maui.NavigationDrawer](https://www.nuget.org/packages/Syncfusion.Maui.NavigationDrawer) and [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) NuGet packages in your .NET MAUI project. The `Syncfusion.Maui.Core` package is required for the [SfGlassEffectView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfGlassEffectView.html) container used to host the Liquid Glass Effect.

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

N>
* The Liquid Glass Effect is supported only on **.NET 10** targeting **macOS 26 or higher** and **iOS 26 or higher**.
* It is not supported on Android or Windows.

## Enable the Liquid Glass effect

The following code example illustrates how to enable the liquid glass effect on the `Navigation Drawer`. Place the drawer over a visually rich background (image, gradient, or color block) so the translucent effect is visible.

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