---
layout: post
title: DatePicker with .NET MAUI Picker control | Syncfusion
description: Learn here all about date picker with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Picker in .NET MAUI Picker (SfDatePicker)

This section explains about the date picker.

## DatePicker customization

The `SfDatePicker` supports to customize [DateFormat], [MinimumDate], [MaximumDate], [DayInterval], [MonthInterval], [YearInterval], [SelectedDate] properties by the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:datePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <datePicker:SfDatePicker x:Name="datePicker"                                
                                     Format="dd_MMM_yyyy"
                                     MinimumDate="01/08/2023" 
                                     MaximumDate="01/12/2023"
                                     DayInterval="2"
                                     MonthInterval="2"
                                     YearInterval="2">
    </datePicker:SfDatePicker>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

{% tabs %}
{% highlight xaml tabtitle="c#" %}

    datePicker.Format = PickerDateFormat.dd_MM_yyyy;
    datePicker.MinimumDate = new DateTime(01 / 09 / 2023);
    datePicker.MaximumDate = new DateTime(01 / 12 / 2023);
    datePicker.SelectedDate = DateTime.Now;
    datePicker.DayInterval = 2;
    datePicker.MonthInterval = 2;
    datePicker.YearInterval = 2;
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

