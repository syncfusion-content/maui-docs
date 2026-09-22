---
layout: post
title: Properties in .NET MAUI Backdrop Page | Syncfusion®
description: Learn about the properties, events, and methods available in Syncfusion® .NET MAUI Backdrop Page control for customization and configuration.
platform: maui
control: SfBackdropPage
documentation: ug
---

# API Reference for .NET MAUI Backdrop Page

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayer" aria-label="View BackLayer property in API reference">BackLayer</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackdropBackLayer.html" aria-label="View BackdropBackLayer type in API reference">BackdropBackLayer</a></td>
    <td>View placed behind the <code>front layer</code>. Secondary content, such as <code>navigation</code> or <code>filters</code>, is displayed in this layer.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayerRevealOption" aria-label="View BackLayerRevealOption property in API reference">BackLayerRevealOption</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.RevealOption.html" aria-label="View RevealOption type in API reference">RevealOption</a></td>
    <td>Controls how the <code>back layer</code> is revealed when <code>expanded</code>. <code>Fill</code> stretches the back layer to fill the entire page, while <code>Auto</code> sizes it to fit the height of its content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseIconImageSource" aria-label="View CloseIconImageSource property in API reference">CloseIconImageSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Custom image displayed for the <code>close</code> icon in the <code>navigation bar</code>. Use this to replace the default icon.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_CloseText" aria-label="View CloseText property in API reference">CloseText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Accessibility</code> text announced by <code>screen readers</code> for the <code>close</code> icon in the <code>navigation bar</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_Content" aria-label="View Content property in API reference">Content</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td><code>Root</code> view that hosts the page content. The page renders whatever is placed inside this view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_ControlTemplate" aria-label="View ControlTemplate property in API reference">ControlTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.controltemplate" aria-label="View ControlTemplate type in API reference">ControlTemplate</a></td>
    <td>Template that defines the <code>page layout</code>. Apply a custom template to restructure the appearance of the <code>backdrop page</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_FrontLayer" aria-label="View FrontLayer property in API reference">FrontLayer</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackdropFrontLayer.html" aria-label="View BackdropFrontLayer type in API reference">BackdropFrontLayer</a></td>
    <td>Primary view placed in front of the <code>back layer</code>. Main content is displayed in this layer.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_IsBackLayerRevealed" aria-label="View IsBackLayerRevealed property in API reference">IsBackLayerRevealed</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the <code>back layer</code> is currently revealed. When <code>true</code>, the back layer is <code>expanded</code> and visible above the <code>front layer</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenIconImageSource" aria-label="View OpenIconImageSource property in API reference">OpenIconImageSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Custom image displayed for the <code>open</code> icon in the <code>navigation bar</code>. Use this to replace the default icon.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_OpenText" aria-label="View OpenText property in API reference">OpenText</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td><code>Accessibility</code> text announced by <code>screen readers</code> for the <code>open</code> icon in the <code>navigation bar</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.SfBackdropPage.html#Syncfusion_Maui_Backdrop_SfBackdropPage_BackLayerStateChanged" aria-label="View BackLayerStateChanged event in API reference">BackLayerStateChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;BackLayerStateChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Backdrop.BackLayerStateChangedEventArgs.html" aria-label="View BackLayerStateChangedEventArgs type in API reference">BackLayerStateChangedEventArgs&gt;</a></a></td>
    <td>Triggered when the <code>back layer</code> is <code>revealed</code> or <code>concealed</code>, providing the current state of the back layer.</td>
</tr>
</table>