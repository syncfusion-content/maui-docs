---
layout: post
title: Liquid Glass Support for .NET MAUI Toolbar | Syncfusion®
description: Learn how to enable liquid glass  support for the Syncfusion® .NET MAUI Toolbar using the EnableLiquidGlassEffect property.
platform: maui
control: Toolbar (SfToolbar)
documentation: ug
---

# Liquid Glass Effect in .NET MAUI Toolbar (SfToolbar)

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Toolbar (SfToolbar) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Toolbar control:

### Step 1: Enable the liquid glass effect on Toolbar

Set the [EnableLiquidGlassEffect](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html#Syncfusion_Maui_Toolbar_SfToolbar_EnableLiquidGlassEffect) property to `true` in the [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 2: Customize the background

To achieve a glass like background in the Toolbar, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfToolbar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Toolbar.SfToolbar.html) control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" %}

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
{% highlight c# tabtitle="MainPage.xaml.cs" %}

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
* Supported on `macOS 26 or higher` and `iOS 26 or higher`.
* This feature is available only in `.NET 10.`
