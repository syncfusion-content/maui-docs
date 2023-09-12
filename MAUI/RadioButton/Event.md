---
layout: post
title: Event in .NET MAUI Radio Button control | Syncfusion
description: Learn about Event support in Syncfusion Essential Studio .NET MAUI Radio Button control, its elements and more.
platform: Maui
control: Radio Button
documentation: ug
---

# Event in .NET MAUI Radio Button (SfRadioButton)

## StateChanged event

Occurs when the value(state) of the [`IsChecked`] property is changed by either touching the check box or setting the value to the [`IsChecked`] property using XAML or C# code. The event arguments are of type [`StateChangedEventArgs`] and expose the following property:

* [`IsChecked`] : The new value(state) of the [`IsChecked`] property.

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
