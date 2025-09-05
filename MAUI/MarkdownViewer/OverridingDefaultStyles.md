---
layout: post
title: Override Default Styles in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to override the default appearance of Markdown content using custom CSS in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# How to Override Default Styles in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.SfMarkdownViewer.html) control in .NET MAUI comes with a set of built-in default styles that ensure Markdown content is rendered cleanly and consistently across platforms. However, in many real-world applications, developers may need to override these defaults to match their app’s branding, improve readability, or create a custom visual experience.

This guide explains how to override the default styles using the [MarkdownStyleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html) class and the [CssStyleRules](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_CssStyleRules) property.

### Defining Styles

**XAML**

{% highlight xaml %}

    <ContentPage.Resources>
        <ResourceDictionary>
            <x:String x:Key="CustomStyle">
            body {
                background: #F5F7FA;
                font-family: 'Segoe UI', sans-serif;
                font-size: 16px;
                color: #2E2E2E;
                line-height: 1.7;
            }

            h1 {
                font-weight: 700;
                font-size: 30px;
                line-height: 38px;
                letter-spacing: 0.5px;
                color: #1E3A8A;
                margin-bottom: 16px;
            }

            h2 {
                font-weight: 600;
                font-size: 24px;
                line-height: 32px;
                letter-spacing: 0.4px;
                color: #3B5BAA;
                margin-top: 24px;
                margin-bottom: 12px;
            }

            h3 {
                font-weight: 500;
                font-size: 20px;
                line-height: 28px;
                letter-spacing: 0.3px;
                color: #6C83C1;
                margin-top: 20px;
                margin-bottom: 10px;
            }
            </x:String>
        </ResourceDictionary>
    </ContentPage.Resources>

{% endhighlight %}

Apply the defined CSS style to the Markdown Viewer using the [CssStyleRules](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_CssStyleRules) property, as shown in the XAML code below:

{% highlight xaml %}

    <ContentPage
        . . .    
        xmlns:markdown="clr-namespace:Syncfusion.Maui.MarkdownViewer;
        assembly=Syncfusion.Maui.MarkdownViewer">
        . . .
        <markdown:SfMarkdownViewer Source={Binding MarkdownContent}>
            <markdown:SfMarkdownViewer.Settings>
                <markdown:MarkdownStyleSettings CssStyleRules="{StaticResource CustomStyle}" />
            </markdown:SfMarkdownViewer.Settings>
        </markdown:SfMarkdownViewer>

    </ContentPage>

{% endhighlight %}

The output below reflects the styled appearance of the Markdown content.

![Overriding default styles output image](Images/maui-markdown-viewer-overriding-styles.png).

By defining custom styles, you can transform the Markdown Viewer into a fully branded and polished content surface that fits seamlessly into your app’s design system.

N> Apply CSS styles only when necessary as they will override the properties of individual Markdown elements such as [H1FontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H1FontSize), [H1Color](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_H1Color), [BodyTextColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_BodyTextColor), [TableHeaderFontSize](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html#Syncfusion_Maui_MarkdownViewer_MarkdownStyleSettings_TableHeaderFontSize), etc., defined in the [MarkdownStyleSettings](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.MarkdownViewer.MarkdownStyleSettings.html) class.