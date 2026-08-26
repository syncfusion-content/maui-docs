---
layout: post
title: Properties of .NET MAUI Calendar control | Syncfusion®
description: Learn about the properties, methods, and events of the Syncfusion .NET MAUI Calendar control API reference documentation.
platform: maui
control: SfCalendar
documentation: ug
---

# Properties in .NET MAUI Calendar control

## Properties

<table>
<tr valign="top">
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_AcceptCommand" aria-label="View AcceptCommand property in API reference">AcceptCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when the user confirms the current selection through the action button. Use together with <code>ShowActionButtons</code> to defer selection-related actions until the user explicitly accepts them.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_AllowViewNavigation" aria-label="View AllowViewNavigation property in API reference">AllowViewNavigation</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether tapping items in Year, Decade, and Century views drills down to the next view level. When disabled, those cells can be selected instead of navigating.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CanToggleDaySelection" aria-label="View CanToggleDaySelection property in API reference">CanToggleDaySelection</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Allows the currently selected date to be cleared by tapping it again in Single selection mode. The default value is false. Applicable only when <code>SelectionMode</code> is <c>Single</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CornerRadius" aria-label="View CornerRadius property in API reference">CornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Rounds the corners of the calendar container. The default value is 20.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DeclineCommand" aria-label="View DeclineCommand property in API reference">DeclineCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when the user cancels the current operation through the action button. Use together with <code>ShowActionButtons</code> to handle cancel actions.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DisplayDate" aria-label="View DisplayDate property in API reference">DisplayDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Navigates the calendar to a specific date programmatically and updates the visible date range. Navigation is constrained by <code>MinimumDate</code> and <code>MaximumDate</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DoubleTappedCommand" aria-label="View DoubleTappedCommand property in API reference">DoubleTappedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when a date cell is double-tapped. The default value is null.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Applies the Liquid Glass visual effect to the calendar when supported by the platform and hosting environment. Platform requirements should be verified against the Liquid Glass feature documentation.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnablePastDates" aria-label="View EnablePastDates property in API reference">EnablePastDates</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Prevents users from selecting dates that occur before the current day. The default value is true.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnableSwipeSelection" aria-label="View EnableSwipeSelection property in API reference">EnableSwipeSelection</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Enables drag or swipe gestures to select a date range in Range selection mode. The default value is false. Applicable only when <code>SelectionMode</code> is <c>Range</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EndRangeSelectionBackground" aria-label="View EndRangeSelectionBackground property in API reference">EndRangeSelectionBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the visual highlight applied to the ending date of a selected range. Applicable only when <code>SelectionMode</code> is <c>Range</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_FooterView" aria-label="View FooterView property in API reference">FooterView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarFooterView.html" aria-label="View CalendarFooterView type in API reference">CalendarFooterView</a></td>
    <td>Customizes the footer displayed below the calendar views.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in header with a custom template for Month, Year, Decade, and Century views. For default view customization, use <code>HeaderView</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_HeaderView" aria-label="View HeaderView property in API reference">HeaderView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html" aria-label="View CalendarHeaderView type in API reference">CalendarHeaderView</a></td>
    <td>Customizes the appearance and behavior of the built-in header across calendar views.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Identifier" aria-label="View Identifier property in API reference">Identifier</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarIdentifier.html" aria-label="View CalendarIdentifier type in API reference">CalendarIdentifier</a></td>
    <td>Chooses the calendar system used to display and interpret dates, such as Gregorian or Hijri. The default value is Gregorian. <code>FlowDirection</code> is updated based on this value; set <code>FlowDirection</code> after <code>Identifier</code> to override.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_IsOpen" aria-label="View IsOpen property in API reference">IsOpen</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether the calendar popup is currently displayed when the calendar is used in a popup-based mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressedCommand" aria-label="View LongPressedCommand property in API reference">LongPressedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when a date cell is long-pressed. The default value is null.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MaximumDate" aria-label="View MaximumDate property in API reference">MaximumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits navigation and selection to dates on or before the specified date. Dates beyond this range remain unavailable.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MinimumDate" aria-label="View MinimumDate property in API reference">MinimumDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a></td>
    <td>Limits navigation and selection to dates on or after the specified date. Dates before this range remain unavailable.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Mode" aria-label="View Mode property in API reference">Mode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMode.html" aria-label="View CalendarMode type in API reference">CalendarMode</a></td>
    <td>Determines whether the calendar is displayed inline or shown as a popup relative to a target view.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MonthView" aria-label="View MonthView property in API reference">MonthView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html" aria-label="View CalendarMonthView type in API reference">CalendarMonthView</a></td>
    <td>Configures month-view-specific features such as special dates, week numbers, weekend appearance, and date-cell styling.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MonthViewHeaderTemplate" aria-label="View MonthViewHeaderTemplate property in API reference">MonthViewHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in month-view header row with a custom template. For default view customization, use <code>CalendarMonthHeaderView</code> from <code>MonthView</code>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_NavigateToAdjacentMonth" aria-label="View NavigateToAdjacentMonth property in API reference">NavigateToAdjacentMonth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether tapping leading or trailing dates automatically navigates to the corresponding adjacent month. The default value is true. Applicable only in month view.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_NavigationDirection" aria-label="View NavigationDirection property in API reference">NavigationDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarNavigationDirection.html" aria-label="View CalendarNavigationDirection type in API reference">CalendarNavigationDirection</a></td>
    <td>Controls whether users navigate through dates vertically or horizontally. The default value is <c>Vertical</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_PopupHeight" aria-label="View PopupHeight property in API reference">PopupHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Specifies the height of the calendar popup when displayed in a popup-based mode. The default height is the sum of header, month-view header, and footer heights.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_PopupWidth" aria-label="View PopupWidth property in API reference">PopupWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Specifies the width of the calendar popup when displayed in a popup-based mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_RangeSelectionDirection" aria-label="View RangeSelectionDirection property in API reference">RangeSelectionDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarRangeSelectionDirection.html" aria-label="View CalendarRangeSelectionDirection type in API reference">CalendarRangeSelectionDirection</a></td>
    <td>Controls how date ranges are extended and interpreted during range selection. See <code>CalendarRangeSelectionDirection</code> for supported options. The default value is <c>Default</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_RelativePosition" aria-label="View RelativePosition property in API reference">RelativePosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarRelativePosition.html" aria-label="View CalendarRelativePosition type in API reference">CalendarRelativePosition</a></td>
    <td>Defines where the popup appears relative to <code>RelativeView</code> when using relative dialog mode. Applicable only for relative dialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_RelativeView" aria-label="View RelativeView property in API reference">RelativeView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Specifies the view used as the reference element for positioning the calendar popup in relative dialog mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate" aria-label="View SelectableDayPredicate property in API reference">SelectableDayPredicate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.func-2" aria-label="View Func type in API reference">Func&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime</a>, <a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool&gt;</a></a></td>
    <td>Applies custom logic to determine which dates can be selected. Dates that do not satisfy the predicate remain unavailable for selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDate" aria-label="View SelectedDate property in API reference">SelectedDate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable" aria-label="View Nullable type in API reference">Nullable&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Represents the currently selected date in Single selection mode. In Year, Decade, and Century views, selection is possible only when <code>AllowViewNavigation</code> is disabled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDateRange" aria-label="View SelectedDateRange property in API reference">SelectedDateRange</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDateRange.html" aria-label="View CalendarDateRange type in API reference">CalendarDateRange</a></td>
    <td>Represents the currently selected date range in Range selection mode. The range must have a valid start and end sequence.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDateRanges" aria-label="View SelectedDateRanges property in API reference">SelectedDateRanges</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDateRange.html" aria-label="View CalendarDateRange type in API reference">CalendarDateRange&gt;</a></a></td>
    <td>Represents multiple selected date ranges when the calendar is configured to support multi-range selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDates" aria-label="View SelectedDates property in API reference">SelectedDates</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;<a href="https://learn.microsoft.com/dotnet/api/system.datetime" aria-label="View DateTime type in API reference">DateTime&gt;</a></a></td>
    <td>Represents the collection of selected dates in Multiple selection mode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionBackground" aria-label="View SelectionBackground property in API reference">SelectionBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the highlight applied to selected dates. In Range mode, the same brush is used for the dates between the range start and end. The default value is null; when null, the default accent (<c>#6200EE</c>) is used.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionCellTemplate" aria-label="View SelectionCellTemplate property in API reference">SelectionCellTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default appearance of selected cells with a custom template.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChangedCommand" aria-label="View SelectionChangedCommand property in API reference">SelectionChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes whenever the calendar selection changes.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionMode.html" aria-label="View CalendarSelectionMode type in API reference">CalendarSelectionMode</a></td>
    <td>Determines whether users can select a single date, multiple dates, or a date range. Supported values are <code>Single</code>, <code>Multiple</code>, and Range.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionShape" aria-label="View SelectionShape property in API reference">SelectionShape</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionShape.html" aria-label="View CalendarSelectionShape type in API reference">CalendarSelectionShape</a></td>
    <td>Controls the shape used to highlight selected dates. The default value is <c>Circle</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ShowActionButtons" aria-label="View ShowActionButtons property in API reference">ShowActionButtons</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays confirm and cancel buttons that allow users to accept or discard pending selections. The default value is false.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ShowOutOfRangeDates" aria-label="View ShowOutOfRangeDates property in API reference">ShowOutOfRangeDates</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether dates outside the <code>MinimumDate</code> and <code>MaximumDate</code> limits remain visible in the calendar.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ShowTodayButton" aria-label="View ShowTodayButton property in API reference">ShowTodayButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Displays a button that navigates the calendar to the current date. The default value is false.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ShowTrailingAndLeadingDates" aria-label="View ShowTrailingAndLeadingDates property in API reference">ShowTrailingAndLeadingDates</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Controls whether dates from adjacent periods are shown in Month, Decade, and Century views. This setting does not apply to Year view. The default value is true.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_StartRangeSelectionBackground" aria-label="View StartRangeSelectionBackground property in API reference">StartRangeSelectionBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the visual highlight applied to the starting date of a selected range. The default value is <c>#6200EE</c> (blue). Applicable only when <code>SelectionMode</code> is <c>Range</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_TappedCommand" aria-label="View TappedCommand property in API reference">TappedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when a date cell is tapped. The default value is null.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_TodayHighlightBrush" aria-label="View TodayHighlightBrush property in API reference">TodayHighlightBrush</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the visual highlight used to identify the current date. The default value is <c>#6200EE</c> (blue). This value is applied to month view header text when the dates include today and the value is not transparent.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_View" aria-label="View View property in API reference">View</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarView.html" aria-label="View CalendarView type in API reference">CalendarView</a></td>
    <td>Selects the active calendar view. Supported views are Month, Year, Decade, and Century. The default value is <c>Month</c>.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChangedCommand" aria-label="View ViewChangedCommand property in API reference">ViewChangedCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Executes when the active view changes or when the visible date range is updated through navigation. The default value is null.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_YearView" aria-label="View YearView property in API reference">YearView</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html" aria-label="View CalendarYearView type in API reference">CalendarYearView</a></td>
    <td>Configures the appearance and behavior of the Year, Decade, and Century views.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Backward" aria-label="View Backward method in API reference">Backward()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Navigates to the previous date interval in the current calendar view, such as the previous month, year, decade, or century. If navigation beyond MinimumDate is not allowed, the visible dates remain unchanged.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Forward" aria-label="View Forward method in API reference">Forward()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Navigates to the next date interval in the current calendar view, such as the next month, year, decade, or century. If navigation beyond MaximumDate is not allowed, the visible dates remain unchanged.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_UpdateSpecialDayPredicate" aria-label="View UpdateSpecialDayPredicate method in API reference">UpdateSpecialDayPredicate()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Refreshes the special-date indicators in the month view after the <code>SpecialDayPredicate</code> logic changes, ensuring the visible date cells reflect the updated special-day state.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ActionButtonCanceled" aria-label="View ActionButtonCanceled event in API reference">ActionButtonCanceled</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the user taps the cancel button. Any unconfirmed date or range selections are reverted to the last confirmed selection.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ActionButtonClicked" aria-label="View ActionButtonClicked event in API reference">ActionButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSubmittedEventArgs.html" aria-label="View CalendarSubmittedEventArgs type in API reference">CalendarSubmittedEventArgs&gt;</a></a></td>
    <td>Triggered when the user taps the confirm button to accept the current date or range selection. Use this event to commit selection-dependent actions when ShowActionButtons is enabled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CalendarPopupClosed" aria-label="View CalendarPopupClosed event in API reference">CalendarPopupClosed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the calendar popup has been closed.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CalendarPopupClosing" aria-label="View CalendarPopupClosing event in API reference">CalendarPopupClosing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs" aria-label="View CancelEventArgs type in API reference">CancelEventArgs&gt;</a></a></td>
    <td>Triggered before the calendar popup closes, allowing the close operation to be canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CalendarPopupOpened" aria-label="View CalendarPopupOpened event in API reference">CalendarPopupOpened</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered after the calendar popup becomes visible.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CalendarPopupOpening" aria-label="View CalendarPopupOpening event in API reference">CalendarPopupOpening</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/system.componentmodel.canceleventargs" aria-label="View CancelEventArgs type in API reference">CancelEventArgs&gt;</a></a></td>
    <td>Triggered before the calendar popup opens, allowing the open operation to be canceled.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DoubleTapped" aria-label="View DoubleTapped event in API reference">DoubleTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDoubleTappedEventArgs.html" aria-label="View CalendarDoubleTappedEventArgs type in API reference">CalendarDoubleTappedEventArgs&gt;</a></a></td>
    <td>Triggered when a date cell is double-tapped. Use this event to provide secondary interactions for a date without affecting the primary tap behavior.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressed" aria-label="View LongPressed event in API reference">LongPressed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html" aria-label="View CalendarLongPressedEventArgs type in API reference">CalendarLongPressedEventArgs&gt;</a></a></td>
    <td>Triggered when a date cell is pressed and held. Commonly used to display context actions or additional information for a date.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html" aria-label="View CalendarSelectionChangedEventArgs type in API reference">CalendarSelectionChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the selected date, selected dates, or selected range changes, depending on the active SelectionMode.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Tapped" aria-label="View Tapped event in API reference">Tapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html" aria-label="View CalendarTappedEventArgs type in API reference">CalendarTappedEventArgs&gt;</a></a></td>
    <td>Triggered when a date cell is tapped. This event provides access to the interacted date and can be used to handle custom date-selection behavior.</td>
</tr>
<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChanged" aria-label="View ViewChanged event in API reference">ViewChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html" aria-label="View CalendarViewChangedEventArgs type in API reference">CalendarViewChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the active calendar view changes or when navigation updates the currently visible date range.</td>
</tr>
</table>