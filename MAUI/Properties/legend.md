---
layout: post
title: Legend and styles in .NET MAUI Polar Chart | Syncfusion®
description: Customize legends, labels, markers, and related styles in .NET MAUI Polar Chart to improve chart readability and visual appearance.
platform: maui
control: SfPolarChart
documentation: ug
---

# Legend API in .NET MAUI Polar Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsFloating" aria-label="View IsFloating property in API reference">IsFloating</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Positions the legend as a <code>floating overlay</code> on top of the chart's plot area instead of occupying dedicated space outside the plot.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of the legend within the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemsLayout" aria-label="View ItemsLayout property in API reference">ItemsLayout</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.layout" aria-label="View Layout type in API reference">Layout</a></td>
    <td>Defines how individual legend items are arranged within the legend, such as in a <code>horizontal row</code> or <code>vertical column</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines a custom <code>view template</code> to replace the default appearance of each legend item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendLabelStyle.html" aria-label="View ChartLegendLabelStyle type in API reference">ChartLegendLabelStyle</a></td>
    <td>Customizes the <code>font</code>, <code>color</code>, and other visual attributes of the text labels displayed for each legend item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_OffsetX" aria-label="View OffsetX property in API reference">OffsetX</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Adjusts the <code>horizontal position</code> of the legend relative to its default placement, measured in device-independent units. Applies only when the legend is <code>floating</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_OffsetY" aria-label="View OffsetY property in API reference">OffsetY</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Adjusts the <code>vertical position</code> of the legend relative to its default placement, measured in device-independent units. Applies only when the legend is <code>floating</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_Placement" aria-label="View Placement property in API reference">Placement</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LegendPlacement.html" aria-label="View LegendPlacement type in API reference">LegendPlacement</a></td>
    <td>Determines the position of the legend relative to the chart plot area, such as <code>top</code>, <code>bottom</code>, <code>left</code>, or <code>right</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_ToggleSeriesVisibility" aria-label="View ToggleSeriesVisibility property in API reference">ToggleSeriesVisibility</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to <code>show or hide</code> the associated chart series by tapping its corresponding legend item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Fill" aria-label="View Fill property in API reference">Fill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the <code>color</code> or <code>brush</code> used to paint the <code>interior</code> of the marker.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Height" aria-label="View Height property in API reference">Height</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the <code>vertical size</code> of the marker, measured in <code>device-independent units</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the <code>color</code> or <code>brush</code> used to draw the <code>outer border</code> of the marker.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the <code>thickness</code> of the marker's <code>outer border</code>, measured in <code>device-independent units</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Type" aria-label="View Type property in API reference">Type</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeType.html" aria-label="View ShapeType type in API reference">ShapeType</a></td>
    <td>Determines the <code>geometric shape</code> of the marker, such as a <code>circle</code>, <code>diamond</code>, or <code>rectangle</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html#Syncfusion_Maui_Charts_ChartMarkerSettings_Width" aria-label="View Width property in API reference">Width</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the <code>horizontal size</code> of the marker, measured in <code>device-independent units</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Delta" aria-label="View Delta property in API reference">Delta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the numeric span between the start and end values of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Empty" aria-label="View Empty property in API reference">Empty</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Represents an empty range that contains no valid values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_End" aria-label="View End property in API reference">End</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the upper bound of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_IsEmpty" aria-label="View IsEmpty property in API reference">IsEmpty</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Indicates whether the range contains any valid values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Median" aria-label="View Median property in API reference">Median</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the midpoint value between the start and end of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Start" aria-label="View Start property in API reference">Start</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the lower bound of the range.</td>
</tr>
</table>

## Methods

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Equals_System_Object_" aria-label="View Equals method in API reference">Equals(Object)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified object represents the same range values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Exclude_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange__Syncfusion_Maui_Charts_DoubleRange__" aria-label="View Exclude method in API reference">Exclude(DoubleRange, DoubleRange, out DoubleRange, out DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Removes one range from another and returns the remaining range portions, if any.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_GetHashCode" aria-label="View GetHashCode method in API reference">GetHashCode()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Returns a hash code that uniquely represents the current range instance for comparison and collection operations.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Inside_System_Double_" aria-label="View Inside method in API reference">Inside(Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified value falls within the range boundaries.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Inside_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Inside method in API reference">Inside(DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified range is completely contained within the current range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Intersects_System_Double_System_Double_" aria-label="View Intersects method in API reference">Intersects(Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the current range overlaps the specified start and end values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Intersects_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Intersects method in API reference">Intersects(DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the current range overlaps another range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Offset_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Offset method in API reference">Offset(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range whose start and end values are shifted by the specified offset.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Scale_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Scale method in API reference">Scale(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range whose size is scaled by the specified factor.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_System_Double___" aria-label="View Union method in API reference">Union(Double[])</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses all specified values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Union method in API reference">Union(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses both the specified range and value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Union method in API reference">Union(DoubleRange, DoubleRange)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses both specified ranges.</td>
</tr>
</table>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html#Syncfusion_Maui_Charts_ChartLegend_LegendItemCreated" aria-label="View LegendItemCreated event in API reference">LegendItemCreated</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LegendItemEventArgs.html" aria-label="View LegendItemEventArgs type in API reference">LegendItemEventArgs</a><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">&gt;</a></td>
    <td>Triggered when a legend item is created, allowing <code>customization</code> of the item's content or appearance before it is rendered.</td>
</tr>
</table>
