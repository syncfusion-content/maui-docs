---
layout: post
title: Formatting in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about Formatting support in Syncfusion .NET MAUI DatePicker (SfDatePicker) control and more.
platform: maui
control: DatePicker
documentation: ug
---

# Formatting in .NET MAUI DatePicker (SfDatePicker)

Format is a way to represent the value of the date in a different string format.

By default, the DatePicker format is "[`PickerDateFormat.yyyy_MM_dd`]()".

The different types of formats are:

[`M_d_yyyy`]() - Represents the month day year in m/d/yyyy format.

[`MM_dd_yyyy`]() - Represents the month day year in mm/dd/yyyy format.

[`yyyy_MM_dd`]() - Represents the year month day in yyyy/mm/dd format.

[`dd_MMM_yyyy`]() - Represents the day month year in dd/mmm/yyyy format.

[`dd_MM_yyyy`]() - Represents the day month year in dd/MM/yyyy format.

[`dd_MM`]() - Represents the day month in dd/MM format.

[`MM_yyyy`]() - Represents the month year in MM/yyyy format.

[`MMM_yyyy`]() - Represents the month year in MMM/yyyy format

The following example demonstrates the DatePicker with the custom format [`PickerDateFormat.MM_dd_yyyy`]().

{% tabs %}

{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker"
             x:Class="DatePickerSample.MainPage">
    <ContentPage.Content>
        <syncfusion:SfDatePicker x:Name="datepicker"
                                 Format="MM_dd_yyyy"/>
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
                Format = PickerDateFormat.MM_dd_yyyy,
            };

            this.Content = datePicker;
        }
    }
}

{% endhighlight %}

{% endtabs %}

![Format of SfDatePicker]()
