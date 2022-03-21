---
layout: post
title: Agenda view in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about the Agenda view feature of Syncfusion .NET MAUI Scheduler (SfScheduler) control and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Agenda view in .NET MAUI Scheduler (SfScheduler)

The agenda view displays the events or appointments (normal appointments, all-day appointments, recurring appointments, and span appointments) in chronological order, grouped by date between the minimum and maximum dates and the current date displayed by default. When the `AppointmentsSource` property of `SfScheduler` is `null`, the agenda view will show only the month, week, and date headers for mobile view and responsive UI, and for desktop UI it will display only the date header of display date.

A agenda view displays different UI for mobile and desktop, for mobile it displays the month header, the week header, and the date header however for desktop, it displays the appointment only.

N> When the desktop view width is less than 600, the scheduler will display the mobile agenda UI on the desktop.

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Agenda">
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;
// Creating an instance for the scheduler appointment collection.
var appointments = new ObservableCollection<SchedulerAppointment>();
// Adding scheduler appointment in the scheduler appointment collection.
appointments.Add(new SchedulerAppointment()
{
    Subject = "Meeting",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1),
    Background = Brush.Orange,
});
// Adding scheduler appointment into the AppointmentsSource.
this.Scheduler.AppointmentsSource = appointments;

{% endhighlight %}
{% endtabs %}

## Month header customization

The agenda month header view can be customized by using the `MonthHeaderSettings` property of `AgendaView` in the `SfScheduler.`

### Customize month header appearance using style

You can style the date format, height, text style, and background color by using the properties such as `DateFormat,` `Height,` `TextStyle,` and `Background` properties of `MonthHeaderSettings.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler"
                        View="Agenda">
    <scheduler:SfScheduler.AgendaView>
        <scheduler:SchedulerAgendaView>
            <scheduler:SchedulerAgendaView.MonthHeaderSettings>
                <scheduler:SchedulerMonthHeaderSettings DateFormat="MMM yyy"
                                                        Height="200"
                                                        Background="LightGreen" />
            </scheduler:SchedulerAgendaView.MonthHeaderSettings>
        </scheduler:SchedulerAgendaView>
    </scheduler:SfScheduler.AgendaView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;
var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 25,
};

this.Scheduler.AgendaView.MonthHeaderSettings.DateFormat = "MMM yyy";
this.Scheduler.AgendaView.MonthHeaderSettings.Height = 200;
this.Scheduler.AgendaView.MonthHeaderSettings.TextStyle = textStyle;
this.Scheduler.AgendaView.MonthHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}
{% endtabs %}

### Customize month header appearance using DataTemplate

You can customize the month header appearance of scheduler by using the `MonthHeaderTemplate` property of `AgendaView.`

{% tabs %}
{% highlight xaml %}

  <scheduler:SfScheduler x:Name="Scheduler"
                         View="Agenda">
    <scheduler:SfScheduler.AgendaView>
        <scheduler:SchedulerAgendaView>
            <scheduler:SchedulerAgendaView.MonthHeaderTemplate>
                <DataTemplate>
                    <Grid>
                        <Label x:Name="label" HorizontalOptions="Center" Background="LightGreen" VerticalOptions="Center" TextColor="Black" FontSize="25"  Text="{Binding StringFormat='{0:MMMM yyyy}'}" />
                    </Grid>
                </DataTemplate>
            </scheduler:SchedulerAgendaView.MonthHeaderTemplate>
        </scheduler:SchedulerAgendaView>
    </scheduler:SfScheduler.AgendaView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% endtabs %}

N> 
* The default value of `DateFormat,` and `Height` are `MMMM yyyy,` and `150` respectively.
* For desktop UI, The agenda view displays the appointment only.

### Customize month header appearance using DataTemplateSelector

You can customize the month header appearance by using the `MonthHeaderTemplate` property of `AgendaView` in the `SfScheduler.` The `DataTemplateSelector` can choose a `DataTemplate` at runtime based on the value of a data-bound to month header by using the `MonthHeaderTemplate.` It lets to choose a different data template for each month header, customizing the appearance of a particular month header based on certain conditions.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.Resources>
        <DataTemplate x:Key="todayDateTemplate">
            <Grid>
                <Label x:Name="label" HorizontalOptions="Center" Background="BlueViolet" VerticalOptions="Center" TextColor="Yellow" FontSize="25"  Text="{Binding StringFormat='{0:MMMM yyyy}'}" />
            </Grid>
        </DataTemplate>
        <DataTemplate x:Key="normalDateTemplate">
            <Grid>
                <Label x:Name="label" HorizontalOptions="Center" Background="BlueViolet" VerticalOptions="Center" TextColor="White" FontSize="25"  Text="{Binding StringFormat='{0:MMMM yyyy}'}" />
            </Grid>
        </DataTemplate>
        <local:AgendaViewTemplateSelector x:Key="agendaViewTemplateSelector" TodayDateTemplate="{StaticResource todayDateTemplate}" NormalDateTemplate="{StaticResource normalDateTemplate}"/>
    </Grid.Resources>
    <scheduler:SfScheduler x:Name="Scheduler" 
                           View="Agenda" >
        <scheduler:SfScheduler.AgendaView>
            <scheduler:SchedulerAgendaView MonthHeaderTemplate="{StaticResource agendaViewTemplateSelector}" />
        </scheduler:SfScheduler.AgendaView>
    </scheduler:SfScheduler>
 </Grid>

{% endhighlight %}
{% highlight c# tabtitle="AgendaViewTemplateSelector.cs" %}

public class AgendaViewTemplateSelector : DataTemplateSelector
{
    public AgendaViewTemplateSelector()
    {
    }
    public DataTemplate NormalDateTemplate { get; set; }
    public DataTemplate TodayDateTemplate { get; set; }
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var dateTime = (DateTime)item;
        if (dateTime.Month == DateTime.Today.Month)
            return TodayDateTemplate;
        else
            return NormalDateTemplate;
    }
}

{% endhighlight %}  
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;

{% endhighlight %} 
{% endtabs %}

N>
* The default value of `DateFormat,` and `Height` are `MMMM yyyy,` and `150` respectively.
* For desktop UI, The agenda view displays the appointment only.
* The data template selector is experiencing more performance issues, when creating template views and there is a delay in loading.

## Week header customization

The agenda week header view can be customized by using the `WeekHeaderSettings` property of `AgendaView` in the `SfScheduler.`

You can style the date format, height, text style, and background color by using the properties such as `DateFormat,` `Height,` `TextStyle,` and `Background` properties of `WeekHeaderSettings.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler"
                        View="Agenda">
    <scheduler:SfScheduler.AgendaView>
        <scheduler:SchedulerAgendaView>
            <scheduler:SchedulerAgendaView.WeekHeaderSettings>
                <scheduler:SchedulerWeekHeaderSettings  DateFormat="MM, ddd"
                                                        Height="100"
                                                        Background="LightGreen" />
            </scheduler:SchedulerAgendaView.WeekHeaderSettings>
        </scheduler:SchedulerAgendaView>
    </scheduler:SfScheduler.AgendaView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;
