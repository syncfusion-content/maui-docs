---
layout: post
title: Migrating from Xamarin to .NET MAUI Button | Syncfusion 
description: Learn all about Migrating from Syncfusion Xamarin Button to Syncfusion .NET MAUI Button control and more here.
platform: maui
control: SfButton
documentation: ug
---  

# Migrating from Xamarin SfButton to .NET MAUI SfButton 

To migrate easier from Xamarin SfButton to `.NET MAUI SfButton`, we kept most of the APIs from Xamarin SfButton in MAUI SfButton. However, to maintain the consistency of API naming in MAUI SfButton, we renamed some of the APIs. The APIs changed in MAUI SfButton from Xamarin SfButton are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfButton</th>
<th>.NET MAUI SfButton</th></tr>
<tr>
<td>Syncfusion.Xamarin.Buttons</td>
<td>Syncfusion.Maui.Buttons</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfButton</th>
<th>.NET MAUI SfButton</th>
<th>Description</th></tr>
<tr>
<td> {{'[BorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Border.SfBorder.html#Syncfusion_XForms_Border_SfBorder_BorderThickness)'| markdownify }}</td>
<td> {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SfButton.html#Syncfusion_Maui_Buttons_SfButton_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke thickness.</td></tr>
<tr>
<td> {{'[BorderColor]`| markdownify }}</td>
<td> {{'[Stroke]`| markdownify }}</td>
<td>Gets or sets the color of the border.</td></tr>
<tr>
<td> {{'[BackgroundImage]`| markdownify }}</td>
<td> {{'[BackgroundImageSource]`| markdownify }} </td>
<td>Gets or sets the background image in Button.</td></tr>
<tr>
<td> {{'[ImageWidth]`| markdownify }}</td>
<td> {{'[ImageSize]`| markdownify }}</td>
<td>Gets or sets the image size in Button.</td></tr>
</table> 


