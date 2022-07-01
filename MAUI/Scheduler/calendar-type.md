---
layout: post
title: Calendar type in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Calendar type in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more details.
platform: maui
control: SfScheduler
documentation: ug
---

# Calendar type in .NET MAUI Scheduler (SfScheduler)
The Scheduler control supports different types of calendars such as Gregorian, Korean, Hebrew, and more. Change the calendar types by using the CalendarType property in the SfScheduler.  

<table>
<tr>
<th>Supported Calendars</th>
<th>UnSupported Calendars</th>
</tr>
<tr>

<td>
* GregorianCalendar<br>
* HebrewCalendar<br>
* HijriCalendar<br>
* KoreanCalendar<br>
* TaiwanCalendar<br>
* ThaiCalendar<br>
* UmAlQuraCalendar<br>
* PersianCalendar<br>
* JulianCalendar<br>
* JapaneseCalendar<br>
</td>

<td>
* Gezer Calendar<br>
* Haida Calendar<br>
* Igbo calendar<br>
* Islamic calendar<br>
* Javanese calendar<br>
* Maramataka (Māori lunar calendar)<br>
* Nepal Sambat<br>
* Yoruba calendar<br>
</td>
</tr>
</table>

N>
* The FlowDirection will be updated based on the CalendarType. If you want to override this behavior, set the FlowDirection after CalendarTypeIf calendar is specified other than the Gregorian. All the DateTime values such as Appointment Start and End time, SpecialTimeRegion Start and End time, SelectableDayPredicate, SelectedDate, and DisplayDate can be given in two ways.
* DateTime instance without specifying calendar type. Scheduler will handle the DateTime value for the specified calendar type.
* When a DateTime instance has a calendar type, the Scheduler handles it directly.
* All calendar types are supported except Lunar type calendars.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineMonth" CalendarType="Hijri">
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10" %}
this.Scheduler.CalendarType = CalendarType.Hijri;
{% endhighlight %}
{% endtabs %}

### DateTime values in Calendar Types
All the DateTime values can be given such as [DisplayDate,]() [SelectedDate,]() [BlackoutDates,]() Appointment [StartTime,]() and [EndTime,]() SpecialTimeRegion [StartTime]() and [EndTime]() values in two ways when calendar identifier is specified other than [GregorianCalendar.]()

* Create an appointment with a start and end time value by declaring the calendar type and respective calendar type date.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10" %}
// Creating an instance for the schedule appointment collection.
var appointments = new ObservableCollection<SchedulerAppointment>(); 

// Adding schedule appointment in the schedule appointment collection.
appointments.Add(new SchedulerAppointment()
{
	Subject = "Meeting",
	// StartTime and EndTime value specified with calendar type and respective calendar date.
	StartTime = new DateTime(1443, 02, 22, 10, 0, 0, new HijriCalendar()),
	EndTime = new DateTime(1443, 02, 22, 11, 0, 0, new HijriCalendar()),
});

// Adding the schedule appointment collection to the ItemsSource.
this.Scheduler.AppointmentsSource = appointments;
{% endhighlight %}
{% endtabs %}

* Create an appointment with a start and end time by declaring the local system date; in that case, the system date will be converted to the relevant calendar type date.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9 10" %}
// Creating an instance for the schedule appointment collection.
var appointments = new ObservableCollection<SchedulerAppointment>();

// Adding schedule appointment in the schedule appointment collection.
appointments.Add(new SchedulerAppointment()
{
	Subject = "Meeting",
	//The StartTime and EndTime values specified with the local system date will be converted to the Hijiri calendar mentioned.
	StartTime = new DateTime(2021, 09, 29, 10, 0, 0, 0),
	EndTime = new DateTime(2021, 09, 29, 11, 0, 0, 0),
});

// Adding the schedule appointment collection to the ItemsSource.
this.Scheduler.AppointmentsSource = appointments;
{% endhighlight %}
{% endtabs %}

