---
layout: post
title: Properties of .NET MAUI Date Time Picker control | Syncfusion®
description: Learn about the properties and events of the Syncfusion .NET MAUI Date Time Picker control, including customization and behavior settings.
platform: maui
control: SfDateTimePicker
documentation: ug
---

# Properties in .NET MAUI Date Time Picker control

## Properties

<table>
<tr valign="top">
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand" aria-label="View AcceptCommand property in API reference">AcceptCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Runs when the user confirms the current selection by tapping the OK button in dialog or relative dialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_ActiveView" aria-label="View ActiveView property in API reference">ActiveView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerView.html" aria-label="View DateTimePickerView type in API reference">DateTimePickerView</a></td>
    <td>Switches the visible picker tab between the date and time views.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_BlackoutDateTimes" aria-label="View BlackoutDateTimes property in API reference">BlackoutDateTimes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Prevents specific date and time values from being selected and excludes them from the picker’s selection state.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CloseButtonIcon" aria-label="View CloseButtonIcon property in API reference">CloseButtonIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Customizes the icon displayed in the picker's close button.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_ColumnHeaderView" aria-label="View ColumnHeaderView property in API reference">ColumnHeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerColumnHeaderView.html" aria-label="View DateTimePickerColumnHeaderView type in API reference">DateTimePickerColumnHeaderView</a></td>
    <td>Customizes the appearance and content of the column header area displayed above the picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor" aria-label="View ColumnDividerColor property in API reference">ColumnDividerColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Changes the color of the dividers that separate adjacent picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnHeaderTemplate" aria-label="View ColumnHeaderTemplate property in API reference">ColumnHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default column header UI with custom content. When this template is used, column header style settings are not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DateFormat" aria-label="View DateFormat property in API reference">DateFormat</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html" aria-label="View PickerDateFormat type in API reference">PickerDateFormat</a></td>
    <td>Controls which date columns are displayed and how date values are presented in the date view.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_DayInterval" aria-label="View DayInterval property in API reference">DayInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays day values at the specified interval in the day column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnTextStyle" aria-label="View DayColumnTextStyle property in API reference">DayColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the day column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnWidth" aria-label="View DayColumnWidth property in API reference">DayColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the day column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand" aria-label="View DeclineCommand property in API reference">DeclineCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Runs when the user cancels the picker by tapping the Cancel button in dialog or relative dialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Applies the Liquid Glass visual effect to the picker when supported by the platform and hosting configuration. Platform requirements should be verified against the product documentation.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping" aria-label="View EnableLooping property in API reference">EnableLooping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows picker columns to wrap from the last item back to the first item and vice versa during scrolling.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default footer UI with custom content. When this template is used, footer style settings are not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterView" aria-label="View FooterView property in API reference">FooterView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html" aria-label="View PickerFooterView type in API reference">PickerFooterView</a></td>
    <td>Customizes the picker footer, including the area that hosts validation actions such as OK and Cancel buttons.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default header UI with custom content. When this template is used, header style settings are not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HeaderView" aria-label="View HeaderView property in API reference">HeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerHeaderView.html" aria-label="View DateTimePickerHeaderView type in API reference">DateTimePickerHeaderView</a></td>
    <td>Customizes the picker header, including the Date and Time tab area.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_HourInterval" aria-label="View HourInterval property in API reference">HourInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays hour values at the specified interval in the hour column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HourColumnTextStyle" aria-label="View HourColumnTextStyle property in API reference">HourColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the hour column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HourColumnWidth" aria-label="View HourColumnWidth property in API reference">HourColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the hour column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Opens or closes the picker popup programmatically.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate" aria-label="View IsSelectionImmediate property in API reference">IsSelectionImmediate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls when a selection is committed in dialog and relative dialog modes. When enabled, changes are applied as the user interacts with the picker; otherwise, confirmation through the OK button is required.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the height of each visible item in the picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MaximumDate" aria-label="View MaximumDate property in API reference">MaximumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits selection to date and time values on or before the specified value. Later values remain unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnTextStyle" aria-label="View MeridiemColumnTextStyle property in API reference">MeridiemColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the AM/PM column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnWidth" aria-label="View MeridiemColumnWidth property in API reference">MeridiemColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the AM/PM column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MilliSecondInterval" aria-label="View MilliSecondInterval property in API reference">MilliSecondInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays millisecond values at the specified interval in the millisecond column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnTextStyle" aria-label="View MilliSecondColumnTextStyle property in API reference">MilliSecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the millisecond column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnWidth" aria-label="View MilliSecondColumnWidth property in API reference">MilliSecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the millisecond column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinimumDate" aria-label="View MinimumDate property in API reference">MinimumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits selection to date and time values on or after the specified value. Earlier values remain unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MinuteInterval" aria-label="View MinuteInterval property in API reference">MinuteInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays minute values at the specified interval in the minute column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnTextStyle" aria-label="View MinuteColumnTextStyle property in API reference">MinuteColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the minute column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnWidth" aria-label="View MinuteColumnWidth property in API reference">MinuteColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the minute column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode" aria-label="View Mode property in API reference">Mode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html" aria-label="View PickerMode type in API reference">PickerMode</a></td>
    <td>Controls how the picker is displayed: embedded in the layout (Default), in a dialog (Dialog), or in a dialog positioned relative to a target view (RelativeDialog).</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_MonthInterval" aria-label="View MonthInterval property in API reference">MonthInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays month values at the specified interval in the month column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnTextStyle" aria-label="View MonthColumnTextStyle property in API reference">MonthColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the month column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnWidth" aria-label="View MonthColumnWidth property in API reference">MonthColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the month column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupHeight" aria-label="View PopupHeight property in API reference">PopupHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the height of the picker popup when displayed in dialog-based modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupWidth" aria-label="View PopupWidth property in API reference">PopupWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the picker popup when displayed in dialog-based modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition" aria-label="View RelativePosition property in API reference">RelativePosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerRelativePosition.html" aria-label="View PickerRelativePosition type in API reference">PickerRelativePosition</a></td>
    <td>Determines where the popup appears relative to RelativeView when Mode is set to RelativeDialog.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView" aria-label="View RelativeView property in API reference">RelativeView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Defines the view used as the positioning target for the popup in RelativeDialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SecondInterval" aria-label="View SecondInterval property in API reference">SecondInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays second values at the specified interval in the second column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnTextStyle" aria-label="View SecondColumnTextStyle property in API reference">SecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the second column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnWidth" aria-label="View SecondColumnWidth property in API reference">SecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the second column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle" aria-label="View SelectedTextStyle property in API reference">SelectedTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to the currently selected item in each picker column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectedDate" aria-label="View SelectedDate property in API reference">SelectedDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable" aria-label="View Nullable type in API reference">Nullable&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Represents the currently selected date and time value.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectionView" aria-label="View SelectionView property in API reference">SelectionView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html" aria-label="View PickerSelectionView type in API reference">PickerSelectionView</a></td>
    <td>Customizes the visual appearance of the selection indicator shown around the currently selected item.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectionChangedCommand" aria-label="View SelectionChangedCommand property in API reference">SelectionChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Runs whenever the selected date and time value changes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ShowCloseButton" aria-label="View ShowCloseButton property in API reference">ShowCloseButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays a close button in the picker header. Not supported by SfDateTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode" aria-label="View TextDisplayMode property in API reference">TextDisplayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html" aria-label="View PickerTextDisplayMode type in API reference">PickerTextDisplayMode</a></td>
    <td>Controls how item text is displayed when the available column width is insufficient, such as trimming or wrapping behavior depending on the selected mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a text style to picker items that do not use a column-specific style.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_TimeFormat" aria-label="View TimeFormat property in API reference">TimeFormat</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTimeFormat.html" aria-label="View PickerTimeFormat type in API reference">PickerTimeFormat</a></td>
    <td>Controls which time columns are displayed and how time values are presented in the time view.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_YearInterval" aria-label="View YearInterval property in API reference">YearInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays year values at the specified interval in the year column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnTextStyle" aria-label="View YearColumnTextStyle property in API reference">YearColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies a custom text style to items in the year column. When set, the default unselected item styling for that column is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnWidth" aria-label="View YearColumnWidth property in API reference">YearColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the year column.</td>
