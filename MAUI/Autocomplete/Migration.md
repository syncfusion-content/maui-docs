---
layout: post
title: Migrating from Xamarin to .NET MAUI SfAutocomplete | Syncfusion®
description: Learn how to migrate from Syncfusion® Xamarin SfAutoComplete to the Syncfusion® .NET MAUI SfAutocomplete control, including API renames, removed features, and code samples.
platform: maui
control: SfAutocomplete
documentation: ug
---

# Migrating from Xamarin SfAutoComplete to .NET MAUI SfAutocomplete

## Prerequisites

Before migrating, ensure you have the following:

- A Xamarin.Forms project that uses the [Syncfusion Xamarin SfAutoComplete](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html) (`Syncfusion.SfAutoComplete.XForms`).
- The .NET MAUI workload installed. Refer to Microsoft's [Migrate from Xamarin.Forms to .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/migration/forms-to-maui) guide.
- The [Syncfusion.Maui.Inputs](https://www.nuget.org/packages/Syncfusion.Maui.Inputs) NuGet package installed in the .NET MAUI project.
- The `ConfigureSyncfusionCore()` call registered in `MauiProgram.cs`. See the [Getting Started](Getting-Started.md) page for details.

## Overview

To make migration easier, most of the Xamarin SfAutoComplete APIs are kept in the [.NET MAUI SfAutocomplete](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html). However, to maintain consistent API naming in the .NET MAUI SfAutocomplete, some APIs have been renamed. The API changes from Xamarin SfAutoComplete to .NET MAUI SfAutocomplete are detailed below.

The migration is performed in three steps:

1. Update the namespaces (XAML and C#).
2. Update renamed properties, enums, and events using the tables below.
3. Replace any removed APIs with their .NET MAUI equivalents (see [Removed APIs](#removed-apis)).

## Step 1: Update the namespaces

Update the namespaces in both XAML and C# files.

<table>
<tr>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
</tr>
<tr>
<td><code>Syncfusion.SfAutoComplete.XForms</code></td>
<td><code>Syncfusion.Maui.Inputs</code></td>
</tr>
</table>

**XAML**

{% tabs %}
{% highlight xaml %}

<!-- Xamarin -->
xmlns:autocomplete="clr-namespace:Syncfusion.SfAutoComplete.XForms;assembly=Syncfusion.SfAutoComplete.XForms"

<!-- .NET MAUI -->
xmlns:autocomplete="clr-namespace:Syncfusion.Maui.Inputs;assembly=Syncfusion.Maui.Inputs"

{% endhighlight %}
{% highlight C# %}

// Xamarin
using Syncfusion.SfAutoComplete.XForms;

// .NET MAUI
using Syncfusion.Maui.Inputs;

{% endhighlight %}
{% endtabs %}

## Step 2: Update renamed properties

<table>
<tr>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[Watermark](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_Watermark)' | markdownify }}</td>
<td>{{'[Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_Placeholder)' | markdownify }}</td>
<td>Gets or sets the placeholder text.</td>
</tr>
<tr>
<td>{{'[WatermarkColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_WatermarkColor)' | markdownify }}</td>
<td>{{'[PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_PlaceholderColor)' | markdownify }}</td>
<td>Gets or sets the color of the placeholder text.</td>
</tr>
<tr>
<td>{{'[ClearButtonColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ClearButtonColor)' | markdownify }}</td>
<td>{{'[ClearButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_ClearButtonIconColor)' | markdownify }}</td>
<td>Gets or sets the color of the clear button.</td>
</tr>
<tr>
<td>{{'[ShowClearButton](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ShowClearButton)' | markdownify }}</td>
<td>{{'[IsClearButtonVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_IsClearButtonVisible)' | markdownify }}</td>
<td>Gets or sets a value that indicates whether the clear button is shown.</td>
</tr>
<tr>
<td>{{'[MaximumDropDownHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_MaximumDropDownHeight)' | markdownify }}</td>
<td>{{'[MaxDropDownHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfDropdownEntry.html#Syncfusion_Maui_Core_SfDropdownEntry_MaxDropDownHeight)' | markdownify }}</td>
<td>Gets or sets the maximum drop-down height.</td>
</tr>
<tr>
<td>{{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_SuggestionMode)' | markdownify }}<br/>{{'[AutoCompleteMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_AutoCompleteMode)' | markdownify }}</td>
<td>{{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode)' | markdownify }}</td>
<td>Gets or sets the search mode of the control. Supported values are <code>StartsWith</code> and <code>Contains</code>. <br/><strong>Note:</strong> <code>AutoCompleteMode</code> is not a property of the .NET MAUI SfAutocomplete; only <code>TextSearchMode</code> is used.</td>
</tr>
<tr>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_ItemsSource)' | markdownify }},<br/>{{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_DataSource)' | markdownify }},<br/>{{'[AutoCompleteSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_AutoCompleteSource)' | markdownify }}</td>
<td>{{'[ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_ItemsSource)' | markdownify }}</td>
<td>Gets or sets the data to be populated in the control.</td>
</tr>
<tr>
<td>{{'[Delimiter](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_Delimiter)' | markdownify }}</td>
<td>{{'[DelimiterText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_DelimiterText)' | markdownify }}</td>
<td>Gets or sets the string used as the delimiter between selected items in multiple selection mode.</td>
</tr>
<tr>
<td>{{'[NoResultsFoundFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontAttributes)' | markdownify }}<br/>{{'[NoResultsFoundFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontFamily)' | markdownify }}<br/>{{'[NoResultsFoundFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundFontSize)' | markdownify }}<br/>{{'[NoResultsFoundTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_NoResultsFoundTextColor)' | markdownify }}</td>
<td>{{'[NoResultsFoundTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_NoResultsFoundTemplate)' | markdownify }}</td>
<td>Gets or sets the <code>DataTemplate</code> used to display content in the drop-down when no results are found in the search.</td>
</tr>
</table>

N> **Customizing the no-results message**: The four Xamarin `NoResultsFound*` properties have been replaced by a single `DataTemplate`. Define the styling in the template instead.

{% tabs %}
{% highlight xaml %}

<editors:SfAutocomplete x:Name="autocomplete"
                        ItemsSource="{Binding SocialMedias}"
                        DisplayMemberPath="Name"
                        TextMemberPath="Name">
    <editors:SfAutocomplete.NoResultsFoundTemplate>
        <DataTemplate>
            <Label Text="No matching items"
                   TextColor="Red"
                   FontAttributes="Italic"
                   HorizontalOptions="Center"
                   VerticalOptions="Center" />
        </DataTemplate>
    </editors:SfAutocomplete.NoResultsFoundTemplate>
</editors:SfAutocomplete>

{% endhighlight %}
{% endtabs %}

## Step 3: Update renamed enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th>
</tr>
<tr>
<td>Xamarin – {{'[SuggestionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SfAutoComplete.html#Syncfusion_SfAutoComplete_XForms_SfAutoComplete_SuggestionMode)' | markdownify }}<br/>.NET MAUI – {{'[TextSearchMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_TextSearchMode)' | markdownify }}</td>
<td>{{'[StartsWith](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_StartsWith)' | markdownify }},<br/>{{'[StartsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_StartsWithCaseSensitive)' | markdownify }},<br/>{{'[Contains](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Contains)' | markdownify }},<br/>{{'[ContainsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_ContainsWithCaseSensitive)' | markdownify }},<br/>{{'[Equals](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Equals)' | markdownify }},<br/>{{'[EqualsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EqualsWithCaseSensitive)' | markdownify }},<br/>{{'[EndsWith](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EndsWith)' | markdownify }},<br/>{{'[EndsWithCaseSensitive](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_EndsWithCaseSensitive)' | markdownify }},<br/>{{'[Custom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionMode.html#Syncfusion_SfAutoComplete_XForms_SuggestionMode_Custom)' | markdownify }}</td>
<td>{{'[StartsWith](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_StartsWith)' | markdownify }},<br/>{{'[Contains](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteTextSearchMode.html#Syncfusion_Maui_Inputs_AutocompleteTextSearchMode_Contains)' | markdownify }}</td>
<td>Gets or sets the search mode of the control.</td>
</tr>
<tr>
<td>Xamarin – {{'[SuggestionBoxPlacement](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html)' | markdownify }}<br/>.NET MAUI – {{'[DropDownPlacement](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html)' | markdownify }}</td>
<td>{{'[Auto](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Auto)' | markdownify }},<br/>{{'[Bottom](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Bottom)' | markdownify }},<br/>{{'[None](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_None)' | markdownify }},<br/>{{'[Top](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SuggestionBoxPlacement.html#Syncfusion_SfAutoComplete_XForms_SuggestionBoxPlacement_Top)' | markdownify }}</td>
<td>{{'[Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Auto)' | markdownify }},<br/>{{'[Bottom](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Bottom)' | markdownify }},<br/>{{'[None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_None)' | markdownify }},<br/>{{'[Top](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.DropDownPlacement.html#Syncfusion_Maui_Core_DropDownPlacement_Top)' | markdownify }}</td>
<td>Gets or sets the position of the drop-down.</td>
</tr>
<tr>
<td>Xamarin – {{'[MultiSelectMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html)' | markdownify }}<br/>.NET MAUI – {{'[MultiSelectionDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfAutocomplete.html#Syncfusion_Maui_Inputs_SfAutocomplete_MultiSelectionDisplayMode)' | markdownify }}</td>
<td>{{'[Delimiter](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_Delimiter)' | markdownify }},<br/>{{'[None](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_None)' | markdownify }},<br/>{{'[Token](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.MultiSelectMode.html#Syncfusion_SfAutoComplete_XForms_MultiSelectMode_Token)' | markdownify }}</td>
<td>{{'[Delimiter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Delimiter)' | markdownify }},<br/>{{'[Token](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.AutocompleteMultiSelectionDisplayMode.html#Syncfusion_Maui_Inputs_AutocompleteMultiSelectionDisplayMode_Token)' | markdownify }}</td>
<td>Gets or sets the multi-selection display mode of the SfAutocomplete control.</td>
</tr>
</table>

N> **Removed `SuggestionMode` values**: The case-sensitive variants (`StartsWithCaseSensitive`, `ContainsWithCaseSensitive`, `EqualsWithCaseSensitive`, `EndsWithCaseSensitive`), `Equals`, `EndsWith`, and `Custom` are not available in the .NET MAUI SfAutocomplete. To use custom matching logic, implement a custom filter via the `ItemsSource` or wrap the source collection.

N> **Removed `MultiSelectMode.None`**: `MultiSelectMode.None` is not available in the .NET MAUI SfAutocomplete. To disable a specific display mode, leave `MultiSelectionDisplayMode` at its default value.

## Step 4: Update events

<table>
<tr>
<th>Event Name</th>
<th>Xamarin SfAutoComplete</th>
<th>.NET MAUI SfAutocomplete</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.DropDownControls.DropDownListBase.html#Syncfusion_Maui_Inputs_DropDownControls_DropDownListBase_SelectionChanged)' | markdownify }}</td>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs.html)' | markdownify }}<br/><ul><li>{{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs.html#Syncfusion_SfAutoComplete_XForms_SelectionChangedEventArgs_Value)' | markdownify }}</li></ul></td>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html)' | markdownify }}<br/><ul><li>{{'[PreviousSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangedEventArgs_PreviousSelection)' | markdownify }}</li><li>{{'[CurrentSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SelectionChangedEventArgs.html#Syncfusion_Maui_Inputs_SelectionChangedEventArgs_CurrentSelection)' | markdownify }}</li></ul></td>
<td>Raises when an item is selected in the drop-down or when the selected item is set programmatically. Returns the previous and currently selected items.</td>
</tr>
</table>

The `SelectionChanged` event payload has changed: the Xamarin `Value` property has been replaced by `PreviousSelection` and `CurrentSelection` in .NET MAUI.

{% tabs %}
{% highlight c# %}

// Xamarin
autocomplete.SelectionChanged += (s, e) =>
{
    var selected = e.Value;
};

// .NET MAUI
autocomplete.SelectionChanged += (s, e) =>
{
    var previous = e.PreviousSelection;
    var current = e.CurrentSelection;
};

{% endhighlight %}
{% endtabs %}

## Removed APIs

The following Xamarin APIs have been removed in the .NET MAUI SfAutocomplete:

- `AutoCompleteMode` (replaced by `TextSearchMode`).
- `SuggestionMode.Equals`, `SuggestionMode.EndsWith`, `SuggestionMode.Custom`, and the case-sensitive variants.
- `MultiSelectMode.None`.
- `FilterStartIndex`, `FilterEndIndex`, and other custom-filter helpers.
- `NoResultsFoundFontAttributes`, `NoResultsFoundFontFamily`, `NoResultsFoundFontSize`, and `NoResultsFoundTextColor` (replaced by `NoResultsFoundTemplate`).

N> **Custom filtering**: If you used `SuggestionMode.Custom` in Xamarin, implement a custom `ItemsSource` in .NET MAUI (for example, a `CollectionView` or a filtered `ObservableCollection`) and bind it to the SfAutocomplete `ItemsSource`.

## Upcoming features

- **Diacritic sensitivity** — Allows the search to match accented and non-accented characters (for example, "café" matches "cafe"). Targeted for a future `Syncfusion.Maui.Inputs` release.

## See also

- [Getting Started](Getting-Started.md)
- [Selection](Selection.md)
- [UI Customization](UI-Customization.md)
- [Microsoft: Migrate from Xamarin.Forms to .NET MAUI](https://learn.microsoft.com/en-us/dotnet/maui/migration/forms-to-maui)
- [GitHub: .NET MAUI Autocomplete samples](https://github.com/SyncfusionExamples/maui-autocomplete-samples)
