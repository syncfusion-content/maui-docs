---
layout: post
title: TimePicker with .NET MAUI Picker control | Syncfusion
description: Learn here all about time picker with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Picker in .NET MAUI Picker (SfPicker)

This section explains about the time picker.

## TimePicker customization

The `SfTimePicker` supports to customize [HourInterval], [MinuteInterval], [SecondInterval], [Format] and [SelectedTime] properties by the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:timePicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="Picker_29.MainPage">

    <timePicker:SfTimePicker x:Name="timePicker" 
                             HourInterval="2"
                             MinuteInterval="2"
                             SecondInterval="2"
                             Format="hh_mm_ss_tt">
    </timePicker:SfTimePicker>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    timePicker.HourInterval = 2;
    timePicker.MinuteInterval = 2;
    timePicker.SecondInterval = 2;
    timePicker.Format = PickerTimeFormat.hh_mm_ss_tt;
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

