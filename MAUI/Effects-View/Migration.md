---
layout: post
title: Migrating from Xamarin to .NET MAUI SfEffectsView | Syncfusion® 
description: Learn here all about migrating from Syncfusion® Xamarin Effects View to Syncfusion® .NET MAUI Effects View control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---  

# Migrating from Xamarin SfEffectsView to .NET MAUI SfEffectsView 

To ease the migration from Xamarin SfEffectsView to .NET MAUI SfEffectsView, most APIs from Xamarin SfEffectsView have been retained in MAUI SfEffectsView. However, to maintain API naming consistency in MAUI SfEffectsView, some APIs have been renamed. The changes in MAUI SfEffectsView from Xamarin SfEffectsView are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfEffectsView</th>
<th>.NET MAUI SfEffectsView</th></tr>
<tr>
<td>Syncfusion.XForms.EffectsView</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfEffectsView</th>
<th>.NET MAUI SfEffectsView</th>
<th>Description</th></tr>
<tr>
<td>{{'[AutoResetEffect](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.EffectsView.SfEffectsView.html#Syncfusion_XForms_EffectsView_SfEffectsView_AutoResetEffect)'| markdownify }}</td>
<td>{{'[AutoResetEffects](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_AutoResetEffects)'| markdownify }}</td>
<td>Gets or sets the effect that starts rendering on touch down and starts removing on touch up in Android and UWP platforms.</td></tr>
<tr>
<td>{{'[HighlightColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.EffectsView.SfEffectsView.html#Syncfusion_XForms_EffectsView_SfEffectsView_HighlightColor)'| markdownify }}</td>
<td>{{'[HighlightBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_HighlightBackground)'| markdownify }}</td>
<td>Gets or sets the brush to highlight the Effects View.</td></tr>
<tr>
<td>{{'[RippleColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.EffectsView.SfEffectsView.html#Syncfusion_XForms_EffectsView_SfEffectsView_RippleColor)' | markdownify }}</td>
<td>{{'[RippleBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RippleBackground)'| markdownify }}</td>
<td>Gets or sets the brush of the ripple.</td></tr>
<tr>
<td>{{'[SelectionColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.EffectsView.SfEffectsView.html#Syncfusion_XForms_EffectsView_SfEffectsView_SelectionColor)' | markdownify }}</td>
<td>{{'[SelectionBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_SelectionBackground)'| markdownify }}</td>
<td>Gets or sets the brush applied when the view is in the selected state.</td></tr>
</table> 

## Enums

<table>
<tr>
<th>Enum</th>
<th>Xamarin SfEffectsView</th>
<th>.NET MAUI SfEffectsView</th>
<th>Description</th></tr>
<tr>
<td>RippleStartPosition</td>
<td>Bottom,<br/>Default,<br/>Left,<br/>Right,<br/>Top</td>
<td>Bottom,<br/>BottomLeft,<br/>BottomRight,<br/>Default,<br/>Left,<br/>Right,<br/>Top,<br/>TopLeft,<br/>TopRight</td>
<td>Specifies the start position of the ripple effects.</td></tr>
</table>
