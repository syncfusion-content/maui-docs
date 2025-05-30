---
layout: post
title: Migrating from Xamarin to .NET MAUI Avatar View | Syncfusion® 
description: Learn how to migrate from Syncfusion® Xamarin Avatar View to the Syncfusion® .NET MAUI Avatar View control and more.
platform: MAUI
control: SfAvatarView
documentation: UG
---  

# Migrating from Xamarin SfAvatarView to .NET MAUI SfAvatarView 

To ease the migration from Xamarin [SfAvatarView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.AvatarView.html) to .NET MAUI [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html), most APIs from the Xamarin version have been retained in the MAUI [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html). However, to ensure consistency in API naming within the MAUI environment, some APIs have been renamed. The changes in MAUI [SfAvatarView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfAvatarView.html) from Xamarin [SfAvatarView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.AvatarView.html) are detailed below.

## Namespaces 

<table>
<tr>
<th>Xamarin SfAvatarView</th>
<th>.NET MAUI SfAvatarView</th></tr>
<tr>
<td>Syncfusion.XForms.AvatarView</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfAvatarView</th>
<th>.NET MAUI SfAvatarView</th>
<th>Description</th></tr>
<tr>
<td>BorderColor</td>
<td>Stroke</td>
<td>Gets or sets the stroke of the Avatar View</td></tr>
<tr>
<td>BorderWidth</td>
<td>StrokeThickness</td>
<td>Gets or sets the thickness of the Avatar View stroke</td></tr>
</table> 
