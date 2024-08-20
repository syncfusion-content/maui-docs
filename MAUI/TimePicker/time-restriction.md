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

The time picker provides an option to restrict the selection of time items using the [MinimumTime]() property. This ensures that times beyond the specified minimum time range cannot be selected. The `MinimumTime` value must be less than the `MaximumTime` value. When setting the minimum time, only the hour and minute components are considered.

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

![Minimum time in .NET MAUI Time picker.](images/time-restriction/maui-timepicker-timerestriction-minimumtime.png)

## Maximum Time

The time picker provides an option to restrict the selection of time items using the [MaximumTime]() property. This ensures that times beyond the specified minimum time range cannot be selected. The `MaximumTime` value must be higher than the `MinimumTime` value. When setting the minimum time, only the hour and minute components are considered.

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

![Maximum time in .NET MAUI Time picker.](images/time-restriction/maui-timepicker-timerestriction-maximumtime.png)