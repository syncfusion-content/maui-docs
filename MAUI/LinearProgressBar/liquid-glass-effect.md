---
layout: post
title: Liquid Glass Support for .NET MAUI Linear Progress Bar | Syncfusion®
description: Learn how to enable and customize the Liquid Glass Effect in the Syncfusion® .NET MAUI Linear Progress Bar (SfLinearProgressBar) control.
platform: MAUI
control: SfLinearProgressBar
documentation: ug
---

# Liquid Glass Effect for Linear Progress Bar

The Liquid Glass Effect introduces a modern, translucent design with adaptive color tinting and light refraction, creating a sleek, glass like user experience that remains clear and accessible. This section explains how to enable and customize the effect in the Syncfusion® .NET MAUI Linear Progress Bar (SfLinearProgressBar) control.

## Apply liquid glass effect

Follow these steps to enable and configure the Liquid Glass Effect in the Linear Progress Bar control:

### Step 1: Wrap the control inside glass effect view

To apply the Liquid Glass Effect to the Syncfusion® .NET MAUI [LinearProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html) control, wrap the control inside the `SfGlassEffectView` class.

For more details, refer to the `Liquid Glass Getting Started documentation`.

### Step 2: Customize the background

To achieve a glass like background in the Linear Progress Bar, set the `Background` property to `Transparent`. The background will then be treated as a tinted color, ensuring a consistent glass effect across the controls.

The following code snippet demonstrates how to apply the Liquid Glass Effect to the [SfLinearProgressBar](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ProgressBar.SfLinearProgressBar.html) control:

{% tabs %}
{% highlight xaml %}

<Grid>
    <Grid.Background>
        <LinearGradientBrush StartPoint="0,0"
                             EndPoint="0,1">
            <GradientStop Color="#0F4C75"
                          Offset="0.0" />
            <GradientStop Color="#3282B8"
                          Offset="0.5" />
            <GradientStop Color="#1B262C"
                          Offset="1.0" />
        </LinearGradientBrush>
    </Grid.Background>
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
                                             BackgroundColor="Transparent" />
        </core:SfGlassEffectView>
    </StackLayout>
</Grid>

{% endhighlight %}
{% highlight c# %}

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
    EffectType = LiquidGlassEffectType.Clear,
    EnableShadowEffect = true
};

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
stackLayout.Children.Add(glassView);
grid.Children.Add(stackLayout);
this.Content = grid;

{% endhighlight %}
{% endtabs %}

N>
* Supported on `macOS 26 or higher` and `iOS 16 or higher`.
* This feature is available only in `.NET 10.`