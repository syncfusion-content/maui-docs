---
layout: post
title: Migrating from Xamarin to .NET MAUI SfNumericEntry | Syncfusion 
description: Learn about Migrating from Syncfusion Xamarin NumericTextBox to Syncfusion .NET MAUI NumericEntry control and more.
platform: maui
control: SfNumericEntry
documentation: ug
---  

# Migrating from Xamarin SfNumericTextBox to .NET MAUI SfNumericEntry

To migrate easier from the Xamarin SfNumericTextBox to `.NET MAUI SfNumericEntry`, most of the APIs are kept from the Xamarin SfNumericTextBox in MAUI SfNumericEntry. However, to maintain the consistency of API naming in MAUI SfNumericEntry, rename some of the APIs. The APIs changed in MAUI SfNumericEntry from Xamarin SfNumericTextBox are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfNumericTextBox</th>
<th>.NET MAUI SfNumericEntry</th></tr>
<tr>
<td>Syncfusion.XForms.SfNumericTextBox</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfNumericTextBox</th>
<th>.NET MAUI SfNumericEntry</th>
<th>Description</th></tr>
<tr>
<td>BorderColor</td>
<td>Stroke</td>
<td>Gets or sets a color that describes the stroke.</td></tr>
<tr>
<td>AllowDefaultDecimalDigits</td>
<td>AllowNull</td>
<td>Gets or sets a value indicating whether the SfNumericEntry allows null value or not.</td></tr>
<tr>
<td>ClearButtonVisibility</td>
<td>ShowClearButton</td>
<td>Gets or sets a value indicating whether to show or hide the clear button in SfNumericEntry.</td></tr>
<tr>
<td>FormatString</td>
<td>CustomFormat</td>
<td>Gets or sets the format used to specify the formatting of Value.</td></tr>
<tr>
<td>IsReadOnly</td>
<td>IsEditable</td>
<td>Gets or sets a value indicating whether the SfNumericEntry allows editing the value or not.</td></tr>
<tr>
<td>Watermark</td>
<td>Placeholder</td>
<td>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</td></tr>
<tr>
<td>WatermarkColor</td>
<td>PlaceholderColor</td>
<td>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</td></tr>
</table> 
