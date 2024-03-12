---
layout: post
title: Migrate from Xamarin SfChat to .NET MAUI SfChat | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin Chat to Syncfusion .NET MAUI Chat control and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Migrate from Xamarin.Forms SfChat to .NET MAUI SfChat

To migrate easier from Xamarin.Forms SfChat to .NET MAUI SfChat, we kept most of the APIs from Xamarin SfChat in MAUI SfChat. However, to maintain the consistency of API naming in MAUI SfChat, we renamed some of the APIs. The APIs that have been changed in MAUI SfChat from Xamarin SfChat are detailed as follows.

## Namespaces

<table>
<tr>
<th>Xamarin SfChat </th>
<th>.NET MAUI SfChat</th></tr>
<tr>
<td>Syncfusion.XForms.SfChat</td>
<td>Syncfusion.Maui.Chat</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfChat</th>
<th>.NET MAUI SfChat</th>
<th>Description</th>
</tr>

<tr>
<td>{{'IsBusy'| markdownify }}</td>
<td>{{'IsLazyLoading'| markdownify }}</td>
<td>Gets or sets a value indicating if the chat is currently loading more items. If it is true, the load indicator will be displayed until it is set to false.</td>
</tr>

<tr>
<td>{{'LeftSwipeViewTemplate'| markdownify }}</td>
<td>{{'StartSwipeTemplate'| markdownify }}</td>
<td>Gets or sets the template shown when a user swipes an item to the right.</td>
</tr>

<tr>
<td>{{'RightSwipeViewTemplate'| markdownify }}</td>
<td>{{'EndSwipeTemplate'| markdownify }}</td>
<td>Gets or sets the template shown when a user swipes an item to the left.</td>
</tr>
</table>