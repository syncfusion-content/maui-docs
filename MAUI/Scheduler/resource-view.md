---
layout: post
title: Resource in MAUI Scheduler control | Syncfusion
description:  Learn here all about grouping the appointments based on the resources in the day, week, and timeline views in Syncfusion WinUI Scheduler (SfScheduler) control.
platform: maui
control: SfScheduler
documentation: ug
---

# Resource in MAUI Scheduler (SfScheduler)

The scheduler resource view will allow the group appointments based on the resources or dates, arranged by the column, or row in the day, week, workweek, timeline day, timeline week, timeline workweek, and timeline month views. It also allows to share the events or appointments to the multiple resources and resource appointment details that can be edited by using a built-in appointment editor dialog.

## Assigning resources to appointments

Appointments associated with the scheduler [ResourceCollection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceCollection)  will be displayed by setting the schedule resource Id in the [ScheduleAppointment](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html) by using the [ResourceIdCollection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html#Syncfusion_UI_Xaml_Scheduler_ScheduleAppointment_ResourceIdCollection). For [ResourceGroupType](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ResourceGroupType.html) set as [Resource](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ResourceGroupType.html#Syncfusion_UI_Xaml_Scheduler_ResourceGroupType_Resource) or [Date](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ResourceGroupType.html#Syncfusion_UI_Xaml_Scheduler_ResourceGroupType_Date). Also assign the resources to `recurrence appointments.`

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="3" %}

{% include_relative code-snippet/resourceview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="9" %}
// Creating an instance for the schedule appointment collection.
var scheduleAppointmentCollection = new ScheduleAppointmentCollection();
//Adding schedule appointment in the schedule appointment collection. 
var appointments = new ScheduleAppointment()
{
    StartTime = DateTime.Now,
    EndTime = DateTime.Now.AddHours(2),
    Subject = "General Meeting",
    ResourceIdCollection = new ObservableCollection<object>() { "1000", "1001" }
};
//Adding the schedule appointment to the schedule appointment collection.
scheduleAppointmentCollection.Add(appointments);
//Adding the schedule appointment collection to the ItemsSource of SfScheduler.
this.Schedule.ItemsSource = scheduleAppointmentCollection;
{% endhighlight %}
{% endtabs %}

#### Multiple resource sharing

Multiple resources can share the same events or appointments. If the appointment details are edited or updated, then the changes will be reflected on all other shared instances simultaneously.

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="3" %}

{% include_relative code-snippet/resourceview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="9" %}
// Creating an instance for schedule appointment collection.
var scheduleAppointmentCollection = new ScheduleAppointmentCollection();
//Adding schedule appointment in the schedule appointment collection. 
var appointments = new ScheduleAppointment()
{
   StartTime = DateTime.Now,
   EndTime = DateTime.Now.AddHours(2),
   Subject = "General Meeting",
   ResourceIdCollection = new ObservableCollection<object>() { "1000", "1001","1002" },
   AppointmentBackground = new SolidColorBrush(Color.FromArgb(255, 133, 81, 242)),
};
//Adding the schedule appointment to the schedule appointment collection.
scheduleAppointmentCollection.Add(appointments);
//Adding the schedule appointment collection to the ItemsSource of SfScheduler.
this.Schedule.ItemsSource = scheduleAppointmentCollection;
{% endhighlight %}
{% endtabs %}

![multiple-resource-sharing-resourcegroup-as-resource-week-view-in-winui-scheduler](Resource_Images/multiple-resource-sharing-resourcegroup-as-resource-week-view-in-winui-scheduler.png)

![multiple-resource-sharing-resourcegroup-as-resource-timelineweek-view-in-winui-scheduler](Resource_Images/multiple-resource-sharing-resourcegroup-as-resource-timelineweek-view-in-winui-scheduler.png)

## Scheduler resource mapping

The Schedule supports full data binding to [ResourceCollection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceCollection). Specify the [ResourceMapping](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ResourceMapping.html) attribute to map the properties in the underlying data source to the schedule resource.

| Property Name | Description |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| Name | Maps the property name of custom class, which is equivalent to Name in ScheduleResource. |
| Id | Maps the property name of custom class, which is equivalent to Id in ScheduleResource. |
| Background | Maps the property name of custom class, which is equivalent to Background in ScheduleResource. |
| Foreground | Maps the property name of custom class, which is equivalent to Foreground in ScheduleResource. |

N> Custom resource class should contain a mandatory field for resource `Id`.

## Create business object for resource

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

