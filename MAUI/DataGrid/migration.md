---
layout: post
title: Migrate from Xamarin SfDataGrid to .NET MAUI SfDataGrid | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin SfDataGrid to Syncfusion .NET MAUI SfDataGrid control and more.
platform: MAUI
control: SfDataGrid
documentation: ug
keywords : maui datagrid, maui grid, grid maui, maui gridview, grid in maui, .net maui datagrid, .net maui grid, .net grid maui
--- 

# Migrate from Xamarin.Forms SfDataGrid to .NET MAUI SfDataGrid

To make migration from [Xamarin SfDataGrid](https://www.syncfusion.com/xamarin-ui-controls/xamarin-datagrid) to [.NET MAUI SfDataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) easier, we kept most of the APIs from Xamarin SfDataGrid in MAUI SfDataGrid. However, to maintain the consistency of API naming in MAUI SfDataGrid, we renamed some of the APIs. The APIs that have been changed in MAUI SfDataGrid from Xamarin SfDataGrid are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th></tr>
<tr>
<td>Syncfusion.SfDataGrid.XForms</td>
<td>Syncfusion.Maui.DataGrid</td></tr>
<tr>
<td>Syncfusion.Data</td>
<td>Syncfusion.Maui.Data</td></tr>
<tr>
<td>Syncfusion.SfDataGrid.XForms.DataPager</td>
<td>Syncfusion.Maui.DataGrid.DataPager</td></tr>
</table>

## Enums

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th>
<th>Description</th></tr>
<tr>
<td>{{'[ColumnSizer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.ColumnSizer.html)'| markdownify }}</td>
<td>{{'[ColumnWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html)'| markdownify }}</td>
<td>Defines constants that specify how the columns in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} are sized.</td></tr>
<tr>
<td>{{'[SortTapAction](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SortTapAction.html)'| markdownify }}</td>
<td>{{'[DataGridSortingGestureType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingGestureType.html)'| markdownify }}</td>
<td>Defines the constants that specifies how the sorting is applied.</td>
</tr>
<tr>
<td>{{'[Position](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridTableSummaryRow.html#Syncfusion_SfDataGrid_XForms_GridTableSummaryRow_PositionProperty)'| markdownify }}</td>
<td>{{'[SummaryRowPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SummaryRowPosition.html)'| markdownify }}</td>
<td>Defines the constants that specify whether the table summary row is positioned at the top or bottom of the DataGrid.</td>
</tr>
<tr>
<td>{{'[AutoEllipsisMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AutoEllipsisMode.html)'| markdownify }}</td>
<td>{{'[DataPagerEllipsisMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerEllipsisMode.html)'| markdownify }}</td>
<td>Defines the constants that describes the possible ellipsis modes for the NumericButton.</td>
</tr>
<tr>
<td>{{'[ButtonShape](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.ButtonShape.html)'| markdownify }}</td>
<td>{{'[DataPagerButtonShape](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerButtonShape.html)'| markdownify }}</td>
<td>Defines the constant that specify the shape of the buttons in the data pager.</td>
</tr>
<tr>
<td>{{'[NumericButtonsGenerateMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.NumericButtonsGenerateMode.html)'| markdownify }}</td>
<td>{{'[DataPagerNumericButtonsGenerateMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerNumericButtonsGenerateMode.html)'| markdownify }}</td>
<td>Defines the constants that specify whether the numeric buttons should be generated automatically based on parent size or manually using the specified NumericButtonCount value.</td>
</tr>
<tr>
<td>{{'[PagerDisplayMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.PagerDisplayMode.html)'| markdownify }}</td>
<td>{{'[DataPagerDisplayMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerDisplayMode.html)'| markdownify }}</td>
<td>Defines the possible display mode of SfDataPager.</td>
</tr>
<tr>
<td>{{'[ProgressStates](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.ProgressStates.html)'| markdownify }}</td>
<td>{{'[DataGridProgressState](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridProgressState.html)'| markdownify }}</td>
<td>Defines constants that specify the possible progressing states of resizing operation.</td>
</tr>
<tr>
<td>{{'[QueryColumnDraggingReason](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.QueryColumnDraggingReason.html)'| markdownify }}</td>
<td>{{'[DataGridDragAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDragAction.html)'| markdownify }}</td>
<td>Defines constants that specify the possible progressing states of resizing operation.</td>
</tr>
<tr>
<td>{{'[SelectionUnit](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SelectionUnit.html)'| markdownify }}</td>
<td>{{'[DataGridSelectionUnit]()'| markdownify }}</td>
<td>Defines the constants that specifies how the selection is applied.</td>
</tr>
<tr>
<td>{{'[SwipeOffsetMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SwipeOffsetMode.html)'| markdownify }}</td>
<td>{{'[DataGridSwipeOffsetMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeOffsetMode.html)'| markdownify }}</td>
<td>Defines constants that specifies whether the swipe view content should be auto sized or not.</td>
</tr>
<tr>
<td>{{'[SwipeDirection](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SwipeDirection.html)'| markdownify }}</td>
<td>{{'[DataGridSwipeDirection](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeDirection.html)'| markdownify }}</td>
<td>Defines constants that specify the swipe directions.</td>
</tr>
</table>

