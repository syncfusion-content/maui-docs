---
layout: post
title: Properties of .NET MAUI Popup control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Popup (SfPopup) control.
platform: maui
control: SfPopup
documentation: ug
---

# API Reference for .NET MAUI Popup

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AbsoluteX" aria-label="View AbsoluteX property in API reference">AbsoluteX</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Horizontal <code>screen coordinate</code> used to position the <code>popup</code> when an <code>absolute placement</code> is required. Larger values move the <code>popup</code> toward the <code>right edge</code> of the <code>screen</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AbsoluteY" aria-label="View AbsoluteY property in API reference">AbsoluteY</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Vertical <code>screen coordinate</code> used to position the <code>popup</code> when an <code>absolute placement</code> is required. Larger values move the <code>popup</code> toward the <code>bottom edge</code> of the <code>screen</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AcceptButtonText" aria-label="View AcceptButtonText property in API reference">AcceptButtonText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Label</code> shown on the <code>accept button</code> in the <code>popup footer</code>. Visible only when both <code>ShowFooter</code> and the <code>accept button</code> configuration are <code>enabled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AcceptCommand" aria-label="View AcceptCommand property in API reference">AcceptCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when the <code>accept button</code> is <code>tapped</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>open</code> and <code>close animations</code>, in <code>milliseconds</code>. Larger values produce <code>slower transitions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
    <td><code>Motion curve</code> applied to the <code>open</code> and <code>close animations</code>. Use any supported <code>Easing</code> value such as <code>Linear</code>, <code>SinInOut</code>, or <code>CubicInOut</code> to shape the <code>transition feel</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AnimationMode" aria-label="View AnimationMode property in API reference">AnimationMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAnimationMode.html" aria-label="View PopupAnimationMode enum in API reference">PopupAnimationMode</a></td>
    <td><code>Animation style</code> applied when the <code>popup</code> opens or <code>closes</code>. Choose a supported <code>PopupAnimationMode</code> value such as <code>Fade</code>, <code>Zoom</code>, <code>Slide</code>, or <code>None</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AppearanceMode" aria-label="View AppearanceMode property in API reference">AppearanceMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupButtonAppearanceMode.html" aria-label="View PopupButtonAppearanceMode enum in API reference">PopupButtonAppearanceMode</a></td>
    <td>Visual <code>appearance mode</code> applied to the <code>popup content</code>. Choose a supported <code>PopupButtonAppearanceMode</code> value to switch between <code>OneButton</code>, <code>TwoButton</code>, or related <code>layouts</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AutoCloseDuration" aria-label="View AutoCloseDuration property in API reference">AutoCloseDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.timespan" aria-label="View TimeSpan type in API reference">TimeSpan</a></td>
    <td><code>Time interval</code> after which the <code>popup</code> closes <code>automatically</code>. Set to a positive <code>TimeSpan</code> to enable <code>timed dismissal</code>; ignored when <code>StaysOpen</code> is <code>true</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AutoSizeMode" aria-label="View AutoSizeMode property in API reference">AutoSizeMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAutoSizeMode.html" aria-label="View PopupAutoSizeMode enum in API reference">PopupAutoSizeMode</a></td>
    <td>How the <code>popup</code> computes its <code>size</code> <code>automatically</code>. Choose a supported <code>PopupAutoSizeMode</code> value such as <code>None</code>, <code>Width</code>, <code>Height</code>, or <code>Both</code> to control which <code>dimension</code> adapts to its <code>target</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_AutoSizeTarget" aria-label="View AutoSizeTarget property in API reference">AutoSizeTarget</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupAutoSizeTarget.html" aria-label="View PopupAutoSizeTarget enum in API reference">PopupAutoSizeTarget</a></td>
    <td><code>Element</code> that the <code>popup</code> measures against when <code>AutoSizeMode</code> is <code>active</code>. Choose a supported <code>PopupAutoSizeTarget</code> value such as <code>Content</code>, <code>Container</code>, or <code>RelativeView</code> to control which <code>area</code> is <code>measured</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ContentTemplate" aria-label="View ContentTemplate property in API reference">ContentTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render the <code>popup body</code>. Use it to fully customize the <code>main content area</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_DeclineButtonText" aria-label="View DeclineButtonText property in API reference">DeclineButtonText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Label</code> shown on the <code>decline button</code> in the <code>popup footer</code>. Visible only when both <code>ShowFooter</code> and the <code>decline button</code> configuration are <code>enabled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_DeclineCommand" aria-label="View DeclineCommand property in API reference">DeclineCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when the <code>decline button</code> is <code>tapped</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Applies the <code>Liquid Glass effect</code> to the <code>popup</code> when placed inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 13.0</code> or later and <code>macOS 10.15</code> or later with <code>.NET 8</code> or later.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_FooterHeight" aria-label="View FooterHeight property in API reference">FooterHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>footer area</code>. Larger values reserve more <code>vertical space</code> for <code>action content</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render the <code>footer area</code>. Use it to fully customize <code>buttons</code> and <code>summary content</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_HeaderHeight" aria-label="View HeaderHeight property in API reference">HeaderHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>header area</code>. Larger values reserve more <code>vertical space</code> for the <code>title region</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render the <code>header area</code>. Use it to customize the <code>title</code> and any <code>header branding</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_HeaderTitle" aria-label="View HeaderTitle property in API reference">HeaderTitle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Title text</code> shown in the <code>popup header</code>. Used in conjunction with <code>ShowHeader</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IgnoreActionBar" aria-label="View IgnoreActionBar property in API reference">IgnoreActionBar</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>popup</code> layout ignores the <code>platform action bar</code> when <code>measuring</code>. Set to <code>true</code> to exclude the <code>action bar area</code> from <code>positioning</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsFullScreen" aria-label="View IsFullScreen property in API reference">IsFullScreen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>popup</code> covers the <code>full screen</code>. When <code>true</code>, the <code>popup</code> surface <code>expands</code> to fill the available <code>display area</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Reflects the <code>current visible state</code> of the <code>popup</code>. Set to <code>true</code> to <code>open</code> the <code>popup</code> <code>programmatically</code>; set to <code>false</code> to <code>close it</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Message" aria-label="View Message property in API reference">Message</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Body text</code> displayed in the <code>popup</code>. Provides the <code>primary message</code> shown alongside or instead of custom <code>ContentTemplate</code> content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_OverlayMode" aria-label="View OverlayMode property in API reference">OverlayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupOverlayMode.html" aria-label="View PopupOverlayMode enum in API reference">PopupOverlayMode</a></td>
    <td>Visual <code>treatment</code> of the <code>area behind</code> the <code>popup</code>. Choose a supported <code>PopupOverlayMode</code> value such as <code>None</code>, <code>Transparent</code>, or <code>Blur</code> to control how the <code>background</code> is <code>dimmed or blocked</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Padding" aria-label="View Padding property in API reference">Padding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Inner <code>padding</code> applied to the <code>popup content</code>, controlling <code>spacing</code> around the <code>displayed elements</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_PopupStyle" aria-label="View PopupStyle property in API reference">PopupStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupStyle.html" aria-label="View PopupStyle type in API reference">PopupStyle</a></td>
    <td><code>Style object</code> used to tune the <code>popup appearance</code>, including <code>background</code>, <code>border</code>, and <code>corner radius</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_RelativePosition" aria-label="View RelativePosition property in API reference">RelativePosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupRelativePosition.html" aria-label="View PopupRelativePosition enum in API reference">PopupRelativePosition</a></td>
    <td>Position of the <code>popup</code> relative to its <code>anchor view</code>. Choose a supported <code>PopupRelativePosition</code> value such as <code>AlignTop</code>, <code>AlignBottom</code>, <code>AlignLeft</code>, <code>AlignRight</code>, <code>Center</code>, or <code>TopLeft</code> to control <code>anchor alignment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_RelativeView" aria-label="View RelativeView property in API reference">RelativeView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>Anchor view</code> used for <code>relative placement</code>. Required for <code>ShowRelativeToView</code> and for <code>relative-positioning scenarios</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowCloseButton" aria-label="View ShowCloseButton property in API reference">ShowCloseButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>close button</code> is displayed in the <code>popup header</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowFooter" aria-label="View ShowFooter property in API reference">ShowFooter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>popup footer</code> is displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowHeader" aria-label="View ShowHeader property in API reference">ShowHeader</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>popup header</code> is displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowOverlayAlways" aria-label="View ShowOverlayAlways property in API reference">ShowOverlayAlways</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>overlay</code> remains <code>visible</code> while the <code>popup</code> is <code>open</code>. Set to <code>true</code> to keep the <code>overlay mask</code> <code>active</code> even when the <code>popup</code> does not have <code>focus</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_StartX" aria-label="View StartX property in API reference">StartX</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Horizontal <code>coordinate</code> from which the <code>popup animation</code> starts. Larger values move the <code>animation origin</code> toward the <code>right edge</code> of the <code>screen</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_StartY" aria-label="View StartY property in API reference">StartY</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Vertical <code>coordinate</code> from which the <code>popup animation</code> starts. Larger values move the <code>animation origin</code> toward the <code>bottom edge</code> of the <code>screen</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_StaysOpen" aria-label="View StaysOpen property in API reference">StaysOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>popup</code> remains <code>open</code> until <code>explicitly dismissed</code>. Set to <code>true</code> to prevent the <code>popup</code> from <code>closing</code> on <code>overlay</code> or <code>back-button interactions</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Dismiss" aria-label="View Dismiss method in API reference">Dismiss()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Closes the <code>popup</code> and ends the <code>current presentation</code>. Use it to <code>programmatically dismiss</code> an <code>open popup</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Refresh" aria-label="View Refresh method in API reference">Refresh()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Refreshes the <code>popup layout</code> and reapplies the <code>current visual state</code>. Use it after <code>programmatic property changes</code> that need an <code>immediate update</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Boolean_" aria-label="View Show(Boolean) method in API reference">Show(Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens the <code>popup</code>. The optional <code>Boolean</code> controls whether the <code>configured open animation</code> is applied; pass <code>false</code> to show the <code>popup</code> without <code>animation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_Double_System_Double_" aria-label="View Show(Double, Double) method in API reference">Show(Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens the <code>popup</code> at the specified <code>X</code> and <code>Y coordinates</code> on the <code>screen</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_System_Int32_" aria-label="View Show(String, String, Int32) method in API reference">Show(String, String, Int32)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens a <code>popup</code> with the given <code>title</code>, <code>message</code>, and <code>auto-close duration</code>, in <code>milliseconds</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_System_String_System_Int32_" aria-label="View Show(String, String, String, Int32) method in API reference">Show(String, String, String, Int32)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens a <code>popup</code> with the given <code>title</code>, <code>message</code>, <code>accept button text</code>, and <code>auto-close duration</code>, in <code>milliseconds</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Show_System_String_System_String_System_String_System_String_System_Int32_" aria-label="View Show(String, String, String, String, Int32) method in API reference">Show(String, String, String, String, Int32)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens a <code>popup</code> with the given <code>title</code>, <code>message</code>, <code>accept button text</code>, <code>decline button text</code>, and <code>auto-close duration</code>, in <code>milliseconds</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowAsync" aria-label="View ShowAsync method in API reference">ShowAsync()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Opens the <code>popup</code> and returns a <code>Task</code> that completes when the <code>popup</code> is <code>dismissed</code>. Use it with <code>await</code> to wait for <code>user interaction</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_ShowRelativeToView_Syncfusion_Maui_Popup_PopupRelativePosition_Microsoft_Maui_Controls_View_System_Double_System_Double_" aria-label="View ShowRelativeToView(PopupRelativePosition, View, Double, Double) method in API reference">ShowRelativeToView(PopupRelativePosition, View, Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Opens the <code>popup</code> <code>anchored</code> to the specified <code>view</code> using the chosen <code>PopupRelativePosition</code>, with optional <code>X</code> and <code>Y offsets</code> applied relative to the <code>anchor</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closed" aria-label="View Closed event in API reference">Closed</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupClosedEventArgs.html" aria-label="View PopupClosedEventArgs type in API reference">PopupClosedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>popup</code> has <code>closed</code>, providing the final <code>close state</code> for <code>post-close handling</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Closing" aria-label="View Closing event in API reference">Closing</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupClosingEventArgs.html" aria-label="View PopupClosingEventArgs type in API reference">PopupClosingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>popup</code> closes. Set the <code>Cancel</code> property in the <code>event args</code> to prevent the <code>popup</code> from <code>closing</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opened" aria-label="View Opened event in API reference">Opened</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupOpenedEventArgs.html" aria-label="View PopupOpenedEventArgs type in API reference">PopupOpenedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>popup</code> finishes <code>opening</code>, signaling that the <code>content</code> is fully <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_Opening" aria-label="View Opening event in API reference">Opening</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupOpeningEventArgs.html" aria-label="View PopupOpeningEventArgs type in API reference">PopupOpeningEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>popup</code> opens. Set the <code>Cancel</code> property in the <code>event args</code> to prevent the <code>popup</code> from <code>opening</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.SfPopup.html#Syncfusion_Maui_Popup_SfPopup_PositionChanging" aria-label="View PositionChanging event in API reference">PositionChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Popup.PopupPositionChangingEventArgs.html" aria-label="View PopupPositionChangingEventArgs type in API reference">PopupPositionChangingEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>popup position</code> is <code>recalculated</code>. Inspect or modify the <code>position</code> through the <code>event args</code> to control the final <code>placement</code>.</td>
</tr>
</table>
