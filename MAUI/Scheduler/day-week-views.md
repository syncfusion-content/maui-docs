---
layout: post
title: Day and Week views in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about customizing the Day, Week and Workweek views settings and its appearance in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Day and Week views in .NET MAUI Event Scheduler (SfScheduler)

The [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) provides the ability to display the day, week, workweek views, and the current day will be visible by default. The appointments on a specific day will be arranged in the respective timeslots based on their duration.

* **Day view**: It displays a single day of the Scheduler.

* **Week view**: It displays all the days of a week.

* **Work week view**: It displays only the working days of a week. By default, Saturday and Sunday are not working days. It can be customized with any day of the week.

## Change time interval

The time interval between the time slots in the day, week and workweek views can be customized by using the `TimeInterval` property of `DaysView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView TimeInterval="2:0:0" />
    </scheduler:SfScheduler.DaysView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeInterval = new TimeSpan(2, 0, 0);

{% endhighlight %}
{% endtabs %}

![change-time-interval-in-maui-scheduler](images/day-week-views/change-time-interval-in-maui-scheduler.png)

N> To modify the `TimeInterval` value (in minutes), change the time labels format by setting the `TimeRulerFormat` value to hh:mm.

## Change time interval height

The time interval height can be customized for each time slot cell of the day, week, and workweek view by using the `TimeIntervalHeight` property of `DaysView.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView       
                       TimeIntervalHeight="120"/>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeIntervalHeight = 120;

{% endhighlight %}
{% endtabs %}

![change-time-interval-height-in-maui-scheduler](images/day-week-views/change-time-interval-height-in-maui-scheduler.png)

## Flexible working days

By default, the [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) considers the weekdays from Monday to Friday as working days. The days which are defined in this non-working days collection are considered as `non-working days.` Therefore, the weekend days are set to hide from the Scheduler.

The `NonWorkingDays` property of `DaysView` can also be used to show only the nonworking days of the week.

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="WorkWeek">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView       
                       NonWorkingDays="Monday,Wednesday" />
    </scheduler:SfScheduler.DaysView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.WorkWeek;
this.Scheduler.DaysView.NonWorkingDays = SchedulerWeekDays.Monday | SchedulerWeekDays.Wednesday;

{% endhighlight %}
{% endtabs %}

N> The `workweek` view displays exactly the defined working days on Scheduler control, whereas other views displays all the days.

![flexible-working-days-in-maui-scheduler](images/day-week-views/flexible-working-days-in-maui-scheduler.png)

## Flexible working hours

The default values for `StartHour` and `EndHour` are `0` and `24` respectively, to show all the time slots for a day, week, or workweek view. These properties may be set to show only the required time periods in `DaysView.` The `StartHour` and `EndHour` in time duration can be set to show the required time duration in minutes.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView       
                       StartHour="9"
                       EndHour="16" />
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.StartHour = 9;
this.Scheduler.DaysView.EndHour = 16;

{% endhighlight %}
{% endtabs %}

![flexible-working-hours-in-maui-scheduler](images/day-week-views/flexible-working-hours-in-maui-scheduler.png)

N>
* The `NonWorkingDays` property will be applicable only for `workweek` and `Timeline workweek` views only. It is not applicable for the remaining views.
* No need to specify the decimal point values for `StartHour` and `EndHour`, if you do not want to set the minutes.
* The number of time slots will be calculated based on the total minutes of a day and time interval (total minutes of a day ((start hour - end hour) * 60) / time interval).
* If a custom timeInterval is given, then the number of time slots calculated based on the given `TimeInterval` should result in an integer value (total minutes % timeInterval = 0), otherwise the next immediate time interval that results in integer value when dividing total minutes of a day will be considered. For example, if TimeInterval=2 Hours 15 minutes and total minutes = 1440 (24 Hours per day), then the `TimeInterval` will be changed to ‘144’ (1440%144=0) by considering (total minutes % TimeInterval = 0), it will return integer value for time slots rendering.
* If the custom `StartHour` and `EndHour` are given, then the number of time slots calculated based on the given `StartHour` and `EndHour` should result in integer value, otherwise the next immediate `TimeInterval` will be considered until the result is integer value. For example, if the `StartHour` is 9 (09:00AM), `EndHour` is 18.25 (06:15 PM), `TimeInterval` is 30 minutes, and total minutes = 555 ((18.25-9)*60), then the `TimeInterval` will be changed to ’37 minutes’ (555%37=0) by considering (total minutes % timeInterval = 0) it will return the integer value for time slots rendering.

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/HighlightWorkingHour)

