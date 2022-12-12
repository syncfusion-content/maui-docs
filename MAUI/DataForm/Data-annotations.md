---
layout: post
title: Data annotations in Maui DataForm control | Syncfusion
description: Learn here all about Data annotations support in Syncfusion Maui DataForm (SfDataForm) control and more.
platform: Maui
control: SfDataForm
documentation: UG
---

# Data annotations in Maui DataForm (SfDataForm)

The data form supports the following attribute, and these attributes can be accessible using `System.ComponentModel.DataAnnotation` assembly.

## Display attribute

<table>
<tr>
<th>Property</th>
<th>Details</th>
</tr>
<tr>
<td>
{{'[Name] `Link`
</td>
<td>
Specifies the label text.
</td>
</tr>
<tr>
<td>
{{'[GroupName]`Link`
</td>
<td>
Specifies the group name which groups the fields in the data form. Refer to  `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ShortName] `Link`
</td>
<td>
Specifies the label text. It takes higher priority than Name.
</td>
</tr>
<tr>
<td>
{{'[AutoGenerateField]`Link`
</td>
<td>
Specifies whether the field should be auto generated or not. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ResourceType]`Link`
</td>
<td>
Specifies the Resources File (.Resx) which is used to localize the Display attribute of `Name`, `ShortName`, `GroupName` and `Prompt` values.
</td>
</tr>
<tr>
<td>
{{'[Prompt]`Link`
</td>
<td>
Specifies watermark text for the editor. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[Order] `Link`
</td>
<td>
Specifies the order of field in the data form. Refer to `Link` for more details.
</td>
</tr>
</table>

## Validation attributes

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
MinLength
</td>
<td>
Specifies the required minimum length. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
MaxLength

</td>
<td>
Specifies the required maximum length. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
Required

</td>
<td>
Specifies the required data field value. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
StringLength
</td>
<td>
Specifies the required string length. Refer to `Link` for more details.
</td>
</tr>
</table>

## Bindable attribute

It specifies whether the field should be auto generated or not. Refer to `Link`  for more details.

## Editable attribute

It specifies whether the data field is editable or not.

## ReadOnly attribute

It specifies whether the data field is read only or not. Refer to `Link` for more details.

## EnumDataType attribute

It specifies enum type for the data field.

## DataType attribute

It specifies data type for the field.

Supported data types are Text, MultilineText, Date, DateTime and Time.

Refer to `Link` for more details.

## Custom attribute
The data form supports the following custom attribute, and these attributes can be accessible using `Syncfusion.Maui.DataForm`.

### DataFormDisplayOptions attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
{{'[RowSpan] `Link`
</td>
<td>
Specifies the row span for the data form item. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ColumnSpan] `Link`
</td>
<td>
Specifies the column span for the data form item. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ValidMessage] `Link`
</td>
<td>
Specifies positive message to be shown when validation is passed. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ShowLabel] `Link`
</td>
<td>
Specifies whether the label should be visible or not. Refer to `Link` for more details.
</td>
</tr>
<tr>
<td>
{{'[ItemsOrderInRow] `Link`
</td>
<td>
Specifies the ItemsOrderInRow property to display multiple editors in a single row. Two items with the same RowOrder property value are placed in this row according to their ItemOrderInRow property values.
</td>
</tr>
</table>

### DataFormValueConverter attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
{{'[DataFormValueConverterType] `Link`
</td>
<td>
Specifies the Converter type which converts the original value in different format or as different value. Refer to here for more details.
</td>
</tr>
</table>

### DateFormDateRange attribute

<table>
<tr>
<th>
Property
</th>
<th>
Details
</th>
</tr>
<tr>
<td>
{{'[MaximumDate] `Link`
</td>
<td>
Specifies the required maximum date.
</td>
</tr>
<tr>
<td>
{{'[MinimumDate] `Link`
</td>
<td>
Specifies the required minimum date.
</td>
</tr>
<tr>
<td>
{{'[DisplayFormat] ``Link
</td>
<td>
Specifies the required date display format.
</td>
</tr>
</table>

Refer to `Here Link` for more details.
