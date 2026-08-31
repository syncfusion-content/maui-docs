---
layout: post
title: Properties of .NET MAUI Circular Progress Bar control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Circular Progress Bar (SfCircularProgressBar) control.
platform: maui
control: SfCircularProgressBar
documentation: ug
---

# API Reference for .NET MAUI Circular Progress Bar

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls how long the <code>progress</code> transition animation runs, in <code>milliseconds</code>. Larger values produce slower, smoother transitions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
        <td>Motion curve used for the <code>progress</code> animation. Apply an <code>Easing</code> value such as <code>Linear</code>, <code>SinInOut</code>, or <code>CubicInOut</code> to shape the transition feel.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_Content" aria-label="View Content property in API reference">Content</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>View displayed at the <code>center</code> of the circular progress bar. Use it to show a <code>label</code>, <code>icon</code>, <code>percentage text</code>, or any custom layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Angle, in <code>degrees</code>, where the <code>circular arc</code> ends. Use it together with <code>StartAngle</code> to create <code>partial arcs</code> or <code>gauge-style ranges</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops" aria-label="View GradientStops property in API reference">GradientStops</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html" aria-label="View ProgressGradientStop type in API reference">ProgressGradientStop</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
        <td>Collection of <code>ProgressGradientStop</code> entries that define the <code>gradient brush</code> for the <code>progress arc</code>. Each stop specifies a <code>color</code> and an <code>offset</code> along the arc.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration" aria-label="View IndeterminateAnimationDuration property in API reference">IndeterminateAnimationDuration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Duration of one <code>indeterminate</code> animation cycle, in <code>milliseconds</code>, shown when the <code>progress</code> value is unknown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationEasing" aria-label="View IndeterminateAnimationEasing property in API reference">IndeterminateAnimationEasing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
        <td>Motion curve used for the <code>indeterminate</code> animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidthFactor" aria-label="View IndeterminateIndicatorWidthFactor property in API reference">IndeterminateIndicatorWidthFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Width factor of the moving <code>indicator</code> drawn during <code>indeterminate</code> animation. Larger values make the indicator wider relative to the <code>track</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate" aria-label="View IsIndeterminate property in API reference">IsIndeterminate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Controls whether the progress bar shows an <code>indeterminate</code> loading animation instead of a measurable <code>progress</code> value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Upper bound of the <code>progress</code> range. The <code>arc</code> fills fully when <code>Progress</code> reaches this value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Lower bound of the <code>progress</code> range. The <code>arc</code> is empty at this value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress" aria-label="View Progress property in API reference">Progress</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Current <code>progress</code> value, relative to <code>Minimum</code> and <code>Maximum</code>. Changing this value animates the <code>arc</code> to the new position using the configured <code>duration</code> and <code>easing</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressCornerStyle" aria-label="View ProgressCornerStyle property in API reference">ProgressCornerStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.CornerStyle.html" aria-label="View CornerStyle enum in API reference">CornerStyle</a></td>
        <td>Shape of the <code>progress arc</code> ends. Choose a supported <code>CornerStyle</code> value such as <code>Square</code>, <code>Round</code>, or <code>Flat</code> to style the cap.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill" aria-label="View ProgressFill property in API reference">ProgressFill</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Brush used to paint the <code>progress</code> portion of the <code>arc</code>. Supports <code>solid colors</code> and <code>gradients</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressRadiusFactor" aria-label="View ProgressRadiusFactor property in API reference">ProgressRadiusFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Distance of the <code>progress arc</code> from the <code>center</code> of the control. Values between <code>0</code> and <code>1</code> place the arc inside the available bounds.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness" aria-label="View ProgressThickness property in API reference">ProgressThickness</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Thickness of the <code>progress arc</code>. Larger values create a wider <code>ring</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount" aria-label="View SegmentCount property in API reference">SegmentCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Number of <code>segments</code> rendered when the progress bar uses a <code>segmented</code> appearance.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth" aria-label="View SegmentGapWidth property in API reference">SegmentGapWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Gap between adjacent <code>segments</code> in <code>segmented mode</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Angle, in <code>degrees</code>, where the <code>circular arc</code> begins. Adjust it to rotate the start point of the <code>progress arc</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit" aria-label="View ThicknessUnit property in API reference">ThicknessUnit</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SizeUnit.html" aria-label="View SizeUnit enum in API reference">SizeUnit</a></td>
        <td>Unit used to interpret <code>ProgressThickness</code> and <code>TrackThickness</code>. Choose a supported <code>SizeUnit</code> value such as <code>Pixel</code> or <code>Factor</code> to control how <code>thickness</code> values are measured.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackCornerStyle" aria-label="View TrackCornerStyle property in API reference">TrackCornerStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.CornerStyle.html" aria-label="View CornerStyle enum in API reference">CornerStyle</a></td>
        <td>Shape of the <code>track arc</code> ends. Choose a supported <code>CornerStyle</code> value to style the cap of the background arc.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Brush used to paint the background <code>track</code> of the <code>arc</code>. Supports <code>solid colors</code> and <code>gradients</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackRadiusFactor" aria-label="View TrackRadiusFactor property in API reference">TrackRadiusFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Distance of the <code>track arc</code> from the <code>center</code> of the control. Values between <code>0</code> and <code>1</code> place the track inside the available bounds.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness" aria-label="View TrackThickness property in API reference">TrackThickness</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Thickness of the background <code>track arc</code>.</td>
    </tr>
</table>

## Methods

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SetProgress_System_Double_System_Nullable_System_Double__Microsoft_Maui_Easing_" aria-label="View SetProgress method in API reference">SetProgress</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Updates the current <code>Progress</code> value and optionally animates the transition to the new value using the provided <code>duration</code> and <code>easing</code>.</td>
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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressValueEventArgs.html" aria-label="View ProgressValueEventArgs type in API reference">ProgressValueEventArgs</a>&gt;</a></td>
        <td>Triggered when the <code>Progress</code> value changes, providing the new progress value in the event arguments.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted" aria-label="View ProgressCompleted event in API reference">ProgressCompleted</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Triggered when the <code>Progress</code> value reaches <code>Maximum</code>.</td>
    </tr>
</table>
