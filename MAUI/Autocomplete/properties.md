---
layout: post
title: Properties of .NET MAUI AutoComplete control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI AutoComplete (SfAutocomplete) control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# .NET MAUI AutoComplete API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize">EnableAutoSize</a></td>
        <td>bool</td>
        <td>Defines whether the control adjusts its size automatically.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_FilterBehavior">FilterBehavior</a></td>
        <td>IAutocompleteFilterBehavior</td>
        <td>Defines the behavior used to filter items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_HorizontalTextAlignment">HorizontalTextAlignment</a></td>
        <td>TextAlignment</td>
        <td>Defines the horizontal alignment of the text in the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_MultiSelectionDisplayMode">MultiSelectionDisplayMode</a></td>
        <td>AutocompleteMultiSelectionDisplayMode</td>
        <td>Defines how selected items are displayed in multiple selection mode.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SearchBehavior">SearchBehavior</a></td>
        <td>IAutocompleteSearchBehavior</td>
        <td>Defines the behavior used to search items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode">SelectionMode</a></td>
        <td>AutocompleteSelectionMode</td>
        <td>Defines the selection mode of the control.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ShowBorder">ShowBorder</a></td>
        <td>bool</td>
        <td>Defines whether the control border is shown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode">TextSearchMode</a></td>
        <td>AutocompleteTextSearchMode</td>
        <td>Defines the text search mode used for matching items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode">TokensWrapMode</a></td>
        <td>AutocompleteTokensWrapMode</td>
        <td>Defines how tokens wrap in multiple selection mode.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_VerticalTextAlignment">VerticalTextAlignment</a></td>
        <td>TextAlignment</td>
        <td>Defines the vertical alignment of the text in the control.</td>
    </tr>
</table>

## Events

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ClearButtonClicked">ClearButtonClicked</a></td>
        <td>EventHandler</td>
        <td>Raised when the clear button is clicked.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ValueChanged">ValueChanged</a></td>
        <td>EventHandler&lt;AutocompleteValueChangedEventArgs&gt;</td>
        <td>Raised when the selected value changes.</td>
    </tr>
</table>

## Methods

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_OnValueChanged_System_String_System_String_">OnValueChanged(string, string)</a></td>
        <td>void</td>
        <td>Called when the value changes.</td>
    </tr>
</table>