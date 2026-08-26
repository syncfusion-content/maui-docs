---
layout: post
title: PolarLineSeries in .NET MAUI Polar Chart | Syncfusion®
description: PolarLineSeries connects data points with lines in a polar coordinate system, making patterns and trends easy to visualize.
platform: maui
control: SfPolarChart
documentation: ug
---

# PolarLineSeries API in .NET MAUI Polar Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarDataLabelSettings.html" aria-label="View PolarDataLabelSettings type in API reference">PolarDataLabelSettings</a></td>
    <td>Configures the appearance and positioning of data labels displayed for data points in the polar series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_IsClosed" aria-label="View IsClosed property in API reference">IsClosed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether the polar line connects the last data point back to the first data point, forming a closed shape. When disabled, the line remains open between the first and last points.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_Label" aria-label="View Label property in API reference">Label</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Specifies the text displayed for the series in the chart legend. The default value is <code>string.Empty</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_MarkerSettings" aria-label="View MarkerSettings property in API reference">MarkerSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMarkerSettings.html" aria-label="View ChartMarkerSettings type in API reference">ChartMarkerSettings</a></td>
    <td>Customizes the appearance of markers displayed at individual data points.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_ShowMarkers" aria-label="View ShowMarkers property in API reference">ShowMarkers</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether markers are displayed for the data points in the series. The default value is <code>false</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_StrokeDashArray" aria-label="View StrokeDashArray property in API reference">StrokeDashArray</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.doublecollection" aria-label="View DoubleCollection type in API reference">DoubleCollection</a></td>
    <td>Defines a dash pattern for the series line, allowing the line to be rendered with dashed or dotted strokes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the thickness of the series line. The default value is <code>2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Specifies which field from each data object supplies the radial value used to plot data points in the series.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarSeries.html#Syncfusion_Maui_Charts_PolarSeries_GetDataPointIndex_System_Single_System_Single_" aria-label="View GetDataPointIndex method in API reference">GetDataPointIndex(Single, Single)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Returns the index of the data point located at the specified chart coordinates. If no data point is present at the given position, no valid data-point index is returned.</td>
</tr>
</table>
