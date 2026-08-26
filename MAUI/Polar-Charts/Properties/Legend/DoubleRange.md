---
layout: post
title: Legend and styles in .NET MAUI Polar Chart | Syncfusion®
description: This section lists the public API members of the chart legend, legend label style, marker settings, and shared helper types available in the Syncfusion® .NET MAUI Polar Chart (SfPolarChart) API.
platform: maui
control: SfPolarChart
documentation: ug
---

# Legend API in .NET MAUI Polar Chart

## Properties

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Delta" aria-label="View Delta property in API reference">Delta</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the numeric span between the start and end values of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Empty" aria-label="View Empty property in API reference">Empty</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Represents an empty range that contains no valid values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_End" aria-label="View End property in API reference">End</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the upper bound of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_IsEmpty" aria-label="View IsEmpty property in API reference">IsEmpty</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Indicates whether the range contains any valid values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Median" aria-label="View Median property in API reference">Median</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the midpoint value between the start and end of the range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Start" aria-label="View Start property in API reference">Start</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.double" aria-label="View double type in API reference">double</a></td>
    <td>Provides the lower bound of the range.</td>
</tr>
</table>

## Methods

<table>
<tr>
    <th>Name</th>
    <th>Type</th>
    <th>Description</th>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Equals_System_Object_" aria-label="View Equals method in API reference">Equals(Object)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified object represents the same range values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Exclude_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange__Syncfusion_Maui_Charts_DoubleRange__" aria-label="View Exclude method in API reference">Exclude(DoubleRange, DoubleRange, out DoubleRange, out DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Removes one range from another and returns the remaining range portions, if any.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_GetHashCode" aria-label="View GetHashCode method in API reference">GetHashCode()</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.int32" aria-label="View int type in API reference">int</a></td>
    <td>Returns a hash code that uniquely represents the current range instance for comparison and collection operations.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Inside_System_Double_" aria-label="View Inside method in API reference">Inside(Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified value falls within the range boundaries.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Inside_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Inside method in API reference">Inside(DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the specified range is completely contained within the current range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Intersects_System_Double_System_Double_" aria-label="View Intersects method in API reference">Intersects(Double, Double)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the current range overlaps the specified start and end values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Intersects_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Intersects method in API reference">Intersects(DoubleRange)</a></td>
    <td><a href="https://learn.microsoft.com/dotnet/api/system.boolean" aria-label="View bool type in API reference">bool</a></td>
    <td>Determines whether the current range overlaps another range.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Offset_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Offset method in API reference">Offset(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range whose start and end values are shifted by the specified offset.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Scale_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Scale method in API reference">Scale(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range whose size is scaled by the specified factor.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_System_Double___" aria-label="View Union method in API reference">Union(Double[])</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses all specified values.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_Syncfusion_Maui_Charts_DoubleRange_System_Double_" aria-label="View Union method in API reference">Union(DoubleRange, Double)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses both the specified range and value.</td>
</tr>

<tr valign="top">
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html#Syncfusion_Maui_Charts_DoubleRange_Union_Syncfusion_Maui_Charts_DoubleRange_Syncfusion_Maui_Charts_DoubleRange_" aria-label="View Union method in API reference">Union(DoubleRange, DoubleRange)</a></td>
    <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoubleRange.html" aria-label="View DoubleRange type in API reference">DoubleRange</a></td>
    <td>Creates a range that encompasses both specified ranges.</td>
</tr>
</table>
