---
layout: post
title: Loading Markdown Content in .NET MAUI Markdown Viewer | Syncfusion®
description: Learn how to load markdown content from strings, local files, embedded resources, and URLs in the Syncfusion® .NET MAUI Markdown Viewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer load markdown, syncfusion markdownviewer source maui, sfmarkdownviewer load from url maui, .net maui markdown embedded resource, .net maui markdownviewer local file, markdown viewer binding maui
---

# Load Markdown in .NET MAUI Markdown Viewer (SfMarkdownViewer)

The [.NET MAUI Markdown Viewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control supports flexible input sources, allowing developers to load markdown content from strings, local files, embedded resources, and external URLs.

## Prerequisites

Before using the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html), ensure the following NuGet package is installed in your .NET MAUI project:

- `Syncfusion.Maui.MarkdownViewer`

For a step-by-step setup, refer to the [Getting Started](https://help.syncfusion.com/maui/markdownviewer/gettingstarted) documentation.

## Supported Source Types

| Source | Use Case | Loading Type |
|--------|----------|--------------|
| Inline string | Short, hard-coded content; quick prototyping. | Synchronous assignment. |
| Local file | On-device markdown files (e.g., sample docs shipped with the app). | Synchronous or asynchronous I/O. |
| Embedded resource | Markdown bundled with the app package. | Asynchronous I/O. |
| URL | Remote documentation, release notes, or dynamic content. | Asynchronous fetch (with manual download). |

N> The [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property accepts the markdown text itself; URLs and file paths must be read by the developer and the resulting string assigned to `Source`.

## From String

Assign a markdown-formatted string to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control to render markdown content directly within your application.

{% tabs %}
{% highlight xaml %}

<markdown:SfMarkdownViewer>
    <markdown:SfMarkdownViewer.Source>
        <x:String>
            <![CDATA[
# What is the Markdown Viewer?
The Markdown Viewer is a UI control in .NET MAUI that allows developers to render markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

# Header 1
Used for the main title or top-level heading in a markdown document.

## Header 2
Used to define major sections within your markdown content.
            ]]>
        </x:String>
    </markdown:SfMarkdownViewer.Source>
</markdown:SfMarkdownViewer>

{% endhighlight %}
{% highlight C# %}

// A const string is safe here because the value is a compile-time literal.

private const string markdownContent = @"
# What is the Markdown Viewer?
The Markdown Viewer is a UI control in .NET MAUI that allows developers to render markdown content with full formatting support. It was designed to work efficiently on both mobile and desktop platforms. The viewer supports headings, bold and italic text, lists, tables, images, code blocks and more.

# Header 1
Used for the main title or top-level heading in a markdown document.

## Header 2
Used to define major sections within your markdown content.";

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
markdownViewer.Source = markdownContent;

{% endhighlight %}
{% endtabs %}

## From Local File

To load markdown content from a local `.md` file, read its contents using standard file I/O and assign the result to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the `SfMarkdownViewer`. 

Use the following code-behind to read the file and assign its content to the Markdown Viewer:

{% tabs %}
{% highlight C# %}

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
string filePath = @"D:\MAUI\MarkdownViewer\Files\MarkdownContent.md";
string markdownContent = File.ReadAllText(filePath);
markdownViewer.Source = markdownContent;
Content = markdownViewer;

{% endhighlight %}
{% endtabs %}

## From Embedded Resource

1. To load Markdown content from an embedded resource, place the `.md` file inside the `Resources` folder of your .NET MAUI project. 
2. Use asynchronous file access to read and assign the content to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control.

Refer to the following code-behind to read the embedded resource and assign its content to the Markdown Viewer:

{% tabs %}
{% highlight C# %}

private readonly SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
Content = markdownViewer;
_ = LoadMarkdownAsync();


private async Task LoadMarkdownAsync()
{
    using Stream stream = await FileSystem.OpenAppPackageFileAsync("MarkdownContent.md");
    using StreamReader reader = new StreamReader(stream, Encoding.UTF8);
    string markdownContent = await reader.ReadToEndAsync();
    markdownViewer.Source = markdownContent;
}

{% endhighlight %}
{% endtabs %}

## From URL

Markdown content can be loaded directly from a publicly accessible URL. This is useful for displaying remote documentation, release notes, or any Markdown file hosted online.

{% tabs %}
{% highlight xaml %}

<markdown:SfMarkdownViewer Source="https://raw.githubusercontent.com/SyncfusionExamples/GettingStarted_DockLayout_MAUI/refs/heads/master/README.md">
</markdown:SfMarkdownViewer>

{% endhighlight %}
{% highlight C# %}

SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
markdownViewer.Source = "https://raw.githubusercontent.com/SyncfusionExamples/GettingStarted_DockLayout_MAUI/refs/heads/master/README.md";
Content = markdownViewer;

{% endhighlight %}
{% endtabs %}

## See Also
- [Retrieve Content](https://help.syncfusion.com/maui/markdownviewer/contentretrieval)
- [Customize Appearance](https://help.syncfusion.com/maui/markdownviewer/appearance)
- [Apply CSS Style Rules](https://help.syncfusion.com/maui/markdownviewer/overridingdefaultstyles)
