---
layout: post
title: Merged Cells in .NET MAUI DataGrid control | Syncfusion®
description: Learn all about Merged Cells support in Syncfusion® .NET MAUI DataGrid (SfDataGrid) control and more here.
platform: maui
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui, .net maui merged cells, maui merge cells, maui cell merging
---

# Merged Cells in .NET MAUI DataGrid (SfDataGrid)

The `SfDataGrid` control allows you to merge the range of adjacent cells using the `QueryCoveredRange` event. Merged cells can be exported to Excel and PDF.

The `QueryCoveredRange` event is fired when each cell is arranged, and the custom range is stored for visible rows and columns in `SfDataGrid.CoveredCells`. This event is not fired for cells that are not visible or for cells that are already present in `SfDataGrid.CoveredCells`. When scrolling, the merged range will be added for newly visible rows and columns through this event, and removed for rows and columns that go out of view.

`DataGridQueryCoveredRangeEventArgs` of the `QueryCoveredRange` event provides information about the cell that triggered the event. By using the `DataGridQueryCoveredRangeEventArgs.Range` property, adjacent cells can be merged.

Cell merging works independently of the selection configuration. However, when `SelectionMode` is not `None`, set the `SelectionUnit` to `Cell` and the `NavigationMode` to `Cell` to avoid conflicts between row selection and merged cell rendering.

N> `SelectionUnit` and `NavigationMode` do not need to be set to `Cell` when `SelectionMode` is `None`, as selection is disabled and there is no conflict with merged cell behavior.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       QueryCoveredRange="dataGrid_QueryCoveredRange" />
{% endhighlight %}
{% highlight c# %}
this.dataGrid.QueryCoveredRange += dataGrid_QueryCoveredRange;

private void dataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
}
{% endhighlight %}
{% endtabs %}

## Merging cells

You can span a cell across a row and column by merging a range of cells. Set a `CoveredCellInfo` (by defining Left, Right, Top, and Bottom) to the `DataGridQueryCoveredRangeEventArgs.Range` and handle the event.

### Merging cells horizontally by fixed range

