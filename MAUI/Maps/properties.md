---
layout: post
title: Properties of .NET MAUI Maps control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Maps (SfMaps) control.
platform: maui
control: SfMaps
documentation: ug
---

# API Reference for .NET MAUI Maps

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer" aria-label="View Layer property in API reference">Layer</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLayer.html" aria-label="View MapLayer type in API reference">MapLayer</a></td>
    <td>Primary <code>layer</code> used to render the map's geographic content. Configure this to choose how the map is displayed and populated with <code>shapes</code>, <code>data</code>, and <code>marks</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_GetLatLngFromPoint_Microsoft_Maui_Graphics_Point_" aria-label="View GetLatLngFromPoint method in API reference">GetLatLngFromPoint(Point)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLatLng.html" aria-label="View MapLatLng type in API reference">MapLatLng</a></td>
    <td>Converts a screen <code>Point</code> in the <code>shape layer</code> into a geographic <code>latitude</code> and <code>longitude</code>. Useful for <code>hit testing</code> and translating between pixel and map coordinates.</td>
</tr>
</table>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected" aria-label="View ShapeSelected event in API reference">ShapeSelected</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ShapeSelectedEventArgs.html" aria-label="View ShapeSelectedEventArgs type in API reference">&lt;ShapeSelectedEventArgs&gt;</a></a></td>
    <td>Triggered when a map <code>shape</code> is selected or unselected, providing details about the affected shape. Use it to update <code>selection-dependent</code> UI or related data.</td>
</tr>
</table>

