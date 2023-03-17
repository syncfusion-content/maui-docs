---
layout: post
title: Migrating from Xamarin to .NET MAUI SfMaskedEntry | Syncfusion 
description: Learn about Migrating from Syncfusion Xamarin MaskedEdit to Syncfusion .NET MAUI MaskedEntry control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---  

# Migrating from Xamarin SfMaskedEdit to .NET MAUI SfMaskedEntry

To migrate easier from the `Xamarin SfMaskedEdit` to `.NET MAUI SfMaskedEntry`, most of the APIs are kept from the Xamarin SfMaskedEdit in MAUI SfMaskedEntry. However, to maintain the consistency of API naming in MAUI SfMaskedEntry, rename some of the APIs. The APIs changed in MAUI SfMaskedEntry from Xamarin SfMaskedEdit are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfMaskedEdit</th>
<th>.NET MAUI SfMaskedEntry</th></tr>
<tr>
<td>Syncfusion.XForms.MaskedEdit</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Enum

<table> 
<tr>
<th>Enum</th>
<th>Xamarin SfMaskedEdit</th>
<th>.NET MAUI SfMaskedEntry</th>
<th>Description</th></tr>
<tr>
<td>Xamarin - {{'[MaskType]'| markdownify }} <br/> .NET MAUI - {{'[MaskedEntryMaskType]'| markdownify }}</td>
<td> {{'[Text]'| markdownify }},<br/> {{'[RegEx]'| markdownify }}.</td>
<td> {{'[Simple]'| markdownify }},<br/> {{'[RegEx]'| markdownify }}.</td>
<td>Gets or sets the type of mask elements.</td></tr>

</table> 

## Upcoming features

  * Placeholder and its customization
  * Border customization
  * Set prompt on focus
  * HasError and Validation mode
  * MaskFormat for clipboard operations
  * Password character and password delay duration.

  