---
layout: post
title: Properties of .NET MAUI Diagram control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Diagram(SfDiagram) control.
platform: maui
control: SfDiagram
documentation: ug
---

# API Reference for .NET MAUI Diagram

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Connectors" aria-label="View Connectors property in API reference">Connectors</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Connector.html" aria-label="View Connector type in API reference">Connector</a>&gt;</td>
    <td>Holds the connector list used to represent links between diagram nodes, and keeps the canvas aligned with that list.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Height" aria-label="View Height property in API reference">Height</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the requested diagram height in device-independent units; the layout system uses its own sizing when this value is left at -1.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Id" aria-label="View Id property in API reference">Id</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Provides the unique identifier for the diagram, and one is assigned automatically when no value is supplied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Nodes" aria-label="View Nodes property in API reference">Nodes</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Node.html" aria-label="View Node type in API reference">Node</a>&gt;</td>
    <td>Holds the node list used in the diagram, and keeps the canvas aligned with that list.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Width" aria-label="View Width property in API reference">Width</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the requested diagram width in device-independent units; the layout system uses its own sizing when this value is left at -1.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Add_Syncfusion_Maui_Diagram_Connector_" aria-label="View Add(Connector) method in API reference">Add(Connector)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Places a connector on the diagram canvas without adding it to the connector collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Add_Syncfusion_Maui_Diagram_Node_" aria-label="View Add(Node) method in API reference">Add(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Places a node on the diagram canvas without adding it to the node collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_CanRedoAsync" aria-label="View CanRedoAsync method in API reference">CanRedoAsync()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a>&gt;</td>
    <td>Checks whether redo is available at the current moment.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_CanUndoAsync" aria-label="View CanUndoAsync method in API reference">CanUndoAsync()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a>&gt;</td>
    <td>Checks whether undo is available at the current moment.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Copy" aria-label="View Copy method in API reference">Copy()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a>&gt;</td>
    <td>Copies the current selection to the clipboard and returns it as a JSON string, or nothing when no selection is available.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Cut" aria-label="View Cut method in API reference">Cut()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Moves the current selection to the clipboard and removes it from the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ExportDiagram_Syncfusion_Maui_Diagram_DiagramExportOptions_" aria-label="View ExportDiagram method in API reference">ExportDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a>&gt;</td>
    <td>Exports the diagram as a data URI for image formats or as SVG markup, without saving anything to disk.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_FitToPage" aria-label="View FitToPage method in API reference">FitToPage()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Zooms and pans the diagram so every visible element fits inside the viewport.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_LoadDiagram_System_String_" aria-label="View LoadDiagram method in API reference">LoadDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Replaces the current diagram content with state loaded from a JSON string.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Pan_System_Double_System_Double_System_Nullable_Microsoft_Maui_Graphics_Point__" aria-label="View Pan method in API reference">Pan()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Shifts the viewport by the specified horizontal and vertical offsets, with an optional focus point for centering.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Paste_System_Collections_Generic_IEnumerable_Syncfusion_Maui_Diagram_DiagramElement__" aria-label="View Paste method in API reference">Paste()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Restores items from the clipboard or pastes a provided set of diagram elements into the canvas.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Print_Syncfusion_Maui_Diagram_DiagramExportOptions_" aria-label="View Print method in API reference">Print()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Opens the diagram print flow using the browser-based print pipeline.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Redo" aria-label="View Redo method in API reference">Redo()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Reapplies the last action that was undone.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Remove_Syncfusion_Maui_Diagram_Connector_" aria-label="View Remove(Connector) method in API reference">Remove(Connector)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Removes a connector from the diagram canvas without removing it from the connector collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Remove_Syncfusion_Maui_Diagram_Node_" aria-label="View Remove(Node) method in API reference">Remove(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Removes a node from the diagram canvas without removing it from the node collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SaveDiagram" aria-label="View SaveDiagram method in API reference">SaveDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Serializes the current diagram state into JSON for later restoration.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ScaleAsync_Syncfusion_Maui_Diagram_Connector_System_Double_System_Double_Microsoft_Maui_Graphics_Point_" aria-label="View ScaleAsync(Connector) method in API reference">ScaleAsync(Connector)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Resizes a connector around the specified pivot point by the given scale factors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ScaleAsync_Syncfusion_Maui_Diagram_Node_System_Double_System_Double_Microsoft_Maui_Graphics_Point_" aria-label="View ScaleAsync(Node) method in API reference">ScaleAsync(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Resizes a node around the specified pivot point by the given scale factors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Undo" aria-label="View Undo method in API reference">Undo()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Reverses the most recent diagram action.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Zoom_System_Double_System_Nullable_Microsoft_Maui_Graphics_Point__" aria-label="View Zoom method in API reference">Zoom()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Multiplies the current zoom level by the given factor, with an optional focus point for centering.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_CollectionChanged" aria-label="View CollectionChanged event in API reference">CollectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramCollectionChangedEventArgs.html" aria-label="View DiagramCollectionChangedEventArgs type in API reference">DiagramCollectionChangedEventArgs</a>&gt;</td>
    <td>Reports node or connector additions and removals from the diagram, including changes made through the UI or through code.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ConnectionChanged" aria-label="View ConnectionChanged event in API reference">ConnectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorConnectionChangedEventArgs.html" aria-label="View DiagramConnectorConnectionChangedEventArgs type in API reference">DiagramConnectorConnectionChangedEventArgs</a>&gt;</td>
    <td>Reports connector endpoint attachment, detachment, or rerouting between nodes or ports.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Created" aria-label="View Created event in API reference">Created</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Fires after the JavaScript diagram instance is ready for interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_JavaScriptError" aria-label="View JavaScriptError event in API reference">JavaScriptError</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramJavaScriptErrorEventArgs.html" aria-label="View DiagramJavaScriptErrorEventArgs type in API reference">DiagramJavaScriptErrorEventArgs</a>&gt;</td>
    <td>Reports JavaScript failures from the hosted diagram page, such as load or payload errors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_PositionChanged" aria-label="View PositionChanged event in API reference">PositionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodePositionChangedEventArgs.html" aria-label="View DiagramNodePositionChangedEventArgs type in API reference">DiagramNodePositionChangedEventArgs</a>&gt;</td>
    <td>Reports that a node has finished moving to a new position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_RotationChanged" aria-label="View RotationChanged event in API reference">RotationChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodeRotationChangedEventArgs.html" aria-label="View DiagramNodeRotationChangedEventArgs type in API reference">DiagramNodeRotationChangedEventArgs</a>&gt;</td>
    <td>Reports that a node has finished rotating.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramSelectionChangedEventArgs.html" aria-label="View DiagramSelectionChangedEventArgs type in API reference">DiagramSelectionChangedEventArgs</a>&gt;</td>
    <td>Reports selection changes for nodes or connectors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SizeChanged" aria-label="View SizeChanged event in API reference">SizeChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodeSizeChangedEventArgs.html" aria-label="View DiagramNodeSizeChangedEventArgs type in API reference">DiagramNodeSizeChangedEventArgs</a>&gt;</td>
    <td>Reports selection changes for nodes or connectors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SourcePointChanged" aria-label="View SourcePointChanged event in API reference">SourcePointChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorSourcePointChangedEventArgs.html" aria-label="View DiagramConnectorSourcePointChangedEventArgs type in API reference">DiagramConnectorSourcePointChangedEventArgs</a>&gt;</td>
    <td>Reports that a connector’s source endpoint has finished moving.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_TargetPointChanged" aria-label="View TargetPointChanged event in API reference">TargetPointChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorTargetPointChangedEventArgs.html" aria-label="View DiagramConnectorTargetPointChangedEventArgs type in API reference">DiagramConnectorTargetPointChangedEventArgs</a>&gt;</td>
    <td>Reports that a connector’s target endpoint has finished moving.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_TextEdited" aria-label="View TextEdited event in API reference">TextEdited</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramTextEditedEventArgs.html" aria-label="View DiagramTextEditedEventArgs type in API reference">DiagramTextEditedEventArgs</a>&gt;</td>
    <td>Reports that a node or connector label edit has been committed.</td>
</tr>
</table>