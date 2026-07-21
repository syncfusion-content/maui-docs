---
layout: post
title: Liquid Glass Support in .NET MAUI Radial Menu | Syncfusion®
description: Learn how to enable the Liquid Glass visual effect on Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) and customize its appearance.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Liquid Glass Support in .NET MAUI Radial Menu (SfRadialMenu)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.RadialMenu`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/radial-menu/getting-started) documentation.

## Overview

The [`SfRadialMenu`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.html) supports a Liquid Glass visual effect that renders the menu as a translucent blur of the underlying content. Enable it by setting the [`EnableLiquidGlassEffect`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_EnableLiquidGlassEffect) property to `true`. The effect is most visible when the menu overlays colorful content; on platforms or OS versions that do not support it, the menu falls back to its default appearance.

For an overview of Liquid Glass across Syncfusion controls, see [Liquid glass integration with Syncfusion® .NET MAUI controls](https://help.syncfusion.com/maui/liquid-glass-ui/glassy-controls).

> **Note** This feature is supported only on `.NET 10` along with `iOS 26` and `macOS 26`. On other platforms (Android, Windows, older iOS/macOS), the property has no effect and the Tab View renders with its default styling.

## Properties Summary

| Property | Type | Default | Description |
| --- | --- | --- | --- |
| `EnableLiquidGlassEffect` | `bool` | `false` | When `true`, renders the menu with the Liquid Glass blur. Has effect only on iOS 26 and macOS 26. |

## Enable the Liquid Glass effect

The following samples show the minimum code required to enable the Liquid Glass effect. Place the menu inside a layout that has colorful background content (an image, a gradient, or a colored block) so the blur is visible.

{% tabs %}

{% highlight xaml %}

<Grid>
    <!-- Place an image in Resources/Images with the MauiImage build action to act as the background. -->
    <Image Source="wallpaper.jpg" Aspect="AspectFill" />
    <radialMenu:SfRadialMenu EnableLiquidGlassEffect="true" />
</Grid>

{% endhighlight %}

{% highlight C# %}

public MainPage()
{
    InitializeComponent();
    Content = new Grid
    {
        Children =
        {
            new Image { Source = "wallpaper.jpg", Aspect = Aspect.AspectFill },
            new SfRadialMenu { EnableLiquidGlassEffect = true }
        }
    };
}

{% endhighlight %}

{% endtabs %}

## Behavior and tips

- The Liquid Glass effect is applied to the menu while it is open and during user interaction (tap, drag, and press). When the menu is closed, the effect is not visible.
- Place the menu over colorful content (an image, a gradient, or a color block) so the blur is clearly visible. A flat, single-color background produces little visible change.
- On Android and Windows, the property is ignored and the menu uses its default appearance.
- For accessibility, ensure the foreground text contrast remains readable against any background; the blur cannot guarantee WCAG contrast by itself.

The following image demonstrates the liquid glass effect of Radial Menu.

![Liquid Glass effect on a Radial Menu](images/LiquidGlass/liquid-glass.png)

## Troubleshooting

| Issue | Likely cause | Fix |
| --- | --- | --- |
| Effect is not visible. | Running on Android or Windows, or on an OS version earlier than iOS 26 / macOS 26. | The effect is supported only on iOS 26 and macOS 26. On other platforms, the menu falls back to its default appearance. |
| Effect is visible but very subtle. | Background is a flat color, so the blur has nothing to blend with. | Place the menu over an image, a gradient, or a multi-color block. |
| `EnableLiquidGlassEffect` does not compile. | Missing `using Syncfusion.Maui.RadialMenu;` or out-of-date Syncfusion MAUI package. | Update to Syncfusion MAUI 26.1.x or later and import the namespace. |
| Performance drops on older devices. | The blur is GPU-intensive. | Reduce the radius of the radial menu, lower background image resolution, or disable the effect on those devices. |

## See also

- [Getting Started with .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/getting-started)
- [SfRadialMenuItem’s Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization)
- [Segmenting and Placing Items in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/segmenting-placing-items)
- [CenterButton Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/centerbutton-customization)
- [Events in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/events)
- [Placing and Dragging in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/place-and-drag-radialmenu)