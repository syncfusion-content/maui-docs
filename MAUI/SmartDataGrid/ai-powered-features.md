---
layout: post
title: AI-Powered Features in MAUI SmartDataGrid control | Syncfusion®
description: Learn here all about how to use AI-powered natural language commands in Syncfusion® .NET MAUI SmartDataGrid (SfSmartDataGrid) control and more.
platform: MAUI
control: SfSmartDataGrid
documentation: UG
keywords : maui datagrid, ai assist, natural language commands, sorting, grouping, filtering, highlighting
---

# AI-Powered Features in MAUI SmartDataGrid (SfSmartDataGrid)

The [SfSmartDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartDataGrid.html) provides AI-powered capabilities that enable grid operations through natural language prompts, removing the need for manual configuration. Actions such as sorting, grouping, filtering, highlighting, and clearing can be applied using simple text commands. Multi-column operations are supported in a single prompt for efficient interaction with the grid.

## Sorting

Sorting organizes data by one or more columns in ascending or descending order. Multi-column sorting can be applied in a single command, and previously applied sorting can be removed using a clear command.

### Example Prompts

```
// Applies sort to the City column in Descending direction
sort by city in descending

// Applies sort to the City and Revenue columns in Descending and Ascending directions
sort by city column in descending and Revenue ascending

// Clears sort columns
clear sorting
```

<img alt="maui-smart-datagrid-sort" src="Images\AI-Powered Features\maui-smart-datagrid-sort.gif" width="600"/>

## Grouping

Grouping organizes data by one or more columns as specified in the command. Multiple commands can be combined to create multi-level grouping, and grouping can be removed using a clear command.

### Example Prompts

```
// Groups data by Country column
group by Country

// Groups data by Country and ShipCity columns
group by Country and ShipCity

// Clears all applied grouping
clear grouping
```

<img alt="maui-smart-datagrid-group" src="Images\AI-Powered Features\maui-smart-datagrid-group.gif" width="600"/>

## Filtering

Filtering uses natural language conditions like *equals*, *contains*, *greaterThan*, or *between* to build predicates internally and apply them to the grid. Multi step filters using **AND/OR** can be expressed in a single prompt and filters can be cleared with a single command.

### Example Prompts

```
// Filters rows where Country equals Germany
filter Country equals Germany

// Filters rows where Country equals Germany AND Revenue is greater than 1000
filter Country equals Germany AND Revenue greaterThan 1000

// Clears all applied filters
clear filters
```

<img alt="maui-smart-datagrid-filter" src="Images\AI-Powered Features\maui-smart-datagrid-filter.gif" width="600"/>

## Highlight

Highlighting applies styles to rows or cells that meet specified conditions. A color can be included in the command (for example, Red, LightPink, hex, or RGB); if no color is specified, the default highlight color is used. Multiple highlight rules can be combined, and highlights can be cleared individually or all at once.

### Example Prompts

```
// Highlights rows where Total is greater than 1000 with LightPink color
highlight rows where Total > 1000 color LightPink

// Highlights rows where Total > 1000 with LightPink AND cells in OrderID less than 1005 with Red color
highlight rows where Total > 1000 color LightPink AND highlight cells in OrderID lessThan 1005 color Red

// Clears all highlights
clear highlight

// Clears only row highlights
clear row highlight

// Clears only cell highlights
clear cell highlight
```

<img alt="maui-smart-datagrid-highlight" src="Images\AI-Powered Features\maui-smart-datagrid-highlight.gif" width="600" />
