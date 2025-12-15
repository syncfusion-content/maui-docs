---
layout: post
title: Liquid Glass Support for .NET MAUI Image Editor | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Liquid glass effect

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Image Editor (SfImageEditor) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Image Editor control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to Syncfusion® .NET MAUI `ImageEditor` control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the Liquid Glass Getting Started documentation.

### Step 2: Enable the liquid glass effect on Image Editor

Set the `EnableLiquidGlassEffect` property to `true` in the `SfImageEditor` control to apply the Liquid Glass Effect. When enabled, the effect is also applied to its dependent controls and provides responsive interaction for a smooth and engaging user experience.

### Step 3: Customize the background

To achieve a glass like background in the Image Editor and its Toolbar, set the `Background` property to `Transparent`.

The background will then be treated as a tinted color, ensuring a consistent glass effect across the control.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the SfImageEditor control:

{% tabs %}
{% highlight xaml tabtitle="MainPage.xaml" hl_lines="14 15 16 21" %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0" 
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75" 
                          Offset="0.0"/>
            <GradientStop Color="#3282B8" 
                          Offset="0.5"/>
            <GradientStop Color="#1B262C" 
                          Offset="1.0"/>
        </LinearGradientBrush>
    </Grid.Background>

    <core:SfGlassEffectView EffectType="Regular"
                            EnableShadowEffect="True"
                            CornerRadius="20">
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Background="Transparent"
                                   SelectionStroke="#AE97FF"
                                   Source="editorimage.png"
                                   EnableLiquidGlassEffect="True">
            <imageEditor:SfImageEditor.ToolbarSettings>
                <imageEditor:ImageEditorToolbarSettings Background="Transparent"
                                                        Stroke="Transparent"/>
            </imageEditor:SfImageEditor.ToolbarSettings>
        </imageEditor:SfImageEditor>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# tabtitle="MainPage.xaml.cs" hl_lines="4 6 7 8 11" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.ImageEditor;

var gradientBrush = new LinearGradientBrush
{
    StartPoint = new Point(0, 0),
    EndPoint = new Point(0, 1),
    GradientStops = new GradientStopCollection
    {
        new GradientStop { Color = Color.FromArgb("#0F4C75"), Offset = 0.0f },
        new GradientStop { Color = Color.FromArgb("#3282B8"), Offset = 0.5f },
        new GradientStop { Color = Color.FromArgb("#1B262C"), Offset = 1.0f }
    }
};

var grid = new Grid
{
    Background = gradientBrush
};

var glassView = new SfGlassEffectsView
{
    CornerRadius = 20,
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

this.imageEditor.EnableLiquidGlassEffect = true;
glassView.Content = this.imageEditor;
grid.Children.Add(glassView);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

Note>
* Supported on macOS 26 or higher and iOS 16 or higher.
* This feature is available only in .NET 10.