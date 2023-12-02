---
layout: post
title: Animation Duration in .NET MAUI Navigation Drawer control | Syncfusion
description: Learn here all about Animation Duration support in Syncfusion .NET MAUI Navigation Drawer (SfNavigationDrawer) control and more.
platform: maui
control: SfNavigationDrawer
documentation: ug
---
# Animation Duration in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Animation Duration in SfNavigationDrawer

The [`Duration`]() property of [`SfNavigationDrawer`]() indicates the timeline for completing one animation cycle. Setting a smaller duration value accelerates animation speed.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <navigationdrawer:DrawerSettings DrawerWidth="300"
                                         Duration="1"
                                         DrawerHeaderHeight="160"/>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

namespace NavigationSample;

public partial class NavigationDrawerPage : ContentPage
{
	public NavigationDrawerPage()
	{
		InitializeComponent();
        SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
        navigationDrawer.DrawerSettings = new DrawerSettings()
        {
            DrawerWidth = 300,
            Duration = 1,
            DrawerHeaderHeight = 160,
        };
        this.Content = navigationDrawer;
    }
}

    
{% endhighlight %}

{% endtabs %}


The following screenshot illustrates the result of the above code.

![Maximum Duration]()


