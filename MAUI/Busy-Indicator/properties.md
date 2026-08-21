---
layout: post
title: Properties of .NET MAUI Busy Indicator control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Busy Indicator (SfBusyIndicator) control.
platform: MAUI
control: SfBusyIndicator
documentation: ug
---

# API Reference for .NET MAUI Busy Indicator

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_AnimationType" aria-label="View AnimationType property in API reference">AnimationType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AnimationType.html" aria-label="View AnimationType type in API reference">AnimationType</a></td>
    <td>Animation <code>style</code> used by the busy indicator. Choose a supported <code>AnimationType</code> value such as <code>CircularMaterial</code>, <code>Cupertino</code>, or <code>LinearMaterial</code> to control the <code>loading effect</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_DurationFactor" aria-label="View DurationFactor property in API reference">DurationFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Multiplier applied to the base <code>animation duration</code>. Larger values <code>slow down</code> the loading motion, while smaller values <code>speed it up</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
    <td><code>Font styling</code> applied to the title text. Use it to render the title as <code>Bold</code>, <code>Italic</code>, or <code>plain</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the title text respects the device's <code>font scaling</code> settings for <code>accessibility</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Font family</code> used for the title text. The selected font is applied to the <code>label</code> shown with the indicator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Font size of the title text. Larger values make the title more <code>prominent</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IndicatorColor" aria-label="View IndicatorColor property in API reference">IndicatorColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> used to draw the busy indicator. High <code>contrast</code> helps the loading animation stand out from the <code>overlay</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning" aria-label="View IsRunning property in API reference">IsRunning</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the busy indicator <code>animation</code> is active. Set this to <code>true</code> to show the <code>loading state</code> and <code>false</code> to stop it.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OverlayFill" aria-label="View OverlayFill property in API reference">OverlayFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied to the area behind the indicator. Use a <code>solid</code> or <code>gradient fill</code> to dim the surrounding content during loading.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_SizeFactor" aria-label="View SizeFactor property in API reference">SizeFactor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Scale factor for the size of the indicator. Larger values make the loading animation <code>bigger</code> relative to its <code>container</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TextColor" aria-label="View TextColor property in API reference">TextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> applied to the title text. Use a color that contrasts with the <code>overlay fill</code> for better <code>readability</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_Title" aria-label="View Title property in API reference">Title</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Text shown alongside the busy indicator. Use it to describe the current <code>loading state</code> to the <code>user</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitlePlacement" aria-label="View TitlePlacement property in API reference">TitlePlacement</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BusyIndicatorTitlePlacement.html" aria-label="View BusyIndicatorTitlePlacement type in API reference">BusyIndicatorTitlePlacement</a></td>
    <td>Placement of the title relative to the indicator. Choose a supported <code>BusyIndicatorTitlePlacement</code> value such as <code>Top</code>, <code>Bottom</code>, <code>Left</code>, or <code>Right</code> to position the <code>label</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_TitleSpacing" aria-label="View TitleSpacing property in API reference">TitleSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Spacing between the title and the indicator. Larger values increase the <code>distance</code> between the two <code>elements</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_OnFontChanged_Microsoft_Maui_Font_Microsoft_Maui_Font_" aria-label="View OnFontChanged method in API reference">OnFontChanged(Font, Font)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Internal <code>callback</code> that updates the title text font when the font changes. Used by the control to keep its <code>rendering</code> consistent with the configured font.</td>
</tr>
</table>