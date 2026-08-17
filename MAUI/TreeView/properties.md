---
layout: post
title: Properties of .NET MAUI TreeView control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI TreeView (SfTreeView) control.
platform: maui
control: SfTreeView
documentation: ug
---

# .NET MAUI TreeView API Reference

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AllowDragging" aria-label="View AllowDragging property in API reference">AllowDragging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Enables <code>drag and drop</code> support so nodes can be moved within the tree.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode" aria-label="View AutoExpandMode property in API reference">AutoExpandMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.AutoExpandMode.html" aria-label="View AutoExpandMode enum in API reference">AutoExpandMode</a></td>
<td>Controls when nodes expand automatically by using the <code>AutoExpandMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandOnFilter" aria-label="View AutoExpandOnFilter property in API reference">AutoExpandOnFilter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Expands matching nodes automatically when <code>filtering</code> is applied.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoScroller" aria-label="View AutoScroller property in API reference">AutoScroller</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.AutoScroller.html" aria-label="View AutoScroller type in API reference">AutoScroller</a></td>
<td>Provides automatic scrolling during <code>drag and drop</code> operations.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckActionTarget" aria-label="View CheckActionTarget property in API reference">CheckActionTarget</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckActionTarget.html" aria-label="View TreeViewCheckActionTarget enum in API reference">TreeViewCheckActionTarget</a></td>
<td>Defines where the <code>check</code> action is triggered through the <code>TreeViewCheckActionTarget</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode" aria-label="View CheckBoxMode property in API reference">CheckBoxMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeNodeCheckBoxMode.html" aria-label="View CheckBoxMode enum in API reference">TreeNodeCheckBoxMode</a></td>
<td>Controls how <code>check boxes</code> are shown and updated using the <code>TreeNodeCheckBoxMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxPosition" aria-label="View CheckBoxPosition property in API reference">CheckBoxPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckBoxPosition.html" aria-label="View CheckBoxPosition enum in API reference">TreeViewCheckBoxPosition</a></td>
<td>Specifies the placement of <code>check boxes</code> relative to node content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxWidth" aria-label="View CheckBoxWidth property in API reference">CheckBoxWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width reserved for the <code>check box</code> area of each node.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckedItems" aria-label="View CheckedItems property in API reference">CheckedItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
<td>Stores the collection of items that are currently <code>checked</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ChildPropertyName" aria-label="View ChildPropertyName property in API reference">ChildPropertyName</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property name used to identify child items in hierarchical data.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseCommand" aria-label="View CollapseCommand property in API reference">CollapseCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Runs custom logic when a node is collapsed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CurrentItem" aria-label="View CurrentItem property in API reference">CurrentItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Gets the item that currently has focus in the tree view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_DragAndDropController" aria-label="View DragAndDropController property in API reference">DragAndDropController</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.DragAndDropController.html" aria-label="View DragAndDropController type in API reference">DragAndDropController</a></td>
<td>Defines the controller that manages <code>drag and drop</code> behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_DragItemTemplate" aria-label="View DragItemTemplate property in API reference">DragItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to render an item while it is being dragged.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Specifies the content shown when no tree items are available.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to present the <code>empty view</code> content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableHorizontalScrolling" aria-label="View EnableHorizontalScrolling property in API reference">EnableHorizontalScrolling</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Enables horizontal scrolling for long node content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Turns on the <code>liquid glass</code> visual effect for the tree view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandActionTarget" aria-label="View ExpandActionTarget property in API reference">ExpandActionTarget</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpandActionTarget.html" aria-label="View TreeViewExpandActionTarget enum in API reference">TreeViewExpandActionTarget</a></td>
<td>Defines the area used to expand or collapse a node through the <code>TreeViewExpandActionTarget</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandCommand" aria-label="View ExpandCommand property in API reference">ExpandCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Runs custom logic when a node is expanded.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderPosition" aria-label="View ExpanderPosition property in API reference">ExpanderPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpanderPosition.html" aria-label="View TreeViewExpanderPosition enum in API reference">TreeViewExpanderPosition</a></td>
<td>Controls where the expand and collapse indicator appears.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderTemplate" aria-label="View ExpanderTemplate property in API reference">ExpanderTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used for the expand and collapse indicator.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderWidth" aria-label="View ExpanderWidth property in API reference">ExpanderWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the width reserved for the expander area beside each node.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilteredItems" aria-label="View FilteredItems property in API reference">FilteredItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Gets the items that match the current filter condition.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterMode" aria-label="View FilterMode property in API reference">FilterMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html" aria-label="View TreeViewFilterMode enum in API reference">TreeViewFilterMode</a></td>
<td>Controls how filtering is applied using the <code>TreeViewFilterMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPath" aria-label="View FilterPath property in API reference">FilterPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Defines the property path used to evaluate filter matches.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPaths" aria-label="View FilterPaths property in API reference">FilterPaths</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;string&gt;</a></td>
<td>Defines the collection of property paths used for filtering.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPredicate" aria-label="View FilterPredicate property in API reference">FilterPredicate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.predicate-1" aria-label="View Predicate type in API reference">Predicate&lt;object&gt;</a></td>
<td>Provides custom filter logic that determines which nodes match.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterText" aria-label="View FilterText property in API reference">FilterText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Contains the text used to filter tree nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FullRowSelect" aria-label="View FullRowSelect property in API reference">FullRowSelect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the whole row is selected instead of only the node content.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_HierarchyPropertyDescriptors" aria-label="View HierarchyPropertyDescriptors property in API reference">HierarchyPropertyDescriptors</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.HierarchyPropertyDescriptors.html" aria-label="View HierarchyPropertyDescriptorCollection type in API reference">HierarchyPropertyDescriptorCollection</a></td>
<td>Defines the hierarchy mapping used to build parent-child relationships from data.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Indentation" aria-label="View Indentation property in API reference">Indentation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the space added for each child level in the hierarchy.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_IsAnimationEnabled" aria-label="View IsAnimationEnabled property in API reference">IsAnimationEnabled</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether expand and collapse actions use animation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the height assigned to each tree node.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Defines the data source used to populate the tree view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Defines the template used to render each tree node.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplateContextType" aria-label="View ItemTemplateContextType property in API reference">ItemTemplateContextType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTemplateContextType.html" aria-label="View ItemTemplateContextType enum in API reference">ItemTemplateContextType</a></td>
<td>Defines the template context using the <code>ItemTemplateContextType</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LoadOnDemandCommand" aria-label="View LoadOnDemandCommand property in API reference">LoadOnDemandCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes logic when child items are requested on demand.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LongPressCommand" aria-label="View LongPressCommand property in API reference">LongPressCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes custom behavior when a node receives a long press gesture.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCheckedCommand" aria-label="View NodeCheckedCommand property in API reference">NodeCheckedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Runs logic after a node's <code>checked</code> state changes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodePopulationMode" aria-label="View NodePopulationMode property in API reference">NodePopulationMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeNodePopulationMode.html" aria-label="View TreeNodePopulationMode enum in API reference">TreeNodePopulationMode</a></td>
<td>Controls how nodes are created from the data source using the <code>TreeNodePopulationMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes" aria-label="View Nodes property in API reference">Nodes</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNodeCollection.html" aria-label="View TreeViewNodeCollection type in API reference">TreeViewNodeCollection</a></td>
<td>Gets the generated collection of tree view nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeSizeMode" aria-label="View NodeSizeMode property in API reference">NodeSizeMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewNodeSizeMode.html" aria-label="View TreeViewNodeSizeMode enum in API reference">TreeViewNodeSizeMode</a></td>
<td>Defines how node sizes are calculated using the <code>TreeViewNodeSizeMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NotificationSubscriptionMode" aria-label="View NotificationSubscriptionMode property in API reference">NotificationSubscriptionMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNotificationSubscriptionMode.html" aria-label="View TreeViewNotificationSubscriptionMode enum in API reference">TreeViewNotificationSubscriptionMode</a></td>
<td>Controls how data change notifications are tracked using the <code>TreeViewNotificationSubscriptionMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RightTapCommand" aria-label="View RightTapCommand property in API reference">RightTapCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes custom logic when a node is right tapped.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItem" aria-label="View SelectedItem property in API reference">SelectedItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Gets the currently selected tree node.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItems" aria-label="View SelectedItems property in API reference">SelectedItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
<td>Stores the collection of selected nodes in multi-selection scenarios.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionBackground" aria-label="View SelectionBackground property in API reference">SelectionBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the <code>Brush</code> applied to the background of selected nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionForeground" aria-label="View SelectionForeground property in API reference">SelectionForeground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the <code>Brush</code> applied to the text of selected nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewSelectionMode.html" aria-label="View TreeViewSelectionMode enum in API reference">TreeViewSelectionMode</a></td>
<td>Controls selection behavior using the <code>TreeViewSelectionMode</code> enum.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SortDescriptors" aria-label="View SortDescriptors property in API reference">SortDescriptors</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SortDescriptorCollection.html" aria-label="View SortDescriptorCollection type in API reference">ObservableCollection&lt;SortDescriptors&gt;</a></td>
<td>Defines the collection of sort rules used to order nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_TapCommand" aria-label="View TapCommand property in API reference">TapCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td>Executes custom logic when a node is tapped.</td>
</tr>

