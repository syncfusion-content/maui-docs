---
layout: post
title: Properties of .NET MAUI Cartesian Chart control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Cartesian Chart (SfCartesianChart) control.
platform: maui
control: SfCartesianChart
documentation: ug
---

# .NET MAUI Cartesian Chart API Reference

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
    <td>Adds <code>text</code>, <code>shapes</code>, <code>images</code>, or <code>lines</code> at specified positions in the chart to highlight or explain data.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_CrosshairBehavior" aria-label="View CrosshairBehavior property in API reference">CrosshairBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartCrosshairBehavior.html" aria-label="View ChartCrosshairBehavior type in API reference">ChartCrosshairBehavior</a></td>
    <td>Enables <code>crosshair lines</code> and <code>axis labels</code> for precise value inspection when the user interacts with the <code>plot area</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_EnableSideBySideSeriesPlacement" aria-label="View EnableSideBySideSeriesPlacement property in API reference">EnableSideBySideSeriesPlacement</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Places compatible series <code>beside one another</code> when enabled and draws them <code>over one another</code> when disabled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_IsTransposed" aria-label="View IsTransposed property in API reference">IsTransposed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Changes the chart <code>orientation</code> by displaying the <code>X-axis</code> vertically and the <code>Y-axis</code> horizontally.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
    <td>Applies an <code>ordered set</code> of <code>brushes</code> to the chart series, allowing each series to use a distinct <code>color</code> or <code>gradient</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html" aria-label="View ChartSelectionBehavior type in API reference">ChartSelectionBehavior</a></td>
    <td>Enables <code>single</code> or <code>multiple</code> series selection and controls how selected series are <code>highlighted</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series" aria-label="View Series property in API reference">Series</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeriesCollection.html" aria-label="View ChartSeriesCollection type in API reference">ChartSeriesCollection</a></td>
    <td>Defines the series rendered in the Cartesian chart, with each series visualizing its configured <code>data</code> in a supported <code>chart type</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballBehavior" aria-label="View TrackballBehavior property in API reference">TrackballBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTrackballBehavior.html" aria-label="View ChartTrackballBehavior type in API reference">ChartTrackballBehavior</a></td>
    <td>Displays <code>labels</code> for <code>data points</code> near the user's <code>interaction position</code>, making values across one or more series easier to inspect.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes" aria-label="View XAxes property in API reference">XAxes</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisCollection.html" aria-label="View ChartAxisCollection type in API reference">ChartAxisCollection</a></td>
    <td>Defines the chart's <code>X-axes</code>, which support <code>category</code>, <code>numeric</code>, and <code>date-time</code> scales. <code>X-axes</code> are horizontal unless the chart is <code>transposed</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes" aria-label="View YAxes property in API reference">YAxes</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisCollection.html" aria-label="View ChartAxisCollection type in API reference">ChartAxisCollection</a></td>
    <td>Defines the chart's <code>Y-axes</code>, which use <code>numeric scales</code>. <code>Y-axes</code> are vertical unless the chart is <code>transposed</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomPanBehavior" aria-label="View ZoomPanBehavior property in API reference">ZoomPanBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomPanBehavior.html" aria-label="View ChartZoomPanBehavior type in API reference">ChartZoomPanBehavior</a></td>
    <td>Enables and configures supported <code>zooming</code> and <code>panning interactions</code> so users can inspect a smaller range of chart data.</td>
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
    <td>Starts the configured <code>animation</code> for each visible series in the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_" aria-label="View PointToValue method in API reference">PointToValue(ChartAxis, double, double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Converts a <code>point</code> in the chart, measured in <code>pixels</code>, to its corresponding <code>data value</code> on the specified axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResumeSeriesNotification" aria-label="View ResumeSeriesNotification method in API reference">ResumeSeriesNotification()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Applies all data-source changes buffered after <code>SuspendSeriesNotification()</code> in one consolidated chart update. It has no effect when <code>notifications</code> are not suspended.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SuspendSeriesNotification" aria-label="View SuspendSeriesNotification method in API reference">SuspendSeriesNotification()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Buffers <code>data-source changes</code> across all Cartesian series until <code>ResumeSeriesNotification()</code> is called, avoiding a separate render for each change. Repeated calls while <code>notifications</code> are already suspended have no additional effect.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_" aria-label="View ValueToPoint method in API reference">ValueToPoint(ChartAxis, double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.single" aria-label="View Single type in API reference">float</a></td>
    <td>Converts a <code>data value</code> on the specified axis to its corresponding <code>chart coordinate</code> in pixels.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartAnnotationTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotationTappedEventArgs.html" aria-label="View ChartAnnotationTappedEventArgs type in API reference">ChartAnnotationTappedEventArgs&gt;</a></a></td>
    <td>Triggered when the user <code>taps</code> an <code>annotation</code> in the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AxisLabelTapped" aria-label="View AxisLabelTapped event in API reference">AxisLabelTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;AxisLabelTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelTappedEventArgs.html" aria-label="View AxisLabelTappedEventArgs type in API reference">AxisLabelTappedEventArgs&gt;</a></a></td>
    <td>Triggered when the user taps an <code>axis label</code>, providing the tapped <code>axis</code>, <code>label</code>, and <code>position</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_DataLabelTapped" aria-label="View DataLabelTapped event in API reference">DataLabelTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;DataLabelTappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataLabelTappedEventArgs.html" aria-label="View DataLabelTappedEventArgs type in API reference">DataLabelTappedEventArgs&gt;</a></a></td>
    <td>Triggered when the user taps a <code>data label</code>, providing its <code>series</code>, <code>data point</code>, <code>tap position</code>, and <code>segment information</code> when available.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResetZoom" aria-label="View ResetZoom event in API reference">ResetZoom</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ZoomResetEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ZoomResetEventArgs.html" aria-label="View ZoomResetEventArgs type in API reference">ZoomResetEventArgs&gt;</a></a></td>
    <td>Triggered for each chart axis after a <code>double-tap</code> resets the zoom, providing the axis's <code>previous zoom factor</code> and <code>position</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Scroll" aria-label="View Scroll event in API reference">Scroll</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartScrollEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartScrollEventArgs.html" aria-label="View ChartScrollEventArgs type in API reference">ChartScrollEventArgs&gt;</a></a></td>
    <td>Triggered for each chart axis during <code>panning</code>, providing its current <code>zoom position</code> and allowing the <code>pan operation</code> to be canceled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomDelta" aria-label="View SelectionZoomDelta event in API reference">SelectionZoomDelta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomDeltaEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomDeltaEventArgs.html" aria-label="View SelectionZoomDeltaEventArgs type in API reference">SelectionZoomDeltaEventArgs&gt;</a></a></td>
    <td>Triggered while the user changes the <code>box-selection region</code>, providing its current <code>bounds</code> and allowing <code>selection zooming</code> to be canceled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomEnd" aria-label="View SelectionZoomEnd event in API reference">SelectionZoomEnd</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomEndEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomEndEventArgs.html" aria-label="View SelectionZoomEndEventArgs type in API reference">SelectionZoomEndEventArgs&gt;</a></a></td>
    <td>Triggered after <code>box-selection zooming</code> finishes, providing the final <code>bounds</code> of the <code>zoomed region</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomStart" aria-label="View SelectionZoomStart event in API reference">SelectionZoomStart</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionZoomStartEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SelectionZoomStartEventArgs.html" aria-label="View SelectionZoomStartEventArgs type in API reference">SelectionZoomStartEventArgs&gt;</a></a></td>
    <td>Triggered when the user begins <code>box-selection zooming</code>, providing the initial <code>bounds</code> of the <code>selection region</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated" aria-label="View TrackballCreated event in API reference">TrackballCreated</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;TrackballCreatedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.TrackballCreatedEventArgs.html" aria-label="View TrackballCreatedEventArgs type in API reference">TrackballCreatedEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>trackball</code> moves from one <code>data point</code> to another, allowing its <code>labels</code> and <code>markers</code> to be customized for the current points.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomDelta" aria-label="View ZoomDelta event in API reference">ZoomDelta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomDeltaEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomDeltaEventArgs.html" aria-label="View ChartZoomDeltaEventArgs type in API reference">ChartZoomDeltaEventArgs&gt;</a></a></td>
    <td>Triggered for each chart axis while <code>zooming</code>, providing the <code>previous</code> and <code>current zoom factor</code> and <code>position</code> and allowing the <code>zoom operation</code> to be canceled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomEnd" aria-label="View ZoomEnd event in API reference">ZoomEnd</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomEndEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomEndEventArgs.html" aria-label="View ChartZoomEndEventArgs type in API reference">ChartZoomEndEventArgs&gt;</a></a></td>
    <td>Triggered for each chart axis after <code>zooming</code> finishes, providing its final <code>zoom factor</code> and <code>position</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomStart" aria-label="View ZoomStart event in API reference">ZoomStart</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChartZoomStartEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartZoomStartEventArgs.html" aria-label="View ChartZoomStartEventArgs type in API reference">ChartZoomStartEventArgs&gt;</a></a></td>
    <td>Triggered for each chart axis when the user starts <code>pinch zooming</code>, providing the updated <code>zoom factor</code> and <code>position</code> and allowing the <code>zoom operation</code> to be canceled.</td>
</tr>
</table>
