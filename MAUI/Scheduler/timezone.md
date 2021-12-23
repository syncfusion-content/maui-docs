---

layout: post
title: Time Zone in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Time Zone support in Syncfusion MAUI Scheduler (SfScheduler) control, it's elements and more.
platform: maui
control: SfScheduler
documentation: ug

---

# Time Zone in MAUI Scheduler (SfScheduler)
[MAUI Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler) allows to create appointments in various time zones and display them in the respective time zone or any other time zone. Use the time zone in the following four different ways:
* Create appointments in different time zones.
* Display appointments based on the client’s time zone.
* Display appointments based on scheduler time zone.
* Display appointments at the same time everywhere regardless of client’s time zone.

The following Time Zone's respective countries are added to cover all the time zone regions. Use any of the time zones from the following list for scheduler time zone.
<table>
<tr>
<th>Time Zone</th>
<th>Region</th>
<th>UTC Offset</th>
</tr>
<tr>
<td>
Samoa Standard Time
</td>
<td>
Pacific/Apia
</td>
<td>
UTC - 13:00
</td>
</tr>
<tr>
<td>
Dateline Standard Time
</td>
<td>
Etc/GMT+12
</td>
<td>
UTC - 12:00
</td>
</tr>
<tr>
<td>
UTC-11
</td>
<td>
Pacific/Midway
</td>
<td>
UTC - 11:00
</td>
</tr>
<tr>
<td>
Hawaiian Standard Time
</td>
<td>
Pacific/Honolulu
</td>
<td>
UTC - 10:00
</td>
</tr>
<tr>
<td>
Alaskan Standard Time
</td>
<td>
America/Anchorage
</td>
<td>
UTC - 09:00
</td>
</tr>
<tr>
<td>
Pacific Standard Time
</td>
<td>
America/Los_Angeles
</td>
<td>
UTC - 08:00
</td>
</tr>
<tr>
<td>
Pacific Standard Time (Mexico)
</td>
<td>
America/Santa_Isabel
</td>
<td>
UTC - 08:00
</td>
</tr>
<tr>
<td>
Mountain Standard Time
</td>
<td>
America/Denver
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
Mountain Standard Time (Mexico)
</td>
<td>
America/Chihuahua
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
US Mountain Standard Time
</td>
<td>
America/Phoenix
</td>
<td>
UTC - 07:00
</td>
</tr>
<tr>
<td>
Canada Central Standard Time
</td>
<td>
America/Regina
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
Central America Standard Time
</td>
<td>
America/Guatemala
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
Central Standard Time
</td>
<td>
America/Chicago
</td>
<td>
UTC - 06:00
</td>
</tr>
<tr>
<td>
Eastern Standard Time
</td>
<td>
America/New_York
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
SA Pacific Standard Time
</td>
<td>
America/Bogota
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
US Eastern Standard Time
</td>
<td>
America/Indianapolis
</td>
<td>
UTC - 05:00
</td>
</tr>
<tr>
<td>
Venezuela Standard Time
</td>
<td>
America/Caracas
</td>
<td>
UTC - 04:30
</td>
</tr>
<tr>
<td>
Atlantic Standard Time
</td>
<td>
America/Halifax
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
Central Brazilian Standard Time
</td>
<td>
America/Cuiaba
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
Pacific SA Standard Time
</td>
<td>
America/Santiago
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
Paraguay Standard Time
</td>
<td>
America/Asuncion
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
SA Western Standard Time
</td>
<td>
America/La_Paz
</td>
<td>
UTC - 04:00
</td>
</tr>
<tr>
<td>
Newfoundland Standard Time
</td>
<td>
America/St_Johns
</td>
<td>
UTC - 03:30
</td>
</tr>
<tr>
<td>
Bahia Standard Time
</td>
<td>
America/Bahia
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
Argentina Standard Time
</td>
<td>
America/Buenos_Aires
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
E. South America Standard Time
</td>
<td>
America/Sao_Paulo
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
Greenland Standard Time
</td>
<td>
America/Godthab
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
Montevideo Standard Time
</td>
<td>
America/Montevideo
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
SA Eastern Standard Time
</td>
<td>
America/Cayenne
</td>
<td>
UTC - 03:00
</td>
</tr>
<tr>
<td>
UTC-02
</td>
<td>
America/Noronha
</td>
<td>
UTC - 02:00
</td>
</tr>
<tr>
<td>
Azores Standard Time
</td>
<td>
Atlantic/Azores
</td>
<td>
UTC - 01:00
</td>
</tr>
<tr>
<td>
Cape Verde Standard Time
</td>
<td>
Atlantic/Cape_Verde
</td>
<td>
UTC - 01:00
</td>
</tr>
<tr>
<td>
GMT Standard Time
</td>
<td>
Europe/London
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Greenwich Standard Time
</td>
<td>
Atlantic/Reykjavik
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Morocco Standard Time
</td>
<td>
Africa/Casablanca
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
UTC
</td>
<td>
America/Danmarkshavn
</td>
<td>
UTC
</td>
</tr>
<tr>
<td>
Central Europe Standard Time
</td>
<td>
Europe/Budapest
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Central European Standard Time
</td>
<td>
Europe/Warsaw
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Namibia Standard Time
</td>
<td>
Africa/Windhoek
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
Romance Standard Time
</td>
<td>
Europe/Paris
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
W. Central Africa Standard Time
</td>
<td>
Africa/Lagos
</td>
<td>
UTC + 01:00
</td>
</tr>
<tr>
<td>
W. Europe Standard Time
</td>
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
Egypt Standard Time
</td>
<td>
Africa/Cairo
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
FLE Standard Time
</td>
<td>
Europe/Kiev
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
GTB Standard Time
</td>
<td>
Europe/Bucharest
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Israel Standard Time
</td>
<td>
Asia/Jerusalem
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Libya Standard Time
</td>
<td>
Africa/Tripoli
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Middle East Standard Time
</td>
<td>
Asia/Beirut
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
South Africa Standard Time
</td>
<td>
Africa/Johannesburg
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Syria Standard Time
</td>
<td>
Asia/Damascus
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Turkey Standard Time
</td>
<td>
Europe/Istanbul
</td>
<td>
UTC + 02:00
</td>
</tr>
<tr>
<td>
Arab Standard Time
</td>
<td>
Asia/Riyadh
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Arabic Standard Time
</td>
<td>
Asia/Baghdad
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Belarus Standard Time
</td>
<td>
Europe/Minsk
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
E. Africa Standard Time
</td>
<td>
Africa/Nairobi
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Jordan Standard Time
</td>
<td>
Asia/Amman
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Kaliningrad Standard Time
</td>
<td>
Europe/Kaliningrad
</td>
<td>
UTC + 03:00
</td>
</tr>
<tr>
<td>
Iran Standard Time
</td>
<td>
Asia/Tehran
</td>
<td>
UTC + 03:30
</td>
</tr>
<tr>
<td>
Arabian Standard Time
</td>
<td>
Etc/GMT-4
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Azerbaijan Standard Time
</td>
<td>
Asia/Baku
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Caucasus Standard Time
</td>
<td>
Asia/Yerevan
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Georgian Standard Time
</td>
<td>
Asia/Tbilisi
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Mauritius Standard Time
</td>
<td>
Indian/Mauritius
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Russia Time Zone 3
</td>
<td>
Europe/Samara
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Russian Standard Time
</td>
<td>
Europe/Moscow
</td>
<td>
UTC + 04:00
</td>
</tr>
<tr>
<td>
Afghanistan Standard Time
</td>
<td>
Asia/Kabul
</td>
<td>
UTC + 04:30
</td>
</tr>
<tr>
<td>
Pakistan Standard Time
</td>
<td>
Asia/Karachi
</td>
<td>
UTC + 05:00
</td>
</tr>
<td>
West Asia Standard Time
</td>
<td>
Asia/Tashkent
</td>
<td>
UTC + 05:00
</td>
</tr>
<tr>
<td>
India Standard Time
</td>
<td>
Asia/Calcutta
</td>
<td>
UTC + 05:30
</td>
</tr>
<tr>
<td>
Sri Lanka Standard Time
</td>
<td>
Asia/Colombo
</td>
<td>
UTC + 05:30
</td>
</tr>
<tr>
<td>
Nepal Standard Time
</td>
<td>
Asia/Kathmandu
</td>
<td>
UTC + 05:45
</td>
</tr>
<tr>
<td>
Bangladesh Standard Time
</td>
<td>
Asia/Dhaka
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Central Asia Standard Time
</td>
<td>
Asia/Almaty
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Ekaterinburg Standard Time
</td>
<td>
Asia/Yekaterinburg
</td>
<td>
UTC + 06:00
</td>
</tr>
<tr>
<td>
Myanmar Standard Time
</td>
<td>
Asia/Rangoon
</td>
<td>
UTC + 06:30
</td>
</tr>
<tr>
<td>
SE Asia Standard Time
</td>
<td>
Asia/Bangkok
</td>
<td>
UTC + 07:00
</td>
</tr>
<tr>
<td>
N. Central Asia Standard Time
</td>
<td>
Asia/Novosibirsk
</td>
<td>
UTC + 07:00
</td>
</tr>
<tr>
<td>
China Standard Time
</td>
<td>
Asia/Shanghai
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
North Asia Standard Time
</td>
<td>
Asia/Krasnoyarsk
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Singapore Standard Time
</td>
<td>
Asia/Singapore
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Taipei Standard Time
</td>
<td>
Asia/Taipei
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Ulaanbaatar Standard Time
</td>
<td>
Asia/Ulaanbaatar
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
W. Australia Standard Time
</td>
<td>
Australia/Perth
</td>
<td>
UTC + 08:00
</td>
</tr>
<tr>
<td>
Korea Standard Time
</td>
<td>
Asia/Seoul
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
North Asia East Standard Time
</td>
<td>
Asia/Irkutsk
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
Tokyo Standard Time
</td>
<td>
Asia/Tokyo
</td>
<td>
UTC + 09:00
</td>
</tr>
<tr>
<td>
AUS Central Standard Time
</td>
<td>
Australia/Darwin
</td>
<td>
UTC + 09:30
</td>
</tr>
<tr>
<td>
Cen. Australia Standard Time
</td>
<td>
Australia/Adelaide
</td>
<td>
UTC + 09:30
</td>
</tr>
<tr>
<td>
AUS Eastern Standard Time
</td>
<td>
Australia/Sydney
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
E. Australia Standard Time
</td>
<td>
Australia/Brisbane
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Tasmania Standard Time
</td>
<td>
Australia/Hobart
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
West Pacific Standard Time
</td>
<td>
Pacific/Port Moresby
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Yakutsk Standard Time
</td>
<td>
Asia/Yakutsk
</td>
<td>
UTC + 10:00
</td>
</tr>
<tr>
<td>
Central Pacific Standard Time
</td>
<td>
Pacific/Guadalcanal
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Russia Time Zone 10
</td>
<td>
Asia/Srednekolymsk
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Vladivostok Standard Time
</td>
<td>
Asia/Vladivostok
</td>
<td>
UTC + 11:00
</td>
</tr>
<tr>
<td>
Fiji Standard Time
</td>
<td>
Pacific/Fiji
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Magadan Standard Time
</td>
<td>
Asia/Magadan
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
New Zealand Standard Time
</td>
<td>
Pacific/Auckland
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Russia Time Zone 11
</td>
<td>
Asia/Kamchatka
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
UTC+12
</td>
<td>
Pacific/Tarawa
</td>
<td>
UTC + 12:00
</td>
</tr>
<tr>
<td>
Tonga Standard Time
</td>
<td>
Pacific/Tongatapu
</td>
<td>
UTC + 13:00
</td>
</tr>
<tr>
<td>
Line Islands Standard Time
</td>
<td>
Pacific/Kiritimati
</td>
<td>
UTC + 14:00
</td>
</tr>
</table>

