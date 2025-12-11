---
layout: post
title: Syncfusion AI Coding Assistant Prompt Library | Syncfusion
description: Enhance .NET MAUI productivity with the Syncfusion AI Coding Assistant Prompt Library, prompts for code generation, configuration, and contextual guidance.
platform: MAUI
control: Syncfusion AI Coding Assistant Prompt Library
documentation: ug
---

# Prompt Library - AI Coding Assistant

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

The Syncfusion .NET MAUI DataGrid delivers flexible, efficient data tables for handling extensive records with built-in interactivity.

{% promptcards %}
{% promptcard Data Binding %}
#SyncfusionMAUIAssistant How to bind the DataGrid to a DataTable and show an example with columns auto-generated and customized?
{% endpromptcard %}
{% promptcard Column Types %}
#SyncfusionMAUIAssistant Show me a DataGrid using numeric, text, date, checkbox, image, combobox, picker, and template columns.
{% endpromptcard %}
{% promptcard Editing with Column Types %}
#SyncfusionMAUIAssistant How to configure in-place editing using numeric, text, date, checkbox, image, combo box, picker, and template editors in the DataGrid.
{% endpromptcard %}
{% promptcard Selection and Keyboard Navigation %}
#SyncfusionMAUIAssistant Enable single and multiple row selection with programmatic selection APIs and Windows keyboard navigation.
{% endpromptcard %}
{% promptcard Data Virtualization (Overview) %}
#SyncfusionMAUIAssistant Compare and configure DataGrid virtualization modes: paging, incremental loading, and virtualization for large datasets.
{% endpromptcard %}
{% promptcard Master-Details View %}
#SyncfusionMAUIAssistant Display hierarchical data with a master-detail layout using nested DataGrids in .NET MAUI.
{% endpromptcard %}
{% promptcard Multi-Column Sorting %}
#SyncfusionMAUIAssistant Enable sorting on multiple columns and show initial sort descriptions in the DataGrid.
{% endpromptcard %}
{% promptcard Multi-Column Grouping %}
#SyncfusionMAUIAssistant How to enable interactive multiple columns grouping and show grouped summaries in the .NET MAUI DataGrid.
{% endpromptcard %}
{% promptcard Summaries %}
#SyncfusionMAUIAssistant How to configure column and group summaries (Sum, Count, Average) in the .NET MAUI DataGrid with footer and group summary rows.
{% endpromptcard %}
{% promptcard Filtering %}
#SyncfusionMAUIAssistant Programmatically filter DataGrid records using multiple criteria and clear filters on demand.
{% endpromptcard %}
{% promptcard Column Sizing Modes %}
#SyncfusionMAUIAssistant Set DataGrid column width modes (Auto, Star, FitToContent) and mix sizing strategies.
{% endpromptcard %}
{% promptcard Column and Row Drag and Drop %}
#SyncfusionMAUIAssistant How to enable drag-and-drop to reorder columns and  reorder records in the DataGrid?
{% endpromptcard %}
{% promptcard Freeze Panes %}
#SyncfusionMAUIAssistant Freeze specific rows and columns so they remain visible while scrolling the DataGrid.
{% endpromptcard %}
{% promptcard Styling and Conditional Formatting %}
#SyncfusionMAUIAssistant Customize cell and header styles and apply conditional formatting based on data values.
{% endpromptcard %}
{% promptcard Paging %}
#SyncfusionMAUIAssistant Enable paging with page size, navigation UI, and initial page in the .NET MAUI DataGrid.
{% endpromptcard %}
{% promptcard Unbound Row and Column %}
#SyncfusionMAUIAssistant Add an unbound row and column that displays calculated or custom values not present in the data model.
{% endpromptcard %}
{% promptcard Exporting %}
#SyncfusionMAUIAssistant Export DataGrid content to Excel and PDF with options to include headers, summaries, and styles.
{% endpromptcard %}
{% endpromptcards %}

### Charts

