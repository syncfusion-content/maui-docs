---
layout: post
title: Accessibility in .NET MAUI Calendar control | Syncfusion
description: Learn here all about accessibility features of Syncfusion .NET MAUI Calendar (SfCalendar) control. 
platform: maui
control: SfCalendar
documentation: ug
---

# Accessibility in .NET Maui SfCalendar

Enhance .NET MAUI Calendar's accessibility with user-friendly design, ensuring inclusive features for seamless navigation and usability for all users. Please find the table of elements along with their formats and examples.

## Month View

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Month Header</td>
<td>MMMM yyyy</td>
<td>May 2023</td>
</tr>
<tr>
<td>Month Header – More than one month in view</td>
<td>MMMM – MMMM yyyy</td>
<td>November – December 2023</td>
</tr>
<tr>
<td>View Header</td>
<td>EEE</td>
<td>Monday</td>
</tr>
<tr>
<td>Week Number</td>
<td>Week, Week number</td>
<td>Week 26</td>
</tr>
<tr>
<td>MonthCell</td>
<td>dddd dd/MMMM/yyyy</td>
<td>Tuesday 27/May/2023</td>
</tr>
<tr>
<td>Disabled Cells</td>
<td>EEE, dd/MMMM/yyyy, Disabled date</td>
<td>Friday, 31 January 2023, Disabled date</td>
</tr>
<tr>
<td>Blackout date</td>
<td>EEE, dd/MMMM/yyyy, Blackout date</td>
<td>Monday, 13 May 2023, Blackout date</td>
</tr>
</table>

## Year View

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Header</td>
<td>yyyy</td>
<td>2023</td>
</tr>
<tr>
<td>Year Cell</td>
<td>MMMM yyyy</td>
<td>January 2023</td>
</tr>
<tr>
<td>Disabled cell</td>
<td>MMMM yyyy, Disabled cell</td>
<td>December 2019, Disabled cell</td>
</tr>
</table>

## Decade View

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Header</td>
<td>yyyy - yyyy</td>
<td>2020 – 2029</td>
</tr>
<tr>
<td>Decade Cell</td>
<td>yyyy</td>
<td>2023</td>
</tr>
<tr>
<td>Disabled cell</td>
<td>yyyy, Disabled cell</td>
<td>2019 Disabled cell</td>
</tr>
</table>

## Century View

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Header</td>
<td>yyyy - yyyy</td>
<td>2000 – 2099</td>
</tr>
<tr>
<td>Century Cell</td>
<td>yyyy</td>
<td>2070 – 2079</td>
</tr>
<tr>
<td>Disabled cell</td>
<td>yyyy - yyyy</td>
<td>2010 to 2019, Disabled cell</td>
</tr>
</table>