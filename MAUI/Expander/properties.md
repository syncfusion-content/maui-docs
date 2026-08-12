---
layout: post
title: Properties of .NET MAUI Expander control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Expander (SfExpander) control.
platform: maui
control: SfExpander
documentation: ug
---

# .NET MAUI Expander API Reference

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration">AnimationDuration</a></td>
<td>double</td>
<td>Defines the duration of the expand and collapse animation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing">AnimationEasing</a></td>
<td>Easing</td>
<td>Defines the easing function used for the expand and collapse animation.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content">Content</a></td>
<td>View</td>
<td>Defines the content displayed within the expander.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_EnableLiquidGlassEffect">EnableLiquidGlassEffect</a></td>
<td>bool</td>
<td>Defines whether the liquid glass effect is enabled.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header">Header</a></td>
<td>View</td>
<td>Defines the header displayed for the expander.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderBackground">HeaderBackground</a></td>
<td>Brush</td>
<td>Defines the background of the expander header.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconColor">HeaderIconColor</a></td>
<td>Color</td>
<td>Defines the color of the header icon.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconPosition">HeaderIconPosition</a></td>
<td>ExpanderIconPosition</td>
<td>Defines the position of the header icon.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded">IsExpanded</a></td>
<td>bool</td>
<td>Defines whether the expander content is expanded.</td>
</tr>

</table>

## Methods

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html">AnimationCompleted()</a></td>
<td>void</td>
<td>Invoked when the expand or collapse animation is completed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html">RaiseCollapsedEvent()</a></td>
<td>void</td>
<td>Raises the collapsed event.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html">RaiseCollapsingEvent()</a></td>
<td>void</td>
<td>Raises the collapsing event.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html">RaiseExpandedEvent()</a></td>
<td>void</td>
<td>Raises the expanded event.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html">RaiseExpandingEvent()</a></td>
<td>void</td>
<td>Raises the expanding event.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed">Collapsed</a></td>
<td>EventHandler</td>
<td>Raised when the expander content is collapsed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing">Collapsing</a></td>
<td>EventHandler</td>
<td>Raised before the expander content is collapsed.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded">Expanded</a></td>
<td>EventHandler</td>
<td>Raised when the expander content is expanded.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding">Expanding</a></td>
<td>EventHandler</td>
<td>Raised before the expander content is expanded.</td>
</tr>

</table>
