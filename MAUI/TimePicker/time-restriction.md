---
layout: post
title: Time Restriction in .NET MAUI Time Picker Control | Syncfusion
description: Learn about time restriction support in Syncfusion .NET MAUI Time Picker (SfTImePicker) control and its basic features.
platform: maui
control: SfTimePicker
documentation: ug
---  

# Time restriction in .NET MAUI Time Picker (SfTimePicker)

## Minimum Time

The time picker provides an option to restrict the selection of time items by using the [MinimumTime]() property in [SfTimePicker](), and you cannot select the times beyond the minimum time range. The `MinimumTime` value has to be lesser than the `MaximumTime` value.When you set minimum time as timespan only hour and minute gets considered.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     MinimumTime="7:40:0">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfTimePicker picker = new SfTimePicker();
picker.MinimumTime = new TimeSpan(7, 40, 0);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Minimum time in .NET MAUI Time picker.]()

## Maximum Time

The time picker provides an option to restrict the selection of time items by using the [MaximumTime]() property in [SfTimePicker](), and you cannot select the times beyond the maximum time range.The `MaximumTime` value has to be higher than the `MinimumTime` value.When you set maximum time as timespan only hour and minute gets considered.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="2" %}

<picker:SfTimePicker x:Name="Picker"
                     MaximumTime="20:15:0">
</picker:SfTimePicker>

{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="2" %}

SfTimePicker picker = new SfTimePicker();
picker.MaximumTime = new TimeSpan(20, 15, 0);
this.Content = picker;

{% endhighlight %}  
{% endtabs %}

![Maximum time in .NET MAUI Time picker.]()