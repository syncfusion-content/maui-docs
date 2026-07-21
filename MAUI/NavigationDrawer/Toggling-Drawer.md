---
layout: post
title: Toggling the Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn how to programmatically open and close the drawer in the Syncfusion® .NET MAUI Navigation Drawer.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Programmatically Toggling the Drawer in .NET MAUI Navigation Drawer

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Overview

You can toggle the drawer in the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) in the following ways:

* [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property
* [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method
* [Swipe gesture](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture)

The following table summarizes each approach:

| Approach | Type | Use case |
|----------|------|----------|
| `IsOpen` | `bool` property on `DrawerSettings` | Bind to a view-model flag or set declaratively. |
| `ToggleDrawer` | Method on `SfNavigationDrawer` | Toggle from a button click, command, or code-behind. |
| Swipe gesture | Touch interaction | Toggle by dragging from the drawer edge. |

## Opening the Drawer Programmatically

You can open the drawer using the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property of [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html) or the [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method on [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html).

### Using the ToggleDrawer method

[ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) is a method on `SfNavigationDrawer` that returns `Task`. It supports the following overloads:

| Overload | Description |
|----------|-------------|
| `ToggleDrawer()` | Toggles the drawer between open and closed. |
| `ToggleDrawer(bool isOpen)` | Opens the drawer when `true` is passed; closes it when `false` is passed. |

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings>
            <navigationDrawer:DrawerSettings.DrawerContentView>
                <Label Text="Drawer Content"/>
            </navigationDrawer:DrawerSettings.DrawerContentView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
    <Button Text="Toggle Drawer"
            Clicked="OnToggleDrawerClicked"
            VerticalOptions="Start"/>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer;
var button = new Button()
{
    Text = "Toggle Drawer",
    VerticalOptions = LayoutOptions.Start
};
button.Clicked += OnToggleDrawerClicked;

navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings()
    {
        DrawerContentView = new Label
        {
            Text = "Drawer Content"
        }
    },
    ContentView = button,
};

private void OnToggleDrawerClicked(object sender, EventArgs e)
{
     navigationDrawer.ToggleDrawer();
}

{% endhighlight %}

{% endtabs %}

> NOTE: The `IsOpen` property is available from `Syncfusion.Maui.NavigationDrawer` version `21.2.3` onwards. `ToggleDrawer` is available from version `19.4.0` onwards. For setup steps, refer to the [Getting Started with .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

### Using the IsOpen property

`IsOpen` is a `bool` property that defaults to `false`. Setting it to `true` opens the drawer; setting it to `false` closes it.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings IsOpen="True">
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        IsOpen = true
    }
};

{% endhighlight %}

{% endtabs %}

## Closing the Drawer Programmatically

You can close the drawer by setting `IsOpen` to `false` or by calling `ToggleDrawer(false)`.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings IsOpen="False">
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        IsOpen = false
    }
};

{% endhighlight %}

{% endtabs %}

Toggling the drawer by swipe gesture is explained in the [Swipe Gesture and Sensitivity](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture) section.


## See also

- [Getting Started with .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/getting-started)
- [Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)