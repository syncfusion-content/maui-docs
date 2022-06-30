---
layout: post
title: Resource in MAUI Scheduler control | Syncfusion
description:  Learn here all about grouping the appointments based on the resources in the timeline day, timeline week, timeline workweek and timeline month views in Syncfusion .NET MAUI Scheduler (SfScheduler) control.
platform: maui
control: SfScheduler
documentation: ug
---

# Resource in MAUI Scheduler (SfScheduler)

The .NET MAUI Scheduler control allows you to group appointments based on the resources associated with them in the timeline day, timeline week, timeline workweek, and timeline month views, with complete business object binding, multi resource appointment sharing and UI customization features.

## Create Scheduler resources
You can create a resource view by setting the Name, Id, Background, and Foreground property of the SchedulerResource.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineWeek">
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
// Adding schedule resource in the scheduler resource collection.
var resourceCollection = new ObservableCollection<SchedulerResource>()
{
   new SchedulerResource() { Name = "Sophia", Foreground = Colors.Blue, Background = Colors.Green, Id = "1000" },
   new SchedulerResource() { Name = "Zoey Addison",  Foreground = Colors.Blue, Background = Colors.Green, Id = "1001" },
   new SchedulerResource() { Name = "James William",  Foreground = Colors.Blue, Background = Colors.Green, Id = "1002" },
};

// Adding the scheduler resource collection to the schedule resources of SfSchedule.
this.Scheduler.ResourceView.Resources = resourceCollection;
{% endhighlight %}
{% endtabs %}

### Assigning Scheduler resources to appointments

