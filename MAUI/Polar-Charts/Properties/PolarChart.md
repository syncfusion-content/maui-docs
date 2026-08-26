---
layout: post
title: Chart in .NET MAUI Polar Chart | Syncfusion®
description: This section lists the public API members of the SfPolarChart control and its ChartBase base class available in the Syncfusion® .NET MAUI Polar Chart (SfPolarChart) API.
platform: maui
control: SfPolarChart
documentation: ug
---

# Polar Chart API in .NET MAUI Polar Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Applies the Liquid Glass visual effect to the chart when supported by the platform. Supported on iOS and macOS. The default value is false.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_GridLineType" aria-label="View GridLineType property in API reference">GridLineType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.PolarChartGridLineType.html" aria-label="View PolarChartGridLineType type in API reference">PolarChartGridLineType</a></td>
    <td>Controls the shape of the chart grid lines, allowing them to be displayed as circular rings or polygonal grids. The default value is <code>Circle</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_InteractiveBehavior" aria-label="View InteractiveBehavior property in API reference">InteractiveBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartInteractiveBehavior.html" aria-label="View ChartInteractiveBehavior type in API reference">ChartInteractiveBehavior</a></td>
    <td>Provides a custom interaction handler for the chart, enabling advanced customization of touch and pointer interactions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend" aria-label="View Legend property in API reference">Legend</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html" aria-label="View ChartLegend type in API reference">ChartLegend</a></td>
    <td>Displays a legend that helps users identify the series shown in the polar chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
    <td>Specifies the collection of brushes used to color chart series. Custom brushes can be provided to override the default chart palette.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_PlotAreaBackgroundView" aria-label="View PlotAreaBackgroundView property in API reference">PlotAreaBackgroundView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Displays custom content behind the chart's plotting area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_PrimaryAxis" aria-label="View PrimaryAxis property in API reference">PrimaryAxis</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAxis.html" aria-label="View ChartAxis type in API reference">ChartAxis</a></td>
    <td>Defines the angular axis used to position data points around the chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_SecondaryAxis" aria-label="View SecondaryAxis property in API reference">SecondaryAxis</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RangeAxisBase.html" aria-label="View RangeAxisBase type in API reference">RangeAxisBase</a></td>
    <td>Defines the radial axis used to position data points based on their values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_Series" aria-label="View Series property in API reference">Series</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartPolarSeriesCollection.html" aria-label="View ChartPolarSeriesCollection type in API reference">ChartPolarSeriesCollection</a></td>
    <td>Contains the collection of series displayed in the polar chart, including polar area and polar line series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfPolarChart.html#Syncfusion_Maui_Charts_SfPolarChart_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartPolarAngle.html" aria-label="View ChartPolarAngle type in API reference">ChartPolarAngle</a></td>
    <td>Controls the angle at which the polar chart begins rendering, allowing the chart to be rotated to a different starting orientation. The default value is <code>Rotate270</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SeriesBounds" aria-label="View SeriesBounds property in API reference">SeriesBounds</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.rect" aria-label="View Rect type in API reference">Rect</a></td>
    <td>Provides the actual area occupied by the rendered chart series after layout is completed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Title" aria-label="View Title property in API reference">Title</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
    <td>Displays a title above the chart using either text or a custom view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_TooltipBehavior" aria-label="View TooltipBehavior property in API reference">TooltipBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartTooltipBehavior.html" aria-label="View ChartTooltipBehavior type in API reference">ChartTooltipBehavior</a></td>
    <td>Configures the appearance and behavior of tooltips displayed when users interact with chart data points.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_" aria-label="View GetStreamAsync method in API reference">GetStreamAsync(ImageFileFormat)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">Task&lt;</a><a href="https://learn.microsoft.com/dotnet/api/system.io.stream" aria-label="View Stream type in API reference">Stream</a><a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task" aria-label="View Task type in API reference">&gt;</a></td>
    <td>Converts a chart view to a stream. The supported file formats are JPEG and PNG. To get the stream in PNG format, use <code>await chart.GetStreamAsync(ImageFileFormat.Png)</code>; for JPEG, use <code>await chart.GetStreamAsync(ImageFileFormat.Jpeg)</code>. The chart stream can only be rendered when the chart view is added to the visual tree.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SaveAsImage_System_String_" aria-label="View SaveAsImage method in API reference">SaveAsImage(String)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Saves a chart view as an image. The supported image formats are JPEG and PNG; PNG is the default. Pass the filename with the <code>.png</code> or <code>.jpeg</code> extension to choose the format. Saved location: Pictures folder on Windows, Android, and Mac; Photos Album folder on iOS. The view can be saved as an image only when added to the visual tree.</td>
</tr>
</table>
