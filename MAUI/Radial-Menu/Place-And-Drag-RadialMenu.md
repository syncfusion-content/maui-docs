---
layout: post
title: Placing and Dragging in .NET MAUI Radial Menu | Syncfusion®
description: Learn how to place and drag the Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) and how to use the related drag events.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Placing and Dragging in .NET MAUI Radial Menu (SfRadialMenu)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.RadialMenu`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/radial-menu/getting-started) documentation.

## Overview

You can place the Radial Menu anywhere on its parent layout and drag it within that layout. The default position is the center of the parent; set the [`Point`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Point) property to override that. Enable dragging with the [`IsDragEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_IsDragEnabled) property and react to drag start / end with the [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) and [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragEnd) events.

## Properties Summary

| Property | Type | Default | Description |
| --- | --- | --- | --- |
| `Point` | `Microsoft.Maui.Graphics.Point` | `(-1, -1)` (centered) | Position of the menu in device-independent units (DIUs), relative to the parent layout. |
| `IsDragEnabled` | `bool` | `false` | When `true`, allows the user to drag the menu inside its parent layout. |
| `EnableRotation` | `bool` | `true` | When `true`, the rim rotates as the user drags around the center button. |

## Dragging Radial Menu

You can enable or disable dragging by using the [`IsDragEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_IsDragEnabled) property. When dragging is enabled, the user can grab the rim and move the menu within its parent layout. The center button is not the drag handle — only the rim responds to drag gestures.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu x:Name="radialMenu"
                            IsDragEnabled="true"
                            CenterButtonText="&#xe710;"
                            CenterButtonFontFamily="Maui Material Assets"
                            CenterButtonRadius="30"
                            CenterButtonFontSize="26"
                            CenterButtonBorderThickness="3">
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    IsDragEnabled = true,
    CenterButtonText = "\ue710",
    CenterButtonFontFamily = "Maui Material Assets",
    CenterButtonRadius = 30,
    CenterButtonFontSize = 26,
    CenterButtonBorderThickness = 3
};

{% endhighlight %}

{% endtabs %}

![Dragging Radial Menu](images/placing-dragging/maui-radialmenu-dragging.png)

## Rotation

The rim of the Radial Menu can rotate as the user drags around the center button. Use the [`EnableRotation`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_EnableRotation) property to enable or disable this visual behavior. Rotation is independent of `IsDragEnabled` — you can disable rotation while keeping drag-to-move enabled, and vice versa.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu x:Name="radialMenu"
                        EnableRotation="false" />
   

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    EnableRotation = false
};

{% endhighlight %}

{% endtabs %}

## Placing the Radial Menu

You can place the Radial Menu at a specific position on its parent layout by setting the [`Point`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Point) property. The value is measured in device-independent units (DIUs) and is interpreted relative to the parent layout's top-left corner. When `Point` is left at its default value, the menu is centered on the parent layout.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu x:Name="radialMenu"
                                Point="100,150"
                                CenterButtonText="&#xe710;"
                                CenterButtonFontFamily="Maui Material Assets"
                                CenterButtonRadius="30"
                                CenterButtonFontSize="26"
                                CenterButtonTextColor="White"
                                CenterButtonStroke="White"
                                CenterButtonStrokeThickness="3">
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    CenterButtonText = "\ue710",
    CenterButtonFontFamily = "Maui Material Assets",
    CenterButtonRadius = 30,
    CenterButtonFontSize = 26,
    CenterButtonTextColor = Colors.White,
    CenterButtonStroke = Colors.White,
    CenterButtonStrokeThickness = 3,
    Point = new Point(100, 150)
};
            
{% endhighlight %}

{% endtabs %}


## Handle drag events

`SfRadialMenu` raises two events while the user drags the menu: [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) fires when the drag starts, and [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragEnd) fires when it ends. Both events are only raised when `IsDragEnabled` is `true`.

### DragBegin event

This event is raised when the user starts to drag the Radial Menu. The handler receives a [`DragBeginEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html) instance.

| `DragBeginEventArgs` property | Description |
| --- | --- |
| `Position` | The starting position of the menu when the drag began (in DIUs, relative to the parent layout). |
| `Handled` | Gets or sets a boolean. Set to `true` to cancel the drag — the menu will stay at its current position. |

