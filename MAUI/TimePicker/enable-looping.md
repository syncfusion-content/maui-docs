---
layout: post
title: Looping support in .NET MAUI Time Picker Control | Syncfusion®
description: Learn about looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control.
platform: maui
control: SfTimePicker
documentation: ug
---

# Looping support in .NET MAUI Time Picker (SfTimePicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property allows you to enable looping support in the time picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

To enable the looping in time picker by setting the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property as `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     EnableLooping="True"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    EnableLooping = True,
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![Enable Looping in .NET MAUI Time picker.](images/enable-looping/time-picker-enable-looping.gif){:width="330" height="360"}