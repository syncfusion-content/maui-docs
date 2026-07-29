---
layout: post
title: Events in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn about the built-in events in the Syncfusion® .NET MAUI Navigation Drawer control and how to handle them.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Events in .NET MAUI Navigation Drawer (SfNavigationDrawer)

This section explains the built-in events of the [.NET MAUI Navigation Drawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) control and how to handle them in your application.

The following five built-in events are available in the `Navigation Drawer` control:

* [DrawerOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening)
* [DrawerOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened)
* [DrawerClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing)
* [DrawerClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed)
* [DrawerToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled)

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Event life cycle

The events fire in the following order during a state change:

1. `DrawerOpening` - fires before the open animation starts (cancelable).
2. `DrawerOpened` - fires after the open animation completes.
3. `DrawerClosing` - fires before the close animation starts (cancelable).
4. `DrawerClosed` - fires after the close animation completes.
5. `DrawerToggled` - fires after every state change, alongside `DrawerOpened` or `DrawerClosed`, and reports the resulting `IsOpen` state.

## DrawerOpening event

The [DrawerOpening](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpening) event is triggered before the drawer pane opens. You can cancel the open operation by setting the `Cancel` property of the event argument to `true`. The event argument is of type `DrawerCancelEventArgs`.

* `Cancel`: Determines if the drawer opening should be canceled.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer" 
                                     DrawerOpening="OnDrawerOpening" />

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerOpening += OnDrawerOpening;

{% endhighlight %}
{% endtabs %}

The `DrawerOpening` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnDrawerOpening(object sender, DrawerCancelEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## DrawerOpened event

The [DrawerOpened](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerOpened) event is triggered after a drawer is opened. You can execute your own set of codes once the drawer is opened.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer"               
                                     DrawerOpened="OnDrawerOpened" />

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerOpened += OnDrawerOpened;

{% endhighlight %}
{% endtabs %}

The `DrawerOpened` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnDrawerOpened(object sender, DrawerEventArgs e)
{
    // Codes that need to be executed once the drawer is opened.
}

{% endhighlight %}
{% endtabs %}

## DrawerClosing event

The [DrawerClosing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosing) event is triggered before the drawer pane closes. You can cancel the close operation by setting the `Cancel` property of the event argument to `true`. The event argument is of type `DrawerCancelEventArgs`.

* `Cancel`: Determines if the drawer closing should be canceled.

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer" 
                                     DrawerClosing="OnDrawerClosing" />

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerClosing += OnDrawerClosing;

{% endhighlight %}

{% endtabs %}

The `DrawerClosing` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnDrawerClosing(object sender, DrawerCancelEventArgs e)
{
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}

## DrawerClosed event

The [DrawerClosed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerClosed) event is triggered after a drawer is closed. You can execute your own set of codes once the drawer is closed.

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer"  
                                     DrawerClosed="OnDrawerClosed" />

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerClosed += OnDrawerClosed;

{% endhighlight %}
{% endtabs %}

The `DrawerClosed` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnDrawerClosed(object sender, DrawerEventArgs e)
{
    // Codes that need to be executed once the drawer is closed.
}

{% endhighlight %}
{% endtabs %}

## DrawerToggled event

The [DrawerToggled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerToggled) event is a unified state-change notification that fires after the drawer is opened or closed, alongside `DrawerOpened` or `DrawerClosed`. The event argument is of type [ToggledEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.ToggledEventArgs.html). It exposes the following property:

* [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.ToggledEventArgs.html#Syncfusion_Maui_NavigationDrawer_ToggledEventArgs_IsOpen): Indicates whether the drawer is opened or closed.

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer" 
                                     DrawerToggled="OnDrawerToggled" />

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer();
navigationDrawer.DrawerToggled += OnDrawerToggled;

{% endhighlight %}
{% endtabs %}

The `DrawerToggled` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnDrawerToggled(object sender, Syncfusion.Maui.NavigationDrawer.ToggledEventArgs e)
{
    var isOpen = e.IsOpen;
    // Codes that need to be executed once the drawer is toggled.
}

{% endhighlight %}
{% endtabs %}

## See also

- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)
- [Configure the Drawer in Different Sides in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/navigation-pane-sides)