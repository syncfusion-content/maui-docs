---
layout: post
title: Accessibility in .NET MAUI Image Editor | Syncfusion®
description: Learn about accessibility features and keyboard shortcuts in Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Accessibility in .NET MAUI Image Editor

The Image Editor supports screen readers. Each toolbar item has a description that the screen reader announces when the item receives focus.

## Screen reader announcements

The following tables list the toolbar items and the text a screen reader announces for each.

### Main toolbar

| Toolbar item | Screen reader announcement |
|---|---|
| Browse | Browse Button |
| Undo | Undo Button |
| Redo | Redo Button |
| Zoom Out | Zoom Out Button |
| Zoom In | Zoom In Button |
| Reset | Reset Button |
| Save | Save Button |
| Crop | Crop Button |
| Shape | Shape Button |
| Text | Text Button |
| Pen | Pen Button |
| Effects | Effects Button |
| Back | Back Button |

### Crop and transform

| Toolbar item | Screen reader announcement |
|---|---|
| Custom Crop | Custom Crop Button* |
| Original Crop | Original Crop Button* |
| Square Crop | Square Crop Button* |
| Circle Crop | Circle Crop Button* |
| Ellipse Crop | Ellipse Crop Button* |
| 3:1 Crop | 3:1 Crop Button* |
| 3:2 Crop | 3:2 Crop Button* |
| 4:3 Crop | 4:3 Crop Button* |
| 5:4 Crop | 5:4 Crop Button* |
| 7:5 Crop | 7:5 Crop Button* |
| 16:9 Crop | 16:9 Crop Button* |
| Rotate | Rotate Button |
| Flip Horizontal | Flip Horizontal Button |
| Flip Vertical | Flip Vertical Button |

### Shapes

| Toolbar item | Screen reader announcement |
|---|---|
| Rectangle | Rectangle Shape Button* |
| Circle | Circle Shape Button* |
| Line | Line Shape Button* |
| Arrow | Arrow Shape Button* |
| Double Arrow | Double Arrow Shape Button* |
| Dotted Line | Dotted Line Shape Button* |
| Dotted Arrow | Dotted Arrow Shape Button* |
| Dotted Double Arrow | Dotted Double Arrow Shape Button* |
| Polygon | Polygon Shape Button* |
| Polyline | Polyline Shape Button* |

### Text

| Toolbar item | Screen reader announcement |
|---|---|
| Add Text | Add Text Button |
| Font Family | Font Family Button |
| Text Color | Text Color Button |
| Text Background | Text Background Button* |
| Font Attributes | Font Attributes Button |
| Text Alignment | Text Alignment Button |
| Delete | Delete Button |

### Pen

| Toolbar item | Screen reader announcement |
|---|---|
| Stroke Thickness | Pen Stroke Thickness Button* |
| Pen Color | Pen Color Button* |

### Effects

| Toolbar item | Screen reader announcement |
|---|---|
| Brightness | Brightness Button |
| Contrast | Contrast Button |
| Hue | Hue Button |
| Saturation | Saturation Button |
| Exposure | Exposure Button |
| Opacity | Opacity Button |
| Blur | Blur Button |
| Sharpen | Sharpen Button |

## Keyboard shortcuts

The [Syncfusion .NET MAUI Image Editor](https://www.syncfusion.com/maui-controls/maui-image-editor) supports the following keyboard shortcuts.

| Shortcut | Description |
|---|---|
| Tab | Moves focus to the next toolbar item. |
| Shift + Tab | Moves focus to the previous toolbar item. |
| Enter | Activates the focused toolbar item and raises the [`ToolbarItemSelected`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ImageEditor.SfImageEditor.html#Syncfusion_Maui_ImageEditor_SfImageEditor_ToolbarItemSelected) event. |
| Ctrl + Z | Undoes the most recent action. |
| Ctrl + Y | Redoes the last undone action. |
| Ctrl + S | Saves the current image. |
| Ctrl + O | Opens the file browser to load a new image. |

N> On macOS, use the `Command` key instead of `Ctrl`.
