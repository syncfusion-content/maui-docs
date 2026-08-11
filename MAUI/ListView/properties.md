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
        <td>Defines whether grouped items can be expanded and collapsed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowSwiping">AllowSwiping</a></td>
        <td>bool</td>
        <td>Defines whether swipe actions are enabled for list items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode">AutoFitMode</a></td>
        <td>AutoFitMode</td>
        <td>Defines how the item size is calculated and adjusted automatically.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoScroller">AutoScroller</a></td>
        <td>AutoScroller</td>
        <td>Defines the helper used to automatically scroll the list during interactions.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CachingStrategy">CachingStrategy</a></td>
        <td>CachingStrategy</td>
        <td>Defines how item templates are cached and reused while rendering.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CanMaintainScrollPosition">CanMaintainScrollPosition</a></td>
        <td>bool</td>
        <td>Defines whether the current scroll position is preserved when the data source changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CurrentItem">CurrentItem</a></td>
        <td>object</td>
        <td>Defines the item that is currently active or focused in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DataSource">DataSource</a></td>
        <td>DataSource</td>
        <td>Defines the data source used for sorting, grouping, and filtering operations.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DisplayMemberPath">DisplayMemberPath</a></td>
        <td>string</td>
        <td>Defines the property path used to display text when no item template is applied.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragDropController">DragDropController</a></td>
        <td>DragDropController</td>
        <td>Defines the controller used to manage drag and drop behavior.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragItemTemplate">DragItemTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to render an item while it is being dragged.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragStartMode">DragStartMode</a></td>
        <td>DragStartMode</td>
        <td>Defines how and when the drag operation begins.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyView">EmptyView</a></td>
        <td>object</td>
        <td>Defines the content shown when the list has no items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyViewTemplate">EmptyViewTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to display the empty view content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableFadeOnScroll">EnableFadeOnScroll</a></td>
        <td>bool</td>
        <td>Defines whether items fade in or out during scrolling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
        <td>bool</td>
        <td>Defines whether the liquid glass visual effect is applied to the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EndSwipeTemplate">EndSwipeTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template shown when an item is swiped toward the end side.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITemplate">FilteringUITemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used for the filtering user interface.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITitle">FilteringUITitle</a></td>
        <td>string</td>
        <td>Defines the title displayed in the filtering user interface.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterSize">FooterSize</a></td>
        <td>double</td>
        <td>Defines the size of the footer section in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterTemplate">FooterTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to render the footer section.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderColor">GroupHeaderBorderColor</a></td>
        <td>Color</td>
        <td>Defines the border color applied to group headers.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderMargin">GroupHeaderBorderMargin</a></td>
        <td>Thickness</td>
        <td>Defines the margin around the group header border.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderRadius">GroupHeaderBorderRadius</a></td>
        <td>CornerRadius</td>
        <td>Defines the corner radius applied to the group header border.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderThickness">GroupHeaderBorderThickness</a></td>
        <td>Thickness</td>
        <td>Defines the thickness of the group header border.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderSize">GroupHeaderSize</a></td>
        <td>double</td>
        <td>Defines the size of each group header.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderTemplate">GroupHeaderTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to render group headers.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorColor">GroupItemSeparatorColor</a></td>
        <td>Color</td>
        <td>Defines the color of separators shown between items in a group.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorMargin">GroupItemSeparatorMargin</a></td>
        <td>Thickness</td>
        <td>Defines the margin applied to group item separators.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupItemSeparatorThickness">GroupItemSeparatorThickness</a></td>
        <td>double</td>
        <td>Defines the thickness of the separator between grouped items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderSize">HeaderSize</a></td>
        <td>double</td>
        <td>Defines the size of the header section in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderTemplate">HeaderTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to render the header section.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading">IsLazyLoading</a></td>
        <td>bool</td>
        <td>Defines whether additional items are loaded on demand while scrolling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsScrollingEnabled">IsScrollingEnabled</a></td>
        <td>bool</td>
        <td>Defines whether the list can be scrolled.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyFooter">IsStickyFooter</a></td>
        <td>bool</td>
        <td>Defines whether the footer remains fixed while scrolling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyGroupHeader">IsStickyGroupHeader</a></td>
        <td>bool</td>
        <td>Defines whether group headers stay visible while scrolling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsStickyHeader">IsStickyHeader</a></td>
        <td>bool</td>
        <td>Defines whether the header remains visible while scrolling.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderColor">ItemBorderColor</a></td>
        <td>Color</td>
        <td>Defines the border color applied to each item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderMargin">ItemBorderMargin</a></td>
        <td>Thickness</td>
        <td>Defines the margin around each item border.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderRadius">ItemBorderRadius</a></td>
        <td>CornerRadius</td>
        <td>Defines the corner radius applied to item borders.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemBorderThickness">ItemBorderThickness</a></td>
        <td>Thickness</td>
        <td>Defines the thickness of the border around each item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemGenerator">ItemGenerator</a></td>
        <td>ItemsGenerator</td>
        <td>Defines the generator used to create and manage list items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorColor">ItemSeparatorColor</a></td>
        <td>Color</td>
        <td>Defines the color of separators between list items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorMargin">ItemSeparatorMargin</a></td>
        <td>Thickness</td>
        <td>Defines the margin applied to item separators.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSeparatorThickness">ItemSeparatorThickness</a></td>
        <td>double</td>
        <td>Defines the thickness of separators between items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSize">ItemSize</a></td>
        <td>double</td>
        <td>Defines the size of each item in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemSpacing">ItemSpacing</a></td>
        <td>Thickness</td>
        <td>Defines the spacing around each item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsLayout">ItemsLayout</a></td>
        <td>ListViewLayout</td>
        <td>Defines the layout used to arrange list items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSource">ItemsSource</a></td>
        <td>object</td>
        <td>Defines the data collection displayed by the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemsSourceChangeCachingStrategy">ItemsSourceChangeCachingStrategy</a></td>
        <td>ItemsSourceChangeCachingStrategy</td>
        <td>Defines how item views are cached when the data source changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate">ItemTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to customize each item.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommand">LoadMoreCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when load-more is triggered.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreCommandParameter">LoadMoreCommandParameter</a></td>
        <td>object</td>
        <td>Defines the parameter passed to the load-more command.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreOption">LoadMoreOption</a></td>
        <td>LoadMoreOption</td>
        <td>Defines how and when load-more behavior is activated.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMorePosition">LoadMorePosition</a></td>
        <td>LoadMorePosition</td>
        <td>Defines where the load-more item appears in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LoadMoreTemplate">LoadMoreTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to display the load-more indicator or content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommand">LongPressCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when an item is long pressed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_LongPressCommandParameter">LongPressCommandParameter</a></td>
        <td>object</td>
        <td>Defines the parameter passed to the long-press command.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Orientation">Orientation</a></td>
        <td>ItemsLayoutOrientation</td>
        <td>Defines whether the list is arranged vertically or horizontally.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RightTapCommand">RightTapCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when an item is right tapped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RightTapCommandParameter">RightTapCommandParameter</a></td>
        <td>object</td>
        <td>Defines the parameter passed to the right-tap command.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollBarVisibility">ScrollBarVisibility</a></td>
        <td>ScrollBarVisibility</td>
        <td>Defines when the scroll bar is shown.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem">SelectedItem</a></td>
        <td>object</td>
        <td>Defines the currently selected item in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItemTemplate">SelectedItemTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template used to render the selected item state.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItems">SelectedItems</a></td>
        <td>ObservableCollection&lt;object&gt;</td>
        <td>Defines the collection of items currently selected in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionBackground">SelectionBackground</a></td>
        <td>Brush</td>
        <td>Defines the background brush used for selected items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommand">SelectionChangedCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when the selection changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChangedCommandParameter">SelectionChangedCommandParameter</a></td>
        <td>object</td>
        <td>Defines the parameter passed to the selection-changed command.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionController">SelectionController</a></td>
        <td>SelectionController</td>
        <td>Defines the controller used to manage item selection behavior.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionGesture">SelectionGesture</a></td>
        <td>TouchGesture</td>
        <td>Defines the gesture used to select items in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionMode">SelectionMode</a></td>
        <td>SelectionMode</td>
        <td>Defines how many items can be selected at the same time.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowFilteringUICommand">ShowFilteringUICommand</a></td>
        <td>ICommand</td>
        <td>Defines the command used to display the filtering user interface.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowGroupHeaderBorder">ShowGroupHeaderBorder</a></td>
        <td>bool</td>
        <td>Defines whether borders are shown around group headers.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowGroupItemSeparator">ShowGroupItemSeparator</a></td>
        <td>bool</td>
        <td>Defines whether separators are shown between items within groups.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowItemBorder">ShowItemBorder</a></td>
        <td>bool</td>
        <td>Defines whether item borders are displayed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ShowItemSeparator">ShowItemSeparator</a></td>
        <td>bool</td>
        <td>Defines whether separators are displayed between list items.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_StartSwipeTemplate">StartSwipeTemplate</a></td>
        <td>DataTemplate</td>
        <td>Defines the template shown when an item is swiped toward the start side.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_StickyFooterPosition">StickyFooterPosition</a></td>
        <td>ListViewFooterPosition</td>
        <td>Defines the position of the sticky footer in the list.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeOffset">SwipeOffset</a></td>
        <td>double</td>
        <td>Defines the offset distance used when an item is swiped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeThreshold">SwipeThreshold</a></td>
        <td>double</td>
        <td>Defines the swipe distance required to trigger a swipe action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommand">TapCommand</a></td>
        <td>ICommand</td>
        <td>Defines the command executed when an item is tapped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_TapCommandParameter">TapCommandParameter</a></td>
        <td>object</td>
        <td>Defines the parameter passed to the tap command.</td>
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
