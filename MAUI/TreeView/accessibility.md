---
layout: post
title: Accessibility in .NET MAUI TreeView control | Syncfusion®
description: Learn about accessibility support in the Syncfusion® .NET MAUI TreeView (SfTreeView) control, including screen reader announcements, keyboard navigation, focus indication, and testing guidance.
platform: MAUI
control: SfTreeView
documentation: ug
---

# Accessibility in .NET MAUI TreeView 

The .NET MAUI TreeView (SfTreeView) exposes its expanders and checkboxes to platform assistive technologies (TalkBack on Android, VoiceOver on iOS/macOS, and Narrator on Windows). On desktop and tablet it also supports keyboard navigation with a visible focus indicator.

A tree is more than a list: each node has a **level**, a **parent/child relationship**, and an **expanded or collapsed state**. This guide explains what SfTreeView announces and which keys it supports. It also describes what you should add in your own `ItemTemplate` so every node is understandable without sight.

N> The tables below describe the semantics SfTreeView provides itself. Text inside a node comes from your `ItemTemplate`, so it is announced as the platform reads that template's content.

## Accessibility Features

| Feature | Support |
|---|---|
| Screen reader descriptions for expander buttons | Built in |
| Expand/collapse hint that follows node state | Built in |
| Screen reader descriptions for node checkboxes | Built in |
| Keyboard navigation (arrows, Home, End, Page Up/Down, Space) | Windows, macOS, and hardware keyboards on Android/iPadOS |
| Expand/collapse with Left/Right arrow | Built in |
| Multi-selection keyboard shortcuts (Ctrl+A, Shift+arrows, Ctrl+arrows) | Built in (`Extended` mode) |
| Visible keyboard focus border | Built in |
| Right-to-left layout | Supported |
| Custom semantics through `SemanticProperties` in templates | Supported |

## TreeView Structure and Accessibility

| Part | Role for the user | Accessibility behavior |
|---|---|---|
| **TreeView** | Container of the hierarchy | Honors `SemanticProperties.Description` set on `SfTreeView`; this text is used as a prefix for expander and checkbox descriptions. |
| **Root node** | Top-level item | Navigated like any other visible node. |
| **Parent node** | Node with children | Exposes an expander button announced with its expand/collapse hint. |
| **Child node** | Node inside a parent | Visible only when all ancestors are expanded; indentation shows depth visually. |
| **Leaf node** | Node without children | No expander is exposed. |
| **Checkbox node** | Node with a checkbox (`CheckBoxMode` not `None`) | Checkbox is exposed with its own description. |
| **Lazy-loaded node** | Children supplied on demand (`LoadOnDemand`) | Children appear after the first expansion; |

Only nodes currently visible in the flattened tree are navigable. Collapsing a parent removes its descendants from keyboard and screen reader navigation.

## Screen Reader Support

### Built-in announcements

| Element | Announced description | Hint |
|---|---|---|
| Expander (collapsed node) | `[TreeView description] Item[Index] Expander` | Double tap to expand |
| Expander (expanded node) | `[TreeView description] Item[Index] Expander` | Double tap to Collapse |
| Node checkbox | `[TreeView description] Item[Index] Checkbox` | Platform checkbox state (checked / unchecked / indeterminate) |

`[TreeView description]` is the value of `SemanticProperties.Description` on the `SfTreeView`, and `Item[Index]` is the node's index in the visible list.

N> The built-in expander description is applied only when the default expander is used. If you set a custom `ExpanderTemplate`, you are responsible for its semantics.

### Narrator

Windows Narrator navigates with Caps Lock/Insert + arrow keys in scan mode, or with the keyboard when focus is inside the tree.

- Move to an expander to hear its description and the "Double tap to expand/Collapse" hint.
- Activate it with Enter or Space in Narrator to toggle the node, or use Left/Right arrow while a node has keyboard focus.
- Node text is read from your template content.

### Mobile screen readers

| Gesture (TalkBack / VoiceOver) | Action |
|---|---|
| Swipe right | Move focus to the next element |
| Swipe left | Move focus to the previous element |
| Single tap | Focus and announce the element |
| Double tap | Activate: toggles the expander, toggles the checkbox, or selects the node |

### Enable a screen reader

| Platform | Steps |
|---|---|
| Android | Settings → Accessibility → TalkBack → On |
| Windows | Settings → Accessibility → Narrator → On (or <kbd>Windows</kbd> + <kbd>Ctrl</kbd> + <kbd>Enter</kbd>) |
| iOS | Settings → Accessibility → VoiceOver → On |
| macOS | System Settings → Accessibility → VoiceOver (or <kbd>Command</kbd> + <kbd>F5</kbd>) |

## Keyboard Navigation

Keyboard support applies on Windows, macOS, and hardware keyboards attached to Android or iPadOS. Focus moves between visible nodes.

