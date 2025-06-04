---
layout: post
title: Date Interval in .NET MAUI Date Picker Control – Syncfusion<sup>&reg;</sup>
description: Learn about date interval in Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Interval in .NET MAUI Date Picker(SfDatePicker)

The `SfDatePicker` provides three types of intervals in the [.NET MAUI Date Picker](https://www.syncfusion.com/maui-controls/maui-datepicker).

 * [`DayInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval)
 * [`MonthInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval)
 * [`YearInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval)

## Day interval

The Date Picker provides an option to set an interval between days using the [DayInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval) property of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     DayInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    DayInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Day interval in .NET MAUI Date Picker.](images/intervals/maui-date-picker-day-interval.png)

## Month interval

The Date Picker provides an option to set an interval between months using the [MonthInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval) property of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     MonthInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    MonthInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Month interval in .NET MAUI Date Picker.](images/intervals/maui-date-picker-month-interval.png)

## Year interval

The Date Picker provides an option to set an interval between years using the [YearInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval) property of [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     YearInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    YearInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Year interval in .NET MAUI Date Picker.](images/intervals/maui-date-picker-year-interval.png)
