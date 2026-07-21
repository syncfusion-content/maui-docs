---
layout: post
title: Events in .NET MAUI CheckBox Control | Syncfusion®
description: Learn about event support in Syncfusion® Essential Studio® .NET MAUI CheckBox control, its elements, and more.
platform: MAUI
control: SfCheckBox
documentation: UG
---

# Events in .NET MAUI CheckBox

## Prerequisites

Before using the [SfCheckBox](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.Buttons`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/checkbox/getting-started) documentation.

## StateChanged event

The [`StateChanged`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_StateChanged) event occurs when the value of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property changes, either by user interaction or programmatically through XAML or C# code. The event arguments are of type [`StateChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangedEventArgs.html), exposing the following property:

* [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangedEventArgs.html#Syncfusion_Maui_Buttons_StateChangedEventArgs_IsChecked) (bool?) : The new checked state of the CheckBox. Returns `true` when checked, `false` when unchecked, and `null` when the CheckBox is in an indeterminate state (requires [`IsThreeState`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsThreeState) to be enabled).

N> The example below mutates the CheckBox's `Text` inside the handler to visually demonstrate the new state. Place the handler in the same code-behind class as the `x:Name="checkBox"` instance.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfCheckBox x:Name="checkBox" 
                       Text="Unchecked State" IsThreeState="True" StateChanged="CheckBox_StateChanged"/>

{% endhighlight %}
{% highlight c# %}

SfCheckBox checkBox = new SfCheckBox();
checkBox.Text = "Unchecked State";
checkBox.IsThreeState = true;
checkBox.StateChanged += CheckBox_StateChanged;
this.Content = checkBox;
	
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

private void CheckBox_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
{
    if (e.IsChecked.HasValue && e.IsChecked.Value)
    {
        checkBox.Text = "Checked State";
    }
    else if (e.IsChecked.HasValue && !e.IsChecked.Value)
    {
        checkBox.Text = "Unchecked State";
    }
    else
    {
        checkBox.Text = "Indeterminate State";
    }
}

{% endhighlight %}
{% endtabs %}

![.NET MAUI CheckBox showing the three states of SfCheckBox](Images/Events/tristate.png)

## StateChanging event

The [`StateChanging`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_StateChanging) event is triggered when the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property is about to change, either by user interaction (tapping) or programmatically. The event arguments are of type [`StateChangingEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangingEventArgs.html), providing the following properties:

* [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangingEventArgs.html#Syncfusion_Maui_Buttons_StateChangingEventArgs_IsChecked) (bool?) : The new checked state the CheckBox is about to take.

{% tabs %}
{% highlight xaml %}

xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

<syncfusion:SfCheckBox x:Name="checkBox" Text="CheckBox" StateChanging="OnStateChanging"/>

{% endhighlight %}
{% highlight c# %}

SfCheckBox checkBox = new SfCheckBox();
checkBox.Text = "CheckBox";
checkBox.StateChanging += OnStateChanging;
this.Content = checkBox;
	
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

private void OnStateChanging(object sender, StateChangingEventArgs e)
{
    // Cancel the state change.
    e.Cancel = true;
}

{% endhighlight %}
{% endtabs %}