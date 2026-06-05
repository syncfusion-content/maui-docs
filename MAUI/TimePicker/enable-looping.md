---
layout: post
title: Looping and Selection support in .NET MAUI Time Picker | Syncfusion®
description: Learn about looping and Selection support in Syncfusion<sup>&reg;</sup> .NET MAUI Time Picker (SfTimePicker) control.
platform: maui
control: SfTimePicker
documentation: ug
---

# Looping support in .NET MAUI Time Picker (SfTimePicker)

The [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property allows you to enable looping support in the time picker control. With looping enabled, the control seamlessly navigates from the last item to the first item and back again, iterating in both forward and backward directions.

To enable the looping in time picker by setting the [EnableLooping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping) property as `true`. The default value is `false`.

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

## Set selected time to the Time Picker

The SfTimePicker control allows you to select the time using the [SelectedTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime) property in the [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html). The default value of the `SelectedTime` is the current time.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="picker" 
                     SelectedTime="07:22:01">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3" %}

SfTimePicker picker = new SfTimePicker()
{
    SelectedTime = new TimeSpan(07, 22, 01),
};

this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Set Selected time in .NET MAUI Time picker.](images/getting-started/maui-time-picker-set-selected-time.png)

## Clear selection

The .NET MAUI TimePicker provides clear selection support, allowing you to clear the selected time by setting the `SelectedTime` property to `null`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<picker:SfTimePicker x:Name="picker" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    this.picker.SelectedTime = null;

{% endhighlight %}  
{% endtabs %}