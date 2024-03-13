---
layout: post
title: Accessibility in .NET MAUI TreeMap | Syncfusion
description: Learn here about performing actions using accessibility in Syncfusion .NET MAUI TreeMap(STreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

## Accessibility in .NET MAUI TreeMap (SfTreeMap)

The TreeMap is designed to effectively work with its elements, providing voice descriptions of the treemap items.

## Keyboard shortcuts in .NET MAUI TreeMap (SfTreeMap)

The [Syncfusion .NET MAUI TreeMap](https://ftstaging.syncfusion.com:14039/maui-controls/maui-tree-map) supports keyboard shortcuts for user interaction. 

N> It is only applicable for Windows and macOS.

The table provided outlines various shortcuts and their associated functions.

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
* In `SelectionMode.None`, the focused item should not be selected.
* In `SelectionMode.Single`, each key press clears the previous focus and selects the new item.
* In `SelectionMode.Multiple`, the previously focused item remains selected while new items are selected with each key press.
