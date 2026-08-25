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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;T&gt; type in API reference">IList&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html" aria-label="View KanbanColumn type in API reference">KanbanColumn&gt;</a></a></td>
    <td>Read-only <code>collection</code> of <code>KanbanColumn</code> entries that reflects the <code>columns</code> currently rendered on the <code>board</code> after <code>auto-generation</code> or <code>filtering</code> has been resolved.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_AutoGenerateColumns" aria-label="View AutoGenerateColumns property in API reference">AutoGenerateColumns</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>columns</code> are generated <code>automatically</code> from the bound <code>ItemsSource</code> when explicit <code>columns</code> are not provided. Useful for building <code>lanes</code> from the <code>underlying data</code> without <code>manual definitions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_CardTemplate" aria-label="View CardTemplate property in API reference">CardTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render each <code>Kanban card</code>. Use it to fully customize the <code>card surface</code> with your <code>visual layout</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnMappingPath" aria-label="View ColumnMappingPath property in API reference">ColumnMappingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Property path</code> of each <code>item</code> used to determine its <code>target column</code>. <code>Items</code> are routed to the <code>column</code> whose <code>Categories</code> match the value provided by this <code>path</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Columns" aria-label="View Columns property in API reference">Columns</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumnCollection.html" aria-label="View KanbanColumnCollection type in API reference">KanbanColumnCollection</a></td>
    <td><code>Collection</code> of <code>KanbanColumn</code> entries that define the <code>visible lanes</code> of the <code>board</code>, including <code>header text</code>, <code>categories</code>, and <code>minimum or maximum card counts</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ColumnWidth" aria-label="View ColumnWidth property in API reference">ColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Width</code> applied to every <code>board column</code>. Larger values reserve more <code>horizontal space</code> per <code>lane</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Applies the <code>Liquid Glass effect</code> to the <code>board</code> when placed inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 26</code> or later and <code>macOS 26</code> or later with <code>.NET 10</code> or later; unsupported configurations use the standard background.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render the <code>header</code> of each <code>column</code>. Use it to customize the <code>lane title area</code> with <code>icons</code>, <code>counts</code>, or any <code>custom view</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td><code>Collection</code> of <code>items</code> displayed as <code>cards</code> on the <code>board</code>. Updates to the <code>source</code> honor any <code>automatic</code> <code>column</code> and <code>workflow evaluation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumColumnWidth" aria-label="View MaximumColumnWidth property in API reference">MaximumColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Upper limit</code> for the <code>width</code> of a <code>column</code> in <code>responsive layouts</code>. <code>Columns</code> do not expand beyond this value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MaximumHeaderHeight" aria-label="View MaximumHeaderHeight property in API reference">MaximumHeaderHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Upper limit</code> for <code>column header height</code>. <code>Header</code> content does not grow <code>taller</code> than this value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumColumnWidth" aria-label="View MinimumColumnWidth property in API reference">MinimumColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Lower limit</code> for <code>column width</code>, preventing <code>lanes</code> from becoming too <code>narrow</code> on <code>compact screens</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_MinimumHeaderHeight" aria-label="View MinimumHeaderHeight property in API reference">MinimumHeaderHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Lower limit</code> for <code>column header height</code>, keeping <code>header</code> content <code>readable</code> on <code>compact screens</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingMappingPath" aria-label="View SortingMappingPath property in API reference">SortingMappingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Property path</code> of each <code>item</code> that is used to <code>order</code> <code>cards</code> within a <code>column</code>. Required for <code>column-internal sorting</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_SortingOrder" aria-label="View SortingOrder property in API reference">SortingOrder</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanSortingOrder.html" aria-label="View KanbanSortingOrder enum in API reference">KanbanSortingOrder</a></td>
    <td><code>Direction</code> used when <code>sorting</code> <code>cards</code> within a <code>column</code>. Choose a supported <code>KanbanSortingOrder</code> value such as <code>Ascending</code> or <code>Descending</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_Workflows" aria-label="View Workflows property in API reference">Workflows</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanWorkflow.html" aria-label="View KanbanWorkflow type in API reference">ObservableCollection&lt;KanbanWorkflow&gt;</a></td>
    <td><code>ObservableCollection</code> of <code>KanbanWorkflow</code> rules that define which <code>cards</code> can move between <code>columns</code>. Used to enforce <code>state relationships</code> during <code>drag-and-drop</code> and <code>programmatic moves</code>.</td>
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
    <td>Refreshes the <code>board</code> so that recent changes in <code>Columns</code>, <code>Workflows</code>, <code>ItemsSource</code>, or other settings take effect <code>immediately</code>. Useful after the <code>underlying data</code> has been modified and the <code>auto-generated columns</code> need to <code>re-evaluate</code>.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanCardTappedEventArgs.html" aria-label="View KanbanCardTappedEventArgs type in API reference">KanbanCardTappedEventArgs&gt;</a></a></td>
    <td>Triggered when a <code>Kanban card</code> is <code>tapped</code>, providing the <code>tapped card</code> and its <code>data context</code> for <code>selection</code>, <code>navigation</code>, or <code>custom handling</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart" aria-label="View DragStart event in API reference">DragStart</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html" aria-label="View KanbanDragStartEventArgs type in API reference">KanbanDragStartEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>user begins dragging</code> a <code>card</code>. Set the <code>Cancel</code> property in the <code>event args</code> to prevent the <code>drag</code> from <code>starting</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnter" aria-label="View DragEnter event in API reference">DragEnter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html" aria-label="View KanbanDragEnterEventArgs type in API reference">KanbanDragEnterEventArgs&gt;</a></a></td>
    <td>Triggered when a <code>dragged card</code> <code>enters</code> a <code>column</code>, allowing you to provide <code>live feedback</code> for the <code>target lane</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragOver" aria-label="View DragOver event in API reference">DragOver</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html" aria-label="View KanbanDragOverEventArgs type in API reference">KanbanDragOverEventArgs&gt;</a></a></td>
    <td>Triggered <code>continuously</code> while the <code>card</code> is <code>dragged over</code> a <code>column</code>, providing <code>up-to-date positioning information</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragLeave" aria-label="View DragLeave event in API reference">DragLeave</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html" aria-label="View KanbanDragLeaveEventArgs type in API reference">KanbanDragLeaveEventArgs&gt;</a></a></td>
    <td>Triggered when a <code>dragged card</code> <code>leaves</code> a <code>column</code>, signaling that the <code>previous target</code> is no longer <code>active</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnd" aria-label="View DragEnd event in API reference">DragEnd</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html" aria-label="View KanbanDragEndEventArgs type in API reference">KanbanDragEndEventArgs&gt;</a></a></td>
    <td>Triggered when a <code>drag operation completes</code>. Inspect the <code>Cancel</code> property to determine whether the <code>card</code> was successfully <code>dropped</code> or the <code>move was canceled</code>.</td>
</tr>
</table>
