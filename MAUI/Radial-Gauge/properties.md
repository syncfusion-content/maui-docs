---
layout: post
title: Properties of .NET MAUI Radial Gauge control | Syncfusion®
description: This section explains the properties with Syncfusion<sup>&reg;</sup> MAUI Radial Gauge (SfRadialGauge) control.
platform: maui
control: SfRadialGauge
documentation: ug
---

# API Reference for .NET MAUI Radial Gauge

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfRadialGauge.html#Syncfusion_Maui_Gauges_SfRadialGauge_Axes" aria-label="View Axes property in API reference">Axes</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxisCollection.html" aria-label="View RadialAxisCollection type in API reference">RadialAxisCollection</a></td>
    <td><code>Collection</code> of <code>RadialAxis</code> entries that build the <code>visible scales</code> of the <code>gauge</code>. Add one or more <code>axes</code> to compose <code>single</code> or <code>multiple concentric</code> circular <code>scales</code>.</td>
</tr>
</table>

## Radial Axis Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of <code>axis animations</code>, in <code>milliseconds</code>. Larger values produce <code>slower transitions</code> of <code>pointers</code>, <code>ranges</code>, and <code>visual state changes</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Annotations" aria-label="View Annotations property in API reference">Annotations</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html" aria-label="View GaugeAnnotation type in API reference">ObservableCollection&lt;GaugeAnnotation&gt;</a></td>
    <td><code>Collection</code> of <code>GaugeAnnotation</code> entries placed at <code>precise radial locations</code> on the <code>axis</code>. Use <code>annotations</code> to add <code>labels</code>, <code>icons</code>, or <code>custom views</code> aligned with <code>scale values</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AxisLabelStyle" aria-label="View AxisLabelStyle property in API reference">AxisLabelStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html" aria-label="View GaugeLabelStyle type in API reference">GaugeLabelStyle</a></td>
    <td><code>Text style</code> applied to <code>axis labels</code>, controlling <code>font</code>, <code>size</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AxisLineStyle" aria-label="View AxisLineStyle property in API reference">AxisLineStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialLineStyle.html" aria-label="View RadialLineStyle type in API reference">RadialLineStyle</a></td>
    <td><code>Stroke</code> and <code>thickness</code> applied to the <code>circular axis line</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_BackgroundContent" aria-label="View BackgroundContent property in API reference">BackgroundContent</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>View</code> displayed <code>behind</code> the <code>axis</code> at the <code>gauge center</code>. Use it to host a <code>custom center image</code>, <code>badge</code>, or <code>summary view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_BackgroundContentRadiusFactor" aria-label="View BackgroundContentRadiusFactor property in API reference">BackgroundContentRadiusFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Radial distance</code> of <code>BackgroundContent</code> from the <code>gauge center</code>, expressed as a <code>fraction</code> of the <code>axis radius</code>. Values are <code>clamped</code> between <code>0</code> and <code>1</code>, where <code>1</code> places the <code>content</code> at the <code>outer edge</code> of the <code>axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_CanRotateLabels" aria-label="View CanRotateLabels property in API reference">CanRotateLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>axis labels</code> <code>rotate</code> to follow the <code>circular path</code>. When <code>true</code>, <code>labels</code> remain <code>upright</code> relative to the <code>radial direction</code> instead of <code>tilting</code> along the <code>arc</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_CanScaleToFit" aria-label="View CanScaleToFit property in API reference">CanScaleToFit</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>axis</code> <code>scales its radius</code> to <code>fit the available space</code>. When <code>true</code>, the <code>gauge</code> adapts to <code>layout size changes</code> without <code>clipping</code> or <code>overflow</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EnableLoadingAnimation" aria-label="View EnableLoadingAnimation property in API reference">EnableLoadingAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether a <code>loading animation</code> runs while the <code>axis</code> is being <code>rendered</code> or <code>initialized</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Angle</code>, in <code>degrees</code>, where the <code>circular scale</code> <code>ends</code>. Combined with <code>StartAngle</code>, this defines the <code>sweep</code> of the <code>visible axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Interval" aria-label="View Interval property in API reference">Interval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Spacing</code> between <code>major ticks</code> and <code>labels</code> around the <code>scale</code>. Larger values space the <code>marks</code> <code>farther apart</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>value flow</code> runs in the <code>opposite direction</code>. When <code>true</code>, <code>Maximum</code> is placed at <code>StartAngle</code> and <code>Minimum</code> at <code>EndAngle</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelFormat" aria-label="View LabelFormat property in API reference">LabelFormat</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Format string</code> applied to every <code>axis label</code>, such as <code>"0"</code> or <code>"0.##"</code>, to control <code>numeric precision</code> and <code>culture</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelOffset" aria-label="View LabelOffset property in API reference">LabelOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code> between <code>labels</code> and the <code>axis line</code>. Larger values push <code>labels</code> <code>farther out</code> from the <code>circular path</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelPosition" aria-label="View LabelPosition property in API reference">LabelPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelsPosition.html" aria-label="View GaugeLabelsPosition enum in API reference">GaugeLabelsPosition</a></td>
    <td><code>Position</code> of <code>labels</code> relative to the <code>axis line</code>. Choose a supported <code>GaugeLabelsPosition</code> value such as <code>Inside</code>, <code>Outside</code>, or <code>Cross</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialTickStyle.html" aria-label="View RadialTickStyle type in API reference">RadialTickStyle</a></td>
    <td>Visual <code>style</code> applied to <code>major ticks</code>, including <code>length</code>, <code>thickness</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Upper <code>bound</code> of the <code>axis scale</code>. <code>Pointer</code> and <code>range values</code> cannot <code>exceed</code> this <code>value</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MaximumLabelsCount" aria-label="View MaximumLabelsCount property in API reference">MaximumLabelsCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Maximum</code> <code>number</code> of <code>labels</code> rendered on the <code>axis</code>. Useful for keeping <code>label density</code> low on <code>narrow layouts</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Lower <code>bound</code> of the <code>axis scale</code>. <code>Pointer</code> and <code>range values</code> cannot go <code>below</code> this <code>value</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Number</code> of <code>minor ticks</code> drawn between two <code>major ticks</code>. Larger values produce a <code>finer scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialTickStyle.html" aria-label="View RadialTickStyle type in API reference">RadialTickStyle</a></td>
    <td>Visual <code>style</code> applied to <code>minor ticks</code>, including <code>length</code>, <code>thickness</code>, and <code>color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_OffsetUnit" aria-label="View OffsetUnit property in API reference">OffsetUnit</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html" aria-label="View SizeUnit enum in API reference">SizeUnit</a></td>
    <td><code>Unit</code> used to interpret <code>offset</code> and <code>distance values</code>. Choose a supported <code>SizeUnit</code> value such as <code>Pixel</code> or <code>Factor</code> to control whether <code>values</code> are <code>absolute</code> or <code>relative</code> to the <code>axis radius</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Pointers" aria-label="View Pointers property in API reference">Pointers</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html?tabs=tabid-1" aria-label="View RadialPointer type in API reference">ObservableCollection&lt;RadialPointer&gt;</a></td>
    <td><code>Collection</code> of <code>RadialPointer</code> entries rendered on the <code>axis</code>, such as <code>needles</code>, <code>markers</code>, or <code>range-style indicators</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_RadiusFactor" aria-label="View RadiusFactor property in API reference">RadiusFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Radius</code> of the <code>axis</code> expressed as a <code>fraction</code> of the <code>available gauge space</code>. Values are <code>clamped</code> between <code>0</code> and <code>1</code>; use <code>multiple axes</code> with different <code>factors</code> to build <code>concentric scales</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Ranges" aria-label="View Ranges property in API reference">Ranges</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html" aria-label="View RadialRange type in API reference">ObservableCollection&lt;RadialRange&gt;</a></td>
    <td><code>Collection</code> of <code>RadialRange</code> entries used to <code>highlight</code> <code>value bands</code> across the <code>scale</code>, each with a <code>start</code>, <code>end</code>, and <code>visual style</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowAxisLine" aria-label="View ShowAxisLine property in API reference">ShowAxisLine</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of the <code>circular axis line</code>. Set to <code>false</code> to render the <code>gauge</code> without the <code>base circle</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowFirstLabel" aria-label="View ShowFirstLabel property in API reference">ShowFirstLabel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>label</code> at <code>StartAngle</code> is <code>rendered</code>. Set to <code>false</code> to <code>hide</code> the <code>first label</code> of the <code>scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of <code>axis labels</code>. Set to <code>false</code> to <code>hide labels</code> while keeping <code>ticks</code> <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowLastLabel" aria-label="View ShowLastLabel property in API reference">ShowLastLabel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>label</code> at <code>EndAngle</code> is <code>rendered</code>. Set to <code>false</code> to <code>hide</code> the <code>last label</code> of the <code>scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the <code>visibility</code> of <code>major</code> and <code>minor tick marks</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Angle</code>, in <code>degrees</code>, where the <code>circular scale</code> <code>begins</code>. The <code>scale</code> <code>sweeps clockwise</code> from <code>StartAngle</code> to <code>EndAngle</code> by default.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_TickOffset" aria-label="View TickOffset property in API reference">TickOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code> between <code>tick marks</code> and the <code>axis line</code>. Larger values move <code>ticks</code> <code>farther</code> from the <code>circular path</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_TickPosition" aria-label="View TickPosition property in API reference">TickPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
    <td><code>Position</code> of <code>tick marks</code> relative to the <code>axis line</code>. Choose a supported <code>GaugeElementPosition</code> value such as <code>Inside</code>, <code>Outside</code>, or <code>Cross</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_UseRangeColorForAxis" aria-label="View UseRangeColorForAxis property in API reference">UseRangeColorForAxis</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>axis elements</code> <code>adopt the color</code> of the <code>underlying range</code>. When <code>true</code>, <code>labels</code> and <code>ticks</code> <code>inherit</code> the <code>range color</code> in the <code>matching section</code>.</td>
</tr>
</table>