## Special time regions

The user interaction such as selection and highlights specific regions of day, week, and workweek views can be restricted by adding the `TimeRegions` property of the `DaysView` in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html). Set the [StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime) and [EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime) properties of `TimeRegions` to create a specialTimeRegion. Use the [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_TimeZone) property to set the specific timezone for start and end time of `TimeRegions.`

![special-time-region-in-timeslots-views-in-maui-scheduler](images/day-week-views/special-time-region-in-timeslots-views-in-maui-scheduler.png)

### Selection restriction in timeslots

Enable or disable the touch interaction of TimeRegion using the [EnablePointerInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_EnablePointerInteraction) property of `TimeRegion.` By default, its value is `true.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

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

{% endhighlight %}
{% endtabs %}

![time-region-selection-restriction-in-timeslots-views-in-maui-scheduler](images/day-week-views/time-region-selection-restriction-in-timeslots-views-in-maui-scheduler.png)

N> This property only restricts the interaction on region and it does not restrict the following:
* The Programmatic selection (if the user updates the selected date value dynamically).
* It does not clear the selection when the user selects the region and dynamically change the `EnablePointerInteraction` property to false.
* It does not restrict appointment interaction when the appointment placed in the region.
* It does not restrict the appointment interaction when the appointment is placed in the region.

### Recurring time region

The recurring time region on a daily, weekly, monthly, or yearly interval. The recurring special time regions can be created by setting the [RecurrenceRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceRule) property in `TimeRegion.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

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
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

{% endhighlight %}
{% endtabs %}

![recurring-time-region-selection-restriction-in-timeslots-views-in-maui-scheduler](images/day-week-views/recurring-time-region-selection-restriction-in-timeslots-views-in-maui-scheduler.png)

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/HighlightNonWorkingHour)

### Recurrence exception dates

Any of occurrence that is an exception from the recurrence pattern time region can be deleted by using the [RecurrenceExceptionDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceExceptionDates) property of `TimeRegion.` The deleted occurrence date will be considered as a recurrence exception date.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeRegions = this.GetTimeRegion();

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

![recurring-exception-time-region-selection-restriction-in-timeslots-views-in-maui-scheduler](images/day-week-views/recurring-exception-time-region-selection-restriction-in-timeslots-views-in-maui-scheduler.png)

### Customize special time region appearance

The specialTimeRegion background and text style can be customized by using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_Background) and [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_TextStyle) properties of `TimeRegion.` It is used to customize the background color for time region background and text style for the text of the specialTimeRegion.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeRegions = this.GetTimeRegion();

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

![time-region-appearence-customization-in-timeslots-views-in-maui-scheduler](images/day-week-views/time-region-appearence-customization-in-timeslots-views-in-maui-scheduler.png)

## Full screen scheduler

The [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) time interval height can be adjusted based on screen height by changing the `TimeIntervalHeight` property of `DaysView` to `-1.` It will auto-fit the day, week and work week views to the screen height.

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView 
                        TimeIntervalHeight="-1"/>
    </scheduler:SfScheduler.DaysView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeIntervalHeight = -1;

{% endhighlight %}
{% endtabs %}

![full-screen-scheduler-in-timeslots-views-in-maui-scheduler](images/day-week-views/full-screen-scheduler-in-timeslots-views-in-maui-scheduler.png)

## Show current time indicator

You can show or hide the current time indicator in day, week, and workweek views of [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) by using the `ShowCurrentTimeIndicator` property of `DaysView,` and by default, its `true.`

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
            <scheduler:SchedulerDaysView 
                       ShowCurrentTimeIndicator="False"/>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.ShowCurrentTimeIndicator = false;

{% endhighlight %}
{% endtabs %}

### Customize current time indicator appearance

The current time indicator can be customized by using the `CurrentTimeIndicatorBrush` property of `DaysView` in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
            <scheduler:SchedulerDaysView 
                       CurrentTimeIndicatorBrush="Blue"/>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.CurrentTimeIndicatorBrush = Brush.Blue;

{% endhighlight %}
{% endtabs %}

![customize-current-time-indicator-appearance-in-timeslots-views-in-maui-scheduler](images/day-week-views/customize-current-time-indicator-appearance-in-timeslots-views-in-maui-scheduler.png)

N>
The current time indicator color is applied only when the`ShowCurrentTimeIndicator` property is enabled.

## Change time ruler width

The `TimeRulerWidth` property of `DaysView` can be used to customize the size of the time ruler view where the labels with the time are placed.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView 
                       TimeRulerWidth="120"/>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeRulerWidth = 120;

