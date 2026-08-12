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

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness">MaximumStrokeThickness</a></td>
    <td>double</td>
    <td>Defines the maximum thickness of the signature stroke.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness">MinimumStrokeThickness</a></td>
    <td>double</td>
    <td>Defines the minimum thickness of the signature stroke.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor">StrokeColor</a></td>
    <td>Color</td>
    <td>Defines the color used to draw the signature stroke.</td>
</tr>
</table>

## Methods

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear">Clear()</a></td>
    <td>void</td>
    <td>Clears all signature strokes from the signature pad.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_GetSignaturePoints">GetSignaturePoints()</a></td>
    <td>IList&lt;Point&gt;</td>
    <td>Returns the collection of points that make up the signature.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource">ToImageSource()</a></td>
    <td>ImageSource</td>
    <td>Converts the current signature into an image source.</td>
</tr>
</table>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted">DrawCompleted</a></td>
    <td>EventHandler</td>
    <td>Raised when the user completes drawing a signature stroke.</td>
</tr>

<tr>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted">DrawStarted</a></td>
    <td>EventHandler</td>
    <td>Raised when the user starts drawing on the signature pad.</td>
</tr>
</table>

