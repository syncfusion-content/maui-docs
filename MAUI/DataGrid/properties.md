---
layout: post
title: Properties of .NET MAUI Data Grid control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Data Grid (SfDataGrid) control.
platform: maui
control: SfDataGrid
documentation: ug
keywords: .net maui datagrid, .net maui sfdatagrid, syncfusion datagrid, datagrid maui, .net maui grid, .net grid maui.
---

# API Reference for .NET MAUI Data Grid

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
        <td>Lets users select a complete <code>column</code> by <code>tapping</code> or <code>double-tapping</code> its <code>header</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDeleting" aria-label="View AllowDeleting property in API reference">AllowDeleting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>delete</code> selected <code>rows</code> with the <code>Delete</code> key while navigating the DataGrid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDiagonalScrolling" aria-label="View AllowDiagonalScrolling property in API reference">AllowDiagonalScrolling</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users scroll <code>horizontally</code> and <code>vertically</code> in the same <code>gesture</code>; when disabled, each gesture scrolls along only one axis.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingColumn" aria-label="View AllowDraggingColumn property in API reference">AllowDraggingColumn</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>reorder columns</code> by dragging their <code>headers</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowDraggingRow" aria-label="View AllowDraggingRow property in API reference">AllowDraggingRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>reorder records</code> by dragging <code>rows</code> within the DataGrid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowEditing" aria-label="View AllowEditing property in API reference">AllowEditing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users edit <code>cell values</code> using the <code>gesture</code> configured by <code>EditTapAction</code>; individual columns must also permit editing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowGroupExpandCollapse" aria-label="View AllowGroupExpandCollapse property in API reference">AllowGroupExpandCollapse</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>expand</code> or <code>collapse</code> grouped records from the <code>group caption row</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowKeyboardNavigation" aria-label="View AllowKeyboardNavigation property in API reference">AllowKeyboardNavigation</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users move the <code>current cell</code> with the keyboard when <code>SelectionMode</code> is not <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowLoadMore" aria-label="View AllowLoadMore property in API reference">AllowLoadMore</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Displays a <code>load-more row</code> that invokes <code>LoadMoreCommand</code> so additional records can be appended on demand.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowPullToRefresh" aria-label="View AllowPullToRefresh property in API reference">AllowPullToRefresh</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>pull down</code> on the DataGrid to invoke its <code>refresh command</code> and display the <code>refresh indicator</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowResizingColumns" aria-label="View AllowResizingColumns property in API reference">AllowResizingColumns</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>resize</code> a <code>column</code> by dragging the <code>right edge</code> of its header.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowSwiping" aria-label="View AllowSwiping property in API reference">AllowSwiping</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Lets users <code>swipe rows</code> to reveal the content supplied by the <code>left</code> or <code>right swipe template</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowTriStateSorting" aria-label="View AllowTriStateSorting property in API reference">AllowTriStateSorting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Adds an <code>unsorted state</code> to the ascending and descending sort cycle, allowing users to remove a column's sort through the <code>sorting gesture</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AlternationRowCount" aria-label="View AlternationRowCount property in API reference">AlternationRowCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Controls how often the <code>alternate row style</code> repeats across record <code>rows</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoExpandGroups" aria-label="View AutoExpandGroups property in API reference">AutoExpandGroups</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows all <code>grouped records</code> <code>expanded</code> when <code>grouping</code> is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsMode" aria-label="View AutoGenerateColumnsMode property in API reference">AutoGenerateColumnsMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsMode.html" aria-label="View AutoGenerateColumnsMode enum in API reference">AutoGenerateColumnsMode</a></td>
        <td>Controls how automatically generated <code>columns</code> are updated when <code>ItemsSource</code> changes: <code>None</code>, <code>Reset</code>, <code>Retain</code>, or <code>SmartReset</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateColumnsModeForCustomType" aria-label="View AutoGenerateColumnsModeForCustomType property in API reference">AutoGenerateColumnsModeForCustomType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.AutoGenerateColumnsModeForCustomType.html" aria-label="View AutoGenerateColumnsModeForCustomType enum in API reference">AutoGenerateColumnsModeForCustomType</a></td>
        <td>Controls column generation for <code>complex properties</code>: <code>None</code> uses explicit columns, <code>Parent</code> generates the complex property, <code>Child</code> generates its inner properties, and <code>Both</code> generates both.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGenerateRelations" aria-label="View AutoGenerateRelations property in API reference">AutoGenerateRelations</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Creates <code>master-details relations</code> automatically from eligible properties in the bound data.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowPosition" aria-label="View AddNewRowPosition property in API reference">AddNewRowPosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridAddNewRowPosition.html" aria-label="View DataGridAddNewRowPosition enum in API reference">DataGridAddNewRowPosition</a></td>
        <td>Places the <code>add-new row</code> at <code>Top</code>, <code>FixedTop</code>, or <code>Bottom</code>; <code>FixedTop</code> keeps it above scrolling rows, while <code>None</code> hides it.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AddNewRowText" aria-label="View AddNewRowText property in API reference">AddNewRowText</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View string type in API reference">string</a></td>
        <td>Sets the <code>prompt</code> shown in the <code>add-new row</code> before the user starts entering a record.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowRowHoverHighlighting" aria-label="View AllowRowHoverHighlighting property in API reference">AllowRowHoverHighlighting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Highlights the <code>record row</code> under the <code>mouse pointer</code> using the configured <code>row-hover color</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanMaintainScrollPosition" aria-label="View CanMaintainScrollPosition property in API reference">CanMaintainScrollPosition</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Keeps the visible <code>scroll position</code> stable when records are added to or removed from the <code>data source</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CanUseViewFilter" aria-label="View CanUseViewFilter property in API reference">CanUseViewFilter</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Applies the <code>filter</code> configured on the DataGrid's <code>View</code> to determine which records remain visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnWidthMode" aria-label="View ColumnWidthMode property in API reference">ColumnWidthMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html" aria-label="View ColumnWidthMode enum in API reference">ColumnWidthMode</a></td>
        <td>Sizes columns using <code>None</code>, <code>Auto</code>, <code>Fill</code>, <code>FitByCell</code>, <code>FitByHeader</code>, or <code>LastColumnFill</code>, depending on whether widths should follow <code>content</code> or fill the available space.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentCell" aria-label="View CurrentCell property in API reference">CurrentCell</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.RowColumnIndex.html" aria-label="View RowColumnIndex type in API reference">RowColumnIndex</a></td>
        <td>Identifies the <code>row</code> and <code>column</code> indexes of the cell that currently has focus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentRow" aria-label="View CurrentRow property in API reference">CurrentRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Provides the <code>data record</code> associated with the <code>row</code> that currently has focus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DataFetchSize" aria-label="View DataFetchSize property in API reference">DataFetchSize</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Controls how many records are requested in each <code>on-demand loading</code> operation.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DefaultColumnWidth" aria-label="View DefaultColumnWidth property in API reference">DefaultColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Applies a common <code>width</code> to columns that do not specify their own width.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewDefaultStyle" aria-label="View DetailsViewDefaultStyle property in API reference">DetailsViewDefaultStyle</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html" aria-label="View DataGridStyle type in API reference">DataGridStyle</a></td>
        <td>Applies a shared <code>visual style</code> to nested <code>DataGrids</code> displayed in <code>details views</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DetailsViewPadding" aria-label="View DetailsViewPadding property in API reference">DetailsViewPadding</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
        <td>Controls the <code>spacing</code> around each nested <code>DataGrid</code> shown in a <code>details view</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EditTapAction" aria-label="View EditTapAction property in API reference">EditTapAction</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTapAction.html" aria-label="View DataGridTapAction enum in API reference">DataGridTapAction</a></td>
        <td>Starts <code>cell editing</code> with <code>OnTap</code> or <code>OnDoubleTap</code> when editing is enabled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Displays the supplied text, <code>view</code>, or other content when <code>ItemsSource</code> is null or contains no records.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
        <td>Defines a reusable custom layout for the <code>empty state</code> shown when no records are available.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_EnableDataVirtualization" aria-label="View EnableDataVirtualization property in API reference">EnableDataVirtualization</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Loads data in pages as rows come into view, reducing the amount of data held for large sources that support <code>virtualization</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ExpanderColumnWidth" aria-label="View ExpanderColumnWidth property in API reference">ExpanderColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls the <code>width</code> of the column containing the <code>details-view</code> expand and collapse icon.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenColumnCount" aria-label="View FrozenColumnCount property in API reference">FrozenColumnCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Keeps the specified number of columns <code>fixed</code> at the left while the remaining columns <code>scroll horizontally</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenRowCount" aria-label="View FrozenRowCount property in API reference">FrozenRowCount</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Keeps the specified number of rows <code>fixed</code> at the top while the remaining rows <code>scroll vertically</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GridLinesVisibility" aria-label="View GridLinesVisibility property in API reference">GridLinesVisibility</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GridLinesVisibility.html" aria-label="View GridLinesVisibility enum in API reference">GridLinesVisibility</a></td>
        <td>Shows <code>record-cell borders</code> using <code>Both</code>, <code>Horizontal</code>, <code>Vertical</code>, or <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_GroupingMode" aria-label="View GroupingMode property in API reference">GroupingMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GroupingMode.html" aria-label="View GroupingMode enum in API reference">GroupingMode</a></td>
        <td>Allows records to be <code>grouped</code> by one column with <code>Single</code> or by multiple columns with <code>Multiple</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderGridLinesVisibility" aria-label="View HeaderGridLinesVisibility property in API reference">HeaderGridLinesVisibility</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.GridLinesVisibility.html" aria-label="View GridLinesVisibility enum in API reference">GridLinesVisibility</a></td>
        <td>Shows <code>header-cell borders</code> using <code>Both</code>, <code>Horizontal</code>, <code>Vertical</code>, or <code>None</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HeaderRowHeight" aria-label="View HeaderRowHeight property in API reference">HeaderRowHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls the vertical <code>height</code> of the column-header <code>row</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_HorizontalScrollBarVisibility" aria-label="View HorizontalScrollBarVisibility property in API reference">HorizontalScrollBarVisibility</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.scrollbarvisibility" aria-label="View ScrollBarVisibility enum in API reference">ScrollBarVisibility</a></td>
        <td>Controls when the <code>horizontal scrollbar</code> is visible on <code>WinUI</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IndentColumnWidth" aria-label="View IndentColumnWidth property in API reference">IndentColumnWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls the horizontal <code>width</code> reserved for each grouping <code>indent level</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_IsBusy" aria-label="View IsBusy property in API reference">IsBusy</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows or hides the <code>busy state</code> used while a <code>load-more</code> operation is running.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Supplies the <code>records</code> displayed as rows; use a collection that reports collection and property changes when the grid must update automatically.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LoadMorePosition" aria-label="View LoadMorePosition property in API reference">LoadMorePosition</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLoadMorePosition.html" aria-label="View DataGridLoadMorePosition enum in API reference">DataGridLoadMorePosition</a></td>
        <td>Places the <code>load-more row</code> at the <code>Top</code> or <code>Bottom</code> of the DataGrid.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_LostFocusBehavior" aria-label="View LostFocusBehavior property in API reference">LostFocusBehavior</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridLostFocusBehavior.html" aria-label="View DataGridLostFocusBehavior enum in API reference">DataGridLostFocusBehavior</a></td>
        <td>Controls whether an active <code>edit</code> is kept, committed, or canceled when the DataGrid loses <code>focus</code>, using the documented <code>DataGridLostFocusBehavior</code> values.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_MaxSwipeOffset" aria-label="View MaxSwipeOffset property in API reference">MaxSwipeOffset</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Limits how far a <code>row</code> can move <code>horizontally</code> during a <code>swipe</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_NavigationMode" aria-label="View NavigationMode property in API reference">NavigationMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNavigationMode.html" aria-label="View DataGridNavigationMode enum in API reference">DataGridNavigationMode</a></td>
        <td>Uses <code>Cell</code> to move <code>focus</code> between individual cells or <code>Row</code> to navigate entire <code>rows</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ReuseRowsOnItemsSourceChange" aria-label="View ReuseRowsOnItemsSourceChange property in API reference">ReuseRowsOnItemsSourceChange</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Reuses existing <code>row containers</code> when <code>ItemsSource</code> is replaced, reducing the visual work required for frequent source changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeaderWidth" aria-label="View RowHeaderWidth property in API reference">RowHeaderWidth</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls the horizontal <code>width</code> of the <code>row-header column</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeight" aria-label="View RowHeight property in API reference">RowHeight</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
        <td>Controls the vertical <code>height</code> of record <code>rows</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
        <td>Selects the record at the specified zero-based <code>index</code> or identifies the selected record when row selection is active.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow" aria-label="View SelectedRow property in API reference">SelectedRow</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View object type in API reference">object</a></td>
        <td>Selects the specified <code>data record</code> or provides the record selected in single-selection scenarios.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows" aria-label="View SelectedRows property in API reference">SelectedRows</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ilist" aria-label="View IList type in API reference">IList</a></td>
        <td>Provides the <code>data records</code> currently selected when row selection allows one or more rows.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionMode.html" aria-label="View DataGridSelectionMode enum in API reference">DataGridSelectionMode</a></td>
        <td>Controls row or cell <code>selection</code> with <code>None</code>, <code>Single</code>, <code>SingleDeselect</code>, or <code>Multiple</code>; <code>SingleDeselect</code> lets the user clear the sole selection by selecting it again.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectionUnit" aria-label="View SelectionUnit property in API reference">SelectionUnit</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSelectionUnit.html" aria-label="View DataGridSelectionUnit enum in API reference">DataGridSelectionUnit</a></td>
        <td>Applies <code>selection</code> to complete records with <code>Row</code> or to individual cells with <code>Cell</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowColumnWhenGrouped" aria-label="View ShowColumnWhenGrouped property in API reference">ShowColumnWhenGrouped</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Keeps a <code>grouped column</code> visible in the DataGrid <code>body</code>; disabling it hides that column while <code>grouping</code> remains applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowDetailsViewIndentCell" aria-label="View ShowDetailsViewIndentCell property in API reference">ShowDetailsViewIndentCell</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows the <code>details-view</code> indent cell beside the <code>expander column</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowRowHeader" aria-label="View ShowRowHeader property in API reference">ShowRowHeader</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows the <code>row-header column</code> used for row interaction and resizing.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowSortNumbers" aria-label="View ShowSortNumbers property in API reference">ShowSortNumbers</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows each sorted column's <code>priority number</code> in its <code>header</code> when multiple-column sorting is active.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingGestureType" aria-label="View SortingGestureType property in API reference">SortingGestureType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingGestureType.html" aria-label="View DataGridSortingGestureType enum in API reference">DataGridSortingGestureType</a></td>
        <td>Applies <code>sorting</code> when the user performs the <code>Tap</code> or <code>DoubleTap</code> gesture on a column <code>header</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingMode" aria-label="View SortingMode property in API reference">SortingMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingMode.html" aria-label="View DataGridSortingMode enum in API reference">DataGridSortingMode</a></td>
        <td>Uses <code>Single</code> to sort by one column or <code>Multiple</code> to keep sort criteria for several columns.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SourceType" aria-label="View SourceType property in API reference">SourceType</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.type" aria-label="View Type type in API reference">Type</a></td>
        <td>Supplies the record <code>type</code> used to generate columns when the bound source has no records from which to infer a type.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowToolTip" aria-label="View ShowToolTip property in API reference">ShowToolTip</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
        <td>Shows the complete cell <code>value</code> in a <code>tooltip</code> when the displayed content is clipped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SwipeOffsetMode" aria-label="View SwipeOffsetMode property in API reference">SwipeOffsetMode</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeOffsetMode.html" aria-label="View DataGridSwipeOffsetMode enum in API reference">DataGridSwipeOffsetMode</a></td>
        <td>Uses <code>Auto</code> to size the <code>swipe view</code> from its template content or <code>Custom</code> to limit it with <code>MaxSwipeOffset</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_TransitionType" aria-label="View TransitionType property in API reference">TransitionType</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html" aria-label="View PullToRefreshTransitionType enum in API reference">PullToRefreshTransitionType</a></td>
        <td>Uses <code>Push</code> to place the <code>refresh indicator</code> over the DataGrid content or <code>SlideOnTop</code> to move it above the content as the user pulls.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_VerticalScrollBarVisibility" aria-label="View VerticalScrollBarVisibility property in API reference">VerticalScrollBarVisibility</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.scrollbarvisibility" aria-label="View ScrollBarVisibility enum in API reference">ScrollBarVisibility</a></td>
        <td>Controls when the <code>vertical scrollbar</code> is visible on <code>WinUI</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_View" aria-label="View View property in API reference">View</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ICollectionViewAdv.html" aria-label="View ICollectionViewAdv type in API reference">ICollectionViewAdv</a></td>
        <td>Provides the <code>collection view</code> through which the DataGrid applies sorting, grouping, and filtering to its records.</td>
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
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangedEventArgs.html" aria-label="View GroupExpandCollapseChangedEventArgs type in API reference">GroupExpandCollapseChangedEventArgs&gt;</a></a></td>
        <td>Triggered after a group is collapsed. This can be used to update <code>grouping</code> state or refresh related UI elements.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsing" aria-label="View GroupCollapsing event in API reference">GroupCollapsing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs&gt;</a></a></td>
        <td>Triggered before a group collapses. The pending action can be reviewed and canceled before the <code>collapse</code> is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanded" aria-label="View GroupExpanded event in API reference">GroupExpanded</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangedEventArgs.html" aria-label="View GroupExpandCollapseChangedEventArgs type in API reference">GroupExpandCollapseChangedEventArgs&gt;</a></a></td>
        <td>Triggered after a group is expanded. This is useful for syncing visibility state or loading content tied to the expanded <code>section</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanding" aria-label="View GroupExpanding event in API reference">GroupExpanding</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs&gt;</a></a></td>
        <td>Triggered before a group expands. This allows validation or cancellation before the child <code>items</code> become visible.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing" aria-label="View ItemAppearing event in API reference">ItemAppearing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html" aria-label="View ItemAppearingEventArgs type in API reference">ItemAppearingEventArgs&gt;</a></a></td>
        <td>Triggered when an item enters the visible viewport. This is useful for <code>lazy</code> loading, animation, or visibility tracking.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing" aria-label="View ItemDisappearing event in API reference">ItemDisappearing</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html" aria-label="View ItemDisappearingEventArgs type in API reference">ItemDisappearingEventArgs&gt;</a></a></td>
        <td>Triggered when an item leaves the visible viewport. This is useful for stopping <code>animations</code> or releasing temporary resources.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDragging" aria-label="View ItemDragging event in API reference">ItemDragging</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDraggingEventArgs.html" aria-label="View ItemDraggingEventArgs type in API reference">ItemDraggingEventArgs&gt;</a></a></td>
        <td>Triggered while an item is being dragged. This is useful for tracking drag progress and updating custom <code>feedback</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped" aria-label="View ItemDoubleTapped event in API reference">ItemDoubleTapped</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html" aria-label="View ItemDoubleTappedEventArgs type in API reference">ItemDoubleTappedEventArgs&gt;</a></a></td>
        <td>Triggered when an item is double tapped. This is useful for opening details or triggering an alternate <code>action</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress" aria-label="View ItemLongPress event in API reference">ItemLongPress</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html" aria-label="View ItemLongPressEventArgs type in API reference">ItemLongPressEventArgs&gt;</a></a></td>
        <td>Triggered when an item is long pressed. This is commonly used for context menus or secondary <code>commands</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemRightTapped" aria-label="View ItemRightTapped event in API reference">ItemRightTapped</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html" aria-label="View ItemRightTappedEventArgs type in API reference">ItemRightTappedEventArgs&gt;</a></a></td>
        <td>Triggered when an item is right tapped. This is useful for desktop-style <code>context</code> actions and menus.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs&gt;</a></a></td>
        <td>Triggered when an item is tapped. This is the primary interaction event for selection, navigation, or custom handling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded" aria-label="View Loaded event in API reference">Loaded</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadedEventArgs.html" aria-label="View ListViewLoadedEventArgs type in API reference">ListViewLoadedEventArgs&gt;</a></a></td>
        <td>Triggered after the list control has finished loading. This is a suitable point for final setup and post-load <code>customization</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize" aria-label="View QueryItemSize event in API reference">QueryItemSize</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.QueryItemSizeEventArgs.html" aria-label="View QueryItemSizeEventArgs type in API reference">QueryItemSizeEventArgs&gt;</a></a></td>
        <td>Triggered when the size of an item is being determined. This is useful for providing a custom <code>size</code> for specific content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollStateChanged" aria-label="View ScrollStateChanged event in API reference">ScrollStateChanged</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ScrollStateChangedEventArgs.html" aria-label="View ScrollStateChangedEventArgs type in API reference">ScrollStateChangedEventArgs&gt;</a></a></td>
        <td>Triggered when the scrolling state changes. This can be used to react to <code>idle</code>, <code>dragging</code>, or active scroll transitions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html" aria-label="View ItemSelectionChangedEventArgs type in API reference">ItemSelectionChangedEventArgs&gt;</a></a></td>
        <td>Triggered after the selection has changed. This is useful for updating related UI or running selection-based <code>logic</code>.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html" aria-label="View ItemSelectionChangingEventArgs type in API reference">ItemSelectionChangingEventArgs&gt;</a></a></td>
        <td>Triggered before the selection changes. This allows the pending selection to be reviewed or canceled before it is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeEnded" aria-label="View SwipeEnded event in API reference">SwipeEnded</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeEndedEventArgs.html" aria-label="View SwipeEndedEventArgs type in API reference">SwipeEndedEventArgs&gt;</a></a></td>
        <td>Triggered when a swipe interaction ends. This is useful for handling the final state after <code>swipe</code> actions complete.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeReset" aria-label="View SwipeReset event in API reference">SwipeReset</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ResetSwipeEventArgs.html" aria-label="View ResetSwipeEventArgs type in API reference">ResetSwipeEventArgs&gt;</a></a></td>
        <td>Triggered when a swipe item is reset to its default state. This is useful for restoring the item appearance after a <code>swipe</code> action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeStarting" aria-label="View SwipeStarting event in API reference">SwipeStarting</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeStartingEventArgs.html" aria-label="View SwipeStartingEventArgs type in API reference">SwipeStartingEventArgs&gt;</a></a></td>
        <td>Triggered before a swipe begins. This allows the gesture to be inspected before the swipe <code>UI</code> is shown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Swiping" aria-label="View Swiping event in API reference">Swiping</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipingEventArgs.html" aria-label="View SwipingEventArgs type in API reference">SwipingEventArgs&gt;</a></a></td>
        <td>Triggered continuously while a swipe is in progress. This is useful for updating thresholds, actions, or custom <code>gesture</code> feedback.</td>
    </tr>
</table>
