---
layout: post
title: Methods support in .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn here all about methods support in Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Methods in .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The [SfSmartScheduler](https://www.syncfusion.com/scheduler-sdk/maui-smart-scheduler) control provides three methods for programmatically managing the AI assistant view:

- **[ResetAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#Syncfusion_Maui_SmartScheduler_SfSmartScheduler_ResetAssistView)** — Clears the assistant view and resets it to its initial state (`void`)
- **[CloseAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#Syncfusion_Maui_SmartScheduler_SfSmartScheduler_CloseAssistView)** — Hides the AI assistant panel (`void`)
- **[OpenAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartScheduler.SfSmartScheduler.html#Syncfusion_Maui_SmartScheduler_SfSmartScheduler_OpenAssistView)** — Displays the AI assistant panel (`void`)

All methods are synchronous and do not require parameters or throw exceptions under normal conditions.

## Reset AI Assistant View

The `ResetAssistView` method clears the AI assistant view and resets it to its initial state. Use this to start a new conversation or clear previous assistant interactions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartScheduler;assembly=Syncfusion.Maui.SmartScheduler">

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="50"/>
        </Grid.RowDefinitions>
        <smartScheduler:SfSmartScheduler x:Name="smartScheduler" Grid.Row="0"/>
        <Button Grid.Row="1" Text="Reset Assistant" Clicked="OnResetClicked"/>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6"  %}

using Syncfusion.Maui.SmartScheduler;
. . .

private void OnResetClicked(object sender, EventArgs e)
{
    this.smartScheduler.ResetAssistView();
}

{% endhighlight %}
{% endtabs %}

## Close AI Assistant View

The `CloseAssistView` method hides the AI assistant panel while preserving its state. The assistant view can be reopened later without losing the current conversation.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartScheduler;assembly=Syncfusion.Maui.SmartScheduler">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="50"/>
        </Grid.RowDefinitions>
        <smartScheduler:SfSmartScheduler x:Name="smartScheduler" Grid.Row="0"/>
        <Button Grid.Row="1" Text="Close Assistant" Clicked="OnCloseClicked"/>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6"  %}

using Syncfusion.Maui.SmartScheduler;
. . .

private void OnCloseClicked(object sender, EventArgs e)
{
    this.smartScheduler.CloseAssistView();
}

{% endhighlight %}
{% endtabs %}

## Open AI Assistant View

The `OpenAssistView` method displays the AI assistant panel. Use this after calling `CloseAssistView` to reopen the assistant, or to programmatically trigger the assistant display in response to user actions.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

<ContentPage   
    . . .
    xmlns:smartScheduler="clr-namespace:Syncfusion.Maui.SmartScheduler;assembly=Syncfusion.Maui.SmartScheduler">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="50"/>
        </Grid.RowDefinitions>
        <smartScheduler:SfSmartScheduler x:Name="smartScheduler" Grid.Row="0"/>
        <Button Grid.Row="1" Text="Open Assistant" Clicked="OnOpenClicked"/>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6"  %}

using Syncfusion.Maui.SmartScheduler;
. . .

private void OnOpenClicked(object sender, EventArgs e)
{
    this.smartScheduler.OpenAssistView();
}

{% endhighlight %}
{% endtabs %}