---
layout: post
title: Accessibility in .NET MAUI TreeView control | Syncfusion®
description: Learn here all about Accessibility support in Syncfusion® .NET MAUI TreeView (SfTreeView) control, its elements, screen reader announcements, keyboard navigation, and AutomationId patterns.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Accessibility in .NET MAUI TreeView

The .NET MAUI TreeView (SfTreeView) provides built-in accessibility support, exposing its expanders and checkboxes to assistive technologies such as screen readers (TalkBack on Android, VoiceOver on iOS/macOS, and Narrator on Windows). It also provides keyboard navigation, expand/collapse by keyboard, and visual focus indication for desktop and tablet platforms, and `AutomationId` values for UI test automation.

The following tables list each element along with the value announced by screen readers and its interactive accessibility behavior.

## TreeView Nodes

The content of a node comes from your `ItemTemplate` (bound mode) or from the `Content` of the `TreeViewNode` (unbound mode). Screen readers read that content using the platform's default behavior. SfTreeView does not add an item index, level, or selected-state prefix to the node itself.

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>Node (root, parent, child, or leaf)</td>
<td>[Node Content from ItemTemplate]</td>
</tr>
<tr>
<td>Node (Selected)</td>
<td>[Node Content from ItemTemplate]. The selected state is shown visually; the spoken selected state depends on the platform.</td>
</tr>
</table>

