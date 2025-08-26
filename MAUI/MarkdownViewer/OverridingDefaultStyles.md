---
layout: post
title: Override Default Styles in .NET MAUI MarkdownViewer | Syncfusion
description: Learn how to override the default appearance of Markdown content using custom CSS in the Syncfusion .NET MAUI MarkdownViewer control.
platform: MAUI
control: SfMarkdownViewer
documentation: ug
---

# How to Override Default Styles in .NET MAUI SfMarkdownViewer

The [SfMarkdownViewer]() control in .NET MAUI comes with a set of built-in default styles that ensure Markdown content is rendered cleanly and consistently across platforms. However, in many real-world applications, developers may need to override these defaults to match their app’s branding, improve readability, or create a custom visual experience.

This guide explains how to override the default styles using the [MarkdownStyleSettings]() class and the [CssStyleRules]() property.

### Define Styles in XAML

{% highlight xaml %}

    <ContentPage.Resources>

        <ResourceDictionary>
            <x:String x:Key="CustomStyle">
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
            </x:String>
        </ResourceDictionary>

    </ContentPage.Resources>

{% endhighlight %}

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

By defining custom styles, you can transform the Markdown viewer into a fully branded and polished content surface that fits seamlessly into your app’s design system.

N> Apply CSS styles only when necessary as they will override the properties of individual Markdown elements such as `H1FontSize`, `H1Color`, `BodyTextColor`, `TableHeaderFontSize`, etc., defined in the [MarkdownStyleSettings]() class.