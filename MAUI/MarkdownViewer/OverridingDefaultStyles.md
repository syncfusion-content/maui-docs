---
layout: post
title: How to Override Default Styles in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to override the default appearance of Markdown content using custom CSS in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# How to Override Default Styles in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer]() control in .NET MAUI comes with a set of built-in default styles that ensure Markdown content is rendered cleanly and consistently across platforms. However, in many real-world applications, developers may need to override these defaults to match their app’s branding, improve readability, or create a custom visual experience.

This guide explains how to override the default styles using the [MarkdownStyleSettings]() class and the [CssStyleRules]() property.

### Override Styles in C# Code

Override styles programmatically by extending the `SfMarkdownViewer` and overriding the `GetCustomCssStyles()` method.

{% highlight xaml %}

<ContentPage
    . . .
    <controls:CustomMarkdownViewer x:Name="MarkdownView" />
    . . .
</ContentPage>

{% endhighlight %}

{% highlight C# %}

public class CustomMarkdownViewer : SfMarkdownViewer
{
    private const string CustomStyle = @"
body {
    background: #F0F0F0;
    font-family: 'Segoe UI', sans-serif;
    padding: 20px;
}
h1 {
    font-size: 28px;
    color: #005EEB;
}
p {
    font-size: 15px;
    color: #444;
}
img {
    max-width: 100%;
    display: block;
    margin: 16px auto;
}";

    protected override string GetCustomCssStyles()
    {
        return CustomStyle;
    }
}

{% endhighlight %}

By overriding default styles, you can transform the Markdown viewer into a fully branded and polished content surface that fits seamlessly into your app’s design system.
