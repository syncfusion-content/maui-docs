---
layout: post
title: Migrating from Xamarin to MAUI Rich Text Editor control | Syncfusion®
description: Learn about Migrating from Syncfusion® Xamarin Rich Text Editor to Syncfusion® .NET MAUI Rich Text Editor control and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Migrating from Xamarin RichTextEditor to .NET MAUI RichTextEditor

To migrate easily from [`Xamarin SfRichTextEditor`](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.html) to [`.NET MAUI SfRichTextEditor`](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.html), we kept all the APIs from Xamarin SfRichTextEditor in MAUI SfRichTextEditor. However, to maintain the consistency of API naming in MAUI https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.html, we renamed some of the APIs. The APIs that have been changed in MAUI SfRichTextEditor from Xamarin SfRichTextEditor are detailed as follows.

## Namespaces 

<table>
    <tr>
        <th>Xamarin SfRichTextEditor</th>
        <th>.NET MAUI SfRichTextEditor</th>
    </tr>
    <tr>
        <td>Syncfusion.RichTextEditor.XForms</td>
        <td>Syncfusion.Maui.RichTextEditor</td>
    </tr>
</table>

## Properties

<table> 
    <tr>
        <th>Xamarin SfRichTextEditor</th>
        <th>.NET MAUI SfRichTextEditor</th>
        <th>Description</th>
    </tr>
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

## Methods

<table>
    <tr>
        <th>Xamarin SfRichTextEditor</th>
        <th>.NET MAUI SfRichTextEditor</th>
        <th>Description</th>
    </tr>
    <tr>
        <td>{{'[AlignFull()](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_AlignFull)'| markdownify }}</td>
        <td>AlignJustify()</td>
        <td>Justifies the paragraph.</td>
    </tr>
    <tr>
        <td>{{'[ApplyFont(string fontName)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_ApplyFont_System_String_)'| markdownify }}</td>
        <td>ApplyFontFamily(string fontName)</td>
        <td>JApplies the specified font family.</td>
    </tr>
    <tr>
        <td>{{'[EditHyperlink(string url, string text)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_EditHyperlink_System_String_System_String_)'| markdownify }}</td>
        <td>EditHyperlink(string text, string oldUrl, string newUrl)</td>
        <td>Edits the hyperlink.</td>
    </tr>
    <tr>
        <td>{{'[InsertHyperlink(string url, string displayText)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_InsertHyperlink_System_String_System_String_)'| markdownify }}</td>
        <td>InsertHyperlink(string displayText, string Url)</td>
        <td>Inserts the hyperlink.</td>
    </tr>
    <tr>
        <td>{{'[RemoveHyperlink()](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_RemoveHyperlink)'| markdownify }}</td>
        <td>RemoveHyperlink(string text, string Url)</td>
        <td>Removes the hyperlink.</td>
    </tr>
    <tr>
        <td>{{'[InsertImage(ImageSource imageSource)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_InsertImage_Syncfusion_XForms_RichTextEditor_ImageSource_)'| markdownify }}</td>
        <td>InsertImage(SfRichTextEditorImageSource imageSource)</td>
        <td>Inserts the specified image into the SfRichTextEditor.</td>
    </tr>
    <tr>
        <td>{{'[SetFontColor(string fontColor)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_SetFontColor_System_String_)'| markdownify }}</td>
        <td>ApplyTextColor(Color textColor)</td>
        <td>Apply the text color.</td>
    </tr>
    <tr>
        <td>{{'[SetFontSize(string fontSize)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_SetFontSize_System_String_)'| markdownify }}</td>
        <td>ApplyFontSize(double fontSize)</td>
        <td>Apply the font size.</td>
    </tr>
    <tr>
        <td>{{'[SetHighlightColor(string color)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_SetHighlightColor_System_String_)'| markdownify }}</td>
        <td>ApplyHighlightColor(Color highlightColor)</td>
        <td>Highlights the background color.</td>
    </tr>
    <tr>
        <td>{{'[SetParagraphFormat(string heading)](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_SetParagraphFormat_System_String_)'| markdownify }}</td>
        <td>ApplyParagraphFormat(RichTextEditorParagraphFormat format)</td>
        <td>Apply the paragraph formatting style.</td>
    </tr>
    <tr>
        <td>{{'[ToggleSubScript()](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_ToggleSubScript)'| markdownify }}</td>
        <td>ToggleSubscript()</td>
        <td>Toggles the selected text as sub script format.</td>
    </tr>
    <tr>
        <td>{{'[ToggleSuperScript()](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.RichTextEditor.SfRichTextEditor.html#Syncfusion_XForms_RichTextEditor_SfRichTextEditor_ToggleSuperScript)'| markdownify }}</td>
        <td>ToggleSuperscript()</td>
        <td>Toggles the selected text as super script format.</td>
    </tr>
</table>


## Limitations

* `Nested ScrollView:` RichTextEditor scroll behavior is incompatible with parent ScrollView containers and will be automatically disabled.
* `AutoSize Configuration:` To prevent off-screen rendering when AutoSize is enabled, configure the MaximumHeightRequest property to constrain the control within viewport boundaries.
* `Keyboard Interaction:` Toolbar visibility is affected when MaximumHeightRequest extends into the on-screen keyboard area, causing automatic hiding.
* `Supported Content Types:` Editor content is restricted to plain text and HTML markup formats only.