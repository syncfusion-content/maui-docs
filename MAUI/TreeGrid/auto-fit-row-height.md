---
layout: post
title: Auto-Fit Row Height in .NET MAUI Tree Grid | Syncfusion®
description: Learn how to auto-fit row heights based on cell content in Syncfusion® .NET MAUI Tree Grid using the QueryRowHeight event and the GetIntrinsicRowHeight method.
platform: MAUI
control: SfTreeGrid
documentation: ug
keywords : maui tree grid, maui treegrid, maui grid, grid maui, .net maui treegrid, .net maui tree grid, auto fit row height, treegrid row height, maui treegrid autofit, QueryRowHeight, GetIntrinsicRowHeight
appliesto: UI Component Suite
---

# Auto-Fit Row Height in .NET MAUI Tree Grid

The [.NET MAUI Tree Grid](https://www.syncfusion.com/maui-controls/maui-treegrid) (SfTreeGrid) allows you to size rows based on their cell content instead of using a fixed height. Auto-fit is applied on demand through the [QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowHeight) event, and the height is calculated by the [GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) method.

Auto-fit is not enabled automatically. By default, every data row uses [SfTreeGrid.RowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_RowHeight) (default 47) and the header row uses [SfTreeGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_HeaderRowHeight) (default 55). Auto-fit is applied only when you handle `QueryRowHeight`.

## Public APIs

| API | Type | Description |
|---|---|---|
| [SfTreeGrid.QueryRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_QueryRowHeight) | Event (`EventHandler<TreeGridQueryRowHeightEventArgs>`) | Occurs when the height of a row is queried. Handle it to set a custom or auto-fit height. |
| [TreeGridQueryRowHeightEventArgs.RowIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_RowIndex) | `int` (read-only) | The index of the row whose height is queried. |
| [TreeGridQueryRowHeightEventArgs.Height](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_Height) | `double` | Gets or sets the height of the row. |
| [TreeGridQueryRowHeightEventArgs.Handled](https://help.syncfusion.com/cr/maui/System.ComponentModel.HandledEventArgs.html) | `bool` | Inherited from `HandledEventArgs`. Set to `true` for the assigned `Height` to be applied. |
| [TreeGridQueryRowHeightEventArgs.GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridQueryRowHeightEventArgs.html#Syncfusion_Maui_TreeGrid_TreeGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__) | Method | Returns the height required to fit the content of the specified row. |
| [TreeGridHelper.GetRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridHelper.html) | Extension method on `SfTreeGrid` | Returns the content-based height of a row. Use it when the `SfTreeGrid` instance is available but the event arguments are not. |

N> There is no separate enum or property to switch auto-fit on or off. The feature is controlled entirely through the `QueryRowHeight` event.

### GetIntrinsicRowHeight parameters

`GetIntrinsicRowHeight(int rowIndex, bool canIncludeHiddenColumns = false, List<string>? excludedColumns = null)`

| Parameter | Description |
|---|---|
| `rowIndex` | The index of the row whose height is calculated. |
| `canIncludeHiddenColumns` | By default, hidden columns ([TreeGridColumn.Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_Visible) is `false`) are skipped. Set to `true` to include them in the calculation. |
| `excludedColumns` | A list of [TreeGridColumn.MappingName](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_MappingName) values to skip. By default, all columns are considered. |

## Auto-fit data rows based on content

Handle the `QueryRowHeight` event, assign the value returned by `GetIntrinsicRowHeight` to `Height`, and set `Handled` to `true`.

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage.BindingContext>
    <local:ProjectViewModel />
</ContentPage.BindingContext>

<syncfusion:SfTreeGrid x:Name="treeGrid"
                       ItemsSource="{Binding Projects}"
                       ChildPropertyName="Tasks"
                       ExpanderColumn="Name"
                       AutoGenerateColumnsMode="None"
                       QueryRowHeight="TreeGrid_QueryRowHeight">
    <syncfusion:SfTreeGrid.Columns>
        <syncfusion:TreeGridTextColumn MappingName="Name" HeaderText="Name" />
        <syncfusion:TreeGridTextColumn MappingName="Description" HeaderText="Description" />
        <syncfusion:TreeGridTextColumn MappingName="Owner" HeaderText="Owner" />
        <syncfusion:TreeGridTextColumn MappingName="Status" HeaderText="Status" />
    </syncfusion:SfTreeGrid.Columns>
</syncfusion:SfTreeGrid>
{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeGrid;

SfTreeGrid treeGrid = new SfTreeGrid();
ProjectViewModel viewModel = new ProjectViewModel();
treeGrid.ItemsSource = viewModel.Projects;
treeGrid.ChildPropertyName = "Tasks";
treeGrid.ExpanderColumn = "Name";
treeGrid.AutoGenerateColumnsMode = AutoGenerateColumnsMode.None;
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Name", HeaderText = "Name" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Description", HeaderText = "Description" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Owner", HeaderText = "Owner" });
treeGrid.Columns.Add(new TreeGridTextColumn { MappingName = "Status", HeaderText = "Status" });
treeGrid.QueryRowHeight += TreeGrid_QueryRowHeight;
this.Content = treeGrid;
{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    // Row index 0 is the header row when no stacked header rows are defined.
    if (e.RowIndex == 0)
    {
        return;
    }

    // Calculates the height of the row based on its content.
    e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
    e.Handled = true;
}
{% endhighlight %}
{% endtabs %}

N> The height is applied only when `e.Handled` is `true`. Otherwise the default `RowHeight` is used for the row.

## Calculate height based on certain columns

To ignore some columns while calculating the row height, pass their `MappingName` values in the `excludedColumns` parameter.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex, false, new List<string> { "Description" });
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Include hidden columns in the calculation

By default, hidden columns do not contribute to the row height. Set `canIncludeHiddenColumns` to `true` to consider them.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex > 0)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex, true);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Auto-fit header row based on header content

The header row is queried through the same event. Passing the header row index to `GetIntrinsicRowHeight` calculates the height from the header text or [HeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderTemplate). The calculated value is also assigned to [SfTreeGrid.HeaderRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.SfTreeGrid.html#Syncfusion_Maui_TreeGrid_SfTreeGrid_HeaderRowHeight).

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    // The header row index equals the number of stacked header rows (0 when there are none).
    if (e.RowIndex == treeGrid.StackedHeaderRows.Count)
    {
        e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Apply a custom height to specific rows

`QueryRowHeight` can also be used to set fixed heights for selected rows. Rows that are not handled keep the default `RowHeight`.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
private void TreeGrid_QueryRowHeight(object? sender, TreeGridQueryRowHeightEventArgs e)
{
    if (e.RowIndex == 3)
    {
        e.Height = 80;
        e.Handled = true;
    }
}
{% endhighlight %}
{% endtabs %}

## Get the content-based height outside the event

The `TreeGridHelper.GetRowHeight` extension method returns the same content-based height for a row index without needing event arguments.

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
using Syncfusion.Maui.TreeGrid;

double height = treeGrid.GetRowHeight(2);

// Optionally include hidden columns and exclude specific columns.
double customHeight = treeGrid.GetRowHeight(2, canIncludeHiddenColumns: false, excludedColumns: new List<string> { "Description" });
{% endhighlight %}
{% endtabs %}

## Refreshing the row heights

`QueryRowHeight` is raised for the visible rows when the TreeGrid loads, when you scroll, and when the row structure changes, such as expanding or collapsing a node or changing the source collection. To re-evaluate the heights after changing your own condition, such as toggling auto-fit at runtime, refresh the view:

{% tabs %}
{% highlight c# tabtitle="MainPage.xaml.cs" %}
treeGrid.View?.Refresh();
{% endhighlight %}
{% endtabs %}

## Behavior and usage notes

* The `QueryRowHeight` event is raised only when it has at least one subscriber. Without a handler, all rows use `RowHeight`.
* The event is raised for the header row, the stacked header rows and the data rows. Use `e.RowIndex` to restrict the logic. The header row index equals the number of stacked header rows, and data rows follow it.
* For text columns, the row height is calculated from the column that displays the longest text, measured against that column's actual width. For [template columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridTemplateColumn.html), the template content is measured, and the largest of the text and template heights is used.
* The cell padding of the column ([TreeGridColumn.CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_CellPadding)) and header padding ([TreeGridColumn.HeaderPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeGrid.TreeGridColumn.html#Syncfusion_Maui_TreeGrid_TreeGridColumn_HeaderPadding)) are part of the measured size.
* Rows inside collapsed nodes are not displayed, so their heights are not queried until the node is expanded.
* Setting `RowHeight` or `HeaderRowHeight` to a negative value throws an `ArgumentOutOfRangeException`.

## Limitations

* Auto-fit height is calculated on demand for the rows being displayed. The height of rows that are out of view is estimated until they are scrolled into view.
* Auto-fit is not applied if the `QueryRowHeight` event is not handled with `Handled` set to `true`.
* `GetIntrinsicRowHeight` measures the content of the rows using the current column widths. If column widths change, for example through column resizing, refresh the view to recalculate the heights.

## See Also

* [Styling](https://help.syncfusion.com/maui/treegrid/styling)
* [Column Sizing](https://help.syncfusion.com/maui/treegrid/column-sizing)
