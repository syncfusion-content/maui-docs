---
layout: post
title: Accessibility in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Accessibility support in Syncfusion® .NET MAUI ListView control, its elements and more.
platform: MAUI
control: SfListView
documentation: ug
---

# Accessibility in .NET MAUI ListView

The .NET MAUI ListView (SfListView) provides built-in accessibility support, exposing its items, group headers, header, footer, Load More item, empty view, and swipe actions to assistive technologies such as screen readers (TalkBack on Android, VoiceOver on iOS/macOS, and Narrator on Windows). It also provides keyboard navigation and visual focus indication for desktop and tablet platforms, and supports `AutomationId` for UI test automation.

The following tables list each element along with the value announced by screen readers and its interactive accessibility behavior.

## List Items

The content of an item comes from your `ItemTemplate`. Screen readers read that content using the platform's default behavior, followed by the position of the item in the list.

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>ListViewItem (Unselected)</td>
<td>[Item Content], Item [Index] of [Count]</td>
</tr>
<tr>
<td>ListViewItem (Selected)</td>
<td>Selected, [Item Content], Item [Index] of [Count]</td>
</tr>
</table>

N> When defining custom content in `ItemTemplate`, configure semantic descriptions on child views (such as `SemanticProperties.Description` and `SemanticProperties.Hint`) to ensure screen readers announce specific item fields accurately.

## Group Header

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>GroupHeaderItem (Expanded)</td>
<td>Group [Group Title], Expanded, [Group Item Count] items, Double Tap to Collapse</td>
</tr>
<tr>
<td>GroupHeaderItem (Collapsed)</td>
<td>Group [Group Title], Collapsed, [Group Item Count] items, Double Tap to Expand</td>
</tr>
</table>

N> When `AllowGroupExpandCollapse` is set to `true`, group header elements provide state announcements indicating whether the group is currently expanded or collapsed. A group is expanded or collapsed by tap, click, or the screen reader's double tap. There is no dedicated keyboard shortcut; use the `KeyDown` event if you need one.

## Header and Footer

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>HeaderItem</td>
<td>[Header Content], List Header</td>
</tr>
<tr>
<td>FooterItem</td>
<td>[Footer Content], List Footer</td>
</tr>
</table>

N> The content comes from `HeaderTemplate` and `FooterTemplate`.

## Load More

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>LoadMoreView</td>
<td>Load More Items Button, Double Tap to Load More Items</td>
</tr>
</table>

N> With `LoadMoreOption` set to `Manual`, the Load More item can be reached with the arrow keys. When it has focus, pressing <kbd>Enter</kbd> executes the `LoadMoreCommand` if its `CanExecute` returns `true`. The content comes from `LoadMoreTemplate`.

## Empty View

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>EmptyView</td>
<td>[Empty View Content], No Items Available</td>
</tr>
</table>

N> The content comes from `EmptyView` or `EmptyViewTemplate`. The empty view does not respond to tap, double tap, or long press gestures.

## Swipe Actions

<table>
<tr>
<th>Element</th>
<th>Value</th>
</tr>
<tr>
<td>StartSwipeView</td>
<td>[Start Action Content], Swipe Action Button</td>
</tr>
<tr>
<td>EndSwipeView</td>
<td>[End Action Content], Swipe Action Button</td>
</tr>
</table>

N> The content comes from `StartSwipeTemplate` and `EndSwipeTemplate`, and swiping requires `AllowSwiping` to be `true`. Keyboard navigation is ignored while an item is being swiped. Provide an alternative way to perform each swipe action, for example a button inside the item template, for users who cannot swipe.

## Focus Border and Visual States

The keyboard focus border is drawn around the currently focused item. It is styled through theme resources, so it can be changed without code.

<table>
<tr>
<th>Theme Resource</th>
<th>Description</th>
</tr>
<tr>
<td>SfListViewFocusedListViewItemStroke</td>
<td>Specifies the stroke color of the focus border drawn around the currently focused item.</td>
</tr>
<tr>
<td>SfListViewFocusedListViewItemStrokeThickness</td>
<td>Specifies the thickness of the focus border drawn around the currently focused item.</td>
</tr>
</table>

In `Multiple` and `Extended` selection modes, focus can move independently of selection, so the focus border and the selected background are drawn separately.

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

