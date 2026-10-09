---
layout: post
title: Properties of .NET MAUI Interactive Viewer control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI InteractiveViewer(SfInteractiveViewer) control.
platform: maui
control: SfInteractiveViewer
documentation: ug
---

# API Reference for .NET MAUI Interactive Viewer

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_Content" aria-label="View Content property in API reference">Content</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Hosts the visual content shown inside the viewer, such as an image, chart, diagram, or custom control.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_IsPanEnabled" aria-label="View IsPanEnabled property in API reference">IsPanEnabled</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-10.0" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Enables or disables panning inside the viewer.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_IsZoomEnabled" aria-label="View IsZoomEnabled property in API reference">IsZoomEnabled</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean?view=net-10.0" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Enables or disables zooming inside the viewer.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_MaximumZoomFactor" aria-label="View MaximumZoomFactor property in API reference">MaximumZoomFactor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Caps the highest zoom level the viewer can reach while zooming is enabled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_MinimumZoomFactor" aria-label="View MinimumZoomFactor property in API reference">MinimumZoomFactor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Caps the lowest zoom level the viewer can reach while zooming is enabled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_PanAxis" aria-label="View PanAxis property in API reference">PanAxis</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.PanAxis.html" aria-label="View PanAxis type in API reference">PanAxis</a></td>
    <td>Limits panning to both directions or to a single axis, depending on the selected mode.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_ZoomFactor" aria-label="View ZoomFactor property in API reference">ZoomFactor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Tracks the current zoom level applied to the viewer content.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_Reset" aria-label="View Reset method in API reference">Reset</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Restores the content to its original zoom, pan, and rotation state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_Rotate" aria-label="View Rotate method in API reference">Rotate</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Rotates the content clockwise by 90 degrees each time it is called.
</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_ScrollChanged" aria-label="View ScrollChanged event in API reference">ScrollChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.InteractiveScrollChangedEventArgs.html" aria-label="View InteractiveScrollChangedEventArgs type in API reference">InteractiveScrollChangedEventArgs</a>&gt;</a></td>
    <td>Triggered after the pan position or zoom level changes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.SfInteractiveViewer.html#Syncfusion_Maui_InteractiveViewer_SfInteractiveViewer_ZoomFactorChanged" aria-label="View ZoomFactorChanged event in API reference">ZoomFactorChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.InteractiveViewer.ZoomFactorChangedEventArgs.html" aria-label="View ZoomFactorChangedEventArgs type in API reference">ZoomFactorChangedEventArgs</a>&gt;</a></td>
    <td>Triggered after the zoom level changes.</td>
</tr>
</table>
