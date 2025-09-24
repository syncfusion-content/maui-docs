---
layout: post
title: Date Restrictions in .NET MAUI Calendar control | Syncfusion
description: Learn here all about Date restrictions feature of Syncfusion .NET MAUI Calendar (SfCalendar) control and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Date Restrictions in .NET MAUI Calendar (SfCalendar)

## Minimum date
The [MinimumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MinimumDate) property will restrict the backward navigation of date selection and also you cannot swipe beyond the minimum date range.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

  this.calendar.MinimumDate = DateTime.Now.AddDays(-5);

{% endhighlight %}
{% endtabs %}

![Month view minimum datetime in .NET MAUI Calendar.](images/date-restriction/net-maui-month-view-minimum-date.png)

## Maximum date
The [MaximumDate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MaximumDate) property will restrict the forward navigation of date selection and also you cannot swipe beyond the maximum date range.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.MaximumDate = DateTime.Now.AddDays(5);

{% endhighlight %}
{% endtabs %}

![Month view maximum dtetime in .NET MAUI Calendar.](images/date-restriction/net-maui-month-view-maximum-date.png)

## Enable past dates
To enable or disable the dates before today's date using the [EnablePastDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnablePastDates) property of the `SfCalendar` and you cannot select the dates before the today date while it is disabled.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar" 
                        View="Month"
                        EnablePastDates="false">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.EnablePastDates = false;

{% endhighlight %}
{% endtabs %}

![Month view enable past dates in .NET MAUI Calendar.](images/date-restriction/enable-past-date-in-net-maui-calendar.png)

## Selectable day predicate
The [SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate) of the `SfCalendar` decides whether the cell is selectable or not in calendar and if you want to disable the particular selected date in a calendar. Easily prevent the selection of weekends by disabling them. If the callback returns true, the date will be selectable in the Calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.calendar.SelectableDayPredicate = (date) =>
{
  if (date.Date == DateTime.Now.AddDays(-2).Date || date.Date == DateTime.Now.AddDays(-7).Date || date.Date == DateTime.Now.AddDays(-12).Date || date.Date == DateTime.Now.AddDays(1).Date || date.Date == DateTime.Now.AddDays(15).Date)
  {
    return false;
  }
  
  return true;
};

{% endhighlight %}
{% endtabs %}

![Month view selectable day predicate in .NET MAUI Calendar.](images/date-restriction/net-maui-selectable-day-predicate.png){:width="271" height="351"}