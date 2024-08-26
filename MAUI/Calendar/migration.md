---
layout: post
title: Migrate from Syncfusion Xamarin SfCalendar to .NET MAUI SfCalendar
description: Learn here all about Migrating from Syncfusion Xamarin calendar to Syncfusion .NET MAUI Calendar control.
platform: maui
control: SfCalendar
documentation: ug
---  

# Migrate from Xamarin.Forms SfCalendar to .NET MAUI SfCalendar 

To make the migration from the [Xamarin SfCalendar](https://www.syncfusion.com/xamarin-ui-controls/xamarin-calendar) to [.NET MAUI SfCalendar](https://www.syncfusion.com/maui-controls/maui-calendar) easier, most of the APIs from the Xamarin SfCalendar were kept in the.NET MAUI SfCalendar. However, to maintain the consistency of API naming in the .NET MAUI SfCalendar, some of the APIs have been renamed. Please find the difference in the following topics.

## Namespaces 

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>Syncfusion.SfCalendar.XForms</td>
<td>Syncfusion.Maui.Calendar</td></tr>
</table>

N> The selection-based `.NET MAUI SfCalendar` does not manage appointments like the `Xamarin SfCalendar` does. If you require appointment/events management use `.NET MAUI SfScheduler`.

## Initialize control

To initialize the control, import the calendar namespace and initialize `SfCalendar` as shown in the following code sample.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

    <calendar:SfCalendar/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar />

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th></tr>
<tr>
<td>{{'[SelectionRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SelectionRange.html)'| markdownify }}</td>
<td>{{'[CalendarDateRange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarDateRange.html)'| markdownify }}</td>
<td>Represents a class which holds the start and end date of the range in SfCalendar.</td>
</tr> 
<tr>
<td>{{'[MonthViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html)' | markdownify }}</td>
<td>{{'[CalendarMonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html)' | markdownify }}</td>
<td>Represents a class which is used to configure all the properties and styles of calendar month view.</td>
</tr> 
<tr>
<td>{{'[YearViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html)' | markdownify }}</td>
<td>{{'[CalendarYearView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html)' | markdownify }}</td>
<td>Represents a class which is used to used to configure all the properties and styles of calendar year, decade and century view.</td>
</tr>
<tr>
<td>{{'[CalendarTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.CalendarTappedEventArgs.html)' | markdownify }}</td>
<td>{{'[CalendarTappedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTappedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the tap interaction event details and it occurs when the user clicks or touch on the calendar elements.</td>
</tr> 
<tr>
<td>{{'[DayCellHoldingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.DayCellHoldingEventArgs.html)' | markdownify }}</td>
<td>{{'[CalendarLongPressedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarLongPressedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the long press interaction event details and it occurs when the user long press inside the calendar elements.</td>
</tr> 
<tr>
<td>{{'[MonthChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[CalendarViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the view changed event details.</td>
</tr> 
<tr>
<td>{{'[SelectionChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SelectionChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[CalendarSelectionChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionChangedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the selection changed event details.</td>
</tr> 
<tr>
<td>{{'[ViewModeChangedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.ViewModeChangedEventArgs.html)' | markdownify }}</td>
<td>{{'[CalendarViewChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarViewChangedEventArgs.html)' | markdownify }}</td>
<td>Represents a class which is used to hold the view changed event details.</td>
</tr> 
<tr>
<td>{{'[MonthLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthLabelSettings.html)' | markdownify }}</td>
<td>Nil</td>
<td>Use properties from {{'[MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#properties)' | markdownify }}.</td>
</tr> 
<tr>
<td>{{'[CalendarInlineEvent](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.CalendarInlineEvent.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MonthEventParameters](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthEventParameters.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr> 
<tr>
<td>{{'[InlineEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.InlineEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr> 
<tr>
<td>{{'[InlineItemTappedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.InlineItemTappedEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr> 
<tr>
<td>{{'[InlineToggledEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.InlineToggledEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr> 
<tr>
<td>{{'[MonthCell](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthCell.html)' | markdownify }}</td>
<td>Nil</td>
<td>Use properties from {{'[MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#properties)' | markdownify }}</td>
</tr> 
<tr>
<td>{{'[MonthCellLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthCellLoadedEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[ViewChanged](https://help.syncfusion.com/maui/calendar/events#viewchanged)' | markdownify}} event args.</td>
</tr> 
<tr>
<td>{{'[MonthChangingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthChangingEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr> 
<tr>
<td>{{'[YearCell](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearCell.html)' | markdownify }}</td>
<td>Nil</td>
<td>Use properties from {{'[YearView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html)' | markdownify }}</td>
</tr>
<tr>
<td>{{'[YearCellLoadedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearCellLoadedEventArgs.html)' | markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[ViewChanged](https://help.syncfusion.com/maui/calendar/events#viewchanged)' | markdownify }} event args.</td>
</tr>
</table>

## Properties 

### SfCalendar

The following code example, explains how to initialize the properties of the `Xamarin SfCalendar` and `.NET MAUI SfCalendar` class.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

    <calendar:SfCalendar ViewMode="MonthView"/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.ViewMode = CalendarView.MonthView;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar View="Month"/>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
calendar.View = CalendarView.Month;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[AgendaViewHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_AgendaViewHeight)'| markdownify }}</td>
<td>Nil</td>
<td>For agenda view related support use the .NET MAUI Scheduler control.</td>
</tr>
<tr>
<td>{{'[BlackoutDates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_BlackoutDates)'| markdownify }}</td>
<td>{{'[SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate)'| markdownify }}</td>
<td>Gets or sets the function to decide whether the cell is selectable or not in the calendar.</td>
</tr>
<tr>
<td>{{'[BlackoutDatesViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_BlackoutDatesViewMode)'| markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate)' | markdownify }} for this requirement.</td>
</tr>
<tr>
<td>{{'[CustomDayLabels](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_CustomDayLabels)'| markdownify }}</td>
<td>Nil</td>
<td>By using custom header (hides default view header using {{'[Height](https://help.syncfusion.com/maui/calendar/headers#customize-view-header-height)' | markdownify }} value as 0), you can customize.</td>
</tr>
<tr>
<td>{{'[DataSource](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_DataSource)'| markdownify }}</td>
<td>Nil</td>
<td>For {{'[Datasource](https://help.syncfusion.com/maui/scheduler/appointments)' | markdownify }} related support suggesting to use .NET MAUI Scheduler</td>
</tr>
<tr>
<td>{{'[DisplayDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_DisplayDate)'| markdownify }}</td>
<td>{{'[DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DisplayDate)'| markdownify }}</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfCalendar.</td>
</tr>
<tr>
<td>{{'[EnableDatesInPast](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_EnableDatesInPast)'| markdownify }}</td>
<td>{{'[EnablePastDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnablePastDates)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the dates enabled or disabled before today date.</td>
</tr>
<tr>
<td>{{'[EnableSwiping](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_EnableSwiping)'| markdownify }}</td>
<td>{{'[EnableSwipeSelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnableSwipeSelection)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the swiping selection enabled for select the date range.</td>
</tr>
<tr>
<td>{{'[FirstDayofWeek](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_FirstDayofWeek)'| markdownify }}</td>
<td>{{'[[FirstDayOfWeek](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_FirstDayOfWeek)(From [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the day of week that used to change the default first day of week in SfCalendar.</td>
</tr>
<tr>
<td>{{'[HeaderHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_HeaderHeight)'| markdownify }}</td>
<td>{{'[[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_Height)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets the value to specify the height of header view on SfCalendar.</td>
</tr>
<tr>
<td>{{'[HeaderView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_HeaderView)'| markdownify }}</td>
<td>{{'[CalendarHeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html)'| markdownify }}</td>
<td>Represents a class which is used to customize all the properties of header view of the SfCalendar.</td>
</tr>
<tr>
<td>{{'[HoldCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_HoldCommand)'| markdownify }}</td>
<td>{{'[LongPressedCommand]()'| markdownify }}</td>
<td>Gets or sets a command to hold a date of SfCalendar.</td>
</tr>
<tr>
<td>{{'[InlineViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_InlineViewMode)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[Locale](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_Locale)'| markdownify }}</td>
<td>Nil</td>
<td>Refer to this {{'[link](https://help.syncfusion.com/maui/calendar/localization)' | }} for using localization in .NET MAUI Calendar</td>
</tr>
<tr>
<td>{{'[MaxDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MaxDate)'| markdownify }}</td>
<td>{{'[MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MaximumDate)'| markdownify }}</td>
<td>Gets or sets the maximum display date to restrict the visible dates in the SfCalendar.</td>
</tr>
<tr>
<td>{{'[MaximumEventIndicatorCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MaximumEventIndicatorCount)'| markdownify }}</td>
<td>Nil</td>
<td>For {{'[Datasource](https://help.syncfusion.com/maui/scheduler/appointments)' | markdownify }} related support suggesting to use .NET MAUI Scheduler</td>
</tr>
<tr>
<td>{{'[MinDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MinDate)'| markdownify }}</td>
<td>{{'[MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MinimumDate)'| markdownify }}</td>
<td>Gets or sets the minimum display date to restrict the visible dates in the SfCalendar.</td>
</tr>
<tr>
<td>{{'[MonthChangedCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MonthChangedCommand)'| markdownify }}</td>
<td>{{'[ViewChangedCommand]()'| markdownify }}</td>
<td>Gets or sets a command to change the view of SfCalendar.</td>
</tr>
<tr>
<td>{{'[MonthViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MonthViewSettings)'| markdownify }}</td>
<td>{{'[MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MonthView)'| markdownify }}</td>
<td>Gets or sets the properties which allows to customize the calendar month view.</td>
</tr>
<tr>
<td>{{'[MoveToDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MoveToDate)'| markdownify }}</td>
<td>{{'[DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DisplayDate)'| markdownify }}</td>
<td>Gets or sets the display date to programmatically navigate the dates in the SfCalendar.</td>
</tr>
<tr>
<td>{{'[NavigateToMonthOnInActiveDatesSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigateToMonthOnInActiveDatesSelection)'| markdownify }}</td>
<td>Nil</td>
<td>It can be achieved by setting the {{'[DisplayDate](https://help.syncfusion.com/maui/calendar/date-navigation#programmatic-date-navigation)' | markdownify }} property inside the {{'[Tapped](https://help.syncfusion.com/maui/calendar/events#tapped)' | markdownify }} event.</td>
</tr>
<tr>
<td>{{'[NavigationArrowThickness](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigationArrowThickness)'| markdownify }}</td>
<td>Nil</td>
<td>By using custom header ({{'[Height](https://help.syncfusion.com/maui/calendar/headers#customize-the-header-height)' | markdownify }} value as 0), customize the navigation arrows.</td>
</tr>
<tr>
<td>{{'[NavigationButtonHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigationButtonHeight)'| markdownify }}</td>
<td>Nil</td>
<td>By using custom header, customize the navigation arrows.</td>
</tr>
<tr>
<td>{{'[NavigationButtonWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigationButtonWidth)'| markdownify }}</td>
<td>Nil</td>
<td>By using custom header, customize the navigation arrows.</td>
</tr>
<tr>
<td>{{'[NavigationDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigationDirection)'| markdownify }}</td>
<td>{{'[NavigationDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_NavigationDirection)'| markdownify }}</td>
<td>Gets or sets a value which determines the direction of the calendar scrolls.</td>
</tr>
<tr>
<td>{{'[NullableSelectedDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NullableSelectedDate)'| markdownify }}</td>
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDate)'| markdownify }}</td>
<td>Gets or sets the selected date to select the particular date of the calendar.</td>
</tr>
<tr>
<td>{{'[NumberOfWeeksInView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NumberOfWeeksInView)'| markdownify }}</td>
<td>{{'[[NumberOfVisibleWeeks](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_NumberOfVisibleWeeks)(From [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets a value to display the number of weeks in calendar month view.</td>
</tr>
<tr>
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectedDate)'| markdownify }}</td>
<td>{{'[SelectedDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDate)'| markdownify }}</td>
<td>Gets or sets the selected date to select the particular date of the calendar.</td>
</tr>
<tr>
<td>{{'[SelectedDates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectedDates)'| markdownify }}</td>
<td>{{'[SelectedDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDates)'| markdownify }}</td>
<td>Gets or sets the selected dates to select the multiple dates of the calendar.</td>
</tr>
<tr>
<td>{{'[SelectedRange](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectedRange)'| markdownify }}</td>
<td>{{'[SelectedDateRange](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectedDateRange)'| markdownify }}</td>
<td>Gets or sets the selected date range to select the range of dates of the calendar.</td>
</tr>
<tr>
<td>{{'[SelectionChangedCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectionChangedCommand)'| markdownify }}</td>
<td>{{'[SelectionChangedCommand]()'| markdownify }}</td>
<td>Gets or sets a command to select a date of SfCalendar.</td>
</tr>
<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectionMode)'| markdownify }}</td>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionMode)'| markdownify }}</td>
<td>Gets or sets the selection mode of the calendar.</td>
</tr>
<tr>
<td>{{'[ShowHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ShowHeader)'| markdownify }}</td>
<td>Nil</td>
<td>By using {{'[Height](https://help.syncfusion.com/maui/calendar/headers#customize-the-header-height)' | markdownify }} value as 0 in the HeaderView, you can hide and show the headers.</td>
</tr>
<tr>
<td>{{'[ShowInlineEvents](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ShowInlineEvents)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ShowLeadingAndTrailingDays](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ShowLeadingAndTrailingDays)'| markdownify }}</td>
<td>{{'[ShowTrailingAndLeadingDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ShowTrailingAndLeadingDates)'| markdownify }}</td>
<td>Gets or sets a value indicating whether to displays the leading and trailing dates in the month, decade, century views of the SfCalendar.</td>
</tr>
<tr>
<td>{{'[ShowNavigationButtons](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ShowNavigationButtons)'| markdownify }}</td>
<td>{{'[[ShowNavigationArrows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_ShowNavigationArrows)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html))]'| markdownify }}</td>
<td>Gets or sets a value indicating whether to displays the navigation arrows on the header view of the SfCalendar.</td>
</tr>
<tr>
<td>{{'[ShowYearView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ShowYearView)'| markdownify }}</td>
<td>{{'[AllowViewNavigation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_AllowViewNavigation)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the navigation enabled on year, decade and century cell interaction.</td>
</tr>
<tr>
<td>{{'[TapCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_TapCommand)'| markdownify }}</td>
<td>{{'[TappedCommand]()'| markdownify }}</td>
<td>Gets or sets a command to tap a date of SfCalendar.</td>
</tr>
<tr>
<td>{{'[ToggleDaySelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ToggleDaySelection)'| markdownify }}</td>
<td>{{'[CanToggleDaySelection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_CanToggleDaySelection)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the selected date is deselect through interaction on single selection mode of SfCalendar.</td>
</tr>
<tr>
<td>{{'[TransitionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_TransitionMode)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ViewMode)'| markdownify }}</td>
<td>{{'[View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_View)'| markdownify }}</td>
<td>Gets or sets the built-in views such as month, year, decade and century of the SfCalendar.</td>
</tr>
<tr>
<td>{{'[VisibleDates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_VisibleDates)'| markdownify }}</td>
<td>Nil</td>
<td>Use visible dates from the {{'[ViewChanged](https://help.syncfusion.com/maui/calendar/events#viewchanged)' | markdownify }} event.</td>
</tr>
<tr>
<td>{{'[YearViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_YearViewMode)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[YearViewSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_YearViewSettings)'| markdownify }}</td>
<td>{{'[YearView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_YearView)'| markdownify }}</td>
<td>Gets or sets the properties which allows to customize the calendar year, decade and century views.</td>
</tr>
</table>

### MonthViewSettings

The following code example explains how to configure the month view settings in `Xamarin SfCalendar` and `.NET MAUI SfCalendar`.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">
        <calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.MonthViewSettings>
                <calendar:MonthViewSettings SelectionShape = SelectionShape.Circle/>
            </calendar:SfCalendar.MonthViewSettings>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.MonthViewSettings.SelectionShape = SelectionShape.Circle;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
        <calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.MonthView>
                <calendar:CalendarMonthView NumberOfVisibleWeeks="6"/>
            </calendar:SfCalendar.MonthView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
calendar.MonthView.NumberOfVisibleWeeks = 6;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[AgendaSelectedDateColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_AgendaSelectedDateColor)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[BlackoutColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_BlackoutColor)'| markdownify }}</td>
<td>{{'[DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle)'| markdownify }}</td>
<td>Gets or sets the text style of the disabled month cells text, that used to customize the text color, font, font size, font family and font attributes.</td>
</tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_BorderColor)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can customize the month cells.</td>
</tr>
<tr>
<td>{{'[CellGridOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_CellGridOptions)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can customize the month cells.</td>
</tr>
<tr>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_CellTemplate)'| markdownify }}</td>
<td>{{'[CellTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html?tabs=tabid-2#Syncfusion_Maui_Calendar_CalendarMonthView_CellTemplate)'| markdownify }}</td>
<td>Gets or sets the month cell template or template selector.</td>
</tr>
<tr>
<td>{{'[CurrentMonthBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_CurrentMonthBackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_Background)'| markdownify }}</td>
<td>Gets or sets the background for the month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[CurrentMonthTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_CurrentMonthTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[DateSelectionColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DateSelectionColor)'| markdownify }}</td>
<td>{{'[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionBackground)'| markdownify }}</td>
<td>Gets or sets the value that describes the highlight of selection based on selection mode of the calendar.</td>
</tr>
<tr>
<td>{{'[DateTextAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DateTextAlignment)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can align the month cells text.</td>
</tr>
<tr>
<td>{{'[DayCellFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayCellFont)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[DayCellFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayCellFontFamily)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TextStyle), [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayTextStyle), [TrailingLeadingDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesTextStyle), [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle), [WeekendDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_WeekendDatesTextStyle), [SpecialDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SpecialDatesTextStyle) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[DayFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayFontSize)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TextStyle), [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayTextStyle), [TrailingLeadingDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesTextStyle), [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle), [WeekendDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_WeekendDatesTextStyle), [SpecialDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SpecialDatesTextStyle) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[DayFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayFontAttributes)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TextStyle), [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayTextStyle), [TrailingLeadingDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesTextStyle), [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle), [WeekendDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_WeekendDatesTextStyle), [SpecialDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SpecialDatesTextStyle) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_Background)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_HeaderView) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the background of the view header view in SfCalendar.</td>
</tr>
<tr>
<td>{{'[DayHeaderFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderFont)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[DayHeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderFont)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_HeaderView) in [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderFontFamily)'| markdownify }}</td>
<td>{{'[FontFamily(From TextStyle of HeaderView in MonthView)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextStyle)'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderFontSize)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_HeaderView) in [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_HeaderView) in [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeaderFormat](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeaderFormat)'| markdownify }}</td>
<td>{{'[[TextFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_TextFormat)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
<tr>
<td>{{'[DayHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayHeight)'| markdownify }}</td>
<td>{{'[[Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html#Syncfusion_Maui_Calendar_CalendarMonthHeaderView_Height)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthHeaderView.html) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the value to specify the height of view header view on SfCalendar.</td>
</tr>
<tr>
<td>{{'[DayLabelTextAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DayLabelTextAlignment)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can customize the month cells.</td>
</tr>
<tr>
<td>{{'[DisabledBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DisabledBackgroundColor)'| markdownify }}</td>
<td>{{'[DisabledDatesBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesBackground)'| markdownify }}</td>
<td>Gets or sets the background for the disabled month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[DisabledTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_DisabledTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle) of [MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_Background)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) of [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>
<tr>
<td>{{'[HeaderFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderFont)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttributes](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderFontAttributes)'| markdownify }}</td>
<td>{{'[[FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontAttributes)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) in [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the font attributes of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderFontFamily)'| markdownify }}</td>
<td>{{'[[FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontFamily)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) in [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the font family of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderFontSize)'| markdownify }}</td>
<td>{{'[[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_FontSize)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) in [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the font size of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_HeaderTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle) of [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) in [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[InlineBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_InlineBackgroundColor)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[InlineItemTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_InlineItemTemplate)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[InlineTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_InlineTextColor)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MonthLabelSettings](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_MonthLabelSettings)'| markdownify }}</td>
<td>Nil</td>
<td>Use properties from {{'[MonthView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#properties)' | markdownify }}.</td>
</tr>
<tr>
<td>{{'[PreviousMonthBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_PreviousMonthBackgroundColor)'| markdownify }}</td>
<td>{{'[YearTrailingLeadingDatesBackgroundView]()'| markdownify }}</td>
<td>Gets or sets the background for the trailing and leading month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[PreviousMonthTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_PreviousMonthTextColor)'| markdownify }}</td>
<td>{{'[TextColor(From TrailingLeadingDatesTextStyle)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesTextStyle)'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[SelectedDayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_SelectedDayTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [SelectionTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SelectionTextStyle) and [RangeTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_RangeTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[SelectionRadius](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_SelectionRadius)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[SelectionShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_SelectionShape)'| markdownify }}</td>
<td>{{'[[SelectionShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionShape)(From [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the selection shape of the SfCalendar.</td>
</tr>
<tr>
<td>{{'[TodayBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_TodayBorderColor)'| markdownify }}</td>
<td>{{'[[TodayHighlightBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_TodayHighlightBrush)(From [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the value that describes the today highlight color value.</td>
</tr>
<tr>
<td>{{'[TodaySelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_TodaySelectionBackgroundColor)'| markdownify }}</td>
<td>{{'[[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionBackground)(From [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the value that describes the highlight of selection based on selection mode of the calendar.</td>
</tr>
<tr>
<td>{{'[TodaySelectionTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_TodaySelectionTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [SelectionTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SelectionTextStyle) and [RangeTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_RangeTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[TodayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_TodayTextColor)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[WeekDayBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_WeekDayBackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_Background), [TodayBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayBackground), [TrailingLeadingDatesBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesBackground), [DisabledDatesBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesBackground), [SpecialDatesBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SpecialDatesBackground)'| markdownify }}</td>
<td>Gets or sets the background for the week day month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[WeekDayTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_WeekDayTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TextStyle), [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TodayTextStyle), [TrailingLeadingDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_TrailingLeadingDatesTextStyle), [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_DisabledDatesTextStyle), [SpecialDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_SpecialDatesTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[WeekEndBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_WeekEndBackgroundColor)'| markdownify }}</td>
<td>{{'[WeekendDatesBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_WeekendDatesBackground)'| markdownify }}</td>
<td>Gets or sets the background for the weekend month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[WeekEndTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.MonthViewSettings.html#Syncfusion_SfCalendar_XForms_MonthViewSettings_WeekEndTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [WeekendDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_WeekendDatesTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
</table>

### YearViewSettings

The following code example explains how to configure the year view settings in `Xamarin SfCalendar` and `.NET MAUI SfCalendar`.

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th></tr>
<tr>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.SfCalendar.XForms;assembly=Syncfusion.SfCalendar.XForms">

<calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.YearViewSettings>
                <calendar:YearViewSettings HeaderBackground = "Red"/>
            </calendar:SfCalendar.YearViewSettings>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.SfCalendar.XForms;
...

SfCalendar calendar = new SfCalendar ();
calendar.YearViewSettings.HeaderBackground = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}

</td>
<td>
{% tabs %}

{% highlight xaml %}

<ContentPage
xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">
         <calendar:SfCalendar x:Name="calendar">
            <calendar:SfCalendar.YearView>
                <calendar:CalendarYearView Background="Red"/>
            </calendar:SfCalendar.YearView>
        </calendar:SfCalendar>

</ContentPage>

{% endhighlight %}

{% highlight C# %}

using Syncfusion.Maui.Calendar;
...

SfCalendar calendar = new SfCalendar();
calendar.YearView.Background = Colors.Red;
this.Content = calendar;

{% endhighlight %}

{% endtabs %}
</td></tr>
</table>

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[LayoutBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_LayoutBackground)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarMonthView.html#Syncfusion_Maui_Calendar_CalendarMonthView_Background)'| markdownify }}</td>
<td>Gets or sets the background for the month cells of the calendar month view.</td>
</tr>
<tr>
<td>{{'[LabelAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_LabelAlignment)'| markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#year-cell-appearance-using-datatemplate)' | markdownify }} property from YearView.</td>
</tr>
<tr>
<td>{{'[MonthHeaderBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_MonthHeaderBackground)'| markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#year-cell-appearance-using-datatemplate)' | markdownify }} property from YearView.</td>
</tr>
<tr>
<td>{{'[MonthHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_MonthHeaderTextColor)'| markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#year-cell-appearance-using-datatemplate)' | markdownify }} property from YearView.</td>
</tr>
<tr>
<td>{{'[DateTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_DateTextColor)'| markdownify }}</td>
<td>{{'[[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarTextStyle.html#Syncfusion_Maui_Calendar_CalendarTextStyle_TextColor)(From [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html#Syncfusion_Maui_Calendar_CalendarYearView_TextStyle), [TodayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html#Syncfusion_Maui_Calendar_CalendarYearView_TodayTextStyle), [LeadingDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html#Syncfusion_Maui_Calendar_CalendarYearView_LeadingDatesTextStyle), [DisabledDatesTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html#Syncfusion_Maui_Calendar_CalendarYearView_DisabledDatesTextStyle))]'| markdownify }}</td>
<td>Gets or sets the text color of the text style.</td>
</tr>
<tr>
<td>{{'[HeaderBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_HeaderBackground)'| markdownify }}</td>
<td>{{'[[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_Background)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) of [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the background of the header view in SfCalendar.</td>
</tr>
<tr>
<td>{{'[MonthLayoutBackground](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_MonthLayoutBackground)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarYearView.html#Syncfusion_Maui_Calendar_CalendarYearView_Background)'| markdownify }}</td>
<td>Gets or sets the background for the year, decade and century cells of the calendar year, decade and century view.</td>
</tr>
<tr>
<td>{{'[YearHeaderTextColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewSettings.html#Syncfusion_SfCalendar_XForms_YearViewSettings_YearHeaderTextColor)'| markdownify }}</td>
<td>{{'[[TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html#Syncfusion_Maui_Calendar_CalendarHeaderView_TextStyle)(From [HeaderView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarHeaderView.html) of [SfCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html))]'| markdownify }}</td>
<td>Gets or sets the text style of the header text in SfCalendar.</td>
</tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[BlackoutDatesViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.BlackoutDatesViewMode.html)'| markdownify }}</td>
<td>Nil</td>
<td>Use the {{'[SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate)' | markdownify }} property.</td>
</tr>
<tr>
<td>{{'[CellGridOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.CellGridOptions.html)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can customize the month cells.</td>
</tr>
<tr>
<td>{{'[DateTextAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.DateTextAlignment.html)'| markdownify }}</td>
<td>Nil</td>
<td>Using the {{'[CellTemplate](https://help.syncfusion.com/maui/calendar/customizations#month-cell-appearance-using-datatemplate)' | markdownify }}, you can align the month cells text.</td>
</tr>
<tr>
<td>{{'[DayLabelTextAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.DayLabelTextAlignment.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[InlineViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.InlineViewMode.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[LabelAlignment](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.LabelAlignment.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[NavigationDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.NavigationDirection.html)'| markdownify }}</td>
<td>{{'[CalendarNavigationDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarNavigationDirection.html)'| markdownify }}</td>
<td>Defines the navigation direction for the SfCalendar.</td>
</tr>
<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SelectionMode.html)'| markdownify }}</td>
<td>{{'[CalendarSelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionMode.html)'| markdownify }}</td>
<td>Defines the selection mode for the SfCalendar.</td>
</tr>
<tr>
<td>{{'[SelectionShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SelectionShape.html)'| markdownify }}</td>
<td>{{'[CalendarSelectionShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarSelectionShape.html)'| markdownify }}</td>
<td>Defines the selection shape for the SfCalendar.</td>
</tr>
<tr>
<td>{{'[TransitionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.TransitionMode.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.ViewMode.html)'| markdownify }}</td>
<td>{{'[CalendarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarView.html)'| markdownify }}</td>
<td>Defines the view for the SfCalendar.</td>
</tr>
<tr>
<td>{{'[YearViewMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.YearViewMode.html)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[InlineItemTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_InlineItemTapped)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[InlineToggled](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_InlineToggled)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[MonthChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MonthChanged)'| markdownify }}</td>
<td>{{'[ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChanged)'| markdownify }}</td>
<td>Occurs whenever the calendar view and visible dates changed on SfCalendar. </td>
</tr>
<tr>
<td>{{'[MonthChanging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_MonthChanging)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[OnCalendarTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnCalendarTapped)'| markdownify }}</td>
<td>{{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Tapped)'| markdownify }}</td>
<td>Occurs after the tap interaction on SfCalendar.</td>
</tr>
<tr>
<td>{{'[OnDateCellHolding](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnDateCellHolding)'| markdownify }}</td>
<td>{{'[LongPressed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_LongPressed)'| markdownify }}</td>
<td>Occurs after the long press interaction on SfCalendar.</td>
</tr>
<tr>
<td>{{'[OnHeaderLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnHeaderLoaded)'| markdownify }}</td>
<td>Nil</td>
<td>Customize the header view by using the properties of {{'[HeaderView](https://help.syncfusion.com/maui/calendar/headers)' | markdownify }}.</td>
</tr>
<tr>
<td>{{'[OnInlineLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnInlineLoaded)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[OnMonthCellLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnMonthCellLoaded)'| markdownify }}</td>
<td>Nil</td>
<td>Customize the header view by using the properties of {{'[MonthView](https://help.syncfusion.com/maui/calendar/customizations#month-cell-customization)' | markdownify }}.</td>
</tr>
<tr>
<td>{{'[OnViewModeChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnViewModeChanged)'| markdownify }}</td>
<td>{{'[ViewChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_ViewChanged)'| markdownify }}</td>
<td>Occurs whenever the calendar view and visible dates changed on SfCalendar. </td>
</tr>
<tr>
<td>{{'[OnYearCellLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_OnYearCellLoaded)'| markdownify }}</td>
<td>Nil</td>
<td>Customize the year view by using the properties of {{'[YearView](https://help.syncfusion.com/maui/calendar/customizations#year-cell-customization)' | markdownify}}.</td>
</tr>
<tr>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SelectionChanged)'| markdownify }}</td>
<td>{{'[SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectionChanged)'| markdownify }}</td>
<td>Occurs after the selection changed on SfCalendar.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfCalendar</th>
<th>.NET MAUI SfCalendar</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[AddDatesInPast](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_AddDatesInPast)'| markdownify }}</td>
<td>{{'[EnablePastDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnablePastDates)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the dates are enabled or disabled before today's date.</td>
</tr>
<tr>
<td>{{'[Backward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_AddDatesInPast)'| markdownify }}</td>
<td>{{'[Backward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Backward)'| markdownify }}</td>
<td>Move to previous view which displays previous view dates.</td>
</tr>
<tr>
<td>{{'[ClearSelection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ClearSelection)'| markdownify }}</td>
<td>Nil</td>
<td>You can deselect the date by using the CanToggleDaySelection property.</td>
</tr>
<tr>
<td>{{'[CollapseInlineView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_CollapseInlineView_System_DateTime_)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ExpandInlineView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ExpandInlineView_System_DateTime_)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[Forward](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_Forward)'| markdownify }}</td>
<td>{{'[Forward](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Forward)'| markdownify }}</td>
<td>Move to next view which displays next view dates.</td>
</tr>
<tr>
<td>{{'[NavigateTo](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_NavigateTo_System_DateTime_)'| markdownify }}</td>
<td>Nil</td>
<td>Using {{'[DisplayDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_DisplayDate)' | markdownify }}, you can navigate to specific date.</td>
</tr>
<tr>
<td>{{'[Refresh](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_Refresh)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[ResumeAppointmentUpdate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_ResumeAppointmentUpdate)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
<tr>
<td>{{'[SuspendAppointmentUpdate](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfCalendar.XForms.SfCalendar.html#Syncfusion_SfCalendar_XForms_SfCalendar_SuspendAppointmentUpdate)'| markdownify }}</td>
<td>Nil</td>
<td>Not Supported.</td>
</tr>
</table>