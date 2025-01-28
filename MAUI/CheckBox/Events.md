---
layout: post
title: Events in .NET MAUI CheckBox Control | Syncfusion®
description: Learn about Event support in Syncfusion® Essential Studio® .NET MAUI CheckBox control, its elements and more.
platform: maui
control: SfCheckBox
documentation: ug
---

# Events in .NET MAUI CheckBox

## StateChanged event

This event occurs when the value or state of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property is changed by touching the check box or setting the value to the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property using XAML or C# code. The event arguments are of type [`StateChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangedEventArgs.html) and expose the following property:

* [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) : The new value(state) of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property.


{% tabs %}
{% highlight xaml %}

<syncfusion:SfCheckBox x:Name="checkBox" Text="Unchecked State" IsThreeState="True" StateChanged="CheckBox_StateChanged"/>

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
    else if(e.IsChecked.HasValue && !e.IsChecked.Value)
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

![.NET MAUI CheckBox](Images/Getting-Started/tristate.png)

## StateChanging event

The [StateChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangingEventArgs.html) event is triggered when the state of the [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) property is about to change by tapping the CheckBox control. The event arguments are of type `StateChangingEventArgs` and provide the following properties:

* [IsChecked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfCheckBox.html#Syncfusion_Maui_Buttons_SfCheckBox_IsChecked) : The new value(state) of the `IsChecked` property.
* `Cancel` : Gets or sets a value indicating whether the event should be canceled.

{% tabs %}
{% highlight xaml %}

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
    e.cancel=true;
}

{% endhighlight %}
{% endtabs %}