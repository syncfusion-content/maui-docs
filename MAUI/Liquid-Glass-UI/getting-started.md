---
layout: post
title: Getting Started with Liquid Glass UI in Syncfusion® .NET MAUI Controls
description: Getting started with the Liquid Glass Effect UI in Syncfusion® .NET MAUI controls and learn how to enable and customize it.
platform: MAUI
control: General
documentation: UG
---

# Getting Started with Liquid Glass for Modern UI

This section explains how to enable and customize the Liquid Glass Effect in Syncfusion® .NET MAUI controls. For detailed information on specific Syncfusion® controls and their usage, refer to the respective Getting Started documentation. Ensure the control is properly configured and functioning before applying the Liquid Glass Effect.

N> This feature is supported only on `.NET 10`

## Supported Platforms

* macOS 26 or higher
* iOS 26 or higher

## Liquid Glass Effect

The Liquid Glass Effect provides a modern, translucent design with background blur and depth effects, enhancing the visual appearance of your UI without requiring major code changes. To apply the Liquid Glass Effect to any Syncfusion® .NET MAUI control or custom view (such as a DataTemplate), wrap the control inside the `SfGlassEffectView` class.

This view acts as a visual container that adds blur, translucency, and light refraction to its content, creating a realistic glass-like appearance. In this section, we will demonstrate how to use `SfGlassEffectView` with Syncfusion® controls to achieve a visually appealing glass effect.

The `SfGlassEffectView` class is available in [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core) and provides the following properties:

### Effect types

The `EffectType` property specifies the type of glass effect to apply:

* **Regular:** Creates a blurred, frosted glass appearance.
* **Clear:** Creates a transparent, glass-like appearance.

{% tabs %}
{% highlight XAML hl_lines="18" %}

...
xmlns:core="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"
xmlns:button="clr-namespace:Syncfusion.Maui.Buttons;assembly=Syncfusion.Maui.Buttons"

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
    <core:SfGlassEffectView CornerRadius="20"
                            EffectType="Clear"
                            Padding="16"
                            HeightRequest="140"
                            WidthRequest="420">
        <Grid ColumnDefinitions="64,*,Auto"
              ColumnSpacing="12">
            <!-- Avatar -->
            <core:SfGlassEffectView WidthRequest="64"
                                    HeightRequest="64"
                                    EffectType="Clear"
                                    CornerRadius="32">
                <core:SfAvatarView WidthRequest="64"
                                   HeightRequest="64"
                                   FontSize="24"
                                   CornerRadius="32"
                                   FontAttributes="Bold"
                                   AvatarName="SF"
                                   Background="Transparent"
                                   ContentType="Initials"
                                   InitialsType="DoubleCharacter" />
            </core:SfGlassEffectView>
            <!-- Title / Subtitle -->
            <VerticalStackLayout Grid.Column="1"
                                 Spacing="2"
                                 VerticalOptions="Center">
                <Label Text="Syncfusion®"
                       TextColor="White"
                       FontAttributes="Bold"
                       FontSize="20" />
                <Label Text="Deliver innovation with ease"
                       TextColor="#DDFFFFFF"
                       FontSize="15" />
            </VerticalStackLayout>
            <!-- Action Button -->
            <core:SfGlassEffectView CornerRadius="20"
                                    EffectType="Clear"
                                    WidthRequest="100"
                                    Grid.Column="2"
                                    HeightRequest="40">
                <button:SfButton Text="Follow"
                                 Background="Transparent"
                                 TextColor="White" />
            </core:SfGlassEffectView>
        </Grid>
    </core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% highlight C# hl_lines="22" %}

using Syncfusion.Maui.Core;
using Syncfusion.Maui.Buttons;

// Gradient background
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

// Avatar inside glass effect
var avatarGlass = new SfGlassEffectView
{
    WidthRequest = 64,
    HeightRequest = 64,
    EffectType = GlassEffectType.Clear,
    CornerRadius = 32,
    Content = new SfAvatarView
    {
        WidthRequest = 64,
        HeightRequest = 64,
        FontSize = 24,
        CornerRadius = 32,
        FontAttributes = FontAttributes.Bold,
        AvatarName = "SF",
        Background = Colors.Transparent,
        ContentType = AvatarContentType.Initials,
        InitialsType = InitialsType.DoubleCharacter
    }
};

