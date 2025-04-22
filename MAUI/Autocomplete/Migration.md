---
layout: post
title: Migrating from Xamarin to .NET MAUI SfAutocomplete | Syncfusion® 
description: Learn all about Migrating from Syncfusion® Xamarin Autocomplete to Syncfusion® .NET MAUI Autocomplete control and more here.
platform: maui
control: SfAutocomplete
documentation: ug
---  

# Migrating from Xamarin SfAutoComplete to .NET MAUI SfAutocomplete 

To migrate easier from Xamarin SfAutoComplete to [.NET MAUI SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html), we kept most of the APIs from Xamarin SfAutoComplete in MAUI SfAutocomplete. However, to maintain the consistency of API naming in MAUI SfAutocomplete, we renamed some of the APIs. The APIs changed in MAUI SfAutocomplete from Xamarin SfAutoComplete are detailed as follows:

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
<td> {{'[Watermark](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_Watermark)'| markdownify }}</td>
<td> {{'[Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Placeholder)'| markdownify }}</td>
<td>Gets or sets the place holder text.</td></tr>
<tr>
<td> {{'[WatermarkColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_WatermarkColor)'| markdownify }}</td>
<td> {{'[PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_PlaceholderColor)'| markdownify }}</td>
<td>Gets or sets the color of the place holder text.</td></tr>
<tr>
<td> {{'[ClearButtonColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ClearButtonColor)'| markdownify }}</td>
<td> {{'[ClearButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_ClearButtonIconColor)'| markdownify }}</td>
<td>Gets or sets the color of the clear button.</td></tr>
<tr>
<td> {{'[ShowClearButton](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ShowClearButton)'| markdownify }}</td>
<td> {{'[IsClearButtonVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsClearButtonVisible)'| markdownify }}</td>
<td>Gets or sets whether to show the clear button.</td></tr>
<tr>
<td> {{'[MaximumDropDownHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_DropDownItemHeight)'| markdownify }}</td>
<td> {{'[MaxDropDownHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_MaxDropDownHeight)'| markdownify }} </td>
<td>Gets or sets the maximum dropdown height.</td></tr>
<tr>
<td>{{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_SuggestionMode)'| markdownify }}<br/> {{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_AutoCompleteMode)'| markdownify }}</td>
<td>{{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode)'| markdownify }}</td>
<td>Gets or sets the search mode of the control. The enum values are "StartsWith" and "Contains". <br/>When using StartsWith, the AutoCompleteMode will be set to Append. <br/> When using Contains, the AutoCompleteMode will be set to Suggest.</td></tr>
<tr>
<td> {{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ItemsSource)'| markdownify }},<br/> {{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_DataSource)'| markdownify }},<br/> {{'[AutoCompleteSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_AutoCompleteSource)'| markdownify }} </td>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource)'| markdownify }}</td>
<td>Gets or sets the data to be populated in the control.</td></tr>

<tr>
<td>
{{'[Delimiter](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_Delimiter)'| markdownify }}
</td>
<td>
{{'[DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText)'| markdownify }}
</td>
<td>Gets or sets a string as delimiter which is displayed between the selected items in multiple selection mode.</td>
</tr>

<tr>
<td>
{{'[NoResultsFoundFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontAttributes)'| markdownify }},
<br/>
{{'[NoResultsFoundFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontFamily)'| markdownify }},
<br/>
{{'[NoResultsFoundFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontSize)'| markdownify }},
<br/>
{{'[NoResultsFoundTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundTextColor)'| markdownify }}
</td>
<td>
{{'[NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate)'| markdownify }}
</td>
<td>Gets or sets the DataTemplate used to display in the dropdown when no results are found in the search.</td>
</tr>

</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th></tr>
<tr>
<td>Xamarin - {{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_SuggestionMode)'| markdownify }} <br/> .NET MAUI - {{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode)'| markdownify }}</td>
<td> {{'[StartsWith](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_StartsWith)'| markdownify }},<br/> {{'[StartsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_StartsWithCaseSensitive)'| markdownify }},<br/> {{'[Contains](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Contains)'| markdownify }},<br/> {{'[ContainsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_ContainsWithCaseSensitive)'| markdownify }},<br/> {{'[Equals](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Equals)'| markdownify }},<br/> {{'[EqualsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EqualsWithCaseSensitive)'| markdownify }},<br/> {{'[EndsWith](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EndsWith)'| markdownify }},<br/> {{'[EndsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EndsWithCaseSensitive)'| markdownify }},<br/> {{'[Custom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Custom)'| markdownify }}</td>
<td> {{'[StartsWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_StartsWith)'| markdownify }},<br/> {{'[Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains)'| markdownify }}.</td>
<td>Gets or sets the search mode of the control.</td></tr>

<tr>
<td>
Xamarin - {{'[SuggestionBoxPlacement](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html)'| markdownify }} 
<br/>
.NET MAUI - {{'[DropDownPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html)'| markdownify }} 
</td>

<td>
{{'[Auto](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Auto)'| markdownify }}, 
<br/>
{{'[Bottom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Bottom)'| markdownify }},  
<br/>
{{'[None](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_None)'| markdownify }}, 
<br/>
{{'[Top](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Top)'| markdownify }}
</td>

<td>
{{'[Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Auto)'| markdownify }}, 
<br/>
{{'[Bottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Bottom)'| markdownify }}, 
<br/>
{{'[None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_None)'| markdownify }}, 
<br/>
{{'[Top](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Top)'| markdownify }} 
</td>
<td>Gets or sets the position of the drop-down.</td>
</tr>

<tr>
<td>
Xamarin - {{'[MultiSelectMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html)'| markdownify }} 
<br/>
.NET MAUI - {{'[MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_MultiSelectionDisplayMode)'| markdownify }} 
</td>
<td>
{{'[Delimiter](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_Delimiter)'| markdownify }},
<br/>
{{'[None](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_None)'| markdownify }},
<br/>
{{'[Token](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_Token)'| markdownify }}
</td>
<td>
{{'[Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Delimiter)'| markdownify }},
<br/>
{{'[Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Token)'| markdownify }}
</td>
<td>Gets or sets the multi selection mode for the SfAutocomplete control.</td>
</tr>

</table>

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th></tr>
<tr>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged)'| markdownify }}</td>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs.html)'| markdownify }}<br/> <ul><li> {{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs.html#Syncfusion_SfAutoComplete_XForms_SelectionChangedEventArgs_Value)'| markdownify }}</li></ul></td>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[PreviousSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangedEventArgs_PreviousSelection)'| markdownify }} </li> <li>  {{'[CurrentSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangedEventArgs_CurrentSelection)'| markdownify }}</li> </ul></td>
<td>Raises when an item is selected in the dropdown or the SelectedItem is set programmatically.Returns the previous selected item and the currently selected item</td></tr>
</table> 

## Upcoming features

  * Diacritic Sensitivity
