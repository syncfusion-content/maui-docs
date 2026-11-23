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

The `SfDataPager` provides navigation commands that allow you to respond to successful page navigation from a ViewModel without using code-behind. Each command executes after page navigation completes successfully and after the `PageChanging` and `PageChanged` events are raised. A command is not executed if navigation is canceled in `PageChanging`, the target page does not exist (for example, the first, previous, next, or last page), or `CanExecute` returns `false`.

The following commands are available in `SfDataPager`.

| Property | Description | Command parameter |
|----------|-------------|-------------------|
| [NavigateToFirstPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToFirstPageCommand) | Executes when navigation to the first page completes successfully. | `null` |
| [NavigateToPreviousPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPreviousPageCommand) | Executes when navigation to the previous page completes successfully. | `null` |
| [NavigateToNextPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToNextPageCommand) | Executes when navigation to the next page completes successfully. | `null` |
| [NavigateToLastPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToLastPageCommand) | Executes when navigation to the last page completes successfully. | `null` |
| [NavigateToPageCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPageCommand) | Executes when navigation to a specific page completes successfully through user interaction or by calling `MoveToPage`. | The value of `NavigateToPageCommandParameter` if set; otherwise, the zero-based destination page index (`int`). |
| [NavigateToPageCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataPager.SfDataPager.html#Syncfusion_Maui_DataPager_SfDataPager_NavigateToPageCommandParameter) | Not a command. Specifies an `object` that is passed to `NavigateToPageCommand` instead of the destination page index. | - |

These commands are executed for both user-initiated navigation (such as tapping a pager button) and programmatic navigation through `MoveToFirstPage`, `MoveToPreviousPage`, `MoveToNextPage`, `MoveToLastPage`, and `MoveToPage`.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height = "*" />
        <RowDefinition Height = "Auto" />
    </Grid.RowDefinitions>
    <Border Grid.Row = "1" Padding = "5">
        <pager:SfDataPager x:Name = "dataPager"
                           PageSize = "15" 
                           Source = "{Binding Orders}"
                           NavigateToFirstPageCommand = "{Binding FirstPageCommand}"
                           NavigateToPreviousPageCommand = "{Binding PreviousPageCommand}"
                           NavigateToNextPageCommand = "{Binding NextPageCommand}"
                           NavigateToLastPageCommand = "{Binding LastPageCommand}"
                           NavigateToPageCommand = "{Binding GoToPageCommand}">
        </pager:SfDataPager>
    </Border>
</Grid>
{% endhighlight %}
{% highlight c# %}
SfDataPager dataPager = new SfDataPager();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataPager.PageSize = 15;
dataPager.Source = viewModel.Orders;
dataPager.NavigateToFirstPageCommand = viewModel.FirstPageCommand;
dataPager.NavigateToPreviousPageCommand = viewModel.PreviousPageCommand;
dataPager.NavigateToNextPageCommand = viewModel.NextPageCommand;
dataPager.NavigateToLastPageCommand = viewModel.NavigateToLastPageCommand;
dataPager.NavigateToPageCommand = viewModel.GoToPageCommand;

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
{% endhighlight %}
{% endtabs %}

Set `NavigateToPageCommandParameter` when `NavigateToPageCommand` should receive a fixed value instead of the destination page index:

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

N> The navigation commands are notification mechanisms only and do not initiate navigation. To navigate programmatically, use `MoveToPage` or the related navigation methods. Because the commands execute after the `PageChanged` event, the `PageIndex` property already reflects the newly selected page.