---
layout: post
title: Toolbar in .NET MAUI Rich Text Editor | Syncfusion®
description: Learn here all about Toolbar features in Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Toolbar in .NET MAUI Rich Text Editor (SfRichTextEditor)

## Toolbar position

The Rich Text Editor allows you to position the toolbar at the top or bottom of the content area, depending on your layout requirements. By default, the toolbar appears at the top on Windows and macOS, and at the bottom on Android and iOS for better accessibility.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor ToolbarPosition="Bottom" />

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.ToolbarPosition = RichTextEditorToolbarPosition.Bottom;

{% endhighlight %}
{% endtabs %}

## Link quick tooltip 

The link quick tooltip appears when you click on a link in the editor. The Rich Text Editor provides essential tools in the link quick tooltip, including “Open”, “Edit Link” and “Remove Link”.

![.NET MAUI Rich Text Editor Link Quick Tooltip](images/richtexteditor-link-quick-tooltip.png)

N> The link quick tooltip will automatically disappear after 2 seconds if there is no user interaction.

