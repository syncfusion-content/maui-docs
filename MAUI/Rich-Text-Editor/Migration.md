---
layout: post
title: Migrating from Xamarin to MAUI Rich Text Editor control | Syncfusion®
description: Learn about Migrating from Syncfusion® Xamarin Rich Text Editor to Syncfusion® .NET MAUI Rich Text Editor control and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Migrating from Xamarin RichTextEditor to .NET MAUI RichTextEditor

To migrate easily from [`Xamarin SfRichTextEditor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfRichTextEditor.XForms.SfRichTextEditor.html) to `.NET MAUI SfRichTextEditor`, we kept all the APIs from Xamarin SfRichTextEditor in MAUI SfRichTextEditor. However, to maintain the consistency of API naming in MAUI SfRichTextEditor, we renamed some of the APIs. The APIs that have been changed in MAUI SfRichTextEditor from Xamarin SfRichTextEditor are detailed as follows.

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
<td>{{'[AutoSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_AutoSize)'| markdownify }}</td>
<td>EnableAutoSize</td>
<td>Gets or sets a value indicating whether the editor should automatically resize based on its content.</td>
</tr>
<tr>
<td>{{'[BackgroundColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_BackgroundColor)'| markdownify }}</td>
<td>EditorBackgroundColor</td>
<td>Gets or sets the background color of the editor's content area.</td>
</tr>

<tr>
<td>{{'[DefaultFont](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_DefaultFont)'| markdownify }}</td>
<td>DefaultFontFamily</td>
<td>Gets or sets the default font family.</td>
</tr>

<tr>
<td>{{'[DefaultFontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_DefaultFontColor)'| markdownify }}</td>
<td>DefaultTextColor</td>
<td>Gets or sets the default text color.</td>
</tr>

<tr>
<td>{{'[PlaceHolder](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_PlaceHolder)'| markdownify }}</td>
<td>Placeholder</td>
<td>Gets or sets the placeholder text that is displayed when the editor is empty.</td>
</tr>

<tr>
<td>{{'[PlaceHolderFontColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_PlaceHolderFontColor)'| markdownify }}</td>
<td>PlaceholderColor</td>
<td>Gets or sets the value for place holder font color.</td>
</tr>

<tr>
<td>{{'[PlaceHolderFontFamily](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_PlaceHolderFontFamily)'| markdownify }}</td>
<td>PlaceholderFontFamily</td>
<td>Gets or sets the value for place holder font family.</td>
</tr>

<tr>
<td>{{'[PlaceHolderFontSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_PlaceHolderFontSize)'| markdownify }}</td>
<td>PlaceholderFontSize</td>
<td>Gets or sets the value for place holder font size.</td>
</tr>

<tr>
<td>{{'[WordWrap](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_PlaceHolderFontSize)'| markdownify }}</td>
<td>EnableWordWrap</td>
<td>Gets or sets the word-wrap that allows long words to be able to be broken and wrap onto the next line.</td>
</tr>
</table>

## Events

<table>
<tr>
<th>Xamarin SfRichTextEditor</th>
<th>.NET MAUI SfRichTextEditor</th>
<th>Description</th>
</tr>
<tr>
<td>{{'[ImageInserted](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_ImageRequest)'| markdownify }}</td>
<td>ImageRequested</td>
<td>Occurs when an image is about to be inserted, allowing for customization of the image source.</td>
</tr>
<tr>
<td>{{'[HyperlinkSelected](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_ImageInserted)'| markdownify }}</td>
<td>HyperlinkClicked</td>
<td>Occurs when a hyperlink is tapped, allowing for custom actions to be performed.</td>
</tr>
</table>