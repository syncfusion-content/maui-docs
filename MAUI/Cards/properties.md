---
layout: post
title: Properties in .NET MAUI Cards | Syncfusion®
description: Learn about properties in Syncfusion® .NET MAUI Cards (SfCards) control. Explore configuration options and API reference.
platform: maui
control: SfCardLayout
documentation: ug
---

# .NET MAUI Cards API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_HorizontalCardSpacing" aria-label="View HorizontalCardSpacing property in API reference">HorizontalCardSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Spacing between cards placed side by side. Increase this value to create more separation and improve readability.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_ShowSwipedCard" aria-label="View ShowSwipedCard property in API reference">ShowSwipedCard</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the swiped card remains visible after a swipe action. Set this to <code>false</code> to remove the card immediately after it is swiped.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_SwipeDirection" aria-label="View SwipeDirection property in API reference">SwipeDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardSwipeDirection.html" aria-label="View CardSwipeDirection type in API reference">CardSwipeDirection</a></td>
    <td>Direction in which cards can be swiped. Choose a supported <code>CardSwipeDirection</code> value to control the swipe gesture behavior.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VerticalCardSpacing" aria-label="View VerticalCardSpacing property in API reference">VerticalCardSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Spacing between stacked cards. Larger values increase the vertical gap between cards in the layout.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndex" aria-label="View VisibleIndex property in API reference">VisibleIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable-1" aria-label="View Nullable&lt;Int32&gt; type in API reference">int</a></td>
    <td>Index of the currently visible card. Use this to programmatically show a specific card when the layout loads or updates.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Backward" aria-label="View Backward method in API reference">Backward()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves the card layout to the <code>previous</code> card when one is available.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Forward" aria-label="View Forward method in API reference">Forward()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves the card layout to the <code>next</code> card when one is available.</td>
</tr>
</table>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Tapped" aria-label="View Tapped event in API reference">Tapped</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;TappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.tapedeventargs" aria-label="View TappedEventArgs type in API reference">TappedEventArgs</a>&gt;</a></td>
    <td>Raised when the card layout is tapped by the user. Use this event to respond to selection or open card details.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanged" aria-label="View VisibleIndexChanged event in API reference">VisibleIndexChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;CardVisibleIndexChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardVisibleIndexChangedEventArgs.html" aria-label="View CardVisibleIndexChangedEventArgs type in API reference">CardVisibleIndexChangedEventArgs</a>&gt;</a></td>
    <td>Raised after the visible card index changes. Use this event to update related UI after the new card becomes active.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanging" aria-label="View VisibleIndexChanging event in API reference">VisibleIndexChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;CardVisibleIndexChangingEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardVisibleIndexChangingEventArgs.html" aria-label="View CardVisibleIndexChangingEventArgs type in API reference">CardVisibleIndexChangingEventArgs</a>&gt;</a></td>
    <td>Raised before the visible card index changes. Use this event to validate the change or cancel it when needed.</td>
</tr>
</table>