The following sample shows how to read the start position and cancel the drag.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu x:Name="radialMenu"
                            DragBegin="RadialMenu_DragBegin"
                            IsDragEnabled="true"
                            CenterButtonText="&#xe710;"
                            CenterButtonFontFamily="Maui Material Assets"
                            CenterButtonRadius="30"
                            CenterButtonFontSize="26"
                            CenterButtonBorderThickness="3">
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    IsDragEnabled = true,
    CenterButtonText = "\ue710",
    CenterButtonFontFamily = "Maui Material Assets",
    CenterButtonRadius = 30,
    CenterButtonFontSize = 26,
    CenterButtonBorderThickness = 3
};

radialMenu.DragBegin += RadialMenu_DragBegin;

private void RadialMenu_DragBegin(object sender, DragBeginEventArgs e)
{
    // e.Position is the start position; e.Handled = true cancels the drag.
    System.Diagnostics.Debug.WriteLine($"Drag started at {e.Position}");
    if (e.Position.X < 0)
    {
        e.Handled = true;
    }
}

{% endhighlight %}
{% endtabs %}

### DragEnd event

This event is raised when the drag ends. The handler receives a [`DragEndEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html) instance.

| `DragEndEventArgs` property | Description |
| --- | --- |
| `OldValue` | The position of the menu when the drag started (the start point). |
| `NewValue` | The position of the menu when the drag ended (the end point). |
| `Handled` | Gets or sets a boolean. Set to `true` to prevent the menu from moving to `NewValue` — the menu will stay at `OldValue`. |

The following sample shows how to read both positions and reject moves outside a target rectangle.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu x:Name="radialMenu"
                            IsDragEnabled="true"
                            DragEnd="RadialMenu_DragEnd"
                            CenterButtonText="&#xe710;"
                            CenterButtonFontFamily="Maui Material Assets"
                            CenterButtonRadius="30"
                            CenterButtonFontSize="26"
                            CenterButtonTextColor="White"
                            CenterButtonStroke="White"
                            CenterButtonStrokeThickness="3">
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    IsDragEnabled = true,
    CenterButtonText = "\ue710",
    CenterButtonFontFamily = "Maui Material Assets",
    CenterButtonRadius = 30,
    CenterButtonFontSize = 26,
    CenterButtonBorderThickness = 3
};

radialMenu.DragEnd += RadialMenu_DragEnd;

private void RadialMenu_DragEnd(object sender, DragEndEventArgs e)
{
    // e.OldValue is the start point; e.NewValue is the end point.
    // e.Handled = true keeps the menu at e.OldValue.
    System.Diagnostics.Debug.WriteLine($"Dragged from {e.OldValue} to {e.NewValue}");
    if (e.NewValue.X < 0 || e.NewValue.Y < 0)
    {
        e.Handled = true;
    }
}

{% endhighlight %}
{% endtabs %}

## Troubleshooting

| Issue | Likely cause | Fix |
| --- | --- | --- |
| Dragging does not work. | `IsDragEnabled` is `false` (the default), or the menu is wrapped in a layout that consumes gestures (e.g., a `ScrollView` or a `CollectionView`). | Set `IsDragEnabled` to `true` and place the menu in a non-scrolling parent such as `Grid` or `AbsoluteLayout`. |
| The center button is not the drag handle. | Only the rim responds to drag gestures. | Drag the rim, not the center button. |
| `Point` has no effect. | The parent layout resets child positions (e.g., `StackLayout`), or the value is set after the menu is rendered. | Place the menu in `Grid` or `AbsoluteLayout` and set `Point` before the menu is added to the visual tree. |
| `e.Handled = true;` does not cancel the drag. | The property is set in the wrong event (`DragEnd` instead of `DragBegin`, or vice versa). | Use `DragBegin` to cancel a drag that has not started, and `DragEnd` to roll back the move after it has finished. |
| `Point` is missing in C# sample. | Missing `using Microsoft.Maui.Graphics;`. | Add the `using` directive. |
| Icon character (`&#xe710;`) appears as literal text. | The `Maui Material Assets` font is not registered. | Add the `.ttf` to `Resources/Fonts/`, set the build action to `MauiFont`, and register it in `MauiProgram.cs`. |
| `CenterButtonBorderColor` does not exist. | The property is named `CenterButtonStroke`. | Use `CenterButtonStroke` and `CenterButtonStrokeThickness`. |

## See also

- [Getting Started with .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/getting-started)
- [SfRadialMenuItem’s Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization)
- [Segmenting and Placing Items in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/segmenting-placing-items)
- [CenterButton Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/centerbutton-customization)
- [Events in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/events)
