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
<td>Defines the time, in milliseconds, taken by the progress animation and controls how quickly the filled segment changes between values.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
<td>Defines the easing curve used for the progress animation and shapes the motion feel during value updates.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops" aria-label="View GradientStops property in API reference">GradientStops</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html?tabs=tabid-1" aria-label="View ProgressGradientStopCollection type in API reference">ProgressGradientStopCollection</a></td>
<td>Defines the collection of gradient stops applied to the progress segment and provides the color transitions used to render multi-stop fill effects.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration" aria-label="View IndeterminateAnimationDuration property in API reference">IndeterminateAnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the time, in milliseconds, taken by the `indeterminate` animation and controls the movement speed of the animated indicator.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationEasing" aria-label="View IndeterminateAnimationEasing property in API reference">IndeterminateAnimationEasing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
<td>Defines the easing curve used for the `indeterminate` animation and controls how the moving indicator accelerates and decelerates.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidthFactor" aria-label="View IndeterminateIndicatorWidthFactor property in API reference">IndeterminateIndicatorWidthFactor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width factor of the `indeterminate` indicator and controls how much horizontal space the moving segment occupies.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate" aria-label="View IsIndeterminate property in API reference">IsIndeterminate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the progress bar operates in `indeterminate` mode and switches the control from value-based progress to animated feedback.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the maximum progress value and establishes the upper limit used to measure completion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the minimum progress value and establishes the lower limit used to measure completion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress" aria-label="View Progress property in API reference">Progress</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the current progress value and represents the live completion state rendered by the control.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressCornerRadius" aria-label="View ProgressCornerRadius property in API reference">ProgressCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the corner radius of the progress segment and controls how rounded the filled portion appears.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill" aria-label="View ProgressFill property in API reference">ProgressFill</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the fill applied to the progress segment and controls the visual styling of the completed portion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressHeight" aria-label="View ProgressHeight property in API reference">ProgressHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height of the progress segment and controls the thickness of the filled bar.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_ProgressPadding" aria-label="View ProgressPadding property in API reference">ProgressPadding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
<td>Defines the padding applied to the progress segment and controls spacing around the filled area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryAnimationDuration" aria-label="View SecondaryAnimationDuration property in API reference">SecondaryAnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the time, in milliseconds, taken by the secondary progress animation and controls how quickly the secondary value updates.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgress" aria-label="View SecondaryProgress property in API reference">SecondaryProgress</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the secondary progress value and represents an additional progress level rendered alongside the primary bar.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressCornerRadius" aria-label="View SecondaryProgressCornerRadius property in API reference">SecondaryProgressCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the corner radius of the secondary progress segment and controls how rounded the secondary fill appears.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressFill" aria-label="View SecondaryProgressFill property in API reference">SecondaryProgressFill</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the fill applied to the secondary progress segment and controls the visual styling of the secondary completion layer.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_SecondaryProgressHeight" aria-label="View SecondaryProgressHeight property in API reference">SecondaryProgressHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height of the secondary progress segment and controls the thickness of the secondary bar.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount" aria-label="View SegmentCount property in API reference">SegmentCount</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the number of segments in the progress bar and controls how many visible divisions are used to represent progress.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth" aria-label="View SegmentGapWidth property in API reference">SegmentGapWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width of the gaps between segments and controls the separation visible between each segment block.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackCornerRadius" aria-label="View TrackCornerRadius property in API reference">TrackCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the corner radius of the track segment and controls how rounded the background track appears.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the fill applied to the track segment and controls the visual appearance of the unfilled background portion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html#Syncfusion_Maui_ProgressBar_SfLinearProgressBar_TrackHeight" aria-label="View TrackHeight property in API reference">TrackHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height of the track segment and controls the thickness of the background bar.</td>
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
<td>Updates the progress value with animation and supports optional target value and easing-based transition behavior.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html?tabs=tabid-1" aria-label="View ProgressValueEventArgs type in API reference">ProgressValueEventArgs</a></td>
<td>Raised when the progress value changes and provides event data describing the updated progress state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted" aria-label="View ProgressCompleted event in API reference">ProgressCompleted</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html?tabs=tabid-1" aria-label="View EventArgs type in API reference">ProgressValueEventArgs</a></td>
<td>Raised when the progress reaches its maximum value and signals that completion has been achieved.</td>
</tr>
</table>
