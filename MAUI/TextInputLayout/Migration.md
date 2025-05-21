---
layout: post
title: Migrating from Xamarin to .NET MAUI SfTextInputLayout | Syncfusion® 
description: Learn about migrating from Syncfusion® Xamarin TextInputLayout to Syncfusion® .NET MAUI TextInputLayout control and more.
platform: maui
control: SfTextInputLayout
documentation: ug
keywords: .net maui text input layout, syncfusion text input layout, text input layout maui
---  

# Migrating from Xamarin TextInputLayout to .NET MAUI TextInputLayout

Migrating from Xamarin SfTextInputLayout to .NET MAUI SfTextInputLayout is facilitated by retaining most of the APIs from Xamarin. However, to maintain consistency in API naming conventions in .NET MAUI, some APIs have been renamed. The following sections detail the changes:
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

There is a known issue in .NET 8.0 where manually input values do not update the stroke value due to an implicit style not being overridden. You can resolve this by setting the stroke value using the Visual State Manager (VSM) through style. For more details, refer to this [link](https://github.com/dotnet/maui/issues/18103).
