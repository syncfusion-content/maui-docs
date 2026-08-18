---
layout: post
title: Properties of .NET MAUI Cartesian Chart control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# API Reference for .NET MAUI Cartesian Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Annotations" aria-label="View Annotations property in API reference">Annotations</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotationCollection.html" aria-label="View ChartAnnotationCollection type in API reference">ChartAnnotationCollection</a></td>
    <td>Collection of annotations displayed on the chart. Use this to place custom text, shapes, or callout at specific chart positions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_CrosshairBehavior" aria-label="View CrosshairBehavior property in API reference">CrosshairBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartCrosshairBehavior.html" aria-label="View ChartCrosshairBehavior type in API reference">ChartCrosshairBehavior</a></td>
    <td>Crosshair behavior used to show reference lines and labels when the user inspects values in the chart area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_EnableSideBySideSeriesPlacement" aria-label="View EnableSideBySideSeriesPlacement property in API reference">EnableSideBySideSeriesPlacement</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether compatible series are placed <code>side by side</code> instead of overlapping. Enable this for clearer comparison between series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_IsTransposed" aria-label="View IsTransposed property in API reference">IsTransposed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the chart axes are swapped. Set this to <code>true</code> to display the chart in a <code>transposed</code> orientation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
    <td>Collection of brushes used to color chart series. This lets each series or segment use a distinct visual palette.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html" aria-label="View ChartSelectionBehavior type in API reference">ChartSelectionBehavior</a></td>
    <td>Selection behavior used to highlight data points or chart segments when the user interacts with the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series" aria-label="View Series property in API reference">Series</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeriesCollection.html" aria-label="View ChartSeriesCollection type in API reference">ChartSeriesCollection</a></td>
    <td>Collection of chart series displayed in the Cartesian chart. Each series can represent a different data set or visual style.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballBehavior" aria-label="View TrackballBehavior property in API reference">TrackballBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html" aria-label="View ChartTrackballBehavior type in API reference">ChartTrackballBehavior</a></td>
    <td>Trackball behavior used to inspect values at a chosen position across one or more series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes" aria-label="View XAxes property in API reference">XAxes</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisCollection.html" aria-label="View ChartAxisCollection type in API reference">ChartAxisCollection</a></td>
    <td>Collection of horizontal axes used by the chart. These axes define labels, scale, and positioning along the <code>X</code> direction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes" aria-label="View YAxes property in API reference">YAxes</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisCollection.html" aria-label="View ChartAxisCollection type in API reference">ChartAxisCollection</a></td>
    <td>Collection of vertical axes used by the chart. These axes define labels, scale, and positioning along the <code>Y</code> direction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomPanBehavior" aria-label="View ZoomPanBehavior property in API reference">ZoomPanBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html" aria-label="View ChartZoomPanBehavior type in API reference">ChartZoomPanBehavior</a></td>
    <td>Zoom and pan behavior used to control how users navigate through large or detailed chart data.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnimateSeries" aria-label="View AnimateSeries method in API reference">AnimateSeries()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Animates all eligible series in the chart. Use this when you want the series to appear with motion after data is loaded or updated.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_" aria-label="View PointToValue method in API reference">PointToValue(ChartAxis, double, double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Converts a point on the chart to the corresponding axis value. Use this to map touch or pointer coordinates back to data values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResumeSeriesNotification" aria-label="View ResumeSeriesNotification method in API reference">ResumeSeriesNotification()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Resumes series notifications after they were suspended. Call this after batching updates to refresh the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SuspendSeriesNotification" aria-label="View SuspendSeriesNotification method in API reference">SuspendSeriesNotification()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Suspends series notifications temporarily. Use this while performing multiple updates to improve performance.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_" aria-label="View ValueToPoint method in API reference">ValueToPoint(ChartAxis, double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.single" aria-label="View Single type in API reference">float</a></td>
    <td>Converts an axis value to the corresponding point coordinate in the chart area. Use this to locate the plotted position of a value.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnnotationTapped" aria-label="View AnnotationTapped event in API reference">AnnotationTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartAnnotationTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotationTappedEventArgs.html" aria-label="View ChartAnnotationTappedEventArgs type in API reference">ChartAnnotationTappedEventArgs</a>&gt;</a></td>
    <td>Raised when a chart annotation is tapped. Use this event to respond to annotation-based user interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AxisLabelTapped" aria-label="View AxisLabelTapped event in API reference">AxisLabelTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;AxisLabelTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html" aria-label="View AxisLabelTappedEventArgs type in API reference">AxisLabelTappedEventArgs</a>&gt;</a></td>
    <td>Raised when an axis label is tapped. This is useful for building custom axis selection or drill-down experiences.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_DataLabelTapped" aria-label="View DataLabelTapped event in API reference">DataLabelTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;DataLabelTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelTappedEventArgs.html" aria-label="View DataLabelTappedEventArgs type in API reference">DataLabelTappedEventArgs</a>&gt;</a></td>
    <td>Raised when a data label is tapped. Use this event to handle selections, tooltips, or custom actions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResetZoom" aria-label="View ResetZoom event in API reference">ResetZoom</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ZoomResetEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ZoomResetEventArgs.html" aria-label="View ZoomResetEventArgs type in API reference">ZoomResetEventArgs</a>&gt;</a></td>
    <td>Raised when the chart zoom is reset to its default state. Use this to refresh dependent UI or restore view state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Scroll" aria-label="View Scroll event in API reference">Scroll</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartScrollEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartScrollEventArgs.html" aria-label="View ChartScrollEventArgs type in API reference">ChartScrollEventArgs</a>&gt;</a></td>
    <td>Raised when the chart is scrolled. This helps track navigation across a large data range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomDelta" aria-label="View SelectionZoomDelta event in API reference">SelectionZoomDelta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomDeltaEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomDeltaEventArgs.html" aria-label="View SelectionZoomDeltaEventArgs type in API reference">SelectionZoomDeltaEventArgs</a>&gt;</a></td>
    <td>Raised while selection zoom is in progress. Use this event to track the currently selected zoom rectangle.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomEnd" aria-label="View SelectionZoomEnd event in API reference">SelectionZoomEnd</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomEndEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomEndEventArgs.html" aria-label="View SelectionZoomEndEventArgs type in API reference">SelectionZoomEndEventArgs</a>&gt;</a></td>
    <td>Raised when selection zoom ends. Use this event to capture the final zoom range applied to the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomStart" aria-label="View SelectionZoomStart event in API reference">SelectionZoomStart</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomStartEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomStartEventArgs.html" aria-label="View SelectionZoomStartEventArgs type in API reference">SelectionZoomStartEventArgs</a>&gt;</a></td>
    <td>Raised when selection zoom starts. This lets you prepare the chart before the zoom range is applied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated" aria-label="View TrackballCreated event in API reference">TrackballCreated</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;TrackballCreatedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TrackballCreatedEventArgs.html" aria-label="View TrackballCreatedEventArgs type in API reference">TrackballCreatedEventArgs</a>&gt;</a></td>
    <td>Raised when the trackball is created. Use this event to customize the trackball experience after initialization.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomDelta" aria-label="View ZoomDelta event in API reference">ZoomDelta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomDeltaEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomDeltaEventArgs.html" aria-label="View ChartZoomDeltaEventArgs type in API reference">ChartZoomDeltaEventArgs</a>&gt;</a></td>
    <td>Raised while zooming is in progress. This event can be used to monitor live zoom changes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomEnd" aria-label="View ZoomEnd event in API reference">ZoomEnd</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomEndEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomEndEventArgs.html" aria-label="View ChartZoomEndEventArgs type in API reference">ChartZoomEndEventArgs</a>&gt;</a></td>
    <td>Raised when zooming ends. Use this event to apply actions after the final zoom range is available.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomStart" aria-label="View ZoomStart event in API reference">ZoomStart</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomStartEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomStartEventArgs.html" aria-label="View ChartZoomStartEventArgs type in API reference">ChartZoomStartEventArgs</a>&gt;</a></td>
    <td>Raised when zooming starts. This is useful for preparing the chart before the zoom interaction begins.</td>
</tr>
</table>
