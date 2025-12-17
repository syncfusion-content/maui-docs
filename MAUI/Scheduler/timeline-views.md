---
layout: post
title: Timeline Views in .NET MAUI Scheduler control | Syncfusion®
description: Learn here all about how to customize the timeline views settings in Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
keywords : .net maui scheduler, .net maui timelineview, .net maui timeline day view, .net maui timeline week view, .net maui timeline work week view, .net maui timeline month view.
---

# Timeline Views in .NET MAUI Scheduler (SfScheduler)

The timelineView displays the date inside the horizontal time axis with the desired count of each day. See the past or future dates by scrolling to the right or left. The appointments on a specific day will be arranged in the respective timeslots based on their duration.

* **Timeline day view**: It displays a single day in the horizontal time axis of the Scheduler.

* **Timeline week view**: It displays all the days of a week in horizontal time axis. The past or future dates can be viewed by scrolling to right or left.

* **Timeline work week view**: It displays only the working days of a week in horizontal axis. By default, Saturday and Sunday are not working days. You can customize it with any day of the week.

* **Timeline month**: A horizontal axis displaying appointments across all days of a month is displayed, where each column represents a single day.

## Number of days visible in the timeline views

The [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) number of visible days in the timeline day, timeline week, and timeline workweek can be adjusted by changing the [NumberOfVisibleDays](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_NumberOfVisibleDaysProperty) property of the [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight XAML hl_lines="5" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                        NumberOfVisibleDays="3"/>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.NumberOfVisibleDays = 3;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![visible-days-count-in-maui-scheduler-timeline-views](images/timeline-views/number-of-visibledays-in-maui-scheduler.png)

## Change time interval

The time interval between the time slots in the timeline day, timeline week, and timeline workweek views can be customized by using the [TimeInterval](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeInterval) property of the [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       TimeInterval="2:0:0" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.TimeInterval = new TimeSpan(2, 0, 0);
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![change-time-interval-in-maui-scheduler](images/timeline-views/change-time-interval-in-maui-scheduler.png)

N> To modify the `TimeInterval` value (in minutes), change the time labels format by setting the `TimeRulerFormat` value to `hh:mm.`

## Change time interval width

The Time interval width can be customized for each time slot cell of the timeline day, timeline week, timeline workweek, and timeline month views by using the [TimeIntervalWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeIntervalWidth) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight XAML hl_lines="5" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       TimeIntervalWidth="120" />
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.TimeIntervalWidth = 120;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![change-time-interval-width-in-maui-scheduler](images/timeline-views/change-time-interval-width-in-maui-scheduler.png)

## Flexible working days

By default, the [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) considers the weekdays from Monday to Friday as working days. The days which are defined in this non-working days collection are considered as `non-working days.` Therefore, the weekend days are set to hide from the Scheduler.

The [NonWorkingDays](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_NonWorkingDays) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) can also be used to show only the nonworking days of the week.

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWorkWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       NonWorkingDays="Monday,Wednesday" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.NonWorkingDays = SchedulerWeekDays.Monday | SchedulerWeekDays.Wednesday;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

N> The `Timeline workweek` view displays exactly the defined working days on Scheduler control, whereas other views displays all the days.

## Hide non-working days in timeline month

The [HideNonWorkingDays](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_HideNonWorkingDays) property of the [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) allows you to control the visibility of non-working days in `TimelineMonth`. By default, the [HideNonWorkingDays](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_HideNonWorkingDays) property is set to false.

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineMonth">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       NonWorkingDays="Monday,Wednesday" HideNonWorkingDays = "True"/>
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="4" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineMonth;
scheduler.TimelineView.NonWorkingDays = SchedulerWeekDays.Monday | SchedulerWeekDays.Wednesday;
scheduler.TimelineView.HideNonWorkingDays = true;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![hide-non-working-days-in-timelinemonth-maui-scheduler](images/timeline-views/hide-non-working-days-in-timelinemonth-maui-scheduler.png)

N> The `HideNonWorkingDays` property will be applicable only for `TimelineMonth` view, and not be applicable for the remaining views.

## Flexible working hours

The default values for [StartHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_StartHour) and [EndHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_EndHour) are `0` and `24` respectively, to show all the time slots for a timeline day, timeline week, or timeline workweek view. You may set these properties to show only the required time periods in [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html). You can set [StartHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_StartHour) and [EndHour](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_EndHour) in the time duration to show the required time duration in minutes.

{% tabs %}
{% highlight XAML hl_lines="5 6" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
            <scheduler:SchedulerTimelineView 
                       StartHour="9"
                       EndHour="16" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3 4" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.StartHour = 9;
scheduler.TimelineView.EndHour = 16;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![flexible-working-hours-in-maui-scheduler](images/timeline-views/flexible-working-hours-in-maui-scheduler.png)

N>
* The `NonWorkingDays` property will be applicable only for `workWeek` , `TimelineWorkWeek` and `TimelineMonth` views only, and not be applicable for the remaining views.
* No need to specify the decimal point values for `StartHour` and `EndHour`, if you do not want to set the minutes.
* The number of time slots will be calculated based on total minutes of a day and time interval (total minutes of a day ((start hour - end hour) * 60) / time interval).
* If a custom timeInterval is given, then the number of time slots calculated based on the given `TimeInterval` should result in an integer value (total minutes % timeInterval = 0), otherwise the next immediate time interval that results in integer value when dividing total minutes of a day will be considered. For example, if TimeInterval=2 Hours 15 minutes and total minutes = 1440 (24 Hours per day), then the `TimeInterval` will be changed to ‘144’ (1440%144=0) by considering (total minutes % TimeInterval = 0), it will return integer value for time slots rendering.
* If the custom `StartHour` and `EndHour` are given, then the number of time slots calculated based on the given `StartHour` and `EndHour` should result in integer value, otherwise the next immediate `TimeInterval` will be considered until the result is integer value. For example, if the `StartHour` is 9 (09:00AM), `EndHour` is 18.25 (06:15 PM), `TimeInterval` is 30 minutes, and total minutes = 555 ((18.25-9)*60), then the `TimeInterval` will be changed to ’37 minutes’ (555%37=0) by considering (total minutes % timeInterval = 0) it will return the integer value for time slots rendering.

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/HighlightWorkingHour)

## Special time regions

The user interaction such as selection and highlights specific regions of timeline day, timeline week, and timeline workweek views can be restricted by adding the [TimeRegions](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegions) property of the [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html). You need to set the [StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime) and [EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime) properties of `TimeRegions` to create a specialTimeRegion, you can use the [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_TimeZone) property to set the specific timezone for start and end time of `TimeRegions.`

![special-time-region-in-maui-scheduler](images/timeline-views/special-time-region-in-maui-scheduler.png)

Watch the video below for a step-by-step guide on adding and customizing TimeRegions in .NET MAUI SfScheduler

{% youtube "https://www.youtube.com/watch?v=ru06fr9jo5Q" %}

### Selection restriction in timeslots

You can enable or disable the touch interaction of TimeRegion using the [EnablePointerInteraction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_EnablePointerInteraction) property of [TimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html). By default, its value is `true.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/timelineview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="12" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

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

The recurring time region on a daily, weekly, monthly, or yearly interval. The recurring special time regions can be created by setting the [RecurrenceRule](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceRule) property in [TimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/timelineview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="13" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

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

N> [View sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/HighlightNonWorkingHour)

### Recurrence exception dates

Any occurrence that is an exception from the recurrence pattern time region can be deleted by using the [RecurrenceExceptionDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_RecurrenceExceptionDates) property of [TimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html). The deleted occurrence date will be considered as a recurrence exception date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/timelineview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7 15 16 17 18" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

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

The special time region appearance customization can be achieved by using the [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_TextStyle) and [TimeRegionTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegionTemplate) properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

#### Customize special time region appearance using style

The specialTimeRegion background and text style can be customized by using the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_Background) and [TextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html#Syncfusion_Maui_Scheduler_SchedulerTimeRegion_TextStyle) properties of [TimeRegion](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeRegion.html) that is used to customize the background color for time region background and text style for the text of the specialTimeRegion.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/timelineview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="20" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

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

![customize-time-region-appearance-in-maui-scheduler](images/timeline-views/customize-time-region-appearance-in-maui-scheduler.png)

#### Customize special time region appearance using DataTemplate

You can customize the time region appearance by using the [TimeRegionTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegionTemplate) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5 6 7 8 9 10 11" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView>
            <scheduler:SchedulerTimelineView.TimeRegionTemplate>
                <DataTemplate>
                    <Grid Background="MediumPurple" >
                        <Label HorizontalOptions="Center" TextColor="White" VerticalOptions="Center" Text="{Binding Text}" />
                    </Grid>
                </DataTemplate>
            </scheduler:SchedulerTimelineView.TimeRegionTemplate>
        </scheduler:SchedulerTimelineView>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        EnablePointerInteraction = false,
        Background = Brush.Orange,
    };

    timeRegions.Add(timeRegion);
    return timeRegions;
}

{% endhighlight %}
{% endtabs %}

![time-region-appearence-template-customization-in-timeslots-views-in-maui-scheduler](images/timeline-views/time-region-appearence-template-customization-in-timeslots-views-in-maui-scheduler.png)

#### Customize special time region appearance using DataTemplateSelector

You can customize the time region appearance by using the [TimeRegionTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRegionTemplate) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html). The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to scheduler time region by using the `TimeRegionTemplate.` It allows you to choose a different data template for each time region, as well as customize the appearance of a particular time region based on certain conditions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="18" %}

<Grid>
    <Grid.Resources>
        <DataTemplate x:Key="timeRegiontemplate">
            <Grid Background = "LightCyan" Opacity="0.5">
                <Label x:Name="label" HorizontalOptions="Center" TextColor="Red" Text="{Binding Text}" VerticalOptions="Center" />
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="timeRegiontemplate1">
            <Grid Background = "Lightgreen" Opacity="0.5">
                <Label x:Name="label" HorizontalOptions="Center" TextColor="Orange" Text="{Binding Text}" VerticalOptions="Center" />
            </Grid>
        </DataTemplate>
        <local:TimeRegionTemplateSelector x:Key="timeRegionTemplateSelector"  TimeRegionsTemplate="{StaticResource timeRegiontemplate}"  TimeRegionsTemplate1="{StaticResource timeRegiontemplate1}" />
    </Grid.Resources>
     <scheduler:SfScheduler x:Name="Scheduler" 
                            View="TimelineWeek">
        <scheduler:SfScheduler.TimelineView>
            <scheduler:SchedulerTimelineView TimeRegionTemplate = "{StaticResource timeRegionTemplateSelector}"/>
        </scheduler:SfScheduler.TimelineView>
    </scheduler:SfScheduler>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="TimeRegionTemplateSelector.cs" %}

public class TimeRegionTemplateSelector : DataTemplateSelector
{
    public TimeRegionTemplateSelector()
    {
    }
    public DataTemplate TimeRegionsTemplate { get; set; }
    public DataTemplate TimeRegionsTemplate1 { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var timeRegionDetails = item as SchedulerTimeRegion;
        if (timeRegionDetails.EnablePointerInteraction)
            return TimeRegionsTemplate;
        return TimeRegionsTemplate1;
    }
}

{% endhighlight %}  
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
this.Scheduler.TimelineView.TimeRegions = this.GetTimeRegion();

private ObservableCollection<SchedulerTimeRegion> GetTimeRegion()
{
    var timeRegions = new ObservableCollection<SchedulerTimeRegion>();
    var timeRegion = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(13),
        EndTime = DateTime.Today.Date.AddHours(14),
        Text = "Lunch",
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
        EnablePointerInteraction = true,
    };
    var timeRegion1 = new SchedulerTimeRegion()
    {
        StartTime = DateTime.Today.Date.AddHours(17),
        EndTime = DateTime.Today.Date.AddHours(18),
        Text = "Break",
        RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
        Background = Brush.Red,
        EnablePointerInteraction = false,
    };
    timeRegions.Add(timeRegion);
    timeRegions.Add(timeRegion1);
    return timeRegions;
}

{% endhighlight %} 
{% endtabs %}

N>
* The BindingContext of the `TimeRegionTemplate` is the `SchedulerTimeRegion.`
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

## Full screen scheduler

The [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) time interval width can be adjusted based on screen width by changing the [TimeIntervalWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeIntervalWidth) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) to `-1.` It will auto-fit the timeline day, timeline week and timeline work week views to the screen width.

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineDay">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       TimeIntervalWidth="-1" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineDay;
scheduler.TimelineView.TimeIntervalWidth = -1;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![full-screen-scheduler-in-timeline-views-in-maui-scheduler](images/timeline-views/full-screen-scheduler-in-timeline-views-in-maui-scheduler.png)

## Show current time indicator

You can show or hide the current time indicator in timeline day, timeline week, and timeline workweek views of [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) by using the [ShowCurrentTimeIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_ShowCurrentTimeIndicator) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html), and by default, its `true.`

{% tabs %}
{% highlight XAML hl_lines="5" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       ShowCurrentTimeIndicator="False"/>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.ShowCurrentTimeIndicator = false;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

#### Customize current time indicator appearance

The current time indicator can be customized by using the [CurrentTimeIndicatorBrush](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_CurrentTimeIndicatorBrush) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
            <scheduler:SchedulerTimelineView 
                       CurrentTimeIndicatorBrush="Green" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.CurrentTimeIndicatorBrush = Brush.Green;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![customize-current-time-indicator-appearance-in-timeline-views-in-maui-scheduler](images/timeline-views/customize-current-time-indicator-appearance-in-timeline-views-in-maui-scheduler.png)

N>
The current time indicator color is applied only when the`ShowCurrentTimeIndicator` property is enabled.

## Change time ruler height

The [TimeRulerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeRulerHeight) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) can be used to customize the size of the time ruler view where the labels with the time are placed.

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                       TimeRulerHeight="100" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.TimeRulerHeight = 100;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![change-time-ruler-height-in-maui-scheduler](images/timeline-views/change-time-ruler-height-in-maui-scheduler.png)

## Minimum appointment duration

The [MinimumAppointmentDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_MinimumAppointmentDuration) property allows to set an arbitrary height to appointments which have a minimum duration in the timeline day, timeline week, and timeline workweek views so that the subject can be readable.

{% tabs %}
{% highlight XAML hl_lines="5" %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
            <scheduler:SchedulerTimelineView 
                       MinimumAppointmentDuration="0:30:0" />
    </scheduler:SfScheduler.TimelineView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.MinimumAppointmentDuration = new TimeSpan(0, 30, 0);
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![minimum-appointment-duration-in-maui-scheduler](images/timeline-views/minimum-appointment-duration-in-maui-scheduler.png)

N>
* The `MinimumAppointmentDuration` value will be set when an appointment duration value is lesser than `MinimumAppointmentDuration.`
* Appointment duration value will be set when the appointment duration value is greater than `MinimumAppointmentDuration`.
* The `TimeInterval` value will be set when the `MinimumAppointmentDuration` is greater than `TimeInterval` with lesser appointment duration.
* The all-day appointment does not support `MinimumAppointmentDuration.`

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)
* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## View header

You can customize the default appearance of view header in a timeline views by setting the [DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateFormat), [DayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayFormat), [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Background), [DateTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateTextStyle), [DayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayTextStyle), [Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Height), and [ViewHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_ViewHeaderTemplate) properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

### View header text formatting

The date and day format of SfScheduler view header can be customized by using the [DateFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateFormat) and [DayFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayFormat) properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight XAML hl_lines="6 7" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView>
            <scheduler:SchedulerTimelineView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd" 
                                                       DateFormat="MMMM dd"/>
            </scheduler:SchedulerTimelineView.ViewHeaderSettings>
        </scheduler:SchedulerTimelineView>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3 4" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.ViewHeaderSettings.DayFormat = "dddd";
scheduler.TimelineView.ViewHeaderSettings.DateFormat = "MMMM dd";
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![change-view-header-text-formatting-in-maui-scheduler](images/timeline-views/change-view-header-text-formatting-in-maui-scheduler.png)

### View header height

The height of the ViewHeader can be customized by setting the `Height` property of [ViewHeaderSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html) in [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight XAML hl_lines="6" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView>
            <scheduler:SchedulerTimelineView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Height="100" />
            </scheduler:SchedulerTimelineView.ViewHeaderSettings>
        </scheduler:SchedulerTimelineView>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.ViewHeaderSettings.Height = 100;
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![customize-view-header-height-in-timeslot-views-in-maui-scheduler](images/timeline-views/customize-view-header-height-in-timeslot-views-in-maui-scheduler.png)

### Customize view header appearance

The view header appearance customization can be achieved by using the `TextStyle` and `ViewHeaderTemplate` properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

#### Customize view header appearance using text style

The background color and text style for the labels mentioning the time can be customized, by setting the [Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerHeaderSettingsBase.html#Syncfusion_Maui_Scheduler_SchedulerHeaderSettingsBase_Background), [DateTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DateTextStyle), and [DayTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerViewHeaderSettings.html#Syncfusion_Maui_Scheduler_SchedulerViewHeaderSettings_DayTextStyle) properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView>
            <scheduler:SchedulerTimelineView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Background="LightGreen"/>
            </scheduler:SchedulerTimelineView.ViewHeaderSettings>
        </scheduler:SchedulerTimelineView>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="15 16" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
var dateTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineView.ViewHeaderSettings.DateTextStyle = dateTextStyle;
var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineView.ViewHeaderSettings.DayTextStyle = dayTextStyle;
this.Scheduler.TimelineView.ViewHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}
{% endtabs %}

![customize-view-header-text-style-in-maui-scheduler](images/timeline-views/customize-view-header-text-style-in-maui-scheduler.png)

#### Customize view header appearance using DataTemplate

You can customize the view header appearance by using the [ViewHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_ViewHeaderTemplate) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}  
{% highlight xaml tabtitle="MainPage.xaml" %}    

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView>
            <scheduler:SchedulerTimelineView.ViewHeaderTemplate>
                <DataTemplate>
                    <Grid x:Name="grid" Background="MediumPurple" >
                        <Label x:Name="label" HorizontalOptions="Start" VerticalOptions="Center"  TextColor="White" >
                            <Label.Text>
                                <MultiBinding StringFormat = "{}{0:dd} {1:ddd}" >
                                    <Binding />
                                    <Binding />
                                </MultiBinding >
                            </Label.Text >
                            <Label.Triggers >
                                <DataTrigger TargetType="Label" Binding="{Binding}" Value="{x:Static system:DateTime.Today}">
                                    <Setter TargetName = "label" Property="TextColor" Value="Orange"/>
                                </DataTrigger>
                            </Label.Triggers>
                        </Label>
                        <Grid.Triggers>
                            <DataTrigger TargetType = "Grid" Binding="{Binding}" Value="{x:Static system:DateTime.Today}">
                                <Setter TargetName = "grid" Property="Background" Value="LightGreen"/>
                            </DataTrigger>
                        </Grid.Triggers>
                    </Grid>
                </DataTemplate>
            </scheduler:SchedulerTimelineView.ViewHeaderTemplate>
        </scheduler:SchedulerTimelineView>
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% endtabs %}

![customize-view-header-appearance-using-template-in-timeslot-view-in-maui-scheduler](images/timeline-views/customize-view-header-appearance-using-template-in-timeslot-view-in-maui-scheduler.png)

N>
* The BindingContext of the `ViewHeaderTemplate` is the`DateTime.` The `SelectableDayPredicate,` `MinimumDateTime,` and `MaximumDateTime` properties of date and time values can be used directly in the data template selector.

#### Customize view header appearance using DataTemplateSelector

You can customize the view header appearance by using the [ViewHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_ViewHeaderTemplate) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html). The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to scheduler view header by using the `ViewHeaderTemplate.` It allows you to choose a different data template for each view header, as well as customize the appearance of a particular view header based on certain conditions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<Grid>
    <Grid.Resources>
        <DataTemplate x:Key="normalDateTemplate">
            <Grid x:Name="grid" Background="MediumPurple" >
                <Label x:Name="label" HorizontalOptions="Start" VerticalOptions="Center"  TextColor="White" >
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:dd} {1:ddd}" >
                            <Binding />
                            <Binding />
                        </MultiBinding >
                    </Label.Text >
                </Label>
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="todayDateTemplate">
            <Grid x:Name="grid" Background="MediumPurple" >
                <Label x:Name="label" HorizontalOptions="Start" VerticalOptions="Center"  TextColor="Yellow" >
                    <Label.Text>
                        <MultiBinding StringFormat = "{}{0:dd} {1:ddd}" >
                            <Binding />
                            <Binding />
                        </MultiBinding >
                    </Label.Text >
                </Label>
            </Grid>
        </DataTemplate>
        <local:ViewHeaderTemplateSelector x:Key="viewHeaderTemplateSelector" TodayDateTemplate="{StaticResource todayDateTemplate}" NormalDateTemplate="{StaticResource normalDateTemplate}"/>
    </Grid.Resources>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="TimelineWeek" >
        <scheduler:SfScheduler.TimelineView>
            <scheduler:SchedulerTimelineView ViewHeaderTemplate="{StaticResource viewHeaderTemplateSelector}" />
        </scheduler:SfScheduler.TimelineView>
    </scheduler:SfScheduler>
 </Grid>
 
{% endhighlight %}
{% highlight c# tabtitle="ViewHeaderTemplateSelector.cs" %}

public class ViewHeaderTemplateSelector : DataTemplateSelector
{
    public ViewHeaderTemplateSelector()
    {
    }
    public DataTemplate NormalDateTemplate { get; set; }
    public DataTemplate TodayDateTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var dateTime = (DateTime)item;
        if (dateTime.Date == DateTime.Today.Date)
            return TodayDateTemplate;
        else
            return NormalDateTemplate;
    }
}

{% endhighlight %}  
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Scheduler.View = SchedulerView.TimelineWeek;

{% endhighlight %} 
{% endtabs %}

N>
* The BindingContext of the `ViewHeaderTemplate` is the`DateTime.` The `SelectableDayPredicate,` `MinimumDateTime,` and `MaximumDateTime` properties of date and time values can be used directly in the data template selector.
* When using data template selector, performance issues occur as the conversion template views take time within the framework.

## Time text formatting

The format for the labels mentioning the time can be customized by setting the [TimeFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeFormat) property of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}
{% highlight XAML hl_lines="5" %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="TimelineWeek">
    <scheduler:SfScheduler.TimelineView>
        <scheduler:SchedulerTimelineView 
                        TimeFormat="hh:mm" />
    </scheduler:SfScheduler.TimelineView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight C# hl_lines="3" %}

SfScheduler scheduler = new SfScheduler();
scheduler.View = SchedulerView.TimelineWeek;
scheduler.TimelineView.TimeFormat = "hh:mm";
this.Content = scheduler;

{% endhighlight %}
{% endtabs %}

![change-time-ruler-text-formatting-in-.net-maui-scheduler](images/timeline-views/change-time-ruler-text-formatting-in-.net-maui-scheduler.png)

N>
* By default, the scheduler time text format is `hh:mm tt.`

#### Customize time ruler text style

The text style for the labels mentioning the time can be customized, by setting the [TimeRulerTextStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimeSlotView.html#Syncfusion_Maui_Scheduler_SchedulerTimeSlotView_TimeRulerTextStyle) properties of [TimelineView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html) in the [SfScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/timelineview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}

this.Scheduler.View = SchedulerView.TimelineWeek;
var timeRulerTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.TimelineView.TimeRulerTextStyle = timeRulerTextStyle;

{% endhighlight %}
{% endtabs %}

![customize-time-ruler-text-style-in-maui-scheduler](images/timeline-views/customize-time-ruler-text-style-in-maui-scheduler.png)
