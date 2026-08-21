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
    <td><code>Height</code> of each <code>digital character</code> displayed in the <code>gauge</code>. Larger values produce taller <code>segmented glyphs</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterSpacing" aria-label="View CharacterSpacing property in API reference">CharacterSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Horizontal spacing</code> between consecutive <code>characters</code>. Larger values add more <code>visual separation</code> between adjacent <code>glyphs</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterStroke" aria-label="View CharacterStroke property in API reference">CharacterStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> used to paint the <code>enabled (active) segments</code> of each <code>character</code>, controlling the primary <code>visible color</code> of the <code>lit portions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterType" aria-label="View CharacterType property in API reference">CharacterType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.DigitalGaugeCharacterType.html" aria-label="View DigitalGaugeCharacterType enum in API reference">DigitalGaugeCharacterType</a></td>
    <td><code>Segment style</code> used to display the <code>text</code>. Choose a supported <code>DigitalGaugeCharacterType</code> value such as <code>SevenSegment</code>, <code>FourteenSegment</code>, or <code>SixteenSegment</code> to define how each <code>glyph</code> renders.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_CharacterWidth" aria-label="View CharacterWidth property in API reference">CharacterWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Width</code> of each <code>digital character</code> displayed in the <code>gauge</code>. Larger values produce wider <code>segmented glyphs</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentAlpha" aria-label="View DisabledSegmentAlpha property in API reference">DisabledSegmentAlpha</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Opacity</code> applied to the <code>inactive segments</code> of each <code>character</code>. Lower values make <code>unlit segments</code> appear <code>fainter</code>, and higher values make them more <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_DisabledSegmentStroke" aria-label="View DisabledSegmentStroke property in API reference">DisabledSegmentStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> used to paint the <code>inactive segments</code> of each <code>character</code>, controlling the <code>off-state color</code> of the <code>digital glyphs</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_StrokeWidth" aria-label="View StrokeWidth property in API reference">StrokeWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Thickness</code> of each <code>segment line</code> in the <code>digital pattern</code>. Larger values produce <code>bolder</code> <code>character strokes</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Gauges.SfDigitalGauge.html#Syncfusion_Maui_Gauges_SfDigitalGauge_Text" aria-label="View Text property in API reference">Text</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Text</code> rendered by the <code>gauge</code> as a <code>segmented digital display</code>. Values are drawn using the configured <code>CharacterType</code>.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.textchangedeventargs" aria-label="View TextChangedEventArgs type in API reference">TextChangedEventArgs</a>&gt;</a></td>
    <td>Triggered when the <code>Text</code> property changes, providing the <code>previous</code> and <code>new text values</code>.</td>
</tr>
</table>
