---
layout: post
title: Selection in .NET MAUI Date Picker Control | Syncfusion
description: Learn about Selection in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# Selection in .NET MAUI Date Picker (SfDatePicker)

## Prerequisites

Before proceeding, ensure the [Syncfusion.Maui.Picker](https://www.nuget.org/packages/Syncfusion.Maui.Picker) NuGet package is installed and the Syncfusion<sup>&reg;</sup> handler is registered. For details, refer to the [Getting Started with .NET MAUI Date Picker](getting-started.md) documentation.

> **Version compatibility:** The APIs shown in this documentation require .NET MAUI 9.0 or later and Syncfusion<sup>&reg;</sup> MAUI Picker NuGet package version 30.x.x or later.

## Set selected date

The SfDatePicker control allows you to set a date using the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate) property of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html). The `SelectedDate` property is of type `DateTime?` (nullable); if no value is assigned, the current date is applied at runtime.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="picker" 
                         SelectedDate="2023-09-07">
    </picker:SfDatePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker picker = new SfDatePicker()
{
    SelectedDate = new DateTime(2023, 9, 7),
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

> **Note:** The XAML date string `"2023-09-07"` uses the culture-invariant `yyyy-MM-dd` format to avoid locale-specific parsing differences (for example, `9/7/2023` can be interpreted as either September 7 or July 9 depending on the device culture).

![Set Selected date in .NET MAUI Date picker.](images/getting-started/maui-date-picker-selected-date.png)

## Clear selection

The SfDatePicker provides clear selection support, allowing you to clear the selected date by setting the `SelectedDate` property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDatePicker x:Name="picker" />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.picker.SelectedDate = null;

{% endhighlight %}  
{% endtabs %}