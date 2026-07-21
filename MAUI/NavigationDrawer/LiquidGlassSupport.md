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

## Overview

The [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) supports a liquid glass effect (also called acrylic or glass morphism) that applies a frosted, translucent style to the drawer pane, allowing the background to show through during interaction.

## Properties

| Property | Type | Default Value | Description |
|----------|------|---------------|-------------|
| [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_EnableLiquidGlassEffect) | `bool` | `false` | Enables or disables the liquid glass effect on the drawer pane. |

## Example

The following code example illustrates how to enable the liquid glass effect on the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html). Place the drawer over a visually rich background (image, gradient, or color block) so the translucent effect is visible.

> **Note** This feature is supported only on `.NET 10` along with `iOS 26` and `macOS 26`. On other platforms (Android, Windows, older iOS/macOS), the property has no effect and the Tab View renders with its default styling.

{% tabs %}

{% highlight xaml %}

<Grid>
    <!-- Background to make the glass effect visible while pressing the navigation drawer -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
    <navigationDrawer:SfNavigationDrawer EnableLiquidGlassEffect="true" />
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

## Behavior

- The glass effect is applied to the Navigation Drawer at render time and remains visible during user interaction.
- The effect is rendered on top of the underlying content, so the background must be visually rich (image, gradient, or color block) for the frosted look to be noticeable.
- Visual output and performance may vary by device and platform; keep backgrounds moderately detailed to maintain clarity during interaction.
- The effect is only applied when the drawer's transition mode is `SlideOn`. For other modes, the effect is ignored.

## Styling tips

For the best visual result, configure the drawer contents to be transparent so the background blends with the glass effect:

| Property | Owner | Recommended Value | Description |
|----------|-------|-------------------|-------------|
| `ContentBackground` | `DrawerSettings` | `Transparent` | Removes the opaque background of the side pane. |
| `Background` | `ContentView` (sample) | `Transparent` | Removes the opaque background of the content view in the sample. |

## Example output

The following GIF demonstrates the liquid glass effect of the Navigation Drawer.

![Liquid Glass effect in .NET MAUI Navigation Drawer](images/LiquidGlass/liquid-glass.gif)

## Accessibility

The liquid glass effect is purely visual and does not alter the drawer's interactive behavior or the information exposed to assistive technologies. Ensure that any text or controls placed on the translucent pane meet standard contrast guidelines for the target platform.

## Troubleshooting

| Issue | Possible cause | Resolution |
|-------|----------------|------------|
| Effect is not visible | The drawer is in a transition mode other than `SlideOn` | Set the transition to `SlideOn` as described in [Toggling the Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer) |
| Effect is not visible | Background is a solid color or has no content | Use a visually rich background (image, gradient, or color block) |
| App crashes on startup | The project is not on .NET 10 or the platform is below iOS 26 / macOS 26 | Upgrade the project to .NET 10 and target iOS 26 / macOS 26 |
| Effect flickers during animation | The drawer's `ContentBackground` is opaque | Set `DrawerSettings.ContentBackground` to `Transparent` |

## See also

- [Getting Started with .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/getting-started)
- [Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)