The Syncfusion .NET MAUI Chart suite offers versatile, high-performance charts for mobile and desktop with multiple series types and interactions.

{% promptcards %}
{% promptcard Local and Remote Data %}
#SyncfusionMAUIAssistant How do I bind both local and remote data sources to a Syncfusion .NET MAUI Chart?
{% endpromptcard %}
{% promptcard Chart Types Overview %}
#SyncfusionMAUIAssistant What chart types are available in the Syncfusion .NET MAUI Chart and how to configure them?
{% endpromptcard %}
{% promptcard Markers and Data Labels %}
#SyncfusionMAUIAssistant How can I display markers and data labels on a line chart in .NET MAUI?
{% endpromptcard %}
{% promptcard Annotations %}
#SyncfusionMAUIAssistant Add custom annotations to highlight specific data points in a .NET MAUI chart.
{% endpromptcard %}
{% promptcard Export to Image %}
#SyncfusionMAUIAssistant How do I export a Syncfusion .NET MAUI Chart to image format?
{% endpromptcard %}
{% promptcard Axes and Multiple Axes %}
#SyncfusionMAUIAssistant Configure CategoryAxis, NumericalAxis, DateTimeAxis, and add a secondary Y-axis with series mapped to it.
{% endpromptcard %}
{% promptcard Tooltips and Trackball %}
#SyncfusionMAUIAssistant Show interactive tooltips and a trackball with formatted labels and multiple series value display.
{% endpromptcard %}
{% promptcard Legend and Title %}
#SyncfusionMAUIAssistant Add chart title, subtitle, and a responsive legend (positioning, overflow modes) in a .NET MAUI chart.
{% endpromptcard %}
{% promptcard Data Labels and Smart Labels %}
#SyncfusionMAUIAssistant Enable data labels with templates, alignment, and smart label collision avoidance for dense data.
{% endpromptcard %}
{% promptcard Annotations and Plot Bands %}
#SyncfusionMAUIAssistant Add chart annotations and plot bands (strip lines) to highlight ranges and thresholds.
{% endpromptcard %}
{% promptcard Series Types Quick Setup %}
#SyncfusionMAUIAssistant Create a chart with Line, Spline, StepLine, Area, SplineArea, Column, Bar, Scatter, and Bubble series.
{% endpromptcard %}
{% promptcard Range and Error Bars %}
#SyncfusionMAUIAssistant Show RangeColumn/RangeArea series and add ErrorBar adornments for variability visualization.
{% endpromptcard %}
{% promptcard Financial Series %}
#SyncfusionMAUIAssistant How to set up OHLC and Candle series with DateTimeAxis, tooltip formatting, and crosshair/trackball.
{% endpromptcard %}
{% promptcard Live (Real-time) Updates %}
#SyncfusionMAUIAssistant How to implement a live-updating chart using ObservableCollection and timer-based data feeds.
{% endpromptcard %}
{% promptcard Segment Color Mapping and Gradients %}
#SyncfusionMAUIAssistant Apply segment color mapping and gradient fills based on Y-value ranges.
{% endpromptcard %}
{% promptcard Axis Customization %}
#SyncfusionMAUIAssistant Configure axis intervals, labels format, inversed axis, axis crossing, and logarithmic axis.
{% endpromptcard %}
{% promptcard Gridlines and Plot Area Styling %}
#SyncfusionMAUIAssistant Customize major/minor gridlines, tick lines, plot area background, and border.
{% endpromptcard %}
{% promptcard Series Animation %}
#SyncfusionMAUIAssistant Enable and customize series animation on load and refresh for a Cartesian chart.
{% endpromptcard %}
{% promptcard Sampling and Performance %}
#SyncfusionMAUIAssistant Optimize large datasets with data sampling and performance tips for smooth interactions.
{% endpromptcard %}
{% endpromptcards %}

### Scheduler

The Syncfusion .NET MAUI Scheduler helps manage events, resources, and timelines with powerful views and customization.

