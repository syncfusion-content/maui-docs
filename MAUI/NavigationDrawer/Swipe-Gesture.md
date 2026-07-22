---
layout: post
title: Swipe Gesture in .NET MAUI Navigation Drawer | Syncfusion®
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


The [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) supports a swipe gesture for both opening and closing the side pane. The gesture is enabled by default and can be customized to fit the layout of your app.

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

## See also

- [Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)