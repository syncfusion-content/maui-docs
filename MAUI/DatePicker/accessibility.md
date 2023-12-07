---
layout: post
title: Accessibility with .NET MAUI Date Picker Control | Syncfusion
description: Learn here about accessibility with Syncfusion .NET MAUI Date Picker (SfDatePicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Accessibility in .NET MAUI Date Picker (SfDatePicker)

The .NET MAUI Date Picker control has interact with the `Header`, `Column Header`, `Footer`, and `Picker Items`.

## Header Layout

The SfDatePicker control has interact header text with localization of header layout.

## Column Header Layout

The SfDatePicker control has interact column header text with localization of column header layout. It contains DayHeaderText, MonthHeaderText, and YearHeaderText properties of the DatePickerColumnHeaderView. The default value of the DayHeaderText property is "Day", MonthHeaderText is "Month", and YearHeaderText is "Year".

## Footer Layout

The SfDatePicker control has interact validation buttons (OK and Cancel) with localization of footer layout. The Default value of the OkButtonText property is "OK", and CancelButtonText is "Cancel".

## Picker Items

The SfDatePicker control has interact with the item source in picker items. The item source contains based on the Date format. For example, 

<table>
<tr>
<th>Format</th>
<th>Example</th></tr>
<tr>
<td>d, M</td>
<td>1</td>
</tr>
<tr>
<td>dd, MM</td>
<td>01</td>
</tr>
<tr>
<td>MMM</td>
<td>January</td>
</tr> 
<tr>
<td>yyyy</td>
<td>2023</td>
</tr> 
</table>
