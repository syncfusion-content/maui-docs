---
layout: post
title: Appointment Tooltip in .NET MAUI Scheduler | Syncfusion
description: Learn how to show appointment tooltips in the Syncfusion .NET MAUI Scheduler to quickly view details and customize tooltip appearance and behavior.
platform: maui
control: SfScheduler
documentation: ug
keywords : .net maui scheduler, .net maui scheduler appointment tooltip, .net maui appointment details tooltip, .net maui scheduler tooltip customization, .net maui scheduler tooltip behavior.
---

# Appointment Tooltip in .NET MAUI SfScheduler

The appointment tooltip provides a quick, contextual preview of scheduled events. By default, the [IsAppointmentToolTipEnabled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_IsAppointmentToolTipEnabled) property is set to `false`. To display appointment details such as the subject, start time, and end time when hovering over or tapping an appointment, set the `IsAppointmentToolTipEnabled` property to `true`.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="4" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:scheduler="clr-namespace:Syncfusion.Maui.Scheduler;assembly=Syncfusion.Maui.Scheduler"
             x:Class="GettingStarted.MainPage">
    <scheduler:SfScheduler x:Name="scheduler" 
                           View="Day" 
                           IsAppointmentToolTipEnabled="True">
    </scheduler:SfScheduler>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="7" %}
using Syncfusion.Maui.Scheduler;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.scheduler.IsAppointmentToolTipEnabled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Appointment-Tooltip-in-.NET-MAUI-SfScheduler](images/appointment-tooltip/appointment-tooltip.png)

N>
- **Desktop platforms**: A tooltip is shown when you hover the mouse over an appointment.
- **Mobile platforms**: A tooltip is shown when you tap or long‑press an appointment. For long‑press interactions, the tooltip appears only when [appointment dragging](appointment-drag-and-drop.md) is disabled.
- **Version**: `IsAppointmentToolTipEnabled`, `AppointmentToolTipSettings`, and `AppointmentToolTipTemplate` are available from Syncfusion .NET MAUI Scheduler `v21.2.3` onwards. Requires .NET MAUI 7.0 or higher.

## Appointment Tooltip Settings

The [AppointmentToolTipSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AppointmentToolTipSettings) property allows you to customize the appearance and behavior of appointment tooltips. The following settings can be configured:
 
- **Background** – Defines the background color of the tooltip. Accepts a `Color` value (for example, a named color such as `"PaleGreen"`, `Colors.PaleGreen`, or a hex string) or a `Brush` value (for example, `SolidColorBrush`, `LinearGradientBrush`).
 
