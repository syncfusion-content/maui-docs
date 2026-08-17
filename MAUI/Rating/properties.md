---
layout: post
title: Properties of .NET MAUI Rating control | Syncfusion®
description: This section explains the properties and events with Syncfusion® MAUI Rating (SfRating) control.
platform: maui
control: SfRating
documentation: ug
---

# .NET MAUI Rating API Reference

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_BackgroundColor" aria-label="View BackgroundColor property in API reference">BackgroundColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Defines the background color applied to the rating control and establishes the visual base behind the rating items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_IsReadOnly" aria-label="View IsReadOnly property in API reference">IsReadOnly</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the rating value can be changed through interaction and keeps the current value fixed when set to <code>true</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount" aria-label="View ItemCount property in API reference">ItemCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Defines the total number of rating items displayed and controls how many visual units are available for selection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSize" aria-label="View ItemSize property in API reference">ItemSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the size of each rating item and controls the rendered scale of the star, heart, or custom shape.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the spacing between rating items and controls the visual separation across the control surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Path" aria-label="View Path property in API reference">Path</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Defines the custom shape path used to render rating items and allows a fully custom glyph outline to be displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Precision" aria-label="View Precision property in API reference">Precision</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html" aria-label="View Precision enum in API reference">Precision</a></td>
    <td>Defines the selection precision by using the <code>Precision</code> enum and controls whether values are captured in whole steps, partial steps, or finer intervals.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_RatingSettings" aria-label="View RatingSettings property in API reference">RatingSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html" aria-label="View RatingSettings type in API reference">RatingSettings</a></td>
    <td>Defines the appearance settings applied to the rating items and provides control over the visual behavior of the selected and unselected states.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_RatingShape" aria-label="View RatingShape property in API reference">RatingShape</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingShape.html" aria-label="View RatingShape enum in API reference">RatingShape</a></td>
    <td>Defines the shape used to display rating items by using the <code>RatingShape</code> enum and controls whether the control renders stars, hearts, or other built-in shapes.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Value" aria-label="View Value property in API reference">Value</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the current rating value and reflects the selected score represented by the control.</td>
</tr>
</table>

## Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ValueChanged" aria-label="View ValueChanged event in API reference">ValueChanged</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ValueChangedEventArgs.html" aria-label="View ValueChangedEventArgs type in API reference">ValueChangedEventArgs</a></td>
    <td>Raised when the rating value changes and provides the updated rating information for handling selection updates.</td>
</tr>
</table>
