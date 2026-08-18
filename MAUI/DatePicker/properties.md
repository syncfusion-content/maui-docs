---
layout: post
title: Properties of .NET MAUI Date Picker control | Syncfusion®
description: Learn about the properties and events of the Syncfusion .NET MAUI Date Picker control, including customization and behavior settings.
platform: maui
control: SfDatePicker
documentation: ug
---

# Properties in .NET MAUI Date Picker control

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_BlackoutDates" aria-label="BlackoutDates property">BlackoutDates</a></td>
		<td>ObservableCollection&lt;DateTime&gt;</td>
		<td>Defines the dates that cannot be selected.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_ColumnHeaderView" aria-label="ColumnHeaderView property">ColumnHeaderView</a></td>
		<td>DatePickerColumnHeaderView</td>
		<td>Defines the column header view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval" aria-label="DayInterval property">DayInterval</a></td>
		<td>int</td>
		<td>Defines the day interval.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_Format" aria-label="Format property">Format</a></td>
		<td>PickerDateFormat</td>
		<td>Defines the date format.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_HeaderView" aria-label="HeaderView property">HeaderView</a></td>
		<td>PickerHeaderView</td>
		<td>Defines the header view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate" aria-label="MaximumDate property">MaximumDate</a></td>
		<td>DateTime</td>
		<td>Defines the latest selectable date.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate" aria-label="MinimumDate property">MinimumDate</a></td>
		<td>DateTime</td>
		<td>Defines the earliest selectable date.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval" aria-label="MonthInterval property">MonthInterval</a></td>
		<td>int</td>
		<td>Defines the month interval.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate" aria-label="SelectedDate property">SelectedDate</a></td>
		<td>DateTime</td>
		<td>Defines the selected date.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChangedCommand" aria-label="SelectionChangedCommand property">SelectionChangedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when the date changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval" aria-label="YearInterval property">YearInterval</a></td>
		<td>int</td>
		<td>Defines the year interval.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnCancelButtonClicked_System_EventArgs_" aria-label="CancelButtonClicked event">CancelButtonClicked</a></td>
		<td>EventHandler&lt;EventArgs&gt;</td>
		<td>Raised when the Cancel button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_" aria-label="Closed event">Closed</a></td>
		<td>EventHandler&lt;EventArgs&gt;</td>
		<td>Raised when the picker closes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_" aria-label="Closing event">Closing</a></td>
		<td>EventHandler&lt;CancelEventArgs&gt;</td>
		<td>Raised before the picker closes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_" aria-label="Opened event">Opened</a></td>
		<td>EventHandler&lt;EventArgs&gt;</td>
		<td>Raised when the picker opens.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_" aria-label="OkButtonClicked event">OkButtonClicked</a></td>
		<td>EventHandler&lt;EventArgs&gt;</td>
		<td>Raised when the OK button is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChanged" aria-label="SelectionChanged event">SelectionChanged</a></td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnCancelButtonClicked_System_EventArgs_" aria-label="OnCancelButtonClicked method">OnCancelButtonClicked(EventArgs)</a></td>
		<td>void</td>
		<td>Handles the Cancel button click.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_" aria-label="OnOkButtonClicked method">OnOkButtonClicked(EventArgs)</a></td>
		<td>void</td>
		<td>Handles the OK button click.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_" aria-label="OnPopupClosed method">OnPopupClosed(EventArgs)</a></td>
		<td>void</td>
		<td>Runs after the popup closes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_" aria-label="OnPopupClosing method">OnPopupClosing(CancelEventArgs)</a></td>
		<td>void</td>
		<td>Runs before the popup closes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_" aria-label="OnPopupOpened method">OnPopupOpened(EventArgs)</a></td>
		<td>void</td>
		<td>Runs after the popup opens.</td>
	</tr>
</table>
