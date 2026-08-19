---
layout: post
title: Properties of .NET MAUI TreeView control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI TreeView (SfTreeView) control.
platform: maui
control: SfTreeView
documentation: ug
---

# API Reference for .NET MAUI TreeView

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
<td>Enables <code>drag-and-drop</code> interaction so <code>nodes</code> can be rearranged within the tree view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode" aria-label="View AutoExpandMode property in API reference">AutoExpandMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.AutoExpandMode.html" aria-label="View AutoExpandMode enum in API reference">AutoExpandMode</a></td>
<td>Controls when <code>nodes</code> expand automatically. Choose a supported <code>AutoExpandMode</code> value such as <code>None</code>, <code>RootNodeExpanded</code>, or <code>AllNodesExpanded</code> to set the desired default behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandOnFilter" aria-label="View AutoExpandOnFilter property in API reference">AutoExpandOnFilter</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Controls whether <code>nodes</code> that match the active <code>filter</code> are expanded automatically.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoScroller" aria-label="View AutoScroller property in API reference">AutoScroller</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.AutoScroller.html" aria-label="View AutoScroller type in API reference">AutoScroller</a></td>
<td>Provides <code>automatic scrolling</code> of the viewport during <code>drag-and-drop</code> operations when a <code>node</code> is dragged near the edges of the visible area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckActionTarget" aria-label="View CheckActionTarget property in API reference">CheckActionTarget</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckActionTarget.html" aria-label="View TreeViewCheckActionTarget enum in API reference">TreeViewCheckActionTarget</a></td>
<td>Defines where the <code>check</code> action is accepted on a <code>node</code>. Choose a supported <code>TreeViewCheckActionTarget</code> value such as <code>Node</code> or <code>Row</code> to control where a tap toggles the checkbox.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxMode" aria-label="View CheckBoxMode property in API reference">CheckBoxMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeNodeCheckBoxMode.html" aria-label="View CheckBoxMode enum in API reference">TreeNodeCheckBoxMode</a></td>
<td>Controls how <code>check boxes</code> appear and update on each <code>node</code>. Choose a supported <code>TreeNodeCheckBoxMode</code> value such as <code>Individual</code> or <code>Recursive</code> to define selection behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxPosition" aria-label="View CheckBoxPosition property in API reference">CheckBoxPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewCheckBoxPosition.html" aria-label="View CheckBoxPosition enum in API reference">TreeViewCheckBoxPosition</a></td>
<td>Places the <code>check box</code> at the <code>start</code> or <code>end</code> of each node content area.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckBoxWidth" aria-label="View CheckBoxWidth property in API reference">CheckBoxWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td><code>Width</code> reserved for the <code>check box</code> area of each <code>node</code>. Larger values give the checkbox more horizontal space.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CheckedItems" aria-label="View CheckedItems property in API reference">CheckedItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
<td>Collection of items that are currently <code>checked</code>. Changes to this collection update the underlying <code>node</code> state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ChildPropertyName" aria-label="View ChildPropertyName property in API reference">ChildPropertyName</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Property name of the underlying <code>data item</code> that holds its <code>children</code>. Required when binding <code>hierarchical data</code> without a custom node population mode.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseCommand" aria-label="View CollapseCommand property in API reference">CollapseCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> that runs when a <code>node</code> is <code>collapsed</code>. Use this to extend or react to the default collapse behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CurrentItem" aria-label="View CurrentItem property in API reference">CurrentItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Item that currently holds <code>keyboard focus</code> within the tree view.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_DragAndDropController" aria-label="View DragAndDropController property in API reference">DragAndDropController</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.DragAndDropController.html" aria-label="View DragAndDropController type in API reference">DragAndDropController</a></td>
<td>Custom <code>controller</code> that manages <code>drag-and-drop</code> behavior. Override its members to customize <code>drag validation</code>, <code>drop indicators</code>, and <code>item movement</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_DragItemTemplate" aria-label="View DragItemTemplate property in API reference">DragItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Template used to render the <code>node</code> while it is being <code>dragged</code>. Use this to customize the <code>drag preview</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyView" aria-label="View EmptyView property in API reference">EmptyView</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Content shown when the tree view has no <code>items</code> to display.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EmptyViewTemplate" aria-label="View EmptyViewTemplate property in API reference">EmptyViewTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Template used to present the <code>empty view</code> content. Supports richer <code>layouts</code> for the empty state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableHorizontalScrolling" aria-label="View EnableHorizontalScrolling property in API reference">EnableHorizontalScrolling</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Controls whether the tree view can scroll <code>horizontally</code> when node content exceeds the available <code>width</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Applies the <code>Liquid Glass effect</code> to the tree view when it is placed inside an <code>SfGlassEffectView</code>. Supported on <code>iOS 13.0</code> or later and <code>macOS 10.15</code> or later with <code>.NET 8</code> or later.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandActionTarget" aria-label="View ExpandActionTarget property in API reference">ExpandActionTarget</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpandActionTarget.html" aria-label="View TreeViewExpandActionTarget enum in API reference">TreeViewExpandActionTarget</a></td>
<td>Defines the <code>area</code> used to expand or collapse a <code>node</code>. Choose a supported <code>TreeViewExpandActionTarget</code> value such as <code>Node</code> or <code>Expander</code> to control where taps trigger expansion.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandCommand" aria-label="View ExpandCommand property in API reference">ExpandCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> that runs when a <code>node</code> is <code>expanded</code>. Use this to extend or react to the default expand behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderPosition" aria-label="View ExpanderPosition property in API reference">ExpanderPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpanderPosition.html" aria-label="View TreeViewExpanderPosition enum in API reference">TreeViewExpanderPosition</a></td>
<td>Places the <code>expand</code> and <code>collapse</code> indicator at the <code>start</code> or <code>end</code> of each <code>node</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderTemplate" aria-label="View ExpanderTemplate property in API reference">ExpanderTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Template used to render the <code>expand</code> and <code>collapse</code> indicator. Use this to replace the default <code>expander icon</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpanderWidth" aria-label="View ExpanderWidth property in API reference">ExpanderWidth</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td><code>Width</code> reserved for the <code>expand</code> and <code>collapse</code> indicator area beside each <code>node</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilteredItems" aria-label="View FilteredItems property in API reference">FilteredItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
<td>Items that match the current <code>filter condition</code>. Returns the visible <code>nodes</code> after filtering is applied.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterMode" aria-label="View FilterMode property in API reference">FilterMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewFilterMode.html" aria-label="View TreeViewFilterMode enum in API reference">TreeViewFilterMode</a></td>
<td>Controls how <code>filtering</code> evaluates <code>nodes</code>. Choose a supported <code>TreeViewFilterMode</code> value such as <code>StartsWith</code> or <code>Contains</code> to set the comparison behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPath" aria-label="View FilterPath property in API reference">FilterPath</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Property path on the <code>data item</code> that is evaluated when <code>filtering nodes</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPaths" aria-label="View FilterPaths property in API reference">FilterPaths</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList type in API reference">IList&lt;string&gt;</a></td>
<td>Collection of property paths used for <code>filtering</code>. Multiple paths allow filtering across several <code>fields</code> of the data item.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterPredicate" aria-label="View FilterPredicate property in API reference">FilterPredicate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.predicate-1" aria-label="View Predicate type in API reference">Predicate&lt;object&gt;</a></td>
<td>Custom <code>predicate</code> that determines which <code>nodes</code> match the <code>filter</code>. Provide this for full control over the filter logic.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FilterText" aria-label="View FilterText property in API reference">FilterText</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
<td>Text used to <code>filter tree nodes</code>. Updating this value reapplies the filter against the configured <code>path</code> or <code>predicate</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_FullRowSelect" aria-label="View FullRowSelect property in API reference">FullRowSelect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Controls whether the entire <code>row</code> is selected on <code>tap</code> instead of only the <code>node content</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_HierarchyPropertyDescriptors" aria-label="View HierarchyPropertyDescriptors property in API reference">HierarchyPropertyDescriptors</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.HierarchyPropertyDescriptors.html" aria-label="View HierarchyPropertyDescriptorCollection type in API reference">HierarchyPropertyDescriptorCollection</a></td>
<td>Maps properties on the <code>data item</code> to tree <code>hierarchy fields</code>. Required when binding hierarchical data with custom property names.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Indentation" aria-label="View Indentation property in API reference">Indentation</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Horizontal <code>space</code> added for each <code>child level</code> in hierarchy. Larger values indent deeper levels more strongly.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_IsAnimationEnabled" aria-label="View IsAnimationEnabled property in API reference">IsAnimationEnabled</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Controls whether <code>expand</code> and <code>collapse transitions</code> are <code>animated</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td><code>Height</code> assigned to each tree <code>node</code>. Applies when the <code>node size mode</code> uses a fixed height.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td><code>Data source</code> used to populate the tree view. Bind this to a <code>collection</code> or <code>hierarchical model</code> to generate nodes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
<td>Template used to render each tree <code>node</code>.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTemplateContextType" aria-label="View ItemTemplateContextType property in API reference">ItemTemplateContextType</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTemplateContextType.html" aria-label="View ItemTemplateContextType enum in API reference">ItemTemplateContextType</a></td>
<td>Defines the <code>binding context</code> available inside the <code>item template</code>. Choose a supported <code>ItemTemplateContextType</code> value such as <code>Node</code> or <code>DataItem</code> to expose the corresponding data.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LoadOnDemandCommand" aria-label="View LoadOnDemandCommand property in API reference">LoadOnDemandCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> executed when <code>child items</code> are requested on <code>demand</code>. Use this to load children lazily when a <code>node</code> expands.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LongPressCommand" aria-label="View LongPressCommand property in API reference">LongPressCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> executed when a <code>node</code> receives a <code>long-press</code> gesture. Use this for context-aware operations.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCheckedCommand" aria-label="View NodeCheckedCommand property in API reference">NodeCheckedCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> executed after a <code>node's</code> <code>checked state</code> changes. The command receives the current node state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodePopulationMode" aria-label="View NodePopulationMode property in API reference">NodePopulationMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeNodePopulationMode.html" aria-label="View TreeNodePopulationMode enum in API reference">TreeNodePopulationMode</a></td>
<td>Controls how <code>nodes</code> are generated from the <code>data source</code>. Choose a supported <code>TreeNodePopulationMode</code> value such as <code>Default</code> or <code>OnDemand</code> to control when children are created.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Nodes" aria-label="View Nodes property in API reference">Nodes</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNodeCollection.html" aria-label="View TreeViewNodeCollection type in API reference">TreeViewNodeCollection</a></td>
<td>Generated collection of tree view <code>nodes</code>. Updates automatically when the <code>data source</code> changes.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeSizeMode" aria-label="View NodeSizeMode property in API reference">NodeSizeMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewNodeSizeMode.html" aria-label="View TreeViewNodeSizeMode enum in API reference">TreeViewNodeSizeMode</a></td>
<td>Defines how <code>node sizes</code> are calculated. Choose a supported <code>TreeViewNodeSizeMode</code> value such as <code>Fixed</code> or <code>AutoFit</code> to control height behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NotificationSubscriptionMode" aria-label="View NotificationSubscriptionMode property in API reference">NotificationSubscriptionMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNotificationSubscriptionMode.html" aria-label="View TreeViewNotificationSubscriptionMode enum in API reference">TreeViewNotificationSubscriptionMode</a></td>
<td>Controls how the tree view tracks <code>data change notifications</code> from bound items. Choose a supported <code>TreeViewNotificationSubscriptionMode</code> value such as <code>Default</code> or <code>CollectionView</code> to control update propagation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RightTapCommand" aria-label="View RightTapCommand property in API reference">RightTapCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> executed when a <code>node</code> is <code>right-tapped</code>. Use this to surface <code>context-style</code> actions.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItem" aria-label="View SelectedItem property in API reference">SelectedItem</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
<td>Node that is currently <code>selected</code>. Bind to this to react to selection in <code>single-selection</code> scenarios.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectedItems" aria-label="View SelectedItems property in API reference">SelectedItems</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.collections.objectmodel.observablecollection-1" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;object&gt;</a></td>
<td>Collection of <code>selected nodes</code>. Used in <code>multi-selection</code> scenarios to track the active set.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionBackground" aria-label="View SelectionBackground property in API reference">SelectionBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td><code>Brush</code> applied to the <code>background</code> of <code>selected nodes</code> to indicate the selection state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionForeground" aria-label="View SelectionForeground property in API reference">SelectionForeground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td><code>Brush</code> applied to the <code>text</code> or <code>content</code> of <code>selected nodes</code> to indicate the selection state.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionMode" aria-label="View SelectionMode property in API reference">SelectionMode</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewSelectionMode.html" aria-label="View TreeViewSelectionMode enum in API reference">TreeViewSelectionMode</a></td>
<td>Controls how <code>nodes</code> are <code>selected</code>. Choose a supported <code>TreeViewSelectionMode</code> value such as <code>Single</code>, <code>Multiple</code>, or <code>None</code> to control selection behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SortDescriptors" aria-label="View SortDescriptors property in API reference">SortDescriptors</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SortDescriptorCollection.html" aria-label="View SortDescriptorCollection type in API reference">ObservableCollection&lt;SortDescriptors&gt;</a></td>
<td>Collection of <code>sort rules</code> applied to <code>nodes</code>. Used to order nodes within each level.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_TapCommand" aria-label="View TapCommand property in API reference">TapCommand</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
<td><code>Command</code> executed when a <code>node</code> is <code>tapped</code>. Use this to react to common tap interactions.</td>
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
<td>Brings the specified <code>TreeViewNode</code> into the <code>visible area</code> and aligns it according to the selected <code>ScrollToPosition</code> option. If the node is already visible, the scroll position remains unchanged.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_BringIntoView_System_Object_System_Boolean_System_Boolean_Microsoft_Maui_Controls_ScrollToPosition_" aria-label="View BringIntoView(Object, Boolean, Boolean, ScrollToPosition) method in API reference">BringIntoView(Object, Boolean, Boolean, ScrollToPosition)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Brings the node associated with the specified <code>data object</code> into the <code>visible area</code> and aligns it according to the selected <code>ScrollToPosition</code> option. If the node is already visible, the scroll position remains unchanged.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseAll" aria-label="View CollapseAll method in API reference">CollapseAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses every <code>expanded node</code> in the tree view, returning the hierarchy to a compact state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNode_Syncfusion_TreeView_Engine_TreeViewNode_" aria-label="View CollapseNode method in API reference">CollapseNode(TreeViewNode)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses the specified <code>TreeViewNode</code> while leaving the rest of the tree unchanged.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_CollapseNodes_System_Int32_" aria-label="View CollapseNodes method in API reference">CollapseNodes(Int32)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Collapses all nodes down to the specified <code>level</code>, leaving deeper levels in their current state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandAll" aria-label="View ExpandAll method in API reference">ExpandAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands every <code>node</code> in the tree view so the full <code>hierarchy</code> becomes visible.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNode_Syncfusion_TreeView_Engine_TreeViewNode_" aria-label="View ExpandNode method in API reference">ExpandNode(TreeViewNode)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands the specified <code>TreeViewNode</code> and reveals its <code>child nodes</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ExpandNodes_System_Int32_" aria-label="View ExpandNodes method in API reference">ExpandNodes(Int32)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Expands nodes from the <code>root</code> down to the specified <code>level</code> to reveal a controlled portion of the hierarchy.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_GetCheckedNodes" aria-label="View GetCheckedNodes method in API reference">GetCheckedNodes()</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.TreeView.Engine.TreeViewNode.html" aria-label="View ObservableCollection type in API reference">ObservableCollection&lt;TreeViewNode&gt;</a></td>
<td>Returns the collection of <code>TreeViewNode</code> items that are currently <code>checked</code>. The collection reflects the current checked state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshFilter" aria-label="View RefreshFilter method in API reference">RefreshFilter()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Reapplies the active <code>filter</code> against the current <code>data</code> and updates the visible <code>nodes</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_RefreshView_System_Boolean_" aria-label="View RefreshView method in API reference">RefreshView(Boolean)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Refreshes the tree view and rebuilds the visible <code>nodes</code>. The <code>Boolean</code> parameter controls whether the existing tree state is preserved.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ResetTreeViewItems" aria-label="View ResetTreeViewItems method in API reference">ResetTreeViewItems(Boolean)</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Resets the generated tree <code>items</code> and rebuilds the <code>hierarchy</code> from the current <code>data source</code>. The <code>Boolean</code> parameter controls whether the <code>layout state</code> is preserved.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectAll" aria-label="View SelectAll method in API reference">SelectAll()</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
<td>Selects every <code>item</code> in the tree view when the current <code>SelectionMode</code> allows <code>multiple selection</code>. Has no effect in <code>single-selection</code> mode.</td>
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
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.FilteredEventArgs.html" aria-label="View FilteredEventArgs type in API reference">FilteredEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> <code>filtering</code> completes, providing the final <code>filtered result</code> for further processing.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Filtering" aria-label="View Filtering event in API reference">Filtering</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.FilteringEventArgs.html" aria-label="View FilteringEventArgs type in API reference">FilteringEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> <code>filtering</code> starts, allowing you to inspect or adjust the operation before <code>nodes</code> are evaluated.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDoubleTapped" aria-label="View ItemDoubleTapped event in API reference">ItemDoubleTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDoubleTappedEventArgs.html" aria-label="View ItemDoubleTappedEventArgs type in API reference">ItemDoubleTappedEventArgs&gt;</a></a></td>
<td>Triggered when a tree item is <code>double-tapped</code>, providing details about the tapped <code>node</code> and <code>gesture</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemDragging" aria-label="View ItemDragging event in API reference">ItemDragging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemDraggingEventArgs.html" aria-label="View ItemDraggingEventArgs type in API reference">ItemDraggingEventArgs&gt;</a></a></td>
<td>Triggered while a <code>node</code> is being moved through <code>drag-and-drop</code>, allowing you to control the <code>drag preview</code> and <code>drop behavior</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress" aria-label="View ItemLongPress event in API reference">ItemLongPress</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html" aria-label="View ItemLongPressEventArgs type in API reference">ItemLongPressEventArgs&gt;</a></a></td>
<td>Triggered when a tree item receives a <code>long press</code>, providing details about the <code>gesture</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemRightTapped" aria-label="View ItemRightTapped event in API reference">ItemRightTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemRightTappedEventArgs.html" aria-label="View ItemRightTappedEventArgs type in API reference">ItemRightTappedEventArgs&gt;</a></a></td>
<td>Triggered when a tree item is <code>right-tapped</code> or receives a <code>context-style</code> gesture.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs&gt;</a></a></td>
<td>Triggered when a tree item is <code>tapped</code>, providing details about the tapped <code>node</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_KeyDown" aria-label="View KeyDown event in API reference">KeyDown</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.keyeventargs" aria-label="View KeyEventArgs type in API reference">KeyEventArgs&gt;</a></a></td>
<td>Triggered when a <code>keyboard key</code> is pressed while the tree view has <code>focus</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_Loaded" aria-label="View Loaded event in API reference">Loaded</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewLoadedEventArgs.html" aria-label="View TreeViewLoadedEventArgs type in API reference">TreeViewLoadedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> the tree view has finished loading and is ready for interaction.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeChecked" aria-label="View NodeChecked event in API reference">NodeChecked</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeCheckedEventArgs.html" aria-label="View NodeCheckedEventArgs type in API reference">NodeCheckedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> a <code>node's</code> <code>checked state</code> changes, providing the affected <code>node</code> and its new state.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsed" aria-label="View NodeCollapsed event in API reference">NodeCollapsed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandedCollapsedEventArgs.html" aria-label="View NodeExpandedCollapsedEventArgs type in API reference">NodeExpandedCollapsedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> a <code>node</code> is <code>collapsed</code>, providing details about the node whose hierarchy is no longer visible.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeCollapsing" aria-label="View NodeCollapsing event in API reference">NodeCollapsing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandingCollapsingEventArgs.html" aria-label="View NodeExpandingCollapsingEventArgs type in API reference">NodeExpandingCollapsingEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> a <code>node</code> <code>collapses</code>, allowing the collapse action to be <code>canceled</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanded" aria-label="View NodeExpanded event in API reference">NodeExpanded</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandedCollapsedEventArgs.html" aria-label="View NodeExpandedCollapsedEventArgs type in API reference">NodeExpandedCollapsedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> a <code>node</code> is <code>expanded</code>, providing details about the node and the new visible hierarchy.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NodeExpanding" aria-label="View NodeExpanding event in API reference">NodeExpanding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.NodeExpandingCollapsingEventArgs.html" aria-label="View NodeExpandingCollapsingEventArgs type in API reference">NodeExpandingCollapsingEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> a <code>node</code> <code>expands</code>, allowing the expand action to be <code>canceled</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_QueryNodeSize" aria-label="View QueryNodeSize event in API reference">QueryNodeSize</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.QueryNodeSizeEventArgs.html" aria-label="View QueryNodeSizeEventArgs type in API reference">QueryNodeSizeEventArgs&gt;</a></a></td>
<td>Triggered when the <code>size</code> of a <code>node</code> is requested for <code>layout measurement</code>. Use this to customize <code>node height</code> per item.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemSelectionChangedEventArgs.html" aria-label="View ItemSelectionChangedEventArgs type in API reference">ItemSelectionChangedEventArgs&gt;</a></a></td>
<td>Triggered <code>after</code> the <code>selected nodes</code> have changed, providing the new <code>selection state</code>.</td>
</tr>

<tr>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemSelectionChangingEventArgs.html" aria-label="View ItemSelectionChangingEventArgs type in API reference">ItemSelectionChangingEventArgs&gt;</a></a></td>
<td>Triggered <code>before</code> the <code>selection</code> changes, allowing the selection update to be <code>validated</code> or <code>canceled</code>.</td>
</tr>

</table>
