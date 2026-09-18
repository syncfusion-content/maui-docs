---
layout: post
title: Auto-Sizing in .NET MAUI Markdown Viewer | Syncfusion®
description: Learn how to automatically size the Syncfusion® .NET MAUI Markdown Viewer based on its rendered Markdown content.
platform: maui
control: SfMarkdownViewer
documentation: ug
keywords: .net maui markdownviewer autosize, syncfusion markdown viewer automatic sizing, sfmarkdownviewer enableautoheight, .net maui markdown content measurement
---

# Auto-Sizing in .NET MAUI Markdown Viewer

## Overview

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) supports automatic sizing through the `EnableAutoHeight` property. When enabled, the control measures the rendered Markdown content and adjusts its size to fit the content without requiring fixed `HeightRequest` or `WidthRequest` values.

## XAML Example

The following example enables automatic sizing for Markdown content. 

{% tabs %}
{% highlight xaml %}

<markdown:SfMarkdownViewer EnableAutoHeight="True">
    <markdown:SfMarkdownViewer.Source>
        # Order status

        Your order has been shipped.

        - Order number: 1024
        - Estimated delivery: Friday
    </markdown:SfMarkdownViewer.Source>
</markdown:SfMarkdownViewer>

{% endhighlight %}
{% highlight C# %}

var markdownViewer = new SfMarkdownViewer
{
    EnableAutoHeight = true,
    Source = """
        # Order status

        Your order has been shipped.

        - Order number: 1024
        - Estimated delivery: Friday
        """
};

Content = markdownViewer;

{% endhighlight %}
{% endtabs %}