</table>

## Methods

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_Syncfusion_TreeView_Engine_TreeViewNode_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_" aria-label="View BringIntoView(TreeViewNode, Boolean, Boolean, ScrollToPosition) method in API reference">BringIntoView(TreeViewNode, Boolean, Boolean, ScrollToPosition)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Scrolls the specified <code>TreeViewNode</code> into view and positions it using the specified <code>ScrollToPosition</code> value. The additional Boolean parameters control the scrolling behavior during the operation.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_System_Object_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_" aria-label="View BringIntoView(Object, Boolean, Boolean, ScrollToPosition) method in API reference">BringIntoView(Object, Boolean, Boolean, ScrollToPosition)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Scrolls the node associated with the specified <code>object</code> into view and aligns it according to the selected <code>ScrollToPosition</code> option.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseAll" aria-label="View CollapseAll method in API reference">CollapseAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses every expanded node in the tree view and returns the hierarchy to a compact state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNode_Syncfusion_TreeView_Engine_TreeViewNode_" aria-label="View CollapseNode method in API reference">CollapseNode(TreeViewNode)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses the specified <code>TreeViewNode</code> while keeping the rest of the tree unchanged.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNodes_System_Int32_" aria-label="View CollapseNodes method in API reference">CollapseNodes(Int32)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses all nodes up to the specified level and preserves deeper levels in their current state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandAll" aria-label="View ExpandAll method in API reference">ExpandAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands every node in the tree view so the full hierarchy becomes visible.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNode_Syncfusion_TreeView_Engine_TreeViewNode_" aria-label="View ExpandNode method in API reference">ExpandNode(TreeViewNode)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands the specified <code>TreeViewNode</code> and reveals its child nodes.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNodes_System_Int32_" aria-label="View ExpandNodes method in API reference">ExpandNodes(Int32)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands nodes up to the specified level to show a controlled portion of the hierarchy.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_GetCheckedNodes" aria-label="View GetCheckedNodes method in API reference">GetCheckedNodes()</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;TreeViewNode&gt;</a></td>
<td>Returns the collection of <code>TreeViewNode</code> items that are currently checked.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshFilter" aria-label="View RefreshFilter method in API reference">RefreshFilter()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Reapplies the active filter and updates the displayed tree items based on the current filter state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshView_System_Boolean_" aria-label="View RefreshView method in API reference">RefreshView(Boolean)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Refreshes the tree view and rebuilds the visible content. The Boolean parameter controls whether the refresh runs with the current tree state preserved.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ResetTreeViewItems" aria-label="View ResetTreeViewItems method in API reference">ResetTreeViewItems(Boolean)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Resets the generated tree items and rebuilds the hierarchy from the current data source. The Boolean parameter controls whether the reset should preserve the existing layout state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectAll" aria-label="View SelectAll method in API reference">SelectAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Selects every item in the tree view when selection mode allows multiple selection.</td>
</tr>

