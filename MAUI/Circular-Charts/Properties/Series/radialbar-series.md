---
layout: post
title: RadialBarSeries in .NET MAUI Circular Chart | Syncfusion®
description: This section lists the public API members of the radial bar series available in the Syncfusion® .NET MAUI Circular Chart (SfCircularChart) API.
platform: maui
control: SfCircularChart
documentation: ug
---

# RadialBarSeries API in .NET MAUI Circular Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CapStyle" aria-label="View CapStyle property in API reference">CapStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CapStyle.html" aria-label="View CapStyle type in API reference">CapStyle</a></td>
    <td>Defines the <code>shape</code> of the <code>start and end points</code> of each <code>radial bar segment</code>, with options such as <code>BothFlat</code>, <code>BothRound</code>, <code>StartFlat</code>, <code>StartRound</code>, <code>EndFlat</code>, and <code>EndRound</code>. Defaults to <code>BothFlat</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterHoleSize" aria-label="View CenterHoleSize property in API reference">CenterHoleSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Returns the <code>diameter</code> of the <code>inner hole</code> as a fraction of the <code>chart radius</code>, derived from <code>InnerRadius</code>. <code>Read-only</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_CenterView" aria-label="View CenterView property in API reference">CenterView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Renders a <code>custom view</code> inside the <code>radial bar center</code>, useful for <code>total values</code>, <code>titles</code>, or <code>images</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_DataLabelSettings" aria-label="View DataLabelSettings property in API reference">DataLabelSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularDataLabelSettings.html" aria-label="View CircularDataLabelSettings type in API reference">CircularDataLabelSettings</a></td>
    <td>Provides <code>circular-specific options</code> for data labels such as <code>smart label collision avoidance</code>, <code>connector lines</code>, and <code>label wrap behavior</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableAnimation" aria-label="View EnableAnimation property in API reference">EnableAnimation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Animates the <code>radial bar series</code> when it first appears and whenever the <code>underlying data changes</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_EnableTooltip" aria-label="View EnableTooltip property in API reference">EnableTooltip</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays a <code>tooltip</code> with <code>segment details</code> when the user hovers over or taps a <code>bar</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_EndAngle" aria-label="View EndAngle property in API reference">EndAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets the <code>angular position</code>, in <code>degrees</code>, where the <code>radial bar layout</code> stops drawing. Defaults to <code>360</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Fill" aria-label="View Fill property in API reference">Fill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Applies a <code>solid color</code> to all <code>segments</code> when no <code>palette</code> or <code>data-driven colors</code> are provided.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_GapRatio" aria-label="View GapRatio property in API reference">GapRatio</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets the <code>spacing</code> between <code>adjacent radial bar segments</code> as a fraction of <code>segment width</code>, between <code>0</code> and <code>1</code>. Defaults to <code>0.2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_InnerRadius" aria-label="View InnerRadius property in API reference">InnerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Defines the <code>inner circle radius</code> as a fraction of the <code>outer radius</code>, between <code>0</code> and <code>1</code>. Defaults to <code>0.4</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisible" aria-label="View IsVisible property in API reference">IsVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Shows or hides the <code>entire series</code>, including its <code>segments</code>, <code>labels</code>, and <code>legend entry</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_IsVisibleOnLegend" aria-label="View IsVisibleOnLegend property in API reference">IsVisibleOnLegend</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether a <code>legend item</code> is rendered for this series.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
    <td>Supplies the <code>collection of business objects</code> used to plot the <code>radial bar chart</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelContext" aria-label="View LabelContext property in API reference">LabelContext</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelContext.html" aria-label="View LabelContext type in API reference">LabelContext</a></td>
    <td>Selects what each <code>data label</code> displays, such as the <code>raw value</code>, its <code>percentage</code> of the <code>maximum</code>, or both. <code>Percentage</code> is recommended for <code>PieSeries</code>, <code>DoughnutSeries</code>, and <code>BarSeries</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LabelTemplate" aria-label="View LabelTemplate property in API reference">LabelTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the <code>default data label</code> with a <code>custom layout</code>, enabling <code>rich content</code> such as <code>icons</code>, <code>formatted numbers</code>, or <code>bound text</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_LegendIcon" aria-label="View LegendIcon property in API reference">LegendIcon</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartLegendIconType.html" aria-label="View ChartLegendIconType type in API reference">ChartLegendIconType</a></td>
    <td>Defines the <code>legend marker shape</code>, such as <code>circle</code>, <code>rectangle</code>, <code>diamond</code>, or <code>cross</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ListenPropertyChange" aria-label="View ListenPropertyChange property in API reference">ListenPropertyChange</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>When enabled, the series automatically <code>refreshes</code> in response to <code>property changes</code> on <code>bound source objects</code>; disabled by default.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_MaximumValue" aria-label="View MaximumValue property in API reference">MaximumValue</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets the <code>upper bound</code> used to compute <code>segment sweeps</code>. Values exceeding this are <code>clamped</code>. Defaults to <code>NaN</code>, which auto-fits the <code>largest data value</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_Opacity" aria-label="View Opacity property in API reference">Opacity</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Adjusts <code>segment transparency</code>, where <code>0</code> is <code>fully transparent</code> and <code>1</code> is <code>fully opaque</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes" aria-label="View PaletteBrushes property in API reference">PaletteBrushes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;</a><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">&gt;</a></td>
    <td>Cycles through this <code>list of colors</code> to paint <code>individual segments</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PointColorPath" aria-label="View PointColorPath property in API reference">PointColorPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Resolves a <code>per-segment brush</code> by reading a <code>color value</code> from each <code>source object</code> through the specified <code>property path</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Radius" aria-label="View Radius property in API reference">Radius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the <code>overall size</code> of the <code>radial bar</code> as a fraction of the <code>available plot area</code>, between <code>0</code> and <code>1</code>. Defaults to <code>0.8</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_SelectionBehavior" aria-label="View SelectionBehavior property in API reference">SelectionBehavior</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DataPointSelectionBehavior.html" aria-label="View DataPointSelectionBehavior type in API reference">DataPointSelectionBehavior</a></td>
    <td>Configures <code>segment selection rules</code>, such as <code>single tap</code>, <code>multiple selection</code>, <code>deselection on re-tap</code>, or <code>none</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_ShowDataLabels" aria-label="View ShowDataLabels property in API reference">ShowDataLabels</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays <code>data labels</code> next to or above each <code>segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StartAngle" aria-label="View StartAngle property in API reference">StartAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets the <code>angular position</code>, in <code>degrees</code>, where the <code>radial bar layout</code> begins drawing. Defaults to <code>0</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_Stroke" aria-label="View Stroke property in API reference">Stroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Paints the <code>outline</code> of each <code>radial bar segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets <code>segment outline thickness</code>; ignored when <code>Stroke</code> is <code>null</code>. Defaults to <code>2</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackFill" aria-label="View TrackFill property in API reference">TrackFill</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Paints the <code>unfilled track</code> behind each <code>radial bar segment</code>, making the <code>empty portion</code> visible.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackStroke" aria-label="View TrackStroke property in API reference">TrackStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Paints the <code>outline</code> of the <code>unfilled track</code> behind each <code>segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.RadialBarSeries.html#Syncfusion_Maui_Charts_RadialBarSeries_TrackStrokeWidth" aria-label="View TrackStrokeWidth property in API reference">TrackStrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Sets the <code>outline thickness</code> of the <code>unfilled track</code>. Defaults to <code>1</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_TooltipTemplate" aria-label="View TooltipTemplate property in API reference">TooltipTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the <code>default tooltip content</code> with a <code>custom layout</code> bound to the <code>current segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XBindingPath" aria-label="View XBindingPath property in API reference">XBindingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Maps a <code>property</code> on the <code>source object</code> to the <code>category value</code> for each <code>segment</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_XRange" aria-label="View XRange property in API reference">XRange</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Returns the computed <code>minimum</code> and <code>maximum category values</code> produced by the <code>visible series</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.CircularSeries.html#Syncfusion_Maui_Charts_CircularSeries_YBindingPath" aria-label="View YBindingPath property in API reference">YBindingPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
    <td>Maps a <code>property</code> on the <code>source object</code> to the <code>radial value</code> that determines each <code>segment's length</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_YRange" aria-label="View YRange property in API reference">YRange</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Returns the computed <code>minimum</code> and <code>maximum radial values</code> produced by the <code>visible series</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_GetDataPointIndex_System_Single_System_Single_" aria-label="View GetDataPointIndex method in API reference">GetDataPointIndex(Single, Single)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Returns the <code>zero-based index</code> of the <code>segment</code> located at the given <code>pixel coordinates</code>, or <code>-1</code> when <code>no segment is hit</code>.</td>
</tr>
</table>
