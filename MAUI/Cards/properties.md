---
layout: post
title: Properties in .NET MAUI Cards | Syncfusion®
description: Learn about properties in Syncfusion® .NET MAUI Cards (SfCards) control. Explore configuration options and API reference.
platform: maui
control: SfCardLayout
documentation: ug
---

# Properties in .NET MAUI Cards

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_HorizontalCardSpacing">HorizontalCardSpacing</a></td>
        <td>int</td>
        <td>Defines the horizontal spacing between adjacent cards in the layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_ShowSwipedCard">ShowSwipedCard</a></td>
        <td>bool</td>
        <td>Defines whether the swiped card remains visible after the swipe action.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_SwipeDirection">SwipeDirection</a></td>
        <td>CardSwipeDirection</td>
        <td>Defines the direction in which cards can be swiped.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VerticalCardSpacing">VerticalCardSpacing</a></td>
        <td>int</td>
        <td>Defines the vertical spacing between stacked cards in the layout.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndex">VisibleIndex</a></td>
        <td>Nullable&lt;int&gt;</td>
        <td>Defines the index of the currently visible card.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Backward">Backward()</a></td>
        <td>void</td>
        <td>Moves the layout to the previous card, if available.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Forward">Forward()</a></td>
        <td>void</td>
        <td>Moves the layout to the next card, if available.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Tapped">Tapped</a></td>
        <td>EventHandler&lt;TappedEventArgs&gt;</td>
        <td>Raised when the card layout is tapped by the user.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanged">VisibleIndexChanged</a></td>
        <td>EventHandler&lt;CardVisibleIndexChangedEventArgs&gt;</td>
        <td>Raised after the visible card index has changed.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanging">VisibleIndexChanging</a></td>
        <td>EventHandler&lt;CardVisibleIndexChangingEventArgs&gt;</td>
        <td>Raised before the visible card index changes and can be canceled.</td>
    </tr>
</table>