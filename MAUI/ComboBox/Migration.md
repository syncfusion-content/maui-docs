---
layout: post
title: Migrating from Xamarin to .NET MAUI SfComboBox | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin ComboBox to Syncfusion .NET MAUI ComboBox control and more.
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
<td>Gets or sets the search mode of the control. The enum values are "StartsWith" and "Contains"</td></tr>
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

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfComboBox SelectionChangedEventArgs</th>
<th>.NET MAUI SfComboBox SelectionChangedEventArgs</th>
<th>Description</th></tr>
<tr>
<td>SelectedChanged</td>
<td>Value</td>
<td>PreviousSelection  CurrentSelection</td>
<td>Raises when an item is selected in the dropdown or the SelectedItem is set programatically.Returns the previous selected item and the currently selected item</td></tr>

</table> 