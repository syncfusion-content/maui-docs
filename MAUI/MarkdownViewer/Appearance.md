---
layout: post
title: Customize Appearance in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to style and customize the appearance of Markdown content using the MarkdownStyleSettings class in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# Customize Appearance in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control in .NET MAUI provides a powerful styling system through the [MarkdownStyleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html) class. This allows developers to customize the visual presentation of Markdown content with precision and flexibility.

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

## Customization with MarkdownStyleSettings

The appearance of headings and body content in SfMarkdownViewer can be customized using the MarkdownStyleSettings class.

- [H1FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H1FontSize), [H2FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H2FontSize), [H3FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H3FontSize) – Gets or sets the font size for H1, H2, and H3 heading elements respectively.  
- [H1Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H1Color), [H2Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H2Color), [H3Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H3Color) – Gets or sets the text color for H1, H2, and H3 heading elements respectively.  
- [BodyFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_BodyFontSize) – Gets or sets the font size for regular paragraph text. 
- [BodyTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_BodyTextColor) – Gets or sets the text color for body content.  
- [TableHeaderFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableHeaderFontSize), [TableDataFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableDataFontSize) – Gets or sets the font size for table headers and table content respectively.  
- [TableHeaderTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableHeaderTextColor), [TableDataTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableDataTextColor) – Gets or sets the text color for table headers and table content respectively.  
- [TableBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableBackground) – Gets or sets the background color for the entire table area.
- [CssStyleRules](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_CssStyleRules) – Gets or sets raw CSS styles to override or extend default Markdown rendering behavior.

{% tabs %} 
{% highlight xaml %}

    <ContentPage>
        . . .
        <markdown:SfMarkdownViewer Source={Binding MarkdownContent}>
            <markdown:SfMarkdownViewer.Settings>
                <markdown:MarkdownStyleSettings H1FontSize = "32px"
                                                H1Color = "#8352FB"
                                                H2Color = "#9971FB"
                                                H3Color = "#A98AF7"
                                                BodyFontSize = "16px"
                                                BodyTextColor = "#2C3E50"
                                                TableBackground = "#FFE2ED"
                                                TableHeaderTextColor = "HotPink">
                </markdown:MarkdownStyleSettings>
            </markdown:SfMarkdownViewer.Settings>
        </markdown:SfMarkdownViewer>
        . . .
    </ContentPage>

{% endhighlight %}

{% highlight C# %}

    public partial class MainPage : ContentPage
    {
        . . .

        public MainPage()
        {
            InitializeComponent();  

            SfMarkdownViewer markdownViewer = new SfMarkdownViewer();
            markdownViewer.Source = MarkdownContent;
            MarkdownViewer.Settings = new MarkdownStyleSettings()
            {
                H1FontSize = "32px",
                H1Color = "#8352FB",
                H2Color = "#9971FB",
                H3Color = "#A98AF7",
                BodyFontSize = "16px",
                BodyTextColor = "#2C3E50",
                TableBackground = "#FFE2ED",
                TableHeaderTextColor = "HotPink"
            };

            Content = markdownViewer;       
        }
    }  

{% endhighlight %}
{% endtabs %} 

The following output shows how these style settings enhance the appearance of rendered Markdown content:

![Sample markdown content appearance customization](images/maui-markdown-viewer-appearance.png)

With [MarkdownStyleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html), you gain full control over how Markdown content looks in your .NET MAUI app, whether you're building a documentation viewer, a note-taking app, or a styled content portal.

N> Always specify the font size with the "px" unit (e.g., "16px") to ensure consistent rendering across all platforms.