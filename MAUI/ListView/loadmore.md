---
layout: post
title: Load More in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Load More support in Syncfusion® .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---
# Load More in .NET MAUI ListView (SfListView)

The `SfListView` enables `Load More` view by setting the [SfListView.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreOption) and [SfListView.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand) properties. This can be displayed either on the top or bottom of the view by setting the [SfListView.LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMorePosition) property. This view is displayed when the end of the list is reached and the `LoadMorePosition` is set to `End`. This provides an option to add the items at runtime.

The `SfListView.LoadMoreOption` property contains the following four different modes of operations:

 * [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_None): Disables the load more button. This is the default value.
 * [Manual](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_Manual): Displays the load more button when the end of the list is reached and executes `SfListView.LoadMoreCommand` when the button is tapped.
 * [Auto](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_Auto): Automatically executes the `SfListView.LoadMoreCommand` when the end of the list is reached.
 * [AutoOnScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_AutoOnScroll): Executes `SfListView.LoadMoreCommand` when users interact with the ListView and reach the end of the list.

The `SfListView.LoadMorePosition` property has two positions:

* [Start](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMorePosition.html#Syncfusion_Maui_ListView_LoadMorePosition_Start): Positioned on the start of list.
* [End](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMorePosition.html#Syncfusion_Maui_ListView_LoadMorePosition_End): Positioned on the end of list when reaching the end of the list. This is the default value.

N> **Behavior with an empty list.** `SfListView.LoadMoreCommand` is invoked when the ListView is empty. This is the default behavior of `Manual` and `Auto` modes. To prevent the command from firing on an empty list, return `false` from the command's `CanExecute` predicate (see [How to disable LoadMoreCommand execution when the ListView is empty](#how-to-disable-loadmorecommand-execution-when-the-listview-is-empty)).

N> **Key limitations at a glance.** When `LoadMorePosition` is `Start`, only `Manual` mode is supported. `Auto` and `AutoOnScroll` require `LoadMorePosition = End`. `Manual` mode is not supported when the ListView `Orientation` is `Horizontal`. See the [Limitations](#limitations) section for the full list.

N> In the following samples, `ItemSize="120"` is set to use a fixed item size for simplicity. When items have variable heights, use the [QueryItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize) event or set `AutoFitMode` instead of relying on a fixed `ItemSize`.

## Load more automatically

Set the [SfListView.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_Auto) property to `Auto` to automatically load more items using the [SfListView.LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand) and [SfListView.LoadMoreCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommandParameter) when the end of the list is reached.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
                 ItemSize="120"
                 LoadMoreOption="Auto"
                 LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                 LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                 ItemsSource="{Binding Products}"/>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreOption = LoadMoreOption.Auto;
listView.LoadMoreCommand = viewModel.LoadMoreItemsCommand;

//ViewModel.cs
LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);

private bool CanLoadMoreItems(object obj)
{
    if (Products.Count >= totalItems)
        return false;
    return true;
}

private async void LoadMoreItems(object obj)
{
    var listView = obj as Syncfusion.Maui.ListView.SfListView;
    listView.IsLazyLoading = true;
    await Task.Delay(2500);
    var index = Products.Count;
    var count = index + 3 >= totalItems ? totalItems - index : 3;
    AddProducts(index, count);
    listView.IsLazyLoading = false;
}

private void AddProducts(int index, int count)
{
    for (int i = index; i < index + count; i++)
    {
        var name = Names[i];
        var p = new Product()
        {
            Name = name,
            Weight = Weights[i],
            Price = Prices[i],
            Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
    Products.Add(p);
    }
}
{% endhighlight %}
{% endtabs %}

## Load more manually

Set the `SfListView.LoadMoreOption` property as Manual to load more items manually using the `SfListView.LoadMoreCommand` and `SfListView.LoadMoreCommandParameter` when tapping the load more button at end of the list.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
                 ItemSize="120"
                 LoadMoreOption="Manual"
                 LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                 LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                 ItemsSource="{Binding Products}"/>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="ViewModel.cs" %}
listView.LoadMoreOption = LoadMoreOption.Manual;
listView.LoadMoreCommand = viewModel.LoadMoreItemsCommand;

LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);

private bool CanLoadMoreItems(object obj)
{
    if (Products.Count >= totalItems)
        return false;
    return true;
}

private async void LoadMoreItems(object obj)
{
    var listView = obj as Syncfusion.Maui.ListView.SfListView;
    listView.IsLazyLoading = true;
    await Task.Delay(2500);
    var index = Products.Count;
    var count = index + 3 >= totalItems ? totalItems - index : 3;
    AddProducts(index, count);
    listView.IsLazyLoading = false;
}

private void AddProducts(int index, int count)
{
    for (int i = index; i < index + count; i++)
    {
        var name = Names[i];
        var p = new Product()
        {
            Name = name,
            Weight = Weights[i],
            Price = Prices[i],
            Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
    Products.Add(p);
    }
}
{% endhighlight %}
{% endtabs %}

## Load more when user interacts

To load more items only when users interact with the ListView and reach the end of the list, set `SfListView.LoadMoreOption` to [AutoOnScroll](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMoreOption.html#Syncfusion_Maui_ListView_LoadMoreOption_AutoOnScroll) and wire up `SfListView.LoadMoreCommand` and `SfListView.LoadMoreCommandParameter`. The `SfListView.LoadMoreCommand` does not execute and the `SfListView.LoadMoreTemplate` is not displayed when the ListView is initially loaded; both are deferred until the user interacts and reaches the end of the list, at which point the visibility of `LoadMoreTemplate` is driven by the command's `CanExecute` method.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
                 ItemSize="120"
                 LoadMoreOption="AutoOnScroll"
                 LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                 LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                 ItemsSource="{Binding Products}"/>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreOption = LoadMoreOption.AutoOnScroll;
listView.LoadMoreCommand = viewModel.LoadMoreItemsCommand;

// ViewModel.cs
LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);

/// <summary>
/// When AutoOnScroll load more is enabled, the CanExecute method will be called only when the user interacts and reaches the end of the list.
/// Based on return value, the visibility of the LoadMoreTemplate is handled and the Execute method is called.
/// </summary>
/// <param name="obj">ListView is passed as default parameter.</param>
/// <returns>Returns true if the list has items to load, else returns false.</returns>
private bool CanLoadMoreItems(object obj)
{
    if (Products.Count >= totalItems)
        return false;
    return true;
}
/// <summary>
/// The `Execute` method is called based on the return value of the `CanExecute` method. If `CanExecute` returns false, the `Execute` method will not be executed.
/// </summary>
/// <param name="obj">ListView is passed as default parameter.</param>
private async void LoadMoreItems(object obj)
{
    var listView = obj as Syncfusion.Maui.ListView.SfListView;
    //Enables LoadMoreIndicator to the LoadMoreTemplate.
    listView.IsLazyLoading = true;
    await Task.Delay(2500);
    var index = Products.Count;
    var count = index + 3 >= totalItems ? totalItems - index : 3;
    //Adding the items to the list.
    AddProducts(index, count);
    //Disables LoadMoreIndicator after adding the items.
    listView.IsLazyLoading = false;
}

private void AddProducts(int index, int count)
{
    for (int i = index; i < index + count; i++)
    {
        var name = Names[i];
        var p = new Product()
        {
            Name = name,
            Weight = Weights[i],
            Price = Prices[i],
            Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
    Products.Add(p);
    }
}
{% endhighlight %}
{% endtabs %}

## Show loading indicator

The [SfListView.LoadMoreIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadMoreIndicator.html) is displayed while items are being loaded. By using the [SfListView.IsLazyLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading) property, you can swap the load more button for a busy indicator inside the same `LoadMoreTemplate`. Set `IsLazyLoading` to `true` before adding items to the list and back to `false` after the items have been added. You can also bind `IsLazyLoading` through a view model so the swap is driven from the view model rather than the view.

By using the [SfListView.IsLazyLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading) property, you can interchange the visibility of the button and busy indicator when creating the load more view. You can set the value of the `SfListView.IsLazyLoading` property to `true` before adding items to the list and set it to `false`, after adding the items. You can also bind the `IsLazyLoading` property using ViewModel.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private async void LoadMoreItems(object obj)
{
    var listView = obj as Syncfusion.Maui.ListView.SfListView;
    //Show the indicator and hide the button.
    listView.IsLazyLoading = true;
    await Task.Delay(2500);
    var index = Products.Count;
    var count = index + 3 >= totalItems ? totalItems - index : 3;
    AddProducts(index, count);
    //Hide the indicator and show the button.
    listView.IsLazyLoading = false;
}
{% endhighlight %}
{% endtabs %}

Items can be loaded either on the top or bottom of the view.

![Syncfusion .NET MAUI listview with load more on scrolling at bottom](Images/load-more/maui-listview-loadmore-items-on-end.gif)

![Syncfusion .NET MAUI listview with load more on scrolling at top](Images/load-more/maui-listview-loadmore-items-on-start.gif)


## Load more view customization

The SfListView allows customizing the User Interface (UI) of the `Load More` view.

### Load more button

To customize the load more button, add the custom UI in the [SfListView.LoadMoreTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreTemplate) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="LoadMore.MainPage"
             xmlns:local="clr-namespace:LoadMore"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:InverseBoolConverter x:Key="inverseBoolConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <syncfusion:SfListView x:Name="listView"
                           ItemSize="120"
                           LoadMoreOption="Manual"
                           LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                           LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                           ItemsSource="{Binding Products}">
        <syncfusion:SfListView.LoadMoreTemplate>
            <DataTemplate>
                <Grid>
                    <Label Text="Load More Items..." TextColor="Black" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" IsVisible="{Binding IsLazyLoading, Converter={StaticResource inverseBoolConverter}, Source={x:Reference Name=listView}}">
                    </Label>
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.LoadMoreTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    var label = new Label
    {
        Text = "Load More Items...",
        FontSize = 20,
        BackgroundColor = Color.AliceBlue,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
    label.SetBinding(Label.IsVisibleProperty, new Binding("IsLazyLoading", BindingMode.Default, new InverseBoolConverter(), null, null, listView));
    grid.Children.Add(label);
    return grid;
});
{% endhighlight %}
{% endtabs %}

### Loading indicator

To customize the loading indicator, add the custom UI in the [SfListView.LoadMoreTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreTemplate) property.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="LoadMore.MainPage"
             xmlns:local="clr-namespace:LoadMore"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.Resources>
        <ResourceDictionary>
            <local:InverseBoolConverter x:Key="inverseBoolConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <syncfusion:SfListView x:Name="listView"
                           ItemSize="120"
                           LoadMoreOption="Manual"
                           LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                           LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                           ItemsSource="{Binding Products}">
        <syncfusion:SfListView.LoadMoreTemplate>
            <DataTemplate>
                <Grid>
                    <Label Text="Load More Items" TextColor="Black" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" IsVisible="{Binding IsLazyLoading, Converter={StaticResource inverseBoolConverter}, Source={x:Reference Name=listView}}">
                    </Label>
                    <syncfusion:ListViewLoadMoreIndicator IsRunning="{Binding IsLazyLoading, Source={x:Reference Name=listView}}" IsVisible="{Binding IsLazyLoading, Source={x:Reference Name=listView}}" Color="Red" VerticalOptions="Center"/>
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.LoadMoreTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    var label = new Label
    {
        Text = "Load More Items...",
        FontSize = 20,
        BackgroundColor = Color.AliceBlue,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
    label.SetBinding(Label.IsVisibleProperty, new Binding("IsLazyLoading", BindingMode.Default, new InverseBoolConverter(), null, null, listView));
    var loadMoreIndicator = new ListViewLoadMoreIndicator();
    loadMoreIndicator.Color = Color.Red;
    loadMoreIndicator.VerticalOptions = LayoutOptions.Center;
    loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsRunningProperty, new Binding("IsLazyLoading", BindingMode.Default, null, null,null, listView));
    loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsVisibleProperty, new Binding("IsLazyLoading", BindingMode.Default, null, null, null, listView));
    grid.Children.Add(label);
    grid.Children.Add(loadMoreIndicator);
    return grid;
});
{% endhighlight %}
{% endtabs %}

