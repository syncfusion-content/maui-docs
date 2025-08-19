---
layout: post
title: Retrieve Content Programmatically in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to retrieve and transform Markdown content using built-in methods in the Syncfusion .NET MAUI MarkdownViewer control, including raw Markdown, HTML, and plain text extraction.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# Retrieve Content Programmatically in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer]() control provides built-in methods to retrieve and transform Markdown content programmatically. These methods allow developers to access the raw Markdown, convert it to HTML, or extract plain text without formatting.

## GetMarkdownText()

Retrieves the raw Markdown content currently assigned to the `Source` property of the [SfMarkdownViewer]() control. 

{% tabs %}
{% highlight C# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();  
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        markdownViewer.Source = "Welcome to **Markdown Viewer**!";
        Content = markdownViewer;       
    }
    . . .

    string markdown = MarkdownViewer.GetMarkdown();
}

{% endhighlight %}
{% endtabs %}

## GetHtml()

Converts the Markdown content of the SfMarkdownViewer control into HTML format and provides the result as a string.

{% tabs %}
{% highlight C# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();  
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        markdownViewer.Source = "Welcome to **Markdown Viewer**!";
        Content = markdownViewer;       
    }
    . . .

    string html = MarkdownViewer.GetHtml();
}

{% endhighlight %}
{% endtabs %}

## GetText()

Extracts the plain text content from the Markdown assigned to the `SfMarkdownViewer` control, removing all Markdown formatting such as headings, emphasis, links, and code blocks.

{% tabs %}
{% highlight C# %}

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();  
        SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
        markdownViewer.Source = "Welcome to **Markdown Viewer**!";
        Content = markdownViewer;       
    }
    . . .

    string text = markdownViewer.GetText();
}

{% endhighlight %}
{% endtabs %}