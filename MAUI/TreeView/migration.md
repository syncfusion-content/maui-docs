---
layout: post
title: Migrate from Xamarin SfTreeView to .NET MAUI SfTreeView | Syncfusion®
description: Learn here all about Migrating from Syncfusion® Xamarin TreeView to Syncfusion® .NET MAUI TreeView control and more.
platform: MAUI
control: SfTreeView
documentation: ug
---  

# Migrate from Xamarin.Forms SfTreeView to .NET MAUI SfTreeView 

To make it easier to migrate from [Xamarin SfTreeView](https://www.syncfusion.com/xamarin-ui-controls/xamarin-treeview) to [.NET MAUI SfTreeView](https://www.syncfusion.com/maui-controls/maui-treeview), we retained most of the APIs from the Xamarin SfTreeView in the .NET MAUI SfTreeView. To keep API naming consistent in the .NET MAUI SfTreeView, however, we renamed some APIs. The APIs that have changed from the Xamarin SfTreeView to the .NET MAUI SfTreeView are detailed as follows.

## Prerequisites

Before migrating, ensure the following:

* The [MAUI SfTreeView](https://www.syncfusion.com/maui-controls/maui-treeview) is supported starting from Syncfusion .NET MAUI TreeView **v20.1.0.47** (Essential Studio® 2022 Volume 1). For the latest compatibility details and platform support, see [System Requirements](system-requirements.html) and [Release Notes](release-notes.html).
* Create or convert your project to a .NET MAUI app. To move a Xamarin.Forms project to .NET MAUI, follow the migration guide: [Upgrade from Xamarin.Forms to .NET MAUI](upgrade.html).
* Remove the Xamarin TreeView NuGet package(s) and add the MAUI TreeView package. The required package is `Syncfusion.Maui.TreeView` (available on NuGet). See [Installation](installation.html) for setup steps.
* Register the Syncfusion license key after installation. For details, see [Licensing](licensing.html).

> **NOTE**  
> The tables below list only the APIs whose names changed. All other APIs from the Xamarin SfTreeView are retained in the .NET MAUI SfTreeView under the new namespace.

## Namespaces 

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th></tr>
<tr>
<td>Syncfusion.XForms.TreeView</td>
<td>Syncfusion.Maui.TreeView</td></tr>
</table>

> The C# namespace changes from `Syncfusion.XForms.TreeView` to `Syncfusion.Maui.TreeView`. The following XAML `xmlns` declarations must also be updated:
>
> | API scope | Xamarin SfTreeView | .NET MAUI SfTreeView |
> | --- | --- | --- |
> | XAML namespace | `xmlns:syncfusion="clr-namespace:Syncfusion.XForms.TreeView;assembly=Syncfusion.SfTreeView.XForms"` | `xmlns:syncfusion="clr-namespace:Syncfusion.Maui.TreeView;assembly=Syncfusion.Maui.TreeView"` |

## Properties

The following table lists the properties whose names changed in the .NET MAUI SfTreeView:

<table> 
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[HoldCommand](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_HoldCommand)'| markdownify }}</td>
<td>{{'[LongPressCommand](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_LongPressCommand)'| markdownify }}</td>
<td>Gets or sets a System.Windows.Input.ICommand that will be executed when the TreeViewItem is long-pressed. Note: In MAUI, the command parameter is of type `TreeViewLongPressCommandParameter`; update command bindings accordingly.</td></tr>
<tr>
<td>{{'[IsScrollBarVisible](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_IsScrollBarVisible)'| markdownify }}</td>
<td>{{'[ScrollBarVisibility](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ScrollBarVisibility)'| markdownify }}</td>
<td>Gets or sets a value indicating whether the scrollbar should be displayed. Note: The property type changed from a Boolean (`IsScrollBarVisible`) in Xamarin to the [`ScrollBarVisibility`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ScrollBarVisibility.html) enum in MAUI — set it to `Default`, `Always`, `Never`, or `Disabled`.</td></tr>
<tr>
<td>{{'[SelectionBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_SelectionBackgroundColor)' | markdownify }}</td>
<td>{{'[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionBackground)'| markdownify }}</td>
<td>Gets or sets the selection background color for the selected item.</td></tr>
<tr>
<td>{{'[SelectionForegroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_SelectionForegroundColor)'| markdownify }}</td>
<td>{{'[SelectionForeground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_SelectionForeground)'| markdownify }}</td>
<td>Gets or sets the selected item's foreground color. Note: It is applicable in unbound mode only. The same restriction applies to the .NET MAUI SfTreeView — `SelectionForeground` is applied only in unbound mode.</td>
</tr>
</table> 

## Enums

The following table lists the enums whose names changed in the .NET MAUI SfTreeView. The enum members themselves are unchanged from Xamarin to MAUI; only the type names changed:

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ItemType.html)'| markdownify }}</td>
<td>{{'[TreeViewItemType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewItemType.html)'| markdownify }}</td>
<td>Defines the item type for a TreeViewItemInfoBase.</td></tr>
<tr>
<td>{{'[ExpandActionTarget](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ExpandActionTarget.html)'| markdownify }}</td>
<td>{{'[TreeViewExpandActionTarget](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpandActionTarget.html)'| markdownify }}</td>
<td>Defines whether expanding and collapsing of nodes can be performed only by tapping the expander view, or by tapping both the expander view and the content view.</td></tr>
<tr>
<td>{{'[ExpanderPosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ExpanderPosition.html)'| markdownify }}</td>
<td>{{'[TreeViewExpanderPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewExpanderPosition.html)'| markdownify }}</td>
<td>Defines the expander position of the SfTreeView. The expander can be positioned at either the start or the end of the item.</td></tr>
<tr>
<td>{{'[SelectionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SelectionMode.html)'| markdownify }}</td>
<td>{{'[TreeViewSelectionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.TreeViewSelectionMode.html)'| markdownify }}</td>
<td>Defines constants that specify the selection modes supported by the SfTreeView control.</td></tr>
<tr>
<td>{{'[AutoExpandMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.TreeView.Engine.AutoExpandMode.html)'| markdownify }}</td>
<td>{{'[TreeViewAutoExpandMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_AutoExpandMode)'| markdownify }}</td>
<td>Defines the possible expand modes while loading the nodes in the SfTreeView. Note: In Xamarin, this enum lived in the `Syncfusion.TreeView.Engine` namespace; in .NET MAUI, it has moved to `Syncfusion.Maui.TreeView` and been renamed.</td></tr>
<tr>
<td>{{'[NotificationSubscriptionMode](https://help.syncfusion.com/cr/xamarin/Syncfusion.TreeView.Engine.NotificationSubscriptionMode.html)'| markdownify }}</td>
<td>{{'[TreeViewNotificationSubscriptionMode](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_NotificationSubscriptionMode)'| markdownify }}</td>
<td>Defines the constants that specify whether to listen for the PropertyChanging and `System.ComponentModel.INotifyPropertyChanged.PropertyChanged` events of the data object, and the `System.Collections.Specialized.INotifyCollectionChanged.CollectionChanged` event of the source collection. Note: In Xamarin, this enum lived in the `Syncfusion.TreeView.Engine` namespace; in .NET MAUI, it has moved to `Syncfusion.Maui.TreeView` and been renamed.</td></tr>
</table>

## Events

The only renamed event in the .NET MAUI SfTreeView is listed below. Its associated event-arguments class is also renamed:

<table>
<tr>
<th>Xamarin SfTreeView</th>
<th>.NET MAUI SfTreeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[ItemHolding](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.SfTreeView.html#Syncfusion_XForms_TreeView_SfTreeView_ItemHolding)'| markdownify }}</td>
<td>{{'[ItemLongPress](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.SfTreeView.html#Syncfusion_Maui_TreeView_SfTreeView_ItemLongPress)'| markdownify }}</td>
<td>Occurs when the TreeViewItem's content view is long-pressed.</td></tr>
<tr>
<td>{{'[ItemHoldingEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TreeView.ItemHoldingEventArgs.html)'| markdownify }}</td>
<td>{{'[ItemLongPressEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeView.ItemLongPressEventArgs.html)'| markdownify }}</td>
<td>Provides data for the `ItemHolding` (Xamarin) and `ItemLongPress` (.NET MAUI) events.</td></tr>
</table>

## Methods, interfaces, and attached properties

No public methods, interfaces, or bindable (attached) properties were renamed in the .NET MAUI SfTreeView. They are retained from the Xamarin SfTreeView under the new namespace. For any API not listed in the tables above, simply update its namespace from `Syncfusion.XForms.TreeView` to `Syncfusion.Maui.TreeView`. 