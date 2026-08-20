---
layout: post
title: Properties of .NET MAUI Switch control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Switch (SfSwitch) control.
platform: maui
control: SfSwitch
documentation: ug
---

# API Reference for .NET MAUI Switch

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
    <td>Enables a third state in addition to <code>On</code> and <code>Off</code>, allowing the switch to cycle through <code>On</code>, <code>Off</code>, and <code>indeterminate</code> states.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the <code>liquid glass</code> visual treatment is applied to the switch surface for a more polished and modern appearance.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled" aria-label="View IsEnabled property in API reference">IsEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Enables or disables user interaction with the switch. When disabled, the switch does not respond to user input.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn" aria-label="View IsOn property in API reference">IsOn</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls the current switch state. When indeterminate state support is enabled, the switch can also display the Indeterminate state.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_SwitchSettings" aria-label="View SwitchSettings property in API reference">SwitchSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html" aria-label="View SwitchSettings type in API reference">SwitchSettings</a></td>
    <td>Customizes the appearance of the switch, including the track, thumb, icon, border, corner radius, and sizing options.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangedEventArgs.html" aria-label="View SwitchStateChangedEventArgs type in API reference">SwitchStateChangedEventArgs&gt;</a></a></td>
    <td>Triggered after the switch state changes and the new state has been applied.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging" aria-label="View StateChanging event in API reference">StateChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchStateChangingEventArgs.html" aria-label="View SwitchStateChangingEventArgs type in API reference">SwitchStateChangingEventArgs&gt;</a></a></td>
    <td>Triggered before the switch state changes, allowing the pending state change to be canceled.</td>
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
<td>Displays a custom icon inside the switch thumb using the specified path geometry.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_IconColor" aria-label="View IconColor property in API reference">IconColor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
<td>Customizes the color of the icon displayed inside the switch thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbBackground" aria-label="View ThumbBackground property in API reference">ThumbBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Customizes the background of the switch thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbCornerRadius" aria-label="View ThumbCornerRadius property in API reference">ThumbCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Controls how rounded the switch thumb appears.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbHeightRequest" aria-label="View ThumbHeightRequest property in API reference">ThumbHeightRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the height of the switch thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStroke" aria-label="View ThumbStroke property in API reference">ThumbStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Customizes the border of the switch thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStrokeThickness" aria-label="View ThumbStrokeThickness property in API reference">ThumbStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the thickness of the switch thumb border.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbWidthRequest" aria-label="View ThumbWidthRequest property in API reference">ThumbWidthRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the width of the switch thumb.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackBackground" aria-label="View TrackBackground property in API reference">TrackBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Customizes the background of the switch track.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackCornerRadius" aria-label="View TrackCornerRadius property in API reference">TrackCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Controls how rounded the switch track appears.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackHeightRequest" aria-label="View TrackHeightRequest property in API reference">TrackHeightRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the height of the switch track.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStroke" aria-label="View TrackStroke property in API reference">TrackStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Customizes the border of the switch track.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStrokeThickness" aria-label="View TrackStrokeThickness property in API reference">TrackStrokeThickness</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the thickness of the switch track border.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackWidthRequest" aria-label="View TrackWidthRequest property in API reference">TrackWidthRequest</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the width of the switch track.</td>
</tr>

</table>
