---
layout: post
title: Properties of .NET MAUI Linear ProgressBar control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Linear ProgressBar (SfLinearProgressBar) control.
platform: maui
control: SfLinearProgressBar
documentation: ug
---

# API Reference for .NET MAUI Linear ProgressBar

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>value update animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower transitions</code> between <code>Progress values</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
    <td><code>Motion curve</code> applied to the <code>value update animation</code>. Use any supported <code>Easing</code> value such as <code>Linear</code>, <code>SinInOut</code>, or <code>CubicInOut</code> to shape the <code>transition feel</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops" aria-label="View GradientStops property in API reference">GradientStops</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html?tabs=tabid-1" aria-label="View ProgressGradientStopCollection type in API reference">ProgressGradientStopCollection</a></td>
    <td><code>Collection</code> of <code>ProgressGradientStop</code> entries that define <code>multi-stop color transitions</code> on the <code>filled progress segment</code>. Takes <code>precedence</code> over a single <code>ProgressFill</code> when <code>gradient stops</code> are provided.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration" aria-label="View IndeterminateAnimationDuration property in API reference">IndeterminateAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of one <code>cycle</code> of the <code>indeterminate animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower indicator movement</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationEasing" aria-label="View IndeterminateAnimationEasing property in API reference">IndeterminateAnimationEasing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
    <td><code>Motion curve</code> applied to the <code>indeterminate indicator</code> as it moves across the <code>track</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidthFactor" aria-label="View IndeterminateIndicatorWidthFactor property in API reference">IndeterminateIndicatorWidthFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Width</code> of the moving <code>indeterminate indicator</code> expressed as a <code>fraction</code> of the <code>track width</code>. Values are <code>clamped</code> between <code>0</code> and <code>1</code>, where <code>1</code> fills the entire <code>track</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate" aria-label="View IsIndeterminate property in API reference">IsIndeterminate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>progress bar</code> runs in <code>indeterminate mode</code>. Set to <code>true</code> to display a continuously <code>moving indicator</code> instead of a <code>value-based fill</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Upper bound</code> of the <code>Progress range</code>. <code>Progress values</code> are <code>clamped</code> to this <code>maximum</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Lower bound</code> of the <code>Progress range</code>. <code>Progress values</code> are <code>clamped</code> to this <code>minimum</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress" aria-label="View Progress property in API reference">Progress</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Current <code>progress value</code> rendered by the <code>bar</code>. Updates <code>animate</code> when <code>AnimationDuration</code> is greater than <code>zero</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressCornerRadius" aria-label="View ProgressCornerRadius property in API reference">ProgressCornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Corner radius</code> applied to the <code>filled progress segment</code>. Larger values produce more <code>rounded ends</code> on the <code>filled portion</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill" aria-label="View ProgressFill property in API reference">ProgressFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the <code>filled progress segment</code>. Use it to set the <code>color</code> or <code>gradient</code> of the <code>completed portion</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressHeight" aria-label="View ProgressHeight property in API reference">ProgressHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>filled progress segment</code>. Larger values produce a <code>thicker filled bar</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressPadding" aria-label="View ProgressPadding property in API reference">ProgressPadding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Inner <code>padding</code> applied to the <code>progress segment</code>, controlling <code>spacing</code> between the <code>track</code> and the <code>filled bar</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryAnimationDuration" aria-label="View SecondaryAnimationDuration property in API reference">SecondaryAnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>secondary progress update animation</code>, in <code>milliseconds</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgress" aria-label="View SecondaryProgress property in API reference">SecondaryProgress</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Secondary progress value</code> rendered as a <code>layered fill</code> on top of the <code>track</code>. Used to show an <code>additional progress indicator</code> such as <code>buffered state</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressCornerRadius" aria-label="View SecondaryProgressCornerRadius property in API reference">SecondaryProgressCornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Corner radius</code> applied to the <code>secondary progress segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressFill" aria-label="View SecondaryProgressFill property in API reference">SecondaryProgressFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the <code>secondary progress segment</code>. Use it to distinguish the <code>secondary fill</code> from the <code>primary fill</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressHeight" aria-label="View SecondaryProgressHeight property in API reference">SecondaryProgressHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>secondary progress segment</code>. Larger values produce a <code>thicker secondary bar</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount" aria-label="View SegmentCount property in API reference">SegmentCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Number</code> of <code>equal segments</code> used to render the <code>progress</code>. Set to a value greater than <code>1</code> to display a <code>segmented bar</code> with <code>gaps</code> between each <code>segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth" aria-label="View SegmentGapWidth property in API reference">SegmentGapWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Width</code> of the <code>gaps</code> between <code>segments</code> when <code>SegmentCount</code> is greater than <code>1</code>. Larger values produce more <code>visible separation</code> between <code>segments</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackCornerRadius" aria-label="View TrackCornerRadius property in API reference">TrackCornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Corner radius</code> applied to the <code>background track</code>. Larger values produce more <code>rounded ends</code> on the <code>unfilled portion</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the <code>unfilled track background</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackHeight" aria-label="View TrackHeight property in API reference">TrackHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>background track</code>. Larger values produce a <code>thicker overall bar</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SetProgress_System_Double_System_Nullable_System_Double__Microsoft_Maui_Easing_" aria-label="View SetProgress(Double, Nullable&lt;Double&gt;, Easing) method in API reference">SetProgress(Double, Nullable&lt;Double&gt;, Easing)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Updates the <code>Progress value</code> with an <code>animated transition</code>. The optional <code>duration</code> overrides <code>AnimationDuration</code> for this update, and the optional <code>easing curve</code> overrides <code>AnimationEasing</code>. If no <code>duration</code> is provided, the configured <code>AnimationDuration</code> is used.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressChanged" aria-label="View ProgressChanged event in API reference">ProgressChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html?tabs=tabid-1" aria-label="View ProgressValueEventArgs type in API reference">ProgressValueEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>Progress value</code> changes, providing the <code>previous</code> and <code>new progress values</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted" aria-label="View ProgressCompleted event in API reference">ProgressCompleted</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html?tabs=tabid-1" aria-label="View EventArgs type in API reference">ProgressValueEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>Progress value</code> reaches the configured <code>Maximum</code>, signaling that the <code>progress operation</code> has <code>finished</code>.</td>
</tr>
</table>
