---
layout: post
title: Retrieve Content in .NET MAUI SfMarkdownViewer | Syncfusion
description: Learn how to retrieve and transform markdown content using built-in methods in the Syncfusion .NET MAUI SfMarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer get text, syncfusion markdownviewer get html maui, sfmarkdownviewer get markdown text maui, .net maui markdown to html, .net maui markdown extract text, markdown viewer api maui
---

# Retrieve Content Programmatically in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control provides built-in methods to retrieve and transform markdown content programmatically. These methods allow developers to access the raw markdown, convert it to HTML, or extract plain text without formatting.

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

N> All three methods are synchronous and must be invoked on the UI thread after the control has been loaded and a [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) value has been set.

The following example shows the shared setup used by the samples in this document:

{% tabs %} 
{% highlight C# %}

using Syncfusion.Maui.MarkdownViewer;

namespace MarkdownViewerContentRetrieval
{
    public partial class MainPage : ContentPage
    {
        private readonly SfMarkdownViewer markdownViewer;

        public MainPage()
        {
            InitializeComponent();

            markdownViewer = new SfMarkdownViewer
            {
                Source = "# Welcome\n\nThis is **Markdown Viewer** running on .NET MAUI."
            };

            Content = markdownViewer;
        }
    }
}

{% endhighlight %}
{% endtabs %} 

## GetMarkdownText

The [GetMarkdownText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetMarkdownText) method returns the raw markdown content currently assigned to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the `SfMarkdownViewer` control.

{% tabs %} 
{% highlight C# %}

string markdown = markdownViewer.GetMarkdownText();
// Sample return value: "# Welcome\n\nThis is **Markdown Viewer** running on .NET MAUI."

{% endhighlight %}
{% endtabs %}

N> If `Source` has not been set, the method returns an empty string.

## GetHtmlText

The [GetHtmlText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetHtmlText) method converts the rendered markdown into an HTML string. The output is a self-contained HTML5 fragment containing the rendered elements (headings, paragraphs, lists, tables, and code blocks). It does not include `<html>`, `<head>`, or `<body>` tags, and does not embed any CSS or scripts.

{% tabs %} 
{% highlight C# %}

string html = markdownViewer.GetHtmlText();
// Sample return value:
// "<h1>Welcome</h1><p>This is <strong>Markdown Viewer</strong> running on .NET MAUI.</p>"

{% endhighlight %}
{% endtabs %}

N> `GetHtmlText` is useful for exporting the rendered content to web views, email bodies, or any consumer that accepts HTML markup.

## GetText

The [GetText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_GetText) method extracts the plain text from the markdown content, removing all formatting such as headings, emphasis, links, and code blocks. Links are flattened to their visible text, and image alt text is preserved when available.

{% tabs %} 
{% highlight C# %}

string text = markdownViewer.GetText();
// Sample return value: "Welcome\n\nThis is Markdown Viewer running on .NET MAUI."

{% endhighlight %}
{% endtabs %}

## Troubleshooting

| Issue | Possible Cause | Recommended Action |
|-------|----------------|--------------------|
| The method returns an empty string. | The [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property was never set, or the control has not been loaded yet. | Assign a value to `Source` and ensure the view is rendered before calling the method. |
| The call throws an exception. | The method was invoked off the UI thread. | Dispatch the call back to the UI thread using `MainThread.BeginInvokeOnMainThread`. |
| `GetHtmlText` output is missing styles. | CSS rules defined via `CssStyleRules` are not part of the returned HTML; they are applied internally by the viewer. | Wrap the returned HTML in a host page that supplies the required styles if you export it elsewhere. |

## See Also

- [Getting Started with .NET MAUI SfMarkdownViewer](https://help.syncfusion.com/maui/markdownviewer/getting-started)
- [Loading Markdown Content](https://help.syncfusion.com/maui/markdownviewer/databinding)
- [Customize Appearance](https://help.syncfusion.com/maui/markdownviewer/appearance)
- [Apply CSS Style Rules](https://help.syncfusion.com/maui/markdownviewer/overridingdefaultstyles)