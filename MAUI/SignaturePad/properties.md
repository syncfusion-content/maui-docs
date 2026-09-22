---
layout: post
title: Properties of .NET MAUI Signature Pad control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Signature Pad (SfSignaturePad) control.
platform: maui
control: SfSignaturePad
documentation: ug
---

# API Reference for .NET MAUI Signature Pad

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
    <td>Controls the maximum width of signature strokes. Higher values produce bolder lines during drawing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness" aria-label="View MinimumStrokeThickness property in API reference">MinimumStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the minimum width of signature strokes. Higher values produce thicker lines even during light or fast pen movements.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor" aria-label="View StrokeColor property in API reference">StrokeColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Controls the color used to render signature strokes on the drawing surface.</td>
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
    <td>Removes all strokes from the signature pad and restores an empty drawing surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_GetSignaturePoints" aria-label="View GetSignaturePoints method in API reference">GetSignaturePoints()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1" aria-label="View List type in API reference">List&lt;List&lt;float&gt;&gt;</a></td>
    <td>Retrieves the captured stroke points that make up the current signature, allowing the signature data to be stored or processed independently of its rendered image.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource" aria-label="View ToImageSource method in API reference">ToImageSource()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Converts the current signature into an image that can be displayed, saved, shared, or exported.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.DrawCompletedEventArgs.html" aria-label="View DrawCompletedEventArgs type in API reference">DrawCompletedEventArgs&gt;</a></a></td>
    <td>Triggered when the user finishes drawing a stroke on the signature surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted" aria-label="View DrawStarted event in API reference">DrawStarted</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.DrawStartedEventArgs.html" aria-label="View DrawStartedEventArgs type in API reference">DrawStartedEventArgs&gt;</a></a></td>
    <td>Triggered when the user begins drawing on the signature surface.</td>
</tr>
</table>
