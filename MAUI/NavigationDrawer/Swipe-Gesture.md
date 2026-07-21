---
layout: post
title: Swipe Gesture in .NET MAUI Navigation Drawer (SfNavigationDrawer) | Syncfusion®
description: Learn how to enable and customize the swipe gesture in the Syncfusion® .NET MAUI Navigation Drawer control.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Swipe Gesture in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Overview

The [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) supports a swipe gesture for both opening and closing the side pane. The gesture is enabled by default and can be customized to fit the layout of your app.


## Properties

| Property | Type | Default Value | Unit | Description |
|----------|------|---------------|------|-------------|
| [EnableSwipeGesture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_EnableSwipeGesture) | `bool` | `true` | - | Enables or disables the swipe gesture for opening and closing the side pane. |
| [TouchThreshold](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_TouchThreshold) | `double` | `120` | Pixels (device-independent) | Width of the swipe region measured from the drawer's edge. Larger values make the gesture easier to trigger. |

## Enable swipe gesture

Use [EnableSwipeGesture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_EnableSwipeGesture) to enable or disable the swipe gesture. When set to `false`, the user can still open or close the side pane programmatically (via [IsOpen](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer) or [ToggleDrawer](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)) or by tapping a hamburger button.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings EnableSwipeGesture="true" />
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings
    {
        EnableSwipeGesture = true
    },
};

{% endhighlight %}

{% endtabs %}

## Swipe sensitivity

Use [TouchThreshold](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_TouchThreshold) to control the size of the swipe region measured from the drawer's edge. The default is `120` device-independent pixels. A larger value makes the gesture easier to trigger (recommended on tablets and desktop layouts); a smaller value makes the gesture less intrusive on dense mobile layouts. Typical values range from `60` to `240`.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings TouchThreshold="200" />
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings
    {
        TouchThreshold = 200
    },
};

{% endhighlight %}

{% endtabs %}

## Combined example

The following example enables the swipe gesture and sets a custom threshold on a `Left` positioned drawer.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings Position="Left"
                                            DrawerWidth="280"
                                            EnableSwipeGesture="true"
                                            TouchThreshold="180" />
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings
    {
        Position = Position.Left,
        DrawerWidth = 280,
        EnableSwipeGesture = true,
        TouchThreshold = 180
    },
};
        
{% endhighlight %}

{% endtabs %}

## Behavior

- The swipe direction is determined by the drawer's [Position](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides). A `Left` drawer responds to right-to-left swipes; a `Right` drawer responds to left-to-right swipes; a `Top` drawer responds to top-to-bottom swipes; a `Bottom` drawer responds to bottom-to-top swipes.
- The swipe region is measured from the configured edge. A swipe that starts outside the threshold region does not open the drawer.
- The swipe gesture is independent of programmatic open/close. Setting `EnableSwipeGesture` to `false` does not affect `IsOpen`, `ToggleDrawer`, or the [DrawerToggled](https://help.syncfusion.com/maui/navigationdrawer/events) event.
- When a primary and secondary drawer are configured for the same position, the primary drawer takes precedence on swipes. See [Multi Drawer](https://help.syncfusion.com/maui/navigationdrawer/multi-drawer) for details.

## How to test

After configuring the swipe gesture:

1. Build and run the app on a device or emulator that supports touch input.
2. Place a finger within the configured `TouchThreshold` region on the configured edge.
3. Drag the finger across the screen in the direction that matches the drawer's `Position`.
4. Release to open the side pane; drag in the opposite direction to close it.

## Troubleshooting

| Issue | Possible cause | Resolution |
|-------|----------------|------------|
| Swipe gesture does not open the drawer | `EnableSwipeGesture` is `false` | Set `EnableSwipeGesture` to `true` |
| Swipe is too sensitive | `TouchThreshold` is too large | Reduce `TouchThreshold` to a smaller value (for example, `60`-`90`) |
| Swipe is hard to trigger | `TouchThreshold` is too small | Increase `TouchThreshold` (for example, `180`-`240`) |
| Swipe opens the primary drawer instead of the secondary | Both drawers are configured for the same `Position` | Set the secondary drawer to a different `Position`, or trigger it programmatically. See [Multi Drawer](https://help.syncfusion.com/maui/navigationdrawer/multi-drawer) |
| Swipe direction is wrong | The drawer's `Position` does not match the desired direction | Update `DrawerSettings.Position`. See [Navigation Pane Sides](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides) |

## See also

- [Getting Started with .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/getting-started)
- [Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)