---
layout: post
title: Selection in .NET MAUI Date Time Picker Control | Syncfusion®
description: Learn about Selection in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Selection in .NET MAUI Date Time Picker (SfDateTimePicker)

## Set the selected date and time

The SfDateTimePicker control lets you select a date and time using the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) property of the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). The default value of `SelectedDate` is the current date and time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker" 
                             SelectedDate="9/7/2023 10:15:22">
    </picker:SfDateTimePicker>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        SfDateTimePicker picker = new SfDateTimePicker()
        {
            SelectedDate = new DateTime(2023, 09, 07, 10, 15, 22),
        };
        this.Content = picker;
    }
}

{% endhighlight %}
{% endtabs %}

   ![Set selected date in .NET MAUI Date Time picker.](images/getting-started/maui-date-time-picker-set-selected-date.png)

## Clear selection

The [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html) provides a clear selection feature that allows users to clear the selected date and time by setting the [SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate) property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:picker="clr-namespace:Syncfusion.Maui.Picker;assembly=Syncfusion.Maui.Picker">
    <picker:SfDateTimePicker x:Name="picker" />
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.Picker;
. . .
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.picker.SelectedDate = null;
    }
}

{% endhighlight %}
{% endtabs %}