---
layout: post
title: Migrating from Xamarin to .NET MAUI SfComboBox | Syncfusion 
description: Learn all about Migrating from Syncfusion Xamarin ComboBox to Syncfusion .NET MAUI ComboBox control and more here.
platform: maui
control: SfComboBox
documentation: ug
---  

# Migrating from Xamarin SfComboBox to .NET MAUI SfComboBox 

To migrate easier from Xamarin SfComboBox to .NET MAUI `SfComboBox`, we kept most of the APIs from Xamarin SfComboBox in MAUI SfComboBox. However, to maintain the consistency of API naming in MAUI SfComboBox, we renamed some of the APIs. The APIs that have been changed in MAUI SfComboBox from Xamarin SfComboBox are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfComboBox</th>
<th>.NET MAUI SfComboBox</th></tr>
<tr>
<td>Syncfusion.XForms.ComboBox</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfComboBox</th>
<th>.NET MAUI SfComboBox</th>
<th>Description</th></tr>
<tr>
<td>IsEditableMode</td>
<td>IsEditable</td>
<td>Gets or sets whether the textbox can support editing.</td></tr>
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
<td>SuggestionMode,<br/>ComboBoxMode</td>
<td>TextSearchMode</td>
<td>Gets or sets the search mode of the control. The enum values are "StartsWith" and "Contains". <br/>When using StartsWith, the ComboBoxMode will be set to Append. <br/> When using Contains, the ComboBoxMode will be set to Suggest.</td></tr>
<tr>
<td>ItemsSource,<br/>DataSource,<br/>ComboBoxSource </td>
<td>ItemsSource</td>
<td>Gets or sets the data to be populated in the control.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfComboBox</th>
<th>.NET MAUI SfComboBox</th>
<th>Description</th></tr>
<tr>
<td>Xamarin - SuggestionMode <br/> .NET MAUI - TextSearchMode</td>
<td>StartsWith,<br/>StartsWithCaseSensitive,<br/>Contains,<br/>ContainsWithCaseSensitive,<br/>Equals,<br/>EqualsWithCaseSensitive,<br/>EndsWith,<br/>EndsWithCaseSensitive,<br/>Custom</td>
<td>StartsWith,<br/>Contains.</td>
<td>Gets or sets the search mode of the control.</td></tr>
</table>

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfComboBox</th>
<th>.NET MAUI SfComboBox</th>
<th>Description</th></tr>
<tr>
<td>SelectedChanged</td>
<td>SelectionChangedEventArgs<br/> <ul><li>Value</li></ul></td>
<td>SelectionChangedEventArgs<br/> <ul> <li>PreviousSelection </li> <li> CurrentSelection</li> </ul></td>
<td>Raises when an item is selected in the dropdown or the SelectedItem is set programatically.Returns the previous selected item and the currently selected item</td></tr>

</table> 

## Upcoming features

  * Item Template
  * Multiple Selection with Tokens and Delimiter
  * Diacritic Sensitivity
  * Header and Footer
  * Highlighting Text
  * Load More Feature
  * Minimum Prefix Character
  * Customizations in Drop-Down