## Create appointments in different time zones
Create appointments at different time zones using the [StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_StartTimeZone) and [EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_EndTimeZone) properties of [SchedulerAppointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html). An appointment’s start time and end time are calculated based on the given time zone information for the start time and end time. Set different time zones to the StartTimeZone and EndTimeZone properties.

Use the [StartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_StartTime) and [EndTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerRegionBase.html#Syncfusion_Maui_Scheduler_SchedulerRegionBase_EndTime) properties of ScheduleAppointment to get the exact start time and end time of an appointment. By using the [ActualStartTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html#Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualStartTime) and [ActualEndTime](Syncfusion_Maui_Scheduler_SchedulerAppointment_ActualEndTime) properties, get the exact appointment rendering time.

{% tabs %}	
{% highlight c# %}
var appointments = new ScheduleAppointmentCollection();
appointments.Add(new ScheduleAppointment()
{
    Subject = "Meeting",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1),
    StartTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata")
    EndTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata")
});		  
{% endhighlight %}
{% endtabs %}

>**NOTE**
* If the recurring appointment is converted to another time zone, then the whole sequence will be recalculated according to the new time zone information.
* If an all-day appointment is created, it's start time and end time will be set to 12 A.M. and 12 A.M. by default, so time zone is not applicable for all-day appointments.
* Scheduler supports daylight saving time.
* The time zone support is applicable for custom appointments too, so map the corresponding property.
* Use [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimeZone) for custom appointments by mapping the [StartTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_StartTimeZone) and [EndTimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html#Syncfusion_Maui_Scheduler_SchedulerAppointmentMapping_EndTimeZone) custom properties of [AppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html).

## Display Appointments based on client’s  time zone
Display the appointments based on the client’s local time zone in scheduler. For example, consider a scenario that you are in North Carolina and you want to set up a meeting at 10 A.M. on North Carolina time. You have colleagues in London and Chennai, and they also need to participate. The time for this meeting will be 3 P.M. (15:00) in London and 5.30 A.M. in Chennai. When each view your Scheduler, you need to see the appointment displayed relative to your local time zones 5.30 A.M., 10 A.M., and 3 P.M., respectively. It can be achieved by setting schedule time zone to default (it will consider your device’s local time zone as schedule time zone) and appointment’s time zone to `Eastern Standard Time (North Carolina)` [as you are in North Carolina and it's time zone is Eastern Standard Time].

## Display appointments based on Scheduler time zone
Set the specific time zone to schedule using the [TimeZone](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_TimeZone) property of scheduler. On this scenario, the appointments will be displayed in UTC time when the `StartTimeZone` and `EndTimeZone` properties of `ScheduleAppointment` are set to null. The appointments will be displayed in UTC time based on the given scheduler time zone.

{% tabs %}
{% highlight xaml %}
<scheduler:SfScheduler x:Name="scheduler" TimeZone="Asia/Kolkata"/>

{% endhighlight %}
{% highlight c#%}
this.scheduler.TimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");
{% endhighlight %}
{% endtabs %}