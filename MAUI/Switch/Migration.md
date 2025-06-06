---
layout: post
title: Migrating from Xamarin to .NET MAUI Switch | Syncfusion® 
description: Learn about migrating from Syncfusion® Xamarin Switch to the Syncfusion® .NET MAUI Switch control, and more.
platform: MAUI
control: SfSwitch
documentation: UG
---  

# Migrating from Xamarin SfSwitch to .NET MAUI SfSwitch 

To facilitate easier migration from Xamarin SfSwitch to .NET MAUI SfSwitch, most of the APIs from Xamarin SfSwitch have been retained in MAUI SfSwitch. However, to maintain API naming consistency in MAUI SfSwitch, some APIs have been renamed. The changes in APIs from Xamarin SfSwitch to MAUI SfSwitch are detailed as follows:

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
<td>{{'[TrackBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackBorderWidth)'| markdownify }}</td>
<td>{{'[TrackStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the track stroke thickness.</td></tr>
<tr>
<td>{{'[ThumbBorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbBorderWidth)'| markdownify }}</td>
<td>{{'[ThumbStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStrokeThickness)'| markdownify }}</td>
<td>Gets or sets the thumb stroke thickness.</td></tr>
<tr>
<td>{{'[TrackBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackBorderColor)'| markdownify }}</td>
<td>{{'[TrackStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackStroke)'| markdownify }}</td>
<td>Gets or sets the color of the track border.</td></tr>
<tr>
<td>{{'[ThumbBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbBorderColor)'| markdownify }}</td>
<td>{{'[ThumbStroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbStroke)'| markdownify }}</td>
<td>Gets or sets the color of the thumb border.</td></tr>
<tr>
<td>{{'[TrackColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_TrackColor)'| markdownify }}</td>
<td>{{'[TrackBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_TrackBackground)'| markdownify }}</td>
<td>Gets or sets the color of the track.</td></tr>
<tr>
<td>{{'[ThumbColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.ISwitchSettings.html#Syncfusion_XForms_Buttons_ISwitchSettings_ThumbColor)'| markdownify }}</td>
<td>{{'[ThumbBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Buttons.SwitchSettings.html#Syncfusion_Maui_Buttons_SwitchSettings_ThumbBackground)'| markdownify }}</td>
<td>Gets or sets the color of the thumb.</td></tr>
</table>

## Upcoming features

  * Vertical orientation support.
  * BusyIndicator and its customization.
  * Background image support for both Track and Thumb.
  * Gradient color customization for both Track and Thumb.
