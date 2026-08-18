---
layout: post
title: Properties of .NET MAUI Rotator control | Syncfusion®
description: This section explains the properties, events and methods with Syncfusion® MAUI Rotator (SfRotator) control.
platform: maui
control: SfRotator
documentation: ug
---

# API Reference for .NET MAUI Rotator

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Command" aria-label="View Command property in API reference">Command</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.windows.input.icommand" aria-label="View ICommand type in API reference">ICommand</a></td>
    <td>Defines the command invoked when a rotator item is interacted with and supports connecting item interaction to application logic.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_CommandParameter" aria-label="View CommandParameter property in API reference">CommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Defines the parameter passed to the configured command and enables the selected item context to be forwarded during execution.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotPlacement" aria-label="View DotPlacement property in API reference">DotPlacement</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.DotsPlacement.html" aria-label="View DotPlacement enum in API reference">DotPlacement</a></td>
    <td>Defines the placement of the navigation dots by using the <code>DotPlacement</code> enum, which controls where the indicator row appears relative to the content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotsStroke" aria-label="View DotsStroke property in API reference">DotsStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the stroke applied to navigation dots and controls the outline style used for the indicator elements.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay" aria-label="View EnableAutoPlay property in API reference">EnableAutoPlay</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether items advance automatically at timed intervals and creates an animated presentation flow without manual navigation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableLooping" aria-label="View EnableLooping property in API reference">EnableLooping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether navigation wraps continuously from the last item back to the first item and keeps rotation cycling without interruption.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableSwiping" aria-label="View EnableSwiping property in API reference">EnableSwiping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether swipe gestures can change the displayed item and enables touch-based navigation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_IsTextVisible" aria-label="View IsTextVisible property in API reference">IsTextVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether item text is displayed alongside the visual content and controls the visibility of supporting labels.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td>Defines the collection of items displayed in the rotator and serves as the data source used to generate the rotating content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Defines the template used to render rotator items and enables custom visual layouts for each entry in the sequence.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonBackground" aria-label="View NavigationButtonBackground property in API reference">NavigationButtonBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the background of navigation buttons and controls the surface styling of the previous and next controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonIcon" aria-label="View NavigationButtonIcon property in API reference">NavigationButtonIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Defines the icon displayed inside navigation buttons and allows custom imagery for directional controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay" aria-label="View NavigationDelay property in API reference">NavigationDelay</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Defines the delay, in milliseconds, between automatic item transitions and controls the pacing of autoplay movement.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDirection" aria-label="View NavigationDirection property in API reference">NavigationDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html" aria-label="View RotatorNavigationDirection enum in API reference">NavigationDirection</a></td>
    <td>Defines the direction used for navigation by using the <code>NavigationDirection</code> enum and controls whether movement occurs horizontally or vertically.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationStripMode" aria-label="View NavigationStripMode property in API reference">NavigationStripMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationStripMode.html" aria-label="View NavigationStripMode enum in API reference">NavigationStripMode</a></td>
    <td>Defines the display mode of the navigation strip by using the <code>NavigationStripMode</code> enum and controls how dot indicators are presented.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationStripPosition" aria-label="View NavigationStripPosition property in API reference">NavigationStripPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationStripPosition.html" aria-label="View NavigationStripPosition enum in API reference">NavigationStripPosition</a></td>
    <td>Defines the position of the navigation strip by using the <code>NavigationStripPosition</code> enum and controls where the indicator bar is placed around the content.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedDotColor" aria-label="View SelectedDotColor property in API reference">SelectedDotColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Defines the color of the selected navigation dot and highlights the current item in the navigation sequence.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Defines the zero-based index of the currently selected item and identifies which rotator entry is active.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedThumbnailStroke" aria-label="View SelectedThumbnailStroke property in API reference">SelectedThumbnailStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the stroke applied to the selected thumbnail and provides a clear visual emphasis for the active item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ShowNavigationButton" aria-label="View ShowNavigationButton property in API reference">ShowNavigationButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether navigation buttons are displayed and controls the visibility of explicit next and previous controls.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedDotColor" aria-label="View UnselectedDotColor property in API reference">UnselectedDotColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Defines the color of unselected navigation dots and distinguishes inactive positions from the active indicator.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedThumbnailStroke" aria-label="View UnselectedThumbnailStroke property in API reference">UnselectedThumbnailStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Defines the stroke applied to unselected thumbnails and helps separate inactive items from the selected one.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Next" aria-label="View Next method in API reference">Next()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Advances the rotator to the next item and updates the active selection accordingly.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Previous" aria-label="View Previous method in API reference">Previous()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves the rotator to the previous item and updates the visible content to the prior entry.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Refresh" aria-label="View Refresh method in API reference">Refresh()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Refreshes the rotator and reapplies its visual state, item templates, and bound content.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTapped" aria-label="View ItemTapped event in API reference">ItemTapped</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs</a></td>
    <td>Raised when a rotator item is tapped and provides the tapped item details for interaction handling.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndexChanged" aria-label="View SelectedIndexChanged event in API reference">SelectedIndexChanged</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html" aria-label="View SelectedIndexChangedEventArgs type in API reference">SelectedIndexChangedEventArgs</a></td>
    <td>Raised when the selected item index changes and makes the new active position available for follow-up logic.</td>
</tr>
</table>