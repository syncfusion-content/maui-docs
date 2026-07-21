---
layout: post
title: Events in .NET MAUI Radial Menu Control | Syncfusion®
description: Learn about Events in Syncfusion® .NET MAUI Radial Menu (SfRadialMenu) control, its elements and more.
platform: MAUI
control: SfRadialMenu
documentation: UG
---

# Events in .NET MAUI Radial Menu (SfRadialMenu)

## Prerequisites

Before using the [SfTabView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.RadialMenu`

For step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/radial-menu/getting-started) documentation.

## Overview

`SfRadialMenu` raises a set of events that you can subscribe to in order to react to user interaction, navigation, and life cycle changes. This document describes each event, the arguments it provides, and shows how to wire it up in both XAML and C#.

## Events Summary

| Event | Raised when | Cancelable | `EventArgs` |
| --- | --- | --- | --- |
| `Navigating` | Before the menu moves to the next or previous level. | Yes | `NavigatingEventArgs` |
| `Navigated` | After the menu has moved to a new level. | No | `NavigatedEventArgs` |
| `Opening` | When the menu begins to open. | No | `OpeningEventArgs` |
| `Opened` | When the menu has fully opened. | No | `OpenedEventArgs` |
| `Closing` | When the menu begins to close. | No | `ClosingEventArgs` |
| `Closed` | When the menu has fully closed. | No | `ClosedEventArgs` |
| `CenterButtonBackTapped` | When the center back button is tapped. | No | `CenterButtonBackTappedEventArgs` |
| `ItemTapped` (on `SfRadialMenuItem`) | When an item is tapped. | No | `ItemTappedEventArgs` |
| `TouchDown` (on `SfRadialMenuItem`) | When the user presses an item. | No | `RadialMenuItemEventArgs` |
| `TouchUp` (on `SfRadialMenuItem`) | When the user releases the press on an item. | No | `RadialMenuItemEventArgs` |

The two `ItemTapped`, `TouchDown`, and `TouchUp` events are raised by `SfRadialMenuItem`, not by `SfRadialMenu`. Subscribe to them on the item instance, not on the menu.

## Handle the Navigating and Navigated events

Use these events to react when the Radial Menu moves between levels. The [`Navigating`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Navigating) event occurs when moving from one level to another (and is cancelable), and the [`Navigated`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Navigated) event triggers after reaching the new level. Events fire in this order: `Navigating` → `Navigated`.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu Navigating="SfRadialMenu_Navigating" 
                            Navigated="SfRadialMenu_Navigated">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.Navigating += SfRadialMenu_Navigating;
radialMenu.Navigated += SfRadialMenu_Navigated;

private async void SfRadialMenu_Navigating(object sender, NavigatingEventArgs e)
{
    await DisplayAlert("Alert", "ItemNavigating", "Ok");
}

private async void SfRadialMenu_Navigated(object sender, NavigatedEventArgs e)
{
    await DisplayAlert("Alert", "ItemNavigated", "Ok");
}

{% endhighlight %}

{% endtabs %}

> You can cancel navigation by setting `e.Cancel = true` in the `Navigating` handler. The example below prevents the menu from entering the next level if the new level has no items.

{% tabs %}

{% highlight C# %}
private void SfRadialMenu_Navigating(object sender, NavigatingEventArgs e)
{
    if (e.TargetLevel == null || e.TargetLevel.Items.Count == 0)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}

{% endtabs %}

| `NavigatingEventArgs` property | Description |
| --- | --- |
| `Cancel` | When set to `true`, prevents the navigation from occurring. |
| `SourceLevel` | The level the menu is navigating away from. |
| `TargetLevel` | The level the menu is navigating to. |

| `NavigatedEventArgs` property | Description |
| --- | --- |
| `SourceLevel` | The level the menu navigated away from. |
| `TargetLevel` | The level the menu navigated to. |

## Handle the Opening and Opened events

You can react when the Radial Menu opens. The [`Opening`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Opening) event occurs when the Radial Menu begins to open, and the [`Opened`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Opened) event occurs once it is fully open. Neither event is cancelable.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu Opening ="SfRadialMenu_Opening" 
                            Opened="SfRadialMenu_Opened">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.Opening += SfRadialMenu_Opening;
radialMenu.Opened += SfRadialMenu_Opened;

private async void SfRadialMenu_Opening(object sender, OpeningEventArgs e)
{
    await DisplayAlert("Alert", "ItemOpening", "Ok");
}

private async void SfRadialMenu_Opened(object sender, OpenedEventArgs e)
{
    await DisplayAlert("Alert", "ItemOpened", "Ok");
}

{% endhighlight %}

{% endtabs %}

| `OpeningEventArgs` / `OpenedEventArgs` property | Description |
| --- | --- |
| `IsOpen` | `true` when the menu is in the open state (provided on `Opened`). |
| `Cancel` | Reserved; setting this has no effect on the open life cycle. |

## Handle the Closing and Closed events

You can perform an action when closing the Radial Menu. The [`Closing`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Closing) event occurs when the Radial Menu begins to close, and the [`Closed`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_Closed) event occurs once it is completely closed. Neither event is cancelable; to stop the menu from closing, intercept the `Closing` event in a subclass and skip the base call.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu  Closing ="SfRadialMenu_Closing" 
                            Closed="SfRadialMenu_Closed">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.Closing += SfRadialMenu_Closing;
radialMenu.Closed += SfRadialMenu_Closed;

private async void SfRadialMenu_Closing(object sender, ClosingEventArgs e)
{
    await DisplayAlert("Alert", "ItemClosing", "Ok");
}

private async void SfRadialMenu_Closed(object sender, ClosedEventArgs e)
{
    await DisplayAlert("Alert", "ItemClosed", "Ok");
}

{% endhighlight %}
{% endtabs %}

| `ClosingEventArgs` / `ClosedEventArgs` property | Description |
| --- | --- |
| `Cancel` | Reserved; setting this has no effect on the close life cycle. |
| `IsOpen` | `false` when the menu has fully closed (provided on `Closed`). |

## Handle the CenterButtonBackTapped event

You can react when the user taps the center back button of the Radial Menu. The [`CenterButtonBackTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenu.html#Syncfusion_Maui_RadialMenu_SfRadialMenu_CenterButtonBackTapped) event occurs when the center back button is tapped. The event is raised only when the back button is visible (i.e. when the menu is on a sub-level).

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu CenterButtonBackTapped="SfRadialMenu_CenterButtonBackTapped">
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.CenterButtonBackTapped += SfRadialMenu_CenterButtonBackTapped;

private async void SfRadialMenu_CenterButtonBackTapped(object sender, CenterButtonBackTappedEventArgs e)
{
    await DisplayAlert("Alert", "CenterButtonTapped", "Ok");
}

{% endhighlight %}

{% endtabs %}

## Handle the ItemTapped event

You can react when the user taps an item in the Radial Menu. The [`ItemTapped`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html#Syncfusion_Maui_RadialMenu_SfRadialMenuItem_ItemTapped) event is an item-level event on `SfRadialMenuItem` and is triggered when any item in the Radial Menu is tapped. The `ItemTappedEventArgs` payload exposes the tapped item and its level.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu>
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12" ItemTapped="SfRadialMenuItem_ItemTapped"/>
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>
 
 {% endhighlight %}

 {% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.Items[0].ItemTapped += SfRadialMenuItem_ItemTapped;

private async void SfRadialMenuItem_ItemTapped(object sender, Syncfusion.Maui.RadialMenu.ItemTappedEventArgs e)
{
    await DisplayAlert("Alert", "ItemTapped", "Ok");
}

{% endhighlight %}

{% endtabs %}


## Handle the TouchDown and TouchUp events

You can react to the user pressing and releasing an item. The [`TouchDown`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html?tabs=tabid-1#Syncfusion_Maui_RadialMenu_SfRadialMenuItem_TouchDown) event occurs when the user presses the item, and the [`TouchUp`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RadialMenu.SfRadialMenuItem.html?tabs=tabid-1#Syncfusion_Maui_RadialMenu_SfRadialMenuItem_TouchUp) event occurs when the user releases the press. Both events are item-level and are only raised while the menu is open.

{% tabs %}

{% highlight xaml %}

<radialMenu:SfRadialMenu>
    <radialMenu:SfRadialMenu.Items>
        <radialMenu:SfRadialMenuItem Text="Bold" FontSize="12" TouchDown="SfRadialMenuItemTouchDown" TouchUp="SfRadialMenuItemTouchUp" />
        <radialMenu:SfRadialMenuItem Text="Copy" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Undo" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Paste" FontSize="12"/>
        <radialMenu:SfRadialMenuItem Text="Color" FontSize="12"/>
    </radialMenu:SfRadialMenu.Items>
</radialMenu:SfRadialMenu>

{% endhighlight %}

{% highlight C# %}

SfRadialMenu radialMenu = new SfRadialMenu()
{
    Items =  new RadialMenuItemsCollection()
    {
        new SfRadialMenuItem() { Text = "Bold", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Copy", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Paste", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Undo", FontSize = 12 },
        new SfRadialMenuItem() { Text = "Color", FontSize = 12 },
    },
};

radialMenu.Items[0].TouchDown += SfRadialMenuItemTouchDown;
radialMenu.Items[0].TouchUp += SfRadialMenuItemTouchUp;

private async void SfRadialMenuItemTouchDown(object? sender, RadialMenuItemEventArgs e)
{
    await DisplayAlert("Alert", "The RadialMenuItem is pressed.", "Ok");
}

private async void SfRadialMenuItemTouchUp(object? sender, RadialMenuItemEventArgs e)
{
    await DisplayAlert("Alert", "The RadialMenuItem is released.", "Ok");
}

{% endhighlight %}

{% endtabs %}

## Troubleshooting

| Issue | Likely cause | Fix |
| --- | --- | --- |
| Event handler never fires. | The event is not wired up, or the menu was constructed without an `Items` collection. | Verify the `+=` subscription is on the correct instance and that `Items` is populated before the menu is shown. |
| `TouchDown` / `TouchUp` do not fire. | The menu is closed when the press happens, or the touch occurred outside any item. | Open the menu and tap directly on an item. |
| Item-level event fires on every item instead of one. | The event was subscribed on the menu (`SfRadialMenu`) instead of the item (`SfRadialMenuItem`). | Subscribe on the `SfRadialMenuItem` instance, not on the menu. |
| Unhandled exception in `async void` handler. | `DisplayAlert` was awaited without a `try`/`catch`. | Wrap the body in a `try`/`catch` and log or swallow the exception. |
| `CenterButtonBackTapped` does not fire. | The menu is on the root level (no back button is shown). | Navigate to a sub-level before tapping the back button. |
| `e.Cancel` has no effect. | The event is not cancelable (e.g., `Navigated`, `Opening`, `Closing`, `Closed`). | Only `Navigating` is cancelable in `SfRadialMenu`. |

## See also


- [Getting Started with .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/getting-started)
- [SfRadialMenuItem’s Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/sfradialmenuitem-customization)
- [Segmenting and Placing Items in .NET MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/segmenting-placing-items)
- [CenterButton Customization in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/centerbutton-customization)
- [Placing and Dragging in MAUI Radial Menu](https://help.syncfusion.com/maui/radial-menu/place-and-drag-radialmenu)