## MapShapeLayer Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings" aria-label="View BubbleSettings property in API reference">BubbleSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapBubbleSettings.html" aria-label="View MapBubbleSettings type in API reference">MapBubbleSettings</a></td>
    <td>Defines the <code>bubble</code> configuration used by the shape layer. Controls how bubbles are <code>rendered</code>, bound to <code>data</code>, and <code>animated</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipSettings" aria-label="View BubbleTooltipSettings property in API reference">BubbleTooltipSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html" aria-label="View MapTooltipSettings type in API reference">MapTooltipSettings</a></td>
    <td>Defines how bubble <code>tooltips</code> appear and behave. Controls tooltip <code>position</code>, <code>style</code>, and <code>visibility</code> rules.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipTemplate" aria-label="View BubbleTooltipTemplate property in API reference">BubbleTooltipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Custom template used to render bubble tooltip content. Supports richer <code>layouts</code>, <code>formatted values</code>, and bound <code>data</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings" aria-label="View ColorMappings property in API reference">ColorMappings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html" aria-label="View ColorMapping type in API reference">ObservableCollection&lt;ColorMapping&gt;</a></td>
    <td>Collection of <code>ColorMapping</code> entries used to color shapes based on <code>value ranges</code>. Enables value-driven color grouping across the map.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html" aria-label="View MapDataLabelSettings type in API reference">MapDataLabelSettings</a></td>
    <td>Defines how <code>data labels</code> appear on shapes. Controls label <code>placement</code>, <code>visibility</code>, and <code>style</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource" aria-label="View DataSource property in API reference">DataSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Data source</code> used to bind and populate the layer. Provides items for <code>shapes</code>, <code>bubbles</code>, and <code>labels</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection" aria-label="View EnableSelection property in API reference">EnableSelection</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether shapes in the layer can be <code>selected</code>. When enabled, <code>tap</code> or <code>click</code> selects an individual shape.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Geometry" aria-label="View Geometry property in API reference">Geometry</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapGeometryType.html" aria-label="View MapGeometryType enum in API reference">MapGeometryType</a></td>
    <td>Specifies the <code>geometry type</code> used by the shape source. Choose the appropriate <code>MapGeometryType</code> value, such as <code>Point</code>, <code>Line</code>, or <code>Polygon</code>, to match the loaded map data.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend" aria-label="View Legend property in API reference">Legend</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html" aria-label="View MapLegend type in API reference">MapLegend</a></td>
    <td><code>Legend</code> shown for the layer. Helps explain shape <code>colors</code>, <code>ranges</code>, or categorized <code>values</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath" aria-label="View PrimaryValuePath property in API reference">PrimaryValuePath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Field path used as the <code>primary value</code> when matching shapes to the data source. Required for <code>value-based coloring</code> and <code>lookups</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedItems" aria-label="View SelectedItems property in API reference">SelectedItems</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
    <td>Collection of currently <code>selected shapes</code>. Tracks the active selection and supports <code>multi-selection</code> scenarios.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill" aria-label="View SelectedShapeFill property in API reference">SelectedShapeFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Fill brush</code> applied to selected shapes. Distinct from the default fill to emphasize the selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStroke" aria-label="View SelectedShapeStroke property in API reference">SelectedShapeStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Stroke brush</code> applied to selected shapes. Combines with <code>SelectedShapeFill</code> to outline active shapes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStrokeThickness" aria-label="View SelectedShapeStrokeThickness property in API reference">SelectedShapeStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Thickness</code> of the stroke applied to selected shapes. Higher values create a stronger selection outline.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSelectionMode.html" aria-label="View MapSelectionMode enum in API reference">MapSelectionMode</a></td>
    <td>Determines how <code>shape selection</code> behaves. Choose a supported <code>MapSelectionMode</code> value such as <code>Single</code> or <code>Multiple</code> to control how many shapes can be selected at once.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeColorValuePath" aria-label="View ShapeColorValuePath property in API reference">ShapeColorValuePath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Field path used to determine each shape's <code>color value</code>. Enables <code>value-driven coloring</code> from bound data.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField" aria-label="View ShapeDataField property in API reference">ShapeDataField</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Field from the data source used to <code>match</code> each shape. Required for linking source data to <code>map regions</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeFill" aria-label="View ShapeFill property in API reference">ShapeFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Default <code>fill brush</code> used for map shapes. Provides the base appearance before <code>hover</code> or <code>selection styles</code> are applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverFill" aria-label="View ShapeHoverFill property in API reference">ShapeHoverFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Fill</code> applied when a shape is <code>hovered</code>. Gives clear pointer feedback without changing the selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStroke" aria-label="View ShapeHoverStroke property in API reference">ShapeHoverStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Stroke</code> applied when a shape is <code>hovered</code>. Improves visibility of the hovered region on pointer movement.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStrokeThickness" aria-label="View ShapeHoverStrokeThickness property in API reference">ShapeHoverStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Thickness</code> of the stroke applied to <code>hovered shapes</code>. Larger values make the hover outline more visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource" aria-label="View ShapesSource property in API reference">ShapesSource</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html" aria-label="View MapSource type in API reference">MapSource</a></td>
    <td><code>Source</code> used to load map shapes. Controls where the geographic shape <code>data</code> is retrieved from, such as an <code>embedded file</code> or <code>URI</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStroke" aria-label="View ShapeStroke property in API reference">ShapeStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Default <code>stroke brush</code> for map shapes. Outlines regions and improves map readability.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStrokeThickness" aria-label="View ShapeStrokeThickness property in API reference">ShapeStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Thickness</code> of the default stroke applied to map shapes. Larger values create a stronger regional outline.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipSettings" aria-label="View ShapeTooltipSettings property in API reference">ShapeTooltipSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html" aria-label="View MapTooltipSettings type in API reference">MapTooltipSettings</a></td>
    <td>Defines how shape <code>tooltips</code> appear and behave. Controls <code>visibility</code>, <code>placement</code>, and <code>styling rules</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipTemplate" aria-label="View ShapeTooltipTemplate property in API reference">ShapeTooltipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Custom template used to render shape tooltip content. Supports richer <code>layouts</code> and formatted <code>properties</code> for each shape.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbles" aria-label="View ShowBubbles property in API reference">ShowBubbles</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether bubbles are <code>displayed</code> on shapes. Use this to overlay an additional <code>value layer</code> on the map.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbleTooltip" aria-label="View ShowBubbleTooltip property in API reference">ShowBubbleTooltip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether bubble tooltips appear on <code>hover</code> or <code>tap</code>. Helps present bubble-specific details without cluttering the map.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether data labels are <code>displayed</code> on the map. Useful for showing <code>names</code>, <code>values</code>, or other <code>annotations</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip" aria-label="View ShowShapeTooltip property in API reference">ShowShapeTooltip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether shape tooltips appear on <code>hover</code> or <code>tap</code>. Helps expose <code>shape-specific</code> details interactively.</td>
</tr>
</table>
