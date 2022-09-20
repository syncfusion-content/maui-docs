---
layout: post
title: Reminders in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Reminder support in Syncfusion .NET MAUI Scheduler (SfScheduler) control, its element and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Reminder in .NET MAUI Scheduler (SfScheduler)

The MAUI Scheduler notify an appointment reminder by using  the [EnableReminder] property and [ReminderAlertOpening] event. An appointment can have one or more reminders.

N>
* In .NET MAUI Framework notification implementation is in progress, So as of now added event to notify appointment reminder.

## Enable reminder

Reminder can be enabled by setting the [EnableReminder] property to `true` which will trigger the `ReminderAlertOpening` event to notify appointment reminder. The reminder can be set by using the [Reminders] property of [SchedulerAppointment.]

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="3" %}
<syncfusion:SfScheduler x:Name="Scheduler"
                        View ="Week"
                        EnableReminder="True" >
</syncfusion:SfScheduler>
{% endhighlight %}
{% endtabs %}

## Adding Reminders

Configure the appointment reminders with [SchedulerReminder.] The `SchedulerReminder` has the following properties for reminder alert.

<table>
<tr>
<th>Properties</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[TimeBeforeStart]'| markdownify }}</td>
<td>Gets or sets the time interval that decides to notify the reminder before the appointment’s start time.
</td>
</tr>
<tr>
<td>{{'[AlertTime]'| markdownify }}</td>
<td>Gets the reminder time that decides when to enable `ReminderAlertOpening` event to the reminder of the appointment.</td>
</tr>
<tr>
<td>{{'[Appointment]'| markdownify }}</td>
<td>Gets the appointment details for which the reminder is created.</td>
</tr>
<tr>
<td>{{'[DataItem]'| markdownify }}</td>
<td>Gets the reminder data object associated with the `SchedulerReminder.`</td>
</tr>
<tr>
<td>{{'[IsDismissed]' | markdownify }}</td>
<td> Gets or sets whether the reminder is dismissed. </td>
</tr>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="6" %}
 <syncfusion:SfScheduler x:Name="Schedule" 
                AppointmentsSource="{Binding Events}"
                EnableReminder="True">
        <syncfusion:SfScheduler.BindingContext>
            <local:SchedulerViewModel/>
        </syncfusion:SfScheduler.BindingContext>
  </syncfusion:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="ReminderViewModel.cs" %}
 public class ReminderViewModel 
 {
    ...
    public ObservableCollection<SchedulerAppointment> Events { get; set; } = new ObservableCollection<SchedulerAppointment>();
    this.Events.Add(new ScheduleAppointment()
    {
        StartTime = DateTime.Now,
        EndTime = DateTime.Now.AddHours(1),
        AppointmentBackground = new SolidColorBrush(Color.FromArgb(255, 83, 99, 250)),
        Subject = "Conference",
        Reminders = new ObservableCollection<SchedulerReminder>
        {
            new SchedulerReminder { ReminderTimeInterval = new TimeSpan(0)},
        }
    });
 }
{% endhighlight %}
{% endtabs %}

## Creating business object for reminder

[Reminders] supports to map the custom object with  [SchedulerAppointment.Reminders.]

