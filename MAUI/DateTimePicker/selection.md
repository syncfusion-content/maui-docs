---
layout: post
title: Selection in .NET MAUI Date Time Picker Control | Syncfusion®
description: Learn about Selection in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Selection in .NET MAUI Date Time Picker (SfDateTimePicker)

## Set selected date and selected time to the Date Time Picker

The SfDateTimePicker control allows you to select the date and time by using the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) property in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). The default value of the `SelectedDate` is the current date and time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker" 
                         SelectedDate="9/7/2023 10:15:22">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

SfDateTimePicker picker = new SfDateTimePicker()
{
    SelectedDate = new DateTime(2023, 09, 07, 10, 15, 22),
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

   ![Set selected date in .NET MAUI Date Time picker.](images/getting-started/maui-date-time-picker-set-selected-date.png)

## Clear selection

The .NET MAUI DateTimePicker provides clear selection support, allowing you to clear the selected date and time by setting the `SelectedDate` property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfDateTimePicker x:Name="picker" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.Picker.SelectedDate = null;

{% endhighlight %}  
{% endtabs %}