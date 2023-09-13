---
layout: post
title: Date interval in .NET MAUI Date Picker control | Syncfusion
description: Learn about date interval in Syncfusion .NET MAUI Date Picker (SfDatePicker) control and its basic features.
platform: maui
control: SfDatePicker
documentation: ug
---

# Date Interval in .NET MAUI Date Picker(SfDatePicker)

The `SfDatePicker` provides three intervals in [.NET MAUI Date Picker].

 * [`DayInterval`]
 * [`MonthInterval`]
 * [`YearInterval`]

## Day interval

Date Picker provides an option to give an interval between days using the [DayInterval] property of [SfDatePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     DayInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    DayInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Month interval

Date Picker provides an option to give an interval between months using the [MonthInterval] property of [SfDatePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     MonthInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    MonthInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}

## Year interval

Date Picker provides an option to give an interval between years using the [YearInterval] property of [SfDatePicker].

{% tabs %}

{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfDatePicker x:Name="datePicker"
                     YearInterval="2"/>

{% endhighlight %}

{% highlight c# tabtitle="C#" hl_lines="3" %}

SfDatePicker datePicker = new SfDatePicker()
{
    YearInterval = 2
};

this.Content = datePicker;

{% endhighlight %}

{% endtabs %}