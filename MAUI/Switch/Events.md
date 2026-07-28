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

The [.NET MAUI Switch](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html) control exposes the following events that are raised when the `IsOn` property changes.

- [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanged)
- [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging)

## Prerequisites

Before using the [`SfSwitch`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/switch/getting-started) documentation.

## StateChanged

The [StateChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanged) event is raised after the state of the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property changes. The change can be triggered by tapping the .NET MAUI Switch or by setting a value to the `IsOn` property programmatically. The [SwitchStateChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_NewValue): Gets the new value of the Switch after the state has changed.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_OldValue): Gets the previous value of the Switch before the state changed.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch"
                     StateChanged="SfSwitch_StateChanged"/>
	
{% endhighlight %}
{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged += SfSwitch_StateChanged;
this.Content = sfSwitch;

{% endhighlight %}
{% endtabs %}

The `StateChanged` event can be handled in C# as follows:

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

The [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging) event is raised before the state of the [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property changes. Set the `Cancel` property to `true` to prevent the change from being applied. The [SwitchStateChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_NewValue): Gets the value that the Switch is about to change to.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_OldValue): Gets the current value of the Switch before the change.
* `Cancel`: Gets or sets a `bool` value indicating whether the state change should be canceled. The default is `false`.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfSwitch x:Name="sfSwitch"
                     StateChanging="SfSwitch_StateChanging"/>

{% endhighlight %}
{% highlight c# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanging += SfSwitch_StateChanging;
this.Content = sfSwitch;

{% endhighlight %}
{% endtabs %}

The `StateChanging` event can be handled in C# as follows. The following example prevents the Switch from changing to the `Indeterminate` state:

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

## See Also

- [Customization in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/customization)
- [States in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/states)
- [Visual state manager in .NET MAUI Switch](https://help.syncfusion.com/maui/switch/visual-state-manager)