## Properties

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th>
<th>Description</th></tr>
<tr>
<td>{{'[AutoGenerateColumns](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_AutoGenerateColumns)'| markdownify }}</td>
<td>{{'[AutoGenerateColumnsMode.None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.ColumnWidthMode.html)'| markdownify }}</td>
<td>Defines constants that specify how the columns in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} are sized.</td></tr>
<tr>
<td>{{'[AllowSorting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_AllowSorting)'| markdownify }}</td>
<td>{{'[SortingMode.Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingMode.html#Syncfusion_Maui_DataGrid_DataGridSortingMode_Single)'| markdownify }}</td>
<td>Specifies that the single column alone can be sorted at a time.</td>
</tr>
<tr>
<td>{{'[AllowMultiSorting](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_AllowMultiSorting)'| markdownify }}</td>
<td>{{'[SortingMode.Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSortingMode.html#Syncfusion_Maui_DataGrid_DataGridSortingMode_Multiple)'| markdownify }}</td>
<td>Specifies that the multiple columns can be sorted.</td>
</tr>
<tr>
<td>{{'[SortTapAction](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SortTapAction.html)'| markdownify }}</td>
<td>{{'[SortingGestureType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SortingGestureType)'| markdownify }}</td>
<td>Defines the constants that specifies how the sorting is applied.</td>
</tr>
<tr>
<td>{{'[IsHidden](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html#Syncfusion_SfDataGrid_XForms_GridColumn_IsHidden)'| markdownify }}</td>
<td>{{'[Visible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html#Syncfusion_Maui_DataGrid_DataGridColumn_Visible)'| markdownify }}</td>
<td>Gets or sets a value indicating whether a column should be visible.</td>
</tr>
<tr>
<td>{{'[SelectedItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_SelectedItem)'| markdownify }}</td>
<td>{{'[SelectedRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRow)'| markdownify }}</td>
<td>Gets or sets a row which is currently selected.</td>
</tr>
<tr>
<td>{{'[SelectedItems](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_SelectedItems)'| markdownify }}</td>
<td>{{'[SelectedRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_SelectedRows)'| markdownify }}</td>
<td>Gets or sets the collection of rows which are all selected.</td>
</tr>
<tr>
<td>{{'[CurrentItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_CurrentItem)'| markdownify }}</td>
<td>{{'[CurrentRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CurrentRow)'| markdownify }}</td>
<td>Gets or sets a row which is currently navigated.</td>
</tr>
<tr>
<td>{{'[HeaderBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_HeaderBackgroundColor)'| markdownify }}</td>
<td>{{'[HeaderRowBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_HeaderRowBackground)'| markdownify }}</td>
<td>Gets or sets the background for the header row.</td>
</tr>
<tr>
<td>{{'[RowBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_RowBackgroundColor)'| markdownify }}</td>
<td>{{'[RowBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_RowBackground)'| markdownify }}</td>
<td>Gets or sets the background of the data rows.</td>
</tr>
<tr>
<td>{{'[RowForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_RowForegroundColor)'| markdownify }}</td>
<td>{{'[RowTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_RowTextColor)'| markdownify }}</td>
<td>Gets or sets the text color of the data row.</td>
</tr>
<tr>
<td>{{'[HeaderForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_HeaderForegroundColor)'| markdownify }}</td>
<td>{{'[HeaderRowTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_HeaderRowTextColor)'| markdownify }}</td>
<td>Gets or sets the text color of the header row.</td>
</tr>
<tr>
<td>{{'[GridCellBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_GridCellBorderColor)'| markdownify }}</td>
<td>{{'[GridLineColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GridLineColor)'| markdownify }}</td>
<td>Gets or sets the color for the grid lines.</td>
</tr>
<tr>
<td>{{'[GridCellBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_GridCellBorderWidth)'| markdownify }}</td>
<td>{{'[GridLineStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_GridLineStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke thickness of the grid lines.</td>
</tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_SelectionBackgroundColor)'| markdownify }}</td>
<td>{{'[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SelectionBackground)'| markdownify }}</td>
<td>Gets or sets the background of the selected rows.</td>
</tr>
<tr>
<td>{{'[SelectionForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_SelectionForegroundColor)'| markdownify }}</td>
<td>{{'[SelectedRowTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_SelectedRowTextColor)'| markdownify }}</td>
<td>Gets or sets the text color of the selected rows.</td>
</tr>
<tr>
<td>{{'[ColumnSizer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnSizer)'| markdownify }}</td>
<td>{{'[ColumnWidthMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ColumnWidthMode)'| markdownify }}</td>
<td>Gets or sets the value that indicates how all the columns widths are determined.</td>
</tr>
<tr>
<td>{{'[FontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html#Syncfusion_SfDataGrid_XForms_GridColumn_FontAttribute)'| markdownify }}</td>
<td>{{'[DataGridCell.FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html#Syncfusion_Maui_DataGrid_DataGridCell_FontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes.</td>
</tr>
<tr>
<td>{{'[HeaderFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html#Syncfusion_SfDataGrid_XForms_GridColumn_HeaderFont)'| markdownify }}</td>
<td>{{'[DataGridHeaderCell.FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html#Syncfusion_Maui_DataGrid_DataGridCell_FontFamily)'| markdownify }}</td>
<td>Gets or sets the font family.</td>
</tr>
<tr>
<td>{{'[HeaderFontAttribute](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html#Syncfusion_SfDataGrid_XForms_GridColumn_HeaderFontAttribute)'| markdownify }}</td>
<td>{{'[DataGridHeaderCell.FontAttributes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html#Syncfusion_Maui_DataGrid_DataGridCell_FontAttributes)'| markdownify }}</td>
<td>Gets or sets the font attributes.</td>
</tr>
<tr>
<td>{{'[RecordFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html#Syncfusion_SfDataGrid_XForms_GridColumn_RecordFont)'| markdownify }}</td>
<td>{{'[DataGridCell.FontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html#Syncfusion_Maui_DataGrid_DataGridCell_FontFamily)'| markdownify }}</td>
<td>Gets or sets the font family.</td>
</tr>
<tr>
<td>{{'[FrozenRowsCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_FrozenRowsCount)'| markdownify }}</td>
<td>{{'[FrozenRowCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenRowCount)'| markdownify }}</td>
<td>The number of non-scrolling rows at the top of SfDataGrid.</td>
</tr>
<tr>
<td>{{'[FrozenColumnsCount](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_FrozenColumnsCount)'| markdownify }}</td>
<td>{{'[FrozenColumnCount](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_FrozenColumnCount)'| markdownify }}</td>
<td>The number of non-scrolling columns at the left side of SfDataGrid.</td>
</tr>
<tr>
<td>{{'[AppearanceManager](https://help.syncfusion.com/xamarin/sfdatagrid/paging#appearancemanager)'| markdownify }}</td>
<td>{{'[DefaultStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_DefaultStyle)'| markdownify }}</td>
<td>This enables users to customize the appearance of the data pager.</td>
</tr>
<tr>
<td>{{'[GetNumericButtonSelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html#Syncfusion_SfDataGrid_XForms_DataPager_AppearanceManager_GetNumericButtonSelectionBackgroundColor)'| markdownify }}</td>
<td>{{'[NumericButtonSelectionBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataGrid_DataPager_DataPagerStyle_NumericButtonSelectionBackgroundColor)'| markdownify }}</td>
<td>This enables users to customize the selection background color for numeric button.</td>
</tr>
<tr>
<td>{{'[GetDataPagerBackgroundColor()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html#Syncfusion_SfDataGrid_XForms_DataPager_AppearanceManager_GetDataPagerBackgroundColor)'| markdownify }}</td>
<td>{{'[DataPagerBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataGrid_DataPager_DataPagerStyle_DataPagerBackgroundColor)'| markdownify }}</td>
<td>This enables users to customize the background color of the SfDataPager.</td>
</tr>
<tr>
<td>{{'[GetNavigationButtonIconColor()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html#Syncfusion_SfDataGrid_XForms_DataPager_AppearanceManager_GetNavigationButtonIconColor)'| markdownify }}</td>
<td>{{'[NavigationButtonIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataGrid_DataPager_DataPagerStyle_NavigationButtonIconColor)'| markdownify }}</td>
<td>This enables users to customize the icon color of the navigation buttons.</td>
</tr>
<tr>
<td>{{'[GetNumericButtonForegroundColor()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html#Syncfusion_SfDataGrid_XForms_DataPager_AppearanceManager_GetNumericButtonForegroundColor)'| markdownify }}</td>
<td>{{'[NumericButtonTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataGrid_DataPager_DataPagerStyle_NumericButtonTextColor)'| markdownify }}</td>
<td>This enables users to customize the text color of the numeric values in the navigation buttons.</td>
</tr>
<tr>
<td>{{'[GetNumericButtonSelectionForegroundColor()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html#Syncfusion_SfDataGrid_XForms_DataPager_AppearanceManager_GetNumericButtonSelectionForegroundColor)'| markdownify }}</td>
<td>{{'[NumericButtonSelectionTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html#Syncfusion_Maui_DataGrid_DataPager_DataPagerStyle_NumericButtonSelectionTextColor)'| markdownify }}</td>
<td>This enables users to customize the text color of the currently selected numeric button in the view.</td>
</tr>
<tr>
<td>{{'[EnableGridPaging()](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.SfDataPager.html#Syncfusion_SfDataGrid_XForms_DataPager_SfDataPager_EnableGridPaging)'| markdownify }}</td>
<td>-</td>
<td>This property isn't available because the [UseOnDemandPaging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_UseOnDemandPaging) property alone is sufficient to enable on-demand paging in the MAUI DataGrid.</td>
</tr>
<tr>
<td>{{'[AllowResizingColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_AllowResizingColumn)'| markdownify }}</td>
<td>{{'[AllowResizingColumns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AllowResizingColumnProperty)'| markdownify }}</td>
<td>This enables users to resize the columns by tapping and dragging the right border of the column headers. 
</td>
</tr>
<tr>
<td>{{'[Reason](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.QueryRowDraggingEventArgs.html#Syncfusion_SfDataGrid_XForms_QueryRowDraggingEventArgs_Reason)'| markdownify }}</td>
<td>{{'[DraggingAction](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryColumnDraggingEventArgs_DraggingAction)'| markdownify }}</td>
<td>This enables users to get the column dragging details as a `DataGridDragAction`. 
</td>
</tr>
<tr>
<td>{{'[ColumnDragViewForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataGridStyle.html#Syncfusion_SfDataGrid_XForms_DataGridStyle_ColumnDragViewForegroundColor)'| markdownify }}</td>
<td>{{'[ColumnDragViewTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStyle.html#Syncfusion_Maui_DataGrid_DataGridStyle_ColumnDragViewTextColor)'| markdownify }}</td>
<td>This enables users to change the color of the column drag view text color. 
</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[GridTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridTapped)'| markdownify }}</td>
<td>{{'[CellTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTapped)'| markdownify }}</td>
<td>Occurs when the cell is tapped.</td>
</tr>
<tr>
<td>{{'[GridTappedCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridTappedCommand)'| markdownify }}</td>
<td>{{'[CellTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellTappedCommand)'| markdownify }}</td>
<td>Occurs when the cell is tapped.</td>
</tr>
<tr>
<td>{{'[GridDoubleTapped](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridDoubleTapped)'| markdownify }}</td>
<td>{{'[CellDoubleTapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellDoubleTapped)'| markdownify }}</td>
<td>Occurs when the cell is tapped twice.</td>
</tr>
<tr>
<td>{{'[GridDoubleTappedCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridDoubleTappedCommand)'| markdownify }}</td>
<td>{{'[CellDoubleTappedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellDoubleTappedCommand)'| markdownify }}</td>
<td>Occurs when the cell is tapped twice.</td>
</tr>
<tr>
<td>{{'[GridLongPressed](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridLongPressed)'| markdownify }}</td>
<td>{{'[CellLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPress)'| markdownify }}</td>
<td>Occurs when the cell is long pressed for particular period.</td>
</tr>
<tr>
<td>{{'[GridLongPressedCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridLongPressedCommand)'| markdownify }}</td>
<td>{{'[CellLongPressedCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_CellLongPressCommand)'| markdownify }}</td>
<td>Occurs when the cell is long pressed for particular period.</td>
</tr>
<tr>
<td>{{'[QueryRowStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_QueryRowStyle)'| markdownify }}</td>
<td>-</td>
<td>This event is not available in MAUI DataGrid. You can write the custom style for {{'[DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html)'| markdownify }} TargetType.<br>
By writing the converter, you can achieve the requirement conditionally. Refer {{'[Conditional Styling](https://help.syncfusion.com/maui/datagrid/conditional-styling)'| markdownify }} UG documentation for more information.
</td>
</tr>
<tr>
<td>{{'[QueryCellStyle](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_QueryCellStyle)'| markdownify }}</td>
<td>-</td>
<td>This event is not available in MAUI DataGrid. You can write the custom style for {{'[DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html)'| markdownify }} TargetType.<br> By writing the converter, you can achieve the requirement conditionally. Refer {{'[Conditional Styling](https://help.syncfusion.com/maui/datagrid/conditional-styling)'| markdownify }} UG documentation for more information.
</td>
</tr>
<tr>
<td>{{'[PageIndexChanging](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.SfDataPager.html#Syncfusion_SfDataGrid_XForms_DataPager_SfDataPager_PageIndexChanging)'| markdownify }}</td>
<td>{{'[PageChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_PageChanging)'| markdownify }}</td>
<td>Occurs when page index is being changed.</td>
</tr>
<tr>
<td>{{'[PageIndexChanged](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.SfDataPager.html#Syncfusion_SfDataGrid_XForms_DataPager_SfDataPager_PageIndexChanged)'| markdownify }}</td>
<td>{{'[PageChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html#Syncfusion_Maui_DataGrid_DataPager_SfDataPager_PageChanged)'| markdownify }}</td>
<td>Occurs when page index is changed.</td>
</tr>
<tr>
<td>{{'[GridViewCreated](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridViewCreated)'| markdownify}}</td>
<td>{{'[ViewCreated](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ViewCreated)' | markdownify}}</td>
<td>Occurs when the View is created.</td>
</tr>
<tr>
<td>{{'[GridLoaded](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SfDataGrid.html#Syncfusion_SfDataGrid_XForms_SfDataGrid_GridLoaded)'| markdownify}}</td>
<td>{{'[DataGridLoaded](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_DataGridLoaded)'| markdownify}}</td>
<td>Occurs when the components in the SfDataGrid initialized and rendered.</td>
</tr>
</table>

## Methods

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th>
<th>Description</th></tr>
<tr>
<td>{{'[GetRowHeight](https://help.syncfusion.com/xamarin/datagrid/row-height-customization#auto-fit-the-grid-rows-based-on-content)'| markdownify }}</td>
<td>{{'[GetIntrinsicRowHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryRowHeightEventArgs.html#Syncfusion_Maui_DataGrid_DataGridQueryRowHeightEventArgs_GetIntrinsicRowHeight_System_Int32_System_Boolean_System_Collections_Generic_List_System_String__)'| markdownify }}</td>
<td>Gets the row height to fit that row based on the content.<br>
We have passed the optional parameters such as {{'[canIncludeHiddenColumns](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridRowSizingOptions.html#Syncfusion_SfDataGrid_XForms_GridRowSizingOptions_CanIncludeHiddenColumns)'| markdownify }} and {{'[excludedColumns](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridRowSizingOptions.html#Syncfusion_SfDataGrid_XForms_GridRowSizingOptions_ExcludeColumns)'| markdownify }} where as we have not provided the {{'[GridRowSizingOptions](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridRowSizingOptions.html)'| markdownify }} class as parameters.
</td>
</tr>
</table>

## Classes

<table>
<tr>
<th>Xamarin SfDataGrid</th>
<th>.NET MAUI SfDataGrid</th>
<th>Description</th></tr>
<tr>
<td>{{'[GridColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumn.html)'| markdownify }}</td>
<td>{{'[DataGridColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumn.html)'| markdownify }}</td>
<td>Represents the base class for the different column types of the {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>
<tr>
<td>{{'[GridNumericColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridNumericColumn.html)'| markdownify }}</td>
<td>{{'[DataGridNumericColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridNumericColumn.html)'| markdownify }}</td>
<td>A column which is used to handle the numeric values.</td>
</tr>
<tr>
<td>{{'[GridDateTimeColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridDateTimeColumn.html)'| markdownify }}</td>
<td>{{'[DataGridDateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridDateColumn.html)'| markdownify }}</td>
<td>A column which is used to show any type of System.DateTime.</td>
</tr>
<tr>
<td>{{'[GridImageColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridImageColumn.html)'| markdownify }}</td>
<td>{{'[DataGridImageColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridImageColumn.html)'| markdownify }}</td>
<td>A column which is used to show any type of ImageSource.</td>
</tr>
<tr>
<td>{{'[GridTemplateColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridTemplateColumn.html)'| markdownify }}</td>
<td>{{'[DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html)'| markdownify }}</td>
<td>A column which is used to show any type of template.</td>
</tr>
<tr>
<td>{{'[GridTextColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridTextColumn.html)'| markdownify }}</td>
<td>{{'[DataGridTextColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTextColumn.html)'| markdownify }}</td>
<td>Represents a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} column that hosts textual Content in its cells.</td>
</tr>
<tr>
<td>{{'[GridCell](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridCell.html)'| markdownify }}</td>
<td>{{'[DataGridCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridCell.html)'| markdownify }}</td>
<td>Represents a record cell in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>
<tr>
<td>{{'[VirtualizingCellsControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.VirtualizingCellsControl.html)'| markdownify }}</td>
<td>{{'[DataGridRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridRow.html)'| markdownify }}</td>
<td>Represents a record row in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[GridHeaderCellControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridHeaderCellControl.html)'| markdownify }}</td>
<td>{{'[DataGridHeaderCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridHeaderCell.html)'| markdownify }}</td>
<td>Represents a header cell in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control</td>
</tr>

<tr>
<td>{{'[GridColumnSizer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridColumnSizer.html)'| markdownify }}</td>
<td>{{'[DataGridColumnSizer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnSizer.html)'| markdownify }}</td>
<td>Represents a class that handles the sizing for all the {{'[columns](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_Columns)'| markdownify }} in the Columns collection in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[GridSummaryRow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridSummaryRow.html)'| markdownify }}</td>
<td>{{'[DataGridSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSummaryRow.html)'| markdownify }}</td>
<td> Represents a class that defines the summary information of summary row.</td>
</tr>

<tr>
<td>{{'[GridTableSummaryRow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridTableSummaryRow.html)'| markdownify }}</td>
<td>{{'[DataGridTableSummaryRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRow.html)'| markdownify }}</td>
<td> Represents a class that defines summary information of table summary row in {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }}.</td>
</tr>

<tr>
<td>{{'[Position](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.Position.html)'| markdownify }}</td>
<td>{{'[SummaryRowPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SummaryRowPosition.html)'| markdownify }}</td>
<td> Defines the constants that specify whether the table summary row is positioned at the top or bottom of the {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[TableSummaryRowControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.TableSummaryRowControl.html)'| markdownify }}</td>
<td>{{'[DataGridTableSummaryRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTableSummaryRowView.html)'| markdownify }}</td>
<td> Represents a table summary row in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[StackedColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.StackedColumn.html)'| markdownify }}</td>
<td>{{'[DataGridStackedColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedColumn.html)'| markdownify }}</td>
<td>Represents a column that is stacked across the specified child columns in it.</td>
</tr>

<tr>
<td>{{'[StackedHeaderCellControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.StackedHeaderCellControl.html)'| markdownify }}</td>
<td>{{'[DataGridStackedHeaderCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderCell.html)'| markdownify }}</td>
<td>Represents a {{'[DataGridStackedCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderCell.html)'| markdownify }} in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[GridStackedHeaderCellRenderer](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridStackedHeaderCellRenderer.html)'| markdownify }}</td>
<td>{{'[DataGridStackedHeaderCellRenderer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderCellRenderer.html)'| markdownify }}</td>
<td>A class for cell renderer that displays{{'[DataGridStackedHeaderRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderRow.html)'| markdownify }} in a {{'[DataGridStackedCell](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderCell.html)'| markdownify }}.</td>
</tr>

<tr>
<td>{{'[StackedHeaderRow](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.StackedHeaderRow.html)'| markdownify }}</td>
<td>{{'[DataGridStackedHeaderRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderRow.html)'| markdownify }}</td>
<td>The {{'[DataGridStackedHeaderRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderRow.html)'| markdownify }} contains the collection of {{'[DataGridStackedColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedColumn.html)'| markdownify }} to be grouped under a particular category.}}.</td>
</tr>

<tr>
<td>{{'[GridStackedHeaderCellControl](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridStackedHeaderCellControl.html)'| markdownify }}</td>
<td>{{'[DataGridStackedHeaderRowView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderRowView.html)'| markdownify }}</td>
<td>Represents a {{'[DataGridStackedHeaderRow](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridStackedHeaderRow.html)'| markdownify }} as a control in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[GridUnboundRows](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.UnboundRows.html)'| markdownify}}</td>
<td>{{'[DataGridUnboundRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundRows.html)'| markdownify}}</td>
<td>Represents a {{'[DataGridUnboundRows](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundRows.html)'| markdownify}} as a control to add additional rows in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[GridUnboundColumn](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridUnboundColumn.html)'| markdownify}}</td>
<td>{{'[DataGridUnboundColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html)'| markdownify}}</td>
<td>Represents a {{'[DataGridUnboundColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridUnboundColumn.html)'| markdownify}} as a control to add additional columns in a {{'[SfDataGrid](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html)'| markdownify }} control.</td>
</tr>

<tr>
<td>{{'[AppearanceManager](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.DataPager.AppearanceManager.html)'| markdownify }}</td>
<td>{{'[DataPagerStyle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.DataPagerStyle.html)'| markdownify }}</td>
<td>Represents a class that enables users to customize the appearance of the data pager.</td>
</tr>

<tr>
<td>{{'[GridResizingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.GridResizingEventArgs.html)'| markdownify }}</td>
<td>{{'[DataGridColumnResizingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridColumnResizingEventArgs.html)'| markdownify }}</td>
<td>Represents a datagrid column resizing event args.</td>
</tr>

<tr>
<td>{{'[QueryColumnDraggingEventArgs ](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.QueryColumnDraggingEventArgs.html)'| markdownify }}</td>
<td>{{'[DataGridQueryColumnDraggingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridQueryColumnDraggingEventArgs.html)'| markdownify }}</td>
<td>Represents a datagrid column drag and drop event args.</td>
</tr>

<tr>
<td>{{'[SwipeStartedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SwipeStartedEventArgs.html)'| markdownify }}</td>
<td>{{'[DataGridSwipeStartingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeStartingEventArgs.html)'| markdownify }}</td>
<td>Represents a datagrid swipe starting event args.</td>
</tr>

<tr>
<td>{{'[SwipingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SwipingEventArgs.html)'| markdownify }}</td>
<td>{{'[DataGridSwipingEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipingEventArgs.html)'| markdownify }}</td>
<td>Represents a datagrid swiping event args.</td>
</tr>

<tr>
<td>{{'[SwipeEndedEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataGrid.XForms.SwipeEndedEventArgs.html)'| markdownify }}</td>
<td>{{'[DataGridSwipeEndedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridSwipeEndedEventArgs.html)'| markdownify }}</td>
<td>Represents a datagrid swipe ended event args.</td>
</tr>
</table>

## Known issues 

* [Android] Horizontal scrolling performance is not smooth in the Debug solution configuration when compared to Xamarin.Forms SfDataGrid. However, the scrolling performance is smooth when the solution configuration is Release.

* [Windows] Swiping and Row Drag-and-Drop using the touchscreen are not working.

## Upcoming Features   

*	Custom selection
