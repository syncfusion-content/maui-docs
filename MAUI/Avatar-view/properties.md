---
layout: post
title: Properties in .NET MAUI Avatar View | Syncfusion®
description: Learn about properties, events, and methods available in Syncfusion® .NET MAUI Avatar View (SfAvatarView) API reference documentation.
platform: maui
control: SfAvatarView
documentation: ug
---

# API Reference for .NET MAUI Avatar View

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_Aspect" aria-label="View Aspect property in API reference">Aspect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.aspect" aria-label="View Aspect type in API reference">Aspect</a></td>
    <td>Controls how an avatar image fits within the view. <code>AspectFit</code> preserves the entire image and may leave empty space, <code>AspectFill</code> fills the view and may crop the image, <code>Fill</code> stretches the image, and <code>Center</code> displays it at its original scale in the center.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarCharacter" aria-label="View AvatarCharacter property in API reference">AvatarCharacter</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AvatarCharacter.html" aria-label="View AvatarCharacter type in API reference">AvatarCharacter</a></td>
    <td>Selects one of the built-in avatar images, from <code>Avatar1</code> through <code>Avatar30</code>, when <code>ContentType</code> is <code>AvatarCharacter</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarColorMode" aria-label="View AvatarColorMode property in API reference">AvatarColorMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AvatarColorMode.html" aria-label="View AvatarColorMode type in API reference">AvatarColorMode</a></td>
    <td>Controls the color treatment applied to the avatar's background and initials. <code>Default</code> uses the configured colors, while <code>DarkBackground</code> and <code>LightBackground</code> apply predefined dark or light tones.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarName" aria-label="View AvatarName property in API reference">AvatarName</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Supplies the name from which the avatar's <code>initials</code> are generated. The displayed characters depend on <code>InitialsType</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarShape" aria-label="View AvatarShape property in API reference">AvatarShape</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AvatarShape.html" aria-label="View AvatarShape type in API reference">AvatarShape</a></td>
    <td>Controls the avatar outline. <code>Circle</code> creates a circular avatar, <code>Square</code> creates a square avatar, and <code>Custom</code> allows the corners to be shaped with <code>CornerRadius</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_AvatarSize" aria-label="View AvatarSize property in API reference">AvatarSize</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AvatarSize.html" aria-label="View AvatarSize type in API reference">AvatarSize</a></td>
    <td>Applies a preset width and height to the avatar: <code>ExtraSmall (24)</code>, <code>Small (32)</code>, <code>Medium (40)</code>, <code>Large (48)</code>, or <code>ExtraLarge (64)</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_Background" aria-label="View Background property in API reference">Background</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Fills the avatar background with a <code>solid-color</code> or <code>gradient</code> brush.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_BackgroundColor" aria-label="View BackgroundColor property in API reference">BackgroundColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Fills the avatar background with a <code>solid color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_BackgroundColorMemberPath" aria-label="View BackgroundColorMemberPath property in API reference">BackgroundColorMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the color value to use for each member's background when <code>ContentType</code> is <code>Group</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentPadding" aria-label="View ContentPadding property in API reference">ContentPadding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the spacing between the avatar's <code>stroke</code> and its <code>image</code>, <code>initials</code>, or <code>built-in character</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ContentType" aria-label="View ContentType property in API reference">ContentType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.AvatarContentType.html" aria-label="View ContentType type in API reference">ContentType</a></td>
    <td>Selects the content displayed by the avatar: <code>Default</code> shows the default avatar image, <code>Initials</code> derives text from <code>AvatarName</code>, <code>AvatarCharacter</code> shows a built-in avatar, <code>Custom</code> shows <code>ImageSource</code>, and <code>Group</code> combines up to three members.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_CornerRadius" aria-label="View CornerRadius property in API reference">CornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerRadius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Rounds the avatar's corners when a <code>custom outline</code> is used; larger values produce more rounded corners.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_FontAttributes" aria-label="View FontAttributes property in API reference">FontAttributes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
    <td>Applies <code>None</code>, <code>Bold</code>, or <code>Italic</code> styling to the displayed <code>initials</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_FontAutoScalingEnabled" aria-label="View FontAutoScalingEnabled property in API reference">FontAutoScalingEnabled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Allows the <code>initials</code> to follow the operating system's preferred <code>text-size</code> setting.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_FontFamily" aria-label="View FontFamily property in API reference">FontFamily</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Applies the specified <code>font family</code> to the displayed <code>initials</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_FontSize" aria-label="View FontSize property in API reference">FontSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the <code>size</code> of the displayed <code>initials</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_GroupSource" aria-label="View GroupSource property in API reference">GroupSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td>Provides the members shown when <code>ContentType</code> is <code>Group</code>; the Avatar View displays up to <code>three</code> member images or initials.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_HeightRequest" aria-label="View HeightRequest property in API reference">HeightRequest</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Requests the avatar's <code>vertical size</code> within its parent layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSource" aria-label="View ImageSource property in API reference">ImageSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Provides the <code>image</code> displayed when <code>ContentType</code> is <code>Custom</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_ImageSourceMemberPath" aria-label="View ImageSourceMemberPath property in API reference">ImageSourceMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the image value to display for each member when <code>ContentType</code> is <code>Group</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsColor" aria-label="View InitialsColor property in API reference">InitialsColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Applies the specified <code>color</code> to the displayed <code>initials</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsColorMemberPath" aria-label="View InitialsColorMemberPath property in API reference">InitialsColorMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the initials color to use for each member when <code>ContentType</code> is <code>Group</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsMemberPath" aria-label="View InitialsMemberPath property in API reference">InitialsMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the name or text from which each member's <code>initials</code> are generated when <code>ContentType</code> is <code>Group</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_InitialsType" aria-label="View InitialsType property in API reference">InitialsType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.InitialsType.html" aria-label="View InitialsType type in API reference">InitialsType</a></td>
    <td>Controls how initials are derived from <code>AvatarName</code>. <code>SingleCharacter</code> shows its first character; <code>DoubleCharacter</code> shows the first and last characters of a single word, or the first characters of the first and last words.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Draws the avatar <code>outline</code> with the specified <code>solid-color</code> or <code>gradient</code> brush.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_StrokeThickness" aria-label="View StrokeThickness property in API reference">StrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the <code>thickness</code> of the <code>outline</code> around the avatar.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html#Syncfusion_Maui_Core_SfAvatarView_WidthRequest" aria-label="View WidthRequest property in API reference">WidthRequest</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Requests the avatar's <code>horizontal size</code> within its parent layout.</td>
</tr>

</table>
