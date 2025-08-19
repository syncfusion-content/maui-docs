---
layout: post
title: Customize Appearance in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to style and customize the appearance of Markdown content using the MarkdownStyleSettings class in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# Customize Appearance in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer]() control in .NET MAUI provides a powerful styling system through the `MarkdownStyleSettings` class. This allows developers to customize the visual presentation of Markdown content with precision and flexibility.

## Key Features

- **Granular Styling**: Customize font sizes and colors for headings, body text, and tables.
- **Custom CSS Support**: Apply advanced styling using raw CSS rules.
- **Two-Layer Styling System**: Merge base styles with custom CSS for full control.
- **Reset Functionality**: Revert all styles to default with a single method call.

## Use Cases

- Match Markdown content appearance with your app’s theme.
- Improve readability with tailored font sizes and spacing.
- Highlight specific Markdown elements like tables or code blocks.
- Apply branding styles using custom CSS.

## Styling with MarkdownStyleSettings

### Define Styles in XAML

{% highlight xaml %}

<ContentPage
    . . .    
    xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;
    assembly=Syncfusion.Maui.MarkdownViewer">
   
    <markdown:SfMarkdownViewer>
        <markdown:SfMarkdownViewer.Settings>
            <markdown:MarkdownStyleSettings CssStyleRules="{StaticResource DefaultLightStyle}"/>
        </markdown:SfMarkdownViewer.Settings>
    </markdown:SfMarkdownViewer>

</ContentPage>

{% endhighlight %}
{% highlight xaml %}

<ResourceDictionary>

    <x:String x:Key="DefaultLightStyle">
body {
    background: #FFFBFE;
    font-family: 'Roboto', sans-serif;
}
        
h1 {
    font-family: 'Roboto', sans-serif;
    font-weight: 700;
    font-size: 28px;
    line-height: 36px;
    letter-spacing: 0px;
    color: #1C1B1F;
}

h2 {
    font-family: 'Roboto', sans-serif;
    font-weight: 700;
    font-size: 24px;
    line-height: 32px;
    letter-spacing: 0px;
    color: #1C1B1F;
}

h3 {
    font-family: 'Roboto', sans-serif;
    font-weight: 600;
    font-size: 22px;
    line-height: 28px;
    letter-spacing: 0px;
    color: #1C1B1F;
}

h4 {
    font-family: 'Roboto', sans-serif;
    font-weight: 600;
    font-size: 20px;
    line-height: 26px;
    letter-spacing: 0px;
    color: #1C1B1F;
}

h5 {
    font-family: 'Roboto', sans-serif;
    font-weight: 500;
    font-size: 18px;
    line-height: 22px;
    letter-spacing: 0px;
    color: #1C1B1F;
    margin: 18px 0 12px 0;
}

h6 {
    font-family: 'Roboto', sans-serif;
    font-weight: 500;
    font-size: 16px;
    line-height: 24px;
    letter-spacing: 0px;
    color: #1C1B1F;
    margin: 16px 0 10px 0;
}

a, a:hover, a:active {
    font-family: 'Roboto', sans-serif;
    font-weight: 400;
    font-size: 16px;
    line-height: 24px;
    letter-spacing: 0.25px;
    color: #005EEB;
    text-decoration: none;
}
        
a:hover, a:active {
    font-family: 'Roboto', sans-serif;
    font-weight: 400;
    font-size: 16px;
    line-height: 24px;
    letter-spacing: 0.25px;
    color: #543E66;
    text-decoration: none;
    text-decoration-line: none;
    border-bottom: none;
}

table {
    width: 70%;
    border-collapse: collapse;
    border-width: 1px 1px 1px 1px;
    border-style: solid;
    border-color: #CAC4D0;
    font-weight: 500;
}

td {
    border-width: 1px 1px 1px 1px;
    border-style: solid;
    border-color: #CAC4D0;
    letter-spacing: 0.25px;
    color:#1C1B1F;
    font-weight: 500;
}
        
td {
    border-width: 1px 1px 1px 1px;
    border-style: solid;
    border-color: #CAC4D0;
    letter-spacing: 0.25px;
    color:#1C1B1F;
    font-weight: 400;
}

img {
   width: 50%;
   height: 40%;
   float: left;
   margin-bottom: 30px;
}

p {
    font-family: 'Roboto', sans-serif;
    font-weight: 400;
    font-size: 16px;
    line-height: 24px;
    letter-spacing: 0px;
    color: #1C1B1F;
    clear: both;
}
        
code {
  background-color: #F5F5F5;
  color: #333333;
  padding: 2px 6px;
  border-radius: 4px;
}
    </x:String>
</ResourceDictionary>

{% endhighlight %}

### Apply Styles in C#

{% highlight C# %}

public class GettingStartedMarkdownViwerExt : Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer
{
    private const string GettingStartedMarkDownStyle = 
@"body, h1, h2, p {
    font-family: 'Roboto', Arial, sans-serif;
    color: #1C1B1F;
    line-height: 1.6;
}

body {
    max-width: 1500px;
    margin: 0 auto;
    padding: 20px 10px 20px 30px;
    background: #fff;
}

h1 {
    font-weight: 700;
    font-size: 28px;
    color: #0385F6;
    line-height: 35px;
    margin-top: 0;
    margin-bottom: 8px;
}

h2 {
    font-weight: 600;
    font-size: 20px;
    color: #2297FD;
    line-height: 35px;
    margin-top: 15px;
    margin-bottom: 8px;
}

p {
    font-size: 16px;
    margin: 0 0 12px 0;
}

img {
    max-width: 100%;
    height: auto;
    display: block;
    margin: 16px auto;
}"

    protected override string GetCustomCssStyles()
    {
        return GettingStartedMarkDownStyle;
    }
}

{% endhighlight %}

## Default Styles Overview

The control includes default styles for:

- Headings (`h1` to `h6`)
- Body text and links
- Lists (`ul`, `ol`)
- Tables (`th`, `td`)
- Code blocks (`code`, `pre`)
- Blockquotes and images

These defaults ensure a clean, readable layout and can be extended or overridden as needed.

With [MarkdownStyleSettings](), you gain full control over how Markdown content looks in your .NET MAUI app—whether you're building a documentation viewer, a note-taking app, or a styled content portal.
