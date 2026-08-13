---
layout: post
title: Migration to .NET MAUI Badge View | Syncfusion®
description: Learn about migration from Syncfusion® Xamarin Badge View to .NET MAUI Badge View control with API comparisons.
platform: maui
control: SfBadgeView
documentation: ug
---

# Migration from Xamarin Badge View to .NET MAUI Badge View 

To migrate easier from Xamarin BadgeView to .NET MAUI Badge View, we kept most of the APIs from Xamarin BadgeView in .NET MAUI Badge View. However, some APIs have been renamed to ensure consistency with MAUI naming conventions. Below are the details of the changes from Xamarin BadgeView to .NET MAUI Badge View.

## Namespaces 

<table>
<tr>
<th>Xamarin BadgeView</th>
<th>.NET MAUI Badge View</th></tr>
<tr>
<td>Syncfusion.XForms.BadgeView</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin BadgeView</th>
<th>.NET MAUI Badge View</th>
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
<th>Xamarin BadgeView</th>
<th>.NET MAUI Badge View</th>
<th>Description</th></tr>
<tr>
<td>BadgePosition</td>
<td>BottomLeft,<br/>BottomRight,<br/>TopLeft,<br/>TopRight</td>
<td>Bottom,<br/>BottomLeft,<br/>BottomRight,<br/>Left,<br/>Right,<br/>Top,<br/>TopLeft,<br/>TopRight</td>
<td>Defines the position of the badge over the Badge View control.</td></tr>
</table>

## Classes 

<table>
<tr>
<th>Xamarin BadgeView</th>
<th>.NET MAUI Badge View</th>
<th>Description</th></tr>
<tr>
<td>{{'[BadgeSetting](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.BadgeView.BadgeSetting.html)'| markdownify}}</td>
<td>{{'[BadgeSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.BadgeSettings.html)'| markdownify }}</td>
<td>Represents the badge settings class.</td></tr>
</table>
