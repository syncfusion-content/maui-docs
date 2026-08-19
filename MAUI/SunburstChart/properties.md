---
layout: post
title: Properties of .NET MAUI Sunburst Chart control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Sunburst Chart (SfSunburstChart) control.
platform: maui
control: SfSunburstChart
documentation: ug
---

# API Reference for .NET MAUI Sunburst Chart

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls how long the Sunburst Chart <code>animation</code> runs. Higher values produce slower <code>transitions</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_CenterHoleSize" aria-label="View CenterHoleSize property in API reference">CenterHoleSize</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Provides the calculated <code>size</code> of the chart's <code>center hole</code>, which can be used to size center content without overlapping the <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_CenterView" aria-label="View CenterView property in API reference">CenterView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Displays custom content in the chart's <code>center hole</code>; the content inherits the Sunburst Chart as its <code>binding context</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstDataLabelSettings.html" aria-label="View SunburstDataLabelSettings type in API reference">SunburstDataLabelSettings</a></td>
<td>Customizes segment-label <code>text</code> and controls whether labels follow the segment <code>angle</code>, remain <code>horizontal</code>, are <code>trimmed</code>, or are <code>hidden</code> when space is limited. These settings are visible only when <code>ShowLabels</code> is enabled.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableAnimation" aria-label="View EnableAnimation property in API reference">EnableAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Animates the Sunburst Chart when it is <code>rendered</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableDrillDown" aria-label="View EnableDrillDown property in API reference">EnableDrillDown</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Lets users <code>double-tap</code> a <code>segment</code> to focus on that <code>hierarchy level</code>. During drill-down, a <code>toolbar</code> provides <code>zoom-back</code> and <code>reset</code> actions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Applies the <code>Liquid Glass</code> appearance to the Sunburst Chart on <code>iOS</code> and <code>macOS</code>. When enabled, the <code>background</code> configured in <code>TooltipSettings</code> is ignored.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows a <code>tooltip</code> with the segment's <code>category</code> and <code>value</code> when the user <code>taps</code> a segment.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Sets the <code>angle</code> where the Sunburst Chart <code>ends</code>, defining the end of its <code>circular span</code> together with <code>StartAngle</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_InnerRadius" aria-label="View InnerRadius property in API reference">InnerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the <code>size</code> of the <code>center hole</code> as a value from <code>0</code> to <code>1</code> relative to the chart <code>radius</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Supplies the <code>data items</code> that the configured <code>Levels</code> organize into <code>hierarchical rings</code> and <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Legend" aria-label="View Legend property in API reference">Legend</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLegend.html" aria-label="View SunburstLegend type in API reference">SunburstLegend</a></td>
<td>Displays a <code>SunburstLegend</code> that identifies chart <code>segments</code> and can be positioned and styled alongside the visualization.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Levels" aria-label="View Levels property in API reference">Levels</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstLevelCollection.html" aria-label="View SunburstLevelCollection type in API reference">SunburstLevelCollection</a></td>
<td>Defines the <code>hierarchy</code> shown by the chart, with each configured <code>level</code> mapping a <code>data field</code> to one <code>concentric ring</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;Brush&gt; type in API reference">IList&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a>&gt;</a></td>
<td>Applies an <code>ordered collection</code> of <code>brushes</code> to the chart <code>segments</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Radius" aria-label="View Radius property in API reference">Radius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the chart's <code>outer radius</code> as a value from <code>0</code> to <code>1</code> relative to the available <code>plot area</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_SelectionSettings" aria-label="View SelectionSettings property in API reference">SelectionSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionSettings.html" aria-label="View SunburstSelectionSettings type in API reference">SunburstSelectionSettings</a></td>
<td>Controls which related <code>segments</code> are selected and how the selection is <code>highlighted</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ShowLabels" aria-label="View ShowLabels property in API reference">ShowLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows a <code>data label</code> for each Sunburst Chart <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Sets the <code>angle</code> where the Sunburst Chart <code>begins</code>, defining the start of its <code>circular span</code> together with <code>EndAngle</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Applies the specified <code>brush</code> to the <code>outline</code> around each chart <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the <code>thickness</code> of the <code>outline</code> around each chart <code>segment</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_Title" aria-label="View Title property in API reference">Title</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Displays a text title or custom <code>view</code> above the Sunburst Chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ToolbarSettings" aria-label="View ToolbarSettings property in API reference">ToolbarSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstToolbarSettings.html" aria-label="View SunburstToolbarSettings type in API reference">SunburstToolbarSettings</a></td>
<td>Customizes the <code>position</code>, <code>alignment</code>, <code>background</code>, and <code>icon color</code> of the drill-down <code>toolbar</code>. The toolbar appears only while drill-down navigation is active.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_TooltipSettings" aria-label="View TooltipSettings property in API reference">TooltipSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstTooltipSettings.html" aria-label="View SunburstTooltipSettings type in API reference">SunburstTooltipSettings</a></td>
<td>Customizes the tooltip's <code>text</code>, <code>background</code>, <code>spacing</code>, and <code>display duration</code>. The tooltip must be enabled through <code>EnableTooltip</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Replaces the default <code>category-and-value tooltip</code> with custom content. The tooltip must be enabled through <code>EnableTooltip</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_ValueMemberPath" aria-label="View ValueMemberPath property in API reference">ValueMemberPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Identifies the <code>data field</code> whose numeric <code>values</code> determine the <code>size</code> of each Sunburst Chart <code>segment</code>.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangedEventArgs.html" aria-label="View SunburstSelectionChangedEventArgs type in API reference">SunburstSelectionChangedEventArgs&gt;</a></a></td>
<td>Triggered after a <code>segment</code> is selected or deselected, providing the <code>previous segment</code>, the <code>current segment</code>, and the resulting <code>selection state</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SfSunburstChart.html#Syncfusion_Maui_SunburstChart_SfSunburstChart_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangingEventArgs.html" aria-label="View SunburstSelectionChangingEventArgs type in API reference">SunburstSelectionChangingEventArgs&gt;</a></a></td>
<td>Triggered before a <code>segment</code> selection changes, allowing the pending selection or deselection to be <code>canceled</code>.</td>
</tr>

</table>