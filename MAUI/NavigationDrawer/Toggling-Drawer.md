---
layout: post
title: Toggle methods in .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about Toggle methods support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# Toggle methods in .NET MAUI Navigation Drawer (SfNavigationDrawer)

Drawer can be toggled using

* IsOpen property
* ToggleDrawer method
* Swipe gesture

## Opening Drawer Programmatically
The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_IsOpen) property and [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method enable programmatically opening or closing the drawer.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" IsOpen="True">
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}	
	
{% highlight c# %} 

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    IsOpen = true,
};

{% endhighlight %}

{% endtabs %}

Using [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method,

{% highlight c# %} 

navigationDrawer.ToggleDrawer();

{% endhighlight %}

Toggling drawer by swipe gesture is explained in [Swipe Gesture and Sensitivity](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture) section.