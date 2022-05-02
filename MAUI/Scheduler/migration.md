---
layout: post
title: Migrate from Xamarin SfSchedule to .NET MAUI SfScheduler
description: Learn here all about Migrating from Syncfusion Xamarin Schedule to Syncfusion .NET MAUI Scheduler control and more.
platform: MAUI
control: SfScheduler
documentation: ug
---  

# Migrate from Xamarin.Forms SfSchedule to .NET MAUI SfScheduler 

To make the migration from the Xamarin [Xamarin SfSchedule](https://www.syncfusion.com/xamarin-ui-controls/xamarin-scheduler) to [.NET MAUI SfScheduler](https://www.syncfusion.com/maui-controls/maui-scheduler) easier, most of the APIs from the Xamarin SfSchedule were kept in the.NET MAUI SfScheduler. However, to maintain the consistency of API naming in the.NET MAUI SfScheduler, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>Syncfusion.SfSchedule.XForms</td>
<td>Syncfusion.Maui.Scheduler</td></tr>
</table>

## Initialize control

To initialize the control, import the scheduler namespace and initialize SfScheduler as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:schedule="clr-namespace:Syncfusion.SfSchedule.XForms;assembly=Syncfusion.SfSchedule.XForms">

    <schedule:SfSchedule/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfSchedule.XForms;
...

SfSchedule schedule = new SfSchedule ();
this.Content = schedule;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:scheduler="clr-namespace:Syncfusion.Maui.Scheduler;assembly=Syncfusion.Maui.Scheduler">

    <scheduler:SfScheduler />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Scheduler;
…

SfScheduler scheduler = new SfScheduler();
this.Content = scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
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
<td>Represents a class which is used to configure all the properties of Month view.</td></tr>

<tr>
<td>{{'[TimelineLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html)'| markdownify }}</td>
<td>{{'[SchedulerTimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html?tabs=tabid-3%2Ctabid-5)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of timeline day, timeline week, timeline workweek and timeline month views of the SfScheduler.</td></tr>

<tr>
<td>{{'[AppointmentLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentLoadedEventArgs.html)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[MonthInlineAppointmentLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthInlineAppointmentLoadedEventArgs.html)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[MonthInlineAppointmentTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthInlineAppointmentTappedEventArgs.html)'| markdownify }}</td>
<td>{{'[SchedulerTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTappedEventArgs.html)'| markdownify }}</td>
<td>Occurs when the user clicks or touch on the scheduler elements.</td></tr>

<tr>
<td>{{'[MonthInlineLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthInlineLoadedEventArgs.html)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[MonthCellLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthCellLoadedEventArgs.html)'| markdownify }}</td>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_CellTemplate)'| markdownify }}</td>
<td>Gets or sets the month cell template or template selector.</td></tr>

<tr>
<td>{{'[MonthInlineViewStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthInlineViewStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerAgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAgendaView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of agenda view in the SfScheduler.</td></tr>

<tr>
<td>{{'[AgendaViewStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AgendaViewStyle.html)'| markdownify }}</td>
<td>{{'[SchedulerAgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAgendaView.html)'| markdownify }}</td>
<td>Represents a class which is used to configure all the properties of agenda view in the SfScheduler.</td></tr>

<tr>
<td>{{'[SelectionStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SelectionStyle.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td></tr>

</table> 

## Properties

### SfSchedule

The following code example, explains how to initialize the properties of the Xamarin SfSchedule and .NET MAUI SfScheduler class.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule" ScheduleView="DayView" FirstDayOfWeek="3"/>

{% endhighlight %}

{% highlight C# %}

SfSchedule schedule = new SfSchedule();
schedule.ScheduleView = ScheduleView.DayView;
schedule.FirstDayOfWeek = 3;
this.Content = schedule;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                        View="Week"
                        FirstDayOfWeek="Tuesday"
                        ShowNavigationArrows="True"
                        AllowedViews="Day,Week,WorkWeek,Month"
                        AllowViewNavigation="True">
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

SfScheduler scheduler = new SfScheduler();

scheduler.FirstDayOfWeek = DayOfWeek.Tuesday;
scheduler.AllowedViews = SchedulerViews.Day | SchedulerViews.Week | SchedulerViews.WorkWeek | SchedulerViews.Month;
scheduler.ShowNavigationArrows = true;
scheduler.AllowViewNavigation = true;   

this.Content = scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

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

<tr>
<td>{{'[AppointmentViewLayout](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_AppointmentViewLayout)' | markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[VerticalLineColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_VerticalLineColor)' | markdownify }}</td>
<td>{{'[CellBorderBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_CellBorderBrush)'| markdownify }}</td>
<td>Gets or sets the color that describes the cell border color value.</td></tr>

<tr>
<td>{{'[SelectionView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_SelectionView)' | markdownify }}</td>
<td>{{'[CellBorderBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_CellBorderBrush)'| markdownify }}</td>
<td>Gets or sets the color that describes the cell border color value.</td></tr>

<tr>
<td>{{'[SelectionStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_SelectionStyle)' | markdownify }}</td>
<td>{{'[CellBorderBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_CellBorderBrush)'| markdownify }}</td>
<td>Gets or sets the color that describes the cell border color value.</td></tr>

<tr>
<td>{{'[ShowAppointmentsInline](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_ShowAppointmentsInline)' | markdownify }}</td>
<td> You can use {{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }} instead of InlineView in the scheduler.</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[MonthCellViewLayout](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthCellViewLayout)' | markdownify }}</td>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_CellTemplate)'| markdownify }}</td>
<td>Gets or sets the month cell template or template selector.</td></tr>

<tr>
<td>{{'[InlineView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_InlineView)' | markdownify }}</td>
<td>{{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[EnableNavigation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_EnableNavigation)' | markdownify }}</td>
<td>Nil</td>
<td>The navigation is enabled by default.</td></tr>

<tr>
<td>{{'[TimeSlotBorderStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeZone)' | markdownify }}</td>
<td>Nil</td>
<td>Not supported.</td></tr>

<tr>
<td>{{'[VerticalLineStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeZone)' | markdownify }}</td>
<td>Nil</td>
<td>Not supported.</td></tr>

</table> 

### SchedulerAppointment

The following code example explains how to create the scheduler appointments in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule"/>

{% endhighlight %}

{% highlight C# %}

// Creating an instance for the schedule appointment collection.
ScheduleAppointmentCollection appointmentCollection = new ScheduleAppointmentCollection();   

// Creating new event   
ScheduleAppointment clientMeeting = new ScheduleAppointment();   
clientMeeting.StartTime = DateTime.Today.AddHours(9);   
clientMeeting.EndTime = DateTime.Today.AddHours(11);   
clientMeeting.Color = Color.Blue;   
clientMeeting.Subject = "ClientMeeting";   
appointmentCollection.Add(clientMeeting);  
 
// Adding the schedule appointment collection to the DataSource of Xamarin Schedule.
schedule.DataSource = appointmentCollection;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" />

{% endhighlight %}

{% highlight C# %}

// Creating an instance for the scheduler appointment collection.
var schedulerAppointmentCollection = new ObservableCollection<SchedulerAppointment>();

// Adding scheduler appointment in the schedule appointment collection. 
schedulerAppointmentCollection.Add(new SchedulerAppointment()
{
    StartTime = DateTime.Today.AddHours(9),
    EndTime = DateTime.Today.AddHours(11),
    Subject = "Client Meeting",
    Background = Brush.LightSkyBlue,
});

// Adding the scheduler appointment collection to the AppointmentsSource of .NET MAUI Scheduler.
this.Scheduler.AppointmentsSource = schedulerAppointmentCollection;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

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

<tr>
<td>{{'[MinHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_MinHeight)'| markdownify }}</td>
<td>{{'[MinimumAppointmentDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_MinimumAppointmentDuration)'| markdownify }} (From DaysView, TimelineView)</td>
<td>Gets or sets the height for an appointment when it has minimum duration in time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[ExceptionOccurrenceActualDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointment.html#Syncfusion_SfSchedule_XForms_ScheduleAppointment_ExceptionOccurrenceActualDate)'| markdownify }}</td>
<td>{{'[RecurrenceId](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_RecurrenceId)'| markdownify }}</td>
<td>Gets or sets the Id which is used to maintain the pattern recurrence Id that added in AppointmentsSource for creating the exception recurrence appointment.</td></tr>

</table> 

### SchedulerAppointmentMapping

The following code example explains how to map the custom appointments data in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule">
    <schedule:SfSchedule.AppointmentMapping>
        <schedule:SchedulerAppointmentMapping
                StartTimeMapping="From"
                EndTimeMapping="To"
                SubjectMapping="EventName"
                ColorMapping="color"
                IsAllDayMapping="AllDay"
               />
    </schedule:SfSchedule.AppointmentMapping>
</schedule:SfSchedule>

{% endhighlight %}

{% highlight C# %}

/// <summary>   
/// Represents custom data properties.   
/// </summary>   
public class Meeting
{
    public string EventName { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public Color color { get; set; }
    public bool AllDay { get; set; }
}

// Creates meetings and stores in a collection.  
public ObservableCollection<Meeting> Meetings = new ObservableCollection<Meeting>();
Meeting meeting = new Meeting();
meeting.From = DateTime.Today.AddHours(9);   
meeting.To = (meeting.From.AddHours(1));
meeting.EventName = eventNameCollection[randomTime.Next(9)];
meeting.color = colorCollection[randomTime.Next(9)];
Meetings.Add(meeting);

// Adding the custom schedule appointment collection to the DataSource of Xamarin Schedule.
schedule.DataSource = Meetings;

ScheduleAppointmentMapping dataMapping = new ScheduleAppointmentMapping(); 
dataMapping.ColorMapping = "color";  
dataMapping.EndTimeMapping = "To";
dataMapping.StartTimeMapping = "From"; 
dataMapping.SubjectMapping = "EventName";
dataMapping.IsAllDayMapping = "AllDay";
schedule.AppointmentMapping = dataMapping;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.AppointmentMapping>
        <scheduler:SchedulerAppointmentMapping
                StartTime="From"
                EndTime="To"
                Subject="EventName"
                Background="Background"
                IsAllDay="IsAllDay"
               />
    </scheduler:SfScheduler.AppointmentMapping>
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

/// <summary>    
/// Represents the custom data properties.    
/// </summary>    
public class Meeting
{
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public bool IsAllDay { get; set; }
    public string EventName { get; set; }
    public Brush Background { get; set; }
}

// Creates meetings and stores in a collection.  
public ObservableCollection<Meeting> Meetings = new ObservableCollection<Meeting>();
Meeting meeting = new Meeting();
meeting.From = DateTime.Today.AddHours(9);   
meeting.To = (meeting.From.AddHours(1));
meeting.EventName = "Meeting";
meeting.Background = Brush.Blue;
Meetings.Add(meeting);

// Adding the custom scheduler appointment collection to the AppointmentsSource of .NET MAUI Scheduler.
this.Scheduler.AppointmentsSource = Meetings;

SchedulerAppointmentMapping appointmentMapping = new SchedulerAppointmentMapping();
appointmentMapping.Subject = "EventName";
appointmentMapping.StartTime = "From";
appointmentMapping.EndTime = "To";
appointmentMapping.Background = "Background";
appointmentMapping.IsAllDay = "IsAllDay";
this.Scheduler.AppointmentMapping = appointmentMapping;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

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

<tr>
<td>{{'[MinHeightMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_MinHeightMapping)'| markdownify }}</td>
<td>{{'[MinimumAppointmentDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_MinimumAppointmentDuration)'| markdownify }} (From DaysView, TimelineView)</td>
<td>Gets or sets the height for an appointment when it has minimum duration in time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[ExceptionOccurrenceActualDateMapping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ScheduleAppointmentMapping.html#Syncfusion_SfSchedule_XForms_ScheduleAppointmentMapping_ExceptionOccurrenceActualDateMapping)'| markdownify }}</td>
<td>{{'[RecurrenceId](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_RecurrenceId)'| markdownify }}</td>
<td>Gets or sets the Recurrence ID mapping to map the custom appointment property with scheduler appointments Recurrence ID property.</td></tr>

 </table> 

### MonthView

The following code example explains how to configure the month view settings in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule" ScheduleView="MonthView">
    <schedule:SfSchedule.MonthViewSettings>
        <schedule:MonthViewSettings ShowWeekNumber="False" AppointmentDisplayMode="Appointment">
        </schedule:MonthViewSettings>
    </schedule:SfSchedule.MonthViewSettings>
</schedule>

{% endhighlight %}

{% highlight C# %}

SfSchedule schedule = new SfSchedule();
schedule.ScheduleView = ScheduleView.MonthView;
MonthViewSettings monthViewSettings = new MonthViewSettings();
monthViewSettings.ShowWeekNumber = false;
monthViewSettings.AppointmentDisplayMode = AppointmentDisplayMode.Appointment;
schedule.MonthViewSettings = monthViewSettings;
this.Content = schedule;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                        View="MontView" ShowWeekNumber="false">			
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView 
                       AppointmentDisplayMode="Indicator"/>
    </scheduler:SfScheduler.MonthView>						
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

SfScheduler Scheduler = new SfScheduler();

this.Scheduler.ShowWeekNumber = true;
this.Scheduler.MonthView.AppointmentDisplayMode = SchedulerMonthAppointmentDisplayMode.Indicator;

this.Content = Scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

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

<tr>
<td>{{'[AgendaViewStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AgendaViewStyle)' | markdownify }}</td>
<td>{{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[AgendaItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AgendaItemTemplate)' | markdownify }}</td>
<td>{{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[ShowAgendaView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_ShowAgendaView)' | markdownify }}</td>
<td>You can use {{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }} instead of agenda view in the month view of the scheduler.</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[SelectionTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_SelectionTextColor)' | markdownify }}</td>
<td>{{'[AppointmentTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AppointmentTextStyle)'| markdownify }}</td>
<td>Gets or sets the style of appointment text, that used to customize the text color, font, font size, font family and font attributes.</td></tr>

<tr>
<td>{{'[AppointmentIndicatorCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AppointmentIndicatorCount)' | markdownify }}</td>
<td>Nil</td>
<td>The appointment indicator will be rendered based on the cell size.</td></tr>

<tr>
<td>{{'[AgendaViewHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AgendaViewHeight)' | markdownify }}</td>
<td>{{'[AgendaView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AgendaView)'| markdownify }}</td>
<td>Gets or sets properties which allows to customize the agenda view of the SfScheduler.</td></tr>

<tr>
<td>{{'[AppointmentDisplayCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewSettings.html#Syncfusion_SfSchedule_XForms_MonthViewSettings_AppointmentDisplayCount)' | markdownify }}</td>
<td>Nil</td>
<td>The appointment will be rendered based on the cell size..</td></tr>

 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (MonthLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (MonthView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthLabelSettings.html#Syncfusion_SfSchedule_XForms_MonthLabelSettings_DateFormat)'| markdownify }}</td>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateFormat)'| markdownify }} (From ViewHeaderSettings of MonthView class) </td>
<td>Gets or sets a view header date format of the SfScheduler.</td></tr>

<tr>
<td>{{'[DayFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthLabelSettings.html#Syncfusion_SfSchedule_XForms_MonthLabelSettings_DayFormat)'| markdownify }}</td>
<td>{{'[DayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayFormat)'| markdownify }} (From ViewHeaderSettings of MonthView class) </td>
<td>Gets or sets a view header day format of the SfScheduler.</td></tr>
 </table> 
 
### DayView

The following code example explains how to configure the day view settings in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule" ScheduleView="DayView">
 <schedule:SfSchedule.DayViewSettings>
        <schedule:DayViewSettings 
            StartHour="9"
            EndHour="16"
			ShowCurrentTimeIndicator="false">
        </schedule:DayViewSettings>
    </schedule:SfSchedule.DayViewSettings>
</schedule>

{% endhighlight %}

{% highlight C# %}

SfSchedule schedule = new SfSchedule();
schedule.Scheduleview = ScheduleView.DayView;
schedule.ShowCurrentTimeIndicator = false;
DayViewSettings dayViewSettings = new DayViewSettings();
dayViewSettings.StartHour = 9;
dayViewSettings.EndHour = 16;
schedule.DayViewSettings = dayViewSettings;
this.Content = schedule;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                        View="Day">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView       
                       StartHour="9"
                       EndHour="16"
					   ShowCurrentTimeIndicator="False"/>
    </scheduler:SfScheduler.DaysView>					
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

SfScheduler Scheduler = new SfScheduler();
this.Scheduler.View = SchedulerView.Day;

this.Scheduler.DaysView.StartHour = 9;
this.Scheduler.DaysView.EndHour = 16;
this.Scheduler.DaysView.ShowCurrentTimeIndicator = false;

this.Content = Scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (DayViewSettings, WeekViewSettings, WorkWeekViewSettings)</th>
<th>.NET MAUI SfScheduler <br/> (DayView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeRulerSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_TimeRulerSize)'| markdownify }}</td>
<td>{{'[TimeRulerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html#Syncfusion_Maui_Scheduler_SchedulerDaysView_TimeRulerWidth)'| markdownify }} </td>
<td>Gets or sets the width for the time ruler view to layout within this in day, week, and work week views of the SfScheduler.</td></tr>

<tr>
<td>{{'[NonAccessibleBlocks](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_NonAccessibleBlocks)'| markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }}</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[StartHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_StartHour)'| markdownify }}</td>
<td>{{'[StartHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_StartHour)'| markdownify }} </td>
<td>Gets or sets the start hour for the time slot views in the SfScheduler.</td></tr>

<tr>
<td>{{'[EndHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_EndHour)'| markdownify }}</td>
<td>{{'[EndHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_EndHour)'| markdownify }} </td>
<td>Gets or sets the end hour for the time slot views in the SfScheduler.</td></tr>

<tr>
<td>{{'[WorkStartHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_WorkStartHour)'| markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the scheduler.</td></tr>

<tr>
<td>{{'[WorkEndHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_WorkEndHour)'| markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the scheduler.</td></tr>

<tr>
<td>{{'[TimeSlotBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_TimeSlotBorderColor)' | markdownify }}</td>
<td>{{'[CellBorderBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_CellBorderBrush)'| markdownify }}</td>
<td>Gets or sets the color that describes the cell border color value.</td></tr>

<tr>
<td>{{'[TimeSlotColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_TimeSlotColor)' | markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }}</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[NonWorkingHoursTimeSlotBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_NonWorkingHoursTimeSlotBorderColor)' | markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }}</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[NonWorkingHoursTimeSlotColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayViewSettings.html#Syncfusion_SfSchedule_XForms_DayViewSettings_NonWorkingHoursTimeSlotColor)' | markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }}</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[ShowAllDay](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_TimeZone)' | markdownify }}</td>
<td>Nil</td>
<td>The all day panel will be visible if the all-day appointments present in the scheduler.</td></tr>

 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (DayLabelSettings, WeekLabelSettings, WorkWeekLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (DayView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeLabelSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html#Syncfusion_SfSchedule_XForms_DayLabelSettings_TimeLabelSize)'| markdownify }}</td>
<td>{{'[TimeRulerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html#Syncfusion_Maui_Scheduler_SchedulerDaysView_TimeRulerWidth)'| markdownify }} (From TimeRulerTextStyle of DayView class)</td>
<td>Gets or sets the width for the time ruler view to layout within this in day, week, and work week views of the SfScheduler.</td></tr>

<tr>
<td>{{'[TimeLabelColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html#Syncfusion_SfSchedule_XForms_DayLabelSettings_TimeLabelColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TimeRulerTextStyle of DayView class) </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[TimeFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html#Syncfusion_SfSchedule_XForms_DayLabelSettings_TimeFormat)'| markdownify }}</td>
<td>{{'[TimeFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeFormat)'| markdownify }}</td>
<td>Gets or sets the time formats for the time text in the time slot views of the SfScheduler</td></tr>

<tr>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html#Syncfusion_SfSchedule_XForms_DayLabelSettings_DateFormat)'| markdownify }}</td>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateFormat)'| markdownify }} (From ViewHeaderSettings of DayView class)  </td>
<td>Gets or sets a view header date format of the SfScheduler.</td></tr>

<tr>
<td>{{'[DayFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.DayLabelSettings.html#Syncfusion_SfSchedule_XForms_DayLabelSettings_DayFormat)'| markdownify }}</td>
<td>{{'[DayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayFormat)'| markdownify }} (From ViewHeaderSettings of DayView class) </td>
<td>Gets or sets a view header day format of the SfScheduler.</td></tr>

 </table> 

### TimelineView

The following code example explains how to configure the timeline view settings in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule" ScheduleView="TimelineView">
   <schedule:SfSchedule.TimelineViewSettings>
        <schedule:TimelineViewSettings
            StartHour="09"
            EndHour="13">
        </schedule:TimelineViewSettings>
    </schedule:SfSchedule.TimelineViewSettings>
</schedule>

{% endhighlight %}

{% highlight C# %}

SfSchedule schedule = new SfSchedule();
schedule.SchedulerView = SchedulerView.TimelineView;
TimelineViewSettings timelineViewSettings = new TimelineViewSettings();
timelineViewSettings.StartHour = 09;
timelineViewSettings.EndHour = 13;
schedule.TimelineViewSettings = timelineViewSettings;
this.Content = schedule;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView       
                       StartHour="9"
                       EndHour="16"
					   ShowCurrentTimeIndicator="False"/>
    </scheduler:SfScheduler.TimelineView>					
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

SfScheduler Scheduler = new SfScheduler();
this.Scheduler.View = SchedulerView.TimelineWeek;

this.Scheduler.TimelineView.StartHour = 9;
this.Scheduler.TimelineView.EndHour = 16;
this.Scheduler.TimelineView.ShowCurrentTimeIndicator = false;

this.Content = Scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimelineViewSettings)</th>
<th>.NET MAUI SfScheduler <br/> (TimelineView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[LabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_LabelSettings)'| markdownify }}</td>
<td>{{'[TimeRulerTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRulerTextStyle)'| markdownify }} </td>
<td>Gets or sets the style of time ruler text, that used to customize the text color, font, font size, font family and font attributes.</td></tr>

<tr>
<td>{{'[NonWorkingsDays](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_NonWorkingsDays)'| markdownify }}</td>
<td>{{'[NonWorkingDays](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_NonWorkingDays)'| markdownify }} </td>
<td>Gets or sets the non working days for the workweek view and timeline workweek view in the SfScheduler.</td></tr>

<tr>
<td>{{'[TimeRulerSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_TimeRulerSize)'| markdownify }}</td>
<td>{{'[TimeRulerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeRulerHeight)'| markdownify }} </td>
<td>Gets or sets the height for the time ruler view to layout within this in timeline views of the SfScheduler.</td></tr>

<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_BorderColor)'| markdownify }}</td>
<td>{{'[CellBorderBrush]()'| markdownify }} (From Scheduler) </td>
<td>Specifies the displaying mode for appointment in month view.</td></tr>

<tr>
<td>{{'[StartHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_StartHour)'| markdownify }}</td>
<td>{{'[StartHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_StartHour)'| markdownify }} </td>
<td>Gets or sets the start hour for the time slot views in the SfScheduler..</td></tr>

<tr>
<td>{{'[EndHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_EndHour)'| markdownify }}</td>
<td>{{'[EndHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_EndHour)'| markdownify }} </td>
<td>Gets or sets the end hour for the time slot views in the SfScheduler.</td></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_Color)'| markdownify }}</td>
<td>{{'[TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions)'| markdownify }} (From DaysView  ,TimelineView)</td>
<td>Gets or sets to defines the collection of special time region in the time slot views of the scheduler.</td></tr>

<tr>
<td>{{'[AppointmentHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_AppointmentHeight)'| markdownify }}</td>
<td>{{'[MinimumAppointmentDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_MinimumAppointmentDuration)'| markdownify }}</td>
<td>Gets or sets the height for an appointment when it has minimum duration in time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineViewSettings.html#Syncfusion_SfSchedule_XForms_TimelineViewSettings_BorderWidth)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td></tr>

 </table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimeLabelSettings)</th>
<th>.NET MAUI SfScheduler <br/> (TimelineView)</th>
<th>Description</th></tr>

<tr>
<td>{{'[TimeFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html#Syncfusion_SfSchedule_XForms_TimelineLabelSettings_TimeFormat)'| markdownify }}</td>
<td>{{'[TimeFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeFormat)'| markdownify }} </td>
<td>Gets or sets the time formats for the time text in the time slot views of the SfScheduler.</td></tr>

<tr>
<td>{{'[TimeLabelSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html#Syncfusion_SfSchedule_XForms_TimelineLabelSettings_TimeLabelSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} (From TimeRulerTextStyle of TimelineView class) </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[TimeLabelColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html#Syncfusion_SfSchedule_XForms_TimelineLabelSettings_TimeLabelColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TimeRulerTextStyle of TimelineView class) </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimelineLabelSettings.html#Syncfusion_SfSchedule_XForms_TimelineLabelSettings_DateFormat)'| markdownify }}</td>
<td>{{'[DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateFormat)'| markdownify }} (From ViewHeaderSettings of TimelineView class)  </td>
<td>Gets or sets a view header date format of the SfScheduler.</td></tr>
 </table> 
 
### SchedulerTimeRegion

The following code example, explains how to configure the special time regions in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="schedule" ScheduleView="TimelineView">
    <schedule:SfSchedule.SpecialTimeRegions>
        <schedule:TimeRegionSettings 
            StartHour="12" 
            EndHour="13" 
            Text="Lunch"
            CanEdit="False"
            Color="#EAEAEA"
            TextColor="Black"/>
    </schedule:SfSchedule.SpecialTimeRegions>
</schedule>

{% endhighlight %}

{% highlight C# %}

SfSchedule schedule = new SfSchedule();
ObservableCollection<TimeRegionSettings> specialTimeRegions = new ObservableCollection<TimeRegionSettings>();
TimeRegionSettings timeRegionSettings = new TimeRegionSettings();
timeRegionSettings.StartHour = 12;
timeRegionSettings.EndHour = 13;
timeRegionSettings.Text = "Lunch";
timeRegionSettings.Color = Color.FromHex("#EAEAEA");
timeRegionSettings.TextColor = Color.Black;
timeRegionSettings.CanEdit = false;
specialTimeRegions.Add(timeRegionSettings);
schedule.SpecialTimeRegions = specialTimeRegions;
this.Content = schedule;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                        View="Week">				
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

SfScheduler Scheduler = new SfScheduler();
this.Scheduler.View = SchedulerView.Week;

this.Scheduler.DaysView.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        EnablePointerInteraction = false,
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

this.Content = Scheduler;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table> 

<table>
<tr>
<th>Xamarin SfSchedule <br/> (TimeRegionSettings)</th>
<th>.NET MAUI SfScheduler <br/> (SchedulerTimeRegion)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[StartHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_StartHour)'| markdownify }}</td>
<td>{{'[StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime)'| markdownify }} </td>
<td>Gets or sets the start time for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[EndHour](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_EndHour)'| markdownify }}</td>
<td>{{'[EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime)'| markdownify }} </td>
<td>Gets or sets the end time for an appointment or the scheduler time region in the SfScheduler.</td></tr>

<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_Color)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_Background)'| markdownify }} </td>
<td>Gets or sets the background color for an appointment or the scheduler time region in the SfScheduler..</td></tr>

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TextStyle) </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[Text](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_Text)'| markdownify }}</td>
<td>{{'[Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_Text)'| markdownify }} </td>
<td>Gets or sets the text for the scheduler time region.</td></tr>

<tr>
<td>{{'[CanEdit](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.TimeRegionSettings.html#Syncfusion_SfSchedule_XForms_TimeRegionSettings_CanEdit)'| markdownify }}</td>
<td>{{'[EnablePointerInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_EnablePointerInteraction)'| markdownify }} </td>
<td>Gets or sets a value indicating whether this SchedulerTimeRegion is enable pointer interaction..</td></tr>

</table> 

### HeaderView

The following code example explains how to customize the appearance of the header in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="Scheduler">
    <schedule:SfSchedule.HeaderStyle>
        <schedule:HeaderStyle 
                        Background="Orange"
                        TextColor="Blue"
                        FontSize="20">
        </schedule:HeaderStyle>
    </schedule:SfSchedule.HeaderStyle>
 </schedule:SfSchedule>

{% endhighlight %}

{% highlight C# %}

HeaderStyle headerStyle = new HeaderStyle();
headerStyle.BackgroundColor = Color.FromRgb(250, 219, 216);
headerStyle.FontSize = "20";
headerStyle.TextColor=Color.Blue;
schedule.HeaderStyle = headerStyle;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" View="Week">
    <scheduler:SfScheduler.HeaderView>
        <scheduler:SchedulerHeaderView 
                        Background="LightGreen">
        </scheduler:SchedulerHeaderView>
    </scheduler:SfScheduler.HeaderView>
 </scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};

this.Scheduler.HeaderView.TextStyle = textStyle;
this.Scheduler.HeaderView.Background = Brush.LightGreen;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (HeaderStyle)</th>
<th>.NET MAUI SfScheduler <br/> (HeaderView)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html#Syncfusion_SfSchedule_XForms_HeaderStyle_BackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Background)'| markdownify }} </td>
<td>Gets or sets the header background to customize the default background of the header in the scheduler.</td></tr>

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html#Syncfusion_SfSchedule_XForms_HeaderStyle_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html#Syncfusion_SfSchedule_XForms_HeaderStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} </td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html#Syncfusion_SfSchedule_XForms_HeaderStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.HeaderStyle.html#Syncfusion_SfSchedule_XForms_HeaderStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

</table> 

### ViewHeaderSettings

The following code example explains how to customize the appearance of the view header in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="Schedule">
    <schedule:SfSchedule.ViewHeaderStyle>
        <schedule:ViewHeaderStyle
             Background="LightGreen"
             DayTextColor="#FFFFFF"
             DateTextColor="#FFFFFF"
             DayFontFamily="Arial"
             DateFontFamily="Arial">
        </schedule:ViewHeaderStyle>
    </schedule:SfSchedule.ViewHeaderStyle>
</schedule:SfSchedule>

{% endhighlight %}

{% highlight C# %}

// Customize the schedule view header
ViewHeaderStyle viewHeaderStyle = new ViewHeaderStyle();
viewHeaderStyle.BackgroundColor = Color.FromHex("#009688");
viewHeaderStyle.DayTextColor = Color.FromHex("#FFFFFF");
viewHeaderStyle.DateTextColor = Color.FromHex("#FFFFFF");
viewHeaderStyle.DayFontFamily = "Arial";
viewHeaderStyle.DateFontFamily = "Arial";
schedule.ViewHeaderStyle = viewHeaderStyle;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView>
            <scheduler:SchedulerDaysView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Background="LightGreen" />
            </scheduler:SchedulerDaysView.ViewHeaderSettings>
        </scheduler:SchedulerDaysView>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}

{% highlight C# %}

var dateTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontFamily = "Arial",
};

this.Scheduler.DaysView.ViewHeaderSettings.DateTextStyle = dateTextStyle;

var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontFamily = "Arial",
};

this.Scheduler.DaysView.ViewHeaderSettings.DayTextStyle = dayTextStyle;
this.Scheduler.DaysView.ViewHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (ViewHeaderStyle)</th>
<th>.NET MAUI SfScheduler <br/> (ViewHeaderSettings)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[CurrentDayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_CurrentDayTextColor)'| markdownify }}, <br/> {{'[CurrentDateTextColor]()'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TodayTextStyle of Scheduler) </td>
<td>Gets or sets the current day text color for the scheduler.</td></tr>

<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_BackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Background)'| markdownify }} </td>
<td>Gets or sets the view header background to customize the default background of the header in the scheduler.</td></tr>

<tr>
<td>{{'[DayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DayTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From DayTextStyle) </td>
<td>Gets or sets the day text color for the scheduler.</td></tr>

<tr>
<td>{{'[DateTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DateTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From DateTextStyle)</td>
<td>Gets or sets the date text color for the scheduler.</td></tr>

<tr>
<td>{{'[DayFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DayFontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} (From DayTextStyle)</td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[DateFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DateFontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} (From DateTextStyle)</td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[DayFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DayFontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} (From DayTextStyle) </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[DateFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DayFontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} (From DateTextStyle) </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[DayFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DayFontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} (From DayTextStyle) </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

<tr>
<td>{{'[DateFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewHeaderStyle.html#Syncfusion_SfSchedule_XForms_ViewHeaderStyle_DateFontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} (From DateTextStyle) </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

</table> 


### AppointmentTextStyle

The following code example explains how to customize the appearance of the appointment in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="Schedule">
    <schedule:SfSchedule.AppointmentStyle>
        <schedule:AppointmentStyle
             TextColor="#FFFFFF"
             FontSize = "25"
             FontAttributes = "Bold"
             FontFamily = "Arial">
        </schedule:AppointmentStyle>
    </schedule:SfSchedule.AppointmentStyle>
</schedule:SfSchedule>

{% endhighlight %}

{% highlight C# %}

var appointments = new ObservableCollection<ScheduleAppointment>();
appointments.Add(new ScheduleAppointment()
{
    Subject = "Planning",
    StartTime = DateTime.Now.AddHours(1),
    EndTime = DateTime.Now.AddHours(2),
});
this.Scheduler.DataSource = appointments;

// Creating Appointment style
AppointmentStyle appointmentStyle = new AppointmentStyle();
appointmentStyle.TextColor = Color.Red;
appointmentStyle.FontSize = 25;
appointmentStyle.FontAttributes = FontAttributes.Bold;
appointmentStyle.FontFamily = "Arial";

// Setting Appointment Style
schedule.AppointmentStyle = appointmentStyle;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfScheduler
    x:Name="Scheduler">
    <schedule:SfScheduler.AppointmentTextStyle>
        <schedule:SchedulerTextStyle
            TextColor="Orange"
            FontFamily="Arial"
            FontSize="12"
            FontAttributes="Italic"/>
    </schedule:SfScheduler.AppointmentTextStyle>
</schedule:SfScheduler>

{% endhighlight %}

{% highlight C# %}

var appointments = new ObservableCollection<SchedulerAppointment>();
appointments.Add(new SchedulerAppointment()
{
    Subject = "meeting",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1),
});
this.Scheduler.AppointmentsSource = appointments;

var appointmentTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontFamily ="Arial",
    FontSize = 12,
    FontAttributes = FontAttributes.Bold
};

this.Scheduler.AppointmentTextStyle = appointmentTextStyle;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (AppointmentStyle)</th>
<th>.NET MAUI SfScheduler <br/> (AppointmentTextStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} </td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

<tr>
<td>{{'[BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[BorderCornerRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[SelectionBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[SelectedAppointmentBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectedAppointmentBackground)'| markdownify }}</td>
<td>Gets or sets the color that describes the selection background for the scheduler appointments.</td></tr>

<tr>
<td>{{'[SelectionTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.AppointmentStyle.html#Syncfusion_SfSchedule_XForms_AppointmentStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

</table> 

### CellStyle

The following code example explains how to customize the appearance of the month cell in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule.MonthCellStyle>
    <schedule:MonthViewCellStyle
                BackgroundColor="#8282ff"
                TextColor="Orange"
                FontSize="20"
                FontFamily = "Arial"
                FontAttributes = "None"
                NextMonthBackgroundColor="Gray"
                NextMonthTextColor="Gray"
                PreviousMonthBackgroundColor="White"
                PreviousMonthTextColor="Gray"
                TodayBackgroundColor="#f97272"
                TodayTextColor="White">
    </schedule:MonthViewCellStyle>
</schedule:SfSchedule.MonthCellStyle>

{% endhighlight %}

{% highlight C# %}

// MonthCell Appearance
MonthViewCellStyle monthCellStyle = new MonthViewCellStyle();
monthCellStyle.BackgroundColor = Color.FromHex("#8282ff");
monthCellStyle.NextMonthBackgroundColor = Color.White;
monthCellStyle.NextMonthTextColor = Color.Gray;
monthCellStyle.PreviousMonthBackgroundColor = Color.White;
monthCellStyle.PreviousMonthTextColor = Color.Gray;
monthCellStyle.TextColor = Color.Orange;
monthCellStyle.FontFamily = "Arial";
monthCellStyle.FontSize = 20;
monthCellStyle.FontAttributes = FontAttributes.None;
monthCellStyle.TodayBackgroundColor = Color.FromHex("#f97272");
monthCellStyle.TodayTextColor = Color.White;
schedule.MonthCellStyle = monthCellStyle;
{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfScheduler
    x:Name="Scheduler"
    View="Month">
    <schedule:SfScheduler.MonthView>
        <schedule:SchedulerMonthView>
                <schedule:SchedulerMonthView.CellStyle>
                    <schedule:SchedulerMonthCellStyle TodayBackground="LightBlue"
                                                      Background="Orange"
                                                      LeadingMonthBackground="Brown"
                                                      TrailingMonthBackground="Yellow"/>
                </schedule:SchedulerMonthView.CellStyle>
        </schedule:SchedulerMonthView>
    </schedule:SfScheduler.MonthView>
</schedule:SfScheduler>

{% endhighlight %}

{% highlight C# %}

    var textStyle = new SchedulerTextStyle()
    {
        TextColor = Colors.DarkBlue,
        FontSize = 14,
    };

    var leadingMonthTextStyle = new SchedulerTextStyle()
    {
        TextColor = Colors.Red,
        FontSize = 14,
    };

    var trailingMonthTextStyle = new SchedulerTextStyle()
    {
        TextColor = Colors.Red,
        FontSize = 14,
    };

    var monthCellStyle = new SchedulerMonthCellStyle()
    {
        Background = Brush.LightSkyBlue,
        TodayBackground = Brush.LightBlue,
        LeadingMonthBackground = Brush.LightGreen,
        TrailingMonthBackground = Brush.LightYellow,
        TextStyle = textStyle,
        LeadingMonthTextStyle = leadingMonthTextStyle,
        TrailingMonthTextStyle = trailingMonthTextStyle
    };

    this.Scheduler.MonthView.CellStyle = monthCellStyle;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (MonthCellStyle, MonthViewCellStyle)</th>
<th>.NET MAUI SfScheduler <br/> (CellStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} </td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html#Syncfusion_Maui_Scheduler_SchedulerMonthCellStyle_Background)'| markdownify }} </td>
<td>Gets or sets the background color for the month cell of month view, that used to customize the background color.</td></tr>

<tr>
<td>{{'[TodayBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_TodayBackgroundColor)'| markdownify }}</td>
<td>{{'[TodayBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html#Syncfusion_Maui_Scheduler_SchedulerMonthCellStyle_TodayBackground)'| markdownify }} </td>
<td>Gets or sets the background color for the today month cell of month view, that used to customize the background color.</td></tr>

<tr>
<td>{{'[TodayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_TodayTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TodayTextStyle of Scheduler) </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[PreviousMonthTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_PreviousMonthTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From LeadingMonthTextStyle) </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[PreviousMonthBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_PreviousMonthBackgroundColor)'| markdownify }}</td>
<td>{{'[LeadingMonthBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html#Syncfusion_Maui_Scheduler_SchedulerMonthCellStyle_LeadingMonthBackground)'| markdownify }} </td>
<td>Gets or sets the background color for the leading month cell of month view, that used to customize the background color.</td></tr>

<tr>
<td>{{'[NextMonthBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_NextMonthBackgroundColor)'| markdownify }}</td>
<td>{{'[TrailingMonthBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthCellStyle.html#Syncfusion_Maui_Scheduler_SchedulerMonthCellStyle_TrailingMonthBackground)'| markdownify }} </td>
<td>Gets or sets the background color for the trailing month cell of month view, that used to customize the background color.</td></tr>

<tr>
<td>{{'[NextMonthTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.MonthViewCellStyle.html#Syncfusion_SfSchedule_XForms_MonthViewCellStyle_NextMonthTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} (From TrailingMonthTextStyle)</td>
<td>Gets or sets the text color for the scheduler.</td></tr>

</table> 

### WeekNumberStyle

The following code example explains how to customize the appearance of the cell in Xamarin SfSchedule and .NET MAUI SfScheduler.

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfSchedule x:Name="Schedule">
<schedule:SfSchedule.MonthViewSettings>
    <schedule:MonthViewSettings>
        <schedule:MonthViewSettings.WeekNumberStyle>
            <schedule:WeekNumberStyle FontSize="10"
                                        FontFamily="Arial"
                                        FontAttributes="Bold"
                                        TextColor="AliceBlue"
                                        BackgroundColor="Red"/>
        </schedule:MonthViewSettings.WeekNumberStyle>
    </schedule:MonthViewSettings>
</schedule:SfSchedule.MonthViewSettings>
</schedule:SfSchedule>

{% endhighlight %}

{% highlight C# %}

// creating new instance for WeekNumberStyle
WeekNumberStyle weekNumberStyle = new WeekNumberStyle();
weekNumberStyle.FontFamily = "Arial";
weekNumberStyle.FontSize = 15;
weekNumberStyle.FontAttributes = FontAttributes.None;
weekNumberStyle.BackgroundColor = Color.Blue;
weekNumberStyle.TextColor = Color.White;
monthViewSettings.WeekNumberStyle = weekNumberStyle;

{% endhighlight %}

{% endtabs %}
</td>
<td>
{% tabs %}

{% highlight xaml %}

<schedule:SfScheduler
    x:Name="Scheduler"
    ShowWeekNumber="True"
    View="Month">
        <schedule:SfScheduler.WeekNumberStyle>
            <schedule:SchedulerWeekNumberStyle Background="Red"/>
        </schedule:SfScheduler.WeekNumberStyle>
</schedule:SfScheduler>

{% endhighlight %}

{% highlight C# %}

this.Scheduler.ShowWeekNumber = true;
var schedulerTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 14,
    FontFamily = "Arial",
    FontAttributes = FontAttributes.Bold
};

var schedulerWeekNumberStyle = new SchedulerWeekNumberStyle()
{
    Background = Brush.LightGreen,
    TextStyle = schedulerTextStyle
};

this.Scheduler.WeekNumberStyle = schedulerWeekNumberStyle;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfSchedule <br/> (WeekNumberStyle)</th>
<th>.NET MAUI SfScheduler <br/> (WeekNumberStyle)</th>
<th>Description</th></tr> 

<tr>
<td>{{'[TextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekNumberStyle.html#Syncfusion_SfSchedule_XForms_WeekNumberStyle_TextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_TextColor)'| markdownify }} </td>
<td>Gets or sets the text color for the scheduler.</td></tr>

<tr>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekNumberStyle.html#Syncfusion_SfSchedule_XForms_WeekNumberStyle_FontFamily)'| markdownify }}</td>
<td>{{'[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontFamily)'| markdownify }} </td>
<td>Gets or sets the string, that represents font family of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekNumberStyle.html#Syncfusion_SfSchedule_XForms_WeekNumberStyle_FontSize)'| markdownify }}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontSize)'| markdownify }} </td>
<td>Gets or sets the double value that represents size of the SfScheduler.</td></tr>

<tr>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.WeekNumberStyle.html#Syncfusion_SfSchedule_XForms_WeekNumberStyle_FontAttributes)'| markdownify }}</td>
<td>{{'[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html#Syncfusion_Maui_Scheduler_SchedulerTextStyle_FontAttributes)'| markdownify }} </td>
<td>Gets or sets the FontAttributes of the SfScheduler.</td></tr>

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

<tr>
<td>{{'[ViewLayoutOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.ViewLayoutOptions.html)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SelectionMode.html)'| markdownify }}</td>
<td>Nil.</td>
<td>Not Supported.</td></tr>

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

<tr>
<td>{{'[MonthInlineAppointmentTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthInlineAppointmentTapped)'| markdownify }}</td>
<td>{{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify }}</td>
<td>Occurs when header item is tapped.</td></tr>

<tr>
<td>{{'[OnAppointmentLoadedEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthInlineAppointmentTapped)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From DaysView, TimelineView, and MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[OnMonthInlineAppointmentLoadedEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthInlineAppointmentTapped)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[OnMonthInlineLoadedEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthInlineAppointmentTapped)'| markdownify }}</td>
<td>{{'[AppointmentTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html?tabs=tabid-9%2Ctabid-3%2Ctabid-5%2Ctabid-7%2Ctabid-1#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_AppointmentTemplate)'| markdownify }} (From MonthView)</td>
<td>Gets or sets the appointment template to customize the default UI.</td></tr>

<tr>
<td>{{'[OnMonthCellLoadedEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_MonthInlineAppointmentTapped)'| markdownify }}</td>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthView.html#Syncfusion_Maui_Scheduler_SchedulerMonthView_CellTemplate)'| markdownify }}</td>
<td>Gets or sets the month cell template or template selector.</td></tr>

</table> 

## Methods

<table>
<tr>
<th>Xamarin SfSchedule</th>
<th>.NET MAUI SfScheduler</th>
<th>Description</th></tr>

<tr>
<td>{{'[Backward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_Backward)'| markdownify}}</td>
<td>{{'[Backward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Backward)'| markdownify }}</td>
<td>Move to previous view which displays previous view dates.</td></tr>

<tr>
<td>{{'[Forward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_Forward)'| markdownify}}</td>
<td>{{'[Forward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Forward)'| markdownify }}</td>
<td>Move to next view which displays next view dates.</td></tr>

<tr>
<td>{{'[NavigateTo](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfSchedule.XForms.SfSchedule.html#Syncfusion_SfSchedule_XForms_SfSchedule_NavigateTo_System_DateTime_)'| markdownify}}</td>
<td>{{'[DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_DisplayDate)'| markdownify }}</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfScheduler.</td></tr>

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

## Upcoming Features

* Resource view support.
* Days count support in timeslot views.
* Month view navigation direction support.
* Command support for Tapped, DoubleTapped, LongPressed and ViewChanged events.
* Support to change text color for each scheduler appointment.
* Suspend and resume for appointment update.
* Appointment Drag and Drop.

## Limitations for .NET MAUI.

* Android 5.0 (API 21) or higher.
* iOS 10 or higher.
* macOS 10.13 or higher, using Mac Catalyst.
* Windows 11 and Windows 10 version 1809 or higher, using [Windows UI Library (WinUI) 3](https://docs.microsoft.com/en-us/windows/apps/winui/winui3/).

## Known issues in .NET MAUI Scheduler 

* [Windows] Scheduler view swiping using the touch screen is not working.
* [Android] - Scheduler view swiping using the touch screen is not working in all timeline views.
* The touch and mouse swipe are not working inside the shell page.
* `FlowDirection` property runtime change will not work.
