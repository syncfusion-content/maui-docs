---
layout: post
title: Basic features in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Basic feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Basic features  in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the numeric and date range slider.

## Minimum

The minimum value that the user can select. The default value of `Minimum` property is 0.0 and it must be less than the `Maximum` value.

## Maximum

The maximum value that the user can select. The default value of `Maximum` property is 1.5 and it must be greater than the `Minimum` value.

## Range values

It represents the values currently selected in the range slider. The range slider’s thumb is drawn corresponding to this `RangeStart` and `RangeEnd` values.

For date values, the range slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

{% tabs %}

{% highlight xaml %}

<rangeslider:SfRangeSlider Minimum="2010-01-01" 
                       Maximum="2020-01-01" 
                       RangeStart="2012-01-01" 
                       RangeEnd="2018-01-01" 
                       ShowLabels="True">
</rangeslider:SfRangeSlider>
 
{% endhighlight %}

{% highlight C# %}

 SfRangeSlider rangeSlider = new SfRangeSlider();
 rangeSlider.Minimum = new DateTime(2010, 01, 01);
 rangeSlider.Maximum = new DateTime(2020, 01, 01);
 rangeSlider.RangeStart = new DateTime(2012, 01, 01);
 rangeSlider.RangeEnd = new DateTime(2018, 01, 01);
 rangeSlider.ShowLabels = true;

{% endhighlight %}

{% endtabs %}

![RangeSlider date label](images/basic-features/date-labels.png)

