---
layout: post
title: Series in .NET MAUI Cartesian Chart | Syncfusion®
description: This section lists the public API members for series in the Syncfusion® .NET MAUI Cartesian Chart (SfCartesianChart).
platform: maui
control: SfCartesianChart
documentation: ug
---

# Series API Reference in .NET MAUI Cartesian Chart

This page lists the public properties, methods, and events of the series base classes and every Cartesian series type.

<table>
<tr>
    <th>Class</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="area-series" aria-label="View AreaSeries class in API reference">AreaSeries</a></td>
    <td>Five members declared by <code>AreaSeries</code> itself, covering the <code>area-specific rendering</code> options such as the <code>alpha</code> (transparency) overlay, <code>stroke</code> settings, and <code>border appearance</code> that distinguish filled areas from simple lines. The type-specific members are added on top of those inherited from <code>XYDataSeries</code>, <code>CartesianSeries</code>, and <code>ChartSeries</code>.</td>
</tr>

<tr valign="top">
    <td><a href="box-and-whisker-series" aria-label="View BoxAndWhiskerSeries class in API reference">BoxAndWhiskerSeries</a></td>
    <td>Seven members declared by <code>BoxAndWhiskerSeries</code>, covering the <code>box</code>, <code>whisker</code>, and <code>outlier</code> rendering such as <code>box mode</code>, <code>whisker style</code>, <code>outlier visibility</code>, and <code>median line appearance</code>. The type-specific members extend the standard <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="bubble-series" aria-label="View BubbleSeries class in API reference">BubbleSeries</a></td>
    <td>Five members declared by <code>BubbleSeries</code>, covering <code>bubble-specific rendering</code> such as the <code>size mapping path</code>, <code>minimum</code> and <code>maximum size constraints</code>, and <code>shape customization</code>. The type-specific members are added on top of the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="candle-series" aria-label="View CandleSeries class in API reference">CandleSeries</a></td>
    <td>Two members declared by <code>CandleSeries</code>, covering the <code>bull-and-bear fill colors</code> used to distinguish <code>rising</code> and <code>falling candlesticks</code>. The type-specific members are added on top of those inherited from <code>HiLoOpenCloseSeries</code>, <code>FinancialSeriesBase</code>, <code>CartesianSeries</code>, and <code>ChartSeries</code>.</td>
</tr>

