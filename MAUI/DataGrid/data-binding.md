---
layout: post
title: Data Binding in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about Data Binding support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui data binding, maui data binding
---

# Data Binding in MAUI DataGrid (SfDataGrid)

The [.NET MAUI DataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) Control is bound to an external data source to display the data in a tabular format. It supports data sources such as List, IEnumerable, and so on. The [SfDataGrid.ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSourceProperty) property helps to bind this control with a collection of objects.

The codes below codes demonstrate how to bind a data source to the `SfDataGrid`. Each row in the SfDataGrid binds to an object in the data source. Each column binds to a property in the data model object.

{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="sfDataGrid"
                       ItemsSource="{Binding OrderInfoCollection}" />
</ContentPage>
{% endhighlight %}

{% highlight c# %}
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
this.sfDataGrid.ItemsSource = orderInfoViewModel.OrderInfoCollection;
{% endhighlight %}
{% endtabs %}

If the data source implements the [ICollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.icollection?view=net-6.0) interface, then the `SfDataGrid` will automatically refresh the view when an item is added, removed, or cleared. When you add or remove an item in [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-6.0), it automatically refreshes the view as the ObservableCollection. That implements the [INotifyCollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.system-componentmodel-inotifypropertychanged-propertychanged?view=net-6.0). But when you do the same in `List`, it will not refresh the view automatically.

If the data model implements the `INotifyPropertyChanged` interface, then the SfDataGrid responds to the property change at runtime to update the view.

## Binding with IEnumerable

The `SfDataGrid` control supports binding any collection that implements from [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-6.0) interface. All the data operations such as sorting and filtering are supported when the binding collection is derived from `IEnumerable`.

## Binding with DataTable

The `SfDataGrid` control supports binding the [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-6.0). `SfDataGrid` control automatically refresh the UI when binding `DataTable` as `ItemsSource` when rows are added, removed or cleared.

{% tabs %}
{% highlight c# %}
DataTable table = this.GetDataTable();
this.sfDataGrid1.ItemsSource = table;
{% endhighlight %}
{% endtabs %}

### Limitations

* Custom sorting is not supported.
* [SfDataGrid.View.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_Filter) is not supported.
* [SfDataGrid.View.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_LiveDataUpdateMode) is not supported.

## Binding complex properties

The SfDataGrid control provides support for binding complex properties to its columns. To bind the complex property to [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html), set the complex property path to [MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName).

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID" />
        <syncfusion:DataGridTextColumn MappingName="Customer.CustomerID" />
        <syncfusion:DataGridTextColumn MappingName="ShipCity" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}


The SfDataGrid control provides support for binding complex properties such as indexers, dictionaries to its columns. To bind the complex property to [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html), set the [UseBindingValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_UseBindingValue) property to true.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="OrderID" UseBindingValue="True" />
        <syncfusion:DataGridTextColumn MappingName="CustomerID" UseBindingValue="True" />
        <syncfusion:DataGridTextColumn MappingName="ShipCity" UseBindingValue="True" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

### Limitations when binding complex property 

* SfDataGrid doesn’t support [LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LiveDataUpdateModeProperty) - `AllowDataShaping` and `AllowSummaryUpdate`.

## View

The `SfDataGrid` has the View property of type [ICollectionViewAdv](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html) interface that implements `ICollectionView` interface. The view is responsible for maintaining and manipulating data and other advanced operations, like Sorting, Filtering, and etc.,

When you bind a collection to the `ItemsSource` property of the `SfDataGrid`, then View will be created and maintains the operations on Data such as Sorting, Filtering, Inserting, Deleting, and Modification.

>Note: The `SfDataGrid` creates different types of view derived from `ICollectionViewAdv` interface based on the `ItemsSource` property.

### LiveDataUpdateMode

During data manipulation operations and property changes, the `SfDataGrid` supports updating the view by using the `LiveDataUpdateMode` property which exists in the [SfDataGrid.View](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv) class.

<table>
<tr>
<th>LiveDataUpdateMode</th>
<th>Description</th>
</tr>
<tr>
<td>Default</td>
<td>Data operations are not updated. </td>
</tr>
<tr>
<td>AllowSummaryUpdate</td>
<td>Summaries are updated during data manipulation change.</td>
</tr>
<tr>
<td>AllowDataShaping</td>
<td>Data operations like sorting, and filtering are updated during data manipulation change.
</td>
</tr>
</table>

{% tabs %}
{% highlight c# %}
this.sfDataGrid.Loaded += SfDataGrid_Loaded;

private void SfDataGrid_Loaded(object sender, EventArgs e)
{
    this.sfDataGrid.View.LiveDataUpdateMode = LiveDataUpdateMode.Default;
}
{% endhighlight %}
{% endtabs %}

### RecordPropertyChanged

The [RecordPropertyChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_RecordPropertyChanged) event is invoked when the value of the `DataModel` property is changed, if `DataModel` implements the `INotifyPropertyChanged` interface. The event receives with two arguments namely `sender` that handles the `DataModel` and the [PropertyChangedEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.propertychangedeventargs?view=net-6.0) as argument. `PropertyChangedEventArgs` object contains the following property,

* **PropertyName**: Defines the `PropertyName` of the changed value in the `DataModel`.

### SourceCollectionChanged

The [SourceCollectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_SourceCollectionChanged) event is invoked when the `SourceCollection` is changed, for example, adding or removing the collection. The event receives two arguments namely `sender` that handles [GridQueryableCollectionViewWrapper](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GridQueryableCollectionViewWrapper.html) object and the [NotifyCollectionChangedEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.notifycollectionchangedeventargs?view=net-6.0) as argument. `NotifyCollectionChangedEventArgs` object contains the following properties,

* **Action**: Defines the current action. (i.e.) Add, Remove, Move, Replace, Reset.
* **NewItems**: It contains the list of new items involved in the change.
* **OldItems**: It contains the list of old items affected by the Action.
* **NewStartingIndex**: It contains the index at which the change occurred.
* **OldStartingIndex**: It contains the index at which the Action occurred.

## Retain scroll position

To retain the scroll position when [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) changes, set the [SfDataGrid.CanMaintainScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanMaintainScrollPosition) to true. If you set `SfDataGrid.CanMaintainScrollPosition` to true then on changing `ItemsSource`, the newly added `ItemsSource` will be loaded with the previous ItemsSource's `ScrollOffset`.

{% highlight C# %}
dataGrid.CanMaintainScrollPosition = true;
{% endhighlight %}