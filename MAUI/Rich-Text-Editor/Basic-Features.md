---
layout: post
title: Basic Features in .NET MAUI Rich Text Editor | Syncfusion®
description: Learn about the basic features of the .NET MAUI Rich Text Editor (SfRichTextEditor) such as handling content, events, and other core functionalities.
platform: maui
control: Rich Text Editor
documentation: ug
---

# Basic Features in .NET MAUI Rich Text Editor (SfRichTextEditor)

This section covers the essential properties, methods, and events of the .NET MAUI `SfRichTextEditor` for handling content and user interactions.

## Handling Content

### Setting and Getting HTML Content

The rich content of the editor, including all formatting, is accessible through the `Text` property. You can use this property to both load and retrieve the content as an HTML string.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor Text="The Syncfusion .NET MAUI Rich Text Editor is a WYSIWYG editor for creating and editing rich text content." />

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.Text = "The Syncfusion .NET MAUI Rich Text Editor is a WYSIWYG editor for creating and editing rich text content.";
this.Content = richTextEditor;

{% endhighlight %}

{% endtabs %}

### Getting HTML Content Asynchronously

To ensure you get the most up-to-date content, especially after recent edits, you can retrieve the HTML string asynchronously using the `GetHtmlString` method.

{% tabs %}

{% highlight c# %}

string htmlContent = await rte.GetHtmlText();

{% endhighlight %}

{% endtabs %}


### Getting Selected HTML

To retrieve the HTML representation of the currently selected content, use the `GetSelectedText` method.

{% tabs %}

{% highlight c# %}

string selectedText = await rte.GetSelectedText();

{% endhighlight %}

{% endtabs %}

## Placeholder

The editor can display a placeholder text when the content is empty. This is useful for prompting the user. The placeholder is cleared as soon as the user starts typing.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor Placeholder="Type Here..." />

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.Placeholder = "Type Here...";

{% endhighlight %}

{% endtabs %}

![.NET MAUI Rich Text Editor with Placeholder](images/richtexteditor-placeholder.png)


## Events

### TextChanged Event

The `TextChanged` event is fired whenever the content in the editor is changed. The event arguments provide the old and new HTML content.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor TextChanged="OnTextChanged" />

{% endhighlight %}

{% highlight c# %}

private void OnTextChanged(object sender, RichTextEditorTextChangedEventArgs e)
{
    string oldHtml = e.OldValue;
    string newHtml = e.NewValue;
    // Logic to execute when the Text changes.
}

{% endhighlight %}

{% endtabs %}

### FormatChanged Event

The `FormatChanged` event is Occurs when the formatting status changes. This is useful for implementing contextual formatting options.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor FormatChanged="OnFormatChanged" />

{% endhighlight %}

{% highlight c# %}

private void OnFormatChanged(object sender, RichTextEditorFormatChangedEventArgs e)
{
    // Logic to execute when the Format changes.
}

{% endhighlight %}

{% endtabs %}

### HyperlinkClicked Event

The `HyperlinkClicked` event is fired when a user taps on a hyperlink within the content. The event arguments contain the URL and the text of the Clicked link.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor HyperlinkClicked="OnHyperlinkClicked"/>

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.Text = "<p>Visit the <a href='https://www.syncfusion.com'>Syncfusion</a> website.</p>";
richTextEditorHyperlinkClicked += OnHyperlinkClicked


private void OnHyperlinkClicked(object sender, RichTextEditorHyperlinkClickedEventArgs e)
{
    string url =  e.URL;
    string text = e.DisplayText;
    // You can handle the navigation here, for example:
}

{% endhighlight %}

{% endtabs %}

## Focus Management

You can programmatically set or remove focus from the editor control using the `Focus()` and `Unfocus()` methods.

{% tabs %}

{% highlight C# %}

// To set focus on the Rich Text Editor
richTextEditor.Focus();

// To remove focus from the Rich Text Editor
richTextEditor.Unfocus();

{% endhighlight %}
{% endtabs %}
