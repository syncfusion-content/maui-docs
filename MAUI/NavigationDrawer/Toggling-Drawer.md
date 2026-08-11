---
layout: post
title: Toggling the Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: Learn how to programmatically open and close the drawer in the Syncfusion® .NET MAUI Navigation Drawer.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Programmatically Toggling the Drawer in .NET MAUI Navigation Drawer

You can toggle the drawer in the [.NET MAUI Navigation Drawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html) in the following ways:

- [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property
- [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method
- [Swipe gesture](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture)


## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Opening the Drawer Programmatically

You can open the drawer using the [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) property of [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html) or the [ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) method on `Navigation Drawer`.

### Using the IsOpen property

`IsOpen` is a `bool` property that defaults to `false`. Setting it to `true` opens the drawer; setting it to `false` closes it.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings IsOpen="True">
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

using Syncfusion.Maui.NavigationDrawer;

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer
{
    DrawerSettings = new DrawerSettings
    {
        IsOpen = true
    }
};

{% endhighlight %}

{% endtabs %}

### Using the ToggleDrawer method

[ToggleDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleDrawer) is a method on `Navigation Drawer` to open or close the drawer based on the existing state.

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings>
            <navigationDrawer:DrawerSettings.DrawerContentView>
                <Label Text="Drawer Content"/>
            </navigationDrawer:DrawerSettings.DrawerContentView>
        </navigationDrawer:DrawerSettings>
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
    <Button Text="Toggle Drawer"
            Clicked="OnToggleDrawerClicked"
            VerticalOptions="Start"/>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}
{% highlight c# %}

Button button = new Button()
{
    Text = "Toggle Drawer",
    VerticalOptions = LayoutOptions.Start
};
button.Clicked += OnToggleDrawerClicked;

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings()
    {
        DrawerContentView = new Label
        {
            Text = "Drawer Content"
        }
    },
    ContentView = button,
};

{% endhighlight %}
{% endtabs %}

The Button's `Clicked` event can be handled in C# as follows:

{% tabs %}
{% highlight c# %}

private void OnToggleDrawerClicked(object sender, EventArgs e)
{
     navigationDrawer.ToggleDrawer();
}

{% endhighlight %}
{% endtabs %}

## Toggling drawer by swipe gesture

Toggling drawer by swipe gesture is explained in the [Swipe Gesture and Sensitivity](https://help.syncfusion.com/maui/navigationdrawer/swipe-gesture) section.

## See also

- [Toggle Methods in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/Navigation Drawer/toggling-drawer)
- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Side Pane Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)