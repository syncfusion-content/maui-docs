---
layout: post
title: Migrating from Xamarin SfListView to .NET MAUI SfListView | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin ListView to Syncfusion .NET MAUI ListView control and more.
platform: MAUI
control: SfListView
documentation: ug
---  

# Migrating from Xamarin SfListView to .NET MAUI SfListView 

The .NET MAUI ListView control is used to present lists of data in a vertical or horizontal orientation with different layouts virtually. It supports essential features such as selection, template selectors, horizontal and vertical orientation, load more, autofitting items, and more. The control also supports sorting, grouping, and filtering with optimization for working with large amounts of data.

## Adding Reference 

Assembly Name 
<table>
<tr>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th></tr>
<tr>
<td>Syncfusion.SfListView.XForms</td>
<td>Syncfusion.Maui.ListView</td></tr>
</table>

Namespaces 
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

The following tables shows the API changes between Xamarin SfListView and .NET MAUI SfListView.

Properties

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
</table> 

Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfListView</th>
<th>.NET MAUI SfListView</th>
<th>Description</th></tr>
<tr>
<td>LoadMorePosition</td>
<td>Top,<br/>Bottom</td>
<td>Start,<br/>End</td>
<td>Defines position for the load more support of SfListView.</td></tr>
<tr>
<td>TouchGesture</td>
<td>Hold</td>
<td>LongPress</td>
<td>Describes the possible values of touch operation. These values are used when updating selection in the SfListView control.</td></tr>
</table>

Events

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

Classes 

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
<td>Syncfusion.ListView.XForms.Helpers.InverseBoolConverter</td>
<td>Syncfusion.Maui.Core.Converters.InvertedBoolConverter</td>
<td>Converter to reverse the boolean value.</td></tr>
</table>