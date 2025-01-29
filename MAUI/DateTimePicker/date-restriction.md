---
layout: post
title: Date restriction in .NET MAUI Date Time Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about date restriction in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Restriction in .NET MAUI Date Time Picker (SfDateTimePicker)

## Minimum date
The Date time picker provides an option to restrict the selection of date and time using the [MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinimumDate) property in [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html), and you cannot select the date and time beyond the minimum date range. The MinimumDate value has to be lesser than the MaximumDate value.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         MinimumDate="2000/5/6 3:34:12 AM">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MinimumDate = new DateTime(2000, 5, 6, 3, 34, 12);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

   ![Minimum date in .NET MAUI Date Time picker.](images/date-restriction/maui-date-time-picker-minimum-date.png)

## Maximum date
The Date time picker provides an option to restrict the selection of date and time using the [MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MaximumDate) property in [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html), and you cannot select the date and time beyond the maximum date range.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         MaximumDate="2042/10/10 12:15:03 PM">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MaximumDate = new DateTime(2042, 10, 10, 12, 15, 03);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

   ![Maximum date in .NET MAUI Date Time picker.](images/date-restriction/maui-date-time-picker-maximum-date.png)