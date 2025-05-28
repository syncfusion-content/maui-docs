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

<syncfusion:SfDataGrid 
            x:Name="dataGrid"    
            ColumnWidthMode="Fill"
            AutoGenerateColumnsMode="None"
            ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridUnboundColumn 
                        MappingName="DiscountPrice"
                        HeaderText="SUM"
                        Expression="Price1+Price2"
                        Format="C" />
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>

{% endhighlight %}

{% highlight c# %}

SfDataGrid dataGrid = new SfDataGrid();
OrderInforRepo orderInforRepo = new OrderInforRepo();
dataGrid.ItemsSource = orderInforRepo;

DataGridUnboundColumn DiscountColumn = new DataGridUnboundColumn()
{
    MappingName = "DiscountPrice",
    HeaderText = "SUM",
    Expression = "Price1+Price2",
    Format = "C"
};

this.datagrid.Columns.Add(DiscountColumn);
  
{% endhighlight %}
{% endtabs %}


<img alt="Unbound column in MAUI DataGrid" src="Images\unbound-column\maui-datagrid-unbound-column.png" width="404" />

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

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid x:Name="dataGrid"    
        ColumnWidthMode="Fill"
        AutoGenerateColumnsMode="None"
        ItemsSource="{Binding OrderInfoCollection1}">
    <syncfusion:SfDataGrid.Columns>
         <syncfusion:DataGridUnboundColumn 
                MappingName="DiscountPrice"
                Expression="Price1+Price2"
                HeaderText="SUM"/>
    </syncfusion:SfDataGrid.Columns>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

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
{% highlight C# %}

datagrid.QueryUnboundColumnValue += DataGrid_QueryUnboundColumnValue;

private void DataGrid_QueryUnboundColumnValue(object? sender, DataGridUnboundColumnEventArgs e)
{
    if (e.UnboundAction == DataGridUnboundActions.QueryData)
    {
        var Price1 = Convert.ToInt16(e.Record.GetType().GetProperty("Price1").GetValue(e.Record));
        var Price2 = Convert.ToInt16(e.Record.GetType().GetProperty("Price2").GetValue(e.Record));
        e.Value = Price1 - Price2;
    }
}
  
{% endhighlight %}
{% endtabs %}