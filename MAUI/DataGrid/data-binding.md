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

The code below demonstrates how to bind a data source to the `SfDataGrid`. Each row in the SfDataGrid binds to an object in the data source. Each column binds to a property in the data model object.


{% tabs %}
{% highlight xaml %}
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:GettingStarted"
             xmlns:syncfusion="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             x:Class="GettingStarted.MainPage">

    <ContentPage.BindingContext>
        <local:OrderInfoViewModel/>
    </ContentPage.BindingContext>

    <syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}" />
</ContentPage>
{% endhighlight %}

{% highlight c# %}
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = orderInfoViewModel.OrderInfoCollection;
{% endhighlight %}
{% endtabs %}

If the data source implements the [INotifyCollectionChanged](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=net-6.0) interface, then the `SfDataGrid` will automatically refresh the view when an item is added, removed, or cleared. [ObservableCollection](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1?view=net-6.0) implements this interface and automatically triggers UI updates. However, [List](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-6.0) does not, so changes will not refresh the view automatically.

If the data model implements the [INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-6.0) interface, then the SfDataGrid responds to property changes at runtime and updates the view.

## Binding with IEnumerable

The `SfDataGrid` control supports binding any collection that implements from [IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable?view=net-6.0) interface. All the data operations such as sorting and filtering are supported when the binding collection is derived from `IEnumerable`.

## Binding with DataTable

The `SfDataGrid` control supports binding to a [DataTable](https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-6.0). The `SfDataGrid` automatically refreshes the UI when rows are added, removed, or cleared.

{% tabs %}
{% highlight c# %}
DataTable table = GetDataTable();
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = table;

private DataTable GetDataTable()
{
    DataTable table = new DataTable("Orders");
    table.Columns.Add("OrderID", typeof(int));
    table.Columns.Add("CustomerName", typeof(string));
    table.Columns.Add("OrderDate", typeof(DateTime));
    
    table.Rows.Add(1001, "John Smith", new DateTime(2024, 1, 15));
    table.Rows.Add(1002, "Jane Doe", new DateTime(2024, 1, 16));
    table.Rows.Add(1003, "Bob Wilson", new DateTime(2024, 1, 17));
    
    return table;
}
{% endhighlight %}
{% endtabs %}

### Limitations

* Custom sorting is not supported.
* [SfDataGrid.View.Filter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_Filter) is not supported. Use application-level filtering instead.
* [SfDataGrid.View.LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_LiveDataUpdateMode) is not supported. Manual grid refresh is required when data changes.

## Binding with dynamic data object

The `SfDataGrid` control supports binding to [dynamic data objects](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject?view=net-9.0) using [ExpandoObject](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.expandoobject?view=net-6.0).

### Example: ViewModel with Dynamic Objects

{% tabs %}
{% highlight c# %}
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class EmployeeViewModel : INotifyPropertyChanged
{
    private ObservableCollection<dynamic> _employeeDetails;
    private readonly Random _random = new Random();
    private readonly string[] _employeeNames = new[]
    {
        "Sean Jacobson",
        "Phyllis Allen",
        "Marvin Allen",
        "Michael Allen",
    };
    
    public EmployeeViewModel()
    {
        EmployeeDetails = GetEmployeesDetails_Dynamic(200);
    }
    
    public ObservableCollection<dynamic> EmployeeDetails
    {
        get => _employeeDetails;
        set
        {
            if (_employeeDetails != value)
            {
                _employeeDetails = value;
                OnPropertyChanged();
            }
        }
    }
    
    public ObservableCollection<dynamic> GetEmployeesDetails_Dynamic(int count)
    {
        var employees = new ObservableCollection<dynamic>();
        for (int i = 1; i <= count; i++)
        {
            employees.Add(GetDynamicEmployee(i));
        }
        return employees;
    }
    
    public dynamic GetDynamicEmployee(int id)
    {
        dynamic employee = new ExpandoObject();
        employee.EmployeeID = id;
        employee.EmployeeName = _employeeNames[_random.Next(_employeeNames.Length)];
        employee.ContactID = id + 1000;
        return employee;
    }
    
    public event PropertyChangedEventHandler PropertyChanged;
    
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
{% endhighlight %}
{% endtabs %}

### Manually Defined Columns (with Dynamic Data)

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding EmployeeDetails}"
                       AutoGenerateColumnsMode="None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="[EmployeeID]"
                                          HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="[EmployeeName]"
                                       HeaderText="Employee Name" />
        <syncfusion:DataGridNumericColumn MappingName="[ContactID]"
                                          HeaderText="Contact ID" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       AutoGeneratingColumn="datagrid_AutoGeneratingColumn" />
{% endhighlight %}

{% highlight c# %}
OrderInfoRepository viewModel = new OrderInfoRepository();

SfDataGrid dataGrid = new SfDataGrid();
dataGrid.ItemsSource = viewModel.OrderInfoCollection;
dataGrid.AutoGeneratingColumn += datagrid_AutoGeneratingColumn;

private void datagrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
     e.Column.MappingName = "[" + e.Column.MappingName + "]";
}
{% endhighlight %}
{% endtabs %}

### Limitations with Dynamic Objects

* SfDataGrid doesn't support [LiveDataUpdateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_LiveDataUpdateMode) with `AllowDataShaping` and `AllowSummaryUpdate`.

## Binding complex properties

The SfDataGrid control supports binding complex (nested) properties to columns. To bind a complex property, set the property path to [MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) using dot notation.

### Data Model Example

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    public int OrderID { get; set; }
    public string ShipCity { get; set; }
    public Customer Customer { get; set; }
}

public class Customer
{
    public string CustomerID { get; set; }
    public string CustomerName { get; set; }
}
{% endhighlight %}
{% endtabs %}

### XAML Example

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid AutoGenerateColumnsMode="None"
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="OrderID" HeaderText="Order ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer.CustomerID" HeaderText="Customer ID" />
        <syncfusion:DataGridTextColumn MappingName="Customer.CustomerName" HeaderText="Customer Name" />
        <syncfusion:DataGridTextColumn MappingName="ShipCity" HeaderText="City" />
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

## View and Data Operations

When you bind a collection to the `ItemsSource` property, the SfDataGrid creates a view object that manages data operations.

### ICollectionViewAdv Interface

The [ICollectionViewAdv](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html) interface is responsible for:
- Maintaining the collection and applying filters/sorts
- Handling data insertions, deletions, and modifications
- Supporting advanced operations like grouping and summaries

The SfDataGrid creates different view implementations based on your `ItemsSource` type.

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
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.Loaded += SfDataGrid_Loaded;

private void SfDataGrid_Loaded(object sender, EventArgs e)
{
    dataGrid.View.LiveDataUpdateMode = LiveDataUpdateMode.Default;
}
{% endhighlight %}
{% endtabs %}

### RecordPropertyChanged Event

The [RecordPropertyChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_RecordPropertyChanged) event fires when a data model property changes (requires `INotifyPropertyChanged` implementation).

#### Event Arguments
- **sender**: The data model object
- **PropertyChangedEventArgs.PropertyName**: Name of the changed property

#### Example

{% highlight c# %}
void OnViewLoaded()
{
    dataGrid.View.RecordPropertyChanged += (sender, args) =>
    {
        Debug.WriteLine($"Property changed: {args.PropertyName}");
    };
}
{% endhighlight %}

### SourceCollectionChanged Event

The [SourceCollectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Data.ICollectionViewAdv.html#Syncfusion_Maui_Data_ICollectionViewAdv_SourceCollectionChanged) event fires when the underlying collection is modified (add, remove, clear items).

#### Event Arguments ([NotifyCollectionChangedEventArgs](https://learn.microsoft.com/en-us/dotnet/api/system.collections.specialized.notifycollectionchangedeventargs?view=net-6.0))
- **Action**: Type of change (Add, Remove, Move, Replace, or Reset)
- **NewItems**: Items added to the collection
- **OldItems**: Items removed from the collection
- **NewStartingIndex**: Index where new items appear
- **OldStartingIndex**: Index where old items were

#### Example

{% highlight c# %}
void OnViewLoaded()
{
    dataGrid.View.SourceCollectionChanged += (sender, args) =>
    {
        if (args.Action == NotifyCollectionChangedAction.Add)
            Debug.WriteLine($"{args.NewItems.Count} items added at index {args.NewStartingIndex}");
    };
}
{% endhighlight %}

## Retain scroll position

To retain the scroll position when [ItemsSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource) changes, set the [SfDataGrid.CanMaintainScrollPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanMaintainScrollPosition) to true. If you set `SfDataGrid.CanMaintainScrollPosition` to true then on changing `ItemsSource`, the newly added `ItemsSource` will be loaded with the previous ItemsSource's `ScrollOffset`.

{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
dataGrid.CanMaintainScrollPosition = true;
{% endhighlight %}

## SetCellValue

The `SetCellValue` method allows you to programmatically update a cell value at runtime.

> **Note:** For features like Sorting, Grouping, or Filtering to update automatically after a value change, set `LiveDataUpdateMode="AllowDataShaping"` on the grid's View. Ensure the cell's row and column exist in the grid.

### Limitations
- Caption rows, summary rows, unbound rows, and unbound columns cannot be updated by `SetCellValue`.

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
    // Update using column object
    dataGrid.SetCellValue(1, dataGrid.Columns[0], "11111");    
}
{% endhighlight %}
{% endtabs %}

### Overload 2: SetCellValue(int rowIndex, string fieldName, object value)

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
    // Update using property name
    dataGrid.SetCellValue(1, "OrderID", "11111");    
}
{% endhighlight %}
{% endtabs %}

> **Note:** Looking for the full .NET MAUI DataGrid component overview, features, pricing, and documentation? Visit the [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) page.
