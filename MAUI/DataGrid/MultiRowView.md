---
layout: post
title: Multi-Row View in .NET MAUI Data Grid | Syncfusion
description: Learn how to display records across multiple rows in Syncfusion® .NET MAUI Data Grid using Multi-Row View and create rich, card-like layouts.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui data grid, maui datagrid, multirow view, multi row view, maui grid layout, maui datagrid layout, .net maui datagrid
---

# Multi-Row View in .NET MAUI Data Grid

The [SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html) supports displaying a record across multiple rows by using the `MultiRowViewDefinition`. This feature enables you to arrange columns in a customized layout and create card-like views within each record row.

The Multi-Row View is useful when displaying a large number of fields, improving readability by organizing data into multiple rows and columns.

## Enabling Multi-Row View

You can enable Multi-Row View by defining a `DataGridMultiRowViewDefinition` in the `SfDataGrid.MultiRowViewDefinition` property. The `RowsCount` and `ColumnsCount` properties specify the number of rows and columns in the layout. The available cell space is divided based on these values.

{% tabs %}
{% highlight xaml %}

<syncfusion:SfDataGrid ItemsSource="{Binding OrderInfoCollection}">
    <syncfusion:SfDataGrid.MultiRowViewDefinition>
        <syncfusion:DataGridMultiRowViewDefinition RowsCount="2" ColumnsCount="2" />
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

## Defining Column Positions

The column positions in a Multi-Row View layout can be customized using the positioning properties available in the `DataGridColumn` class. These properties determine where a cell is displayed within the Multi-Row View structure.

- `Row` - Specifies the row index where the column is placed.
- `Column` - Specifies the column index where the column is placed.
- `RowSpan` - Specifies the number of rows occupied by the column.
- `ColumnSpan` - Specifies the number of columns occupied by the column.

The `Row` and `Column` properties use zero-based indexing to position cells within the layout. The `Row` property arranges cells vertically from top to bottom, while the `Column` property arranges cells horizontally from left to right. The `RowSpan` and `ColumnSpan` properties can be used to make a cell span across multiple rows or columns.

## Multi-Row layout example

In the following example, the record data is displayed in a layout containing 2 rows and 3 columns. Each column is positioned using the `Row` and `Column` properties, and can span multiple rows or columns using the `RowSpan` and `ColumnSpan` properties.

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

<img alt="MAUI Data Grid with MultiRowView" src="Images\multiRowView\maui-datagrid-multirowview.png" width="404" />  

In this layout, the **Profile** column spans two rows using `RowSpan = 2`, and the **Customer ID** column spans two columns using `ColumnSpan = 2`. The remaining columns are positioned based on their assigned `Row` and `Column` indexes.

## Limitations

- The `Row` and `Column` values must be within the ranges specified by `RowsCount` and `ColumnsCount`.
- `RowSpan` and `ColumnSpan` values should not exceed the defined layout boundaries, and multiple columns cannot occupy the same layout cell.
- Multi-Row View does not support column resizing, row resizing, frozen columns, Details View, stacked headers, column drag and drop, column chooser, row headers, and serialization.
- Only `Fill` `ColumnWidthMode` is supported.