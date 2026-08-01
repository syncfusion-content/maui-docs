---
layout: post
title: Events support in .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn all about Events support in Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Events in .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.html) supports the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#events) event to interact with .NET MAUI smart Scheduler.

## AssistAppointmentResponseCompleted Event

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.html) control raises the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#events) event when an appointment is created or modified through AI assistance. The appointment, assistant response, handled state, and action are passed through the [AssistAppointmentResponseCompletedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.AssistAppointmentResponseCompletedEventArgs.html). This argument provides the following details:

 * [Appointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html) : The appointment details as a `SchedulerAppointment` object containing all appointment properties (Subject, StartTime, EndTime, etc.).
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartScheduler_AssistAppointmentResponseCompletedEventArgs_Handled) : A boolean value (default: `false`) indicating whether the event has been handled. Set to `true` to prevent the default appointment handling behavior.
 * [AssistantResponse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartScheduler_AssistAppointmentResponseCompletedEventArgs_AssistantResponse) : The text response from the AI assistant describing the appointment action (e.g., "Meeting scheduled for tomorrow at 2 PM").
 * [Action](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartScheduler_AssistAppointmentResponseCompletedEventArgs_Action) : An `AppointmentAction` enum value indicating the operation: `Add`, `Edit`, or `Delete`.

The following example demonstrates how to handle the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#events) event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="5" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartScheduler;assembly=Syncfusion.Maui.SmartScheduler">
    <smartScheduler:SfSmartScheduler x:Name="smartScheduler"
                                     AssistAppointmentResponseCompleted="OnAssistAppointmentResponseCompleted"/>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

using Syncfusion.Maui.SmartScheduler;

. . .
private void OnAssistAppointmentResponseCompleted(object sender, AssistAppointmentResponseCompletedEventArgs e)
{
    SchedulerAppointment? appointment = e.Appointment;
    string response = e.AssistantResponse;
    if (e.Action == AppointmentAction.Add)
    {
        e.Handled = true;
    }
}

{% endhighlight %}
{% endtabs %}