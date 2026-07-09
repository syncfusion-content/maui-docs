---
layout: post
title: Looping support in .NET MAUI Date Time Picker Control | Syncfusion®
description: Learn about looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Looping support in .NET MAUI Date Time Picker (SfDateTimePicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property enables cyclic navigation in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html). When enabled, supported columns wrap from the last item to the first item and vice versa during both forward and backward navigation.

To enable looping in the [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html), set the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property to `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="dateTimePicker"
                     EnableLooping="True"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    EnableLooping = true,
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}

![Enable Looping in .NET MAUI Date Time picker.](images/enable-looping/date-time-picker-enable-looping.gif){:width="330" height="360"}