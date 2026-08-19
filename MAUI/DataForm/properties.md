---
layout: post
title: Properties of .NET MAUI DataForm control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI DataForm (SfDataForm) control.
platform: maui
control: SfDataForm
documentation: ug
---

# API Reference for .NET MAUI DataForm

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_AutoGenerateItems" aria-label="View AutoGenerateItems property in API reference">AutoGenerateItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether form items are generated automatically from the bound data object and enables the control to build the field list without manual item definitions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ColumnCount" aria-label="View ColumnCount property in API reference">ColumnCount</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
<td>Defines the number of columns used to arrange form items and controls how the editing surface is distributed across the available layout width.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_CommitMode" aria-label="View CommitMode property in API reference">CommitMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html" aria-label="View DataFormCommitMode enum in API reference">DataFormCommitMode</a></td>
<td>Defines when editor values are committed to the data object by using the <code>DataFormCommitMode</code> enum and controls how field updates flow into the underlying source.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject" aria-label="View DataObject property in API reference">DataObject</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Represents the data object displayed in the form and supplies the source instance whose properties are exposed for editing and validation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DefaultLayoutSettings" aria-label="View DefaultLayoutSettings property in API reference">DefaultLayoutSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html" aria-label="View DataFormDefaultLayoutSettings type in API reference">DataFormDefaultLayoutSettings</a></td>
<td>Defines the default layout settings used for form items and controls how spacing, alignment, and arrangement are applied to generated editors.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_EditorTextStyle" aria-label="View EditorTextStyle property in API reference">EditorTextStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
<td>Defines the text style applied to editor content and controls typography-related settings such as font appearance, size, and color for editable fields.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ErrorLabelTextStyle" aria-label="View ErrorLabelTextStyle property in API reference">ErrorLabelTextStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
<td>Defines the text style applied to validation error labels and controls the visual presentation of error messages displayed for invalid fields.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GroupHeaderTemplate" aria-label="View GroupHeaderTemplate property in API reference">GroupHeaderTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used for group headers and enables custom visual structure for sections that organize related form items.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_IsReadOnly" aria-label="View IsReadOnly property in API reference">IsReadOnly</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the data form is read-only and controls whether the displayed fields accept editing input or remain display-only.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemManager" aria-label="View ItemManager property in API reference">ItemManager</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItemManager.html" aria-label="View DataFormItemManager type in API reference">DataFormItemManager</a></td>
<td>Provides the item manager used to coordinate data form items and manages the internal item collection and related state transitions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items" aria-label="View Items property in API reference">Items</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html?tabs=tabid-6%2Ctabid-11%2Ctabid-21%2Ctabid-16%2Ctabid-1" aria-label="View DataFormItemCollection type in API reference">ObservableCollection&lt;DataFormViewItem&gt;</a></td>
<td>Provides the collection of items displayed in the data form and stores the configured form entries that participate in layout and validation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemsSourceProvider" aria-label="View ItemsSourceProvider property in API reference">ItemsSourceProvider</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.IDataFormItemsSourceProvider.html" aria-label="View IDataFormItemsSourceProvider type in API reference">IDataFormItemsSourceProvider</a></td>
<td>Provides custom item sources for editors and supplies lookup data or selection lists used by supported form editors.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_LabelTextStyle" aria-label="View LabelTextStyle property in API reference">LabelTextStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
<td>Defines the text style applied to field labels and controls the typography used to display field captions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_LayoutType" aria-label="View LayoutType property in API reference">LayoutType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormLayoutType.html" aria-label="View DataFormLayoutType enum in API reference">DataFormLayoutType</a></td>
<td>Defines the layout type of the data form by using the <code>DataFormLayoutType</code> enum and controls whether items are arranged in a default, stacked, or custom layout structure.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_TextInputLayoutSettings" aria-label="View TextInputLayoutSettings property in API reference">TextInputLayoutSettings</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html" aria-label="View TextInputLayoutSettings type in API reference">TextInputLayoutSettings</a></td>
<td>Defines the layout settings for text input editors and controls the arrangement of text-based input fields inside the form.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidationMode" aria-label="View ValidationMode property in API reference">ValidationMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidationMode.html" aria-label="View DataFormValidationMode enum in API reference">DataFormValidationMode</a></td>
<td>Defines how validation is performed by using the <code>DataFormValidationMode</code> enum and controls when validation is triggered during editing or commit flow.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidMessageLabelTextStyle" aria-label="View ValidMessageLabelTextStyle property in API reference">ValidMessageLabelTextStyle</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
<td>Defines the text style applied to validation success messages and controls the appearance of positive validation feedback.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Commit" aria-label="View Commit method in API reference">Commit()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Commits the editor values to the data object and applies the current pending edits to the bound source.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GetDataFormGroupItem_System_String_" aria-label="View GetDataFormGroupItem(String) method in API reference">GetDataFormGroupItem(String)</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html" aria-label="View DataFormGroupItem type in API reference">DataFormGroupItem</a></td>
<td>Returns the specified data form group item and provides access to the grouped section that matches the supplied field or group name.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GetDataFormItem_System_String_" aria-label="View GetDataFormItem(String) method in API reference">GetDataFormItem(String)</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html" aria-label="View DataFormItem type in API reference">DataFormItem</a></td>
<td>Returns the data form item associated with the specified property name and provides the configured field metadata for the matching entry.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_DataFormEditorType_" aria-label="View RegisterEditor(String, DataFormEditorType) method in API reference">RegisterEditor(String, DataFormEditorType)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Registers an editor type for the specified property and maps the field to a predefined editor configuration.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_IDataFormEditor_" aria-label="View RegisterEditor(String, IDataFormEditor) method in API reference">RegisterEditor(String, IDataFormEditor)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Registers a custom editor for the specified property and allows a tailored editor implementation to be associated with the field.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_Type_Syncfusion_Maui_DataForm_DataFormEditorType_" aria-label="View RegisterEditor(Type, DataFormEditorType) method in API reference">RegisterEditor(Type, DataFormEditorType)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Registers an editor type for the specified data type and applies editor mapping based on the underlying CLR type.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ScrollTo_System_String_" aria-label="View ScrollTo(String) method in API reference">ScrollTo(String)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Scrolls to the specified data form item and brings the matching field into view within the current layout.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_UpdateEditor_System_String_" aria-label="View UpdateEditor(String) method in API reference">UpdateEditor(String)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Updates the editor associated with the specified property and refreshes the editor state for the matching data field.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Validate" aria-label="View Validate() method in API reference">Validate()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Validates all data form items and returns whether every field satisfies the configured validation rules.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Validate_System_Collections_Generic_List_System_String__" aria-label="View Validate(List&lt;String&gt;) method in API reference">Validate(List&lt;String&gt;)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Validates the specified data form items and returns whether the listed fields pass the active validation rules.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GenerateDataFormItem" aria-label="View GenerateDataFormItem event in API reference">GenerateDataFormItem</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.GenerateDataFormItemEventArgs.html" aria-label="View GenerateDataFormItemEventArgs type in API reference">GenerateDataFormItemEventArgs</a></td>
<td>Raised when a data form item is being generated and allows the generated field configuration to be observed or adjusted before it is displayed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateForm" aria-label="View ValidateForm event in API reference">ValidateForm</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidateFormEventArgs.html" aria-label="View DataFormValidateFormEventArgs type in API reference">DataFormValidateFormEventArgs</a></td>
<td>Raised when the data form is validated and provides the validation scope information for the complete form life cycle.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateProperty" aria-label="View ValidateProperty event in API reference">ValidateProperty</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidatePropertyEventArgs.html" aria-label="View DataFormValidatePropertyEventArgs type in API reference">DataFormValidatePropertyEventArgs</a></td>
<td>Raised when an individual property is validated and provides validation details for the field currently under evaluation.</td>
</tr>

</table>