You can merge columns in a row by setting the column range using the `Left` and `Right` properties of `CoveredCellInfo`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       QueryCoveredRange="dataGrid_QueryCoveredRange" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
    if (e.RowColumnIndex.RowIndex == 1)
    {
        if (e.RowColumnIndex.ColumnIndex >= 1 && e.RowColumnIndex.ColumnIndex <= 3)
        {
            e.Range = new CoveredCellInfo(1, 3, 1, 1);
            e.Handled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Horizontally merged cells in .NET MAUI DataGrid" src="Images\mergedcell\maui-datagrid-horizontal-merged-cells.png" width="404"/>

### Merging cells vertically by fixed range

You can merge a range of rows for a particular column by setting the row range using the `Top` and `Bottom` properties of `CoveredCellInfo`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       QueryCoveredRange="dataGrid_QueryCoveredRange" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
    if (e.RowColumnIndex.ColumnIndex == 1)
    {
        if (e.RowColumnIndex.RowIndex >= 1 && e.RowColumnIndex.RowIndex <= 5)
        {
            e.Range = new CoveredCellInfo(1, 1, 1, 5);
            e.Handled = true;
        }
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Vertically merged cells in .NET MAUI DataGrid" src="Images\mergedcell\maui-datagrid-vertical-merged-cells.png" width="404"/>

### Merging a range of cells

You can merge a range of rows and columns by setting the range using the `Left`, `Right`, `Top`, and `Bottom` properties of `CoveredCellInfo`.
{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       QueryCoveredRange="dataGrid_QueryCoveredRange" />
{% endhighlight %}
{% highlight c# %}
private void dataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
    if (e.RowColumnIndex.ColumnIndex == 1 && e.RowColumnIndex.RowIndex == 1)
    {
        e.Range = new CoveredCellInfo(1, 2, 1, 5);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Merged range of cells in .NET MAUI DataGrid" src="Images\mergedcell\maui-datagrid-merge-range-of-cells.png" width="404"/>

## Merging cells based on content

You can merge redundant data in adjacent cells in a row or column using the `QueryCoveredRange` event.

In the following code, the `GetRange` method returns a range for a cell based on the adjacent cells' content. The `QueryCoveredRange` handler then sets the range if the calculated range does not already exist in `SfDataGrid.CoveredCells`, using the `CoveredCells.IsInRange` method.

{% tabs %}
{% highlight c# %}
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.QueryCoveredRange += DataGrid_QueryCoveredRange;
        dataGrid.ItemsSourceChanged += DataGrid_ItemsSourceChanged;
    }
    
    private void DataGrid_ItemsSourceChanged(object sender, DataGridItemsSourceChangedEventArgs e)
    {
        // Refresh covered cells when the data source changes
        dataGrid.CoveredCells.Clear();
    }

    private void DataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
    {
        var range = GetRange(e.Column, e.RowColumnIndex.RowIndex, e.RowColumnIndex.ColumnIndex, e.Record);

        if (range == null)
            return;

        // Check if the range already exists in CoveredCells
        if (!dataGrid.CoveredCells.IsInRange(range))
        {
            e.Range = range;
            e.Handled = true;
        }
    }

    private CoveredCellInfo GetRange(DataGridColumn column, int rowIndex, int columnIndex, object rowData)
    {
        var range = new CoveredCellInfo(columnIndex, columnIndex, rowIndex, rowIndex);

        if (rowData == null || column == null)
            return null;

        var propertyInfo = rowData.GetType().GetProperty(column.MappingName);
        if (propertyInfo == null)
            return null;

        object data = propertyInfo.GetValue(rowData);

        int leftColumnIndex  = columnIndex;
        int rightColumnIndex = columnIndex;

        // Compare right columns
        for (int i = dataGrid.Columns.IndexOf(column) + 1; i < dataGrid.Columns.Count; i++)
        {
            var nextColumn = dataGrid.Columns[i];
            var nextPropertyInfo = rowData.GetType().GetProperty(nextColumn.MappingName);
            if (nextPropertyInfo == null) break;

            var compareData = nextPropertyInfo.GetValue(rowData);
            if (compareData == null || !compareData.Equals(data)) break;

            rightColumnIndex = dataGrid.ResolveToScrollColumnIndex(i);
        }

        // Compare left columns
        for (int i = dataGrid.Columns.IndexOf(column) - 1; i >= 0; i--)
        {
            var prevColumn = dataGrid.Columns[i];
            var prevPropertyInfo = rowData.GetType().GetProperty(prevColumn.MappingName);
            if (prevPropertyInfo == null) break;

            var compareData = prevPropertyInfo.GetValue(rowData);
            if (compareData == null || !compareData.Equals(data)) break;

            leftColumnIndex = dataGrid.ResolveToScrollColumnIndex(i);
        }

        if (leftColumnIndex != columnIndex || rightColumnIndex != columnIndex)
        {
            return new CoveredCellInfo(leftColumnIndex, rightColumnIndex, rowIndex, rowIndex);
        }

        // Merge vertically
        int topRowIndex    = rowIndex;
        int bottomRowIndex = rowIndex;

        var recordsCount = dataGrid.View?.Records?.Count ?? 0;

        // Compare previous rows
        for (int i = rowIndex - 1; i >= 1; i--)
        {
            var prevData = dataGrid.GetRecordAtRowIndex(i);
            if (prevData == null) break;

            var prevPropertyInfo = prevData.GetType().GetProperty(column.MappingName);
            if (prevPropertyInfo == null) break;

            var compareData = prevPropertyInfo.GetValue(prevData);
            if (compareData == null || !compareData.Equals(data)) break;

            topRowIndex = i;
        }

        // Compare next rows
        for (int i = rowIndex + 1; i <= recordsCount; i++)
        {
            var nextData = dataGrid.GetRecordAtRowIndex(i);
            if (nextData == null) break;

            var nextPropertyInfo = nextData.GetType().GetProperty(column.MappingName);
            if (nextPropertyInfo == null) break;

            var compareData = nextPropertyInfo.GetValue(nextData);
            if (compareData == null || !compareData.Equals(data)) break;

            bottomRowIndex = i;
        }

        if (topRowIndex != rowIndex || bottomRowIndex != rowIndex)
        {
            return new CoveredCellInfo(columnIndex, columnIndex, topRowIndex, bottomRowIndex);
        }

        return null;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Merged cells based on content in .NET MAUI DataGrid" src="Images\mergedcell\maui-datagrid-merge-cells-based-on-content.png" width="404"/>

## Merge cells in Master-Details view

The master-details view allows you to merge the range of cells using the `QueryCoveredRange` event of the nested `DetailsViewDataGrid`.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"
                       ItemsSource="{Binding OrderInfoCollection}"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both">
    <syncfusion:SfDataGrid.DetailsViewDefinition>
        <syncfusion:DataGridViewDefinition RelationalColumn="Orders">
            <syncfusion:DataGridViewDefinition.DataGrid>
                <syncfusion:SfDataGrid x:Name="FirstLevelNestedGrid"
                                       GridLinesVisibility="Both"
                                       HeaderGridLinesVisibility="Both"
                                       QueryCoveredRange="FirstLevelNestedGrid_QueryCoveredRange" />
            </syncfusion:DataGridViewDefinition.DataGrid>
        </syncfusion:DataGridViewDefinition>
    </syncfusion:SfDataGrid.DetailsViewDefinition>
</syncfusion:SfDataGrid>
{% endhighlight %}
{% highlight c# %}
private void FirstLevelNestedGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
    if (e.RowColumnIndex.ColumnIndex == 3)
    {
        e.Range = new CoveredCellInfo(3, 3, 2, 3);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Merged cells in Master-Details view in .NET MAUI DataGrid" src="Images\mergedcell\maui-datagrid-merge-cells-master-details-view.png" width="404"/>

### Merging range of parent cells

You cannot merge cells vertically for a parent row that has a details view expanded beneath it. Before defining the merged range inside the `QueryCoveredRange` event handler of the parent grid, use the `CanMergeNextRows` extension method of `SfDataGridHelpers` to check whether the row has a details view, and skip the merge accordingly.

{% tabs %}
{% highlight c# %}
private void dataGrid_QueryCoveredRange(object sender, DataGridQueryCoveredRangeEventArgs e)
{
    // Use CanMergeNextRows from SfDataGridHelpers to check if the row has a details view
    if (!dataGrid.CanMergeNextRows(e.Record))
        return;
}
{% endhighlight %}
{% endtabs %}

N> Vertical cell merging is not supported for a parent row that has an expanded details view.

## Refreshing merged cells at runtime

### Add covered range

You can add a range to `SfDataGrid.CoveredCells`at runtime using the `AddRange` extension method of `SfDataGridHelpers`. After adding the range, call `GetVisualContainer().InvalidateMeasure()` to refresh the layout and reflect the merged cell changes in the UI.

{% tabs %}
{% highlight c# %}
private void AddRange_Clicked(object sender, EventArgs e)
{
    dataGrid.AddRange(new CoveredCellInfo(2, 3, 3, 3));
    dataGrid.GetVisualContainer().InvalidateMeasure();
}
{% endhighlight %}
{% endtabs %}

### Remove covered range

You can remove a range from `SfDataGrid.CoveredCells` at runtime using the `RemoveRange` extension method of `SfDataGridHelpers`. After removing the range, call `GetVisualContainer().InvalidateMeasure()` to refresh the layout and reflect the changes in the UI.

{% tabs %}
{% highlight c# %}
private void RemoveRange_Clicked(object sender, EventArgs e)
{
    dataGrid.RemoveRange(new CoveredCellInfo(2, 3, 3, 3));
    dataGrid.GetVisualContainer().InvalidateMeasure();
}
{% endhighlight %}
{% endtabs %}

### Trigger QueryCoveredRange event programmatically

You can trigger the `QueryCoveredRange` event for a particular cell by removing its range from `SfDataGrid.CoveredCells` and calling `GetVisualContainer().InvalidateMeasure()` to invalidate the layout. You can retrieve the range for a particular cell in `CoveredCells` by passing the row and column index to the `CoveredCells.GetCoveredCellInfo` method.

For example, if you want to merge adjacent cells with the same content while editing, you can remove the existing range and invalidate the container in the [CurrentCellEndEdit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCellEndEdit) event so that the `QueryCoveredRange` event is retriggered to recalculate the merged ranges.

{% tabs %}
{% highlight c# %}
private void dataGrid_CurrentCellEndEdit(object sender, DataGridCurrentCellEndEditEventArgs e)
{
    var rowIndex    = e.RowColumnIndex.RowIndex;
    var columnIndex = e.RowColumnIndex.ColumnIndex;

    var range = dataGrid.CoveredCells.GetCoveredCellInfo(rowIndex, columnIndex);
    if (range != null)
    {
        dataGrid.RemoveRange(range);
        dataGrid.GetVisualContainer().InvalidateMeasure();
    }
}
{% endhighlight %}
{% endtabs %}


## Limitations

The following limitations apply when using cell merging in the SfDataGrid:

1. When `SelectionMode` is not `None`, `SelectionUnit` must be set to `Cell` and `NavigationMode` must be set to `Cell`. Row-level selection (`SelectionUnit` as `Row` or `Any`) is not supported alongside cell merging.
2. Cells in heterogeneous rows cannot be merged.
3. Frozen rows and columns do not support cell merging.
4. Swiping will not be enabled when a merged cell is applied.
