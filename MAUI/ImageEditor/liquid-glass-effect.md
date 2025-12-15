---
layout: post
title: Liquid Glass Support for .NET MAUI Image Editor Control | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI ImageEditor(SfImageEditor) control using SfGlassEffectsView.
platform: MAUI
control: SfImageEditor
documentation: ug
---

# Liquid Glass Support

The `SfImageEditor` supports a liquid glass  appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the Image Editor is placed over images or colorful layouts.

Additionally, you can apply the glass effect to the ImageEditor control by enabling the [EnableLiquidGlassEffect]() property.

## Platform and Version Support

1. This feature is supported on .NET 10 or greater.
2. This feature is supported on macOS 26 and iOS 26 or later.
3. On platforms or versions below these requirements, the control renders without the acrylic blur effect and falls back to a standard background.

## Prerequisites

- Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView).
- Add the [Syncfusion.Maui.ImageEditor](https://www.nuget.org/packages/Syncfusion.Maui.ImageEditor/) package (for SfImageEditor).

## Apply Liquid Glass Effect to SfImageEditor

Wrap the `SfImageEditor` inside an [SfGlassEffectsView]() to give the Image Editor surface a glass (blurred or clear) appearance.

{% tabs %}
{% highlight xaml %}

<Grid>
    <Image Source="liquidglassimage.jpg"
           Aspect="AspectFill" />

    <core:SfGlassEffectView>
        <imageEditor:SfImageEditor x:Name="imageEditor"
                                   Background="Transparent"
                                   SelectionStroke="#AE97FF"
                                   Source="{converters:SfImageResource Source={OnPlatform Default=imageeditordesktop.png, Android=imageeditormobile.png, iOS=imageeditormobile.png}}"
                                   EnableLiquidGlassEffect="True">
            <imageEditor:SfImageEditor.ToolbarSettings>
                <imageEditor:ImageEditorToolbarSettings Background="Transparent"
                                                        Stroke="Transparent"/>
            </imageEditor:SfImageEditor.ToolbarSettings>
        </imageEditor:SfImageEditor>
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.ImageEditor;

var glassView = new SfGlassEffectsView
{
    CornerRadius = 20,
    Padding = new Thickness(12),
    EffectType = LiquidGlassEffectType.Regular,
    EnableShadowEffect = true
};

this.imageEditor.EnableLiquidGlassEffect = true;
glassView.Content = this.imageEditor;

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Key Properties

- [EffectType](): Choose between Regular (blurry) and Clear (glassy) effects.
- [EnableShadowEffect](): Enables a soft shadow around the acrylic container.
- [CornerRadius](): Rounds the corners of the acrylic container.
- Padding/Height/Width: Adjust layout around the ImageEditor control.

## Best Practices and Tips

- Hosting the Image Editor control inside [SfGlassEffectsView]() gives the control body an acrylic look.
- For the most noticeable effect, place the control over images or vibrant backgrounds.

The following screenshot illustrates `SfImageEditor` hosted within an acrylic container, and the dialog mode using the glass effect.