- **TextStyle** – Specifies the text styling of the tooltip content. The [`SchedulerTextStyle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerTextStyle.html) exposes `TextColor`, `FontSize`, `FontAttributes`, `FontFamily`, `FontAutoScalingEnabled`, `LineBreakMode`, and other text-related properties.
 
- **Padding** – Specifies the spacing inside the tooltip.
 
- **ToolTipPosition** – Determines the placement of the tooltip relative to the appointment. Supported values are defined by the [`SchedulerToolTipPosition`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerToolTipPosition.html) enum and include Auto (default), Left, Right, Top, and Bottom.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="4 5 6 7 8 9 10 11 12 13" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:scheduler="clr-namespace:Syncfusion.Maui.Scheduler;assembly=Syncfusion.Maui.Scheduler"
             x:Class="GettingStarted.MainPage">
    <scheduler:SfScheduler x:Name="scheduler" 
                           View="Day" 
                           IsAppointmentToolTipEnabled="True">
        <scheduler:SfScheduler.AppointmentToolTipSettings>
            <scheduler:AppointmentToolTipSettings Background="PaleGreen" Padding="5" ToolTipPosition="Right">
                <scheduler:AppointmentToolTipSettings.TextStyle>
                    <scheduler:SchedulerTextStyle TextColor="Purple" FontSize="15" FontAttributes="Bold"/>
                </scheduler:AppointmentToolTipSettings.TextStyle>
            </scheduler:AppointmentToolTipSettings>
        </scheduler:SfScheduler.AppointmentToolTipSettings>
    </scheduler:SfScheduler>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="C#" hl_lines="3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27" %}
using Syncfusion.Maui.Scheduler;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.scheduler.IsAppointmentToolTipEnabled = true;
            this.scheduler.AppointmentToolTipSettings = new AppointmentToolTipSettings()
            {
                Background = Colors.PaleGreen,
                Padding = new Thickness(5),
                ToolTipPosition = SchedulerToolTipPosition.Right,
                TextStyle = new SchedulerTextStyle
                {
                    TextColor = Colors.Purple,
                    FontSize = 15,
                    FontAttributes = FontAttributes.Bold
                }
            };
        }
    }
}
{% endhighlight %}
{% endtabs %}

![Appointment-Tooltip-Settings-in-.NET-MAUI-SfScheduler](images/appointment-tooltip/appointment-tooltip-settings.png)

## Appointment ToolTip Template

The [AppointmentToolTipTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_AppointmentToolTipTemplate) property lets you create a custom tooltip layout for appointments, allowing you to display additional information or change the tooltip’s appearance as needed.

{% tabs %}
{% highlight xaml tabtitle="XAML" hl_lines="4 5 6 7 8 9 10 11 12 13 50 51 52" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:scheduler="clr-namespace:Syncfusion.Maui.Scheduler;assembly=Syncfusion.Maui.Scheduler"
             x:Class="GettingStarted.MainPage">
    <scheduler:SfScheduler x:Name="scheduler" 
                           View="Day" 
                           IsAppointmentToolTipEnabled="True">

        <scheduler:SfScheduler.AppointmentToolTipSettings>
            <scheduler:AppointmentToolTipSettings ToolTipPosition="Left"/>
        </scheduler:SfScheduler.AppointmentToolTipSettings>

        <scheduler:SfScheduler.AppointmentToolTipTemplate>
            <DataTemplate x:DataType="scheduler:SchedulerAppointment">
                <Grid ColumnDefinitions="Auto,*">
                    <BoxView Grid.Column="0"
                             Background="{Binding Background}"
                             WidthRequest="10"
                             HorizontalOptions="Start"
                             VerticalOptions="Fill"
                             Margin="0,0,5,0" />

                    <VerticalStackLayout Grid.Column="1" Spacing="5">
                        <Label Text="{Binding Subject}"
                               FontAttributes="Bold"
                               FontSize="12"
                               TextColor="White"
                               LineBreakMode="TailTruncation"
                               MaxLines="2"
                               Margin="0,0,0,5" />

                        <HorizontalStackLayout Spacing="4">
                            <Label Text="Start Time: "
                                   FontAttributes="Bold"
                                   FontSize="12"
                                   TextColor="White" />
                            <Label Text="{Binding StartTime, StringFormat='{0:MM/dd/yyyy}'}"
                                   FontSize="12"
                                   TextColor="White" />
                        </HorizontalStackLayout>

                        <HorizontalStackLayout Spacing="4">
                            <Label Text="End Time: "
                                   FontAttributes="Bold"
                                   FontSize="12"
                                   TextColor="White" />
                            <Label Text="{Binding EndTime, StringFormat='{0:MM/dd/yyyy}'}"
                                   FontSize="12"
                                   TextColor="White" />
                        </HorizontalStackLayout>
                    </VerticalStackLayout>
                </Grid>
            </DataTemplate>
        </scheduler:SfScheduler.AppointmentToolTipTemplate>
    </scheduler:SfScheduler>
</ContentPage>
{% endhighlight %}
{% endtabs %}

![Appointment-Tooltip-Template-in-.NET-MAUI-SfScheduler](images/appointment-tooltip/appointment-tooltip-template.png)

### Sample AppointmentsSource for the Template Example

Because the template uses `x:DataType="scheduler:SchedulerAppointment"`, the `AppointmentsSource` must be a collection of `SchedulerAppointment` objects. Add the following collection to your code-behind or view model:

```csharp
using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            scheduler.AppointmentsSource = new ObservableCollection<SchedulerAppointment>
            {
                new SchedulerAppointment
                {
                    Subject = "Team Sync",
                    StartTime = DateTime.Today.AddHours(10),
                    EndTime   = DateTime.Today.AddHours(11),
                    Background = new SolidColorBrush(Colors.Teal)
                }
            };
        }
    }
}
```

> If you need to use a custom business object (for example, a `Meeting` POCO), map its properties to `SchedulerAppointment` using [SchedulerAppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html). See [Appointments](appointments.md) for details.

### Set the Appointment Tooltip Template in C#

You can also set `AppointmentToolTipTemplate` programmatically using [`DataTemplate`](https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate). When the bound items are `SchedulerAppointment` objects, you can bind directly without setting `x:DataType`:

```csharp
using Syncfusion.Maui.Scheduler;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.scheduler.IsAppointmentToolTipEnabled = true;
            this.scheduler.AppointmentToolTipTemplate = new DataTemplate(() =>
            {
                var subject = new Label
                {
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 12,
                    TextColor = Colors.White
                };
                subject.SetBinding(Label.TextProperty, "Subject");
                return subject;
            });
        }
    }
}
```

## Troubleshooting

- **Tooltip does not appear on tap or hover** – Verify `IsAppointmentToolTipEnabled` is set to `true` on `SfScheduler`.
- **Tooltip never appears on long‑press (mobile)** – Disable appointment dragging, as the long‑press gesture is reserved for drag operations.
- **Custom template bindings show empty values** – Make sure the bound `DataTemplate` uses `x:DataType="scheduler:SchedulerAppointment"` and that the bound properties exist on the underlying appointment model.
- **Bindings are empty when using a custom business object (POCO)** – The template binds to `SchedulerAppointment` properties. Either change `AppointmentsSource` to a `SchedulerAppointment` collection, or configure [SchedulerAppointmentMapping](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointmentMapping.html) to map your POCO fields.
- **AOT/iOS runtime errors with custom appointment data** – When publishing in AOT mode on iOS and macOS, add `[Preserve(AllMembers = true)]` to your custom data model so the binding reflection works at runtime.

See also: [Appointment Drag and Drop](appointment-drag-and-drop.md), [Scheduler Getting Started](getting-started.md), [Appointments](appointments.md).