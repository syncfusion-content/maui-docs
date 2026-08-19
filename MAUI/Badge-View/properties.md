---
layout: post
title: Properties of .NET MAUI Badge View control | Syncfusion®
description: This section explains the properties with Syncfusion<sup>&reg;</sup> MAUI Badge View (SfBadgeView) control.
platform: MAUI
control: SfBadgeView
documentation: ug
---

# API Reference for .NET MAUI Badge View

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeSettings" aria-label="View BadgeSettings property in API reference">BadgeSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html" aria-label="View BadgeSettings type in API reference">BadgeSettings</a></td>
    <td>Group of settings that define the <code>badge's appearance</code>, <code>position</code>, and <code>animation behavior</code>. Configure this to customize how the badge is displayed on the <code>target view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeText" aria-label="View BadgeText property in API reference">BadgeText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Text shown inside the <code>badge</code>. The value appears as the <code>badge label</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_ScreenReaderText" aria-label="View ScreenReaderText property in API reference">ScreenReaderText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Accessibility</code> text announced by <code>screen readers</code> to describe the badge for <code>assistive technologies</code>.</td>
</tr>
</table>

## BadgeSettings Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Animation" aria-label="View Animation property in API reference">Animation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeAnimation.html" aria-label="View BadgeAnimation type in API reference">BadgeAnimation</a></td>
    <td>Animation used when the badge appears, changes, or hides. Choose a supported <code>BadgeAnimation</code> value such as <code>None</code>, <code>Scale</code>, or <code>Fade</code> to control the <code>motion effect</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls how long the <code>badge animation</code> runs, in <code>milliseconds</code>. Higher values produce slower transitions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_AutoHide" aria-label="View AutoHide property in API reference">AutoHide</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the badge hides automatically when the <code>target value</code>, such as a <code>notification count</code>, reaches zero or no longer needs to be displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Background" aria-label="View Background property in API reference">Background</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Brush used to fill the <code>badge background</code>. Supports <code>solid</code> or <code>gradient fills</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_BadgeAlignment" aria-label="View BadgeAlignment property in API reference">BadgeAlignment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeAlignment.html" aria-label="View BadgeAlignment type in API reference">BadgeAlignment</a></td>
    <td>Alignment of the badge relative to the <code>target view</code>. Choose a supported <code>BadgeAlignment</code> value such as <code>Start</code>, <code>Center</code>, or <code>End</code> to control placement inside the bounds.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_CornerRadius" aria-label="View CornerRadius property in API reference">CornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerRadius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Corner radius applied to the <code>badge shape</code>. Higher values make the badge more rounded.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
    <td>Font styling applied to the <code>badge text</code>, such as <code>Bold</code> or <code>Italic</code>, to adjust the <code>visual emphasis</code> of the label.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>badge text</code> respects the device's <code>font scaling settings</code> for accessibility.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Font family</code> used for the <code>badge text</code>. The selected font is applied to the <code>badge label</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Font size of the <code>badge text</code>. Larger values make the label more prominent.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Icon" aria-label="View Icon property in API reference">Icon</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeIcon.html" aria-label="View BadgeIcon type in API reference">BadgeIcon</a></td>
    <td>Icon displayed inside the badge. Choose a supported <code>BadgeIcon</code> value such as <code>Add</code>, <code>Delete</code>, or <code>Dismiss</code> to replace or supplement the text.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.bindableproperty" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the badge is shown on screen. Set this to <code>false</code> to hide the badge.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Offset" aria-label="View Offset property in API reference">Offset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.point" aria-label="View Point type in API reference">Point</a></td>
    <td>Offset applied from the default <code>badge position</code>. Positive values shift the badge <code>horizontally</code> or <code>vertically</code> relative to the target.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Position" aria-label="View Position property in API reference">Position</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html" aria-label="View BadgePosition type in API reference">BadgePosition</a></td>
    <td>Position of the badge relative to the <code>target view</code>. Choose a supported <code>BadgePosition</code> value such as <code>TopLeft</code>, <code>TopRight</code>, <code>BottomLeft</code>, <code>BottomRight</code>, or <code>Center</code> to place the badge correctly.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Stroke color drawn around the badge. Adds a visible <code>outline</code> around the <code>badge shape</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_StrokeThickness" aria-label="View StrokeThickness property in API reference">StrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Thickness of the <code>badge stroke</code>. Larger values create a stronger outline.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Color applied to the <code>badge text</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextPadding" aria-label="View TextPadding property in API reference">TextPadding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Padding around the <code>badge text</code>. Larger values give the label more internal space.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Type" aria-label="View Type property in API reference">Type</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html" aria-label="View BadgeType type in API reference">BadgeType</a></td>
    <td><code>Badge type</code> that controls how the badge is rendered. Choose a supported <code>BadgeType</code> value such as <code>Primary</code>, <code>Secondary</code>, <code>Light</code>, <code>Outline</code>, or <code>Success</code> to determine its <code>visual style</code>.</td>
</tr>
</table>