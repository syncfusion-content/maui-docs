---
layout: post
title: Accessibility in .NET MAUI TreeView control | Syncfusion®
description: Learn about accessibility support in the Syncfusion® .NET MAUI TreeView (SfTreeView) control, including screen reader announcements, keyboard navigation, focus indication, and testing guidance.
platform: MAUI
control: SfTreeView
documentation: ug
---

# TreeView Accessibility

## Overview

The [.NET MAUI TreeView](https://www.syncfusion.com/maui-controls/maui-treeview) (SfTreeView) exposes its expanders and checkboxes to platform assistive technologies (TalkBack on Android, VoiceOver on iOS/macOS, and Narrator on Windows). On desktop and tablet it also supports keyboard navigation with a visible focus indicator.

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
| Visible keyboard focus border | Built in, themed |
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
| **Lazy-loaded node** | Children supplied on demand (`LoadOnDemand`) | Children appear after the first expansion; see [Limitations](#limitations-and-known-considerations). |

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

### NVDA

NVDA is not a supported target for .NET MAUI Windows apps in the same way Narrator is, because the MAUI Windows UIA tree is the integration point. NVDA reads UIA properties, so results are similar to Narrator, but verify in your own app before claiming support.

### JAWS

The same applies to JAWS: it consumes the UIA tree exposed by the MAUI Windows handler. Validate the behavior with your templates, especially for the node level and position, which are not announced automatically (see [Limitations](#limitations-and-known-considerations)).

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

## Focus and Navigation Behavior

- Keyboard focus is drawn as a border around the focused node. It is themed through the `SfTreeViewFocusedTreeViewItemStroke` and `SfTreeViewFocusedTreeViewItemStrokeThickness` theme resources.
- Navigating with the keyboard brings the focused node into view automatically.
- In `Multiple` and `Extended` modes, focus can move independently of selection, so the focus border and the selected state are shown separately.
- Focus is kept on the same node when its ancestors expand or collapse.
- Interactive controls inside templates (buttons, entries) participate in the normal Tab order.

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

To announce level and position, bind them in your template. For example, with a data model that exposes `Level`:

```xaml
<Label Text="{Binding Name}"
       SemanticProperties.Description="{Binding Name, StringFormat='{0}, level {1}'}" />
```

Example sequence for a file tree, with the screen reader on the "Documents" expander:

1. "File explorer Item2 Expander, Double tap to expand."
2. The user activates it. The node expands and the hint changes.
3. The next focus on the expander reads: "File explorer Item2 Expander, Double tap to Collapse."

## High Contrast and Visual Accessibility

- Selection, focus, and expander colors come from the theme resource dictionaries (`maui/src/treeview/Themes`). Override the resources for a high-contrast palette.
- Do not convey selection or state with color alone; the focus border and expander glyph direction provide non-color cues.
- Keep a contrast ratio of at least 4.5:1 for node text and 3:1 for the focus border and expander icons against their background.
- The focus border can be made thicker for low-vision users through `SfTreeViewFocusedTreeViewItemStrokeThickness`.
- Support platform text scaling by enabling dynamic item height (auto-fit) so enlarged text is not clipped.
- Touch targets for expanders and checkboxes should be at least 44 x 44 units where possible.

## Localization Considerations

- Built-in hints ("Double tap to expand", "Double tap to Collapse") are currently English strings and are not localized through resources. Set your own descriptions in your template and avoid depending on them when shipping in other languages.
- Localize `SemanticProperties.Description` and `Hint` values in your templates through resource files.
- With `FlowDirection="RightToLeft"` the layout is mirrored, including indentation and the expander position. Left/Right arrow semantics follow the layout, so verify expand/collapse behavior in RTL.
- Use localized, concise node text because screen readers read it in full.

## Accessibility Best Practices

1. Set `SemanticProperties.Description` on `SfTreeView` to name the tree.
2. Provide text alternatives for every icon or image in a template.
3. Hide decorative elements with `AutomationProperties.IsInAccessibleTree="False"`.
4. Include level, child count, or position in the node description when it matters to the task.
5. Keep templates simple. Fewer focusable child elements per node means faster keyboard navigation.
6. Offer a keyboard path for every action available by gesture, such as context menus and drag-and-drop reordering.
7. Do not remove or hide the focus border.
8. Explain canceled expand/collapse or drops through visible and spoken feedback.
9. Assign a unique `AutomationId` to each tree.

## Accessibility Testing Guidelines

| Area | Check |
|---|---|
| Screen reader | With Narrator, TalkBack, and VoiceOver, move through nodes and verify names, expander hints, and checkbox states. |
| Keyboard only | Complete expand, collapse, select, and multi-select without a mouse. Confirm focus is always visible. |
| Expand/collapse | Verify the hint changes and the focus stays on the parent. |
| Lazy loading | Expand a load-on-demand node and confirm the new children can be reached. |
| High contrast | Enable Windows contrast themes and check that all states remain distinguishable. |
| Text scaling | Set the largest system font and check for clipping. |
| RTL | Test with `FlowDirection="RightToLeft"`. |
| Tools | Accessibility Insights for Windows, Inspect.exe, Android Accessibility Scanner, and Xcode Accessibility Inspector. |
| Automation | Use the generated `AutomationId` values in UI tests. |

## WCAG Compliance Considerations

| Criterion | Level | Considerations |
|---|---|---|
| 1.1.1 Non-text Content | A | Provide `SemanticProperties.Description` for icons and images in templates. |
| 1.3.1 Info and Relationships | A | Hierarchy is visual; add level or parent context to node descriptions. |
| 1.4.1 Use of Color | A | Do not rely on color alone for selection or state. |
| 1.4.3 Contrast (Minimum) | AA | Check node text and theme colors. |
| 1.4.11 Non-text Contrast | AA | Check the focus border, expander, and checkbox colors. |
| 2.1.1 Keyboard | A | Navigation, expand/collapse, and selection are available by keyboard. |
| 2.4.3 Focus Order | A | Focus follows the visible node order. |
| 2.4.7 Focus Visible | AA | Themed focus border. |
| 3.1.2 Language of Parts | AA | Localize descriptions in templates. |
| 4.1.2 Name, Role, Value | A | Expander and checkbox expose a name and state; verify node name, level, and role for your template. |

Final conformance depends on your templates, data, and theme, so test your complete app.

## Limitations and Known Considerations

- The tree does not expose a native tree-item role with level, position-in-set, or expanded state to the platform accessibility tree. The expand state is conveyed through the expander hint, and the level and position are not announced unless you add them in the template.
- Built-in expander and checkbox descriptions use the form "Item[Index]", based on the visible index, so the number changes when nodes are expanded or collapsed.
- Built-in hints are not localized.
- <kbd>Enter</kbd> does not toggle expansion or selection.
- <kbd>Tab</kbd> does not move between nodes; use the arrow keys.
- A custom `ExpanderTemplate` replaces the built-in expander semantics.
- Nodes added by `LoadOnDemand` are not announced when they appear; the user must move to them.
- Drag-and-drop reordering is pointer and touch based and has no keyboard alternative.
- Behavior of NVDA and JAWS with MAUI Windows apps depends on the UIA data exposed by the platform handlers; test it in your app.
- Keyboard shortcuts are not available on mobile without a hardware keyboard.

## Summary

SfTreeView provides screen reader descriptions for expanders and checkboxes, expand/collapse hints that follow node state, full arrow-key navigation with expand/collapse, multi-selection shortcuts, and a themed focus border. Use `SemanticProperties` in your templates to name content, include level and position where they matter, hide decorative elements, and localize all text. Test with real assistive technologies on each target platform.
