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
    <td>Defines the primary <code>MapLayer</code> used to render geographic content. Controls how the map is displayed and populated.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_GetLatLngFromPoint_Microsoft_Maui_Graphics_Point_" aria-label="View GetLatLngFromPoint method in API reference">GetLatLngFromPoint(Point)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLatLng.html" aria-label="View MapLatLng type in API reference">MapLatLng</a></td>
    <td>Converts a screen <code>Point</code> into a geographic <code>latitude</code> and <code>longitude</code>. Useful for hit testing and coordinate translation.</td>
</tr>
</table>

### Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected" aria-label="View ShapeSelected event in API reference">ShapeSelected</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ShapeSelectedEventArgs.html" aria-label="View ShapeSelectedEventArgs type in API reference">EventHandler&lt;ShapeSelectedEventArgs&gt;</a></td>
    <td>Raised when a map <code>shape</code> is selected or unselected. Useful for updating selection-dependent UI or related data.</td>
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
    <td>Defines the bubble configuration used by the shape layer. Controls bubble appearance, data binding, and behavior.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipSettings" aria-label="View BubbleTooltipSettings property in API reference">BubbleTooltipSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html" aria-label="View MapTooltipSettings type in API reference">MapTooltipSettings</a></td>
    <td>Defines the tooltip settings for bubbles. Controls how bubble tooltips appear and behave.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipTemplate" aria-label="View BubbleTooltipTemplate property in API reference">BubbleTooltipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render bubble tooltip content. Supports custom <code>layout</code> and formatted text.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings" aria-label="View ColorMappings property in API reference">ColorMappings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.ColorMapping.html" aria-label="View ColorMapping type in API reference">ObservableCollection&lt;ColorMapping&gt;</a></td>
    <td>Stores the collection of <code>ColorMapping</code> entries used to color shapes. Enables value-based color ranges and visual grouping.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapDataLabelSettings.html" aria-label="View MapDataLabelSettings type in API reference">MapDataLabelSettings</a></td>
    <td>Defines the settings for map data labels. Controls label placement, visibility, and style.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource" aria-label="View DataSource property in API reference">DataSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Provides the data used to bind and populate the layer. Acts as the source for shape, bubble, and label content.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection" aria-label="View EnableSelection property in API reference">EnableSelection</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether shape <code>selection</code> is enabled. Allows tap-based highlighting of individual map shapes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Geometry" aria-label="View Geometry property in API reference">Geometry</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapGeometryType.html" aria-label="View MapGeometryType enum in API reference">MapGeometryType</a></td>
    <td>Specifies the geometry type used by the shape source. Use the appropriate <code>MapGeometryType</code> value for the loaded map data.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend" aria-label="View Legend property in API reference">Legend</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapLegend.html" aria-label="View MapLegend type in API reference">MapLegend</a></td>
    <td>Defines the legend shown for the layer. Helps explain shape colors, ranges, or categorized values.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath" aria-label="View PrimaryValuePath property in API reference">PrimaryValuePath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Specifies the field path used as the primary value for matching shapes. Used during data binding and value lookup.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedItems" aria-label="View SelectedItems property in API reference">SelectedItems</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
    <td>Contains the collection of currently selected shapes. Supports multi-selection scenarios and state tracking.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill" aria-label="View SelectedShapeFill property in API reference">SelectedShapeFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the fill applied to a selected shape. Used to visually distinguish active map regions.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStroke" aria-label="View SelectedShapeStroke property in API reference">SelectedShapeStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the stroke applied to a selected shape. Works together with <code>SelectedShapeFill</code> for emphasis.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStrokeThickness" aria-label="View SelectedShapeStrokeThickness property in API reference">SelectedShapeStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Sets the stroke thickness for selected shapes. Larger values create a stronger selection outline.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSelectionMode.html" aria-label="View MapSelectionMode enum in API reference">MapSelectionMode</a></td>
    <td>Defines how shape selection behaves. Use the appropriate <code>MapSelectionMode</code> value for single or multiple selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeColorValuePath" aria-label="View ShapeColorValuePath property in API reference">ShapeColorValuePath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Specifies the field path used to determine shape color values. Enables value-driven coloring from bound data.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField" aria-label="View ShapeDataField property in API reference">ShapeDataField</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the data field used to match each shape. Required for linking source data to map shapes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeFill" aria-label="View ShapeFill property in API reference">ShapeFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the default fill used for map shapes. Provides the base appearance before interaction states are applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverFill" aria-label="View ShapeHoverFill property in API reference">ShapeHoverFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the fill applied when a shape is hovered. Helps provide clear pointer feedback.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStroke" aria-label="View ShapeHoverStroke property in API reference">ShapeHoverStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the stroke shown when a shape is hovered. Improves interaction visibility on pointer movement.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStrokeThickness" aria-label="View ShapeHoverStrokeThickness property in API reference">ShapeHoverStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Sets the stroke thickness used for hovered shapes. Makes hover feedback more noticeable on the map.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource" aria-label="View ShapesSource property in API reference">ShapesSource</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapSource.html" aria-label="View MapSource type in API reference">MapSource</a></td>
    <td>Defines the source used to load map shapes. Controls where the geographical shape data is retrieved from.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStroke" aria-label="View ShapeStroke property in API reference">ShapeStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the default stroke for map shapes. Used to outline regions and improve map readability.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStrokeThickness" aria-label="View ShapeStrokeThickness property in API reference">ShapeStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the stroke thickness for map shapes. Higher values create a stronger region outline.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipSettings" aria-label="View ShapeTooltipSettings property in API reference">ShapeTooltipSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapTooltipSettings.html" aria-label="View MapTooltipSettings type in API reference">MapTooltipSettings</a></td>
    <td>Defines the tooltip settings for shapes. Controls tooltip visibility, placement, and behavior.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipTemplate" aria-label="View ShapeTooltipTemplate property in API reference">ShapeTooltipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render shape tooltip content. Supports richer tooltip layouts and formatting.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbles" aria-label="View ShowBubbles property in API reference">ShowBubbles</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether bubbles are shown for shapes. Useful for visualizing additional values on the map.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbleTooltip" aria-label="View ShowBubbleTooltip property in API reference">ShowBubbleTooltip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether bubble tooltips are displayed. Helps present detailed information on hover or tap.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether data labels are shown on the map. Useful for displaying names, values, or annotations.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip" aria-label="View ShowShapeTooltip property in API reference">ShowShapeTooltip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether shape tooltips are displayed. Helps expose shape-specific details interactively.</td>
</tr>
</table>