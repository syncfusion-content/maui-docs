---
layout: post
title: Events in .NET MAUI PullToRefresh control | Syncfusion
description: Learn about Events support in the Syncfusion .NET MAUI PullToRefresh (SfPullToRefresh) control and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
--- 

# Events in .NET MAUI SfPullToRefresh (SfPullToRefresh)

There are three built-in events in the PullToRefresh control, namely:

1. [Pulling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Pulling)
2. [Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing)
3. [Refreshed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshed)

The `Pulling` event will be notified whenever the swipe gesture is started. This event will notify the listener each and every time until the refresh content height exceeds. When you release the gesture from pullable content, the `Refreshing` event will be triggered. Now, the refresh operation can be performed. Once the content is refreshed, set `SfPullToRefresh.IsRefreshing` to `false` to stop the animation. Once the animation is stopped, the `Refreshed` event will be triggered to notify that the refreshing is completed.

## Pulling

The [Pulling](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Pulling) event is triggered whenever you start pulling down on the [PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent) with [PullingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullingEventArgs.html) that contains the following properties.

* `Cancel` - You can cancel the pulling action based on the `Progress` value.
* [Progress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullingEventArgs.html#properties) - Gets the progress completion value.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfPullToRefresh x:Name="pullToRefresh" 
                                PullingEvent="OnPullToRefreshPulling" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    pullToRefresh.Pulling += OnPullToRefreshPulling;

    private void OnPullToRefreshPulling(object sender, PullingEventArgs args)
    {
        args.Cancel = false;
        var progress = args.Progress;
    }

{% endhighlight %}
{% endtabs %}

## Refreshing

The [Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing) event is triggered once the pointer is released. This event will occur till the [IsRefreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing) property is set as `false.`

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

The [Refreshed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshed) event is triggered once the `Refreshing` event is completed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfPullToRefresh x:Name=" pullToRefresh" 
                                Refreshed="OnPullToRefreshRefreshed" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1" %}

    pullToRefresh.Refreshed += OnPullToRefreshRefreshed;
    
    private void OnPullToRefreshRefreshed(object sender , EventArgs args)
    {
    }

{% endhighlight %}
{% endtabs %}