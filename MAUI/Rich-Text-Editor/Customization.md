---
layout: post
title: Customization in .NET MAUI Rich Text Editor | Syncfusion®
description: Learn here all about customization support in the Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control, including the toolbar, and more.
platform: maui 
control: Rich Text Editor
documentation: ug
---

# Customization in .NET MAUI Rich Text Editor (SfRichTextEditor)

The .NET MAUI Rich Text Editor control provides extensive options for customizing its appearance and functionality, from the toolbar and editor area to programmatic formatting and hyperlink management.

## Customizing the Toolbar

The [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) toolbar is highly customizable, allowing you to control its items, styling, and position.

### Add or Remove Toolbar Items

By default, the toolbar includes a comprehensive set of formatting tools. You can specify a custom set of items by populating the [ToolbarItems](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToolbarItems) collection. This allows you to add or remove any built-in toolbar item.

The following items are available to be added to the `ToolbarItems` collection:
*   `Bold`, `Italic`, `Underline`, `Strikethrough`
*   `Subscript`, `Superscript`
*   `FontFamily`, `FontSize`, `TextColor`, `HighlightColor`
*   `ParagraphFormat` , `Alignment`
*   `NumberList`, `BulletList`
*   `IncreaseIndent`, `DecreaseIndent`
*   `Hyperlink`, `Image`, `Table`
*   `Undo`, `Redo`
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

You can customize the visual style of the toolbar using the `ToolbarSettings` property. This gives you access to the [RichTextEditorToolbarSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html) object, which has several properties for changing its appearance.

*   [BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_BackgroundColor): Sets the Background color or brush of the toolbar.
*   [TextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_TextColor) : Sets the color of the toolbar item icons.
*   [IsScrollButtonVisible](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_IsScrollButtonVisible): Sets the scroll button visibility.
*   [SeparatorColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_SeparatorColor): Sets the color of the separator lines between toolbar items.
*   [SeparatorThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_SeparatorThickness): Sets the thickness of the separator lines.
*   [ForwardIconBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_ForwardIconBackground): Sets the background color of the forward scroll icon.
*   [ForwardIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_ForwardIconColor): Sets the color of the forward scroll icon.
*   [BackwardIconBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_BackwardIconBackground): Sets the background color of the backward scroll icon.
*   [BackwardIconColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_BackwardIconColor): Sets the color of the backward scroll icon.
*   [SelectionColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_SelectionColor): Sets the color for toolbar text hover and selection color.


