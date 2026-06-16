---
layout: post
title: Time Zone in .NET MAUI Scheduler control | Syncfusion<sup>&reg;</sup>
description: Learn here all about Time Zone support in Syncfusion<sup>&reg;</sup> MAUI Scheduler (SfScheduler) control, it's elements and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Time zone in .NET MAUI Scheduler (SfScheduler)

The [.NET MAUI Scheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html) allows to create appointments in various time zones and display them in the respective time zone or any other time zone. Use the time zone in the following four different ways:

* Create appointments in different time zone.
* Display appointments based on the client’s time zone.
* Display appointments based on scheduler time zone.
* Display appointments at the same time everywhere regardless of client’s time zone.

The following Time Zone's of the respective countries are added to cover all the time zone regions. Use any of the time zones from the following list for scheduler time zone.
<table>
<tr>
<th>Region</th>
<th>UTC Offset</th>
</tr>
<tr>
<td>
Pacific/Apia
</td>
<td>
UTC - 13:00
</td>
</tr>
<tr>
<td>
Etc/GMT+12
</td>
<td>
UTC - 12:00
</td>
</tr>
<tr>
<td>
Pacific/Midway
</td>
<td>
UTC - 11:00
</td>
</tr>
<tr>
<td>
Pacific/Honolulu
</td>
<td>
UTC - 10:00
</td>
</tr>
<tr>
<td>
America/Anchorage
</td>
<td>
UTC - 09:00
</td>
</tr>
<tr>
<td>
America/Los_Angeles
</td>
<td>
UTC - 08:00
</td>
</tr>
<tr>
<td>
America/Santa_Isabel
</td>
<td>
UTC - 08:00
</td>
</tr>
<tr>
<td>
America/Denver
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
America/Chihuahua
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
America/Phoenix
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
America/Regina
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
America/Guatemala
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
America/Chicago
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
America/New_York
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
America/Bogota
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
America/Indianapolis
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
America/Caracas
</td>
<td>
UTC - 04:30
</td>
</tr>
<tr>
<td>
America/Halifax
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
America/Cuiaba
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
America/Santiago
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
America/Asuncion
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
America/La_Paz
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
America/St_Johns
</td>
<td>
UTC - 03:30
</td>
</tr>
<tr>
<td>
America/Bahia
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Buenos_Aires
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Sao_Paulo
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Godthab
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Montevideo
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Cayenne
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
America/Noronha
</td>
<td>
UTC - 02:00
</td>
</tr>
<tr>
<td>
Atlantic/Azores
</td>
<td>
UTC - 01:00
</td>
</tr>
<tr>
<td>
Atlantic/Cape_Verde
</td>
<td>
UTC - 01:00
</td>
</tr>
<tr>
<td>
Europe/London
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Atlantic/Reykjavik
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Africa/Casablanca
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
America/Danmarkshavn
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Europe/Budapest
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Europe/Warsaw
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Africa/Windhoek
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Europe/Paris
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Africa/Lagos
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Europe/Berlin
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<tr>
<td>
Africa/Cairo
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Europe/Kiev
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Europe/Bucharest
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Asia/Jerusalem
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Africa/Tripoli
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Asia/Beirut
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Africa/Johannesburg
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Asia/Damascus
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Europe/Istanbul
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Asia/Riyadh
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Asia/Baghdad
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Europe/Minsk
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Africa/Nairobi
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Asia/Amman
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Europe/Kaliningrad
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Asia/Tehran
</td>
<td>
UTC + 03:30
</td>
</tr>
<tr>
<td>
Etc/GMT-4
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Asia/Baku
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Asia/Yerevan
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Asia/Tbilisi
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Indian/Mauritius
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Europe/Samara
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Europe/Moscow
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Asia/Kabul
</td>
<td>
UTC + 04:30
</td>
</tr>
<tr>
<td>
Asia/Karachi
</td>
<td>
UTC + 05:00
</td>
</tr>
<td>
Asia/Tashkent
</td>
<td>
UTC + 05:00
</td>
</tr>
<tr>
<td>
Asia/Calcutta
</td>
<td>
UTC + 05:30
</td>
</tr>
<tr>
<td>
Asia/Colombo
</td>
<td>
UTC + 05:30
</td>
</tr>
<tr>
<td>
Asia/Kathmandu
</td>
<td>
UTC + 05:45
</td>
</tr>
<tr>
<td>
Asia/Dhaka
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Asia/Almaty
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Asia/Yekaterinburg
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Asia/Rangoon
</td>
<td>
UTC + 06:30
</td>
</tr>
<tr>
<td>
Asia/Bangkok
</td>
<td>
UTC + 07:00
</td>
</tr>
<tr>
<td>
Asia/Novosibirsk
</td>
<td>
UTC + 07:00
</td>
</tr>
<tr>
<td>
Asia/Shanghai
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Asia/Krasnoyarsk
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Asia/Singapore
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Asia/Taipei
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Asia/Ulaanbaatar
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Australia/Perth
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Asia/Seoul
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
Asia/Irkutsk
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
Asia/Tokyo
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
Australia/Darwin
</td>
<td>
UTC + 09:30
</td>
</tr>
<tr>
<td>
Australia/Adelaide
</td>
<td>
UTC + 09:30
</td>
</tr>
<tr>
<td>
Australia/Sydney
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Australia/Brisbane
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Australia/Hobart
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Pacific/Port Moresby
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Asia/Yakutsk
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Pacific/Guadalcanal
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Asia/Srednekolymsk
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Asia/Vladivostok
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Pacific/Fiji
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Asia/Magadan
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Pacific/Auckland
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Asia/Kamchatka
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Pacific/Tarawa
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Pacific/Tongatapu
</td>
<td>
UTC + 13:00
</td>
</tr>
<tr>
<td>
Pacific/Kiritimati
</td>
<td>
UTC + 14:00
</td>
</tr>
</table>

