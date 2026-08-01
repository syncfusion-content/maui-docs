---
layout: post
title: Pull To Refresh in .NET MAUI DataGrid control | Syncfusion®
description: Learn here all about Pull To Refresh support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui pull to refresh, maui pull to refresh
---

# Pull To Refresh in MAUI DataGrid (SfDataGrid)

## Pull To Refresh

To enable the pull-to-refresh option in the data grid, set the [SfDataGrid.AllowPullToRefresh](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowPullToRefresh) property to `true`. This allows the control to refresh the data source at runtime when the pull-to-refresh gesture is performed.

The data grid refreshes its data by executing an `ICommand` bound to the [SfDataGrid.PullToRefreshCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_PullToRefreshCommand) property. When the pull-to-refresh gesture is performed and the progress bar reaches 100%, this command is triggered to update the records in view.

To indicate that a refresh operation is in progress, set the [SfDataGrid.IsBusy](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy) property to `true` before starting the refresh. Once the refresh is complete, set this property back to `false`.

The following code example demonstrates how to enable and implement pull-to-refresh:

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowPullToRefresh="True"
                       PullToRefreshCommand="{Binding RefreshCommand}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowPullToRefresh = true;
        dataGrid.PullToRefreshCommand = new Command(ExecutePullToRefreshCommand);
        this.Content = dataGrid;
    }

    private async void ExecutePullToRefreshCommand()
    {
        dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.ItemsSourceRefresh();
        dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Pull To Refresh" src="Images\pull-to-refresh\net-maui-pull-to-refresh-slide-on-top.gif" width="404"/>

### Transition Type

To customize the progress view animation, adjust the [SfDataGrid.TransitionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TransitionType) property. By default, the transition type is set to `SlideOnTop`.

**Available Transition Types:**
- **SlideOnTop** (default): Draws the refresh indicator on top of the data grid
- **Push**: Moves only the scrollable content while the header remains fixed

The following code snippet demonstrates how to change the transition type to `Push`:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<syncfusion:SfDataGrid x:Name="DataGrid"
                       ItemsSource="{Binding Orders}"
                       AllowPullToRefresh="True"
                       TransitionType="Push"
                       PullToRefreshCommand="{Binding RefreshCommand}">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowPullToRefresh = true;
        dataGrid.TransitionType = Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.Push;
        dataGrid.PullToRefreshCommand = new Command(ExecutePullToRefreshCommand);
        this.Content = dataGrid;
    }

    private async void ExecutePullToRefreshCommand()
    {
        dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.ItemsSourceRefresh();
        dataGrid.IsBusy = false;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="TransitionType Push" src="Images\pull-to-refresh\net-maui-pull-to-refresh-push.gif" width="404"/>

### Customization

For advanced customization of the progress indicator, access the internal `SfPullToRefresh` control via the `DataGrid.DataGridLoaded` event. You can customize properties such as `ProgressColor`, `ProgressBackground`, `ProgressThickness`, `PullingThreshold`, and `RefreshViewThreshold`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.PullToRefresh;

public partial class MainPage : ContentPage
{
    SfDataGrid dataGrid;
    OrderInfoViewModel viewModel;

    public MainPage()
    {
        InitializeComponent();
        dataGrid = new SfDataGrid();
        viewModel = new OrderInfoViewModel();
        dataGrid.ItemsSource = viewModel.Orders;
        dataGrid.AllowPullToRefresh = true;
        dataGrid.TransitionType = Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.Push;
        dataGrid.PullToRefreshCommand = new Command(ExecutePullToRefreshCommand);
        dataGrid.DataGridLoaded += DataGrid_DataGridLoaded;
        this.Content = dataGrid;
    }

    private async void ExecutePullToRefreshCommand()
    {
        dataGrid.IsBusy = true;
        await Task.Delay(new TimeSpan(0, 0, 5));
        viewModel.ItemsSourceRefresh();
        dataGrid.IsBusy = false;
    }

    private void DataGrid_DataGridLoaded(object? sender, EventArgs e)
    {
        SfPullToRefresh refreshView = dataGrid.Children.OfType<SfPullToRefresh>().First();
        if (refreshView != null)
        {
            refreshView.ProgressColor = Color.FromArgb("#e76f51");       
            refreshView.ProgressBackground = Color.FromArgb("#219ebc");  
            refreshView.ProgressThickness = 4;
            refreshView.RefreshViewThreshold = 10;
            refreshView.PullingThreshold = 120;
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Customization" src="Images\pull-to-refresh\net-maui-pull-to-refresh-customization.gif" width="404"/>

For more customization options of SfPullToRefresh, refer to the [PullToRefresh customization documentation](https://help.syncfusion.com/maui/pull-to-refresh/customization).

##  Host .NET MAUI DataGrid as pullable content
The `SfPullToRefresh` control supports wrapping any custom control (including DataGrid) as pullable content. This approach provides more flexibility for refresh behavior and visual customization compared to the built-in approach.
<ol>
    <li> <strong>Add Assembly References:</strong> Ensure both DataGrid and PullToRefresh assemblies are referenced in your project.</li>
    <li> <strong>Import Namespaces:</strong> Add the required namespaces to your XAML page as follows.</li>
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
    <li> <strong>Define the DataGrid as PullableContent:</strong> Wrap the DataGrid inside SfPullToRefresh.PullableContent.</li> 
    <li> <strong>Handle Refresh Events:</strong> Subscribe to the Refreshing event to update data when pull-to-refresh is triggered.</li> 
    <li> <strong>Customize Properties:</strong> Configure DataGrid and PullToRefresh properties as needed.</li>
</ol>

Here is the complete implementation for hosting a DataGrid control as pullable content:

<img alt="TransitionMode SlideOnTop" src="Images\pull-to-refresh\net-maui-datagrid-slideontop.gif" width="404"/>

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:DataGridUGDemo"
             xmlns:sfgrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             xmlns:pulltoRefresh="clr-namespace:Syncfusion.Maui.PullToRefresh;assembly=Syncfusion.Maui.PullToRefresh"
             x:Class="DataGridUGDemo.MainPage">
    <ContentPage.Behaviors>
        <local:PullToRefreshBehavior />
    </ContentPage.Behaviors>
    <Grid>
        <pulltoRefresh:SfPullToRefresh x:Name="PullToRefresh"
                                       TransitionMode="SlideOnTop">
            <pulltoRefresh:SfPullToRefresh.PullableContent>
                <sfgrid:SfDataGrid x:Name="DataGrid"
                                   ItemsSource="{Binding Orders}">
                </sfgrid:SfDataGrid>
            </pulltoRefresh:SfPullToRefresh.PullableContent>
        </pulltoRefresh:SfPullToRefresh>
    </Grid>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="PullToRefreshBehavior.cs" %}
using Syncfusion.Maui.PullToRefresh;

public class PullToRefreshBehavior : Behavior<ContentPage>
{
    private OrderInfoViewModel? viewModel;
    private SfPullToRefresh? pullToRefresh;

    protected override void OnAttachedTo(ContentPage bindable)
    {
        this.viewModel = new OrderInfoViewModel();
        bindable.BindingContext = this.viewModel;
        this.pullToRefresh = bindable.FindByName<SfPullToRefresh>("PullToRefresh");
        
        if (this.pullToRefresh != null)
        {
            this.pullToRefresh.Refreshing += this.PullToRefresh_Refreshing;
        }

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
        if (this.pullToRefresh != null)
        {
            this.pullToRefresh.Refreshing -= this.PullToRefresh_Refreshing;
        }

        base.OnDetachingFrom(bindable);
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
<pulltoRefresh:SfPullToRefresh x:Name="PullToRefresh"
                               TransitionMode="SlideOnTop">
    <pulltoRefresh:SfPullToRefresh.PullableContent>
        <sfgrid:SfDataGrid x:Name="DataGrid"
                           ItemsSource="{Binding Orders}">
        </sfgrid:SfDataGrid>
    </pulltoRefresh:SfPullToRefresh.PullableContent>
</pulltoRefresh:SfPullToRefresh>
{% endhighlight %}
{% endtabs %}

The following code example shows how to set the `TransitionMode` as `Push` to SfPullToRefresh. This transition moves only the refresh content and the header is fixed.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="2" %}

<pulltoRefresh:SfPullToRefresh x:Name="PullToRefresh"
                               TransitionMode="Push">
    <pulltoRefresh:SfPullToRefresh.PullableContent>
        <sfgrid:SfDataGrid x:Name="DataGrid"
                           ItemsSource="{Binding Orders}">
        </sfgrid:SfDataGrid>
    </pulltoRefresh:SfPullToRefresh.PullableContent>
</pulltoRefresh:SfPullToRefresh>

{% endhighlight %}
{% endtabs %}

<img alt="TransitionMode Push" src="Images\pull-to-refresh\net-maui-datagrid-push.gif" width="404"/>

For detailed information about additional SfPullToRefresh properties and customization options, refer to the [PullToRefresh customization documentation](https://help.syncfusion.com/maui/pull-to-refresh/customization#refreshviewthreshold).
