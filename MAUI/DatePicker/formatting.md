---
layout: post
title: Formatting in .NET MAUI Date Picker Control | Syncfusion
description: Learn about formatting support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Formatting in .NET MAUI Date Picker (SfDatePicker)

Format is a way to represent the date in a different string format. You can customize the date format using the [Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_Format) property in [PickerDateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html). The default format is `yyyy_MM_dd`.

The different types of formats are:

[`dd_MM`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_dd_MM) - Represents the day month in dd/MM format.

[`dd_MM_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_dd_MM_yyyy) - Represents the day month year in dd/MM/yyyy format.

[`dd_MMM_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_dd_MMM_yyyy) - Represents the day month year in dd/MMM/yyyy format.

[`M_d_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_M_d_yyyy) - Represents the month day year in M/d/yyyy format.

[`MM_dd_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_MM_dd_yyyy) - Represents the month day year in MM/dd/yyyy format.

[`MM_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_MM_yyyy) - Represents the month year in MM/yyyy format.

[`MMM_yyyy`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_MMM_yyyy) - Represents the month year in MMM/yyyy format.

[`yyyy_MM_dd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_yyyy_MM_dd) - Represents the year month day in yyyy/MM/dd format.

[`Default`]() - Represents the day month year in default culture based format.

The following example demonstrates the Date Picker with the custom format [PickerDateFormat.MM_dd_yyyy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html#Syncfusion_Maui_Picker_PickerDateFormat_MM_dd_yyyy).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datepicker"
                     Format="MM_dd_yyyy"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    Format = PickerDateFormat.MM_dd_yyyy,
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![Formatting in .NET MAUI Date picker.](images/formatting/maui-date-picker-formatting.png)