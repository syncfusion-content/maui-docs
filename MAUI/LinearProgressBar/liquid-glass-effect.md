---
layout: post
title: Liquid Glass Support for .NET MAUI Linear ProgressBar | Syncfusion®
description: Learn how to enable liquid glass support for the Syncfusion® .NET MAUI Linear ProgressBar (SfLinearProgressBar) control using SfGlassEffectsView.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Liquid Glass Support

The [SfLinearProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html) supports a liquid glass appearance by hosting the control inside the Syncfusion [SfGlassEffectsView](). You can customize the effect using properties such as [EffectType](), [EnableShadowEffect](), and round the corners using [CornerRadius](). This approach improves visual depth and readability when the linear progressbar is placed over images or colorful layouts.

N> This feature is supported only on `.NET 10`

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Prerequisites

* Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) package (for SfGlassEffectsView).
* Add the [Syncfusion.Maui.ProgressBar](https://www.nuget.org/packages/Syncfusion.Maui.ProgressBar/) package (for SfLinearProgressBar).

## Apply Liquid Glass Effect to SfLinearProgressBar

{% tabs %}
{% highlight xaml %}

...
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
xmlns:progressBar="clr-namespace:Syncfusion.Maui.ProgressBar;assembly=Syncfusion.Maui.ProgressBar"

<StackLayout>
    <core:SfGlassEffectView HeightRequest="18"
                            CornerRadius="9"
                            EffectType="Clear">
        <progressBar:SfLinearProgressBar x:Name="linearProgressBar"
                                        TrackHeight="8"
                                        ProgressHeight="8"
                                        ProgressCornerRadius="8"
                                        TrackCornerRadius="8"
                                        Progress="75"
                                        Margin="5"
                                        BackgroundColor="Transparent"/>
    </core:SfGlassEffectView>
</StackLayout>

{% endhighlight %}
{% highlight c# %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.ProgressBar;

var stackLayout = new StackLayout();
var glassView = new SfGlassEffectsView
{
    HeightRequest = 18,
    CornerRadius = 9,
    EffectType = GlassEffectType.Clear
};

var linearProgressBar = new SfLinearProgressBar
{
    TrackHeight = 8,
    ProgressHeight = 8,
    ProgressCornerRadius = 8,
    TrackCornerRadius = 8,
    Progress = 75,
    Margin = new Thickness(5),
    BackgroundColor = Colors.Transparent
};

glassView.Content = linearProgressBar;
stackLayout.Children.Add(glass);
this.Content = stackLayout;

{% endhighlight %}
{% endtabs %}

N>
* Liquid Glass effects are most visible over images or colorful backgrounds.
* Use EffectType="Regular" for a blurrier look and "Clear" for a glassy look.

## Key Properties

* [EffectType](): Choose between Regular (blurry) and Clear (glassy) effects.
* [EnableShadowEffect](): Enables a soft shadow around the acrylic container.
* [CornerRadius](): Rounds the corners of the acrylic container.
* Padding/Height/Width: Adjust layout around the embedded linear progressbar.

## Best Practices and Tips

* Hosting the linear progressbar inside [SfGlassEffectsView]() gives the linear progressbar body an acrylic look.
* For the most noticeable effect, place the control over images or vibrant backgrounds.