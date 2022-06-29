---
layout: post
title: Migrate from Xamarin to .NET MAUI SfSignaturePad | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SignaturePad to Syncfusion .NET MAUI SignaturePad control and more.
platform: MAUI
control: SfSignaturePad
documentation: ug
---  

# Migrate from Xamarin.Forms SfSignaturePad to .NET MAUI SfSignaturePad 

To migrate from the [Xamarin SignaturePad](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.SignaturePad.SfSignaturePad.html) to `.NET MAUI  SignaturePad` easier, most of the APIs from the Xamarin SfSignaturePad were kept in the .NET MAUI SfSignaturePad. However, to maintain the consistency of API naming in the.NET MAUI SfSignaturePad, some of the APIs have been renamed. Please find the difference in the following topics.

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
<td>{{'StrokeColor'| markdownify }}</td>
<td>{{'StrokeColor'| markdownify }}</td>
<td>Gets or sets the stroke color of the signature.</td></tr>
<tr>
<td>{{'MinimumStrokeWidth'| markdownify }}</td>
<td>{{'MinimumStrokeThickness'| markdownify }}</td>
<td>Gets or sets the minimum stroke thickness of the signature.</td></tr>
<tr>
<td>{{'MaximumStrokeWidth'| markdownify }}</td>
<td>{{'MaximumStrokeThickness'| markdownify }}</td>
<td>Gets or sets the maximum stroke thickness of the signature.</td></tr>
</table> 

## Methods

<table> 
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'Save'| markdownify }}</td>
<td>{{'ToImageSource'| markdownify }}</td>
<td>Gets the drawn signature in the SfSignaturePad as an image.</td></tr>
<tr>
<td>{{'Clear'| markdownify }}</td>
<td>{{'Clear'| markdownify }}</td>
<td>Clears the drawn signature in the SfSignaturePad.</td></tr>
</table> 

## Events

<table> 
<tr>
<th>Xamarin SfSignaturePad</th>
<th>.NET MAUI SfSignaturePad</th>
<th>Description</th></tr>
<tr>
<td>{{'StrokeStarted'| markdownify }}</td>
<td>{{'DrawStarted'| markdownify }}</td>
<td>Occurs when a drawing is started in the SfSignaturePad.</td></tr>
<tr>
<td>{{'StrokeCompleted'| markdownify }}</td>
<td>{{'DrawCompleted'| markdownify }}</td>
<td>Occurs when the drawing is completed in the SfSignaturePad.</td></tr>
</table> 