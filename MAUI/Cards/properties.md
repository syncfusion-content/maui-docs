---
layout: post
title: Properties in .NET MAUI Cards | Syncfusion®
description: Learn about properties in Syncfusion® .NET MAUI Cards (SfCards) control. Explore configuration options and API reference.
platform: maui
control: SfCardLayout
documentation: ug
---

# API Reference for .NET MAUI Cards

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
    <td><code>Horizontal spacing</code> between <code>cards</code> placed side by side in the <code>layout</code>. Larger values add more <code>separation</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_ShowSwipedCard" aria-label="View ShowSwipedCard property in API reference">ShowSwipedCard</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>swiped card</code> remains visible after a <code>swipe gesture</code>. Set this to <code>false</code> to <code>dismiss</code> the card immediately after the swipe completes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_SwipeDirection" aria-label="View SwipeDirection property in API reference">SwipeDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardSwipeDirection.html" aria-label="View CardSwipeDirection type in API reference">CardSwipeDirection</a></td>
    <td>Direction in which <code>cards</code> can be <code>swiped</code>. Choose a supported <code>CardSwipeDirection</code> value such as <code>Left</code>, <code>Right</code>, <code>Up</code>, or <code>Down</code> to control how <code>swipe gestures</code> behave.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VerticalCardSpacing" aria-label="View VerticalCardSpacing property in API reference">VerticalCardSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Vertical spacing</code> between <code>stacked cards</code> in the <code>layout</code>. Larger values increase the <code>gap</code> between layered cards.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndex" aria-label="View VisibleIndex property in API reference">VisibleIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.nullable-1" aria-label="View Nullable&lt;Int32&gt; type in API reference">int</a></td>
    <td><code>Index</code> of the <code>card</code> currently displayed by the <code>layout</code>. Changing this value brings the corresponding <code>card</code> to the <code>visible position</code>.</td>
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
    <td>Moves the <code>layout</code> to the <code>previous card</code>. If the current <code>visible card</code> is the <code>first card</code>, the <code>visible index</code> remains unchanged.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Forward" aria-label="View Forward method in API reference">Forward()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves the <code>layout</code> to the <code>next card</code>. If the current <code>visible card</code> is the <code>last card</code>, the <code>visible index</code> remains unchanged.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;TappedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.tapedeventargs" aria-label="View TappedEventArgs type in API reference">TappedEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>card layout</code> is tapped by the user. Use this event to respond to <code>selection</code> or open <code>card details</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanged" aria-label="View VisibleIndexChanged event in API reference">VisibleIndexChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;CardVisibleIndexChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardVisibleIndexChangedEventArgs.html" aria-label="View CardVisibleIndexChangedEventArgs type in API reference">CardVisibleIndexChangedEventArgs&gt;</a></a></td>
    <td>Triggered <code>after</code> the <code>visible card index</code> changes, providing the <code>previous</code> and <code>new indices</code>. Use this event to update related <code>UI</code> after a new card becomes <code>active</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanging" aria-label="View VisibleIndexChanging event in API reference">VisibleIndexChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;CardVisibleIndexChangingEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.CardVisibleIndexChangingEventArgs.html" aria-label="View CardVisibleIndexChangingEventArgs type in API reference">CardVisibleIndexChangingEventArgs&gt;</a></a></td>
    <td>Triggered <code>before</code> the <code>visible card index</code> changes, providing the upcoming <code>new index</code>. Use this event to <code>validate</code> the <code>transition</code> or <code>cancel</code> it when needed.</td>
</tr>
</table>