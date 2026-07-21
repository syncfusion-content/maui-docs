---
layout: post
title: Side Pane Sizing in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn how to size the side pane in the Syncfusion® .NET MAUI Navigation Drawer control using DrawerWidth and DrawerHeight.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Side Pane Sizing in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Overview

The size of the side pane is controlled by the [DrawerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth) and [DrawerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight) properties of `DrawerSettings`. The property that takes effect depends on the drawer's [Position](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides).

## Properties

| Property | Type | Default Value | Description |
|----------|------|---------------|-------------|
| [DrawerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth) | `double` | `250` | Width of the side pane. Applied when `Position` is `Left` or `Right`. |
| [DrawerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight) | `double` | `250` | Height of the side pane. Applied when `Position` is `Top` or `Bottom`. |

## Position-dependent sizing

The size property that takes effect depends on the drawer's position:

| Position | Size property |
|----------|---------------|
| `Left`, `Right` | `DrawerWidth` |
| `Top`, `Bottom` | `DrawerHeight` |

For more details on the `Position` enum, see [Navigation Pane Sides](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides).

## DrawerHeight

The [DrawerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerHeight) property changes the height of the side pane. It is primarily applied when [Position](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides) is set to [Top](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Position.html#Syncfusion_Maui_NavigationDrawer_Position_Top) or [Bottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Position.html#Syncfusion_Maui_NavigationDrawer_Position_Bottom).

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings Position="Top"
                                            DrawerHeight="50"
                                            DrawerHeaderHeight="50">
            <navigationDrawer:DrawerSettings.DrawerHeaderView>
                <Label Text="This is a brief content used to demonstrate the DrawerHeight property."
                        VerticalOptions="Center"
                        HorizontalOptions="Center" />
            </navigationDrawer:DrawerSettings.DrawerHeaderView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        Position = Position.Top,
        DrawerHeight = 50,
        DrawerHeaderHeight = 50,
        DrawerHeaderView = new Label
        {
            Text = "This is a brief content used to demonstrate the DrawerHeight property.",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        }
    }
};

{% endhighlight %}

{% endtabs %}

![Side pane height in .NET MAUI Navigation Drawer](Images/panel-size/navigation_drawer_pane_height.png)

## DrawerWidth

The [DrawerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth) property changes the width of the side pane. It is primarily applied when [Position](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides) is set to [Left](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Position.html#Syncfusion_Maui_NavigationDrawer_Position_Left) or [Right](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.Position.html#Syncfusion_Maui_NavigationDrawer_Position_Right).

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings Position="Left"
                                            DrawerWidth="250"
                                            DrawerHeaderHeight="75">
            <navigationDrawer:DrawerSettings.DrawerHeaderView>
                <Label Text="This is a brief content used to demonstrate the DrawerWidth property."
                        VerticalOptions="Center"
                        HorizontalOptions="Center" />
            </navigationDrawer:DrawerSettings.DrawerHeaderView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        Position = Position.Left,
        DrawerWidth = 250,
        DrawerHeaderHeight = 75,
        DrawerHeaderView = new Label
        {
            Text = "This is a brief content used to demonstrate the DrawerWidth property.",
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center
        }
    }
};

{% endhighlight %}
{% endtabs %}

![Side pane width in .NET MAUI Navigation Drawer](Images/panel-size/navigation_drawer_pane_width.png)

> NOTE: The `DrawerHeaderHeight` and `DrawerFooterHeight` properties (used in the examples above) are documented in [Side Pane Content](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content). The header and footer regions stack inside the side pane; their heights do not affect `DrawerWidth` or `DrawerHeight`.

## Behavior

- The size property that takes effect depends on the drawer's `Position`. Setting `DrawerWidth` while `Position` is `Top` or `Bottom` has no visible effect, and vice versa.
- The side pane's content area fills the remaining space between the header and footer when those regions are configured. See [Side Pane Content](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content) for details.
- Size changes take effect immediately and animate with the next open/close transition. See [Animation Duration](https://help.syncfusion.com/maui/navigationdrawer/duration) to customize the transition.
- When the drawer is configured for a `SecondaryDrawerSettings` (see [Multi Drawer](https://help.syncfusion.com/maui/navigationdrawer/multi-drawer)), each drawer can have an independent size.

## Troubleshooting

| Issue | Possible cause | Resolution |
|-------|----------------|------------|
| `DrawerWidth` has no effect | `Position` is `Top` or `Bottom` | Set `Position` to `Left` or `Right`, or use `DrawerHeight` instead |
| `DrawerHeight` has no effect | `Position` is `Left` or `Right` | Set `Position` to `Top` or `Bottom`, or use `DrawerWidth` instead |
| Side pane content is clipped | The inner view's width or height is fixed | Use `*` (star) sizing or remove explicit dimensions from the inner layout |
| Side pane is hidden behind the navigation bar | Safe area insets are not respected on iOS/Android | Apply `SafeArea` margins to the drawer content or to `ContentBackground` |

## See also

- [Getting Started with .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/getting-started)
- [Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)