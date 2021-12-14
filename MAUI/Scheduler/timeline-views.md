---
layout: post
title: Timeline Views in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about to customize the timeline views settings in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Timeline Views in .NET MAUI Scheduler (SfScheduler)

The timelineView displays the date inside the horizontal time axis with the desired count of each day. See the past or future dates by scrolling to the right or left. The appointments on a specific day will be arranged in the respective timeslots based on their duration.

* **Timeline day view**: It displays a single day in the horizontal time axis of the Scheduler.

* **Timeline week view**: It displays all days of a week in horizontal time axis. You can see the past or future dates by scrolling to right or left.

* **Timeline work week view**: It displays only the working days of a week in horizontal axis. By default, Saturday and Sunday are not working days. You can customize it with any day of the week.

* **Timeline month**: A horizontal axis displaying appointments across all days of a month is displayed, where each column represents a single day.

## Change time interval

You can customize the time interval between the time slots in the timeline day, timeline week, and timeline workweek views by using the `TimeInterval` property of `TimelineViewSettings.`

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeInterval = new TimeSpan(2, 0, 0);

{% endhighlight %}
{% endtabs %}

N> To modify the `TimeInterval` value (in minutes), change the time labels format by setting the `TimeRulerFormat` value to hh:mm.

## Change time interval width

