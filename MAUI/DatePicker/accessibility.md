---
layout: post
title: Accessibility with .NET MAUI Date Picker Control | Syncfusion<sup>&reg;</sup>
description: Learn here about accessibility with Syncfusion<sup>&reg;</sup> .NET MAUI Date Picker (SfDatePicker) control.
platform: maui
control: SfDatePicker
documentation: ug
---

# Accessibility in .NET MAUI Date Picker (SfDatePicker)

The [.NET MAUI Date Picker](https://www.syncfusion.com/maui-controls/maui-datepicker) control interacts with the `Header`, `Column Header`, `Footer`, and `Picker Items`.

## Header Layout

The SfDatePicker control interacts [Header Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html#Syncfusion_Maui_Picker_PickerHeaderView_Text) with localization of header layout.

![Header Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-header.png)

## Column Header Layout

The SfDatePicker control interacts column header text with localization of column header layout. It contains [DayHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_DayHeaderText), [MonthHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_MonthHeaderText), and [YearHeaderText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html#Syncfusion_Maui_Picker_DatePickerColumnHeaderView_YearHeaderText) properties of the [DatePickerColumnHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html). The default value of the `DayHeaderText` property is "Day", `MonthHeaderText` is "Month", and `YearHeaderText` is "Year".

![Column Header Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-columnheader.png)

## Footer Layout

The SfDatePicker control interacts validation buttons (OK and Cancel) with localization of footer layout. The default value of the [OkButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_OkButtonText) property is "OK", and [CancelButtonText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html#Syncfusion_Maui_Picker_PickerFooterView_CancelButtonText) is "Cancel".

![Footer Layout in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-footer.png)

## Picker Items

The SfDatePicker control interacts with the item source in picker items. The item source is based on the [Date Format](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html). For example, 

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

![Picker Items in .NET MAUI Date Picker.](images/accessibility/maui-accessibility-datepicker-datepickeritems.png)

## Keyboard
`SfDatePicker` supports selection through keyboard interactions.

<table>
<tr>
<th>
Key
</th>
<th>
Description
</th>
</tr>
<tr>
<td>
Tab
</td>
<td>
Focus the picker.
</td>
</tr>
<tr>
<td>
Enter
</td>
<td>
Opens the picker.
</td>
</tr>
<tr>
<td>
DownArrow
</td>
<td>
Selects an item from the expanded list by moving downwards.
</td>
</tr>
<tr>
<td>
UpArrow
</td>
<td>
Selects an item from the expanded list by moving upwards.
</td>
</tr>
<tr>
<td>
RightArrow/Tab
</td>
<td>
Navigates through the items in the right direction.
</td>
</tr>
<tr>
<td>
LeftArrow/Shift+Tab
</td>
<td>
Navigates through the items in the left direction.
</td>
</tr>
<tr>
<td>
Esc/Enter
</td>
<td>
Exits and commits selection.
</td>
</tr>
</table>
