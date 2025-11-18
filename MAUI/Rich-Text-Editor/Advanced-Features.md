---
layout: post
title: Basic Features in .NET MAUI Rich Text Editor | Syncfusion®
description: Learn about the basic features of the .NET MAUI Rich Text Editor (SfRichTextEditor) such as handling content, events, and other core functionalities.
platform: maui
control: Rich Text Editor
documentation: ug
---

# Advanced Features in .NET MAUI Rich Text Editor (SfRichTextEditor)

This section covers the essential properties, methods, and events of the .NET MAUI [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) for handling content and user interactions.

## Setting Plain Text

The Rich Text Editor control displays the plain text that can be set using the [Text](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_Text) property.

{% tabs %} 

{% highlight xaml %} 

 <richtexteditor:SfRichTextEditor Text="The rich text editor component is WYSIWYG editor that provides the best user experience to create and update the content" />

{% endhighlight %}

{% highlight C# %} 

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richtexteditor.Text = "The rich text editor component is WYSIWYG editor that provides the best user experience to create and update the content";

{% endhighlight %}

{% endtabs %}

![.NET MAUI Rich Text Editor with Text](images/richtexteditor-text-property.png)

## Setting HTML Formatted Text

The [HtmlText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_HtmlText) property of the `SfRichTextEditor` control is used to set HTML formatted text.

{% tabs %} 

{% highlight xaml %} 

 <richtexteditor:SfRichTextEditor HtmlText= "The &lt;b&gt; rich text editor &lt;/b&gt; component is WYSIWYG editor that provides the best user experience to create and update the content" />

{% endhighlight %}

{% highlight C# %} 

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richtexteditor.HtmlText = "The <b>rich text editor</b> component is WYSIWYG editor that provides the best user experience to create and update the content";

{% endhighlight %}

{% endtabs %}
![.NET MAUI Rich Text Editor with HtmlText](images/richtexteditor-htmltext-property.png)


## Getting Selected HTML

To retrieve the HTML representation of the currently selected content, use the [GetSelectedText](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_GetSelectedText) method.

{% tabs %}

{% highlight c# %}

string selectedText = await rte.GetSelectedText();

{% endhighlight %}

{% endtabs %}

## Default Text Style

You can define the default appearance for any new text typed into the editor. These settings apply to text that does not have any other specific formatting applied.

*   [DefaultFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_DefaultFontFamily): Sets the default font family for the content.
*   [DefaultFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_DefaultFontSize): Sets the default font size.
*   [DefaultTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_DefaultTextColor): Sets the default color of the text.

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor DefaultFontFamily="Impact"
                      DefaultFontSize="14"
                      DefaultTextColor="DarkGreen" />

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.DefaultFontFamily = "Impact";
richTextEditor.DefaultFontSize = 14;
richTextEditor.DefaultTextColor = Colors.DarkGreen;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Rich Text Editor with Default text style](images/richtexteditor-text.png)


## Placeholder

The editor can display a [placeholder](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_Placeholder) text when the content is empty. This is useful for prompting the user. The placeholder is cleared as soon as the user starts typing.

*   [PlaceholderFontFamily](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_PlaceholderFontFamily) : Sets the font family of the placeholder text.
*   [PlaceholderFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_PlaceholderFontSize): Sets the font size of the placeholder text.
*   [PlaceholderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_PlaceholderColor): Sets the color of the placeholder text.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor Placeholder="Type your content here..."
                      PlaceholderFontFamily="Impact"
                      PlaceholderFontSize="24"
                      PlaceholderColor="Green">
</rte:SfRichTextEditor>

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.Placeholder = "Type your content here...";
richTextEditor.PlaceholderFontFamily = "Impact";
richTextEditor.PlaceholderFontSize = 24;
richTextEditor.PlaceholderColor = Colors.Green;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Rich Text Editor with Placeholder](images/richtexteditor-placeholder.png)


## Programmatic Control

The [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) provides several methods to programmatically control its behavior, such as managing focus, history, and cursor position.

### Move Cursor to Start

Moves the cursor to the very beginning of the content in the editor.

{% tabs %}

{% highlight c# %}

richTextEditor.MoveCursorToStart();

{% endhighlight %}

{% endtabs %}

### Move Cursor to End

Moves the cursor to the very end of the content in the editor.

{% tabs %}

{% highlight c# %}

richTextEditor.MoveCursorToEnd();

{% endhighlight %}

{% endtabs %}

### Increase Indent

Increases the indentation of the current paragraph or selected paragraphs.

{% tabs %}

{% highlight c# %}

richTextEditor.IncreaseIndent();

{% endhighlight %}

{% endtabs %}

### Decrease Indent

Decreases the indentation of the current paragraph or selected paragraphs.

{% tabs %}

{% highlight c# %}

richTextEditor.DecreaseIndent();

{% endhighlight %}

{% endtabs %}

### Set Focus

Programmatically sets the input focus to the rich text editor.

{% tabs %}

{% highlight c# %}

richTextEditor.Focus();

{% endhighlight %}

{% endtabs %}

### Remove Focus

Programmatically removes the input focus from the rich text editor.

{% tabs %}

{% highlight c# %}

richTextEditor.Unfocus();

{% endhighlight %}

{% endtabs %}

### Undo Last Action

Reverts the last action performed in the editor.

{% tabs %}

{% highlight c# %}

richTextEditor.Undo();

{% endhighlight %}

{% endtabs %}

### Redo Last Action

Re-applies the last action that was undone.

{% tabs %}

{% highlight c# %}

richTextEditor.Redo();

{% endhighlight %}

{% endtabs %}

## Events
The [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) provides a variety of events to notify the changes and user interactions within the control. You can subscribe to these events to execute custom logic in response to actions like text changes, focus shifts, or hyperlink clicks.

### FormatChanged Event

The [FormatChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_FormatChanged) event is occurs when the formatting status changes. This is useful for implementing contextual formatting options.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor FormatChanged="OnFormatChanged" />

{% endhighlight %}

{% highlight c# %}

private void OnFormatChanged(object sender, RichTextEditorFormatChangedEventArgs e)
{
    // Handle when format changed
}

{% endhighlight %}

{% endtabs %}

### HyperlinkClicked Event

The [HyperlinkClicked](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_HyperlinkClicked) event is fired when a user taps on a hyperlink within the content. The event arguments contain the URL and the text of the clicked link.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor HyperlinkClicked="OnHyperlinkClicked"/>

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.HtmlText = "<p>Visit the <a href='https://www.syncfusion.com'>Syncfusion</a> website.</p>";
richTextEditorHyperlinkClicked += OnHyperlinkClicked


private void OnHyperlinkClicked(object sender, RichTextEditorHyperlinkClickedEventArgs e)
{
    string url =  e.URL;
    string text = e.DisplayText;
    // Handle when hyperlink clicked
}

{% endhighlight %}

{% endtabs %}

### TextChanged Event

The [TextChanged](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_TextChanged) event is fired whenever the content in the editor is changed. The event arguments provide the old and new HTML content.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor TextChanged="OnTextChanged" />

{% endhighlight %}

{% highlight c# %}

private void OnTextChanged(object sender, RichTextEditorTextChangedEventArgs e)
{
    string oldHtml = e.OldText;
    string newHtml = e.NewText;
    // Handle when Text changed
}

{% endhighlight %}

{% endtabs %}


### Focused Event

The [Focused](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_Focused) event occurs when the Rich Text Editor receives input focus.

{% tabs %}

{% highlight xaml %}
<rte:SfRichTextEditor Focused="OnEditorFocused" />
{% endhighlight %}

{% highlight c# %}
richTextEditor.Focused += OnEditorFocused;

private void OnEditorFocused(object sender, EventArgs e)
{
    // Handle when editor focused
}
{% endhighlight %}
{% endtabs %}

### Unfocused Event

The [Unfocused](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_Unfocused) event occurs when the Rich Text Editor loses input focus.

{% tabs %}

{% highlight xaml %}
<rte:SfRichTextEditor Unfocused="OnEditorUnfocused" />
{% endhighlight %}

{% highlight c# %}
richTextEditor.Unfocused += OnEditorUnfocused;

private void OnEditorUnfocused(object sender, EventArgs e)
{
    // Handle when editor loses focus
}
{% endhighlight %}
{% endtabs %}
