---
layout: post
title: Chart in .NET MAUI Circular Chart | Syncfusion®
description: Create interactive circular charts in .NET MAUI to visualize proportional data with customizable appearance, layout, and behavior.
platform: maui
control: SfCircularChart
documentation: ug
---

# Chart API in .NET MAUI Circular Chart

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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_InteractiveBehavior" aria-label="View InteractiveBehavior property in API reference">InteractiveBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartInteractiveBehavior.html" aria-label="View ChartInteractiveBehavior type in API reference">ChartInteractiveBehavior</a></td>
    <td>Provides a custom interaction handler for the chart, enabling advanced customization of touch and pointer interactions.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend" aria-label="View Legend property in API reference">Legend</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegend.html" aria-label="View ChartLegend type in API reference">ChartLegend</a></td>
    <td>Displays a legend that helps users identify series or data points represented in the circular chart.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_PlotAreaBackgroundView" aria-label="View PlotAreaBackgroundView property in API reference">PlotAreaBackgroundView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Displays custom content behind the chart's plotting area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_SeriesBounds" aria-label="View SeriesBounds property in API reference">SeriesBounds</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.rect" aria-label="View Rect type in API reference">Rect</a></td>
    <td>Provides the actual area occupied by the rendered chart series after layout is completed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series" aria-label="View Series property in API reference">Series</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeriesCollection.html" aria-label="View ChartSeriesCollection type in API reference">ChartSeriesCollection</a></td>
    <td>Contains the collection of series displayed in the circular chart, including pie, doughnut, and radial bar series.</td>
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
    <th>Class</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_AnimateSeries" aria-label="View AnimateSeries method in API reference">AnimateSeries()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Plays the animation for all currently visible series. Useful for rerunning chart animations after data is loaded or updated.</td>
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
