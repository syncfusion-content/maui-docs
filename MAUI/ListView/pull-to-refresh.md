---
layout: post
title: Pull To Refresh in .NET MAUI ListView control | Syncfusion
description: Learn here all about Pull To Refresh support in Syncfusion .NET MAUI ListView (SfListView) control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Pull To Refresh in .NET MAUI ListView (SfListView)

The [.NET MAUI SfPullToRefresh](https://help.syncfusion.com/maui/pull-to-refresh/getting-started) refreshing control allows interacting and refreshing the loaded view. When the `.NET MAUI SfListView` is loaded inside the `SfPullToRefresh`, it refreshes the view when performing the pull-to-refresh action.

Refer [PullToRefresh GettingStarted](https://help.syncfusion.com/maui/pull-to-refresh/getting-started) to use the `SfPullToRefresh` control in your application.

## SfListView inside the SfPullToRefresh

The `SfListView` supports refreshing the data in view when performing the pull-to-refresh action at runtime by loading it directly into the [SfPullToRefresh.PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent) property.

{% tabs %}
{% highlight xaml hl_lines="13 15" %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                x:Class="RefreshableListView.MainPage"
                xmlns:ListView="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
                xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
                xmlns:local="clr-namespace:RefreshableListView">

        <ContentPage.Content>
            <Grid>
                <pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                            TransitionMode="SlideOnTop"
                                            IsRefreshing="False">
                    <pulltoRefresh:SfPullToRefresh.PullableContent>
                        <Grid x:Name="mainGrid">
                            <ListView:SfListView Grid.Row="1"
                                                x:Name="listView">
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
{% highlight c# %}

    public MainPage()
    {
      InitializeComponent();

      // Initializing the PullToRefresh control.
      SfPullToRefresh pullToRefresh = new SfPullToRefresh();
      pullToRefresh.RefreshContentHeight = 50;
      pullToRefresh.RefreshContentWidth = 50;
      pullToRefresh.TransitionMode = TransitionType.Push;
      pullToRefresh.IsRefreshing = false;
      
      // Initializing the SfListView control.
      var listView = new SfListView();
      listView.ItemSize = 120;
      listView.SelectionMode = SelectionMode.None;
      
      // loading listview into pulltorefresh
      pullToRefresh.PullableContent = listView;
	  
	  this.Content = pullToRefresh;
    }
{% endhighlight %}
{% endtabs %}

## Loading data when refreshing

To refresh the data in view at runtime, use the [SfPullToRefresh.Refreshing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_Refreshing) event. The `Refreshing` event gets triggered once the progress bar meets 100%. The data can be added into the underlying collection, and the data gets updated in view once the `Refreshing` event gets completed.

{% tabs %}
{% highlight c# hl_lines="7 9 11" %}

	pullToRefresh.Refreshing += PullToRefresh_Refreshing;
	
	private async void PullToRefresh_Refreshing(object? sender, EventArgs e)
    {
	    // show progress indicator before data loading.
        pullToRefresh!.IsRefreshing = true;
        await Task.Delay(2500);
        ViewModel!.AddItems(3);
		// hide progress indicator.
        pullToRefresh.IsRefreshing = false;
    }
{% endhighlight %}
{% endtabs %}

![Pull-to-refresh view in .NET MAUI ListView](Images/pull-to-refresh/net-maui-listview-slideontop.gif)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/load-listview-as-pullable-content-of-.net-maui-pull-to-refresh)

## SfListView inside the SfPullToRefresh with ScrollView 

The ListView (SfListView) allows loading as a [SfPullToRefresh.PullableContent](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent) of the `SfPullToRefresh` with `ScrollView` and refresh the data in view at runtime.

{% tabs %}
{% highlight xaml %}

<ContentPage xmlns:pulltoRefresh="clr-namespace:Syncfusion.SfPullToRefresh.XForms;assembly=Syncfusion.SfPullToRefresh.XForms"
                xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms" >
    <ScrollView>
      <pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh" 
                                  ProgressBackgroundColor="#428BCA" 
                                  TransitionMode="SlideOnTop" 
                                  IsRefreshing="False">
        <pulltoRefresh:SfPullToRefresh.PullableContent>
                <syncfusion:SfListView x:Name="listView" 
                                      ItemSize="120" 
                                      AutoFitMode="Height" 
                                      SelectionMode="None">
                </syncfusion:SfListView>
        </pulltoRefresh:SfPullToRefresh.PullableContent>
      </pulltoRefresh:SfPullToRefresh>
    </ScrollView>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

    public MainPage()
    {
      InitializeComponent();
      // Initializing the PullToRefresh control.
      SfPullToRefresh pullToRefresh = new SfPullToRefresh();
      pullToRefresh.RefreshContentHeight = 50;
      pullToRefresh.RefreshContentWidth = 50;
      pullToRefresh.TransitionMode = TransitionType.Push;
      pullToRefresh.IsRefreshing = false;

      // Initializing the SfListView control.
      var listView = new SfListView();
      listView.ItemSize = 120;
      listView.SelectionMode = SelectionMode.None;

      // loading listview into pulltorefresh
      pullToRefresh.PullableContent = listView;

      this.Content = new ScrollView()
      {
          Content = pullToRefresh
      };
    }
		
{% endhighlight %}
{% endtabs %}

N> The `Horizontal` ListView does not support the `Pull-to-Refresh` feature.