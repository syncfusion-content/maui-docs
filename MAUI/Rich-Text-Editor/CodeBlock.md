---
layout: post
title: Code block support in .NET MAUI Rich Text Editor control | Syncfusion
description: Learn here all about inserting and managing code blocks with language support in Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control.
platform: maui
control: SfRichTextEditor
documentation: ug
keywords: maui rich text editor code block, code block language maui rte, syncfusion maui rte code formatting, maui rte syntax code block, rich text editor code snippet maui.
---

# Code block support in .NET MAUI Rich Text Editor

The [.NET MAUI SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) includes built-in support for inserting and managing code blocks. This feature enables developers and end users to embed formatted code snippets within rich text content while preserving structure, readability, and formatting consistency.

Code blocks are especially useful in applications that involve technical documentation, blogging platforms, or developer-centric tools.

## Insert code block

You can insert a code block using the `CodeBlock` toolbar item available in the rich text editor toolbar.

### Example

{% tabs %}

{% highlight xaml %}
xmlns:richTextEditor="clr-namespace:Syncfusion.Maui.RichTextEditor;assembly=Syncfusion.Maui.RichTextEditor"

 <richTextEditor:SfRichTextEditor ShowToolbar="True">
        <richTextEditor:SfRichTextEditor.ToolbarItems>
            <richTextEditor:RichTextToolbarItem Type="CodeBlock" />
        </richTextEditor:SfRichTextEditor.ToolbarItems>
</richTextEditor:SfRichTextEditor>

{% endhighlight %}

{% highlight c# %}
using Syncfusion.Maui.RichTextEditor;

// Create the Rich Text Editor
SfRichTextEditor richTextEditor = new SfRichTextEditor
{
    ShowToolbar = true
};

// Add CodeBlock toolbar item
// For default toolbar behavior, see: https://help.syncfusion.com/maui/rich-text-editor/toolbar#customizing-the-toolbar
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem
{
    Type = RichTextToolbarOptions.CodeBlock
});

{% endhighlight %}

{% endtabs %}

![.NET MAUI Rich Text Editor Code Block](images/richtexteditor-code-block.png)