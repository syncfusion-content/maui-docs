---
layout: post
title: Date restriction with .NET MAUI Date Time Picker control | Syncfusion
description: Learn about date restriction with Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date restriction with .NET MAUI Date Time Picker (SfDateTimePicker)

## Minimum date
The Date time picker provides an option to restrict the selection of date items by using the [MinimumDate] property in [SfDateTimePicker] and you cannot select the dates beyond the minimum date range. The MinimumDate value has to be lesser than the MaximumDate value.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker"
                         MinimumDate="2000/12/1">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MinimumDate = new DateTime(2000, 12, 1);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}


## Maximum date
The Date time picker provides an option to restrict the selection of date items by using the [MaximumDate] property in [SfDateTimePicker] and you cannot select the dates beyond the maximumDate date range.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="Picker"
                         MaximumDate="2042/10/10">
</picker:SfDateTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MaximumDate = new DateTime(2042, 10, 10);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}