</tr>
</table>

## Methods

<table>
<tr valign="top">
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnCancelButtonClicked_System_EventArgs_" aria-label="View OnCancelButtonClicked method in API reference">OnCancelButtonClicked(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles the Cancel button action when the user dismisses the picker without confirming a selection. Override this method to customize cancellation behavior.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnHeaderButtonClicked_System_Int32_" aria-label="View OnHeaderButtonClicked method in API reference">OnHeaderButtonClicked(int)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Responds to header button selection. In SfDateTimePicker, this is used to switch between the Date and Time tabs.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_" aria-label="View OnOkButtonClicked method in API reference">OnOkButtonClicked(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles the OK button action when the user confirms the current selection. Override this method to customize how selections are applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPickerLoading" aria-label="View OnPickerLoading method in API reference">OnPickerLoading()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Provides an extension point during picker initialization, such as when a popup is opening or when switching from popup mode to the default display mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_" aria-label="View OnPopupClosed method in API reference">OnPopupClosed(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles post-close processing after the picker popup is dismissed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_" aria-label="View OnPopupClosing method in API reference">OnPopupClosing(CancelEventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Executes before the picker popup closes, allowing the close operation to be canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_" aria-label="View OnPopupOpened method in API reference">OnPopupOpened(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles post-open processing after the picker popup becomes visible.</td>
</tr>
</table>

## Events

<table>
<tr valign="top">
    <th>Name</th>
    <th>Event args</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CancelButtonClicked" aria-label="View CancelButtonClicked event in API reference">CancelButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the user taps the Cancel button. This event is raised only when the picker footer and Cancel button are visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed" aria-label="View Closed event in API reference">Closed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup closes. Use this event to perform cleanup or update UI that depends on the popup state.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing" aria-label="View Closing event in API reference">Closing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs" aria-label="View CancelEventArgs type in API reference">CancelEventArgs&gt;</a></a></td>
    <td>Triggered before the picker popup closes, allowing the close operation to be canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked" aria-label="View OkButtonClicked event in API reference">OkButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the user taps the OK button to confirm the current selection. This event is raised only when the picker footer and OK button are visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened" aria-label="View Opened event in API reference">Opened</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup opens and becomes visible to the user.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDateTimePicker.html#Syncfusion_Maui_Picker_SfDateTimePicker_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DateTimePickerSelectionChangedEventArgs.html" aria-label="View DateTimePickerSelectionChangedEventArgs type in API reference">DateTimePickerSelectionChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the selected date and time value changes. Use this event to respond to user selection updates.</td>
</tr>
</table>