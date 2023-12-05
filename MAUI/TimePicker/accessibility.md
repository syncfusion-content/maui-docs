---
layout: post
title: Accessibility with .NET MAUI Time Picker Control | Syncfusion
description: Learn here all about accessibility with Syncfusion .NET MAUI Time Picker (SfTimePicker) control.
platform: maui
control: SfTimePicker
documentation: ug
---

# Accessibility in .NET MAUI Time Picker (SfTimePicker)

The .NET MAUI Time Picker control has interact with the `Header`, `Column Header`, `Footer`, and `Picker Items`.

## Header Layout

The SfTimePicker control has intract header text with localization of header layout.

## Column Header Layout

The SfTimePicker control has intract column header text with localization of column header layout. It contains HourHeaderText, MinuteHeaderText, SecondHeaderText, and MeridiemHeaderText properties of the TimePickerColumnHeaderView. The default value of the HourHeaderText property is "Hour", MinuteHeaderText is "Minute", SecondHeaderText is "Second", and MerdiemHeaderText is "string.Empty".

## Footer Layout

The SfTimePicker control has intract validation buttons (OK and Cancel) with localization of footer layout. The Default value of the OkButtonText property is "OK", and CancelButtonText is "Cancel".

## Picker Items

The SfTimePicker control has intract with item source in picker items. The item source contains based on time format. For example, 

<table>
<tr>
<th>Format</th>
<th>Example</th></tr>
<tr>
<td>h, H</td>
<td>1</td>
</tr>
<tr>
<td>hh, HH</td>
<td>01</td>
</tr>
<tr>
<td>mm, ss</td>
<td>01</td>
</tr> 
<tr>
<td>tt</td>
<td>AM/PM</td>
</tr> 
</table>
