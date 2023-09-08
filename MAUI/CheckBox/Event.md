---
layout: post
title: Events in .NET MAUI CheckBox control | Syncfusion
description: Learn about Events support in Syncfusion Essential Studio .NET MAUI CheckBox control, its elements and more.
platform: .NET MAUI
control: CheckBox
documentation: ug
---

# Events in .NET MAUI CheckBox

## StateChanged event

Occurs when the value(state) of the [`IsChecked`] property is changed by either touching the check box or setting the value to the [`IsChecked`] property using XAML or C# code. The event arguments are of type [`StateChangedEventArgs`] and expose the following property:

* [`IsChecked`]: The new value(state) of the [`IsChecked`] property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfCheckBox x:Name="checkBox" Text="Unchecked State" IsThreeState="True" StateChanged="CheckBox_StateChanged"/>

{% endhighlight %}
{% highlight c# %}

SfCheckBox checkBox = new SfCheckBox();
checkBox.Text = "Unchecked State";
checkBox.IsThreeState = true;
checkBox.StateChanged += CheckBox_StateChanged;
	
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

![Checked state image](Images/Event1.png)
![Unchecked state image](Images/Event2.png)
![Indeterminate state image ](Images/Event3.png)

## See also

[How to get the values of selected checkboxes in a group using Syncfusion.Maui.Buttons]
