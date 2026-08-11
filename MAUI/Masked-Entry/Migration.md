---
layout: post
title: Migrating from Xamarin to .NET MAUI Masked Entry | Syncfusion®
description: Learn about Migrating from Syncfusion® Xamarin Masked Edit to Syncfusion® .NET MAUI Masked Entry control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---  

# Migrating from Xamarin Masked Edit to .NET MAUI Masked Entry

To migrate easier from the Xamarin Masked Edit to [.NET MAUI Masked Entry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), most of the APIs are kept from the Xamarin Masked Edit in .NET MAUI Masked Entry. However, to maintain the consistency of API naming in .NET MAUI Masked Entry, rename some of the APIs. The APIs changed in .NET MAUI Masked Entry from Xamarin Masked Edit are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin Masked Edit</th>
<th>.NET MAUI Masked Entry</th></tr>
<tr>
<td>Syncfusion.XForms.MaskedEdit</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Enum

<table> 
<tr>
<th>Enum</th>
<th>Xamarin Masked Edit</th>
<th>.NET MAUI Masked Entry</th>
<th>Description</th></tr>
<tr>
<td>Xamarin - MaskType <br/> .NET MAUI - MaskedEntryMaskType</td>
<td> {{'[Text](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskType.html#Syncfusion_XForms_MaskedEdit_MaskType_Text)'| markdownify }},<br/> {{'[RegEx](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskType.html#Syncfusion_XForms_MaskedEdit_MaskType_RegEx)'| markdownify}}.</td>
<td> {{'[Simple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html#Syncfusion_Maui_Inputs_MaskedEntryMaskType_Simple)'| markdownify}},<br/> {{'[RegEx](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html#Syncfusion_Maui_Inputs_MaskedEntryMaskType_RegEx)'| markdownify}}.</td>
<td>Gets or sets the type of mask elements.</td></tr>

</table> 

## Upcoming features

  * Border customization
  * MaskFormat for clipboard operations
  * Password delay duration.

  