---
layout: post
title: Labels and Dividers in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about the Labels and Dividers feature of .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Labels and Dividers in .NET MAUI Range Slider (SfRangeSlider)

This section explains about how to add the labels and dividers in the range slider.

## Show labels

The `ShowLabels` property is used to render the labels on given interval. The default value of `ShowLabels property is `False`.

## Number format

The `NumberFormat` property is used to format the numeric labels. The default value of `NumberFormat` property is `0.##`.

## Date format

The `DateFormat` property is used to format the date labels. It is mandatory for date `SfRangeSlider`. For date values, the slider does not have auto interval support. So, it is mandatory to set `Interval`, `DateIntervalType`, and `DateFormat` for date values. The default value of `DateFormat` property is `yyyy`.

## Label placement

The `LabelsPlacement` property is used to place the labels either between the major ticks or on the major ticks. The default value of the `LabelsPlacement` property is `SliderLabelsPlacement.OnTicks`.

## Customize label text

You can format or change the whole numeric or date label text using the `LabelCreated` event. The `SliderLabelCreatedEventArgs` contains the following parameters,

* Text – Customize the text color using the `Text` parameter.
* Style – Formats the text color, font size, font family, offset using the `Style` parameter.

## Label style

You can change the active and inactive label appearance of the range slider using the `ActiveTextColor`, `ActiveFontSize`, `ActiveFontFamily`, `ActiveFontAttributes`, `InactiveTextColor`, `InactiveFontSize`, `InactiveFontFamily`, `InactiveFontAttributes` and `Offset`  properties of the `LabelStyle` class.

The active side of the range slider is between start and end thumbs.

The inactive side of the range slider is between the `Minimum` value and the left thumb, and the right thumb and the `Maximum` value.

## Label offset

You can adjust the space between ticks and labels of the range slider using the `Offset` property. The default value of the `Offset` property is 5.0 when `ShowTicks` enabled, otherwise it is `15.0` by default.

## Show dividers

The `ShowDividers` property is used to render the dividers on the track. The default value of the `ShowDividers` property is `False`. It is a shape which is used to represent the major interval points of the track.

For example, if `Minimum` is 0.0 and `Maximum` is 10.0 and `Interval` is 2.0, the range slider will render the dividers at 0.0, 2.0, 4.0 and so on.

## Divider radius

You can change the active and inactive divider radius of the range slider using the `ActiveRadius` and the `InactiveRadius` properties of the `DividerStyle` class.

## Divider stroke width and stroke color

You can change the active and inactive divider stroke width of the range slider using the `ActiveStrokeWidth` and the `InactiveStrokeWidth` properties of the `DividerStyle` class.

Also, you can change the active and inactive divider stroke color of the range slider using the `ActiveStrokeColor` and the `InactiveStrokeColor` properties of the `DividerStyle` class.

## Divider color

You can change the active and inactive divider color of the range slider using the `ActiveColor` and `InactiveColor` properties of the `DividerStyle` class.
