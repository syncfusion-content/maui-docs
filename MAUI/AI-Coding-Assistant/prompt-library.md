---
layout: post
title: Syncfusion AI Coding Assistant Prompt Library | Syncfusion
description: Explore the Syncfusion AI Coding Assistant Prompt Library to enhance .NET MAUI development productivity with intelligent code generation, configuration examples, and contextual guidance.
control: Syncfusion AI Coding Assistant Prompt Library
platform: MAUI
documentation: ug
domainurl: ##DomainURL##
---

# Prompt Library

Speed up your .NET MAUI projects using these ready-made prompts for popular Syncfusion components. Each prompt is short, easy to understand, and focused on real tasks—like quick setups, tweaks, and fixes.

## How to Use

Before starting, make sure your MCP Server is set up and running.

* Choose a prompt that fits your need.
* Copy the full prompt with the #SyncfusionMAUIAssistant handle.
* Customize the prompt for your specific use case.
* Execute via the MCP Server.
* Always check and test the code before adding it to your project.

## Component-Specific Prompts

### DataGrid

The Syncfusion .NET MAUI DataGrid delivers flexible, performant data tables for handling extensive records with built-in interactivity.

Data Binding (including DataTable)
```
#SyncfusionMAUIAssistant How to bind the DataGrid to a DataTable and show an example with columns auto-generated and customized?
```

Column Types
```
#SyncfusionMAUIAssistant Show me a DataGrid using numeric, text, date, checkbox, image, combobox, picker, and template columns.
```

Editing with Column Types
```
#SyncfusionMAUIAssistant How to configure in-place editing using numeric, text, date, checkbox, image, combo box, picker, and template editors in the DataGrid.
```

Selection and Keyboard Navigation
```
#SyncfusionMAUIAssistant Enable single and multiple row selection with programmatic selection APIs and Windows keyboard navigation.
```

Data Virtualization (Overview)
```
#SyncfusionMAUIAssistant Compare and configure DataGrid virtualization modes: paging, incremental loading, and virtualization for large datasets.
```

Master-Details View
```
#SyncfusionMAUIAssistant Display hierarchical data with a master-detail layout using nested DataGrids in .NET MAUI.
```

Multi-Column Sorting
```
#SyncfusionMAUIAssistant Enable sorting on multiple columns and show initial sort descriptions in the DataGrid.
```

Multi-Column Grouping
```
#SyncfusionMAUIAssistant How to enable interactive multiple columns grouping and show grouped summaries in the .NET MAUI DataGrid.
```

Summaries
```
#SyncfusionMAUIAssistant How to configure column and group summaries (Sum, Count, Average) in the .NET MAUI DataGrid with footer and group summary rows.
```

Filtering
```
#SyncfusionMAUIAssistant Programmatically filter DataGrid records using multiple criteria and clear filters on demand.
```

Column Sizing Modes
```
#SyncfusionMAUIAssistant Set DataGrid column width modes (Auto, Star, FitToContent) and mix sizing strategies.
```

Column and Row Drag and Drop
```
#SyncfusionMAUIAssistant How to enable drag-and-drop to reorder columns and  reorder records in the DataGrid?
```

Freeze Panes
```
#SyncfusionMAUIAssistant Freeze specific rows and columns so they remain visible while scrolling the DataGrid.
```

Styling and Conditional Formatting
```
#SyncfusionMAUIAssistant Customize cell and header styles and apply conditional formatting based on data values.
```

Paging
```
#SyncfusionMAUIAssistant Enable paging with page size, navigation UI, and initial page in the .NET MAUI DataGrid.
```

Unbound Row and Column
```
#SyncfusionMAUIAssistant Add an unbound row and column that displays calculated or custom values not present in the data model.
```

Exporting
```
#SyncfusionMAUIAssistant Export DataGrid content to Excel and PDF with options to include headers, summaries, and styles.
```


### Chart

The Syncfusion .NET MAUI Chart suite offers versatile, high-performance charts for mobile and desktop with multiple series types and interactions.

Local and Remote Data
```
#SyncfusionMAUIAssistant How do I bind both local and remote data sources to a Syncfusion .NET MAUI Chart?
```

Range Selection
```
#SyncfusionMAUIAssistant Show me how to enable range selection in a Syncfusion .NET MAUI Chart.
```

Chart Types Overview
```
#SyncfusionMAUIAssistant What chart types are available in the Syncfusion .NET MAUI Chart and how to configure them?
```

Markers and Data Labels
```
#SyncfusionMAUIAssistant How can I display markers and data labels on a line chart in .NET MAUI?
```

