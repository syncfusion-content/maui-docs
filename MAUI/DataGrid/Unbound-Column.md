---
layout: post
title: Unbound Columns in MAUI DataGrid control | Syncfusion®
description: Learn here all about unbound columns support in Syncfusion® MAUI DataGrid (SfDataGrid) control and more about it.
platform: MAUI
control: SfDataGrid
documentation: UG
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui unbound column, maui unbound coulumn
---

# Unbound column in MAUI DataGrid (SfDataGrid)

The data grid allows adding additional columns that are not bound with data objects from the underlying data source. The unbound column can be added using the [SfDataGrid.DataGridUnboundColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html) class.

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       AutoGenerateColumnsMode = "None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName = "Customer"
                                       HeaderText = "Customer"/>
        <syncfusion:DataGridNumericColumn MappingName = "Quantity"
                                          HeaderText = "Quantity"
                                          Format = "#"/>
        <syncfusion:DataGridNumericColumn MappingName = "UnitPrice"
                                          HeaderText = "Unit Price"
                                          Format = "C"/>
        <syncfusion:DataGridUnboundColumn MappingName = "TotalPrice"
                                          HeaderText = "Total"
                                          Expression = "UnitPrice*Quantity"
                                          Format = "C" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

var orderColumn = new DataGridTextColumn()
{
    MappingName = "Customer",
    HeaderText = "Customer",
};
dataGrid.Columns.Add(orderColumn);

var quantityColumn = new DataGridNumericColumn()
{
    MappingName = "Quantity",
    HeaderText = "Quantity",
    Format = "#",
};
dataGrid.Columns.Add(quantityColumn);

var unitPriceColumn = new DataGridNumericColumn()
{
    MappingName = "UnitPrice",
    HeaderText = "Unit Price",
    Format = "C",
};
dataGrid.Columns.Add(unitPriceColumn);

DataGridUnboundColumn totalColumn = new DataGridUnboundColumn()
{
    MappingName = "TotalPrice",
    HeaderText = "total",
    Expression = "UnitPrice*Quantity",
    Format = "C"
};
dataGrid.Columns.Add(totalColumn);

this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}


<img alt="Unbound column in MAUI DataGrid" src="Images\unbound-column\maui-datagrid-unbound-column.png" width="404" Height = "429"/>

> **Note:** It is mandatory to specify the `DataGridColumn.MappingName` for `SfDataGrid.DataGridUnboundColumn` with some name to identify the column. It is not necessary for this field to exist in the data object.

## Populating data for the unbound column

Data for the unbound column can be configured using one of two approaches:
1. **Expression property** — for simple arithmetic and logical calculations
2. **QueryUnboundColumnValue event** — for complex logic and custom data retrieval

### Using Expression

