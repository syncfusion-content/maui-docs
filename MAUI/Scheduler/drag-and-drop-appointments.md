---
layout: post
title: Appointment drag and drop in .NET MAUI Scheduler control | Syncfusion
description: Learn here all about Appointment drag and drop support in Syncfusion .NET MAUI Scheduler(SfScheduler) control.
platform: maui
control: SfScheduler
documentation: ug
---

# Appointment Drag and Drop in .NET MAUI Scheduler
Appointments can be rescheduled using the drag and drop operation. To perform drag-and-drop operations within the schedule, enable the `AllowAppointmentDrag` property of SfScheduler.

{% tabs %}
{% highlight xaml %}
<scheduler:SfScheduler x:Name="scheduler" View="Week" AllowAppointmentDrag="True">        
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.scheduler.AllowAppointmentDrag = true;
{% endhighlight %}
{% endtabs %}

## Handle dragging based on the appointment
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

#### Disabling dragging when the appointment is AllDay appointment
You can enable/disable the appointment dragging based on the requirement by using `Cancel` property in the `AppointmentDragStartingEventArgs` argument of Scheduler `AppointmentDragStarting` event.

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

## Get the dragging appointment position and time
you can get the dragging appointment details, position and time of the particular location by using `AppointmentDragOver` event. This event will be continuously triggered when the appointment is being dragged. The `AppointmentDragOverEventArgs` argument contains the following properties.

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

## Handle appointment dropping
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

## Customizing the Drag and Drop environment
You can handle the behavior of drag and drop in Scheduler by using `DragDropSettings` property.

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

#### Disabling navigation when dragging appointment
Using `AllowNavigate` property of `DragDropSettings` you can handle whether you can navigate views while dragging the appointment or not. The default value of the AllowNavigate property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AllowNavigation = true;
{% endhighlight %}
{% endtabs %}

#### Handling navigation delay while holding dragged appointment
Using `AutoNavigationDelay` property you can handle the navigation time when navigating through views while holding the dragged appointment.
{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AutoNavigationDelay = new TimeSpan(0, 0, 0, 1, 0);
{% endhighlight %}
{% endtabs %}

#### Disabling scroll when dragging appointment
Using `AllowScroll` property you can handle the scrolling the time slot while dragging the appointment or not. while dragging the appointment to the endpoint of the current view in Schedule. The default value of the `AllowScroll` property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.AllowScroll = true;
{% endhighlight %}
{% endtabs %}

#### Disabling dragging time indicator
You can handle whether the drag and drop indicator should be displayed within the scheduler during appointment dragging by using `ShowTimeIndicator` property which shows the dragged appointment current position time. The default value of the `ShowTimeIndicator` property is `true`.

{% tabs %}
{% highlight c# %}
scheduler.DragDropSettings.ShowTimeIndicator = false;
{% endhighlight %}
{% endtabs %}

#### Customize appearance of dragging Time Indicator
You can customize dragging time indicator by using `TimeIndicatorStyle` property of `DragDropSettings`.

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

