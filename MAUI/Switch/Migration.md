---
layout: post
title: Migrating from Xamarin to .NET MAUI Switch | Syncfusion 
description: Learn about Migrating from Syncfusion Xamarin Switch to the Syncfusion .NET MAUI Switch control and more here.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---  

# Migrating from Xamarin SfSwitch to .NET MAUI SfSwitch 

To migrate easier from Xamarin SfSwitch to [.NET MAUI SfSwitch], we kept most of the APIs from Xamarin SfSwitch in MAUI SfSwitch. However, to maintain the consistency of the API naming in MAUI SfSwitch, we renamed some of the APIs. The APIs changed in MAUI SfSwitch from Xamarin SfSwitch are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfSwitch</th>
<th>.NET MAUI SfSwitch</th></tr>
<tr>
<td>Syncfusion.XForms.Buttons</td>
<td>Syncfusion.Maui.Buttons</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfSwitch</th>
<th>.NET MAUI SfSwitch</th>
<th>Description</th></tr>
<tr>
<td> {{'[TrackBorderWidth]'| markdownify }}</td>
<td> {{'[TrackStrokeThickness]'| markdownify }}</td>
<td>Gets or sets the track stroke thickness.</td></tr>
<tr>
<td> {{'[ThumbBorderWidth]'| markdownify }}</td>
<td> {{'[ThumbStrokeThickness]'| markdownify }}</td>
<td>Gets or sets the thumb stroke thickness.</td></tr>
<tr>
<td> {{'[TrackBorderColor]'| markdownify }}</td>
<td> {{'[TrackStroke]'| markdownify }} </td>
<td>Gets or sets the color of the track border.</td></tr>
<tr>
<td> {{'[ThumbBorderColor]'| markdownify }}</td>
<td> {{'[ThumbStroke]'| markdownify }}</td>
<td>Gets or sets the color of the thumb border.</td></tr>
<tr>
<td> {{'[TrackColor]'| markdownify }}</td>
<td> {{'[TrackBackground]'| markdownify }}</td>
<td>Gets or sets the color of the track.</td></tr>
<tr>
<td> {{'[ThumbColor]'| markdownify }}</td>
<td> {{'[ThumbBackground]'| markdownify }}</td>
<td>Gets or sets the color of the thumb.</td></tr>
</table>