Annotations
```
#SyncfusionMAUIAssistant Add custom annotations to highlight specific data points in a .NET MAUI chart.
```

Chart Export to Image or PDF
```
#SyncfusionMAUIAssistant How do I export a Syncfusion .NET MAUI Chart to PDF or image format?
```

Print Support
```
#SyncfusionMAUIAssistant Enable print functionality for a Syncfusion .NET MAUI Chart component.
```

Dynamic Chart with Remote Data
```
#SyncfusionMAUIAssistant Create a .NET MAUI chart that updates dynamically with remote API data.
```

Multiple Series Types
```
#SyncfusionMAUIAssistant How do I combine bar and line chart types in a single Syncfusion .NET MAUI Chart?
```

Troubleshooting Chart Data Binding
```
#SyncfusionMAUIAssistant Why isn’t my remote data showing up in the Syncfusion .NET MAUI Chart?
```

Interactive Range Selector
```
#SyncfusionMAUIAssistant Configure a range selector for zooming and filtering in a .NET MAUI time-series chart.
```

Custom Markers and Labels
```
#SyncfusionMAUIAssistant Show me an example of customizing chart markers and data label styles in .NET MAUI.
```

### Schedule

The Syncfusion .NET MAUI Scheduler helps manage events, resources, and timelines with powerful views and customization.

Module Injection
```
#SyncfusionMAUIAssistant How do I configure views and resources in the Syncfusion .NET MAUI Scheduler?
```

Remote Data Binding
```
#SyncfusionMAUIAssistant Bind the Scheduler to a remote API for dynamic event loading in .NET MAUI.
```

CRUD Actions
```
#SyncfusionMAUIAssistant Show me how to implement full CRUD operations in the .NET MAUI Scheduler.
```

Virtual Scrolling
```
#SyncfusionMAUIAssistant Enable virtual scrolling for large event datasets in the .NET MAUI Scheduler.
```

Timezone Support
```
#SyncfusionMAUIAssistant How can I configure timezone support in the Syncfusion .NET MAUI Scheduler?
```

Export Schedule to PDF or Excel
```
#SyncfusionMAUIAssistant Add export functionality to download the Scheduler view as PDF or Excel in .NET MAUI.
```

Timeline Header Rows
```
#SyncfusionMAUIAssistant How do I customize timeline header rows in the .NET MAUI Scheduler?
```

Multiple Module Injection
```
#SyncfusionMAUIAssistant Configure multiple views like Day, Week, and Timeline in the .NET MAUI Scheduler.
```

Troubleshooting Schedule CRUD
```
#SyncfusionMAUIAssistant Why aren’t my CRUD actions working correctly in the .NET MAUI Scheduler?
```

Local and Remote Data
```
#SyncfusionMAUIAssistant Bind both local and remote event data to the .NET MAUI Scheduler.
```

Export and Timezone
```
#SyncfusionMAUIAssistant Configure timezone-aware exporting for the .NET MAUI Scheduler view.
```

Advanced Schedule Setup
```
#SyncfusionMAUIAssistant Create a Scheduler setup with multiple views, CRUD, virtual scrolling, and exporting in .NET MAUI.
```

### Kanban

The Syncfusion .NET MAUI Kanban organizes tasks in columns with drag-and-drop, swimlanes, and templating for agile workflows.

Data Binding
```
#SyncfusionMAUIAssistant How do I bind local or remote data to the Syncfusion .NET MAUI Kanban board?
```

Sorting
```
#SyncfusionMAUIAssistant Enable sorting of cards within columns in the .NET MAUI Kanban component.
```

Swimlane View
```
#SyncfusionMAUIAssistant Show me how to group Kanban cards using swimlane headers in .NET MAUI.
```

Kanban Card Editing
```
#SyncfusionMAUIAssistant How can I enable inline editing of Kanban cards in .NET MAUI?
```

Virtualization
```
#SyncfusionMAUIAssistant Configure virtualization for performance with large Kanban datasets in .NET MAUI.
```

Localization
```
#SyncfusionMAUIAssistant How do I localize labels and messages in the .NET MAUI Kanban component?
```

Drag and Drop
```
#SyncfusionMAUIAssistant Enable drag-and-drop functionality for moving cards between columns in .NET MAUI.
```

Sorting and Swimlane
```
#SyncfusionMAUIAssistant Create a .NET MAUI Kanban board with swimlane grouping and sortable cards.
```

Editable Cards and Localization
```
#SyncfusionMAUIAssistant Show me how to edit cards and apply localization in the .NET MAUI Kanban.
```

