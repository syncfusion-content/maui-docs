---
layout: post
title: Properties of .NET MAUI Switch control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Switch (SfSwitch) control.
platform: maui
control: SfSwitch
documentation: ug
---

# .NET MAUI Switch API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState" aria-label="View AllowIndeterminateState property in API reference">AllowIndeterminateState</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the switch can move beyond the standard <code>On</code> and <code>Off</code> states and also support an <code>indeterminate</code> state for tri-state workflows.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the <code>liquid glass</code> visual treatment is applied to the switch surface for a more polished and modern appearance.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled" aria-label="View IsEnabled property in API reference">IsEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the switch is enabled for interaction and can respond to pointer, touch, or keyboard input.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn" aria-label="View IsOn property in API reference">IsOn</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Defines the current state of the switch and represents whether the control is in the <code>On</code> or <code>Off</code> position, or in <code>indeterminate</code> mode when tri-state behavior is enabled.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_SwitchSettings" aria-label="View SwitchSettings property in API reference">SwitchSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html" aria-label="View SwitchSettings type in API reference">SwitchSettings</a></td>
    <td>Defines the appearance and layout settings applied to the switch, including the thumb, track, sizing, and related visual customization options.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanged" aria-label="View StateChanged event in API reference">StateChanged</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html" aria-label="View SwitchStateChangedEventArgs type in API reference">SwitchStateChangedEventArgs</a></td>
    <td>Raised after the switch state changes and the final <code>On</code>, <code>Off</code>, or <code>indeterminate</code> value is available.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging" aria-label="View StateChanging event in API reference">StateChanging</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html" aria-label="View SwitchStateChangingEventArgs type in API reference">SwitchStateChangingEventArgs</a></td>
    <td>Raised before the switch state changes and exposes the pending transition so it can be reviewed or canceled.</td>
</tr>
</table>

## SwitchSettings Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_CustomPath" aria-label="View CustomPath property in API reference">CustomPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the custom path used to draw the icon inside the switch thumb and enables a fully customized glyph or symbol shape.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_IconColor" aria-label="View IconColor property in API reference">IconColor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
<td>Defines the color applied to the icon displayed within the switch thumb and helps ensure clear contrast across different visual themes.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbBackground" aria-label="View ThumbBackground property in API reference">ThumbBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush of the switch thumb and supports solid, gradient, or image-based styling.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbCornerRadius" aria-label="View ThumbCornerRadius property in API reference">ThumbCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Defines the corner radius of the switch thumb and controls how rounded the thumb appears in the control layout.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbHeightRequest" aria-label="View ThumbHeightRequest property in API reference">ThumbHeightRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height requested for the switch thumb and allows the thumb size to be tuned for compact or spacious layouts.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStroke" aria-label="View ThumbStroke property in API reference">ThumbStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the border brush of the switch thumb and provides visual separation from the track background.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStrokeThickness" aria-label="View ThumbStrokeThickness property in API reference">ThumbStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the thickness of the thumb border and controls how prominent the thumb outline appears.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbWidthRequest" aria-label="View ThumbWidthRequest property in API reference">ThumbWidthRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width requested for the switch thumb and helps match the thumb size to the intended design.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackBackground" aria-label="View TrackBackground property in API reference">TrackBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background brush of the switch track and determines the visual surface behind the thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackCornerRadius" aria-label="View TrackCornerRadius property in API reference">TrackCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Defines the corner radius of the switch track and controls how rounded the track container appears.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackHeightRequest" aria-label="View TrackHeightRequest property in API reference">TrackHeightRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height requested for the switch track and helps adjust the overall proportions of the control.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStroke" aria-label="View TrackStroke property in API reference">TrackStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the border brush of the switch track and can be used to emphasize or soften the outer track edge.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStrokeThickness" aria-label="View TrackStrokeThickness property in API reference">TrackStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the thickness of the track border and controls how strongly the track outline is rendered.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackWidthRequest" aria-label="View TrackWidthRequest property in API reference">TrackWidthRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width requested for the switch track and allows the control to be sized for different layouts and densities.</td>
</tr>

</table>
