---
layout: post
title: Accessibility in .NET MAUI TreeMap (STreeMap) control | Syncfusion
description: Learn here about performing actions using accessibility in Syncfusion .NET MAUI TreeMap (STreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Accessibility in .NET MAUI TreeMap (SfTreeMap)

The TreeMap is designed to effectively work with its elements, providing voice descriptions of the treemap items.

## Keyboard shortcuts in .NET MAUI TreeMap (SfTreeMap)

The `Syncfusion .NET MAUI TreeMap` supports keyboard shortcuts for user interaction. 

N> This feature is only applicable for Windows and macOS platforms.

Below is a table outlining the various shortcuts and their associated functions:

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Shift<br/><br/></td><td> 
Moves selection to the next item on the right side of the TreeMap.
<br/><br/></td></tr>
<tr>
<td>
Shift + Tab<br/><br/></td><td>
Moves selection to the previous item on the left side of the TreeMap.
<br/><br/></td></tr>
</table>

N> 

* When `SelectionMode` is set to `Single,` each key press clears the previous focus and selects the new item.
* When `SelectionMode` is set to `Multiple,` the previously focused item remains selected while new items are selected with each key press.
* When `SelectionMode` is set to `None,` the item is not selected.