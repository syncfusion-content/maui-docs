---
layout: post
title: Calendar type in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Calendar type in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more details.
platform: maui
control: SfScheduler
documentation: ug
---

# Calendar type in .NET MAUI Scheduler (SfScheduler)
The Scheduler control supports different types of calendars such as Gregorian, Korean, Hebrew, and more. You can change the calendar types by using the CalendarType property in SfScheduler. 

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
* Lunar type calendars<br>
</td>
</tr>
</table>

N>
* FlowDirection will be updated based on the CalendarType and if you want to override this behavior, set FlowDirection after CalendarTypeIf calendar type is specified other than Gregorian, all the DateTime values such as Appointment Start and End time, SpecialTimeRegion Start and End time, SelectableDayPredicate, SelectedDate and DisplayDate can be given in two ways.
* DateTime instance without specifying calendar type. Scheduler will handle the DateTime value for the specified calendar type.
* When a DateTime instance has a calendar type, the Scheduler handles it directly.
* All calendar types are supported except Lunar type calendars.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineMonth" CalendarType="Taiwan">
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="10" %}
this.Scheduler.CalendarType = CalendarType.Taiwan;
{% endhighlight %}
{% endtabs %}
