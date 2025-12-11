---
layout: post
title: Methods support in .NET MAUI Smart Scheduler control | Syncfusion
description: Learn here all about methods support in Syncfusion<sup>&reg;</sup> .NET MAUI Smart Scheduler(SfSmartScheduler) control.
platform: MAUI
control: SfSmartScheduler
documentation: ug
---

# Methods in .NET MAUI Smart Scheduler (SfSmartScheduler)

The `SfSmartScheduler` supports the `ResetAssistView`, `CloseAssistView` and `OpenAssistView` methods to reset, close or open assist view programmatically.

## Reset assist view

The `SfSmartScheduler` control provides the `ResetAssistView()` method to reset assist view programmatically using an event.

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4"  %}

private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.ResetAssistView();
}

{% endhighlight %}
{% endtabs %}

## Close assist view

The `SfSmartScheduler` control provides the `CloseAssistView()` method to close assist view programmatically using an event.

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4"  %}

private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.CloseAssistView();
}

{% endhighlight %}
{% endtabs %}

## Open assist view

The `SfSmartScheduler` control provides the `OpenAssistView()` method to open assist view programmatically using an event.

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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4"  %}

private void Button_Clicked(object sender, EventArgs e)
{
    this.smartScheduler.OpenAssistView();
}

{% endhighlight %}
{% endtabs %}