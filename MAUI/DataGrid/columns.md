---
layout: post
title: Columns in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about Columns support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control, its elements, and more here.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui column, maui column
---

# Columns in MAUI DataGrid (SfDataGrid)

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) allows a user to create and add columns in the following two ways:

* Automatically generating columns
* Manually defining columns

To get start quickly with column manipulation in .NET MAUI DataGrid, you can check on this video:

<style>#MAUIDataGridVideoTutorial{width : 90% !important; height: 400px !important }</style> <iframe id='MAUIDataGridVideoTutorial' src='https://www.youtube.com/embed/QrMUWMnnLDU'></iframe>

## Automatic columns generation

The SfDataGrid creates columns automatically based on the bindable property [SfDataGrid.AutoGenerateColumnsMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsMode). The columns are generated based on the type of individual properties in the underlying collection that is set as ItemsSource.

The table below shows the column type created for the respective data types. For the remaining data types, [DataGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextColumn.html) will be created.

<table>
<tr>
<th> Data Type </th>
<th> Column </th>
</tr>
<tr>
<td> string, object </td>
<td> DataGridTextColumn </td>
</tr>
<tr>
<td> int, float, double, decimal and it’s respective nullable types </td>
<td> DataGridNumericColumn </td>
</tr>
<tr>
<td> DateTime </td>
<td> DataGridDateColumn </td>
</tr>
<tr>
<td> bool </td>
<td> DataGridCheckboxColumn </td>
</tr>
<tr>
<td> ImageSource </td>
<td> DataGridImageColumn </td>
</tr>
</table>

### Different modes to auto generate columns

The auto generation of the columns in `SfDataGrid` is happening based on the `SfDataGrid.AutoGenerateColumnsMode` property. The default value is [AutoGenerateColumnsMode.Reset](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsMode.html#Syncfusion_Maui_DataGrid_AutoGenerateColumnsMode_Reset).
The `SfDataGrid.AutoGenerateColumnsMode` includes the following modes,

<table>
<tr>
<th> Modes </th>
<th> Description </th>
</tr>
<tr>
<td> <code>None</code> </td>
<td> Stores only the columns that are defined in <code>SfDataGrid.Columns</code> collection.<br/> When changing the <code>ItemsSource</code> and sorting for explicitly defined <code>SfDataGrid.Columns</code> alone will be retained. </td>
</tr>
<tr>
<td> <code>Reset</code> </td>
<td> Retains the columns defined explicitly in the application level and creates columns newly for all the other properties in a data source.<br/> When changing the <code>ItemsSource</code> and sorting for explicitly defined <code>SfDataGrid.Columns</code> alone will be retained. </td>
</tr>
<tr>
<td> <code>ResetAll</code> </td>
<td> When changing the <code>ItemsSource</code>, the columns for the previous data source are cleared and the columns will be newly created for the new data source. Even when columns are explicitly defined, it does not consider the defined columns and creates the column based on the underlying collection.<br/> Further when changing the <code>ItemsSource</code> and sorting for all the columns will be cleared. </td>
</tr>
<tr>
<td> <code>RetainOld</code> </td>
<td> When changing the <code>ItemsSource</code>,  create columns for all fields in a data source when the DataGrid does not have any explicit definition for columns. When columns are defined explicitly, then the defined columns alone are retained and new columns are not created.<br/>Similarly, when changing the <code>ItemsSource</code> and when the DataGrid has an explicit definition for columns and sorting are retained as it is. </td>
</tr>
<tr>
<td> <code>SmartReset</code> </td>
<td> Retains the columns defined explicitly at the application level and the columns with <code>MappingName</code> identical to the properties in the new data source. Newly creates columns for all the other properties in the data source.
Similarly, it retains the sorting of the columns that are defined explicitly at the application level and the columns with <code>MappingName</code> identical to the properties in the new data source. </td>
</tr>
</table>

### Auto generate columns for custom type

By default, columns are also auto-generated for custom type properties and parent properties of complex properties in the data object. In the case of complex properties, use the [SfDataGrid.AutoGenerateColumnsModeForCustomType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsModeForCustomType) to auto-generate columns for either the parent property, inner properties of the parent, or both the parent and inner properties.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        AutoGenerateColumnsModeForCustomType="Both"
                        NavigationMode="Cell"
                        SelectionMode="Single">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AutoGenerateColumnsModeForCustomType = AutoGenerateColumnsModeForCustomType.Both;
dataGrid.NavigationMode = DataGridNavigationMode.Cell;
dataGrid.SelectionMode = DataGridSelectionMode.Single;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

### Customize automatically generated columns

The auto generated column can be customized by handling the [SfDataGrid.AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingColumn) event. The event will be invoked when the column is auto-generated.

The [DataGridAutoGeneratingColumnEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAutoGeneratingColumnEventArgs.html) object contains the following properties,

* **Column**: This property returns the created column which can be customized.
* **Cancel**: This property cancels the column creation.
* **PropertyType**: This property specifies the type of the underlying model property for which the column is created.

You can skip generating a column by handling the `SfDataGrid.AutoGeneratingColumn` event as follows,

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        AutoGeneratingColumn="DataGrid_AutoGeneratingColumn">
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "Country")
    {
        e.Cancel = true;
    }
}
{% endhighlight %}
{% endtabs %}

