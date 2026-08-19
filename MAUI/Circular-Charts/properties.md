---
layout: post
title: Properties of .NET MAUI Circular Chart control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Circular Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# API Reference for .NET MAUI Circular Chart

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series" aria-label="View Series property in API reference">Series</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeriesCollection.html" aria-label="View ChartSeriesCollection type in API reference">ChartSeriesCollection</a></td>
<td>Defines the <code>pie</code> and <code>doughnut series</code> rendered in the circular chart, with each series visualizing the <code>proportions</code> of its configured <code>data points</code>.</td>
</tr>

</table>

## Methods

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_AnimateSeries" aria-label="View AnimateSeries method in API reference">AnimateSeries()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Starts the configured <code>animation</code> for each visible series in the circular chart.</td>
</tr>

</table>

## Chart Series

### Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableAnimation" aria-label="View EnableAnimation property in API reference">EnableAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Animates the series when the chart is initially rendered.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays <code>information</code> about a circular chart <code>segment</code> when the user <code>taps</code> it or <code>hovers</code> over it with a pointer.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill" aria-label="View Fill property in API reference">Fill</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Applies a <code>brush</code> to the rendered series shapes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the series in the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend" aria-label="View IsVisibleOnLegend property in API reference">IsVisibleOnLegend</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the <code>legend items</code> generated for the series when a chart <code>legend</code> is configured.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Supplies the <code>collection</code> of <code>data items</code> from which the series creates its <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelContext" aria-label="View LabelContext property in API reference">LabelContext</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelContext.html" aria-label="View LabelContext type in API reference">LabelContext</a></td>
<td>Chooses whether each data label displays the segment's <code>YValue</code> or its <code>Percentage</code> of the series total. <code>Percentage</code> is recommended for <code>pie</code> and <code>doughnut series</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard data-label appearance</code> with custom visual content. Data labels must also be enabled for the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon" aria-label="View LegendIcon property in API reference">LegendIcon</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">ChartLegendIconType</a></td>
<td>Selects the symbol used for associated <code>legend items</code>: <code>Circle</code>, <code>Cross</code>, <code>Diamond</code>, <code>Hexagon</code>, <code>HorizontalLine</code>, <code>InvertedTriangle</code>, <code>Pentagon</code>, <code>Plus</code>, <code>Rectangle</code>, <code>SeriesType</code>, <code>Triangle</code>, or <code>VerticalLine</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ListenPropertyChange" aria-label="View ListenPropertyChange property in API reference">ListenPropertyChange</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Refreshes the series automatically when relevant properties of bound <code>data items</code> change. Enabling it can reduce performance during bulk or rapid <code>data updates</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Opacity" aria-label="View Opacity property in API reference">Opacity</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls series transparency from <code>0</code> for fully transparent to <code>1</code> for fully opaque.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
<td>Applies an <code>ordered set</code> of <code>brushes</code> across the series <code>segments</code>, allowing each segment to use a distinct <code>color</code> or <code>gradient</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a <code>brush-valued field</code> in each bound <code>data item</code> to the color of its corresponding <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html" aria-label="View DataPointSelectionBehavior type in API reference">DataPointSelectionBehavior</a></td>
<td>Enables and configures <code>selection</code> of one or more circular chart <code>segments</code>, including the <code>selection mode</code> and <code>highlight brush</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays a <code>label</code> for each series <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard tooltip appearance</code> with custom visual content. <code>Tooltips</code> must also be enabled for the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a field in each bound <code>data item</code> to the segment's <code>category value</code>, which is also used as the corresponding <code>legend text</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XRange" aria-label="View XRange property in API reference">XRange</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
<td>Provides the calculated <code>minimum</code> and <code>maximum X-values</code> represented by the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_YRange" aria-label="View YRange property in API reference">YRange</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
<td>Provides the calculated <code>minimum</code> and <code>maximum Y-values</code> represented by the series.</td>
</tr>

</table>

### Methods

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_CreateAnimation_System_Action_System_Double__" aria-label="View CreateAnimation method in API reference">CreateAnimation(Action&lt;double&gt;)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Creates the series <code>animation</code> that supplies <code>progress values</code> to the specified <code>callback</code>. This is a <code>protected method</code> intended for custom series implementations.</td>
</tr>

</table>