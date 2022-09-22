---
layout: post
title: Appointments Reminders in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the appointments reminders support in Syncfusion .NET MAUI Scheduler (SfScheduler) appointments.
platform: maui
control: SfScheduler
documentation: ug
---

# Appointments reminders in .NET MAUI Scheduler (SfScheduler)

The MAUI Scheduler notify an appointment reminders by using  the [EnableReminder] property and [ReminderAlertOpening] event. An appointment can have one or more reminders.

N>
* As restriction in enabling toast notification in .NET MAUI Framework, as of now added event to notify appointment reminder.[Reference](https://github.com/dotnet/maui/discussions/4216)

## Handling reminders for future appointment

* Future normal and recurring appointment reminder alert will be displayed as Reminder alert time.

* Reminder alert time will be calculated form appointment start time substrate with reminder time interval. For an example if appointment time is 3.30pm and reminder time interval is new Timespan (0,15,0) then reminder alter time is 3.15 pm.

## Handling reminders for overdue appointment

* If a Non-recurring appointments reminder is in past, reminder alert as overdue untill dismissed.

* Recurring appointment overdue after recurrence end until dismissed and past occurrences do not have reminders.

* Recurrence appointment due calculated from current date occurrence and its in due until next occurrence reminder time.

*  If the last occurrence in recurrence is series is get dismissed, then the pattern recurring appointment dismissed.

## Handling reminders for Changed occurrence appointment

* Once the changed occurrence is moved to the future, its reminder is re-created from the pattern.

* When the changed occurrence is restored to a time in the past, the reminder is deleted. 

* Past Changed occurrence reminders will be dismissed.

## Enable reminders

Reminders can be enabled by setting the [EnableReminder] property to `true` which will trigger the `ReminderAlertOpening` event to notify appointment reminders. The reminders can be set by using the [Reminders] property of [SchedulerAppointment.]

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<syncfusion:SfScheduler x:Name="Scheduler"
                        View ="Week"
                        EnableReminder="True" >
</syncfusion:SfScheduler>
{% endhighlight %}
{% endtabs %}

## Adding Reminders

Configure the appointment reminders with [SchedulerReminder.] The `SchedulerReminder` has the following properties for reminder alert.

<table>
<tr><th>Properties</th><th>Description</th></tr>
<tr><td>{{'[TimeBeforeStart]'| markdownify }}</td>
<td>Gets or sets the time interval that decides to notify the reminder before the appointment’s start time.
</td></tr>
<tr><td>{{'[AlertTime]'| markdownify }}</td>
<td>Gets the reminder time that decides when to enable `ReminderAlertOpening` event to the reminder of the appointment.</td></tr>
<tr><td>{{'[Appointment]'| markdownify }}</td>
<td>Gets the appointment details for which the reminder is created.</td></tr>
<tr><td>{{'[DataItem]'| markdownify }}</td>
<td>Gets the reminder data object associated with the `SchedulerReminder.`</td></tr>
<tr><td>{{'[IsDismissed]' | markdownify }}</td>
<td> Gets or sets whether the reminder is dismissed. </td></tr>
</table>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}
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
        // Normal Appointment
        SchedulerAppointment normalAppointment = new SchedulerAppointment()
        {
            StartTime = DateTime.Now.AddMinutes(5),
            EndTime = DateTime.Now.AddHours(1),
            Subject = "Normal Appointment",
            Background = Brush.SkyBlue,
            Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder {TimeBeforeStart = new TimeSpan (0,4,0)},
            }

        };
        Events.Add(normalAppointment);

        // All Day Appointment
        SchedulerAppointment allDayAppointment = new SchedulerAppointment()
        {
            StartTime = DateTime.Now.AddDays(1).AddMinutes(1),
            EndTime = DateTime.Now.AddDays(1).AddHours(1),
            Subject = "All Day Appointment",
            Background = Brush.SkyBlue,
            IsAllDay = true,
            Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder {TimeBeforeStart = new TimeSpan (0,0,50)},
            }

        };
        Events.Add(allDayAppointment);

        // Recurrence Appointment
        SchedulerAppointment recurrenceAppointment = new SchedulerAppointment()
        {
            Id = 1,
            StartTime = DateTime.Now.AddDays(2).AddMinutes(1),
            EndTime = DateTime.Now.AddDays(2).AddHours(1),
            Subject = "Recurrence Appointment",
            Background = Brush.LightGray,
            RecurrenceRule = "FREQ=DAILY;COUNT=3",
            Reminders = new ObservableCollection<SchedulerReminder>
            {
                new SchedulerReminder {TimeBeforeStart = new TimeSpan (0,0,40)},
            }

        };
        Events.Add(recurrenceAppointment);
 }
{% endhighlight %}
{% endtabs %}

