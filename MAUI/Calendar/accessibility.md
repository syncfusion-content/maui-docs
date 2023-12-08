---
layout: post
title: Accessibility in .NET MAUI Calendar Control | Syncfusion
description: Learn here all about the accessibility features of Syncfusion .NET MAUI Calendar (SfCalendar) control.
platform: maui
control: SfCalendar
documentation: ug
---

# Accessibility in .NET Maui SfCalendar

Enhance .NET MAUI Calendar's accessibility with a user-friendly design, ensuring inclusive features for seamless navigation and usability for all users. Please find the table of elements along with their formats and examples.

## Month View

<table>
<tr>
<th>Element</th>
<th>Format</th>
<th>Example</th>
</tr>
<tr>
<td>Header</td>
<td>MMMM yyyy</td>
<td>May 2023</td>
</tr>
<tr>
<td>Header – More than one month in view while number week lesser than 6</td>
<td>MMMM – MMMM yyyy</td>
<td>November – December 2023</td>
</tr>
<tr>
<td>Left arrow</td>
<td>string</td>
<td>Backward</td>
</tr>
<tr>
<td>Right arrow</td>
<td>string</td>
<td>Forward</td>
</tr>
<tr>
<td>Today button</td>
<td>string</td>
<td>Today</td>
</tr>
<tr>
<td>Ok button</td>
<td>string</td>
<td>Ok</td>
</tr>
<tr>
<td>Cancel button</td>
<td>string</td>
<td>Cancel</td>
</tr>
<tr>
<td>Month Header</td>
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
<tr>
<td>Special date</td>
<td>EEE, dd/MMMM/yyyy, Special date</td>
<td>Monday, 25 May 2023, Special date</td>
</tr>
</table>

![Month view accessibility in .NET MAUI Calendar.](images/accessibility/maui-month-view-accessibility.png)

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

![Year view accessibility in .NET MAUI Calendar.](images/accessibility/maui-year-view-accessibility.png)

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

![Decade view accessibility in .NET MAUI Calendar.](images/accessibility/maui-decade-view-accessibility.png)

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

![Century view accessibility in .NET MAUI Calendar.](images/accessibility/maui-century-view-accessibility.png)