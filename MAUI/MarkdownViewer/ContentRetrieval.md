---
layout: post
title: Retrieve Content in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to retrieve and transform Markdown content using built-in methods in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# Retrieve Content Programmatically in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control provides built-in methods to retrieve and transform Markdown content programmatically. These methods allow developers to access the raw Markdown, convert it to HTML, or extract plain text without formatting.

## GetMarkdownText

Retrieves the raw Markdown content currently assigned to the [Source](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html#Syncfusion_Maui_MarkdownViewer_SfMarkdownViewer_Source) property of the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control. 

{% tabs %}
{% highlight C# hl_lines="12" %}

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

        string markdown = markdownViewer.GetMarkdownText();
    }

{% endhighlight %}
{% endtabs %}

## GetHtmlText

Converts the Markdown content of the SfMarkdownViewer control into HTML format and provides the result as a string.

{% tabs %}
{% highlight C# hl_lines="12" %}

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

        string html = markdownViewer.GetHtmlText();
    }

{% endhighlight %}
{% endtabs %}

## GetText

Extracts the plain text content from the Markdown assigned to the [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control, removing all Markdown formatting such as headings, emphasis, links, and code blocks.

{% tabs %}
{% highlight C# hl_lines="12" %}

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