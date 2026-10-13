---
layout: post
title: Supported Syncfusion® A2UI Components for .NET MAUI | Syncfusion®
description: Reference guide to all Syncfusion® A2UI for .NET MAUI adapters, grouped by category with A2UI catalog IDs and brief descriptions.
control: A2UI Supported Components
platform: MAUI
documentation: ug
---

# Supported Syncfusion® A2UI Components for .NET MAUI

The Syncfusion® A2UI for .NET MAUI package includes **56 Syncfusion® .NET MAUI adapters** and **18 A2UI primitives** in one A2UI v0.9 catalog.

An agent can send these adapters in `createSurface` or `updateComponents` messages. `A2uiSurface` renders them through `SurfaceHost`. Use the exact adapter ID from this page in the payload's `component` property. Supported properties and events vary by adapter.

See [Getting Started](./getting-started) to register the catalog and render a surface. The Composer sample shows how to author and preview A2UI messages.

## Data and collections

| Component ID | Description |
| --- | --- |
| `SyncfusionDataGrid` | Data grid for tabular rows, sorting, filtering, grouping, editing, and selection. |
| `SyncfusionTreeMap` | Hierarchical treemap for quantitative data. |
| `SyncfusionTreeView` | Hierarchical data with expansion and selection. |
| `SyncfusionListView` | Data-bound list with item sizing, separators, and selection. |
| `SyncfusionDataForm` | Data-driven form layout and editor generation. |

## Charts and progress

| Component ID | Description |
| --- | --- |
| `SyncfusionCartesianChart` | Cartesian chart with line, column, bar, and area series. |
| `SyncfusionPieChart` | Pie or doughnut chart for proportional data. |
| `SyncfusionLinearProgressBar` | Linear determinate or indeterminate progress. |
| `SyncfusionCircularProgressBar` | Circular determinate or indeterminate progress. |
| `SyncfusionStepProgressBar` | Progress across ordered steps. |

## Sliders and range controls

| Component ID | Description |
| --- | --- |
| `SyncfusionSlider` | Single-value slider. |
| `SyncfusionRangeSlider` | Minimum and maximum value slider. |
| `SyncfusionRangeSelector` | Range selector with a chart-style selection surface. |
| `SyncfusionDateTimeSlider` | Slider for a date-time value. |
| `SyncfusionDateTimeRangeSlider` | Slider for a date-time range. |
| `SyncfusionDateTimeRangeSelector` | Range selector for date-time data. |

## Inputs and pickers

| Component ID | Description |
| --- | --- |
| `SyncfusionTextInputLayout` | Input container with label, helper text, error, and visual states. |
| `SyncfusionNumericEntry` | Numeric input with formatting and value constraints. |
| `SyncfusionMaskedEntry` | Input constrained by a mask pattern. |
| `SyncfusionComboBox` | Searchable single-selection input with editable text support. |
| `SyncfusionPicker` | Selecting an item from a list. |
| `SyncfusionAutocomplete` | Type-ahead input with filtered suggestions. |
| `SyncfusionColorPicker` | Color selection control. |
| `SyncfusionRating` | Symbol or star rating input with read-only support. |
| `SyncfusionChipGroup` | Chip collection for choice, filter, or action states. |

## Calendar and scheduling

| Component ID | Description |
| --- | --- |
| `SyncfusionCalendar` | Calendar view for date selection. |
| `SyncfusionDatePicker` | Date selection input. |
| `SyncfusionDateTimePicker` | Date and time selection input. |
| `SyncfusionTimePicker` | Time-only selection input. |
| `SyncfusionScheduler` | Day, Week, Month, Agenda, and Timeline views. |

## Buttons and selection

| Component ID | Description |
| --- | --- |
| `SyncfusionButton` | Button with styling and action dispatch. |
| `SyncfusionCheckBox` | Boolean checkbox input. |
| `SyncfusionRadioButton` | Single-choice radio input. |
| `SyncfusionSwitch` | Boolean on/off switch. |
| `SyncfusionSegmented` | Segmented single-selection control. |

## Content and navigation

| Component ID | Description |
| --- | --- |
| `SyncfusionToolbar` | Toolbar containing configured action items. |
| `SyncfusionTabView` | Tabbed content layout. |
| `SyncfusionNavigationDrawer` | Navigation drawer with content and drawer states. |
| `SyncfusionPopup` | Popup content surface. |
| `SyncfusionCarousel` | Swipeable carousel of content. |
| `SyncfusionRotator` | Rotating or swipeable content presentation. |
| `SyncfusionCardView` | Card with content and visual styling. |
| `SyncfusionCardLayout` | Card-oriented layout container. |

## Editors

| Component ID | Description |
| --- | --- |
| `SyncfusionRichTextEditor` | Rich text editing surface. |
| `SyncfusionImageEditor` | Image editing surface. |

## Indicators and decorative controls

| Component ID | Description |
| --- | --- |
| `SyncfusionBadgeView` | Badge content over a target view. |
| `SyncfusionAvatarView` | Avatar with initials, image, shape, and size options. |
| `SyncfusionShimmer` | Loading placeholder effect. |
| `SyncfusionBusyIndicator` | Busy or loading indicator. |
| `SyncfusionEffectsView` | Visual effects applied to hosted content. |

## Maps, gauges, and utilities

| Component ID | Description |
| --- | --- |
| `SyncfusionMaps` | Geographic map with shape data, markers, bubbles, labels, and legends. |
| `SyncfusionLinearGauge` | Linear gauge for numeric ranges and indicators. |
| `SyncfusionDigitalGauge` | Digital gauge for numeric or textual display. |
| `SyncfusionRadialGauge` | Radial gauge with scales, pointers, ranges, and annotations. |
| `SyncfusionPdfViewer` | PDF viewing surface. |
| `SyncfusionBarcodeGenerator` | One-dimensional and two-dimensional barcode generation. |

## A2UI primitives

The combined catalog also includes these 18 renderer-independent primitives: `Text`, `Image`, `Icon`, `Video`, `AudioPlayer`, `Row`, `Column`, `List`, `Card`, `Tabs`, `Modal`, `Divider`, `Button`, `TextField`, `CheckBox`, `ChoicePicker`, `Slider`, and `DateTimeInput`.

These primitives can be composed with Syncfusion® adapters in the same surface. Use a unique component `id` for every component instance.

## See also

- [Overview](./overview)
- [Getting Started](./getting-started)
- [A2UI v0.9 protocol](https://a2ui.org/specification/v0.9-a2ui/)
