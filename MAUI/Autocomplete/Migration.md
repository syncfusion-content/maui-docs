---
layout: post
title: Migrating from Xamarin to .NET MAUI SfAutocomplete | Syncfusion 
description: Learn all about Migrating from Syncfusion Xamarin Autocomplete to Syncfusion .NET MAUI Autocomplete control and more here.
platform: maui
control: SfAutocomplete
documentation: ug
---  

# Migrating from Xamarin SfAutoComplete to .NET MAUI SfAutocomplete 

To migrate easier from Xamarin SfAutoComplete to .NET MAUI `SfAutocomplete`, we kept most of the APIs from Xamarin SfAutoComplete in MAUI SfAutocomplete. However, to maintain the consistency of API naming in MAUI SfAutocomplete, we renamed some of the APIs. The APIs changed in MAUI SfAutocomplete from Xamarin SfAutoComplete are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th></tr>
<tr>
<td>Syncfusion.SfAutoComplete.XForms</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th></tr>
<tr>
<td>SuggestionMode</td>
<td>TextSearchMode</td>
<td>Gets or sets the search mode of the control. The enum values are "StartsWith" and "Contains"</td></tr>
<tr>
<td>Watermark</td>
<td>Placeholder</td>
<td>Gets or sets the place holder text.</td></tr>
<tr>
<td>WatermarkColor</td>
<td>PlaceholderColor</td>
<td>Gets or sets the color of the place holder text.</td></tr>
<tr>
<td>ClearButtonColor</td>
<td>ClearButtonIconColor</td>
<td>Gets or sets the color of the clear button.</td></tr>
<tr>
<td>ShowClearButton</td>
<td>IsClearButtonVisible</td>
<td>Gets or sets whether to show the clear button.</td></tr>
<tr>
<td>MaximumDropDownHeight</td>
<td>MaxDropDownHeight</td>
<td>Gets or sets the maximum dropdown height.</td></tr>
</table> 

## Upcoming features

  * ItemTemplate
  * AutoCompleteModes
  * MultipleSelection
  *	DiacriticSensitivity
  *	Header and Footer
  *	Highlighting Text
  *	LoadMore 
  *	NoResultsFound