Troubleshooting Kanban Drag and Drop
```
#SyncfusionMAUIAssistant Why isn’t drag-and-drop working correctly in my .NET MAUI Kanban board?
```

Remote Data and Virtualization
```
#SyncfusionMAUIAssistant Bind remote data to .NET MAUI Kanban and enable virtualization for performance.
```

Advanced Kanban Setup
```
#SyncfusionMAUIAssistant Create a .NET MAUI Kanban board with data binding, swimlane, card editing, and drag-and-drop.
```

### RichTextEditor

The Syncfusion .NET MAUI RichTextEditor offers a modern WYSIWYG editor with extensive formatting, media, and integration features for mobile and desktop.

Toolbar Configuration
```
#SyncfusionMAUIAssistant How do I customize the toolbar options in the Syncfusion RichTextEditor?
```

Link Manipulation
```
#SyncfusionMAUIAssistant Show me how to add, edit, and remove hyperlinks in RichTextEditor content.
```

Read-only Mode
```
#SyncfusionMAUIAssistant How can I render the RichTextEditor in read-only mode and toggle editability?
```

Feature Enable/Disable
```
#SyncfusionMAUIAssistant Enable or disable features like toolbar, link, and image in the .NET MAUI RichTextEditor.
```

Undo and Redo
```
#SyncfusionMAUIAssistant Enable undo and redo functionality in the RichTextEditor toolbar.
```

MVVM Data Binding
```
#SyncfusionMAUIAssistant How do I bind the RichTextEditor content using MVVM and validate input in .NET MAUI?
```

Content Import and Export
```
#SyncfusionMAUIAssistant Export RichTextEditor content to HTML or import existing HTML content.
```

Advanced Toolbar
```
#SyncfusionMAUIAssistant Create a RichTextEditor with toolbar options for formatting, links, and undo/redo.
```

Read-only and MVVM Support
```
#SyncfusionMAUIAssistant Use RichTextEditor in read-only mode and bind it to a ViewModel for submission in .NET MAUI.
```

Undo/Redo and Export
```
#SyncfusionMAUIAssistant Enable undo/redo and export content to HTML in RichTextEditor.
```

Module Injection and Link Editing
```
#SyncfusionMAUIAssistant Inject toolbar and link modules to enable rich link editing in the editor.
```

### Calendar

The Syncfusion .NET MAUI Calendar supports flexible date selection, localization, and custom rendering.

Date Range Selection
```
#SyncfusionMAUIAssistant How do I enable date range selection in the Syncfusion .NET MAUI Calendar?
```

Globalization Support
```
#SyncfusionMAUIAssistant Configure the .NET MAUI Calendar to support multiple cultures and languages.
```

Multi-Date Selection
```
#SyncfusionMAUIAssistant Show me how to allow users to select multiple dates in the .NET MAUI Calendar.
```

Islamic Calendar Support
```
#SyncfusionMAUIAssistant How can I switch the .NET MAUI Calendar to use the Islamic calendar system?
```

Skip Months Feature
```
#SyncfusionMAUIAssistant Enable skipping months in the .NET MAUI Calendar navigation for faster browsing.
```

Calendar Showing Other Month Days
```
#SyncfusionMAUIAssistant How do I show days from adjacent months in the current .NET MAUI Calendar view?
```

Custom Day Cell Format
```
#SyncfusionMAUIAssistant Customize the day cell format in the .NET MAUI Calendar to show short weekday names.
```

Calendar Highlighting Weekends
```
#SyncfusionMAUIAssistant Highlight weekends in the .NET MAUI Calendar with a different background color.
```

Globalization and Islamic Calendar
```
#SyncfusionMAUIAssistant Configure the .NET MAUI Calendar for Arabic culture using Islamic calendar and localization.
```

Multi-Selection and Range
```
#SyncfusionMAUIAssistant Enable both multi-date selection and range selection in the .NET MAUI Calendar.
```

Troubleshooting Calendar Date Range
```
#SyncfusionMAUIAssistant Why isn’t my .NET MAUI Calendar selecting the correct date range?
```

Advanced Calendar Setup
```
#SyncfusionMAUIAssistant Create a .NET MAUI Calendar with date range, multi-selection, globalization, and weekend highlights.
```

## See also

* [AI Coding Assistant Overview](https://help.syncfusion.com/maui/ai-coding-assistant/overview)
* [SyncfusionMAUIAssistant MCP Server](https://help.syncfusion.com/maui/ai-coding-assistant/mcp-server)