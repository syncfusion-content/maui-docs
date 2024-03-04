---
layout: post
title: PullToRefresh in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about PullToRefresh support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# PullToRefresh in MAUI DataGrid (SfDataGrid)

PullToRefresh is a refresh control that allows you to interact and refresh the view loaded in it. The PullToRefresh control allows you to refresh the view upon performing the pull-to-refresh action. A progress indicator will be shown while starting the pulling. The application will be refreshed once you have pulled down a certain distance and released the touch.

## Host .NET MAUI DataGrid as pullable content

The `PullToRefresh` control provides support for loading any custom control as pullable content. To host the .NET MAUI Datagrid inside the PullToRefresh, follow these steps.
<ol>
    <li> Add the required assembly references as discussed in the <a href="https://help.syncfusion.com/maui/datagrid/getting-started">DataGrid</a> and PullToRefresh.</li>
    <li> Import PullToRefresh and DataGrid control namespace as follows.</li>
    <br/>
{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

    xmlns:sfgrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
    xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    using Syncfusion.Maui.DataGrid;
    using Syncfusion.Maui.PullToRefresh;

{% endhighlight %}
{% endtabs %}
    <br/>
    <li> Define the DataGrid as PullableContent of the PullToRefresh.</li> 
    <li> Handle the pull to refresh events for refreshing the data. </li>
    <li> Customize the required properties of the DataGrid and PullToRefresh based on your requirement.</li>
</ol>

This is how the final output will look like when hosting a Datagrid control as pullable content.

<img alt="TransitionMode SlideonTop" src="Images\pull-to-refresh\net-maui-datagrid-slideontop.gif" width="404"/>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="23 24 36 37" %}

    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PullToRefreshTemplate.MainPage"
             xmlns:sfgrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
             xmlns:local="clr-namespace:PullToRefreshTemplate">

        <ContentPage.Behaviors>
            <local:PullToRefreshTemplateBehavior />
        </ContentPage.Behaviors>

        <ContentPage.Content>
            <Grid>
                <pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                                            RefreshViewHeight="50"
                                            RefreshViewThreshold="30"
                                            PullingThreshold="150"
                                            RefreshViewWidth="50"
                                            WidthRequest="404"
                                            HeightRequest="396"
                                            ProgressThickness='{OnPlatform Android="3", Default="2"}'
                                            TransitionMode="SlideOnTop"
                                            >
                    <pulltoRefresh:SfPullToRefresh.PullableContent>
                        <sfgrid:SfDataGrid x:Name="dataGrid"
                                        HeaderRowHeight="52"
                                        RowHeight="48"
                                        SortingMode="Single"
                                        ItemsSource="{Binding OrderInfoCollection}"
                                        AutoGenerateColumnsMode="None"
                                        >
                            <sfgrid:SfDataGrid.Columns>
                                <sfgrid:DataGridNumericColumn MappingName="OrderID"
                                                                Format="#"
                                                                HeaderText="Order ID" />
                                <sfgrid:DataGridTextColumn MappingName="Name"
                                                            ColumnWidthMode="FitByCell"
                                                            HeaderText="Customer ID" />
                                <sfgrid:DataGridTextColumn MappingName="ShipCountry"
                                                            ColumnWidthMode="FitByCell"
                                                            HeaderText="Ship Country" />
                            </sfgrid:SfDataGrid.Columns>
                        </sfgrid:SfDataGrid>
                    </pulltoRefresh:SfPullToRefresh.PullableContent>
                </pulltoRefresh:SfPullToRefresh>
            </Grid>
        </ContentPage.Content>
    </ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="PullToRefreshTemplateBehavior.cs" %}

    using Syncfusion.Maui.DataGrid;
    using Syncfusion.Maui.PullToRefresh;

    namespace PullToRefreshTemplate
    {
        public class PullToRefreshTemplateBehavior : Behavior<ContentPage>
        {
            private OrderInfoRepository? viewModel;
            private Syncfusion.Maui.PullToRefresh.SfPullToRefresh? pullToRefresh;
            private SfDataGrid? dataGrid;
            protected override void OnAttachedTo(ContentPage bindable)
            {
                this.viewModel = new OrderInfoRepository();
                bindable.BindingContext = this.viewModel;
                this.pullToRefresh = bindable.FindByName<Syncfusion.Maui.PullToRefresh.SfPullToRefresh>("pullToRefresh");
                this.dataGrid = bindable.FindByName<SfDataGrid>("dataGrid");
                this.dataGrid.ItemsSource = this.viewModel.OrderInfoCollection;
                this.pullToRefresh.Refreshing += this.PullToRefresh_Refreshing;
                base.OnAttachedTo(bindable);
            }

            private async void PullToRefresh_Refreshing(object? sender, EventArgs e)
            {
                this.pullToRefresh!.IsRefreshing = true;
                await Task.Delay(new TimeSpan(0, 0, 3));
                this.viewModel!.ItemsSourceRefresh();
                this.pullToRefresh.IsRefreshing = false;
            }
        }
    }

{% endhighlight %}
{% endtabs %}

## TransitionMode

The [TransitionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode) property specifies the mode of the animations. It has the following two modes:

* [SlideOnTop](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html#Syncfusion_Maui_PullToRefresh_PullToRefreshTransitionType_SlideOnTop)
* [Push](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html#Syncfusion_Maui_PullToRefresh_PullToRefreshTransitionType_Push)

The default transition is `SlideOnTop` that draws the RefreshView on top of the `PullableContent`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfPullToRefresh x:Name="pullToRefresh" 
                                TransitionMode="SlideOnTop" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    pullToRefresh.TransitionMode = PullToRefreshTransitionType.SlideOnTop;

{% endhighlight %}
{% endtabs %}

The following code example shows how to set the `TransitionMode` as `Push` to PullToRefresh. This transition moves only the refresh content and the header is fixed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

    <syncfusion:SfPullToRefresh x:Name=" pullToRefresh" 
                                TransitionMode="Push" />

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}

    pullToRefresh.TransitionMode = PullToRefreshTransitionType.Push;

{% endhighlight %}
{% endtabs %}

<img alt="TransitionMode SlideonTop" src="Images\pull-to-refresh\net-maui-datagrid-push.gif" width="404"/>

For more details and code examples of the properties of SfPullToRefresh, refer to this [documentation](https://help.syncfusion.com/maui/pull-to-refresh/customization#refreshviewthreshold).