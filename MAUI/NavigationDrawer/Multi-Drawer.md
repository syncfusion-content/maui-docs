---
layout: post
title: Multi Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: The navigation drawer allows users to open drawers on multiple sides with different toggle methods.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Multi Drawer in MAUI Navigation Drawer (SfNavigationDrawer)

The navigation drawer allows users to open the drawer on multiple sides with different toggle methods. The [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class and its properties need to be used when users need to provide multiple drawers. The multiple drawers can be implemented using the following drawer settings.

* DrawerSettings
* SecondaryDrawerSettings

N> Users can open only one drawer at a time.

![Multi Drawer](Images/multi-drawer/multi-drawer.gif)

### DrawerSettings

Implement the primary drawer using the drawer settings class. The following code sample demonstrates how to set the drawer settings’s properties inside the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.DrawerSettings>
            <navigationdrawer:DrawerSettings DrawerWidth="250"
                                             Transition="SlideOnTop"
                                             ContentBackground="LightGray"
                                             Position="Left">
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.DrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}


    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.DrawerWidth = 250;
    drawerSettings.Transition = Syncfusion.Maui.NavigationDrawer.Transition.SlideOnTop;
    drawerSettings.ContentBackground = Colors.LightGray;
    drawerSettings.Position = Syncfusion.Maui.NavigationDrawer.Position.Left;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;


{% endhighlight %}

{% endtabs %}

### SecondaryDrawerSettings

Implement the secondary drawer using the secondary drawer settings class. Its properties and functionalities are same as the primary drawer. The secondary drawer can be set to different positions similar to the primary drawer. The following code demonstrates how to set the secondary drawer settings's properties in XAML and C#.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationdrawer:DrawerSettings x:Name="secondaryDrawer"
                                    DrawerHeaderHeight="40"
                                    DrawerFooterHeight="40"
                                    ContentBackground="Blue"
                                    DrawerHeight="250"
                                    DrawerWidth= "250"
                                    Duration="400" 
                                    Position="Right"
                                    Transition="SlideOnTop">
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>
               
{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    secondaryDrawer.DrawerHeight = 250;
    secondaryDrawer.Position = Syncfusion.Maui.NavigationDrawer.Position.Right;
    secondaryDrawer.Transition = Syncfusion.Maui.NavigationDrawer.Transition.SlideOnTop;
    secondaryDrawer.ContentBackground = Colors.Blue;
    secondaryDrawer.DrawerWidth = 250;
    secondaryDrawer.DrawerHeaderHeight = 40;
    secondaryDrawer.DrawerFooterHeight = 40;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

N> When the primary drawer and the secondary drawer are set to the same position, the primary drawer will open on swiping.

## Toggling method

Users can toggle the secondary drawer using the `ToggleSecondaryDrawer` method. 

{% highlight c# %} 

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.ToggleSecondaryDrawer();

{% endhighlight %}

### Opening the drawer programmatically

The `IsOpen` property in the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) of `SecondaryDrawerSettings` is used to open or close the drawer programmatically.

The following code sample demonstrates how to set `IsOpen` property in XAML and C#.

{% tabs %}

{% highlight xaml %}

    <navigationdrawer:SfNavigationDrawer>
        <navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationdrawer:DrawerSettings IsOpen="True">
            </navigationdrawer:DrawerSettings>
        </navigationdrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    secondaryDrawer.IsOpen = true;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}



