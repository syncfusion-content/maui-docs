---
layout: post
title: Accessibility in .NET MAUI Chat control | Syncfusion
description: Learn here all about Accessibility support in Syncfusion .NET MAUI Chat (SfChat) control, its elements, and more.
platform: MAUI
control: SfChat
documentation: ug
---

# Accessibility in .NET MAUI Chat (SfChat)

`SfChat` support built-in `AutomationId` for all their inner elements. These `AutomationId` values allow the automation framework to find and interact with the inner elements when the test scripts are run. A unique `AutomationId` is maintained for each inner element by prefixing the control’s `AutomationId` with the inner element’s Id.

## Calendar

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>Calendar View</td>
<td>"Calendar"</td>
</tr>
</table>

![.NET MAUI Chat Calendar Accessibility](images/Accessibility/maui-chat-accessibility-calendar.png)

## Suggestion

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>Suggestions View</td>
<td>"Suggestions"</td>
</tr>
</table>

![.NET MAUI Chat Suggestion Accessibility](images/Accessibility/maui-chat-accessibility-suggestions.png)

## Cards

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>Card View</td>
<td>"Cards"</td>
</tr>
</table>

![.NET MAUI Chat Cards Accessibility](images/Accessibility/maui-chat-accessibility-cards.png)

## Avatar

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>AvatarView</td>
<td>"Avatar"</td>
</tr>
</table>

## LoadMore

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>loadMoreView</td>
<td>"Load more button"</td>
</tr>
<tr>
<td>loadMoreView</td>
<td>"Double tap to load more messages"</td>
</tr>
</table>

## Attachment Button

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>AttachmentIconView</td>
<td>"Attachment Button"</td>
</tr>
<tr>
<td>AttachmentIconView</td>
<td>"Double tap to activate"</td>
</tr>
</table>

## Send Icon

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>SendIconView</td>
<td>"Send Button"</td>
</tr>
<tr>
<td>SendIconView</td>
<td>"Double tap to send message"</td>
</tr>
</table>

The following screenshot illustrates the `Accessibility` values of the inner elements of `SfChat`.

![.NET MAUI Chat inner elements Accessibility](images/Accessibility/maui-chat-accessibility-loadmore.png)




