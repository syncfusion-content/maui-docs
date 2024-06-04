---
layout: post
title: Performance in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling p in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Performance in MAUI DataGrid (SfDataGrid)

## LoadUIView

The `GridColumn.LoadUIView` property determines whether to load a `UIElement` inside the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) or to draw the cell value directly on the `canvas` of the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) on the Android platform.

If `LoadUIView` is set to `false`, the cell value of the column will be drawn directly on the `canvas` of the grid cells to enhance performance. However, when `LoadUIView` is set to `true`, a `UIElement` ([SfDataGridLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGridLabel.html)) will be loaded in the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html).

The default value of `LoadUIView` is `True` for Android and `false` for other platforms in Maui.

{% highlight c# %}

DataGridTextColumn column = new DataGridTextColumn();
column.LoadUIView = false;
dataGrid.Columns.Add(column);

{% endhighlight %}

### Limitations

* The Top and Bottom [CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding) of [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) is not supported when `LoadUiView` is set to `False`.