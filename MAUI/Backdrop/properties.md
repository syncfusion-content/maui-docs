---
layout: post
title: Properties of .NET MAUI Backdrop control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Backdrop (SfBackdropPage) control.
platform: maui
control: SfBackdropPage
documentation: ug
---

# .NET MAUI Backdrop API Reference

## Properties

<table>
	<tr>
		<th>Name</th>
		<th>Type</th>
		<th>Description</th>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayer">BackLayer</a></td>
		<td>BackdropBackLayer</td>
		<td>Defines the view placed behind the front layer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayerRevealOption">BackLayerRevealOption</a></td>
		<td>RevealOption</td>
		<td>Defines how the back layer is revealed.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseIconImageSource">CloseIconImageSource</a></td>
		<td>ImageSource</td>
		<td>Defines the image source used for the close icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseText">CloseText</a></td>
		<td>string</td>
		<td>Defines the accessibility text for the close icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_Content">Content</a></td>
		<td>View</td>
		<td>Defines the view that contains the content of the page.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_ControlTemplate">ControlTemplate</a></td>
		<td>ControlTemplate</td>
		<td>Defines the control template used to display content.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_FrontLayer">FrontLayer</a></td>
		<td>BackdropFrontLayer</td>
		<td>Defines the view placed in front of the back layer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_IsBackLayerRevealed">IsBackLayerRevealed</a></td>
		<td>bool</td>
		<td>Defines whether the back layer is in the expanded state.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenIconImageSource">OpenIconImageSource</a></td>
		<td>ImageSource</td>
		<td>Defines the image source used for the open icon.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenText">OpenText</a></td>
		<td>string</td>
		<td>Defines the accessibility text for the open icon.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayerStateChanged">BackLayerStateChanged</a></td>
		<td>EventHandler&lt;BackLayerStateChangedEventArgs&gt;</td>
		<td>Raised when the back layer is revealed or concealed.</td>
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
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_GetTouchHeight">GetTouchHeight()</a></td>
		<td>double</td>
		<td>Returns the touch height for the front layer.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OnAppearing">OnAppearing()</a></td>
		<td>void</td>
		<td>Invoked when the page is about to appear.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OnDisappearing">OnDisappearing()</a></td>
		<td>void</td>
		<td>Invoked when the page is about to disappear.</td>
	</tr>
	<tr valign="top">
		<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OnSizeAllocated_System_Double_System_Double_">OnSizeAllocated(double, double)</a></td>
		<td>void</td>
		<td>Handles the size allocation for the page.</td>
	</tr>
</table>
