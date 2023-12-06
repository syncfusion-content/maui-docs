---
layout: post
title: Events and Commands in .NET MAUI PullToRefresh control | Syncfusion
description: Learn about Events And Commands support in the Syncfusion .NET MAUI PullToRefresh (SfPullToRefresh) control and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
--- 

# Events in .NET MAUI SfPullToRefresh (SfPullToRefresh)

There are three built-in events in the PullToRefresh control, namely:

1. `Pulling`
2. `Refreshing`
3. `Refreshed`

The `Pulling` event will be notified whenever the swipe gesture is started. This event will notify the listener each and every time until the refresh content height exceeds. When you release the gesture from pullable content, the `Refreshing` event will be triggered. Now, the refresh operation can be performed. Once the content is refreshed, set `SfPullToRefresh.IsRefreshing` to `false` to stop the animation. Once the animation is stopped, the `Refreshed` event will be triggered to notify that the refreshing is completed.

## Pulling

The `Pulling` event is triggered whenever you start pulling down on the `PullableContent` with `PullingEventArgs` that contains the following properties.

* `Cancel` - You can cancel the pulling action based on the `Progress` value.
* `Progress` - Gets the progress completion value.

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

The `Refreshing` event is triggered once the pointer is released. This event will occur till the `IsRefreshing` property is set as `false.`

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

The `Refreshed` event is triggered once the `Refreshing` event is completed.

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