## Creating business object for reminders

Create a business object class `Event` with mandatory fields `From,` `To,` and `EventName.` and also business object class `Reminder` with mandatory fields `TimeBeforeStart` and `IsDismissed`.

{% tabs %}
{% highlight c# tabtitle="Event.cs" %}
/// <summary>
/// Represents custom data properties.
/// </summary>
 public class Event
    {
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

* [TimeBeforeStart]: Maps the property name of a custom class, which is equivalent for the [SchedulerReminder.TimeBeforeStart.]

* [IsDismissed]: Maps the property name of a custom class, which is equivalent for the [SchedulerReminder.IsDismissed.]

{% tabs %}
{% highlight c# tabtitle="Reminder.cs" %}
/// <summary>
/// Represents custom reminder properties.
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
    public bool IsDismissed { get; set; }

}

{% endhighlight %}
{% endtabs %}

Map those properties of the `Event` class with the [SfScheduler] control by using the [AppointmentMapping] and map `CustomReminder` properties with the [SchedulerReminder] by using [ReminderMapping.]

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 17 18 19 20" %}
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
                    RecurrenceExceptionDates="RecurrenceExceptionDates"
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

   // Normal Appointment
    Event normalAppointment = new Event()
    {
        From = DateTime.Now.AddMinutes(5),
        To = DateTime.Now.AddHours(1),
        EventName = "Normal Appointment",
        Color = Brush.SkyBlue,
        Reminders = new ObservableCollection<Reminder>
        {
            new Reminder {TimeBeforeStart = new TimeSpan (0,4,0)},
        }

    };
    Events.Add(normalAppointment);

    // All Day Appointment
    Event allDayAppointment = new Event()
    {
        From = DateTime.Now.AddDays(1).AddMinutes(1),
        To = DateTime.Now.AddDays(1).AddHours(1),
        EventName = "All Day Appointment",
        Color = Brush.SkyBlue,
        IsAllDay = true,
        Reminders = new ObservableCollection<Reminder>
        {
            new Reminder {TimeBeforeStart = new TimeSpan (0,0,50)},
        }

    };
    Events.Add(allDayAppointment);

    // Recurrence Appointment
    Event recurrenceAppointment = new Event()
    {
        Id = 1,
        From = DateTime.Now.AddDays(2).AddMinutes(1),
        To = DateTime.Now.AddDays(2).AddHours(1),
        EventName = "Recurrence Appointment",
        Color = Brush.LightGray,
        RecurrenceRule = "FREQ=DAILY;COUNT=3",
        Reminders = new ObservableCollection<Reminder>
        {
            new Reminder {TimeBeforeStart = new TimeSpan (0,0,40)},
        }

    };
    Events.Add(recurrenceAppointment);
}
{% endhighlight %}
{% endtabs %}

## ReminderAlertOpening event
Scheduler notify the appointment's reminders by [ReminderAlertOpening] event before the appointment's start time. The [ReminderAlertOpeningEventArgs] has the following property,
* [Reminders]: Gets a list of reminders that are used to notify the appointment reminders.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
scheduler.ReminderAlertOpening += Scheduler_ReminderAlertOpening;

private void Scheduler_ReminderAlertOpening(object sender, ReminderAlertOpeningEventArgs e)
{
    bool snooze = await DisplayAlert("Reminder", Reminders[0].Appointment.Subject + " - " + Reminders[0].Appointment.StartTime.ToString(" dddd, MMMM dd, yyyy, hh:mm tt"), "Snooze", "Dismiss"); 
}
{% endhighlight %}
{% endtabs %}
## Handle Dismissed for reminders

* Normal appointment directly dismissed using [IsDismissed] property

* For recurrence appointment, if current occurrence need to dismiss then need to add changed occurrence for reminder occurrence dismissed, then current occurrence dismissed details get updated in underlying appointment or data source.

* If only occurrence dismissed, then the changed icon will not be updated for dismissed changed occurrence

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
scheduler.ReminderAlertOpening += Scheduler_ReminderAlertOpening;

private void Scheduler_ReminderAlertOpening(object sender, ReminderAlertOpeningEventArgs e)
{
    bool snooze = await DisplayAlert("Reminder", Reminders[0].Appointment.Subject + " - " + Reminders[0].Appointment.StartTime.ToString(" dddd, MMMM dd, yyyy, hh:mm tt"), "Snooze", "Dismiss");
    if (Dismiss)
    {
        // For Recurrence appointment, if current occurrence need to dismiss then need to add changed occurrence for reminder occurrence dismissed
        if (!string.IsNullOrEmpty(e.Reminders[0].Appointment.RecurrenceRule))
        {
            ObservableCollection<SchedulerAppointment> appointments = scheduler.AppointmentsSource as ObservableCollection<SchedulerAppointment>;
            SchedulerAppointment patternAppointment = appointments.FirstOrDefault(x => x.Id == e.Reminders[0].Appointment.Id);
            DateTime changedExceptionDate = e.Reminders[0].Appointment.StartTime;
            DateTime endDate = e.Reminders[0].Appointment.EndTime;
            patternAppointment.RecurrenceExceptionDates = new ObservableCollection<DateTime>()
                {
                    changedExceptionDate,
                };
            // Clone parent details
            SchedulerAppointment exceptionAppointment = new SchedulerAppointment()
            {
                Id = 2,
                Subject = patternAppointment.Subject,
                StartTime = new DateTime(changedExceptionDate.Year, changedExceptionDate.Month, changedExceptionDate.Day, changedExceptionDate.Hour, 0, 0),
                EndTime = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, 0, 0),
                Background = patternAppointment.Background,
                RecurrenceId = 1,
                Reminders = patternAppointment.Reminders,
            };
            if (!appointments.Contains(exceptionAppointment))
            {
                exceptionAppointment.Reminders[0].IsDismissed = true;
                appointments.Add(exceptionAppointment);

            }
        }
        // To dismiss normal reminder
        else
        {
            for (int i = e.Reminders.Count - 1; i >= 0; i--)
            {
                e.Reminders[i].IsDismissed = true;
            }
        }
    }    

}
{% endhighlight %}
{% endtabs %}

