---
layout: post
title: DateTimePicker with .NET MAUI Picker control | Syncfusion
description: Learn here all about date time picker with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# DateTime Picker in .NET MAUI Picker (SfDateTimePicker)

This section explains about the time picker.

## DateTimePicker customization

The `SfDateTimePicker` supports to customize [HourInterval], [MinuteInterval], [SecondInterval], [DateFormat], [TimeFormat], [MinimumDate], [MaximumDate], [DayInterval], [MonthInterval], [YearInterval], [SelectedDate] properties by the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:dateTimePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <dateTimePicker:SfDateTimePicker x:Name="dateTimePicker"
                                     HourInterval="2"
                                     MinuteInterval="2"
                                     SecondInterval="2"
                                     DateFormat="dd_MMM_yyyy" TimeFormat="hh_mm_ss_tt"
                                     MinimumDate="01/08/2023" 
                                     MaximumDate="01/12/2023"
                                     DayInterval="2"
                                     MonthInterval="2"
                                     YearInterval="2">
    </dateTimePicker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

        dateTimePicker.HourInterval = 2;
        dateTimePicker.MinuteInterval = 2;
        dateTimePicker.SecondInterval = 2;
        dateTimePicker.TimeFormat = PickerTimeFormat.hh_mm_ss_tt;
        dateTimePicker.DateFormat = PickerDateFormat.dd_MM_yyyy;
        dateTimePicker.MinimumDate = new DateTime(01 / 09 / 2023);
        dateTimePicker.MaximumDate = new DateTime(01 / 12 / 2023);
        dateTimePicker.SelectedDate = DateTime.Now;
        dateTimePicker.DayInterval = 2;
        dateTimePicker.MonthInterval = 2;
        dateTimePicker.YearInterval = 2;
        
{% endhighlight %}
{% endtabs %}

