---
layout: post
title: Properties of .NET MAUI Markdown Viewer control | Syncfusion®
description: This section explains the properties, events, and methods with Syncfusion® MAUI Markdown Viewer (SfMarkdownViewer) control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# API Reference for .NET MAUI Markdown Viewer

## Properties

<table>
    <tr>
        <th>Name</th>
        <th>Type</th>
        <th>Description</th>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Settings" aria-label="View Settings property in API reference">Settings</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html" aria-label="View MarkdownStyleSettings type in API reference">MarkdownStyleSettings</a></td>
        <td>Defines the style configuration used to control how markdown content is rendered. Includes formatting details such as <code>font</code>, <code>spacing</code>, and other visual presentation settings.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source" aria-label="View Source property in API reference">Source</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Defines the markdown content to be displayed in the viewer. Supports headings, lists, links, tables, and other standard markdown elements.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_HyperlinkClicked" aria-label="View HyperlinkClicked event in API reference">HyperlinkClicked</a></td>
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownHyperlinkClickedEventArgs.html" aria-label="View MarkdownHyperlinkClickedEventArgs type in API reference">EventHandler&lt;MarkdownHyperlinkClickedEventArgs&gt;</a></td>
        <td>Raised when a <code>hyperlink</code> inside the markdown content is clicked. Allows link interactions to be handled through application logic.</td>
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
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetHtmlText" aria-label="View GetHtmlText method in API reference">GetHtmlText()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Returns the current markdown content converted to <code>HTML</code>. Useful when the rendered content must be reused in another format.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetMarkdownText" aria-label="View GetMarkdownText method in API reference">GetMarkdownText()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Returns the current content in <code>markdown</code> format. Useful for reading back the original formatted text.</td>
    </tr>
    <tr valign="top">
        <td><a href="https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetText" aria-label="View GetText method in API reference">GetText()</a></td>
        <td><a href="https://learn.microsoft.com/dotnet/api/system.string" aria-label="View String type in API reference">string</a></td>
        <td>Returns the current content as plain text without markdown formatting. Useful for extracting readable text.</td>
    </tr>
</table>