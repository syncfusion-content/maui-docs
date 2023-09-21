---
layout: post
title: Migrate from Xamarin SfTreeView to .NET MAUI SfTreeView | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin TreeView to Syncfusion .NET MAUI TreeView control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---  

# Migrate from Xamarin.Forms SfTreeView to .NET MAUI SfTreeView 

To migrate easier from [Xamarin SfTreeView](https://www.syncfusion.com/xamarin-ui-controls/xamarin-treeview) to [.NET MAUI SfTreeView](https://www.syncfusion.com/maui-controls/maui-treeview), we kept most of the APIs from Xamarin SfTreeView in MAUI SfTreeView. However, to maintain the consistency of API naming in MAUI SfTreeView, we renamed some of the APIs. The APIs that have been changed in MAUI SfTreeView from Xamarin SfTreeView are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th></tr>
<tr>
<td>Syncfusion.XForms.TreeView</td>
<td>Syncfusion.Maui.TreeView</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[HoldCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_HoldCommand)'| markdownify }}</td>
<td>{{[LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LongPressCommand)| markdownify }}</td>
<td>Gets or sets System.Windows.Input.ICommand which will be executed when hold on the TreeViewItem.</td></tr>
<tr>
<td>{{'[IsScrollBarVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_IsScrollBarVisible)'| markdownify }}</td>
<td>{{[ScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ScrollBarVisibility)| markdownify }}</td>
<td>Gets or sets a value indicating whether or not the scrollbar should be displayed.</td></tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_SelectionBackgroundColor)' | markdownify }}</td>
<td>{{[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionBackground)| markdownify }}</td>
<td>Gets or sets the selection background color for the selected item.</td></tr>
<tr>
<td>{{'[SelectionForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_SelectionForegroundColor)'| markdownify }}</td>
<td>{{[SelectionForeground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionForeground)| markdownify }}</td>
<td>Gets or sets the selected item foreground color. Note: It will applicable for unbound mode only.</td>
</tr>
</table> 

## Enums

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ItemType.html)'| markdownify }}</td>
<td>{{[TreeViewItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewItemType.html)| markdownify }}</td>
<td>Defines the item type for the TreeViewItemInfoBase.</td></tr>
<tr>
<td>{{'[ExpandActionTarget](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ExpandActionTarget.html)'| markdownify }}</td>
<td>{{[TreeViewExpandActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpandActionTarget.html)| markdownify }}</td>
<td>Defines that the expanding and collapsing of nodes can be performed only by tapping in expander view or in both expander view and content view.</td></tr>
<tr>
<td>{{'[ExpanderPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ExpanderPosition.html)'| markdownify }}</td>
<td>{{[TreeViewExpanderPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpanderPosition.html)| markdownify }}</td>
<td>Defines the expander position of the SfTreeView. The expander can be positioned either start or end of the item.</td></tr>
<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SelectionMode.html)'| markdownify }}</td>
<td>{{[TreeViewSelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewSelectionMode.html)| markdownify }}</td>
<td>Defines constants that specify the selections that are supported by a SfTreeView control.</td></tr>
<tr>
<td>{{'[AutoExpandMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.TreeView.Engine.AutoExpandMode.html)'| markdownify }}</td>
<td>{{[TreeViewAutoExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode)| markdownify }}</td>
<td>Defines the possible expand modes while loading the nodes in the SfTreeView.</td></tr>
<tr>
<td>{{'[NotificationSubscriptionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.TreeView.Engine.NotificationSubscriptionMode.html)'| markdownify }}</td>
<td>{{[TreeViewNotificationSubscriptionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NotificationSubscriptionMode)| markdownify }}</td>
<td>Defines the constants that specify whether need to listen the PropertyChanging and `System.ComponentModel.INotifyPropertyChanged.PropertyChanged` events of data object and `System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged` event of source collection.</td></tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemHolding](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_ItemHolding)'| markdownify }}</td>
<td>{{[ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress)| markdownify }}</td>
<td>Occurs when the TreeViewItem's ContentView is long pressed.</td></tr>
</table> 

## Upcoming features

  * Animation
  * Checkbox
  * LoadOnDemand
