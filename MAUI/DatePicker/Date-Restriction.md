---
layout: post
title: Date Restriction in .NET MAUI Date Picker control | Syncfusion
description: Learn here all about date restriction support in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---


# Date Restriction in .NET MAUI Date Picker (SfDatePicker)

Date Picker provides an option to select a date value within a specified range by using the [MinimumDate]() and [MaximumDate]() properties of [SfDatePicker](). Always the [MinimumDate]() value has to be lesser than the [MaximumDate]() value.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datepicker"
                        MinimumDate="1/1/2020"
                        MaximumDate="12/31/2030"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfDatePicker datePicker = new SfDatePicker()
{
    MinimumDate = new System.DateTime(2020, 1, 1),
    MaximumDate = new System.DateTime(2030, 12, 31)
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

![MinimumDate of SfDatePicker]()
![MaximumDate of SfDatePicker]()

