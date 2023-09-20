---
layout: post
title: Date Restriction in .NET MAUI Date Picker Control | Syncfusion
description: Learn about date restriction support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Restriction in .NET MAUI Date Picker (SfDatePicker)

## Minimum date

The Date picker provides an option to restrict the selection of date items by using the [MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate) property in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html), and you cannot select the dates beyond the minimum date range. The MinimumDate value has to be lesser than the MaximumDate value.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     MinimumDate="2000/05/15">
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDatePicker picker = new SfDatePicker();
picker.MinimumDate = new DateTime(2000, 05, 15);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

## Maximum date

The Date picker provides an option to restrict the selection of date items by using the [MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate) property in [SfDatePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html), and you cannot select the dates beyond the maximum date range.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="Picker"
                     MaximumDate="2042/10/10">
</picker:SfDatePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDatePicker picker = new SfDatePicker();
picker.MaximumDate = new DateTime(2042, 10, 10);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}