---
layout: post
title: DateTime intervals in .NET MAUI DateTimePicker Control | Syncfusion<sup>&reg;</sup>
description: Learn about date time intervals in Syncfusion<sup>&reg;</sup> .NET MAUI DateTimePicker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# DateTime intervals in .NET MAUI DateTimePicker (SfDateTimePicker)
The `SfDateTimePicker` provides six intervals in [.NET MAUI DateTimePicker](https://www.syncfusion.com/maui-controls/maui-datetimepicker).

 * [`DayInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DayInterval)
 * [`MonthInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval)
 * [`YearInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval)
 * [`HourInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval)
 * [`MinuteInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval)
 * [`SecondInterval`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval)

## Day interval
DateTimePicker provides an option to set an interval between days using its [DayInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DayInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         DayInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.DayInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Day interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-day-interval.png)

## Month interval
DateTimePicker provides an option to set an interval between months using its [MonthInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         MonthInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.MonthInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Day interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-month-interval.png)

## Year interval
DateTimePicker provides an option to set an interval between years using its [YearInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         YearInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfDateTimePicker picker = new SfDateTimePicker();
picker.YearInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Year interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-year-interval.png)

## Hour interval
DateTimePicker provides an option to set an interval between hours using its [HourInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         HourInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

SfDateTimePicker picker = new SfDateTimePicker();
picker.HourInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Hour interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-hour-interval.png)

## Minute interval
DateTimePicker provides an option to set an interval between minutes using its [MinuteInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         MinuteInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

SfDateTimePicker picker = new SfDateTimePicker();
picker.MinuteInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Minute interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-minute-interval.png)

## Second interval
DateTimePicker provides an option to set an interval between seconds using its [SecondInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval) property of [SfDateTimePicker](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html).

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDateTimePicker x:Name="picker"
                         SecondInterval="2"/>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}  

SfDateTimePicker picker = new SfDateTimePicker()
picker.SecondInterval = 2;
this.Content = picker;

{% endhighlight %}
{% endtabs %}

   ![Second interval in .NET MAUI DateTimePicker.](images/intervals/maui-date-time-picker-second-interval.png)