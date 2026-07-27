---
layout: post
title: Retrieve Content in .NET MAUI Markdown Viewer | Syncfusion®
description: Learn how to retrieve and transform markdown content using built-in methods in the Syncfusion® .NET MAUI Markdown Viewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer get text, syncfusion markdownviewer get html maui, sfmarkdownviewer get markdown text maui, .net maui markdown to html, .net maui markdown extract text, markdown viewer api maui
---

# Retrieve Content Programmatically in .NET MAUI Markdown Viewer (SfMarkdownViewer)

The [.NET MAUI Markdown Viewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control provides built-in methods to retrieve and transform markdown content programmatically. These methods allow developers to access the raw markdown, convert it to HTML, or extract plain text without formatting.

## Prerequisites

Before using the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.MarkdownViewer`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/markdownviewer/gettingstarted) documentation.

## Supported Methods

| Method | Return Type | Description |
|--------|-------------|-------------|
| [GetMarkdownText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetMarkdownText) | `string` | Returns the raw markdown currently assigned to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property. |
| [GetHtmlText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetHtmlText) | `string` | Converts the rendered markdown to an HTML string. |
| [GetText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetText) | `string` | Extracts the plain text from the markdown, stripping formatting such as headings, emphasis, links, and code blocks. |

## GetMarkdownText

The [GetMarkdownText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetMarkdownText) method returns the raw markdown content currently assigned to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the `SfMarkdownViewer` control.

{% tabs %} 
{% highlight C# %}

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
markdownViewer.Source = "Welcome to **Markdown Viewer**!";
Content = markdownViewer;  

{% endhighlight %}
{% endtabs %}

{% tabs %} 
{% highlight C# %}

string markdown = markdownViewer.GetMarkdownText();

{% endhighlight %}
{% endtabs %}

## GetHtmlText

The [GetHtmlText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetHtmlText) method converts the markdown content of the `SfMarkdownViewer` control into HTML format and provides the result as a string.

{% tabs %} 
{% highlight C# %}

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
markdownViewer.Source = "Welcome to **Markdown Viewer**!";
Content = markdownViewer;  

{% endhighlight %}
{% endtabs %}

{% tabs %} 
{% highlight C# %}

string html = markdownViewer.GetHtmlText();

{% endhighlight %}
{% endtabs %}

## GetText

The [GetText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetText) method extracts the plain text from the markdown content, removing all formatting such as headings, emphasis, links, and code blocks. Links are flattened to their visible text, and image alt text is preserved when available.

{% tabs %} 
{% highlight C# %}

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
markdownViewer.Source = "Welcome to **Markdown Viewer**!";
Content = markdownViewer;   

{% endhighlight %}
{% endtabs %}

{% tabs %} 
{% highlight C# %}

string text = markdownViewer.GetText();

{% endhighlight %}
{% endtabs %}

## See Also

- [Loading Markdown Content](https://help.syncfusion.com/maui/markdownviewer/databinding)
- [Customize Appearance](https://help.syncfusion.com/maui/markdownviewer/appearance)
- [Apply CSS Style Rules](https://help.syncfusion.com/maui/markdownviewer/overridingdefaultstyles)