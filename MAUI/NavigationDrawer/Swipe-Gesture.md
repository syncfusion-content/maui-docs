---
layout: post
title: SwipGesture in .NET MAUI Navigation Drawer | Syncfusion
description: Learn here all about SwipGesture support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: NavigationDrawer
documentation: ug
---
# SwipeGesture in .NET MAUI Navigation Drawer

The NavigationDrawer supports the swipe gesture for both opening and closing the drawer. 

## Enabling Swipe Gesture

It can be enabled/disabled using the [`EnableSwipeGesture`]() property.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings EnableSwipeGesture="True">
            <navigationdrawer:DrawerSettings.DrawerHeaderView>
                <Grid BackgroundColor="#1aa1d6"
                      VerticalOptions="Center"
                      HorizontalOptions="Center">
                    <Label Text="Header view"
                           FontSize="16"
                           VerticalOptions="Center"
                           HorizontalOptions="Center"/>
                </Grid>
            </navigationdrawer:DrawerSettings.DrawerHeaderView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}	
	
{% highlight c# %} 

navigationDrawer.DrawerSettings.EnableSwipeGesture = true;

{% endhighlight %}

{% endtabs %}