---
layout: post
title: SunburstSelectionBehaviors in .NET MAUI Sunburst Chart | Syncfusion®
description: This section lists the public API members of the SunburstSelectionSettings class available in the Syncfusion® .NET MAUI Sunburst Chart API.
platform: maui
control: SfSunburstChart
documentation: ug
---

# SunburstSelectionBehaviors API in .NET MAUI Sunburst Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_DisplayMode" aria-label="View DisplayMode property in API reference">DisplayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionDisplayMode.html" aria-label="View SunburstSelectionDisplayMode type in API reference">SunburstSelectionDisplayMode</a></td>
    <td>Controls how selected segments are visually highlighted in the sunburst chart, such as by changing their fill, stroke, or emphasizing unselected segments through opacity changes. The default value is <code>HighlightByBrush</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Fill" aria-label="View Fill property in API reference">Fill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Specifies the brush used to highlight selected segments when the selection display mode uses fill-based highlighting. The default value is <code>#1C1B1F</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Opacity" aria-label="View Opacity property in API reference">Opacity</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the opacity applied to unselected segments when the selection display mode emphasizes the selected segment by reducing the visibility of other segments. The default value is <code>0.7</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Specifies the brush used to draw the outline of selected segments when the selection display mode uses stroke-based highlighting. The default value is <code>#1C1B1F</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the thickness of the outline used to highlight selected segments when stroke-based highlighting is enabled. The default value is <code>2.0</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html#Syncfusion_Maui_SunburstChart_SunburstSelectionSettings_Type" aria-label="View Type property in API reference">Type</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionType.html" aria-label="View SunburstSelectionType type in API reference">SunburstSelectionType</a></td>
    <td>Determines how selection is applied within the sunburst hierarchy, such as selecting an individual segment or including related parent, child, or grouped segments. The default value is <code>Single</code>.</td>
</tr>
</table>