</table>

## Events

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Filtered" aria-label="View Filtered event in API reference">Filtered</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.FilteredEventArgs.html" aria-label="View FilteredEventArgs type in API reference">FilteredEventArgs</a></td>
<td>Raised after filtering completes and the final filtered result is available for processing.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Filtering" aria-label="View Filtering event in API reference">Filtering</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.FilteringEventArgs.html" aria-label="View FilteringEventArgs type in API reference">FilteringEventArgs</a></td>
<td>Raised before filtering begins and allows the filtering operation to be inspected or adjusted.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDoubleTapped" aria-label="View ItemDoubleTapped event in API reference">ItemDoubleTapped</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html" aria-label="View ItemDoubleTappedEventArgs type in API reference">ItemDoubleTappedEventArgs</a></td>
<td>Raised when a tree item receives a <code>double tap</code> gesture.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDragging" aria-label="View ItemDragging event in API reference">ItemDragging</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDraggingEventArgs.html" aria-label="View ItemDraggingEventArgs type in API reference">ItemDraggingEventArgs</a></td>
<td>Raised while a node is being moved through <code>drag and drop</code> interaction.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress" aria-label="View ItemLongPress event in API reference">ItemLongPress</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html" aria-label="View ItemLongPressEventArgs type in API reference">ItemLongPressEventArgs</a></td>
<td>Raised when a tree item receives a sustained press and long-press handling is triggered.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemRightTapped" aria-label="View ItemRightTapped event in API reference">ItemRightTapped</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html" aria-label="View ItemRightTappedEventArgs type in API reference">ItemRightTappedEventArgs</a></td>
<td>Raised when a tree item receives a <code>right tap</code> or context-style gesture.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs</a></td>
<td>Raised when a tree item is tapped and becomes the active interaction target.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_KeyDown" aria-label="View KeyDown event in API reference">KeyDown</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.keyeventargs" aria-label="View KeyEventArgs type in API reference">KeyEventArgs</a></td>
<td>Raised when a keyboard key is pressed while the tree view has focus.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Loaded" aria-label="View Loaded event in API reference">Loaded</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewLoadedEventArgs.html" aria-label="View TreeViewLoadedEventArgs type in API reference">TreeViewLoadedEventArgs</a></td>
<td>Raised after the tree view has finished loading and is ready for interaction.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeChecked" aria-label="View NodeChecked event in API reference">NodeChecked</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html" aria-label="View NodeCheckedEventArgs type in API reference">NodeCheckedEventArgs</a></td>
<td>Raised after a node's <code>checked</code> state changes.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsed" aria-label="View NodeCollapsed event in API reference">NodeCollapsed</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandedCollapsedEventArgs.html" aria-label="View NodeExpandedCollapsedEventArgs type in API reference">NodeExpandedCollapsedEventArgs</a></td>
<td>Raised after a node is collapsed and its child hierarchy is no longer visible.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsing" aria-label="View NodeCollapsing event in API reference">NodeCollapsing</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandingCollapsingEventArgs.html" aria-label="View NodeExpandingCollapsingEventArgs type in API reference">NodeExpandingCollapsingEventArgs</a></td>
<td>Raised before a node collapses and can be used to review or cancel the transition.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanded" aria-label="View NodeExpanded event in API reference">NodeExpanded</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandedCollapsedEventArgs.html" aria-label="View NodeExpandedCollapsedEventArgs type in API reference">NodeExpandedCollapsedEventArgs</a></td>
<td>Raised after a node is expanded and its child hierarchy becomes visible.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanding" aria-label="View NodeExpanding event in API reference">NodeExpanding</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandingCollapsingEventArgs.html" aria-label="View NodeExpandingCollapsingEventArgs type in API reference">NodeExpandingCollapsingEventArgs</a></td>
<td>Raised before a node expands and can be used to control the expansion flow.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_QueryNodeSize" aria-label="View QueryNodeSize event in API reference">QueryNodeSize</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html" aria-label="View QueryNodeSizeEventArgs type in API reference">QueryNodeSizeEventArgs</a></td>
<td>Raised when the size of a node is requested for layout measurement.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemSelectionChangedEventArgs.html" aria-label="View ItemSelectionChangedEventArgs type in API reference">ItemSelectionChangedEventArgs</a></td>
<td>Raised after the selected nodes have changed and the new selection is available.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemSelectionChangingEventArgs.html" aria-label="View ItemSelectionChangingEventArgs type in API reference">ItemSelectionChangingEventArgs</a></td>
<td>Raised before the selection changes and can be used to validate or cancel the update.</td>
</tr>

</table>