---
layout: post
title: Pull To Refresh in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Pull To Refresh support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui pull to refresh, maui pull to refresh
---

# Pull To Refresh in MAUI DataGrid (SfDataGrid)

## Pull-to-refresh

To enable the `PullToRefresh` option in the data grid, set the [SfDataGrid.AllowPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowPullToRefresh) property to `true`. This allows the control to refresh the data source at runtime when the pull-to-refresh gesture is performed. 

### Pull-to-refresh command

The data grid can refresh its data during runtime by executing an `ICommand` bound to the [SfDataGrid.PullToRefreshCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_PullToRefreshCommand) property. When a pull-to-refresh gesture is performed and the progress bar reaches 100%, this command is triggered to update the records in view.

To indicate that a pull-to-refresh operation is in progress, set the [SfDataGrid.IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy) property to `true` before starting the refresh. Once the refresh is complete, set this property back to `false`. You can also customize the duration of the pull-to-refresh animation by adding a delay in the code.

To enable and perform the pull-to-refresh operation, refer to the following code example:

{% tabs %}

{% highlight Xaml %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                       AllowPullToRefresh="True"
                       PullToRefreshCommand="{Binding RefreshCommand}"
                       ItemsSource="{Binding OrdersInfo}">

{% endhighlight %}

{% highlight c# %}

dataGrid.AllowPullToRefresh = true;

Command RefreshCommand = new Command(ExecutePullToRefreshCommand);
dataGrid.PullToRefreshCommand = RefreshCommand;
 
private async void ExecutePullToRefreshCommand()
{
    this.dataGrid.IsBusy = true;
    await Task.Delay(new TimeSpan(0, 0, 5));
    viewModel.ItemsSourceRefresh();
    this.dataGrid.IsBusy = false;
}

//ViewModel.cs
public void ItemsSourceRefresh()
{
    int count = random.Next (1, 10);
    for (int i = 1; i <= count; i++) 
    {
        this.OrdersInfo!.Insert(0, new OrderInfo()
        {
            OrderID = i,
            CustomerID = this.customerID[this.random.Next(15)],
            EmployeeID = this.random.Next(1700, 1800),
        });
    }        
}

{% endhighlight %}
{% endtabs %}

<img alt="Pull To Refresh" src="Images\pull-to-refresh\net-maui-pull-to-refresh-slide-on-top.gif" width="404"/>

### Transition Type

To customize the progress view animation, adjust the [SfDataGrid.TransitionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TransitionType) property. By default, the transition type is set to SlideOnTop.

The following code snippet demonstrates how to change the transition type to `Push`. In this mode, only the scrollable view moves, while the header remains fixed:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<syncfusion:SfDataGrid x:Name="dataGrid"
                       TransitionType="Push"
                       AllowPullToRefresh="True"
                       ItemsSource="{Binding OrdersInfo}">

{% endhighlight %}
{% endtabs %}

<img alt="TransitionType Push" src="Images\pull-to-refresh\net-maui-pull-to-refresh-push.gif" width="404"/>

### Customization

You can customize various properties of [SfPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html) in the data grid, including `TransitionType`, `PullingThreshold`, `ProgressBackground`, `ProgressColor`, and more.

{% tabs %}
{% highlight c# %}

public MainPage()
{
    InitializeComponent();
    dataGrid.AllowPullToRefresh = true;
    dataGrid.DataGridLoaded += DataGrid_DataGridLoaded;
}

private void DataGrid_DataGridLoaded(object? sender, EventArgs e)
{
    SfPullToRefresh refreshView = dataGrid.Children.OfType().First();
    if (refreshView != null)
    {
        refreshView.ProgressColor = Color.FromArgb("ffb703");
        refreshView.ProgressBackground = Color.FromArgb("023047");
        refreshView.ProgressThickness = 4;
        refreshView.RefreshViewThreshold = 10;
        refreshView.PullingThreshold = 120;
    }
}

{% endhighlight %}
{% endtabs %}

<img alt="Customization" src="Images\pull-to-refresh\net-maui-pull-to-refresh-customization.gif" width="404"/>

To customize the various properties of SfPullToRefresh, refer to this [documentation](https://help.syncfusion.com/maui/pull-to-refresh/customization).

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

This is how the final output will look like when hosting a DataGrid control as pullable content.

<img alt="TransitionMode SlideonTop" src="Images\pull-to-refresh\net-maui-datagrid-slideontop.gif" width="404"/>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

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
                                        TransitionMode="SlideOnTop">

                <pulltoRefresh:SfPullToRefresh.PullableContent>
                    <sfgrid:SfDataGrid x:Name="dataGrid"
                                    ItemsSource="{Binding OrderInfoCollection}">
                    </sfgrid:SfDataGrid>
                </pulltoRefresh:SfPullToRefresh.PullableContent>
            </pulltoRefresh:SfPullToRefresh>
        </Grid>
    </ContentPage.Content>
</ContentPage>

{% endhighlight %}
{% highlight c# tabtitle="PullToRefreshTemplateBehavior.cs" %}

using Syncfusion.Maui.PullToRefresh;

namespace PullToRefreshTemplate
{
    public class PullToRefreshTemplateBehavior : Behavior<ContentPage>
    {
        private OrderInfoRepository? viewModel;
        private Syncfusion.Maui.PullToRefresh.SfPullToRefresh? pullToRefresh;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            this.viewModel = new OrderInfoRepository();
            bindable.BindingContext = this.viewModel;
            this.pullToRefresh = bindable.FindByName<Syncfusion.Maui.PullToRefresh.SfPullToRefresh>("pullToRefresh");
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

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            this.pullToRefresh!.Refreshing -= this.PullToRefresh_Refreshing;
            base.OnDetachingFrom(bindable);
        }
    }
}

{% endhighlight %}
{% endtabs %}

### Transition Mode

The [TransitionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode) property specifies the mode of the animations. It has the following two modes:

* [SlideOnTop](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html#Syncfusion_Maui_PullToRefresh_PullToRefreshTransitionType_SlideOnTop)
* [Push](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html#Syncfusion_Maui_PullToRefresh_PullToRefreshTransitionType_Push)

The default transition is `SlideOnTop` that draws the RefreshView on top of the `DataGrid`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                            TransitionMode="SlideOnTop">
    <pulltoRefresh:SfPullToRefresh.PullableContent>
        <sfgrid:SfDataGrid x:Name="dataGrid"
                            ItemsSource="{Binding OrderInfoCollection}">
        </sfgrid:SfDataGrid>
    </pulltoRefresh:SfPullToRefresh.PullableContent>
</pulltoRefresh:SfPullToRefresh>

{% endhighlight %}
{% endtabs %}

The following code example shows how to set the `TransitionMode` as `Push` to SfPullToRefresh. This transition moves only the refresh content and the header is fixed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<pulltoRefresh:SfPullToRefresh x:Name="pullToRefresh"
                            TransitionMode="Push">
    <pulltoRefresh:SfPullToRefresh.PullableContent>
        <sfgrid:SfDataGrid x:Name="dataGrid"
                            ItemsSource="{Binding OrderInfoCollection}">
        </sfgrid:SfDataGrid>
    </pulltoRefresh:SfPullToRefresh.PullableContent>
</pulltoRefresh:SfPullToRefresh>

{% endhighlight %}
{% endtabs %}

<img alt="TransitionMode SlideonTop" src="Images\pull-to-refresh\net-maui-datagrid-push.gif" width="404"/>

For more details and code examples of the properties of SfPullToRefresh, refer to this [documentation](https://help.syncfusion.com/maui/pull-to-refresh/customization#refreshviewthreshold).