The arithmetic or logical expression can be specified using the `Expression` property to compute the display value. By default, `DataGridUnboundColumn` evaluates expressions with case sensitivity. Disable case sensitivity by setting the [CaseSensitive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html#Syncfusion_Maui_DataGrid_DataGridUnboundColumn_CaseSensitiveProperty) property to `false`.

<table>
    <tr>
        <th> Arithmetic operations </th>
        <th> Operator </th>
        <th> Usage in Expression </th>
    </tr>
    <tr>
        <td> Add</td>
        <td> + </td>
        <td> `UnitPrice + Tax` </td>
    </tr>
    <tr>
        <td> Subtract</td>
        <td> - </td>
        <td> `Price - Discount` </td>
    </tr>
    <tr>
        <td> Multiply</td>
        <td> * </td>
        <td> `UnitPrice * Quantity` </td>
    </tr>
    <tr>
        <td> Divide </td>
        <td> / </td>
        <td> `Total / ItemCount` </td>
    </tr>
    <tr>
        <td> Power</td>
        <td> ^ </td>
        <td> `Value ^ 2` </td>
    </tr>
    <tr>
        <td> Mod</td>
        <td> % </td>
        <td> `Quantity % 12` </td>
    </tr>
    <tr>
        <td> Greater Than</td>
        <td> > </td>
        <td> `Price > 1000` </td>
    </tr>
    <tr>
        <td> Less than</td>
        <td> < </td>
        <td> `Quantity < 10` </td>
    </tr>
    <tr>
        <td> Equal</td>
        <td> = </td>
        <td> `Status = 'Active'` </td>
    </tr>
    <tr>
        <td> Greater Than or Equal</td>
        <td> >= </td>
        <td> `Rating >= 4` </td>
    </tr>
    <tr>
        <td> Less Than or Equal </td>
        <td> <= </td>
        <td> `Age <= 18` </td>
    </tr>
</table>

<table>
    <tr>
        <th> Logical operations </th>
        <th> Character Code </th>
        <th> Usage in Expression </th>
    </tr>
    <tr>
        <td> AND </td>
        <td> (char)135 </td>
        <td> `(Quantity > 10)(char)135(UnitPrice > 100)` </td>
    </tr>
    <tr>
        <td> OR  </td>
        <td> (char)136 </td>
        <td> `(Quantity > 10)(char)136(UnitPrice > 100)` </td>
    </tr>
    <tr>
        <td> NOT </td>
        <td> (char)137 </td>
        <td> `(char)137(IsApproved)` </td>
    </tr>
</table>

**CaseSensitive Example:**

With `CaseSensitive="True"` (default): Expression `"unitprice*quantity"` will fail because field names are case-sensitive.
With `CaseSensitive="False"`: Expression `"unitprice*quantity"` works and matches `UnitPrice` and `Quantity`.

## Using QueryUnboundColumnValue event

The [QueryUnboundColumnValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryUnboundColumnValue) event fires when a value for the unbound column is requested. It provides information about the cell that triggered this event, allowing you to set custom values for unbound column cells. This event is triggered with `DataGridUnboundColumnEventArgs`.

The [DataGridUnboundColumnEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumnEventArgs.html) provides the following properties:

- **Column:** Gets the `DataGridColumn` of the cell that triggers this event.
- **OriginalSender:** Gets the data grid instance raising the event.
- **Record:** Gets the underlying row data object.
- **UnboundAction:** Defines the action that triggered the event. 
- **Value:** Gets or sets the value for the `DataGridUnboundColumn` cell based on the `UnboundAction`.

Populate the data for the unbound column by handling the `QueryUnboundColumnValue` event, which allows customizing the value of the `DataGridUnboundColumn`. The `DataGridUnboundColumnEventArgs` exposes the `Value` property, allowing you to set values for unbound column cells based on the `UnboundAction`.

Refer to the following code example in which data for the unbound column is populated by handling the `QueryUnboundColumnValue` event:

{% tabs %}
{% highlight xaml %}
<ContentPage.BindingContext>
    <local:OrderInfoViewModel x:Name = "viewModel"/>
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name = "dataGrid"
                       ItemsSource = "{Binding Orders}"
                       QueryUnboundColumnValue = "DataGrid_QueryUnboundColumnValue"
                       AutoGenerateColumnsMode = "None">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName = "Customer"
                                       HeaderText = "Customer"/>
        <syncfusion:DataGridNumericColumn MappingName = "Quantity"
                                          HeaderText = "Quantity"
                                          Format = "#"/>
        <syncfusion:DataGridNumericColumn MappingName = "UnitPrice"
                                          HeaderText = "Unit Price"
                                          Format = "C"/>
        <syncfusion:DataGridUnboundColumn MappingName = "TotalPrice"
                                          HeaderText = "Total"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight C# %}
SfDataGrid dataGrid = new SfDataGrid();
OrderInfoViewModel viewModel = new OrderInfoViewModel();
dataGrid.ItemsSource = viewModel.Orders;
dataGrid.QueryUnboundColumnValue += DataGrid_QueryUnboundColumnValue;
dataGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;

var orderColumn = new DataGridTextColumn()
{
    MappingName = "Customer",
    HeaderText = "Customer",
};
dataGrid.Columns.Add(orderColumn);

var quantityColumn = new DataGridNumericColumn()
{
    MappingName = "Quantity",
    HeaderText = "Quantity",
    Format = "#",
};
dataGrid.Columns.Add(quantityColumn);

var unitPriceColumn = new DataGridNumericColumn()
{
    MappingName = "UnitPrice",
    HeaderText = "Unit Price",
    Format = "C",
};
dataGrid.Columns.Add(unitPriceColumn);

DataGridUnboundColumn totalColumn = new DataGridUnboundColumn()
{
    MappingName = "TotalPrice",
    HeaderText = "total",
};
dataGrid.Columns.Add(totalColumn);

this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight C# %}
private void DataGrid_QueryUnboundColumnValue(object? sender, DataGridUnboundColumnEventArgs e)
{
    if (e.UnboundAction == DataGridUnboundActions.QueryData)
    {
        var recordType = e.Record?.GetType();
        if (recordType == null)
            return;

        var unitPriceProperty = recordType.GetProperty("UnitPrice");
        var quantityProperty = recordType.GetProperty("Quantity");

        if (unitPriceProperty == null || quantityProperty == null)
            return;

        var unitPriceValue = unitPriceProperty.GetValue(e.Record);
        var quantityValue = quantityProperty.GetValue(e.Record);

        if (unitPriceValue != null && quantityValue != null &&
            decimal.TryParse(unitPriceValue.ToString(), out decimal unitPrice) &&
            int.TryParse(quantityValue.ToString(), out int quantity))
        {
            decimal total = unitPrice * quantity;
            e.Value = total.ToString("C");
        }
    }
}
{% endhighlight %}
{% endtabs %}
