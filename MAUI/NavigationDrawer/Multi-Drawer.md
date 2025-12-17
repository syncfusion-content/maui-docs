---
layout: post
title: Multi Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: The navigation drawer allows users to open drawers on multiple sides with different toggle methods, offering customizable layouts and smooth transitions.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Multi Drawer in MAUI Navigation Drawer (SfNavigationDrawer)

The Navigation drawer allows users to open the drawer on multiple sides with different toggle methods. The [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class and its properties need to be used when users need to provide multiple drawers. The multiple drawers can be implemented using the following drawer settings.

* DrawerSettings
* SecondaryDrawerSettings

N> Users can open only one drawer at a time.

![Multi Drawer](Images/multi-drawer/multi-drawer.gif)

### DrawerSettings

Implement the primary drawer using the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) property in SfNavigationDrawer. The following code sample demonstrates how to customize the primary drawer.

{% tabs %}

{% highlight xaml %}

    <navigationDrawer:SfNavigationDrawer>
        <navigationDrawer:SfNavigationDrawer.DrawerSettings>
            <navigationDrawer:DrawerSettings DrawerWidth="250"
                                             Transition="SlideOnTop"
                                             ContentBackground="LightGray"
                                             Position="Left">
            </navigationDrawer:DrawerSettings>
        </navigationDrawer:SfNavigationDrawer.DrawerSettings>
    </navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}


    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings drawerSettings = new DrawerSettings();
    drawerSettings.DrawerWidth = 250;
    drawerSettings.Transition = Transition.SlideOnTop;
    drawerSettings.ContentBackground = Colors.LightGray;
    drawerSettings.Position = Position.Left;
    navigationDrawer.DrawerSettings = drawerSettings;
    this.Content = navigationDrawer;


{% endhighlight %}

{% endtabs %}

### SecondaryDrawerSettings

Implement the secondary drawer using the [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) property in SfNavigationDrawer. Its properties and functionalities are same as the primary drawer. The secondary drawer can be set to different positions similar to the primary drawer. The following code demonstrates how to customize the secondary drawer.

{% tabs %}

{% highlight xaml %}

    <navigationDrawer:SfNavigationDrawer>
        <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationDrawer:DrawerSettings x:Name="secondaryDrawer"
                                    ContentBackground="Blue"
                                    DrawerWidth= "250"
                                    Position="Right"
                                    Transition="SlideOnTop">
            </navigationDrawer:DrawerSettings>
        </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationDrawer:SfNavigationDrawer>
               
{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    secondaryDrawer.Position = Position.Right;
    secondaryDrawer.Transition = Transition.SlideOnTop;
    secondaryDrawer.ContentBackground = Colors.Blue;
    secondaryDrawer.DrawerWidth = 250;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;
  
{% endhighlight %}

{% endtabs %}

N> When the primary drawer and the secondary drawer are set to the same position, the primary drawer will open on swiping.

### Toggling method

Users can toggle the secondary drawer using the [ToggleSecondaryDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer) method. 

{% highlight c# %} 

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.ToggleSecondaryDrawer();

{% endhighlight %}

### Opening the drawer programmatically

The [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property in the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) of [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) used to open or close the secondary drawer programmatically.

The following code sample demonstrates how to set [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property in XAML and C#.

{% tabs %}

{% highlight xaml %}

    <navigationDrawer:SfNavigationDrawer>
        <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationDrawer:DrawerSettings IsOpen="True">
            </navigationDrawer:DrawerSettings>
        </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

    SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
    DrawerSettings secondaryDrawer = new DrawerSettings();
    secondaryDrawer.IsOpen = true;
    navigationDrawer.SecondaryDrawerSettings = secondaryDrawer;
    this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}