Appointments associated with the scheduler [ResourceCollection]()  will be displayed by setting the schedule resource Id in the [ScheduleAppointment]() by using the [ResourceIdCollection](). For [ResourceGroupType]() set as [Resource]() or [Date](). Also assign the resources to `recurrence appointments.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineWeek">
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
var appointment = new ObservableCollection<SchedulerAppointment>();

//Adding scheduler appointment in the scheduler appointment collection. 
appointment.Add(new SchedulerAppointment()
{
	StartTime = DateTime.Today.AddHours(9),
	EndTime = DateTime.Today.AddHours(11),
	Subject = "Client Meeting",
	Location = "Hutchison road",
	ResourceIds = new ObservableCollection<object>() { "1000", "1001" }
});

//Adding the scheduler appointment collection to the AppointmentsSource of .NET MAUI Scheduler.
this.Scheduler.AppointmentsSource = appointment;
{% endhighlight %}
{% endtabs %}

### Multiple resource sharing using Scheduler resources

Multiple resources can share the same events or appointments. If the appointment details are edited or updated, then the changes will be reflected on all other shared instances simultaneously.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineWeek">
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="9" %}
var appointment = new ObservableCollection<SchedulerAppointment>();

//Adding scheduler appointment in the scheduler appointment collection. 
appointment.Add(new SchedulerAppointment()
{
	StartTime = DateTime.Today.AddHours(9),
	EndTime = DateTime.Today.AddHours(11),
	Subject = "Client Meeting",
	Location = "Hutchison road",
	ResourceIds = new ObservableCollection<object>() { "1000", "1001","1002" }
});

//Adding the scheduler appointment collection to the AppointmentsSource of .NET MAUI Scheduler.
this.Scheduler.AppointmentsSource = appointment;
{% endhighlight %}
{% endtabs %}

## Business object binding for resources

The Schedule supports full data binding to [ResourceCollection](). Specify the [ResourceMapping]() attribute to map the properties in the underlying data source to the schedule resource.

| Property Name | Description |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| Name | Maps the property name of custom class, which is equivalent to Name in ScheduleResource. |
| Id | Maps the property name of custom class, which is equivalent to Id in ScheduleResource. |
| Background | Maps the property name of custom class, which is equivalent to Background in ScheduleResource. |
| Foreground | Maps the property name of custom class, which is equivalent to Foreground in ScheduleResource. |

N> Custom resource class should contain a mandatory field for resource `Id`.

## Mapping resource business object custom field

Create a custom class employee with mandatory fields `Name,` `Id,` `ForegroundColor,` and `BackgroundColor.` Also assign the resources to `recurrence appointments.`

{% tabs %}
{% highlight c# tabtitle="Employee.cs" hl_lines="6" %}
public class Employee
{
   public string Name {get; set;}

   public string Id {get; set;}

   public Brush BackgroundColor {get; set; }

   public Brush ForegroundColor {get; set; }
}

{% endhighlight %}
{% endtabs %}

Map the properties of the `Employee` class with SfScheduler control using the Scheduler `SchedulerResourceMapping.`

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3 4" %}
<scheduler:SfScheduler Name="Schedule" ViewType="TimelineWeek">
<schedule:SfScheduler.ResourceView>
    <schedule:SchedulerResourceView>
        <schedule:SchedulerResourceView.Mapping>
            <schedule:SchedulerResourceMapping Name="Name"
                                            Id="Id"
                                            Background="Background"
                                            Foreground="Foreground"/>
        </schedule:SchedulerResourceView.Mapping>
    </schedule:SchedulerResourceView>
</schedule:SfScheduler.ResourceView>
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="2 7" %}
 // Schedule data mapping for custom resource.
SchedulerResourceMapping resourceMapping = new SchedulerResourceMapping();
resourceMapping.Name = "Name";
resourceMapping.Id = "Id";
resourceMapping.Background = "BackgroundColor";
resourceMapping.Foreground = "ForegroundColor";
this.Scheduler.ResourceView.Mapping = resourceMapping;
{% endhighlight %}
{% endtabs %}

### Assign resource object collection to scheduler

Add the resources of `Employee` collection that can be assigned to the scheduler using the [ResourceCollection]() property which is of `IEnumerable` type. Also add or remove scheduler resources dynamically.

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="2 3 4" %}
<scheduler:SfScheduler Name="Schedule" ViewType="Week" ResourceGroupType="Resource">
    <scheduler:SfScheduler.ResourceMapping>
       <scheduler:ResourceMapping Id="Id" Name="Name" Background="BackgroundColor" Foreground="ForegroundColor"/>
    </scheduler:SfScheduler.ResourceMapping>
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="10" %}
// Creating and Adding custom resource in scheduler resource collection.
var ResourceCollection = new ObservableCollection<Employee>()
{
   new Employee () {Name = "Sophia", Background=Colors.Blue, Id = "1000", Foreground = Colors.Green},
   new Employee () {Name = "Zoey Addison", Background=Colors.Blue, Id = "1001", Foreground = Colors.Green},
   new Employee () {Name = "James William", Background=Colors.Blue, Id = "1002", Foreground = Colors.Green},
};

// Adding the scheduler resource collection to the schedule resources of SfSchedule.
this.Scheduler.ResourceView.Resources = ResourceCollection;
{% endhighlight %}
{% endtabs %}

### Assign the resource objects to appointment business object

Associate the scheduler [ResourceMapping]() to the custom appointment by mapping resource [Id]() in the [ResourceIdCollection]() property of [AppointmentMapping](). The custom appointments associated with the scheduler resources will be displayed when the `ResourceGroupType` is set to `Resource` or `Date.` Also assign the resources to recurrence appointments.

{% tabs %}
{% highlight c# tabtitle="Meeting.cs" %}
/// <summary>   
/// Represents the custom data properties.   
/// </summary> 
public class Meeting
{
	public string EventName {get; set;}
	public DateTime From {get; set;}
	public DateTime To {get; set;}
    public ObservableCollection<object> Resources
}
{% endhighlight %}
{% endtabs %}


Map those properties of the `Meeting` class to schedule appointments by using the `AppointmentMapping` properties.

{%tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2 3 4 5 6 7 8" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineWeek"
                            AppointmentsSource="{Binding Events}"
                            AllowedViews="TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek" >
        <schedule:SfScheduler.AppointmentMapping>
            <schedule:SchedulerAppointmentMapping
                Subject="EventName"
                StartTime="From"
                EndTime="To"
                Background="Background"
                IsAllDay="IsAllDay"
                StartTimeZone="StartTimeZone"
                EndTimeZone="EndTimeZone"
                ResourceIds="Resources"/>
        </schedule:SfScheduler.AppointmentMapping>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPAge.xaml.cs" hl_lines="2 8" %}
//Schedule data mapping for custom appointments
SchedulerAppointmentMapping dataMapping = new SchedulerAppointmentMapping();
dataMapping.Subject = "EventName";
dataMapping.StartTime = "From";
dataMapping.EndTime = "To";
dataMapping.Background = "Color";
dataMapping.ResourceIds = "Resources";
this.Scheduler.AppointmentMapping = dataMapping;
{% endhighlight %}
{% endtabs %}

Schedule meetings for a resource by setting `From,` `To,` and `Resources` of the Meeting class.

{%tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
Meeting meeting = new Meeting ();
meeting.From = new DateTime(2020, 07, 01, 10, 0, 0);
meeting.To = meeting.From.AddHours(1);
meeting.EventName = "Meeting";
meeting.Resources = new ObservableCollection<object> { (Resources[0] as Employee).Id, (Resources[1] as Employee).Id };
var Meetings = new ObservableCollection<Meeting> ();
Meetings.Add(meeting);
this.Schedule.ItemsSource = Meetings;
{% endhighlight %}
{% endtabs %}

## Resource minimum row height
You can customize minimum row height of visible resources in timeline day, timeline week, timeline workweek and timeline month views by using the [MinimumRowHeight]() property of [SchedulerResourceView]() in [SfScheduler.]() By default, esource row height will be auto-expanded from minimum height based on the appointment counts.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="6" %}
<schedule:SfScheduler x:Name="Scheduler"  View="TimelineWeek"
                            AllowedViews="TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek" >
<schedule:SfScheduler.ResourceView>
    <schedule:SchedulerResourceView MinimumRowHeight="90"/>
</schedule:SfScheduler.ResourceView>
</schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
this.Scheduler.ResourceView.MinimumRowHeight = 100;
{% endhighlight %}
{% endtabs %} 

N>
* By default, if the viewport height is greater than 400 then each resource height will be calculated by viewport size divided by the minimum value of scheduler resources count and 4 (default resource count). 
* If the viewport height is lesser than 400 then each resource height will be calculated by default viewport size(4 (default resource*100)) divided by the minimum value of scheduler resources count and 4 (default resource count).
* If the MinimumRowHeight is less than the default row height then the default row height will be used.

## Assign resources to special time regions
Special time region can be created based on the resources in the timeline day, timeline week, timeline workweek, and timeline month views.

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" %}


{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="9" %}
this.Scheduler.DaysView.TimeRegions.Add(new SchedulerTimeRegion
{
	StartTime = new DateTime(2022, 06, 04, 13, 0, 0),
	EndTime = new DateTime(2022, 06, 04, 14, 0, 0),
	Text = "Lunch",
	RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
	ResourceIds = new ObservableCollection<object>() { "1000", "1001", "1002" }
});
{% endhighlight %}
{% endtabs %}

## Programmatic resource selection
You can programmatically select the resource by using the ResourceId and SelectedDate of the SfScheduler. Please [click]() here to see more details about programmatic date selection.

## Appearance customization

The resource appearance customization can be achieved by using the [ResourceHeaderTemplate]() property of the [SfScheduler]().

#### Customize resource appearance using ResourceHeaderTemplate

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="28" %}

<ContentPage.Behaviors>
    <local:ResourceViewBehavior/>
</ContentPage.Behaviors>
    
<Grid>
    <schedule:SfScheduler x:Name="Scheduler"  View="TimelineMonth"
                                AppointmentsSource="{Binding Events}"
                                AllowedViews="TimelineDay,TimelineMonth,TimelineWeek,TimelineWorkWeek" >

        <schedule:SfScheduler.Resources>
            <local:SfImageSourceConverter x:Key="imageConverter"/>
        </schedule:SfScheduler.Resources>
        <schedule:SfScheduler.ResourceView>
            <schedule:SchedulerResourceView Resources="{Binding Resources}">
                <schedule:SchedulerResourceView.HeaderTemplate>
                    <DataTemplate>
                        <StackLayout Padding="5" Orientation="Vertical" VerticalOptions="Center" HorizontalOptions="Fill">
                            <Border StrokeThickness="5"
                                        Stroke="{Binding Background}"
                                        HorizontalOptions="Center"
                                        HeightRequest="{OnIdiom Desktop = 70, Phone = 65}"
                                        WidthRequest="{OnIdiom Desktop= 70, Phone=65}">
                                <Border.StrokeShape>
                                    <RoundRectangle CornerRadius="150"/>
                                </Border.StrokeShape>
                                <Image WidthRequest="{OnIdiom Desktop = 55, Phone = 50}"
                                            HeightRequest="{OnIdiom Desktop = 55, Phone = 50}"
                                            HorizontalOptions="Center"
                                            Source="{Binding DataItem.ImageName,Converter={StaticResource imageConverter}}" 
                                            VerticalOptions="Center"
                                    Aspect="Fill"/>
                            </Border>
                            <Label Text="{Binding Name}" TextColor="Black" FontSize="{OnIdiom Desktop= 12, Phone=10}" VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
                        </StackLayout>
                    </DataTemplate>
                </schedule:SchedulerResourceView.HeaderTemplate>

                <schedule:SchedulerResourceView.Mapping>
                    <schedule:SchedulerResourceMapping Name="Name"
                                                    Id="Id"
                                                    Background="Background"
                                                    Foreground="Foreground"/>
                </schedule:SchedulerResourceView.Mapping>
            </schedule:SchedulerResourceView>
        </schedule:SfScheduler.ResourceView>

        <schedule:SfScheduler.AppointmentMapping>
            <schedule:SchedulerAppointmentMapping
                Subject="EventName"
                StartTime="From"
                EndTime="To"
                Background="Background"
                IsAllDay="IsAllDay"
                StartTimeZone="StartTimeZone"
                EndTimeZone="EndTimeZone"
                ResourceIds="Resources"/>
        </schedule:SfScheduler.AppointmentMapping>

        <schedule:SfScheduler.TimelineView>
            <schedule:SchedulerTimelineView
                    StartHour="8"
                    EndHour="20"/>
        </schedule:SfScheduler.TimelineView>

        <schedule:SfScheduler.BindingContext>
            <local:ResourceViewViewModel/>
        </schedule:SfScheduler.BindingContext>

    </schedule:SfScheduler>

</Grid>
{% endhighlight %}
{% endtabs %}
