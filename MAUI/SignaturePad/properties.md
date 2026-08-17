---
layout: post
title: Properties of .NET MAUI Signature Pad control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Signature Pad (SfSignaturePad) control.
platform: maui
control: SfSignaturePad
documentation: ug
---

# .NET MAUI Signature Pad API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness" aria-label="View MaximumStrokeThickness property in API reference">MaximumStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the largest stroke thickness allowed when drawing the signature and helps control how bold the captured ink can appear.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness" aria-label="View MinimumStrokeThickness property in API reference">MinimumStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the smallest stroke thickness allowed when drawing the signature and helps preserve consistent line visibility across different pen speeds.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor" aria-label="View StrokeColor property in API reference">StrokeColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Defines the color used to render signature strokes and determines the visual tone of the captured handwriting or sketch.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear" aria-label="View Clear method in API reference">Clear()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Clears all captured strokes from the signature surface and resets the control to an empty drawing state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_GetSignaturePoints" aria-label="View GetSignaturePoints method in API reference">GetSignaturePoints()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1" aria-label="View List type in API reference">List&lt;List&lt;float&gt;&gt;</a></td>
    <td>Returns the collection of interaction points that make up the signature path, organized as nested point values for further processing or export.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource" aria-label="View ToImageSource method in API reference">ToImageSource()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Converts the current signature into an image source so the drawing can be displayed, stored, shared, or exported as an image.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted" aria-label="View DrawCompleted event in API reference">DrawCompleted</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.DrawCompletedEventArgs.html" aria-label="View DrawCompletedEventArgs type in API reference">DrawCompletedEventArgs</a></td>
    <td>Raised after drawing finishes and the completed signature input is available for validation, export, or processing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted" aria-label="View DrawStarted event in API reference">DrawStarted</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.DrawStartedEventArgs.html" aria-label="View DrawStartedEventArgs type in API reference">DrawStartedEventArgs</a></td>
    <td>Raised when drawing begins on the signature surface and the initial interaction with the pad has started.</td>
</tr>
</table>
