---
layout: post
title: Animation Duration in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about the Duration property in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control and how to customize the animation speed.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---
# Animation Duration in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Duration

The [Duration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Duration) property of the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) specifies the timeline for completing one animation cycle. Setting a smaller duration value accelerates animation speed.


The following code example illustrates how to set the animation duration of the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html).

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings Duration="2000"/>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        Duration = 2000
    }
};
{% endhighlight %}

{% endtabs %}

The following screenshot illustrates the result of the above code.

![Animation Duration in .NET MAUI Navigation Drawer](Images/animation-duration/navigation_duration.gif)

## Related Members

The `Duration` property works together with the following members to control the drawer's animation behavior:

- [AnimationEasing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_AnimationEasing) — defines the acceleration curve of the animation.
- [Transition](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer) — controls the open/close animation style.
- [SwipeGestureSettings](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture) — configures the swipe interaction that triggers the animation.

For more details on configuring the drawer behavior, see [Toggling the Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggling-drawer) and [Swipe Gesture](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture).

## See also

- [How to Customize the Animation Duration in .NET MAUI Navigation Drawer?](https://support.syncfusion.com/kb/article/15504/how-to-customize-the-animation-duration-in-net-maui-navigation-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)