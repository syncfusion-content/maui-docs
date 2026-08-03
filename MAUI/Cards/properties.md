---
layout: post
title: Properties of .NET MAUI Card Layout control | Syncfusion®
description: This section explains the properties and events with Syncfusion® MAUI Card Layout (SfCardLayout) control.
platform: maui
control: SfCardLayout
documentation: ug
---

# .NET MAUI Card Layout API Reference

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
		<td>Defines the horizontal spacing between cards.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_ShowSwipedCard">ShowSwipedCard</a></td>
		<td>bool</td>
		<td>Shows the swiped card.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_SwipeDirection">SwipeDirection</a></td>
		<td>CardSwipeDirection</td>
		<td>Defines the swipe direction.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VerticalCardSpacing">VerticalCardSpacing</a></td>
		<td>int</td>
		<td>Defines the vertical spacing between cards.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndex">VisibleIndex</a></td>
		<td>Nullable&lt;int&gt;</td>
		<td>Defines the visible card index.</td>
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
		<td>Raised when the layout is tapped.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanged">VisibleIndexChanged</a></td>
		<td>EventHandler&lt;CardVisibleIndexChangedEventArgs&gt;</td>
		<td>Raised when the visible card changes.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_VisibleIndexChanging">VisibleIndexChanging</a></td>
		<td>EventHandler&lt;CardVisibleIndexChangingEventArgs&gt;</td>
		<td>Raised before the visible card changes.</td>
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
		<td>Moves to the previous card.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Cards.SfCardLayout.html#Syncfusion_Maui_Cards_SfCardLayout_Forward">Forward()</a></td>
		<td>void</td>
		<td>Moves to the next card.</td>
	</tr>
</table>
