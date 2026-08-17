---
layout: post
title: Properties of .NET MAUI Circular Chart control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Circular Chart (SfCircularChart) control.
platform: maui
control: SfCircularChart
documentation: ug
---

# .NET MAUI Circular Chart API Reference

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_Series" aria-label="View Series property in API reference">Series</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeriesCollection.html" aria-label="View ChartSeriesCollection type in API reference">ChartSeriesCollection</a></td>
<td>Defines the collection of circular chart series displayed in the chart and controls the set of visual series rendered around the circular plot area.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCircularChart.html#Syncfusion_Maui_Charts_SfCircularChart_AnimateSeries" aria-label="View AnimateSeries method in API reference">AnimateSeries()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Animates all series in the circular chart and applies the configured transition to each visible series.</td>
</tr>

</table>

# .NET MAUI Chart Series API Reference

### Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableAnimation" aria-label="View EnableAnimation property in API reference">EnableAnimation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether animation is enabled for the series and controls whether the series plays a transition when it is rendered or updated.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether tooltips are displayed for the series and controls whether point details appear during interaction.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill" aria-label="View Fill property in API reference">Fill</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the fill brush used to render the series and controls the primary interior color applied to the series shape.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether the series is visible and controls whether the series is included in chart rendering.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend" aria-label="View IsVisibleOnLegend property in API reference">IsVisibleOnLegend</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether the series is displayed in the legend and controls whether a legend entry is created for the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Defines the data source used to populate the series and supplies the collection that is transformed into rendered data points.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelContext" aria-label="View LabelContext property in API reference">LabelContext</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelContext.html" aria-label="View LabelContext type in API reference">LabelContext</a></td>
<td>Defines the context used to display data labels and controls the information passed into the label rendering pipeline.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to display data labels and enables custom visual formatting for label content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon" aria-label="View LegendIcon property in API reference">LegendIcon</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">ChartLegendIconType</a></td>
<td>Defines the icon displayed for the series in the legend by using the <code>ChartLegendIconType</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ListenPropertyChange" aria-label="View ListenPropertyChange property in API reference">ListenPropertyChange</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether the series listens for changes in the data source and controls automatic updates when bound values change.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Opacity" aria-label="View Opacity property in API reference">Opacity</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the opacity of the series and controls the transparency applied to the rendered series shape.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">IList&lt;Brush</a>&gt;</a></td>
<td>Defines the collection of brushes used to render series segments and supplies the palette applied across the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to apply individual point colors and identifies the source field mapped to each point color.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html" aria-label="View DataPointSelectionBehavior type in API reference">DataPointSelectionBehavior</a></td>
<td>Defines the selection behavior applied to the series by using the <code>DataPointSelectionBehavior</code> enum and controls how selected points are highlighted.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Defines whether data labels are displayed and controls the visibility of label text on the series.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to display tooltips and enables custom visual content for tooltip presentation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to map x-values and identifies the source field that supplies the category or axis value.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XRange" aria-label="View XRange property in API reference">XRange</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
<td>Gets the calculated range of x-values in the series and reflects the minimum and maximum x-axis values used by the chart.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_YRange" aria-label="View YRange property in API reference">YRange</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
<td>Gets the calculated range of y-values in the series and reflects the minimum and maximum y-axis values used by the chart.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_CreateAnimation_System_Action_System_Double__" aria-label="View CreateAnimation method in API reference">CreateAnimation(Action)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Creates and starts the animation for the series by invoking the supplied callback during the animation lifecycle.</td>
</tr>

</table>