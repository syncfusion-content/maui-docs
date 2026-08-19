---
layout: post
title: Properties of .NET MAUI Kanban Board control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Kanban Board (SfKanban) control.
platform: maui
control: SfKanban
documentation: ug
---

# API Reference for .NET MAUI Kanban Board

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ActualColumns" aria-label="View ActualColumns property in API reference">ActualColumns</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList<T> type in API reference">IList&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html" aria-label="View KanbanColumn type in API reference">KanbanColumn</a>&gt;</a></td>
<td>Provides the collection of columns currently displayed in the board and reflects the resolved column set used during layout, rendering, and workflow evaluation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_AutoGenerateColumns" aria-label="View AutoGenerateColumns property in API reference">AutoGenerateColumns</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether columns are created automatically from the bound data and enables the board to build its column structure without explicit column definitions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTemplate" aria-label="View CardTemplate property in API reference">CardTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to render Kanban cards and allows the card surface to be customized with a tailored visual layout.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath" aria-label="View ColumnMappingPath property in API reference">ColumnMappingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the field path used to map items to columns and controls how each card is associated with a board column.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Columns" aria-label="View Columns property in API reference">Columns</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumnCollection.html" aria-label="View KanbanColumnCollection type in API reference">KanbanColumnCollection</a></td>
<td>Provides the collection of columns defined for the board and serves as the primary container for the visible Kanban lanes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnWidth" aria-label="View ColumnWidth property in API reference">ColumnWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width of each Kanban column and controls how much horizontal space is reserved for every lane.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>liquid glass</code> visual treatment is enabled and applies a refined translucent appearance to the board surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to render column headers and enables custom header layouts for each board lane.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Provides the collection of items displayed in the board and supplies the data used to create and update Kanban cards.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumColumnWidth" aria-label="View MaximumColumnWidth property in API reference">MaximumColumnWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the maximum width allowed for a Kanban column and constrains column expansion in responsive layouts.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumHeaderHeight" aria-label="View MaximumHeaderHeight property in API reference">MaximumHeaderHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the maximum height allowed for column headers and limits how tall the header area can become.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumColumnWidth" aria-label="View MinimumColumnWidth property in API reference">MinimumColumnWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the minimum width allowed for a Kanban column and prevents columns from shrinking beyond the supported size.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumHeaderHeight" aria-label="View MinimumHeaderHeight property in API reference">MinimumHeaderHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the minimum height allowed for column headers and keeps the header surface readable in compact layouts.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingMappingPath" aria-label="View SortingMappingPath property in API reference">SortingMappingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the field path used to sort cards and controls which item property is evaluated during ordering.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingOrder" aria-label="View SortingOrder property in API reference">SortingOrder</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanSortingOrder.html" aria-label="View KanbanSortingOrder enum in API reference">KanbanSortingOrder</a></td>
<td>Defines the ordering direction used for card sorting by using the <code>KanbanSortingOrder</code> enum, such as <code>Ascending</code> or <code>Descending</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Workflows" aria-label="View Workflows property in API reference">Workflows</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html" aria-label="View KanbanWorkflow type in API reference">ObservableCollection&lt;KanbanWorkflow&gt;</a></td>
<td>Provides the workflow rules and transition definitions used to control card movement between columns and enforce board state relationships.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_RefreshKanbanColumns" aria-label="View RefreshKanbanColumns method in API reference">RefreshKanbanColumns()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Refreshes the Kanban columns and reapplies the current layout so that changes in data, workflow, or configuration are reflected immediately.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTapped" aria-label="View CardTapped event in API reference">CardTapped</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html" aria-label="View KanbanCardTappedEventArgs type in API reference">KanbanCardTappedEventArgs</a></td>
<td>Raised when a Kanban card is tapped and provides the tapped card context for selection, navigation, or custom interaction handling.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnd" aria-label="View DragEnd event in API reference">DragEnd</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html" aria-label="View KanbanDragEndEventArgs type in API reference">KanbanDragEndEventArgs</a></td>
<td>Raised when a drag operation ends and supplies the final drag state for card repositioning or validation logic.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnter" aria-label="View DragEnter event in API reference">DragEnter</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html" aria-label="View KanbanDragEnterEventArgs type in API reference">KanbanDragEnterEventArgs</a></td>
<td>Raised when a dragged card enters a column and provides the target column context for live drag feedback.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragLeave" aria-label="View DragLeave event in API reference">DragLeave</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html" aria-label="View KanbanDragLeaveEventArgs type in API reference">KanbanDragLeaveEventArgs</a></td>
<td>Raised when a dragged card leaves a column and exposes the drag transition state as the item exits the target area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragOver" aria-label="View DragOver event in API reference">DragOver</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html" aria-label="View KanbanDragOverEventArgs type in API reference">KanbanDragOverEventArgs</a></td>
<td>Raised while a card is dragged over a column and provides continuous updates for hover positioning and drop evaluation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart" aria-label="View DragStart event in API reference">DragStart</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html" aria-label="View KanbanDragStartEventArgs type in API reference">KanbanDragStartEventArgs</a></td>
<td>Raised when a drag operation starts and provides the initial drag context for preparing drag-and-drop behavior.</td>
</tr>
</table>
