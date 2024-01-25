---
layout: post
title: Migrate from Xamarin SfPullToRefresh to .NET MAUI SfPullToRefresh | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin PullToRefresh to Syncfusion .NET MAUI SfPullToRefresh control and more.
platform: MAUI
control: SfPullToRefresh
documentation: ug
---  

# Migrate from Xamarin.Forms SfPullToRefresh to .NET MAUI SfPullToRefresh

To migrate easier from Xamarin.Forms SfPullToRefresh to .NET MAUI SfPullToRefresh, we kept most of the APIs from Xamarin SfPullToRefresh in .NET MAUI SfPullToRefresh. However, to maintain the consistency of API naming in .NET MAUI SfPullToRefresh, we renamed some of the APIs. The APIs that have been changed in .NET MAUI SfPullToRefresh from Xamarin SfPullToRefresh are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfPullToRefresh </th>
<th>.NET .NET MAUI SfPullToRefresh</th></tr>
<tr>
<td>Syncfusion.SfPullToRefresh.XForms</td>
<td>Syncfusion.Maui.PullToRefresh</td></tr>
</table>

## Properties

<table>
<tr>
<th>Xamarin SfPullToRefresh</th>
<th>.NET MAUI SfPullToRefresh</th>
<th>Description</th></tr>
<tr>
<td>{{'[ProgressStrokeColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressStrokeColor)'| markdownify }}</td>
<td>{{'[ProgressColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressColor)'| markdownify }}</td>
<td>Gets or sets the progress stroke color of SfPullToRefresh.</td>
</tr>

<tr>
<td>{{'[ProgressBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressBackgroundColor)'| markdownify }}</td>
<td>{{'[ProgressBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressBackground)'| markdownify }}</td>
<td>Gets or sets the progress background color of SfPullToRefresh.</td>
</tr>

<tr>
<td>{{'[ProgressStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_ProgressStrokeWidth)'| markdownify }}</td>
<td>{{'[ProgressThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_ProgressThickness)'| markdownify }}</td>
<td>Gets or sets the progress indicator stroke width. </td>
</tr>

<tr>
<td>{{'[RefreshContentHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentHeight)'| markdownify }}</td>
<td>{{'[RefreshViewHeight](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewHeight)'| markdownify }}</td>
<td>Gets or sets the value for the refresh content height.</td>
</tr>

<tr>
<td>{{'[RefreshContentWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentWidth)'| markdownify }}</td>
<td>{{'[RefreshViewWidth](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewWidth)'| markdownify }}</td>
<td>Gets or sets the value for the refresh content width.</td>
</tr>

<tr>
<td>{{'[RefreshContentThreshold](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.SfPullToRefresh.html#Syncfusion_SfPullToRefresh_XForms_SfPullToRefresh_RefreshContentThreshold)'| markdownify }}</td>
<td>{{'[RefreshViewThreshold](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.SfPullToRefresh.html#Syncfusion_Maui_PullToRefresh_SfPullToRefresh_RefreshViewThreshold)'| markdownify }}</td>
<td>Gets or sets the refresh content threshold value that indicates progress indicator starting position in view.</td>
</tr>
</table>

## Enums 

<table>
<tr>
<th>Xamarin SfPullToRefresh</th>
<th>.NET MAUI SfPullToRefresh</th>
<th>Description</th></tr>
<tr>
<td>{{'[TransitionType](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfPullToRefresh.XForms.TransitionType.html)'| markdownify }}</td>
<td>{{'[PullToRefreshTransitionType](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.PullToRefresh.PullToRefreshTransitionType.html)'| markdownify }}</td>
<td>Defines type of pulling animation can be perfomed.</td></tr>
</table>