---
layout: post
Title: Appointment Drag and Drop in .NET MAUI Scheduler Control | Syncfusion
Description: Learn here all about Appointment drag and drop support in the Syncfusion .NET MAUI Scheduler(SfScheduler) control.
platform: maui
control: SfScheduler
documentation: ug
---

# Appointment Drag and Drop in .NET MAUI Scheduler
Appointments can be rescheduled using the drag-and-drop operation. To perform drag-and-drop operations within the scheduler, enable the `AllowAppointmentDrag` property of SfScheduler. You can disable appointment drag and drop by assigning `false` to the `AllowAppointmentDrag` property. The default value is `true`.

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

N> Inherit the business object class from the `INotifyPropertyChanged` for dynamic changes in custom data.

## Handle appointment drag starting
You can get the appointment details and handle whether the appointment can be draggable or not by using the `AppointmentDragStarting` event. This event will be triggered when the appointment is started dragging. The `AppointmentDragStartingEventArgs` argument contains the following properties.

`Appointment` - Get the appointment that is going to be dragged.
`Resource` - Get the resource under which the appointment is currently located.

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

Refer to the below code to cancel the all-day appointment dragging.
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
You can handle the dragging appointment details, position, and time of the particular location by using the `AppointmentDragOver` event. This event will be continuously triggered when the appointment is being dragged. The `AppointmentDragOverEventArgs` argument contains the following properties.

`Appointment` - Get the appointment that is being dragged.
`DragPoint`- Get the dragging point of the scheduler appointment user interface.
`DragTime` - Get the dragging time of the appointment object being dragged.
`DragResource` - Get the original resource of the appointment that is being dragged.

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
Using the `AppointmentDrop` event you can get the dropping appointment details, position, time and you can handle whether the appointment can be dropped to the specific position or not. This event will trigger after dropping the appointment. The `AppointmentDropEventArgs` argument contains the following properties.

`Appointment` - Get the appointment that is being dragged and dropped.
`DropTime`- Get or set the date and time at which the appointment is being dropped.
`SourceResource` - Get the original resource of the appointment that is being dropped.
`TargetResource` - Get the resource into which the appointment is being dropped.

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
You can change the appointment of drag and drop settings in Scheduler by using the `DragDropSettings` property.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="scheduler" ShowBusyIndicator="True"
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
Using the `AllowNavigate` property of the `DragDropSettings` you can handle whether you can navigate views while dragging the appointment or not. The default value of the AllowNavigate property is `true`.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="Scheduler"
                    View="Week">
<schedule:SfScheduler.DragDropSettings>
    <schedule:DragDropSettings AllowNavigation="False">
    </schedule:DragDropSettings>
</schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DragDropSettings.AllowNavigation = false;
{% endhighlight %}
{% endtabs %}

#### Handle navigation delay for dragged appointment
Using the `AutoNavigationDelay` property you can handle the navigation time when navigating through views while holding the dragged appointment.

{% tabs %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DragDropSettings.AutoNavigationDelay = new TimeSpan(0, 0, 0, 0, 2000);
{% endhighlight %}
{% endtabs %}

#### Handle view scroll when dragging appointment
Using the `AllowScroll` property you can handle scrolling the time slot while dragging the appointment or not, while dragging the appointment to the endpoint of the current view in Schedule. The default value of the `AllowScroll` property is `true`.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="Scheduler"
                    View="Week">
<schedule:SfScheduler.DragDropSettings>
    <schedule:DragDropSettings AllowScroll="False">
    </schedule:DragDropSettings>
</schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DragDropSettings.AllowScroll = false;
{% endhighlight %}
{% endtabs %}

N> This is not applicable for MonthView.

#### Show or hide drag time indicator
You can handle whether the drag and drop indicator should be displayed within the scheduler during appointment dragging by using the `ShowTimeIndicator` property which shows the dragged appointment's current position time. The default value of the `ShowTimeIndicator` property is `true`.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="Scheduler"
                    View="Week">
<schedule:SfScheduler.DragDropSettings>
    <schedule:DragDropSettings ShowTimeIndicator="False">
    </schedule:DragDropSettings>
</schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DragDropSettings.ShowTimeIndicator = false;
{% endhighlight %}
{% endtabs %}

N>
* The drag time indicator is applicable only when the [TimeRulerWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerDaysView.html#Syncfusion_Maui_Scheduler_SchedulerDaysView_TimeRulerWidth) property is greater than zero in Day, Week, and WorkWeek views and the [TimeRulerHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTimelineView.html#Syncfusion_Maui_Scheduler_SchedulerTimelineView_TimeRulerHeight) property is is greater than zero in TimeLineDay, TimeLineWeek, TimeLineWorkWeek views.
* The drag time indicator is not applicable for Month and Timeline Month views.
 
#### Change drag time indicator text style
You can change the drag time indicator style by using the `TimeIndicatorStyle` property of `DragDropSettings`.

{% tabs %}
{% highlight xaml %}
<schedule:SfScheduler x:Name="scheduler" ShowBusyIndicator="True"
                    AppointmentsSource="{Binding DragEvents}"
                    View="Week">
        <schedule:SfScheduler.DragDropSettings>
            <schedule:DragDropSettings TimeIndicatorStyle="{schedule:SchedulerTextStyle TextColor=Green}"/>
        </schedule:SfScheduler.DragDropSettings>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
var timeIndicatorStyle = new SchedulerTextStyle()
{
   TextColor = Colors.Green,
};
this.Scheduler.DragDropSettings.TimeIndicatorStyle = timeIndicatorStyle;
{% endhighlight %}
{% endtabs %}

#### Change drag time indicator format
You can change the drag time indicator format by using the `TimeIndicatorTextFormat` property of `DragDropSettings`.

{% tabs %}
{% highlight c# %}
this.Scheduler.View = SchedulerView.Week;
this.Scheduler.DragDropSettings.TimeIndicatorTextFormat = "hh:mm";
{% endhighlight %}
{% endtabs %}