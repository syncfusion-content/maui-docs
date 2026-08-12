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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_AllowIndeterminateState">AllowIndeterminateState</a></td>
    <td>bool</td>
    <td>Defines whether the switch supports an indeterminate state in addition to On and Off.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
    <td>bool</td>
    <td>Defines whether the liquid glass visual effect is enabled.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsEnabled">IsEnabled</a></td>
    <td>bool</td>
    <td>Defines whether the switch is enabled for user interaction.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_IsOn">IsOn</a></td>
    <td>bool</td>
    <td>Defines the current on, off, or indeterminate state of the switch.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_SwitchSettings">SwitchSettings</a></td>
    <td>SwitchSettings</td>
    <td>Defines the appearance settings applied to the switch.</td>
</tr>
</table>

## Methods

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_ChangeVisualState">ChangeVisualState()</a></td>
    <td>void</td>
    <td>Updates the visual state of the switch based on its current value.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_Finalize">Finalize()</a></td>
    <td>void</td>
    <td>Releases resources before the switch is removed by garbage collection.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanged">StateChanged</a></td>
    <td>EventHandler&lt;SwitchStateChangedEventArgs&gt;</td>
    <td>Raised when the switch state changes.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfSwitch.html#Syncfusion_Maui_Buttons_SfSwitch_StateChanging">StateChanging</a></td>
    <td>EventHandler&lt;SwitchStateChangingEventArgs&gt;</td>
    <td>Raised before the switch state changes and can be canceled.</td>
</tr>
</table>