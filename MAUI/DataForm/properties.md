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
    <td>Controls whether <code>form items</code> are generated <code>automatically</code> from the bound <code>DataObject</code>. When <code>true</code>, the form builds an <code>editor</code> for every editable <code>property</code>; manually added items can still be merged with the generated ones.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ColumnCount" aria-label="View ColumnCount property in API reference">ColumnCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Number of <code>columns</code> used to arrange <code>form items</code> across the available <code>layout width</code>. Larger values place more <code>editors</code> side by side.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_CommitMode" aria-label="View CommitMode property in API reference">CommitMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormCommitMode.html" aria-label="View DataFormCommitMode enum in API reference">DataFormCommitMode</a></td>
    <td>Controls when <code>editor values</code> are committed to the <code>data object</code>. Choose a supported <code>DataFormCommitMode</code> value such as <code>LostFocus</code>, <code>PropertyChanged</code>, or <code>Manual</code> to define how <code>field updates</code> flow into the <code>underlying source</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DataObject" aria-label="View DataObject property in API reference">DataObject</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Source object</code> whose <code>properties</code> are exposed for <code>editing</code>, <code>validation</code>, and <code>data binding</code> in the <code>form</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_DefaultLayoutSettings" aria-label="View DefaultLayoutSettings property in API reference">DefaultLayoutSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormDefaultLayoutSettings.html" aria-label="View DataFormDefaultLayoutSettings type in API reference">DataFormDefaultLayoutSettings</a></td>
    <td><code>Layout settings</code> applied to <code>generated editors</code>, including <code>spacing</code>, <code>label position</code>, and <code>arrangement defaults</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_EditorTextStyle" aria-label="View EditorTextStyle property in API reference">EditorTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
    <td><code>Text style</code> applied to the <code>content</code> of <code>editors</code>, controlling <code>font</code>, <code>size</code>, and <code>color</code> for <code>editable fields</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ErrorLabelTextStyle" aria-label="View ErrorLabelTextStyle property in API reference">ErrorLabelTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
    <td><code>Text style</code> applied to <code>validation error labels</code> shown beneath <code>invalid fields</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GroupHeaderTemplate" aria-label="View GroupHeaderTemplate property in API reference">GroupHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render <code>group headers</code>. Use it to customize the <code>visual presentation</code> of <code>sections</code> that organize related <code>form items</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_IsReadOnly" aria-label="View IsReadOnly property in API reference">IsReadOnly</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the displayed <code>fields</code> accept <code>editing input</code>. Set this to <code>true</code> to make the form <code>display-only</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemManager" aria-label="View ItemManager property in API reference">ItemManager</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItemManager.html" aria-label="View DataFormItemManager type in API reference">DataFormItemManager</a></td>
    <td><code>Item manager</code> that coordinates the internal <code>item collection</code> and <code>state transitions</code>, such as <code>register</code> or <code>update</code> operations.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Items" aria-label="View Items property in API reference">Items</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormViewItem.html?tabs=tabid-6%2Ctabid-11%2Ctabid-21%2Ctabid-16%2Ctabid-1" aria-label="View DataFormItemCollection type in API reference">ObservableCollection&lt;DataFormViewItem&gt;</a></td>
    <td><code>Collection</code> of <code>DataFormViewItem</code> entries displayed in the <code>form</code>, including <code>generated</code> and <code>manually configured</code> items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ItemsSourceProvider" aria-label="View ItemsSourceProvider property in API reference">ItemsSourceProvider</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.IDataFormItemsSourceProvider.html" aria-label="View IDataFormItemsSourceProvider type in API reference">IDataFormItemsSourceProvider</a></td>
    <td>Custom <code>provider</code> that supplies <code>lookup data</code> or <code>selection lists</code> used by <code>editors</code> such as <code>drop-downs</code> and <code>pickers</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_LabelTextStyle" aria-label="View LabelTextStyle property in API reference">LabelTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
    <td><code>Text style</code> applied to <code>field labels</code>, controlling the <code>typography</code> used for <code>field captions</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_LayoutType" aria-label="View LayoutType property in API reference">LayoutType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormLayoutType.html" aria-label="View DataFormLayoutType enum in API reference">DataFormLayoutType</a></td>
    <td><code>Layout type</code> used by the <code>data form</code> to arrange <code>items</code>. Choose a supported <code>DataFormLayoutType</code> value such as <code>Default</code> or <code>TextInputLayout</code> to define the overall <code>arrangement structure</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_TextInputLayoutSettings" aria-label="View TextInputLayoutSettings property in API reference">TextInputLayoutSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.TextInputLayoutSettings.html" aria-label="View TextInputLayoutSettings type in API reference">TextInputLayoutSettings</a></td>
    <td><code>Layout settings</code> applied to <code>text input editors</code>, including <code>label position</code>, <code>border style</code>, and <code>helper text appearance</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidationMode" aria-label="View ValidationMode property in API reference">ValidationMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidationMode.html" aria-label="View DataFormValidationMode enum in API reference">DataFormValidationMode</a></td>
    <td>Controls when <code>validation</code> is triggered during the <code>form life cycle</code>. Choose a supported <code>DataFormValidationMode</code> value such as <code>LostFocus</code>, <code>PropertyChanged</code>, or <code>Manual</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidMessageLabelTextStyle" aria-label="View ValidMessageLabelTextStyle property in API reference">ValidMessageLabelTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormTextStyle.html" aria-label="View DataFormTextStyle type in API reference">DataFormTextStyle</a></td>
    <td><code>Text style</code> applied to <code>validation success messages</code> shown for <code>valid fields</code>.</td>
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
    <td>Commits pending <code>editor values</code> to the <code>data object</code> and applies the current <code>unsaved changes</code> to the <code>bound source</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GetDataFormGroupItem_System_String_" aria-label="View GetDataFormGroupItem(String) method in API reference">GetDataFormGroupItem(String)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormGroupItem.html" aria-label="View DataFormGroupItem type in API reference">DataFormGroupItem</a></td>
    <td>Returns the <code>DataFormGroupItem</code> that matches the specified <code>group_name</code>, providing access to the <code>grouped section</code> that contains related <code>form items</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_GetDataFormItem_System_String_" aria-label="View GetDataFormItem(String) method in API reference">GetDataFormItem(String)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormItem.html" aria-label="View DataFormItem type in API reference">DataFormItem</a></td>
    <td>Returns the <code>DataFormItem</code> associated with the specified <code>property_name</code>, providing the configured <code>field metadata</code> for the matching entry. Returns <code>null</code> when no matching item exists.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_DataFormEditorType_" aria-label="View RegisterEditor(String, DataFormEditorType) method in API reference">RegisterEditor(String, DataFormEditorType)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Maps the specified <code>property_name</code> to a predefined <code>DataFormEditorType</code> so the form uses that <code>built-in editor</code> for the <code>field</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_String_Syncfusion_Maui_DataForm_IDataFormEditor_" aria-label="View RegisterEditor(String, IDataFormEditor) method in API reference">RegisterEditor(String, IDataFormEditor)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Maps the specified <code>property_name</code> to a custom <code>IDataFormEditor</code> implementation, allowing a tailored <code>editor</code> to be associated with the <code>field</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_RegisterEditor_System_Type_Syncfusion_Maui_DataForm_DataFormEditorType_" aria-label="View RegisterEditor(Type, DataFormEditorType) method in API reference">RegisterEditor(Type, DataFormEditorType)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Maps the specified <code>CLR data type</code> to a predefined <code>DataFormEditorType</code>, applying the <code>editor</code> to every <code>property</code> of that <code>underlying type</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ScrollTo_System_String_" aria-label="View ScrollTo(String) method in API reference">ScrollTo(String)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Scrolls to the <code>data form item</code> associated with the specified <code>property_name</code> and brings the matching <code>field</code> into view within the current <code>layout</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_UpdateEditor_System_String_" aria-label="View UpdateEditor(String) method in API reference">UpdateEditor(String)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Refreshes the <code>editor state</code> for the specified <code>property_name</code> and re-syncs the <code>editor</code> with the current value of the <code>underlying data object</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Validate" aria-label="View Validate() method in API reference">Validate()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Validates all <code>data form items</code> using the active <code>validation rules</code> and returns whether every <code>field</code> satisfies them.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_Validate_System_Collections_Generic_List_System_String__" aria-label="View Validate(List&lt;String&gt;) method in API reference">Validate(List&lt;String&gt;)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Validates only the <code>data form items</code> whose <code>property_names</code> are provided and returns whether the listed <code>fields</code> pass the active <code>rules</code>.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.GenerateDataFormItemEventArgs.html" aria-label="View GenerateDataFormItemEventArgs type in API reference">GenerateDataFormItemEventArgs</a>&gt;</a></td>
    <td>Triggered <code>while</code> a <code>data form item</code> is being generated, allowing the <code>field configuration</code> to be <code>observed</code> and <code>adjusted</code> before the <code>editor</code> is displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateForm" aria-label="View ValidateForm event in API reference">ValidateForm</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidateFormEventArgs.html" aria-label="View DataFormValidateFormEventArgs type in API reference">DataFormValidateFormEventArgs</a>&gt;</a></td>
    <td>Triggered when the <code>data form</code> is <code>validated</code>, providing <code>validation scope details</code> for the entire <code>form life cycle</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.SfDataForm.html#Syncfusion_Maui_DataForm_SfDataForm_ValidateProperty" aria-label="View ValidateProperty event in API reference">ValidateProperty</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataForm.DataFormValidatePropertyEventArgs.html" aria-label="View DataFormValidatePropertyEventArgs type in API reference">DataFormValidatePropertyEventArgs</a>&gt;</a></td>
    <td>Triggered when an individual <code>property</code> is <code>validated</code>, providing <code>rule details</code> and <code>validation state</code> for the <code>field</code> under evaluation.</td>
</tr>
</table>
