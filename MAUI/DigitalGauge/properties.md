---
layout: post
title: Properties of .NET MAUI Digital Gauge control | Syncfusion®
description: This section explains the properties and events with Syncfusion® MAUI Digital Gauge (SfDigitalGauge) control.
platform: maui
control: SfDigitalGauge
documentation: ug
---

# API Reference for .NET MAUI Digital Gauge

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterHeight" aria-label="View CharacterHeight property in API reference">CharacterHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height of the digital characters and controls the vertical size of each rendered segment pattern.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing" aria-label="View CharacterSpacing property in API reference">CharacterSpacing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the spacing between digital characters and controls the amount of horizontal separation applied between consecutive glyphs.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke" aria-label="View CharacterStroke property in API reference">CharacterStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the fill brush used for enabled character segments and controls the primary visible color of the rendered digital outline.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType" aria-label="View CharacterType property in API reference">CharacterType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html" aria-label="View DigitalGaugeCharacterType enum in API reference">DigitalGaugeCharacterType</a></td>
<td>Defines the character style used by the gauge by using the <code>DigitalGaugeCharacterType</code> enum and controls whether the display renders digits, hexadecimal-style characters, or other supported digital formats.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth" aria-label="View CharacterWidth property in API reference">CharacterWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width of the digital characters and controls the horizontal size of each segmented glyph.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentAlpha" aria-label="View DisabledSegmentAlpha property in API reference">DisabledSegmentAlpha</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the opacity of disabled segments and controls how faint inactive parts of the character appear.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentStroke" aria-label="View DisabledSegmentStroke property in API reference">DisabledSegmentStroke</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the brush used for disabled segments and controls the visual appearance of inactive portions of the digital character.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the stroke width of the digital segments and controls the thickness of each rendered segment line.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_Text" aria-label="View Text property in API reference">Text</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the text displayed in the digital gauge and provides the content that is rendered in segmented form.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_TextChanged" aria-label="View TextChanged event in API reference">TextChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.textchangedeventargs" aria-label="View TextChangedEventArgs type in API reference">TextChangedEventArgs&gt;</a></a></td>
<td>Raised when the text displayed in the digital gauge changes and provides the updated text change information.</td>
</tr>

</table>