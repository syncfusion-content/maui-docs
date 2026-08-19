---
layout: post
title: Properties of .NET MAUI Chip control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Chip (SfChip) control.
platform: maui
control: SfChip
documentation: ug
---

# API Reference for .NET MAUI Chip 

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonColor" aria-label="View CloseButtonColor property in API reference">CloseButtonColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Color used for the close button icon. Use a high-contrast color so the button remains easy to identify.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonPath" aria-label="View CloseButtonPath property in API reference">CloseButtonPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Path data used to draw the close button icon. This lets you customize the icon shape shown inside the chip.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_IsSelected" aria-label="View IsSelected property in API reference">IsSelected</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the chip is currently selected. Set this to true to show the selected state programmatically.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_SelectionIndicatorColor" aria-label="View SelectionIndicatorColor property in API reference">SelectionIndicatorColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Color applied to the selection indicator shown on the chip. Use a visible color to make the selection state clear.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ShowCloseButton" aria-label="View ShowCloseButton property in API reference">ShowCloseButton</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the close button is shown on the chip. Enable this when users should be able to remove the chip.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_ShowSelectionIndicator" aria-label="View ShowSelectionIndicator property in API reference">ShowSelectionIndicator</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether the selection indicator is displayed on the chip. Use this to visually highlight the active chip.</td>
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
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html#Syncfusion_Maui_Core_SfChip_CloseButtonClicked" aria-label="View CloseButtonClicked event in API reference">CloseButtonClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler" aria-label="View EventHandler type in API reference">EventHandler</a></td>
    <td>Raised when the close button is clicked. Use this event to remove the chip or trigger a related action.</td>
</tr>
</table>

## Chip Group

### Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipBackground" aria-label="View ChipBackground property in API reference">ChipBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Background brush applied to chips in the group. Use it to match the chip surface with the app theme.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipCornerRadius" aria-label="View ChipCornerRadius property in API reference">ChipCornerRadius</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.cornerradius" aria-label="View CornerRadius type in API reference">CornerRadius</a></td>
    <td>Corner radius applied to chips in the group. Larger values create a more rounded chip shape.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipFontAttributes" aria-label="View ChipFontAttributes property in API reference">ChipFontAttributes</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.fontattributes" aria-label="View FontAttributes type in API reference">FontAttributes</a></td>
    <td>Font styling applied to chip text. Use this to make chip labels bold, italic, or plain.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipFontFamily" aria-label="View ChipFontFamily property in API reference">ChipFontFamily</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Font family used for chip text. The selected font is applied to every chip in the group.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipImageSize" aria-label="View ChipImageSize property in API reference">ChipImageSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Size of images displayed inside chips. Increase this value to make chip icons more prominent.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipLayout" aria-label="View ChipLayout property in API reference">ChipLayout</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.layout" aria-label="View Layout type in API reference">Layout</a></td>
    <td>Layout used to arrange the chips. Assign a layout that matches the desired wrapping or alignment behavior.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipPadding" aria-label="View ChipPadding property in API reference">ChipPadding</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.thickness" aria-label="View Thickness type in API reference">Thickness</a></td>
    <td>Padding applied inside each chip. More padding gives the chip text and icon additional space.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStroke" aria-label="View ChipStroke property in API reference">ChipStroke</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Border brush applied to chips. Use this to define the outline style of the chip surface.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipStrokeThickness" aria-label="View ChipStrokeThickness property in API reference">ChipStrokeThickness</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Border thickness applied to chips. Larger values make the chip outline more visible.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipTextColor" aria-label="View ChipTextColor property in API reference">ChipTextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Text color used for chips. Choose a readable color that works well with the chip background.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipTextSize" aria-label="View ChipTextSize property in API reference">ChipTextSize</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Font size used for chip text. Larger values make the text easier to read.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipType" aria-label="View ChipType property in API reference">ChipType</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipsType.html" aria-label="View SfChipsType type in API reference">SfChipsType</a></td>
    <td>Type of chip displayed in the group. Choose a supported <code>SfChipsType</code> value to match the intended chip behavior and appearance.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChoiceMode" aria-label="View ChoiceMode property in API reference">ChoiceMode</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SelectionMode.html" aria-label="View SelectionMode type in API reference">SelectionMode</a></td>
    <td>Selection behavior used by the chip group. Choose a supported <code>SelectionMode</code> value to allow single or multiple chip selection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_CloseButtonColor" aria-label="View CloseButtonColor property in API reference">CloseButtonColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Color of the close button displayed in chips. Use a visible color so the action remains easy to find.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_DisplayMemberPath" aria-label="View DisplayMemberPath property in API reference">DisplayMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Property path used to display chip text from the data source. Use this when binding chips to a data collection.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ImageMemberPath" aria-label="View ImageMemberPath property in API reference">ImageMemberPath</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
    <td>Property path used to display chip images from the data source. This helps map image data to each chip.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_InputView" aria-label="View InputView property in API reference">InputView</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.view" aria-label="View View type in API reference">View</a></td>
    <td>Input view used to add or edit chips. Assign a custom view when the group must support chip entry or editing.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemHeight" aria-label="View ItemHeight property in API reference">ItemHeight</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View Double type in API reference">double</a></td>
    <td>Height of each chip item. Increase this value when chips need more vertical space for text or icons.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_Items" aria-label="View Items property in API reference">Items</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;SfChip&gt; type in API reference">IList&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html" aria-label="View SfChip type in API reference">SfChip</a>&gt;</a></td>
    <td>Collection of chip items contained in the group. Use this when chips are created and managed directly in code.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemsSource" aria-label="View ItemsSource property in API reference">ItemsSource</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.ienumerable" aria-label="View IEnumerable type in API reference">IEnumerable</a></td>
    <td>Data source used to generate chip items. Bind this to a collection when chips should be created from data.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemTemplate" aria-label="View ItemTemplate property in API reference">ItemTemplate</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.controls.datatemplate" aria-label="View DataTemplate type in API reference">DataTemplate</a></td>
    <td>Template used to customize chip appearance. Use this to define the visual content for each item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedChipBackground" aria-label="View SelectedChipBackground property in API reference">SelectedChipBackground</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.brush" aria-label="View Brush type in API reference">Brush</a></td>
    <td>Background brush applied to selected chips. Use this to visually distinguish selected items from unselected ones.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedChipTextColor" aria-label="View SelectedChipTextColor property in API reference">SelectedChipTextColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Text color used for selected chips. Choose a clear contrast color for the active state.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectedItem" aria-label="View SelectedItem property in API reference">SelectedItem</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.object" aria-label="View Object type in API reference">object</a></td>
    <td>Currently selected item in the group. Use this to read or set the active chip item.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionIndicatorColor" aria-label="View SelectionIndicatorColor property in API reference">SelectionIndicatorColor</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/microsoft.maui.graphics.color" aria-label="View Color type in API reference">Color</a></td>
    <td>Color of the selection indicator. Use it to highlight the active chip clearly.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ShowIcon" aria-label="View ShowIcon property in API reference">ShowIcon</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View Boolean type in API reference">bool</a></td>
    <td>Determines whether chip icons are displayed. Enable this when chips need to show an associated image or icon.</td>
