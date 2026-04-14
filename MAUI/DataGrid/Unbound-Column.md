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

The data grid allows adding additional columns that are not bound with data objects from the underlying data source.The unbound column can be added using the [SfDataGrid.DataGridUnboundColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html) class.

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

N> It is mandatory to specify the `DataGridColumn.MappingName` for `SfDataGrid.DataGridUnboundColumn` with some name to identify the column. It is not necessary to define name of the field in the data object.

## Populating data for the unbound column
Data for the unbound column can be configured by setting the `Expression` property.

### Using Expression
The arithmetic or logic expression can be specified by using the expression property to compute the display value. By default, `DataGridUnboundColumn` evaluates the expression with casing. The casing will be disabled while evaluating the expression by setting the [CaseSensitive](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html#Syncfusion_Maui_DataGrid_DataGridUnboundColumn_CaseSensitiveProperty) property to false

List of supported arithmetic and logical operations are as follows:

<table>
    <tr>
        <th> Arithmetic operations </th>
        <th> Operator </th>
    </tr>
    <tr>
        <td> Add</td>
        <td> + </td>
    </tr>
    <tr>
        <td> Subtract</td>
        <td> - </td>
    </tr>
    <tr>
        <td> Multiply</td>
        <td> * </td>
    </tr>
    <tr>
        <td> Divide </td>
        <td> / </td>
    </tr>
    <tr>
        <td> Power</td>
        <td> ^ </td>
    </tr>
    <tr>
        <td> Mod</td>
        <td> % </td>
    </tr>
    <tr>
        <td> Greater Than</td>
        <td> < </td>
    </tr>
    <tr>
        <td> Less than</td>
        <td> > </td>
    </tr>
    <tr>
        <td> Equal</td>
        <td> = </td>
    </tr>
    <tr>
        <td> GreaterThanOrEqual</td>
        <td> >= </td>
    </tr>
    <tr>
        <td> LessThanOrEqual </td>
        <td> <= </td>
    </tr>
</table>

<table>
    <tr>
        <th> Logical operations </th>
        <th> Operators </th>
    </tr>
    <tr>
        <td> AND </td>
        <td> (char)135 </td>
    </tr>
    <tr>
        <td> OR  </td>
        <td> (char)136 </td>
    </tr>
    <tr>
        <td> NOT </td>
        <td> (char)137 </td>
    </tr>
</table>

## Using QueryUnboundColumnValue event

The [QueryUnboundColumnValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_QueryUnboundColumnValue) event is fired when value for the unbound column is quired. It provides information about the cell that triggered this event. So, you can set the desired value for the grid cells of the unbound column. This event is triggered with the `DataGridUnboundEventArgs`.

The [DataGridUnboundColumnEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumnEventArgs.html) provides the following properties:

***Column:*** Gets DataGridColumn of the cell that triggers this event.
***OriginalSender:*** Gets the data grid raising event.
***Record:*** Gets the underlying row data
***UnboundAction:*** Defines the action for triggering event.
***Value:*** Gets or Sets the value for DataGridUnboundColumn cell based on unboundAction.

Populate the data for the unbound column by handling `QueryUnboundColumnValue` event which allows customizing the value of the `DataGridUnboundColumn`. `DataGridUnboundColumnEventArgs` exposes `Value` property, by which you can set the value for the grid cells of the unbound column based on the `UnboundAction`.

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
        var unitPrice = Convert.ToInt16(e.Record.GetType().GetProperty("UnitPrice").GetValue(e.Record));
        var quantity = Convert.ToInt16(e.Record.GetType().GetProperty("Quantity").GetValue(e.Record));
        var total = unitPrice * quantity;
        e.Value = total.ToString("C");

    }
} 
{% endhighlight %}
{% endtabs %}