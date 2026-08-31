---
layout: post
title: Selection in .NET MAUI Date Picker control | Syncfusion®
description: Learn about selection in Syncfusion® .NET MAUI Date Picker control to manage selected date and programmatic selection.
platform: maui
control: SfDatePicker
documentation: ug
---

# Selection in .NET MAUI Date Picker control

## Set selected date to the Date Picker

The SfDatePicker control allows you to select the date using the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate) property in the [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). The default value of the `SelectedDate` is the current date.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="5" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="datePicker"
                         SelectedDate="9/7/2023">
    </picker:SfDatePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="6" %}

using Syncfusion.Maui.Picker;

. . .
SfDatePicker datePicker = new SfDatePicker()
{
    SelectedDate = new DateTime(2023, 9, 7).Date,
};

this.Content = datePicker;

{% endhighlight %}
{% endtabs %}

![Set Selected date in .NET MAUI Date picker.](images/getting-started/maui-date-picker-selected-date.png)

## Clear selection

The SfDatePicker provides clear selection support, allowing you to clear the selected date by setting the `SelectedDate` property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
             . . .
             xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="datePicker" />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Picker;

. . .
this.datePicker.SelectedDate = null;

{% endhighlight %}
{% endtabs %}