// Title and subtitle
var textStack = new VerticalStackLayout
{
    Spacing = 2,
    VerticalOptions = LayoutOptions.Center,
    Children =
    {
        new Label
        {
            Text = "Syncfusion®",
            TextColor = Colors.White,
            FontAttributes = FontAttributes.Bold,
            FontSize = 20
        },
        new Label
        {
            Text = "Deliver innovation with ease",
            TextColor = Color.FromArgb("#DDFFFFFF"),
            FontSize = 15
        }
    }
};

// Action button inside glass effect
var buttonGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    WidthRequest = 100,
    HeightRequest = 40,
    Content = new SfButton
    {
        Text = "Follow",
        Background = Colors.Transparent,
        TextColor = Colors.White
    }
};

// Inner grid layout
var innerGrid = new Grid
{
    ColumnDefinitions = new ColumnDefinitionCollection
    {
        new ColumnDefinition { Width = 64 },
        new ColumnDefinition { Width = GridLength.Star },
        new ColumnDefinition { Width = GridLength.Auto }
    },
    ColumnSpacing = 12,
    Children =
    {
        avatarGlass,
        { textStack, 1, 0 },
        { buttonGlass, 2, 0 }
    }
};

// Outer glass effect container
var outerGlass = new SfGlassEffectView
{
    CornerRadius = 20,
    EffectType = GlassEffectType.Clear,
    Padding = 16,
    HeightRequest = 140,
    WidthRequest = 420,
    Content = innerGrid
};

// Root grid with gradient background
var rootGrid = new Grid
{
    Background = gradientBrush,
    Children = { outerGlass }
};

Content = rootGrid;

{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-clear-effect-type-in-.net-maui](images/getting-started/liquid-glass-ui-with-clear-effect-type-in-.net-maui.png)
   
### Corner radius

Defines the corner radius for the view, enabling customization of its shape such as rounded rectangles or capsules.

{% tabs %}
{% highlight XAML hl_lines="14" %}

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
    <core:SfGlassEffectView EffectType="Clear"
                            CornerRadius="30"
                            EnableShadowEffect="true"
                            Padding="16"
                            HeightRequest="140"
                            WidthRequest="420">
        <Grid ColumnDefinitions="64,*,Auto"
              ColumnSpacing="12">
            <!-- Avatar -->
            <core:SfGlassEffectView WidthRequest="64"
                                    HeightRequest="64"
                                    EffectType="Clear"
                                    CornerRadius="32">
                <core:SfAvatarView WidthRequest="64"
                                   HeightRequest="64"
                                   FontSize="24"
                                   CornerRadius="32"
                                   FontAttributes="Bold"
                                   AvatarName="SF"
                                   Background="Transparent"
                                   ContentType="Initials"
                                   InitialsType="DoubleCharacter" />
            </core:SfGlassEffectView>
            <!-- Title / Subtitle -->
            <VerticalStackLayout Grid.Column="1"
                                 Spacing="2"
                                 VerticalOptions="Center">
                <Label Text="Syncfusion®"
                       TextColor="White"
                       FontAttributes="Bold"
                       FontSize="20" />
                <Label Text="Deliver innovation with ease"
                       TextColor="#DDFFFFFF"
                       FontSize="15" />
            </VerticalStackLayout>
            <!-- Action Button -->
            <core:SfGlassEffectView CornerRadius="20"
                                    EffectType="Clear"
                                    WidthRequest="100"
                                    Grid.Column="2"
                                    HeightRequest="40">
                <button:SfButton Text="Follow"
                                 Background="Transparent"
                                 TextColor="White" />
            </core:SfGlassEffectView>
        </Grid>
    </core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-corner-radius-in-.net-maui](images/getting-started/liquid-glass-ui-with-corner-radius-in-.net-maui.png)

### Enable shadow effect

Adds a soft shadow to the content within the glass view, creating depth and a more realistic appearance.

