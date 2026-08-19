---
layout: post
title: Properties of .NET MAUI Funnel Chart control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Funnel Chart (SfFunnelChart) control.
platform: maui
control: SfFunnelChart
documentation: ug
---

# API Reference for .NET MAUI Funnel Chart

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.FunnelDataLabelSettings.html" aria-label="View FunnelDataLabelSettings type in API reference">FunnelDataLabelSettings</a></td>
<td>Controls the <code>position</code> and <code>appearance</code> of funnel-segment <code>data labels</code>. Data labels must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays <code>information</code> about a funnel <code>segment</code> when the user <code>taps</code> it or <code>hovers</code> over it with a pointer.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_GapRatio" aria-label="View GapRatio property in API reference">GapRatio</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the spacing between adjacent funnel <code>segments</code> using a value from <code>0</code> to <code>1</code>; higher values create larger <code>gaps</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Supplies the <code>collection</code> of <code>data items</code> from which the chart creates its funnel <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard data-label appearance</code> with custom visual content. Data labels must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_LegendIcon" aria-label="View LegendIcon property in API reference">LegendIcon</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">ChartLegendIconType</a></td>
<td>Selects the symbol used for funnel-segment <code>legend items</code>: <code>Circle</code>, <code>Cross</code>, <code>Diamond</code>, <code>Hexagon</code>, <code>HorizontalLine</code>, <code>InvertedTriangle</code>, <code>Pentagon</code>, <code>Plus</code>, <code>Rectangle</code>, <code>SeriesType</code>, <code>Triangle</code>, or <code>VerticalLine</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartOrientation.html" aria-label="View ChartOrientation type in API reference">ChartOrientation</a></td>
<td>Displays the funnel from <code>top to bottom</code> with <code>Vertical</code> or from <code>left to right</code> with <code>Horizontal</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
<td>Applies an <code>ordered set</code> of <code>solid</code> or <code>gradient brushes</code> across the funnel <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a <code>brush-valued field</code> in each bound <code>data item</code> to the color of its corresponding funnel <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html" aria-label="View DataPointSelectionBehavior type in API reference">DataPointSelectionBehavior</a></td>
<td>Enables and configures <code>selection</code> of one or more funnel <code>segments</code>, including the <code>selection mode</code> and <code>highlight brush</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays a <code>data label</code> for each funnel <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Applies a <code>brush</code> to the <code>outline</code> of every funnel <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the <code>thickness</code> of the <code>outline</code> drawn around every funnel <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard tooltip appearance</code> with custom visual content. <code>Tooltips</code> must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a field in each bound <code>data item</code> to the segment's <code>category</code>, which is also used as its <code>legend text</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a <code>numeric field</code> in each bound <code>data item</code> to the <code>value</code> that determines the corresponding funnel segment's <code>size</code>.</td>
</tr>

</table>
