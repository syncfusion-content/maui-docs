---
layout: post
title: Properties of .NET MAUI Markdown Viewer control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Markdown Viewer (SfMarkdownViewer) control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# .NET MAUI Markdown Viewer API Reference

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Settings">Settings</a></td>
        <td>MarkdownStyleSettings</td>
        <td>Defines the style settings used to control the appearance of markdown content.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source">Source</a></td>
        <td>string</td>
        <td>Defines the markdown source content to be rendered in the viewer.</td>
    </tr>
</table>

## Events

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_HyperlinkClicked">HyperlinkClicked</a></td>
        <td>EventHandler&lt;MarkdownHyperlinkClickedEventArgs&gt;</td>
        <td>Raised when a hyperlink inside the markdown content is clicked.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetHtmlText">GetHtmlText()</a></td>
        <td>string</td>
        <td>Returns the current markdown content converted to HTML.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetMarkdownText">GetMarkdownText()</a></td>
        <td>string</td>
        <td>Returns the current content as markdown-formatted text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetText">GetText()</a></td>
        <td>string</td>
        <td>Returns the current content as plain text without formatting.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_OnBindingContextChanged">OnBindingContextChanged()</a></td>
        <td>void</td>
        <td>Called when the binding context of the control changes.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_OnParentSet">OnParentSet()</a></td>
        <td>void</td>
        <td>Called when the parent of the control changes.</td>
    </tr>
</table>