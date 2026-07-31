---
layout: post
title: Properties of .NET MAUI TreeMap control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® MAUI TreeMap (SfTreeMap) control and more.
platform: maui
control: SfTreeMap
documentation: ug
---

# .NET MAUI TreeMap API Reference

## Properties

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DataSource">DataSource</a></td><td>object</td><td>Gets or sets a collection used to generate the item in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_DrillDownHeaderSettings">DrillDownHeaderSettings</a></td><td>TreeMapDrillDownHeaderSettings</td><td>Gets or sets the drill down header settings value.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_EnableDrillDown">EnableDrillDown</a></td><td>bool</td><td>Gets or sets the value for the drilldown support.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_GroupItemBrushSettings">GroupItemBrushSettings</a></td><td>TreeMapPaletteBrushSettings</td><td>Gets or sets the settings for the group item brush, which is used to customize the group items in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LayoutType">LayoutType</a></td><td>LayoutType</td><td>Gets or sets the layout type used to arrange items using a specific layout algorithm.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemBrushSettings">LeafItemBrushSettings</a></td><td>TreeMapBrushSettings</td><td>Gets or sets the settings for the leaf item brush, which is used to customize the leaf items in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemSettings">LeafItemSettings</a></td><td>TreeMapLeafItemSettings</td><td>Gets or sets the settings for the leaf item, which is used to customize the stroke color, stroke width, text style, spacing between items, and text format option in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LeafItemTemplate">LeafItemTemplate</a></td><td>DataTemplate</td><td>Gets or sets the data template to use for customizing the appearance of individual leaf items in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_LegendSettings">LegendSettings</a></td><td>TreeMapLegendSettings</td><td>Gets or sets the settings for the legend, which is used to customize the icon size, text style, icon type, placement, show legend and legend size in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_Levels">Levels</a></td><td>ObservableCollection&lt;TreeMapLevel&gt;</td><td>Gets or sets the collection of levels defining the hierarchical structure for grouped visualization of data in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_PrimaryValuePath">PrimaryValuePath</a></td><td>string</td><td>Gets or sets the name of the property in the data object that provides the primary value for each item in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_RangeColorValuePath">RangeColorValuePath</a></td><td>string</td><td>Gets or sets the name of the property in the data object that provides the range color value for each item in the SfTreeMap control.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItems">SelectedItems</a></td><td>ObservableCollection&lt;TreeMapItemInfo&gt;</td><td>Gets or sets the collection of tree map item representing the currently selected items in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItemStroke">SelectedItemStroke</a></td><td>Brush</td><td>Gets or sets the stroke color for the selected item in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectedItemStrokeWidth">SelectedItemStrokeWidth</a></td><td>double</td><td>Gets or sets the stroke width for the selected item in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectionMode">SelectionMode</a></td><td>SelectionMode</td><td>Gets or sets the selection mode for the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ShowToolTip">ShowToolTip</a></td><td>bool</td><td>Gets or sets a value indicating whether tool tips are displayed for items in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipSettings">ToolTipSettings</a></td><td>TreeMapToolTipSettings</td><td>Gets or sets the settings for the tool tips, which is used to customize the background, duration, stroke, and text style in the SfTreeMap.</td></tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_ToolTipTemplate">ToolTipTemplate</a></td><td>DataTemplate</td><td>Gets or sets the data template to use for customizing the appearance of tool tips for items in the SfTreeMap.</td></tr>
</table>

## Methods

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SfTreeMap">SfTreeMap()</a></td><td>Constructor</td><td>Initializes a new instance of the SfTreeMap class.</td></tr>
</table>

## Events

<table>
	<tr>
		<th>Name<br/></th>
		<th>Type<br/></th>
		<th>Description<br/></th>
	</tr>
	<tr valign="top"><td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html#Syncfusion_Maui_TreeMap_SfTreeMap_SelectionChanged">SelectionChanged</a></td><td>EventHandler&lt;TreeMapSelectionChangedEventArgs&gt;</td><td>Occurs when the selection within the tree map item is changed.</td></tr>
</table>