Map the properties of the `Employee` class with SfScheduler control using the Scheduler `ResourceMapping.`

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="2 3 4" %}
<scheduler:SfScheduler Name="Schedule" ViewType="Week" ResourceGroupType="Resource">
    <scheduler:SfScheduler.ResourceMapping>
       <scheduler:ResourceMapping Id="Id" Name="Name" Background="BackgroundColor" Foreground="ForegroundColor"/>
    </scheduler:SfScheduler.ResourceMapping>
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="2 7" %}
 // Schedule data mapping for custom resource.
ResourceMapping resourceMapping = new ResourceMapping();
resourceMapping.Name = "Name";
resourceMapping.Id = "Id";
resourceMapping.Background = "BackgroundColor";
resourceMapping.Foreground = "ForegroundColor";
this.Schedule.ResourceMapping = resourceMapping;
{% endhighlight %}
{% endtabs %}

#### Assign resource object collection

Add the resources of `Employee` collection that can be assigned to the scheduler using the [ResourceCollection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceCollection) property which is of `IEnumerable` type. Also add or remove scheduler resources dynamically.

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
   new Employee () {Name = "Sophia", BackgroundColor = new SolidColorBrush((Color.FromArgb(255, 157, 101, 201))), Id = "1000", ForegroundColor = new SolidColorBrush(Colors.White) },
   new Employee () {Name = "Zoey Addison", BackgroundColor = new SolidColorBrush(Color.FromArgb(255, 240, 138, 93)), Id = "1001" , ForegroundColor = new SolidColorBrush(Colors.White)},
   new Employee () {Name = "James William", BackgroundColor = new SolidColorBrush(Color.FromArgb(255,103, 155, 155)), Id = "1002" , ForegroundColor = new SolidColorBrush(Colors.White)},
};

// Adding the scheduler resource collection to the schedule resources of SfSchedule.
this.Schedule.ResourceCollection = ResourceCollection;
{% endhighlight %}
{% endtabs %}

#### Assign the resource objects to appointment business object

Associate the scheduler [ResourceMapping](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.ResourceMapping.html) to the custom appointment by mapping resource [Id](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html#Syncfusion_UI_Xaml_Scheduler_ScheduleAppointment_Id) in the [ResourceIdCollection](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html#Syncfusion_UI_Xaml_Scheduler_ScheduleAppointment_ResourceIdCollection) property of [AppointmentMapping](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.AppointmentMapping.html). The custom appointments associated with the scheduler resources will be displayed when the `ResourceGroupType` is set to `Resource` or `Date.` Also assign the resources to recurrence appointments.

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
   public ObservableCollection<object> Resources {get; set;}
}
{% endhighlight %}
{% endtabs %}


Map those properties of the `Meeting` class to schedule appointments by using the `AppointmentMapping` properties.

{%tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="2 3 4 5 6 7 8" %}
<scheduler:SfScheduler x:Name="Schedule" ItemsSource="{Binding Appointments}" ViewType="Week">
         <scheduler:SfScheduler.AppointmentMapping>
            <scheduler:AppointmentMapping
            Subject="EventName"
            StartTime="From"
            EndTime="To"
            ResourceIdCollection ="Resources"/>
        </scheduler:SfScheduler.AppointmentMapping>
</scheduler:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="2 8" %}
//Schedule data mapping for custom appointments
AppointmentMapping dataMapping = new AppointmentMapping();
dataMapping.Subject = "EventName";
dataMapping.StartTime = "From";
dataMapping.EndTime = "To";
dataMapping.AppointmentBackground = "Color";
dataMapping.ResourceIdCollection= "Resources";
this.Schedule.AppointmentMapping = dataMapping;
{% endhighlight %}
{% endtabs %}

Schedule meetings for a resource by setting `From,` `To,` and `Resources` of the Meeting class.

