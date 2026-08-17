---
layout: post
title: Properties of .NET MAUI Data Grid control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Data Grid (SfDataGrid) control.
platform: maui
control: SfDataGrid
documentation: ug
keywords: .net maui datagrid, .net maui sfdatagrid, syncfusion datagrid, datagrid maui, .net maui grid, .net grid maui.
---

# .NET MAUI Data Grid API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowColumnSelection" aria-label="View AllowColumnSelection property in API reference">AllowColumnSelection</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables selection of an entire column when <code>true</code>. When enabled, tapping a column header selects every cell in that column.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDeleting" aria-label="View AllowDeleting property in API reference">AllowDeleting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables row deletion from the data grid. Set to <code>true</code> to allow the selected rows to be removed at runtime.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDiagonalScrolling" aria-label="View AllowDiagonalScrolling property in API reference">AllowDiagonalScrolling</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables diagonal scrolling, which allows moving content on both <code>horizontal</code> and <code>vertical</code> axes at the same time.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingColumn" aria-label="View AllowDraggingColumn property in API reference">AllowDraggingColumn</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables column reordering by dragging the column header to a new position.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingRow" aria-label="View AllowDraggingRow property in API reference">AllowDraggingRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables row reordering by dragging a row to a different index in the same grid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowEditing" aria-label="View AllowEditing property in API reference">AllowEditing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables inline editing of cell values. When <code>true</code>, cells become editable based on the <code>EditTapAction</code> setting.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowGroupExpandCollapse" aria-label="View AllowGroupExpandCollapse property in API reference">AllowGroupExpandCollapse</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables expand and collapse of grouped rows. When <code>true</code>, group captions can be tapped to show or hide the child rows.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowKeyboardNavigation" aria-label="View AllowKeyboardNavigation property in API reference">AllowKeyboardNavigation</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables navigation between cells using the keyboard. Arrow keys, <code>Tab</code>, and <code>Enter</code> are used to move the <code>current cell</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowLoadMore" aria-label="View AllowLoadMore property in API reference">AllowLoadMore</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables incremental data loading through a <code>LoadMore</code> button at runtime.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowPullToRefresh" aria-label="View AllowPullToRefresh property in API reference">AllowPullToRefresh</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables the pull-to-refresh gesture that triggers the <code>PullToRefreshing</code> and <code>PullToRefreshed</code> events.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowResizingColumns" aria-label="View AllowResizingColumns property in API reference">AllowResizingColumns</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables runtime resizing of columns by dragging the right edge of the column header.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowSwiping" aria-label="View AllowSwiping property in API reference">AllowSwiping</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables swipe gestures on rows to reveal action buttons. The maximum offset is controlled by the <code>MaxSwipeOffset</code> property.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowTriStateSorting" aria-label="View AllowTriStateSorting property in API reference">AllowTriStateSorting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables the unsorted state during sorting. Choose <code>SortedAscending</code>, <code>SortedDescending</code>, or <code>Unsorted</code> by cycling through the states.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AlternationRowCount" aria-label="View AlternationRowCount property in API reference">AlternationRowCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Defines how many rows are styled with the alternate <code>Background</code> color. Useful for improving row readability.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoExpandGroups" aria-label="View AutoExpandGroups property in API reference">AutoExpandGroups</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Expands all grouped rows automatically when the grid is loaded.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsMode" aria-label="View AutoGenerateColumnsMode property in API reference">AutoGenerateColumnsMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsMode.html" aria-label="View AutoGenerateColumnsMode enum in API reference">AutoGenerateColumnsMode</a></td>
        <td>Controls how columns are generated from the bound <code>ItemsSource</code>. Choose <code>None</code>, <code>Reset</code>, <code>Retain</code>, or <code>SmartReset</code> to define regeneration behavior.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsModeForCustomType" aria-label="View AutoGenerateColumnsModeForCustomType property in API reference">AutoGenerateColumnsModeForCustomType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsModeForCustomType.html" aria-label="View AutoGenerateColumnsModeForCustomType enum in API reference">AutoGenerateColumnsModeForCustomType</a></td>
        <td>Controls automatic column generation for custom <code>Type</code> properties. Choose <code>None</code>, <code>Display</code>, or <code>Both</code> to define the columns created.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations" aria-label="View AutoGenerateRelations property in API reference">AutoGenerateRelations</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Generates <code>DetailsView</code> relations automatically based on the master-detail structure of the bound data.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowPosition" aria-label="View AddNewRowPosition property in API reference">AddNewRowPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowPosition.html" aria-label="View DataGridAddNewRowPosition enum in API reference">DataGridAddNewRowPosition</a></td>
        <td>Defines the position of the <code>AddNewRow</code>. Choose <code>Top</code> or <code>Bottom</code> to place it at the first or last row.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowText" aria-label="View AddNewRowText property in API reference">AddNewRowText</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
        <td>Defines the placeholder text displayed inside the <code>AddNewRow</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowRowHoverHighlighting" aria-label="View AllowRowHoverHighlighting property in API reference">AllowRowHoverHighlighting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Highlights the row under the pointer on supported platforms to improve pointer-based interaction feedback.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanMaintainScrollPosition" aria-label="View CanMaintainScrollPosition property in API reference">CanMaintainScrollPosition</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Retains the current <code>scroll position</code> when the underlying data changes, for example during add or remove operations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanUseViewFilter" aria-label="View CanUseViewFilter property in API reference">CanUseViewFilter</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Allows the grid to apply a <code>View</code> filter to the bound data when supported by the underlying <code>ICollectionViewAdv</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnWidthMode" aria-label="View ColumnWidthMode property in API reference">ColumnWidthMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html" aria-label="View ColumnWidthMode enum in API reference">ColumnWidthMode</a></td>
        <td>Defines how the <code>column widths</code> are calculated. Choose <code>Auto</code>, <code>AutoLastColumnFill</code>, <code>AutoFill</code>, <code>FitByCell</code>, <code>FitByHeader</code>, or <code>Star</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCell" aria-label="View CurrentCell property in API reference">CurrentCell</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.RowColumnIndex.html" aria-label="View RowColumnIndex type in API reference">RowColumnIndex</a></td>
        <td>Represents the index of the cell that currently has focus. Useful for tracking the active <code>row</code> and <code>column</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentRow" aria-label="View CurrentRow property in API reference">CurrentRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Returns the underlying data object of the row that currently has focus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DataFetchSize" aria-label="View DataFetchSize property in API reference">DataFetchSize</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Defines the number of records fetched at a time during incremental loading. Larger values reduce load operations but use more memory.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultColumnWidth" aria-label="View DefaultColumnWidth property in API reference">DefaultColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the default width applied to columns that do not specify a custom width.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewDefaultStyle" aria-label="View DetailsViewDefaultStyle property in API reference">DetailsViewDefaultStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html" aria-label="View DataGridStyle type in API reference">DataGridStyle</a></td>
        <td>Defines the default <code>DataGridStyle</code> applied to nested <code>DetailsView</code> grids.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewPadding" aria-label="View DetailsViewPadding property in API reference">DetailsViewPadding</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
        <td>Defines the inner spacing around each <code>DetailsView</code> grid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EditTapAction" aria-label="View EditTapAction property in API reference">EditTapAction</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTapAction.html" aria-label="View DataGridTapAction enum in API reference">DataGridTapAction</a></td>
        <td>Defines the gesture that starts cell editing. Choose <code>OnTap</code> or <code>OnDoubleTap</code> based on the preferred interaction.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Defines the content displayed when the <code>ItemsSource</code> is null or empty.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
        <td>Defines a custom <code>DataTemplate</code> used to render the empty state when no records are available.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EnableDataVirtualization" aria-label="View EnableDataVirtualization property in API reference">EnableDataVirtualization</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables data virtualization so that only the visible rows are realized, improving performance for large data sources.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpanderColumnWidth" aria-label="View ExpanderColumnWidth property in API reference">ExpanderColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the width of the <code>ExpanderColumn</code> that contains the expand and collapse icon for the <code>DetailsView</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenColumnCount" aria-label="View FrozenColumnCount property in API reference">FrozenColumnCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Defines the number of columns that remain fixed on the left while the rest are scrolled horizontally.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenRowCount" aria-label="View FrozenRowCount property in API reference">FrozenRowCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Defines the number of rows that remain fixed on the top while the rest are scrolled vertically.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GridLinesVisibility" aria-label="View GridLinesVisibility property in API reference">GridLinesVisibility</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GridLinesVisibility.html" aria-label="View GridLinesVisibility enum in API reference">GridLinesVisibility</a></td>
        <td>Defines the visibility of the <code>grid lines</code>. Choose <code>Both</code>, <code>Horizontal</code>, <code>Vertical</code>, or <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupingMode" aria-label="View GroupingMode property in API reference">GroupingMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupingMode.html" aria-label="View GroupingMode enum in API reference">GroupingMode</a></td>
        <td>Defines whether grouping is applied to a single column or multiple columns. Choose <code>Single</code> or <code>Multiple</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderGridLinesVisibility" aria-label="View HeaderGridLinesVisibility property in API reference">HeaderGridLinesVisibility</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GridLinesVisibility.html" aria-label="View GridLinesVisibility enum in API reference">GridLinesVisibility</a></td>
        <td>Defines the visibility of <code>grid lines</code> within the header row. Choose <code>Both</code>, <code>Horizontal</code>, <code>Vertical</code>, or <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight" aria-label="View HeaderRowHeight property in API reference">HeaderRowHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the height of the <code>header row</code> that contains the column titles.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalScrollBarVisibility" aria-label="View HorizontalScrollBarVisibility property in API reference">HorizontalScrollBarVisibility</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.scrollbarvisibility" aria-label="View ScrollBarVisibility enum in API reference">ScrollBarVisibility</a></td>
        <td>Defines the visibility of the <code>horizontal scrollbar</code>. Choose <code>Default</code>, <code>Always</code>, <code>Never</code>, or <code>Auto</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IndentColumnWidth" aria-label="View IndentColumnWidth property in API reference">IndentColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the width of the <code>indent column</code> used to indicate the level of nested rows in grouped data.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy" aria-label="View IsBusy property in API reference">IsBusy</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Indicates whether the grid is currently performing a long-running operation such as data loading or sorting.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Defines the data source bound to the grid. Supports any collection that implements <code>IEnumerable</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMorePosition" aria-label="View LoadMorePosition property in API reference">LoadMorePosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMorePosition.html" aria-label="View DataGridLoadMorePosition enum in API reference">DataGridLoadMorePosition</a></td>
        <td>Defines the position of the <code>LoadMore</code> button. Choose <code>Top</code> or <code>Bottom</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LostFocusBehavior" aria-label="View LostFocusBehavior property in API reference">LostFocusBehavior</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLostFocusBehavior.html" aria-label="View DataGridLostFocusBehavior enum in API reference">DataGridLostFocusBehavior</a></td>
        <td>Defines how the <code>current cell</code> behaves when focus is lost. Choose <code>Default</code>, <code>EndEditing</code>, <code>CancelEditing</code>, or <code>MoveLast</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_MaxSwipeOffset" aria-label="View MaxSwipeOffset property in API reference">MaxSwipeOffset</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the maximum distance a row can be swiped before the action buttons are revealed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NavigationMode" aria-label="View NavigationMode property in API reference">NavigationMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNavigationMode.html" aria-label="View DataGridNavigationMode enum in API reference">DataGridNavigationMode</a></td>
        <td>Defines how the <code>current cell</code> moves during navigation. Choose <code>Cell</code>, <code>Row</code>, or <code>Line</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ReuseRowsOnItemsSourceChange" aria-label="View ReuseRowsOnItemsSourceChange property in API reference">ReuseRowsOnItemsSourceChange</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Reuses existing row containers when the <code>ItemsSource</code> is replaced, improving performance during data refreshes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeaderWidth" aria-label="View RowHeaderWidth property in API reference">RowHeaderWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the width of the <code>row header</code> column that displays the row index.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight" aria-label="View RowHeight property in API reference">RowHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Defines the height of each <code>row</code> in the data grid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Defines the index of the currently selected row when <code>SelectionMode</code> is <code>Single</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow" aria-label="View SelectedRow property in API reference">SelectedRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Returns the underlying data object of the currently selected row.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows" aria-label="View SelectedRows property in API reference">SelectedRows</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ilist" aria-label="View IList type in API reference">IList</a></td>
        <td>Returns the collection of selected row data objects. The selection count is controlled by the <code>SelectionMode</code> property.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionMode.html" aria-label="View DataGridSelectionMode enum in API reference">DataGridSelectionMode</a></td>
        <td>Defines the selection mode. Choose <code>Single</code>, <code>Multiple</code>, <code>SingleDeselect</code>, or <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionUnit" aria-label="View SelectionUnit property in API reference">SelectionUnit</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionUnit.html" aria-label="View DataGridSelectionUnit enum in API reference">DataGridSelectionUnit</a></td>
        <td>Defines the unit of selection. Choose <code>Row</code> or <code>Cell</code> to control whether rows or individual cells are selected.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowColumnWhenGrouped" aria-label="View ShowColumnWhenGrouped property in API reference">ShowColumnWhenGrouped</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Keeps the grouped column visible inside the group caption. When <code>false</code>, the grouped column is hidden from the body.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowDetailsViewIndentCell" aria-label="View ShowDetailsViewIndentCell property in API reference">ShowDetailsViewIndentCell</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Displays an extra indent cell next to the expander column for the <code>DetailsView</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowRowHeader" aria-label="View ShowRowHeader property in API reference">ShowRowHeader</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Displays the <code>row header</code> column that contains the row index and selection indicator.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowSortNumbers" aria-label="View ShowSortNumbers property in API reference">ShowSortNumbers</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Displays a number badge next to the column header that indicates the sort priority of the column.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingGestureType" aria-label="View SortingGestureType property in API reference">SortingGestureType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingGestureType.html" aria-label="View DataGridSortingGestureType enum in API reference">DataGridSortingGestureType</a></td>
        <td>Defines the gesture used to sort a column. Choose <code>Tap</code> or <code>DoubleTap</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingMode" aria-label="View SortingMode property in API reference">SortingMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingMode.html" aria-label="View DataGridSortingMode enum in API reference">DataGridSortingMode</a></td>
        <td>Defines how sorting is performed. Choose <code>Single</code> or <code>Multiple</code> to allow sorting by one or more columns.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SourceType" aria-label="View SourceType property in API reference">SourceType</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.type" aria-label="View Type type in API reference">Type</a></td>
        <td>Defines the <code>Type</code> used for column auto-generation. Set this to a specific type when the bound collection is empty.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowToolTip" aria-label="View ShowToolTip property in API reference">ShowToolTip</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Enables tooltips for cells whose content is clipped due to column width.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeOffsetMode" aria-label="View SwipeOffsetMode property in API reference">SwipeOffsetMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeOffsetMode.html" aria-label="View DataGridSwipeOffsetMode enum in API reference">DataGridSwipeOffsetMode</a></td>
        <td>Defines whether the swipe offset is calculated based on the <code>row</code> or the <code>view</code> when a row is swiped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TransitionType" aria-label="View TransitionType property in API reference">TransitionType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html" aria-label="View PullToRefreshTransitionType enum in API reference">PullToRefreshTransitionType</a></td>
        <td>Defines the animation used for the <code>pull-to-refresh</code> indicator. Choose <code>PushDown</code>, <code>SlideOnTop</code>, or <code>Scale</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalScrollBarVisibility" aria-label="View VerticalScrollBarVisibility property in API reference">VerticalScrollBarVisibility</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.scrollbarvisibility" aria-label="View ScrollBarVisibility enum in API reference">ScrollBarVisibility</a></td>
        <td>Defines the visibility of the <code>vertical scrollbar</code>. Choose <code>Default</code>, <code>Always</code>, <code>Never</code>, or <code>Auto</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_View" aria-label="View View property in API reference">View</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ICollectionViewAdv.html" aria-label="View ICollectionViewAdv type in API reference">ICollectionViewAdv</a></td>
        <td>Defines the underlying <code>ICollectionViewAdv</code> that the grid uses for sorting, filtering, and grouping.</td>
    </tr>
