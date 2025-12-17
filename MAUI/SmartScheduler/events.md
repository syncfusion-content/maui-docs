---
layout: post
title: Events support in .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn here all about Events support in Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Events in .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) supports the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_AssistAppointmentResponseCompleted) event to interact with .NET MAUI smart Scheduler.

## AssistAppointmentResponseCompleted Event

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) control provides the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_AssistAppointmentResponseCompleted) to respond an appointment is created or modified through AI assistance. The appointment, assistant response, handled and action are passed through the [AssistAppointmentResponseCompletedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistAppointmentResponseCompletedEventArgs.html). This argument provides the following details:

 * [Appointment](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SchedulerAppointment.html) : The appointment details.
 * [Handled](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartComponents_AssistAppointmentResponseCompletedEventArgs_Handled) : The value indicates whether the event is handled or not.
 * [AssistantResponse](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartComponents_AssistAppointmentResponseCompletedEventArgs_AssistantResponse) : The appointment response.
 * [Action](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.AssistAppointmentResponseCompletedEventArgs.html#Syncfusion_Maui_SmartComponents_AssistAppointmentResponseCompletedEventArgs_Action) : The action indicates whether the appointment is added, edited or deleted.

The following example demonstrates how to handle the [AssistAppointmentResponseCompleted](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_AssistAppointmentResponseCompleted) event.

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