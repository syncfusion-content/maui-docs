---
layout: post
title: Features in .NET MAUI MarkdownViewer Control | Syncfusion
description: Learn about features in the Syncfusion® .NET MAUI MarkdownViewer control, including Markdown rendering, styling, input flexibility, and scrolling support.
platform: MAUI
control: MarkdownViewer
documentation: ug
---

# Features in .NET MAUI MarkdownViewer Control

## Default Rendering

The [SfMarkdownViewer]() control effortlessly renders standard Markdown syntax including headings, bold and italic text, lists, tables, images, and code blocks. This ensures clean formatting and a consistent layout across platforms.

{% tabs %}
{% highlight markdown %}

# What is Markdown Viewer?  
Markdown View is a UI control in .NET MAUI that allows developers to render Markdown content with full formatting support.

# Header 1  
Used for the main title or top-level heading in a Markdown document. 

## Header 2  
Used to define major sections within your Markdown content.

![image](https://cdn.syncfusion.com/content/images/Xamarin/Mascot-1.png)

{% endhighlight %}
{% endtabs %}

![Default Markdown Rendering in .NET MAUI]()

## Custom Font Styling

Customize the appearance of Markdown content using CSS-like styling. You can define font family, size, weight, and color to match your app’s design.

{% tabs %}

{% highlight C# %}

public class GettingStartedMarkdownViwerExt : Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer 
{ 
    private const string GettingStartedMarkDownStyle = "body, h1, h2, h3, h4, h5, h6, p, ul, ol, li, table, th, td {" + " font-family: 'Roboto', Arial, sans-serif;" + " color: #1C1B1F;" + " line-height: 1.6;" + "}" +

"body {" + " max-width: 1500px;" + " margin: 0 auto;" + " padding: 20px 10px 20px 30px;" + " background: #fff;" + "}" +

"h1 {" + " font-weight: 700;" + " font-size: 28px;" + " color: #0385F6;" + " margin-bottom: 8px;" + "}" +

"h2 {" + " font-weight: 600;" + " font-size: 20px;" + " color: #2297FD;" + " margin-bottom: 8px;" + "}" +

"p {" + " font-size: 16px;" + " margin-bottom: 12px;" + "}" +

"table {" + " width: 100%;" + " border-collapse: separate;" + " border-spacing: 0;" + " border-radius: 12px;" + " box-shadow: 0 4px 16px rgba(50,50,50,0.10);" + "}" +

"th, td {" + " border: 1px solid #e0e0e0;" + " padding: 8px;" + " font-size: 15px;" + "}" +

"code, pre {" + " background: #f5f5f5;" + " color: #37474f;" + " font-family: 'Fira Mono', 'Consolas', monospace;" + " font-size: 14px;" + "}";

    protected override string GetCustomCssStyles() 
    { 
        return GettingStartedMarkDownStyle; 
    } 
}

{% endhighlight %}
{% endtabs %}

![Custom Font Styling]()

## Flexible Input Sources

The MarkdownViewer control accepts content from multiple sources:

- Local `.md` files
- Embedded resources
- Direct Markdown strings

This flexibility allows developers to dynamically load and render Markdown content based on application needs.

{% tabs %}
{% highlight c# %}

// Load from string
markdownViewer.Source = "# Hello from Markdown";

// Load from embedded resource
markdownViewer.Source = await FileSystem.OpenAppPackageFileAsync("readme.md");

{% endhighlight %}
{% endtabs %}

![Flexible Input Sources]()

## Automatic Link Rendering

Clickable hyperlinks are fully supported. You can customize their appearance and handle click events to open external URLs or navigate within the app.

{% tabs %}
{% highlight markdown %}

Check out [Syncfusion](https://www.syncfusion.com) for more components.

{% endhighlight %}
{% endtabs %}

![Automatic Link Rendering]()

## Smooth Scrolling Support

The MarkdownViewer control provides fluid scrolling for large Markdown documents, ensuring a responsive and user-friendly reading experience across mobile and desktop platforms.

![Smooth Scrolling Support in .NET MAUI]()
