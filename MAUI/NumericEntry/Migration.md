---
layout: post
title: Migrating from Xamarin to .NET MAUI SfNumericEntry | Syncfusion® 
description: Learn about migrating from Syncfusion® Xamarin NumericTextBox and NumericUpDown to Syncfusion® .NET MAUI NumericEntry control and more.
platform: maui
control: SfNumericEntry
documentation: ug
---  

# Migrating from Xamarin SfNumericTextBox and SfNumericUpDown to .NET MAUI SfNumericEntry

To facilitate migration from Xamarin SfNumericTextBox and SfNumericUpDown to [.NET MAUI SfNumericEntry](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html), most of the APIs have been retained for compatibility. However, some APIs have been renamed in .NET MAUI SfNumericEntry to ensure consistent API naming. Below are the API changes when migrating from Xamarin SfNumericTextBox and SfNumericUpDown to MAUI SfNumericEntry.

## Namespaces 

<table>
<tr>
<th>Xamarin SfNumericTextBox <br> Xamarin SfNumericUpDown</th>
<th>.NET MAUI SfNumericEntry</th></tr>
<tr>
<td>Syncfusion.SfNumericTextBox.XForms</td>
<td>Syncfusion.Maui.Inputs</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfNumericTextBox <br> Xamarin SfNumericUpDown </th>
<th>.NET MAUI SfNumericEntry</th>
<th>Description</th></tr>
<tr>
<td>{{'[BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_BorderColor)'| markdownify }}</td>
<td>{{'[Stroke](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Stroke)'| markdownify }}</td>
<td>Gets or sets the stroke color of the control.</td></tr>
<tr>
<td>{{'[ClearButtonVisibility](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_ClearButtonVisibility)'| markdownify }}</td>
<td>{{'[ShowClearButton](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_ShowClearButton)'| markdownify }}</td>
<td>Gets or sets a value to indicate whether to show or hide the clear button in the SfNumericEntry.</td></tr>
<tr>
<td>{{'[FormatString](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_FormatString)'| markdownify }}</td>
<td>{{'[CustomFormat](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_CustomFormat)'| markdownify }}</td>
<td>Gets or sets the format used to specify the value's formatting.</td></tr>
<tr>
<td>{{'[IsReadOnly](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_IsReadOnly)'| markdownify }}</td>
<td>{{'[IsEditable](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_IsEditable)'| markdownify }}</td>
<td>Gets or sets a value to indicate whether editing the value in the SfNumericEntry is allowed.</td></tr>
<tr>
<td>{{'[Watermark](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_Watermark)'| markdownify }}</td>
<td>{{'[Placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_Placeholder)'| markdownify }}</td>
<td>Gets or sets the text displayed in the control until the value changes by user action or other operations.</td></tr>
<tr>
<td>{{'[WatermarkColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.SfNumericTextBox.html#Syncfusion_SfNumericTextBox_XForms_SfNumericTextBox_WatermarkColor)'| markdownify }}</td>
<td>{{'[PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfNumericEntry.html#Syncfusion_Maui_Inputs_SfNumericEntry_PlaceholderColor)'| markdownify }}</td>
<td>Gets or sets the color of the placeholder text in the control.</td></tr>
</table>

## Events

<table> 
<tr>
<th>Event Name</th>
<th>Xamarin SfNumericTextBox <br> Xamarin SfNumericUpDown </th>
<th>.NET MAUI SfNumericEntry</th>
<th>Description</th></tr>
<tr>
<td> ValueChanged </td>
<td>{{'[ValueEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[Value](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html#Syncfusion_SfNumericTextBox_XForms_ValueEventArgs_Value)'| markdownify }} </li> <li>  {{'[OldValue](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfNumericTextBox.XForms.ValueEventArgs.html#Syncfusion_SfNumericTextBox_XForms_ValueEventArgs_OldValue)'| markdownify }}</li> </ul></td>
<td>{{'[NumericEntryValueChangedEventArgs](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html)'| markdownify }}<br/> <ul> <li> {{'[OldValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html#Syncfusion_Maui_Inputs_NumericEntryValueChangedEventArgs_OldValue)'| markdownify }} </li> <li>  {{'[NewValue](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.NumericEntryValueChangedEventArgs.html#Syncfusion_Maui_Inputs_NumericEntryValueChangedEventArgs_NewValue)'| markdownify }}</li> </ul></td>
<td>Occurs after the user triggers evaluation of new input by pressing the Enter key, clicking a spin button, or by changing focus.</td></tr>
</table> 

## Upcoming Features

- ReturnCommand and ReturnCommandParameter support
- SelectAllOnFocus boolean support
- GroupSeparatorMode support