Formatting for the auto-generated columns can be applied as follows:

{% tabs %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AutoGeneratingColumn += DataGrid_AutoGeneratingColumn;
this.Content = dataGrid;

// Customizing the column format for UnitPrice and OrderDate columns
private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "UnitPrice")
    {
        e.Column.Format = "C";
    }
    else if (e.Column.MappingName == "OrderDate")
    {
        e.Column.Format = "MMMM dd";
    }
}
{% endhighlight %}
{% endtabs %}

### Data Annotations with AutoGenerateColumns

SfDataGrid support to generate the columns based on built-in [Data Annotation Attributes](https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc490428(v=vs.95)).

N> Data annotations are only applied when the `DataGrid.AutoGenerateColumns` property is set to True.

#### Exclude column

You can skip the column generation using `AutoGenerateField` property.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    [Display(AutoGenerateField = false, Description = "OrderID field is not generated in UI")]
    public int OrderID { get; set; }

    public string Customer { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Product { get; set; }
    public DateTime OrderDate { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### Editing

You can enable editing of cell values by setting the `Editable` attribute to true.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    public int OrderID { get; set; }
    public string Customer { get; set; }
    public string City { get; set; }

    [Editable(true)]
    public string Country { get; set; }

    public string Product { get; set; }
    public DateTime OrderDate { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### Change the HeaderText of column

You can customize header text of column using `Display.Name` property or `Display.ShortName` property.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    public int OrderID { get; set; }

    [Display(Name = "Name of the Customer", Description = "CustomerName is necessary for identification ")]
    public string Customer { get; set; }

    public string City { get; set; }
    public string Country { get; set; }
    public string Product { get; set; }
    public DateTime OrderDate { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### Change the order of the columns

You can change the order of columns using the `Display.Order` property. Columns are arranged based on the specified order value, with lower values appearing first.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    [Display(Order = 1)]
    public int OrderID { get; set; }

    [Display(Order = 0)]
    public string Customer { get; set; }

    public string City { get; set; }
    public string Country { get; set; }
    public string Product { get; set; }
    public DateTime OrderDate { get; set; }
}
{% endhighlight %}
{% endtabs %}

The OrderID and Customer column rearranged based on specified order.

<img alt="Changing Columns Order in Maui DataGrid" src="Images\columns\maui-datagrid-order.png" width="404"/>

#### DataGrid read-only column 

You can disable the editing for a column using `ReadOnly` attribute.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    [ReadOnly(true)]
    public int OrderID { get; set; }

    public string Customer { get; set; }
    public string City { get; set; }

    [ReadOnly(true)]
    public string Country { get; set; }

    public string Product { get; set; }
}
{% endhighlight %}
{% endtabs %}

#### Format datagrid columns using DisplayFormat attribute

You can format auto-generated columns using the [DisplayFormat](https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc679253%28v%3dvs.95%29) attribute with the [DataFormatString](https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc679306%28v%3dvs.95%29) property defined for properties in the model.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    public int OrderID { get; set; }
    public string Customer { get; set; }

    [DisplayFormat(DataFormatString = "yyyy"), Display(Name = "Order Date")]
    public DateTime OrderDate { get; set; }

    [DisplayFormat(DataFormatString = "Country is {0}")]
    public string Country { get; set; }
}
{% endhighlight %}
{% endtabs %}

<img alt="Maui DataGrid with Columns Formatting" src="Images\columns\maui-datagrid-formatting.png" width="404"/>

#### Group columns under stacked header
You can group multiple columns under a shared stacked header using the `Display.GroupName` property. Nested grouping is supported using the / separator in the ChildColumns property.

{% tabs %}
{% highlight c# %}
public class OrderInfo
{
    [Display(GroupName = "Order Details")]
    public int OrderID { get; set; }

    [Display(GroupName = "Order Details")]
    public string Customer { get; set; }

    [Display(GroupName = "Order Details")]
    public string City { get; set; }

    [Display(GroupName = "Order Details")]
    public string Country { get; set; }
}

[Display(GroupName = "Order Details")]
public double Qty
{
    get { return qty; }
    set { this.qty = value; }
}
{% endhighlight %}
{% endtabs %}

<img alt="Maui DataGrid group columns with stacked header" src="Images\columns\maui-datagrid-groupName.png" width="404"/>

## Manually generate columns

The `SfDataGrid` allows to define the columns manually by adding the [DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html) objects to the [SfDataGrid.Columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns) collection. If you want to show only the manually defined columns in the view, you can achieve that by setting the `SfDataGrid.AutoGenerateColumnsMode` property to `None`.

There are different types of columns available. Any column can be created based on the requirements from both XAML and code.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        AutoGenerateColumnsMode="None"
                        ItemsSource="{Binding Orders}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID"
                                            MappingName="OrderID"/>
        <syncfusion:DataGridTextColumn  HeaderText="Customer"
                                        MappingName="Customer"/>
        <syncfusion:DataGridTextColumn  HeaderText="Ship City"
                                        MappingName="City"/>
        <syncfusion:DataGridTextColumn  HeaderText="Ship Country"
                                        MappingName="Country"/>
        <syncfusion:DataGridTextColumn  HeaderText="Product"
                                        MappingName="Product"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

DataGridNumericColumn orderIdColumn = new DataGridNumericColumn { HeaderText = "Order ID", MappingName = "OrderID" };
DataGridTextColumn customerColumn = new DataGridTextColumn { HeaderText = "Customer", MappingName = "Customer" };
DataGridTextColumn shipCityColumn = new DataGridTextColumn { HeaderText = "Ship City", MappingName = "City" };
DataGridTextColumn shipCountryColumn = new DataGridTextColumn { HeaderText = "Ship Country", MappingName = "Country" };
DataGridTextColumn productColumn = new DataGridTextColumn { HeaderText = "Product", MappingName = "Product" };

dataGrid.Columns.Add(orderIdColumn);
dataGrid.Columns.Add(customerColumn);
dataGrid.Columns.Add(shipCityColumn);
dataGrid.Columns.Add(shipCountryColumn);
dataGrid.Columns.Add(productColumn);

this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

## Column manipulation

You can get the columns from the `SfDataGrid.Columns` property.

### Adding column to DataGrid

You can add a column to the DataGrid at runtime by adding an instance of a `DataGridColumn` to the `SfDataGrid.Columns` collection.

{% tabs %}
{% highlight c# %}
this.dataGrid.Columns.Add(new DataGridTextColumn() { HeaderText = "Order ID", MappingName = "OrderID" });
{% endhighlight %}
{% endtabs %}

### Accessing a column

You can access a column through its column index or [DataGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_MappingName) from the `SfDataGrid.Columns` collection.

{% tabs %}
{% highlight c# %}
DataGridColumn column = this.dataGrid.Columns[1];
// OR
DataGridColumn column = this.dataGrid.Columns["OrderID"];
{% endhighlight %}
{% endtabs %}

### Clearing or removing a column

You can remove all the columns by clearing the `SfDataGrid.Columns` property.

{% tabs %}
{% highlight c# %}
this.dataGrid.Columns.Clear();
{% endhighlight %}
{% endtabs %}

You can remove a column using the `Remove` and `RemoveAt` methods.

{% tabs %}
{% highlight c# %}
this.dataGrid.Columns.Remove(column);
// OR
this.dataGrid.Columns.RemoveAt(1);
{% endhighlight %}
{% endtabs %}

## Column Chooser

SfDataGrid allows you show or hide columns at runtime by selecting or deselecting them through the Column Chooser. You can enable this feature by setting the `SfDataGrid.ShowColumnChooser` property.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        ShowColumnChooser="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.ShowColumnChooser = true;
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

### Column Chooser Header Text

You can also customize the header text of the Column Chooser using the `SfDataGrid.ColumnChooserHeaderText` property. By default, `SfDataGrid.ColumnChooserHeaderText` property is set to `string.Empty`, so the header is not displayed. If you assign any non-empty string, the header becomes visible.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                        ItemsSource="{Binding Orders}"
                        ColumnChooserHeaderText="Select Visible Columns"
                        ShowColumnChooser="True">
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel orderInfoViewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = orderInfoViewModel.Orders;
dataGrid.ShowColumnChooser = true;
dataGrid.ColumnChooserHeaderText = "Select Visible Columns";
this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

<img alt="Maui DataGrid Column Chooser" src="Images\columns/maui-datagrid-columnchooser.png" width="404"/>