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
<td>Defines the horizontal spacing between child elements in the dock layout and controls the gap applied along the left-to-right or right-to-left arrangement axis.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_ShouldExpandLastChild" aria-label="View ShouldExpandLastChild property in API reference">ShouldExpandLastChild</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the final child expands to occupy the remaining available space and helps the docked layout fill the container efficiently.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_VerticalSpacing" aria-label="View VerticalSpacing property in API reference">VerticalSpacing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the vertical spacing between child elements in the dock layout and controls the gap applied along the top-to-bottom arrangement axis.</td>
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
<td>Creates and returns the layout manager used by the dock layout and provides the internal engine responsible for measuring and arranging docked children.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_GetDock_Microsoft_Maui_Controls_BindableObject_" aria-label="View GetDock(BindableObject) method in API reference">GetDock(BindableObject)</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Dock.html" aria-label="View Dock enum in API reference">Dock</a></td>
<td>Returns the dock position assigned to the specified child element by using the <code>Dock</code> enum, which identifies whether the element is placed at <code>Left</code>, <code>Top</code>, <code>Right</code>, or <code>Bottom</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDockLayout.html#Syncfusion_Maui_Core_SfDockLayout_SetDock_Microsoft_Maui_Controls_BindableObject_Syncfusion_Maui_Core_Dock_" aria-label="View SetDock(BindableObject, Dock) method in API reference">SetDock(BindableObject, Dock)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Sets the dock position for the specified child element and applies the selected <code>Dock</code> value to control where the element is arranged inside the layout.</td>
</tr>

</table>