</tr>
</table>

### Methods

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_GetChips" aria-label="View GetChips method in API reference">GetChips()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.ilist-1" aria-label="View IList&lt;SfChip&gt; type in API reference">IList&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChip.html" aria-label="View SfChip type in API reference">SfChip</a>&gt;</a></td>
    <td>Returns the current collection of chips in the group. Use this to inspect or manage chip items in code.</td>
</tr>
</table>

### Events

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ChipClicked" aria-label="View ChipClicked event in API reference">ChipClicked</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChipClickedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ChipClickedEventArgs.html" aria-label="View ChipClickedEventArgs type in API reference">ChipClickedEventArgs</a>&gt;</a></td>
    <td>Raised when a chip is clicked. Use this event to respond to chip selection or interaction.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_ItemRemoved" aria-label="View ItemRemoved event in API reference">ItemRemoved</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;ChipEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.ChipEventArgs.html" aria-label="View ChipEventArgs type in API reference">ChipEventArgs</a>&gt;</a></td>
    <td>Raised when a chip is removed from the group. This is useful for updating the data source after deletion.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanged" aria-label="View SelectionChanged event in API reference">SelectionChanged</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionChangedEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SelectionChangedEventArgs.html" aria-label="View SelectionChangedEventArgs type in API reference">SelectionChangedEventArgs</a>&gt;</a></td>
    <td>Raised when the selected chip changes. Use this event to react after the new selection is applied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfChipGroup.html#Syncfusion_Maui_Core_SfChipGroup_SelectionChanging" aria-label="View SelectionChanging event in API reference">SelectionChanging</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.eventhandler-1" aria-label="View EventHandler&lt;SelectionChangingEventArgs&gt; type in API reference">EventHandler&lt;<a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SelectionChangingEventArgs.html" aria-label="View SelectionChangingEventArgs type in API reference">SelectionChangingEventArgs</a>&gt;</a></td>
    <td>Raised before the selected chip changes. Use this event to validate or cancel the selection update.</td>
</tr>
</table>
