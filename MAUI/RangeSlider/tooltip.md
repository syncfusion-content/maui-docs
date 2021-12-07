---
layout: post
title: Tooltip in .NET MAUI Range Slider control | Syncfusion
description: Learn here all about adding the Tooltip feature of Syncfusion .NET MAUI Range Slider (SfRangeSlider) control and more.
platform: maui
control: SfRangeSlider
documentation: ug
---

# Tooltip in .NET MAUI Range Slider (SfRangeSlider)

This section helps to learn about how to add tooltip in the range slider.

## Enable tooltip

You can enable tooltip for the thumb by setting the `ToolTipShape` property to `SliderToolTipShape.Rectangular`. It is used to clearly indicate the current selection of the value during interaction. By default, tooltip text is formatted with either numberFormat or dateFormat. The default value of the `ToolTipShape` property is `SliderToolTipShape.None`.

## Tooltip text format

By default it is formatted based on `NumberFormat` property and `DateFormat` property based on whether it is date type `SfRangeSlider` or numeric `SfRangeSlider`.

You can format or change the whole tooltip label text using the `ToolTipLabelCreated` event. The `SliderLabelCreatedEventArgs` contains the following parameters,

* Text – Change the format of the tooltip text using the `Text` property.
* Style – Change the appearance of the tooltip text like color, stroke color, and padding using the `Style` property.

## Tooltip label style

You can change the appearance of the tooltip text like color, stroke color, padding around the text using the `ToolTipStyle` property.