## Handle Snooze for reminders
If Snooze time is set to 5 minutes than the value of reminder [TimeBeforeStart] property is calculated by 

* For Future appointments, TimeBeforeStart = Appointment.StartTime - AlertTime - snoozeTime

* For Overdue appointments, TimeBeforeStart = Appointment.StartTime.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime

* For All day appointment, TimeBeforeStart = Appointment.StartTime.Date.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}
scheduler.ReminderAlertOpening += Scheduler_ReminderAlertOpening;

private void Scheduler_ReminderAlertOpening(object sender, ReminderAlertOpeningEventArgs e)
{
    bool snooze = await DisplayAlert("Reminder", Reminders[0].Appointment.Subject + " - " + Reminders[0].Appointment.StartTime.ToString(" dddd, MMMM dd, yyyy, hh:mm tt"), "Snooze", "Dismiss");

    if (snooze)
        {
            TimeSpan snoozeTime = new TimeSpan(0, 5, 0);
            // Future appointment reminder
            if (e.Reminders[0].Appointment.ActualStartTime > DateTime.Now && !e.Reminders[0].Appointment.IsAllDay)
            {
                e.Reminders[0].TimeBeforeStart = e.Reminders[0].Appointment.StartTime - e.Reminders[0].AlertTime - snoozeTime;
            }
            // Allday appointment reminder
            else if (e.Reminders[0].Appointment.IsAllDay)
            {
                e.Reminders[0].TimeBeforeStart = e.Reminders[0].Appointment.StartTime.Date.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime;
            }
            // Overdue appointment reminder
            else
            {
                e.Reminders[0].TimeBeforeStart = e.Reminders[0].Appointment.StartTime.AddSeconds(DateTime.Now.Second) - DateTime.Now - snoozeTime;
            }
           
            if (!string.IsNullOrEmpty(e.Reminders[0].Appointment.RecurrenceRule))
            {
                ObservableCollection<SchedulerAppointment> appointments = scheduler.AppointmentsSource as ObservableCollection<SchedulerAppointment>;
                SchedulerAppointment patternAppointment = appointments.FirstOrDefault(x => x.Id == e.Reminders[0].Appointment.Id);
                DateTime changedExceptionDate = e.Reminders[0].Appointment.StartTime;
                DateTime endDate = e.Reminders[0].Appointment.EndTime;
                patternAppointment.RecurrenceExceptionDates = new ObservableCollection<DateTime>()
                    {
                        changedExceptionDate,
                    };
                // Clone parent details
                SchedulerAppointment exceptionAppointment = new SchedulerAppointment()
                {
                    Id = 2,
                    Subject = patternAppointment.Subject,
                    StartTime = new DateTime(changedExceptionDate.Year, changedExceptionDate.Month, changedExceptionDate.Day, changedExceptionDate.Hour, 0, 0),
                    EndTime = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, 0, 0),
                    Background = patternAppointment.Background,
                    RecurrenceId = 1,
                    Reminders = new ObservableCollection<SchedulerReminder> { new SchedulerReminder { TimeBeforeStart = e.Reminders[0].TimeBeforeStart } },
                };
                if (!appointments.Contains(exceptionAppointment))
                {
                    appointments.Add(exceptionAppointment);
                }
            }          
        }
}
{% endhighlight %}
{% endtabs %}

