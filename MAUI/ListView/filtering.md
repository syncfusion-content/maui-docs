---
layout: post
title: Filtering in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Filtering support in Syncfusion® .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Filtering in .NET MAUI ListView (SfListView)

This section explains how to filter the data and its related operations in the SfListView.

To get start quickly with filtering in .NET MAUI ListView, you can check on this video:
<style>#MAUIListViewFilteringVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIListViewFilteringVideoTutorial' src='https://www.youtube.com/embed/IedulwH4h4c'></iframe>

## Programmatic filtering

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html) supports data filtering by setting the [SfListView.DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_Filter) property. The `Filter` property accepts a `Predicate<object>` delegate that returns `true` if the item should be displayed and `false` if it should be excluded. You have to call the [SfListView.DataSource.RefreshFilter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_RefreshFilter) method after assigning the `Filter` property for refreshing the view.

The [FilterChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_FilterChanged) event is raised once filtering is applied to the SfListView.

The `FilterContacts` method filters the data that contains the specified text. Assign the `FilterContacts` method to the `SfListView.DataSource.Filter` predicate to filter the `ContactName`. The following code example shows how to apply filtering in the SfListView:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="10" %}
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             x:Class="FilteringSample.MainPage">
 <Grid>
    <Grid.RowDefinitions>
      <RowDefinition Height="Auto"/>
      <RowDefinition Height="Auto"/>
    </Grid.RowDefinitions>
    <SearchBar x:Name="filterText"
               HeightRequest="40"
               Placeholder="Search here to filter"
               TextChanged="OnFilterTextChanged"/>
    <syncfusion:SfListView x:Name="listView" Grid.Row="1"
                           ItemSize="60"
                           ItemsSource="{Binding Items}"/>
  </Grid>
</ContentPage>
{% endhighlight %}
{% endtabs %}

The following code example illustrates how to filter the data using the `FilterContacts` method in the code-behind:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="1 2 4 5 6 7 8 9 10 12 13 14 15 16 17 18 19 20 21 22 23" %}
SearchBar searchBar;
SfListView listView;
public MainPage()
{
    InitializeComponent();
    searchBar = this.filterText;
    listView = this.listView;
    listView.BindingContext = new ViewModel();
    listView.ItemsSource = (listView.BindingContext as ViewModel).Items;
    searchBar.TextChanged += OnFilterTextChanged;
}

private void OnFilterTextChanged(object sender, TextChangedEventArgs e)
{
    if (listView.DataSource != null)
    {
        this.listView.DataSource.Filter = FilterContacts;
        this.listView.DataSource.RefreshFilter();
    }
}

private bool FilterContacts(object obj)
{
    if (searchBar == null || searchBar.Text == null)
        return true;

    var taskInfo = obj as TaskInfo;
    if (taskInfo == null)
        return false;
    if (taskInfo.Title.ToLower().Contains(searchBar.Text.ToLower()) || taskInfo.Description.ToLower().Contains(searchBar.Text.ToLower()))
        return true;
    else
        return false;
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output rendered when the items are filtered:
![Syncfusion .NET MAUI ListView Filtering](Images/filtering/maui-listview-filtering-items.png)

### Filter based on multiple criteria

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html) allows filtering the items based on multiple criteria. The following code example shows how to filter the data using multiple properties combined with logical operators:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="5 6 7 8" %}
private bool FilterContacts(object obj)
{
  if (searchBar == null || searchBar.Text == null)
     return true;

  var taskInfo = obj as TaskInfo;
  if (taskInfo == null)
     return false;
  if (taskInfo.Title.ToLower().Contains(searchBar.Text.ToLower()) &&
      taskInfo.Status == "Open" &&
      taskInfo.DueDate >= DateTime.Today)
     return true;
  else
     return false;
}
{% endhighlight %}
{% endtabs %}

N> The `Status` and `DueDate` properties must exist on the `TaskInfo` model class for the multi-criteria filter to compile.

## Getting the filtered data

You can get filtered items from the view and modify it in the [SfListView.DataSource.FilterChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_FilterChanged) event. When the filter is applied, the filtered items are available in [SfListView.DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_DisplayItems).

