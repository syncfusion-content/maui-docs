---
layout: post
title: Migrate from Xamarin SfRangeSlider to .NET MAUI SfSlider | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin RangeSlider to Syncfusion .NET MAUI Slider control and more.
platform: MAUI
control: SfSlider
documentation: ug
---  

# Migrate from Xamarin.Forms SfRangeSlider to .NET MAUI SfSlider 

To migrate easier from [Xamarin SfRangeSlider](https://www.syncfusion.com/xamarin-ui-controls/xamarin-range-slider) to [.NET MAUI SfSlider](https://www.syncfusion.com/maui-controls/maui-slider), we kept most of the APIs from Xamarin SfRangeSlider in MAUI SfSlider. However, to maintain the consistency of API naming in MAUI SfSlider, we renamed some of the APIs. The APIs that have been changed in MAUI SfSlider from Xamarin SfRangeSlider are detailed as follows.

## Assembly Name 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th></tr>
<tr>
<td>Syncfusion.SfRangeSlider.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Namespaces 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th></tr>
<tr>
<td>Syncfusion.ListView.XForms</td>
<td>Syncfusion.Maui.Sliders</td></tr>
</table>

## Properties

### Track

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[TrackColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the active track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the active track in the SfSlider.</td></tr>
</table> 

### Thumb

<table> 
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[ThumbSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionColor](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveFill](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the brush for the active track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.InactiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the inactive track in the SfSlider.</td></tr>
<tr>
<td>{{'[TrackSelectionThickness](Pastethehttplinkhere)'| markdownify }}</td>
<td>{{'[SliderTrackStyle.ActiveSize](Pastethehttplinkhere)'| markdownify }}</td>
<td>Gets or sets the size for the active track in the SfSlider.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[LoadMorePosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.LoadMorePosition.html)'| markdownify }}</td>
<td>Top,<br/>Bottom</td>
<td>Start,<br/>End</td>
<td>Defines position for the load more support of SfRangeSlider.</td></tr>
<tr>
<td>{{'[TouchGesture](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.TouchGesture.html)'| markdownify }}</td>
<td>Hold</td>
<td>LongPress</td>
<td>Describes the possible values of touch operation. These values are used when updating selection in the SfRangeSlider control.</td></tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemHolding](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.SfRangeSlider.html#Syncfusion_ListView_XForms_SfListView_ItemHolding)'| markdownify }}</td>
<td>{{'[ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfRangeSlider.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress)'| markdownify }}</td>
<td>Occurs when an item is long pressed.</td></tr>
</table> 

## Classes 

<table>
<tr>
<th>Xamarin SfRangeSlider</th>
<th>.NET MAUI SfSlider</th>
<th>Description</th></tr>
<tr>
<td>{{'[FooterItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.FooterItem.html)'| markdownify}}</td>
<td>{{'[ListViewFooterItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewFooterItem.html)'| markdownify }}</td>
<td>Represents the footer item of data in the SfRangeSlider control.</td></tr>
<tr> 
<td>{{'[FooterPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.FooterPosition.html)'| markdownify }}</td>
<td>{{'[ListViewFooterPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewFooterItem.html)'| markdownify }}</td>
<td>Defines the position of the footer when IsStickyFooter is enabled.</td></tr> 
<tr>
<td>{{'[GroupHeader](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.GroupHeaderItem.html)'| markdownify}}</td>
<td>{{'[ListViewGroupHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewGroupHeaderItem.html)'| markdownify }}</td>
<td>Represents the group header item in a SfRangeSlider control.</td></tr>
<tr>
<td>{{'[HeaderItem](https://help.syncfusion.com/cr/xamarin/Syncfusion.ListView.XForms.HeaderItem.html)'| markdownify }}</td>
<td>{{'[ListViewHeaderItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewHeaderItem.html)'| markdownify }}</td>
<td>Represents the header item of data in the SfRangeSlider control.</td></tr>
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
<td>Represents the load more item in a SfRangeSlider control.</td></tr>
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

  * Item reordering
  * Pull to refresh
  * Swiping