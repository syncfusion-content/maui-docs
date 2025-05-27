---
layout: post
title: "Migrating from Xamarin to .NET MAUI Button | Syncfusion®"
description: "Learn about migrating from the Syncfusion® Xamarin Button to the Syncfusion® .NET MAUI Button control."
platform: maui
control: SfButton
documentation: ug
---  

# Migrating from Xamarin SfButton to .NET MAUI SfButton 

To facilitate an easier migration from Xamarin SfButton to the [.NET MAUI SfButton](https://www.syncfusion.com/maui-controls/maui-button), most APIs from the Xamarin SfButton have been retained in the MAUI version. However, some APIs have been renamed to maintain consistency in naming within the MAUI SfButton. The changes in API names between MAUI and Xamarin SfButton are detailed below:

## Namespaces 

<table>
<tr>
<th>Xamarin SfButton</th>
<th>.NET MAUI SfButton</th></tr>
<tr>
<td>Syncfusion.XForms.Buttons</td>
<td>Syncfusion.Maui.Buttons</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfButton</th>
<th>.NET MAUI SfButton</th>
<th>Description</th></tr>
<tr>
<td> {{'[BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BorderWidth)'| markdownify }}</td>
<td> {{'[StrokeThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_StrokeThickness)'| markdownify }}</td>
<td>Gets or sets the stroke thickness.</td></tr>
<tr>
<td> {{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BorderColor)'| markdownify }}</td>
<td> {{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_Stroke)'| markdownify }}</td>
<td>Gets or sets the color of the border.</td></tr>
<tr>
<td> {{'[BackgroundImage](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BackgroundImage)'| markdownify }}</td>
<td> {{'[BackgroundImageSource](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_BackgroundImageSource)'| markdownify }} </td>
<td>Gets or sets the background image in Button.</td></tr>
<tr>
<td> {{'[ImageWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_ImageWidth)'| markdownify }}</td>
<td> {{'[ImageSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ButtonBase.html#Syncfusion_Maui_Core_ButtonBase_ImageSize)'| markdownify }}</td>
<td>Gets or sets the image size in Button.</td></tr>
</table> 

## Known Issues

The gradient colors used as a background are not functioning as expected because of a framework-level issue. This issue is specifically related to the incorrect rendering of gradient color on iOS and macOS when clipping a view. Refer to this [link](https://github.com/dotnet/maui/issues/18671) for more details.

