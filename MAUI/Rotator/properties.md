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
    <td>Executes a command when a rotator item is tapped, making it easy to connect item interactions to application logic.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_CommandParameter" aria-label="View CommandParameter property in API reference">CommandParameter</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Supplies additional data when the associated command is executed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotPlacement" aria-label="View DotPlacement property in API reference">DotPlacement</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.DotsPlacement.html" aria-label="View DotPlacement enum in API reference">DotPlacement</a></td>
    <td>Controls where the navigation dots are displayed relative to the rotator content using the supported <code>DotPlacement</code> values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_DotsStroke" aria-label="View DotsStroke property in API reference">DotsStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Customizes the outline appearance of the navigation dots.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableAutoPlay" aria-label="View EnableAutoPlay property in API reference">EnableAutoPlay</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Automatically advances through rotator items at regular intervals.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableLooping" aria-label="View EnableLooping property in API reference">EnableLooping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Allows navigation to continue from the last item back to the first item and from the first item to the last item without stopping.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_EnableSwiping" aria-label="View EnableSwiping property in API reference">EnableSwiping</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Allows users to navigate between items using swipe gestures.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_IsTextVisible" aria-label="View IsTextVisible property in API reference">IsTextVisible</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Shows or hides the text associated with rotator items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td>Generates rotator items from a bound data collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Replaces the default item presentation with a custom layout for each rotator item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonBackground" aria-label="View NavigationButtonBackground property in API reference">NavigationButtonBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Customizes the background appearance of the previous and next navigation buttons.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationButtonIcon" aria-label="View NavigationButtonIcon property in API reference">NavigationButtonIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.imagesource" aria-label="View ImageSource type in API reference">ImageSource</a></td>
    <td>Replaces the default navigation button icon with custom imagery.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDelay" aria-label="View NavigationDelay property in API reference">NavigationDelay</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Controls the delay between automatic item transitions, in milliseconds, when autoplay is enabled. Higher values produce slower automatic navigation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationDirection" aria-label="View NavigationDirection property in API reference">NavigationDirection</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationDirection.html" aria-label="View RotatorNavigationDirection enum in API reference">NavigationDirection</a></td>
    <td>Controls whether items are navigated horizontally or vertically using the supported <code>NavigationDirection</code> values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationStripMode" aria-label="View NavigationStripMode property in API reference">NavigationStripMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationStripMode.html" aria-label="View NavigationStripMode enum in API reference">NavigationStripMode</a></td>
    <td>Controls how navigation indicators are displayed using the supported <code>NavigationStripMode</code> values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_NavigationStripPosition" aria-label="View NavigationStripPosition property in API reference">NavigationStripPosition</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.Rotator.NavigationStripPosition.html" aria-label="View NavigationStripPosition enum in API reference">NavigationStripPosition</a></td>
    <td>Controls where the navigation strip is displayed around the rotator content using the supported <code>NavigationStripPosition</code> values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedDotColor" aria-label="View SelectedDotColor property in API reference">SelectedDotColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Customizes the appearance of the navigation dot that represents the currently displayed item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Controls which rotator item is currently displayed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedThumbnailStroke" aria-label="View SelectedThumbnailStroke property in API reference">SelectedThumbnailStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Customizes the border appearance of the selected thumbnail.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_ShowNavigationButton" aria-label="View ShowNavigationButton property in API reference">ShowNavigationButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Shows or hides the previous and next navigation buttons.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedDotColor" aria-label="View UnselectedDotColor property in API reference">UnselectedDotColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Customizes the appearance of navigation dots that do not represent the currently displayed item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_UnselectedThumbnailStroke" aria-label="View UnselectedThumbnailStroke property in API reference">UnselectedThumbnailStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Customizes the border appearance of unselected thumbnails.</td>
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
    <td>Moves to the next item in the rotator. If looping is enabled, navigating past the last item continues from the first item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Previous" aria-label="View Previous method in API reference">Previous()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves to the previous item in the rotator. If looping is enabled, navigating before the first item continues from the last item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_Refresh" aria-label="View Refresh method in API reference">Refresh()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Reloads the rotator content and reapplies item templates and visual updates.</td>
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
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.ItemTappedEventArgs.html" aria-label="View ItemTappedEventArgs type in API reference">ItemTappedEventArgs&gt;</a></a></td>
    <td>Triggered when a user taps a rotator item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SfRotator.html#Syncfusion_Maui_Rotator_SfRotator_SelectedIndexChanged" aria-label="View SelectedIndexChanged event in API reference">SelectedIndexChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Rotator.SelectedIndexChangedEventArgs.html" aria-label="View SelectedIndexChangedEventArgs type in API reference">SelectedIndexChangedEventArgs&gt;</a></a></td>
    <td>Triggered after the displayed rotator item changes.</td>
</tr>
</table>