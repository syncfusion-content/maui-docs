---
layout: post
title: Month View in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about how to customize the appearance and change the date format for month view in Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Month View in .NET MAUI Scheduler (SfScheduler)

By default, the Month view displays the entire days of a particular month and current month initially. The current date color is differentiated from other dates of the current month, and also the color differentiation for dates will be applicable for the previous and next month dates.

By default, when an appointment is tried to create through Month view, it is considered to be created for an entire day.

## Appointment display mode

The scheduler month view appointment display can be handled by using the `AppointmentDisplayMode` property of `MonthViewSettings.` By default, `AppointmentDisplayMode` is set to `Text,` using the `AppointmentDisplayMode.` 

You can set the month view appointments display as follows.

* `None`:  Appointment will not be displayed.
* `Indicator`:  Appointment will be denoted as the circle.
* `Text`:  Appointment subject will be displayed in the month cell.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthViewSettings>
        <scheduler:SchedulerMonthViewSettings  
            AppointmentDisplayMode="Indicator"/>
    </scheduler:SfScheduler.MonthViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthViewSettings.AppointmentDisplayMode = SchedulerMonthAppointmentDisplayMode.Indicator;

{% endhighlight %}  
{% endtabs %}

## Hide leading and trailing dates

The previous and next month dates from a Scheduler month view can be hidden by using the `ShowLeadingAndTrailingDates` property in the `MonthViewSettings` of the `SfScheduler.` The `ShowLeadingAndTrailingDates` property defaults to `true.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthViewSettings>
        <scheduler:SchedulerMonthViewSettings  
            ShowLeadingAndTrailingDates="False"/>
    </scheduler:SfScheduler.MonthViewSettings>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthViewSettings.ShowLeadingAndTrailingDates = false;

{% endhighlight %}  
{% endtabs %}

## Change day format of view header

Customize the day format of Scheduler view header by using the `DayFormat` property of `MonthViewSettings.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthViewSettings.ViewHeaderSettings.DayFormat = "dddd";

{% endhighlight %}  
{% endtabs %}

## Customize view header appearance

Customize the month view header day text style, day format and background color by using the `SchedulerTextStyle,` `DayFormat` and `Background` of `ViewHeaderSettings` property of `MonthViewSettings` respectively.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};
this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthViewSettings.ViewHeaderSettings.Background = Brush.LightSkyBlue;
this.Scheduler.MonthViewSettings.ViewHeaderSettings.DayFormat = "dddd";
this.Scheduler.MonthViewSettings.ViewHeaderSettings.DayTextStyle = dayTextStyle;

{% endhighlight %}  
{% endtabs %}

## customize month cell appearance

By using the `MonthCellStyle` property of `MonthViewSettings,` the month properties such as `Background,` `TodayBackground,` `TrailingMonthBackground,` `LeadingMonthBackground,` `TextStyle,` `TrailingMonthTextStyle,` and `LeadingMonthTextStyle` can be customized.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};

var leadingMonthTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 14,
};
            
var trailingMonthTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 14,
};

var monthCellStyle = new SchedulerMonthCellStyle()
{
    Background = Brush.LightSkyBlue,
    TodayBackground = Brush.LightBlue,
    LeadingMonthBackground = Brush.LightGreen,
    TrailingMonthBackground = Brush.LightYellow,
    TextStyle = textStyle,
    LeadingMonthTextStyle = leadingMonthTextStyle,
    TrailingMonthTextStyle = trailingMonthTextStyle
};

this.Scheduler.MonthViewSettings.MonthCellStyle = monthCellStyle;

{% endhighlight %}  
{% endtabs %}