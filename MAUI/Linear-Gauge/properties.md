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
    <td><code>Duration</code> of <code>pointer and range animations</code>, in <code>milliseconds</code>. Larger values produce <code>slower transitions</code>; smaller values make the <code>gauge</code> snap to its new <code>value</code> more quickly.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_BarPointers" aria-label="View BarPointers property in API reference">BarPointers</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.BarPointer.html" aria-label="View BarPointerCollection type in API reference">ObservableCollection&lt;BarPointer&gt;</a></td>
    <td><code>Collection</code> of <code>BarPointer</code> entries rendered as <code>bar-shaped value indicators</code> along the <code>linear axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_EnableAxisAnimation" aria-label="View EnableAxisAnimation property in API reference">EnableAxisAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>axis</code> animates when its <code>layout</code> changes. Set to <code>false</code> to disable <code>axis animation</code> while keeping <code>pointer</code> and <code>range animations</code> <code>active</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_EnableRangeAnimation" aria-label="View EnableRangeAnimation property in API reference">EnableRangeAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>ranges</code> animate when their <code>values</code> or <code>widths</code> change.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Interval" aria-label="View Interval property in API reference">Interval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Spacing</code> between <code>major ticks</code> and <code>labels</code> along the <code>linear scale</code>. Larger values space the marks farther apart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>axis</code> runs in the opposite <code>direction</code>. When <code>true</code>, <code>Maximum</code> is placed at the <code>start</code> and <code>Minimum</code> at the <code>end</code> of the <code>axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_IsMirrored" aria-label="View IsMirrored property in API reference">IsMirrored</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>axis-related elements</code> such as <code>labels</code> and <code>ticks</code> are <code>mirrored</code> to the opposite <code>side</code> of the <code>axis line</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelFormat" aria-label="View LabelFormat property in API reference">LabelFormat</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Format string</code> applied to every <code>axis label</code>, such as <code>"0"</code> or <code>"0.##"</code>, to control <code>numeric precision</code> and <code>culture</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelOffset" aria-label="View LabelOffset property in API reference">LabelOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code> between <code>labels</code> and the <code>axis line</code>. Larger values push <code>labels</code> farther away from the <code>axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelPosition" aria-label="View LabelPosition property in API reference">LabelPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
    <td>Position of <code>labels</code> relative to the <code>axis line</code>. Choose a supported <code>GaugeElementPosition</code> value such as <code>Inside</code>, <code>Outside</code>, or <code>Cross</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LabelStyle" aria-label="View LabelStyle property in API reference">LabelStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html" aria-label="View GaugeLabelStyle type in API reference">GaugeLabelStyle</a></td>
    <td><code>Text style</code> applied to <code>axis labels</code>, controlling <code>font</code>, <code>size</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_LineStyle" aria-label="View LineStyle property in API reference">LineStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearLineStyle.html" aria-label="View LinearLineStyle type in API reference">LinearLineStyle</a></td>
    <td><code>Visual style</code> of the <code>axis line</code>, including <code>thickness</code>, <code>color</code>, and <code>dash pattern</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearTickStyle.html" aria-label="View LinearTickStyle type in API reference">LinearTickStyle</a></td>
    <td><code>Visual style</code> applied to <code>major ticks</code>, including <code>length</code>, <code>thickness</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MarkerPointers" aria-label="View MarkerPointers property in API reference">MarkerPointers</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearMarkerPointer.html" aria-label="View LinearMarkerPointer type in API reference">ObservableCollection&lt;LinearMarkerPointer&gt;</a></td>
    <td><code>Collection</code> of <code>LinearMarkerPointer</code> entries rendered as <code>pointer indicators</code> along the <code>scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Upper boundary</code> of the <code>linear scale</code>. <code>Pointer</code> and <code>range values</code> cannot exceed this value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MaximumLabelsCount" aria-label="View MaximumLabelsCount property in API reference">MaximumLabelsCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Maximum number</code> of <code>labels</code> rendered on the <code>axis</code>. Useful for keeping <code>label density</code> low on <code>narrow layouts</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Lower boundary</code> of the <code>linear scale</code>. <code>Pointer</code> and <code>range values</code> cannot go below this value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Number</code> of <code>minor ticks</code> drawn between <code>two major ticks</code>. Larger values produce a <code>finer scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearTickStyle.html" aria-label="View LinearTickStyle type in API reference">LinearTickStyle</a></td>
    <td><code>Visual style</code> applied to <code>minor ticks</code>, including <code>length</code>, <code>thickness</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeOrientation.html" aria-label="View GaugeOrientation enum in API reference">GaugeOrientation</a></td>
    <td>Layout <code>direction</code> of the <code>gauge</code>. Choose a supported <code>GaugeOrientation</code> value such as <code>Horizontal</code> or <code>Vertical</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_Ranges" aria-label="View Ranges property in API reference">Ranges</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LinearRange.html" aria-label="View LinearRange type in API reference">ObservableCollection&lt;LinearRange&gt;</a></td>
    <td><code>Collection</code> of <code>LinearRange</code> entries used to <code>highlight</code> <code>value bands</code> across the <code>scale</code>, each with a <code>start</code>, <code>end</code>, and <code>visual style</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of <code>axis labels</code>. Set to <code>false</code> to hide <code>labels</code> while keeping <code>ticks visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowLine" aria-label="View ShowLine property in API reference">ShowLine</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of the <code>axis line</code>. Set to <code>false</code> to render the <code>gauge</code> without the <code>main track</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of <code>major</code> and <code>minor tick marks</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickOffset" aria-label="View TickOffset property in API reference">TickOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code> between <code>tick marks</code> and the <code>axis line</code>. Larger values move <code>ticks</code> farther from the <code>axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_TickPosition" aria-label="View TickPosition property in API reference">TickPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
    <td>Position of <code>tick marks</code> relative to the <code>axis line</code>. Choose a supported <code>GaugeElementPosition</code> value such as <code>Inside</code>, <code>Outside</code>, or <code>Cross</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_UseRangeColorForAxis" aria-label="View UseRangeColorForAxis property in API reference">UseRangeColorForAxis</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>axis elements</code> adopt the <code>color</code> of the <code>underlying range</code>. When <code>true</code>, <code>labels</code> and <code>ticks</code> inherit the <code>range color</code> in the <code>matching section</code>.</td>
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
    <td>Converts the specified <code>axis factor</code>, expressed as a value between <code>0</code> and <code>1</code>, to the corresponding <code>scale value</code> within <code>Minimum</code> and <code>Maximum</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_GenerateVisibleLabels" aria-label="View GenerateVisibleLabels() method in API reference">GenerateVisibleLabels()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Regenerates the <code>visible axis labels</code> based on the <code>current axis configuration</code>. Use it after programmatically changing <code>axis properties</code> to force an <code>immediate label update</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfLinearGauge.html#Syncfusion_Maui_Gauges_SfLinearGauge_ValueToFactor_System_Double_" aria-label="View ValueToFactor(Double) method in API reference">ValueToFactor(Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Converts the specified <code>scale value</code> to its corresponding <code>axis factor</code>, expressed as a value between <code>0</code> and <code>1</code>.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.LabelCreatedEventArgs.html" aria-label="View LabelCreatedEventArgs type in API reference">LabelCreatedEventArgs</a>&gt;</a></td>
    <td>Triggered when an <code>axis label</code> is <code>created</code>, allowing the <code>label text</code> or <code>appearance</code> to be customized before it is <code>rendered</code>.</td>
</tr>
</table>
