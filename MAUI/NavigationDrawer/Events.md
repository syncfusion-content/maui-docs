---
layout: post
title: Events in .NET MAUI Navigation Drawer Control | Syncfusion®
description: Learn about event support in the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control, its elements, and more.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Events in .NET MAUI Navigation Drawer (SfNavigationDrawer)

There are five built-in events in the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.html) control, namely:

* [DrawerOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening)
* [DrawerOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened)
* [DrawerClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing)
* [DrawerClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed)
* [DrawerToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled)

## DrawerOpening event

The [DrawerOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening) event is triggered before the drawer pane opens. Restrict the drawer from opening by canceling this event by setting the `Cancel` property in the event argument to `true`. The event arguments are of type `CancelEventArgs`. It exposes the following property:

 * `Cancel`: Determines if the drawer opening should be canceled.

 {% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerOpening="navigationDrawer_DrawerOpening"/>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    navigationDrawer.DrawerOpening += navigationDrawer_DrawerOpening;
}

private void navigationDrawer_DrawerOpening(object sender, System.ComponentModel.CancelEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## DrawerOpened event

The [DrawerOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened) event triggered after a drawer is opened.

You can execute your own set of codes once the drawer is opened.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerOpened="navigationDrawer_DrawerOpened"/>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    navigationDrawer.DrawerOpened += navigationDrawer_DrawerOpened;
}

private void navigationDrawer_DrawerOpened(object sender, EventArgs e)
{
    // Codes that need to be executed once the drawer is opened.
}

{% endhighlight %}
{% endtabs %}

## DrawerClosing event

The [DrawerClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing) event is triggered before the drawer pane closes. Restrict the drawer from closing by canceling this event by setting the `Cancel` property in the event argument to `true`. The event arguments are of type `CancelEventArgs`. It exposes the following property:

 * `Cancel`: Determines if the drawer closing should be canceled.

 {% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerClosing="navigationDrawer_DrawerClosing"/>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    navigationDrawer.DrawerClosing += navigationDrawer_DrawerClosing;
}

private void navigationDrawer_DrawerClosing(object sender, System.ComponentModel.CancelEventArgs e)
{
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

## DrawerClosed event

The [DrawerClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed) event triggered after a drawer is closed.

You can execute your own set of codes once the drawer is closed.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerClosed="navigationDrawer_DrawerClosed"/>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    navigationDrawer.DrawerClosed += navigationDrawer_DrawerClosed;
}

private void navigationDrawer_DrawerClosed(object sender, EventArgs e)
{
    // Codes that need to be executed once the drawer is closed.
}

{% endhighlight %}
{% endtabs %}

## DrawerToggled event

The [DrawerToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled) event is triggered after a drawer is opened or closed. The event arguments are of type [ToggledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.ToggledEventArgs.html). It exposes the following property:

* [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.ToggledEventArgs.html#Syncfusion_Maui_NavigationDrawer_ToggledEventArgs_IsOpen): Indicates whether the drawer is opened or closed.

{% tabs %}

{% highlight xaml %}

<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer" DrawerToggled="navigationDrawer_DrawerToggled"/>

{% endhighlight %}

{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    navigationDrawer.DrawerToggled += navigationDrawer_DrawerToggled;
}

private void navigationDrawer_DrawerToggled(object sender, Syncfusion.Maui.NavigationDrawer.ToggledEventArgs e)
{
    var isOpen = e.IsOpen;
    // Codes that need to be executed once the drawer is toggled.
}

{% endhighlight %}
{% endtabs %}