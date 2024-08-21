---
layout: post
title: Events in .NET MAUI Switch Control | Syncfusion
description: Learn about Event support in the Syncfusion .NET MAUI Switch control, its elements, and more.
platform: maui
control: SfSwitch
documentation: ug
keywords : .net maui switch, maui switch, .net maui switch events, maui switch event.
---

# Events in .NET MAUI Switch

This section provides information about the events available in the .NET MAUI Switch control.

## StateChanged event

The StateChanged event occurs when the value or state of [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property is changed by tapping the .NET MAUI Switch button or setting a value to `IsOn` property. The [SwitchStateChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_NewValue) : Gets the current value of the .NET MAUI Switch control.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangedEventArgs_OldValue) : Gets the previous value of the .NET MAUI Switch control.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch StateChanged="SfSwitch_StateChanged"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanged+= SfSwitch_StateChanged;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private async void SfSwitch_StateChanged(object sender, SwitchStateChangedEventArgs e)
{
    // Access the new and old values
    bool? newValue = e.NewValue;
    bool? oldValue = e.OldValue?;

    await DisplayAlert("Alert", "Switch State Changed", "close");
}

{% endhighlight %}

{% endtabs %}

![SwitchStateChangedEventArgs](images/Events/Events.gif)

## StateChanging event

The StateChanging event occurs when the state of [IsOn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn) property is about to change in the .NET MAUI Switch control. The [SwitchStateChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html) provides the following properties:

* [NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_NewValue) : Gets the current value of the .NET MAUI Switch control.
* [OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html#Syncfusion_Maui_Buttons_SwitchStateChangingEventArgs_OldValue) : Gets the previous value of the .NET MAUI Switch control.
* `Cancel` : Gets or sets a value indicating whether the event should be canceled.

{% tabs %}

{% highlight xaml %}

<syncfusion:SfSwitch StateChanging="SfSwitch_StateChanging"/>
	
{% endhighlight %}

{% highlight C# %}

SfSwitch sfSwitch = new SfSwitch();
sfSwitch.StateChanging += SfSwitch_StateChanging;
this.Content = sfSwitch;

{% endhighlight %}

{% endtabs %}

{% tabs %}

{% highlight c# %}
    
private void SfSwitch_StateChanging(object sender, SwitchStateChangingEventArgs e)
{
    // Access the new and old values
    bool? newValue = e.NewValue;
    bool? oldValue = e.OldValue;

    // Cancel the event if needed
    if (newValue == null)
    {
        e.Cancel = true;
    }
}

{% endhighlight %}

{% endtabs %}