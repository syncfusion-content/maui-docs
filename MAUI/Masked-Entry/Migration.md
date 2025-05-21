---
layout: post
title: Migrating from Xamarin to .NET MAUI SfMaskedEntry | Syncfusion® 
description: Learn about Migrating from Syncfusion® Xamarin MaskedEdit to Syncfusion® .NET MAUI MaskedEntry control and more.
platform: maui
control: SfMaskedEntry
documentation: ug
---  

# Migrating from Xamarin SfMaskedEdit to .NET MAUI SfMaskedEntry

To facilitate easier migration from Xamarin SfMaskedEdit to [.NET MAUI SfMaskedEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfMaskedEntry.html), most APIs have been preserved from Xamarin SfMaskedEdit in the MAUI SfMaskedEntry. However, some APIs have been renamed to maintain naming consistency within the MAUI environment. The API changes from Xamarin SfMaskedEdit to MAUI SfMaskedEntry are detailed below.

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
<td>Xamarin - MaskType <br/> .NET MAUI - MaskedEntryMaskType</td>
<td> {{'[Text](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskType.html#Syncfusion_XForms_MaskedEdit_MaskType_Text)'| markdownify }},<br/> {{'[RegEx](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.MaskedEdit.MaskType.html#Syncfusion_XForms_MaskedEdit_MaskType_RegEx)'| markdownify}}.</td>
<td> {{'[Simple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html#Syncfusion_Maui_Inputs_MaskedEntryMaskType_Simple)'| markdownify}},<br/> {{'[RegEx](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.MaskedEntryMaskType.html#Syncfusion_Maui_Inputs_MaskedEntryMaskType_RegEx)'| markdownify}}.</td>
<td>Gets or sets the type of mask elements.</td></tr>

</table> 

## Upcoming features

- Border customization
- HasError and Validation mode
- MaskFormat for clipboard operations
- Password character and password delay duration.
