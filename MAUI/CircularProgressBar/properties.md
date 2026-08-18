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
        <td>Controls how long the progress transition takes in milliseconds. Larger values make the animation slower and smoother.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
        <td>Sets the motion curve used for the progress animation. Use an appropriate <code>Easing</code> value to make the movement feel linear, smooth, or more natural.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_Content" aria-label="View Content property in API reference">Content</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
        <td>Displays a custom <code>View</code> at the center of the circular progress bar, such as a label, image, or any other layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the angle where the circular arc ends. Use this to create partial circles or custom gauge ranges.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_GradientStops" aria-label="View GradientStops property in API reference">GradientStops</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressGradientStop.html" aria-label="View ProgressGradientStop type in API reference">ProgressGradientStop</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">&gt;</a></td>
        <td>Defines the collection of <code>ProgressGradientStop</code> objects used to create the gradient brush for the <code>progress</code> arc. Each stop specifies a color and an offset. The default is an empty collection.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationDuration" aria-label="View IndeterminateAnimationDuration property in API reference">IndeterminateAnimationDuration</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls how long one <code>indeterminate</code> animation cycle lasts when the progress value is unknown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateAnimationEasing" aria-label="View IndeterminateAnimationEasing property in API reference">IndeterminateAnimationEasing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
        <td>Defines the motion curve used for the <code>indeterminate</code> animation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IndeterminateIndicatorWidthFactor" aria-label="View IndeterminateIndicatorWidthFactor property in API reference">IndeterminateIndicatorWidthFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Adjusts the width of the moving indicator that appears while the control is in <code>indeterminate</code> mode.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_IsIndeterminate" aria-label="View IsIndeterminate property in API reference">IsIndeterminate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Specifies whether the control shows an animated loading state instead of a measurable progress value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Maximum" aria-label="View Maximum property in API reference">Maximum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Sets the upper bound of the progress range.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Minimum" aria-label="View Minimum property in API reference">Minimum</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Sets the lower bound of the progress range.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_Progress" aria-label="View Progress property in API reference">Progress</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Represents the current progress value displayed by the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressCornerStyle" aria-label="View ProgressCornerStyle property in API reference">ProgressCornerStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.CornerStyle.html" aria-label="View CornerStyle enum in API reference">CornerStyle</a></td>
        <td>Controls how the ends of the <code>progress arc</code> are drawn using the <code>CornerStyle</code> enum.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressFill" aria-label="View ProgressFill property in API reference">ProgressFill</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Defines the brush used to paint the <code>progress</code> portion of the arc.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressRadiusFactor" aria-label="View ProgressRadiusFactor property in API reference">ProgressRadiusFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Adjusts how far the <code>progress arc</code> is positioned from the center of the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ProgressThickness" aria-label="View ProgressThickness property in API reference">ProgressThickness</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Sets the thickness of the <code>progress arc</code>. Larger values create a wider ring.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentCount" aria-label="View SegmentCount property in API reference">SegmentCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Specifies how many segments are shown when the progress bar is rendered in segmented mode.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_SegmentGapWidth" aria-label="View SegmentGapWidth property in API reference">SegmentGapWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Sets the spacing between adjacent <code>segments</code> in segmented mode.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the angle where the circular arc begins.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_ThicknessUnit" aria-label="View ThicknessUnit property in API reference">ThicknessUnit</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SizeUnit.html" aria-label="View SizeUnit enum in API reference">SizeUnit</a></td>
        <td>Defines how thickness values are measured by the control using the <code>SizeUnit</code> enum.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackCornerStyle" aria-label="View TrackCornerStyle property in API reference">TrackCornerStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.CornerStyle.html" aria-label="View CornerStyle enum in API reference">CornerStyle</a></td>
        <td>Controls how the ends of the <code>track arc</code> are drawn using the <code>CornerStyle</code> enum.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
        <td>Defines the brush used to paint the <code>track</code> portion of the arc.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackRadiusFactor" aria-label="View TrackRadiusFactor property in API reference">TrackRadiusFactor</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Adjusts how far the <code>track arc</code> is positioned from the center of the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfCircularProgressBar.html#Syncfusion_Maui_ProgressBar_SfCircularProgressBar_TrackThickness" aria-label="View TrackThickness property in API reference">TrackThickness</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Sets the thickness of the <code>track arc</code>.</td>
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
        <td>Updates the current <code>Progress</code> value and can animate the transition using optional duration and easing settings.</td>
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
        <td>Raised whenever the <code>Progress</code> value changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.ProgressBarBase.html#Syncfusion_Maui_ProgressBar_ProgressBarBase_ProgressCompleted" aria-label="View ProgressCompleted event in API reference">ProgressCompleted</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
        <td>Raised when the <code>Progress</code> value reaches the <code>Maximum</code> value.</td>
    </tr>
</table>
