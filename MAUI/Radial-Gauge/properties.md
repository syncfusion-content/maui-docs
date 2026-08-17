---
layout: post
title: Properties of .NET MAUI Radial Gauge control | Syncfusion®
description: This section explains the properties with Syncfusion® MAUI Radial Gauge (SfRadialGauge) control.
platform: maui
control: SfRadialGauge
documentation: ug
---

# .NET MAUI Radial Gauge API Reference

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
    <td>Defines the collection of radial axes displayed in the gauge and serves as the primary container for building one or more circular scale segments.</td>
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
    <td>Defines the duration, in milliseconds, used for axis animation and controls how long value or visual transitions take to complete.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Annotations" aria-label="View Annotations property in API reference">Annotations</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeAnnotation.html" aria-label="View GaugeAnnotation type in API reference">ObservableCollection&lt;GaugeAnnotation&gt;</a></td>
    <td>Defines the collection of annotations displayed on the axis and provides a way to place supplementary content at precise radial locations.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AxisLabelStyle" aria-label="View AxisLabelStyle property in API reference">AxisLabelStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelStyle.html" aria-label="View GaugeLabelStyle type in API reference">GaugeLabelStyle</a></td>
    <td>Defines the appearance of axis labels and controls font settings, color, and other text-related styling for the scale values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_AxisLineStyle" aria-label="View AxisLineStyle property in API reference">AxisLineStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialLineStyle.html" aria-label="View RadialLineStyle type in API reference">RadialLineStyle</a></td>
    <td>Defines the appearance of the axis line and controls the stroke, thickness, and overall presentation of the circular base scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_BackgroundContent" aria-label="View BackgroundContent property in API reference">BackgroundContent</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Defines the content displayed behind the axis and allows custom visual elements to be positioned underneath the gauge scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_BackgroundContentRadiusFactor" aria-label="View BackgroundContentRadiusFactor property in API reference">BackgroundContentRadiusFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the radius factor used to position background content and controls how far the content sits from the center of the gauge.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_CanRotateLabels" aria-label="View CanRotateLabels property in API reference">CanRotateLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether axis labels rotate along the circular path and helps keep labels aligned with the radial direction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_CanScaleToFit" aria-label="View CanScaleToFit property in API reference">CanScaleToFit</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the axis automatically scales to fit the available space and helps the gauge adapt to different layouts without clipping.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EnableLoadingAnimation" aria-label="View EnableLoadingAnimation property in API reference">EnableLoadingAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether loading animation is enabled and provides animated feedback while the axis is being rendered or initialized.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the end angle of the radial axis and controls where the circular scale stops in the gauge layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Interval" aria-label="View Interval property in API reference">Interval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the interval between major ticks and labels and controls the spacing of marked values around the axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_IsInversed" aria-label="View IsInversed property in API reference">IsInversed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the axis direction is reversed and changes the logical flow of values around the circular path.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelFormat" aria-label="View LabelFormat property in API reference">LabelFormat</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Defines the format string used for axis labels and controls how numeric values are presented around the scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelOffset" aria-label="View LabelOffset property in API reference">LabelOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the distance between labels and the axis and controls how far text is placed from the circular line.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_LabelPosition" aria-label="View LabelPosition property in API reference">LabelPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeLabelsPosition.html" aria-label="View GaugeLabelsPosition enum in API reference">GaugeLabelsPosition</a></td>
    <td>Defines the position of labels relative to the axis line by using the <code>GaugeLabelsPosition</code> enum and controls whether labels appear inside, outside, or near the axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MajorTickStyle" aria-label="View MajorTickStyle property in API reference">MajorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialTickStyle.html" aria-label="View RadialTickStyle type in API reference">RadialTickStyle</a></td>
    <td>Defines the appearance of major tick marks and controls the visual style used to highlight primary scale divisions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the maximum value of the axis and sets the upper bound used by the radial scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MaximumLabelsCount" aria-label="View MaximumLabelsCount property in API reference">MaximumLabelsCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Defines the maximum number of labels displayed on the axis and helps control label density in compact layouts.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the minimum value of the axis and establishes the lower bound used by the radial scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MinorTicksPerInterval" aria-label="View MinorTicksPerInterval property in API reference">MinorTicksPerInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Defines the number of minor ticks displayed between major ticks and controls the granularity of the axis scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_MinorTickStyle" aria-label="View MinorTickStyle property in API reference">MinorTickStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialTickStyle.html" aria-label="View RadialTickStyle type in API reference">RadialTickStyle</a></td>
    <td>Defines the appearance of minor tick marks and controls the styling of the smaller scale divisions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_OffsetUnit" aria-label="View OffsetUnit property in API reference">OffsetUnit</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SizeUnit.html" aria-label="View SizeUnit enum in API reference">SizeUnit</a></td>
    <td>Defines the unit used for offsets and positioning by using the <code>SizeUnit</code> enum and controls whether values are interpreted as absolute or relative measurements.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Pointers" aria-label="View Pointers property in API reference">Pointers</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialPointer.html?tabs=tabid-1" aria-label="View RadialPointer type in API reference">ObservableCollection&lt;RadialPointer&gt;</a></td>
    <td>Defines the collection of pointers displayed on the axis and serves as the container for all radial indicator elements.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_RadiusFactor" aria-label="View RadiusFactor property in API reference">RadiusFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the radius factor of the radial axis and controls how much of the available circular space the axis occupies.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_Ranges" aria-label="View Ranges property in API reference">Ranges</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialRange.html" aria-label="View RadialRange type in API reference">ObservableCollection&lt;RadialRange&gt;</a></td>
    <td>Defines the collection of ranges displayed on the axis and provides a way to highlight value bands across the scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowAxisLine" aria-label="View ShowAxisLine property in API reference">ShowAxisLine</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the axis line is displayed and controls the visibility of the circular base line.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowFirstLabel" aria-label="View ShowFirstLabel property in API reference">ShowFirstLabel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the first axis label is displayed and helps manage label visibility near the starting edge of the scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether axis labels are displayed and controls the visibility of the textual value markers around the scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowLastLabel" aria-label="View ShowLastLabel property in API reference">ShowLastLabel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the last axis label is displayed and helps keep the final value visible at the end of the scale.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_ShowTicks" aria-label="View ShowTicks property in API reference">ShowTicks</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether tick marks are displayed and controls the visibility of major and minor scale markers.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the start angle of the radial axis and sets the initial placement of the circular scale around the center point.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_TickOffset" aria-label="View TickOffset property in API reference">TickOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the distance between tick marks and the axis line and controls how far the ticks are positioned from the base circle.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_TickPosition" aria-label="View TickPosition property in API reference">TickPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.GaugeElementPosition.html" aria-label="View GaugeElementPosition enum in API reference">GaugeElementPosition</a></td>
    <td>Defines the position of tick marks relative to the axis line by using the <code>GaugeElementPosition</code> enum and controls whether ticks render inside, outside, or centered on the axis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.RadialAxis.html#Syncfusion_Maui_Gauges_RadialAxis_UseRangeColorForAxis" aria-label="View UseRangeColorForAxis property in API reference">UseRangeColorForAxis</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether range colors are applied to axis elements and enables range-based visual styling across the scale.</td>
</tr>
</table>
