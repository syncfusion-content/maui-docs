---
layout: post
title: About Axis in .NET MAUI Cartesian Chart control | Syncfusion
description: Learn here all about chart axis and its keys features of Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
keywords: .net maui cartesian chart axis overview, .net maui cartesian chart control axis, .net maui cartesian chart axis features, .net maui cartesian chart control axis functionality.
---

# Axis in .NET MAUI Cartesian Chart

[ChartAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html) is used to locate a data point inside the chart area. Charts typically have two axes that are used to measure and categorize data: a vertical (Y) axis, and a horizontal (X) axis.

The horizontal (X) axis supports the following types of scale:

* Category
* Numeric
* DateTime
* DateTimeCategory
* Logarithmic

The vertical (Y) axis typically uses a numerical scale, but other axis types (such as Category, DateTime, or Logarithmic) can also be assigned to it.

## Key features

* Supports different types of axes such as [Category](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html), [Numeric](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html), [Logarithmic](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html), [DateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html), and [DateTimeCategory](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html).
* Allows you to customize the chart axis line, grid lines, and tick lines, and to define the style of the axis line using the [AxisLineStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle).
* Allows you to customize the origin of the chart axis using the [Origin](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Origin) property.
* Provides options to set padding for the axis and the axis visible range using the [PlotOffset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffset) and [RangePadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html#Syncfusion_Maui_Charts_RangeAxisBase_RangePadding) properties.
* Multiple axes support provides a way to arrange multiple series inside the same chart area, giving more space for the X and Y axes.
