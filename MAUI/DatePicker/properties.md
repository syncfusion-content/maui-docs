---
layout: post
title: Properties of .NET MAUI Date Picker control | Syncfusion®
description: This section explains about the properties and events with Syncfusion® MAUI Date Picker (SfDatePicker) control and more.
platform: maui
control: SfDatePicker
documentation: ug
---

# .NET MAUI Date Picker API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_BlackoutDates">BlackoutDates</a></td>
        <td>ObservableCollection&lt;DateTime&gt;</td>
        <td>Defines the collection of dates that cannot be selected in the picker.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_ColumnHeaderView">ColumnHeaderView</a></td>
        <td>DatePickerColumnHeaderView</td>
        <td>Defines the view used to display headers for the date columns.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval">DayInterval</a></td>
        <td>int</td>
        <td>Defines the interval used to display day values in the picker.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_Format">Format</a></td>
        <td>PickerDateFormat</td>
        <td>Defines the date format used to present the selected value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_HeaderView">HeaderView</a></td>
        <td>PickerHeaderView</td>
        <td>Defines the view shown in the picker header area.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate">MaximumDate</a></td>
        <td>DateTime</td>
        <td>Defines the latest date that can be selected in the picker.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate">MinimumDate</a></td>
        <td>DateTime</td>
        <td>Defines the earliest date that can be selected in the picker.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval">MonthInterval</a></td>
        <td>int</td>
        <td>Defines the interval used to display month values in the picker.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate">SelectedDate</a></td>
        <td>DateTime</td>
        <td>Defines the currently selected date value.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChangedCommand">SelectionChangedCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when the selected date changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval">YearInterval</a></td>
        <td>int</td>
        <td>Defines the interval used to display year values in the picker.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnCancelButtonClicked_System_EventArgs_">CancelButtonClicked</a></td>
        <td>EventHandler&lt;EventArgs&gt;</td>
        <td>Raised when the Cancel button is tapped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_">Closed</a></td>
        <td>EventHandler&lt;EventArgs&gt;</td>
        <td>Raised after the picker popup is closed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_">Closing</a></td>
        <td>EventHandler&lt;CancelEventArgs&gt;</td>
        <td>Raised before the picker popup closes and can be canceled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_">Opened</a></td>
        <td>EventHandler&lt;EventArgs&gt;</td>
        <td>Raised after the picker popup is opened.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_">OkButtonClicked</a></td>
        <td>EventHandler&lt;EventArgs&gt;</td>
        <td>Raised when the OK button is tapped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChanged">SelectionChanged</a></td>
        <td>EventHandler&lt;DatePickerSelectionChangedEventArgs&gt;</td>
        <td>Raised when the selected date changes.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnCancelButtonClicked_System_EventArgs_">OnCancelButtonClicked(EventArgs)</a></td>
        <td>void</td>
        <td>Handles the Cancel button click and raises the related event.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_">OnOkButtonClicked(EventArgs)</a></td>
        <td>void</td>
        <td>Handles the OK button click and raises the related event.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_">OnPopupClosed(EventArgs)</a></td>
        <td>void</td>
        <td>Runs after the popup has been closed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_">OnPopupClosing(CancelEventArgs)</a></td>
        <td>void</td>
        <td>Runs before the popup closes and can be used to cancel the action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_">OnPopupOpened(EventArgs)</a></td>
        <td>void</td>
        <td>Runs after the popup has been opened.</td>
    </tr>
</table>