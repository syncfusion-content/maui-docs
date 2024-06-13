---
layout: post
title: Accessibility in .NET MAUI Image Editor Control | Syncfusion
description: Learn here about performing actions using accessibility in Syncfusion .NET MAUI Image Editor (SfImageEditor) control.
platform: maui
control: SfImageEditor
documentation: ug
---

# Accessibility in .NET MAUI Image Editor (SfImageEditor)

The Image Editor is designed to work effectively with the icons and sliders on its toolbar, providing voice descriptions of their names, and functions.

## Keyboard shortcuts in .NET MAUI Image Editor (SfImageEditor)

The [Syncfusion .NET MAUI Image Editor](https://www.syncfusion.com/maui-controls/maui-image-editor) supports keyboard shortcuts for user interaction. The table provided outlines various shortcuts and their associated functions.

N> [ToolbarItemSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ToolbarItemSelected) event triggers for toolbar item tapped.

#### Toolbar

<table>
<tr>
<td>
<b> Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Tab<br/><br/></td><td>Moves selection to the next focusable toolbar item. 
<br/><br/></td></tr>
<tr>
<td>
Shift + Tab<br/><br/></td><td>
Moves selection to the previous focusable toolbar item. 
<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
It triggers {{'[ToolbarItemSelected](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ToolbarItemSelected)'| markdownify}} event<br/><br/></td></tr>
<tr>
<td>
Ctrl + Z<br/><br/></td><td>
Reverse the most recent action performed on the image editor. 
<br/><br/></td></tr>
<tr>
<td>
Ctrl + Y<br/><br/></td><td>
Restores the last undone action.
<br/><br/></td></tr>
<tr>
<td>
Ctrl + S<br/><br/></td><td>
Save the current image. 
<br/><br/></td></tr>
<tr>
<td>
Ctrl + O<br/><br/></td><td>
Opens the image browser to import the new image inside ImageEditor. 
<br/><br/></td></tr>
</table>

N> Use the `Command` key instead of the `Ctrl` key in macOS.
