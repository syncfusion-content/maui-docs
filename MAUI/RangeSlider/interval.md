---
layout: post
title: Interval in.NET MAUI Range Slider control | Syncfusion 
description: Learn here all about adding the Interval feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Interval in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the interval for numeric and date range slider.

## Numeric interval

Range Slider elements like labels, ticks and dividers are rendered based on the `Interval`, `Minimum` and `Maximum` properties. The default value is `Zero`.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the range slider will render the labels, major ticks, and dividers at 0.0, 2.0, 4.0 and so on.

{% tabs %}

{% highlight xaml %}

    <sliders:SfRangeSlider Minimum="0" 
                           Maximum="10" 
                           Interval="2"  
                           RangeStart="2" 
                           RangeEnd="8" 
                           ShowLabels="True" 
                           ShowTicks="True" 
                           ShowDividers="True">
    </sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

    SfRangeSlider rangeSlider = new SfRangeSlider();
    rangeSlider.Minimum = 0;
    rangeSlider.Maximum = 10;
    rangeSlider.RangeStart = 2;
    rangeSlider.RangeEnd = 8;
    rangeSlider.Interval = 2;
    rangeSlider.ShowLabels = true;
    rangeSlider.ShowTicks = true;
    rangeSlider.ShowDividers = true;
         
{% endhighlight %}

{% endtabs %}

![RangeSlider numeric interval](images/interval/numeric-interval.png)

## Date interval

The type of date interval. It can be years to seconds. It is mandatory for date `SfRangeSlider`. The default value of `DateIntervalType` property is `DateTime.Year`.

For date values, the range slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

For example, if `Minimum` is `DateTime(2000, 01, 01)` and `Maximum` is `DateTime(2005, 01, 01)` and `Interval` is `1`, `DateIntervalType` is `SliderDateIntervalType.years`, `DateFormat` is `yyyy` then the range slider will render the labels, major ticks, and dividers at 2000, 2001, 2002 and so on.

{% tabs %}

{% highlight xaml %}

    <sliders:SfRangeSlider Minimum="2000-01-01" 
                           Maximum="2005-01-01" 
                           Interval="1" 
                           RangeStart="2001-01-01" 
                           RangeEnd="2004-01-01" 
                           DateFormat="yyyy" 
                           DateIntervalType="Years" 
                           ShowLabels="True" 
                           ShowTicks="True" 
                           ShowDividers="True">
    </sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

    SfRangeSlider rangeSlider = new SfRangeSlider();
    rangeSlider.Minimum = new DateTime(2000, 01, 01);
    rangeSlider.Maximum = new DateTime(2005, 01, 01);
    rangeSlider.RangeStart = new DateTime(2001, 01, 01); 
    rangeSlider.RangeEnd = new DateTime(2004, 01, 01);            
    rangeSlider.Interval = 1;
    rangeSlider.DateIntervalType = SliderDateIntervalType.Years;
    rangeSlider.DateFormat = "yyyy";
    rangeSlider.ShowLabels = true;
    rangeSlider.ShowTicks = true;
    rangeSlider.ShowDividers = true;
         
{% endhighlight %}

{% endtabs %}

![RangeSlider date interval](images/interval/date-interval.png)

## Discrete selection for numeric values

You can move the thumb in discrete manner for numeric values using the `StepSize` property in the range slider.

{% tabs %}

{% highlight xaml %}

    <sliders:SfRangeSlider StepSize="0.2" /> 

{% endhighlight %}

{% highlight C# %}

    SfRangeSlider rangeSlider = new SfRangeSlider();
    rangeSlider.StepSize = 0.2;
         
{% endhighlight %}

{% endtabs %}

![RangeSlider numeric discrete mode](images/interval/step-size.gif)

## Discrete selection for date values

You can move the thumb in discrete manner for date values using the `StepDuration` property in the range slider.

For example, if `Minimum` is DateTime(2015, 01, 01) and `Maximum` is DateTime(2020, 01, 01) and `StepDuration` is `1`, the range slider will move the thumbs at DateTime(2015, 01, 01), DateTime(2016, 01, 01), DateTime(2017, 01, 01),and DateTime(2018, 01, 01).

{% tabs %}

{% highlight xaml %}

    <sliders:SfRangeSlider Minimum="2000-01-01" 
                           Maximum="2005-01-01" 
                           RangeStart="2001-01-01"
                           RangeEnd="2004-01-01"  
                           StepDuration="1" >
    </sliders:SfRangeSlider>

{% endhighlight %}

{% highlight C# %}

    SfRangeSlider rangeSlider = new SfRangeSlider();
    rangeSlider.Minimum = new DateTime(2000, 01, 01);
    rangeSlider.Maximum = new DateTime(2005, 01, 01);
    rangeSlider.RangeStart = new DateTime(2001, 01, 01); 
    rangeSlider.RangeEnd = new DateTime(2004, 01, 01);            
    rangeSlider.StepDuration = new SliderStepDuration(years: 1);
         
{% endhighlight %}

{% endtabs %}

![RangeSlider date discrete mode](images/interval/step-duration.gif)
