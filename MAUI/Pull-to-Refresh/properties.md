---
layout: post
title: Properties of .NET MAUI PullToRefresh control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI PullToRefresh (SfPullToRefresh) control.
platform: maui
control: SfPullToRefresh
documentation: ug
---

# API Reference for .NET MAUI PullToRefresh

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_CanRestrictChildTouch" aria-label="View CanRestrictChildTouch property in API reference">CanRestrictChildTouch</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>child view touch interactions</code> are <code>blocked</code> while a <code>pull gesture</code> is being <code>recognized</code>. When <code>true</code>, the <code>wrapped content</code> does not <code>consume gestures</code> during the <code>pull</code>, keeping <code>refresh behavior</code> <code>responsive</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_IsRefreshing" aria-label="View IsRefreshing property in API reference">IsRefreshing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Reflects whether a <code>refresh operation</code> is currently <code>in progress</code>. Set to <code>true</code> to start <code>refreshing</code> <code>programmatically</code>; set to <code>false</code> to end <code>refreshing</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressBackground" aria-label="View ProgressBackground property in API reference">ProgressBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td><code>Brush</code> applied <code>behind</code> the <code>progress indicator</code> during the <code>refresh feedback area</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressColor" aria-label="View ProgressColor property in API reference">ProgressColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td><code>Color</code> of the <code>progress indicator</code>. Provides the <code>primary accent</code> for the <code>refresh animation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressThickness" aria-label="View ProgressThickness property in API reference">ProgressThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Thickness</code> of the <code>progress indicator</code>. Larger values produce a <code>bolder refresh progress line</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullableContent" aria-label="View PullableContent property in API reference">PullableContent</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Scrollable <code>content</code> wrapped by <code>SfPullToRefresh</code> that <code>participates</code> in the <code>pull gesture</code>. Typically a scrollable view such as <code>ListView</code> or <code>CollectionView</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullingThreshold" aria-label="View PullingThreshold property in API reference">PullingThreshold</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code>, in <code>pixels</code>, the <code>content</code> must be <code>pulled</code> before a <code>refresh operation</code> is <code>triggered</code>. Larger values require a longer <code>pull</code> before <code>refresh</code> begins.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_PullingViewTemplate" aria-label="View PullingViewTemplate property in API reference">PullingViewTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> shown while the <code>content</code> is being <code>pulled</code>. Use it to provide custom <code>visual feedback</code> during the <code>drag interaction</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommand" aria-label="View RefreshCommand property in API reference">RefreshCommand</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td><code>Command</code> executed when <code>refresh</code> is <code>triggered</code>, either by a <code>pull gesture</code> or by setting <code>IsRefreshing</code> to <code>true</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshCommandParameter" aria-label="View RefreshCommandParameter property in API reference">RefreshCommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Parameter</code> passed to <code>RefreshCommand</code> when <code>refresh</code> is <code>triggered</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshingViewTemplate" aria-label="View RefreshingViewTemplate property in API reference">RefreshingViewTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> shown while <code>refresh</code> is <code>in progress</code>. Use it to provide a <code>dedicated visual</code> for the <code>active refresh state</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewHeight" aria-label="View RefreshViewHeight property in API reference">RefreshViewHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Height</code> of the <code>refresh view area</code>. Larger values reserve more <code>vertical space</code> for the <code>indicator</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewThreshold" aria-label="View RefreshViewThreshold property in API reference">RefreshViewThreshold</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Distance</code>, in <code>pixels</code>, at which the <code>refresh view</code> starts to become <code>visible</code> during the <code>pull</code>. Smaller values make the <code>indicator</code> appear <code>earlier</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewWidth" aria-label="View RefreshViewWidth property in API reference">RefreshViewWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Width</code> of the <code>refresh view area</code>. Larger values reserve more <code>horizontal space</code> for the <code>indicator</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_TransitionMode" aria-label="View TransitionMode property in API reference">TransitionMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html" aria-label="View PullToRefreshTransitionType enum in API reference">PullToRefreshTransitionType</a></td>
    <td><code>Transition behavior</code> of the <code>refresh view</code>. Choose a supported <code>PullToRefreshTransitionType</code> value such as <code>SlideOnTop</code> or <code>Push</code> to control how the <code>indicator</code> moves <code>into</code> and <code>out of view</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_EndRefreshing" aria-label="View EndRefreshing method in API reference">EndRefreshing()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Ends the <code>current refresh operation</code> and returns the <code>control</code> to <code>normal interaction</code>. Set <code>IsRefreshing</code> to <code>false</code> after your <code>refresh logic</code> completes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_StartRefreshing" aria-label="View StartRefreshing method in API reference">StartRefreshing()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Starts the <code>refresh operation</code> <code>programmatically</code>, <code>triggering</code> the <code>refresh sequence</code> without requiring a <code>pull gesture</code>.</td>
</tr>
</table>
