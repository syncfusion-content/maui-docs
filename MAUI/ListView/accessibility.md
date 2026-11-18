---
layout: post
title: Accessibility in .NET MAUI ListView control | Syncfusion®
description: Learn here all about Accessibility support in Syncfusion® .NET MAUI ListView (SfListView) control, its elements, screen reader announcements, and keyboard navigation.
platform: MAUI
control: SfListView
documentation: ug
---

# Accessibility in .NET MAUI ListView

The .NET MAUI ListView (SfListView) provides built-in accessibility support, exposing its visual elements and item containers to assistive technologies such as screen readers (TalkBack on Android, VoiceOver on iOS/macOS, and Narrator on Windows). It also provides comprehensive keyboard navigation and visual focus indication for desktop and tablet platforms.

The following tables list each element along with the value announced by screen readers and its interactive accessibility behavior.

## List Items

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

N> When `AllowGroupExpandCollapse` is set to `true`, group header elements provide state announcements indicating whether the group is currently expanded or collapsed.

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

## Focus Border and Visual States

To ensure accessible visual focus indication when navigating via keyboard or screen reader, `SfListView` provides dedicated focus border styling properties on `ListViewItem`:

<table>
<tr>
<th>Property</th>
<th>Description</th>
</tr>
<tr>
<td>FocusBorderColor</td>
<td>Specifies the stroke color of the focus border drawn around the currently focused item.</td>
</tr>
<tr>
<td>FocusBorderThickness</td>
<td>Specifies the thickness of the focus border drawn around the currently focused item.</td>
</tr>
</table>

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

`SfListView` implements full keyboard interaction support on desktop and tablet environments (Windows, macOS, and physical keyboards connected to Android or iPadOS):

### Navigation and Selection Keys

<table>
<tr>
<th>Key / Key Combination</th>
<th>Description</th>
</tr>
<tr>
<td><kbd>Down Arrow</kbd></td>
<td>Moves focus to the next visible item in vertical layout. In Single selection mode, selects the next item.</td>
</tr>
<tr>
<td><kbd>Up Arrow</kbd></td>
<td>Moves focus to the previous visible item in vertical layout. In Single selection mode, selects the previous item.</td>
</tr>
<tr>
<td><kbd>Right Arrow</kbd></td>
<td>Moves focus to the next item or adjacent column in horizontal or grid layout. In RTL mode, moves to the previous item.</td>
</tr>
<tr>
<td><kbd>Left Arrow</kbd></td>
<td>Moves focus to the previous item or adjacent column in horizontal or grid layout. In RTL mode, moves to the next item.</td>
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
<td><kbd>Space</kbd> or <kbd>Enter</kbd></td>
<td>Selects or toggles selection of the currently focused item. In group headers with expand/collapse enabled, toggles group expansion.</td>
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
<td>In `Extended` selection mode, expands range selection from anchor item to the newly focused item.</td>
</tr>
<tr>
<td><kbd>Tab</kbd></td>
<td>Navigates focus into and out of the `SfListView` control and interactive elements inside templates.</td>
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

## Semantic Properties in ItemTemplate

When creating custom item templates, you can leverage .NET MAUI `SemanticProperties` on template elements to customize the announcement for assistive technologies:
```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView">
  <syncfusion:SfListView x:Name="listView" ItemsSource="{Binding ContactList}">
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
## Right-to-Left (RTL) Support

The `SfListView` automatically mirrors its layout and inverts directional keyboard navigation (e.g., Left and Right arrow keys) when placed in a Right-to-Left context (`FlowDirection="RightToLeft"`), ensuring consistent spatial navigation for users who utilize screen readers in RTL locales.
