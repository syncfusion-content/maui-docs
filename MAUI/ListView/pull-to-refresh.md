---
layout: post
title: Pull To Refresh in .NET MAUI ListView control | Syncfusion
description: Learn here all about Pull To Refresh support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
keywords : .net maui listview, .net maui list,.net maui pull-to-refresh, .net maui refresh listview, .net maui refresh view, .net maui refreshing list, .net maui dynamic update list.
---

# Pull To Refresh in .NET MAUI ListView (SfListView)

The [SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html) refreshing control allows interacting and refreshing the loaded view. When the SfListView is loaded inside the `SfPullToRefresh`, it refreshes the item when performing the pull-to-refresh action.

Refer [initializing pull-to-refresh](https://help.syncfusion.com/maui/pull-to-refresh/getting-started#register-the-handler) to launch pull-to-refresh on each platform.

## SfListView inside the SfPullToRefresh 

The `SfListView` supports refreshing the data in view when performing the pull-to-refresh action at runtime by loading it directly into the [SfPullToRefresh.PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent) of the [SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html).

<ol>
    <li>	Add the required assembly references as discussed in the <a href="https://help.syncfusion.com/maui/listview/getting-started">ListView</a> and PullToRefresh.</li>
    <li>	Import the SfPullToRefresh control and SfListView control namespace as follows.</li>
    <br/>
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    xmlns:ListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
    xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.ListView;
    using Syncfusion.Maui.PullToRefresh;

{% endhighlight %}
{% endtabs %}
    <br/>
    <li>	Define the ListView as PullableContent of the SfPullToRefresh.</li>
    <li>	Handle the pull to refresh events for refreshing the data. </li>
    <li>	Customize the required properties of ListView and PullToRefresh based on your requirement.</li>
</ol>

This is how the final output will look like when hosting a SfListView control as pullable content.

![.NET MAUI PullToRefresh with ListView hosted with slide on top transition mode.](Images/pulltorefresh/net-maui-listview-slideontop.gif)

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="21 23 33 35" %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="RefreshableListView.MainPage"
                xmlns:ListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
                xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
                xmlns:local="clr-namespace:RefreshableListView">

        <ContentPage.Behaviors>
            <local:ListViewPullToRefreshBehavior />
        </ContentPage.Behaviors>

        <ContentPage.Content>
            <Grid>
                <pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                            RefreshViewHeight="50"
                                            RefreshViewThreshold="30"
                                            PullingThreshold="150"
                                            RefreshViewWidth="50"
                                            TransitionMode="SlideOnTop"
                                            IsRefreshing="False">
                    <pulltoRefresh:SfPullToRefresh.PullableContent>
                        <Grid x:Name="mainGrid">
                            <ListView:SfListView Grid.Row="1"
                                                x:Name="listView"
                                                ItemsSource="{Binding InboxInfos}"
                                                ItemSize="102"
                                                SelectionMode="Single"
                                                ScrollBarVisibility="Always"
                                                AutoFitMode="Height">
                                . . . 
                                . . . .

                            </ListView:SfListView>
                        </Grid>
                    </pulltoRefresh:SfPullToRefresh.PullableContent>
                </pulltoRefresh:SfPullToRefresh>
            </Grid>
        </ContentPage.Content>
    </ContentPage>
    
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.DataSource;
    using Syncfusion.Maui.DataSource.Extensions;
    using Syncfusion.Maui.ListView;
    using Syncfusion.Maui.PullToRefresh;
    namespace RefreshableListView
    {
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ViewModel = new ListViewInboxInfoViewModel();
            bindable.BindingContext = ViewModel;
            pullToRefresh = bindable.FindByName<SfPullToRefresh>("pullToRefresh");
            ListView = bindable.FindByName<SfListView>("listView");
            pullToRefresh.Refreshing += PullToRefresh_Refreshing;

            base.OnAttachedTo(bindable);
        }

        private async void PullToRefresh_Refreshing(object? sender, EventArgs e)
        {
            pullToRefresh!.IsRefreshing = true;
            await Task.Delay(2500);
            ViewModel!.AddItemsRefresh(3);
            pullToRefresh.IsRefreshing = false;
        }
    }

{% endhighlight %}
{% endtabs %}

N> [View sample in GitHub](https://github.com/SyncfusionExamples/load-listview-as-pullable-content-of-.net-maui-pull-to-refresh).

If you run the above sample with the [TransitionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode) as Push, the output will look as follows.

![. NET MAUI PullToRefresh with ListView hosted with push transition mode.](Images/pulltorefresh/net-maui-listview-push.gif)

## Limitation

The `Horizontal` ListView does not support the [SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html).