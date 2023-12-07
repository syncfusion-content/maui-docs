---
layout: post
title: Accessibility with .NET MAUI Date Time Picker Control | Syncfusion
description: Learn here about accessibility with Syncfusion .NET MAUI Date Time Picker (SfDateTimePicker) control.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Accessibility in .NET MAUI Date Time Picker (SfDateTimePicker)

The .NET MAUI Date Time Picker control has interact with the `Header`, `Column Header`, `Footer`, and `Picker Items`.

## Header Layout

The SfDateTimePicker control has interact header text with localization of header layout. It contains DateFormat and TimeFormat property of the DateTimePickerHeaderView. For example,

<table>
<tr>
<th>Format</th>
<th>Accessibility</th>
</tr>
<tr>
<td>Date Format</td>
<td>1/January/2023</td>
</tr>
<tr>
<td>Time Format</td>
<td>10:15:30 AM (or) PM</td>
</tr>
</table>

## Column Header Layout

The SfDateTimePicker control has interact column header text with localization of column header layout. It contains DayHeaderText, MonthHeaderText, YearHeaderText, HourHeaderText, MinuteHeaderText, SecondHeaderText, and the MeridiemHeaderText properties of the DateTimePickerColumnHeaderView. The default value of the DayHeaderText property is "Day", MonthHeaderText is "Month", YearHeaderText is "Year", HourHeaderText property is "Hour", MinuteHeaderText is "Minute", SecondHeaderText is "Second", and MerdiemHeaderText is "string.Empty".

## Footer Layout

The SfDateTimePicker control has interact validation buttons (OK and Cancel) with localization of footer layout. The Default value of the OkButtonText property is "OK", and CancelButtonText is "Cancel".

## Picker Items

The SfDateTimePicker control has interact with the item source in picker items. The item source contains based on the Date and Time format. For example, 

<table>
<tr>
<th>Format</th>
<th>Example</th></tr>
<tr>
<td>d, M, h, H</td>
<td>1</td>
</tr>
<tr>
<td>dd, MM, hh, HH, mm, ss</td>
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
<tr>
<td>tt</td>
<td>AM/PM</td>
</tr>
</table>
