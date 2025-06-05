---
layout: post
title: Enable Looping in .NET MAUI Date Time Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn about enable looping support in Syncfusion<sup>&reg;</sup> .NET MAUI Date Time Picker (SfDateTimePicker) control.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Enable Looping in .NET MAUI Date Time Picker (SfDateTimePicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property allows you to enable looping support in the date time picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

To enable the looping in date time picker by setting the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.EnableLooping.html) property as `true`. The default value is `false`.

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="dateTimePicker"
                     EnableLooping="True"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfDateTimePicker dateTimePicker = new SfDateTimePicker()
{
    EnableLooping = True,
};

this.Content = dateTimePicker;

{% endhighlight %}

{% endtabs %}