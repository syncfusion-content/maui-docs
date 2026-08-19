---
layout: post
title: Properties of .NET MAUI Expander control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Expander (SfExpander) control.
platform: maui
control: SfExpander
documentation: ug
---

# API Reference for .NET MAUI Expander

## Properties

<table>
<tr>
<th>Name</th>
<th>Type</th>
<th>Description</th>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationDuration" aria-label="View AnimationDuration property in API reference">AnimationDuration</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
<td>Defines the duration, in milliseconds, used for the expand and collapse animation. Larger values produce a slower transition, while smaller values create a quicker visual change.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_AnimationEasing" aria-label="View AnimationEasing property in API reference">AnimationEasing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.easing" aria-label="View Easing type in API reference">Easing</a></td>
<td>Defines the easing curve used for the expand and collapse animation and controls how the motion accelerates and decelerates during transition.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Content" aria-label="View Content property in API reference">Content</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Defines the content displayed inside the expander body and represents the region that becomes visible when the control is expanded.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_EnableLiquidGlassEffect" aria-label="View EnableLiquidGlassEffect property in API reference">EnableLiquidGlassEffect</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the <code>liquid glass</code> effect is enabled and applies a refined translucent appearance to the expander surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Header" aria-label="View Header property in API reference">Header</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
<td>Defines the header displayed for the expander and provides the visible area that triggers expansion and collapse behavior.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderBackground" aria-label="View HeaderBackground property in API reference">HeaderBackground</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
<td>Defines the background used for the expander header and controls the visual styling applied to the header surface.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconColor" aria-label="View HeaderIconColor property in API reference">HeaderIconColor</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
<td>Defines the color of the header icon and controls the appearance of the expand and collapse indicator.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_HeaderIconPosition" aria-label="View HeaderIconPosition property in API reference">HeaderIconPosition</a></td>
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpanderIconPosition.html" aria-label="View ExpanderIconPosition enum in API reference">ExpanderIconPosition</a></td>
<td>Defines the position of the header icon by using the <code>ExpanderIconPosition</code> enum and controls whether the indicator appears at the <code>Start</code> or <code>End</code> of the header.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_IsExpanded" aria-label="View IsExpanded property in API reference">IsExpanded</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
<td>Determines whether the expander content is expanded and reflects the current open or collapsed state of the control.</td>
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
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsed" aria-label="View Collapsed event in API reference">Collapsed</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
<td>Raised after the expander content has collapsed and provides the final collapse state for post-action handling.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Collapsing" aria-label="View Collapsing event in API reference">Collapsing</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs&gt;</a></a></td>
<td>Raised before the expander content collapses and allows the pending collapse operation to be observed or canceled.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanded" aria-label="View Expanded event in API reference">Expanded</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandedAndCollapsedEventArgs.html" aria-label="View ExpandedAndCollapsedEventArgs type in API reference">ExpandedAndCollapsedEventArgs&gt;</a></a></td>
<td>Raised after the expander content has expanded and signals that the body content is fully visible.</td>
</tr>

<tr valign="top">
<td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.SfExpander.html#Syncfusion_Maui_Expander_SfExpander_Expanding" aria-label="View Expanding event in API reference">Expanding</a></td>
<td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Expander.ExpandingAndCollapsingEventArgs.html" aria-label="View ExpandingAndCollapsingEventArgs type in API reference">ExpandingAndCollapsingEventArgs</a></td>
<td>Raised before the expander content expands and provides a point to inspect or adjust the expansion process.</td>
</tr>

</table>
