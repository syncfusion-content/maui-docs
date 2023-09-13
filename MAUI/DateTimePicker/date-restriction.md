---
layout: post
title: Date restriction in .NET MAUI Date Time Picker control | Syncfusion
description: Learn about date restriction in Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Restriction in .NET MAUI Date Time Picker (SfDateTimePicker)

## Minimum date
The Date time picker provides an option to restrict the selection of date and time by using the [MinimumDate] property in [SfDateTimePicker] and you cannot select the date and time beyond the minimum date range. The MinimumDate value has to be lesser than the MaximumDate value.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker"
                         MinimumDate="2000/5/6 3:34:12 AM">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MinimumDate = new DateTime(2000, 5, 6, 3, 34, 12);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}


## Maximum date
The Date time picker provides an option to restrict the selection of date and time by using the [MaximumDate] property in [SfDateTimePicker] and you cannot select the date and time beyond the maximumDate date range.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker"
                         MaximumDate="2042/10/10 12:15:03 PM">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MaximumDate = new DateTime(2042, 10, 10, 12, 15, 03);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}