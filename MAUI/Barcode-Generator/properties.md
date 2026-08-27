---
layout: post
title: Properties of .NET MAUI Barcode Generator control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Barcode Generator (SfBarcodeGenerator) control.
platform: MAUI
control: SfBarcodeGenerator
documentation: ug
---

# API Reference for .NET MAUI Barcode Generator

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_ForegroundColor" aria-label="View ForegroundColor property in API reference">ForegroundColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> used to draw the <code>barcode bars</code> and <code>modules</code>. High <code>contrast</code> against the background improves <code>readability</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_ShowText" aria-label="View ShowText property in API reference">ShowText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>encoded value</code> is displayed below the <code>barcode</code>. Set this to <code>false</code> to show only the <code>barcode pattern</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Symbology" aria-label="View Symbology property in API reference">Symbology</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SymbologyBase.html" aria-label="View SymbologyBase type in API reference">SymbologyBase</a></td>
    <td><code>Barcode symbology</code> used to generate the code. Choose a supported <code>1D</code> or <code>2D</code> symbology such as <code>Code128</code>, <code>QRCode</code>, or <code>DataMatrix</code> to match the required <code>encoding</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextAlignment" aria-label="View TextAlignment property in API reference">TextAlignment</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
    <td>Alignment of the <code>human-readable text</code> shown below the <code>barcode</code>. Use <code>Start</code>, <code>Center</code>, or <code>End</code> to position the <code>label</code> relative to the barcode.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextSpacing" aria-label="View TextSpacing property in API reference">TextSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Vertical spacing</code> between the <code>barcode</code> and the <code>text label</code>. Larger values increase the <code>gap</code> below the barcode.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.BarcodeTextStyle.html" aria-label="View BarcodeTextStyle type in API reference">BarcodeTextStyle</a></td>
    <td><code>Text style</code> applied to the <code>barcode label</code>, including <code>font</code>, <code>size</code>, and <code>text color</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Value" aria-label="View Value property in API reference">Value</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Source <code>string</code> encoded into the <code>barcode</code>. Updating the value <code>regenerates</code> the <code>barcode image</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_" aria-label="View GetStreamAsync method in API reference">GetStreamAsync(ImageFileFormat)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task-1" aria-label="View Task&lt;Stream&gt; type in API reference">Task&lt;<a href="https://learn.microsoft.com/dotnet/api/system.io.stream" aria-label="View Stream type in API reference">Stream&gt;</a></a></td>
    <td>Generates the <code>barcode</code> as a <code>stream</code> in the requested <code>ImageFileFormat</code>, such as <code>PNG</code> or <code>JPEG</code>. Useful when the output needs to be <code>saved</code> or <code>processed</code> before display.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_SaveAsImage_System_String_" aria-label="View SaveAsImage method in API reference">SaveAsImage(string)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Saves the generated <code>barcode</code> to the specified <code>file path</code> on <code>disk</code>.</td>
</tr>
</table>