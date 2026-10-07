---
layout: post
title: Properties of .NET MAUI Grid Splitter control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Grid Splitter(SfGridSplitter) control.
platform: maui
control: SfGridSplitter
documentation: ug
---

# API Reference for .NET MAUI GridSplitter

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ExpandCollapseIconColor" aria-label="View ExpandCollapseIconColor property in API reference">ExpandCollapseIconColor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Gets or sets the color used for the expand and collapse icons and the accent line in the hovered state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterOrientation.html" aria-label="View GridSplitterOrientation type in API reference">GridSplitterOrientation</a></td>
    <td>Gets or sets whether the panes are arranged horizontally or vertically.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeIconColor" aria-label="View ResizeIconColor property in API reference">ResizeIconColor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Gets or sets the color used for the resize handle and separator accent line in the default state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeIconTemplate" aria-label="View ResizeIconTemplate property in API reference">ResizeIconTemplate</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Gets or sets the custom template used to draw the resize icon.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SeparatorBackground" aria-label="View SeparatorBackground property in API reference">SeparatorBackground</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Gets or sets the background brush used for the separator in its default state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SeparatorSize" aria-label="View SeparatorSize property in API reference">SeparatorSize</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Gets or sets the width or height of each separator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SplitterPanes" aria-label="View SplitterPanes property in API reference">SplitterPanes</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SplitterPane.html" aria-label="View SplitterPane type in API reference">SplitterPane</a>&gt;</a></td>
    <td>Gets or sets the collection of panes displayed by the splitter.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_AddPane_Syncfusion_Maui_GridSplitter_SplitterPane_" aria-label="View AddPane method in API reference">AddPane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Adds a pane to the splitter and rebuilds the layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_CollapsePane_System_Int32_" aria-label="View CollapsePane method in API reference">CollapsePane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Collapses the pane at the specified index.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ExpandPane_System_Int32_" aria-label="View ExpandPane method in API reference">ExpandPane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Expands the pane at the specified index.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_RemovePane_System_Int32_" aria-label="View RemovePane method in API reference">RemovePane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Removes the pane at the specified index and refreshes the layout.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Collapsed" aria-label="View Collapsed event in API reference">Collapsed</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneCollapsedEventArgs.html" aria-label="View GridSplitterPaneCollapsedEventArgs type in API reference">GridSplitterPaneCollapsedEventArgs</a>&gt;</a></td>
    <td>Occurs after a pane finishes collapsing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneCollapsingEventArgs.html" aria-label="View GridSplitterPaneCollapsingEventArgs type in API reference">GridSplitterPaneCollapsingEventArgs</a>&gt;</a></td>
    <td>Occurs when a pane collapse operation is about to begin.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneExpandedEventArgs.html" aria-label="View GridSplitterPaneExpandedEventArgs type in API reference">GridSplitterPaneExpandedEventArgs</a>&gt;</a></td>
    <td>Occurs after a pane finishes expanding.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneExpandingEventArgs.html" aria-label="View GridSplitterPaneExpandingEventArgs type in API reference">GridSplitterPaneExpandingEventArgs</a>&gt;</a></td>
    <td>Occurs when a pane expand operation is about to begin.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeEnded" aria-label="View ResizeEnded event in API reference">ResizeEnded</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizeEndedEventArgs.html" aria-label="View GridSplitterResizeEndedEventArgs type in API reference">GridSplitterResizeEndedEventArgs</a>&gt;</a></td>
    <td>Occurs when a resize interaction ends.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeStarted" aria-label="View ResizeStarted event in API reference">ResizeStarted</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizeStartedEventArgs.html" aria-label="View GridSplitterResizeStartedEventArgs type in API reference">GridSplitterResizeStartedEventArgs</a>&gt;</a></td>
    <td>Occurs when a resize interaction begins.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Resizing" aria-label="View Resizing event in API reference">Resizing</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizingEventArgs.html" aria-label="View GridSplitterResizingEventArgs type in API reference">GridSplitterResizingEventArgs</a>&gt;</a></td>
    <td>Occurs repeatedly while a pane is being resized.</td>
</tr>
</table>