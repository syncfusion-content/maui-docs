---
layout: post
title: Date Time intervals in .NET MAUI Date Time Picker Control | Syncfusion
description: Learn about date time intervals in Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control and its basic features.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Date Time intervals in .NET MAUI Date Time Picker (SfDateTimePicker)
The `SfDateTimePicker` provides six intervals in [.NET MAUI Date Picker].

 * [`DayInterval`]
 * [`MonthInterval`]
 * [`YearInterval`]
 * [`HourInterval`]
 * [`MinuteInterval`]
 * [`SecondInterval`]

## Day interval
Date Time picker provides an option to give an interval between days using the [DayInterval] property of [SfDateTimePicker].

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

## Month interval
Date Time picker provides an option to give an interval between months using the [MonthInterval] property of [SfDateTimePicker].

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

## Year interval
Date Time picker provides an option to give an interval between years using the [YearInterval] property of [SfDateTimePicker].

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

## Hour interval
Date Time picker provides an option to give an interval between hours using the [HourInterval] property of [SfDateTimePicker].

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

## Minute interval
Date Time picker provides an option to give an interval between minutes using the [MinuteInterval] property of [SfDateTimePicker].

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

## Second interval
Date Time picker provides an option to give an interval between seconds using the [SecondInterval] property of [SfDateTimePicker].

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