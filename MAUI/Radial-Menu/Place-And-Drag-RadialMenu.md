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

## Placing and Dragging

You can place the Radial Menu anywhere on its parent layout and drag it within that layout. The default position is the center of the parent; set the [`Point`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Point) property to override that. Enable dragging with the [`IsDragEnabled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_IsDragEnabled) property and react to drag start / end with the [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) and [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragEnd) events.


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


## Handle drag events

`SfRadialMenu` raises two events while the user drags the menu: [`DragBegin`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragBegin) fires when the drag starts, and [`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_DragEnd) fires when it ends. Both events are only raised when `IsDragEnabled` is `true`.

### DragBegin event

This event is raised when the user starts to drag the Radial Menu. The handler receives a [`DragBeginEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html) instance.

- [`Position`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Position) - Gets the starting position of the Radial Menu.

- [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragBeginEventArgs.html#Syncfusion_Maui_RadialMenu_DragBeginEventArgs_Handled) - Gets and sets a boolean value for enabling or disabling the dragging of the Radial Menu.

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

- [`OldValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_OldValue) - Gets the start position of the Radial Menu.

- [`NewValue`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_NewValue) - Gets the end position of the Radial Menu.

- [`Handled`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.DragEndEventArgs.html#Syncfusion_Maui_RadialMenu_DragEndEventArgs_Handled) - Gets and sets a boolean value to restrict the Radial Menu from moving to another position.

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

## See also

- [SfRadialMenuItem’s Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization)
- [Segmenting and Placing Items in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/segmenting-placing-items)
- [CenterButton Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/centerbutton-customization)
- [Events in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/events)