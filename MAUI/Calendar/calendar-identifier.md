---
layout: post
title: Calendar Identifier in .NET MAUI Calendar Control | Syncfusion
description: Learn here all about the Calendar identifier in the Syncfusion .NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Calendar identifier in .NET MAUI Calendar (SfCalendar)
The .NET MAUI Calendar supports Calendar Identifier to display the different types of calendars based on various cultures and regions. The supported identifiers are Gregorian, Hijri, Korean, Persian, Taiwan, ThaiBuddhist, and UmAlQura. Change the calendar identifier using the [Identifier] property in the SfCalendar.

<table>
<tr>
<th>Supported Calendars</th>
<th>UnSupported Calendars</th>
</tr>
<tr>

<td>
* GregorianCalendar<br>
* HijriCalendar<br>
* KoreanCalendar<br>
* PersianCalendar<br>
* TaiwanCalendar<br>
* ThaiCalendar<br>
* UmAlQuraCalendar<br>
</td>

<td>
* Gezer Calendar<br>
* Haida Calendar<br>
* Igbo calendar<br>
* Islamic calendar<br>
* Javanese calendar<br>
* Maramataka (Māori lunar calendar)<br>
* Nepal Sambat<br>
* HebrewCalendar<br>
* JulianCalendar<br>
* JapaneseCalendar<br>
* Yoruba calendar<br>
</td>
</tr>
</table>

N>
* The Flow Direction will be updated based on the calendar identifier. All the DateTime values, such as DisplayDate, MinimumDate, MaximumDate, SelectedDate, SelectedDates, SelectedDateRange, SelectableDayPredicate, and SpecialDayPredicate, can be given in two ways.
* The DateTime instance without specifying calendar identifier. The calendar will handle the DateTime value for the specified calendar identifier.
* When a DateTime instance has a calendar identifier, the calendar handles it directly.
* View haeder will show full week day name for all the calendar identifiers except gregorian calendar while the text format is "ddddd".

{% tabs %}
{% highlight XAML hl_lines="2" %}
<calendar:SfCalendar x:Name="Calendar"
					 Identifier="Hijri">
</calendar:SfCalendar>
{% endhighlight %}
{% highlight C# hl_lines="2" %}

SfCalendar calendar = new SfCalendar();
calendar.Identifier = CalendarIdentifier.Hijri;
this.Content = calendar;

{% endhighlight %}
{% endtabs %}

### DateTime values in Calendar identifiers
All the DateTime properties of the calendar can be given in two ways when the calendar identifier is specified other than the GregorianCalendar.

* Create an display date value by declaring the calendar identifier and respective calendar identifier date.

{% tabs %}
{% highlight MainPage.xaml %}

<calendar:SfCalendar x:Name="Calendar" />

{% endhighlight %}
{% highlight MainPage.xaml.cs hl_lines="2" %}

this.Calendar.Identifier = CalendarIdentifier.Hijri;
this.Calendar.DisplayDate = new DateTime(1444, 11, 21, 0, 0, 0, new HijriCalendar());

{% endhighlight %}
{% endtabs %}

* Create an display date value by declaring the local system date. In this case, the system date will be converted to the respective calendar identifier date.

{% tabs %}
{% highlight MainPage.xaml s%}

<calendar:SfCalendar x:Name="Calendar" />

{% endhighlight %}
{% highlight MainPage.xaml.cs hl_lines="2" %}

this.Calendar.Identifier = CalendarIdentifier.Hijri;
this.Calendar.DisplayDate = new DateTime(2023, 6, 9);

{% endhighlight %}
{% endtabs %}