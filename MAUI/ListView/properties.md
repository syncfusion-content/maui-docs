---
layout: post
title: Properties of .NET MAUI ListView control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI ListView (SfListView) control.
platform: maui
control: SfListView
documentation: ug
---

# .NET MAUI ListView API Reference

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowGroupExpandCollapse">AllowGroupExpandCollapse</a></td>
		<td>bool</td>
		<td>Defines whether group expand and collapse is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowSwiping">AllowSwiping</a></td>
		<td>bool</td>
		<td>Defines whether item swiping is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode">AutoFitMode</a></td>
		<td>AutoFitMode</td>
		<td>Defines how item size is calculated.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoScroller">AutoScroller</a></td>
		<td>AutoScroller</td>
		<td>Defines the auto scroll helper.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CachingStrategy">CachingStrategy</a></td>
		<td>CachingStrategy</td>
		<td>Defines the item template caching mode.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CanMaintainScrollPosition">CanMaintainScrollPosition</a></td>
		<td>bool</td>
		<td>Defines whether scroll position is preserved after data changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CurrentItem">CurrentItem</a></td>
		<td>object</td>
		<td>Defines the current item.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DataSource">DataSource</a></td>
		<td>DataSource</td>
		<td>Defines data operations like sorting and grouping.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DisplayMemberPath">DisplayMemberPath</a></td>
		<td>string</td>
		<td>Defines the field displayed when no item template is set.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragDropController">DragDropController</a></td>
		<td>DragDropController</td>
		<td>Defines drag and drop behavior.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragItemTemplate">DragItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the dragged item template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragStartMode">DragStartMode</a></td>
		<td>DragStartMode</td>
		<td>Defines how dragging starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyView">EmptyView</a></td>
		<td>object</td>
		<td>Defines the content shown when the list is empty.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyViewTemplate">EmptyViewTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the empty view template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableFadeOnScroll">EnableFadeOnScroll</a></td>
		<td>bool</td>
		<td>Defines whether fade animation is enabled during scrolling.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
		<td>bool</td>
		<td>Defines whether the liquid glass effect is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EndSwipeTemplate">EndSwipeTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template shown after swiping to the end side.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITemplate">FilteringUITemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the filtering UI template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITitle">FilteringUITitle</a></td>
		<td>string</td>
		<td>Defines the filtering UI title.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterSize">FooterSize</a></td>
		<td>double</td>
		<td>Defines the footer size.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterTemplate">FooterTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the footer template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderColor">GroupHeaderBorderColor</a></td>
		<td>Color</td>
		<td>Defines the group header border color.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderMargin">GroupHeaderBorderMargin</a></td>
		<td>Thickness</td>
		<td>Defines the group header border margin.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderRadius">GroupHeaderBorderRadius</a></td>
		<td>CornerRadius</td>
		<td>Defines the group header border corner radius.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderThickness">GroupHeaderBorderThickness</a></td>
		<td>Thickness</td>
		<td>Defines the group header border thickness.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderSize">GroupHeaderSize</a></td>
		<td>double</td>
		<td>Defines the group header size.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderTemplate">GroupHeaderTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the group header template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorColor">GroupItemSeparatorColor</a></td>
		<td>Color</td>
		<td>Defines the group item separator color.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorMargin">GroupItemSeparatorMargin</a></td>
		<td>Thickness</td>
		<td>Defines the group item separator margin.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorThickness">GroupItemSeparatorThickness</a></td>
		<td>double</td>
		<td>Defines the group item separator thickness.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderSize">HeaderSize</a></td>
		<td>double</td>
		<td>Defines the header size.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderTemplate">HeaderTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the header template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading">IsLazyLoading</a></td>
		<td>bool</td>
		<td>Defines whether load more content is active.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsScrollingEnabled">IsScrollingEnabled</a></td>
		<td>bool</td>
		<td>Defines whether scrolling is enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyFooter">IsStickyFooter</a></td>
		<td>bool</td>
		<td>Defines whether sticky footers are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyGroupHeader">IsStickyGroupHeader</a></td>
		<td>bool</td>
		<td>Defines whether sticky group headers are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyHeader">IsStickyHeader</a></td>
		<td>bool</td>
		<td>Defines whether sticky headers are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderColor">ItemBorderColor</a></td>
		<td>Color</td>
		<td>Defines the item border color.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderMargin">ItemBorderMargin</a></td>
		<td>Thickness</td>
		<td>Defines the item border margin.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderRadius">ItemBorderRadius</a></td>
		<td>CornerRadius</td>
		<td>Defines the item border corner radius.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderThickness">ItemBorderThickness</a></td>
		<td>Thickness</td>
		<td>Defines the item border thickness.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemGenerator">ItemGenerator</a></td>
		<td>ItemsGenerator</td>
		<td>Defines the item generator.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorColor">ItemSeparatorColor</a></td>
		<td>Color</td>
		<td>Defines the item separator color.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorMargin">ItemSeparatorMargin</a></td>
		<td>Thickness</td>
		<td>Defines the item separator margin.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorThickness">ItemSeparatorThickness</a></td>
		<td>double</td>
		<td>Defines the item separator thickness.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize">ItemSize</a></td>
		<td>double</td>
		<td>Defines the item size.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSpacing">ItemSpacing</a></td>
		<td>Thickness</td>
		<td>Defines the spacing between items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsLayout">ItemsLayout</a></td>
		<td>ListViewLayout</td>
		<td>Defines the item layout.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource">ItemsSource</a></td>
		<td>object</td>
		<td>Defines the item source.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSourceChangeCachingStrategy">ItemsSourceChangeCachingStrategy</a></td>
		<td>ItemsSourceChangeCachingStrategy</td>
		<td>Defines the caching mode when the source changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate">ItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the item template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand">LoadMoreCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when load more is triggered.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommandParameter">LoadMoreCommandParameter</a></td>
		<td>object</td>
		<td>Defines the load more command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreOption">LoadMoreOption</a></td>
		<td>LoadMoreOption</td>
		<td>Defines the load more mode.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMorePosition">LoadMorePosition</a></td>
		<td>LoadMorePosition</td>
		<td>Defines where the load more item appears.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreTemplate">LoadMoreTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the load more template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand">LongPressCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when an item is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter">LongPressCommandParameter</a></td>
		<td>object</td>
		<td>Defines the long press command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Orientation">Orientation</a></td>
		<td>ItemsLayoutOrientation</td>
		<td>Defines the list orientation.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RightTapCommand">RightTapCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when an item is right tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RightTapCommandParameter">RightTapCommandParameter</a></td>
		<td>object</td>
		<td>Defines the right tap command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollBarVisibility">ScrollBarVisibility</a></td>
		<td>ScrollBarVisibility</td>
		<td>Defines the scroll bar visibility.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem">SelectedItem</a></td>
		<td>object</td>
		<td>Defines the first selected item.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItemTemplate">SelectedItemTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the selected item template.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems">SelectedItems</a></td>
		<td>ObservableCollection&lt;object&gt;</td>
		<td>Defines the selected items collection.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground">SelectionBackground</a></td>
		<td>Brush</td>
		<td>Defines the selection background.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommand">SelectionChangedCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when selection changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommandParameter">SelectionChangedCommandParameter</a></td>
		<td>object</td>
		<td>Defines the selection changed command parameter.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionController">SelectionController</a></td>
		<td>SelectionController</td>
		<td>Defines the selection controller.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionGesture">SelectionGesture</a></td>
		<td>TouchGesture</td>
		<td>Defines the selection gesture.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode">SelectionMode</a></td>
		<td>SelectionMode</td>
		<td>Defines the selection mode.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowFilteringUICommand">ShowFilteringUICommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that shows the filtering UI.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowGroupHeaderBorder">ShowGroupHeaderBorder</a></td>
		<td>bool</td>
		<td>Defines whether group header borders are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowGroupItemSeparator">ShowGroupItemSeparator</a></td>
		<td>bool</td>
		<td>Defines whether group item separators are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowItemBorder">ShowItemBorder</a></td>
		<td>bool</td>
		<td>Defines whether item borders are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowItemSeparator">ShowItemSeparator</a></td>
		<td>bool</td>
		<td>Defines whether item separators are enabled.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_StartSwipeTemplate">StartSwipeTemplate</a></td>
		<td>DataTemplate</td>
		<td>Defines the template shown after swiping to the start side.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_StickyFooterPosition">StickyFooterPosition</a></td>
		<td>ListViewFooterPosition</td>
		<td>Defines the sticky footer position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeOffset">SwipeOffset</a></td>
		<td>double</td>
		<td>Defines the swipe offset.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeThreshold">SwipeThreshold</a></td>
		<td>double</td>
		<td>Defines the swipe threshold.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand">TapCommand</a></td>
		<td>ICommand</td>
		<td>Defines the command that runs when an item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommandParameter">TapCommandParameter</a></td>
		<td>object</td>
		<td>Defines the tap command parameter.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsed">GroupCollapsed</a></td>
		<td>EventHandler&lt;GroupExpandCollapseChangedEventArgs&gt;</td>
		<td>Raised when a group collapses.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsing">GroupCollapsing</a></td>
		<td>EventHandler&lt;GroupExpandCollapseChangingEventArgs&gt;</td>
		<td>Raised before a group collapses.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanded">GroupExpanded</a></td>
		<td>EventHandler&lt;GroupExpandCollapseChangedEventArgs&gt;</td>
		<td>Raised when a group expands.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanding">GroupExpanding</a></td>
		<td>EventHandler&lt;GroupExpandCollapseChangingEventArgs&gt;</td>
		<td>Raised before a group expands.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing">ItemAppearing</a></td>
		<td>EventHandler&lt;ItemAppearingEventArgs&gt;</td>
		<td>Raised when an item appears.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing">ItemDisappearing</a></td>
		<td>EventHandler&lt;ItemDisappearingEventArgs&gt;</td>
		<td>Raised when an item disappears.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDragging">ItemDragging</a></td>
		<td>EventHandler&lt;ItemDraggingEventArgs&gt;</td>
		<td>Raised while an item is dragged.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped">ItemDoubleTapped</a></td>
		<td>EventHandler&lt;ItemDoubleTappedEventArgs&gt;</td>
		<td>Raised when an item is double tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress">ItemLongPress</a></td>
		<td>EventHandler&lt;ItemLongPressEventArgs&gt;</td>
		<td>Raised when an item is long pressed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemRightTapped">ItemRightTapped</a></td>
		<td>EventHandler&lt;ItemRightTappedEventArgs&gt;</td>
		<td>Raised when an item is right tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped">ItemTapped</a></td>
		<td>EventHandler&lt;ItemTappedEventArgs&gt;</td>
		<td>Raised when an item is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded">Loaded</a></td>
		<td>EventHandler&lt;ListViewLoadedEventArgs&gt;</td>
		<td>Raised when the control is loaded.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize">QueryItemSize</a></td>
		<td>EventHandler&lt;QueryItemSizeEventArgs&gt;</td>
		<td>Raised when item size is queried.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollStateChanged">ScrollStateChanged</a></td>
		<td>EventHandler&lt;ScrollStateChangedEventArgs&gt;</td>
		<td>Raised when the scroll state changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged">SelectionChanged</a></td>
		<td>EventHandler&lt;ItemSelectionChangedEventArgs&gt;</td>
		<td>Raised when the selection changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging">SelectionChanging</a></td>
		<td>EventHandler&lt;ItemSelectionChangingEventArgs&gt;</td>
		<td>Raised before the selection changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeEnded">SwipeEnded</a></td>
		<td>EventHandler&lt;SwipeEndedEventArgs&gt;</td>
		<td>Raised when a swipe ends.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeReset">SwipeReset</a></td>
		<td>EventHandler&lt;ResetSwipeEventArgs&gt;</td>
		<td>Raised when a swipe is reset.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeStarting">SwipeStarting</a></td>
		<td>EventHandler&lt;SwipeStartingEventArgs&gt;</td>
		<td>Raised before swiping starts.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Swiping">Swiping</a></td>
		<td>EventHandler&lt;SwipingEventArgs&gt;</td>
		<td>Raised while an item is swiped.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseAll">CollapseAll()</a></td>
		<td>void</td>
		<td>Collapses all groups.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseGroup_Syncfusion_Maui_DataSource_GroupResult_">CollapseGroup(GroupResult)</a></td>
		<td>void</td>
		<td>Collapses the specified group.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandAll">ExpandAll()</a></td>
		<td>void</td>
		<td>Expands all groups.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandGroup_Syncfusion_Maui_DataSource_GroupResult_">ExpandGroup(GroupResult)</a></td>
		<td>void</td>
		<td>Expands the specified group.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshItem_System_Int32_System_Int32_System_Boolean_">RefreshItem(Int32, Int32, Boolean)</a></td>
		<td>void</td>
		<td>Refreshes the specified item.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView">RefreshView()</a></td>
		<td>void</td>
		<td>Refreshes the view.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ResetSwipeItem_System_Boolean_">ResetSwipeItem(Boolean)</a></td>
		<td>void</td>
		<td>Resets the swiped item.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_">ScrollTo(Double, Boolean)</a></td>
		<td>void</td>
		<td>Scrolls to the specified position.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Object_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_">ScrollTo(Object, ScrollToPosition, Boolean)</a></td>
		<td>void</td>
		<td>Scrolls to the specified item.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectAll">SelectAll()</a></td>
		<td>void</td>
		<td>Selects all items.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeItem_System_Object_System_Double_">SwipeItem(Object, Double)</a></td>
		<td>void</td>
		<td>Swipes the specified item.</td>
	</tr>
</table>
