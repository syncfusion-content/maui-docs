---
layout: post
title: Properties of .NET MAUI Carousel View control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Carousel View (SfCarousel) control.
platform: maui
control: SfCarousel
documentation: ug
---

# API Reference for .NET MAUI Carousel View

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_AllowLoadMore" aria-label="View AllowLoadMore property in API reference">AllowLoadMore</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether more <code>items</code> can be fetched and appended on <code>demand</code> as the user reaches the end of the <code>carousel</code>. Requires <code>LoadMoreItemsCount</code> to define the <code>batch size</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Duration" aria-label="View Duration property in API reference">Duration</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Controls how long the <code>item transition animation</code> runs, in <code>milliseconds</code>. Larger values produce <code>slower</code>, <code>smoother</code> movement between items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableInteraction" aria-label="View EnableInteraction property in API reference">EnableInteraction</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether the user can <code>navigate items</code> using <code>touch</code>, <code>swipe</code>, or <code>drag gestures</code>. Set this to <code>false</code> for <code>read-only</code> display.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_EnableVirtualization" aria-label="View EnableVirtualization property in API reference">EnableVirtualization</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Controls whether <code>item virtualization</code> is used. Enable this to improve <code>performance</code> with very large <code>item collections</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Height</code> of each <code>carousel item</code> when a <code>fixed item layout</code> is used. Adjusts the <code>vertical space</code> occupied by every visible item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemSpacing" aria-label="View ItemSpacing property in API reference">ItemSpacing</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Spacing</code> between neighboring <code>carousel items</code>. Larger values add more <code>horizontal separation</code> between items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" aria-label="View IEnumerable&lt;object&gt; type in API reference">IEnumerable&lt;object&gt;</a></td>
    <td><code>Collection</code> of <code>items</code> displayed in the <code>carousel</code>. Each item is rendered using the <code>ItemTemplate</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> used to render each <code>carousel item</code>. Use this to define how every item appears.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ItemWidth" aria-label="View ItemWidth property in API reference">ItemWidth</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Width</code> of each <code>carousel item</code> when a <code>fixed item layout</code> is used. Adjusts the <code>horizontal size</code> of every visible item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreItemsCount" aria-label="View LoadMoreItemsCount property in API reference">LoadMoreItemsCount</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Number of <code>items</code> appended each time <code>load-more</code> is triggered or <code>LoadMore</code> is called. Increase this to fetch larger <code>batches</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMoreTemplate" aria-label="View LoadMoreTemplate property in API reference">LoadMoreTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td><code>Template</code> shown for the <code>load-more indicator</code> while additional <code>items</code> are being appended.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_Offset" aria-label="View Offset property in API reference">Offset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Spacing</code> applied between <code>adjacent items</code> in the <code>carousel layout</code>. Higher values create more <code>space</code> between items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_RotationAngle" aria-label="View RotationAngle property in API reference">RotationAngle</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td>Rotation, in <code>degrees</code>, applied to <code>items</code> as they move into or out of the <code>selected position</code>. Use this to create a <code>tilted</code> or <code>3D</code> appearance.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ScaleOffset" aria-label="View ScaleOffset property in API reference">ScaleOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Scale difference</code> between the <code>selected item</code> and its <code>neighbors</code>. Higher values make neighboring items appear <code>smaller</code> relative to the <code>selected one</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedIndex" aria-label="View SelectedIndex property in API reference">SelectedIndex</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View Int32 type in API reference">int</a></td>
    <td><code>Index</code> of the <code>active item</code> in the <code>carousel</code>. Changing this value updates the <code>selected item</code> and scrolls it into view.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedItem" aria-label="View SelectedItem property in API reference">SelectedItem</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td><code>Active item</code> in the <code>carousel</code>. Reading or setting this updates the <code>SelectedIndex</code> in sync.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectedItemOffset" aria-label="View SelectedItemOffset property in API reference">SelectedItemOffset</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td><code>Position offset</code> applied to the <code>selected item</code> along the <code>layout axis</code>. Use this to <code>fine-tune</code> the placement of the <code>active item</code> within the carousel.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeMovementMode" aria-label="View SwipeMovementMode property in API reference">SwipeMovementMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SwipeMovementMode.html" aria-label="View SwipeMovementMode type in API reference">SwipeMovementMode</a></td>
    <td>Controls how <code>swipe gestures</code> navigate between <code>items</code>. Choose a supported <code>SwipeMovementMode</code> value to define the <code>navigation behavior</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_ViewMode" aria-label="View ViewMode property in API reference">ViewMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.ViewMode.html" aria-label="View ViewMode type in API reference">ViewMode</a></td>
    <td>Defines the overall <code>arrangement</code> of <code>items</code> in the <code>carousel</code>. Choose a supported <code>ViewMode</code> value to control the <code>layout style</code>.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_LoadMore" aria-label="View LoadMore method in API reference">LoadMore()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Triggers <code>loading</code> of additional <code>items</code> immediately and appends them to the <code>carousel</code>. The number of items added is controlled by <code>LoadMoreItemsCount</code>.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_MoveNext" aria-label="View MoveNext method in API reference">MoveNext()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves <code>selection</code> to the <code>next item</code> in the <code>carousel</code>. If the <code>current item</code> is the <code>last one</code>, selection remains unchanged.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_MovePrevious" aria-label="View MovePrevious method in API reference">MovePrevious()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.void" aria-label="View Void type in API reference">void</a></td>
    <td>Moves <code>selection</code> to the <code>previous item</code> in the <code>carousel</code>. If the <code>current item</code> is the <code>first one</code>, selection remains unchanged.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SelectionChangedEventArgs.html" aria-label="View SelectionChangedEventArgs type in API reference">SelectionChangedEventArgs</a>&gt;</a></td>
    <td>Triggered when the <code>selected item</code> changes, providing details about the <code>newly selected</code> and <code>previously selected</code> items.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeStarted" aria-label="View SwipeStarted event in API reference">SwipeStarted</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SwipeStartedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SwipeStartedEventArgs.html" aria-label="View SwipeStartedEventArgs type in API reference">SwipeStartedEventArgs</a>&gt;</a></td>
    <td>Triggered when a <code>swipe gesture</code> begins. Use this to track the <code>start of user interaction</code> or prepare the <code>UI</code> for the transition.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Carousel.SfCarousel.html#Syncfusion_Maui_Carousel_SfCarousel_SwipeEnded" aria-label="View SwipeEnded event in API reference">SwipeEnded</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Triggered when the <code>swipe gesture</code> completes. Use this to <code>finalize</code> interaction state or <code>refresh</code> visible content after the swipe.</td>
</tr>
</table>
