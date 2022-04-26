---
layout: post
title: Migration from Xamarin to .NET MAUI Chart control | Syncfusion
description: This section explains about the features available in the .NET MAUI Chart (SfCartesianChart) control over Xamarin SfChart.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Migrate from Xamarin.Forms SfChart to .NET MAUI SfCartesianChart

We do not have to rewrite the entire code for .NET MAUI Charts while using Xamarin SfChart. However, a minor code change is required. In addition, we have divided SfChart into five chart control in .NET MAUI for a better user experience and understanding.

<table>
<tr>
<th>Xamarin</th>
<th>.NET MAUI</th></tr>
<tr>
<td>
SfChart
</td>
<td>
<br> SfCartesianChart </br>
<br> SfCircularChart </br>
<br> SfFunnelChart (Upcoming) </br>
<br> SfPolarChart (Upcoming) </br>
<br> SfPyramidChart (Upcoming) </br>
</td>
</tr>
</table>

For more details, please check [here]() for API changes. 

## Upcoming Features in .NET MAUI

### Chart 

* Plot area customization. 
* Chart area watermark support.
* Trackball interaction support. 
* Crosshair interaction support. 
* Chart exporting as image or stream. 
* Chart localization support. 
* Annotation support. 
* Suspend and resume notice. 
* Technical indicators for charts.

### Series

* Listen property change support for series.
* Get data point index based on value.
* Get data points by passing rect.
* Notify event or method while series rendering.
* Suspend and resume notification.
* Trendlines support for continuous series. 

### Axis

* Logarithmic axis support.
* DateTime category axis support.
* Align the axis labels and tick inside the series clip rect.
* Range style customization.
* Event or method to notify the axis label click.
* Axis label wrapping support.
* Axis labels draws multiple lines using /n.
* Striplines for range base axis.
* Arrange category axis labels based on series values.
* Support to set the maximum labels count for chart axis.
* Support to extent size between Axis title and axis label.

### Legend 

* Title for legend. 
* Support to enable or disable the legend icon visibility.
* Legend wrap support.
* Legend items floating support.
* Maximum width support for Legend.
* Individual legend items based on the data point count.
* Event or method to notify the legend click and the creation of a legend item.
* DataTemplate support for legend.

### Data label

* Data marker support for line series.
* DataTemplate support for data label.
* Connector lines and its customization.

### Tooltip

* Hide and Show method for tooltip.

### Selection

* Series selection support.

### Zooming

* Selection zooming support.
* Directional zooming.
* Support to set the maximum zoom level.
* Event for zooming and panning.

## Unsupported Features from Xamarin.Forms

* Data marker support for chart series.
* Data label created event support was not provided in series, instead of that event you can use the `DrawDataLabel` override method in `ChartSeries` class.
* `OpposedPosition` property was not exposed in axis, instead of that you can move to axis opposed position by setting the `CrossesAt` value as `double.MaxValue`.
* `RangeStyle` support was not provided in axis, instead of that you can use `DrawMajorTick`, `DrawMinorTick`, and `DrawGridLine` override methods provided in axis class. 

## Limitations for .NET MAUI.

* Android 5.0 (API 21) or higher.
* iOS 10 or higher.
* macOS 10.13 or higher, using Mac Catalyst.
* Windows 11 and Windows 10 version 1809 or higher, using [Windows UI Library (WinUI) 3](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/).

## Known issues in .NET MAUI.

* The legend item was not dynamically added.
* While resizing the window, the chart size is not dynamically updated.
* Axis label rotation does not work for all angles.
* The title position was incorrect for a category axis with an inversed position.
* Axis range and series are not updated properly when dynamically removing or inserting the axis collection.
* Axis minor gridlines are not visible unless major gridlines are enabled.

## Support and feedback

If you need an alternate solution for the above mentioned missing features, we will try to achieve your requirements by customizing the chart, please contact us by creating a [support ticket](https://www.syncfusion.com/support/directtrac/incidents).
Do not see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/maui).