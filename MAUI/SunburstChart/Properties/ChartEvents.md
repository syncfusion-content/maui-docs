---
layout: post
title: Events in .NET MAUI Sunburst Chart | Syncfusion®
description: Chart events in .NET MAUI Sunburst Chart let you respond to selection changes and user interactions for customized behavior.
platform: maui
control: SfSunburstChart
documentation: ug
---

# Events API in .NET MAUI Sunburst Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangingEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangingEventArgs_Cancel" aria-label="View Cancel property in API reference">Cancel</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the pending selection change should be prevented. Set this property to stop the new selection from being applied.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangedEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangedEventArgs_IsSelected" aria-label="View IsSelected property in API reference">IsSelected</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Indicates whether the affected segment is currently selected or deselected after the selection change is completed.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangedEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangedEventArgs_NewSegment" aria-label="View NewSegment property in API reference">NewSegment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSegment.html" aria-label="View SunburstSegment type in API reference">SunburstSegment</a></td>
    <td>Provides the segment that was selected or deselected during the selection change operation.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangingEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangingEventArgs_NewSegment" aria-label="View NewSegment property in API reference">NewSegment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSegment.html" aria-label="View SunburstSegment type in API reference">SunburstSegment</a></td>
    <td>Provides the segment that is about to be selected.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangedEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangedEventArgs_OldSegment" aria-label="View OldSegment property in API reference">OldSegment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSegment.html" aria-label="View SunburstSegment type in API reference">SunburstSegment</a></td>
    <td>Provides the segment that was selected before the current selection change occurred.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSelectionChangingEventArgs.html#Syncfusion_Maui_SunburstChart_SunburstSelectionChangingEventArgs_OldSegment" aria-label="View OldSegment property in API reference">OldSegment</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.SunburstChart.SunburstSegment.html" aria-label="View SunburstSegment type in API reference">SunburstSegment</a></td>
    <td>Provides the segment that was selected before the pending selection change.</td>
</tr>
</table>
