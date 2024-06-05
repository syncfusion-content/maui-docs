---
layout: post
title: Performance in .NET MAUI DataGrid control | Syncfusion
description: Learn here all about Scrolling performance in Syncfusion .NET MAUI DataGrid (SfDataGrid) control and more.
platform: MAUI
control: SfDataGrid
documentation: UG
---

# Performance in MAUI DataGrid (SfDataGrid)

## LoadUIView

By default, the `UIElement` is loaded inside the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html). The `DataGridColumn.LoadUIView` property determines whether to load a `UIElement` inside the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) or to draw the cell value directly on the `canvas` of the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) on the Android platform.

If `LoadUIView` is set to `false`, the cell value of the column will be drawn directly on the `canvas` of the grid cells to enhance performance. However, when `LoadUIView` is set to `true`, a `UIElement` ([SfDataGridLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGridLabel.html)) will be loaded in the [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html).

The default value of `LoadUIView` is `True`.  The scrolling performance improved when `LoadUIView` was set to `False`.

{% highlight c# %}

DataGridTextColumn column = new DataGridTextColumn();
column.LoadUIView = false;
dataGrid.Columns.Add(column);

{% endhighlight %}

You can also download the entire source code of this from [GitHub](https://github.com/SyncfusionExamples/How-to-improve-scrolling-performance-in-.NET-MAUI-DataGrid).

### Limitations

* Implicit and explicit padding is not supported. [CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding) is applied to the left and right, but the top and bottom [CellPadding](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_CellPadding) of [DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html) are determined by the content.

* LineBreakMode is not supported.

* Accessibility does not work.

* Runtime theme switching is not supported.
