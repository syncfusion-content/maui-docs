---
layout: post
title: Migrate from Xamarin to .NET MAUI SfSignaturePad | Syncfusion ®
description: Learn here all about Migrating from Syncfusion<sup>®</sup> Xamarin SignaturePad to Syncfusion<sup>®</sup> .NET MAUI SignaturePad control and more.
platform: MAUI
control: SfSignaturePad
documentation: ug
---  

# Migrate from Xamarin.Forms SfSignaturePad to .NET MAUI SfSignaturePad 

To migrate from the [Xamarin SignaturePad](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html) to [.NET MAUI  SignaturePad](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html) easier, most of the APIs from the Xamarin SfSignaturePad were kept in the .NET MAUI SfSignaturePad. However, to maintain the consistency of API naming in the.NET MAUI SfSignaturePad, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th></tr>
<tr>
<td>Syncfusion.XForms.SignaturePad</td>
<td>Syncfusion.Maui.SignaturePad</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeColor)'| markdownify }}</td>
<td>{{'[StrokeColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_StrokeColor)'| markdownify }}</td>
<td>Gets or sets the stroke color of the signature.</td></tr>
<tr>
<td>{{'[MinimumStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_MinimumStrokeWidth)'| markdownify }}</td>
<td>{{'[MinimumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MinimumStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the minimum stroke thickness of the signature.</td></tr>
<tr>
<td>{{'[MaximumStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_MaximumStrokeWidth)'| markdownify }}</td>
<td>{{'[MaximumStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_MaximumStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the maximum stroke thickness of the signature.</td></tr>
</table> 

## Methods

<table> 
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[Save](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_Save)'| markdownify }}</td>
<td>{{'[ToImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_ToImageSource)'| markdownify }}</td>
<td>Gets the drawn signature in the SfSignaturePad as an image.</td></tr>
<tr>
<td>{{'[Clear](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_Clear)'| markdownify }}</td>
<td>{{'[Clear](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_Clear)'| markdownify }}</td>
<td>Clears the drawn signature in the SfSignaturePad.</td></tr>
</table> 

## Events

<table> 
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'[StrokeStarted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeStarted)'| markdownify }}</td>
<td>{{'[DrawStarted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawStarted)'| markdownify }}</td>
<td>Occurs when a drawing is started in the SfSignaturePad.</td></tr>
<tr>
<td>{{'[StrokeCompleted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html#Syncfusion_XForms_SignaturePad_SfSignaturePad_StrokeCompleted)'| markdownify }}</td>
<td>{{'[DrawCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SignaturePad.SfSignaturePad.html#Syncfusion_Maui_SignaturePad_SfSignaturePad_DrawCompleted)'| markdownify }}</td>
<td>Occurs when the drawing is completed in the SfSignaturePad.</td></tr>
</table> 