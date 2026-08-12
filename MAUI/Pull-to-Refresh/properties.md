---
layout: post
title: Properties of .NET MAUI PullToRefresh control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI PullToRefresh (SfPullToRefresh) control.
platform: maui
control: SfPullToRefresh
documentation: ug
---

# .NET MAUI PullToRefresh API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_CanRestrictChildTouch">CanRestrictChildTouch</a></td>
    <td>bool</td>
    <td>Defines whether touch interactions in child views are restricted while pulling.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing">IsRefreshing</a></td>
    <td>bool</td>
    <td>Defines whether the refresh operation is currently in progress.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressBackground">ProgressBackground</a></td>
    <td>Brush</td>
    <td>Defines the background of the progress indicator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressColor">ProgressColor</a></td>
    <td>Color</td>
    <td>Defines the color of the progress indicator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressThickness">ProgressThickness</a></td>
    <td>double</td>
    <td>Defines the thickness of the progress indicator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent">PullableContent</a></td>
    <td>View</td>
    <td>Defines the content that supports pull-to-refresh interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullingThreshold">PullingThreshold</a></td>
    <td>double</td>
    <td>Defines the distance required to trigger a refresh operation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullingViewTemplate">PullingViewTemplate</a></td>
    <td>DataTemplate</td>
    <td>Defines the template displayed while the view is being pulled.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommand">RefreshCommand</a></td>
    <td>ICommand</td>
    <td>Defines the command executed when a refresh is triggered.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommandParameter">RefreshCommandParameter</a></td>
    <td>object</td>
    <td>Defines the parameter passed to the refresh command.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshingViewTemplate">RefreshingViewTemplate</a></td>
    <td>DataTemplate</td>
    <td>Defines the template displayed while refreshing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewHeight">RefreshViewHeight</a></td>
    <td>double</td>
    <td>Defines the height of the refresh view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewThreshold">RefreshViewThreshold</a></td>
    <td>double</td>
    <td>Defines the distance at which the refresh view becomes visible.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewWidth">RefreshViewWidth</a></td>
    <td>double</td>
    <td>Defines the width of the refresh view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode">TransitionMode</a></td>
    <td>PullToRefreshTransitionMode</td>
    <td>Defines the transition behavior used during the pull-to-refresh operation.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_EndRefreshing">EndRefreshing()</a></td>
    <td>void</td>
    <td>Ends the current refresh operation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_StartRefreshing">StartRefreshing()</a></td>
    <td>void</td>
    <td>Starts the refresh operation programmatically.</td>
</tr>
</table>
