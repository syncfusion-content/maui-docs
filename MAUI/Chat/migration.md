---
layout: post
title: Migrate from Xamarin.Forms SfChat to .NET MAUI SfChat | Syncfusion® 
description: Learn here all about Migrating from Syncfusion® Xamarin Chat to Syncfusion® .NET MAUI Chat control and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Migrate from Xamarin.Forms SfChat to .NET MAUI SfChat

To make migration easier, we have retained most of the Xamarin SfChat APIs in MAUI [SfChat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html). However, to maintain the consistency of API naming in MAUI SfChat, we renamed some of the APIs. The APIs that have changed in MAUI SfChat (compared with Xamarin SfChat) are detailed below.

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
        <td>{{'[IsBusy](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Chat.SfChat.html#Syncfusion_XForms_Chat_SfChat_IsBusy)'| markdownify }}</td>
        <td>{{'[IsLazyLoading](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_IsLazyLoading)'| markdownify }}</td>
        <td>Gets or sets a value indicating whether the chat is currently loading more items. If it is true, the load indicator will be displayed until it is set to false.</td>
    </tr>
    <tr>
        <td>{{'[LeftSwipeViewTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Chat.SfChat.html#Syncfusion_XForms_Chat_SfChat_LeftSwipeViewTemplate)'| markdownify }}</td>
        <td>{{'[StartSwipeTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_StartSwipeTemplate)'| markdownify }}</td>
        <td>Gets or sets the template shown when a user swipes an item to the right.</td>
    </tr>
    <tr>
        <td>{{'[RightSwipeViewTemplate](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Chat.SfChat.html#Syncfusion_XForms_Chat_SfChat_RightSwipeViewTemplate)'| markdownify }}</td>
        <td>{{'[EndSwipeTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Chat.SfChat.html#Syncfusion_Maui_Chat_SfChat_EndSwipeTemplate)'| markdownify }}</td>
        <td>Gets or sets the template shown when a user swipes an item to the left.</td>
    </tr>
</table>