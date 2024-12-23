---
layout: post
title: Events in .NET MAUI Kanban Board control | Syncfusion
description: Learn here all about Events support in Syncfusion .NET MAUI Kanban Board (SfKanban) control, its elements and more.
platform: maui
control: Kanban
documentation: ug
---

# Events in .NET MAUI Kanban Board (SfKanban)

## DragStart

[`DragStart`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragStart) event is triggered when you start to drag a card. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragStartEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragStartEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.   

## DragEnd  

[`DragEnd`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnd) event is triggered whenever the card is dropped or dragging action is canceled. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetCategory`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetCategory) - Used to get the category of the column where the card is going to be dropped.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetColumn) - Used to get the current column which is the drop target for the card.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEndEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEndEventArgs_TargetIndex) - Used to get the index of the card in target column.

## DragEnter 

[`DragEnter`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragEnter) event is triggered when a card enters into a column while dragging. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`IsAboveMaximumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_IsAboveMaximumLimit) - Used to know whether the total cards count of the target column will be above the maximum limit if you drop the card in target column. You can define the maximum limit of the cards using [MaximumLimit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MaximumLimit) property of [KanbanColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html). 
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_TargetColumn) - Used to get the column upon which the card enters.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEnterEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEnterEventArgs_TargetIndex) - Used to get the index of the card in target column.

## DragLeave 

[`DragLeave`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragLeave) event is triggered when a card leaves a column while dragging. The argument contains the following information.

* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`IsBelowMinimumLimit`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragLeaveEventArgs_IsBelowMinimumLimit) - Used to know whether the total cards count of the target column will be below the minimum limit if you remove the card from target column. You can define the minimum limit of the cards using [MinimumLimit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html#Syncfusion_Maui_Kanban_KanbanColumn_MinimumLimit) property of [KanbanColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanColumn.html).
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragLeaveEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragLeaveEventArgs_TargetColumn) - Used to get the column from which the card leaves.

## DragOver

[`DragOver`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.SfKanban.html#Syncfusion_Maui_Kanban_SfKanban_DragOver) event is triggered when a card is dragged to a new index within a column. The argument contains the following information.

* [`Cancel`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_Cancel) - Used to cancel the drag action.
* [`Data`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_Data) - Used to get the underlying model of the card.
* [`SourceColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceColumn) - Used to get the source column of the card.
* [`SourceIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragEventArgs_SourceIndex) - Used to get the index of the card in source column.
* [`TargetColumn`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_TargetColumn) - Used to get the current column which is the drop target for the card.
* [`TargetIndex`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Kanban.KanbanDragOverEventArgs.html#Syncfusion_Maui_Kanban_KanbanDragOverEventArgs_TargetIndex) - Used to get the new index of the card in target column.