---
layout: post
title: Accessibility in MAUI Calendar control | Syncfusion
description: Learn here all about Accessibility support in Syncfusion MAUI Calendar (SfCalendar) control and more.
platform: MAUI
control: SfCalendar
documentation: UG
---

# Accessibility in MAUI Calendar (SfCalendar)

## Keyboard
`SfCalendar` supports selection using keyboard interactions.

<table>
<tr>
<th>
Key
</th>
<th>
Description
</th>
</tr>
<tr>
<td>
DownArrow
</td>
<td>
Moves selection to the date directly below the currently selected date on next row.
</td>
</tr>
<tr>
<td>
UpArrow
</td>
<td>
Moves selection to the date directly above the currently selected date on previous row.
</td>
</tr>
<tr>
<td>
RightArrow
</td>
<td>
Moves the selection to the next date of the date currently selected.
</td>
</tr>
<tr>
<td>
LeftArrow
</td>
<td>
Moves the selection to the previous date of the date currently selected.
</td>
</tr>
</table>

### Shift key combinations
<table>
<tr>
<th>
Key combinations
</th>
<th>
Description
</th>
</tr>
<tr>
<td>
Shift + DownArrow
</td>
<td>
If the SelectionMode is Multiple, the date directly below the last selected date on the next row will be selected along with the currently selected dates. 
If the SelectionMode is RangeSelection and selecting dates using the keyboard, the range will be extended to the date directly below the last selected date.
</td>
</tr>
<tr>
<td>
Shift + UpArrow
</td>
<td>
If the SelectionMode is Multiple, the date directly above the last selected date on the previous row will be selected along with the currently selected dates.
If the SelectionMode is RangeSelection and selecting dates using the keyboard, the range will be extended to the date directly above the last selected date.
</td>
</tr>
<tr>
<td>
Shift + RightArrow
</td>
<td>
If the SelectionMode is Multiple, the next date of the last selected date will be selected along with the currently selected dates. 
If the SelectionMode is RangeSelection and selecting dates using the keyboard, the range will be extended to the next date of the last selected date.
</td>
</tr>
<tr>
<td>
Shift + LeftArrow
</td>
<td>
If the SelectionMode is Multiple, the previous date of the last selected date will be selected along with the currently selected dates.
If the SelectionMode is RangeSelection and selecting dates using the keyboard, the range will be extended to the previous date of the last selected date.
</td>
</tr>
</table>

### View navigations
<table>
<tr>
<th>
Key combinations
</th>
<th>
Description
</th>
</tr>
<tr>
<td>
Ctrl + UpArrow
</td>
<td>
View mode changes in the order of Month, Year, Decade, and Century.
</td>
</tr>
<tr>
<td>
Ctrl + DownArrow
</td>
<td>
View mode changes in the order of Month, Century, Decade, and Year.
</td>
</tr>
</table>
<tr>
<td>
Ctrl + LeftArrow
</td>
<td>
Navigate to the prev view.
</td>
</tr>
<tr>
<td>
Ctrl + RightArrow
</td>
<td>
Navigate to the next view.
</td>
</tr>
