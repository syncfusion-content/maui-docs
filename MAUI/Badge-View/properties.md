---
layout: post
title: Properties of .NET MAUI Badge View control | Syncfusion®
description: This section explains the properties with Syncfusion<sup>&reg;</sup> MAUI Badge View (SfBadgeView) control.
platform: MAUI
control: SfBadgeView
documentation: ug
---

# .NET MAUI Badge View API Reference

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
    <td>Badge configuration used to control the badge appearance, position, and behavior.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_BadgeText" aria-label="View BadgeText property in API reference">BadgeText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Text shown inside the badge. The value appears as the badge label.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBadgeView.html#Syncfusion_Maui_Core_SfBadgeView_ScreenReaderText" aria-label="View ScreenReaderText property in API reference">ScreenReaderText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Accessibility text read by screen readers. This helps describe the badge for assistive technologies.</td>
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
    <td>Animation used when the badge appears, changes, or hides. Choose a supported <code>BadgeAnimation</code> value to control the motion effect.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Time taken by the badge animation in milliseconds. Larger values make the animation slower.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_AutoHide" aria-label="View AutoHide property in API reference">AutoHide</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the badge hides automatically when the badge content no longer needs to be shown.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Background" aria-label="View Background property in API reference">Background</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Brush used for the badge background. A solid or gradient fill can be applied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_BadgeAlignment" aria-label="View BadgeAlignment property in API reference">BadgeAlignment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeAlignment.html" aria-label="View BadgeAlignment type in API reference">BadgeAlignment</a></td>
    <td>Alignment of the badge around the target view. Choose a supported <code>BadgeAlignment</code> value to place the badge in the desired location.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_CornerRadius" aria-label="View CornerRadius property in API reference">CornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerRadius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Corner radius of the badge. Higher values make the badge shape more rounded.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
    <td>Font styling applied to the badge text. Use a supported font style to adjust the text emphasis.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the badge text follows the device font scaling settings.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Font family used for the badge text. The selected font is applied to the label.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Font size of the badge text. Larger values make the text more prominent.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Icon" aria-label="View Icon property in API reference">Icon</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeIcon.html" aria-label="View BadgeIcon type in API reference">BadgeIcon</a></td>
    <td>Icon displayed inside the badge. Choose a supported <code>BadgeIcon</code> value to replace or supplement the text.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the badge is shown on screen. Set this to <code>false</code> to hide the badge.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Offset" aria-label="View Offset property in API reference">Offset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.point" aria-label="View Point type in API reference">Point</a></td>
    <td>Offset from the default badge position. This shifts the badge horizontally or vertically.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Position" aria-label="View Position property in API reference">Position</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgePosition.html" aria-label="View BadgePosition type in API reference">BadgePosition</a></td>
    <td>Position of the badge relative to the target. Choose a supported <code>BadgePosition</code> value to place the badge correctly.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Stroke color around the badge. This adds a visible outline around the badge shape.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_StrokeThickness" aria-label="View StrokeThickness property in API reference">StrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Thickness of the badge stroke. Larger values create a stronger outline.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Text color shown inside the badge. The chosen color is applied to the badge label.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_TextPadding" aria-label="View TextPadding property in API reference">TextPadding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Padding around the badge text. More padding gives the badge label extra space.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Type" aria-label="View Type property in API reference">Type</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeType.html" aria-label="View BadgeType type in API reference">BadgeType</a></td>
    <td>Badge type that controls how the badge is rendered. Choose a supported <code>BadgeType</code> value to match the intended display.</td>
</tr>
</table>
