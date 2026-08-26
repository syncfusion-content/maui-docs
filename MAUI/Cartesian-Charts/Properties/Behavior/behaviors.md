---
layout: post
title: Behaviors in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members of tooltip, trackball, crosshair, zoom and pan, and selection behaviors available in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) API.
platform: maui
control: SfCartesianChart
documentation: ug
---

# Behaviors API in .NET MAUI Cartesian Chart

This page lists the public properties, methods, and events of tooltip, trackball, crosshair, zoom and pan, and selection behaviors.

<table>
<tr>
    <th>Class</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartCrosshairBehavior.html" aria-label="View ChartCrosshairBehavior class in API reference">ChartCrosshairBehavior</a></td>
    <td>Members declared by <code>ChartCrosshairBehavior</code> for configuring the <code>crosshair lines</code> that intersect at the <code>pointer position</code>, including <code>vertical</code> and <code>horizontal line</code> color, <code>stroke width</code>, and <code>dash pattern</code>; <code>axis label</code> visibility and styling; <code>line cap</code> visibility; <code>pointer line</code> appearance; and <code>activation trigger</code> (long press). Used to overlay precise <code>reference lines</code> on the chart to read <code>data values</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html" aria-label="View ChartSelectionBehavior class in API reference">ChartSelectionBehavior</a></td>
    <td>Members declared by <code>ChartSelectionBehavior</code>, the <code>abstract base class</code> for series and data point selection, including <code>selection type</code> (single, multiple, deselect on tap), <code>selection customization</code> via <code>SelectionChanging</code> and <code>SelectionChanged</code> events, and the <code>path</code> or <code>value mapping</code> used to identify selected items. Derived by <code>DataPointSelectionBehavior</code> and <code>SeriesSelectionBehavior</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html" aria-label="View ChartTooltipBehavior class in API reference">ChartTooltipBehavior</a></td>
    <td>Members declared by <code>ChartTooltipBehavior</code>, including <code>enable/disable</code>, <code>duration</code>, <code>text style</code>, <code>background</code>, <code>border</code>, <code>padding</code>, <code>margin</code>, <code>shared tooltip mode</code> across series, <code>template customization</code>, <code>position mode</code>, and <code>TooltipShowing</code> event. Used to display <code>formatted tooltips</code> for the <code>data point</code> under the pointer.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html" aria-label="View ChartTrackballBehavior class in API reference">ChartTrackballBehavior</a></td>
    <td>Members declared by <code>ChartTrackballBehavior</code>, including <code>activation via long press</code>, <code>line stroke</code>, <code>label background</code>, <code>label style</code>, <code>marker visibility</code>, <code>line dash pattern</code>, <code>intersected series labels</code>, <code>axis label styling</code>, and <code>template customization</code>. Used to display a <code>vertical line</code> crossing the chart at the pointer and surface the <code>value</code> of every plotted series at that <code>x-position</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html" aria-label="View ChartZoomPanBehavior class in API reference">ChartZoomPanBehavior</a></td>
    <td>Members declared by <code>ChartZoomPanBehavior</code>, including <code>enable/disable zoom and pan</code>, <code>pinch zoom</code> and <code>double-tap zoom</code> toggles, <code>mouse-wheel zoom</code>, <code>horizontal</code> and <code>vertical zoom direction</code>, <code>minimum</code> and <code>maximum zoom levels</code>, <code>selection rectangle zooming</code>, <code>selection brush</code> and <code>stroke</code>, and <code>pinch gesture sensitivity</code>. Used to allow the user to <code>zoom into</code> and <code>pan across</code> the chart interactively.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TooltipInfo.html" aria-label="View TooltipInfo class in API reference">TooltipInfo</a></td>
    <td>Members declared by <code>TooltipInfo</code>, a <code>contextual data payload</code> that the <code>ChartTooltipBehavior</code> exposes to <code>template bindings</code> and <code>event handlers</code>. Includes <code>series</code>, <code>data point</code>, <code>x</code> and <code>y values</code>, <code>text</code>, <code>formatted text</code>, and any <code>custom content</code> the <code>tooltip template</code> binds to. Used to drive the <code>appearance</code> of each <code>tooltip instance</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TrackballPointInfo.html" aria-label="View TrackballPointInfo class in API reference">TrackballPointInfo</a></td>
    <td>Members declared by <code>TrackballPointInfo</code>, a <code>contextual data payload</code> that the <code>ChartTrackballBehavior</code> exposes to <code>template bindings</code> and <code>event handlers</code> for the <code>data point</code> intersected by the trackball. Includes <code>series</code>, <code>data point</code>, <code>x</code> and <code>y values</code>, <code>label text</code>, and any <code>custom content</code> the <code>trackball label template</code> binds to. Used to drive the <code>appearance</code> of each <code>trackball marker</code> and <code>label</code>.</td>
</tr>
</table>
