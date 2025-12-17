---
layout: post
title: Toggle Methods in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about toggle methods support in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Toggle Methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)

The drawer in the SfNavigationDrawer can be toggled using the following methods:

* IsOpen property
* ToggleDrawer method
* Swipe gesture

## Opening drawer programmatically

The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property and [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method enable programmatically opening or closing the drawer.

{% tabs %}

{% highlight xaml %}

 <navigationDrawer:SfNavigationDrawer>
        <navigationDrawer:SfNavigationDrawer.DrawerSettings>
            <navigationDrawer:DrawerSettings IsOpen="True">
            </navigationDrawer:DrawerSettings>
        </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>


{% endhighlight %}	
	
{% highlight c# %} 

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings primaryDrawer = new DrawerSettings();
    primaryDrawer.IsOpen = true;
    navigationDrawer.DrawerSettings = primaryDrawer;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

Using [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method:

{% highlight c# %} 

navigationDrawer.ToggleDrawer();

{% endhighlight %}

Toggling drawer by swipe gesture is explained in the [Swipe Gesture and Sensitivity](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture) section.