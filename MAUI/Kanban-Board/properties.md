---
layout: post
title: Properties of .NET MAUI Kanban Board control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Kanban Board (SfKanban) control.
platform: maui
control: SfKanban
documentation: ug
---

# .NET MAUI Kanban Board API Reference

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ActualColumns">ActualColumns</a></td>
<td>IList<KanbanColumn></td>
<td>Gets the collection of columns currently displayed in the Kanban board.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_AutoGenerateColumns">AutoGenerateColumns</a></td>
<td>bool</td>
<td>Defines whether columns are generated automatically from the data source.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTemplate">CardTemplate</a></td>
<td>DataTemplate</td>
<td>Defines the template used to render Kanban cards.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath">ColumnMappingPath</a></td>
<td>string</td>
<td>Defines the property path used to map items to columns.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Columns">Columns</a></td>
<td>KanbanColumnCollection</td>
<td>Defines the collection of columns displayed in the Kanban board.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnWidth">ColumnWidth</a></td>
<td>double</td>
<td>Defines the width of Kanban columns.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
<td>bool</td>
<td>Defines whether the liquid glass effect is enabled.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_HeaderTemplate">HeaderTemplate</a></td>
<td>DataTemplate</td>
<td>Defines the template used to render column headers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ItemsSource">ItemsSource</a></td>
<td>IEnumerable</td>
<td>Defines the collection of items displayed in the Kanban board.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumColumnWidth">MaximumColumnWidth</a></td>
<td>double</td>
<td>Defines the maximum width of a Kanban column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumHeaderHeight">MaximumHeaderHeight</a></td>
<td>double</td>
<td>Defines the maximum height of column headers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumColumnWidth">MinimumColumnWidth</a></td>
<td>double</td>
<td>Defines the minimum width of a Kanban column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumHeaderHeight">MinimumHeaderHeight</a></td>
<td>double</td>
<td>Defines the minimum height of column headers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingMappingPath">SortingMappingPath</a></td>
<td>string</td>
<td>Defines the property path used to sort cards.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingOrder">SortingOrder</a></td>
<td>SortOrder</td>
<td>Defines the sorting order of Kanban cards.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Workflows">Workflows</a></td>
<td>KanbanWorkflowCollection</td>
<td>Defines the workflow restrictions and transitions between columns.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html">RefreshKanbanColumns()</a></td>
<td>void</td>
<td>Refreshes the Kanban columns and updates the layout.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTapped">CardTapped</a></td>
<td>EventHandler&lt;KanbanCardTappedEventArgs&gt;</td>
<td>Raised when a Kanban card is tapped.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnd">DragEnd</a></td>
<td>EventHandler&lt;KanbanDragEndEventArgs&gt;</td>
<td>Raised when a drag operation ends.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnter">DragEnter</a></td>
<td>EventHandler&lt;KanbanDragEnterEventArgs&gt;</td>
<td>Raised when a dragged card enters a column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragLeave">DragLeave</a></td>
<td>EventHandler&lt;KanbanDragLeaveEventArgs&gt;</td>
<td>Raised when a dragged card leaves a column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragOver">DragOver</a></td>
<td>EventHandler&lt;KanbanDragOverEventArgs&gt;</td>
<td>Raised while a card is dragged over a column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart">DragStart</a></td>
<td>EventHandler&lt;KanbanDragStartEventArgs&gt;</td>
<td>Raised when a drag operation starts.</td>
</tr>

</table>
