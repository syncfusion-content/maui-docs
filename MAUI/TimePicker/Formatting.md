---
layout: post
title: Formatting in .NET MAUI Time Picker control | Syncfusion
description: Learn here all about formatting support in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---


# Formatting in .NET MAUI Time Picker (SfTimePicker)

[Format]() is a way to represent the value of the time in a different string format.

By default, the TimePicker format is ["PickerTimeFormat.HH_mm_ss"]().

The following example demonstrates the TimePicker with the custom format [PickerTimeFormat.hh_mm_ss_tt]()

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker Format="hh_mm_ss_tt"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    Format = PickerTimeFormat.hh_mm_ss_tt;
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![TimeFormat]()
