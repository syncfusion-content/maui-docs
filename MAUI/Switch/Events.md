---
layout: post
title: Events in .NET MAUI Switch Control | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI Switch (SfSwitch) control and their arguments.
platform: MAUI
control: SfSwitch
documentation: UG
keywords : .net maui switch, maui switch, .net maui switch events, maui switch event.
---

# Events in .NET MAUI Switch

The .NET MAUI Switch (SfSwitch) control exposes the following events that are raised when the `IsOn` property changes:

* [`StateChanged`](#statechanged) — Raised after the state has changed.
* [`StateChanging`](#statechanging) — Raised before the state changes; can be canceled.

N> Before proceeding, ensure that the Syncfusion<sup>®</sup> MAUI Buttons package is installed and the required namespace is registered. For more information, refer to the [Getting Started](Getting-Started.md) documentation.

N> The `IsOn` property is `bool?` (nullable): `true` represents the `On` state, `false` represents the `Off` state, and `null` represents the `Indeterminate` state when [`AllowIndeterminateState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState) is enabled.

## StateChanged

The [`StateChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanged) event is raised after the state of the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property changes. The change can be triggered by tapping the .NET MAUI Switch or by setting a value to the `IsOn` property programmatically. The [SwitchStateChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_NewValue): Gets the new value of the Switch after the state has changed.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_OldValue): Gets the previous value of the Switch before the state changed.

{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" StateChanged="SfSwitch_StateChanged"/>
</ContentPage>
	
{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged += SfSwitch_StateChanged;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private async void SfSwitch_StateChanged(object sender, SwitchStateChangedEventArgs e)
{
    // Access the new and old values
    bool? newValue = e.NewValue;
    bool? oldValue = e.OldValue;

    await DisplayAlert("Alert", "Switch State Changed", "Close");
}

{% endhighlight %}

{% endtabs %}

![StateChanged event](Images/Events/Events.gif)

## StateChanging

The [`StateChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging) event is raised before the state of the [`IsOn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property changes. Set the `Cancel` property to `true` to prevent the change from being applied. The [SwitchStateChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_NewValue): Gets the value that the Switch is about to change to.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_OldValue): Gets the current value of the Switch before the change.
* `Cancel`: Gets or sets a `bool` value indicating whether the state change should be canceled. The default is `false`.

{% tabs %}

{% highlight xaml %}

<ContentPage
    xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons">
    <syncfusion:SfSwitch x:Name="sfSwitch" StateChanging="SfSwitch_StateChanging"/>
</ContentPage>
	
{% endhighlight %}

{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanging += SfSwitch_StateChanging;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

The event handler is declared in the code-behind of the page. The following example prevents the Switch from changing to the `Indeterminate` state:

{% tabs %}

{% highlight c# %}
    
private void SfSwitch_StateChanging(object sender, SwitchStateChangingEventArgs e)
{
    // Access the new and old values
    bool? newValue = e.NewValue;
    bool? oldValue = e.OldValue;

    // Cancel the state change if the new value is null (Indeterminate)
    if (newValue == null)
    {
        e.Cancel = true;
    }
}

{% endhighlight %}

{% endtabs %}