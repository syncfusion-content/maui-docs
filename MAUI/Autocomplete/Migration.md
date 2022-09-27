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
<tr>
<td>SuggestionMode <br/> AutoCompleteMode</td>
<td>TextSearchMode</td>
<td>Gets or sets the search mode of the control. The enum values are "StartsWith" and "Contains". <br/>When using StartsWith, the AutoCompleteMode will be set to Append. <br/> When using Contains, the AutoCompleteMode will be set to Suggest.</td></tr>
<tr>
<td>ItemsSource,<br/>DataSource,<br/>ComboBoxSource. </td>
<td>ItemsSource</td>
<td>Gets or sets the items source to be populated in the control.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th></tr>
<tr>
<td>Xamarin - SuggestionMode <br/> .NET MAUI - TextSearchMode</td>
<td>StartsWith,<br/>StartsWithCaseSensitive,<br/>Contains,<br/>ContainsWithCaseSensitive,<br/>Equals,<br/>EqualsWithCaseSensitive,<br/>EndsWith,<br/>EndsWithCaseSensitive,<br/>Custom.</td>
<td>StartsWith,<br/>Contains.</td>
<td>Gets or sets the search mode of the control.</td></tr>
</table>

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th></tr>
<tr>
<td>SelectedChanged</td>
<td>SelectionChangedEventArgs<br/> <ul><li>Value</li></ul></td>
<td>SelectionChangedEventArgs<br/> <ul> <li>PreviousSelection </li> <li> CurrentSelection</li> </ul></td>
<td>Raises when an item is selected in the dropdown or the SelectedItem is set programatically.Returns the previous selected item and the currently selected item</td></tr>
</table> 

## Upcoming features

  * Item Template
  * Multiple Selection
  * Diacritic Sensitivity
  * Header and Footer
  * Highlighting Text
  * Load More Feature
  * Minimum Prefix Character
