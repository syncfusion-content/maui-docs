---
layout: post
title: Customization in .NET MAUI Rich Text Editor | Syncfusion®
description: Learn here all about customization support in the Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control, including the toolbar, and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Customization in .NET MAUI Rich Text Editor (SfRichTextEditor)

The .NET MAUI Rich Text Editor control provides extensive options for customizing the toolbar's items, appearance, and position, as well as the editor's placeholder text and read-only state.

## Customizing the Toolbar

The `SfRichTextEditor` toolbar is highly customizable, allowing you to control its items, styling, and position.

### Add or Remove Toolbar Items

By default, the toolbar includes a comprehensive set of formatting tools. You can specify a custom set of items by populating the `ToolbarItems` collection. This allows you to add or remove any built-in toolbar item.

The following items are available to be added to the `ToolbarItems` collection:
*   `Bold`, `Italic`, `Underline`, `Strikethrough`
*   `Subscript`, `Superscript`
*   `FontFamily`, `FontSize`, `FontColor`, `BackgroundColor`
*   `NumberList`, `BulletList`
*   `AlignLeft`, `AlignCenter`, `AlignRight`, `Justify`
*   `IncreaseIndent`, `DecreaseIndent`
*   `Hyperlink`, `Image`, `Table`
*   `Undo`, `Redo`
*   `ClearFormat`
*   `Separator`

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor ShowToolbar="True">
    <rte:SfRichTextEditor.ToolbarItems>
        <!-- Define a custom set of toolbar items -->
        <rte:RichTextToolbarItem Type="Bold" />
        <rte:RichTextToolbarItem Type="Italic" />
        <rte:RichTextToolbarItem Type="Underline" />
        <rte:RichTextToolbarItem Type="Separator" />
        <rte:RichTextToolbarItem Type="NumberList" />
        <rte:RichTextToolbarItem Type="BulletList" />
    </rte:SfRichTextEditor.ToolbarItems>
</rte:SfRichTextEditor>

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.ShowToolbar = true;
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.Bold });
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.Italic });
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.Underline });
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.Separator });
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.NumberList });
richTextEditor.ToolbarItems.Add(new RichTextToolbarItem() { Type = RichTextToolbarOptions.BulletList });

{% endhighlight %}
{% endtabs %}

### Customize Toolbar Appearance

You can customize the visual style of the toolbar using the `Toolbar` property. This gives you access to the `RichTextEditorToolbar` object, which has several properties for changing its appearance.

*   `BackgroundColor`: Sets the Background color or brush of the toolbar.
*   `TextColor`: Sets the color of the toolbar item icons.
*   `IsScrollButtonVisible`: Sets the scroll button visibility.

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor ShowToolbar="True">
    <rte:SfRichTextEditor.ToolbarSettings>
        <rte:RichTextEditorToolbarSettings BackgroundColor="LightSteelBlue"
                                   TextColor="DarkSlateGray" IsScrollButtonVisible="True"="True"/>
    </rte:SfRichTextEditor.ToolbarSettings>
</rte:SfRichTextEditor>

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.ShowToolbar = true;
richTextEditor.ToolbarSettings.BackgroundColor = Colors.LightSteelBlue;
richTextEditor.ToolbarSettings.TextColor = Colors.DarkSlateGray;
richTextEditor.ToolbarSettings.IsScrollButtonVisible = true;

{% endhighlight %}
{% endtabs %}

### Customize Toolbar Position

The toolbar can be positioned at the top or bottom of the editor control using the `ToolbarPosition` property.

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor ShowToolbar="True" ToolbarPosition="Bottom" />

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.ShowToolbar = true;
richTextEditor.ToolbarPosition = RichTextEditorToolbarPosition.Bottom;

{% endhighlight %}
{% endtabs %}

## Controlling Default Text Style

You can define the default appearance for any new text typed into the editor. These settings apply to text that does not have any other specific formatting applied.

*   `DefaultFontFamily`: Sets the default font family for the content.
*   `DefaultFontSize`: Sets the default font size.
*   `DefaultTextColor`: Sets the default color of the text.

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor DefaultFontFamily="Impact"
                      DefaultFontSize="20"
                      DefaultTextColor="DarkGreen" />

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.DefaultFontFamily = "Impact";
richTextEditor.DefaultFontSize = 20;
richTextEditor.DefaultTextColor = Colors.DarkGreen;

{% endhighlight %}
{% endtabs %}

## Customizing the Placeholder

The editor can display placeholder text when its content is empty. You can customize both the text and its appearance.

*   `Placeholder`: Sets the text to display.
*   `PlaceholderStyle`: Customizes the appearance of the placeholder text. You can set `TextColor`, `FontSize`, `FontAttributes`, and `FontFamily`.

{% tabs %}

{% highlight xaml %}

<rte:SfRichTextEditor Placeholder="Type your content here..."
                      PlaceholderFontFamily="Impact"
                      PlaceholderFontSize="36"
                      PlaceholderFontSize="Green">
</rte:SfRichTextEditor>

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.Placeholder = "Type your content here...";
richTextEditor.PlaceholderFontFamily = "Impact";
richTextEditor.PlaceholderFontSize = 16;
richTextEditor.PlaceholderFontSize = Colors.Green;

{% endhighlight %}
{% endtabs %}

