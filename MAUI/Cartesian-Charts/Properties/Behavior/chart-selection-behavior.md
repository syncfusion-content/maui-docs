---
layout: post
title: Behaviors in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members of tooltip, trackball, crosshair, zoom and pan, and selection behaviors available in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart) API.
platform: maui
control: SfCartesianChart
documentation: ug
---

# ChartSelectionBehavior API in .NET MAUI Cartesian Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Selects a specific data point or series segment based on its <code>index</code> in the underlying data source.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectedIndexes" aria-label="View SelectedIndexes property in API reference">SelectedIndexes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1" aria-label="View List type in API reference">List&lt;</a><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1" aria-label="View List type in API reference">&gt;</a></td>
    <td>Selects multiple data points or series segments simultaneously by specifying a <code>list of their indices</code> in the data source.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionBrush" aria-label="View SelectionBrush property in API reference">SelectionBrush</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the <code>color</code> or <code>brush</code> applied to a data point or series segment when it is <code>selected</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_Type" aria-label="View Type property in API reference">Type</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionType.html" aria-label="View ChartSelectionType type in API reference">ChartSelectionType</a></td>
    <td>Determines whether a <code>single item</code> or <code>multiple items</code> can be selected at the same time within the chart.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_ClearSelection" aria-label="View ClearSelection method in API reference">ClearSelection()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Removes the current selection, deselecting all currently selected series segments and resetting the selected <code>indices</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangedEventArgs.html" aria-label="View ChartSelectionChangedEventArgs type in API reference">ChartSelectionChangedEventArgs</a><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">&gt;</a></td>
    <td>Triggered after a chart segment is selected or deselected, providing the affected series along with the current and previous selected <code>indices</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;</a><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionChangingEventArgs.html" aria-label="View ChartSelectionChangingEventArgs type in API reference">ChartSelectionChangingEventArgs</a><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">&gt;</a></td>
    <td>Triggered before a chart segment is selected, allowing the selection action to be <code>canceled</code> based on application logic.</td>
</tr>
</table>
