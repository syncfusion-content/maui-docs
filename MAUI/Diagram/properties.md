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
    <td>Gets or sets the collection of connectors that represent connections between diagram nodes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Height" aria-label="View Height property in API reference">Height</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Gets or sets the requested height of the diagram in device-independent units. Defaults to -1 to let the layout system size the control automatically.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Id" aria-label="View Id property in API reference">Id</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Gets or sets the diagram's unique identifier. Assigned automatically when left null.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Nodes" aria-label="View Nodes property in API reference">Nodes</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.Node.html" aria-label="View Node type in API reference">Node</a>&gt;</td>
    <td>Gets or sets the collection of nodes in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Width" aria-label="View Width property in API reference">Width</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Gets or sets the requested width of the diagram in device-independent units. Defaults to -1 to let the layout system size the control automatically.</td>
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
    <td>Adds a connector to the diagram canvas without modifying the Connectors collection. Use this for rendering connectors not owned by the diagram model.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Add_Syncfusion_Maui_Diagram_Node_" aria-label="View Add(Node) method in API reference">Add(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Adds a node to the diagram canvas without adding it to the Nodes collection. Use this for rendering nodes not part of the authoritative model.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_CanRedoAsync" aria-label="View CanRedoAsync method in API reference">CanRedoAsync()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a>&gt;</td>
    <td>Determines whether a redo operation is currently available. Returns false before the diagram is fully initialized.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_CanUndoAsync" aria-label="View CanUndoAsync method in API reference">CanUndoAsync()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a>&gt;</td>
    <td>Determines whether an undo operation is currently available. Returns false before the diagram is fully initialized.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Copy" aria-label="View Copy method in API reference">Copy()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a>&gt;</td>
    <td>Copies the current diagram selection to the internal clipboard and returns the contents as a JSON string. Returns null if called before initialization or if nothing is selected.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Cut" aria-label="View Cut method in API reference">Cut()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Cuts the currently selected nodes and connectors to the diagram's clipboard. A no-op if called before diagram initialization.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ExportDiagram_Syncfusion_Maui_Diagram_DiagramExportOptions_" aria-label="View ExportDiagram method in API reference">ExportDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" aria-label="View Task type in API reference">Task</a>&lt;<a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a>&gt;</td>
    <td>Exports the diagram to an image or SVG format as a data URI string. Returns null if called before initialization. Does not write to disk.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_FitToPage" aria-label="View FitToPage method in API reference">FitToPage()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Zooms and pans the viewport to fit all nodes and connectors within the visible area. A no-op if called before initialization.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_LoadDiagram_System_String_" aria-label="View LoadDiagram method in API reference">LoadDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Replaces the diagram content by loading from a JSON string previously saved with SaveDiagram(). Clears existing nodes and connectors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Pan_System_Double_System_Double_System_Nullable_Microsoft_Maui_Graphics_Point__" aria-label="View Pan method in API reference">Pan()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Sets the diagram viewport's horizontal and vertical scroll offsets. Optionally centers the viewport on a specific point.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Paste_System_Collections_Generic_IEnumerable_Syncfusion_Maui_Diagram_DiagramElement__" aria-label="View Paste method in API reference">Paste()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Pastes nodes and connectors from the diagram's clipboard. Pass null to paste the most recently copied items, or provide elements to paste a specific set.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Print_Syncfusion_Maui_Diagram_DiagramExportOptions_" aria-label="View Print method in API reference">Print()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Initiates a print dialog for the diagram. A no-op if called before initialization. Uses browser-based printing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Redo" aria-label="View Redo method in API reference">Redo()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Reapplies the last undone action. A no-op if there is nothing to redo or if the diagram is not initialized. Ctrl+Y also triggers this.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Remove_Syncfusion_Maui_Diagram_Connector_" aria-label="View Remove(Connector) method in API reference">Remove(Connector)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Removes a connector from the diagram canvas without modifying the Connectors collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Remove_Syncfusion_Maui_Diagram_Node_" aria-label="View Remove(Node) method in API reference">Remove(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Removes a node from the diagram canvas without modifying the Nodes collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SaveDiagram" aria-label="View SaveDiagram method in API reference">SaveDiagram()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Serializes the diagram to a JSON string that can be saved and later restored with LoadDiagram(). Works whether or not initialization is complete.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ScaleAsync_Syncfusion_Maui_Diagram_Connector_System_Double_System_Double_Microsoft_Maui_Graphics_Point_" aria-label="View ScaleAsync(Connector) method in API reference">ScaleAsync(Connector)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Resizes a connector by multiplying its dimensions by scale factors around a pivot point.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ScaleAsync_Syncfusion_Maui_Diagram_Node_System_Double_System_Double_Microsoft_Maui_Graphics_Point_" aria-label="View ScaleAsync(Node) method in API reference">ScaleAsync(Node)</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Resizes a node by multiplying its width and height by scale factors around a pivot point.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Undo" aria-label="View Undo method in API reference">Undo()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Reverses the last action performed on the diagram. A no-op if there is nothing to undo or if not initialized. Ctrl+Z also triggers this.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Zoom_System_Double_System_Nullable_Microsoft_Maui_Graphics_Point__" aria-label="View Zoom method in API reference">Zoom()</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task</a></td>
    <td>Multiplies the current zoom level by a factor. Optionally centers the zoom on a specific viewport point instead of the diagram center.</td>
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
    <td>Raised when nodes or connectors are added to or removed from the diagram, whether through code or user interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_ConnectionChanged" aria-label="View ConnectionChanged event in API reference">ConnectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorConnectionChangedEventArgs.html" aria-label="View DiagramConnectorConnectionChangedEventArgs type in API reference">DiagramConnectorConnectionChangedEventArgs</a>&gt;</td>
    <td>Raised when a connector's source or target endpoint attaches to, detaches from, or routes between different nodes or ports.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_Created" aria-label="View Created event in API reference">Created</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Raised once the JavaScript-side diagram instance is fully initialized and ready to receive nodes and connectors.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_JavaScriptError" aria-label="View JavaScriptError event in API reference">JavaScriptError</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramJavaScriptErrorEventArgs.html" aria-label="View DiagramJavaScriptErrorEventArgs type in API reference">DiagramJavaScriptErrorEventArgs</a>&gt;</td>
    <td>Raised when a JavaScript error occurs in the hosted page, such as a script load failure or malformed payload.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_PositionChanged" aria-label="View PositionChanged event in API reference">PositionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodePositionChangedEventArgs.html" aria-label="View DiagramNodePositionChangedEventArgs type in API reference">DiagramNodePositionChangedEventArgs</a>&gt;</td>
    <td>Raised after a node finishes being dragged to a new position in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_RotationChanged" aria-label="View RotationChanged event in API reference">RotationChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodeRotationChangedEventArgs.html" aria-label="View DiagramNodeRotationChangedEventArgs type in API reference">DiagramNodeRotationChangedEventArgs</a>&gt;</td>
    <td>Raised after a node finishes being rotated in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramSelectionChangedEventArgs.html" aria-label="View DiagramSelectionChangedEventArgs type in API reference">DiagramSelectionChangedEventArgs</a>&gt;</td>
    <td>Raised when the user selects or deselects nodes or connectors in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SizeChanged" aria-label="View SizeChanged event in API reference">SizeChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramNodeSizeChangedEventArgs.html" aria-label="View DiagramNodeSizeChangedEventArgs type in API reference">DiagramNodeSizeChangedEventArgs</a>&gt;</td>
    <td>Raised after a node finishes being resized in the diagram. Hides the base element resize event.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_SourcePointChanged" aria-label="View SourcePointChanged event in API reference">SourcePointChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorSourcePointChangedEventArgs.html" aria-label="View DiagramConnectorSourcePointChangedEventArgs type in API reference">DiagramConnectorSourcePointChangedEventArgs</a>&gt;</td>
    <td>Raised after a connector's floating source endpoint finishes being dragged in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_TargetPointChanged" aria-label="View TargetPointChanged event in API reference">TargetPointChanged</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramConnectorTargetPointChangedEventArgs.html" aria-label="View DiagramConnectorTargetPointChangedEventArgs type in API reference">DiagramConnectorTargetPointChangedEventArgs</a>&gt;</td>
    <td>Raised after a connector's floating target endpoint finishes being dragged in the diagram.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.SfDiagram.html#Syncfusion_Maui_Diagram_SfDiagram_TextEdited" aria-label="View TextEdited event in API reference">TextEdited</a></td>
    <td><a href="https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler</a>&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Diagram.DiagramTextEditedEventArgs.html" aria-label="View DiagramTextEditedEventArgs type in API reference">DiagramTextEditedEventArgs</a>&gt;</td>
    <td>Raised after a node or connector label is edited and the changes are committed in the diagram.</td>
</tr>
</table>