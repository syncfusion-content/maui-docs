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
<tr valign="top">
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_AcceptCommand" aria-label="View AcceptCommand property in API reference">AcceptCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when the user confirms the current picker value through the OK button in dialog or relative dialog modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_BlackoutDates" aria-label="View BlackoutDates property in API reference">BlackoutDates</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Prevents specific dates from being selected in the picker. Disabled dates remain visible but cannot become the selected date.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_CloseButtonIcon" aria-label="View CloseButtonIcon property in API reference">CloseButtonIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Replaces the icon displayed in the picker's close button.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_ColumnHeaderView" aria-label="View ColumnHeaderView property in API reference">ColumnHeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerColumnHeaderView.html" aria-label="View DatePickerColumnHeaderView type in API reference">DatePickerColumnHeaderView</a></td>
    <td>Customizes the appearance of the date column headers displayed above the picker wheels.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnDividerColor" aria-label="View ColumnDividerColor property in API reference">ColumnDividerColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Controls the color of the dividers that separate adjacent picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ColumnHeaderTemplate" aria-label="View ColumnHeaderTemplate property in API reference">ColumnHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in column header content with a custom template. When a template is used, column-header view styling may not be applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_DayInterval" aria-label="View DayInterval property in API reference">DayInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays day values using the specified increment. For example, an interval of 2 shows every second day in the day column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnTextStyle" aria-label="View DayColumnTextStyle property in API reference">DayColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values displayed in the day column. Applies only to SfDatePicker and SfDateTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DayColumnWidth" aria-label="View DayColumnWidth property in API reference">DayColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the day column. Applies only to SfDatePicker and SfDateTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_DeclineCommand" aria-label="View DeclineCommand property in API reference">DeclineCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when the user cancels the picker through the Cancel button in dialog or relative dialog modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Applies the Liquid Glass visual effect to the picker when supported by the platform and hosting environment. Platform requirements should be verified against the Liquid Glass documentation.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_EnableLooping" aria-label="View EnableLooping property in API reference">EnableLooping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows picker columns to continue scrolling from the last item back to the first item, and vice versa.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in footer with a custom template. When a template is used, footer view styling may not be applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_FooterView" aria-label="View FooterView property in API reference">FooterView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerFooterView.html" aria-label="View PickerFooterView type in API reference">PickerFooterView</a></td>
    <td>Customizes the footer area, including the accept and cancel buttons shown in dialog-based modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_Format" aria-label="View Format property in API reference">Format</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerDateFormat.html" aria-label="View PickerDateFormat type in API reference">PickerDateFormat</a></td>
    <td>Controls how date components are arranged and displayed in the picker columns. See PickerDateFormat for supported formats.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in header with a custom template. When a template is used, header view styling may not be applied.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_HeaderView" aria-label="View HeaderView property in API reference">HeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerHeaderView.html" aria-label="View PickerHeaderView type in API reference">PickerHeaderView</a></td>
    <td>Customizes the appearance of the picker header.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether the picker popup is currently displayed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_IsSelectionImmediate" aria-label="View IsSelectionImmediate property in API reference">IsSelectionImmediate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls when a selection is committed in dialog and relative dialog modes. When enabled, changes are applied immediately; otherwise, users must confirm the selection through the OK button.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the height of individual items displayed in the picker columns.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MaximumDate" aria-label="View MaximumDate property in API reference">MaximumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits selection to dates on or before the specified date. Dates beyond the limit are unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnTextStyle" aria-label="View MeridiemColumnTextStyle property in API reference">MeridiemColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values in the AM/PM column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MeridiemColumnWidth" aria-label="View MeridiemColumnWidth property in API reference">MeridiemColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the AM/PM column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnTextStyle" aria-label="View MilliSecondColumnTextStyle property in API reference">MilliSecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values in the milliseconds column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MilliSecondColumnWidth" aria-label="View MilliSecondColumnWidth property in API reference">MilliSecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the milliseconds column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MinimumDate" aria-label="View MinimumDate property in API reference">MinimumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits selection to dates on or after the specified date. Dates before the limit are unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnTextStyle" aria-label="View MinuteColumnTextStyle property in API reference">MinuteColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values in the minutes column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MinuteColumnWidth" aria-label="View MinuteColumnWidth property in API reference">MinuteColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the minutes column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Mode" aria-label="View Mode property in API reference">Mode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerMode.html" aria-label="View PickerMode type in API reference">PickerMode</a></td>
    <td>Determines how the picker is displayed. Supported modes include Default, Dialog, and RelativeDialog.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_MonthInterval" aria-label="View MonthInterval property in API reference">MonthInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays month values using the specified increment. For example, an interval of 2 shows every second month in the month column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnTextStyle" aria-label="View MonthColumnTextStyle property in API reference">MonthColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values displayed in the month column. Applies only to SfDatePicker and SfDateTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_MonthColumnWidth" aria-label="View MonthColumnWidth property in API reference">MonthColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the month column. Applies only to SfDatePicker and SfDateTimePicker.</td>
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
    <td>Controls where the picker popup appears relative to RelativeView when using <code>RelativeDialog</code> mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_RelativeView" aria-label="View RelativeView property in API reference">RelativeView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Specifies the view used as the reference element for positioning the picker popup in RelativeDialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnTextStyle" aria-label="View SecondColumnTextStyle property in API reference">SecondColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values in the seconds column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SecondColumnWidth" aria-label="View SecondColumnWidth property in API reference">SecondColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the seconds column. This property is not used by SfDatePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectedTextStyle" aria-label="View SelectedTextStyle property in API reference">SelectedTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of the currently selected item in the picker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectedDate" aria-label="View SelectedDate property in API reference">SelectedDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable" aria-label="View Nullable type in API reference">Nullable&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Represents the currently selected date displayed by the picker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_SelectionView" aria-label="View SelectionView property in API reference">SelectionView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerSelectionView.html" aria-label="View PickerSelectionView type in API reference">PickerSelectionView</a></td>
    <td>Customizes the visual selection indicator that highlights the active picker row.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChangedCommand" aria-label="View SelectionChangedCommand property in API reference">SelectionChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes whenever the selected date changes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_ShowCloseButton" aria-label="View ShowCloseButton property in API reference">ShowCloseButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays a close button in the picker header.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextDisplayMode" aria-label="View TextDisplayMode property in API reference">TextDisplayMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextDisplayMode.html" aria-label="View PickerTextDisplayMode type in API reference">PickerTextDisplayMode</a></td>
    <td>Controls how picker item text is displayed when the available space is limited. See PickerTextDisplayMode for supported options.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_TextStyle" aria-label="View TextStyle property in API reference">TextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of picker items that are not currently selected.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_YearInterval" aria-label="View YearInterval property in API reference">YearInterval</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Displays year values using the specified increment. For example, an interval of 5 shows every fifth year in the year column.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnTextStyle" aria-label="View YearColumnTextStyle property in API reference">YearColumnTextStyle</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerTextStyle.html" aria-label="View PickerTextStyle type in API reference">PickerTextStyle</a></td>
    <td>Customizes the appearance of values displayed in the year column. Applies only to SfDatePicker and SfDateTimePicker.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_YearColumnWidth" aria-label="View YearColumnWidth property in API reference">YearColumnWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Controls the width of the year column. Applies only to SfDatePicker and SfDateTimePicker.</td>
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
    <td>Handles the Cancel button action, allowing derived picker implementations to respond when the user dismisses the current selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnHeaderButtonClicked_System_Int32_" aria-label="View OnHeaderButtonClicked method in API reference">OnHeaderButtonClicked(int)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles interactions with a header button, allowing derived picker implementations to respond when a custom header action is selected.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnOkButtonClicked_System_EventArgs_" aria-label="View OnOkButtonClicked method in API reference">OnOkButtonClicked(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Handles the OK button action, allowing derived picker implementations to respond when the user confirms the current selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPickerLoading" aria-label="View OnPickerLoading method in API reference">OnPickerLoading()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Called while the picker is being prepared for display, including when opening a popup or transitioning between presentation modes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosed_System_EventArgs_" aria-label="View OnPopupClosed method in API reference">OnPopupClosed(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Called after the picker popup has been dismissed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupClosing_System_ComponentModel_CancelEventArgs_" aria-label="View OnPopupClosing method in API reference">OnPopupClosing(CancelEventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Called before the picker popup closes, allowing the close operation to be canceled and the picker to remain open.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OnPopupOpened_System_EventArgs_" aria-label="View OnPopupOpened method in API reference">OnPopupOpened(EventArgs)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Called after the picker popup becomes visible.</td>
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
    <td>Triggered when the user taps the Cancel button in the picker footer. This event is raised only when the footer and Cancel button are visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closed" aria-label="View Closed event in API reference">Closed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup has been closed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Closing" aria-label="View Closing event in API reference">Closing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs" aria-label="View CancelEventArgs type in API reference">CancelEventArgs&gt;</a></a></td>
    <td>Triggered before the picker popup closes, allowing the close operation to be canceled and the popup to remain open.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_OkButtonClicked" aria-label="View OkButtonClicked event in API reference">OkButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the user taps the OK button to confirm the current selection. This event is raised only when the footer and OK button are visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.PickerBase.html#Syncfusion_Maui_Picker_PickerBase_Opened" aria-label="View Opened event in API reference">Opened</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the picker popup becomes visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.SfDatePicker.html#Syncfusion_Maui_Picker_SfDatePicker_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Picker.DatePickerSelectionChangedEventArgs.html" aria-label="View DatePickerSelectionChangedEventArgs type in API reference">DatePickerSelectionChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the selected date changes, providing access to the previous and current date values.</td>
</tr>
</table>