{% tabs %}
{% highlight XAML hl_lines="15" %}

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
    <core:SfGlassEffectView EffectType="Clear"
                            CornerRadius="20"
                            EnableShadowEffect="true"
                            Padding="16"
                            HeightRequest="140"
                            WidthRequest="420">
        <Grid ColumnDefinitions="64,*,Auto"
              ColumnSpacing="12">
            <!-- Avatar -->
            <core:SfGlassEffectView WidthRequest="64"
                                    HeightRequest="64"
                                    EffectType="Clear"
                                    CornerRadius="32">
                <core:SfAvatarView WidthRequest="64"
                                   HeightRequest="64"
                                   FontSize="24"
                                   CornerRadius="32"
                                   FontAttributes="Bold"
                                   AvatarName="SF"
                                   Background="Transparent"
                                   ContentType="Initials"
                                   InitialsType="DoubleCharacter" />
            </core:SfGlassEffectView>
            <!-- Title / Subtitle -->
            <VerticalStackLayout Grid.Column="1"
                                 Spacing="2"
                                 VerticalOptions="Center">
                <Label Text="Syncfusion®"
                       TextColor="White"
                       FontAttributes="Bold"
                       FontSize="20" />
                <Label Text="Deliver innovation with ease"
                       TextColor="#DDFFFFFF"
                       FontSize="15" />
            </VerticalStackLayout>
            <!-- Action Button -->
            <core:SfGlassEffectView CornerRadius="20"
                                    EffectType="Clear"
                                    WidthRequest="100"
                                    Grid.Column="2"
                                    HeightRequest="40">
                <button:SfButton Text="Follow"
                                 Background="Transparent"
                                 TextColor="White" />
            </core:SfGlassEffectView>
        </Grid>
    </core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-shadow-in-.net-maui](images/getting-started/liquid-glass-ui-with-shadow-in-.net-maui.png)

### Set background color

Applies a background tint color to the glass view, to enhance modern UI styling and improve readability.

{% tabs %}
{% highlight XAML hl_lines="15" %}

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
    <core:SfGlassEffectView EffectType="Clear"
                            CornerRadius="20"
                            Background="Orange"
                            Padding="16"
                            HeightRequest="140"
                            WidthRequest="420">
        <Grid ColumnDefinitions="64,*,Auto"
              ColumnSpacing="12">
            <!-- Avatar -->
            <core:SfGlassEffectView WidthRequest="64"
                                    HeightRequest="64"
                                    EffectType="Clear"
                                    CornerRadius="32">
                <core:SfAvatarView WidthRequest="64"
                                   HeightRequest="64"
                                   FontSize="24"
                                   CornerRadius="32"
                                   FontAttributes="Bold"
                                   AvatarName="SF"
                                   Background="Transparent"
                                   ContentType="Initials"
                                   InitialsType="DoubleCharacter" />
            </core:SfGlassEffectView>
            <!-- Title / Subtitle -->
            <VerticalStackLayout Grid.Column="1"
                                 Spacing="2"
                                 VerticalOptions="Center">
                <Label Text="Syncfusion®"
                       TextColor="White"
                       FontAttributes="Bold"
                       FontSize="20" />
                <Label Text="Deliver innovation with ease"
                       TextColor="#DDFFFFFF"
                       FontSize="15" />
            </VerticalStackLayout>
            <!-- Action Button -->
            <core:SfGlassEffectView CornerRadius="20"
                                    EffectType="Clear"
                                    WidthRequest="100"
                                    Grid.Column="2"
                                    HeightRequest="40">
                <button:SfButton Text="Follow"
                                 Background="Transparent"
                                 TextColor="White" />
            </core:SfGlassEffectView>
        </Grid>
    </core:SfGlassEffectView>
</Grid>
	
{% endhighlight %}
{% endtabs %}

![liquid-glass-ui-with-background-in-.net-maui](images/getting-started/liquid-glass-ui-with-background-in-.net-maui.png)

## Interactive Glass Effect

Enable glass effect that respond to user interactions with clear transparency and dynamic lighting for an engaging UI. To enable this feature, set the `EnableLiquidGlassEffect` property to `true` on the Syncfusion® `SfSwitch` control. This activates interaction-based visual effects.

{% tabs %}
{% highlight XAML %}

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
    <core:SfGlassEffectView EffectType="Clear"
                            CornerRadius="20"
                            HeightRequest="140"
                            WidthRequest="380">
        <button:SfButton Text="Regular Glass"
                         EnableLiquidGlassEffect="True"
                         FontSize="16"
                         WidthRequest="150"
                         HeightRequest="40"
                         Background="Transparent"
                         TextColor="Black" />
    </core:SfGlassEffectView>
</Grid>

{% endhighlight %}
{% endtabs %}

## Controls list

For control specific usage of the Liquid Glass Effect on individual Syncfusion® controls, including availability, and configuration details, please refer to the respective controls' documentation.

N> View sample in GitHub.