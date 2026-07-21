---
layout: post
title: Events in .NET MAUI PullToRefresh control | Syncfusion®
description: Learn about the Pulling, Refreshing, and Refreshed events in the Syncfusion .NET MAUI SfPullToRefresh control.
platform: MAUI
control: SfPullToRefresh
documentation: ug
--- 

# Events in .NET MAUI SfPullToRefresh

SfPullToRefresh raises three events that you can handle to respond to the user pull gesture, perform the refresh operation, and react when the refresh completes:

1. [Pulling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Pulling)
2. [Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing)
3. [Refreshed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshed)

The `Pulling` event is raised whenever the swipe gesture starts. It continues to fire until the pull distance exceeds the refresh threshold. When the user releases the pull gesture, the `Refreshing` event is raised. Perform the refresh operation in the `Refreshing` handler, and then set `SfPullToRefresh.IsRefreshing` to `false` to stop the animation. Once the animation stops, the `Refreshed` event is raised to indicate completion.

## Pulling

The [Pulling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Pulling) event is raised whenever you start pulling down on the [PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent). The handler receives [PullingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullingEventArgs.html), which exposes the following members:

* [Cancel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullingEventArgs.html#Syncfusion_Maui_PullToRefresh_PullingEventArgs_Cancel) - Set to `true` to cancel the pulling action based on the `Progress` value.
* [Progress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullingEventArgs.html#Syncfusion_Maui_PullToRefresh_PullingEventArgs_Progress) - Gets the progress completion value (a value between 0 and 1).

The following sample wires up the `Pulling` event from XAML and reads the `Progress` value inside the handler:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfPullToRefresh x:Name="pullToRefresh" 
                            Pulling="OnPullToRefreshPulling" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

pullToRefresh.Pulling += OnPullToRefreshPulling;

private void OnPullToRefreshPulling(object sender, PullingEventArgs args)
{
    args.Cancel = false;
    var progress = args.Progress; // Read or use the progress value here.
}

{% endhighlight %}
{% endtabs %}

N>  The `Progress` value is 0 when the pull starts and approaches 1 as the pull distance increases toward the refresh threshold.

## Refreshing

The [Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing) event is raised when the user releases the pull gesture. It is raised only once and continues until [IsRefreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing) is set to `false`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfPullToRefresh x:Name="pullToRefresh" 
                            Refreshing="OnPullToRefreshRefreshing" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

pullToRefresh.Refreshing += OnPullToRefreshRefreshing;

private async void OnPullToRefreshRefreshing(object sender, EventArgs args)
{
    pullToRefresh.IsRefreshing = true;
    await Task.Delay(2000);
    pullToRefresh.IsRefreshing = false;
}

{% endhighlight %}
{% endtabs %}

## Refreshed

The [Refreshed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshed) event is raised after the `Refreshing` event completes (that is, after `IsRefreshing` is set to `false`). Use this event to perform post-refresh actions such as updating UI state or showing a confirmation.

The following sample wires up the `Refreshed` event from XAML and handles it in code-behind:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfPullToRefresh x:Name="pullToRefresh" 
                            Refreshed="OnPullToRefreshRefreshed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="3" %}

pullToRefresh.Refreshed += OnPullToRefreshRefreshed;

private void OnPullToRefreshRefreshed(object sender, EventArgs args)
{
    // Add post-refresh logic here.
}

{% endhighlight %}
{% endtabs %}