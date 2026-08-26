---
layout: post
title: DoughnutSeries in .NET MAUI Circular Chart | Syncfusion®
description: DoughnutSeries displays data as proportional segments in a circular ring, making part-to-whole comparisons easy to understand.
platform: maui
control: SfCircularChart
documentation: ug
---

# DoughnutSeries API in .NET MAUI Circular Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterHoleSize" aria-label="View CenterHoleSize property in API reference">CenterHoleSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the rendered size of the doughnut chart's center hole. This value reflects the actual hole size after the series has been laid out.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_CenterView" aria-label="View CenterView property in API reference">CenterView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Displays custom content, such as text, images, or other .NET MAUI views, in the center of the doughnut chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html" aria-label="View CircularDataLabelSettings type in API reference">CircularDataLabelSettings</a></td>
    <td>Configures the appearance and positioning of data labels displayed for the doughnut series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the angle at which the doughnut series ends, allowing the chart to render a full circle or a partial arc. The default value is <code>360</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeAll" aria-label="View ExplodeAll property in API reference">ExplodeAll</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Separates all doughnut segments from the chart center, making each segment stand out visually. The default value is <code>false</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeIndex" aria-label="View ExplodeIndex property in API reference">ExplodeIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Separates the segment at the specified data-point index from the rest of the series. The default value is <code>-1</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeOnTouch" aria-label="View ExplodeOnTouch property in API reference">ExplodeOnTouch</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to separate a segment from the chart by tapping or touching it. The default value is <code>false</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_ExplodeRadius" aria-label="View ExplodeRadius property in API reference">ExplodeRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls how far exploded segments are offset from the chart center. Higher values move segments farther away. The default value is <code>10</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_GroupMode" aria-label="View GroupMode property in API reference">GroupMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieGroupMode.html" aria-label="View PieGroupMode type in API reference">PieGroupMode</a></td>
    <td>Determines how smaller segments are grouped into a single combined segment, based on segment value, angle, or percentage. The default value is <code>PieGroupMode.Value</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PieSeries.html#Syncfusion_Maui_Charts_PieSeries_GroupTo" aria-label="View GroupTo property in API reference">GroupTo</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Specifies the threshold used to group smaller segments into a single combined segment. The threshold is evaluated according to the selected <code>GroupMode</code>. The default value is <code>double.NaN</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html#Syncfusion_Maui_Charts_DoughnutSeries_InnerRadius" aria-label="View InnerRadius property in API reference">InnerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the size of the inner hole relative to the series radius. Larger values create a thinner doughnut ring, while smaller values create a thicker ring. The default value is <code>0.4</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Radius" aria-label="View Radius property in API reference">Radius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the overall size of the doughnut series within the available chart area. The default value is <code>0.8</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the angle at which the doughnut series begins rendering, allowing the chart to be rotated to a custom starting position. The default value is <code>0</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Controls the brush used to draw the borders of doughnut segments. The default value is <code>null</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the thickness of the borders drawn around doughnut segments. The default value is <code>2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Specifies which field from each data object supplies the value used to determine segment size. The default value is <code>null</code>.</td>
</tr>
</table>