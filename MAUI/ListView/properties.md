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
    <td>Lets users <code>tap</code> group headers to show or hide the items in grouped ListView sections.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AllowSwiping" aria-label="View AllowSwiping property in API reference">AllowSwiping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Lets users <code>swipe</code> list items to reveal the actions supplied by the <code>StartSwipeTemplate</code> or <code>EndSwipeTemplate</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoFitMode" aria-label="View AutoFitMode property in API reference">AutoFitMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.AutoFitMode.html" aria-label="View AutoFitMode enum in API reference">AutoFitMode</a></td>
    <td>Uses <code>None</code> to keep <code>ItemSize</code>, <code>Height</code> to size items from their initial content, or <code>DynamicHeight</code> to resize them when their content changes. In a <code>horizontal</code> layout, the modes measure <code>width</code> instead of <code>height</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_AutoScroller" aria-label="View AutoScroller property in API reference">AutoScroller</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.AutoScroller.html" aria-label="View AutoScroller type in API reference">AutoScroller</a></td>
    <td>Provides the <code>auto-scroll</code> settings used when an item is dragged near the ListView's <code>leading</code> or <code>trailing</code> edge.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CachingStrategy" aria-label="View CachingStrategy property in API reference">CachingStrategy</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.CachingStrategy.html" aria-label="View CachingStrategy enum in API reference">CachingStrategy</a></td>
    <td>Uses <code>RecycleTemplate</code> to reuse item templates with updated binding contexts or <code>CreateNewTemplate</code> to create new template content when an item container is reused.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CanMaintainScrollPosition" aria-label="View CanMaintainScrollPosition property in API reference">CanMaintainScrollPosition</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Keeps the current <code>scroll</code> position when <code>ItemsSource</code> is replaced, preventing the ListView from jumping back to another position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CurrentItem" aria-label="View CurrentItem property in API reference">CurrentItem</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Selects the specified data item or provides the item that is currently <code>selected</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DataSource" aria-label="View DataSource property in API reference">DataSource</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DataSource.html" aria-label="View DataSource type in API reference">DataSource</a></td>
    <td>Supplies the <code>data view</code> and its <code>sorting</code>, <code>grouping</code>, and <code>filtering</code> operations to the ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DisplayMemberPath" aria-label="View DisplayMemberPath property in API reference">DisplayMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Identifies the data field displayed as text when no <code>ItemTemplate</code> is supplied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragDropController" aria-label="View DragDropController property in API reference">DragDropController</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DragDropController.html" aria-label="View DragDropController type in API reference">DragDropController</a></td>
    <td>Replaces the default <code>drag-and-drop</code> controller so item <code>reordering</code> and <code>drop</code> behavior can be customized.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragItemTemplate" aria-label="View DragItemTemplate property in API reference">DragItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the visual <code>preview</code> displayed while a ListView item is being dragged.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_DragStartMode" aria-label="View DragStartMode property in API reference">DragStartMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.DragStartMode.html" aria-label="View DragStartMode enum in API reference">DragStartMode</a></td>
    <td>Uses <code>OnHold</code> to begin dragging after an item is held, <code>OnDragIndicator</code> to begin from a <code>DragIndicatorView</code>, or <code>None</code> to disable dragging.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Displays the supplied <code>text</code>, <code>view</code>, or other content when the ListView contains no items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines a reusable custom <code>layout</code> for the content supplied through <code>EmptyView</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EnableFadeOnScroll" aria-label="View EnableFadeOnScroll property in API reference">EnableFadeOnScroll</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Fades list items as the user <code>scrolls</code> the ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_EndSwipeTemplate" aria-label="View EndSwipeTemplate property in API reference">EndSwipeTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Displays custom actions when an item is swiped <code>right</code> in a vertical ListView or <code>down</code> in a horizontal ListView. <code>AllowSwiping</code> must be enabled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITemplate" aria-label="View FilteringUITemplate property in API reference">FilteringUITemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the built-in filtering <code>popup</code> content with a custom layout bound to the filtering <code>view model</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FilteringUITitle" aria-label="View FilteringUITitle property in API reference">FilteringUITitle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Sets the <code>title</code> displayed in the filtering popup used with <code>FilteringUITemplate</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterSize" aria-label="View FooterSize property in API reference">FooterSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the footer's <code>height</code> in a vertical ListView or <code>width</code> in a horizontal ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_FooterTemplate" aria-label="View FooterTemplate property in API reference">FooterTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Displays custom content <code>after</code> the ListView items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderColor" aria-label="View GroupHeaderBorderColor property in API reference">GroupHeaderBorderColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Applies the specified <code>color</code> to the border around each group header.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderMargin" aria-label="View GroupHeaderBorderMargin property in API reference">GroupHeaderBorderMargin</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Controls the outer <code>spacing</code> around the border of each group header.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderRadius" aria-label="View GroupHeaderBorderRadius property in API reference">GroupHeaderBorderRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Controls the corner <code>rounding</code> of each group-header border.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderBorderThickness" aria-label="View GroupHeaderBorderThickness property in API reference">GroupHeaderBorderThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Controls the <code>thickness</code> of the border on each side of a group header.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderSize" aria-label="View GroupHeaderSize property in API reference">GroupHeaderSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls each group header's <code>height</code> in a vertical ListView or <code>width</code> in a horizontal ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupHeaderTemplate" aria-label="View GroupHeaderTemplate property in API reference">GroupHeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the custom <code>content</code> displayed for each grouped section's header.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderSize" aria-label="View HeaderSize property in API reference">HeaderSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the header's <code>height</code> in a vertical ListView or <code>width</code> in a horizontal ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_HeaderTemplate" aria-label="View HeaderTemplate property in API reference">HeaderTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Displays custom content <code>before</code> the ListView items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_IsLazyLoading" aria-label="View IsLazyLoading property in API reference">IsLazyLoading</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Keeps the <code>load-more</code> indicator visible while additional items are being loaded; clear it when the loading operation finishes.</td>
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
    <td>Collapses every expanded <code>group</code>, hiding all group items without changing the data source.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_CollapseGroup_Syncfusion_Maui_DataSource_GroupResult_" aria-label="View CollapseGroup method in API reference">CollapseGroup(GroupResult)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
    <td>Collapses the specified <code>group</code> and hides its items without removing them from the data source.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandAll" aria-label="View ExpandAll method in API reference">ExpandAll()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Expands every collapsed group so all grouped items become <code>visible</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ExpandGroup_Syncfusion_Maui_DataSource_GroupResult_" aria-label="View ExpandGroup method in API reference">ExpandGroup(GroupResult)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataSource.GroupResult.html" aria-label="View GroupResult type in API reference">GroupResult</a></td>
    <td>Expands the specified <code>group</code> so its items become visible.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshItem_System_Int32_System_Int32_System_Boolean_" aria-label="View RefreshItem method in API reference">RefreshItem(Int32, Int32, Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Refreshes one item, an inclusive <code>range</code> of items, or all items; it can also recreate the affected item templates when their visual structure has changed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_RefreshView" aria-label="View RefreshView method in API reference">RefreshView()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Refreshes the entire ListView so its displayed items and <code>layout</code> are recalculated.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ResetSwipeItem_System_Boolean_" aria-label="View ResetSwipeItem method in API reference">ResetSwipeItem(Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Moves the currently swiped item back to its normal position, optionally <code>animating</code> the reset.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Double_System_Boolean_" aria-label="View ScrollTo(double, bool) method in API reference">ScrollTo(Double, Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Scrolls to the specified vertical <code>offset</code> in a vertical ListView or horizontal <code>offset</code> in a horizontal ListView. The movement can be performed without <code>animation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollTo_System_Object_Microsoft_Maui_Controls_ScrollToPosition_System_Boolean_" aria-label="View ScrollTo(object, ScrollToPosition, bool) method in API reference">ScrollTo(Object, ScrollToPosition, Boolean)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Brings the specified item to the <code>leading</code> edge with <code>Start</code>, the <code>middle</code> with <code>Center</code>, the <code>trailing</code> edge with <code>End</code>, or the <code>nearest</code> visible position with <code>MakeVisible</code>. The movement can be performed without <code>animation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectAll" aria-label="View SelectAll method in API reference">SelectAll()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Selects every item in the ListView; use it when the <code>selection mode</code> supports multiple items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeItem_System_Object_System_Double_" aria-label="View SwipeItem method in API reference">SwipeItem(Object, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View void type in API reference">void</a></td>
    <td>Moves the specified item to a swipe offset, revealing the <code>start</code> side with a <code>positive</code> offset and the <code>end</code> side with a <code>negative</code> offset.</td>
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
    <td>Triggered <code>after</code> one or more groups collapse and their items are hidden.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupCollapsing" aria-label="View GroupCollapsing event in API reference">GroupCollapsing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> one or more groups collapse, allowing the collapse action to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanded" aria-label="View GroupExpanded event in API reference">GroupExpanded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangedEventArgs.html" aria-label="View GroupExpandCollapseChangedEventArgs type in API reference">GroupExpandCollapseChangedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> one or more groups expand and their items become visible.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_GroupExpanding" aria-label="View GroupExpanding event in API reference">GroupExpanding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.GroupExpandCollapseChangingEventArgs.html" aria-label="View GroupExpandCollapseChangingEventArgs type in API reference">GroupExpandCollapseChangingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> one or more groups expand, allowing the expansion action to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemAppearing" aria-label="View ItemAppearing event in API reference">ItemAppearing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemAppearingEventArgs.html" aria-label="View ItemAppearingEventArgs type in API reference">ItemAppearingEventArgs&gt;</a></a></td>
    <td>Triggered when an item enters the <code>visible area</code> of the ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDisappearing" aria-label="View ItemDisappearing event in API reference">ItemDisappearing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDisappearingEventArgs.html" aria-label="View ItemDisappearingEventArgs type in API reference">ItemDisappearingEventArgs&gt;</a></a></td>
    <td>Triggered when an item leaves the <code>visible area</code> of the ListView.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDragging" aria-label="View ItemDragging event in API reference">ItemDragging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDraggingEventArgs.html" aria-label="View ItemDraggingEventArgs type in API reference">ItemDraggingEventArgs&gt;</a></a></td>
    <td>Triggered throughout an item <code>drag-and-drop</code> operation, reporting its <code>drag phase</code> and allowing the reordering action to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemDoubleTapped" aria-label="View ItemDoubleTapped event in API reference">ItemDoubleTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemDoubleTappedEventArgs.html" aria-label="View ItemDoubleTappedEventArgs type in API reference">ItemDoubleTappedEventArgs&gt;</a></a></td>
    <td>Triggered when a ListView item is <code>double-tapped</code>, providing the item and its position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemLongPress" aria-label="View ItemLongPress event in API reference">ItemLongPress</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemLongPressEventArgs.html" aria-label="View ItemLongPressEventArgs type in API reference">ItemLongPressEventArgs&gt;</a></a></td>
    <td>Triggered when the user presses and holds a ListView item, providing the pressed item and its position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemRightTapped" aria-label="View ItemRightTapped event in API reference">ItemRightTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemRightTappedEventArgs.html" aria-label="View ItemRightTappedEventArgs type in API reference">ItemRightTappedEventArgs&gt;</a></a></td>
    <td>Triggered when the user <code>right-clicks</code> a ListView item, providing the item and its position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs&gt;</a></a></td>
    <td>Triggered when the user <code>taps</code> a ListView item, providing the tapped item and its position.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Loaded" aria-label="View Loaded event in API reference">Loaded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ListViewLoadedEventArgs.html" aria-label="View ListViewLoadedEventArgs type in API reference">ListViewLoadedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the ListView is loaded for the <code>first time</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_QueryItemSize" aria-label="View QueryItemSize event in API reference">QueryItemSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.QueryItemSizeEventArgs.html" aria-label="View QueryItemSizeEventArgs type in API reference">QueryItemSizeEventArgs&gt;</a></a></td>
    <td>Triggered when an item comes into view, allowing a custom <code>height</code> in a vertical ListView or <code>width</code> in a horizontal ListView to be applied by marking the size as <code>handled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ScrollStateChanged" aria-label="View ScrollStateChanged event in API reference">ScrollStateChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ScrollStateChangedEventArgs.html" aria-label="View ScrollStateChangedEventArgs type in API reference">ScrollStateChangedEventArgs&gt;</a></a></td>
    <td>Triggered when scrolling changes between states such as <code>dragging</code>, <code>flinging</code>, and <code>idle</code>. Supported on <code>Android API level 23</code> or later.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangedEventArgs.html" aria-label="View ItemSelectionChangedEventArgs type in API reference">ItemSelectionChangedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> item selection changes, providing the items <code>added</code> to and <code>removed</code> from the selection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs.html" aria-label="View ItemSelectionChangingEventArgs type in API reference">ItemSelectionChangingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> item selection changes, allowing the pending selection or deselection to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeEnded" aria-label="View SwipeEnded event in API reference">SwipeEnded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeEndedEventArgs.html" aria-label="View SwipeEndedEventArgs type in API reference">SwipeEndedEventArgs&gt;</a></a></td>
    <td>Triggered when an item <code>swipe</code> finishes, providing the swiped item, direction, and final offset.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeReset" aria-label="View SwipeReset event in API reference">SwipeReset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.ResetSwipeEventArgs.html" aria-label="View ResetSwipeEventArgs type in API reference">ResetSwipeEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> a swiped item returns to its normal position, allowing the reset to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SwipeStarting" aria-label="View SwipeStarting event in API reference">SwipeStarting</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipeStartingEventArgs.html" aria-label="View SwipeStartingEventArgs type in API reference">SwipeStartingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> an item begins swiping, allowing the swipe action to be <code>canceled</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_Swiping" aria-label="View Swiping event in API reference">Swiping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SwipingEventArgs.html" aria-label="View SwipingEventArgs type in API reference">SwipingEventArgs&gt;</a></a></td>
    <td>Triggered <code>repeatedly</code> while an item is being swiped; marking it <code>handled</code> holds the item at the current offset until <code>SwipeEnded</code>.</td>
</tr>
</table>

