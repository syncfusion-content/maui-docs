---
layout: post
title: Behaviors in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members of tooltip, trackball, crosshair, zoom and pan, and selection behaviors available in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) API.
platform: maui
control: SfCartesianChart
documentation: ug
---

# ChartZoomPanBehavior API in .NET MAUI Cartesian Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnableDirectionalZooming" aria-label="View EnableDirectionalZooming property in API reference">EnableDirectionalZooming</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to zoom into a specific <code>axis</code> based on the direction of their pinch gesture on touchscreens.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnableDoubleTap" aria-label="View EnableDoubleTap property in API reference">EnableDoubleTap</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to <code>reset</code> the zoom level by double-tapping on the chart plot area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnablePanning" aria-label="View EnablePanning property in API reference">EnablePanning</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to <code>pan</code> or scroll the chart plot area horizontally or vertically when it is zoomed in.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnablePinchZooming" aria-label="View EnablePinchZooming property in API reference">EnablePinchZooming</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to zoom the chart in or out using a <code>two-finger pinch</code> gesture.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_EnableSelectionZooming" aria-label="View EnableSelectionZooming property in API reference">EnableSelectionZooming</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows users to zoom into a specific region by drawing a <code>selection rectangle</code> over the chart plot area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_MaximumZoomLevel" aria-label="View MaximumZoomLevel property in API reference">MaximumZoomLevel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Restricts how far the chart can be <code>zoomed in</code>, preventing data from becoming too magnified.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectFill" aria-label="View SelectionRectFill property in API reference">SelectionRectFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the <code>color</code> or <code>brush</code> used to fill the selection rectangle during selection zooming.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectStroke" aria-label="View SelectionRectStroke property in API reference">SelectionRectStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the <code>color</code> or <code>brush</code> used for the border of the selection rectangle during selection zooming.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectStrokeDashArray" aria-label="View SelectionRectStrokeDashArray property in API reference">SelectionRectStrokeDashArray</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.doublecollection" aria-label="View DoubleCollection type in API reference">DoubleCollection</a></td>
    <td>Applies a custom <code>dash pattern</code> to the border of the selection rectangle to create dashed or dotted lines.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_SelectionRectStrokeWidth" aria-label="View SelectionRectStrokeWidth property in API reference">SelectionRectStrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the <code>thickness</code> of the selection rectangle's border during selection zooming.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomMode" aria-label="View ZoomMode property in API reference">ZoomMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ZoomMode.html" aria-label="View ZoomMode type in API reference">ZoomMode</a></td>
    <td>Restricts zooming and panning to a specific <code>axis</code>, such as horizontal (X), vertical (Y), or both (XY).</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_Reset" aria-label="View Reset method in API reference">Reset()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Restores the chart to its default view by canceling the current zoom and pan positions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomByRange_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_" aria-label="View ZoomByRange method in API reference">ZoomByRange(ChartAxis, Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Zooms the specified axis to fit within the provided <code>start</code> and <code>end</code> double values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomByRange_Syncfusion_Maui_Charts_DateTimeAxis_System_DateTime_System_DateTime_" aria-label="View ZoomByRange method in API reference">ZoomByRange(DateTimeAxis, DateTime, DateTime)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Zooms the DateTime axis to fit within the specified <code>start</code> and <code>end</code> dates.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomIn" aria-label="View ZoomIn method in API reference">ZoomIn()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Magnifies the chart view by a predefined <code>zoom factor</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomOut" aria-label="View ZoomOut method in API reference">ZoomOut()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Reduces the chart magnification by a predefined <code>zoom factor</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomToFactor_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_" aria-label="View ZoomToFactor method in API reference">ZoomToFactor(ChartAxis, Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Adjusts the zoom level of a specific axis to the provided zoom factor and positions the view at the specified <code>offset</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html#Syncfusion_Maui_Charts_ChartZoomPanBehavior_ZoomToFactor_System_Double_" aria-label="View ZoomToFactor method in API reference">ZoomToFactor(Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Uniformly adjusts the zoom level of all axes to the provided <code>zoom factor</code>.</td>
</tr>
</table>
