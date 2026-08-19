---
layout: post
title: Properties in .NET MAUI Autocomplete control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® .NET MAUI Autocomplete control.
platform: maui
control: SfAutocomplete
documentation: ug
---

# API Reference for .NET MAUI Autocomplete

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText" aria-label="View DelimiterText property in API reference">DelimiterText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Specifies the text placed between selected values when <code>SelectionMode</code> is <code>Multiple</code> and <code>MultiSelectionDisplayMode</code> is <code>Delimiter</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DisplayMemberPath" aria-label="View DisplayMemberPath property in API reference">DisplayMemberPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Identifies the item property displayed in the <code>suggestion list</code>. It also supplies the search and selected-item text when <code>TextMemberPath</code> is empty.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownCornerRadius" aria-label="View DropDownCornerRadius property in API reference">DropDownCornerRadius</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerRadius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
<td>Controls the <code>corner radius</code> of the suggestion dropdown.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownFooterView" aria-label="View DropdownFooterView property in API reference">DropdownFooterView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Provides custom content for the <code>bottom</code> of the suggestion dropdown. Set <code>ShowDropdownFooterView</code> to <code>true</code> to display it.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropdownHeaderView" aria-label="View DropdownHeaderView property in API reference">DropdownHeaderView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Provides custom content for the <code>top</code> of the suggestion dropdown. Set <code>ShowDropdownHeaderView</code> to <code>true</code> to display it.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownItemFontSize" aria-label="View DropDownItemFontSize property in API reference">DropDownItemFontSize</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Controls the <code>font size</code> of suggestion text in the dropdown.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownPlacement" aria-label="View DropDownPlacement property in API reference">DropDownPlacement</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html" aria-label="View DropDownPlacement type in API reference">DropDownPlacement</a></td>
<td>Positions the suggestion dropdown using <code>Auto</code>, <code>Top</code>, or <code>Bottom</code>; <code>Auto</code> chooses a position from the available vertical space. <code>None</code> represents a dropdown that is not shown.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_EnableAutoSize" aria-label="View EnableAutoSize property in API reference">EnableAutoSize</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Allows the Autocomplete input area to expand as its content requires more space, such as when selected tokens wrap onto additional lines.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Applies the <code>Liquid Glass</code> effect to the suggestion dropdown when the Autocomplete is hosted inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 26</code> or later and <code>macOS 26</code> or later with <code>.NET 10</code> or later; unsupported configurations use the standard background.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_FilterBehavior" aria-label="View FilterBehavior property in API reference">FilterBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.IAutocompleteFilterBehavior.html" aria-label="View IAutocompleteFilterBehavior type in API reference">IAutocompleteFilterBehavior</a></td>
<td>Replaces the built-in filtering with custom logic that determines which items appear for the entered text. The custom operation can also load matching items asynchronously.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_IsDropDownShadowVisible" aria-label="View IsDropDownShadowVisible property in API reference">IsDropDownShadowVisible</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the <code>shadow</code> around the suggestion dropdown.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Supplies the items that can be searched and displayed as Autocomplete suggestions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the content and layout of each suggestion in the dropdown.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreTemplate" aria-label="View LoadMoreTemplate property in API reference">LoadMoreTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the content and layout of the <code>load-more button</code> shown at the bottom of the suggestion list.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreText" aria-label="View LoadMoreText property in API reference">LoadMoreText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Specifies the <code>label</code> displayed by the load-more button; it is not a loading-status message.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_MaximumSuggestion" aria-label="View MaximumSuggestion property in API reference">MaximumSuggestion</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Controls how many suggestions are loaded <code>initially</code> and added each time the <code>load-more button</code> is used.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_MinimumPrefixCharacters" aria-label="View MinimumPrefixCharacters property in API reference">MinimumPrefixCharacters</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Controls how many characters the user must enter before the <code>suggestion dropdown</code> opens and <code>filtering</code> begins.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_MultiSelectionDisplayMode" aria-label="View MultiSelectionDisplayMode property in API reference">MultiSelectionDisplayMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html" aria-label="View AutocompleteMultiSelectionDisplayMode type in API reference">AutocompleteMultiSelectionDisplayMode</a></td>
<td>Displays multiple selected items as <code>delimiter-separated</code> text with <code>Delimiter</code> or as individually removable <code>tokens</code> with <code>Token</code>. Applies when <code>SelectionMode</code> is <code>Multiple</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate" aria-label="View NoResultsFoundTemplate property in API reference">NoResultsFoundTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the content shown in the suggestion dropdown when <code>filtering</code> produces no matches.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundText" aria-label="View NoResultsFoundText property in API reference">NoResultsFoundText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Specifies the message shown in the suggestion dropdown when <code>filtering</code> produces no matches.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ReturnCommand" aria-label="View ReturnCommand property in API reference">ReturnCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Runs when the user presses the keyboard's <code>Return</code> or <code>Enter</code> key in the editable input field.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ReturnCommandParameter" aria-label="View ReturnCommandParameter property in API reference">ReturnCommandParameter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Supplies the value passed to <code>ReturnCommand</code> when the user presses <code>Return</code> or <code>Enter</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ReturnType" aria-label="View ReturnType property in API reference">ReturnType</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.returntype" aria-label="View ReturnType type in API reference">ReturnType</a></td>
<td>Changes the action label or icon shown on the software keyboard's <code>Return</code> key. Supported values are <code>Default</code>, <code>Done</code>, <code>Go</code>, <code>Next</code>, <code>Search</code>, and <code>Send</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SearchBehavior" aria-label="View SearchBehavior property in API reference">SearchBehavior</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.IAutocompleteSearchBehavior.html" aria-label="View IAutocompleteSearchBehavior type in API reference">IAutocompleteSearchBehavior</a></td>
<td>Applies custom logic to choose which filtered suggestion is highlighted initially; without custom logic, the <code>first matching item</code> is highlighted.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedDropDownItem" aria-label="View SelectedDropDownItem property in API reference">SelectedDropDownItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Verification required: this API is not present in the current <code>DropDownListBase</code> or <code>SfAutocomplete</code> API reference; use <code>SelectedItem</code> for the selected data item.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedDropDownItems" aria-label="View SelectedDropDownItems property in API reference">SelectedDropDownItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ilist" aria-label="View IList type in API reference">IList</a></td>
<td>Verification required: this API is not present in the current <code>DropDownListBase</code> or <code>SfAutocomplete</code> API reference; use <code>SelectedItems</code> for multiple selected data items.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItem" aria-label="View SelectedItem property in API reference">SelectedItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Represents the item selected from the <code>suggestion list</code> in <code>Single</code> selection mode and can also be assigned to select an item programmatically.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedItems" aria-label="View SelectedItems property in API reference">SelectedItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ilist" aria-label="View IList type in API reference">IList</a></td>
<td>Contains the items selected from the <code>suggestion list</code> when <code>SelectionMode</code> is <code>Multiple</code> and can be updated to change the selection programmatically.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValue" aria-label="View SelectedValue property in API reference">SelectedValue</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Exposes the value read from the selected item through <code>SelectedValuePath</code>; when that path is empty, the control uses the item's text representation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectedValuePath" aria-label="View SelectedValuePath property in API reference">SelectedValuePath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Identifies the selected item property exposed through <code>SelectedValue</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteSelectionMode.html" aria-label="View AutocompleteSelectionMode type in API reference">AutocompleteSelectionMode</a></td>
<td>Allows one suggestion to be selected with <code>Single</code> or multiple suggestions with <code>Multiple</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionTextHighlightColor" aria-label="View SelectionTextHighlightColor property in API reference">SelectionTextHighlightColor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
<td>Controls the background color applied by the platform when text is selected in the Autocomplete input field; it does not style matching text in suggestions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ShowBorder" aria-label="View ShowBorder property in API reference">ShowBorder</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the <code>border</code> around the Autocomplete input field.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownFooterView" aria-label="View ShowDropdownFooterView property in API reference">ShowDropdownFooterView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the custom <code>footer</code> supplied through <code>DropdownFooterView</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowDropdownHeaderView" aria-label="View ShowDropdownHeaderView property in API reference">ShowDropdownHeaderView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Shows or hides the custom <code>header</code> supplied through <code>DropdownHeaderView</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ShowSuggestionsOnFocus" aria-label="View ShowSuggestionsOnFocus property in API reference">ShowSuggestionsOnFocus</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Opens the complete <code>suggestion list</code> when the empty Autocomplete input receives <code>focus</code>, without waiting for typed characters.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Text" aria-label="View Text property in API reference">Text</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Contains the text entered or displayed in the editable Autocomplete input. Changes to this property have <code>no effect</code> in a non-editable dropdown control derived from the same base class.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextHighlightMode" aria-label="View TextHighlightMode property in API reference">TextHighlightMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.TextHighlightMode.html" aria-label="View TextHighlightMode type in API reference">TextHighlightMode</a></td>
<td>Controls whether matching text in suggestions is highlighted using <code>None</code>, <code>FirstOccurrence</code>, or <code>MultipleOccurrence</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TextMemberPath" aria-label="View TextMemberPath property in API reference">TextMemberPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Identifies the item property used to search from the entered text and display the selected value in the input area. When empty, <code>DisplayMemberPath</code> is used instead.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode" aria-label="View TextSearchMode property in API reference">TextSearchMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html" aria-label="View AutocompleteTextSearchMode type in API reference">AutocompleteTextSearchMode</a></td>
<td>Filters suggestions with <code>StartsWith</code> when their text begins with the entered value or with <code>Contains</code> when it appears anywhere in their text; built-in matching is case-insensitive and accent-insensitive.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_TokenItemStyle" aria-label="View TokenItemStyle property in API reference">TokenItemStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.TokenItemStyle.html" aria-label="View TokenItemStyle type in API reference">TokenItemStyle</a></td>
<td>Styles selected-item tokens when <code>SelectionMode</code> is <code>Multiple</code> and <code>MultiSelectionDisplayMode</code> is <code>Token</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TokensWrapMode" aria-label="View TokensWrapMode property in API reference">TokensWrapMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTokensWrapMode.html" aria-label="View AutocompleteTokensWrapMode type in API reference">AutocompleteTokensWrapMode</a></td>
<td>Keeps selected tokens on one <code>horizontal line</code> with <code>None</code> or places overflowing tokens on additional <code>vertical lines</code> with <code>Wrap</code>. Applies only to multiple selection in <code>Token</code> display mode.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Clear" aria-label="View Clear method in API reference">Clear()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
<td>Clears the <code>input text</code> and current <code>selection</code>, returning the Autocomplete to an <code>empty state</code>.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ClearButtonClicked" aria-label="View ClearButtonClicked event in API reference">ClearButtonClicked</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
<td>Triggered when the user activates the <code>clear button</code> after the control clears its current <code>input</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Completed" aria-label="View Completed event in API reference">Completed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
<td>Triggered when the user presses <code>Return</code> or <code>Enter</code> after entering text. Applies only to an <code>editable input</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DropDownClosed" aria-label="View DropDownClosed event in API reference">DropDownClosed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
<td>Triggered after the <code>suggestion dropdown</code> closes, whether or not the <code>selection</code> changed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Focused" aria-label="View Focused event in API reference">Focused</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;FocusEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.focuseventargs" aria-label="View FocusEventArgs type in API reference">FocusEventArgs</a>&gt;</a></td>
<td>Triggered when the Autocomplete input receives <code>keyboard focus</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_LoadMoreButtonTapped" aria-label="View LoadMoreButtonTapped event in API reference">LoadMoreButtonTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
<td>Triggered when the user taps the <code>load-more button</code>, allowing the application to provide additional suggestions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html" aria-label="View SelectionChangedEventArgs type in API reference">SelectionChangedEventArgs</a>&gt;</a></td>
<td>Triggered after the selected item or selected-items collection changes and provides the <code>previous</code> and <code>current</code> selections.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionChangingEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangingEventArgs.html" aria-label="View SelectionChangingEventArgs type in API reference">SelectionChangingEventArgs</a>&gt;</a></td>
<td>Triggered before the selection changes and provides the <code>previous</code> and <code>proposed</code> selections; the <code>pending change</code> can be canceled.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_Unfocused" aria-label="View Unfocused event in API reference">Unfocused</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;FocusEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.focuseventargs" aria-label="View FocusEventArgs type in API reference">FocusEventArgs</a>&gt;</a></td>
<td>Triggered when the Autocomplete input loses <code>keyboard focus</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;AutocompleteValueChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteValueChangedEventArgs.html" aria-label="View AutocompleteValueChangedEventArgs type in API reference">AutocompleteValueChangedEventArgs</a>&gt;</a></td>
<td>Triggered when the <code>text</code> in the Autocomplete input changes and provides both the <code>previous</code> and <code>new</code> text values.</td>
</tr>

</table>
