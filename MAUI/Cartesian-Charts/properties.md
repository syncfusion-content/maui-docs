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
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Annotations">Annotations</a></td>
        <td>ChartAnnotationCollection</td>
        <td>Defines the collection of annotations displayed in the chart.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_CrosshairBehavior">CrosshairBehavior</a></td>
        <td>ChartCrosshairBehavior</td>
        <td>Defines the crosshair behavior for displaying crosshair lines and labels.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_EnableSideBySideSeriesPlacement">EnableSideBySideSeriesPlacement</a></td>
        <td>bool</td>
        <td>Defines whether side-by-side placement is enabled for applicable chart series.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_IsTransposed">IsTransposed</a></td>
        <td>bool</td>
        <td>Defines whether the chart axes are transposed.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PaletteBrushes">PaletteBrushes</a></td>
        <td>IList&lt;Brush&gt;</td>
        <td>Defines the collection of palette brushes used for rendering series.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionBehavior">SelectionBehavior</a></td>
        <td>ChartSelectionBehavior</td>
        <td>Defines the selection behavior for chart segments and data points.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Series">Series</a></td>
        <td>ChartSeriesCollection</td>
        <td>Defines the collection of series displayed in the chart.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballBehavior">TrackballBehavior</a></td>
        <td>ChartTrackballBehavior</td>
        <td>Defines the trackball behavior used to inspect chart data.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_XAxes">XAxes</a></td>
        <td>ChartAxisCollection</td>
        <td>Defines the collection of horizontal axes.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_YAxes">YAxes</a></td>
        <td>ChartAxisCollection</td>
        <td>Defines the collection of vertical axes.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomPanBehavior">ZoomPanBehavior</a></td>
        <td>ChartZoomPanBehavior</td>
        <td>Defines the zooming and panning behavior.</td>
    </tr>
</table>

## Events

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnnotationTapped">AnnotationTapped</a></td>
        <td>EventHandler&lt;ChartAnnotationTappedEventArgs&gt;</td>
        <td>Raised when an annotation is tapped.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AxisLabelTapped">AxisLabelTapped</a></td>
        <td>EventHandler&lt;AxisLabelTappedEventArgs&gt;</td>
        <td>Raised when an axis label is tapped.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_DataLabelTapped">DataLabelTapped</a></td>
        <td>EventHandler&lt;DataLabelTappedEventArgs&gt;</td>
        <td>Raised when a data label is tapped.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResetZoom">ResetZoom</a></td>
        <td>EventHandler&lt;ZoomResetEventArgs&gt;</td>
        <td>Raised when the zoom level is reset.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Scroll">Scroll</a></td>
        <td>EventHandler&lt;ChartScrollEventArgs&gt;</td>
        <td>Raised when the chart is scrolled.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomDelta">SelectionZoomDelta</a></td>
        <td>EventHandler&lt;SelectionZoomDeltaEventArgs&gt;</td>
        <td>Raised while selection zooming is in progress.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomEnd">SelectionZoomEnd</a></td>
        <td>EventHandler&lt;SelectionZoomEndEventArgs&gt;</td>
        <td>Raised when selection zooming ends.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SelectionZoomStart">SelectionZoomStart</a></td>
        <td>EventHandler&lt;SelectionZoomStartEventArgs&gt;</td>
        <td>Raised when selection zooming starts.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_TrackballCreated">TrackballCreated</a></td>
        <td>EventHandler&lt;TrackballCreatedEventArgs&gt;</td>
        <td>Raised when the trackball is created.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomDelta">ZoomDelta</a></td>
        <td>EventHandler&lt;ChartZoomDeltaEventArgs&gt;</td>
        <td>Raised while zooming is in progress.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomEnd">ZoomEnd</a></td>
        <td>EventHandler&lt;ChartZoomEndEventArgs&gt;</td>
        <td>Raised when zooming ends.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ZoomStart">ZoomStart</a></td>
        <td>EventHandler&lt;ChartZoomStartEventArgs&gt;</td>
        <td>Raised when zooming starts.</td>
    </tr>
</table>

## Methods

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_AnimateSeries">AnimateSeries()</a></td>
        <td>void</td>
        <td>Animates all eligible series in the chart.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_PointToValue_Syncfusion_Maui_Charts_ChartAxis_System_Double_System_Double_">PointToValue(ChartAxis, Double, Double)</a></td>
        <td>object</td>
        <td>Converts chart coordinates to the corresponding axis value.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ResumeSeriesNotification">ResumeSeriesNotification()</a></td>
        <td>void</td>
        <td>Resumes chart series notifications.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_SuspendSeriesNotification">SuspendSeriesNotification()</a></td>
        <td>void</td>
        <td>Suspends chart series notifications.</td>
    </tr>
    <tr>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_ValueToPoint_Syncfusion_Maui_Charts_ChartAxis_System_Double_">ValueToPoint(ChartAxis, Double)</a></td>
        <td>System.Single</td>
        <td>A float representing the point coordinate in pixels.</td>
    </tr>
</table>