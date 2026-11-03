# DataGrid Sample

A getting-started sample for the Syncfusion .NET MAUI `SfDataGrid` control.

## What it is

The `SfDataGrid` displays tabular data with explicitly mapped columns and supports editing.

## NuGet package

`Syncfusion.Maui.DataGrid`

## Documentation

https://help.syncfusion.com/maui/datagrid/getting-started

## Sample organization

- `DataGridView.xaml` — the page hosting `SfDataGrid` bound to the view model.
- `DataGridViewModel.cs` — holds the `Orders` collection of sample data.
- `DataGridModel.cs` — the data entity (implements `INotifyPropertyChanged` for editing).

## Layout and sample data

The sample includes 50 orders with unique order IDs and 10 customers. Ten columns include customer/shipping details, order date, product, quantity, unit price, and a calculated total. ColumnWidthMode Fill distributes columns across wide windows; minimum column widths keep them readable with horizontal scrolling on narrow screens. The grid fills the page content area and keeps its default control styling.
