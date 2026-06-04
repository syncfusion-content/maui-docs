---
layout: post
title: Customization in.NET MAUI Range Slider control | Syncfusion® 
description: Learn here all about Customization of Syncfusion® .NET MAUI Range Slider (SfDateTimeRangeSlider) control and more.
platform: maui
control: SfDateTimeRangeSlider
documentation: ug
---

# Customization in .NET MAUI Range Slider (SfDateTimeRangeSlider)

## Inverse the slider

Invert the DateTime Range Slider using the [IsInversed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.RangeView-1.html#Syncfusion_Maui_Sliders_RangeView_1_IsInversed) property. The default value of the IsInversed property is **False**.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01" 
                               Maximum="2018-01-01" 
                               RangeStart="2012-01-01" 
                               RangeEnd="2016-01-01"
                               Interval="2" 
                               ShowTicks="True"
                               ShowLabels="True"  
                               MinorTicksPerInterval="1" 
                               IsInversed="True">
</sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2018, 01, 01);
rangeSlider.RangeStart = new DateTime(2012, 01, 01);
rangeSlider.RangeEnd = new DateTime(2016, 01, 01);
rangeSlider.Interval = 2;
rangeSlider.ShowLabels = true;
rangeSlider.ShowTicks = true;
rangeSlider.MinorTicksPerInterval = 1;
rangeSlider.IsInversed = true;

{% endhighlight %}

{% endtabs %}

![Inverse range slider](images/getting-started/slider-inverse.png)

## Formatting labels

Add prefix or suffix to the labels using the [DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Sliders.IDateTimeElement.html#Syncfusion_Maui_Sliders_IDateTimeElement_DateFormat) property.

{% tabs %}

{% highlight xaml %}

<sliders:SfDateTimeRangeSlider Minimum="2010-01-01"
                               Maximum="2011-01-01"
                               RangeStart="2010-04-01"
                               RangeEnd="2010-10-01"
                               DateFormat="MMM"
                               IntervalType="Months"
                               ShowTicks="True"
                               MinorTicksPerInterval="1"
                               ShowLabels="True"
                               Interval="2">
</sliders:SfDateTimeRangeSlider>

{% endhighlight %}

{% highlight C# %}

SfDateTimeRangeSlider rangeSlider = new SfDateTimeRangeSlider();
rangeSlider.Minimum = new DateTime(2010, 01, 01);
rangeSlider.Maximum = new DateTime(2011, 01, 01);
rangeSlider.RangeStart = new DateTime(2010, 04, 01);
rangeSlider.RangeEnd = new DateTime(2010, 10, 01);
rangeSlider.ShowLabels = true;
rangeSlider.Interval = 2;
rangeSlider.ShowTicks = true;
rangeSlider.MinorTicksPerInterval = 1;
rangeSlider.DateFormat = "MMM";
rangeSlider.IntervalType = SliderDateIntervalType.Months;

{% endhighlight %}

{% endtabs %}

![RangeSlider label format](images/getting-started/label-format.png)
