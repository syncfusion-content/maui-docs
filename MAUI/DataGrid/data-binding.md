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

    <syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}" />
</ContentPage>
{% endhighlight %}

{% highlight c# %}
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
this.dataGrid.ItemsSource = orderInfoViewModel.OrderInfoCollection;
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
this.dataGrid.ItemsSource = table;
{% endhighlight %}
{% endtabs %}

### Limitations

* Custom sorting is not supported.
* [SfDataGrid.View.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_Filter) is not supported.
* [SfDataGrid.View.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_LiveDataUpdateMode) is not supported.

## Binding with dynamic data object

The `SfDataGrid` control supports binding to a [dynamic data object](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject?view=net-9.0).

The code examples below demonstrate how to bind a dynamic data object to the `SfDataGrid` using both manually and automatically generated columns.

{% tabs %}
{% highlight c# %}

public class EmployeeCollection
{
       
    Random random = new Random();
        
    public EmployeeCollection()
    {
        EmployeeDetails = GetEmployeesDetails_Dynamic(200);
    }
    
    #region ItemsSource
    
    private ObservableCollection<dynamic> _employeeDetails;
    public ObservableCollection<dynamic> EmployeeDetails
    {
        get
        {
            return _employeeDetails;
        }
        set
        {
            _employeeDetails = value;
            RaisePropertyChanged("EmployeeDetails");
        }
    }
    
    #endregion
    
    // Dynamic DataSource
    
    public ObservableCollection<dynamic> GetEmployeesDetails_Dynamic(int count)
    {
        var employees = new ObservableCollection<dynamic>();
        for (int i = 1; i < count; i++)
        {
            employees.Add(GetDynamicEmployee(i));
        }
        return employees;
    }
    
    // Dynamic Property
    public dynamic GetDynamicEmployee(int i)
    {
        dynamic employee = new ExpandoObject();
        employee.EmployeeName = employeeName[random.Next(4)];
        employee.EmployeeID = i;
        employee.ContactID = i + 100;
        return employee;
    }
    
    string[] employeeName = new string[]
    {
        "Sean Jacobson",
        "Phyllis Allen",
        "Marvin Allen",
        "Michael Allen",
    };
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGenerateColumnsMode="None" />
<syncfusion:SfDataGrid.Columns>
    <syncfusion:DataGridNumericColumn MappingName="[OrderID]"
                                      HeaderText="Order ID" />
    <syncfusion:DataGridTextColumn MappingName="[CustomerID]"
                                   HeaderText="Customer ID" />
    <syncfusion:DataGridTextColumn MappingName="[ShipCountry]"
                                   HeaderText="Ship Country" />
</syncfusion:SfDataGrid.Columns>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGeneratingColumn="datagrid_AutoGeneratingColumn" />
{% endhighlight %}

{% highlight c# %}
private void datagrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
     e.Column.MappingName = "[" + e.Column.MappingName + "]";
}
{% endhighlight %}
{% endtabs %}

### Limitations

* SfDataGrid doesn’t support [LiveDataUpdateMode]() - `AllowDataShaping` and `AllowSummaryUpdate`.

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
this.dataGrid.Loaded += SfDataGrid_Loaded;

private void SfDataGrid_Loaded(object sender, EventArgs e)
{
    this.dataGrid.View.LiveDataUpdateMode = LiveDataUpdateMode.Default;
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

## SetCellValue

The `SetCellValue` method on `SfDataGrid` allows you to programmatically update the value of a specific cell.

N>
1. For features (like Sorting, Grouping, Filtering) set LiveDataUpdateMode="AllowDataShaping" to ensure the grid updates in live mode after a value change.
2.Caption rows, summary rows, unbound rows and unbound columns cannot be updated by SetCellValue.

SfDataGrid provides two overloads of SetCellValue:

1. SetCellValue(int rowIndex, DataGridColumn column, object value)

<table>
<tr>
<th> Parameter </th>
<th> Type </th>
<th> Description </th>
</tr>
<tr>
<td> rowIndex </td>
<td> int </td>
<td> The index of the row in which the cell exists. </td>
</tr>
<tr>
<td> column </td>
<td> DataGridColumn </td>
<td> It represents the column of the cell to be updated. </td>
</tr>
<tr>
<td> value </td>
<td> object </td>
<td> The new value to assign to the cell. </td>
</tr>
</table>

{% tabs %}
{% highlight C# %}
  private void Button_Clicked(object sender, EventArgs e)
  {
      dataGrid.SetCellValue(1, dataGrid.Columns[0], "11111");    
  }
{% endhighlight %}
{% endtabs %}

2. SetCellValue(int rowIndex, string fieldName, object value)

<table>
<tr>
<th> Parameter </th>
<th> Type </th>
<th> Description </th>
</tr>
<tr>
<td> rowIndex </td>
<td> int </td>
<td> The index of the row in which the cell exists. </td>
</tr>
<tr>
<td> column </td>
<td> string fieldName </td>
<td> The name of the property to update in the data record. </td>
</tr>
<tr>
<td> value </td>
<td> object </td>
<td> The new value to assign to the cell. </td>
</tr>
</table>

{% tabs %}
{% highlight C# %}
  private void Button_Clicked(object sender, EventArgs e)
  {
      dataGrid.SetCellValue(1, "OrderID", "11111");    
  }
{% endhighlight %}
{% endtabs %}
