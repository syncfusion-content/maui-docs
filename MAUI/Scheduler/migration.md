---
layout: post
title: Migrate from Xamarin SfSchedule to .NET MAUI SfScheduler | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin Schedule to Syncfusion .NET MAUI Scheduler control and more.
platform: MAUI
control: SfScheduler
documentation: ug
---  

# Migrate from Xamarin.Forms SfSchedule to .NET MAUI SfScheduler 

To migrate easier from [Xamarin SfSchedule](https://www.syncfusion.com/xamarin-ui-controls/xamarin-scheduler) to [.NET MAUI SfScheduler](https://www.syncfusion.com/maui-controls/maui-scheduler), we kept most of the APIs from Xamarin SfSchedule in MAUI SfScheduler. However, to maintain the consistency of API naming in MAUI SfScheduler, we renamed some of the APIs. The APIs that have been changed in MAUI SfScheduler from Xamarin SfSchedule are detailed as follows.

## Assembly Name 

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>Syncfusion.SfSchedule.XForms</td>
<td>Syncfusion.Maui.Scheduler</td></tr>
</table>

## Namespaces 

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>Syncfusion.SfSchedule.XForms</td>
<td>Syncfusion.Maui.Scheduler</td></tr>
<tr>
<td>Syncfusion.SfSchedule.XForms.ScheduleHelper</td>
<td>Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>
<tr>
<td>{{'[AppointmentStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html)'| markdownify}}</td>
<td>{{'[SchedulerTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html)'| markdownify }}</td>
<td> Gets or sets properties which allows to customize the scheduler text style of the SfScheduler.</td></tr>

<tr> 
<td>{{'[CellStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.CellStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerMonthCellStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html)'| markdownify }}</td>
<td> Gets or sets properties which allows to customize the month cell in month view style of the SfScheduler.</td></tr> 
<tr>

<td>{{'[CellTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.CellTappedEventArgs.html)'| markdownify}}</td>
<td>{{'[SchedulerTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTappedEventArgs.html)'| markdownify }}</td>
<td>Provides data for cell tapped event.</td></tr>
<tr>

<td>{{'[DaysViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td> Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>
<tr>

<td>{{'[HeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderView.html)'| markdownify }}</td>
<td> Represents a class which is used to customize all the properties of header settings of the SfScheduler.</td></tr> 
<tr> 

<td>{{'[MonthViewCellStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerMonthCellStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the month cell in month view style of the SfScheduler.</td></tr>
<tr>

<td>{{'[MonthViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerMonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html)'| markdownify }}</td>
<td> Represents a class which is used to configure all the properties of Month view.</td></tr>
<tr>

<td>{{'[NonAccessibleBlock](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.NonAccessibleBlock.html)'| markdownify }}</td>
<td>{{'[SchedulerTimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html)'| markdownify }}</td>
<td>Defines the time region in the scheduler.</td></tr>

<tr>
<td>{{'[RecurrenceProperties](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.RecurrenceProperties.html)'| markdownify }}</td>
<td>{{'[SchedulerRecurrenceInfo](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceInfo.html)'| markdownify }}</td>
<td>Represents a class which allows to create recurrence rule for an scheduler appointment.</td></tr>

<tr>
<td>{{'[ScheduleAppointment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html)'| markdownify }}</td>
<td>{{'[SchedulerAppointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html)'| markdownify }}</td>
<td>Represents a class which defines the scheduler appointment properties of the scheduler.</td></tr>

<tr>
<td>{{'[ScheduleAppointmentMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html)'| markdownify }}</td>
<td>{{'[SchedulerAppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html)'| markdownify }}</td>
<td>Represents a class which is used to mapping the properties for an Scheduler Appointment.</td></tr>

<tr>
<td>{{'[ScheduleHelper](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleHelper.html)'| markdownify }}</td>
<td>{{'[SchedulerRecurrenceManager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager.html)'| markdownify }}</td>
<td> Represents a helper for handling the recurrence appointments.</td></tr>

<tr>
<td>{{'[TimelineViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerTimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html?tabs=tabid-3%2Ctabid-5)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of timeline day, timeline week, timeline workweek and timeline month views of the SfScheduler.</td></tr>

<tr>
<td>{{'[TimeRegionSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerTimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html)'| markdownify }}</td>
<td>Represents a class which is used to highlight time slots on day, week, workweek and timeline day, timeline week and timeline workweek based on start and end time and also used to restrict interaction on time slots.</td></tr>

<tr>
<td>{{'[ViewHeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html)'| markdownify }}</td>
<td>{{'[ViewHeaderSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html)'| markdownify }}</td>
<td>Represents a class which is used to customize all the properties of view header in the SfScheduler.</td></tr>

<tr>
<td>{{'[ViewHeaderTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderTappedEventArgs.html)'| markdownify }}</td>
<td>{{'[SchedulerTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTappedEventArgs.html)'| markdownify }}</td>
<td>Provides data for view header tapped event.</td></tr>

<tr>
<td>{{'[VisibleDatesChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.VisibleDatesChangedEventArgs.html)'| markdownify }}</td>
<td>{{'[SchedulerViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewChangedEventArgs.html)'| markdownify }}</td>
<td>Provides data for scheduler view changed event.</td></tr>

<tr>
<td>{{'[WeekLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>

<tr>
<td>{{'[WeekNumberStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekNumberStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerWeekNumberStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerWeekNumberStyle.html)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the week number style of the SfScheduler.</td></tr>

<tr>
<td>{{'[WeekViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekViewSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>

<tr>
<td>{{'[WorkWeekLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WorkWeekLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>

<tr>
<td>{{'[WorkWeekViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WorkWeekViewSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>

<tr>
<td>{{'[DayLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerDaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of day, week and workweek views of the SfScheduler.</td></tr>

<tr>
<td>{{'[MonthLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerMonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html?tabs=tabid-5%2Ctabid-1)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of Month view..</td></tr>

<tr>
<td>{{'[TimelineLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerTimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html?tabs=tabid-3%2Ctabid-5)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of timeline day, timeline week, timeline workweek and timeline month views of the SfScheduler.</td></tr>
</table> 

## Properties

<table> 
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>
<tr>
<td>{{'[AppointmentMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_AppointmentMapping)'| markdownify }}</td>
<td>{{'[AppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html)'| markdownify }}</td>
<td>Gets or sets the custom object configuration mapping information.</td></tr>
<tr>
<td>{{'[AppointmentStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_AppointmentStyle)'| markdownify }}</td>
<td>{{'[AppointmentTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AppointmentTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of appointment text, that used to customize the text color, font, font size, font family and font attributes.</td></tr>

<tr>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_AppointmentTemplate)' | markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_DataSource)' | markdownify }}</td>
<td>{{'[AppointmentsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AppointmentsSource)'| markdownify }}</td>
<td>Gets or sets the value which used to set the appointment collection to the scheduler.</td></tr>

<tr>
<td>{{'[DayViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_DayViewSettings)' | markdownify }},<br/>{{'[WeekViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_WeekViewSettings)' | markdownify }},<br/>{{'[WorkWeekViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_WorkWeekViewSettings)' | markdownify }}</td>
<td>{{'[DaysView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DaysView)'| markdownify }}</td>
<td>Gets or sets the properties which allows to customize the day, week and work week view of the scheduler.</td></tr>

<tr>
<td>{{'[MonthViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthViewSettings)' | markdownify }}</td>
<td>{{'[MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_MonthView)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the month view of the scheduler.</td></tr>

<tr>
<td>{{'[TimelineViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimelineViewSettings)' | markdownify }}</td>
<td>{{'[TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimelineView)'| markdownify }}</td>
<td>Gets or sets the properties which allows to customize the timeline day, timeline week and timeline work week and timeline month views of the scheduler.</td></tr>

<tr>
<td>{{'[FirstDayOfWeek](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_FirstDayOfWeek)' | markdownify }}</td>
<td>{{'[FirstDayOfWeek](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_FirstDayOfWeek)'| markdownify }}</td>
<td>Gets or sets the day to change the default first day of week in the SfScheduler.</td></tr>

<tr>
<td>{{'[HeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_HeaderStyle)' | markdownify }}</td>
<td>{{'[HeaderVIew](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_HeaderView)'| markdownify }}</td>
<td>Gets or sets the properties which allows to customize the scheduler header of day, week and work week, month, timeline day, timeline week, timeline work week, and timeline month views of the scheduler.</td></tr>

<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_HeaderHeight)' | markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Height)'| markdownify }} (From HeaderView)</td>
<td>Gets or sets the header height to customize the default height property of the header in the scheduler.</td></tr>

<tr>
<td>{{'[Locale](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_Locale)' | markdownify }}</td>
<td>Application culture can be changed by setting CurrentUICulture. in App.xaml.cs file.</td>
<td>To localize the schedule default strings with given language..</td></tr>

<tr>
<td>{{'[MaxDisplayDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MaxDisplayDate)' | markdownify }}</td>
<td>{{'[MaximumDateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_MaximumDateTime)'| markdownify }}</td>
<td>Gets or sets the maximum display date to restrict the visible dates in the SfScheduler.</td></tr>

<tr>
<td>{{'[MinDisplayDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MinDisplayDate)' | markdownify }}</td>
<td>{{'[MinimumDateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_MinimumDateTime)'| markdownify }}</td>
<td>Gets or sets the minimum display date to restrict the visible dates in the SfScheduler.</td></tr>

<tr>
<td>{{'[MonthCellStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthCellStyle)' | markdownify }}</td>
<td>{{'[CellStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_CellStyle)'| markdownify }} (From MonthView)</td>
<td>Gets or sets the style of month cell, that used to customize the background, today background, leading month cell background, trailing month cell background and text color, font, font size, font family, font attributes of normal month cell, leading month cell and trailing month cell.</td></tr>

<tr>
<td>{{'[MoveToDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MoveToDate)' | markdownify }}</td>
<td>{{'[DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DisplayDate)'| markdownify }}</td>
<td>Gets or sets the display date to programmatically navigate the dates in the scheduler.</td></tr>

<tr>
<td>{{'[ScheduleHeaderDateFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ScheduleHeaderDateFormat)' | markdownify }}</td>
<td>{{'[TextFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderView.html#Syncfusion_Maui_Scheduler_SchedulerHeaderView_TextFormat)'| markdownify }} (From HeaderView)</td>
<td>Gets or sets the text format to customize the default text format property of the header in the scheduler..</td></tr>

<tr>
<td>{{'[ScheduleView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ScheduleView)' | markdownify }}</td>
<td>{{'[View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_View)'| markdownify }}</td>
<td>Gets or sets the built in views such as day, week, work week, month, timeline day, timeline week, timeline work week, and timeline month views of the SfScheduler.</td></tr>

<tr>
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_SelectedDate)' | markdownify }}</td>
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectedDate)'| markdownify }}</td>
<td>Gets or sets the Selected Date property for scheduler to select a particular date or time slot programmatically.</td></tr>

<tr>
<td>{{'[ShowCurrentTimeIndicator](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ShowCurrentTimeIndicator)' | markdownify }}</td>
<td>{{'[ShowCurrentTimeIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_ShowCurrentTimeIndicator)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets a value indicating whether the visibility of current time indicator.</td></tr>

<tr>
<td>{{'[SpecialTimeRegions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_SpecialTimeRegions)' | markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the scheduler.</td></tr>

<tr>
<td>{{'[TimeInterval](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeInterval)' | markdownify }}</td>
<td>{{'[TimeInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeInterval)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets the time interval between the time slots in the time slot views of the scheduler.</td></tr>

<tr>
<td>{{'[TimeIntervalHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeIntervalHeight)' | markdownify }}</td>
<td>{{'[TimeIntervalHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html#Syncfusion_Maui_Scheduler_SchedulerDaysView_TimeIntervalHeight)'| markdownify }} (From DaysView), <br/> {{'[TimeIntervalWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeIntervalWidth)'| markdownify }} (From TimelineView)</td>
<td>Gets or sets the height for each time slot cell to layout within this in day, week, and work week views of the scheduler.</td></tr>

<tr>
<td>{{'[TimeZone](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeZone)' | markdownify }}</td>
<td>{{'[TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimeZone)'| markdownify }}</td>
<td>Gets or sets the Time zone to customize the default time zone property of scheduler with particular time zone.</td></tr>

<tr>
<td>{{'[ViewHeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ViewHeaderHeight)' | markdownify }}</td>
<td>{{'[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Height)'| markdownify }} (ViewHeaderSettings from DaysView, MonthView, TimelineView)</td>
<td>Gets or sets the properties which allows to customize the height of view header in the scheduler.</td></tr>

<tr>
<td>{{'[ViewHeaderStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ViewHeaderStyle)' | markdownify }}</td>
<td>{{'[DateTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateTextStyle)'| markdownify }}, <br/> {{'[DayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayTextStyle)'| markdownify }} (From ViewHeaderSettings of DaysView, MonthView, TimelineView)</td>
<td>Gets or sets the properties which allows to customize all the properties of view header in the scheduler.</td></tr>

</table> 

## SchedulerAppointment

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>

<tr>
<td>{{'[StartTime](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_StartTime)'| markdownify }}</td>
<td>{{'[StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime)'| markdownify }}</td>
<td>Gets or sets the start time for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[EndTime](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_EndTime)'| markdownify }}</td>
<td>{{'[EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime)'| markdownify }}</td>
<td>Gets or sets the end time for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[ActualStartTime](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_ActualStartTime)'| markdownify }}</td>
<td>{{'[ActualStartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualStartTime)'| markdownify }}</td>
<td>Gets the internal start time which is converted based on start time zone applied.</td></tr>

<tr>
<td>{{'[ActualEndTime](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_ActualEndTime)'| markdownify }}</td>
<td>{{'[ActualEndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualEndTime)'| markdownify }}</td>
<td>Gets the internal end time which is converted based on end time zone applied.</td></tr>

<tr>
<td>{{'[Subject](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_Subject)'| markdownify }}</td>
<td>{{'[Subject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_Subject)'| markdownify }}</td>
<td>Gets or sets the Subject value for Scheduler Appointment to describe the appointments subject in scheduler.</td></tr>

<tr>
<td>{{'[StartTimeZone](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_StartTimeZone)'| markdownify }}</td>
<td>{{'[StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_StartTimeZone)'| markdownify }}</td>
<td>Gets or sets the start time zone for the appointment.</td></tr>

<tr>
<td>{{'[EndTimeZone](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_EndTimeZone)'| markdownify }}</td>
<td>{{'[EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_EndTimeZone)'| markdownify }}</td>
<td>Gets or sets the end time zone for the appointment.</td></tr>

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From AppointmentTextStyle)</td>
<td>Gets or sets the text color for an appointment in the SfScheduler.</td></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_Color)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_Background)'| markdownify }}</td>
<td>Gets or sets the background color for an appointment or the scheduler time region in the SfScheduler..</td></tr>

<tr>
<td>{{'[IsAllDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_IsAllDay)'| markdownify }}</td>
<td>{{'[IsAllDay](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_IsAllDay)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the appointment is all day.</td></tr>

<tr>
<td>{{'[RecurrenceExceptionDates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_RecurrenceExceptionDates)'| markdownify }}</td>
<td>{{'[RecurrenceExceptionDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceExceptionDates)'| markdownify }}</td>
<td>Gets or sets the recurrence exception dates for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[RecurrenceId](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_RecurrenceId)'| markdownify }}</td>
<td>{{'[RecurrenceId](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_RecurrenceId)'| markdownify }}</td>
<td>Gets or sets the Id which is used to maintain the pattern recurrence Id that added in AppointmentsSource for creating the exception recurrence appointment.</td></tr>

<tr>
<td>{{'[RecurrenceRule](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_RecurrenceRule)'| markdownify }}</td>
<td>{{'[RecurrenceRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceRule)'| markdownify }}</td>
<td>Gets or sets the recurrence rule for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[Id](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_Id)'| markdownify }}</td>
<td>{{'[Id](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_Id)'| markdownify }}</td>
<td>Gets or sets an unique Id for referring event or appointment.</td></tr>

<tr>
<td>{{'[Notes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_Notes)'| markdownify }}</td>
<td>{{'[Notes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_Notes)'| markdownify }}</td>
<td>Gets or sets the Notes for Scheduler Appointment to describe a note about the appointment in scheduler.</td></tr>

<tr>
<td>{{'[Location](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_Location)'| markdownify }}</td>
<td>{{'[Location](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_Location)'| markdownify }}</td>
<td>Gets or sets the Location value for Scheduler Appointment to describe the location of the appointment in scheduler.</td></tr>

</table> 

## SchedulerAppointmentMapping

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>

<tr>
<td>{{'[StartTimeMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_StartTimeMapping)'| markdownify }}</td>
<td>{{'[StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_StartTime)'| markdownify }}</td>
<td>Gets or sets and sets the Start Time Mapping to map the custom appointment property with scheduler appointments start time property.</td></tr>

<tr>
<td>{{'[EndTimeMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_EndTimeMapping)'| markdownify }}</td>
<td>{{'[EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_EndTime)'| markdownify }}</td>
<td>Gets or sets the End Time Mapping to map the custom appointment property with scheduler appointments end time property.</td></tr>

<tr>
<td>{{'[SubjectMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_SubjectMapping)'| markdownify }}</td>
<td>{{'[Subject](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_Subject)'| markdownify }}</td>
<td>Gets or sets the Subject Mapping to map the custom property with scheduler appointments subject property.</td></tr>

<tr>
<td>{{'[StartTimeZoneMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_StartTimeZoneMapping)'| markdownify }}</td>
<td>{{'[StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_StartTimeZone)'| markdownify }}</td>
<td>Gets or sets the Start Time Zone Mapping to map the custom appointment property with scheduler appointments start time zone property.</td></tr>

<tr>
<td>{{'[EndTimeZoneMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_EndTimeZoneMapping)'| markdownify }}</td>
<td>{{'[EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_EndTimeZone)'| markdownify }}</td>
<td>Gets or sets the End Time Zone Mapping to map the custom property with scheduler appointments end time zone property.</td></tr>

<tr>
<td>{{'[ColorMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_ColorMapping)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_Background)'| markdownify }}</td>
<td>Gets or sets the Background Mapping to map the custom appointment property with scheduler appointments color property.</td></tr>

<tr>
<td>{{'[IsAllDayMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_IsAllDayMapping)'| markdownify }}</td>
<td>{{'[IsAllDay](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_IsAllDay)'| markdownify }}</td>
<td>Gets or sets the Is All Day Mapping to map the custom appointment property with scheduler appointments IsAllDay property.</td></tr>

<tr>
<td>{{'[RecurrenceRuleMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_RecurrenceRuleMapping)'| markdownify }}</td>
<td>{{'[RecurrenceRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_RecurrenceRule)'| markdownify }}</td>
<td>Gets or sets the Recurrence Rule Mapping to map the custom appointment property with scheduler appointments Recurrence Rule property.</td></tr>

<tr>
<td>{{'[RecurrenceExceptionDatesMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_RecurrenceExceptionDatesMapping)'| markdownify }}</td>
<td>{{'[RecurrenceExceptionDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_RecurrenceExceptionDates)'| markdownify }}</td>
<td>Gets or sets the Recurrence Exception Dates Mapping to map the custom appointment property with the scheduler appointments Recurrence Exception Dates property.</td></tr>

<tr>
<td>{{'[RecurrenceIdMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_RecurrenceIdMapping)'| markdownify }}</td>
<td>{{'[RecurrenceId](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_RecurrenceId)'| markdownify }}</td>
<td>Gets or sets the Recurrence ID mapping to map the custom appointment property with scheduler appointments Recurrence ID property.</td></tr>

<tr>
<td>{{'[IdMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_IdMapping)'| markdownify }}</td>
<td>{{'[Id](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_Id)'| markdownify }}</td>
<td>Gets or sets the mapping that binds the appointment's Id property to the data source field.</td></tr>

<tr>
<td>{{'[NotesMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_NotesMapping)'| markdownify }}</td>
<td>{{'[Notes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_Notes)'| markdownify }}</td>
<td>Gets or sets the Notes Mapping to map the custom property with scheduler appointments notes property.</td></tr>

<tr>
<td>{{'[LocationMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_LocationMapping)'| markdownify }}</td>
<td>{{'[Location](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_Location)'| markdownify }}</td>
<td>Gets or sets the Location Mapping to map the custom property with scheduler appointments location property.</td></tr>

 </table> 

## Enums

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>

<tr>
<td>{{'[AppointmentDisplayMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentDisplayMode.html)'| markdownify }}</td>
<td>{{'[SchedulerMonthAppointmentDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html)'| markdownify }}</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[RecurrenceRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.RecurrenceRange.html)'| markdownify }}</td>
<td>{{'[SchedulerRecurrenceRange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceRange.html)'| markdownify }}</td>
<td>Specifies the type of recurrence date range.</td></tr>

<tr>
<td>{{'[RecurrenceType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.RecurrenceType.html)'| markdownify }}</td>
<td>{{'[SchedulerRecurrenceType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceType.html)'| markdownify }}</td>
<td>Specifies the type of recurrence in the appointment.</td></tr>

<tr>
<td>{{'[ScheduleView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleView.html)'| markdownify }}</td>
<td>{{'[SchedulerView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerView.html)'| markdownify }}</td>
<td>Defines the view for the SfScheduler.</td></tr>

</table> 

## Events

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>
<tr>
<td>{{'[CellDoubleTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_CellDoubleTapped)'| markdownify }}</td>
<td>{{'[DoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DoubleTapped)'| markdownify }}</td>
<td>Occurs when an item is double tapped.</td></tr>

<tr>
<td>{{'[CellTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_CellTapped)'| markdownify }}</td>
<td>{{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify }}</td>
<td>Occurs when an item is tapped.</td></tr>

<tr>
<td>{{'[CellLongPressed](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_CellLongPressed)'| markdownify }}</td>
<td>{{'[LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_LongPressed)'| markdownify }}</td>
<td>Occurs when an item is long pressed.</td></tr>

<tr>
<td>{{'[HeaderTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_HeaderTapped)'| markdownify }}</td>
<td>{{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify }}</td>
<td>Occurs when header item is tapped.</td></tr>

<tr>
<td>{{'[ViewHeaderTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ViewHeaderTapped)'| markdownify }}</td>
<td>{{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify }}</td>
<td>Occurs when view header item is tapped.</td></tr>

<tr>
<td>{{'[VisibleDatesChangedEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_VisibleDatesChangedEvent)'| markdownify }}</td>
<td>{{'[ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_ViewChanged)'| markdownify }}</td>
<td>Occurs when view changed.</td></tr>

</table> 

## Methods
<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>
<tr>

<tr>
<td>{{'[Backward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_Backward)'| markdownify}}</td>
<td>{{'[Backward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Backward)'| markdownify }}</td>
<td>Move to previous view which displays previous view dates.</td></tr>

<tr>
<td>{{'[Forward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_Forward)'| markdownify}}</td>
<td>{{'[Forward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Forward)'| markdownify }}</td>
<td>Move to next view which displays next view dates.</td></tr>

<tr>
<td>{{'[GetVisibleAppointments](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_GetVisibleAppointments_System_DateTime_System_Nullable_System_DateTime__)'| markdownify}}</td>
<td>{{'[GetOccurrenceAppointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager.html#Syncfusion_Maui_Scheduler_SchedulerRecurrenceManager_GetOccurrenceAppointment_Syncfusion_Maui_Scheduler_SfScheduler_System_Object_System_DateTime_)'| markdownify }}</td>
<td>Returns the occurrence appointment for the given pattern appointment at the specified date. If there is no appointment occurring on the date specified, null is returned.</td></tr>

<tr>
<td>{{'[GetRecurrenceDateTimeCollection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_GetRecurrenceDateTimeCollection_System_String_System_DateTime_System_Nullable_System_DateTime__System_Nullable_System_DateTime__)'| markdownify}}</td>
<td>{{'[GetDateTimeOccurrences](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager.html#Syncfusion_Maui_Scheduler_SchedulerRecurrenceManager_GetDateTimeOccurrences_System_String_System_DateTime_System_Nullable_System_DateTime__System_Nullable_System_DateTime__System_Nullable_System_DateTime__)'| markdownify }}</td>
<td>Method to get date time collection at which the recurrence appointment will occur.</td></tr>

<tr>
<td>{{'[RRuleGenerator](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_RRuleGenerator_Syncfusion_SfSchedule_XForms_RecurrenceProperties_System_DateTime_System_DateTime_)'| markdownify}}</td>
<td>{{'[GenerateRRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager.html#Syncfusion_Maui_Scheduler_SchedulerRecurrenceManager_GenerateRRule_Syncfusion_Maui_Scheduler_SchedulerRecurrenceInfo_System_DateTime_System_DateTime_)'| markdownify }}</td>
<td>Method to generates the recurrence rule based on the given recurrence properties, the start date and end date of the recurrence appointments.</td></tr>

<tr>
<td>{{'[RRuleParser](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_RRuleParser_System_String_System_DateTime_)'| markdownify}}</td>
<td>{{'[ParseRRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRecurrenceManager.html#Syncfusion_Maui_Scheduler_SchedulerRecurrenceManager_ParseRRule_System_String_System_DateTime_)'| markdownify }}</td>
<td>Returns the recurrence properties based on the given recurrence rule and the recurrence start date.</td></tr>
</table> 


## MonthView

<table>
<tr>
<th>Xamarin SfSchedule <br/> (MonthViewSettings)</th>
<th>.NET MAUI SfScheduler <br/> (MonthView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[AppointmentDisplayMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AppointmentDisplayMode)'| markdownify }}</td>
<td>{{'[AppointmentDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_AppointmentDisplayMode)'| markdownify }}</td>
<td>Gets or sets a value which defines the appointment display mode for the month cell in SfScheduler..</td></tr>

<tr>
<td>{{'[BlackoutDates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_BlackoutDates)'| markdownify }}</td>
<td>{{'[SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectableDayPredicate)'| markdownify }} (From Scheduler)</td>
<td>Gets or sets the view rendering to decide whether scheduler view date time should be selectable or not.</td></tr>

<tr>
<td>{{'[ShowWeekNumber](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_ShowWeekNumber)'| markdownify }}</td>
<td>{{'[ShowWeekNumber](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_ShowWeekNumber)'| markdownify }} (From Scheduler)</td>
<td>Gets or sets a value indicating whether to displays the week number of the year in the SfScheduler.</td></tr>

<tr>
<td>{{'[WeekNumberStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_WeekNumberStyle)'| markdownify }}</td>
<td>{{'[WeekNumberStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_WeekNumberStyle)'| markdownify }} (From Scheduler)</td>
<td>Gets or sets the style of the week number, that used to customize the background, text color, font, font size, font family and font attributes.</td></tr>

<tr>
<td>{{'[TodayBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_TodayBackground)'| markdownify }}</td>
<td>{{'[TodayHighlightBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TodayHighlightBrush)'| markdownify }} (From Scheduler)</td>
<td>Gets or sets the color that describes the today highlight color value.</td></tr>

<tr>
<td>{{'[MonthCellTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_MonthCellTemplate)'| markdownify }}</td>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_CellTemplate)'| markdownify }}</td>
<td>Gets or sets the month cell template or template selector.</td></tr>
 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (MonthLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (MonthView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[DateFormat]()'| markdownify }}</td>
<td>{{'[DateFormat]()'| markdownify }} (From ViewHeaderSettings of MonthView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayFormat]()'| markdownify }}</td>
<td>{{'[DayFormat]()'| markdownify }} (From ViewHeaderSettings of MonthView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>
 </table> 

## DayView

<table>
<tr>
<th>Xamarin SfSchedule <br/> (DayViewSettings, WeekViewSettings, WorkWeekViewSettings)</th>
<th>.NET MAUI SfScheduler <br/> (DayView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeRulerSize]()'| markdownify }}</td>
<td>{{'[TimeRulerWidth]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[NonAccessibleBlocks]()'| markdownify }}</td>
<td>{{'[TimeRegions]()'| markdownify }}</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[StartHour]()'| markdownify }}</td>
<td>{{'[StartHour]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[EndHour]()'| markdownify }}</td>
<td>{{'[EndHour]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>
 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (DayLabelSettings, WeekLabelSettings, WorkWeekLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (DayView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeLabelSize]()'| markdownify }}</td>
<td>{{'[TimeRulerWidth]()'| markdownify }} (From TimeRulerTextStyle of DayView class)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TimeLabelColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TimeRulerTextStyle of DayView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TimeFormat]()'| markdownify }}</td>
<td>{{'[TimeFormat]()'| markdownify }}</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateFormat]()'| markdownify }}</td>
<td>{{'[DateFormat]()'| markdownify }} (From ViewHeaderSettings of DayView class)  </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayFormat]()'| markdownify }}</td>
<td>{{'[DayFormat]()'| markdownify }} (From ViewHeaderSettings of DayView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayLabelSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} FontSize(From DateTextStyle in ViewHeaderSettings of DayView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateLabelSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} (From DateTextStyle in ViewHeaderSettings of DayView class)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

 </table> 

## TimelineView

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimelineViewSettings)</th>
<th>.NET MAUI SfScheduler <br/> (TimelineView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[LabelSettings]()'| markdownify }}</td>
<td>{{'[TimeRulerTextStyle]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[NonWorkingsDays]()'| markdownify }}</td>
<td>{{'[NonWorkingDays]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TimeRulerSize]()'| markdownify }}</td>
<td>{{'[TimeRulerHeight]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[BorderColor]()'| markdownify }}</td>
<td>{{'[CellBorderBrush]()'| markdownify }} (From Scheduler) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[StartHour]()'| markdownify }}</td>
<td>{{'[StartHour]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[EndHour]()'| markdownify }}</td>
<td>{{'[EndHour]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimeLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (TimelineView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeFormat]()'| markdownify }}</td>
<td>{{'[TimeFormat]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TimeLabelSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} (From TimeRulerTextStyle of TimelineView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TimeLabelColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TimeRulerTextStyle of TimelineView class) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateFormat]()'| markdownify }}</td>
<td>{{'[DateFormat]()'| markdownify }} (From ViewHeaderSettings of TimelineView class)  </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>
 </table> 


## SchedulerTimeRegion

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimeRegionSettings)</th>
<th>.NET MAUI SfScheduler <br/> (SchedulerTimeRegion)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[StartHour]()'| markdownify }}</td>
<td>{{'[StartTime]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[EndHour]()'| markdownify }}</td>
<td>{{'[EndTime]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[Color]()'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[Text]()'| markdownify }}</td>
<td>{{'[Text]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[CanEdit]()'| markdownify }}</td>
<td>{{'[EnablePointerInteraction]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 

## AppointmentTextStyle

<table>
<tr>
<th>Xamarin SfSchedule <br/> (AppointmentStyle)</th>
<th>.NET MAUI SfScheduler <br/> (AppointmentTextStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 

## CellStyle

<table>
<tr>
<th>Xamarin SfSchedule <br/> (MonthCellStyle, MonthViewCellStyle)</th>
<th>.NET MAUI SfScheduler <br/> (CellStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[BackgroundColor]()'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TodayBackgroundColor]()'| markdownify }}</td>
<td>{{'[TodayBackground]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TodayTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TodayTextStyle of Scheduler) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[PreviousMonthTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From LeadingMonthTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[PreviousMonthBackgroundColor]()'| markdownify }}</td>
<td>{{'[LeadingMonthBackground]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[NextMonthBackgroundColor]()'| markdownify }}</td>
<td>{{'[TrailingMonthBackground]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[NextMonthTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TrailingMonthTextStyle)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 

## HeaderView

<table>
<tr>
<th>Xamarin SfSchedule <br/> (HeaderStyle)</th>
<th>.NET MAUI SfScheduler <br/> (HeaderView)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[BackgroundColor]()'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[TextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 

## ViewHeaderSettings

<table>
<tr>
<th>Xamarin SfSchedule <br/> (ViewHeaderStyle)</th>
<th>.NET MAUI SfScheduler <br/> (ViewHeaderSettings)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[CurrentDayTextColor]()'| markdownify }}, <br/> {{'[CurrentDateTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From TodayTextStyle of Scheduler) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[BackgroundColor]()'| markdownify }}</td>
<td>{{'[Background]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From DayTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateTextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} (From DateTextStyle)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayFontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} (From DayTextStyle)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateFontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} (From DateTextStyle)</td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayFontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} (From DayTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateFontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} (From DateTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DayFontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} (From DayTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[DateFontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} (From DateTextStyle) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 

## WeekNumberStyle

<table>
<tr>
<th>Xamarin SfSchedule <br/> (WeekNumberStyle)</th>
<th>.NET MAUI SfScheduler <br/> (WeekNumberStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor]()'| markdownify }}</td>
<td>{{'[TextColor]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontFamily]()'| markdownify }}</td>
<td>{{'[FontFamily]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontSize]()'| markdownify }}</td>
<td>{{'[FontSize]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[FontAttributes]()'| markdownify }}</td>
<td>{{'[FontAttributes]()'| markdownify }} </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

</table> 