Subscribe to the `FilterChanged` event during page initialization (e.g., in the `MainPage` constructor) so that the handler is registered before any filter is applied:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}
public MainPage()
{
    InitializeComponent();
    listView = this.listView;
    listView.BindingContext = new ViewModel();
    listView.ItemsSource = (listView.BindingContext as ViewModel).Items;
    listView.DataSource.FilterChanged += DataSource_FilterChanged;
}
...
private void DataSource_FilterChanged(object sender, NotifyCollectionChangedEventArgs e)
{
   //TaskInfo is model class
 ObservableCollection<TaskInfo> taskInfo = new ObservableCollection<TaskInfo>();
  // Get the filtered items
  var items = (sender as DataSource).DisplayItems;
  foreach (TaskInfo item in items)
     taskInfo.Add(item as TaskInfo);
}
{% endhighlight %}
{% endtabs %}

## Clear filtering

The SfListView allows clearing the filters by setting the [DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_Filter) to null, and call the [DataSource.RefreshFilter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.DataSource.html#Syncfusion_Maui_DataSource_DataSource_RefreshFilter) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.DataSource.Filter = null;
listView.DataSource.RefreshFilter();
{% endhighlight %}
{% endtabs %}

## Sort the filtered items

Filtered items can be sorted by adding a [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.SortDescriptor.html) in the `FilterChanged` event. The following code example shows how to sort the filtered items:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataSource_FilterChanged(object sender, NotifyCollectionChangedEventArgs e)
{
  listView.DataSource.SortDescriptors.Clear();
  listView.DataSource.SortDescriptors.Add(
          new SortDescriptor 
          { 
             PropertyName = "Title", 
             Direction = ListSortDirection.Ascending 
          }); 
  listView.RefreshView();
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output rendered when the filtered items are sorted:
![Syncfusion .NET MAUI ListView Sorting Filtered Items](Images/filtering/maui-listview-sorting-filtered-items.png)

## Custom Filter UI in .NET MAUI ListView (SfListView)

This section explains how to enable and customize the filtering user interface (UI) in the `.NET MAUI ListView` (`SfListView`). You can customize the filter data using the `FilteringUITemplate` property. The filtering UI can be displayed by using the `ShowFilteringUICommand`, which displays the defined template inside a popup.

## Filtering UI APIs

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.html) provides the following APIs to configure and display the filtering UI:

- [`FilteringUITitle`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITitle): Specifies the title displayed in the filtering UI popup.
- [`ShowFilteringUICommand`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowFilteringUICommand): Triggers the filtering UI programmatically, typically from a button.
- [`FilteringUITemplate`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITemplate): Defines the custom layout of the filtering UI, allowing you to design filter elements such as buttons, chips, or other controls.

{% tabs %}

{% highlight xaml tabtitle="MainPage.xaml" hl_lines="3 9 14" %}
<syncfusion:SfListView x:Name="listView"
                       ItemsSource="{Binding Employees}"
                       FilteringUITitle="Filtering">

    <!-- Trigger Filtering UI -->
    <syncfusion:SfListView.HeaderTemplate>
        <DataTemplate>
            <Button Text="Filter"
                    Command="{Binding Source={x:Reference listView}, Path=ShowFilteringUICommand}" />
        </DataTemplate>
    </syncfusion:SfListView.HeaderTemplate>

    <!-- Custom Filtering UI -->
    <syncfusion:SfListView.FilteringUITemplate>
        <DataTemplate>
            <VerticalStackLayout Padding="14" Spacing="10">
                <Label Text="Department" FontAttributes="Bold"/>
                <!-- Define custom filter UI elements here -->
            </VerticalStackLayout>
        </DataTemplate>
    </syncfusion:SfListView.FilteringUITemplate>

</syncfusion:SfListView>
{% endhighlight %}

{% highlight c# tabtitle="MainPage.xaml.cs"  hl_lines="1 3 5" %}
listView.FilteringUITitle = "Filtering";

var command = listView.ShowFilteringUICommand;

listView.FilteringUITemplate = new DataTemplate(() =>
{
    return new VerticalStackLayout
    {
        Padding = 14,
        Children =
        {
            new Label
            {
                Text = "Department",
                FontAttributes = FontAttributes.Bold
            }
        }
    };
});
{% endhighlight %}

{% endtabs %}

The following screenshot shows the filtering UI popup displayed in the SfListView:

![MAUI ListView Filtering UI](Images/filtering/maui-listview-filtering-ui.png)

## See also

[How to filter the items in .NET MAUI ListView (SfListView) using MVVM](https://www.syncfusion.com/kb/13060/)