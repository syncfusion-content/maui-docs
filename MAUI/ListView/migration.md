---
layout: post
title: Migrate from Xamarin SfListView to .NET MAUI SfListView | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin ListView to Syncfusion .NET MAUI ListView control and more.
platform: MAUI
control: SfListView
documentation: ug
---  

# Migrate from Xamarin.Forms SfListView to .NET MAUI SfListView 

To migrate easier from [Xamarin SfListView](https://www.syncfusion.com/xamarin-ui-controls/xamarin-listview) to [.NET MAUI SfListView](https://www.syncfusion.com/maui-controls/maui-listview), we kept most of the APIs from Xamarin SfListView in MAUI SfListView. However, to maintain the consistency of API naming in MAUI SfListView, we renamed some of the APIs. The APIs that have been changed in MAUI SfListView from Xamarin SfListView are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th></tr>
<tr>
<td>Syncfusion.ListView.XForms</td>
<td>Syncfusion.Maui.ListView</td></tr>
<tr>
<td>Syncfusion.ListView.XForms.Control.Helpers</td>
<td>Syncfusion.Maui.ListView.Helpers</td></tr>
<tr>
<td>Syncfusion.DataSource</td>
<td>Syncfusion.Maui.DataSource</td></tr>
<tr>
<td>Syncfusion.DataSource.Extensions</td>
<td>Syncfusion.Maui.DataSource.Extensions</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th>
<th>Description</th></tr>
<tr>
<td>{{'[HoldCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfListView.html#Syncfusion_ListView_XForms_SfListView_HoldCommand)'| markdownify }}</td>
<td>{{'[LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand)'| markdownify }}</td>
<td>Gets or sets System.Windows.Input.ICommand which will be executed when hold on the ListViewItem.</td></tr>
<tr>
<td>{{'[HoldCommandParameter](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfListView.html#Syncfusion_ListView_XForms_SfListView_HoldCommandParameter)'| markdownify }}</td>
<td>{{'[LongPressCommandParameter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter)'| markdownify }}</td>
<td>Gets or sets the parameter for LongPressCommand.</td></tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfListView.html#Syncfusion_ListView_XForms_SfListView_SelectionBackgroundColor)' | markdownify }}</td>
<td>{{'[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground)'| markdownify }}</td>
<td>Gets or sets the selection background color for the selected item.</td></tr>
<tr>
<td>{{'[IsBusy](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfListView.html#Syncfusion_ListView_XForms_SfListView_IsBusy)'| markdownify }}</td>
<td>{{'[IsLazyLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading)'| markdownify }}</td>
<td>Gets or sets a value indicating whether list view is busy in loading more items. If it is true, the load more indicators will be displayed until it sets to false.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemTappedEventArgs.html#Syncfusion_ListView_XForms_ItemTappedEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemTappedEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html#Syncfusion_Maui_ListView_ItemTappedEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the item data of the tapped item.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemHoldingEventArgs.html#Syncfusion_ListView_XForms_ItemHoldingEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemLongPressEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html#Syncfusion_Maui_ListView_ItemLongPressEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the item data of the long pressed item.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemDoubleTappedEventArgs.html#Syncfusion_ListView_XForms_ItemDoubleTappedEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemDoubleTappedEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html#Syncfusion_Maui_ListView_ItemDoubleTappedEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the item data of the double tapped item.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemAppearingEventArgs.html#Syncfusion_ListView_XForms_ItemAppearingEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemAppearingEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html#Syncfusion_Maui_ListView_ItemAppearingEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the underlying data object of the ListViewItem when item appearing from the bound data source.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemDisappearingEventArgs.html#Syncfusion_ListView_XForms_ItemDisappearingEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemDisappearingEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html#Syncfusion_Maui_ListView_ItemDisappearingEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the underlying data object of the ListViewItem when item disappearing from the bound data source.</td>
</tr>
<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.QueryItemSizeEventArgs.html#Syncfusion_ListView_XForms_QueryItemSizeEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[QueryItemSizeEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.QueryItemSizeEventArgs.html#Syncfusion_Maui_ListView_QueryItemSizeEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the underlying data of the queried item.</td>
</tr>

<tr>
<td>{{'[ItemData](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemDraggingEventArgs.html#Syncfusion_ListView_XForms_ItemDraggingEventArgs_ItemData)'| markdownify }}</td>
<td>{{'[ItemDraggingEventArgs.DataItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDraggingEventArgs.html#Syncfusion_Maui_ListView_ItemDraggingEventArgs_DataItem)'| markdownify }}</td>
<td>Gets the underlying data object of the ListViewItem that is currently being dragged from the bound data source.</td>
</tr>

<tr>
<td>{{'[CanAdjustDragItemAxis](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.DragDropController.html#Syncfusion_ListView_XForms_DragDropController_CanAdjustDragItemAxis)'| markdownify }}</td>
<td>{{'[CanAdjustDragItemAxis](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DragDropController.html#Syncfusion_Maui_ListView_DragDropController_CanAdjustDragItemAxis)'| markdownify }}</td>
<td>A property that Gets or sets a value that determines whether to adjust the X position of the drag item for vertical orientation and the Y position for horizontal orientation.</td>
</tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th>
<th>Description</th></tr>
<tr>
<td>{{'[LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMorePosition.html)'| markdownify }}</td>
<td>Top,<br/>Bottom</td>
<td>Start,<br/>End</td>
<td>Defines position for the load more support of SfListView.</td></tr>
<tr>
<td>{{'[TouchGesture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.TouchGesture.html)'| markdownify }}</td>
<td>Hold</td>
<td>LongPress</td>
<td>Describes the possible values of touch operation. These values are used when updating selection in the SfListView control.</td></tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemHolding](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfListView.html#Syncfusion_ListView_XForms_SfListView_ItemHolding)'| markdownify }}</td>
<td>{{'[ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress)'| markdownify }}</td>
<td>Occurs when an item is long pressed.</td></tr>
</table> 

## Classes 

<table>
<tr>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th>
<th>Description</th></tr>
<tr>
<td>{{'[FooterItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.FooterItem.html)'| markdownify}}</td>
<td>{{'[ListViewFooterItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewFooterItem.html)'| markdownify }}</td>
<td>Represents the footer item of data in the SfListView control.</td></tr>
<tr> 
<td>{{'[FooterPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.FooterPosition.html)'| markdownify }}</td>
<td>{{'[ListViewFooterPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewFooterItem.html)'| markdownify }}</td>
<td>Defines the position of the footer when IsStickyFooter is enabled.</td></tr> 
<tr>
<td>{{'[GroupHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.GroupHeaderItem.html)'| markdownify}}</td>
<td>{{'[ListViewGroupHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewGroupHeaderItem.html)'| markdownify }}</td>
<td>Represents the group header item in a SfListView control.</td></tr>
<tr>
<td>{{'[HeaderItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.HeaderItem.html)'| markdownify }}</td>
<td>{{'[ListViewHeaderItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewHeaderItem.html)'| markdownify }}</td>
<td>Represents the header item of data in the SfListView control.</td></tr>
<tr>
<td>{{'[ItemHoldingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.ItemHoldingEventArgs.html)'| markdownify }}</td>
<td>{{'[ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html)'| markdownify }}</td>
<td>Provides data for ItemLongPress event.</td></tr> 
<tr> 
<td>{{'[LoadMoreIndicator](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.LoadMoreIndicator.html)'| markdownify }}</td>
<td>{{'[ListViewLoadMoreIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadMoreIndicator.html)'| markdownify }}</td>
<td>A loading indicator which will be displayed when loading more items into the list view is in progress.</td></tr>
<tr>
<td>{{'[LoadMoreItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.LoadMoreItem.html)'| markdownify }}</td>
<td>{{'[ListViewLoadMoreItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadMoreItem.html)'| markdownify }}</td>
<td>Represents the load more item in a SfListView control.</td></tr>
<tr>
<td>{{'[LayoutBase](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.LayoutBase.html)'| markdownify }}</td>
<td>{{'[ListViewLayout](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLayout.html)'| markdownify }}</td>
<td>Defines the base for the layouts.</td></tr>
<tr>
<td>{{'[InverseBoolConverter](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.Helpers.InverseBoolConverter.html)'| markdownify }}</td>
<td>{{'[InvertedBoolConverter](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Converters.InvertedBoolConverter.html)'| markdownify }}</td>
<td>Converter to reverse the boolean value.</td></tr>
</table> 

## Upcoming features

  * Pull to refresh
