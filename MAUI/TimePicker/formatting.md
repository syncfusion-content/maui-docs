---
layout: post
title: Formatting in .NET MAUI Time Picker Control | Syncfusion
description: Learn about formatting support in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Formatting in .NET MAUI Time Picker (SfTimePicker)

Format is a way to represent the time in a different string format. You can customize the time format by using the [Format] property in [PickerTimeFormat]. The default format is `HH_mm_ss`.


The different types of formats are:

[`H_mm`] - Represents the hour minute in H_mm format.

[`H_mm_ss`] - Represents the hour minute second in H_mm_ss format.

[`h_mm_ss_tt`] - Represents the hour minute second meridiem in h_mm_ss_tt format.

[`h_mm_tt`] - Represents the hour minute meridiem in h_mm_tt format.

[`HH_mm`] - Represents the hour minute in HH_mm format.

[`HH_mm_ss`] - Represents the hour minute second in HH_mm_ss format.

[`hh_mm_ss_tt`] - Represents the hour minute second meridiem in hh_mm_ss_tt format.

[`hh_mm_tt`] - Represents the hour minute meridiem in hh_mm_tt format.

[`hh_tt`] - Represents the hour meridiem in hh_tt format

The following example demonstrates the Time Picker with the custom format [PickerTimeFormat.hh_mm_ss_tt]

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker" 
                     Format="hh_mm_ss_tt"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    Format = PickerTimeFormat.hh_mm_ss_tt;
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}