</table>

## Methods

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseAll" aria-label="View CollapseAll method in API reference">CollapseAll()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Collapses every grouped section in the list. This is useful for resetting the view to a compact <code>grouped</code> state in a single operation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseGroup_Syncfusion_Maui_DataSource_Extensions_GroupResult_" aria-label="View CollapseGroup method in API reference">CollapseGroup(GroupResult)</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.Extensions.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
        <td>Collapses the specified group represented by <code>GroupResult</code>. The items remain in the data source, but their visible <code>child</code> content is hidden.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandAll" aria-label="View ExpandAll method in API reference">ExpandAll()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Expands every collapsed group in the list. This makes the full <code>hierarchy</code> visible without changing the underlying data.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandGroup_Syncfusion_Maui_DataSource_Extensions_GroupResult_" aria-label="View ExpandGroup method in API reference">ExpandGroup(GroupResult)</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.Extensions.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
        <td>Expands the specified group represented by <code>GroupResult</code>. The group becomes visible again, along with its nested <code>items</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshItem_System_Int32_System_Int32_System_Boolean_" aria-label="View RefreshItem method in API reference">RefreshItem(Int32, Int32, Boolean)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Refreshes the specified item range in the list. This is useful when the visible <code>item</code> content must be updated after data changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView" aria-label="View RefreshView method in API reference">RefreshView()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Refreshes the entire list view. This forces the control to re-evaluate its <code>layout</code>, templates, and visible item state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ResetSwipeItem_System_Boolean_" aria-label="View ResetSwipeItem method in API reference">ResetSwipeItem(Boolean)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Resets the currently swiped item back to its default position. The <code>Boolean</code> value controls whether the reset is <code>animated</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_" aria-label="View ScrollTo(double, bool) method in API reference">ScrollTo(Double, Boolean)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Scrolls to the specified <code>offset</code> position in the list. The <code>Boolean</code> value controls whether the movement is <code>animated</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Object_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_" aria-label="View ScrollTo(object, ScrollToPosition, bool) method in API reference">ScrollTo(Object, ScrollToPosition, Boolean)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Scrolls the list so the specified <code>item</code> becomes visible. The <code>ScrollToPosition</code> enum controls placement such as <code>Start</code>, <code>Center</code>, <code>End</code>, or <code>MakeVisible</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectAll" aria-label="View SelectAll method in API reference">SelectAll()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Selects every available item in the list. This is useful when <code>multi-selection</code> is enabled and bulk actions are required.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeItem_System_Object_System_Double_" aria-label="View SwipeItem method in API reference">SwipeItem(Object, Double)</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
        <td>Swipes the specified item by the given <code>offset</code>. This is useful for opening swipe actions or synchronizing <code>gesture</code> behavior.</td>
    </tr>
