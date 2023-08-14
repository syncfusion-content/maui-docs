---
layout: post
title: Filtering in .NET MAUI ListView control | Syncfusion
description: Learn here all about Filtering support in Syncfusion .NET MAUI ListView (SfListView) control and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Filtering in .NET MAUI ListView (SfListView)

This section explains how to filter the data and its related operations in the SfListView.

To get start quickly with .NET MAUI ListView Filtering, you can check on this video:
<style>#MAUIListViewFilteringVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIListViewFilteringVideoTutorial' src='https://www.youtube.com/watch?v=IedulwH4h4c'></iframe>

## Programmatic filtering

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html) supports data filtering by setting the [SfListView.DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_Filter) property. You have to call the [SfListView.DataSource.RefreshFilter](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_RefreshFilter) method after assigning the `Filter` property for refreshing the view.

The [FilterChanged](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_FilterChanged) event is raised once filtering is applied to the SfListView.

The `FilterContacts` method filters the data contains the filter text value. Assign the `FilterContacts` method to the `SfListView.DataSource.Filter` predicate to filter the `ContactName`. To apply filtering in the SfListView, follow the code example:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="10" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
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
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="6" %}
var grid = new Grid();
grid.RowDefinitions.Add(new RowDefinition());
grid.RowDefinitions.Add(new RowDefinition());

var searchBar = new SearchBar() { Placeholder = "Search here to filter" };
searchBar.TextChanged += OnFilterTextChanged;

var listView = new SfListView();
listView.ItemsSource = viewModel.Items;
listView.ItemSize = 60;

grid.Children.Add(searchBar);
grid.Children.Add(listView);
grid.SetRow(searchBar, 0);
grid.SetRow(listView, 1);

{% endhighlight %}
{% endtabs %}
 
The following code example illustrates how to filter the data using `FilterContacts` method in the ViewModel:

{% tabs %}
{% highlight c# tabtitle="ViewModel.cs" hl_lines="7 12 13 14 15 16 17 18 19 20 21 22" %}
SearchBar searchBar = null;
private void OnFilterTextChanged(object sender, TextChangedEventArgs e)
{
  searchBar = (sender as SearchBar);
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
   if (taskInfo.Title.ToLower().Contains(searchBar.Text.ToLower()) || taskInfo.Description.ToLower().Contains(searchBar.Text.ToLower()))
      return true;
  else
      return false;
}
{% endhighlight %}
{% endtabs %}

The following screenshot shows the output rendered when the items are filtered:
![MAUI ListView Filtering](Images/filtering/maui-listview-filtering-items.png)



### Filter based on multiple criteria

The [SfListView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html) allows filtering the items based on multiple criteria. The following code example explains how to  filter the data using multiple properties:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="7" %}
private bool FilterContacts(object obj)
{
  if (searchBar == null || searchBar.Text == null)
     return true;

  var taskInfo = obj as TaskInfo;
   if (taskInfo.Title.ToLower().Contains(searchBar.Text.ToLower()) || taskInfo.Description.ToLower().Contains(searchBar.Text.ToLower()))
      return true;
   else
      return false;
}
{% endhighlight %}
{% endtabs %}

## Getting the filtered data

You can get filtered items from the view and modify it in the [SfListView.DataSource.FilterChanged](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_FilterChanged) event. When filter is applied, the filtered items are available in the [SfListView.DataSource.DisplayItems](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_DisplayItems).

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="8" %}
listView.DataSource.FilterChanged += DataSource_FilterChanged;
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

The SfListView allows clearing the filters by setting the [DataSource.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_Filter) to null, and call the [DataSource.RefreshFilter](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.DataSource.html#Syncfusion_DataSource_DataSource_RefreshFilter) method.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
listView.DataSource.Filter = null;
listView.DataSource.RefreshFilter();
{% endhighlight %}
{% endtabs %}

## Sort the filtered items

The order of the filtered items can be rearranged in the `FilterChanged` event by adding [SortDescriptor](https://help.syncfusion.com/cr/maui/Syncfusion.DataSource.SortDescriptor.html). To sort the filtered items, follow the code example:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void DataSource_FilterChanged(object sender, NotifyCollectionChangedEventArgs e)
{
  listView.Clear();
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
![MAUI ListView Sorting Filtered Items](Images/filtering/maui-listview-sorting-filtered-items.png)

## See also

[How to filter the items in .NET MAUI ListView (SfListview) using MVVM](https://www.syncfusion.com/kb/13060/)