{% promptcards %}
{% promptcard Views and Quick Switch %}
#SyncfusionMAUIAssistant Configure Day, Week, WorkWeek, Month, Agenda, Timeline Day/Week/WorkWeek/Month views and add quick view switching.
{% endpromptcard %}
{% promptcard Appointment Mapping and Data Binding %}
#SyncfusionMAUIAssistant How to bind custom appointment models using mapping (subject, notes, location, start/end, color, recurrence) with MVVM.
{% endpromptcard %}
{% promptcard Recurring Events and Series Editing %}
#SyncfusionMAUIAssistant Create recurring appointments (daily/weekly/monthly/yearly) and enable editing a single occurrence or the entire series.
{% endpromptcard %}
{% promptcard Time Zones and DST %}
#SyncfusionMAUIAssistant Show appointments in specific time zones with automatic Daylight Saving Time handling and conversion.
{% endpromptcard %}
{% promptcard Work Time, Work Days, and First Day of Week %}
#SyncfusionMAUIAssistant How to set working hours, configure work days, customize the first day of week, and hide non-working days.
{% endpromptcard %}
{% promptcard Min/Max Date Navigation Limits %}
#SyncfusionMAUIAssistant How to restrict navigation with MinimumDateTime and MaximumDateTime to keep users in a valid planning range.
{% endpromptcard %}
{% promptcard Special Time Regions (Blocking Intervals) %}
#SyncfusionMAUIAssistant Define special time regions to block interaction (e.g., holidays/breaks) and highlight them across views.
{% endpromptcard %}
{% promptcard Blackout Dates (Selectable Day Predicate) %}
#SyncfusionMAUIAssistant Disable specific dates like weekends or holidays to prevent selection and interaction.
{% endpromptcard %}
{% promptcard Drag-and-Drop and Inline Editing %}
#SyncfusionMAUIAssistant Enable drag to reschedule, resize to change duration, and inline editors for quick appointment updates.
{% endpromptcard %}
{% promptcard Resources and Grouping %}
#SyncfusionMAUIAssistant Group by resources (rooms/people/teams) with color-coding and timeline views optimized for many resources.
{% endpromptcard %}
{% promptcard Load on Demand %}
#SyncfusionMAUIAssistant Load appointments on demand with a loading indicator for large schedules.
{% endpromptcard %}
{% promptcard Reminders and Notifications Integration %}
#SyncfusionMAUIAssistant Add reminder metadata to appointments and integrate with app notifications for alerts.
{% endpromptcard %}
{% promptcard Theming and Customization %}
#SyncfusionMAUIAssistant How to style headers, cells, appointments, selection, and special regions; support Light/Dark themes.
{% endpromptcard %}
{% endpromptcards %}

### ListView

The Syncfusion .NET MAUI ListView provides a high-performance, flexible list with rich templating, data operations, and interactions.