</table>

## Events

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsed" aria-label="View GroupCollapsed event in API reference">GroupCollapsed</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangedEventArgs.html" aria-label="View GroupExpandCollapseChangedEventArgs type in API reference">GroupExpandCollapseChangedEventArgs</a></td>
        <td>Raised after a group is collapsed. This can be used to update <code>grouping</code> state or refresh related UI elements.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsing" aria-label="View GroupCollapsing event in API reference">GroupCollapsing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs</a></td>
        <td>Raised before a group collapses. The pending action can be reviewed and canceled before the <code>collapse</code> is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanded" aria-label="View GroupExpanded event in API reference">GroupExpanded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangedEventArgs.html" aria-label="View GroupExpandCollapseChangedEventArgs type in API reference">GroupExpandCollapseChangedEventArgs</a></td>
        <td>Raised after a group is expanded. This is useful for syncing visibility state or loading content tied to the expanded <code>section</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanding" aria-label="View GroupExpanding event in API reference">GroupExpanding</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs</a></td>
        <td>Raised before a group expands. This allows validation or cancellation before the child <code>items</code> become visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing" aria-label="View ItemAppearing event in API reference">ItemAppearing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html" aria-label="View ItemAppearingEventArgs type in API reference">ItemAppearingEventArgs</a></td>
        <td>Raised when an item enters the visible viewport. This is useful for <code>lazy</code> loading, animation, or visibility tracking.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing" aria-label="View ItemDisappearing event in API reference">ItemDisappearing</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html" aria-label="View ItemDisappearingEventArgs type in API reference">ItemDisappearingEventArgs</a></td>
        <td>Raised when an item leaves the visible viewport. This is useful for stopping <code>animations</code> or releasing temporary resources.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDragging" aria-label="View ItemDragging event in API reference">ItemDragging</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDraggingEventArgs.html" aria-label="View ItemDraggingEventArgs type in API reference">ItemDraggingEventArgs</a></td>
        <td>Raised while an item is being dragged. This is useful for tracking drag progress and updating custom <code>feedback</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped" aria-label="View ItemDoubleTapped event in API reference">ItemDoubleTapped</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html" aria-label="View ItemDoubleTappedEventArgs type in API reference">ItemDoubleTappedEventArgs</a></td>
        <td>Raised when an item is double tapped. This is useful for opening details or triggering an alternate <code>action</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress" aria-label="View ItemLongPress event in API reference">ItemLongPress</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html" aria-label="View ItemLongPressEventArgs type in API reference">ItemLongPressEventArgs</a></td>
        <td>Raised when an item is long pressed. This is commonly used for context menus or secondary <code>commands</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemRightTapped" aria-label="View ItemRightTapped event in API reference">ItemRightTapped</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html" aria-label="View ItemRightTappedEventArgs type in API reference">ItemRightTappedEventArgs</a></td>
        <td>Raised when an item is right tapped. This is useful for desktop-style <code>context</code> actions and menus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs</a></td>
        <td>Raised when an item is tapped. This is the primary interaction event for selection, navigation, or custom handling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded" aria-label="View Loaded event in API reference">Loaded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadedEventArgs.html" aria-label="View ListViewLoadedEventArgs type in API reference">ListViewLoadedEventArgs</a></td>
        <td>Raised after the list control has finished loading. This is a suitable point for final setup and post-load <code>customization</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize" aria-label="View QueryItemSize event in API reference">QueryItemSize</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.QueryItemSizeEventArgs.html" aria-label="View QueryItemSizeEventArgs type in API reference">QueryItemSizeEventArgs</a></td>
        <td>Raised when the size of an item is being determined. This is useful for providing a custom <code>size</code> for specific content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollStateChanged" aria-label="View ScrollStateChanged event in API reference">ScrollStateChanged</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ScrollStateChangedEventArgs.html" aria-label="View ScrollStateChangedEventArgs type in API reference">ScrollStateChangedEventArgs</a></td>
        <td>Raised when the scrolling state changes. This can be used to react to <code>idle</code>, <code>dragging</code>, or active scroll transitions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html" aria-label="View ItemSelectionChangedEventArgs type in API reference">ItemSelectionChangedEventArgs</a></td>
        <td>Raised after the selection has changed. This is useful for updating related UI or running selection-based <code>logic</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html" aria-label="View ItemSelectionChangingEventArgs type in API reference">ItemSelectionChangingEventArgs</a></td>
        <td>Raised before the selection changes. This allows the pending selection to be reviewed or canceled before it is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeEnded" aria-label="View SwipeEnded event in API reference">SwipeEnded</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeEndedEventArgs.html" aria-label="View SwipeEndedEventArgs type in API reference">SwipeEndedEventArgs</a></td>
        <td>Raised when a swipe interaction ends. This is useful for handling the final state after <code>swipe</code> actions complete.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeReset" aria-label="View SwipeReset event in API reference">SwipeReset</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ResetSwipeEventArgs.html" aria-label="View ResetSwipeEventArgs type in API reference">ResetSwipeEventArgs</a></td>
        <td>Raised when a swipe item is reset to its default state. This is useful for restoring the item appearance after a <code>swipe</code> action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeStarting" aria-label="View SwipeStarting event in API reference">SwipeStarting</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeStartingEventArgs.html" aria-label="View SwipeStartingEventArgs type in API reference">SwipeStartingEventArgs</a></td>
        <td>Raised before a swipe begins. This allows the gesture to be inspected before the swipe <code>UI</code> is shown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Swiping" aria-label="View Swiping event in API reference">Swiping</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipingEventArgs.html" aria-label="View SwipingEventArgs type in API reference">SwipingEventArgs</a></td>
        <td>Raised continuously while a swipe is in progress. This is useful for updating thresholds, actions, or custom <code>gesture</code> feedback.</td>
    </tr>
</table>
