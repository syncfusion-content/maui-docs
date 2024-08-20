---
layout: post
title: Events in .NET MAUI Radio Button Control | Syncfusion
description: Learn about Event support in Syncfusion Essential Studio .NET MAUI Radio Button control, its elements and more.
platform: MAUI
control: SfRadioButton
documentation: ug
---

# Events in .NET MAUI Radio Button (SfRadioButton)

## StateChanged event

This event occurs when the value (state) of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property is changed by touching the check box or setting the value to the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property using XAML or C# code. The event arguments are of type [`StateChangedEventArgs`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangedEventArgs.html) and expose the following property:

* [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) : The new value(state) of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfRadioGroup x:Name="radioGroup">
        <syncfusion:SfRadioButton x:Name="check" Text="Checked State" IsChecked="True" StateChanged="RadioButton_StateChanged"/>
        <syncfusion:SfRadioButton x:Name="uncheck" Text="Unchecked  State" StateChanged="RadioButton_StateChanged"/>
    </syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

    SfRadioGroup radioGroup = new SfRadioGroup();
    SfRadioButton check = new SfRadioButton();
    check.Text = "Checked State";
    check.IsChecked = true;
    check.StateChanged += RadioButton_StateChanged;
    SfRadioButton uncheck = new SfRadioButton();
    uncheck.Text = "Unchecked State";
    uncheck.StateChanged += RadioButton_StateChanged;
    radioGroup.Children.Add(check);
    radioGroup.Children.Add(uncheck);
    this.Content = radioGroup;

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

    private void RadioButton_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
    {
        if (e.IsChecked.HasValue && e.IsChecked.Value)
        {
            (sender as SfRadioButton).Text = "Checked State";
        }
        else if (e.IsChecked.HasValue && !e.IsChecked.Value)
        {
            (sender as SfRadioButton).Text = "Unchecked State";
        }
    }
 
{% endhighlight %}
{% endtabs %}

![StateChanged event 1](Images/Event/statechanged1.png)
![StateChanged event 2](Images/Event/statechanged2.png)

## StateChanging event

The StateChanging event is triggered when the RadioButton control is tapped, indicating that the state of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property in the RadioButton control is about to change. The StateChangingEventArgs provides the following properties:

* [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) : The new value(state) of the [`IsChecked`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked) property.
* `Cancel` : Gets or sets a value indicating whether the event should be canceled.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfRadioGroup x:Name="radioGroup">
        <syncfusion:SfRadioButton x:Name="check" Text="Checked State" IsChecked="True" StateChanging="RadioButton_StateChanging"/>
        <syncfusion:SfRadioButton x:Name="uncheck" Text="Unchecked State"/>
    </syncfusion:SfRadioGroup>

{% endhighlight %}
{% highlight c# %}

    SfRadioGroup radioGroup = new SfRadioGroup();
    SfRadioButton check = new SfRadioButton();
    check.Text = "Checked State";
    check.IsChecked = true;
    check.StateChanging += RadioButton_StateChanging;
    SfRadioButton uncheck = new SfRadioButton();
    uncheck.Text = "Unchecked State";
    uncheck.StateChanging += RadioButton_StateChanging;
    radioGroup.Children.Add(check);
    radioGroup.Children.Add(uncheck);
    this.Content = radioGroup;
	
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}

    private void RadioButton_StateChanging(object sender, Syncfusion.Maui.Buttons.StateChangingEventArgs e)
    {
        e.cancel=true;
    }

{% endhighlight %}
{% endtabs %}