{%tabs %}
{% highlight c# tabtitle="MainWindow.xaml.cs" %}
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

## Resource minimum height
You can customize minimum row height of visible resources in timeline day, timeline week, timeline workweek and timeline month views by using the [RowMinHeight](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.TimelineViewSettings.html#Syncfusion_UI_Xaml_Scheduler_TimelineViewSettings_RowMinHeight) property of [TimelineViewSettings](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.TimelineViewSettings.html) in [SfScheduler.](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html) By default, value of this property is set to 50.

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="6" %}
<Schedule:SfScheduler Name="schedule" 
                      ViewType="TimelineWeek" 
                      ResourceGroupType="Resource">
   <Schedule:SfScheduler.TimelineViewSettings>
      <Schedule:TimelineViewSettings 
                     RowMinHeight="100" />
   </Schedule:SfScheduler.TimelineViewSettings>
</Schedule:SfScheduler>
{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" %}
 schedule.TimelineViewSettings.RowMinHeight = 100;
{% endhighlight %}
{% endtabs %} 

N> The minimum resource row height adjusted based on view port size and the [VisibleResourceCount](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.ViewSettingsBase.html#Syncfusion_UI_Xaml_Scheduler_ViewSettingsBase_VisibleResourceCount) will not be applicable. 

## Assign resources to special time regions

Special time region can be created based on the resources in the day, week, workweek, timeline day, timeline week, timeline workweek, and timeline month views.

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" %}

{% include_relative code-snippet/resourceview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="9" %}
this.Schedule.DaysViewSettings.SpecialTimeRegions.Add(new SpecialTimeRegion
{
   StartTime = new System.DateTime(2021, 04, 04, 13, 0, 0),
   EndTime = new System.DateTime(2021, 04, 04, 14, 0, 0),
   Text = "Lunch",
   CanEdit = false,
   RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
   CanMergeAdjacentRegions = false,
   ResourceIdCollection = new ObservableCollection<object>() { "1000", "1001", "1002" }
});
{% endhighlight %}
{% endtabs %}

![assign-resources-to-special-time-regions-date-basis-in-winui-scheduler](Resource_Images/resources-to-special-time-regions-date-basis-in-winui-scheduler.png)

#### Assign resources to special time regions in timeline view
{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" %}

{% include_relative code-snippet/resourceview.xaml %}

{% endhighlight %}
{% highlight c# tabtitle="MainWindow.xaml.cs" hl_lines="9" %}
this.Schedule.TimelineViewSettings.SpecialTimeRegions.Add(new SpecialTimeRegion
{
   StartTime = new System.DateTime(2021, 04, 04, 13, 0, 0),
   EndTime = new System.DateTime(2021, 04, 04, 14, 0, 0),
   Text = "Lunch",
   CanEdit = false,
   RecurrenceRule = "FREQ=DAILY;INTERVAL=1",
   CanMergeAdjacentRegions = false,
   ResourceIdCollection = new ObservableCollection<object>() { "1000", "1001", "1002" }
});
{% endhighlight %}
{% endtabs %}

![assign-resources-to-special-time-regions-timeline-view-in-winui-scheduler](Resource_Images/resources-to-special-time-regions-timeline-view-in-winui-scheduler.png)

## Appearance customization

The resource appearance customization can be achieved by using the [ResourceHeaderTemplate](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplate) and [ResourceHeaderTemplateSelector](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplateSelector) properties of the [SfScheduler](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html).

#### Customize resource appearance using ResourceHeaderTemplate

{% tabs %}
{% highlight xaml tabtitle="MainWindow.xaml" hl_lines="28" %}
<!--used to find Image Source and Name properties.-->
<Grid>
   <Grid.DataContext>
      <local:Employee />
   </Grid.DataContext>
   <Grid.Resources>
      <DataTemplate  x:Key="DayViewResourceTemplate">
         <Grid Background="Transparent">
            <Border Background="Transparent" >
               <StackPanel VerticalAlignment="Center" Orientation="Vertical">
                  <Border CornerRadius="36" Height="72" Width="72" BorderThickness="4" BorderBrush="{Binding Data.BackgroundBrush}">
                        <Border CornerRadius="36" Height="64" Width="64" BorderThickness="4" BorderBrush="White">
                        <Image HorizontalAlignment="Center" VerticalAlignment="Center" Width="55"
                          Height="55" Source="{Binding Data.ImageSource}" />
                        </Border>
                  </Border>
                  <TextBlock HorizontalAlignment="Center" VerticalAlignment="Center" FontSize="15"
                  Foreground="Black" Text="{Binding Data.Name}" />
               </StackPanel>
            </Border>
         </Grid>
      </DataTemplate>
   </Grid.Resources>
   <scheduler:SfScheduler x:Name="Schedule"  
                          ViewType="Week"
                          ResourceGroupType="Resource" 
                          ResourceCollection="{Binding ResourceCollection}"
                          ResourceHeaderTemplate="{StaticResource DayViewResourceTemplate}">
      <scheduler:SfScheduler.ResourceMapping>
         <scheduler:ResourceMapping Id="Id" Name="Name" Background="BackgroundBrush" Foreground="ForegroundBrush"/>
      </scheduler:SfScheduler.ResourceMapping>
   </scheduler:SfScheduler>
</Grid>
{% endhighlight %}
{% endtabs %}

![customize-resource-appearance-using-resource-header-template-in-winui-scheduler](Resource_Images/customize-resource-appearance-using-resource-header-template-in-winui-scheduler.png)
