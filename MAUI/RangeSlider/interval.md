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

## Date interval

The type of date interval. It can be years to seconds. It is mandatory for date `SfRangeSlider`. The default value of `DateIntervalType` property is `DateTime.Year`.

For date values, the range slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values.

For example, if `Minimum` is `DateTime(2000, 01, 01)` and `Maximum` is `DateTime(2005, 01, 01)` and `Interval` is `1`, `DateIntervalType` is `SliderDateIntervalType.years`, `DateFormat` is `yyyy` then the range slider will render the labels, major ticks, and dividers at 2000, 2001, 2002 and so on.

## Discrete selection for numeric values

You can move the thumb in discrete manner for numeric values using the `StepSize` property in the range slider.

## Discrete selection for date values

You can move the thumb in discrete manner for date values using the `StepDuration` property in the range slider.

For example, if `Minimum` is DateTime(2015, 01, 01) and `Maximum` is DateTime(2020, 01, 01) and `StepDuration` is `1`, the range slider will move the thumbs at DateTime(2015, 01, 01), DateTime(2016, 01, 01), DateTime(2017, 01, 01),and DateTime(2018, 01, 01).
