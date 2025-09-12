---
layout: post
title: Accessibility in .NET MAUI SfScheduler control | Syncfusion<sup>&reg;</sup>
description: Learn here about Accessibility support with the Syncfusion<sup>&reg;</sup> .NET MAUI Scheduler (SfScheduler) control, its elements, and more.
platform: maui
control: SfScheduler
documentation: ug
---

# Accessibility Support in .NET MAUI Scheduler (SfScheduler)

Accessibility support in `SfScheduler` is designed to provide voice descriptions of scheduler elements and scheduled events.

## Keyboard shortcuts in .NET MAUI Scheduler (SfScheduler)

The `SfScheduler` supports selecting the scheduler date time, appointments, and view navigation using keyboard interactions in WinUI, macOS, and iOS platforms.

N> [SelectionChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_SelectionChanged) event triggers for cell selection changed.

### Day, Week and WorkWeek views

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Right arrow<br/><br/></td><td>Moves selection to the same time slot on the next (LTR) or previous (RTL) day.<br/><br/></td></tr>
<tr>
<td>
Left arrow<br/><br/></td><td>
Moves selection to the same time slot on the previous (LTR) or next (RTL) day.<br/><br/></td></tr>
<tr>
<td>
Down arrow<br/><br/></td><td>
Moves selection to the next time slot directly below the currently selected time slot.<br/><br/></td></tr>
<tr>
<td>
Up arrow<br/><br/></td><td>
Moves selection to the previous time slot directly above the currently selected time slot.<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
It triggers {{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify}} event<br/><br/></td></tr>
</table>

### Timeline views

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Right arrow<br/><br/></td><td>Moves selection to the next (LTR) or previous (RTL) time slot of the currently selected time slot. <br/><br/></td></tr>
<tr>
<td>
Left arrow<br/><br/></td><td>
Moves selection to the previous (LTR) or next (RTL) time slot of the currently selected time slot.<br/><br/></td></tr>
<tr>
<td>
Down arrow<br/><br/></td><td>
Moves selection to the same time slot on the next resource.<br/><br/></td></tr>
<tr>
<td>
Up arrow<br/><br/></td><td>
Moves selection to the same time slot on the previous resource.<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
It triggers {{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify}} event<br/><br/></td></tr>
</table>

### Month view

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Right arrow<br/><br/></td><td>Moves selection to the next (LTR) or previous (LTR) date of the currently selected date.<br/><br/></td></tr>
<tr>
<td>
Left arrow<br/><br/></td><td>
Moves selection to the previous (LTR) or next (RTL) date of the currently selected date. <br/><br/></td></tr>
<tr>
<td>
Down arrow<br/><br/></td><td>
Moves selection to the date directly below the currently selected date on the next row.<br/><br/></td></tr>
<tr>
<td>
Up arrow<br/><br/></td><td>
Moves selection to the date directly above the currently selected date on the previous row.<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
It triggers {{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify}} event<br/><br/></td></tr>
</table>

### Appointments

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Tab<br/><br/></td><td>Moves selection to the next (LTR) or Previous (RTL) appointment of the currently selected appointment. 
<br/><br/></td></tr>
<tr>
<td>
Shift + Tab<br/><br/></td><td>
Moves selection to the previous (LTR) or next (RTL) appointment of the currently selected appointment. 
<br/><br/></td></tr>
<tr>
<td>
Delete<br/><br/></td><td>Deletes the selected appointment from appointments collection.<br/><br/></td></tr>
<tr>
<td>
Enter<br/><br/></td><td>
It triggers {{'[Tapped](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Scheduler.SfScheduler.html#Syncfusion_Maui_Scheduler_SfScheduler_Tapped)'| markdownify}} event<br/><br/></td></tr>
</table>

### View navigations

#### Windows

<table>
<tr>
<td>
Ctrl + Alt + 1 => DayView<br/><br/></td><td>
Moves the view to day view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 2 => WeekView<br/><br/></td><td>
Moves the view to week view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 3 => WorkWeekView<br/><br/></td><td>
Moves the view to work week view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 4 => MonthView<br/><br/></td><td>
Moves the view to work week view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 5 => TimelineDayView<br/><br/></td><td>
Moves the view to Timeline day view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 6 => TimelineWeekView<br/><br/></td><td>
Moves the view to Timeline week view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 7 => TimelineWorkWeekView<br/><br/></td><td>
Moves the view to Timeline work week view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 8 => TimelineMonthView<br/><br/></td><td>
Moves the view to Timeline month view.<br/><br/></td></tr>
<tr>
<td>
Ctrl + Alt + 9 => AgendaView<br/><br/></td><td>
Moves the view to Agenda view.<br/><br/></td></tr>
</table>

N> There is a framework issue with unable to remove or modify the default visual focus style on tab press in windows platform and following the framework issue in this report [link](https://github.com/dotnet/maui/issues/10193).

#### MAC and iOS

<table>
<tr>
<td>
Command + 1 => DayView<br/><br/></td><td>
Moves the view to day view.<br/><br/></td></tr>
<tr>
<td>
Command + 2 => WeekView<br/><br/></td><td>
Moves the view to week view.<br/><br/></td></tr>
<tr>
<td>
Command + 3 => WorkWeekView<br/><br/></td><td>
Moves the view to work week view.<br/><br/></td></tr>
<tr>
<td>
Command + 4 => MonthView<br/><br/></td><td>
Moves the view to work week view.<br/><br/></td></tr>
<tr>
<td>
Command + 5 => TimelineDayView<br/><br/></td><td>
Moves the view to Timeline day view.<br/><br/></td></tr>
<tr>
<td>
Command + 6 => TimelineWeekView<br/><br/></td><td>
Moves the view to Timeline week view.<br/><br/></td></tr>
<tr>
<td>
Command + 7 => TimelineWorkWeekView<br/><br/></td><td>
Moves the view to Timeline work week view.<br/><br/></td></tr>
<tr>
<td>
Command + 8 => TimelineMonthView<br/><br/></td><td>
Moves the view to Timeline month view.<br/><br/></td></tr>
<tr>
<td>
Command + 9 => AgendaView<br/><br/></td><td>
Moves the view to Agenda view.<br/><br/></td></tr>
</table>

N> There is a framework issue with focus events not working in MAC and iOS and the following framework issue in this report [link](https://github.com/dotnet/maui/issues/10192).

### Header

<table>
<tr>
<td>
<b> Navigation Shortcut Keys </b> <br/><br/></td><td>
<b> Descriptions </b> <br/><br/></td></tr>
<tr>
<td>
Tab<br/><br/></td><td>Move to next focusable element in header.<br/><br/></td></tr>
<tr>
<td>
Shift + Tab<br/><br/></td><td>
Move to previous focusable element in header.<br/><br/></td></tr>
</table>

N> You can also explore our [MAUI Scheduler example](https://github.com/syncfusion/maui-demos) to know how to schedule and manage appointments through an intuitive user interface, similar to the Outlook calendar.
