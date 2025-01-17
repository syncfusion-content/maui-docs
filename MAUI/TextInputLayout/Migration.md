---
layout: post
title: Migrating from Xamarin to .NET MAUI SfTextInputLayout | Syncfusion® 
description: Learn all about Migrating from Syncfusion® Xamarin TextInputLayout to Syncfusion® .NET MAUI TextInputLayout control and more here.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui.
---  

# Migrating from Xamarin TextInputLayout to .NET MAUI TextInputLayout.

To migrate easier from Xamarin SfTextInputLayout to .NET MAUI SfTextInputLayout, we kept most of the APIs from Xamarin SfTextInputLayout in MAUI SfTextInputLayout. However, to maintain the consistency of API naming in MAUI SfTextInputLayout, we renamed some of the APIs. The APIs changed in MAUI SfTextInputLayout from Xamarin SfTextInputLayout as detailed in the following:

## Namespaces 

<table>
<tr>
<th>Xamarin SfTextInputLayout</th>
<th>.NET MAUI SfTextInputLayout</th></tr>
<tr>
<td>Syncfusion.SfTextInputLayout.XForms</td>
<td>Syncfusion.Maui.Core</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfTextInputLayout</th>
<th>.NET MAUI SfTextInputLayout</th>
<th>Description</th></tr>
<tr>
<td>{{'[FocusedStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_FocusedStrokeWidth)'| markdownify }}</td>
<td>{{'[FocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_FocusedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets a value to customize the stroke thickness in a focused state. It is applicable for the bottom line and outline border when setting the container type as filled and outlined, respectively.</td></tr>
<tr>
<td>{{'[UnfocusedStrokeWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_UnfocusedStrokeWidth)'| markdownify }}</td>
<td>{{'[UnfocusedStrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_UnfocusedStrokeThickness)'| markdownify }}</td>
<td>Gets or sets a value to customize the stroke thickness in an unfocused state. It is applicable for the bottom line and outline border when setting the container type as filled and outlined, respectively.</td></tr>
<tr>
<td>{{'[ContainerBackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_ContainerBackgroundColor)'| markdownify }}</td>
<td>{{'[ContainerBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_ContainerBackground)'| markdownify }}</td>
<td>Gets or sets the background of the container.</td></tr>
<tr>
<td>{{'[InputView](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_InputView)'| markdownify }}</td>
<td>{{'[Content](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfContentView.html#Syncfusion_Maui_Core_SfContentView_Content)'| markdownify }}</td>
<td>Gets or sets the value for input view to place behind the hint label.</td></tr>
<tr>
<td>{{'[FocusedColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_FocusedColor)'| markdownify }}<br/>{{'[UnfocusedColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_UnfocusedColor)'| markdownify }}<br/>{{'[ErrorColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.SfTextInputLayout.html#Syncfusion_XForms_TextInputLayout_SfTextInputLayout_ErrorColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfTextInputLayout.html#Syncfusion_Maui_Core_SfTextInputLayout_Stroke)'| markdownify }}</td>
<td>Gets or sets the border color or base line color based on container and its states.</td></tr>
</table> 

<table>
<tr>
<th>Xamarin LabelStyle</th>
<th>.NET MAUI LabelStyle</th>
<th>Description</th></tr>
<tr>
<td>{{'[Color](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.TextInputLayout.LabelStyle.html#Syncfusion_XForms_TextInputLayout_LabelStyle_Color)'| markdownify }}</td>
<td>{{'[TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.LabelStyle.html#Syncfusion_Maui_Core_LabelStyle_TextColor)'| markdownify }}</td>
<td>Gets or sets the text color of the SfTextInputLayout controls label.</td></tr>
</table>


## Known Issues

Manually input values don't update the Stroke Value due to an issue at the framework level in .NET 8.0. This problem arises because the manual value doesn't override an implicit style. However, you can resolve this by setting the Stroke Value using the Visual State Manager (VSM) through Style. Refer to this [link](https://github.com/dotnet/maui/issues/18103) for more details.
