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
<td>Defines the settings used to display data labels and controls how label content, placement, and appearance are applied to funnel segments.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether tooltips are displayed and controls whether segment details are shown during chart interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_GapRatio" aria-label="View GapRatio property in API reference">GapRatio</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the gap ratio between funnel segments and controls the spacing that separates each section of the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Defines the data source used to populate the funnel chart and supplies the collection rendered as funnel segments.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to display data labels and enables custom formatting for label content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">LegendIcon</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_LegendIcon" aria-label="View LegendIcon property in API reference">ChartLegendIconType</a></td>
<td>Defines the icon displayed for chart items in the legend by using the <code>ChartLegendIconType</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartOrientation.html" aria-label="View ChartOrientation type in API reference">Orientation</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_Orientation" aria-label="View Orientation property in API reference">ChartOrientation</a></td>
<td>Defines the orientation of the funnel chart by using the <code>ChartOrientation</code> enum and controls whether the funnel is rendered vertically or horizontally.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;T&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
<td>Defines the collection of brushes used to render chart segments and supplies the palette applied across the funnel layers.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to apply individual segment colors and identifies the source field mapped to each point color.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html" aria-label="View ChartSelectionBehavior type in API reference">ChartSelectionBehavior</a></td>
<td>Defines the selection behavior applied to chart segments by using the <code>ChartSelectionBehavior</code> enum and controls how selected slices are highlighted.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether data labels are displayed and controls the visibility of label text on the funnel segments.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the border brush used for chart segments and controls the outline color drawn around each funnel section.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the border width of chart segments and controls the thickness of the outline around each funnel slice.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to display tooltips and enables custom visual content for hover or tap feedback.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to map x-values and identifies the source field that supplies the category or label data.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfFunnelChart.html#Syncfusion_Maui_Charts_SfFunnelChart_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to map y-values and identifies the source field that supplies the numerical value for each segment.</td>
</tr>

</table>
