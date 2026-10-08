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
    <td>Controls the color of the floating expand and collapse buttons and the separator accent line in the hovered state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterOrientation.html" aria-label="View GridSplitterOrientation type in API reference">GridSplitterOrientation</a></td>
    <td>Arranges panes side by side in horizontal mode or stacked top to bottom in vertical mode; changing this rebuilds the layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeIconColor" aria-label="View ResizeIconColor property in API reference">ResizeIconColor</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Controls the color of the resize handle and the separator accent line in the default state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeIconTemplate" aria-label="View ResizeIconTemplate property in API reference">ResizeIconTemplate</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default resize icon with a custom template on each separator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SeparatorBackground" aria-label="View SeparatorBackground property in API reference">SeparatorBackground</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Controls the separator’s background brush in the default, non-interactive state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SeparatorSize" aria-label="View SeparatorSize property in API reference">SeparatorSize</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the thickness of each separator strip, using width in vertical layouts and height in horizontal layouts.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_SplitterPanes" aria-label="View SplitterPanes property in API reference">SplitterPanes</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SplitterPane.html" aria-label="View SplitterPane type in API reference">SplitterPane</a>&gt;</a></td>
    <td>Holds the panes displayed by the splitter and defines the layout structure.</td>
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
    <td>Collapses the pane at the specified zero-based index and starts the collapse flow.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ExpandPane_System_Int32_" aria-label="View ExpandPane method in API reference">ExpandPane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Expands the pane at the specified zero-based index and starts the expand flow.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_RemovePane_System_Int32_" aria-label="View RemovePane method in API reference">RemovePane</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Removes the pane at the specified zero-based index and rebuilds the layout.</td>
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
    <td>Triggered after a pane finishes collapsing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneCollapsingEventArgs.html" aria-label="View GridSplitterPaneCollapsingEventArgs type in API reference">GridSplitterPaneCollapsingEventArgs</a>&gt;</a></td>
    <td>Triggered before a pane begins collapsing; use it to stop the collapse if needed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneExpandedEventArgs.html" aria-label="View GridSplitterPaneExpandedEventArgs type in API reference">GridSplitterPaneExpandedEventArgs</a>&gt;</a></td>
    <td>Triggered after a pane finishes expanding.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterPaneExpandingEventArgs.html" aria-label="View GridSplitterPaneExpandingEventArgs type in API reference">GridSplitterPaneExpandingEventArgs</a>&gt;</a></td>
    <td>Triggered before a pane begins expanding; use it to stop the expansion if needed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeEnded" aria-label="View ResizeEnded event in API reference">ResizeEnded</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizeEndedEventArgs.html" aria-label="View GridSplitterResizeEndedEventArgs type in API reference">GridSplitterResizeEndedEventArgs</a>&gt;</a></td>
    <td>Triggered when the user releases the separator after resizing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_ResizeStarted" aria-label="View ResizeStarted event in API reference">ResizeStarted</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizeStartedEventArgs.html" aria-label="View GridSplitterResizeStartedEventArgs type in API reference">GridSplitterResizeStartedEventArgs</a>&gt;</a></td>
    <td>Triggered when the user presses on a separator to start resizing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.SfGridSplitter.html#Syncfusion_Maui_GridSplitter_SfGridSplitter_Resizing" aria-label="View Resizing event in API reference">Resizing</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1?view=net-10.0" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridSplitter.GridSplitterResizingEventArgs.html" aria-label="View GridSplitterResizingEventArgs type in API reference">GridSplitterResizingEventArgs</a>&gt;</a></td>
    <td>Triggered continuously while the separator is being dragged and pane sizes are changing.</td>
</tr>
</table>
