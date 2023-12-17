---
layout: post
title: Migrating from Xamarin to .NET MAUI Switch | Syncfusion 
description: Learn about Migrating from Syncfusion Xamarin Switch to the Syncfusion .NET MAUI Switch control, and more here.
platform: .NET MAUI
control: SfSwitch
documentation: ug
---  

# Migrating from Xamarin SfSwitch to .NET MAUI SfSwitch 

To migrate easier from Xamarin SfSwitch to [.NET MAUI SfSwitch], we kept most of the APIs from Xamarin SfSwitch in MAUI SfSwitch. However, to maintain the consistency of the API naming in MAUI SfSwitch, we renamed some of the APIs. The APIs changed in MAUI SfSwitch from Xamarin SfSwitch are detailed as follows:

## Namespaces 

<table>
<tr>
<th>Xamarin SfSwitch</th>
<th>.NET MAUI SfSwitch</th></tr>
<tr>
<td>Syncfusion.XForms.Buttons</td>
<td>Syncfusion.Maui.Buttons</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfSwitch</th>
<th>.NET MAUI SfSwitch</th>
<th>Description</th></tr>
<tr>
<td> {{'[TrackBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackBorderWidth)'| markdownify }}</td>
<td>TrackStrokeThickness</td>
<td>Gets or sets the track stroke thickness.</td></tr>
<tr>
<td> {{'[ThumbBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbBorderWidth)'| markdownify }}</td>
<td>ThumbStrokeThickness</td>
<td>Gets or sets the thumb stroke thickness.</td></tr>
<tr>
<td> {{'[TrackBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackBorderColor)'| markdownify }}</td>
<td>TrackStroke</td>
<td>Gets or sets the color of the track border.</td></tr>
<tr>
<td> {{'[ThumbBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbBorderColor)'| markdownify }}</td>
<td>ThumbStroke</td>
<td>Gets or sets the color of the thumb border.</td></tr>
<tr>
<td> {{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackColor)'| markdownify }}</td>
<td>TrackBackground</td>
<td>Gets or sets the color of the track.</td></tr>
<tr>
<td> {{'[ThumbColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbColor)'| markdownify }}</td>
<td>ThumbBackground</td>
<td>Gets or sets the color of the thumb.</td></tr>
</table>

## Upcoming features

  * Vertical orientation support.
  * BusyIndicator and its customization.
  * Background image support for both Track and Thumb.
  * Gradient color customization for both Track and Thumb.
