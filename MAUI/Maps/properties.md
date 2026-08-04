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
		<td>Defines the map layer used to render the geographic content.</td>
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
		<td>Converts the given pixel point to a latitude and longitude.</td>
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
		<td>Defines the bubble settings for the map shapes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipSettings">BubbleTooltipSettings</a></td>
		<td>MapTooltipSettings</td>
		<td>Defines the bubble tooltip settings.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_BubbleTooltipTemplate">BubbleTooltipTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template for the bubble tooltip.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ColorMappings">ColorMappings</a></td>
		<td>ObservableCollection&lt;ColorMapping&gt;</td>
		<td>Defines the color mappings for the shapes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataLabelSettings">DataLabelSettings</a></td>
		<td>MapDataLabelSettings</td>
		<td>Defines the data label settings.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_DataSource">DataSource</a></td>
		<td>object</td>
		<td>Defines the data source for the shape layer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_EnableSelection">EnableSelection</a></td>
		<td>bool</td>
		<td>Defines whether shape selection is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Geometry">Geometry</a></td>
		<td>MapGeometryType</td>
		<td>Defines the geometry type of the shape file layer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_Legend">Legend</a></td>
		<td>MapLegend</td>
		<td>Defines the map legend.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_PrimaryValuePath">PrimaryValuePath</a></td>
		<td>string</td>
		<td>Defines the primary value path of the data source.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedItems">SelectedItems</a></td>
		<td>ObservableCollection&lt;object&gt;</td>
		<td>Defines the collection of selected shapes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeFill">SelectedShapeFill</a></td>
		<td>Brush</td>
		<td>Defines the fill of the selected shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStroke">SelectedShapeStroke</a></td>
		<td>Brush</td>
		<td>Defines the stroke of the selected shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectedShapeStrokeThickness">SelectedShapeStrokeThickness</a></td>
		<td>double</td>
		<td>Defines the stroke thickness of the selected shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_SelectionMode">SelectionMode</a></td>
		<td>MapSelectionMode</td>
		<td>Defines the selection mode of the shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeColorValuePath">ShapeColorValuePath</a></td>
		<td>string</td>
		<td>Defines the color value path of the shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeDataField">ShapeDataField</a></td>
		<td>string</td>
		<td>Defines the data field used to identify each shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeFill">ShapeFill</a></td>
		<td>Brush</td>
		<td>Defines the fill of the shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverFill">ShapeHoverFill</a></td>
		<td>Brush</td>
		<td>Defines the fill of the shape on hover.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStroke">ShapeHoverStroke</a></td>
		<td>Brush</td>
		<td>Defines the stroke of the shape on hover.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeHoverStrokeThickness">ShapeHoverStrokeThickness</a></td>
		<td>double</td>
		<td>Defines the stroke thickness of the shape on hover.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapesSource">ShapesSource</a></td>
		<td>MapSource</td>
		<td>Defines the source of the map shapes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStroke">ShapeStroke</a></td>
		<td>Brush</td>
		<td>Defines the stroke of the shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeStrokeThickness">ShapeStrokeThickness</a></td>
		<td>double</td>
		<td>Defines the stroke thickness of the shape.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipSettings">ShapeTooltipSettings</a></td>
		<td>MapTooltipSettings</td>
		<td>Defines the shape tooltip settings.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShapeTooltipTemplate">ShapeTooltipTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template for the shape tooltip.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbles">ShowBubbles</a></td>
		<td>bool</td>
		<td>Defines whether bubbles are shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowBubbleTooltip">ShowBubbleTooltip</a></td>
		<td>bool</td>
		<td>Defines whether the bubble tooltip is shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowDataLabels">ShowDataLabels</a></td>
		<td>bool</td>
		<td>Defines whether data labels are shown.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Maps.MapShapeLayer.html#Syncfusion_Maui_Maps_MapShapeLayer_ShowShapeTooltip">ShowShapeTooltip</a></td>
		<td>bool</td>
		<td>Defines whether the shape tooltip is shown.</td>
	</tr>
</table>