`SfListView` implements keyboard interaction support on desktop and tablet environments (Windows, macOS, and physical keyboards connected to Android or iPadOS). Keyboard handling is not active when `SelectionMode` is `None`.

### Navigation and Selection Keys

<table>
<tr>
<th>Key / Key Combination</th>
<th>Description</th>
</tr>
<tr>
<td><kbd>Down Arrow</kbd></td>
<td>Moves focus to the next item in vertical layout. In Single selection mode, selects the next item.</td>
</tr>
<tr>
<td><kbd>Up Arrow</kbd></td>
<td>Moves focus to the previous item in vertical layout. In Single selection mode, selects the previous item.</td>
</tr>
<tr>
<td><kbd>Right Arrow</kbd></td>
<td>Moves focus to the next item in horizontal layout, or to the adjacent column in grid layout. In RTL mode, moves to the previous item.</td>
</tr>
<tr>
<td><kbd>Left Arrow</kbd></td>
<td>Moves focus to the previous item in horizontal layout, or to the adjacent column in grid layout. In RTL mode, moves to the next item.</td>
</tr>
<tr>
<td><kbd>Home</kbd></td>
<td>Moves focus and scroll position to the first item of the list.</td>
</tr>
<tr>
<td><kbd>End</kbd></td>
<td>Moves focus and scroll position to the last item of the list.</td>
</tr>
<tr>
<td><kbd>Page Down</kbd></td>
<td>Scrolls down by one page and focuses the corresponding item.</td>
</tr>
<tr>
<td><kbd>Page Up</kbd></td>
<td>Scrolls up by one page and focuses the corresponding item.</td>
</tr>
<tr>
<td><kbd>Space</kbd></td>
<td>Selects or toggles selection of the currently focused item, according to the selection mode.</td>
</tr>
<tr>
<td><kbd>Enter</kbd></td>
<td>Executes the `LoadMoreCommand` when the Load More item has focus. It does not select items.</td>
</tr>
<tr>
<td><kbd>Ctrl</kbd> + <kbd>A</kbd> / <kbd>Cmd</kbd> + <kbd>A</kbd></td>
<td>Selects all items when `SelectionMode` is `Multiple` or `Extended`.</td>
</tr>
<tr>
<td><kbd>Ctrl</kbd> + <kbd>Space</kbd> / <kbd>Cmd</kbd> + <kbd>Space</kbd></td>
<td>In `Extended` selection mode, toggles selection of the focused item without deselecting other items.</td>
</tr>
<tr>
<td><kbd>Shift</kbd> + <kbd>Down Arrow</kbd> / <kbd>Up Arrow</kbd></td>
<td>In `Extended` selection mode, extends the range selection from the anchor item to the newly focused item.</td>
</tr>
<tr>
<td><kbd>Tab</kbd> / <kbd>Shift</kbd> + <kbd>Tab</kbd></td>
<td>In grid layout, moves focus to the next or previous item. In linear layout, moves focus into and out of the `SfListView` control and between interactive elements inside templates, according to the platform focus order.</td>
</tr>
</table>

N> <kbd>Enter</kbd> does not select items or toggle group expansion. To handle other keys, use the `KeyDown` event.

### Selection Modes and Keyboard Behavior

<table>
<tr>
<th>SelectionMode</th>
<th>Keyboard behavior</th>
</tr>
<tr>
<td>None</td>
<td>Keyboard navigation is not handled.</td>
</tr>
<tr>
<td>Single</td>
<td>Arrow keys move focus and select the item.</td>
</tr>
<tr>
<td>SingleDeselect</td>
<td>Arrow keys move focus. Space selects the focused item and deselects it when pressed again.</td>
</tr>
<tr>
<td>Multiple</td>
<td>Arrow keys move focus. Space toggles the selection of the focused item. Ctrl + A selects all items.</td>
</tr>
<tr>
<td>Extended</td>
<td>Arrow keys select the focused item only. Shift for ranges, Ctrl for non-contiguous selection, Ctrl + A to select all.</td>
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
<td>Moves accessibility focus to the next item or element.</td>
</tr>
<tr>
<td>Swipe Left</td>
<td>Moves accessibility focus to the previous item or element.</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Focuses and announces the tapped element.</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activates the focused item (triggers selection, tap command, or group expand/collapse).</td>
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
<td>Moves accessibility focus to the next item or element.</td>
</tr>
<tr>
<td>Swipe Left (One finger)</td>
<td>Moves accessibility focus to the previous item or element.</td>
</tr>
<tr>
<td>Single Tap</td>
<td>Focuses and announces the tapped element.</td>
</tr>
<tr>
<td>Double Tap</td>
<td>Activates the focused item (triggers selection, tap command, or group expand/collapse).</td>
</tr>
</table>

