---
layout: post
title: Formatting in .NET MAUI TimePicker control | Syncfusion
description: Learn here all about Formatting support in Syncfusion .NET MAUI TimePicker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---


# Formatting in .NET MAUI TimePicker (SfTimePicker)

[`Format`]() is a way to represent the value of the time in a different string format.

By default, the TimePicker format is [`"PickerTimeFormat.HH_mm_ss"`]().

The following example demonstrates the TimePicker with the custom format [`PickerTimeFormat.hh_mm_ss_tt`]()

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:TimePickerSample"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="TimePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfTimePicker Format="hh_mm_ss_tt"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace TimePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfTimePicker timePicker = new SfTimePicker()
            {
                Format = PickerTimeFormat.hh_mm_ss_tt;
            };

            this.Content = timePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![TimeFormat]()