## Create appointments in different time zone

Create appointments at different time zones using the [StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_StartTimeZone) and [EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_EndTimeZone) properties of [SchedulerAppointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html). An appointment’s start time and end time are calculated based on the given time zone information for the start time and end time. Set different time zones to the `StartTimeZone` and `EndTimeZone` properties.

Use the [StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime) and [EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime) properties of `SchedulerAppointment` to get the exact start time and end time of an appointment. By using the [ActualStartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualStartTime) and [ActualEndTime](Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualEndTime) properties, get the exact appointment rendering time.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<scheduler:SfScheduler x:Name="scheduler" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7 8 11" %}

var appointments = new ObservableCollection<SchedulerAppointment>();
appointments.Add(new SchedulerAppointment()
{
    Subject = "Meeting",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1),
    StartTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata"),
    EndTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata")
});	

this.scheduler.AppointmentsSource = appointments;

{% endhighlight %}
{% endtabs %}

>**NOTE**
* If the recurring appointment is converted to another time zone, then the whole sequence will be recalculated according to the new time zone information.
* If an all-day appointment is created, it's start time and end time will be set to 12 A.M. by default, so time zone is not applicable for all-day appointments.
* Scheduler supports daylight saving time.
* The time zone support is applicable for custom appointments too, so map the corresponding property.
* Use [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimeZone) for custom appointments by mapping the [StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_StartTimeZone) and [EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_EndTimeZone) custom properties of [AppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html).

## Display appointments based on client’s  time zone

Display the appointments based on the client’s local time zone in scheduler. For example, consider a scenario that you are in North Carolina and you want to set up a meeting at 10 A.M. on North Carolina time. You have colleagues in London and Chennai, and they also need to participate. The time for this meeting will be 3 P.M. (15:00) in London and 5.30 A.M. in Chennai. When each view your Scheduler, you need to see the appointment displayed relative to your local time zones 5.30 A.M., 10 A.M., and 3 P.M., respectively. It can be achieved by setting schedule time zone to default (it will consider your device’s local time zone as schedule time zone) and appointment’s time zone to `North Carolina` region [as you are in North Carolina and it's time zone is Eastern Standard Time].

## Display appointments based on scheduler time zone

Set the specific time zone to schedule using the [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimeZone) property of scheduler. On this scenario, the appointments will be displayed in UTC time when the `StartTimeZone` and `EndTimeZone` properties of `SchedulerAppointment` are set to null. The appointments will be displayed in UTC time based on the given scheduler time zone.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<scheduler:SfScheduler x:Name="scheduler" 
                       TimeZone="{Binding SchedulerTimeZoneInfo}">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# tabtitle="SchedulerViewModel.cs" hl_lines="5"%}

public class SchedulerViewModel
{
    public SchedulerViewModel()
    {
        this.SchedulerTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Australia/Brisbane");
    }

    public TimeZoneInfo SchedulerTimeZoneInfo { get; set; }
}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

this.scheduler.TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Australia/Brisbane");

{% endhighlight %}
{% endtabs %}