### Customize the size of the load more view and the loading indicator

`SfListView` allows customizing both the height of the load more row and the size of the indicator rendered inside it. Use the [SfListView.QueryItemSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize) event to size the row, and assign `HeightRequest` / `WidthRequest` on the elements inside the `LoadMoreTemplate` to size the indicator.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
this.listView.QueryItemSize += ListView_QueryItemSize;

private void ListView_QueryItemSize(object sender,Syncfusion.Maui.ListView.QueryItemSizeEventArgs e)
{
    if(e.ItemType == ItemType.LoadMore)
    {
        e.ItemSize = 300;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

To customize the size of the loading indicator, add the custom UI to the [SfListView.LoadMoreTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreTemplate) property and assign the height and width for the grid and loading indicator.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="23" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="LoadMore.MainPage"
             xmlns:local="clr-namespace:LoadMore"
             xmlns:helper="clr-namespace:LoadMore.Converters"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <ContentPage.Resources>
        <ResourceDictionary>
            <helper:InverseBoolConverter x:Key="inverseBoolConverter"/>
        </ResourceDictionary>
    </ContentPage.Resources>
    <syncfusion:SfListView x:Name="listView" 
                           ItemSize="120"
                           LoadMoreOption="Manual"
                           LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                           LoadMoreCommandParameter="{Binding Source={x:Reference listView}}"
                           ItemsSource="{Binding Products}">
        <syncfusion:SfListView.LoadMoreTemplate>
            <DataTemplate>
                <Grid HeightRequest="100" WidthRequest="100">
                    <Label Text="Load More Items" TextColor="Black" HorizontalTextAlignment="Center" VerticalTextAlignment="Center" IsVisible="{Binding IsLazyLoading, Converter={StaticResource inverseBoolConverter}, Source={x:Reference Name=listView}}">
                    </Label>
                    <syncfusion:ListViewLoadMoreIndicator IsRunning="{Binding IsLazyLoading, Source={x:Reference Name=listView}}" IsVisible="{Binding IsLazyLoading, Source={x:Reference Name=listView}}" Color="Red" VerticalOptions="Center" HeightRequest="100" WidthRequest="100"/>                             
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.LoadMoreTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.LoadMoreTemplate = new DataTemplate(() =>
{
    var grid = new Grid();
    grid.HeightRequest = 100;
    grid.WidthRequest = 100;
    var label = new Label
    {
        Text = "Load More Items...",
        FontSize = 20,
        BackgroundColor = Color.AliceBlue,
        HorizontalTextAlignment = TextAlignment.Center,
        VerticalTextAlignment = TextAlignment.Center
    };
    label.SetBinding(Label.IsVisibleProperty, new Binding("IsLazyLoading", BindingMode.Default, new InverseBoolConverter(), null, null, listView));
    var loadMoreIndicator = new ListViewLoadMoreIndicator();
    loadMoreIndicator.Color = Color.Red;
    loadMoreIndicator.VerticalOptions = LayoutOptions.Center;
    loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsRunningProperty, new Binding("IsLazyLoading", BindingMode.Default, null, null,null, listView));
    loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsVisibleProperty, new Binding("IsLazyLoading", BindingMode.Default, null, null, null, listView));
    loadMoreIndicator.HeightRequest = 100;
    loadMoreIndicator.WidthRequest = 100;
    grid.Children.Add(label);
    grid.Children.Add(loadMoreIndicator);
    return grid;
});
{% endhighlight %}
{% endtabs %}

