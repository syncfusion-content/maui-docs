---
layout: post
title: Migrating from Xamarin to .NET MAUI SfNumericEntry | Syncfusion 
description: Learn about Migrating from Syncfusion Xamarin NumericTextBox and NumericUpDown to Syncfusion .NET MAUI NumericEntry control and more.
platform: maui
control: SfNumericEntry
documentation: ug
---  

# Migrating from Xamarin SfNumericTextBox and SfNumericUpDown to .NET MAUI SfNumericEntry

To migrate easier from the Xamarin SfNumericTextBox and SfNumericUpDown to `.NET MAUI SfNumericEntry`, most of the APIs are kept from the Xamarin SfNumericTextBox and SfNumericUpDown  in MAUI SfNumericEntry. However, to maintain the consistency of API naming in MAUI SfNumericEntry, rename some of the APIs. The APIs changed in MAUI SfNumericEntry from Xamarin SfNumericTextBox and SfNumericUpDown are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfNumericTextBox</th>
<th>.NET MAUI SfNumericEntry</th></tr>
<tr>
<td>Syncfusion.SfNumericTextBox.XForms</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfNumericTextBox</th>
<th>.NET MAUI SfNumericEntry</th>
<th>Description</th></tr>
<tr>
<td>[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_BorderColor)</td>
<td>[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Stroke)</td>
<td>Gets or sets a color that describes the stroke.</td></tr>
<tr>
<td>[AllowDefaultDecimalDigits](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_AllowDefaultDecimalDigits)</td>
<td>[AllowNull](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_AllowNull)</td>
<td>Gets or sets a value indicating whether the SfNumericEntry allows null value or not.</td></tr>
<tr>
<td>[ClearButtonVisibility](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_ClearButtonVisibility)</td>
<td>[ShowClearButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ShowClearButton)</td>
<td>Gets or sets a value indicating whether to show or hide the clear button in SfNumericEntry.</td></tr>
<tr>
<td>[FormatString](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_FormatString)</td>
<td>[CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat)</td>
<td>Gets or sets the format used to specify the formatting of Value.</td></tr>
<tr>
<td>[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_IsReadOnly)</td>
<td>[IsEditable](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_IsEditable)</td>
<td>Gets or sets a value indicating whether the SfNumericEntry allows editing the value or not.</td></tr>
<tr>
<td>[Watermark](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_Watermark)</td>
<td>[Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Placeholder)</td>
<td>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</td></tr>
<tr>
<td>[WatermarkColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_WatermarkColor)</td>
<td>[PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_PlaceholderColor)</td>
<td>Gets or sets the text that is displayed in the control until the value is changed by a user action or some other operation.</td></tr>
</table> 

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfNumericTextBox</th>
<th>.NET MAUI SfNumericEntry</th>
<th>Description</th></tr>
<tr>
<td> ValueChanged </td>
<td>{{'[ValueEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html#Syncfusion_SfNumericTextBox_XForms_ValueEventArgs_Value)'| markdownify }} </li> <li>  {{'[OldValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html#Syncfusion_SfNumericTextBox_XForms_ValueEventArgs_OldValue)'| markdownify }}</li> </ul></td>
<td>{{'[NumericEntryValueChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html#Syncfusion_Maui_Inputs_NumericEntryValueChangedEventArgs_OldValue)'| markdownify }} </li> <li>  {{'[NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html#Syncfusion_Maui_Inputs_NumericEntryValueChangedEventArgs_NewValue)'| markdownify }}</li> </ul></td>
<td>Occurs after the user triggers evaluation of new input by pressing the Enter key, clicking a spin button, or by changing focus.</td></tr>
</table> 

## Upcoming features

  * UpdownButton customizations
  * ReturnCommand and ReturnCommandParameter support
  * SelectAllOnFocus boolean support
  * GroupSeparatorMode support
  * ValueChangeMode support
