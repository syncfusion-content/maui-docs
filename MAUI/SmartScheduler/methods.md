---
layout: post
title: Methods support in .NET MAUI AI-Powered Scheduler control | Syncfusion
description: Learn here all about methods support in Syncfusion<sup>&reg;</sup> .NET MAUI AI-Powered Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Methods in .NET MAUI AI-Powered Scheduler (SfSmartScheduler)

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) supports the [ResetAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_ResetAssistView), [CloseAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_CloseAssistView) and [OpenAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_OpenAssistView) methods to reset, close or open assist view programmatically.

## Reset assist view

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) control provides the [ResetAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_ResetAssistView) method to reset assist view programmatically.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition/>
        <RowDefinition Height="50"/>
    </Grid.RowDefinitions>
    <smartScheduler:SfSmartScheduler x:Name="smartScheduler"/>
    <Button Grid.Row="1" Text="Reset assistant" Clicked="Button_Clicked"/>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3"  %}
private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.ResetAssistView();
}

{% endhighlight %}
{% endtabs %}

## Close assist view

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) control provides the [CloseAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_CloseAssistView) method to close assist view programmatically.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition/>
        <RowDefinition Height="50"/>
    </Grid.RowDefinitions>
    <smartScheduler:SfSmartScheduler x:Name="smartScheduler"/>
    <Button Grid.Row="1" Text="Close assistant" Clicked="Button_Clicked"/>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3"  %}
private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.CloseAssistView();
}

{% endhighlight %}
{% endtabs %}

## Open assist view

The [SfSmartScheduler](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html) control provides the [OpenAssistView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SmartComponents.SfSmartScheduler.html#Syncfusion_Maui_SmartComponents_SfSmartScheduler_OpenAssistView) method to open assist view programmatically.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<Grid>
    <Grid.RowDefinitions>
        <RowDefinition/>
        <RowDefinition Height="50"/>
    </Grid.RowDefinitions>
    <smartScheduler:SfSmartScheduler x:Name="smartScheduler"/>
    <Button Grid.Row="1" Text="Open assistant" Clicked="Button_Clicked"/>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3"  %}
private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.OpenAssistView();
}

{% endhighlight %}
{% endtabs %}