## Disable load more at runtime

To disable the `Load More` view, return `false` from the `CanExecute` predicate of `SfListView.LoadMoreCommand`. The SfListView watches the predicate and hides the load more view automatically once the predicate reports no more items. Use this when the underlying data source is finite (for example, a paged API that has returned the last page).

The `totalItems` field is the size of the data source the view model is paging through. It is declared on the `ViewModel` (see the [Prerequisites](#prerequisites) section) and is initialized in the constructor or fetched from the service that returns the data. For the shared `ViewModel` in this document, `totalItems = 22` because `Names`/`Weights`/`Prices` each contain 22 entries.

The following snippet shows the **only** changes required to disable load more at runtime relative to the [Load more automatically](#load-more-automatically) sample. Everything else (the SfListView XAML, the `AddProducts` helper, the `LoadMoreItems` method) stays the same and is not repeated here.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs (delta) %}
//New: the upper bound on the number of items in the data source.
public int totalItems = 22;

public ViewModel()
{
    Products = new ObservableCollection<Product>();
    AddProducts(0, 10);
    //New: wire the CanExecute predicate into the command.
    LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);
}

//New: predicate that disables the Load More view when all items have been loaded.
private bool CanLoadMoreItems(object obj)
{
    if (Products.Count >= totalItems)
        return false;
    return true;
}
{% endhighlight %}
{% endtabs %}

N> When `CanLoadMoreItems` returns `false`, the [CommandManager](https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.commandmanager) re-evaluates the command. The `Load More` view is automatically hidden once the predicate reports no more items.


## Limitations

* You must set a minimum delay for `LoadMore` in the Execute method.
* SfListView does not support setting `Manual` in [SfListView.LoadMoreOption](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreOption) when [SfListView.Orientation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Orientation) is `Horizontal`.
* SfListView supports setting `Auto` and `AutoOnScroll` in `SfListView.LoadMoreOption` only when `SfListView.LoadMorePosition` is set to `End`.
* Handle [LoadMoreCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand) execution by implementing a `CanExecute` predicate on the command.

## How to

This section covers advanced recipes that build on the [Auto](#load-more-automatically), [Manual](#load-more-manually), and [AutoOnScroll](#load-more-when-user-interacts) modes.

### Load more on infinite scroll

Use this pattern when the data source is paged (the server returns a fixed-size window) and the user can keep scrolling indefinitely. This section focuses on the view-model wiring that backs the infinite-scroll behavior; for the XAML setup see [Load more automatically](#load-more-automatically) (use `LoadMoreOption="Auto"` together with the view model below).

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

public class LoadMoreViewModel : INotifyPropertyChanged
{
  //Names, Weights, and Prices are arrays of length 22 (indices 0..21).
  public ObservableCollection<Product> Products { get; set; }
  public Command<object> LoadMoreItemsCommand { get; set; }

  public LoadMoreViewModel()
  {
     Products = new ObservableCollection<Product>();
     AddProducts(0, 10);
     LoadMoreItemsCommand = new Command<object>(LoadMoreItems);
  }
  private async void LoadMoreItems(object obj)
  {
     var listview = obj as Syncfusion.Maui.ListView.SfListView;
     listview.IsLazyLoading = true;
     await Task.Delay(2500);
     //Add 10 more items, starting at index 10 and stopping before exceeding the source array length (22).
     AddProducts(Products.Count, Math.Min(Products.Count + 10, 22));
     listview.IsLazyLoading = false;
  }
  private void AddProducts(int value, int count)
  {
     for (int i = value; i < count; i++)
     {
        var name = Names[i];
        var p = new Product()
        {
           Name = name,
           Weight = Weights[i],
           Price = Prices[i],
           Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
        Products.Add(p);
     }
  }
}
{% endhighlight %}
{% endtabs %}


### Load more items automatically from the top

The `SfListView` allows loading more items automatically when reaching the top of the list by showing the busy indicator by loading in the [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderTemplate).

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
   <syncfusion:SfListView x:Name="ListView" 
                        IsLazyLoading="True" 
                        ItemsSource="{Binding Messages}" 
                        AutoFitMode="Height">
        <syncfusion:SfListView.HeaderTemplate>
            <DataTemplate>
                <Grid>
                <syncfusion:ListViewLoadMoreIndicator 
                Color="Blue" 
                IsRunning="True" 
                IsVisible="{Binding IndicatorIsVisible}"/>
                </Grid>
            </DataTemplate>
        </syncfusion:SfListView.HeaderTemplate>
    </syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
  MainPageViewModel ViewModel;
  public MainPage()
  {
    InitializeComponent();
    ViewModel = new MainPageViewModel();
    ListView.IsLazyLoading = true;
    ListView.ItemsSource = ViewModel.Messages;
    ListView.AutoFitMode = AutoFitMode.Height;
    ListView.HeaderTemplate = new DataTemplate(() =>
    {
      var grid = new Grid();
      var loadMoreIndicator = new ListViewLoadMoreIndicator()
      {
        Color = Color.Blue,
        IsRunning = true
      };
      loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsVisibleProperty, new Binding("IndicatorIsVisible"));
      grid.Children.Add(loadMoreIndicator);
      return grid;
    });
  }
}
{% endhighlight %}
{% endtabs %}

Insert each new item in the 0th position of the underlying collection bound to the `SfListView.ItemsSource` property.
{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.ListView.Helpers;
public partial class MainPage : ContentPage
{
  MainPageViewModel ViewModel;
  VisualContainer visualContainer;
  public bool isScrolled;
  HeaderItem headerItem;

  public MainPage()
  {
    InitializeComponent();
    ViewModel = new MainPageViewModel();
    BindingContext = ViewModel;
    ViewModel.ListView = this.ListView;
    ListView.Loaded += ListView_Loaded;
    visualContainer = ListView.GetVisualContainer();
  }

  private void HeaderItem_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
  {
    if(e.PropertyName=="Visibility")
    {
      if (headerItem.Visibility && isScrolled)
        LoadMoreOnTop();
    }
  }
        
  private async void LoadMoreOnTop()
  {
    //To get the current first item which is visible in the view.
    var firstItem = ListView.DataSource.DisplayItems[0];
    ViewModel.IndicatorIsVisible = true;
    var r = new Random();
    //To avoid layout calls when arranging each item to be added in the view.
    ListView.DataSource.BeginInit();
    for (int i = 0; i < 5; i++)
    {
      var collection = new Message();
      collection.Text = ViewModel.MessageText[r.Next(0, ViewModel.MessageText.Count() - 1)];
      collection.IsIncoming = i % 2 == 0 ? true : false;
      collection.MessageDateTime = DateTime.Now.ToString();
      ViewModel.Messages.Insert(0, collection);
    }
    ListView.DataSource.EndInit();
    await Task.Delay(4000);
    var firstItemIndex = ListView.DataSource.DisplayItems.IndexOf(firstItem);
    var header = (ListView.HeaderTemplate != null && !ListView.IsStickyHeader) ? 1 : 0;
    var totalItems = firstItemIndex + header;
    //Need to scroll back to previous position, else the ScrollViewer moves to the top of the list.
    ListView.ItemsLayout.ScrollToRowIndex(totalItems, true);
    ViewModel.IndicatorIsVisible = false;
  }

  private void ListView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
  {
    //To avoid loading items initially when page loaded.
    if (!isScrolled)
      (ListView.ItemsLayout as LinearLayout).ScrollToRowIndex(ViewModel.Messages.Count - 1, true);
    headerItem = visualContainer.Children.FirstOrDefault(obj => obj.GetType() == typeof(HeaderItem)) as HeaderItem;
    headerItem.PropertyChanged += HeaderItem_PropertyChanged;
    isScrolled = true;
  }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView with Auto Load More](Images/load-more/maui-listview-auto-load-more-on-top.png)

### Load more items manually from the top

The `SfListView` allows loading more items when tapping the button loaded in the `HeaderTemplate` when reaching the top of the list and shows the busy indicator until the items are added to the collection.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
<syncfusion:SfListView x:Name="ListView"
                       IsLazyLoading="True"
                       ItemTemplate="{StaticResource MessageTemplateSelector}"
                       ItemsSource="{Binding Messages}"
                       ItemSize="100">
  <syncfusion:SfListView.HeaderTemplate>
    <DataTemplate>
        <Grid>
          <Grid BackgroundColor="#d3d3d3" IsVisible="{Binding GridIsVisible}">
            <Button Text="Load More" Clicked="Button_Clicked" HorizontalOptions="CenterAndExpand" VerticalOptions="CenterAndExpand"/>
          </Grid>
          <syncfusion:ListViewLoadMoreIndicator Color="Blue" IsRunning="{Binding IndicatorIsVisible}" IsVisible="{Binding IndicatorIsVisible}"/>
        </Grid>
    </DataTemplate>
  </syncfusion:SfListView.HeaderTemplate>
</syncfusion:SfListView>
</ContentPage>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
  MainPageViewModel ViewModel;
  public MainPage()
  {
    InitializeComponent();
    ViewModel = new MainPageViewModel();
    BindingContext = ViewModel;
    ListView.IsLazyLoading = true;
    ListView.ItemsSource = ViewModel.Messages;
    ListView.AutoFitMode = AutoFitMode.Height;
    ListView.HeaderTemplate = new DataTemplate(() =>
    {
      var grid = new Grid();
      var buttonGrid = new Grid { BackgroundColor = Color.FromArgb("#d3d3d3") };
      buttonGrid.SetBinding(Grid.IsVisibleProperty, new Binding("GridIsVisible"));
      var loadMore = new Button()
      {
        HorizontalOptions = LayoutOptions.CenterAndExpand,
        VerticalOptions = LayoutOptions.CenterAndExpand,
        Text = "Load More",
      };
      loadMore.Clicked += Button_Clicked;
      buttonGrid.Children.Add(loadMore);
      var loadMoreIndicator = new ListViewLoadMoreIndicator()
      {
        Color = Color.Blue
      };
      loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsRunningProperty, new Binding("IndicatorIsVisible"));
      loadMoreIndicator.SetBinding(ListViewLoadMoreIndicator.IsVisibleProperty, new Binding("IndicatorIsVisible"));
      grid.Children.Add(buttonGrid);
      grid.Children.Add(loadMoreIndicator);
      return grid;
    });
  }
}
{% endhighlight %}
{% endtabs %}

Insert each new item in the 0th position of the underlying collection bound to the `SfListView.ItemsSource` property.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
public partial class MainPage : ContentPage
{
  MainPageViewModel ViewModel;
  VisualContainer visualContainer;

  public MainPage()
  {
    InitializeComponent();
    ViewModel = new MainPageViewModel();
    BindingContext = ViewModel;
    ViewModel.ListView = this.ListView;
    ListView.Loaded += ListView_Loaded;
  }

  private void ListView_Loaded(object sender, Syncfusion.Maui.ListView.ListViewLoadedEventArgs e)
  {
    (ListView.ItemsLayout as LinearLayout).ScrollToRowIndex(ViewModel.Messages.Count - 1, true);
  }

  private async void Button_Clicked(object sender, EventArgs e)
  {
    //To get the current first item which is visible in the view.
    var firstItem = ListView.DataSource.DisplayItems[0];
    ViewModel.GridIsVisible = false;
    ViewModel.IndicatorIsVisible = true;
    var r = new Random();
    //To avoid layout calls when arranging each item to be added in the view.
    ListView.DataSource.BeginInit();
    for (int i = 0; i < 5; i++)
    {
      var collection = new Message();
      collection.Text = ViewModel.MessageText[r.Next(0, ViewModel.MessageText.Count() - 1)];
      collection.IsIncoming = i % 2 == 0 ? true : false;
      collection.MessageDateTime = DateTime.Now.ToString();
      ViewModel.Messages.Insert(0, collection);
    }
    ListView.DataSource.EndInit();
    await Task.Delay(2000);
    var firstItemIndex = ListView.DataSource.DisplayItems.IndexOf(firstItem);
    var header = (ListView.HeaderTemplate != null && !ListView.IsStickyHeader) ? 1 : 0;
    var totalItems = firstItemIndex + header;
    //Need to scroll back to previous position, else the ScrollViewer moves to the top of the list.
    ListView.ItemsLayout.ScrollToRowIndex(totalItems, true);
    ViewModel.GridIsVisible = true;
    ViewModel.IndicatorIsVisible = false;
  }
}
{% endhighlight %}
{% endtabs %}

![Syncfusion .NET MAUI ListView with Manual Load More](Images/load-more/maui-listview-manual-loadmore-on-top.png)

## Disable LoadMoreCommand execution when the ListView is empty

The recommended way to disable `LoadMoreCommand` is to return `false` from the `CanExecute` predicate. The SfListView reads this predicate, and when it returns `false` the load more view is hidden and the `Execute` method is not invoked. This avoids even entering the load-more pipeline.

A guard inside `Execute` is still useful as a safety net (for example, when the underlying collection is mutated from another thread), but it should not be the primary mechanism for disabling load more.

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" %}
LoadMoreItemsCommand = new Command<object>(LoadMoreItems, CanLoadMoreItems);

private bool CanLoadMoreItems(object obj)
{
    //Disable load more when the collection is empty or all items have been loaded.
    if (Products.Count == 0 || Products.Count >= totalItems)
        return false;
    return true;
}

private async void LoadMoreItems(object obj)
{
    //Safety net: if the collection is empty when the command fires, do nothing.
    if (Products.Count == 0)
        return;
    var listView = obj as Syncfusion.Maui.ListView.SfListView;
    listView.IsLazyLoading = true;
    await Task.Delay(2500);
    var index = Products.Count;
    var count = index + 3 >= totalItems ? totalItems - index : 3;
    AddProducts(index, count);
    listView.IsLazyLoading = false;
}

private void AddProducts(int index, int count)
{
    for (int i = index; i < index + count; i++)
    {
        var name = Names[i];
        var p = new Product()
        {
            Name = name,
            Weight = Weights[i],
            Price = Prices[i],
            Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
        Products.Add(p);
    }
}
{% endhighlight %}
{% endtabs %}
                                                                                            