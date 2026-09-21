---
layout: post
title: MultiRow View in .NET MAUI Data Grid | Syncfusion
description: Learn how to display records across multiple rows in Syncfusion® .NET MAUI Data Grid using MultiRow View and create rich, card-like layouts.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui data grid, maui datagrid, multirow view, multi row view, maui grid layout, maui datagrid layout, .net maui datagrid
---

# MultiRow View in .NET MAUI Data Grid

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) supports displaying a record across multiple rows by using the `MultiRowViewDefinition`. This feature enables you to arrange columns in a customized layout and create card-like views within each record row.

The MultiRow View is useful when displaying a large number of fields, improving readability by organizing data into multiple rows and columns.

## Enabling MultiRow View

You can enable MultiRow View by defining a `DataGridMultiRowViewDefinition` in the `SfDataGrid.MultiRowViewDefinition` property.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">

    <syncfusion:SfDataGrid.MultiRowViewDefinition>
        <syncfusion:DataGridMultiRowViewDefinition
            RowsCount="2"
            ColumnsCount="2" />
    </syncfusion:SfDataGrid.MultiRowViewDefinition>

</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}

var dataGrid = new SfDataGrid
{
    ItemsSource = viewModel.OrderInfoCollection,
    MultiRowViewDefinition = new DataGridMultiRowViewDefinition()
    {
        RowsCount = 2,
        ColumnsCount = 2
    }
};

{% endhighlight %}
{% endtabs %}

## Defining column positions

Each column can be placed within the MultiRow layout by using the following properties:

- `Row` - Specifies the row position.
- `Column` - Specifies the column position.
- `RowSpan` - Specifies the number of rows occupied by the column.
- `ColumnSpan` - Specifies the number of columns occupied by the column.

## MultiRow layout example

The following example arranges record data in a 2 × 3 layout.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid x:Name="dataGrid"                               
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">

    <syncfusion:SfDataGrid.MultiRowViewDefinition>
        <syncfusion:DataGridMultiRowViewDefinition  RowsCount="2"
                                                    ColumnsCount="3" />
    </syncfusion:SfDataGrid.MultiRowViewDefinition>

    <syncfusion:SfDataGrid.Columns>

        <syncfusion:DataGridImageColumn MappingName="EmpImg"
                                        HeaderText="Profile"
                                        Row="0"
                                        Column="0"
                                        RowSpan="2" />

        <syncfusion:DataGridTextColumn  MappingName="OrderID"
                                        HeaderText="Order ID"
                                        Row="0"
                                        Column="1" />

        <syncfusion:DataGridTextColumn  MappingName="Customer"
                                        HeaderText="Customer"
                                        Row="0"
                                        Column="2" />

        <syncfusion:DataGridTextColumn  MappingName="CustomerID"
                                        HeaderText="Customer ID"
                                        Row="1"
                                        Column="1"
                                        ColumnSpan="2" />

    </syncfusion:SfDataGrid.Columns>

</syncfusion:SfDataGrid>

{% endhighlight %}
{% highlight c# %}
SfDataGrid dataGrid = new SfDataGrid();

OrderInfoViewModel viewModel = new OrderInfoViewModel();

dataGrid.ItemsSource = viewModel.OrderInfoCollection;
dataGrid.GridLinesVisibility = GridLinesVisibility.Both;
dataGrid.HeaderGridLinesVisibility = GridLinesVisibility.Both;

dataGrid.MultiRowViewDefinition = new DataGridMultiRowViewDefinition
{
    RowsCount = 2,
    ColumnsCount = 3
};

dataGrid.Columns.Add(new DataGridImageColumn
{
    MappingName = "EmpImg",
    HeaderText = "Profile",
    Row = 0,
    Column = 0,
    RowSpan = 2
});

dataGrid.Columns.Add(new DataGridTextColumn
{
    MappingName = "OrderID",
    HeaderText = "Order ID",
    Row = 0,
    Column = 1
});

dataGrid.Columns.Add(new DataGridTextColumn
{
    MappingName = "Customer",
    HeaderText = "Customer",
    Row = 0,
    Column = 2
});

dataGrid.Columns.Add(new DataGridTextColumn
{
    MappingName = "CustomerID",
    HeaderText = "Customer ID",
    Row = 1,
    Column = 1,
    ColumnSpan = 2
});

this.Content = dataGrid;
{% endhighlight %}
{% endtabs %}

The above configuration displays each record using a two-row and three-column arrangement.

<img alt="MAUI Data Grid with MultiRowView" src="Images\multiRowView\maui-datagrid-multirowview.png" width="404" />  

## Limitations

- The `Row` value must be within the range specified by `RowsCount`.
- The `Column` value must be within the range specified by `ColumnsCount`.
- `RowSpan` and `ColumnSpan` values should not exceed the defined MultiRow layout boundaries.
- Multiple columns cannot occupy the same layout cell.