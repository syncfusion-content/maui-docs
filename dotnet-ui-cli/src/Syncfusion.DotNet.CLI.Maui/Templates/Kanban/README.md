# Kanban Sample

A getting-started sample for the Syncfusion .NET MAUI `SfKanban` control.

## What it is

The `SfKanban` control is used to visualize and manage work items through a Kanban board interface.

## NuGet package

`Syncfusion.Maui.Kanban`

## Documentation

https://help.syncfusion.com/maui/kanban-board/getting-started

## Sample organization

- `KanbanView.xaml` — the page hosting `SfKanban` with predefined columns bound to the view model.
- `KanbanView.xaml.cs` — assigns the `KanbanWorkflow` collection that restricts card moves between categories.
- `KanbanViewModel.cs` — holds the `Cards` collection of `KanbanModel` sample data.

## Layout and sample data

The sample includes 20 release tasks across four workflow columns. The board fills the page content area and uses default card colors and drag behavior.
