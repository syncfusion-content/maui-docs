---
layout: post
title: Multi Drawer in .NET MAUI Navigation Drawer | Syncfusion®
description: Configure primary and secondary drawers on the Syncfusion® .NET MAUI Navigation Drawer (SfNavigationDrawer) control to expose content on multiple sides.
platform: MAUI
control: SfNavigationDrawer
documentation: UG
---

# Multi Drawer in .NET MAUI Navigation Drawer (SfNavigationDrawer)

## Prerequisites

Before using the [SfNavigationDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.NavigationDrawer`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/navigationdrawer/getting-started) documentation.

## Multi Drawer

The Navigation drawer allows users to open the drawer on multiple sides with different toggle methods. The [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) class and its properties need to be used when users need to provide multiple drawers. The multiple drawers can be implemented using the following drawer settings.

- [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) - the primary drawer.
- [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) - the secondary drawer.

N> Users can open only one drawer at a time.

![Multi Drawer in .NET MAUI Navigation Drawer](Images/multi-drawer/multi-drawer.gif)

## Properties

| Property | Type | Default Value | Description |
|----------|------|---------------|-------------|
| [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) | `DrawerSettings` | `null` | Configures the primary drawer. |
| [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SeNavigationDrawer_SecondaryDrawerSettings) | `DrawerSettings` | `null` | Configures the secondary drawer. Shares the same properties as `DrawerSettings`. |
| [Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Position) | `Position` enum | `Left` | Side from which the drawer opens. Values: `Left`, `Right`, `Top`, `Bottom`. |
| [Transition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_Transition) | `Transition` enum | `SlideOnTop` | Animation style. Values: `SlideOnTop`, `Push`, `Reveal`. |
| [ContentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_ContentBackground) | `Color` | `null` | Background of the side pane. |
| [DrawerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_DrawerWidth) | `double` | `250` | Width of the side pane (or height for `Top`/`Bottom`). |
| [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) | `bool` | `false` | Gets or sets whether the drawer is open. Setting this on `SecondaryDrawerSettings` opens or closes the secondary drawer. |
| [ToggleSecondaryDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer) | `void` (method) | - | Toggles the secondary drawer between open and closed. |

## Primary drawer

Configure the primary drawer using the [DrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_DrawerSettings) property of `SfNavigationDrawer`. The following code sample demonstrates how to customize the primary drawer.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer>
    <navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:DrawerSettings DrawerWidth="250"
                                            Transition="SlideOnTop"
                                            ContentBackground="LightGray"
                                            Position="Left" />
    </navigationDrawer:SfNavigationDrawer.DrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    DrawerSettings = new DrawerSettings
    {
        DrawerWidth = 250,
        Transition = Transition.SlideOnTop,
        ContentBackground = Colors.LightGray,
        Position = Position.Left
    },
};

{% endhighlight %}

{% endtabs %}

## Secondary drawer

Configure the secondary drawer using the [SecondaryDrawerSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_SecondaryDrawerSettings) property. Its properties and behavior are the same as the primary drawer, and it can be set to a different position. The following code demonstrates how to customize the secondary drawer.

{% tabs %}
{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
        <navigationDrawer:DrawerSettings x:Name="secondaryDrawer"
                                        ContentBackground="Blue"
                                        DrawerWidth="250"
                                        Position="Right"
                                        Transition="SlideOnTop" />
    </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}
{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    SecondaryDrawerSettings = new DrawerSettings
    {
        ContentBackground = Colors.Blue,
        DrawerWidth = 250
        Position = Position.Right,
        Transition = Transition.SlideOnTop,
    },
};

{% endhighlight %}
{% endtabs %}

N> When the primary drawer and the secondary drawer are set to the same position, the primary drawer will open on swiping.

## Toggling the secondary drawer

You can toggle the secondary drawer in any of the following ways:

### Using the ToggleSecondaryDrawer method

Call the [ToggleSecondaryDrawer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.SfNavigationDrawer.html#Syncfusion_Maui_NavigationDrawer_SfNavigationDrawer_ToggleSecondaryDrawer) method to open or close the secondary drawer.

{% tabs %}

{% highlight x#aml %}

<Grid>
    <navigationDrawer:SfNavigationDrawer x:Name="navigationDrawer">
        <navigationDrawer:SfNavigationDrawer.DrawerSettings>
            <navigationDrawer:DrawerSettings Position="Left" />
        </navigationDrawer:SfNavigationDrawer.DrawerSettings>
        <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
            <navigationDrawer:DrawerSettings x:Name="secondaryDrawer" Position="Right" />
        </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
    </navigationDrawer:SfNavigationDrawer>
    <Button Text="Toggle Secondary"
            HorizontalOptions="Center"
            VerticalOptions="End"
            Clicked="OnToggleSecondaryClicked" />
</Grid>

{% endhighlight %}

{% highlight c# %}

Button button = new Button
{
    Text = "Toggle Secondary",
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.End
};

button.Clicked += OnToggleSecondaryClicked;

Grid grid = new Grid
{
    Children =
    {
        new SfNavigationDrawer
        {
            DrawerSettings = new DrawerSettings
            {
                Position = Position.Left
            },
            SecondaryDrawerSettings = new DrawerSettings
            {
                Position = Position.Right
            }
        },
        button
    }
};

private void OnToggleSecondaryClicked(object sender, EventArgs e)
{
    navigationDrawer.ToggleSecondaryDrawer();
}

{% endhighlight %}

{% endtabs %}

### Using the IsOpen property

Set [IsOpen](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.NavigationDrawer.DrawerSettings.html#Syncfusion_Maui_NavigationDrawer_DrawerSettings_IsOpen) on the `SecondaryDrawerSettings` to open or close the secondary drawer programmatically.

{% tabs %}

{% highlight xaml %}

<navigationDrawer:SfNavigationDrawer>
    <navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
        <navigationDrawer:DrawerSettings IsOpen="true" />
    </navigationDrawer:SfNavigationDrawer.SecondaryDrawerSettings>
</navigationDrawer:SfNavigationDrawer>

{% endhighlight %}

{% highlight c# %}

SfNavigationDrawer navigationDrawer = new SfNavigationDrawer()
{
    SecondaryDrawerSettings = new DrawerSettings
    {
        IsOpen = true
    },
};

{% endhighlight %}

{% endtabs %}

## See also

- [Setting Toggle Animations in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/toggle-animations)
- [Set Sliding Panel Content in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-content)
- [Setting Sliding Panel Size in .NET MAUI Navigation Drawer](https://help.syncfusion.com/maui/navigationdrawer/side-pane-sizing)