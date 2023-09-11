---
layout: post
title: Formatting in .NET MAUI DatePicker control | Syncfusion
description: Learn here all about Formatting support in Syncfusion .NET MAUI DatePicker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# Formatting in .NET MAUI DatePicker (SfDatePicker)

Format is a way to represent the value of the date in a different string format.

By default, the DatePicker format is "[PickerDateFormat.yyyy_MM_dd]()".

The different types of formats are:

[M_d_yyyy]() - Represents the month day year in m/d/yyyy format.

[MM_dd_yyyy]() - Represents the month day year in mm/dd/yyyy format.

[yyyy_MM_dd]() - Represents the year month day in yyyy/mm/dd format.

[dd_MMM_yyyy]() - Represents the day month year in dd/mmm/yyyy format.

[dd_MM_yyyy]() - Represents the day month year in dd/MM/yyyy format.

[dd_MM]() - Represents the day month in dd/MM format.

[MM_yyyy]() - Represents the month year in MM/yyyy format.

[MMM_yyyy]() - Represents the month year in MMM/yyyy format

The following example demonstrates the DatePicker with the custom format [PickerDateFormat.MM_dd_yyyy]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datepicker" Format="MM_dd_yyyy"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    Format = PickerDateFormat.MM_dd_yyyy,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Format of SfDatePicker]()
