---
layout: post
title: Migrating from Xamarin to .NET MAUI SfBusyIndicator | Syncfusion 
description: Learn here all about Migrating from Syncfusion Xamarin BusyIndicator to Syncfusion .NET MAUI BusyIndicator control and more.
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
<td> IsBusy </td>
<td>IsRunning</td>
<td>Gets or sets a value of the IsRunning property in busy indicator. It determines whether the animation of indicator to be shown or not.</td></tr>
<tr>
<td>Duration</td>
<td>DurationFactor</td>
<td>Gets or sets the value of the duration property. It is used to change the speed of animation to finish a cycle.</td></tr>
<tr>
<td>ViewBoxWidth ViewBoxHeight</td>
<td>SizeFactor</td>
<td>Gets or set the size factor of the indicator. This is not applicable for all animation types.</td></tr>
<tr>
<td>TextSize</td>
<td>FontSize</td>
<td>Gets or sets the font size of the title text.</td></tr>
</table> 
