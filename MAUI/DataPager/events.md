---
layout: post
title: Events in .NET MAUI DataPager | Syncfusion®
description: Learn about the events available in the Syncfusion® .NET MAUI DataPager control to handle page changes and perform custom operations.
platform: MAUI
control: SfDataPager
documentation: UG
keywords : maui datapager, datapager events, pagechanging, pagechanged, .net maui datapager
---

# Events in .NET MAUI DataPager

The DataPager control provides events that allow you to handle page changes and perform custom operations based on user interactions.

## PageChanging

The [PageChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_PageChanging) event is triggered when the user navigation from one page to another page begins. [SfDataPager.PageChangingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.PageChangingEventArgs.html) contains the following members, which provide information for the `PageChanging` event:

* **OldPageIndex** - Gets the current page index from which the page is navigating.
* **NewPageIndex** - Gets the new page index to which the page is navigating.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           PageChanging="DataPager_PageChanging"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.PageChanging += DataPager_PageChanging;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void DataPager_PageChanging(object sender, Syncfusion.Maui.DataPager.PageChangingEventArgs e)
{
    int oldPageIndex = e.OldPageIndex;
    int newPageIndex = e.NewPageIndex;
    // Perform any operations before the page changes
}
{% endhighlight %}
{% endtabs %}

## PageChanged
 
The [PageChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_PageChanged) event is triggered when the user navigates from one page to another page. [SfDataPager.PageChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.PageChangedEventArgs.html) contains the following members, which provide information for the `PageChanged` event:

* **OldPageIndex** - Gets the current page index from which the page is navigated.
* **NewPageIndex** - Gets the new page index to which the page is navigated.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15" 
                           PageChanged="DataPager_PageChanged"
                           Source="{Binding Orders}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.PageChanged += DataPager_PageChanged;
dataPager.Source = viewModel.Orders;

Border border = new Border();
border.Padding = new Thickness(5);
border.Content = dataPager;

Grid grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Star });
grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
grid.Children.Add(border);
grid.SetRow(border, 1);
this.Content = grid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# %}
private void DataPager_PageChanged(object sender, Syncfusion.Maui.DataPager.PageChangedEventArgs e)
{
    int oldPageIndex = e.OldPageIndex;
    int newPageIndex = e.NewPageIndex;
    // Perform any operations after the page has changed
}
{% endhighlight %}
{% endtabs %}

## Page navigation commands

The `SfDataPager` exposes `ICommand` properties so that you can respond to successful page navigation from a ViewModel without code-behind. Each command is executed after the navigation (including the `PageChanging` and `PageChanged` events) completes successfully. A command is not executed when the navigation is canceled in `PageChanging`, when the first, previous, next, or last page does not exist, or when `CanExecute` returns `false`.

| Property | Executed when | Command parameter |
|----------|---------------|-------------------|
| [NavigateToFirstPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToFirstPageCommand) | Navigation to the first page succeeds. | `null` |
| [NavigateToPreviousPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPreviousPageCommand) | Navigation to the previous page succeeds. | `null` |
| [NavigateToNextPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToNextPageCommand) | Navigation to the next page succeeds. | `null` |
| [NavigateToLastPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToLastPageCommand) | Navigation to the last page succeeds. | `null` |
| [NavigateToPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPageCommand) | Navigation to a specific page succeeds, for example by tapping a numeric or ellipsis button or calling `MoveToPage`. | The value of `NavigateToPageCommandParameter` if set; otherwise the zero-based destination page index (`int`). |
| [NavigateToPageCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPageCommandParameter) | Not a command. An `object` passed to `NavigateToPageCommand` instead of the page index. | - |

The commands run for both user interaction (tapping a button) and programmatic navigation using `MoveToFirstPage`, `MoveToPreviousPage`, `MoveToNextPage`, `MoveToLastPage`, and `MoveToPage`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="*" />
        <RowDefinition Height="Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row="1" Padding="5">
        <pager:SfDataPager x:Name="dataPager"
                           PageSize="15"
                           Source="{Binding Orders}"
                           NavigateToFirstPageCommand="{Binding FirstPageCommand}"
                           NavigateToPreviousPageCommand="{Binding PreviousPageCommand}"
                           NavigateToNextPageCommand="{Binding NextPageCommand}"
                           NavigateToLastPageCommand="{Binding LastPageCommand}"
                           NavigateToPageCommand="{Binding GoToPageCommand}" />
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
public class OrderInfoViewModel
{
    public ICommand FirstPageCommand { get; }
    public ICommand PreviousPageCommand { get; }
    public ICommand NextPageCommand { get; }
    public ICommand LastPageCommand { get; }
    public ICommand GoToPageCommand { get; }

    public OrderInfoViewModel()
    {
        FirstPageCommand = new Command(() => Status = "Moved to the first page");
        PreviousPageCommand = new Command(() => Status = "Moved to the previous page");
        NextPageCommand = new Command(() => Status = "Moved to the next page");
        LastPageCommand = new Command(() => Status = "Moved to the last page");
        GoToPageCommand = new Command<object>(page => Status = $"Moved to page index {page}");
    }

    public string Status { get; set; } = string.Empty;
}

// Code-behind equivalent
dataPager.NavigateToNextPageCommand = viewModel.NextPageCommand;
dataPager.NavigateToPageCommand = viewModel.GoToPageCommand;
{% endhighlight %}
{% endtabs %}

Set `NavigateToPageCommandParameter` when the command needs a fixed value instead of the page index:

{% tabs %}
{% highlight xaml %}
<pager:SfDataPager NavigateToPageCommand="{Binding GoToPageCommand}"
                   NavigateToPageCommandParameter="Orders" />
{% endhighlight %}
{% highlight c# %}
dataPager.NavigateToPageCommand = viewModel.GoToPageCommand;
dataPager.NavigateToPageCommandParameter = "Orders";
{% endhighlight %}
{% endtabs %}

N> The commands only observe navigation. They do not trigger it, so use `MoveToPage` and the related methods to navigate programmatically. The commands run after the `PageChanged` event, so the pager's `PageIndex` already reflects the new page.
