---
layout: post
title: Events support in .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn here all about Events support in Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Events in .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The `SfSmartScheduler` supports the `AssistAppointmentResponseCompleted` event to interact with .NET MAUI smart Scheduler.

## AssistAppointmentResponseCompleted Event

The `SfSmartScheduler` control provides the `AssistAppointmentResponseCompleted` to respond an appointment is created or modified through AI assistance. The appointment, assistant response, handled and action are passed through the `AssistAppointmentResponseCompletedEventArgs`. This argument provides the following details:

 * [Appointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html) : The appointment details.
 * `Handled` : The value indicates whether the event is handled or not.
 * `AssistantResponse` : The appointment response.
 * `Action` : The action indicates whether the appointment is added, edited or deleted.

The following example demonstrates how to handle the `AssistAppointmentResponseCompleted` event.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<smartScheduler:SfSmartScheduler x:Name="smartScheduler" 
                                 AssistAppointmentResponseCompleted="OnAssistAppointmentResponseCompleted"/>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

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