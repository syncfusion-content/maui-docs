---
layout: post
title: Calendar Identifier in .NET MAUI Calendar Control | Syncfusion®
description: Learn here all about the Calendar identifier in the Syncfusion<sup>&reg;</sup>.NET MAUI Calendar (SfCalendar) control and more details.
platform: maui
control: SfCalendar
documentation: ug
---

# Calendar identifier in .NET MAUI Calendar (SfCalendar)
The [.NET MAUI Calendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html) supports Calendar Identifier to display the different types of calendars based on various cultures and regions. The supported identifiers are Gregorian, Hijri, Korean, Persian, Taiwan, ThaiBuddhist, and UmAlQura. Change the calendar identifier using the [Identifier](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_Identifier) property in the SfCalendar.

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
* Maramataka (Maori lunar calendar)<br>
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
* When a `DateTime` instance is created without specifying a calendar identifier, the calendar handles the value for the specified calendar identifier.
* When a `DateTime` instance has a calendar identifier, the calendar handles it directly.
* The view header shows the full weekday name for all the calendar identifiers except `Gregorian Calendar` when the text format is "ddddd".

{% tabs %}
{% highlight XAML hl_lines="6" %}

<ContentPage
    . . .
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar x:Name="calendar"
                         Identifier="Hijri" />

</ContentPage>

{% endhighlight %}
{% highlight C# hl_lines="5" %}

using Syncfusion.Maui.Calendar;
. . .

SfCalendar calendar = new SfCalendar();
calendar.Identifier = CalendarIdentifier.Hijri;
this.Content = calendar;

{% endhighlight %}
{% endtabs %}

### DateTime values in Calendar identifiers
All the DateTime properties of the calendar can be given in two ways when the calendar identifier is specified other than the [GregorianCalendar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.CalendarIdentifier.html#Syncfusion_Maui_Calendar_CalendarIdentifier_Gregorian).

* Create a display date value by declaring the calendar identifier and the respective calendar identifier date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar x:Name="calendar" />

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}

using Syncfusion.Maui.Calendar;
. . .

this.calendar.Identifier = CalendarIdentifier.Hijri;
this.calendar.DisplayDate = new DateTime(1444, 11, 21, 0, 0, 0, new HijriCalendar());

{% endhighlight %}
{% endtabs %}

* Create a display date value by declaring the local system date. In this case, the system date is converted to the respective calendar identifier date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage
    . . .
    xmlns:calendar="clr-namespace:Syncfusion.Maui.Calendar;assembly=Syncfusion.Maui.Calendar">

    <calendar:SfCalendar x:Name="calendar" />

</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2" %}

using Syncfusion.Maui.Calendar;
. . .

this.calendar.Identifier = CalendarIdentifier.Hijri;
this.calendar.DisplayDate = new DateTime(2023, 6, 9);

{% endhighlight %}
{% endtabs %}

![Multiple views of Calendar identifier in .NET MAUI Calendar.](images/calendar-identifier/maui-multiple-calendar-identifier-views.png)