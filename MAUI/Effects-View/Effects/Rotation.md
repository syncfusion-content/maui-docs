---
layout: post
title: The .NET MAUI Rotation Effect | Effects View Control | Syncfusion®
description: Learn about the rotation effect in the Syncfusion® .NET MAUI Effects View (SfEffectsView) control and more.
platform: MAUI
control: SfEffectsView
documentation: UG
---

# Rotation Effect

The [SfEffects.Rotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffects.html#Syncfusion_Maui_Core_SfEffects_Rotation) effect rotates the [SfEffectsView](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html) around its center by the specified [Angle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Angle). Positive angles rotate clockwise; negative angles rotate counter-clockwise.

> **Note**
>
> `Rotation` cannot be combined with other effects on the same trigger property. Place other effects on a different trigger property (for example, `LongPressEffects`) so both effects can play. See [Combining Effects](Combinations.md) for the full set of rules.

## Rotation Properties

The `Rotation` effect is configured by the following properties on `SfEffectsView`:

| Property | Description | Default |
| --- | --- | --- |
| [Angle](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_Angle) | Rotation angle in degrees. Positive values rotate clockwise; negative values rotate counter-clockwise. | `0` |
| [RotationAnimationDuration](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Core.SfEffectsView.html#Syncfusion_Maui_Core_SfEffectsView_RotationAnimationDuration) | Duration of the rotation animation, in milliseconds. | `200` |

For more details, see [Customization](Customization.md).

## Prerequisites

Before using the examples in this article, ensure the following are in place:

- Install the `Syncfusion.Maui.Core` NuGet package in your .NET MAUI project.
- Register the Syncfusion Core handler in `MauiProgram.cs` by calling `Syncfusion.Maui.Core.Hosting.SyncfusionCoreHostBuilderExtensions.ConfigureSyncfusionCore`.
- Add `using Syncfusion.Maui.Core;` and `using Microsoft.Maui.Controls;` to your C# files.
- Add the namespace `xmlns:syncEffectsView="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core"` to your XAML page.
- See [Getting Started with .NET MAUI Effects View](https://help.syncfusion.com/maui/effects-view/getting-started) for full setup steps.

## Adding a Basic Rotation

The example below rotates the `SfEffectsView` by 180 degrees when the user presses it.

### XAML

```xaml
<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView Angle="180"
                                   TouchDownEffects="Rotation"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>
```

### C#

```csharp
var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    Angle = 180,
    TouchDownEffects = SfEffects.Rotation,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;
```

![Rotation effect rotating the view 180 degrees](Effects_images/net_maui_rotation_animation.gif)

## Customizing the Duration

The example below slows the rotation to 800 milliseconds.

### XAML

```xaml
<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView TouchDownEffects="Rotation"
                                   Angle="360"
                                   RotationAnimationDuration="800"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>
```

### C#

```csharp
var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Rotation,
    Angle = 360,
    RotationAnimationDuration = 800,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;
```

## Combining with Other Effects

`Rotation` cannot share a trigger property with other effects. Place another effect on a different trigger property so the two effects can play independently.

### XAML

```xaml
<Border WidthRequest="36"
        HeightRequest="36"
        HorizontalOptions="Center"
        VerticalOptions="Center"
        StrokeThickness="0">
    <Border.StrokeShape>
        <RoundRectangle CornerRadius="10" />
    </Border.StrokeShape>
    <syncEffectsView:SfEffectsView TouchDownEffects="Rotation"
                                   LongPressEffects="Ripple"
                                   Angle="180"
                                   HorizontalOptions="Center">
        <HorizontalStackLayout Spacing="-4">
            <Label Text="↑"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="Start" />
            <Label Text="↓"
                   FontSize="24"
                   FontAttributes="Bold"
                   VerticalOptions="End"
                   Margin="0,8,0,0" />
        </HorizontalStackLayout>
    </syncEffectsView:SfEffectsView>
</Border>
```

### C#

```csharp
var border = new Border
{
    WidthRequest = 36,
    HeightRequest = 36,
    HorizontalOptions = LayoutOptions.Center,
    VerticalOptions = LayoutOptions.Center,
    StrokeThickness = 0,
    StrokeShape = new RoundRectangle
    {
        CornerRadius = new CornerRadius(10)
    }
};

var effectsView = new SfEffectsView
{
    TouchDownEffects = SfEffects.Rotation,
    LongPressEffects = SfEffects.Ripple,
    Angle = 180,
    HorizontalOptions = LayoutOptions.Center
};

var stackLayout = new HorizontalStackLayout
{
    Spacing = -4,
    Children =
    {
        new Label
        {
            Text = "↑",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.Start
        },

        new Label
        {
            Text = "↓",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            VerticalOptions = LayoutOptions.End,
            Margin = new Thickness(0, 8, 0, 0)
        }
    }
};

effectsView.Content = stackLayout;
border.Content = effectsView;
this.Content = border;
```

## Troubleshooting

- If no rotation occurs, confirm `TouchDownEffects` is set to `SfEffects.Rotation` (or the effect is started through `ApplyEffects`) and that `Angle` is non-zero.
- If the rotation is too fast or too slow, adjust `RotationAnimationDuration` (in milliseconds).
- If you set `TouchDownEffects="Rotation,Ripple"` (or another combination), only the first effect is applied; place other effects on a different trigger property.
- If the rotation is hard to see, confirm the view is not constrained to a fixed size; rotation around the center is more visible on square views.