{% endhighlight %}
{% endtabs %}

![change-time-ruler-width-in-maui-scheduler](images/day-week-views/change-time-ruler-width-in-maui-scheduler.png)

## Minimum appointment duration

The `MinimumAppointmentDuration` property allows to set an arbitrary height to appointments which have a minimum duration in the day, week, and workweek views so that the subject can be readable.

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView 
                       MinimumAppointmentDuration="0:30:0" />
        </scheduler:SfScheduler.DaysView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.MinimumAppointmentDuration = new TimeSpan(0, 30, 0);

{% endhighlight %}
{% endtabs %}

![change-minimum-appointment-duration-in-maui-scheduler](images/day-week-views/change-minimum-appointment-duration-in-maui-scheduler.png)

N>
*  The `MinimumAppointmentDuration` value will be set when an appointment duration value is lesser than `MinimumAppointmentDuration.`
* The appointment duration value will be set when the appointment duration value is greater than the `MinimumAppointmentDuration.`
*  The `TimeInterval` value will be set when the `MinimumAppointmentDuration` is greater than the `TimeInterval` with lesser appointment duration.
* The all-day appointment does not support `MinimumAppointmentDuration.`

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)
* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## View header text formatting

The date and day format of SfScheduler ViewHeader can be customized by using the `DateFormat` and `DayFormat` properties of `DaysView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView>
            <scheduler:SchedulerDaysView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd"
                                                       DateFormat="dd" />
                </scheduler:SchedulerDaysView.ViewHeaderSettings>
        </scheduler:SchedulerDaysView>
    </scheduler:SfScheduler.DaysView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.ViewHeaderSettings.DayFormat = "dddd";
this.Scheduler.DaysView.ViewHeaderSettings.DateFormat = "dd";

{% endhighlight %}
{% endtabs %}

![change-view-header-text-formatting-in-maui-scheduler](images/day-week-views/change-view-header-text-formatting-in-maui-scheduler.png)

### View header height

The height of the ViewHeader in a day, week, and work week views can be customized by setting the `Height` property of `ViewHeaderSettings` in `DaysView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView>
            <scheduler:SchedulerDaysView.ViewHeaderSettings>
                    <scheduler:SchedulerViewHeaderSettings Height="100" />
            </scheduler:SchedulerDaysView.ViewHeaderSettings>
    </scheduler:SchedulerDaysView>
</scheduler:SfScheduler.DaysView>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.ViewHeaderSettings.Height = 100;

{% endhighlight %}
{% endtabs %}

### Customize view header text style

The background color and text style for the labels mentioning the time can be customized, by setting the `Background,` `DateTextStyle,` and `DayTextStyle` properties of `DaysView` in the Scheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView>
            <scheduler:SchedulerDaysView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Background="LightGreen" />
            </scheduler:SchedulerDaysView.ViewHeaderSettings>
        </scheduler:SchedulerDaysView>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
var dateTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.DaysView.ViewHeaderSettings.DateTextStyle = dateTextStyle;
var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.DaysView.ViewHeaderSettings.DayTextStyle = dayTextStyle;
this.Scheduler.DaysView.ViewHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}
{% endtabs %}

![customize-view-header-text-style-in-maui-scheduler](images/day-week-views/customize-view-header-text-style-in-maui-scheduler.png)

## Time text formatting

The format for the labels mentioning the time can be customized by setting the `TimeFormat` property of `DaysView` in the Scheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Week">
    <scheduler:SfScheduler.DaysView>
        <scheduler:SchedulerDaysView TimeFormat="hh:mm"/>
    </scheduler:SfScheduler.DaysView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DaysView.TimeFormat = "hh:mm";

{% endhighlight %}
{% endtabs %}

![change-time-ruler-text-formatting-in-maui-scheduler](images/day-week-views/change-time-ruler-text-formatting-in-maui-scheduler.png)

N>
* By default, the scheduler time text format is `hh:mm tt.`

### Customize time ruler text style

The text style for the labels mentioning the time can be customized, by setting the `TimeRulerTextStyle` property of `DaysView` in the Scheduler.

{% tabs %}
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler"
                       View="Week">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Week;
var timeRulerTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.DaysView.TimeRulerTextStyle = timeRulerTextStyle;

{% endhighlight %}
{% endtabs %}

![customize-time-ruler-text-style-in-maui-scheduler](images/day-week-views/customize-time-ruler-text-style-in-maui-scheduler.png)