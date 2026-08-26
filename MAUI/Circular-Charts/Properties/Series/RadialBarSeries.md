---
layout: post
title: RadialBarSeries in .NET MAUI Circular Chart | Syncfusion®
description: RadialBarSeries visualizes values as circular bars in .NET MAUI Circular Chart, helping compare progress and performance metrics.
platform: maui
control: SfCircularChart
documentation: ug
---

# RadialBarSeries API in .NET MAUI Circular Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CapStyle" aria-label="View CapStyle property in API reference">CapStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CapStyle.html" aria-label="View CapStyle type in API reference">CapStyle</a></td>
    <td>Controls the shape of the start and end edges of radial bar segments. Different cap styles can create flat or rounded segment ends for a distinct visual appearance. The default value is <code>BothFlat</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterHoleSize" aria-label="View CenterHoleSize property in API reference">CenterHoleSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the rendered size of the radial bar chart's center hole after the series layout is calculated.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterView" aria-label="View CenterView property in API reference">CenterView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Displays custom content, such as text, images, or other .NET MAUI views, in the center area of the radial bar chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html" aria-label="View CircularDataLabelSettings type in API reference">CircularDataLabelSettings</a></td>
    <td>Configures the appearance and positioning of data labels displayed for radial bar segments.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the angle at which the radial bar series ends, allowing the chart to render a full circle or a partial arc. The default value is <code>360</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_GapRatio" aria-label="View GapRatio property in API reference">GapRatio</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the spacing between adjacent radial bar segments. Larger values increase the gap between segments. The value ranges between 0 and 1. The default value is <code>0.2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_InnerRadius" aria-label="View InnerRadius property in API reference">InnerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the size of the inner hole relative to the series radius. Larger values create thinner radial bars, while smaller values create thicker radial bars. The value ranges between 0 and 1. The default value is <code>0.4</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_MaximumValue" aria-label="View MaximumValue property in API reference">MaximumValue</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the maximum value used to calculate the length of radial bar segments. Segment lengths are rendered relative to this value. The default value is <code>double.NaN</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Radius" aria-label="View Radius property in API reference">Radius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the overall size of the radial bar series within the available chart area. The value is between 0 and 1. The default value is <code>0.8</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the angle at which the radial bar series begins rendering, allowing the chart to be rotated to a custom starting position. The default value is <code>0</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Controls the brush used to draw the borders of radial bar segments. The default value is <code>null</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the thickness of the borders drawn around radial bar segments. The default value is <code>2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Controls the brush used to fill the background track displayed behind each radial bar segment. The default value is <code>null</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackStroke" aria-label="View TrackStroke property in API reference">TrackStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Controls the brush used to draw the outline of the background track displayed behind each radial bar segment. The default value is <code>null</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackStrokeWidth" aria-label="View TrackStrokeWidth property in API reference">TrackStrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the thickness of the outline drawn around the background track. The default value is <code>1</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Specifies which field from each data object supplies the value used to determine the length of radial bar segments. The default value is <code>null</code>.</td>
</tr>
</table>
