---
layout: post
title: Date Restrictions in MAUI Calendar widget | Syncfusion
description: Learn here all about Date restrictions feature of Syncfusion MAUI Calendar (SfCalendar) widget and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Date Restrictions in MAUI Calendar (SfCalendar)

## Minimum DateTime
The [MinimumDateTime](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/MinimumDateTime.html) property will restrict the backward navigation of date selection and also you cannot able to swipe beyound the minimum date range. The dates before the minimum date time is considered as disabled date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

  this.Calendar.MinimumDateTime = DateTime.Now.AddDays(-5);

{% endhighlight %}
{% endtabs %}

![minimum-date-month-view-in-maui-calendar](images/date-restriction/minimum-date-month-view-in-maui-calendar.png)

## Maximum DateTime
The [MaximumDateTime](https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/MaximumDateTime.html) property will restrict the forward navigation of date selection and also you cannot able to swipe beyound the maximum date range. The dates after the maximum date time is considered as disabled date.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MaximumDateTime = DateTime.Now.AddDays(5);

{% endhighlight %}
{% endtabs %}

![maximum-date-month-view-in-maui-calendar](images/date-restriction/maximum-date-month-view-in-maui-calendar.png)

## Enable past dates
To enable or disable the dates before the today date by using the `EnablePastDates` (https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/EnablePastDate.html) property of the `SfCalendar` and  you cannot able to select the dates before the today date while it is disabled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month"
                        EnablePastDates="false">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.EnablePastDates = false;

{% endhighlight %}
{% endtabs %}

![enable-past-date-in-maui-calendar](images/date-restriction/enable-past-date-in-maui-calendar.png)

## SelectableDayPredicate
The [SelectableDayPredicate] (https://pub.dev/documentation/syncfusion_maui_calendar/latest/calendar/SfCalendar/EnablePastDate.html) of the `SfCalendar` decides whether the cell is selectable or not in calendar and if you want to disable the particular selected date in a calendar. Easily prevent the selection of weekends by disabling them. If the callback returns true, the date will be selectable in the Calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

{% include_relative code-snippet/month-view.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectableDayPredicate = (date) =>
{
  if (date.Date == DateTime.Now.AddDays(3) || date.Date == DateTime.Now.AddDays(6) || date.Date == DateTime.Now.AddDays(-4) || date.Date == DateTime.Now.AddDays(-2))
  {
    return false;
  }
  
  return true;
};

{% endhighlight %}
{% endtabs %}

![selectable-day-predicate-in-maui-calendar](images/date-restriction/selectable-day-predicate-in-maui-calendar.png)