{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor ShowToolbar="True">
    <rte:SfRichTextEditor.ToolbarSettings>
        <rte:RichTextEditorToolbarSettings BackgroundColor="SkyBlue" SelectionColor="Brown"
                                   TextColor="Orange" IsScrollButtonVisible="True"
                                   SeparatorColor="Brown" SeparatorThickness="5" 
                                   ForwardIconBackground="Blue" ForwardIconColor="Green"
                                   BackwardIconBackground="Yellow" BackwardIconColor="Green"/>
    </rte:SfRichTextEditor.ToolbarSettings>
</rte:SfRichTextEditor>

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.ShowToolbar = true;
richTextEditor.ToolbarSettings = new RichTextEditorToolbarSettings
{
    IsScrollButtonVisible = true,
    TextColor = Colors.Orange,
    BackgroundColor = Colors.SkyBlue,
    SelectionColor = Colors.Brown,
    SeparatorColor = Colors.Brown,
    SeparatorThickness = 5,
    ForwardIconBackground = Colors.Blue,
    ForwardIconColor = Colors.Green,
    BackwardIconBackground = Colors.Yellow,
    BackwardIconColor = Colors.Green
};

{% endhighlight %}
{% endtabs %}

![.NET MAUI Rich Text Editor with Toolbar settings](images/richtexteditor-toolbar-settings.png)


### Customize Toolbar Position

The toolbar can be positioned at the top or bottom of the editor control using the [ToolbarPosition](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToolbarPosition) property.

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

## Customizing Editor Appearance

The [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) provides several properties to customize the appearance of the main editor area, including its background, border, and text wrapping behavior.

*   [EditorBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_EditorBackgroundColor): Sets the background color of the content area.
*   [BorderColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_BorderColor): Sets the color of the border around the editor control.
*   [BorderThickness](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_BorderThickness): Sets the thickness of the border.
*   [EnableWordWrap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_EnableWordWrap): Specifies whether text should wrap when it reaches the edge of the editor. By default, this is `True`.

{% tabs %}
{% highlight xaml %}

<rte:SfRichTextEditor EditorBackgroundColor="LightYellow"
                      BorderColor="SlateGray"
                      BorderThickness="2"
                      EnableWordWrap="True" />

{% endhighlight %}
{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor();
richTextEditor.EditorBackgroundColor = Colors.LightYellow;
richTextEditor.BorderColor = Colors.SlateGray;
richTextEditor.BorderThickness = 2;
richTextEditor.EnableWordWrap = true;

{% endhighlight %}
{% endtabs %}

![.NET MAUI Customizing Rich Text Editor](images/richtexteditor-custom-editor.png)


## Programmatic Formatting

The `SfRichTextEditor` provides a comprehensive set of methods to apply formatting programmatically. These methods are useful when you want to create your own custom UI for formatting or apply styles dynamically without relying on the built-in toolbar.

The following code examples assume you have an instance of `SfRichTextEditor` named `richTextEditor`.

### Toggling Character Formatting

You can easily toggle common text styles like bold, italic, and underline on the current text selection.

*   [ToggleBold()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleBold): Toggles the bold style.
*   [ToggleItalic()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleItalic): Toggles the italic style.
*   [ToggleUnderline()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleUnderline) : Toggles the underline style.
*   [ToggleStrikethrough()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleStrikethrough): Toggles the strikethrough style.
*   [ToggleSubscript()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleSubscript): Toggles the subscript style.
*   [ToggleSuperscript()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleSuperscript): Toggles the superscript style.

{% tabs %}
{% highlight c# %}

// Toggle bold on the selected text
richTextEditor.ToggleBold();

// Toggle italic on the selected text
richTextEditor.ToggleItalic();

// Toggle underline on the selected text
richTextEditor.ToggleUnderline();

{% endhighlight %}
{% endtabs %}

### Toggling List Formatting

You can format the selected paragraphs as a bulleted or numbered list.

*   [ToggleBulletList()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleBulletList): Toggles a bulleted list for the selected paragraphs.
*   [ToggleNumberList()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ToggleNumberedList): Toggles a numbered list for the selected paragraphs.

{% tabs %}
{% highlight c# %}

// Apply or remove a bulleted list from the current paragraph
richTextEditor.ToggleBulletList();

// Apply or remove a numbered list from the current paragraph
richTextEditor.ToggleNumberList();

{% endhighlight %}
{% endtabs %}

### Applying Text Alignment

These methods allow you to set the text alignment for the selected paragraphs.

*   [AlignLeft()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_AlignLeft): Aligns the text to the left.
*   [AlignRight()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_AlignRight) : Aligns the text to the right.
*   [AlignCenter()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_AlignCenter) : Centers the text.
*   [AlignJustify()](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_AlignJustify): Justifies the text.

{% tabs %}
{% highlight c# %}

// Justify the text in the current paragraph
richTextEditor.AlignJustify();

// Align the text to the right
richTextEditor.AlignRight();

{% endhighlight %}
{% endtabs %}

### Applying Specific Styles

These methods apply a specific value for a given formatting attribute to the current selection.

*   [ApplyFontFamily(string fontName)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ApplyFontFamily_System_String_): Applies the specified font family.
*   [ApplyFontSize(double fontSize)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ApplyFontSize_System_Double_): Applies the specified font size.
*   [ApplyTextColor(Color textColor)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ApplyTextColor_Microsoft_Maui_Graphics_Color_): Applies the specified text color.
*   [ApplyHighlightColor(Color highlightColor)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ApplyHighlightColor_Microsoft_Maui_Graphics_Color_): Applies the specified highlight color.
*   [ApplyParagraphFormat(RichTextEditorParagraphFormat format)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_ApplyParagraphFormat_Syncfusion_Maui_RichTextEditor_RichTextEditorParagraphFormat_): Applies a paragraph format, such as a heading.

{% tabs %}
{% highlight c# %}

// Apply a new font family and size
richTextEditor.ApplyFontFamily("Arial");
richTextEditor.ApplyFontSize(18);

// Apply a text color and highlight color
richTextEditor.ApplyTextColor(Colors.Blue);
richTextEditor.ApplyHighlightColor(Colors.Yellow);

// Format the current paragraph as a heading 1
richTextEditor.ApplyParagraphFormat(RichTextEditorParagraphFormat.Heading1);

{% endhighlight %}
{% endtabs %}

## Managing Hyperlinks

The [SfRichTextEditor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html) allows you to programmatically insert, edit, and remove hyperlinks from the content.

### Insert a Hyperlink

Use the [InsertHyperlink(string displayText, string Url)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_InsertHyperlink_System_String_System_String_) method to add a new hyperlink at the current cursor position or over the selected text.

*   `displayText`: The text to be displayed for the hyperlink.
*   `Url`: The URL the hyperlink will point to.

{% tabs %}
{% highlight c# %}

// Insert a new hyperlink
richTextEditor.InsertHyperlink("Example", "https://example.com");

{% endhighlight %}
{% endtabs %}

### Edit a Hyperlink

Use the [EditHyperlink(string text, string oldUrl, string newUrl)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_EditHyperlink_System_String_System_String_System_String_) method to modify an existing hyperlink. You can change its target URL.

*   `text`: The existing display text for the hyperlink.
*   `oldUrl`: The original URL of the hyperlink you want to edit.
*   `newUrl`: The new URL for the hyperlink.

{% tabs %}
{% highlight c# %}

// Change the URL of an existing hyperlink
richTextEditor.InsertHyperlink("Example", "https://example.com", "https://www.google.com/");

{% endhighlight %}
{% endtabs %}

### Remove a Hyperlink

Use the [RemoveHyperlink(string text, string Url)](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_RemoveHyperlink_System_String_System_String_) method to remove a hyperlink from the document. The link's text will remain in place as plain text.

*   `text`: The display text of the hyperlink to remove.
*   `Url`: The URL of the hyperlink to remove.

{% tabs %}
{% highlight c# %}

// Remove a specific hyperlink, keeping its text
richTextEditor.RemoveHyperlink("Syncfusion", "https://www.google.com/");

{% endhighlight %}
{% endtabs %}


