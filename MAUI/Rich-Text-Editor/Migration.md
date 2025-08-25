---
layout: post
title: Migrating from Xamarin to MAUI Rich Text Editor control | Syncfusion®
description: Learn about Migrating from Syncfusion® Xamarin Rich Text Editor to Syncfusion® .NET MAUI Rich Text Editor control and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Migrating from Xamarin RichTextEditor to .NET MAUI RichTextEditor

To migrate easily from [`Xamarin SfRichTextEditor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRichTextEditor.XForms.SfRichTextEditor.html) to [`.NET MAUI SfRichTextEditor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html?tabs=tabid-1), we kept all the APIs from Xamarin SfRichTextEditor in MAUI SfRichTextEditor. However, to maintain the consistency of API naming in MAUI SfRichTextEditor, we renamed some of the APIs. The APIs that have been changed in MAUI SfRichTextEditor from Xamarin SfRichTextEditor are detailed as follows.

## Namespaces 

<table>
<tr>
<th>Xamarin SfRichTextEditor</th>
<th>.NET MAUI SfRichTextEditor</th></tr>
<tr>
<td>Syncfusion.RichTextEditor.XForms</td>
<td>Syncfusion.Maui.RichTextEditor</td></tr>
</table>

## Properties

<table> 
<tr>
<th>Xamarin SfRichTextEditor</th>
<th>.NET MAUI SfRichTextEditor</th>
<th>Description</th></tr>
<tr>
<td>{{'[DotsBorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRichTextEditor.XForms.SfRichTextEditor.html#Syncfusion_SfRichTextEditor_XForms_SfRichTextEditor_DotsBorderColor)'| markdownify }}</td>
<td>DotsStroke</td>
<td>Gets or sets the value of DotsStroke.
</td></tr>
</table>
