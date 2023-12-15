---
layout: post
title: Animation Duration in .NET MAUI Navigation Drawer control | Syncfusion
description: Learn about Animation Duration support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: .NET MAUI
control: SfNavigationDrawer
documentation: ug
---
# Animation Duration in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Animation Duration in SfNavigationDrawer

The `Duration` property of the `SfNavigationDrawer` indicates the timeline for completing one animation cycle. Setting a smaller duration value accelerates animation speed.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings  Duration="200"/>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerSettings = new DrawerSettings()
{
    Duration = 200,
};
this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

N> The `Duration` property for the `SfNavigationDrawer` is measured in milliseconds.

The following screenshot illustrates the result of the above code.

![Duration](Images/animation-duration/navigation_duration.gif)