---
layout: post
title: Properties in .NET MAUI Smart Text Editor | Syncfusion®
description: Reference for properties, methods, and events of the Syncfusion® .NET MAUI SmartTextEditor.
platform: maui
control: SfSmartTextEditor
documentation: ug
---

# API Reference for .NET MAUI SfSmartTextEditor

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Applies the Liquid Glass effect to the text editor and its dependent controls when the editor is placed inside an SfGlassEffectView. Supported on iOS 26 or later and macOS 26 or later with .NET 10 or later; unsupported configurations render the standard background.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_MaxLength" aria-label="View MaxLength property in API reference">MaxLength</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Caps the number of characters a user can type or paste into the editor; once the limit is reached, additional input is ignored.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_Placeholder" aria-label="View Placeholder property in API reference">Placeholder</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Shows dimmed hint text inside the editor whenever the Text is empty, and clears it as soon as the user starts typing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_PlaceholderColor" aria-label="View PlaceholderColor property in API reference">PlaceholderColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Tints the placeholder hint text shown when the editor is empty.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_SuggestionDisplayMode" aria-label="View SuggestionDisplayMode property in API reference">SuggestionDisplayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SuggestionDisplayMode.html" aria-label="View SuggestionDisplayMode type in API reference">SuggestionDisplayMode</a></td>
    <td>Controls where AI-completion suggestions appear: Inline renders the predicted text in place after the caret, and Popup shows a small overlay near the caret. Windows and Mac Catalyst default to Inline; Android and iOS default to Popup.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_SuggestionPopupBackground" aria-label="View SuggestionPopupBackground property in API reference">SuggestionPopupBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Paints the background of the suggestion overlay shown in Popup display mode; it has no visible effect when SuggestionDisplayMode is Inline.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_SuggestionTextColor" aria-label="View SuggestionTextColor property in API reference">SuggestionTextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Specifies the color of the suggested completion text displayed in both Inline and Popup suggestion modes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_Text" aria-label="View Text property in API reference">Text</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Holds the editor's current text content, including any accepted suggestion text. Bind it to pre-populate the editor or to capture user input in a view model.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_TextChangedCommand" aria-label="View TextChangedCommand property in API reference">TextChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Invokes the bound ICommand each time the editor's text changes, supporting MVVM-style reactions without a code-behind handler.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SmartTextEditorStyle.html" aria-label="View SmartTextEditorStyle type in API reference">SmartTextEditorStyle</a></td>
    <td>Applies font settings—such as FontSize and TextColor—to the text the user types in the editor, via a SmartTextEditorStyle instance.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_UserPhrases" aria-label="View UserPhrases property in API reference">UserPhrases</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.list-1" aria-label="View List type in API reference">List&lt;string&gt;</a></td>
    <td>Supplies a list of reusable phrases used to bias AI completions toward your brand voice, and as a fallback for offline suggestions when no AI inference service is configured.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_UserRole" aria-label="View UserRole property in API reference">UserRole</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Describes who is typing and their intent, shaping the tone and relevance of AI-generated suggestions; required for AI-powered completions.</td>
</tr>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartTextEditor.html#Syncfusion_Maui_SmartComponents_SfSmartTextEditor_TextChanged" aria-label="View TextChanged event in API reference">TextChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;TextChangedEventArgs&gt;</a></td>
    <td>Triggered whenever the editor's text changes, with TextChangedEventArgs exposing the previous and new text values for comparison.</td>
</tr>

</table>