### Windows (Narrator)

<table>
<tr>
<th>Action</th>
<th>Description</th>
</tr>
<tr>
<td>Arrow keys with focus in the list</td>
<td>Moves between items. Narrator reads the item content from the template.</td>
</tr>
<tr>
<td><kbd>Space</kbd></td>
<td>Selects or deselects the focused item, according to the selection mode.</td>
</tr>
<tr>
<td><kbd>Enter</kbd> on the Load More item</td>
<td>Loads more items.</td>
</tr>
</table>

N> NVDA and JAWS read the UI Automation tree that .NET MAUI exposes on Windows, so announcements can differ from Narrator. Verify the behavior with your templates.

## Semantic Properties in ItemTemplate

When creating custom item templates, you can use .NET MAUI `SemanticProperties` on the list and on template elements to customize the announcement for assistive technologies:
```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView"
                         AutomationId="ContactList"
                         SemanticProperties.Description="Contacts"
                         ItemsSource="{Binding ContactList}">
    <syncfusion:SfListView.ItemTemplate>
      <DataTemplate>
        <Grid Padding="12" ColumnDefinitions="Auto,*">
          <Image Source="{Binding AvatarImage}"
                 SemanticProperties.Description="{Binding Name, StringFormat='Profile picture of {0}'}" />
          <VerticalStackLayout Grid.Column="1" Spacing="4">
            <Label Text="{Binding Name}"
                   FontAttributes="Bold"
                   SemanticProperties.HeadingLevel="Level3" />
            <Label Text="{Binding PhoneNumber}"
                   SemanticProperties.Description="{Binding PhoneNumber, StringFormat='Phone number {0}'}" />
          </VerticalStackLayout>
        </Grid>
      </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
  </syncfusion:SfListView>
</ContentPage>
```

The following properties are supported:

<table>
<tr>
<th>Property</th>
<th>Usage in ListView</th>
</tr>
<tr>
<td>SemanticProperties.Description</td>
<td>On <code>SfListView</code>: the name of the list. On template elements: the spoken text for icons, images, and labels.</td>
</tr>
<tr>
<td>SemanticProperties.Hint</td>
<td>On template elements: extra guidance, such as "Opens the conversation".</td>
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

## AutomationId

`SfListView` does not generate `AutomationId` values for its items. To find elements from UI automation frameworks and test scripts, set `AutomationId` on the list and on the elements in your templates.

<table>
<tr>
<th>Element</th>
<th>How to set the AutomationId</th>
<th>Example</th>
</tr>
<tr>
<td>SfListView</td>
<td>Set <code>AutomationId</code> on the control.</td>
<td>ContactList</td>
</tr>
<tr>
<td>Element in ItemTemplate</td>
<td>Bind <code>AutomationId</code> to a unique value of the item, such as its name or ID.</td>
<td>Contact Thomas</td>
</tr>
<tr>
<td>Header, Footer, Load More, Empty View, or Swipe content</td>
<td>Set <code>AutomationId</code> on the root element of the template.</td>
<td>ListHeader</td>
</tr>
</table>

N> Bind `AutomationId` to a stable value from your data and not to the item index. The list is virtualized, and the index changes when items are sorted, filtered, grouped, or collapsed.

### Accessing ListView Elements

```
public void SfListView_FindItem()
{
    // Find an item through the AutomationId bound in the ItemTemplate
    var item = driver.FindElement(MobileBy.AccessibilityId("Contact Thomas"));
    item.Click();

    // Find the header defined in HeaderTemplate
    driver.FindElement(MobileBy.AccessibilityId("ListHeader"));
}
```

## Right-to-Left (RTL) Support

The `SfListView` automatically mirrors its layout and inverts directional keyboard navigation (for example, the Left and Right arrow keys) when placed in a Right-to-Left context (`FlowDirection="RightToLeft"`), ensuring consistent spatial navigation for users who use screen readers in RTL locales.
