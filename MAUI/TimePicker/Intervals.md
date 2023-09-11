---
layout: post
title: Time Picker interval in .NET MAUI Time Picker control | Syncfusion
description: Learn here all about time picker interval support in Syncfusion .NET MAUI Time Picker (SfTimePicker) control and more.
platform: maui
control: SfTimePicker
documentation: ug
---

# Interval in .NET MAUI Time Picker(SfTimePicker)

The Time Picker contains the `HourInterval`, `MinuteInterval`, `SecondInterval` in [.NET MAUI Time Picker]().

## Hour interval

Time Picker provides an option to give an interval between hours using the [HourInterval]() property of [SfTimePicker]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" HourInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    HourInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Minute interval

Time Picker provides an option to give an interval between minutes using the [MinuteInterval]() property of [SfTimePicker]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" MinuteInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    MinuteInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

## Second interval

Time Picker provides an option to give an interval between seconds using the [SecondInterval]() property of [SfTimePicker]().

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="timePicker" SecondInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="4" %}  

SfTimePicker timePicker = new SfTimePicker()
{
    SecondInterval = 2
};

this.Content = timePicker;

{% endhighlight %}

{% endtabs %}

![TimeInterval]()