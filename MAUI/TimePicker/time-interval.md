---
layout: post
title: Time Interval in .NET MAUI Time Picker Control | Syncfusion
description: Learn about time interval in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---

# Time Interval in .NET MAUI Time Picker(SfTimePicker)

The `SfTimePicker` provides three intervals in [.NET MAUI Time Picker].

 * [`HourInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_HourInterval)
 * [`MinuteInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MinuteInterval)
 * [`SecondInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SecondInterval)

## Hour interval

Time Picker provides an option to give an interval between hours using the [HourInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_HourInterval) property of [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     HourInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    HourInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Minute interval

Time Picker provides an option to give an interval between minutes using the [MinuteInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MinuteInterval) property of [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     MinuteInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    MinuteInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Second interval

Time Picker provides an option to give an interval between seconds using the [SecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SecondInterval) property of [SfTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html).

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker"
                     SecondInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    SecondInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}