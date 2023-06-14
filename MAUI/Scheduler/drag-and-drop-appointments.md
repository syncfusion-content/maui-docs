---
layout: post
title: Appointment drag and drop in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Appointment drag and drop support in Syncfusion .NET MAUI Scheduler(SfScheduler) control.
platform: maui
control: SfScheduler
documentation: ug
---

# Appointment Drag and Drop in .NET MAUI Scheduler
Appointments can be rescheduled using the drag and drop operation. To perform drag-and-drop operations within the scheduler, enable the `AllowAppointmentDrag` property of SfScheduler. You can disable appointment drag and drop by assigning `false` to `AllowAppointmentDrag` property. The default value of is `true`.

{% tabs %}
{% highlight xaml %}
<scheduler:SfScheduler x:Name="scheduler" View="Week" AllowAppointmentDrag="false">        
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.scheduler.AllowAppointmentDrag = false;
{% endhighlight %}
{% endtabs %}

![Appointment Drag and Drop in .NET MAUI Scheduler](images/drag-and-drop/appointment-drag-and-drop.gif)

Refer [here](https://help.syncfusion.com/maui/scheduler/appointments#creating-business-objects) to create a business object class.

N> Inherit the business object class class from the `INotifyPropertyChanged` for dynamic changes in custom data.

## Handle appointment drag starting
You can get the appointment details and handle whether the appointment can be draggable or not by using `AppointmentDragStarting` event. This event will be triggered when the appointment is started dragging. The `AppointmentDragStartingEventArgs` argument contains the following properties.

`Appointment` - Gets the appointment that is going to be dragged.
`Resource` - Gets the resource under which the appointment is currently located.

{% tabs %}
{% highlight c# %}
scheduler.AppointmentDragStarting += OnSchedulerAppointmentDragStarting;

...

private void OnSchedulerAppointmentDragStarting(object? sender, AppointmentDragStartingEventArgs e)
{
    var appointment = e.Appointment;
    e.Cancel = false;
}
{% endhighlight %}
{% endtabs %}

Refer the below code to cancel the all day appointment dragging.
{% tabs %}
{% highlight c# %}
scheduler.AppointmentDragStarting += OnSchedulerAppointmentDragStarting;

...

private void OnSchedulerAppointmentDragStarting(object? sender, AppointmentDragStartingEventArgs e)
{
    var appointment = e.Appointment as SchedulerAppointment;
    if (appointment.IsAllDay)
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

Here, appointment dragging is disabled when the appointment is `AllDay` appointment.

## Handle appointment dragging
you can handle the dragging appointment details, position and time of the particular location by using `AppointmentDragOver` event. This event will be continuously triggered when the appointment is being dragged. The `AppointmentDragOverEventArgs` argument contains the following properties.

`Appointment` - Gets the appointment that is being dragged.
`DragPoint`- Gets the dragging point of the scheduler appointment user interface.
`DragTime` - Gets the dragging time of the appointment object being dragged.
`DragResource` - Gets the original resource of the appointment that is being dragged.

{% tabs %}
{% highlight c# %}
scheduler.AppointmentDragOver += OnSchedulerAppointmentDragOver;

...

private void OnSchedulerAppointmentDragOver(object? sender, AppointmentDragOverEventArgs e)
{
    var appointment = e.Appointment;
    var draggingPoint = e.DragPoint;
    var draggingTime = e.DragTime;
}
{% endhighlight %}
{% endtabs %}

## Handle appointment drop
Using `AppointmentDrop` event you can get the dropping appointment details, position, time and you can handle whether the appointment can be dropped to the specific position or not. This event will trigger after dropping the appointment. The `AppointmentDropEventArgs` argument contains the following properties

`Appointment` - Gets the appointment that is being dragged and dropped.
`DropTime`- Gets or sets the date and time at which the appointment is being dropped.
`SourceResource` - Gets the original resource of the appointment that is being dropped.
`TargetResource` - Gets the resource into which the appointment is being dropped.

{% tabs %}
{% highlight c# %}
scheduler.AppointmentDrop += OnSchedulerAppointmentDrop;

...

private void OnSchedulerAppointmentDrop(object? sender, AppointmentDropEventArgs e)
{
        var appointment = e.Appointment;
        e.Cancel = false;
        var dropTime = e.DropTime;
}
{% endhighlight %}
{% endtabs %}

## Change the drag and drop settings
You can change the appointment of drag and drop settings in Scheduler by using `DragDropSettings` property.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="dragAndDrop" ShowBusyIndicator="True"
                    AppointmentsSource="{Binding DragEvents}"
                    View="Week"
                    DisplayDate="{Binding DisplayDate}"
                    AllowedViews="Day,Week,WorkWeek,Month">
        <schedule:SfScheduler.DragDropSettings>
            <schedule:DragDropSettings AllowNavigation="true" AllowScroll="true" 
                                    ShowTimeIndicator="true"/>
        </schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
scheduler.DragDropSettings = new DragDropSettings 
{
    AllowNavigation = true,
    AllowScroll = true,
    ShowTimeIndicator = true,
};
{% endhighlight %}
{% endtabs %}

#### Disable view navigation when dragging appointment
Using `AllowNavigate` property of `DragDropSettings` you can handle whether you can navigate views while dragging the appointment or not. The default value of the AllowNavigate property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AllowNavigation = true;
{% endhighlight %}
{% endtabs %}

#### Handle navigation delay for dragged appointment
Using `AutoNavigationDelay` property you can handle the navigation time when navigating through views while holding the dragged appointment.
{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AutoNavigationDelay = new TimeSpan(0, 0, 2);
{% endhighlight %}
{% endtabs %}

#### Handle view scroll when dragging appointment
Using `AllowScroll` property you can handle scrolling the time slot while dragging the appointment or not, while dragging the appointment to the endpoint of the current view in Schedule. The default value of the `AllowScroll` property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AllowScroll = false;
{% endhighlight %}
{% endtabs %}

N> This is not applicable for MonthView.

#### Show or hide drag time indicator
You can handle whether the drag and drop indicator should be displayed within the scheduler during appointment dragging by using `ShowTimeIndicator` property which shows the dragged appointment current position time. The default value of the `ShowTimeIndicator` property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.ShowTimeIndicator = false;
{% endhighlight %}
{% endtabs %}

N>
* Not applicable for Month and Timeline Month views.
* If the [TimeRulerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html#Syncfusion_Maui_Scheduler_SchedulerDaysView_TimeRulerWidth) property value is zero, then drag time indicator will not be shown.

#### Change drag time Indicator text style
You can change the drag time indicator style by using `TimeIndicatorStyle` property of `DragDropSettings`.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="dragAndDrop" ShowBusyIndicator="True"
                    AppointmentsSource="{Binding DragEvents}"
                    View="Week"
                    DisplayDate="{Binding DisplayDate}"
                    AllowedViews="Day,Week,WorkWeek,Month">
        <schedule:SfScheduler.DragDropSettings>
            <schedule:DragDropSettings TimeIndicatorStyle="{schedule:SchedulerTextStyle TextColor=Green}"/>
        </schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
scheduler.DragDropSettings.TimeIndicatorStyle = new SchedulerTextStyle { TextColor = Colors.Green };
{% endhighlight %}
{% endtabs %}