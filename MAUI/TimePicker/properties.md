---
layout: post
title: Properties of .NET MAUI Time Picker control | Syncfusion®
description: Learn about the properties and events of the Syncfusion .NET MAUI Time Picker control, including customization and behavior settings.
platform: maui
control: SfTimePicker
documentation: ug
---

# Properties in .NET MAUI Time Picker control

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
    <td>Runs when the user confirms the selection by tapping the OK button in PickerMode.Dialog or PickerMode.RelativeDialog.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_BlackoutTimes" aria-label="View BlackoutTimes property in API reference">BlackoutTimes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://learn.microsoft.com/dotnet/api/system.timespan" aria-label="View TimeSpan type in API reference">TimeSpan&gt;</a></a></td>
    <td>Disables specific time values so they cannot be selected in the time picker. Disabled times are excluded from the selection view.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CloseButtonIcon" aria-label="View CloseButtonIcon property in API reference">CloseButtonIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Customizes the icon displayed in the picker header's close button.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_ColumnHeaderView" aria-label="View ColumnHeaderView property in API reference">ColumnHeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerColumnHeaderView.html" aria-label="View TimePickerColumnHeaderView type in API reference">TimePickerColumnHeaderView</a></td>
    <td>Customizes the content and appearance of the time column headers.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor" aria-label="View ColumnDividerColor property in API reference">ColumnDividerColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Changes the color of the dividers displayed between picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnHeaderTemplate" aria-label="View ColumnHeaderTemplate property in API reference">ColumnHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Provides a custom template for the column header area. When used, built in column-header styling is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnTextStyle" aria-label="View DayColumnTextStyle property in API reference">DayColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies text styling to the day column in date-based pickers. This property is not used by SfTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnWidth" aria-label="View DayColumnWidth property in API reference">DayColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the day column in date-based pickers. This property is not used by SfTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand" aria-label="View DeclineCommand property in API reference">DeclineCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Runs when the user cancels the selection by tapping the Cancel button in PickerMode.Dialog or PickerMode.RelativeDialog.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Applies the Liquid Glass visual effect to the picker when supported by the platform and hosting environment. Platform requirements should be verified from the feature documentation.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping" aria-label="View EnableLooping property in API reference">EnableLooping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows picker columns to wrap continuously from the last item back to the first item and vice versa during scrolling.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Provides a custom template for the picker footer area. When used, built in footer styling is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterView" aria-label="View FooterView property in API reference">FooterView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html" aria-label="View PickerFooterView type in API reference">PickerFooterView</a></td>
    <td>Customizes the footer area, including the validation buttons displayed in dialog-based picker modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_Format" aria-label="View Format property in API reference">Format</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTimeFormat.html" aria-label="View PickerTimeFormat type in API reference">PickerTimeFormat</a></td>
    <td>Determines which time components are displayed, such as hours, minutes, seconds, milliseconds, and meridiem values.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Provides a custom template for the picker header area. When used, built in header styling is not applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_HeaderView" aria-label="View HeaderView property in API reference">HeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html" aria-label="View PickerHeaderView type in API reference">PickerHeaderView</a></td>
    <td>Customizes the content and appearance of the picker header.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_HourInterval" aria-label="View HourInterval property in API reference">HourInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Controls the increment between available hour values displayed in the hour column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HourColumnTextStyle" aria-label="View HourColumnTextStyle property in API reference">HourColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of items displayed in the hour column. When applied, the general unselected text style is not used for that column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HourColumnWidth" aria-label="View HourColumnWidth property in API reference">HourColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the hour column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Opens or closes the picker programmatically.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate" aria-label="View IsSelectionImmediate property in API reference">IsSelectionImmediate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls when a selection is committed in PickerMode.Dialog and PickerMode.RelativeDialog. When enabled, changes are applied immediately while the user interacts with the picker; otherwise, confirmation through the OK button is required.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the height of individual items displayed in picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MaximumTime" aria-label="View MaximumTime property in API reference">MaximumTime</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.timespan" aria-label="View TimeSpan type in API reference">TimeSpan</a></td>
    <td>Restricts selection to times that occur on or before the specified value. Later times are unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnTextStyle" aria-label="View MeridiemColumnTextStyle property in API reference">MeridiemColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of items displayed in the AM/PM column. When applied, the general unselected text style is not used for that column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnWidth" aria-label="View MeridiemColumnWidth property in API reference">MeridiemColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the AM/PM column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MilliSecondInterval" aria-label="View MilliSecondInterval property in API reference">MilliSecondInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Controls the increment between available values in the milliseconds column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnTextStyle" aria-label="View MilliSecondColumnTextStyle property in API reference">MilliSecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of items displayed in the milliseconds column. When applied, the general unselected text style is not used for that column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnWidth" aria-label="View MilliSecondColumnWidth property in API reference">MilliSecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the milliseconds column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MinimumTime" aria-label="View MinimumTime property in API reference">MinimumTime</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.timespan" aria-label="View TimeSpan type in API reference">TimeSpan</a></td>
    <td>Restricts selection to times that occur on or after the specified value. Earlier times are unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_MinuteInterval" aria-label="View MinuteInterval property in API reference">MinuteInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Controls the increment between available minute values displayed in the minute column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnTextStyle" aria-label="View MinuteColumnTextStyle property in API reference">MinuteColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of items displayed in the minute column. When applied, the general unselected text style is not used for that column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnWidth" aria-label="View MinuteColumnWidth property in API reference">MinuteColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the minute column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode" aria-label="View Mode property in API reference">Mode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html" aria-label="View PickerMode type in API reference">PickerMode</a></td>
    <td>Controls how the picker is displayed using Default, Dialog, or RelativeDialog modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnTextStyle" aria-label="View MonthColumnTextStyle property in API reference">MonthColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies text styling to the month column in date-based pickers. This property is not used by SfTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnWidth" aria-label="View MonthColumnWidth property in API reference">MonthColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the month column in date-based pickers. This property is not used by SfTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupHeight" aria-label="View PopupHeight property in API reference">PopupHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the height of the picker popup when displayed in a dialog-based mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_PopupWidth" aria-label="View PopupWidth property in API reference">PopupWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the picker popup when displayed in a dialog-based mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativePosition" aria-label="View RelativePosition property in API reference">RelativePosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerRelativePosition.html" aria-label="View PickerRelativePosition type in API reference">PickerRelativePosition</a></td>
    <td>Positions the popup relative to RelativeView when Mode is set to RelativeDialog.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView" aria-label="View RelativeView property in API reference">RelativeView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Specifies the view used as the anchor element for positioning the popup in RelativeDialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SecondInterval" aria-label="View SecondInterval property in API reference">SecondInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Controls the increment between available second values displayed in the seconds column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnTextStyle" aria-label="View SecondColumnTextStyle property in API reference">SecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of items displayed in the seconds column. When applied, the general unselected text style is not used for that column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnWidth" aria-label="View SecondColumnWidth property in API reference">SecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the seconds column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle" aria-label="View SelectedTextStyle property in API reference">SelectedTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of the currently selected item in the picker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectedTime" aria-label="View SelectedTime property in API reference">SelectedTime</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable" aria-label="View Nullable type in API reference">Nullable&lt;<a href="https://learn.microsoft.com/dotnet/api/system.timespan" aria-label="View TimeSpan type in API reference">TimeSpan&gt;</a></a></td>
    <td>Represents the currently selected time in the picker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectionView" aria-label="View SelectionView property in API reference">SelectionView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html" aria-label="View PickerSelectionView type in API reference">PickerSelectionView</a></td>
    <td>Customizes the visual indicator used to highlight the selected item within the picker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectionChangedCommand" aria-label="View SelectionChangedCommand property in API reference">SelectionChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Runs whenever the selected time changes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ShowCloseButton" aria-label="View ShowCloseButton property in API reference">ShowCloseButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays a close button in the picker header that allows the popup to be dismissed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode" aria-label="View TextDisplayMode property in API reference">TextDisplayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html" aria-label="View PickerTextDisplayMode type in API reference">PickerTextDisplayMode</a></td>
    <td>Controls how picker item text is displayed when the available space is limited, such as trimming or wrapping behavior supported by the selected mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of picker items across all columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnTextStyle" aria-label="View YearColumnTextStyle property in API reference">YearColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Applies text styling to the year column in date-based pickers. This property is not used by SfTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnWidth" aria-label="View YearColumnWidth property in API reference">YearColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the year column in date-based pickers. This property is not used by SfTimePicker.</td>
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
    <td>Handles the action that occurs when the user taps the Cancel button, enabling derived picker implementations to customize the cancel workflow.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnHeaderButtonClicked_System_Int32_" aria-label="View OnHeaderButtonClicked method in API reference">OnHeaderButtonClicked(int)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles interactions with buttons displayed in the picker header, enabling derived picker implementations to customize header actions.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_" aria-label="View OnOkButtonClicked method in API reference">OnOkButtonClicked(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles the action that occurs when the user taps the OK button, enabling derived picker implementations to customize the confirmation workflow.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPickerLoading" aria-label="View OnPickerLoading method in API reference">OnPickerLoading()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Executes while the picker is loading, such as when a popup is opening or when the picker transitions between display modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_" aria-label="View OnPopupClosed method in API reference">OnPopupClosed(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Executes after the picker popup closes, enabling derived picker implementations to perform post-close processing.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_" aria-label="View OnPopupClosing method in API reference">OnPopupClosing(CancelEventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Executes before the picker popup closes, allowing the close operation to be reviewed and canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_" aria-label="View OnPopupOpened method in API reference">OnPopupOpened(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Executes after the picker popup opens, enabling derived picker implementations to perform post-open initialization.</td>
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
    <td>Triggered when the user taps the Cancel button in the picker footer. This event is not raised when the footer is hidden.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed" aria-label="View Closed event in API reference">Closed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup is closed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing" aria-label="View Closing event in API reference">Closing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs" aria-label="View CancelEventArgs type in API reference">CancelEventArgs&gt;</a></a></td>
    <td>Triggered before the picker popup closes, allowing the close operation to be canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked" aria-label="View OkButtonClicked event in API reference">OkButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the user taps the OK button to confirm the current selection. This event is not raised when the footer or OK button is hidden.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened" aria-label="View Opened event in API reference">Opened</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup is displayed and ready for user interaction.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfTimePicker.html#Syncfusion_Maui_Picker_SfTimePicker_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.TimePickerSelectionChangedEventArgs.html" aria-label="View TimePickerSelectionChangedEventArgs type in API reference">TimePickerSelectionChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the selected time changes and provides access to the previous and current time values.</td>
</tr>
</table>