---
layout: post
title: Liquid Glass Support for .NET MAUI Toolbar | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Toolbar using the EnableLiquidGlassEffect property.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---

# Liquid Glass Support

The [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) supports a liquid glass effect by setting the [EnableLiquidGlassEffect]() property to true. This enhances visual depth and readability when toolbars are placed over images or colorful layouts.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Apply Liquid Glass Effect to SfToolbar

Turn on the liquid glass effect on the toolbar by setting [EnableLiquidGlassEffect]() to true.

{% tabs %}
{% highlight xaml %}

<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:toolbar="clr-namespace:Syncfusion.Maui.Toolbar;assembly=Syncfusion.Maui.Toolbar"
    x:Class="AcrylicToolbarPage">

    <Grid>
        <!-- Background to make acrylic blur visible -->
        <Image Source="wallpaper.jpg" Aspect="AspectFill" />

        <toolbar:SfToolbar
            EnableLiquidGlassEffect="True"
            HeightRequest="56"
            WidthRequest="320">
            <toolbar:SfToolbar.Items>
                <toolbar:SfToolbarItem Name="Bold" ToolTipText="Bold">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE770;" FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="Italic" ToolTipText="Italic">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE771;" FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
                <toolbar:SfToolbarItem Name="Underline" ToolTipText="Underline">
                    <toolbar:SfToolbarItem.Icon>
                        <FontImageSource Glyph="&#xE762;" FontFamily="MauiMaterialAssets" />
                    </toolbar:SfToolbarItem.Icon>
                </toolbar:SfToolbarItem>
            </toolbar:SfToolbar.Items>
        </toolbar:SfToolbar>
    </Grid>
</ContentPage>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Toolbar;

var toolbar = new SfToolbar
{
    EnableLiquidGlassEffect = true,
    HeightRequest = 56,
    WidthRequest = 320
};

toolbar.Items = new ObservableCollection<BaseToolbarItem>
{
    new SfToolbarItem { Name = "Bold", ToolTipText = "Bold", Icon = new FontImageSource { Glyph = "\uE770", FontFamily = "MauiMaterialAssets" } },
    new SfToolbarItem { Name = "Italic", ToolTipText = "Italic", Icon = new FontImageSource { Glyph = "\uE771", FontFamily = "MauiMaterialAssets" } },
    new SfToolbarItem { Name = "Underline", ToolTipText = "Underline", Icon = new FontImageSource { Glyph = "\uE762", FontFamily = "MauiMaterialAssets" } }
};

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.

The following screenshot illustrates [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) with the liquid glass effect enabled over a colorful background.
