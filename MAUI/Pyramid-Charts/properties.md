---
layout: post
title: Properties of .NET MAUI Pyramid Chart control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Pyramid Chart (SfPyramidChart) control.
platform: maui
control: SfPyramidChart
documentation: ug
---

# API Reference for .NET MAUI Pyramid Chart

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PyramidDataLabelSettings.html" aria-label="View PyramidDataLabelSettings type in API reference">PyramidDataLabelSettings</a></td>
<td>Controls the <code>position</code> and <code>appearance</code> of pyramid-segment <code>data labels</code>. Data labels must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays <code>information</code> about a pyramid <code>segment</code> when the user <code>taps</code> it or <code>hovers</code> over it with a pointer.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_GapRatio" aria-label="View GapRatio property in API reference">GapRatio</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the spacing between adjacent pyramid <code>segments</code> using a value from <code>0</code> to <code>1</code>; higher values create larger <code>gaps</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Supplies the <code>collection</code> of <code>data items</code> from which the chart creates its pyramid <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard data-label appearance</code> with custom visual content. Data labels must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_LegendIcon" aria-label="View LegendIcon property in API reference">LegendIcon</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">ChartLegendIconType</a></td>
<td>Selects the symbol used for pyramid-segment <code>legend items</code>: <code>Circle</code>, <code>Cross</code>, <code>Diamond</code>, <code>Hexagon</code>, <code>HorizontalLine</code>, <code>InvertedTriangle</code>, <code>Pentagon</code>, <code>Plus</code>, <code>Rectangle</code>, <code>SeriesType</code>, <code>Triangle</code>, or <code>VerticalLine</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_Mode" aria-label="View Mode property in API reference">Mode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PyramidMode.html" aria-label="View PyramidMode type in API reference">PyramidMode</a></td>
<td>Controls how values determine segment <code>size</code>: <code>Linear</code> makes segment <code>width</code> proportional to its value, while <code>Surface</code> uses the <code>square root</code> of the value to determine segment <code>area</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartOrientation.html" aria-label="View ChartOrientation type in API reference">ChartOrientation</a></td>
<td>Displays the pyramid from <code>top to bottom</code> with <code>Vertical</code> or from <code>left to right</code> with <code>Horizontal</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
<td>Applies an <code>ordered set</code> of <code>solid</code> or <code>gradient brushes</code> across the pyramid <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a <code>brush-valued field</code> in each bound <code>data item</code> to the color of its corresponding pyramid <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html" aria-label="View DataPointSelectionBehavior type in API reference">DataPointSelectionBehavior</a></td>
<td>Enables and configures <code>selection</code> of one or more pyramid <code>segments</code>, including the <code>selection mode</code> and <code>highlight brush</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Displays a <code>data label</code> for each pyramid <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Applies a <code>brush</code> to the <code>outline</code> of every pyramid <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the <code>thickness</code> of the <code>outline</code> drawn around every pyramid <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the <code>standard tooltip appearance</code> with custom visual content. <code>Tooltips</code> must also be enabled on the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a field in each bound <code>data item</code> to the segment's <code>category</code>, which is also used as its <code>legend text</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPyramidChart.html#Syncfusion_Maui_Charts_SfPyramidChart_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Maps a <code>numeric field</code> in each bound <code>data item</code> to the <code>value</code> used by the selected <code>Mode</code> to size the corresponding pyramid <code>segment</code>.</td>
</tr>

</table>