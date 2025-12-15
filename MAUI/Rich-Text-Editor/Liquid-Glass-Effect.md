---
layout: post
title: Liquid Glass Effect on .NET MAUI RichTextEditor control | Syncfusion®
description: Learn here all about how to enable cupertino theme for Syncfusion® .NET MAUI Rich Text Editor (SfRichTextEditor) control, its elements and more.
platform: maui 
control: SfRichTextEditor
documentation: ug
---

# Liquid Glass Effect in .NET MAUI RichTextEditor

The Liquid Glass Effect is a modern design style that provides a sleek, minimalist appearance with clean lines, subtle visual effects, and elegant styling. It features smooth rounded corners, refined color palettes, and sophisticated visual treatments that create a polished, professional look for your RichTextEditor.

N> The liquid glass effect is only available on macOS and iOS platforms with iOS version 26 or higher.

## How it Enhances RichTextEditor UI on macOS and iOS

The Liquid Glass Effect enhances the RichTextEditor with liquid glass effects on toolbar and editor elements, creating a modern and visually appealing text editing interface that delivers a sophisticated user experience.

## Apply Liquid Glass Effect to SfRichTextEditor

To enable the Cupertino theme's liquid glass effect, set the [EnableLiquidGlassEffect]() property to `True` on the SfRichTextEditor. For optimal visual appearance with a sleek and glassy output, set transparent backgrounds for both the editor and toolbar using the [EditorBackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.SfRichTextEditor.html#Syncfusion_Maui_RichTextEditor_SfRichTextEditor_EditorBackgroundColor) property of SfRichTextEditor and the [BackgroundColor](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_Maui_RichTextEditor_RichTextEditorToolbarSettings_BackgroundColor) property of ToolbarSettings.

{% tabs %}

{% highlight xaml %}

<editor:SfRichTextEditor EnableLiquidGlassEffect="True"
                         EditorBackgroundColor="Transparent">
    <editor:SfRichTextEditor.ToolbarSettings>
        <editor:RichTextEditorToolbarSettings BackgroundColor="Transparent" />
    </editor:SfRichTextEditor.ToolbarSettings>
</editor:SfRichTextEditor>

{% endhighlight %}

{% highlight c# %}

SfRichTextEditor richTextEditor = new SfRichTextEditor()
{
    EnableLiquidGlassEffect = true,
    EditorBackgroundColor = Colors.Transparent
};

richTextEditor.ToolbarSettings = new RichTextEditorToolbarSettings()
{
    BackgroundColor = Colors.Transparent
};

{% endhighlight %}

{% endtabs %}

### Toolbar

The liquid glass effect is applied to the overall toolbar and its elements, including font family picker, font size picker, text alignment options, text style pickers, insert link popup, table selection, table context menu popup, and the inline toolbar for links.

#### Customize Toolbar Corner Radius

The toolbar corner radius and toolbar selection corner radius can be customized using Syncfusion theme keys:

{% tabs %}

{% highlight xaml %}

<Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <syncTheme:SyncfusionThemeResourceDictionary VisualTheme="CupertinoLight"/>
                <ResourceDictionary>
                    <sys:Double x:Key="SfRichTextEditorToolbarCornerRadius">25</sys:Double>
                    <sys:Double x:Key="SfRichTextEditorToolbarSelectionCornerRadius">25</sys:Double>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>

{% endhighlight %}

{% endtabs %}

### Editor

The liquid glass effect enhances the text editing area, providing a modern and sophisticated appearance for content creation.

#### Customize Editor Corner Radius

The editor corner radius can be customized using the Syncfusion theme key:

{% tabs %}

{% highlight xaml %}

<Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncTheme="clr-namespace:Syncfusion.Maui.Themes;assembly=Syncfusion.Maui.Core">
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <syncTheme:SyncfusionThemeResourceDictionary VisualTheme="CupertinoLight"/>
                <ResourceDictionary>
                    <sys:Double x:Key="SfRichTextEditorCornerRadius">15</sys:Double>
                </ResourceDictionary>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>

{% endhighlight %}

{% endtabs %}

### Best Practices and Tips

- To override the default appearance of the toolbar and the editor’s corner radius, you need to initialize the Syncfusion theme dictionary resources in the application’s resource dictionary. For more details, refer to the [documentation](https://help.syncfusion.com/maui/themes/themes).
- `SfRichTextEditorToolbarCornerRadius` theme key used to customize the corner radius of the toolbar.
- `SfRichTextEditorToolbarSelectionCornerRadius` theme key used to customize the corner radius of selected toolbar item.
- `SfRichTextEditorCornerRadius` theme key used the customize the corner radius of SfRichTextEditor.

N> `SfRichTextEditorCornerRadius` theme key works with the liquid glass effect on iOS and macOS only.


