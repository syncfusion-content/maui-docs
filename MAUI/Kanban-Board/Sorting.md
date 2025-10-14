---
layout: post
title: Sorting in .NET MAUI Kanban control | Syncfusion®
description: Learn here all about Sorting support in Syncfusion® .NET MAUI Kanban (SfKanban) control and more.
platform: maui
control: Kanban (SfKanban)
documentation: ug
keywords: .net maui Kanban sorting, sfKanban sorting in .net maui, .net maui Kanban sorting support.
---

# Card Item Sorting in .NET MAUI Kanban (SfKanban)

The Kanban control supports customizable card sorting within columns based on specific data fields such as priority, due date, or status. Sorting can be applied programmatically and updated dynamically at runtime using following properties

* `SortingMappingPath` - Used to map the sorting field to a property name in the `KanbanModel` or `CustomModel`. The default value is `string.Empty`, in which case the cards will not be sorted.
* `SortingOrder` - Used to define the direction of cards sorting within each column.
   * `Ascending` - Cards with lower values appear first.
   * `Descending` - Cards with higher values appear first. 

N> This property is applicable only when a valid value is assigned to SortingMappingPath.

## Sorting Behavior in DragEnd Event

The `DragEnd` event in the `Kanban` control supports three sorting approaches:

* **Automatic Sorting**: Call RefreshKanbanColumn() to sort the target column based on predefined sorting properties after a card is dropped.
* **Custom Sorting**: Use e.TargetColumn.Items to access and sort the cards manually using your own logic.
* **No Sorting**: If no sorting logic is applied in the DragEnd event, the dropped card remains in its new position without reordering the column.