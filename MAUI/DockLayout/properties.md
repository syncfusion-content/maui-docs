---
layout: post
title: Properties of .NET MAUI DockLayout control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI DockLayout (SfDockLayout) control.
platform: maui
control: SfDockLayout
documentation: ug
---

# API Reference for .NET MAUI DockLayout

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_HorizontalSpacing" aria-label="View HorizontalSpacing property in API reference">HorizontalSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Horizontal spacing</code> between <code>docked children</code>. Applies to <code>children</code> arranged side by side along the <code>horizontal axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_ShouldExpandLastChild" aria-label="View ShouldExpandLastChild property in API reference">ShouldExpandLastChild</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>final child</code> in the <code>collection</code> expands to fill the <code>remaining space</code> after <code>docked children</code> are placed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_VerticalSpacing" aria-label="View VerticalSpacing property in API reference">VerticalSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Vertical spacing</code> between <code>docked children</code>. Applies to <code>children</code> arranged one above the other along the <code>vertical axis</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_CreateLayoutManager" aria-label="View CreateLayoutManager method in API reference">CreateLayoutManager()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.layouts.ilayoutmanager" aria-label="View ILayoutManager type in API reference">ILayoutManager</a></td>
    <td>Creates and returns the <code>layout manager</code> that measures and arranges <code>docked children</code> inside the <code>layout container</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_GetDock_Microsoft_Maui_Controls_BindableObject_" aria-label="View GetDock(BindableObject) method in API reference">GetDock(BindableObject)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Dock.html" aria-label="View Dock enum in API reference">Dock</a></td>
    <td>Returns the <code>Dock position</code> attached to the specified <code>child element</code>. Use it to identify whether the <code>element</code> is <code>docked</code> to the <code>Left</code>, <code>Top</code>, <code>Right</code>, or <code>Bottom</code> of the <code>layout</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_SetDock_Microsoft_Maui_Controls_BindableObject_Syncfusion_Maui_Core_Dock_" aria-label="View SetDock(BindableObject, Dock) method in API reference">SetDock(BindableObject, Dock)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Assigns a <code>Dock position</code> to the specified <code>child element</code>. Use it to control whether the <code>element</code> is arranged at the <code>Left</code>, <code>Top</code>, <code>Right</code>, or <code>Bottom</code> of the <code>layout</code>.</td>
</tr>
</table>