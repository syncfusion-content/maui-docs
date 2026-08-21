---
layout: post
title: Properties of .NET MAUI Parallax View control | Syncfusion®
description: This section explains the properties with Syncfusion<sup>&reg;</sup> MAUI Parallax View (SfParallaxView) control.
platform: maui
control: SfParallaxView
documentation: ug
---

# API Reference for .NET MAUI Parallax View

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Content" aria-label="View Content property in API reference">Content</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>View</code> displayed as the <code>foreground</code> or <code>background visual</code> that shifts with the <code>parallax effect</code>. Use it to host <code>images</code>, <code>gradients</code>, or any <code>visual element</code> that should appear at a different <code>scroll speed</code> than the <code>source</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Orientation" aria-label="View Orientation property in API reference">Orientation</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.Orientation.html" aria-label="View ParallaxOrientation enum in API reference">ParallaxOrientation</a></td>
    <td><code>Direction</code> in which the <code>parallax movement</code> is applied. Choose a supported <code>ParallaxOrientation</code> value such as <code>Horizontal</code> or <code>Vertical</code> to align the <code>parallax motion</code> with the <code>source's scroll axis</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Source" aria-label="View Source property in API reference">Source</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Scrollable <code>view</code> whose <code>scrolling offset</code> drives the <code>parallax movement</code>. Set this to a <code>ScrollView</code>, <code>CollectionView</code>, or <code>ListView</code> whose <code>scroll position</code> controls how the <code>parallax Content shifts</code>. If no <code>source</code> is provided, the <code>parallax effect</code> does not <code>activate</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ParallaxView.SfParallaxView.html#Syncfusion_Maui_ParallaxView_SfParallaxView_Speed" aria-label="View Speed property in API reference">Speed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Multiplier</code> that controls how far the <code>Content</code> shifts relative to the <code>source's scroll position</code>. Values between <code>0</code> and <code>1</code> produce a <code>subtler parallax</code>; values greater than <code>1</code> <code>exaggerate the movement</code>.</td>
</tr>
</table>