<tr valign="top">
    <td><a href="column-series" aria-label="View ColumnSeries class in API reference">ColumnSeries</a></td>
    <td>Four members declared by <code>ColumnSeries</code>, covering the <code>column-specific layout</code> options such as <code>width</code>, <code>spacing</code>, and <code>corner radius</code> of each column. The type-specific members are added on top of the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="errorbar-series" aria-label="View ErrorBarSeries class in API reference">ErrorBarSeries</a></td>
    <td>Twelve members declared by <code>ErrorBarSeries</code>, covering the <code>error bar</code> appearance and direction: <code>horizontal versus vertical mode</code>, <code>type</code> (<code>fixed</code>, <code>percentage</code>, <code>standard deviation</code>, <code>custom</code>), <code>cap stroke</code>, <code>line stroke</code>, and <code>visibility</code>. The type-specific members extend the standard <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="fastline-series" aria-label="View FastLineSeries class in API reference">FastLineSeries</a></td>
    <td>Three members declared by <code>FastLineSeries</code>, covering <code>high-performance rendering</code> options such as enable/disable of <code>segments caching</code>, <code>geometry simplification</code>, and <code>pixel-snapping</code> for large data sets. The type-specific members are added on top of the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="fastscatter-series" aria-label="View FastScatterSeries class in API reference">FastScatterSeries</a></td>
    <td>Five members declared by <code>FastScatterSeries</code>, covering <code>high-performance scatter</code> options such as <code>pixel-snapping</code>, <code>shape type</code>, and <code>shape size tuning</code> for large data sets. The type-specific members are added on top of the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="histogram-series" aria-label="View HistogramSeries class in API reference">HistogramSeries</a></td>
    <td>Four members declared by <code>HistogramSeries</code>, covering the <code>histogram distribution</code> rendering: <code>bin interval</code>, <code>distribution type</code> (<code>normal</code>, <code>uniform</code>, <code>custom</code>), <code>show-normal-curve toggle</code>, and <code>bin-count</code>. The type-specific members extend the standard <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="line-series" aria-label="View LineSeries class in API reference">LineSeries</a></td>
    <td>Three members declared by <code>LineSeries</code>, covering the <code>line-specific stroke styling</code> such as <code>dashes</code>, <code>gap drawing behavior</code>, and <code>smoothing</code>. The type-specific members are added on top of the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="range-area-series" aria-label="View RangeAreaSeries class in API reference">RangeAreaSeries</a></td>
    <td>Three members declared by <code>RangeAreaSeries</code>, covering the <code>filled area rendering</code> between <code>low</code> and <code>high values</code> such as <code>alpha</code>, <code>border settings</code>, and <code>smoothing mode</code>. The type-specific members extend the <code>range</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="range-column-series" aria-label="View RangeColumnSeries class in API reference">RangeColumnSeries</a></td>
    <td>Three members declared by <code>RangeColumnSeries</code>, covering the <code>floating-column rendering</code> between <code>low</code> and <code>high values</code> such as <code>width</code>, <code>spacing</code>, and <code>corner radius</code>. The type-specific members extend the <code>range</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="scatter-series" aria-label="View ScatterSeries class in API reference">ScatterSeries</a></td>
    <td>Four members declared by <code>ScatterSeries</code>, covering the <code>marker appearance</code> such as <code>shape</code>, <code>fill</code>, <code>stroke</code>, and <code>width</code>. The type-specific members extend the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="splinerange-area-series" aria-label="View SplineRangeAreaSeries class in API reference">SplineRangeAreaSeries</a></td>
    <td>Four members declared by <code>SplineRangeAreaSeries</code>, covering <code>spline-specific tension</code> or <code>smoothing control</code> of the <code>high</code> and <code>low boundary curves</code>, plus the <code>area alpha</code>. The type-specific members extend the <code>range</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="spline-series" aria-label="View SplineSeries class in API reference">SplineSeries</a></td>
    <td>Four members declared by <code>SplineSeries</code>, covering <code>spline-specific tension</code> or <code>smoothing control</code> of the curve and related <code>geometry tuning</code>. The type-specific members extend the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="stacking-area-series" aria-label="View StackingAreaSeries class in API reference">StackingAreaSeries</a></td>
    <td>Three members declared by <code>StackingAreaSeries</code>, covering <code>stacking-specific rendering</code> such as <code>grouping label</code>, <code>area stroke</code>, and <code>dash pattern</code>. The type-specific members extend the <code>stacking</code>, <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="stacking-column-series" aria-label="View StackingColumnSeries class in API reference">StackingColumnSeries</a></td>
    <td>Three members declared by <code>StackingColumnSeries</code>, covering the <code>stacking-specific column rendering</code>: <code>Width</code>, <code>Spacing</code>, and <code>CornerRadius</code>. The type-specific members extend the <code>stacking</code>, <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="stackingline-series" aria-label="View StackingLineSeries class in API reference">StackingLineSeries</a></td>
    <td>Two members declared by <code>StackingLineSeries</code>, covering <code>marker visibility</code> (<code>ShowMarkers</code>) and <code>marker styling</code> (<code>MarkerSettings</code>). The type-specific members extend the <code>stacking</code>, <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

<tr valign="top">
    <td><a href="waterfall-series" aria-label="View WaterfallSeries class in API reference">WaterfallSeries</a></td>
    <td>Eight members declared by <code>WaterfallSeries</code>, covering <code>waterfall-specific rendering</code>: <code>AllowAutoSum</code>, <code>ConnectorLineStyle</code>, <code>NegativePointsBrush</code>, <code>ShowConnectorLine</code>, <code>Spacing</code>, <code>SummaryBindingPath</code>, <code>SummaryPointsBrush</code>, and <code>Width</code>. The type-specific members extend the <code>XY</code>, <code>cartesian</code>, and <code>chart base</code> members.</td>
</tr>

</table>
