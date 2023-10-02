---
layout: post
title: Migrating from Xamarin to .NET MAUI SfRating | Syncfusion 
description: Learn all about Migrating from Syncfusion Xamarin Rating to Syncfusion .NET MAUI Rating control and more here.
platform: maui
control: SfRating
documentation: ug
---  

# Migrating from Xamarin SfRating to .NET MAUI SfRating 

To migrate easier from Xamarin SfRating to [.NET MAUI SfRating](https://www.syncfusion.com/maui-controls/maui-rating), most of the APIs were kept from Xamarin SfRating in MAUI SfRating. However, to maintain the consistency of API naming in MAUI SfRating, we renamed some of the APIs. The APIs changed in MAUI SfRating from Xamarin SfRating are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfRating</th>
<th>.NET MAUI SfRating</th></tr>
<tr>
<td>Syncfusion.SfRating.XForms</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfRating</th>
<th>.NET MAUI SfRating</th>
<th>Description</th></tr>
<tr>
<td>{{'[RatedStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRating.XForms.SfRatingSettings.html#Syncfusion_SfRating_XForms_SfRatingSettings_RatedStrokeWidth)'| markdownify }}</td>
<td>{{'[RatedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the rated stroke thickness.</td></tr>
<tr>
<td>{{'[UnratedStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRating.XForms.SfRatingSettings.html#Syncfusion_SfRating_XForms_SfRatingSettings_UnRatedStrokeWidth)'| markdownify }}</td>
<td>{{'[UnratedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html#Syncfusion_Maui_Inputs_RatingSettings_RatedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the unrated stroke thickness.</td></tr>
<tr>
<td>{{'[ReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRating.XForms.SfRating.html#Syncfusion_SfRating_XForms_SfRating_ReadOnly)'| markdownify }}</td>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_IsReadOnly)'| markdownify }}</td>
<td>Gets or sets the boolean value of Is Read Only.</td></tr>
</table> 
