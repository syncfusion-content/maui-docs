---
layout: post
title: Accessibility in .NET MAUI TreeMap (SfTreeMap) Control | Syncfusion<sup>&reg;</sup>
description: Learn here about performing actions using accessibility in Syncfusion<sup>&reg;</sup> .NET MAUI TreeMap (SfTreeMap) control.
platform: maui
control: TreeMap (SfTreeMap)
documentation: ug
---

# Accessibility in .NET MAUI TreeMap (SfTreeMap)

The .NET MAUI TreeMap (SfTreeMap) control supports keyboard navigation and provides accessible descriptions of its items for assistive technologies such as Narrator and VoiceOver. This topic covers the keyboard shortcuts available in the control and explains how selection behavior interacts with keyboard focus.

Keyboard navigation is enabled by default; no additional configuration is required to move focus between items. To interact with the control using the keyboard, first set focus on the TreeMap (for example, by clicking an item or by tabbing to the control from the previous focusable element). Keyboard shortcuts are supported on Windows and macOS only. On Android and iOS, the keyboard shortcuts have no effect and interaction is performed through touch gestures.

N> **Prerequisite:** Ensure that the required NuGet package is installed, the necessary namespaces are imported, and the **TreeMap** control is properly configured in your application. For detailed setup and configuration instructions, refer to the **[Getting Started](https://help.syncfusion.com/maui/tree-map/getting-started)** guide.

## Keyboard shortcuts in .NET MAUI TreeMap (SfTreeMap)

The following table lists the keyboard shortcuts supported by the [Syncfusion .NET MAUI TreeMap](https://www.syncfusion.com/maui-controls/maui-tree-map) and their associated actions. Only `Tab` and `Shift + Tab` are supported; arrow-key navigation is not available.

<table>
<tr>
<td>
<b>Navigation shortcut keys</b> <br/><br/></td><td>
<b>Description</b> <br/><br/></td></tr>
<tr>
<td>
Tab<br/><br/></td><td>
Moves focus to the next item in traversal order.
<br/><br/></td></tr>
<tr>
<td>
Shift + Tab<br/><br/></td><td>
Moves focus to the previous item in traversal order.
<br/><br/></td></tr>
</table>

The item that receives keyboard focus is also visually highlighted. Whether the previously focused item remains selected after focus moves depends on the `SelectionMode` configured for the control; see [Selection and highlights](selection-and-highlights.md) for details.

## Selection behavior during keyboard navigation

The `SelectionMode` property of the [SfTreeMap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SfTreeMap.html) determines how items are selected while navigating with the keyboard:

- When `SelectionMode` is [Single](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SelectionMode.html#Syncfusion_Maui_TreeMap_SelectionMode_Single), each key press moves focus to a new item and selects it, clearing the selection of the previously focused item.
- When `SelectionMode` is [Multiple](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SelectionMode.html#Syncfusion_Maui_TreeMap_SelectionMode_Multiple), each key press moves focus to a new item and adds it to the selection; previously selected items remain selected.
- When `SelectionMode` is [None](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TreeMap.SelectionMode.html#Syncfusion_Maui_TreeMap_SelectionMode_None), focus can still be moved between items, but no item is selected.

{% tabs %}
{% highlight xaml hl_lines="5" %}

<treemap:SfTreeMap x:Name="treeMap"
                   DataSource="{Binding PopulationDetails}"
                   PrimaryValuePath="Population"
                   SelectionMode="Single">
    <!-- code omitted for brevity -->
</treemap:SfTreeMap>

{% endhighlight %}
{% highlight c# hl_lines="4" %}

SfTreeMap treeMap = new SfTreeMap();
treeMap.DataSource = viewModel.PopulationDetails;
treeMap.PrimaryValuePath = "Population";
treeMap.SelectionMode = SelectionMode.Single;
//code omitted for brevity
this.Content = treeMap;

{% endhighlight %}
{% endtabs %}

## Troubleshooting

If `Tab` or `Shift + Tab` does not move focus between items, verify the following:

- The TreeMap contains at least one item (`DataSource` is populated).
- The control or one of its items currently has focus. If focus is outside the control, the shortcuts have no effect until focus is set on the control.
- The application is running on a Windows or macOS target. Keyboard shortcuts are not supported on Android and iOS.

N> Traversal order follows the visual order of items produced by the current layout. For more information about layouts, see [Layouts](layouts.md).