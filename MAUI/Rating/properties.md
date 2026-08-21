---
layout: post
title: Properties of .NET MAUI Rating control | Syncfusion®
description: This section explains the properties and events with Syncfusion<sup>&reg;</sup> MAUI Rating (SfRating) control.
platform: maui
control: SfRating
documentation: ug
---

# API Reference for .NET MAUI Rating

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
    <td>Customizes the background behind the rating items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_IsReadOnly" aria-label="View IsReadOnly property in API reference">IsReadOnly</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Displays the current rating without allowing users to change it through touch or pointer interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemCount" aria-label="View ItemCount property in API reference">ItemCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Controls how many rating items are displayed and defines the maximum rating that can be selected.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSize" aria-label="View ItemSize property in API reference">ItemSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the size of each rating item, such as a star, heart, or custom shape.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the spacing between adjacent rating items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Path" aria-label="View Path property in API reference">Path</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Replaces the built-in rating shape with a custom vector path.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Precision" aria-label="View Precision property in API reference">Precision</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.Precision.html" aria-label="View Precision enum in API reference">Precision</a></td>
    <td>Controls how rating values are selected using the supported <code>Precision</code> values, such as whole-item or partial-item ratings.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_RatingSettings" aria-label="View RatingSettings property in API reference">RatingSettings</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingSettings.html" aria-label="View RatingSettings type in API reference">RatingSettings</a></td>
    <td>Customizes the appearance of rating items in their selected, unselected, and hover states.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_RatingShape" aria-label="View RatingShape property in API reference">RatingShape</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingShape.html" aria-label="View RatingShape enum in API reference">RatingShape</a></td>
    <td>Selects the shape used for rating items using the supported <code>RatingShape</code> values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_Value" aria-label="View Value property in API reference">Value</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the current rating displayed by the control.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.ValueChangedEventArgs.html" aria-label="View ValueChangedEventArgs type in API reference">ValueChangedEventArgs&gt;</a></a></td>
    <td>Triggered after the rating value changes.</td>
</tr>
</table>
