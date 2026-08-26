---
layout: post
title: CategoryAxis in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members of chart axes, axis labels, ticks, titles, and multi-level labels available in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) API.
platform: maui
control: SfCartesianChart
documentation: ug
---

# CategoryAxis API in .NET MAUI Cartesian Chart

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_ArrangeByIndex" aria-label="View ArrangeByIndex property in API reference">ArrangeByIndex</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Determines whether data points are plotted based on their <code>position in the data source</code> (by index) or based on their underlying <code>values</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_Interval" aria-label="View Interval property in API reference">Interval</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Controls the numeric <code>distance</code> between consecutive axis labels and <code>grid lines</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_LabelPlacement" aria-label="View LabelPlacement property in API reference">LabelPlacement</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelPlacement.html" aria-label="View LabelPlacement type in API reference">LabelPlacement</a></td>
<td>Positions the axis labels either directly <code>on the tick lines</code> or <code>centered between</code> them.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html#Syncfusion_Maui_Charts_CategoryAxis_PlotBands" aria-label="View PlotBands property in API reference">PlotBands</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalPlotBandCollection.html" aria-label="View NumericalPlotBandCollection type in API reference">NumericalPlotBandCollection</a></td>
<td>Defines a collection of <code>rectangular regions</code> highlighted across the axis to visually group or separate ranges of data.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AutoScrollingDelta" aria-label="View AutoScrollingDelta property in API reference">AutoScrollingDelta</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Maintains a <code>fixed visible range</code> of values on the axis, automatically <code>scrolling</code> the chart as new data is added.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AutoScrollingMode" aria-label="View AutoScrollingMode property in API reference">AutoScrollingMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAutoScrollingMode.html" aria-label="View ChartAutoScrollingMode type in API reference">ChartAutoScrollingMode</a></td>
<td>Determines whether the auto-scrolling range is anchored to the <code>start</code> or the <code>end</code> of the axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineOffset" aria-label="View AxisLineOffset property in API reference">AxisLineOffset</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Adds <code>padding</code> between the start of the axis line and the chart area's edge.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_AxisLineStyle" aria-label="View AxisLineStyle property in API reference">AxisLineStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLineStyle.html" aria-label="View ChartLineStyle type in API reference">ChartLineStyle</a></td>
<td>Customizes the <code>stroke</code>, <code>dash pattern</code>, and <code>thickness</code> of the main axis line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossAxisName" aria-label="View CrossAxisName property in API reference">CrossAxisName</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Links the current axis to another axis, enabling them to <code>intersect</code> or <code>cross</code> each other at specific points.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_CrossesAt" aria-label="View CrossesAt property in API reference">CrossesAt</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
<td>Positions the axis line at a <code>specific value</code> on the linked crossing axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_EdgeLabelsDrawingMode" aria-label="View EdgeLabelsDrawingMode property in API reference">EdgeLabelsDrawingMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.EdgeLabelsDrawingMode.html" aria-label="View EdgeLabelsDrawingMode type in API reference">EdgeLabelsDrawingMode</a></td>
<td>Controls the <code>visibility</code> and <code>positioning</code> of the labels at the extreme ends of the axis to prevent them from being clipped.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_EnableAutoIntervalOnZooming" aria-label="View EnableAutoIntervalOnZooming property in API reference">EnableAutoIntervalOnZooming</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Recalculates the axis intervals <code>dynamically</code> to fit the zoomed view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Reverses the direction of the axis, plotting values from <code>high to low</code> instead of <code>low to high</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Controls the visibility of the axis <code>line</code>, <code>labels</code>, and <code>ticks</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelExtent" aria-label="View LabelExtent property in API reference">LabelExtent</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Adjusts the <code>empty space</code> between the axis labels and the axis title.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelRotation" aria-label="View LabelRotation property in API reference">LabelRotation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Rotates the axis labels by a specified <code>angle</code> to prevent overlapping or to improve readability.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsIntersectAction" aria-label="View LabelsIntersectAction property in API reference">LabelsIntersectAction</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisLabelsIntersectAction.html" aria-label="View AxisLabelsIntersectAction type in API reference">AxisLabelsIntersectAction</a></td>
<td>Resolves overlapping axis labels by either <code>hiding</code> them, <code>wrapping</code> their text, or placing them on <code>multiple rows</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelsPosition" aria-label="View LabelsPosition property in API reference">LabelsPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisElementPosition.html" aria-label="View AxisElementPosition type in API reference">AxisElementPosition</a></td>
<td>Positions the axis labels either <code>inside</code> or <code>outside</code> the chart plot area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelStyle.html" aria-label="View ChartAxisLabelStyle type in API reference">ChartAxisLabelStyle</a></td>
<td>Customizes the <code>font</code>, <code>color</code>, and <code>margin</code> of the axis labels.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorGridLineStyle" aria-label="View MajorGridLineStyle property in API reference">MajorGridLineStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLineStyle.html" aria-label="View ChartLineStyle type in API reference">ChartLineStyle</a></td>
<td>Customizes the <code>stroke</code>, <code>dash pattern</code>, and <code>thickness</code> of the major grid lines drawn across the plot area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTickStyle.html" aria-label="View ChartAxisTickStyle type in API reference">ChartAxisTickStyle</a></td>
<td>Customizes the <code>length</code>, <code>thickness</code>, and <code>position</code> of the major tick marks on the axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MaximumLabels" aria-label="View MaximumLabels property in API reference">MaximumLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
<td>Limits the maximum number of axis labels displayed per <code>100 pixels</code> to avoid congestion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MultiLevelLabels" aria-label="View MultiLevelLabels property in API reference">MultiLevelLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html" aria-label="View ChartMultiLevelLabel type in API reference">ChartMultiLevelLabel</a>&gt;</a></td>
<td>Defines a collection of <code>hierarchical labels</code> grouped into multiple levels on the axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_MultiLevelLabelStyle" aria-label="View MultiLevelLabelStyle property in API reference">MultiLevelLabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.MultiLevelLabelStyle.html" aria-label="View MultiLevelLabelStyle type in API reference">MultiLevelLabelStyle</a></td>
<td>Customizes the appearance of the <code>hierarchical</code>, <code>multi-level</code> axis labels.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Name" aria-label="View Name property in API reference">Name</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
<td>Defines a <code>unique identifier</code> for the axis, used to associate series or strip lines with it.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetEnd" aria-label="View PlotOffsetEnd property in API reference">PlotOffsetEnd</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Adds <code>padding</code> between the end of the axis and the last data point or grid line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PlotOffsetStart" aria-label="View PlotOffsetStart property in API reference">PlotOffsetStart</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Adds <code>padding</code> between the start of the axis and the first data point or grid line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_RenderNextToCrossingValue" aria-label="View RenderNextToCrossingValue property in API reference">RenderNextToCrossingValue</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Positions the crossing axis immediately <code>next to its crossing value</code> rather than shifting it to the edge of the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ShowMajorGridLines" aria-label="View ShowMajorGridLines property in API reference">ShowMajorGridLines</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Controls the <code>visibility</code> of the major grid lines across the plot area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ShowTrackballLabel" aria-label="View ShowTrackballLabel property in API reference">ShowTrackballLabel</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
<td>Displays a <code>label</code> on the axis when the trackball or crosshair intersects it.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_TickPosition" aria-label="View TickPosition property in API reference">TickPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.AxisElementPosition.html" aria-label="View AxisElementPosition type in API reference">AxisElementPosition</a></td>
<td>Positions the axis tick marks either <code>inside</code> or <code>outside</code> the chart plot area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_Title" aria-label="View Title property in API reference">Title</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html" aria-label="View ChartAxisTitle type in API reference">ChartAxisTitle</a></td>
<td>Defines the <code>text</code> and <code>appearance</code> of the title displayed adjacent to the axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_TrackballLabelStyle" aria-label="View TrackballLabelStyle property in API reference">TrackballLabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLabelStyle.html" aria-label="View ChartLabelStyle type in API reference">ChartLabelStyle</a></td>
<td>Customizes the <code>font</code>, <code>color</code>, and <code>border</code> of the label shown on the axis during trackball interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_TrackballLabelTemplate" aria-label="View TrackballLabelTemplate property in API reference">TrackballLabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines a custom <code>view template</code> to replace the default appearance of the axis trackball label.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleLabels" aria-label="View VisibleLabels property in API reference">VisibleLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabel.html" aria-label="View ChartAxisLabel type in API reference">ChartAxisLabel</a>&gt;</a></td>
<td>Retrieves the collection of axis labels currently <code>rendered on the screen</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleMaximum" aria-label="View VisibleMaximum property in API reference">VisibleMaximum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Retrieves the <code>maximum value</code> of the axis range currently visible on the screen.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_VisibleMinimum" aria-label="View VisibleMinimum property in API reference">VisibleMinimum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Retrieves the <code>minimum value</code> of the axis range currently visible on the screen.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomFactor" aria-label="View ZoomFactor property in API reference">ZoomFactor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Magnifies the chart view by shrinking the visible axis range to a specified <code>percentage</code> of the total range.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ZoomPosition" aria-label="View ZoomPosition property in API reference">ZoomPosition</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Navigates to a specific portion of the magnified axis range by adjusting the <code>visible starting point</code>.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_PointToValue_System_Double_System_Double_" aria-label="View PointToValue method in API reference">PointToValue(Double, Double)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
<td>Converts a specific <code>screen coordinate</code> into its corresponding <code>data value</code> on the axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ValueToPoint_System_Double_" aria-label="View ValueToPoint method in API reference">ValueToPoint(Double)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.single" aria-label="View float type in API reference">float</a></td>
<td>Converts a specific <code>data value</code> into its corresponding <code>screen coordinate</code> within the chart plot area.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_ActualRangeChanged" aria-label="View ActualRangeChanged event in API reference">ActualRangeChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ActualRangeChangedEventArgs.html" aria-label="View ActualRangeChangedEventArgs type in API reference">ActualRangeChangedEventArgs</a>&gt;</a></td>
<td>Triggered when the visible <code>minimum</code> and <code>maximum</code> values of the axis change due to data updates or zooming.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html#Syncfusion_Maui_Charts_ChartAxis_LabelCreated" aria-label="View LabelCreated event in API reference">LabelCreated</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabelEventArgs.html" aria-label="View ChartAxisLabelEventArgs type in API reference">ChartAxisLabelEventArgs</a>&gt;</a></td>
<td>Triggered before an axis label is rendered, allowing its content to be <code>customized</code> or <code>hidden</code>.</td>
</tr>
</table>
