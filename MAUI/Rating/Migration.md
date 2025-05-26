---
layout: post
title: Migrating from Xamarin to .NET MAUI SfRating | Syncfusion® 
description: Learn about migrating from Syncfusion® Xamarin Rating to Syncfusion® .NET MAUI Rating control and related changes.
platform: maui
control: SfRating
documentation: ug
---  

# Migrating from Xamarin SfRating to .NET MAUI SfRating 

To ease the migration from Xamarin SfRating to [.NET MAUI SfRating](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html), most APIs from Xamarin SfRating have been retained in MAUI SfRating. However, to maintain consistency in API naming within MAUI SfRating, some APIs have been renamed. Below are details of the changes made from Xamarin SfRating to MAUI SfRating:
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
