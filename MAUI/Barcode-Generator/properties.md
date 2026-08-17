---
layout: post
title: Properties of .NET MAUI Barcode Generator control | Syncfusion®
description: This section explains the properties and methods with Syncfusion® MAUI Barcode Generator (SfBarcodeGenerator) control.
platform: MAUI
control: SfBarcodeGenerator
documentation: ug
---

# .NET MAUI Barcode Generator API Reference

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
    <td>Color used to draw the <code>barcode</code> bars and modules. A strong contrast improves barcode readability.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_ShowText" aria-label="View ShowText property in API reference">ShowText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the encoded value is shown below the barcode. Set this to <code>false</code> to display only the barcode pattern.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Symbology" aria-label="View Symbology property in API reference">Symbology</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SymbologyBase.html" aria-label="View SymbologyBase type in API reference">SymbologyBase</a></td>
    <td>Barcode symbology used to generate the code. Assign a supported symbology object such as a <code>1D</code> or <code>2D</code> barcode type.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextAlignment" aria-label="View TextAlignment property in API reference">TextAlignment</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.textalignment" aria-label="View TextAlignment type in API reference">TextAlignment</a></td>
    <td>Alignment of the barcode text. Use <code>Start</code>, <code>Center</code>, or <code>End</code> to position the label.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextSpacing" aria-label="View TextSpacing property in API reference">TextSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Spacing between the barcode and its text label in device-independent units. Larger values increase the gap.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.BarcodeTextStyle.html" aria-label="View BarcodeTextStyle type in API reference">BarcodeTextStyle</a></td>
    <td>Text style applied to the barcode label. Use it to control the font, size, and color of the displayed value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_Value" aria-label="View Value property in API reference">Value</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Data encoded in the barcode. This is the source value converted into the generated barcode image.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_GetStreamAsync_Syncfusion_Maui_Core_ImageFileFormat_" aria-label="View GetStreamAsync method in API reference">GetStreamAsync(<code>ImageFileFormat</code>)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.threading.tasks.task-1" aria-label="View Task&lt;Stream&gt; type in API reference">Task&lt;<a href="https://learn.microsoft.com/dotnet/api/system.io.stream" aria-label="View Stream type in API reference">Stream</a>&gt;</a></td>
    <td>Returns the barcode as a stream in the requested image format. This is useful when the output needs to be saved or processed before display.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Barcode.SfBarcodeGenerator.html#Syncfusion_Maui_Barcode_SfBarcodeGenerator_SaveAsImage_System_String_" aria-label="View SaveAsImage method in API reference">SaveAsImage(string)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Saves the generated barcode as an image file at the specified path. This is useful for exporting the barcode to storage.</td>
</tr>
</table>
