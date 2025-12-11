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
                           ItemsSource="{Binding OrderInfoCollection}"
                           AutoGenerateColumnsModeForCustomType="Both"
                           NavigationMode="Cell"
                           SelectionMode="Single">
    </syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
dataGrid.AutoGenerateColumnsModeForCustomType = AutoGenerateColumnsModeForCustomType.Both;
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
{% highlight c# %}
this.dataGrid.AutoGeneratingColumn += SfDataGrid_AutoGeneratingColumn;

private void SfDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
	if(e.Column.MappingName == "ShipCountry")
	{
		e.Cancel = true;
	}
}
{% endhighlight %}
{% endtabs %}

Formatting for the auto-generated columns can be applied as follows:

{% tabs %}
{% highlight c# %}
private void SfDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
{
    if (e.Column.MappingName == "Freight")
    {
        e.Column.Format = "C";
    }
    else if (e.Column.MappingName == "ShippingDate")
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
[Display(AutoGenerateField = false, Description = "OrderID field is not generated in UI")]
public int OrderID
{
    get { return orderID; }
    set { orderID = value; }
}
{% endhighlight %}
{% endtabs %}

#### Editing

You can enable editing of cell values by setting the `Editable` attribute to true.

{% tabs %}
{% highlight c# %}
[Editable(true)]
public string Country
{
    get { return country; }
    set { country = value; }
}
{% endhighlight %}
{% endtabs %}

#### Change the HeaderText of column

You can customize header text of column using `Display.Name` property or `Display.ShortName` property.

{% tabs %}
{% highlight c# %}
[Display(Name="Name of the Customer",Description="CustomerName is necessary for identification ")]
public string CustomerName
{
    get { return customerName; }
    set { customerName = value; }
}
{% endhighlight %}
{% endtabs %}

#### Change the order of the columns

You can change the order of columns using the `Display.Order` property. Columns are arranged based on the specified order value, with lower values appearing first.

{% tabs %}
{% highlight c# %}
[Display(Order=1)]
public string CustomerID
{
    get { return customerId; }
    set { customerId = value; }
}

[Display(Order=0)]
public int OrderID
{
    get { return orderID; }
    set { orderID = value; }
}
{% endhighlight %}
{% endtabs %}

The OrderID and CustomerID column rearranged based on specified order.

<img alt="Changing Columns Order in Maui DataGrid" src="Images\columns\maui-datagrid-order.png" width="404"/>

#### DataGrid read-only column 

You can disable the editing for a column using `ReadOnly` attribute.

{% tabs %}
{% highlight c# %}
[ReadOnly(true)]
public string Country
{
    get { return country; }
    set { country = value; }
}
{% endhighlight %}
{% endtabs %}

#### Format datagrid columns using DisplayFormat attribute

You can format auto-generated columns using the [DisplayFormat](https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc679253%28v%3dvs.95%29) attribute with the [DataFormatString](https://learn.microsoft.com/en-us/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc679306%28v%3dvs.95%29) property defined for properties in the model.

{% tabs %}
{% highlight c# %}
[DisplayFormat(DataFormatString = "yyyy")]
public DateTime OrderDate
{
    get {  return _orderDate; }
    set {  orderDate = value; }
}

[DisplayFormat(DataFormatString = "Country is {0}")]
public string Country
{
    get { return country; }
    set { country = value; }
}
{% endhighlight %}
{% endtabs %}

<img alt="Maui DataGrid with Columns Formatting" src="Images\columns\maui-datagrid-formatting.png" width="404"/>

#### Group columns under stacked header
You can group multiple columns under a shared stacked header using the `Display.GroupName` property. Nested grouping is supported using the / separator in the ChildColumns property.

{% tabs %}
{% highlight c# %}
[Display(GroupName = "Order Details")]
public string? OrderID
{
    get { return orderID; }
    set { this.orderID = value; }
}

[Display(GroupName = "Order Details")]
public DateTime OrderDate
{
    get { return _orderDate; }
    set { _orderDate = value; }
}

[Display(GroupName = "Order Details")]
public string? ShipCountry
{
    get { return shipCountry; }
    set { this.shipCountry = value; }
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
                       ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn HeaderText="Order ID"
                                          MappingName="OrderID" />
        <syncfusion:DataGridTextColumn  HeaderText="Customer ID"
                                        MappingName="CustomerID" />
        <syncfusion:DataGridTextColumn  HeaderText="Customer"
                                        MappingName="Customer" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship City"
                                        MappingName="ShipCity" />
        <syncfusion:DataGridTextColumn  HeaderText="Ship Country"
                                        MappingName="ShipCountry" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
this.dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

DataGridNumericColumn orderIdColumn = new DataGridNumericColumn { HeaderText = "Order ID", MappingName = "OrderID" };
DataGridTextColumn customerIdColumn = new DataGridTextColumn { HeaderText = "Customer ID", MappingName = "CustomerID" };
DataGridTextColumn customerColumn = new DataGridTextColumn { HeaderText = "Customer", MappingName = "Customer" };
DataGridTextColumn shipCityColumn = new DataGridTextColumn { HeaderText = "Ship City", MappingName = "ShipCity" };
DataGridTextColumn shipCountryColumn = new DataGridTextColumn { HeaderText = "Ship Country", MappingName = "ShipCountry" };

this.dataGrid.Columns.Add(orderIdColumn);
this.dataGrid.Columns.Add(customerIdColumn);
this.dataGrid.Columns.Add(customerColumn);
this.dataGrid.Columns.Add(shipCityColumn);
this.dataGrid.Columns.Add(shipCountryColumn);
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

##Column Chooser

SfDataGrid allows you show or hide columns at runtime by selecting or deselecting them through the Column Chooser. You can enable this feature by setting the `SfDataGrid.ShowColumnChooser` property.

You can also customize the header text of the Column Chooser using the `SfDataGrid.ColumnChooserHeaderText` property. By default, `SfDataGrid.ColumnChooserHeaderText` property is set to string.Empty, so the header is not displayed. If you assign any non-empty string, the header becomes visible.

{% tabs %}
{% highlight xaml %}

    <syncfusion:SfDataGrid x:Name="dataGrid"
                           ItemsSource="{Binding OrdersInfo}"
                           ColumnChooserHeaderText="Select Visible Columns"
                           ShowColumnChooser="True">
    </syncfusion:SfDataGrid>

{% endhighlight %}

{% highlight c# %}

dataGrid.ShowColumnChooser = true;

{% endhighlight %}
{% endtabs %}

<img alt="Maui DataGrid Column Chooser" src="Images\columns/maui-datagrid-columnchooser.png" width="404"/>

