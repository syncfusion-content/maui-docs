---
layout: post
title: Unbound Row in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Unbound Row support in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
---


# Unbound Row in .NET MAUI DataGrid (SfDataGrid)

The .NET MAUI DataGrid allows you to add **additional rows** at top and also bottom of the DataGrid which are **not bound with data object** of underlying data source. You can add unbound rows using [SfDataGrid.UnboundRows]() collection property. You can add any no of unbound rows to the DataGrid. Unbound rows can also be exported to pdf and excel documents.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid"  
                       ItemsSource="{Binding OrdersInfo}">
    <syncfusion:SfDataGrid.UnboundRows>
        <syncfusion:DataGridUnboundRow Position="Top" />
    </syncfusion:SfDataGrid.UnboundRows>
</syncfusion:SfDataGrid>
{% endhighlight %}

{% highlight c# %}
this.dataGrid.UnboundRows.Add(new DataGridUnboundRow() { Position = DataGridUnboundRowPosition.Top });
{% endhighlight %}
{% endtabs %}

<img alt="Unbound Rows" src="Images\unboundRow\maui-datagrid-unbound-row-top.png" width="404"/>

## Positioning unbound rows

Unbound row can be placed in top or bottom of the DataGrid by setting the desired value to the [DataGridUnboundRow.Position]() property.

Below table shows the available unbound row positions.

<table>
<tr>
<th>
UnboundRowPosition
</th>
<th>
Position in DataGrid
</th>
</tr>
<tr>
<td>
FixedTop
</td>
<td>
Unbound row placed at top, right below the Header row. In this position, unbound row is not selectable, <b>not editable</b> and <b>frozen</b> when scrolling.
</td>
</tr>
<tr>
<td>
Top
</td>
<td>
Unbound row placed at top, right above the record rows. In this position, unbound row is selectable, <b>editable</b> and <b>scrollable</b>.
</td>
</tr>
<tr>
<td>
Bottom
</td>
<td>
Unbound row placed at bottom, right below record rows. In this position, unbound row is selectable, <b>editable</b> and <b>scrollable</b>.
</td>
</tr>
<tr>
<td>
FixedBottom
</td>
<td>
Unbound row placed at bottom of SfDataGrid. In this position, unbound row is not selectable, <b>not editable</b> and <b>frozen</b> when scrolling.
</td>
</tr>
</table>

Below screenshot shows different unbound rows placed in all possible positions.

<img alt="Positioning unbound rows" src="Images\unboundRow\maui-datagrid-unbound-row-positioning.png" width="404"/>

## Populating data for unbound rows

You can populate data for the unbound row by handling [QueryUnboundRow]() event of .NET MAUI DataGrid. This event is fired for each cell of the unbound rows whenever the row gets refreshed or comes to view. 
[DataGridUnboundRowEventArgs]() of the `QueryUnboundRow` event provides information about the cell that triggered this event.

You can get or set the [DataGridUnboundRowEventArgs.Value]() property based on the [DataGridUnboundActions](). If `UnboundAction` is `QueryData` then you can set the value to be displayed. If the `UnboundAction` is `CommitData` then you can get the edited value.

{% tabs %}
{% highlight xaml %}
<syncfusion:SfDataGrid x:Name="dataGrid" 
                       ItemsSource="{Binding Orders}"                         
                       SelectionMode="Single" >                        
        <syncfusion:SfDataGrid.UnboundRows>
            <syncfusion:DataGridUnboundRow Position="Top" />
        </syncfusion:SfDataGrid.UnboundRows>                                 
</syncfusion:SfDataGrid>
{% endhighlight %}
{% endtabs %}

For example, now unbound row populated based on selected items in SfDataGrid.


{% tabs %}
{% highlight c# %}
datagrid.SelectedIndex = 2;
datagrid.QueryUnboundRow += Datagrid_QueryUnboundRow;
datagrid.SelectionChanged += Datagrid_SelectionChanged;

private void Datagrid_SelectionChanged(object? sender, DataGridSelectionChangedEventArgs e)
{
    datagrid!.InvalidateUnboundRow(datagrid!.UnboundRows[0]);
}

private void Datagrid_QueryUnboundRow(object? sender, DataGridUnboundRowEventArgs e)
{
    if (e.RowColumnIndex.ColumnIndex == 0)
    {
        e.Value = (datagrid.CurrentRow as OrderInfo).OrderID;
    }
    else if (e.RowColumnIndex.ColumnIndex == 1)
    {
        
        e.Value = (datagrid.CurrentRow as OrderInfo).CustomerID;
    }
    else if (e.RowColumnIndex.ColumnIndex == 2)
    {
        
        e.Value = (datagrid.CurrentRow as OrderInfo).ShipCountry;
    }
    e.Handled = true;
}
{% endhighlight %}
{% endtabs %}

<img alt="Populating data for unbound rows" src="Images\unboundRow\maui-datagrid-unbound-row-population-data.png" width="404"/>

## Refreshing the Unbound Rows at runtime


### Add/Remove unbound rows

You can add or remove unbound rows using [SfDataGrid.UnboundRows]() property which reflects in UI immediately.
 
### Trigger QueryUnboundRow event programmatically
 
You can trigger the [QueryUnboundRow]() event for the unbound row cells at runtime by calling [SfDataGrid.InvalidateUnboundRow]() method which invalidates the unbound row at the given index.

Here in the below code example, we have invalidated the unbound rows whenever selection is changed in the DataGrid.

{% tabs %}
{% highlight c# %}
datagrid.SelectionChanged += Datagrid_SelectionChanged;
private void Datagrid_SelectionChanged(object? sender, DataGridSelectionChangedEventArgs e)
{
    datagrid!.InvalidateUnboundRow(datagrid!.UnboundRows[0]);
}
{% endhighlight %}
{% endtabs %}


## Editing in unbound rows

### Cancel the editing for unbound row cell

You can cancel the editing of unbound row cell in the event handler of  [SfDataGrid.CurrentCellBeginEdit]() event with the help of [SfDataGrid.GetUnboundRowAtRowIndex]() method and row index.

{% tabs %}
{% highlight c# %}
this.dataGrid.CurrentCellBeginEdit += DataGrid_CurrentCellBeginEdit;

private void DataGrid_CurrentCellBeginEdit(object sender, DataGridCurrentCellBeginEditEventArgs e)
{
    var unboundRow = dataGrid.GetUnboundRowAtRowIndex(e.RowColumnIndex.RowIndex);

    if (unboundRow == null)
        return;
    e.Cancel = true;
}
{% endhighlight %}
{% endtabs %}

### Saving edited unbound row cell value to external source

You can get the edited value of unbound row cell from [DataGridUnboundRowEventArgs.Value]() property of [QueryUnboundRow]() event when `UnboundAction` is `CommitData`.

{% tabs %}
{% highlight c# %}
private void Datagrid_QueryUnboundRow(object? sender, DataGridUnboundRowEventArgs e)
{
    if (e.UnboundAction == DataGridUnboundActions.CommitData)
    {
       var editedValue = e.Value;
    }
}
{% endhighlight %}
{% endtabs %}

## Changing unbound row height

You can change the height of unbound row using [SfDataGrid.QueryRowHeight]() event.


{% tabs %}
{% highlight c# %}
this.dataGrid.QueryRowHeight += DataGrid_QueryRowHeight;     

private void DataGrid_QueryRowHeight(object? sender, DataGridQueryRowHeightEventArgs e)
{
    if (dataGrid.IsUnboundRow(e.RowIndex))
    {
        e.Height = 60;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

<img alt="Changing unbound row height" src="Images\unboundRow\maui-datagrid-unbound-row-height.png" width="404"/>

## Get unbound rows

The unbound row can be obtained by using the [GetUnboundRowAtRowIndex]() method.

{% tabs %}
{% highlight c# %}
var unboundRow = dataGrid.GetUnboundRowAtRowIndex(1);
{% endhighlight %}
{% endtabs %}