{% tabs %}
{% highlight c# tabtitle="Event.xaml.cs" %}
/// <summary>
/// Represents custom data properties.
/// </summary>
 public class Event
    {
        public Event()
        {
        }

        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsAllDay { get; set; }
        public string EventName { get; set; }
        public string Notes { get; set; }
        public string StartTimeZone { get; set; }
        public string EndTimeZone { get; set; }
        public Brush Color { get; set; }
        public object RecurrenceId { get; set; }
        public object Id { get; set; }
        public string RecurrenceRule { get; set; }
        public ObservableCollection<DateTime> RecurrenceExceptions { get; set; }
        public ObservableCollection<Reminder> Reminders { get; set; }
    }
{% endhighlight %}
{% endtabs %}

The [ReminderMapping] provides the mapping information about the [SchedulerReminder] properties to the [DataItem] object. `ReminderMapping` has the following properties.

* [TimeBeforeStart]: Maps the property name of a custom class, which is equivalent for the [SchedulerReminder.ReminderTimeInterval.]

* [IsDismissed]: Maps the property name of a custom class, which is equivalent for the [SchedulerReminder.IsDismissed.]

{% tabs %}
{% highlight c# tabtitle="Reminder.cs" %}
/// <summary>
/// Represents custom data properties.
/// </summary>
public class Reminder
{
    /// <summary>
    /// Gets or sets a value that decides to notify the reminder before the appointment’s start time.
    /// </summary>
    public TimeSpan TimeBeforeStart { get; set; }
    
    /// <summary>
    /// Gets or sets the value indicating whether the reminder is dismissed or not. 
    /// </summary>
    public bool Dismissed { get; set; }

}

{% endhighlight %}
{% endtabs %}

Map those properties of the `Event` class with the [SfScheduler] control by using the [AppointmentMapping] and map `CustomReminder` properties with the [SchedulerReminder] by using [ReminderMapping.]

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="3 17 18 19 20" %}
  <syncfusion:SfScheduler x:Name="Schedule" 
                AppointmentsSource="{Binding Events}"
                EnableReminder="True">
        <syncfusion:SfScheduler.BindingContext>
            <local:SchedulerViewModel/>
        </syncfusion:SfScheduler.BindingContext>
        <syncfusion:SfScheduler.AppointmentMapping>
            <syncfusion:SchedulerAppointmentMapping
                    Subject="EventName"
                    StartTime="From"
                    EndTime="To"
                    Background="Color"
                    IsAllDay="IsAllDay"
                    StartTimeZone="StartTimeZone"
                    EndTimeZone="EndTimeZone"
                    RecurrenceExceptionDates="RecurrenceExceptions"
                    RecurrenceRule="RecurrenceRule"
                    RecurrenceId="RecurrenceId"
                    Reminders="Reminders">
                <syncfusion:SchedulerAppointmentMapping.ReminderMapping>
                    <syncfusion:SchedulerReminderMapping IsDismissed="IsDismissed"
                    TimeBeforeStart="TimeBeforeStart"/>
                </syncfusion:SchedulerAppointmentMapping.ReminderMapping>
            </syncfusion:SchedulerAppointmentMapping>
        </syncfusion:SfScheduler.AppointmentMapping>
    </syncfusion:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="ReminderViewModel.cs" %}
public class ReminderViewModel 
{
  ...
   public ObservableCollection<Event> Events { get; set; } = new ObservableCollection<Event>();
  this.Events.Add(new Event()
  {
    From = DateTime.Now,
    To = DateTime.Now.AddHours(1),
    Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF339933")),
    EventName = "Conference",
    Reminders = new ObservableCollection<Reminder>
    {
        new Reminder { TimeBeforeStart = new TimeSpan(0)},
    }
    });
}
{% endhighlight %}
{% endtabs %}

## ReminderAlertOpening event
Scheduler notify the appointment's reminder by [ReminderAlertOpening] event before the appointment's start time. The [ReminderAlertOpeningEventArgs] has the following property,
* [Reminders]: Gets a list of reminders that are used to notify the appointment reminders.

{% tabs %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="1" %}
scheduler.ReminderAlertOpening += Scheduler_ReminderAlertOpening;

private void Scheduler_ReminderAlertOpening(object sender, ReminderAlertOpeningEventArgs e)
{
    var reminders = e.Reminders;
    e.Reminders[0].IsDismissed = true;
}
{% endhighlight %}
{% endtabs %}
## Handle Dismissed for reminder

* Normal appointment directly dismissed using [IsDismissed] property

* For recurrence appointment, if current occurrence need to dismiss then need to add changed occurrence for reminder occurrence dismissed, then current occurrence dismissed details get updated in underlying appointment or data source.

* If only occurrence dismissed, then the changed icon will not be updated for dismissed changed occurrence

## Handle Snooze for reminder
If Snooze time is set to 5 minutes than the value of reminder [TimeBeforeStart] property is calculated by 

* For future appointments, TimeBeforeStart = Appointment.StartTime - AlertTime - snoozeTime

* For Overdue appointments, TimeBeforeStart = Appointment.StartTime.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime

* For All day appointment, TimeBeforeStart = Appointment.StartTime.Date.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime

## Handling reminders for future appointment

* Future normal and recurring appointment reminder alert will be displayed as Reminder alert time.

* Reminder alert time will be calculated form appointment start time substrate with reminder time interval. For an example if appointment time is 3.30pm and reminder time interval is new Timespan (0,15,0) then reminder alter time is 3.15 pm.

* If the Reminder alert time is less than the current time, then appointment reminder time will be calculated from the current time. For an example if current time is 3.30pm and the Reminder alert time is 3.40pm, than alert time will be displayed as 10 minutes.

## Handling reminders for overdue appointment

* If a Non-recurring appointments reminder is in past, reminder alert as overdue untill dismissed.

* Recurring appointment overdue after recurrence end until dismissed and past occurrences do not have reminders.

* Recurrence appointment due calculated from current date occurrence and its in due until next occurrence reminder time.

*  If the last occurrence in recurrence is series is get dismissed, then the pattern recurring appointment dismissed.

## Handling reminder for Changed occurrence appointment

* Once the changed occurrence is moved to the future, its reminder is re-created from the pattern.

* When the changed occurrence is restored to a time in the past, the reminder is deleted. 

* Past Changed occurrence reminders will be dismissed.
