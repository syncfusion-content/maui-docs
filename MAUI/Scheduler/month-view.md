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

The scheduler month view appointment display can be handled by using the `AppointmentDisplayMode` property of `MonthView.` By default, `AppointmentDisplayMode` is set to `Text,` using the `AppointmentDisplayMode.` 

You can set the month view appointments display as follows.

* [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_None):  Appointment will not be displayed.
* [Indicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_Indicator):  Appointment will be denoted as the circle.
* [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerMonthAppointmentDisplayMode.html#Syncfusion_Maui_Scheduler_SchedulerMonthAppointmentDisplayMode_Text):  Appointment subject will be displayed in the month cell.

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView 
                       AppointmentDisplayMode="Indicator"/>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.AppointmentDisplayMode = SchedulerMonthAppointmentDisplayMode.Indicator;

{% endhighlight %}  
{% endtabs %}

![change-appointment-display-mode-in-maui-scheduler](images/month-view/change-appointment-display-mode-in-maui-scheduler.png)

N>
* [View scheduler appointment sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/GettingStarted)

* [View business object sample in GitHub](https://github.com/SyncfusionExamples/maui-scheduler-examples/tree/main/BusinessObject)

## Hide leading and trailing dates

The previous and next month dates from a Scheduler month view can be hidden by using the `ShowLeadingAndTrailingDates` property in the `MonthView.` The `ShowLeadingAndTrailingDates` property defaults to `true.`

{% tabs %}  
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView  
                       ShowLeadingAndTrailingDates="False"/>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ShowLeadingAndTrailingDates = false;

{% endhighlight %}  
{% endtabs %}

![show-or-hide-leading-and-trailing-days-appearence-customization-in-maui-scheduler](images/month-view/show-or-hide-leading-and-trailing-days-appearence-customization-in-maui-scheduler.png)

## Change day format of view header

Customize the day format of Scheduler view header by using the `DayFormat` property of `ViewHeaderSettings` in `MonthView.`

{% tabs %}  
{% highlight xaml %}

<scheduler:SfScheduler x:Name="Scheduler" 
                       View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd" />
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.DayFormat = "dddd";

{% endhighlight %}  
{% endtabs %}

![change-day-text-format-of-month-view-header-in-maui-scheduler](images/month-view/change-day-text-format-of-month-view-header-in-maui-scheduler.png)

### View header height

The height of the ViewHeader can be customized by setting the `Height` property of `ViewHeaderSettings` in `MonthView.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings Height="100" />
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.Height = 100;

{% endhighlight %}
{% endtabs %}

## Customize view header appearance

Customize the month view header day text style, day format and background color by using the `DayTextStyle,` `DayFormat` and `Background` of `ViewHeaderSettings` properties of `MonthView` respectively.

{% tabs %}  
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Month">
    <scheduler:SfScheduler.MonthView>
        <scheduler:SchedulerMonthView>
            <scheduler:SchedulerMonthView.ViewHeaderSettings>
                <scheduler:SchedulerViewHeaderSettings DayFormat="dddd"
                                                       Background="LightSkyBlue"/>
            </scheduler:SchedulerMonthView.ViewHeaderSettings>
        </scheduler:SchedulerMonthView>
    </scheduler:SfScheduler.MonthView>
</scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

var dayTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.DarkBlue,
    FontSize = 14,
};
this.Scheduler.View = SchedulerView.Month;
this.Scheduler.MonthView.ViewHeaderSettings.Background = Brush.LightSkyBlue;
this.Scheduler.MonthView.ViewHeaderSettings.DayFormat = "dddd";
this.Scheduler.MonthView.ViewHeaderSettings.DayTextStyle = dayTextStyle;

{% endhighlight %}  
{% endtabs %}

![customize-day-text-format-appearence-of-month-view-header-in-maui-scheduler](images/month-view/customize-day-text-format-appearence-of-month-view-header-in-maui-scheduler.png)

## Customize month cell appearance

By using the `CellStyle` property of `MonthView,` the month properties such as `Background,` `TodayBackground,` `TrailingMonthBackground,` `LeadingMonthBackground,` `TextStyle,` `TrailingMonthTextStyle,` and `LeadingMonthTextStyle` can be customized.

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

this.Scheduler.MonthView.CellStyle = monthCellStyle;

{% endhighlight %}  
{% endtabs %}

![customize-month-cell-appearance-in-maui-scheduler](images/month-view/customize-month-cell-appearance-in-maui-scheduler.png)