var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.AgendaView.WeekHeaderSettings.DateFormat = "MM, ddd";
this.Scheduler.AgendaView.WeekHeaderSettings.Height = 100;
this.Scheduler.AgendaView.WeekHeaderSettings.TextStyle = textStyle;
this.Scheduler.AgendaView.WeekHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}
{% endtabs %}

N> 
* The default value of `DateFormat,` and `Height` are `MMM dd,` and `30` respectively.
* For desktop UI, The agenda view displays the appointment only.

## Day header customization

The agenda day header view can be customized by using the `DayHeaderSettings` property of `AgendaView` in the `SfScheduler.`

You can style the day format, day text style, date text style, and background color by using the properties such as `DayFormat,` `DayTextStyle,` `DateTextStyle,` and `Background` properties of `DayHeaderSettings.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler"
                        View="Agenda">
    <scheduler:SfScheduler.AgendaView>
        <scheduler:SchedulerAgendaView>
            <scheduler:SchedulerAgendaView.DayHeaderSettings>
                <scheduler:SchedulerDayHeaderSettings DayFormat="MM, ddd"
                                                      Background="LightGreen"/>
            </scheduler:SchedulerAgendaView.DayHeaderSettings>
        </scheduler:SchedulerAgendaView>
    </scheduler:SfScheduler.AgendaView>
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;
var textStyle = new SchedulerTextStyle()
{
    TextColor = Colors.Red,
    FontSize = 12,
};

this.Scheduler.AgendaView.DayHeaderSettings.DayFormat = "MM, ddd";
this.Scheduler.AgendaView.DayHeaderSettings.DayTextStyle = textStyle;
this.Scheduler.AgendaView.DayHeaderSettings.DateTextStyle = textStyle;
this.Scheduler.AgendaView.DayHeaderSettings.Background = Brush.LightGreen;

{% endhighlight %}
{% endtabs %}

N> The default value of `DayFormat` is `MMM, ddd.`

## Appointment text customization

The appointment text style can be customized by using the `AppointmentTextStyle` property of the `SfScheduler.`

{% tabs %}
{% highlight xaml %}

 <scheduler:SfScheduler x:Name="Scheduler" 
                        View="Agenda">
 </scheduler:SfScheduler>

{% endhighlight %}
{% highlight c# %}

this.Scheduler.View = SchedulerView.Agenda;
// Creating an instance for the scheduler appointment collection.
var appointments = new ObservableCollection<SchedulerAppointment>();
// Adding scheduler appointment in the scheduler appointment collection.
appointments.Add(new SchedulerAppointment()
{
    Subject = "Meeting",
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(1),
    RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
    Background = Brush.Orange,
});
// Adding scheduler appointment into the AppointmentsSource.
this.Scheduler.AppointmentsSource = appointments;
// Creating the text style for the appointments.
var appointmentTextStyle = new SchedulerTextStyle()
{
    TextColor = Colors.White,
    FontSize = 12,
};
// Setting the text style for the appointments.
this.Scheduler.AppointmentTextStyle = appointmentTextStyle;

{% endhighlight %}
{% endtabs %}