N> Hierarchy (level, parent, and sibling position) is shown by indentation only. To announce it, add it to the description in your `ItemTemplate`. See [Semantic Properties in ItemTemplate](#semantic-properties-in-itemtemplate).

## Expander

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>Expander (Collapsed node)</td>
<td>[TreeView Description] Item[Index] Expander, Double tap to expand</td>
</tr>
<tr>
<td>Expander (Expanded node)</td>
<td>[TreeView Description] Item[Index] Expander, Double tap to Collapse</td>
</tr>
</table>

N> `[TreeView Description]` is the `SemanticProperties.Description` set on `SfTreeView`, and `[Index]` is the position of the node in the currently visible (flattened) tree. Leaf nodes do not expose an expander. The hint is updated each time a node is expanded or collapsed. These values apply only to the default expander; when `ExpanderTemplate` is set, define the semantics in your template.

## CheckBox

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>CheckBox (when <code>CheckBoxMode</code> is not <code>None</code>)</td>
<td>[TreeView Description] Item[Index] Checkbox, [Checked / Unchecked / Indeterminate]</td>
</tr>
</table>

N> The checked, unchecked, or indeterminate state is reported by the platform checkbox. In `Recursive` mode, a parent whose children are only partly checked is indeterminate.

## Empty View

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>EmptyView</td>
<td>[Empty View Content]</td>
</tr>
</table>

N> Set `SemanticProperties.Description` inside `EmptyView` or `EmptyViewTemplate`, for example "No items available", so that screen reader users know the tree is empty.

## Focus Border and Visual States

The keyboard focus border is drawn around the currently focused node. It is styled through theme resources, so it can be changed without code.

<table>
<tr>
<th>Theme Resource</th>
<th>Description</th>
</tr>
<tr>
<td>SfTreeViewFocusedTreeViewItemStroke</td>
<td>Specifies the stroke color of the focus border drawn around the currently focused node.</td>
</tr>
<tr>
<td>SfTreeViewFocusedTreeViewItemStrokeThickness</td>
<td>Specifies the thickness of the focus border drawn around the currently focused node.</td>
</tr>
</table>

In `Multiple` and `Extended` selection modes, focus moves independently of selection, so the focus border and the selected background are drawn separately.

## Enable Accessibility

To enable accessibility and screen reader support on your device:

<table>
<tr>
<th>Platform</th>
<th>Steps</th>
</tr>
<tr>
<td><b>Android</b></td>
<td>Settings → Accessibility → TalkBack → Toggle "On"</td>
</tr>
<tr>
<td><b>Windows</b></td>
<td>Settings → Accessibility → Narrator → Toggle "On" (or press <kbd>Windows</kbd> + <kbd>Ctrl</kbd> + <kbd>Enter</kbd>)</td>
</tr>
<tr>
<td><b>iOS</b></td>
<td>Settings → Accessibility → VoiceOver → Toggle "On"</td>
</tr>
<tr>
<td><b>macOS</b></td>
<td>System Settings → Accessibility → VoiceOver → Enable VoiceOver (or press <kbd>Command</kbd> + <kbd>F5</kbd>)</td>
</tr>
</table>

## Keyboard Navigation

`SfTreeView` implements keyboard interaction support on desktop and tablet environments (Windows, macOS, and physical keyboards connected to Android or iPadOS). Only visible nodes take part in navigation; the children of a collapsed node are skipped.

### Navigation, Expand/Collapse and Selection Keys

<table>
<tr>
<th>Key / Key Combination</th>
<th>Description</th>
</tr>
<tr>
<td><kbd>Down Arrow</kbd></td>
<td>Moves focus to the next visible node. In Single and SingleDeselect selection modes, selects the next node.</td>
</tr>
<tr>
<td><kbd>Up Arrow</kbd></td>
<td>Moves focus to the previous visible node. In Single and SingleDeselect selection modes, selects the previous node.</td>
</tr>
<tr>
<td><kbd>Right Arrow</kbd></td>
<td>Expands the focused node if it is a collapsed parent. Otherwise, selects the focused node.</td>
</tr>
<tr>
<td><kbd>Left Arrow</kbd></td>
<td>Collapses the focused node if it is an expanded parent. Otherwise, selects the focused node.</td>
</tr>
<tr>
<td><kbd>Home</kbd></td>
<td>Moves focus and scroll position to the first visible node.</td>
</tr>
<tr>
<td><kbd>End</kbd></td>
<td>Moves focus and scroll position to the last visible node.</td>
</tr>
<tr>
<td><kbd>Page Down</kbd></td>
<td>Scrolls down by one page and focuses the corresponding node.</td>
</tr>
<tr>
<td><kbd>Page Up</kbd></td>
<td>Scrolls up by one page and focuses the corresponding node.</td>
</tr>
<tr>
<td><kbd>Space</kbd></td>
<td>Selects the focused node. In SingleDeselect and Multiple modes, toggles the selection of the focused node.</td>
</tr>
<tr>
<td><kbd>Ctrl</kbd> + <kbd>A</kbd> / <kbd>Cmd</kbd> + <kbd>A</kbd></td>
<td>Selects all visible nodes when `SelectionMode` is `Extended`.</td>
</tr>
<tr>
<td><kbd>Ctrl</kbd> + <kbd>Space</kbd> / <kbd>Cmd</kbd> + <kbd>Space</kbd></td>
<td>In `Extended` selection mode, toggles selection of the focused node without deselecting other nodes.</td>
</tr>
<tr>
<td><kbd>Ctrl</kbd> + <kbd>Up Arrow</kbd> / <kbd>Down Arrow</kbd></td>
<td>In `Extended` selection mode, moves focus without changing the selection.</td>
</tr>
<tr>
<td><kbd>Shift</kbd> + <kbd>Down Arrow</kbd> / <kbd>Up Arrow</kbd></td>
<td>In `Extended` selection mode, extends the range selection from the anchor node to the newly focused node.</td>
</tr>
<tr>
<td><kbd>Shift</kbd> + <kbd>Home</kbd> / <kbd>End</kbd> / <kbd>Page Up</kbd> / <kbd>Page Down</kbd></td>
<td>In `Extended` selection mode, extends the range selection to the first node, last node, or one page away.</td>
</tr>
<tr>
<td><kbd>Tab</kbd> / <kbd>Shift</kbd> + <kbd>Tab</kbd></td>
<td>Moves focus into and out of the `SfTreeView` control and between interactive elements inside templates, according to the platform focus order. Use the arrow keys to move between nodes.</td>
</tr>
</table>

N> <kbd>Enter</kbd> is not handled by `SfTreeView`. Use <kbd>Right Arrow</kbd> and <kbd>Left Arrow</kbd> to expand and collapse nodes, and <kbd>Space</kbd> to select them. To handle other keys, use the `KeyDown` event.

### Selection Modes and Keyboard Behavior

<table>
<tr>
<th>SelectionMode</th>
<th>Keyboard behavior</th>
</tr>
<tr>
<td>None</td>
<td>Focus moves between nodes; nothing is selected.</td>
</tr>
<tr>
<td>Single</td>
<td>Arrow keys move focus and select the node.</td>
</tr>
<tr>
<td>SingleDeselect</td>
<td>Arrow keys move focus and select the node. Space toggles the selection of the focused node.</td>
</tr>
<tr>
<td>Multiple</td>
<td>Arrow keys move focus only. Space toggles the selection of the focused node.</td>
</tr>
<tr>
<td>Extended</td>
<td>Shift for ranges, Ctrl for non-contiguous selection, Ctrl + A to select all.</td>
</tr>
</table>

## Screen Reader Gesture Navigation

### Android (TalkBack)

<table>
<tr>
<th>Gesture</th>
<th>Description</th>
</tr>
<tr>
<td>Swipe Right</td>
<td>Moves accessibility focus to the next node or element, such as an expander or checkbox.</td>
</tr>
<tr>
<td>Swipe Left</td>
<td>Moves accessibility focus to the previous node or element.</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Focuses and announces the tapped element.</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activates the focused element (expands or collapses a node from its expander, toggles a checkbox, or selects a node).</td>
</tr>
</table>

### iOS / macOS (VoiceOver)

<table>
<tr>
<th>Gesture</th>
<th>Description</th>
</tr>
<tr>
<td>Swipe Right (One finger)</td>
<td>Moves accessibility focus to the next node or element, such as an expander or checkbox.</td>
</tr>
<tr>
<td>Swipe Left (One finger)</td>
<td>Moves accessibility focus to the previous node or element.</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Focuses and announces the tapped element.</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activates the focused element (expands or collapses a node from its expander, toggles a checkbox, or selects a node).</td>
</tr>
</table>

### Windows (Narrator)

<table>
<tr>
<th>Action</th>
<th>Description</th>
</tr>
<tr>
<td>Move to the expander</td>
<td>Narrator reads the expander description and the "Double tap to expand" or "Double tap to Collapse" hint.</td>
</tr>
<tr>
<td>Arrow keys with focus in the tree</td>
<td>Moves between visible nodes. Narrator reads the node content from the template.</td>
</tr>
<tr>
<td><kbd>Right Arrow</kbd> / <kbd>Left Arrow</kbd></td>
<td>Expands or collapses the focused parent node.</td>
</tr>
</table>

N> NVDA and JAWS read the UI Automation tree that .NET MAUI exposes on Windows, so announcements can differ from Narrator. Verify the behavior with your templates.

## Semantic Properties in ItemTemplate

When creating custom item templates, you can use .NET MAUI `SemanticProperties` on the tree and on template elements to customize the announcement for assistive technologies:

```
{% highlight xaml tabtitle="MainPage.xaml" %}
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.TreeView;assembly=Syncfusion.Maui.TreeView">
  <syncfusion:SfTreeView x:Name="treeView"
                         AutomationId="FileTree"
                         SemanticProperties.Description="File explorer"
                         ItemsSource="{Binding Folders}"
                         ChildPropertyName="SubFolders">
    <syncfusion:SfTreeView.ItemTemplate>
      <DataTemplate>
        <Grid Padding="12" ColumnDefinitions="Auto,*">
          <Image Source="{Binding Icon}"
                 SemanticProperties.Description="{Binding Kind}" />
          <Label Grid.Column="1"
                 Text="{Binding Name}"
                 SemanticProperties.Description="{Binding Name, StringFormat='{0}, {1} items'}" />
        </Grid>
      </DataTemplate>
    </syncfusion:SfTreeView.ItemTemplate>
  </syncfusion:SfTreeView>
</ContentPage>
{% endhighlight %}
```
The following properties are supported:

<table>
<tr>
<th>Property</th>
<th>Usage in TreeView</th>
</tr>
<tr>
<td>SemanticProperties.Description</td>
<td>On <code>SfTreeView</code>: the name of the tree, used as the prefix of expander and checkbox descriptions. On template elements: the spoken text for icons, images, and labels.</td>
</tr>
<tr>
<td>SemanticProperties.Hint</td>
<td>On template elements: extra guidance, such as "Opens the folder". The hint of the default expander is managed by the control.</td>
</tr>
<tr>
<td>SemanticProperties.HeadingLevel</td>
<td>On template labels that act as headings.</td>
</tr>
<tr>
<td>AutomationProperties.IsInAccessibleTree</td>
<td>Set to <code>false</code> on decorative template elements, such as divider lines, so screen readers skip them.</td>
</tr>
<tr>
<td>AutomationProperties.Name / HelpText</td>
<td>Older equivalents of <code>Description</code> and <code>Hint</code>. Prefer <code>SemanticProperties</code>.</td>
</tr>
</table>

N> To announce the level of a node, expose it from your data model and include it in the description, for example `SemanticProperties.Description="{Binding Name, StringFormat='{0}, level 2'}"`. Expanded or collapsed state and the position among siblings are not announced for the node itself.

## AutomationId

`SfTreeView` assigns an `AutomationId` to its expander and checkbox elements so UI automation frameworks and test scripts can find them. The ID is built by combining the `AutomationId` of the TreeView with the pattern below. An ID that you have already set on an element is not overwritten.

<table>
<tr>
<th>Element</th>
<th>AutomationId Pattern</th>
<th>Example</th>
</tr>
<tr>
<td>Expander</td>
<td>[TreeView AutomationId] + " Item" + ItemIndex + " Expander"</td>
<td>FileTree Item2 Expander</td>
</tr>
<tr>
<td>CheckBox</td>
<td>[TreeView AutomationId] + " Item" + ItemIndex + " Checkbox"</td>
<td>FileTree Item2 Checkbox</td>
</tr>
</table>

N> `ItemIndex` is the index in the visible tree, so it changes when other nodes are expanded or collapsed. Set a unique `AutomationId` on each `SfTreeView`.

### Accessing TreeView Elements

```
public void SfTreeView_ExpandAndCheck()
{
    // Expand or collapse the node at visible index 2
    driver.FindElement(MobileBy.AccessibilityId("FileTree Item2 Expander")).Click();

    // Toggle the checkbox of the node at visible index 3
    driver.FindElement(MobileBy.AccessibilityId("FileTree Item3 Checkbox")).Click();
}
```

## Right-to-Left (RTL) Support

The `SfTreeView` mirrors its layout, including indentation and expander position, when placed in a Right-to-Left context (`FlowDirection="RightToLeft"`). Verify that the expand and collapse keys behave as expected for your users in RTL locales.