{% promptcards %}
{% promptcard High-Performance Virtualization %}
#SyncfusionMAUIAssistant Configure ListView with UI virtualization and recycling for smooth scrolling on large datasets.
{% endpromptcard %}
{% promptcard Data Binding %}
#SyncfusionMAUIAssistant How to bind ListView to ObservableCollection/IEnumerable with change tracking and updates.
{% endpromptcard %}
{% promptcard Item Templates and Template Selector %}
#SyncfusionMAUIAssistant How to use DataTemplate and DataTemplateSelector for different item appearances based on data.
{% endpromptcard %}
{% promptcard Grouping with Sticky Headers %}
#SyncfusionMAUIAssistant Enable grouping with sticky group headers and customize group header templates.
{% endpromptcard %}
{% promptcard Sorting and Filtering %}
#SyncfusionMAUIAssistant Apply sorting and filtering via the ListView data source or ViewModel helpers.
{% endpromptcard %}
{% promptcard Selection (Single/Multiple) %}
#SyncfusionMAUIAssistant Configure single and multiple selection modes and perform programmatic selection.
{% endpromptcard %}
{% promptcard Swipe Actions %}
#SyncfusionMAUIAssistant Add left and right swipe templates for contextual actions like delete and archive.
{% endpromptcard %}
{% promptcard Drag-and-Drop Reordering %}
#SyncfusionMAUIAssistant Enable drag-and-drop to reorder ListView items and persist the new order.
{% endpromptcard %}
{% promptcard Pull-to-Refresh %}
#SyncfusionMAUIAssistant Add pull-to-refresh behavior to reload data with a loading indicator.
{% endpromptcard %}
{% promptcard Load More / Infinite Scrolling %}
#SyncfusionMAUIAssistant Implement load-more at end of list with automatic and manual triggers for infinite scrolling.
{% endpromptcard %}
{% promptcard Variable Item Height %}
#SyncfusionMAUIAssistant Configure dynamic item sizing to accommodate variable-height content.
{% endpromptcard %}
{% promptcard Headers and Footers %}
#SyncfusionMAUIAssistant Add header and footer templates with optional sticky behavior for contextual UI.
{% endpromptcard %}
{% promptcard Programmatic Scrolling %}
#SyncfusionMAUIAssistant Scroll to a specific item or index with position (start/center/end) and animation options.
{% endpromptcard %}
{% promptcard Layout Modes %}
#SyncfusionMAUIAssistant Switch between linear and grid-like layouts and configure span/count where supported.
{% endpromptcard %}
{% promptcard Empty View %}
#SyncfusionMAUIAssistant Show a custom empty view template when no items are available.
{% endpromptcard %}
{% endpromptcards %}

### AI AssistView

The Syncfusion .NET MAUI AI AssistView provides a ready-made conversational UI for integrating LLMs with features like message list, input box, suggestions, attachments, and tool/action invocation.

{% promptcard Messages %}
#SyncfusionMAUIAssistant Bind AssistView to a message collection with system, user, and pre load conversation history.
{% endpromptcard %}
{% promptcard Streaming and Typing Indicator %}
#SyncfusionMAUIAssistant Enable token streaming with a typing indicator and incremental message updates.
{% endpromptcard %}
{% promptcard Suggestions (Quick Prompts) %}
#SyncfusionMAUIAssistant How to add clickable suggestion chips that insert predefined prompts into the input box.
{% endpromptcard %}
{% promptcard Attachments and File Context %}
#SyncfusionMAUIAssistant How to allow users to attach files and include file metadata/content as context in AI requests.
{% endpromptcard %}
{% promptcard Markdown and Rich Rendering %}
#SyncfusionMAUIAssistant How to render assistant responses with Markdown (headings, code blocks) and support inline images/emojis.
{% endpromptcard %}
{% promptcard Avatars and Message Templates %}
#SyncfusionMAUIAssistant How to customize user/assistant avatars and use DataTemplate/DataTemplateSelector for message bubbles.
{% endpromptcard %}
{% promptcard Error Handling and Retries %}
#SyncfusionMAUIAssistant How to handle provider errors with retry/cancel UI and graceful fallback messages.
{% endpromptcard %}
{% promptcard Theming and Styling %}
#SyncfusionMAUIAssistant Apply custom themes for message bubbles, background, input bar, and suggestion chips (Light/Dark support).
{% endpromptcard %}
{% promptcard Command/Enter Behavior %}
#SyncfusionMAUIAssistant Configure Enter to send and Shift+Enter for newline; support multiline input with character counter.
{% endpromptcard %}
{% promptcard Conversation Persistence %}
#SyncfusionMAUIAssistant How to Save and restore conversations to local storage or database with message replay on app start.
{% endpromptcard %}
{% promptcard Citations and References %}
#SyncfusionMAUIAssistant Display citations/references returned by the model as hyper links under the message.
{% endpromptcard %}
{% endpromptcards %}

## See also

* [AI Coding Assistant Overview](https://help.syncfusion.com/maui/ai-coding-assistant/overview)
* [SyncfusionMAUIAssistant MCP Server](https://help.syncfusion.com/maui/ai-coding-assistant/mcp-server)
