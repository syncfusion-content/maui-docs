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

[`DragStart`]() event is triggered when you start to drag a card. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`SourceColumn`]() - Used to get the source column of card.
* [`SourceIndex`]() - Used to get the index of the card in source column.   

## DragEnd  

[`DragEnd`]() event is triggered whenever the card is dropped or dragging action is canceled. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetCategory`]() - Used to get the category of the column where the card is going to be dropped.
* [`TargetColumn`]() - Used to get the current column which is the drop target for the card.
* [`TargetIndex`]() - Used to get the index of the card in target column.

## DragEnter 

[`DragEnter`]() event is triggered when a card enters into a column while dragging. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`IsAboveMaximumLimit`]() - Used to know whether the total cards count of the target column will be above the maximum limit if you drop the card in target column. You can define the maximum limit of the cards using [MaximumLimit]() property of [KanbanColumn](). 
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the column upon which the card enters.
* [`TargetIndex`]() - Used to get the index of the card in target column.

## DragLeave 

[`DragLeave`]() event is triggered when a card leaves a column while dragging. The argument contains the following information.

* [`Data`]() - Used to get the underlying model of the card.
* [`IsBelowMinimumLimit`]() - Used to know whether the total cards count of the target column will be below the minimum limit if you remove the card from target column. You can define the minimum limit of the cards using [MinimumLimit]() property of [KanbanColumn]().
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the column from which the card leaves.

## DragOver

[`DragOver`]() event is triggered when a card is dragged to a new index within a column. The argument contains the following information.

* [`Cancel`]() - Used to cancel the drag action.
* [`Data`]() - Used to get the underlying model of the card.
* [`SourceColumn`]() - Used to get the source column of the card.
* [`SourceIndex`]() - Used to get the index of the card in source column.
* [`TargetColumn`]() - Used to get the current column which is the drop target for the card.
* [`TargetIndex`]() - Used to get the new index of the card in target column.