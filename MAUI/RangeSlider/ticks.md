---
layout: post
title: Tick in .NET MAUI Range Slider control | Syncfusion 
description: Learn here all about adding the Tick feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Tick in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to add major and minor ticks in the range slider.

## Show major ticks

You can enable the major ticks on the track. It is a shape which is used to represent the major interval points of the track. The default value of `ShowTicks` property is `False`.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the range slider will render the major ticks at 0.0, 2.0, 4.0 and so on.

## Show minor ticks

It is used to represent the number of smaller ticks between two major ticks. For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the range slider will render the major ticks at 0.0, 2.0, 4.0 and so on. If `MinorTicksPerInterval` is 1, then smaller ticks will be rendered on 1.0 and 3.0 and so on. The default value of `MinorTicksPerInterval` property is Zero.

## Major ticks color

You can change the active and inactive major ticks color of the range slider using the `ActiveColor` and `InactiveColor` properties of the `MajorTickStyle` class.

The active side of the range slider is between start and end thumbs.

The inactive side of the range slider is between the `Minimum` value and the left thumb, and the right thumb and the `Maximum` value.

## Minor ticks color

You can change the active and inactive minor ticks color of the range slider using the `ActiveColor` and `InactiveColor` properties of the `MinorTickStyle` class.

The active side of the range slider is between start and end thumbs.

The inactive side of the range slider is between the `Minimum` value and the left thumb, and the right thumb and the `Maximum` value.

## Ticks size

You can change the major and minor ticks size of the range slider using the `ActiveSize` and `InactiveSize` property of the `MajorTickStyle` and `MinorTickStyle` classes. The default value is is `Size(2.0, 8.0)`.

## Ticks offset

You can adjust the space between track and ticks of the range slider using the `Offset` property of the `MajorTickStyle` and `MinorTickStyle`. The default value of the `Offset` property is `3.0`.