| Key | Behavior |
|---|---|
| <kbd>Down Arrow</kbd> | Moves focus to the next visible node. In `Single` and `SingleDeselect` modes the node is also selected. |
| <kbd>Up Arrow</kbd> | Moves focus to the previous visible node. Same selection behavior as Down Arrow. |
| <kbd>Right Arrow</kbd> | On a collapsed parent, expands it. Otherwise selects/focuses the current node. |
| <kbd>Left Arrow</kbd> | On an expanded parent, collapses it. Otherwise selects/focuses the current node. |
| <kbd>Home</kbd> | Moves focus to the first visible node. |
| <kbd>End</kbd> | Moves focus to the last visible node. |
| <kbd>Page Up</kbd> / <kbd>Page Down</kbd> | Moves focus one page up or down. |
| <kbd>Space</kbd> | Selects the focused node. Toggles selection in `SingleDeselect` and `Multiple` modes. In `Extended` mode with Ctrl, toggles the node without clearing others. |
| <kbd>Ctrl</kbd> + <kbd>A</kbd> | Selects all visible nodes in `Extended` mode. |
| <kbd>Shift</kbd> + <kbd>Up</kbd> / <kbd>Down</kbd> | Extends the selection range in `Extended` mode. |
| <kbd>Shift</kbd> + <kbd>Home</kbd> / <kbd>End</kbd> / <kbd>Page Up</kbd> / <kbd>Page Down</kbd> | Extends the range to that node in `Extended` mode. |
| <kbd>Ctrl</kbd> + <kbd>Up</kbd> / <kbd>Down</kbd> | In `Extended` mode, moves focus without changing selection. |
| <kbd>Tab</kbd> / <kbd>Shift</kbd> + <kbd>Tab</kbd> | Handled by the platform focus system to move focus into and out of the control and between interactive elements in templates. The tree itself is a single tab stop; use arrow keys inside it. |

N> <kbd>Enter</kbd> is not handled by SfTreeView. Use <kbd>Right Arrow</kbd> / <kbd>Left Arrow</kbd> to expand and collapse, and <kbd>Space</kbd> to select.

## Selection Accessibility

| Mode | Keyboard behavior | Notes |
|---|---|---|
| `None` | Focus moves; nothing is selected. | |
| `Single` | Arrow keys move focus and select. | Space does not deselect. |
| `SingleDeselect` | Arrows select; Space toggles. | |
| `Multiple` | Arrows move focus without selecting; Space toggles the focused node. | |
| `Extended` | Shift for ranges, Ctrl for non-contiguous, Ctrl+A for all. | Matches desktop list conventions. |

Selection is also shown visually through the node's selected background and text color. Ensure your template does not rely on color alone; see [High Contrast and Visual Accessibility](#high-contrast-and-visual-accessibility).

For checkbox nodes, the checkbox is a separate accessible element with tri-state values (checked, unchecked, indeterminate). A parent whose children are partially checked reports the indeterminate state.

## Expand and Collapse Accessibility

- **Gesture/touch:** the expander is an accessible element. Screen readers announce the hint *Double tap to expand* or *Double tap to Collapse* according to the current state, and the hint updates after each toggle.
- **Keyboard:** <kbd>Right Arrow</kbd> expands and <kbd>Left Arrow</kbd> collapses the focused parent node.
- **Cancelable:** the `NodeExpanding` and `NodeCollapsing` events can cancel the operation. If you cancel, the state and hint remain unchanged; consider informing the user why.
- **Visible set changes:** expanding adds the children to the navigable set, and collapsing removes them. Focus stays on the parent node.

## Automation Properties

SfTreeView uses the .NET MAUI semantic APIs. `SemanticProperties` is the recommended API and maps to the same platform properties as the older `AutomationProperties`.

| Property | Use in TreeView |
|---|---|
| `SemanticProperties.Description` | On `SfTreeView`: a prefix for expander and checkbox descriptions (for example, "File explorer"). On template elements: the spoken text for icons and images. |
| `SemanticProperties.Hint` | On template elements: extra guidance (for example, "Opens the folder"). The built-in expander hint is managed by the control. |
| `SemanticProperties.HeadingLevel` | On template labels that act as headings. |
| `AutomationId` | The control assigns IDs of the form `[TreeView AutomationId] Item[Index] Expander` and `... Checkbox` for UI tests, if not already set. Set `AutomationId` on `SfTreeView` to make them unique. |
| `AutomationProperties.IsInAccessibleTree` | Set to `false` on purely decorative template elements, such as divider lines or ornamental icons, to hide them. |
| `AutomationProperties.Name` / `HelpText` | Legacy equivalents of `Description` and `Hint`; prefer `SemanticProperties`. |

When creating custom item templates, you can leverage .NET MAUI `SemanticProperties` on template elements to customize the announcement for assistive technologies:
```xaml
<syncfusion:SfTreeView x:Name="treeView"
                       AutomationId="FileTree"
                       SemanticProperties.Description="File explorer"
                       ItemsSource="{Binding Folders}"
                       ChildPropertyName="SubFolders">
    <syncfusion:SfTreeView.ItemTemplate>
        <DataTemplate>
            <Grid ColumnDefinitions="Auto,*" Padding="4">
                <Image Source="{Binding Icon}"
                       SemanticProperties.Description="{Binding Kind}" />
                <Label Grid.Column="1" Text="{Binding Name}" />
            </Grid>
        </DataTemplate>
    </syncfusion:SfTreeView.ItemTemplate>
</syncfusion:SfTreeView>
```
## Accessibility States and Announcements

| State | What the user hears / sees | Source |
|---|---|---|
| Collapsed parent | Expander: "Double tap to expand" | Built in |
| Expanded parent | Expander: "Double tap to Collapse" | Built in |
| Checkbox checked / unchecked / indeterminate | Platform checkbox state with the checkbox description | Built in |
| Selected / unselected | Visual selected style; spoken state depends on the platform | Platform, plus your template |
| Level in hierarchy | Not announced automatically | Add to your template |
| Position in set | Not announced automatically | Add to your template |