The Time interval width can be customized for each time slot cell of the timeline day, timeline week, timeline workweek, and timeline month views by using the `TimeIntervalWidth` property of `TimelineViewSettings.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineViewSettings>
        <scheduler:SchedulerTimelineViewSettings 
                       TimeIntervalWidth="120" />
    </scheduler:SfScheduler.TimelineViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeIntervalWidth = 120;

{% endhighlight %}
{% endtabs %}

## Flexible working days

By default, the `.NET MAUI Scheduler`, weekdays from Monday through Friday are considered working days. The days which are defined in this non-working days collection are considered as `non-working days.` Therefore, when the weekend days are set to hide from Scheduler.

The `NonWorkingDays` property of `TimelineViewSettings` can also be used to show only the nonworking days of the week.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWorkWeek">
    <scheduler:SfScheduler.TimelineViewSettings>
        <scheduler:SchedulerTimelineViewSettings 
                       NonWorkingDays="Monday,Wednesday" />
    </scheduler:SfScheduler.TimelineViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWorkWeek;
this.Scheduler.TimelineViewSettings.NonWorkingDays = SchedulerWeekDays.Monday | SchedulerWeekDays.Wednesday;

{% endhighlight %}
{% endtabs %}

N> The `Timeline workweek` view displays exactly the defined working days on Scheduler control, whereas other views displays all the days.

## Flexible working hours

The default values for `StartHour` and `EndHour` are `0` and `24` respectively, to show all time slots for a timeline day, timeline week, or timeline workweek view. You may set these properties to show only the required time periods in `TimelineViewSettings.` You can set `StartHour` and `EndHour` in time duration to show the required time duration in minutes.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineViewSettings>
        <scheduler:SchedulerTimelineViewSettings 
                       StartHour="9"
                       EndHour="16" />
    </scheduler:SfScheduler.TimelineViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.StartHour = 9;
this.Scheduler.TimelineViewSettings.EndHour = 16;

{% endhighlight %}
{% endtabs %}

N>
* The `NonWorkingDays` property will be applicable only for `workWeek` and `TimelineWorkWeek` views only, and not be applicable for the remaining views.
* No need to specify the decimal point values for `StartHour` and `EndHour`, if you do not want to set the minutes.
* The number of time slots will be calculated based on total minutes of a day and time interval (total minutes of a day ((start hour - end hour) * 60) / time interval).
* If a custom timeInterval is given, then the number of time slots calculated based on the given `TimeInterval` should result in an integer value (total minutes % timeInterval = 0), otherwise the next immediate time interval that results in integer value when dividing total minutes of a day will be considered. For example, if TimeInterval=2 Hours 15 minutes and total minutes = 1440 (24 Hours per day), then the `TimeInterval` will be changed to ‘144’ (1440%144=0) by considering (total minutes % TimeInterval = 0), it will return integer value for time slots rendering.
* If the custom `StartHour` and `EndHour` are given, then the number of time slots calculated based on given `StartHour` and `EndHour` should result in integer value, otherwise the next immediate `TimeInterval` will be considered until the result is integer value. For example, if the `StartHour` is 9 (09:00AM), `EndHour` is 18.25 (06:15 PM), `TimeInterval` is 30 minutes, and total minutes = 555 ((18.25-9)*60), then the `TimeInterval` will be changed to ’37 minutes’ (555%37=0) by considering (total minutes % timeInterval = 0) it will return the integer value for time slots rendering.

## Special time regions

You can restrict the user interaction such as selection and highlights specific regions of timeline day, timeline week, and timeline workweek views by adding the `TimeRegions` property of the `SfScheduler.` You need to set the `StartTime` and `EndTime` properties of `TimeRegions` to create a specialTimeRegion, you can use the `TimeZone` property to set the specific timezone for start and end time of `TimeRegions.`

### Selection restriction in timeslots

You can enable or disable the touch interaction of TimeRegion using the `EnablePointerInteraction` property of `TimeRegion.` By default, its value is `true.`

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeRegions = this.GetTimeRegion();

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

{% endhighlight %}
{% endtabs %}

N> This property only restricts the interaction on region and it does not restrict the following:
* The Programmatic selection (if the user updates the selected date value dynamically).
* It does not clear the selection when the user selects the region and dynamically change the `EnablePointerInteraction` property to false.
* It does not restrict appointment interaction when the appointment placed in the region.
* It does not restrict the appointment rendering on a region, when the appointments are loaded from data services or added programmatically.

### Recurring time region

The recurring time region on a daily, weekly, monthly, or yearly interval. The recurring special time regions can be created by setting the `RecurrenceRule` property in `TimeRegion.`

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        EnablePointerInteraction = false,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

{% endhighlight %}
{% endtabs %}

### Recurrence exception dates

You can delete any of occurrence that is an exception from the recurrence pattern time region by using the `RecurrenceExceptionDates` property of `TimeRegion.` The deleted occurrence date will be considered as a recurrence exception date.

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var recurrenceExceptionDates = DateTime.Now.Date.AddDays(3);
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        EnablePointerInteraction = false,
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
        RecurrenceExceptionDates = new ObservableCollection<DateTime>()
        {
            recurrenceExceptionDates,
        }
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

{% endhighlight %}
{% endtabs %}

### Customize special time region appearance

The specialTimeRegion background and text style can be customized by using the `Background` and `TextStyle` properties of `TimeRegion` that is used to customize the background color for time region background and text style for the text of the specialTimeRegion.

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var textStyle = new SchedulerTextStyle()
    {
        TextColor = Colors.DarkBlue,
        FontSize = 14,
    };

    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        EnablePointerInteraction = false,
        Background = Brush.Orange,
        TextStyle = textStyle
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

{% endhighlight %}
{% endtabs %}

## Change time ruler height

The `TimeRulerHeight` property of `TimelineViewSettings` can be used to customize the size of the time ruler view where the labels with the time are placed.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineViewSettings>
        <scheduler:SchedulerTimelineViewSettings 
                       TimeRulerHeight="100" />
    </scheduler:SfScheduler.TimelineViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeRulerHeight = 100;

{% endhighlight %}
{% endtabs %}

## Minimum appointment duration

The `MinimumAppointmentDuration` property allows you to set an arbitrary height to appointments which have a minimum duration in the timeline day, timeline week, and timeline workweek views so that the subject can be readable.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineViewSettings>
        <scheduler:SchedulerTimelineViewSettings 
                       MinimumAppointmentDuration="0:30:0" />
    </scheduler:SfScheduler.TimelineViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.MinimumAppointmentDuration = new TimeSpan(0, 30, 0);

{% endhighlight %}
{% endtabs %}

N>
* The `MinimumAppointmentDuration` value will be set when an appointment duration value is lesser than `MinimumAppointmentDuration.`
* Appointment duration value will be set when the appointment duration value is greater than `MinimumAppointmentDuration`.
* The `TimeInterval` value will be set when the `MinimumAppointmentDuration` is greater than `TimeInterval` with lesser appointment duration.
* The all-day Appointment does not support `MinimumAppointmentDuration.`

## View header text formatting

You can customize the date and day format of `SfScheduler` ViewHeader by using the `DateFormat` and `DayFormat` properties of `TimelineViewSettings.`

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.ViewHeaderSettings.DayFormat = "dddd";
this.Scheduler.TimelineViewSettings.ViewHeaderSettings.DateFormat = "MMMM dd";

{% endhighlight %}
{% endtabs %}

## Customize view header text style

You can customize the background color and text style for the labels mentioning the time, by setting the `Background,` `DateTextStyle,` and `DayTextStyle` properties of `TimelineViewSettings` in the Scheduler.

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
var dateTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineViewSettings.ViewHeaderSettings.DateTextStyle = dateTextStyle;
var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineViewSettings.ViewHeaderSettings.DayTextStyle = dayTextStyle;

{% endhighlight %}
{% endtabs %}

## Time text formatting

You can customize the format for the labels mentioning the time by setting the `TimeFormat` property of `TimelineViewSettings` in the Scheduler.

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineViewSettings.TimeFormat = "hh:mm";

{% endhighlight %}
{% endtabs %}

N>
* By default, the scheduler time text format is `hh:mm tt.`

## Customize time ruler text style

You can customize the background and text style for the labels mentioning the time, by setting the `Background,` and `TimeRulerTextStyle` properties of `TimelineViewSettings` in the Scheduler.

{% tabs %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.TimelineWeek;
var timeRulerTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineViewSettings.TimeRulerTextStyle = timeRulerTextStyle;

{% endhighlight %}
{% endtabs %}