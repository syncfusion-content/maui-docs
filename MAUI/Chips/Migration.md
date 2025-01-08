---
layout: post
title: Migrating from Xamarin to .NET MAUI Chips | Syncfusion<sup>®</sup> 
description: Learn all about Migrating from Syncfusion<sup>®</sup> Xamarin Chips to Syncfusion<sup>®</sup> .NET MAUI Chips control and more here.
platform: maui
control: SfChips
documentation: ug
---  

# Migrating from Xamarin SfChips to .NET MAUI SfChips 

To migrate easier from Xamarin SfChips to [.NET MAUI SfChips](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html), we kept most of the APIs from Xamarin SfChips in MAUI SfChips. However, to maintain the consistency of API naming in MAUI SfChips, we renamed some of the APIs. The APIs changed in MAUI SfChips from Xamarin SfChips are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfChips</th>
<th>.NET MAUI SfChips</th></tr>
<tr>
<td>Syncfusion.Xamarin.Buttons</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfChips</th>
<th>.NET MAUI SfChips</th>
<th>Description</th></tr>
<tr>
<td> {{'[BorderThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Border.SfBorder.html#Syncfusion_XForms_Border_SfBorder_BorderThickness)'| markdownify }}</td>
<td> {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke thickness.</td></tr>
<tr>
<td> {{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Border.SfBorder.html#Syncfusion_XForms_Border_SfBorder_BorderColor)'| markdownify }}</td>
<td> {{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_Stroke)'| markdownify }}</td>
<td>Gets or sets the color of the border.</td></tr>
<tr>
<td> {{'[BackgroundImage](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BackgroundImage)'| markdownify }}</td>
<td> {{'[BackgroundImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_BackgroundImageSource)'| markdownify }} </td>
<td>Gets or sets the background image in chip.</td></tr>
<tr>
<td> {{'[ImageWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_ImageWidth)'| markdownify }}</td>
<td> {{'[ImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ImageSize)'| markdownify }}</td>
<td>Gets or sets the image size in chip.</td></tr>
<tr>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_ImageSource)'| markdownify }}<br/> {{'[Image](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_Image)'| markdownify }}</td>
<td>{{'[ImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ImageSource)'| markdownify }}</td>
<td>Gets or sets the imagesource in chip.</td></tr>
<tr>
<td> {{'[ChipImageWidth ](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_ChipImageWidth)'| markdownify }}</td>
<td> {{'[ChipImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipImageSize)'| markdownify }}</td>
<td>Gets or sets chipgroup image size.</td></tr>
<tr>
<td> {{'[Type](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_Type)'| markdownify }}</td>
<td> {{'[ChipType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipType)'| markdownify }} </td>
<td>Gets or sets the chip type in chipgroup.</td></tr>
<tr>
<td>{{'[SelectedItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_SelectedItems)'| markdownify }}<br/> {{'[SelectedItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_SelectedItem)'| markdownify }}</td>
<td>{{'[SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedItem)'| markdownify }}</td>
<td>Gets or sets the selected item for chip type filter and choice in chip group.</td></tr>

<tr>
<td> {{'[ChipBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_ChipBorderColor)'| markdownify }}</td>
<td> {{'[ChipStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStroke)'| markdownify }} </td>
<td>Gets or sets the border color in chip group.</td></tr>
<tr>
<td> {{'[ChipBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_ChipBorderWidth)'| markdownify }}</td>
<td> {{'[ChipStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStrokeThickness)'| markdownify }} </td>
<td>Gets or sets the stroke thickness in chip group.</td></tr>
<tr>
<td> {{'[ChipBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChipGroup.html#Syncfusion_XForms_Buttons_SfChipGroup_ChipBackgroundColor)'| markdownify }}</td>
<td> {{'[ChipBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipBackground)'| markdownify }} </td>
<td>Gets or sets the background color in chip group.</td></tr>

</table> 


## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfChips</th>
<th>.NET MAUI SfChips</th>
<th>Description</th></tr>
<tr>
<td> {{'[ItemRemoved](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved)'| markdownify }}</td>
<td>{{'[ItemRemovedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.Buttons.XForms.SfChip.ItemRemovedEventArgs.html)'| markdownify }}<br/> <ul><li> {{'[RemovedItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.Buttons.XForms.SfChip.ItemRemovedEventArgs.html#Syncfusion_Buttons_XForms_SfChip_ItemRemovedEventArgs_RemovedItem)'| markdownify }}</li></ul></td>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Chips.SelectionChangedEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[AddedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Chips.SelectionChangedEventArgs.html#Syncfusion_Maui_Core_Chips_SelectionChangedEventArgs_AddedItem)'| markdownify }} </li> <li>  {{'[RemovedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Chips.SelectionChangedEventArgs.html#Syncfusion_Maui_Core_Chips_SelectionChangedEventArgs_RemovedItem)'| markdownify }}</li> </ul></td>
<td>Raises when an item is removed from chipgroup. Returns the currently removed item.</td></tr>
</table> 


