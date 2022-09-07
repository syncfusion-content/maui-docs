---
layout: post
title: Reminders in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Reminder support in Syncfusion .NET MAUI Scheduler (SfScheduler) control, its element and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Reminder in .NET MAUI Scheduler (SfScheduler)

The MAUI Scheduler notify an appointment reminder by using  the [ReminderAlertOpening] event. An appointment can have one or more reminders.

## Enable reminder

Reminder can be enabled by setting the [EnableReminder] property to `true` which will trigger the `ReminderAlertOpening` event to notify appointment reminder. The reminder can be set by using the [Reminders] property of [SchedulerAppointment.]

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="3" %}
<syncfusion:SfScheduler x:Name="Scheduler"
                        ViewType="Week"
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
 <Grid.DataContext>
    <local:ReminderViewModel/>
 </Grid.DataContext>
 <syncfusion:SfScheduler x:Name="Schedule" 
                ItemsSource="{Binding Events}"
                EnableReminder="True">
  </syncfusion:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="ReminderViewModel.cs" %}
 public class ReminderViewModel 
 {
    ...
    public ScheduleAppointmentCollection Events { get; set; } = new ScheduleAppointmentCollection();
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
                ItemsSource="{Binding Events}"
                EnableReminder="True">
            <syncfusion:SfScheduler.AppointmentMapping>
                <syncfusion:AppointmentMapping
                    Subject="EventName"
                    StartTime="From"
                    EndTime="To"
                    AppointmentBackground="Color"
                    IsAllDay="IsAllDay"
                    StartTimeZone="StartTimeZone"
                    EndTimeZone="EndTimeZone"
                    RecurrenceExceptionDates="RecurrenceExceptions"
                    RecurrenceRule="RecurrenceRule"
                    RecurrenceId="RecurrenceId"
                    Reminders="Reminders">
                    <syncfusion:AppointmentMapping.ReminderMapping>
                        <syncfusion:ReminderMapping IsDismissed="Dismissed"
                                                    TimeBeforeStart="TimeBeforeStart"/>
                    </syncfusion:AppointmentMapping.ReminderMapping>
                </syncfusion:AppointmentMapping>
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
