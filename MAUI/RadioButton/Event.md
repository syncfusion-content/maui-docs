---
layout: post
title: Events in .NET MAUI RadioButton control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio .NET MAUI RadioButton control, its elements and more.
platform: .NET MAUI
control: RadioButton
documentation: ug
---

# Event in Xamarin Radio Button (SfRadioButton)

## StateChanged event

Occurs when the value(state) of the [`IsChecked`] property is changed by either touching the check box or setting the value to the [`IsChecked`] property using XAML or C# code. The event arguments are of type [`StateChangedEventArgs`] and expose the following property:

* [`IsChecked`] : The new value(state) of the [`IsChecked`] property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfRadioGroup x:Name="radioGroup">
<syncfusion:SfRadioButton x:Name="check" Text="Checked State" IsChecked="True" StateChanged="RadioButton_StateChanged"/>
<syncfusion:SfRadioButton x:Name="uncheck" Text="Unchecked  State" StateChanged="RadioButton_StateChanged"/>
</syncfusion:SfRadioGroup>

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

![StateChanged event 1]
![StateChanged event 2]

This demo can be downloaded from this [link].

## See also

[How to notify the selection changes in Xamarin.Forms radio button (SfRadioButton)]
 
[How to get the selected Xamarin.Forms radio button (SfRadioButton)]
