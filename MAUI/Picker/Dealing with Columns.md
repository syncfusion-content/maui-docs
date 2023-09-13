---
layout: post
title: Columns with .NET MAUI Picker control | Syncfusion
description: Learn here all about columns with Syncfusion .NET MAUI Picker (SfPicker) control.
platform: maui
control: SfPicker
documentation: ug
---

# Dealing with Columns in .NET MAUI Picker (SfPicker)

This section explains about the customization of picker columns

## Columns customization 

You can customize various properties, including `DisplayMemberPath`, `Width`, `SelectedIndex`, `ItemsSource`, and `HeaderText` for enhanced control and flexibility by the following code.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<?xml version="1.0" encoding="utf-8" ?>
    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                xmlns:sfPicker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
                x:Class="Picker_29.MainPage">
    <sfPicker:SfPicker x:Name="picker">
    </sfPicker:SfPicker>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    picker.Columns[0].SelectedIndex = 5;
    picker.Columns[0].HeaderText = "Languages";
    ObservableCollection<string> languages = new ObservableCollection<string> { "Spanish", "French", "Tamil", "English", "German", "Chinese", "Telegu", "Japanese", "Arabic", "Russian", "Portuguese", "Italian" };
    picker.Columns[0].ItemsSource = languages;
    picker.Columns[0].Width = 150;
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

