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
