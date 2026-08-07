---
layout: post
title: Properties of .NET MAUI Maps control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Maps (SfMaps) control.
platform: maui
control: SfMaps
documentation: ug
---

# .NET MAUI Maps API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.SfMaps.html#Syncfusion_Maui_Maps_SfMaps_Layer">Layer</a></td>
        <td>MapLayer</td>
        <td>Defines the map layer used to render the geographic content on the map.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeSelected">ShapeSelected</a></td>
        <td>EventHandler&lt;ShapeSelectedEventArgs&gt;</td>
        <td>Raised when a map shape is selected or unselected.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_GetLatLngFromPoint_Microsoft_Maui_Graphics_Point_">GetLatLngFromPoint(Point)</a></td>
        <td>MapLatLng</td>
        <td>Converts the specified pixel point into a latitude and longitude value.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleSettings">BubbleSettings</a></td>
        <td>MapBubbleSettings</td>
        <td>Defines the bubble settings used to configure bubbles for map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipSettings">BubbleTooltipSettings</a></td>
        <td>MapTooltipSettings</td>
        <td>Defines the tooltip settings used for map bubbles.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipTemplate">BubbleTooltipTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to display bubble tooltip content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings">ColorMappings</a></td>
        <td>ObservableCollection&lt;ColorMapping&gt;</td>
        <td>Defines the collection of color mappings used to color map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings">DataLabelSettings</a></td>
        <td>MapDataLabelSettings</td>
        <td>Defines the settings used to configure data labels on the map.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource">DataSource</a></td>
        <td>object</td>
        <td>Defines the data source used to bind and populate the shape layer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection">EnableSelection</a></td>
        <td>bool</td>
        <td>Defines whether shape selection is enabled for the layer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Geometry">Geometry</a></td>
        <td>MapGeometryType</td>
        <td>Defines the geometry type used by the shape file layer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend">Legend</a></td>
        <td>MapLegend</td>
        <td>Defines the legend displayed for the map layer.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath">PrimaryValuePath</a></td>
        <td>string</td>
        <td>Defines the data source field used as the primary value for shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedItems">SelectedItems</a></td>
        <td>ObservableCollection&lt;object&gt;</td>
        <td>Defines the collection of currently selected map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill">SelectedShapeFill</a></td>
        <td>Brush</td>
        <td>Defines the fill applied to a selected shape.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStroke">SelectedShapeStroke</a></td>
        <td>Brush</td>
        <td>Defines the stroke applied to a selected shape.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStrokeThickness">SelectedShapeStrokeThickness</a></td>
        <td>double</td>
        <td>Defines the stroke thickness of a selected shape.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectionMode">SelectionMode</a></td>
        <td>MapSelectionMode</td>
        <td>Defines the selection mode used by map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeColorValuePath">ShapeColorValuePath</a></td>
        <td>string</td>
        <td>Defines the data source field used to determine shape color values.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField">ShapeDataField</a></td>
        <td>string</td>
        <td>Defines the data field used to identify each individual shape.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeFill">ShapeFill</a></td>
        <td>Brush</td>
        <td>Defines the default fill applied to map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverFill">ShapeHoverFill</a></td>
        <td>Brush</td>
        <td>Defines the fill applied when a shape is hovered.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStroke">ShapeHoverStroke</a></td>
        <td>Brush</td>
        <td>Defines the stroke applied when a shape is hovered.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStrokeThickness">ShapeHoverStrokeThickness</a></td>
        <td>double</td>
        <td>Defines the stroke thickness applied when a shape is hovered.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource">ShapesSource</a></td>
        <td>MapSource</td>
        <td>Defines the source used to load the map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStroke">ShapeStroke</a></td>
        <td>Brush</td>
        <td>Defines the default stroke applied to map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStrokeThickness">ShapeStrokeThickness</a></td>
        <td>double</td>
        <td>Defines the default stroke thickness of map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipSettings">ShapeTooltipSettings</a></td>
        <td>MapTooltipSettings</td>
        <td>Defines the tooltip settings used for map shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipTemplate">ShapeTooltipTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to display shape tooltip content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbles">ShowBubbles</a></td>
        <td>bool</td>
        <td>Defines whether bubbles are displayed for the shapes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbleTooltip">ShowBubbleTooltip</a></td>
        <td>bool</td>
        <td>Defines whether bubble tooltips are shown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowDataLabels">ShowDataLabels</a></td>
        <td>bool</td>
        <td>Defines whether data labels are displayed on the map.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip">ShowShapeTooltip</a></td>
        <td>bool</td>
        <td>Defines whether shape tooltips are shown.</td>
    </tr>
</table>