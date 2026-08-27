---
layout: post
title: Axis in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members for Axis in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Axis API Reference for .NET MAUI Cartesian Chart

This page lists the public properties, methods, and events of chart axes, axis labels, ticks, titles, and multi-level labels.

<table>
<tr>
    <th>Class</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CategoryAxis.html" aria-label="View CategoryAxis class in API reference">CategoryAxis</a></td>
    <td>Four members declared by <code>CategoryAxis</code>, including <code>Interval</code>, <code>LabelPlacement</code> (between or on ticks), <code>LabelRotation</code>, and the <code>categorical item-source path mapping</code>. Use this axis to plot data along <code>discrete categories</code>, where each label corresponds to a <code>category name</code> rather than a <code>numeric value</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html" aria-label="View ChartAxis class in API reference">ChartAxis</a></td>
    <td>Thirty-nine members declared by <code>ChartAxis</code>, the <code>abstract base class</code> for every axis type. Covers common axis appearance and behavior: <code>title</code>, <code>labels</code> (style, rotation, format, custom template), <code>ticks</code>, <code>gridlines</code>, <code>axis lines</code>, <code>crosshair</code>, <code>zoom factor</code> and <code>position</code>, <code>label create</code>, <code>range calculations</code>, <code>IsVisible</code>, <code>IsInversed</code>, <code>PlotOffset</code>, <code>EdgeLabelsDrawingMode</code>, <code>BreakStripe</code>, and <code>event handlers</code>. The shared configuration surface for every axis on the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisLabel.html" aria-label="View ChartAxisLabel class in API reference">ChartAxisLabel</a></td>
    <td>Three members declared by <code>ChartAxisLabel</code>, the <code>per-label data object</code> used by axis events such as <code>LabelCreated</code> and <code>LabelDrawing</code>. Includes the <code>label text</code>, <code>position</code>, and <code>content view</code>. Use it to customize a specific axis label at <code>render time</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxisTitle.html" aria-label="View ChartAxisTitle class in API reference">ChartAxisTitle</a></td>
    <td>One member declared by <code>ChartAxisTitle</code>, the <code>text content</code> of the axis title (a <code>Text</code> property), inheriting all the <code>visual styling</code> from <code>ChartLabelStyle</code> (text color, size, font, margin, background, etc.). Use it to <code>label the entire axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartMultiLevelLabel.html" aria-label="View ChartMultiLevelLabel class in API reference">ChartMultiLevelLabel</a></td>
    <td>Four members declared by <code>ChartMultiLevelLabel</code>, including <code>Start</code>, <code>End</code>, <code>Text</code>, and <code>Level</code>. Use these <code>stacked labels</code> to display <code>categorized labels</code> on a <code>range axis</code>, for example, to <code>group</code> months into quarters or values into ranges.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeAxis.html" aria-label="View DateTimeAxis class in API reference">DateTimeAxis</a></td>
    <td>Nine members declared by <code>DateTimeAxis</code>, including <code>Interval</code>, <code>IntervalType</code> (years, months, days, hours, minutes, seconds), <code>RangePadding</code>, <code>Minimum</code>, <code>Maximum</code>, <code>AutoScrollingDeltaType</code>/<code>Delta</code>, and <code>AutoScrollingDeltaMode</code>. Use this axis to plot data along a <code>calendar-time continuous range</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DateTimeCategoryAxis.html" aria-label="View DateTimeCategoryAxis class in API reference">DateTimeCategoryAxis</a></td>
    <td>Three members declared by <code>DateTimeCategoryAxis</code>, including the <code>timeline binding path</code> mapping, the <code>interval type</code>, and the <code>range</code>/<code>interval</code> between displayed categories. Use this axis to plot categories whose values are <code>calendar times</code> (such as months or years) along a <code>categorical layout</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LogarithmicAxis.html" aria-label="View LogarithmicAxis class in API reference">LogarithmicAxis</a></td>
    <td>Seven members declared by <code>LogarithmicAxis</code>, including <code>LogBase</code> (commonly 10, 2, or e), <code>Interval</code>, <code>range padding</code>, <code>minimum</code>, <code>maximum</code>, and <code>minor tick visibility</code>. Use this axis to plot data spanning several <code>orders of magnitude</code> on a compressed <code>log scale</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.NumericalAxis.html" aria-label="View NumericalAxis class in API reference">NumericalAxis</a></td>
    <td>Seven members declared by <code>NumericalAxis</code>, including <code>Interval</code>, <code>RangePadding</code>, <code>Minimum</code>, <code>Maximum</code>, <code>StartAngle</code>, <code>SweepDirection</code> (used in polar/circular scenarios, but kept here for shared configuration), and <code>LabelFormat</code>. Use this axis to plot data along a <code>continuous numeric range</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html" aria-label="View RangeAxisBase class in API reference">RangeAxisBase</a></td>
    <td>Five members declared by <code>RangeAxisBase</code>, the <code>abstract base class</code> for axes that plot along a <code>continuous numeric</code> or <code>date-time range</code>. Includes <code>Minimum</code>, <code>Maximum</code>, <code>RangePadding</code> (additional, round, none, auto, normal), <code>Interval</code>, and <code>AutoScrollingDelta</code>. Provides the common <code>range-based options</code> used by <code>NumericalAxis</code>, <code>LogarithmicAxis</code>, and <code>DateTimeAxis</code>.</td>
</tr>
</table>
