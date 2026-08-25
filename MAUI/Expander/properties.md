---
layout: post
title: Properties of .NET MAUI Expander control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Expander (SfExpander) control.
platform: maui
control: SfExpander
documentation: ug
---

# API Reference for .NET MAUI Expander

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Duration</code> of the <code>expand and collapse animation</code>, in <code>milliseconds</code>. Larger values produce <code>slower transitions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
    <td><code>Motion curve</code> applied to the <code>expand and collapse animation</code>. Use any supported <code>Easing</code> value such as <code>Linear</code>, <code>SinInOut</code>, or <code>CubicInOut</code> to shape the <code>transition feel</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content" aria-label="View Content property in API reference">Content</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>View</code> displayed inside the <code>expander body</code>. Becomes <code>visible</code> when the <code>expander is expanded</code> and <code>hidden</code> when <code>collapsed</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Applies the <code>Liquid Glass effect</code> to the <code>expander</code> when placed inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 13.0</code> or later and <code>macOS 10.15</code> or later with <code>.NET 8</code> or later.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header" aria-label="View Header property in API reference">Header</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>View</code> shown at the top of the <code>expander</code>. Acts as the <code>touch target</code> that triggers <code>expand</code> and <code>collapse behavior</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderBackground" aria-label="View HeaderBackground property in API reference">HeaderBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Background brush</code> of the <code>expander header</code>. Use it to customize the <code>header surface color</code> or <code>gradient</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconColor" aria-label="View HeaderIconColor property in API reference">HeaderIconColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> of the <code>expand and collapse indicator</code> shown on the <code>header</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition enum in API reference">ExpanderIconPosition</a></td>
    <td>Position of the <code>header icon</code>. Choose a supported <code>ExpanderIconPosition</code> value such as <code>Start</code> or <code>End</code> to place the <code>indicator</code> at the <code>start</code> or <code>end</code> of the <code>header</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded" aria-label="View IsExpanded property in API reference">IsExpanded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>expander body</code> is currently <code>expanded</code>. Setting this value animates to the <code>new state</code> when the <code>control is visible</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed" aria-label="View Collapsed event in API reference">Collapsed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>expander</code> finishes <code>collapsing</code>, signaling that the <code>body content</code> is no longer <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>expander</code> collapses. Set the <code>Cancel</code> property in the <code>event args</code> to prevent the <code>collapse</code> from happening.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>expander</code> finishes <code>expanding</code>, signaling that the <code>body content</code> is fully <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>expander</code> expands. Set the <code>Cancel</code> property in the <code>event args</code> to prevent the <code>expansion</code> from happening.</td>
</tr>
</table>
