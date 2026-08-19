---
layout: post
title: Properties of .NET MAUI Linear Gauge control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Linear Gauge (SfLinearGauge) control.
platform: maui
control: SfLinearGauge
documentation: ug
---

# API Reference for .NET MAUI Linear Gauge

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the duration, in milliseconds, used for pointer and range animations. Larger values create a slower transition and smaller values produce a faster visual update.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_BarPointers" aria-label="View BarPointers property in API reference">BarPointers</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html" aria-label="View BarPointerCollection type in API reference">ObservableCollection&lt;BarPointer&gt;</a></td>
<td>Defines the collection of bar pointers displayed in the gauge and acts as the container for the bar-style value indicators rendered along the linear axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_EnableAxisAnimation" aria-label="View EnableAxisAnimation property in API reference">EnableAxisAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether axis animation is enabled and controls whether the axis renders with animated transitions during layout updates.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_EnableRangeAnimation" aria-label="View EnableRangeAnimation property in API reference">EnableRangeAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether range animation is enabled and controls whether range elements animate when their visual state changes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval" aria-label="View Interval property in API reference">Interval</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the interval between major ticks and labels and establishes the spacing used to divide the linear scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the axis direction is reversed and changes the value flow along the linear gauge.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored" aria-label="View IsMirrored property in API reference">IsMirrored</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the gauge elements are mirrored and flips the visual placement of axis-related components.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelFormat" aria-label="View LabelFormat property in API reference">LabelFormat</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the format string used for axis labels and controls how values are displayed along the linear scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelOffset" aria-label="View LabelOffset property in API reference">LabelOffset</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the distance between labels and the axis line and controls how far labels appear from the linear axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelPosition" aria-label="View LabelPosition property in API reference">LabelPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
<td>Defines the position of labels relative to the axis by using the <code>GaugeElementPosition</code> enum and controls whether labels appear inside, outside, or centered around the axis line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html" aria-label="View GaugeLabelStyle type in API reference">GaugeLabelStyle</a></td>
<td>Defines the appearance of axis labels and provides control over typography, color, alignment, and other label styling details.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LineStyle" aria-label="View LineStyle property in API reference">LineStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html" aria-label="View LinearLineStyle type in API reference">LinearLineStyle</a></td>
<td>Defines the appearance of the axis line and controls the visual styling applied to the linear gauge track.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearTickStyle.html" aria-label="View LinearTickStyle type in API reference">LinearTickStyle</a></td>
<td>Defines the appearance of major ticks and controls the visual treatment used for primary scale markers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MarkerPointers" aria-label="View MarkerPointers property in API reference">MarkerPointers</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearMarkerPointer.html" aria-label="View LinearMarkerPointer type in API reference">ObservableCollection&lt;LinearMarkerPointer&gt;</a></td>
<td>Defines the collection of marker pointers displayed in the gauge and serves as the container for pointer-based indicators along the scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the maximum value of the gauge axis and establishes the upper boundary of the linear scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MaximumLabelsCount" aria-label="View MaximumLabelsCount property in API reference">MaximumLabelsCount</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the maximum number of labels displayed on the axis and helps control label density in compact layouts.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the minimum value of the gauge axis and establishes the lower boundary of the linear scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the number of minor ticks between major intervals and controls the granularity of the scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearTickStyle.html" aria-label="View LinearTickStyle type in API reference">LinearTickStyle</a></td>
<td>Defines the appearance of minor ticks and controls the styling used for secondary scale markers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeOrientation.html" aria-label="View GaugeOrientation enum in API reference">GaugeOrientation</a></td>
<td>Defines whether the gauge is displayed horizontally or vertically by using the <code>GaugeOrientation</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Ranges" aria-label="View Ranges property in API reference">Ranges</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html" aria-label="View LinearRange type in API reference">ObservableCollection&lt;LinearRange&gt;</a></td>
<td>Defines the collection of ranges displayed in the gauge and provides the container used to highlight value bands across the scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether axis labels are displayed and controls the visibility of label text on the scale.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowLine" aria-label="View ShowLine property in API reference">ShowLine</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the axis line is displayed and controls the visibility of the main linear track.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether tick marks are displayed and controls the visibility of major and minor tick markers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickOffset" aria-label="View TickOffset property in API reference">TickOffset</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the distance between tick marks and the axis line and controls how far ticks are positioned from the main axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickPosition" aria-label="View TickPosition property in API reference">TickPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
<td>Defines the position of tick marks relative to the axis by using the <code>GaugeElementPosition</code> enum and controls whether ticks appear inside, outside, or centered on the axis line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_UseRangeColorForAxis" aria-label="View UseRangeColorForAxis property in API reference">UseRangeColorForAxis</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether range colors are applied to axis elements and enables range-based styling for the linear scale.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_FactorToValue_System_Double_" aria-label="View FactorToValue(Double) method in API reference">FactorToValue(Double)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Converts the specified axis factor to its corresponding gauge value.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_GenerateVisibleLabels" aria-label="View GenerateVisibleLabels() method in API reference">GenerateVisibleLabels()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Generates the labels currently visible on the axis and refreshes the label set used for rendering.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ValueToFactor_System_Double_" aria-label="View ValueToFactor(Double) method in API reference">ValueToFactor(Double)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Converts the specified gauge value to its corresponding axis factor.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelCreated" aria-label="View LabelCreated event in API reference">LabelCreated</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LabelCreatedEventArgs.html" aria-label="View LabelCreatedEventArgs type in API reference">LabelCreatedEventArgs&gt;</a></a></td>
<td>Raised when an axis label is created and allows label content or appearance to be customized before the label is rendered.</td>
</tr>
</table>