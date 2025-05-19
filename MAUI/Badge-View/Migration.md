---
layout: post
title: Migrating from Xamarin to .NET MAUI SfBadgeView | Syncfusion® 
description: Learn how to migrate from Syncfusion® Xamarin BadgeView to Syncfusion® .NET MAUI BadgeView control and more.
platform: MAUI
control: SfBadgeView
documentation: UG
---  

# Migrating from Xamarin SfBadgeView to .NET MAUI SfBadgeView 

To migrate easier from Xamarin SfBadgeView to .NET MAUI SfBadgeView, we kept most of the APIs from Xamarin SfBadgeView in MAUI SfBadgeView. However, some APIs have been renamed to ensure consistency with MAUI naming conventions. Below are the details of the changes from Xamarin SfBadgeView to .NET MAUI SfBadgeView.

## Namespaces 

<table>
<tr>
<th>Xamarin SfBadgeView</th>
<th>.NET MAUI SfBadgeView</th></tr>
<tr>
<td>Syncfusion.XForms.BadgeView</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfBadgeView</th>
<th>.NET MAUI SfBadgeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[BadgeAnimation](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_BadgeAnimation)'| markdownify }}</td>
<td>{{'[Animation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Animation)'| markdownify }}</td>
<td>Gets or sets the animation that should be used when the badge is shown.</td></tr>
<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_BackgroundColor)'| markdownify }}</td>
<td>{{'[Background](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Background)'| markdownify }}</td>
<td>Gets or sets the background for the badge.</td></tr>
<tr>
<td>{{'[StrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_StrokeWidth)' | markdownify }}</td>
<td>{{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke thickness for the badge.</td></tr>
<tr>
<td>{{'[BadgeIcon](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_BadgeIcon)' | markdownify }}</td>
<td>{{'[Icon](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Icon)'| markdownify }}</td>
<td>Gets or sets the Icon to be displayed in the badge.</td></tr>
<tr>
<td>{{'[BadgePosition](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_BadgePosition)' | markdownify }}</td>
<td>{{'[Position](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Position)'| markdownify }}</td>
<td>Gets or sets the position where the badge will be shown relative to the Content.</td></tr>
<tr>
<td>{{'[BadgeType](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html#Syncfusion_XForms_BadgeView_BadgeSetting_BadgeType)' | markdownify }}</td>
<td>{{'[Type](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html#Syncfusion_Maui_Core_BadgeSettings_Type)'| markdownify }}</td>
<td>Gets or sets the type of the badge.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfBadgeView</th>
<th>.NET MAUI SfBadgeView</th>
<th>Description</th></tr>
<tr>
<td>BadgePosition</td>
<td>BottomLeft,<br/>BottomRight,<br/>TopLeft,<br/>TopRight</td>
<td>Bottom,<br/>BottomLeft,<br/>BottomRight,<br/>Left,<br/>Right,<br/>Top,<br/>TopLeft,<br/>TopRight</td>
<td>Defines the position of the badge over the badge view control.</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin SfBadgeView</th>
<th>.NET MAUI SfBadgeView</th>
<th>Description</th></tr>
<tr>
<td>{{'[BadgeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html)'| markdownify}}</td>
<td>{{'[BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html)'| markdownify }}</td>
<td>Represents the badge settings class.</td></tr>
</table>
