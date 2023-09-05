---
layout: post
title: Date Restriction in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about Date Restriction support in Syncfusion .NET MAUI DatePicker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---


# Date Restriction in .NET MAUI DatePicker (SfDatePicker)

DatePicker provides an option to select a date value within a specified range by using the [`MinimumDate`]() and [`MaximumDate`]() properties. Always the [`MinimumDate`]() value has to be lesser than the [`MaximumDate`]() value.

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker"
                                 MinimumDate="1/1/2020"
                                 MaximumDate="12/31/2030"/>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}

{% highlight c# %}  

using Syncfusion.Maui.Picker;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfDatePicker datePicker = new SfDatePicker()
            {
                MinimumDate = new System.DateTime(2020, 1, 1),
                MaximumDate = new System.DateTime(2030, 12, 31)
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![MinimumDate of SfDatePicker]()
![MaximumDate of SfDatePicker]()

