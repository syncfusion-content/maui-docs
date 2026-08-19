---
layout: post
title: Properties of .NET MAUI ListView control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI ListView (SfListView) control.
platform: maui
control: SfListView
documentation: ug
---

# API Reference for .NET MAUI ListView

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowGroupExpandCollapse" aria-label="View AllowGroupExpandCollapse property in API reference">AllowGroupExpandCollapse</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether grouped items can be <code>expanded</code> and <code>collapsed</code>. Controls group visibility in hierarchical list content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowSwiping" aria-label="View AllowSwiping property in API reference">AllowSwiping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Enables or disables <code>swipe</code> interaction on list items. Useful for actions such as delete, archive, or reveal commands.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode" aria-label="View AutoFitMode property in API reference">AutoFitMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.AutoFitMode.html" aria-label="View AutoFitMode enum in API reference">AutoFitMode</a></td>
    <td>Defines how item size is calculated automatically. Controls whether content is measured by <code>width</code>, <code>height</code>, or both.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoScroller" aria-label="View AutoScroller property in API reference">AutoScroller</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.AutoScroller.html" aria-label="View AutoScroller type in API reference">AutoScroller</a></td>
    <td>Provides automatic scrolling support during interaction scenarios. Useful for drag, reorder, and edge scrolling behavior.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CachingStrategy" aria-label="View CachingStrategy property in API reference">CachingStrategy</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.CachingStrategy.html" aria-label="View CachingStrategy enum in API reference">CachingStrategy</a></td>
    <td>Defines how item templates are cached and reused. Helps balance <code>performance</code> and memory usage.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CanMaintainScrollPosition" aria-label="View CanMaintainScrollPosition property in API reference">CanMaintainScrollPosition</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Indicates whether the current <code>scroll</code> position is preserved when the data source changes. Helps avoid visual jumps after refresh.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CurrentItem" aria-label="View CurrentItem property in API reference">CurrentItem</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Represents the item currently active in the list. Typically reflects the focused or last interacted item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DataSource" aria-label="View DataSource property in API reference">DataSource</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DataSource.html" aria-label="View DataSource type in API reference">DataSource</a></td>
    <td>Stores the collection source used for <code>sorting</code>, <code>grouping</code>, and <code>filtering</code>. Forms the base for list data operations.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DisplayMemberPath" aria-label="View DisplayMemberPath property in API reference">DisplayMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Specifies the property path used for text display when no <code>ItemTemplate</code> is applied. Useful for simple bound text lists.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragDropController" aria-label="View DragDropController property in API reference">DragDropController</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DragDropController.html" aria-label="View DragDropController type in API reference">DragDropController</a></td>
    <td>Handles <code>drag-and-drop</code> behavior for list items. Used to customize item movement and drop handling.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragItemTemplate" aria-label="View DragItemTemplate property in API reference">DragItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used while an item is being dragged. Allows a custom <code>drag</code> preview.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragStartMode" aria-label="View DragStartMode property in API reference">DragStartMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DragStartMode.html" aria-label="View DragStartMode enum in API reference">DragStartMode</a></td>
    <td>Specifies when item dragging begins. Controls whether drag starts immediately or after a gesture threshold.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Displays when the list has no items. Provides a simple placeholder for empty states.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render the empty state. Supports custom <code>layout</code> and messaging.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableFadeOnScroll" aria-label="View EnableFadeOnScroll property in API reference">EnableFadeOnScroll</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether items fade during scrolling. Adds a subtle visual effect while the list moves.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EndSwipeTemplate" aria-label="View EndSwipeTemplate property in API reference">EndSwipeTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template shown on the <code>end</code> swipe side. Commonly used for actions such as delete or more options.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITemplate" aria-label="View FilteringUITemplate property in API reference">FilteringUITemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used for the filtering interface. Supports custom <code>filter</code> layouts and controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITitle" aria-label="View FilteringUITitle property in API reference">FilteringUITitle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Sets the title shown in the filtering interface. Helps identify the active filter view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterSize" aria-label="View FooterSize property in API reference">FooterSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the height of the footer section in pixels. Larger values increase the visible footer area.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render the footer. Useful for summary content or extra controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderColor" aria-label="View GroupHeaderBorderColor property in API reference">GroupHeaderBorderColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Sets the border color used for group headers. Helps distinguish grouped sections visually.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderMargin" aria-label="View GroupHeaderBorderMargin property in API reference">GroupHeaderBorderMargin</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Defines the spacing around the group header border. Useful for fine-tuning header layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderRadius" aria-label="View GroupHeaderBorderRadius property in API reference">GroupHeaderBorderRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Defines the corner rounding for group header borders. Controls the visual style of grouped sections.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderThickness" aria-label="View GroupHeaderBorderThickness property in API reference">GroupHeaderBorderThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Defines the border thickness for group headers. Adjusts the strength of the header outline.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderSize" aria-label="View GroupHeaderSize property in API reference">GroupHeaderSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Sets the height of each group header. Larger values create more space for header content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderTemplate" aria-label="View GroupHeaderTemplate property in API reference">GroupHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render group headers. Supports custom labels, icons, and layouts.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderSize" aria-label="View HeaderSize property in API reference">HeaderSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the height of the header section. Used to control the visible space above list items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render the header section. Useful for title, search, or custom controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading" aria-label="View IsLazyLoading property in API reference">IsLazyLoading</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Indicates whether items are loaded on demand while scrolling. Useful for large data sets and better startup performance.</td>
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
    <td>Collapses every expanded group in the list. This is useful for returning the view to a compact <code>grouped</code> state without changing the underlying data.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseGroup_Syncfusion_Maui_DataSource_GroupResult_" aria-label="View CollapseGroup method in API reference">CollapseGroup(GroupResult)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
    <td>Collapses the specified group represented by <code>GroupResult</code>. The group remains in the data source, but its child <code>items</code> are hidden from view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandAll" aria-label="View ExpandAll method in API reference">ExpandAll()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Expands all collapsed groups in the list. This makes the full <code>hierarchy</code> visible while preserving the current data structure.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandGroup_Syncfusion_Maui_DataSource_GroupResult_" aria-label="View ExpandGroup method in API reference">ExpandGroup(GroupResult)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
    <td>Expands the specified group represented by <code>GroupResult</code>. The group becomes visible again, including its nested <code>items</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshItem_System_Int32_System_Int32_System_Boolean_" aria-label="View RefreshItem method in API reference">RefreshItem(Int32, Int32, Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Refreshes a specific item range in the list. This is useful when the visible <code>item</code> content must be updated after a data change.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView" aria-label="View RefreshView method in API reference">RefreshView()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Refreshes the entire list view. This forces the control to re-evaluate its <code>layout</code>, templates, and visible item state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ResetSwipeItem_System_Boolean_" aria-label="View ResetSwipeItem method in API reference">ResetSwipeItem(Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Resets the currently swiped item to its default position. The <code>Boolean</code> value controls whether the reset is <code>animated</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_" aria-label="View ScrollTo(double, bool) method in API reference">ScrollTo(Double, Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Scrolls to the specified <code>offset</code> in the list. The <code>Boolean</code> value controls whether the movement is <code>animated</code>.</td>
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
    <td>Swipes the specified item by the given <code>offset</code>. This is useful for opening swipe actions or coordinating <code>gesture</code> behavior.</td>
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
    <td>Raised after a group is collapsed. This is useful for updating <code>grouping</code> state or refreshing related UI elements.</td>
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
