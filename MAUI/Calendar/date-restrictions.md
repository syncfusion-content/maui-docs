---
layout: post
title: Date Restrictions in .NET MAUI Calendar control | Syncfusion
description: Learn here all about Date restrictions feature of Syncfusion .NET MAUI Calendar (SfCalendar) control and more.
platform: maui
control: SfCalendar
documentation: ug
---

# Date Restrictions in .NET MAUI Calendar (SfCalendar)

## Minimum DateTime
The [MinimumDateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MinimumDate) property will restrict the backward navigation of date selection and also you cannot swipe beyond the minimum date range.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

  this.Calendar.MinimumDateTime = DateTime.Now.AddDays(-5);

{% endhighlight %}
{% endtabs %}

![Month view Minimum DateTime in .NET MAUI Calendar.](images/date-restriction/maui-month-view-minimum-date.png)

## Maximum DateTime
The [MaximumDateTime](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_MaximumDate) property will restrict the forward navigation of date selection and also you cannot swipe beyond the maximum date range.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.MaximumDateTime = DateTime.Now.AddDays(5);

{% endhighlight %}
{% endtabs %}

![Month view Maximum DateTime in .NET MAUI Calendar.](images/date-restriction/maui-month-view-maximum-date.png)

## Enable past dates
To enable or disable the dates before today's date using the [EnablePastDates](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_EnablePastDates)
property of the `SfCalendar` and you cannot select the dates before the today date while it is disabled.

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

![Month view Enable past dates in .NET MAUI Calendar.](images/date-restriction/Enable-past-date-in-maui-calendar.png)

## SelectableDayPredicate
The [SelectableDayPredicate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Calendar.SfCalendar.html#Syncfusion_Maui_Calendar_SfCalendar_SelectableDayPredicate) of the `SfCalendar` decides whether the cell is selectable or not in calendar and if you want to disable the particular selected date in a calendar. Easily prevent the selection of weekends by disabling them. If the callback returns true, the date will be selectable in the Calendar.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<calendar:SfCalendar  x:Name="Calendar" 
                        View="Month">
</calendar:SfCalendar>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

this.Calendar.SelectableDayPredicate = (date) =>
{
  if (date.Date == DateTime.Now.AddDays(-2) || date.Date == DateTime.Now.AddDays(-7) || date.Date == DateTime.Now.AddDays(-12) || date.Date == DateTime.Now.AddDays(1) || date.Date == DateTime.Now.AddDays(15))
  {
    return false;
  }
  
  return true;
};

{% endhighlight %}
{% endtabs %}

![Month view Selectable Day Predicate in .NET MAUI Calendar.](images/date-restriction/maui-selectable-day-predicate.png)