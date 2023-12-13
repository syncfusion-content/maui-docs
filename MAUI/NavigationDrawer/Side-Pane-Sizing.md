---
layout: post
title: Setting Sliding Panel size in .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about Setting Sliding Panel size support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# Setting Sliding Panel size in .NET MAUI Navigation Drawer

The size of the side pane can be adjusted using the `DrawerHeight` and `DrawerWidth` properties.

## Drawer Height

The `DrawerHeight` property changes the height of the side pane when the `Position` is set to `Top` or `Bottom`.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings Position="Top"
                                         DrawerHeight="50">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Label Text="This is a brief content used to demonstrate the DrawerHeight property."/>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}	
	
{% highlight c# %} 

 SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
 DrawerSettings drawerSettings = new DrawerSettings()
 {
     Position = Position.Top,
     DrawerHeight = 50,
 };
 navigationDrawer.DrawerSettings = drawerSettings;
 this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

![Drawer height]()

## Drawer Width

The `DrawerWidth` property changes the width of the side pane when the `Position` is set to `Left` or `Right`.

{% tabs %}

{% highlight xaml %}

 <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
     <navigationdrawer:SfNavigationDrawer.DrawerSettings>
         <navigationdrawer:DrawerSettings Position="Left"
                                          DrawerHeaderHeight="75">
             <navigationdrawer:DrawerSettings.DrawerHeaderView>
                 <Label Text="This is a brief content used to demonstrate the DrawerWidth property."/>
             </navigationdrawer:DrawerSettings.DrawerHeaderView>
         </navigationdrawer:DrawerSettings>
     </navigationdrawer:SfNavigationDrawer.DrawerSettings>
 </navigationdrawer:SfNavigationDrawer>
	
{% endhighlight %}	
	
{% highlight c# %} 

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
DrawerSettings drawerSettings = new DrawerSettings()
{
    Position = Position.Left,
    DrawerHeaderHeight = 75,
};
navigationDrawer.DrawerSettings = drawerSettings;
this.Content = navigationDrawer;

{% endhighlight %}

{% endtabs %}

![Drawer width]()
