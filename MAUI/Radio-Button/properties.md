---
layout: post
title: Properties of .NET MAUI Radio Button control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Radio Button (SfRadioButton) control.
platform: maui
control: SfRadioButton
documentation: ug
---

# API Reference for .NET MAUI Radio Button

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_CheckedColor" aria-label="View CheckedColor property in API reference">CheckedColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> of the <code>radio button indicator</code> in the <code>selected state</code>. Used as the <code>primary accent</code> for the checked <code>radial mark</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_ContentSpacing" aria-label="View ContentSpacing property in API reference">ContentSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Horizontal <code>spacing</code> between the <code>selection indicator</code> and the <code>text label</code>. Larger values push the <code>label</code> <code>farther</code> from the <code>indicator</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_ControlSize" aria-label="View ControlSize property in API reference">ControlSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Size</code> of the <code>circular selection indicator</code>. Larger values produce a more <code>prominent selection mark</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_EnabledAnimation" aria-label="View EnabledAnimation property in API reference">EnabledAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>indicator</code> <code>animates</code> when the <code>checked state</code> <code>changes</code>. Set to <code>false</code> to switch <code>states instantly</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>text label</code> <code>scales automatically</code> with <code>system font size settings</code> for improved <code>readability</code> and <code>accessibility</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_GroupKey" aria-label="View GroupKey property in API reference">GroupKey</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Identifier</code> that <code>groups</code> <code>radio buttons</code> together so that only one <code>button</code> in the <code>group</code> can <code>remain selected</code> at a <code>time</code>. <code>Buttons</code> that share the same <code>GroupKey</code> behave as a <code>mutually exclusive set</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_IsChecked" aria-label="View IsChecked property in API reference">IsChecked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Reflects whether the <code>radio button</code> is currently <code>selected</code>. Setting this to <code>true</code> selects the <code>button</code> and <code>clears</code> any other <code>selected button</code> in the same <code>GroupKey</code> if at least one <code>button</code> in the <code>group</code> must <code>remain selected</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_Text" aria-label="View Text property in API reference">Text</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Label</code> displayed <code>alongside</code> the <code>radio button indicator</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> of the <code>text label</code>. Visual <code>state changes</code> such as <code>checked</code> and <code>disabled</code> can apply different <code>colors</code> <code>automatically</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.ToggleButton.html#Syncfusion_Maui_Buttons_ToggleButton_UncheckedColor" aria-label="View UncheckedColor property in API reference">UncheckedColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> of the <code>radio button indicator</code> in the <code>unselected state</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_Value" aria-label="View Value property in API reference">Value</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Object</code> associated with the <code>selected radio button</code>. Use it to <code>identify</code> which <code>option</code> is <code>chosen</code> <code>within</code> a <code>group</code>, such as when <code>binding</code> the <code>selection</code> to a <code>model property</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_StateChanged" aria-label="View StateChanged event in API reference">StateChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangedEventArgs.html" aria-label="View StateChangedEventArgs type in API reference">StateChangedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>checked state</code> <code>changes</code>, providing the <code>new checked state</code> for <code>post-selection handling</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfRadioButton.html#Syncfusion_Maui_Buttons_SfRadioButton_StateChanging" aria-label="View StateChanging event in API reference">StateChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.StateChangingEventArgs.html" aria-label="View StateChangingEventArgs type in API reference">StateChangingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>checked state</code> <code>changes</code>. Set the <code>Cancel</code> property in the <code>event args</code> to <code>prevent</code> the <code>selection</code> from being <code>applied</code>.</td>
</tr>
</table>
