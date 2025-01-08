---
layout: post
title: Migrating from Xamarin to .NET MAUI SfBusyIndicator | Syncfusion<sup>®</sup> 
description: Learn here all about Migrating from Syncfusion<sup>®</sup> Xamarin BusyIndicator to Syncfusion<sup>®</sup> .NET MAUI BusyIndicator control and more.
platform: maui
control: SfBusyIndicator
documentation: ug
---  

# Migrating from Xamarin SfBusyIndicator to .NET MAUI SfBusyIndicator 

To migrate easier from Xamarin SfBusyIndicator to .NET MAUI [SfBusyIndicator](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html), we kept most of the APIs from Xamarin SfBusyIndicator in MAUI SfBusyIndicator. However, to maintain the consistency of API naming in MAUI SfBusyIndicator, we renamed some of the APIs. The APIs that have been changed in MAUI SfBusyIndicator from Xamarin SfBusyIndicator are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfBusyIndicator</th>
<th>.NET MAUI SfBusyIndicator</th></tr>
<tr>
<td>Syncfusion.SfBusyIndicator.XForms</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfBusyIndicator</th>
<th>.NET MAUI SfBusyIndicator</th>
<th>Description</th></tr>
<tr>
<td> {{'[IsBusy](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html#Syncfusion_SfBusyIndicator_XForms_SfBusyIndicator_IsBusy)'| markdownify}} </td>
<td>{{'[IsRunning](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_IsRunning)'| markdownify}} </td>
<td>Gets or sets a value of the IsRunning property in busy indicator. It determines whether the animation of indicator to be shown or not.</td></tr>
<tr>
<td>{{'[Duration](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html#Syncfusion_SfBusyIndicator_XForms_SfBusyIndicator_Duration)'| markdownify}} </td>
<td>{{'[DurationFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_DurationFactor)'| markdownify}} </td>
<td>Gets or sets the value of the duration property. It is used to change the speed of animation to finish a cycle.</td></tr>
<tr>
<td>{{'[ViewBoxWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html#Syncfusion_SfBusyIndicator_XForms_SfBusyIndicator_ViewBoxWidth) [ViewBoxHeight](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html#Syncfusion_SfBusyIndicator_XForms_SfBusyIndicator_ViewBoxHeight)'| markdownify}}</td>
<td>{{'[SizeFactor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_SizeFactor)'| markdownify}}</td>
<td>Gets or set the size factor of the indicator. This is not applicable for all animation types.</td></tr>
<tr>
<td>{{'[TextSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfBusyIndicator.XForms.SfBusyIndicator.html#Syncfusion_SfBusyIndicator_XForms_SfBusyIndicator_TextSize)'| markdownify}}</td>
<td>{{'[FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfBusyIndicator.html#Syncfusion_Maui_Core_SfBusyIndicator_FontSize)'| markdownify}}</td>
<td>Gets or sets the font size of the title text.</td></tr>
</table> 
